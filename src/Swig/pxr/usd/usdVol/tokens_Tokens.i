// Copyright 2017 Google Inc. All rights reserved.
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

%typemap(cscode) UsdVolTokens %{
  public static TfToken bool_ = new TfToken("bool");
  public static TfToken color = new TfToken("Color");
  public static TfToken double2 = new TfToken("double2");
  public static TfToken double3 = new TfToken("double3");
  public static TfToken double_ = new TfToken("double");
  public static TfToken field = new TfToken("field");
  public static TfToken fieldClass = new TfToken("fieldClass");
  public static TfToken fieldDataType = new TfToken("fieldDataType");
  public static TfToken fieldIndex = new TfToken("fieldIndex");
  public static TfToken fieldName = new TfToken("fieldName");
  public static TfToken fieldPurpose = new TfToken("fieldPurpose");
  public static TfToken filePath = new TfToken("filePath");
  public static TfToken float2 = new TfToken("float2");
  public static TfToken float3 = new TfToken("float3");
  public static TfToken float_ = new TfToken("float");
  public static TfToken fogVolume = new TfToken("fogVolume");
  public static TfToken half = new TfToken("half");
  public static TfToken half2 = new TfToken("half2");
  public static TfToken half3 = new TfToken("half3");
  public static TfToken int2 = new TfToken("int2");
  public static TfToken int3 = new TfToken("int3");
  public static TfToken int64 = new TfToken("int64");
  public static TfToken int_ = new TfToken("int");
  public static TfToken levelSet = new TfToken("levelSet");
  public static TfToken mask = new TfToken("mask");
  public static TfToken matrix3d = new TfToken("matrix3d");
  public static TfToken matrix4d = new TfToken("matrix4d");
  public static TfToken none = new TfToken("None");
  public static TfToken normal = new TfToken("Normal");
  public static TfToken point = new TfToken("Point");
  public static TfToken quatd = new TfToken("quatd");
  public static TfToken staggered = new TfToken("staggered");
  public static TfToken string = new TfToken("string");
  public static TfToken uint = new TfToken("uint");
  public static TfToken unknown = new TfToken("unknown");
  public static TfToken vector = new TfToken("Vector");
  public static TfToken vectorDataRoleHint = new TfToken("vectorDataRoleHint");
%}
