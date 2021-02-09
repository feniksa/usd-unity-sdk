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

public class UsdGeomNurbsPatch : UsdGeomPointBased {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomNurbsPatch(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomNurbsPatch_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomNurbsPatch obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomNurbsPatch() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomNurbsPatch(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomNurbsPatch(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomNurbsPatch__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomNurbsPatch() : this(UsdCsPINVOKE.new_UsdGeomNurbsPatch__SWIG_1(), true) {
  }

  public UsdGeomNurbsPatch(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomNurbsPatch__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomNurbsPatch Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomNurbsPatch ret = new UsdGeomNurbsPatch(UsdCsPINVOKE.UsdGeomNurbsPatch_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomNurbsPatch Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomNurbsPatch ret = new UsdGeomNurbsPatch(UsdCsPINVOKE.UsdGeomNurbsPatch_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetUVertexCountAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetUVertexCountAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateUVertexCountAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUVertexCountAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUVertexCountAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVVertexCountAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetVVertexCountAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVVertexCountAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVVertexCountAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVVertexCountAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetUOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetUOrderAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateUOrderAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUOrderAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetVOrderAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVOrderAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVOrderAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVOrderAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetUKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetUKnotsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateUKnotsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUKnotsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetVKnotsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVKnotsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVKnotsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetUFormAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetUFormAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateUFormAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUFormAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateUFormAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateUFormAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVFormAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetVFormAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVFormAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVFormAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVFormAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVFormAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetURangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetURangeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateURangeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateURangeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateURangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateURangeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVRangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetVRangeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVRangeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVRangeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVRangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetPointWeightsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetPointWeightsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreatePointWeightsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePointWeightsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePointWeightsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurveCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurveCountsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurveCountsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveCountsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurveOrdersAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurveOrdersAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurveOrdersAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveOrdersAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveOrdersAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurveVertexCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurveVertexCountsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurveVertexCountsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveVertexCountsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveVertexCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurveKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurveKnotsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurveKnotsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveKnotsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurveRangesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurveRangesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurveRangesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveRangesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurveRangesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTrimCurvePointsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_GetTrimCurvePointsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTrimCurvePointsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurvePointsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTrimCurvePointsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdGeomNurbsPatch_schemaKind_get();
}

}
