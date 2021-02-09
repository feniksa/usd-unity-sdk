//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdClipsAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdClipsAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdClipsAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdClipsAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdClipsAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdClipsAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdClipsAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdClipsAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdClipsAPI() : this(UsdCsPINVOKE.new_UsdClipsAPI__SWIG_1(), true) {
  }

  public UsdClipsAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdClipsAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdClipsAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdClipsAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdClipsAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdClipsAPI ret = new UsdClipsAPI(UsdCsPINVOKE.UsdClipsAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClips(VtDictionary clips) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClips(swigCPtr, VtDictionary.getCPtr(clips));
    return ret;
  }

  public bool SetClips(VtDictionary clips) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClips(swigCPtr, VtDictionary.getCPtr(clips));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipSets(SdfStringListOp clipSets) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipSets(swigCPtr, SdfStringListOp.getCPtr(clipSets));
    return ret;
  }

  public bool SetClipSets(SdfStringListOp clipSets) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipSets(swigCPtr, SdfStringListOp.getCPtr(clipSets));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfAssetPathArray ComputeClipAssetPaths(string clipSet) {
    SdfAssetPathArray ret = new SdfAssetPathArray(UsdCsPINVOKE.UsdClipsAPI_ComputeClipAssetPaths__SWIG_0(swigCPtr, clipSet), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfAssetPathArray ComputeClipAssetPaths() {
    SdfAssetPathArray ret = new SdfAssetPathArray(UsdCsPINVOKE.UsdClipsAPI_ComputeClipAssetPaths__SWIG_1(swigCPtr), true);
    return ret;
  }

  public bool GetClipAssetPaths(SdfAssetPathArray assetPaths, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipAssetPaths__SWIG_0(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipAssetPaths(SdfAssetPathArray assetPaths) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipAssetPaths__SWIG_1(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths));
    return ret;
  }

  public bool SetClipAssetPaths(SdfAssetPathArray assetPaths, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipAssetPaths__SWIG_0(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipAssetPaths(SdfAssetPathArray assetPaths) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipAssetPaths__SWIG_1(swigCPtr, SdfAssetPathArray.getCPtr(assetPaths));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipPrimPath(/*cstype*/ out string primPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipPrimPath__SWIG_0(swigCPtr, out primPath, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipPrimPath(/*cstype*/ out string primPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipPrimPath__SWIG_1(swigCPtr, out primPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipPrimPath(string primPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipPrimPath__SWIG_0(swigCPtr, primPath, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipPrimPath(string primPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipPrimPath__SWIG_1(swigCPtr, primPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipActive(VtVec2dArray activeClips, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipActive__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(activeClips), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipActive(VtVec2dArray activeClips) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipActive__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(activeClips));
    return ret;
  }

  public bool SetClipActive(VtVec2dArray activeClips, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipActive__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(activeClips), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipActive(VtVec2dArray activeClips) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipActive__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(activeClips));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTimes(VtVec2dArray clipTimes, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTimes__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(clipTimes), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTimes(VtVec2dArray clipTimes) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTimes__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(clipTimes));
    return ret;
  }

  public bool SetClipTimes(VtVec2dArray clipTimes, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTimes__SWIG_0(swigCPtr, VtVec2dArray.getCPtr(clipTimes), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTimes(VtVec2dArray clipTimes) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTimes__SWIG_1(swigCPtr, VtVec2dArray.getCPtr(clipTimes));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipManifestAssetPath(SdfAssetPath manifestAssetPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipManifestAssetPath__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipManifestAssetPath(SdfAssetPath manifestAssetPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipManifestAssetPath__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath));
    return ret;
  }

  public bool SetClipManifestAssetPath(SdfAssetPath manifestAssetPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipManifestAssetPath__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipManifestAssetPath(SdfAssetPath manifestAssetPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipManifestAssetPath__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(manifestAssetPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayer GenerateClipManifest(string clipSet, bool writeBlocksForClipsWithMissingValues) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_0(swigCPtr, clipSet, writeBlocksForClipsWithMissingValues);
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayer GenerateClipManifest(string clipSet) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_1(swigCPtr, clipSet);
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayer GenerateClipManifest(bool writeBlocksForClipsWithMissingValues) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_2(swigCPtr, writeBlocksForClipsWithMissingValues);
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    return ret;
  }

  public SdfLayer GenerateClipManifest() {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdClipsAPI_GenerateClipManifest__SWIG_3(swigCPtr);
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    return ret;
  }

  public static SdfLayer GenerateClipManifestFromLayers(SdfLayerHandleVector clipLayers, SdfPath clipPrimPath) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdClipsAPI_GenerateClipManifestFromLayers(SdfLayerHandleVector.getCPtr(clipLayers), SdfPath.getCPtr(clipPrimPath));
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetInterpolateMissingClipValues(SWIGTYPE_p_bool interpolate, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_0(swigCPtr, SWIGTYPE_p_bool.getCPtr(interpolate), clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetInterpolateMissingClipValues(SWIGTYPE_p_bool interpolate) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_1(swigCPtr, SWIGTYPE_p_bool.getCPtr(interpolate));
    return ret;
  }

  public bool SetInterpolateMissingClipValues(bool interpolate, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_0(swigCPtr, interpolate, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetInterpolateMissingClipValues(bool interpolate) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_1(swigCPtr, interpolate);
    return ret;
  }

  public bool GetClipTemplateAssetPath(/*cstype*/ out string clipTemplateAssetPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateAssetPath__SWIG_0(swigCPtr, out clipTemplateAssetPath, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateAssetPath(/*cstype*/ out string clipTemplateAssetPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateAssetPath__SWIG_1(swigCPtr, out clipTemplateAssetPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateAssetPath(string clipTemplateAssetPath, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateAssetPath__SWIG_0(swigCPtr, clipTemplateAssetPath, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateAssetPath(string clipTemplateAssetPath) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateAssetPath__SWIG_1(swigCPtr, clipTemplateAssetPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateStride(ref double clipTemplateStride, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateStride__SWIG_0(swigCPtr, ref clipTemplateStride, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateStride(ref double clipTemplateStride) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateStride__SWIG_1(swigCPtr, ref clipTemplateStride);
    return ret;
  }

  public bool SetClipTemplateActiveOffset(double clipTemplateActiveOffset, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_0(swigCPtr, clipTemplateActiveOffset, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateActiveOffset(double clipTemplateActiveOffset) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_1(swigCPtr, clipTemplateActiveOffset);
    return ret;
  }

  public bool GetClipTemplateActiveOffset(ref double clipTemplateActiveOffset, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_0(swigCPtr, ref clipTemplateActiveOffset, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateActiveOffset(ref double clipTemplateActiveOffset) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_1(swigCPtr, ref clipTemplateActiveOffset);
    return ret;
  }

  public bool SetClipTemplateStride(double clipTemplateStride, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateStride__SWIG_0(swigCPtr, clipTemplateStride, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateStride(double clipTemplateStride) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateStride__SWIG_1(swigCPtr, clipTemplateStride);
    return ret;
  }

  public bool GetClipTemplateStartTime(ref double clipTemplateStartTime, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateStartTime__SWIG_0(swigCPtr, ref clipTemplateStartTime, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateStartTime(ref double clipTemplateStartTime) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateStartTime__SWIG_1(swigCPtr, ref clipTemplateStartTime);
    return ret;
  }

  public bool SetClipTemplateStartTime(double clipTemplateStartTime, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateStartTime__SWIG_0(swigCPtr, clipTemplateStartTime, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateStartTime(double clipTemplateStartTime) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateStartTime__SWIG_1(swigCPtr, clipTemplateStartTime);
    return ret;
  }

  public bool GetClipTemplateEndTime(ref double clipTemplateEndTime, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateEndTime__SWIG_0(swigCPtr, ref clipTemplateEndTime, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetClipTemplateEndTime(ref double clipTemplateEndTime) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_GetClipTemplateEndTime__SWIG_1(swigCPtr, ref clipTemplateEndTime);
    return ret;
  }

  public bool SetClipTemplateEndTime(double clipTemplateEndTime, string clipSet) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateEndTime__SWIG_0(swigCPtr, clipTemplateEndTime, clipSet);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetClipTemplateEndTime(double clipTemplateEndTime) {
    bool ret = UsdCsPINVOKE.UsdClipsAPI_SetClipTemplateEndTime__SWIG_1(swigCPtr, clipTemplateEndTime);
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdClipsAPI_schemaKind_get();
}

}
