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

public class UsdGeomGprim : UsdGeomBoundable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomGprim(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdGeomGprim_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomGprim obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomGprim() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomGprim(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomGprim(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdGeomGprim__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomGprim() : this(USDIPCPINVOKE.new_UsdGeomGprim__SWIG_1(), true) {
  }

  public UsdGeomGprim(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdGeomGprim__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomGprim_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomGprim_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomGprim Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomGprim ret = new UsdGeomGprim(USDIPCPINVOKE.UsdGeomGprim_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetDisplayColorAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_GetDisplayColorAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateDisplayColorAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDisplayColorAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDisplayColorAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetDisplayOpacityAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_GetDisplayOpacityAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateDisplayOpacityAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDisplayOpacityAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDisplayOpacityAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetDoubleSidedAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_GetDoubleSidedAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDoubleSidedAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDoubleSidedAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateDoubleSidedAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetOrientationAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_GetOrientationAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateOrientationAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrientationAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrientationAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomGprim_CreateOrientationAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar GetDisplayColorPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_GetDisplayColorPrimvar(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayColorPrimvar(TfToken interpolation, int elementSize) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(interpolation), elementSize), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayColorPrimvar(TfToken interpolation) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(interpolation)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayColorPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar GetDisplayOpacityPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_GetDisplayOpacityPrimvar(swigCPtr), true);
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayOpacityPrimvar(TfToken interpolation, int elementSize) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_0(swigCPtr, TfToken.getCPtr(interpolation), elementSize), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayOpacityPrimvar(TfToken interpolation) {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_1(swigCPtr, TfToken.getCPtr(interpolation)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomPrimvar CreateDisplayOpacityPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_2(swigCPtr), true);
    return ret;
  }

}

}
