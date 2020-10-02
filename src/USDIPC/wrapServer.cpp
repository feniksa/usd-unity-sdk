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

#include "server.h"

#include "pxr/base/tf/makePyConstructor.h"
#include "pxr/base/tf/pyPtrHelpers.h"
#include "pxr/base/tf/pyFunction.h"

#include <boost/python.hpp>
#include <boost/python/class.hpp>
#include <boost/python/def.hpp>
#include <boost/python/scope.hpp>
#include <boost/python/call.hpp>

using namespace boost::python;

PXR_NAMESPACE_USING_DIRECTIVE

using Listener = RprIpcServer::Listener;

class ServerListenerWrap : public Listener, public wrapper<Listener> {
public:
    ServerListenerWrap() = default;

    bool ProcessCommand(
        std::string const& command,
        uint8_t* payload, size_t payloadSize) override {

        auto payloadPtr = std::shared_ptr<uint8_t[]>(new uint8_t[payloadSize]);
        std::memcpy(payloadPtr.get(), payload, payloadSize);

        return this->get_override("ProcessCommand")(command, payloadPtr);
    }
};

struct ServerLayerWrap {
    RprIpcServer::Layer* layer;

    UsdStagePtr GetStage() { return layer->GetStage(); };
};

void wrapServer() {
    class_<ServerListenerWrap, boost::noncopyable>("ServerListener")
        .def("ProcessCommand", pure_virtual(&Listener::ProcessCommand));
    ;

    class_<ServerLayerWrap>("IpcLayer", no_init)
        .def("GetStage", &ServerLayerWrap::GetStage)
    ;

    scope s = class_<RprIpcServer, boost::noncopyable>("Server", init<ServerListenerWrap*>())
        .def("AddLayer", +[](RprIpcServer* server, SdfPath const& path, bool isRoot) {
            return ServerLayerWrap{server->AddLayer(path, isRoot)};
        })
        .def("OnLayerEdit", +[](RprIpcServer* server, SdfPath const& path, ServerLayerWrap layer) {
            server->OnLayerEdit(path, layer.layer);
        })
        .def("RemoveLayer", &RprIpcServer::RemoveLayer)
        .def("GetLayerReferencePath", &RprIpcServer::GetLayerReferencePath)
        .staticmethod("GetLayerReferencePath")
    ;
}
