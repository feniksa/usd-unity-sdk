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

public class UsdRiStatementsAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdRiStatementsAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiStatementsAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiStatementsAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdRiStatementsAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdRiStatementsAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdRiStatementsAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiStatementsAPI__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdRiStatementsAPI() : this(UsdCsPINVOKE.new_UsdRiStatementsAPI__SWIG_1(), true) {
  }

  public UsdRiStatementsAPI(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiStatementsAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdRiStatementsAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiStatementsAPI ret = new UsdRiStatementsAPI(UsdCsPINVOKE.UsdRiStatementsAPI_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdRiStatementsAPI Apply(UsdPrim prim) {
    UsdRiStatementsAPI ret = new UsdRiStatementsAPI(UsdCsPINVOKE.UsdRiStatementsAPI_Apply(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiAttribute(TfToken name, string riType, string nameSpace) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), riType, nameSpace), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiAttribute(TfToken name, string riType) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name), riType), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiAttribute(TfToken name, TfType tfType, string nameSpace) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_2(swigCPtr, TfToken.getCPtr(name), TfType.getCPtr(tfType), nameSpace), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateRiAttribute(TfToken name, TfType tfType) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_CreateRiAttribute__SWIG_3(swigCPtr, TfToken.getCPtr(name), TfType.getCPtr(tfType)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetRiAttribute(TfToken name, string nameSpace) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), nameSpace), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetRiAttribute(TfToken name) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetRiAttributes(string nameSpace) {
    UsdPropertyVector ret = new UsdPropertyVector(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttributes__SWIG_0(swigCPtr, nameSpace), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetRiAttributes() {
    UsdPropertyVector ret = new UsdPropertyVector(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttributes__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static TfToken GetRiAttributeName(UsdProperty prop) {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttributeName(UsdProperty.getCPtr(prop)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TfToken GetRiAttributeNameSpace(UsdProperty prop) {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdRiStatementsAPI_GetRiAttributeNameSpace(UsdProperty.getCPtr(prop)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsRiAttribute(UsdProperty prop) {
    bool ret = UsdCsPINVOKE.UsdRiStatementsAPI_IsRiAttribute(UsdProperty.getCPtr(prop));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string MakeRiAttributePropertyName(string attrName) {
    string ret = UsdCsPINVOKE.UsdRiStatementsAPI_MakeRiAttributePropertyName(attrName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCoordinateSystem(string coordSysName) {
    UsdCsPINVOKE.UsdRiStatementsAPI_SetCoordinateSystem(swigCPtr, coordSysName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetCoordinateSystem() {
    string ret = UsdCsPINVOKE.UsdRiStatementsAPI_GetCoordinateSystem(swigCPtr);
    return ret;
  }

  public bool HasCoordinateSystem() {
    bool ret = UsdCsPINVOKE.UsdRiStatementsAPI_HasCoordinateSystem(swigCPtr);
    return ret;
  }

  public void SetScopedCoordinateSystem(string coordSysName) {
    UsdCsPINVOKE.UsdRiStatementsAPI_SetScopedCoordinateSystem(swigCPtr, coordSysName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetScopedCoordinateSystem() {
    string ret = UsdCsPINVOKE.UsdRiStatementsAPI_GetScopedCoordinateSystem(swigCPtr);
    return ret;
  }

  public bool HasScopedCoordinateSystem() {
    bool ret = UsdCsPINVOKE.UsdRiStatementsAPI_HasScopedCoordinateSystem(swigCPtr);
    return ret;
  }

  public bool GetModelCoordinateSystems(SdfPathVector targets) {
    bool ret = UsdCsPINVOKE.UsdRiStatementsAPI_GetModelCoordinateSystems(swigCPtr, SdfPathVector.getCPtr(targets));
    return ret;
  }

  public bool GetModelScopedCoordinateSystems(SdfPathVector targets) {
    bool ret = UsdCsPINVOKE.UsdRiStatementsAPI_GetModelScopedCoordinateSystems(swigCPtr, SdfPathVector.getCPtr(targets));
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdRiStatementsAPI_schemaKind_get();
}

}
