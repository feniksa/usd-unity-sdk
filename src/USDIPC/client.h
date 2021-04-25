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

#ifndef RPR_IMAGING_IPC_CLIENT_H
#define RPR_IMAGING_IPC_CLIENT_H

#include "zmqContext.h"

#include "pxr/usd/usd/stage.h"
#include "pxr/base/tf/declarePtrs.h"

#include "layerformat.h"

#include <functional>
#include <thread>
#include <memory>
#include <string>
#include <map>
#include <set>

PXR_NAMESPACE_OPEN_SCOPE

class RprIpcClient;
TF_DECLARE_WEAK_AND_REF_PTRS(RprIpcClient);

/// \class RprIpcClient
/// 
/// RprIpcClient implements remote UsdStage data synchronization protocol
/// (see overview.dox for more info).
/// All methods are NOT thread-safe unless otherwise indicated.
class RprIpcClient : public TfRefBase, public TfWeakBase {
public:
    // ---------------------------------------------------------------------
    /// \name Construction
    /// @{
    // ---------------------------------------------------------------------

    /// \p serverAddress should be a valid zmq address in the form `tcp://ip:port`
    /// \p onStageUpdateCallback is a callback called on the update of the stage,
    ///      note that this callback will be called from the networking thread.
    /// \p layersBindDir is a directory path where all USD layers are bound on,
    ///      when it's empty all layers created in-memory,
    ///      i.e. RprIpcClient does not interact with the filesystem at all.
    ///      It's necessary to emphasize that layer binding to the filesystem path
    ///      does not mean that they will be saved to the disk. Whether layers should
    ///      be saved to the disk is up to the user (use RprIpcClient::GetStage()->Save()).
    ///      But if you want to support such composition arc as referencing you have
    ///      to set \p layersBindDir to a non-empty path.
    RPR_IPC_API
    static RprIpcClientRefPtr Create(std::string const& serverAddress,
                                     std::function<void()> onStageUpdateCallback,
                                     std::string const& layersBindDir = std::string());

    RPR_IPC_API
    ~RprIpcClient();

    /// @}

    // ---------------------------------------------------------------------
    /// \name Server control
    /// @{
    // ---------------------------------------------------------------------

    /// This API allows the client to send custom comands to the server. These
    /// commands will be processed in @see RprIpcServer#Listener#ProcessCommand.
    RPR_IPC_API
    bool SendCommand(std::string const& command, std::string const& payload);

    /// @}

    // ---------------------------------------------------------------------
    /// \name Stage
    /// @{
    // ---------------------------------------------------------------------

    RPR_IPC_API
    UsdStagePtr GetStage();

    /// @}

    LayerFormat layerFormat() const { return m_layerFormat; }

private:
    RprIpcClient(std::string const& serverAddress,
                 std::function<void()> onStageUpdateCallback,
                 std::string const& layersBindDir);

    void RunNetworkWorker();

    using MessageComposer = std::function<void(zmq::socket_t& socket)>;
    std::string TryRequest(MessageComposer messageComposer,
                           long timeoutMs = -1, int numRetries = 3);

    void configure();

    void SetupControlSocket();

    void ProcessDataSocket();

private:
    /// Server address in the form `tcp://ip:port`
    std::string m_serverAddress;

    /// This callback is called on the update of the stage
    std::function<void()> m_onStageUpdate;

    /// Server control socket. This socket is responsible for
    /// server connection establishment and command sending process.
    zmq::socket_t m_controlSocket;

    /// Server data pull socket. This socket receives any kind of data
    /// from the server, currently it can be either layer data or layer removal data.
    zmq::socket_t m_dataSocket;

    /// Application-NetworkThread communication socket. So as client-server
    /// communication happens in the background thread (m_networkThread), we
    /// are using this socket to pass the data from the application thread to
    /// the networking thread through this socket. This socket is of inproc type,
    /// i.e. message passing overhead is minuscule.
    zmq::socket_t m_appSocket;

    /// Client-sever communication happens in the background thread. In such a way
    /// RprIpcClient is not bound to the user threading setup.
    std::thread m_networkThread;

private:
    class LayerController {
    public:
        LayerController(RprIpcClient* parent, std::string const& layersBindDir);
        ~LayerController();

        void AddLayer(std::string const& layerPath,
                      bool isRoot,
                      char* encodedLayer,
                      size_t encodedLayerSize);
        void RemoveLayer(std::string const& layerPath);

        bool Update();

        UsdStagePtr GetStage() { return m_rootStage; }

    private:
        UsdStageRefPtr CreateRootStage();
        SdfLayerRefPtr CreateLayer(std::string const& layerPath);
        std::string GetLayerSavePath(const char* layerPath);
        bool InMemoryMode() const { return m_layersBindDir.empty(); }

    private:
        RprIpcClient* m_rprIpcClient;
        const std::string m_layersBindDir;

        UsdStageRefPtr m_rootStage;
        std::map<std::string, SdfLayerRefPtr> m_layers;
        std::map<std::string, SdfLayerHandle> m_rootLayers;

        enum ChangeTracker {
            Clean = 0,
            AllDirty = ~Clean,
            DirtyLayers = 1 << 0,
            DirtyRootLayers = 1 << 1,
        };
        uint32_t m_dirtyBits = AllDirty;
    };

private:
    LayerController m_layerController;
    LayerFormat m_layerFormat;
};

PXR_NAMESPACE_CLOSE_SCOPE

#endif // RPR_IMAGING_IPC_CLIENT_H
