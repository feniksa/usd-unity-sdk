/************************************************************************
Copyright 2021 Advanced Micro Devices, Inc
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

#ifndef LAYERFORMAT_H
#define LAYERFORMAT_H

#include "pxr/pxr.h"
#include <string>

PXR_NAMESPACE_OPEN_SCOPE

enum LayerFormat { USDA = 0, USD = 1};

inline std::string to_string(LayerFormat layerFormat)
{
switch (layerFormat)
    {
    case LayerFormat::USD:
        return "usd";
    case LayerFormat::USDA:
        return "usda";
    default:
        return "usda";
    }
}

PXR_NAMESPACE_CLOSE_SCOPE

#endif
