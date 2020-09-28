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

public class UsdGeomNurbsCurves : UsdGeomCurves {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomNurbsCurves(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdGeomNurbsCurves_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomNurbsCurves obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomNurbsCurves() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomNurbsCurves(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomNurbsCurves(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdGeomNurbsCurves__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomNurbsCurves() : this(USDIPCPINVOKE.new_UsdGeomNurbsCurves__SWIG_1(), true) {
  }

  public UsdGeomNurbsCurves(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdGeomNurbsCurves__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomNurbsCurves Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomNurbsCurves ret = new UsdGeomNurbsCurves(USDIPCPINVOKE.UsdGeomNurbsCurves_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomNurbsCurves Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomNurbsCurves ret = new UsdGeomNurbsCurves(USDIPCPINVOKE.UsdGeomNurbsCurves_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetOrderAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_GetOrderAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateOrderAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrderAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrderAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateOrderAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_GetKnotsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateKnotsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateKnotsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateKnotsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRangesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_GetRangesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRangesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRangesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRangesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomNurbsCurves_CreateRangesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

}

}
