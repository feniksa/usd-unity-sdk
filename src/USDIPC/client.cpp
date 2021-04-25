/************************************************************************
Copyright 2020 Advanced Micro Devices, Inc
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
    http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
************************************************************************/

#include "client.h"
#include "common.h"
#include "tokens.h"
#include "debugCodes.h"

#include "pxr/usd/sdf/changeBlock.h"
#include "pxr/base/arch/fileSystem.h"
#include "pxr/base/tf/diagnostic.h"
#include "pxr/base/tf/stringUtils.h"
#include "pxr/base/tf/pathUtils.h"
#include "pxr/base/tf/fileUtils.h"

#ifdef WIN32
#include <Windows.h>
#include <fileapi.h>
#endif // WIN32
#include <sys/stat.h>

#include <fstream>

PXR_NAMESPACE_OPEN_SCOPE

const char* const kInAppCommunicationSockAddr = "inproc://RprIpcClient";

#define RPR_IPC_CLIENT_DEBUG_MSG(fmt, ...) TF_DEBUG(RPR_IPC_DEBUG).Msg("RprIpcClient: " fmt, ##__VA_ARGS__)

//------------------------------------------------------------------------------
// Construction
//------------------------------------------------------------------------------

RprIpcClientRefPtr RprIpcClient::Create(
    std::string const& serverAddress,
    std::function<void()> onStageUpdateCallback,
    std::string const& layersBindDir) {
    return TfCreateRefPtr(new RprIpcClient(serverAddress, onStageUpdateCallback, layersBindDir));
}

RprIpcClient::RprIpcClient(
    std::string const& serverAddress,
    std::function<void()> onStageUpdateCallback,
    std::string const& layersBindDir)
    : m_serverAddress(serverAddress)
    , m_dataSocket(GetZmqContext(), zmq::socket_type::pull)
    , m_onStageUpdate(std::move(onStageUpdateCallback))
    , m_layerController(this, layersBindDir) {
    m_dataSocket.bind("tcp://0.0.0.0:*");

    auto dataSocketPort = GetSocketPort(m_dataSocket);
    auto connectReply = TryRequest([&dataSocketPort](zmq::socket_t& socket) {
        socket.send(GetZmqMessage(RprIpcTokens->connect), zmq::send_flags::sndmore);
        socket.send(GetZmqMessage(dataSocketPort));

        RPR_IPC_CLIENT_DEBUG_MSG("sending connect command: port=%s\n", dataSocketPort.c_str());
    }, 1000);

    if (connectReply != "ok") {
        TF_RUNTIME_ERROR("Failed to connect to %s", m_serverAddress.c_str());
    }

    configure();

    m_appSocket = zmq::socket_t(GetZmqContext(), zmq::socket_type::pair);
    m_appSocket.bind(kInAppCommunicationSockAddr);

    m_networkThread = std::thread([this]() { RunNetworkWorker(); });
}

RprIpcClient::~RprIpcClient() {
    if (m_appSocket) {
        m_appSocket.send(GetZmqMessage(RprIpcTokens->shutdown));
        m_networkThread.join();
    }
}

void RprIpcClient::configure()
{
    zmq::message_t msg;
    m_controlSocket.recv(msg);

    static_assert(LayerFormat::USDA == 0, "Function expect USDA as 0. Please, check enum");
    static_assert(LayerFormat::USD == 1, "Function expect USD as 1. Please, check enum");

    if (msg.size() != 1)
        return;

    if (msg.data<char>()[0] == '1') {
        m_layerFormat = LayerFormat::USD;
    } else {
        m_layerFormat = LayerFormat::USDA;
    }
}

//------------------------------------------------------------------------------
// Server control
//------------------------------------------------------------------------------

bool RprIpcClient::SendCommand(
    std::string const& command,
    std::string const& payload) {
    if (!m_appSocket) return false;

    try {
        m_appSocket.send(GetZmqMessage(command), !payload.empty() ? zmq::send_flags::sndmore : zmq::send_flags::none);
        if (!payload.empty()) {
            m_appSocket.send(GetZmqMessage(payload));
        }

        return true;
    } catch (zmq::error_t& e) {
        TF_RUNTIME_ERROR("Failed to send command=%s with payloadSize=%zu: errorCode=%d", command.c_str(), payload.size(), e.num());
        return false;
    }
}

//------------------------------------------------------------------------------
// Stage
//------------------------------------------------------------------------------

UsdStagePtr RprIpcClient::GetStage() {
    return m_layerController.GetStage();
}

//------------------------------------------------------------------------------
// Private
//------------------------------------------------------------------------------

