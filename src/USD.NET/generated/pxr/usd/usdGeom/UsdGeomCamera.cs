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

public class UsdGeomCamera : UsdGeomXformable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomCamera(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomCamera_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomCamera obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomCamera() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomCamera(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomCamera(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomCamera__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomCamera() : this(UsdCsPINVOKE.new_UsdGeomCamera__SWIG_1(), true) {
  }

  public UsdGeomCamera(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdGeomCamera__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomCamera_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdGeomCamera_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdGeomCamera Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomCamera ret = new UsdGeomCamera(UsdCsPINVOKE.UsdGeomCamera_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomCamera Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdGeomCamera ret = new UsdGeomCamera(UsdCsPINVOKE.UsdGeomCamera_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetProjectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetProjectionAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateProjectionAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateProjectionAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateProjectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateProjectionAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetHorizontalApertureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetHorizontalApertureAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVerticalApertureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetVerticalApertureAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVerticalApertureAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVerticalApertureAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVerticalApertureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetHorizontalApertureOffsetAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetHorizontalApertureOffsetAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureOffsetAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureOffsetAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHorizontalApertureOffsetAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetVerticalApertureOffsetAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetVerticalApertureOffsetAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateVerticalApertureOffsetAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVerticalApertureOffsetAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateVerticalApertureOffsetAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetFocalLengthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetFocalLengthAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateFocalLengthAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFocalLengthAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFocalLengthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocalLengthAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetClippingRangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetClippingRangeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateClippingRangeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateClippingRangeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateClippingRangeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingRangeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetClippingPlanesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetClippingPlanesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateClippingPlanesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateClippingPlanesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateClippingPlanesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateClippingPlanesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetFStopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetFStopAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateFStopAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFStopAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFStopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFStopAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetFocusDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetFocusDistanceAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateFocusDistanceAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFocusDistanceAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFocusDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateFocusDistanceAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetStereoRoleAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetStereoRoleAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateStereoRoleAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateStereoRoleAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateStereoRoleAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateStereoRoleAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetShutterOpenAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetShutterOpenAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateShutterOpenAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateShutterOpenAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateShutterOpenAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterOpenAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetShutterCloseAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetShutterCloseAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateShutterCloseAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateShutterCloseAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateShutterCloseAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateShutterCloseAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetExposureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_GetExposureAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateExposureAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateExposureAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateExposureAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomCamera_CreateExposureAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public GfCamera GetCamera(UsdTimeCode time) {
    GfCamera ret = new GfCamera(UsdCsPINVOKE.UsdGeomCamera_GetCamera(swigCPtr, UsdTimeCode.getCPtr(time)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFromCamera(GfCamera camera, UsdTimeCode time) {
    UsdCsPINVOKE.UsdGeomCamera_SetFromCamera(swigCPtr, GfCamera.getCPtr(camera), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdGeomCamera_schemaKind_get();
}

}
