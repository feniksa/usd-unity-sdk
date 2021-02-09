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

public class UsdRiPxrBarnLightFilter : UsdLuxLightFilter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdRiPxrBarnLightFilter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiPxrBarnLightFilter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdRiPxrBarnLightFilter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdRiPxrBarnLightFilter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdRiPxrBarnLightFilter(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiPxrBarnLightFilter__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdRiPxrBarnLightFilter() : this(UsdCsPINVOKE.new_UsdRiPxrBarnLightFilter__SWIG_1(), true) {
  }

  public UsdRiPxrBarnLightFilter(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiPxrBarnLightFilter__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdRiPxrBarnLightFilter Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiPxrBarnLightFilter ret = new UsdRiPxrBarnLightFilter(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static UsdRiPxrBarnLightFilter Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiPxrBarnLightFilter ret = new UsdRiPxrBarnLightFilter(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetBarnModeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetBarnModeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateBarnModeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateBarnModeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateBarnModeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateBarnModeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateBarnModeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateBarnModeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetWidthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetWidthAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateWidthAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateWidthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateWidthAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateWidthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateWidthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateWidthAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetHeightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetHeightAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateHeightAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateHeightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHeightAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateHeightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHeightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateHeightAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRadiusAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetRadiusAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRadiusAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRadiusAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRadiusAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRadiusAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRadiusAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRadiusAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDirectionalAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDirectionalAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDirectionalAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDirectionalAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDirectionalAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDirectionalAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDirectionalAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDirectionalAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticShearXAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticShearXAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticShearXAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearXAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticShearXAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearXAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticShearXAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearXAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticShearYAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticShearYAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticShearYAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearYAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticShearYAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearYAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticShearYAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticShearYAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticApexAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticApexAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticApexAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticApexAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticApexAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticApexAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticApexAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticApexAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticUseLightDirectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticUseLightDirectionAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticUseLightDirectionAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticUseLightDirectionAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticUseLightDirectionAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticUseLightDirectionAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticUseLightDirectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticUseLightDirectionAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDensityNearDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDensityNearDistanceAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearDistanceAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearDistanceAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearDistanceAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDensityFarDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDensityFarDistanceAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarDistanceAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarDistanceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarDistanceAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarDistanceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarDistanceAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarDistanceAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDensityNearValueAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDensityNearValueAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearValueAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearValueAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearValueAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearValueAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityNearValueAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityNearValueAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDensityFarValueAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDensityFarValueAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarValueAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarValueAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarValueAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarValueAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityFarValueAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityFarValueAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAnalyticDensityExponentAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetAnalyticDensityExponentAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityExponentAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityExponentAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityExponentAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityExponentAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAnalyticDensityExponentAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateAnalyticDensityExponentAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetEdgeThicknessAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetEdgeThicknessAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateEdgeThicknessAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeThicknessAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeThicknessAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeThicknessAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeThicknessAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeThicknessAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetPreBarnEffectAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetPreBarnEffectAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreatePreBarnEffectAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreatePreBarnEffectAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePreBarnEffectAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreatePreBarnEffectAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePreBarnEffectAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreatePreBarnEffectAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetScaleWidthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetScaleWidthAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateScaleWidthAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleWidthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScaleWidthAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleWidthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScaleWidthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleWidthAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetScaleHeightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetScaleHeightAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateScaleHeightAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleHeightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScaleHeightAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleHeightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateScaleHeightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateScaleHeightAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRefineTopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetRefineTopAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRefineTopAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineTopAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineTopAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineTopAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineTopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineTopAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRefineBottomAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetRefineBottomAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRefineBottomAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineBottomAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineBottomAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineBottomAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineBottomAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineBottomAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRefineLeftAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetRefineLeftAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRefineLeftAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineLeftAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineLeftAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineLeftAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineLeftAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineLeftAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRefineRightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetRefineRightAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRefineRightAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineRightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineRightAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineRightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRefineRightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateRefineRightAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetEdgeScaleTopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetEdgeScaleTopAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateEdgeScaleTopAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleTopAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleTopAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleTopAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleTopAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleTopAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetEdgeScaleBottomAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetEdgeScaleBottomAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateEdgeScaleBottomAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleBottomAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleBottomAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleBottomAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleBottomAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleBottomAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetEdgeScaleLeftAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetEdgeScaleLeftAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateEdgeScaleLeftAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleLeftAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleLeftAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleLeftAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleLeftAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleLeftAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetEdgeScaleRightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_GetEdgeScaleRightAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateEdgeScaleRightAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleRightAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleRightAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleRightAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateEdgeScaleRightAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrBarnLightFilter_CreateEdgeScaleRightAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdRiPxrBarnLightFilter_schemaKind_get();
}

}
