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

public class UsdSkelBlendShape : UsdTyped {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdSkelBlendShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdSkelBlendShape_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelBlendShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelBlendShape() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelBlendShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdSkelBlendShape(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdSkelBlendShape__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelBlendShape() : this(UsdCsPINVOKE.new_UsdSkelBlendShape__SWIG_1(), true) {
  }

  public UsdSkelBlendShape(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdSkelBlendShape__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdSkelBlendShape Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelBlendShape ret = new UsdSkelBlendShape(UsdCsPINVOKE.UsdSkelBlendShape_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdSkelBlendShape Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdSkelBlendShape ret = new UsdSkelBlendShape(UsdCsPINVOKE.UsdSkelBlendShape_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetOffsetsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_GetOffsetsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateOffsetsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOffsetsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateOffsetsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetNormalOffsetsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_GetNormalOffsetsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateNormalOffsetsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetPointIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_GetPointIndicesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreatePointIndicesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePointIndicesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreatePointIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdSkelInbetweenShape CreateInbetween(TfToken name) {
    UsdSkelInbetweenShape ret = new UsdSkelInbetweenShape(UsdCsPINVOKE.UsdSkelBlendShape_CreateInbetween(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdSkelInbetweenShape GetInbetween(TfToken name) {
    UsdSkelInbetweenShape ret = new UsdSkelInbetweenShape(UsdCsPINVOKE.UsdSkelBlendShape_GetInbetween(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasInbetween(TfToken name) {
    bool ret = UsdCsPINVOKE.UsdSkelBlendShape_HasInbetween(swigCPtr, TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdSkelInbetweenShapeVector GetInbetweens() {
    UsdSkelInbetweenShapeVector ret = new UsdSkelInbetweenShapeVector(UsdCsPINVOKE.UsdSkelBlendShape_GetInbetweens(swigCPtr), true);
    return ret;
  }

  public UsdSkelInbetweenShapeVector GetAuthoredInbetweens() {
    UsdSkelInbetweenShapeVector ret = new UsdSkelInbetweenShapeVector(UsdCsPINVOKE.UsdSkelBlendShape_GetAuthoredInbetweens(swigCPtr), true);
    return ret;
  }

  public static bool ValidatePointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numPoints, /*cstype*/ out string reason) {
    bool ret = UsdCsPINVOKE.UsdSkelBlendShape_ValidatePointIndices__SWIG_0(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numPoints, out reason);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool ValidatePointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numPoints) {
    bool ret = UsdCsPINVOKE.UsdSkelBlendShape_ValidatePointIndices__SWIG_1(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numPoints);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdSkelBlendShape_schemaKind_get();
}

}
