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

public class UsdShadeOutput : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdShadeOutput(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeOutput obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdShadeOutput() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdShadeOutput(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdShadeOutput() : this(USDIPCPINVOKE.new_UsdShadeOutput__SWIG_0(), true) {
  }

  public TfToken GetFullName() {
    TfToken ret = new TfToken(USDIPCPINVOKE.UsdShadeOutput_GetFullName(swigCPtr), false);
    return ret;
  }

  public TfToken GetBaseName() {
    TfToken ret = new TfToken(USDIPCPINVOKE.UsdShadeOutput_GetBaseName(swigCPtr), true);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdShadeOutput_GetPrim(swigCPtr), true);
    return ret;
  }

  public SdfValueTypeName GetTypeName() {
    SdfValueTypeName ret = new SdfValueTypeName(USDIPCPINVOKE.UsdShadeOutput_GetTypeName(swigCPtr), true);
    return ret;
  }

  public bool Set(VtValue value, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_Set__SWIG_0(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Set(VtValue value) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_Set__SWIG_1(swigCPtr, VtValue.getCPtr(value));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetRenderType(TfToken renderType) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_SetRenderType(swigCPtr, TfToken.getCPtr(renderType));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TfToken GetRenderType() {
    TfToken ret = new TfToken(USDIPCPINVOKE.UsdShadeOutput_GetRenderType(swigCPtr), true);
    return ret;
  }

  public bool HasRenderType() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_HasRenderType(swigCPtr);
    return ret;
  }

  public UsdShadeOutput(UsdAttribute attr) : this(USDIPCPINVOKE.new_UsdShadeOutput__SWIG_1(UsdAttribute.getCPtr(attr)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool IsOutput(UsdAttribute attr) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_IsOutput(UsdAttribute.getCPtr(attr));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetAttr() {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdShadeOutput_GetAttr(swigCPtr), true);
    return ret;
  }

  public UsdProperty GetProperty() {
    UsdProperty ret = new UsdProperty(USDIPCPINVOKE.UsdShadeOutput_GetProperty(swigCPtr), false);
    return ret;
  }

  public UsdRelationship GetRel() {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdShadeOutput_GetRel(swigCPtr), true);
    return ret;
  }

  public bool IsTerminal() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_IsTerminal(swigCPtr);
    return ret;
  }

  public bool IsDefined() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_IsDefined(swigCPtr);
    return ret;
  }

  public bool CanConnect(UsdAttribute source) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_CanConnect__SWIG_0(swigCPtr, UsdAttribute.getCPtr(source));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanConnect(UsdShadeInput sourceInput) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_CanConnect__SWIG_1(swigCPtr, UsdShadeInput.getCPtr(sourceInput));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanConnect(UsdShadeOutput sourceOutput) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_CanConnect__SWIG_2(swigCPtr, UsdShadeOutput.getCPtr(sourceOutput));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType, SdfValueTypeName typeName) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_0(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType, SdfValueTypeName.getCPtr(typeName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName, UsdShadeAttributeType sourceType) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_1(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), (int)sourceType);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(UsdShadeConnectableAPI source, TfToken sourceName) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_2(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(SdfPath sourcePath) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_3(swigCPtr, SdfPath.getCPtr(sourcePath));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(UsdShadeInput sourceInput) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_4(swigCPtr, UsdShadeInput.getCPtr(sourceInput));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ConnectToSource(UsdShadeOutput sourceOutput) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ConnectToSource__SWIG_5(swigCPtr, UsdShadeOutput.getCPtr(sourceOutput));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetConnectedSource(UsdShadeConnectableAPI source, TfToken sourceName, out UsdShadeAttributeType sourceType) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_GetConnectedSource(swigCPtr, UsdShadeConnectableAPI.getCPtr(source), TfToken.getCPtr(sourceName), out sourceType);
    return ret;
  }

  public bool GetRawConnectedSourcePaths(SdfPathVector sourcePaths) {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_GetRawConnectedSourcePaths(swigCPtr, SdfPathVector.getCPtr(sourcePaths));
    return ret;
  }

  public bool HasConnectedSource() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_HasConnectedSource(swigCPtr);
    return ret;
  }

  public bool IsSourceConnectionFromBaseMaterial() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_IsSourceConnectionFromBaseMaterial(swigCPtr);
    return ret;
  }

  public bool DisconnectSource() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_DisconnectSource(swigCPtr);
    return ret;
  }

  public bool ClearSource() {
    bool ret = USDIPCPINVOKE.UsdShadeOutput_ClearSource(swigCPtr);
    return ret;
  }

}

}