void RprIpcClient::RunNetworkWorker() {
    auto threadSocket = zmq::socket_t(GetZmqContext(), zmq::socket_type::pair);
    threadSocket.connect(kInAppCommunicationSockAddr);

    std::vector<zmq::pollitem_t> pollItems = {
        {m_dataSocket, 0, ZMQ_POLLIN, 0},
        {threadSocket, 0, ZMQ_POLLIN, 0},
    };

    while (true) {
        try {
            zmq::poll(pollItems);

            if (pollItems[0].revents & ZMQ_POLLIN) {
                ProcessDataSocket();
            }

            if (pollItems[1].revents & ZMQ_POLLIN) {
                zmq::message_t msg;
                threadSocket.recv(msg);

                auto command = std::to_string(msg);

                if (RprIpcTokens->shutdown == command) {
                    break;
                } else {
                    ProxyMessages(msg, threadSocket, m_controlSocket);

                    m_controlSocket.recv(msg);
                    auto response = std::to_string(msg);

                    RPR_IPC_CLIENT_DEBUG_MSG("server responded on the \"%s\" command: %s\n", command.c_str(), response.c_str());
                }
            }
        } catch (zmq::error_t& e) {
            TF_RUNTIME_ERROR("Network error: %d", e.num());
        }
    }
}

std::string RprIpcClient::TryRequest(
    MessageComposer messageComposer,
    long timeout, int numRetries) {
    if (!m_controlSocket) {
        SetupControlSocket();
    }

    for (int i = 0; i < numRetries; ++i) {
        messageComposer(m_controlSocket);

        zmq::pollitem_t pollItem = {m_controlSocket, 0, ZMQ_POLLIN, 0};
        if (zmq::poll(&pollItem, 1, timeout) == 1 &&
            (pollItem.revents & ZMQ_POLLIN) != 0) {

            zmq::message_t msg;
            m_controlSocket.recv(msg);
            return std::to_string(msg);
        } else {
            TF_WARN("No response from the server, retrying...");

            SetupControlSocket();
        }
    }

    return {};
}

void RprIpcClient::SetupControlSocket() {
    m_controlSocket = zmq::socket_t(GetZmqContext(), zmq::socket_type::req);
    m_controlSocket.set(zmq::sockopt::linger, 0);
    m_controlSocket.connect(m_serverAddress);
}

void RprIpcClient::ProcessDataSocket() {
    zmq::message_t msg;
    while (true) {
        if (!m_dataSocket.recv(msg, zmq::recv_flags::dontwait)) {
            break;
        }

        auto dataType = std::to_string(msg);

        try {
            if (TfStringStartsWith(dataType, RprIpcTokens->layer)) {
                RecvMore(m_dataSocket, msg);
                auto layerPath = std::to_string(msg);

                RPR_IPC_CLIENT_DEBUG_MSG("received \"%s\" dataType: %s\n", dataType.c_str(), layerPath.c_str());

                if (RprIpcTokens->layer == dataType) {
                    RecvMore(m_dataSocket, msg);
                    bool isRoot = true;
                    if (msg.size() == 1 && msg.data<char>()[0] == '0') {
                        isRoot = false;
                    }

                    RecvMore(m_dataSocket, msg);
                    m_layerController.AddLayer(layerPath, isRoot, msg.data<char>(), msg.size());

                    RPR_IPC_CLIENT_DEBUG_MSG("%.*s\n", int(msg.size()), msg.data<char>());
                } else /*if (RprIpcTokens->layerRemove == dataType)*/ {
                    m_layerController.RemoveLayer(layerPath);
                }
            } else {
                TF_RUNTIME_ERROR("Unknown dataType");
            }

            if (msg.more()) {
                TF_RUNTIME_ERROR("Unexpected number of messages in \"%s\" dataType", dataType.c_str());
            }
        } catch (std::exception& e) {
            TF_RUNTIME_ERROR("Failed to process \"%s\" dataType: %s", dataType.c_str(), e.what());
        }

        DropRemainingMessages(m_dataSocket, msg);
    }

    if (m_layerController.Update() && m_onStageUpdate) {
        m_onStageUpdate();
    }
}

//------------------------------------------------------------------------------
// LayerController
//------------------------------------------------------------------------------

static std::string GetLayersBindDir(std::string const& userLayersBindDir) {
    if (userLayersBindDir.empty() && TfDebug::IsEnabled(RPR_IPC_DEBUG)) {
        return ArchGetTmpDir() + std::string(ARCH_PATH_SEP "ipcClient");
    }

    return TfAbsPath(userLayersBindDir);
}

RprIpcClient::LayerController::LayerController(
    RprIpcClient* rprIpcClient,
    std::string const& layersBindDir)
    : m_rprIpcClient(rprIpcClient),
      m_layersBindDir(GetLayersBindDir(layersBindDir))
    , m_rootStage(CreateRootStage()) {
}

