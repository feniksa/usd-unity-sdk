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

public class UsdLuxDomeLight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdLuxDomeLight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxDomeLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdLuxDomeLight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdLuxDomeLight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdLuxDomeLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxDomeLight__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdLuxDomeLight() : this(UsdCsPINVOKE.new_UsdLuxDomeLight__SWIG_1(), true) {
  }

  public UsdLuxDomeLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxDomeLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdLuxDomeLight Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdLuxDomeLight ret = new UsdLuxDomeLight(UsdCsPINVOKE.UsdLuxDomeLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdLuxDomeLight Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdLuxDomeLight ret = new UsdLuxDomeLight(UsdCsPINVOKE.UsdLuxDomeLight_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetTextureFileAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_GetTextureFileAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTextureFileAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTextureFileAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTextureFileAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFileAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetTextureFormatAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_GetTextureFormatAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateTextureFormatAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTextureFormatAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateTextureFormatAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetPortalsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxDomeLight_GetPortalsRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreatePortalsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxDomeLight_CreatePortalsRel(swigCPtr), true);
    return ret;
  }

  public void OrientToStageUpAxis() {
    UsdCsPINVOKE.UsdLuxDomeLight_OrientToStageUpAxis(swigCPtr);
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdLuxDomeLight_schemaKind_get();
}

}
