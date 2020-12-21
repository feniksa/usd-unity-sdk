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
          UsdCsPINVOKE.delete_UsdSkelSkeletonQuery(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelSkeletonQuery() : this(UsdCsPINVOKE.new_UsdSkelSkeletonQuery(), true) {
  }

  public bool IsValid() {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_IsValid(swigCPtr);
    return ret;
  }

  public bool HasBindPose() {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_HasBindPose(swigCPtr);
    return ret;
  }

  public bool HasRestPose() {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_HasRestPose(swigCPtr);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetPrim(swigCPtr), true);
    return ret;
  }

  public UsdSkelSkeleton GetSkeleton() {
    UsdSkelSkeleton ret = new UsdSkelSkeleton(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetSkeleton(swigCPtr), false);
    return ret;
  }

  public UsdSkelAnimQuery GetAnimQuery() {
    UsdSkelAnimQuery ret = new UsdSkelAnimQuery(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetAnimQuery(swigCPtr), false);
    return ret;
  }

  public UsdSkelTopology GetTopology() {
    UsdSkelTopology ret = new UsdSkelTopology(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetTopology(swigCPtr), false);
    return ret;
  }

  public UsdSkelAnimMapper GetMapper() {
    UsdSkelAnimMapper ret = new UsdSkelAnimMapper(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetMapper(swigCPtr), false);
    return ret;
  }

  public VtTokenArray GetJointOrder() {
    VtTokenArray ret = new VtTokenArray(UsdCsPINVOKE.UsdSkelSkeletonQuery_GetJointOrder(swigCPtr), true);
    return ret;
  }

  public string GetDescription() {
    string ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_GetDescription(swigCPtr);
    return ret;
  }

  public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time, bool atRest) {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_2(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), atRest);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointLocalTransforms(VtMatrix4dArray xforms, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_3(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetJointWorldBindTransforms(VtMatrix4dArray xforms) {
    bool ret = UsdCsPINVOKE.UsdSkelSkeletonQuery_GetJointWorldBindTransforms(swigCPtr, VtMatrix4dArray.getCPtr(xforms));
    return ret;
  }

}

}
