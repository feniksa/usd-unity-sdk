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

public class UsdGeomXformCache : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdGeomXformCache(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomXformCache obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomXformCache() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomXformCache(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdGeomXformCache(UsdTimeCode time) : this(USDIPCPINVOKE.new_UsdGeomXformCache__SWIG_0(UsdTimeCode.getCPtr(time)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomXformCache() : this(USDIPCPINVOKE.new_UsdGeomXformCache__SWIG_1(), true) {
  }

  public GfMatrix4d GetLocalToWorldTransform(UsdPrim prim) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdGeomXformCache_GetLocalToWorldTransform(swigCPtr, UsdPrim.getCPtr(prim)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d GetParentToWorldTransform(UsdPrim prim) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdGeomXformCache_GetParentToWorldTransform(swigCPtr, UsdPrim.getCPtr(prim)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d GetLocalTransformation(UsdPrim prim, out bool resetsXformStack) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdGeomXformCache_GetLocalTransformation(swigCPtr, UsdPrim.getCPtr(prim), out resetsXformStack), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d ComputeRelativeTransform(UsdPrim prim, UsdPrim ancestor, SWIGTYPE_p_bool resetXformStack) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdGeomXformCache_ComputeRelativeTransform(swigCPtr, UsdPrim.getCPtr(prim), UsdPrim.getCPtr(ancestor), SWIGTYPE_p_bool.getCPtr(resetXformStack)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsAttributeIncludedInLocalTransform(UsdPrim prim, TfToken attrName) {
    bool ret = USDIPCPINVOKE.UsdGeomXformCache_IsAttributeIncludedInLocalTransform(swigCPtr, UsdPrim.getCPtr(prim), TfToken.getCPtr(attrName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TransformMightBeTimeVarying(UsdPrim prim) {
    bool ret = USDIPCPINVOKE.UsdGeomXformCache_TransformMightBeTimeVarying(swigCPtr, UsdPrim.getCPtr(prim));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetResetXformStack(UsdPrim prim) {
    bool ret = USDIPCPINVOKE.UsdGeomXformCache_GetResetXformStack(swigCPtr, UsdPrim.getCPtr(prim));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    USDIPCPINVOKE.UsdGeomXformCache_Clear(swigCPtr);
  }

  public void SetTime(UsdTimeCode time) {
    USDIPCPINVOKE.UsdGeomXformCache_SetTime(swigCPtr, UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdTimeCode GetTime() {
    UsdTimeCode ret = new UsdTimeCode(USDIPCPINVOKE.UsdGeomXformCache_GetTime(swigCPtr), true);
    return ret;
  }

  public void Swap(UsdGeomXformCache other) {
    USDIPCPINVOKE.UsdGeomXformCache_Swap(swigCPtr, UsdGeomXformCache.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
