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

public class UsdRiTextureAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdRiTextureAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiTextureAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiTextureAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdRiTextureAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdRiTextureAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdRiTextureAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiTextureAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdRiTextureAPI() : this(UsdCsPINVOKE.new_UsdRiTextureAPI__SWIG_1(), true) {
  }

  public UsdRiTextureAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiTextureAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiTextureAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiTextureAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdRiTextureAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiTextureAPI ret = new UsdRiTextureAPI(UsdCsPINVOKE.UsdRiTextureAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdRiTextureAPI Apply(UsdPrim prim) {
    UsdRiTextureAPI ret = new UsdRiTextureAPI(UsdCsPINVOKE.UsdRiTextureAPI_Apply(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetRiTextureGammaAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_GetRiTextureGammaAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRiTextureGammaAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureGammaAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiTextureGammaAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureGammaAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiTextureGammaAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureGammaAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetRiTextureSaturationAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_GetRiTextureSaturationAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateRiTextureSaturationAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureSaturationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiTextureSaturationAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureSaturationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiTextureSaturationAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiTextureAPI_CreateRiTextureSaturationAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdRiTextureAPI_schemaKind_get();
}

}
