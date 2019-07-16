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

public class UsdObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool operator==(UsdObject lhs, UsdObject rhs){
    // The Swig binding glew will re-enter this operator comparing to null, so 
    // that case must be handled explicitly to avoid an infinite loop. This is still
    // not great, since it crosses the C#/C++ barrier twice. A better approache might
    // be to return a simple value from C++ that can be compared in C#.
    bool lnull = lhs as object == null;
    bool rnull = rhs as object == null;
    return (lnull == rnull) && ((lnull && rnull) || UsdObject.Equals(lhs, rhs));
  }
  public static bool operator !=(UsdObject lhs, UsdObject rhs) {
      return !(lhs == rhs);
  }
  override public bool Equals(object rhs) {
    return UsdObject.Equals(this, rhs as UsdObject);
  }

  public static implicit operator bool(UsdObject obj) {
    return obj._IsValid();
  }

  public UsdObject() : this(UsdCsPINVOKE.new_UsdObject(), true) {
  }

  public bool IsValid() {
    bool ret = UsdCsPINVOKE.UsdObject_IsValid(swigCPtr);
    return ret;
  }

  public UsdStageWeakPtr GetStage() {
    UsdStageWeakPtr ret = new UsdStageWeakPtr(UsdCsPINVOKE.UsdObject_GetStage(swigCPtr), true);
    return ret;
  }

  public SdfPath GetPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.UsdObject_GetPath(swigCPtr), true);
    return ret;
  }

  public SdfPath GetPrimPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.UsdObject_GetPrimPath(swigCPtr), false);
    return ret;
  }

  public UsdPrim GetPrim() {
    UsdPrim ret = new UsdPrim(UsdCsPINVOKE.UsdObject_GetPrim(swigCPtr), true);
    return ret;
  }

  public TfToken GetName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdObject_GetName(swigCPtr), false);
    return ret;
  }

  public string GetDescription() {
    string ret = UsdCsPINVOKE.UsdObject_GetDescription(swigCPtr);
    return ret;
  }

  public bool SetMetadata(TfToken key, VtValue value) {
    bool ret = UsdCsPINVOKE.UsdObject_SetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearMetadata(TfToken key) {
    bool ret = UsdCsPINVOKE.UsdObject_ClearMetadata(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasMetadata(TfToken key) {
    bool ret = UsdCsPINVOKE.UsdObject_HasMetadata(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAuthoredMetadata(TfToken key) {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredMetadata(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value) {
    bool ret = UsdCsPINVOKE.UsdObject_SetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearMetadataByDictKey(TfToken key, TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_ClearMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasMetadataDictKey(TfToken key, TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAuthoredMetadataDictKey(TfToken key, TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdMetadataValueMap GetAllMetadata() {
    UsdMetadataValueMap ret = new UsdMetadataValueMap(UsdCsPINVOKE.UsdObject_GetAllMetadata(swigCPtr), true);
    return ret;
  }

  public UsdMetadataValueMap GetAllAuthoredMetadata() {
    UsdMetadataValueMap ret = new UsdMetadataValueMap(UsdCsPINVOKE.UsdObject_GetAllAuthoredMetadata(swigCPtr), true);
    return ret;
  }

  public bool IsHidden() {
    bool ret = UsdCsPINVOKE.UsdObject_IsHidden(swigCPtr);
    return ret;
  }

  public bool SetHidden(bool hidden) {
    bool ret = UsdCsPINVOKE.UsdObject_SetHidden(swigCPtr, hidden);
    return ret;
  }

  public bool ClearHidden() {
    bool ret = UsdCsPINVOKE.UsdObject_ClearHidden(swigCPtr);
    return ret;
  }

  public bool HasAuthoredHidden() {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredHidden(swigCPtr);
    return ret;
  }

  public VtDictionary GetCustomData() {
    VtDictionary ret = new VtDictionary(UsdCsPINVOKE.UsdObject_GetCustomData(swigCPtr), true);
    return ret;
  }

  public VtValue GetCustomDataByKey(TfToken keyPath) {
    VtValue ret = new VtValue(UsdCsPINVOKE.UsdObject_GetCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCustomData(VtDictionary customData) {
    UsdCsPINVOKE.UsdObject_SetCustomData(swigCPtr, VtDictionary.getCPtr(customData));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCustomDataByKey(TfToken keyPath, VtValue value) {
    UsdCsPINVOKE.UsdObject_SetCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearCustomData() {
    UsdCsPINVOKE.UsdObject_ClearCustomData(swigCPtr);
  }

  public void ClearCustomDataByKey(TfToken keyPath) {
    UsdCsPINVOKE.UsdObject_ClearCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasCustomData() {
    bool ret = UsdCsPINVOKE.UsdObject_HasCustomData(swigCPtr);
    return ret;
  }

  public bool HasCustomDataKey(TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasCustomDataKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAuthoredCustomData() {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredCustomData(swigCPtr);
    return ret;
  }

  public bool HasAuthoredCustomDataKey(TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredCustomDataKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VtDictionary GetAssetInfo() {
    VtDictionary ret = new VtDictionary(UsdCsPINVOKE.UsdObject_GetAssetInfo(swigCPtr), true);
    return ret;
  }

  public VtValue GetAssetInfoByKey(TfToken keyPath) {
    VtValue ret = new VtValue(UsdCsPINVOKE.UsdObject_GetAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAssetInfo(VtDictionary customData) {
    UsdCsPINVOKE.UsdObject_SetAssetInfo(swigCPtr, VtDictionary.getCPtr(customData));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAssetInfoByKey(TfToken keyPath, VtValue value) {
    UsdCsPINVOKE.UsdObject_SetAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearAssetInfo() {
    UsdCsPINVOKE.UsdObject_ClearAssetInfo(swigCPtr);
  }

  public void ClearAssetInfoByKey(TfToken keyPath) {
    UsdCsPINVOKE.UsdObject_ClearAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasAssetInfo() {
    bool ret = UsdCsPINVOKE.UsdObject_HasAssetInfo(swigCPtr);
    return ret;
  }

  public bool HasAssetInfoKey(TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasAssetInfoKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAuthoredAssetInfo() {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredAssetInfo(swigCPtr);
    return ret;
  }

  public bool HasAuthoredAssetInfoKey(TfToken keyPath) {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredAssetInfoKey(swigCPtr, TfToken.getCPtr(keyPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetDocumentation() {
    string ret = UsdCsPINVOKE.UsdObject_GetDocumentation(swigCPtr);
    return ret;
  }

  public bool SetDocumentation(string doc) {
    bool ret = UsdCsPINVOKE.UsdObject_SetDocumentation(swigCPtr, doc);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearDocumentation() {
    bool ret = UsdCsPINVOKE.UsdObject_ClearDocumentation(swigCPtr);
    return ret;
  }

  public bool HasAuthoredDocumentation() {
    bool ret = UsdCsPINVOKE.UsdObject_HasAuthoredDocumentation(swigCPtr);
    return ret;
  }

  public static char GetNamespaceDelimiter() {
    char ret = UsdCsPINVOKE.UsdObject_GetNamespaceDelimiter();
    return ret;
  }

  public static bool Equals(UsdObject lhs, UsdObject rhs) {
    bool ret = UsdCsPINVOKE.UsdObject_Equals(UsdObject.getCPtr(lhs), UsdObject.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool _IsValid() {
    bool ret = UsdCsPINVOKE.UsdObject__IsValid(swigCPtr);
    return ret;
  }

  public VtValue GetMetadata(TfToken key) {
    VtValue ret = new VtValue(UsdCsPINVOKE.UsdObject_GetMetadata(swigCPtr, TfToken.getCPtr(key)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VtValue GetMetadataByDictKey(TfToken key, TfToken keyPath) {
    VtValue ret = new VtValue(UsdCsPINVOKE.UsdObject_GetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}