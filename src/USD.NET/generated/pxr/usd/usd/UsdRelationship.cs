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

public class UsdRelationship : UsdProperty {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdRelationship(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRelationship_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRelationship obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdRelationship() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdRelationship(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdRelationship() : this(UsdCsPINVOKE.new_UsdRelationship(), true) {
  }

  public bool AddTarget(SdfPath target, UsdListPosition position) {
    bool ret = UsdCsPINVOKE.UsdRelationship_AddTarget__SWIG_0(swigCPtr, SdfPath.getCPtr(target), (int)position);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddTarget(SdfPath target) {
    bool ret = UsdCsPINVOKE.UsdRelationship_AddTarget__SWIG_1(swigCPtr, SdfPath.getCPtr(target));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool RemoveTarget(SdfPath target) {
    bool ret = UsdCsPINVOKE.UsdRelationship_RemoveTarget(swigCPtr, SdfPath.getCPtr(target));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetTargets(SdfPathVector targets) {
    bool ret = UsdCsPINVOKE.UsdRelationship_SetTargets(swigCPtr, SdfPathVector.getCPtr(targets));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearTargets(bool removeSpec) {
    bool ret = UsdCsPINVOKE.UsdRelationship_ClearTargets(swigCPtr, removeSpec);
    return ret;
  }

  public bool HasAuthoredTargets() {
    bool ret = UsdCsPINVOKE.UsdRelationship_HasAuthoredTargets(swigCPtr);
    return ret;
  }

  public SdfPathVector GetTargets() {
    SdfPathVector ret = new SdfPathVector(UsdCsPINVOKE.UsdRelationship_GetTargets(swigCPtr), true);
    return ret;
  }

  public SdfPathVector GetForwardedTargets() {
    SdfPathVector ret = new SdfPathVector(UsdCsPINVOKE.UsdRelationship_GetForwardedTargets(swigCPtr), true);
    return ret;
  }

}

}
