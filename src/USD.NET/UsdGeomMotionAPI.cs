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

public class UsdGeomMotionAPI : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdGeomMotionAPI(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomMotionAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomMotionAPI() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomMotionAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdGeomMotionAPI(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdGeomMotionAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomMotionAPI() : this(USDIPCPINVOKE.new_UsdGeomMotionAPI__SWIG_1(), true) {
  }

  public UsdGeomMotionAPI(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdGeomMotionAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdGeomMotionAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomMotionAPI ret = new UsdGeomMotionAPI(USDIPCPINVOKE.UsdGeomMotionAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomMotionAPI Apply(UsdPrim prim) {
    UsdGeomMotionAPI ret = new UsdGeomMotionAPI(USDIPCPINVOKE.UsdGeomMotionAPI_Apply(UsdPrim.getCPtr(prim)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetVelocityScaleAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomMotionAPI_GetVelocityScaleAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVelocityScaleAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVelocityScaleAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVelocityScaleAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public float ComputeVelocityScale(UsdTimeCode time) {
    float ret = USDIPCPINVOKE.UsdGeomMotionAPI_ComputeVelocityScale__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ComputeVelocityScale() {
    float ret = USDIPCPINVOKE.UsdGeomMotionAPI_ComputeVelocityScale__SWIG_1(swigCPtr);
    return ret;
  }

}

}