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

public class UsdSkelSkinningQuery : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelSkinningQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelSkinningQuery obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelSkinningQuery() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdSkelSkinningQuery(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelSkinningQuery() : this(USDIPCPINVOKE.new_UsdSkelSkinningQuery__SWIG_0(), true) {
  }

  public UsdSkelSkinningQuery(UsdPrim prim, VtTokenArray skelJointOrder, UsdAttribute jointIndices, UsdAttribute jointWeights, UsdAttribute geomBindTransform, UsdAttribute joints) : this(USDIPCPINVOKE.new_UsdSkelSkinningQuery__SWIG_1(UsdPrim.getCPtr(prim), VtTokenArray.getCPtr(skelJointOrder), UsdAttribute.getCPtr(jointIndices), UsdAttribute.getCPtr(jointWeights), UsdAttribute.getCPtr(geomBindTransform), UsdAttribute.getCPtr(joints)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsValid() {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_IsValid(swigCPtr);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdSkelSkinningQuery_GetPrim(swigCPtr), false);
    return ret;
  }

  public int GetNumInfluencesPerComponent() {
    int ret = USDIPCPINVOKE.UsdSkelSkinningQuery_GetNumInfluencesPerComponent(swigCPtr);
    return ret;
  }

  public TfToken GetInterpolation() {
    TfToken ret = new TfToken(USDIPCPINVOKE.UsdSkelSkinningQuery_GetInterpolation(swigCPtr), false);
    return ret;
  }

  public bool IsRigidlyDeformed() {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_IsRigidlyDeformed(swigCPtr);
    return ret;
  }

  public UsdAttribute GetGeomBindTransformAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransformAttr(swigCPtr), false);
    return ret;
  }

  public UsdGeomPrimvar GetJointIndicesPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdSkelSkinningQuery_GetJointIndicesPrimvar(swigCPtr), false);
    return ret;
  }

  public UsdGeomPrimvar GetJointWeightsPrimvar() {
    UsdGeomPrimvar ret = new UsdGeomPrimvar(USDIPCPINVOKE.UsdSkelSkinningQuery_GetJointWeightsPrimvar(swigCPtr), false);
    return ret;
  }

  public bool GetJointOrder(VtTokenArray jointOrder) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_GetJointOrder(swigCPtr, VtTokenArray.getCPtr(jointOrder));
    return ret;
  }

  public bool GetTimeSamples(StdDoubleVector times) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
    return ret;
  }

  public bool ComputeJointInfluences(VtIntArray indices, VtFloatArray weights, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_0(swigCPtr, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeJointInfluences(VtIntArray indices, VtFloatArray weights) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_1(swigCPtr, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights));
    return ret;
  }

  public bool ComputeVaryingJointInfluences(uint numPoints, VtIntArray indices, VtFloatArray weights, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_0(swigCPtr, numPoints, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeVaryingJointInfluences(uint numPoints, VtIntArray indices, VtFloatArray weights) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_1(swigCPtr, numPoints, VtIntArray.getCPtr(indices), VtFloatArray.getCPtr(weights));
    return ret;
  }

  public bool ComputeSkinnedPoints(VtMatrix4dArray xforms, VtVec3fArray points, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeSkinnedPoints__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), VtVec3fArray.getCPtr(points), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinnedPoints(VtMatrix4dArray xforms, VtVec3fArray points) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeSkinnedPoints__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), VtVec3fArray.getCPtr(points));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinnedTransform(VtMatrix4dArray xforms, GfMatrix4d xform, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeSkinnedTransform__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), GfMatrix4d.getCPtr(xform), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkinnedTransform(VtMatrix4dArray xforms, GfMatrix4d xform) {
    bool ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeSkinnedTransform__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), GfMatrix4d.getCPtr(xform));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ComputeExtentsPadding(VtMatrix4dArray skelRestXforms, UsdGeomBoundable boundable) {
    float ret = USDIPCPINVOKE.UsdSkelSkinningQuery_ComputeExtentsPadding(swigCPtr, VtMatrix4dArray.getCPtr(skelRestXforms), UsdGeomBoundable.getCPtr(boundable));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d GetGeomBindTransform(UsdTimeCode time) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d GetGeomBindTransform() {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_1(swigCPtr), true);
    return ret;
  }

  public string GetDescription() {
    string ret = USDIPCPINVOKE.UsdSkelSkinningQuery_GetDescription(swigCPtr);
    return ret;
  }

}

}
