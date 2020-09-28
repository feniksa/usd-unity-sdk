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

public class UsdGeomPointInstancer : UsdGeomBoundable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomPointInstancer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdGeomPointInstancer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomPointInstancer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomPointInstancer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomPointInstancer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomPointInstancer(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdGeomPointInstancer__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomPointInstancer() : this(USDIPCPINVOKE.new_UsdGeomPointInstancer__SWIG_1(), true) {
  }

  public UsdGeomPointInstancer(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdGeomPointInstancer__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomPointInstancer Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomPointInstancer ret = new UsdGeomPointInstancer(USDIPCPINVOKE.UsdGeomPointInstancer_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomPointInstancer Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomPointInstancer ret = new UsdGeomPointInstancer(USDIPCPINVOKE.UsdGeomPointInstancer_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetProtoIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetProtoIndicesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateProtoIndicesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateProtoIndicesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateProtoIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetIdsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetIdsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateIdsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIdsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIdsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateIdsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetPositionsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetPositionsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreatePositionsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePositionsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePositionsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreatePositionsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetOrientationsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetOrientationsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateOrientationsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrientationsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOrientationsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetScalesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetScalesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateScalesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScalesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScalesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateScalesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVelocitiesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetVelocitiesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVelocitiesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAngularVelocitiesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetAngularVelocitiesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAngularVelocitiesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAngularVelocitiesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAngularVelocitiesAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetInvisibleIdsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_GetInvisibleIdsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateInvisibleIdsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateInvisibleIdsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateInvisibleIdsAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetPrototypesRel() {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdGeomPointInstancer_GetPrototypesRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreatePrototypesRel() {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdGeomPointInstancer_CreatePrototypesRel(swigCPtr), true);
    return ret;
  }

  public bool ActivateId(long id) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ActivateId(swigCPtr, id);
    return ret;
  }

  public bool ActivateIds(VtInt64Array ids) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ActivateIds(swigCPtr, VtInt64Array.getCPtr(ids));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ActivateAllIds() {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ActivateAllIds(swigCPtr);
    return ret;
  }

  public bool DeactivateId(long id) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_DeactivateId(swigCPtr, id);
    return ret;
  }

  public bool DeactivateIds(VtInt64Array ids) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_DeactivateIds(swigCPtr, VtInt64Array.getCPtr(ids));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool VisId(long id, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_VisId(swigCPtr, id, UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool VisIds(VtInt64Array ids, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_VisIds(swigCPtr, VtInt64Array.getCPtr(ids), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool VisAllIds(UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_VisAllIds(swigCPtr, UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool InvisId(long id, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_InvisId(swigCPtr, id, UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool InvisIds(VtInt64Array ids, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_InvisIds(swigCPtr, VtInt64Array.getCPtr(ids), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomBoolVector ComputeMaskAtTime(UsdTimeCode time, VtInt64Array ids) {
    UsdGeomBoolVector ret = new UsdGeomBoolVector(USDIPCPINVOKE.UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), VtInt64Array.getCPtr(ids)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdGeomBoolVector ComputeMaskAtTime(UsdTimeCode time) {
    UsdGeomBoolVector ret = new UsdGeomBoolVector(USDIPCPINVOKE.UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime, UsdGeomPointInstancer.ProtoXformInclusion doProtoXforms, UsdGeomPointInstancer.MaskApplication applyMask) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms, (int)applyMask);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime, UsdGeomPointInstancer.ProtoXformInclusion doProtoXforms) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdTimeCode time, UsdTimeCode baseTime) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_2(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTimes(SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t xformsArray, SWIGTYPE_p_std__vectorT_UsdTimeCode_t times, UsdTimeCode baseTime, UsdGeomPointInstancer.ProtoXformInclusion doProtoXforms, UsdGeomPointInstancer.MaskApplication applyMask) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_0(swigCPtr, SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t.getCPtr(xformsArray), SWIGTYPE_p_std__vectorT_UsdTimeCode_t.getCPtr(times), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms, (int)applyMask);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTimes(SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t xformsArray, SWIGTYPE_p_std__vectorT_UsdTimeCode_t times, UsdTimeCode baseTime, UsdGeomPointInstancer.ProtoXformInclusion doProtoXforms) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_1(swigCPtr, SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t.getCPtr(xformsArray), SWIGTYPE_p_std__vectorT_UsdTimeCode_t.getCPtr(times), UsdTimeCode.getCPtr(baseTime), (int)doProtoXforms);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeInstanceTransformsAtTimes(SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t xformsArray, SWIGTYPE_p_std__vectorT_UsdTimeCode_t times, UsdTimeCode baseTime) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_2(swigCPtr, SWIGTYPE_p_std__vectorT_VtArrayT_GfMatrix4d_t_t.getCPtr(xformsArray), SWIGTYPE_p_std__vectorT_UsdTimeCode_t.getCPtr(times), UsdTimeCode.getCPtr(baseTime));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdStageWeakPtr stage, UsdTimeCode time, VtIntArray protoIndices, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray scales, VtQuathArray orientations, VtVec3fArray angularVelocities, UsdTimeCode angularVelocitiesSampleTime, SdfPathVector protoPaths, UsdGeomBoolVector mask, float velocityScale) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_3(VtMatrix4dArray.getCPtr(xforms), UsdStageWeakPtr.getCPtr(stage), UsdTimeCode.getCPtr(time), VtIntArray.getCPtr(protoIndices), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(scales), VtQuathArray.getCPtr(orientations), VtVec3fArray.getCPtr(angularVelocities), UsdTimeCode.getCPtr(angularVelocitiesSampleTime), SdfPathVector.getCPtr(protoPaths), UsdGeomBoolVector.getCPtr(mask), velocityScale);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ComputeInstanceTransformsAtTime(VtMatrix4dArray xforms, UsdStageWeakPtr stage, UsdTimeCode time, VtIntArray protoIndices, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray scales, VtQuathArray orientations, VtVec3fArray angularVelocities, UsdTimeCode angularVelocitiesSampleTime, SdfPathVector protoPaths, UsdGeomBoolVector mask) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_4(VtMatrix4dArray.getCPtr(xforms), UsdStageWeakPtr.getCPtr(stage), UsdTimeCode.getCPtr(time), VtIntArray.getCPtr(protoIndices), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(scales), VtQuathArray.getCPtr(orientations), VtVec3fArray.getCPtr(angularVelocities), UsdTimeCode.getCPtr(angularVelocitiesSampleTime), SdfPathVector.getCPtr(protoPaths), UsdGeomBoolVector.getCPtr(mask));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeExtentAtTime(VtVec3fArray extent, UsdTimeCode time, UsdTimeCode baseTime) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(extent), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeExtentAtTime(VtVec3fArray extent, UsdTimeCode time, UsdTimeCode baseTime, GfMatrix4d transform) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_1(swigCPtr, VtVec3fArray.getCPtr(extent), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime), GfMatrix4d.getCPtr(transform));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeExtentAtTimes(SWIGTYPE_p_std__vectorT_VtArrayT_GfVec3f_t_t extents, SWIGTYPE_p_std__vectorT_UsdTimeCode_t times, UsdTimeCode baseTime) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_0(swigCPtr, SWIGTYPE_p_std__vectorT_VtArrayT_GfVec3f_t_t.getCPtr(extents), SWIGTYPE_p_std__vectorT_UsdTimeCode_t.getCPtr(times), UsdTimeCode.getCPtr(baseTime));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeExtentAtTimes(SWIGTYPE_p_std__vectorT_VtArrayT_GfVec3f_t_t extents, SWIGTYPE_p_std__vectorT_UsdTimeCode_t times, UsdTimeCode baseTime, GfMatrix4d transform) {
    bool ret = USDIPCPINVOKE.UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_1(swigCPtr, SWIGTYPE_p_std__vectorT_VtArrayT_GfVec3f_t_t.getCPtr(extents), SWIGTYPE_p_std__vectorT_UsdTimeCode_t.getCPtr(times), UsdTimeCode.getCPtr(baseTime), GfMatrix4d.getCPtr(transform));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ProtoXformInclusion {
    IncludeProtoXform,
    ExcludeProtoXform
  }

  public enum MaskApplication {
    ApplyMask,
    IgnoreMask
  }

}

}
