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

public class UsdGeomCube : UsdGeomGprim {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomCube(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdGeomCube_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomCube obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomCube() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomCube(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomCube(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdGeomCube__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomCube() : this(USDIPCPINVOKE.new_UsdGeomCube__SWIG_1(), true) {
  }

  public UsdGeomCube(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdGeomCube__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomCube_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomCube_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomCube Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomCube ret = new UsdGeomCube(USDIPCPINVOKE.UsdGeomCube_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCube Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomCube ret = new UsdGeomCube(USDIPCPINVOKE.UsdGeomCube_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetSizeAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_GetSizeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateSizeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSizeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSizeAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateSizeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public new UsdAttribute GetExtentAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_GetExtentAttr(swigCPtr), true);
    return ret;
  }

  public new UsdAttribute CreateExtentAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new UsdAttribute CreateExtentAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new UsdAttribute CreateExtentAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomCube_CreateExtentAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public static bool ComputeExtent(double size, VtVec3fArray extent) {
    bool ret = USDIPCPINVOKE.UsdGeomCube_ComputeExtent__SWIG_0(size, VtVec3fArray.getCPtr(extent));
    return ret;
  }

  public static bool ComputeExtent(double size, GfMatrix4d transform, VtVec3fArray extent) {
    bool ret = USDIPCPINVOKE.UsdGeomCube_ComputeExtent__SWIG_1(size, GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