RprIpcClient::LayerController::~LayerController() {
}

void RprIpcClient::LayerController::AddLayer(
    std::string const& layerPath,
    bool isRoot,
    char* encodedLayer,
    size_t encodedLayerSize) {
    auto it = m_layers.find(layerPath);
    if (it != m_layers.end()) {
        RPR_IPC_CLIENT_DEBUG_MSG("layer edited (isRoot=%d): %s\n", int(isRoot), layerPath.c_str());
    } else {
        RPR_IPC_CLIENT_DEBUG_MSG("new layer (isRoot=%d): %s\n", int(isRoot), layerPath.c_str());

        auto layer = CreateLayer(layerPath);
        if (!layer) {
            TF_RUNTIME_ERROR("Failed to create SdfLayer for \"%s\" layer", layerPath.c_str());
            return;
        }

        if (isRoot) {
            m_dirtyBits |= DirtyRootLayers;
            m_rootLayers.emplace(layerPath, layer);
        }
        it = m_layers.emplace(layerPath, std::move(layer)).first;
    }
    m_dirtyBits |= DirtyLayers;

    // TODO: avoid this nasty copy
    std::string encodedLayerStr(encodedLayer, encodedLayerSize);
    if (!it->second->ImportFromString(encodedLayerStr)) {
        TF_RUNTIME_ERROR("Failed to set content of SdfLayer \"%s\" from ipc data", layerPath.c_str());
    }
}

void RprIpcClient::LayerController::RemoveLayer(
    std::string const& layerPath) {
    auto it = m_layers.find(layerPath);
    if (it == m_layers.end()) {
        TF_RUNTIME_ERROR("Failed to remove \"%s\" layer: does not exist", layerPath.c_str());
    } else {
        RPR_IPC_CLIENT_DEBUG_MSG("removing layer: %s\n", layerPath.c_str());

        if (!InMemoryMode()) {
            auto layerSavePath = GetLayerSavePath(layerPath.c_str());
            ArchUnlinkFile(layerSavePath.c_str());
        }
        m_layers.erase(it);

        auto rootLayerIt = m_rootLayers.find(layerPath);
        if (rootLayerIt != m_rootLayers.end()) {
            m_dirtyBits |= DirtyRootLayers;
            m_rootLayers.erase(rootLayerIt);
        }
    }
}

bool RprIpcClient::LayerController::Update() {
    if (m_dirtyBits == Clean) return false;

    if (m_dirtyBits & DirtyRootLayers) {
        SdfChangeBlock changeBlock;
        auto targetLayer = InMemoryMode() ? m_rootStage->GetSessionLayer() : m_rootStage->GetRootLayer();
        auto sublayerPaths = targetLayer->GetSubLayerPaths();

        sublayerPaths.clear();
        for (auto& entry : m_rootLayers) {
            auto& layer = entry.second;

            if (InMemoryMode()) {
                sublayerPaths.insert(sublayerPaths.begin(), layer->GetIdentifier());
            } else {
                auto sublayerPath = "." + layer->GetIdentifier().substr(m_layersBindDir.size());
                sublayerPaths.insert(sublayerPaths.begin(), sublayerPath);
            }
        }
    }

    m_dirtyBits = Clean;
    return true;
}

UsdStageRefPtr RprIpcClient::LayerController::CreateRootStage() {
    if (InMemoryMode()) {
        return UsdStage::CreateInMemory();
    } else {
        RPR_IPC_CLIENT_DEBUG_MSG("Layers save directory: %s\n", m_layersBindDir.c_str());
        return UsdStage::CreateNew(GetLayerSavePath("/root"));
    }
}

SdfLayerRefPtr RprIpcClient::LayerController::CreateLayer(std::string const& layerPath) {
    if (InMemoryMode()) {
        return SdfLayer::CreateAnonymous(layerPath + "." + to_string(m_rprIpcClient->layerFormat()));
    } else {
        auto layerSavePath = GetLayerSavePath(layerPath.c_str());
        if (!TfMakeDirs(TfGetPathName(layerSavePath), -1)) {
            TF_RUNTIME_ERROR("Cannot create directory for \"%s\" layer: %s", layerSavePath.c_str(), TfGetPathName(layerSavePath).c_str());
            return nullptr;
        }

        return SdfLayer::CreateNew(layerSavePath);
    }
}

std::string RprIpcClient::LayerController::GetLayerSavePath(const char* layerPath) {
    std::string fileFormat = to_string(m_rprIpcClient->layerFormat());
    return TfNormPath(TfStringPrintf("%s%s.%s", m_layersBindDir.c_str(), layerPath, fileFormat.c_str()));
}

PXR_NAMESPACE_CLOSE_SCOPE
