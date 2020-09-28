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

#ifndef RPR_IMAGING_IPC_API_H
#define RPR_IMAGING_IPC_API_H

#include "pxr/base/arch/export.h"

#if defined(PXR_STATIC)
#   define RPR_IPC_API
#   define RPR_IPC_TEMPLATE_CLASS(...)
#   define RPR_IPC_TEMPLATE_STRUCT(...)
#else
#   if defined(IPC_EXPORTS)
#       define RPR_IPC_API ARCH_EXPORT
#       define RPR_IPC_TEMPLATE_CLASS(...) ARCH_EXPORT_TEMPLATE(class, __VA_ARGS__)
#       define RPR_IPC_TEMPLATE_STRUCT(...) ARCH_EXPORT_TEMPLATE(struct, __VA_ARGS__)
#   else
#       define RPR_IPC_API ARCH_IMPORT
#       define RPR_IPC_TEMPLATE_CLASS(...) ARCH_IMPORT_TEMPLATE(class, __VA_ARGS__)
#       define RPR_IPC_TEMPLATE_STRUCT(...) ARCH_IMPORT_TEMPLATE(struct, __VA_ARGS__)
#   endif
#endif

#endif // RPR_IMAGING_IPC_API_H