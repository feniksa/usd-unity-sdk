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

public class UsdSkelInbetweenShape : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelInbetweenShape(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelInbetweenShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelInbetweenShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdSkelInbetweenShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelInbetweenShape() : this(USDIPCPINVOKE.new_UsdSkelInbetweenShape__SWIG_0(), true) {
  }

  public UsdSkelInbetweenShape(UsdAttribute attr) : this(USDIPCPINVOKE.new_UsdSkelInbetweenShape__SWIG_1(UsdAttribute.getCPtr(attr)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetWeight() {
    float ret = USDIPCPINVOKE.UsdSkelInbetweenShape_GetWeight(swigCPtr);
    return ret;
  }

  public bool SetWeight(float weight) {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_SetWeight(swigCPtr, weight);
    return ret;
  }

  public bool HasAuthoredWeight() {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_HasAuthoredWeight(swigCPtr);
    return ret;
  }

  public bool GetOffsets(VtVec3fArray offsets) {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_GetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
    return ret;
  }

  public bool SetOffsets(VtVec3fArray offsets) {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_SetOffsets(swigCPtr, VtVec3fArray.getCPtr(offsets));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsInbetween(UsdAttribute attr) {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_IsInbetween(UsdAttribute.getCPtr(attr));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdSkelInbetweenShape_GetAttr(swigCPtr), false);
    return ret;
  }

  public bool IsDefined() {
    bool ret = USDIPCPINVOKE.UsdSkelInbetweenShape_IsDefined(swigCPtr);
    return ret;
  }

}

}