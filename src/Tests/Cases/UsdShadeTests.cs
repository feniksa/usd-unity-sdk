﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using pxr;
using USD.NET;
using USD.NET.Unity;
using UnityEngine;

namespace Tests.Cases {
  class UsdShadeTests : UnitTest {

    public static void MaterialBindTest() {

      // Game plan:
      //   1. Create a cube
      //   2. Create a material
      //   3. Create a shader
      //   4. Create a texture
      //   5. Connect the material to the shader's output
      //   6. Connect the shader's albedo parameter to the texture's output
      //   7. Connect the texture to the source file on disk
      //   8. Write all values
      //   9. Bind the cube to the material
      var scene = Scene.Create();

      var cubePath     = "/Model/Geom/Cube";
      var materialPath = "/Model/Materials/SimpleMat";
      var shaderPath   = "/Model/Materials/SimpleMat/StandardShader";
      var texturePath  = "/Model/Materials/SimpleMat/AlbedoTexture";

      var cube = new CubeSample();
      cube.size = 1;

      var material = new MaterialSample();
      material.surface.defaultValue = Color.magenta;
      material.surface.connectedPath = shaderPath + ".outputs:out";

      var shader = new StandardShaderSample();
      shader.id = "Unity.Standard";
      shader.albedo.defaultValue = Color.white;
      shader.albedo.connectedPath = texturePath + ".outputs:out";

      var texture = new Texture2DSample();
      texture.sourceFile.defaultValue = @"C:\A\Bogus\Texture\Path.png";
      texture.sRgb = true;

      scene.Write(cubePath, cube);
      scene.Write(materialPath, material);
      scene.Write(shaderPath, shader);
      scene.Write(texturePath, texture);

      material.Bind(scene, cubePath, materialPath);

      PrintScene(scene);
    }
  }
}