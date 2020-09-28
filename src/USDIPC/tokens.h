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

#ifndef RPR_IMAGING_IPC_TOKENS_H
#define RPR_IMAGING_IPC_TOKENS_H

#include "api.h"

#include "pxr/pxr.h"
#include "pxr/base/tf/staticTokens.h"

PXR_NAMESPACE_OPEN_SCOPE

#define RPR_IPC_TOKENS \
    (connect) \
    (disconnect) \
    (shutdown) \
    (ping) \
    (layer) \
    (layerRemove) \
    (ok) \
    (fail)

TF_DECLARE_PUBLIC_TOKENS(RprIpcTokens, RPR_IPC_API, RPR_IPC_TOKENS);

PXR_NAMESPACE_CLOSE_SCOPE

#endif // RPR_IMAGING_IPC_TOKENS_H
