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

#ifndef RPR_IMAGING_IPC_SERVER_H
#define RPR_IMAGING_IPC_SERVER_H

#include "zmqContext.h"

#include "pxr/usd/sdf/path.h"
#include "pxr/usd/usd/stage.h"

#include <thread>
#include <mutex>

PXR_NAMESPACE_OPEN_SCOPE

/// \class RprIpcServer
///
/// RprIpcServer implements remote UsdStage data synchronization protocol
/// (see overview.dox for more info).
/// All methods are thread-safe unless otherwise indicated
class RprIpcServer {
public:
    // ---------------------------------------------------------------------
    /// \name Construction
    /// @{
    // ---------------------------------------------------------------------

    /// Each callback is called from the network thread
    class Listener {
    public:
		Listener()          = default;
		virtual ~Listener() = default;
        /// The callback to receive commands sent by @see RprIpcClient#SendCommand
        virtual bool ProcessCommand(std::string const& command,
			uint8_t* payload, size_t payloadSize) {
			return false;
		}
    };

    RPR_IPC_API
    RprIpcServer(Listener* Listener, const char* bind_server = "tcp://127.0.0.1:*");

    RPR_IPC_API
    ~RprIpcServer();

    /// @}

    // ---------------------------------------------------------------------
    /// \name Layers management
    /// @{
    // ---------------------------------------------------------------------

    class Layer;

    /// Create a layer with a particular \p layerPath. 
    /// Creating a few layers with the same layerPath is prohibited.
    /// There might be few root layers, in such case,
    /// they all combined through sublayering.
    RPR_IPC_API
    Layer* AddLayer(SdfPath const& layerPath, bool isRoot = true);

    /// Notify server about layer changes. This call leads to layer encoding
    /// process and sending of the encoded stage to the client
    ///
    RPR_IPC_API
    void OnLayerEdit(SdfPath const& layerPath, Layer* layer);

    /// Remove layer from the list of active layers.
    ///
    /// Note: removing inexisting layers results in TF_CODING_ERROR.
    RPR_IPC_API
    void RemoveLayer(SdfPath const& layerPath);

    /// Return a path that can be used as reference assetPath (see SdfReference)
    RPR_IPC_API
    static std::string GetLayerReferencePath(SdfPath const& layerPath);

private:
    class Sender;

public:
    class Layer {
    public:
		RPR_IPC_API
        Layer(bool isRoot, std::string const& layerIdentifier);

        /// Get UsdStage of the current layer. The returned stage can be edited
        /// directly. Any number of edits can be done to the stage. Calling
        /// RprIpcServer::OnLayerEdit is required to notify the client about changes.
		RPR_IPC_API
        UsdStagePtr GetStage() { return m_stage; };

		RPR_IPC_API
        UsdStageRefPtr GetStageRefPtr() { return m_stage; };

		RPR_IPC_API
        bool IsRoot() const { return m_isRoot; }

    private:
        void OnEdit();
        std::string const& GetEncodedStage();

    private:
        const bool m_isRoot;

        UsdStageRefPtr m_stage;
        uint64_t m_timestamp;

        std::string m_encodedStage;
        bool m_isEncodedStageDirty;

        std::shared_ptr<Sender> m_cachedSender;

        friend RprIpcServer;
    };

    /// @}

private:
    void RunNetworkWorker();

    void ProcessControlSocket();
    void ProcessAppSocket();

    void SendAllLayers();

private:
    Listener* m_listener;

    /// Server control socket. This socket is responsible for
    /// server connection establishment and command sending process.
    zmq::socket_t m_controlSocket;

    /// Server data push socket. Server sends any kind of data to the client
    /// through this socket, currently it can be either layer data or layer removal data.
    zmq::socket_t m_dataSocket;

    /// Application-NetworkThread communication socket. So as client-server
    /// communication happens in the background thread (m_networkThread), we
    /// are using this socket as a sink that receives data from all senders (@see Sender).
    zmq::socket_t m_appSocket;

    /// Map with all currently alive layers.
    /// We keep track of all alive layers to be able to send them on client connection.
    std::map<SdfPath, Layer> m_layers;

    /// Ensure thread-safety on layer creation/removal
    std::mutex m_layersMutex;

    /// Client-sever communication happens in the background thread. In such a way
    /// RprIpcServer is not bound to the user threading setup.
    std::thread m_networkThread;

private:
    /// \class Sender
    ///
    /// Sender designed to allow easy data transmission from many worker threads to the client.
    /// Sender should be used on the same thread it was created on. It can be created only with \c GetSender.
    class Sender {
    public:
        void SendLayer(SdfPath const& layerPath, bool isRoot, std::string layer);
        void RemoveLayer(SdfPath const& layerPath);

    private:
        friend RprIpcServer;
        Sender(std::thread::id owningThread, zmq::socket_t&& socket);
        Sender(std::thread::id owningThread, zmq::socket_t* socket);

    private:
        std::thread::id m_owningThreadId;

        zmq::socket_t m_retainedSocket;
        zmq::socket_t* m_pushSocket;
    };

    /// The returned sender can be cached to avoid socket creation and connection.
    /// But the sender should be used on the same thread it was created on.
    /// If this function receives a cached sender it will validate thread conformity
    /// and in case of non-compliance, it will create a new sender.
    void GetSender(std::shared_ptr<Sender>* sender);

private:
    std::unordered_map<std::thread::id, std::weak_ptr<Sender>> m_senders;

private:

    // ---------------------------------------------------------------------
    /// \name Layer creation utility functions
    /// @{
    // ---------------------------------------------------------------------

    /// Each layer should have a filesystem-bound identifier to be referencable
    std::string GetLayerIdentifier(const char* layerPath);

    /// @}

private:
    const std::string m_layersIdentifierPrefix;
};

PXR_NAMESPACE_CLOSE_SCOPE

#endif // RPR_IMAGING_IPC_SERVER_H
