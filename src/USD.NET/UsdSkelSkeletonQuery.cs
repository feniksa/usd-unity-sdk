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

public class UsdSkelSkeletonQuery : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelSkeletonQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelSkeletonQuery obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelSkeletonQuery() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdSkelSkeletonQuery(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelSkeletonQuery() : this(USDIPCPINVOKE.new_UsdSkelSkeletonQuery(), true) {
  }

  public bool IsValid() {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_IsValid(swigCPtr);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdSkelSkeletonQuery_GetPrim(swigCPtr), true);
    return ret;
  }

  public UsdSkelSkeleton GetSkeleton() {
    UsdSkelSkeleton ret = new UsdSkelSkeleton(USDIPCPINVOKE.UsdSkelSkeletonQuery_GetSkeleton(swigCPtr), false);
    return ret;
  }

  public UsdSkelAnimQuery GetAnimQuery() {
    UsdSkelAnimQuery ret = new UsdSkelAnimQuery(USDIPCPINVOKE.UsdSkelSkeletonQuery_GetAnimQuery(swigCPtr), false);
    return ret;
  }

  public UsdSkelTopology GetTopology() {
    UsdSkelTopology ret = new UsdSkelTopology(USDIPCPINVOKE.UsdSkelSkeletonQuery_GetTopology(swigCPtr), false);
    return ret;
  }

  public VtTokenArray GetJointOrder() {
    VtTokenArray ret = new VtTokenArray(USDIPCPINVOKE.UsdSkelSkeletonQuery_GetJointOrder(swigCPtr), true);
    return ret;
  }

  public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time, bool atRest) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), atRest);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointSkelTransforms(VtMatrix4dArray xforms, UsdTimeCode time, bool atRest) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointSkelTransforms__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), atRest);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointSkelTransforms(VtMatrix4dArray xforms, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointSkelTransforms__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointWorldTransforms(VtMatrix4dArray xforms, UsdGeomXformCache xfCache, bool atRest) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointWorldTransforms__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdGeomXformCache.getCPtr(xfCache), atRest);
    return ret;
  }

  public bool ComputeJointWorldTransforms(VtMatrix4dArray xforms, UsdGeomXformCache xfCache) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeJointWorldTransforms__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdGeomXformCache.getCPtr(xfCache));
    return ret;
  }

  public bool ComputeSkinningTransforms(VtMatrix4dArray xforms, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_ComputeSkinningTransforms(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetJointWorldBindTransforms(VtMatrix4dArray xforms) {
    bool ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_GetJointWorldBindTransforms(swigCPtr, VtMatrix4dArray.getCPtr(xforms));
    return ret;
  }

  public string GetDescription() {
    string ret = USDIPCPINVOKE.UsdSkelSkeletonQuery_GetDescription(swigCPtr);
    return ret;
  }

}

}
