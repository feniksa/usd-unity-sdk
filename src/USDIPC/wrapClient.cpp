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

void wrapClient() {
    typedef void OnStageUpdateCallbackSig();
    using OnStageUpdateCallback = std::function<OnStageUpdateCallbackSig>;
    TfPyFunctionFromPython<OnStageUpdateCallbackSig>();

    using This = RprIpcClient;

    scope s = class_<This, RprIpcClientPtr, boost::noncopyable>("Client", no_init)
        .def(TfPyRefAndWeakPtr())
        .def("Create", +[](std::string const& serverAddress, OnStageUpdateCallback onStageUpdateCallback) {
                return RprIpcClient::Create(serverAddress, onStageUpdateCallback);
            },
            return_value_policy<TfPyRefPtrFactory<>>())
        .staticmethod("Create")
        .def("SendCommand", &This::SendCommand)
        .def("GetStage", &This::GetStage)
    ;
}
