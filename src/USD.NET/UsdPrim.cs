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

public class UsdPrim : UsdObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdPrim(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdPrim_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdPrim obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdPrim() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdPrim(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdPrim() : this(USDIPCPINVOKE.new_UsdPrim(), true) {
  }

  public SWIGTYPE_p_SdfPrimSpecHandle GetPrimDefinition() {
    SWIGTYPE_p_SdfPrimSpecHandle ret = new SWIGTYPE_p_SdfPrimSpecHandle(USDIPCPINVOKE.UsdPrim_GetPrimDefinition(swigCPtr), true);
    return ret;
  }

  public SdfSpecifier GetSpecifier() {
    SdfSpecifier ret = (SdfSpecifier)USDIPCPINVOKE.UsdPrim_GetSpecifier(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_SdfPrimSpecHandleVector GetPrimStack() {
    SWIGTYPE_p_SdfPrimSpecHandleVector ret = new SWIGTYPE_p_SdfPrimSpecHandleVector(USDIPCPINVOKE.UsdPrim_GetPrimStack(swigCPtr), true);
    return ret;
  }

  public bool SetSpecifier(SdfSpecifier specifier) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetSpecifier(swigCPtr, (int)specifier);
    return ret;
  }

  public TfToken GetTypeName() {
    TfToken ret = new TfToken(USDIPCPINVOKE.UsdPrim_GetTypeName(swigCPtr), false);
    return ret;
  }

  public bool SetTypeName(TfToken typeName) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetTypeName(swigCPtr, TfToken.getCPtr(typeName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearTypeName() {
    bool ret = USDIPCPINVOKE.UsdPrim_ClearTypeName(swigCPtr);
    return ret;
  }

  public bool HasAuthoredTypeName() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredTypeName(swigCPtr);
    return ret;
  }

  public bool IsActive() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsActive(swigCPtr);
    return ret;
  }

  public bool SetActive(bool active) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetActive(swigCPtr, active);
    return ret;
  }

  public bool ClearActive() {
    bool ret = USDIPCPINVOKE.UsdPrim_ClearActive(swigCPtr);
    return ret;
  }

  public bool HasAuthoredActive() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredActive(swigCPtr);
    return ret;
  }

  public bool IsLoaded() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsLoaded(swigCPtr);
    return ret;
  }

  public bool IsModel() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsModel(swigCPtr);
    return ret;
  }

  public bool IsGroup() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsGroup(swigCPtr);
    return ret;
  }

  public bool IsAbstract() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsAbstract(swigCPtr);
    return ret;
  }

  public bool IsDefined() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsDefined(swigCPtr);
    return ret;
  }

  public bool HasDefiningSpecifier() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasDefiningSpecifier(swigCPtr);
    return ret;
  }

  public TfTokenVector GetAppliedSchemas() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetAppliedSchemas(swigCPtr), true);
    return ret;
  }

  public TfTokenVector GetPropertyNames(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetPropertyNames__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TfTokenVector GetPropertyNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetPropertyNames__SWIG_1(swigCPtr), true);
    return ret;
  }

  public TfTokenVector GetAuthoredPropertyNames(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetAuthoredPropertyNames__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TfTokenVector GetAuthoredPropertyNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetAuthoredPropertyNames__SWIG_1(swigCPtr), true);
    return ret;
  }

  public UsdPropertyVector GetProperties(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetProperties__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetProperties() {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetProperties__SWIG_1(swigCPtr), true);
    return ret;
  }

  public UsdPropertyVector GetAuthoredProperties(SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t predicate) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetAuthoredProperties__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_bool_fTfToken_const_RF_t.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetAuthoredProperties() {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetAuthoredProperties__SWIG_1(swigCPtr), true);
    return ret;
  }

  public UsdPropertyVector GetPropertiesInNamespace(StdStringVector namespaces) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetPropertiesInNamespace__SWIG_0(swigCPtr, StdStringVector.getCPtr(namespaces)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetPropertiesInNamespace(string namespaces) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetPropertiesInNamespace__SWIG_1(swigCPtr, namespaces), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetAuthoredPropertiesInNamespace(StdStringVector namespaces) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_0(swigCPtr, StdStringVector.getCPtr(namespaces)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPropertyVector GetAuthoredPropertiesInNamespace(string namespaces) {
    UsdPropertyVector ret = new UsdPropertyVector(USDIPCPINVOKE.UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_1(swigCPtr, namespaces), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TfTokenVector GetPropertyOrder() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdPrim_GetPropertyOrder(swigCPtr), true);
    return ret;
  }

  public void SetPropertyOrder(TfTokenVector order) {
    USDIPCPINVOKE.UsdPrim_SetPropertyOrder(swigCPtr, TfTokenVector.getCPtr(order));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool RemoveProperty(TfToken propName) {
    bool ret = USDIPCPINVOKE.UsdPrim_RemoveProperty(swigCPtr, TfToken.getCPtr(propName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdProperty GetProperty(TfToken propName) {
    UsdProperty ret = new UsdProperty(USDIPCPINVOKE.UsdPrim_GetProperty(swigCPtr, TfToken.getCPtr(propName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasProperty(TfToken propName) {
    bool ret = USDIPCPINVOKE.UsdPrim_HasProperty(swigCPtr, TfToken.getCPtr(propName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPrim GetChild(TfToken name) {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetChild(swigCPtr, TfToken.getCPtr(name)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPrimSiblingRange GetChildren() {
    UsdPrimSiblingRange ret = new UsdPrimSiblingRange(USDIPCPINVOKE.UsdPrim_GetChildren(swigCPtr), true);
    return ret;
  }

  public UsdPrimSiblingRange GetAllChildren() {
    UsdPrimSiblingRange ret = new UsdPrimSiblingRange(USDIPCPINVOKE.UsdPrim_GetAllChildren(swigCPtr), true);
    return ret;
  }

  public UsdPrimSiblingRange GetFilteredChildren(Usd_PrimFlagsPredicate predicate) {
    UsdPrimSiblingRange ret = new UsdPrimSiblingRange(USDIPCPINVOKE.UsdPrim_GetFilteredChildren(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPrimSubtreeRange GetDescendants() {
    UsdPrimSubtreeRange ret = new UsdPrimSubtreeRange(USDIPCPINVOKE.UsdPrim_GetDescendants(swigCPtr), true);
    return ret;
  }

  public UsdPrimSubtreeRange GetAllDescendants() {
    UsdPrimSubtreeRange ret = new UsdPrimSubtreeRange(USDIPCPINVOKE.UsdPrim_GetAllDescendants(swigCPtr), true);
    return ret;
  }

  public UsdPrimSubtreeRange GetFilteredDescendants(Usd_PrimFlagsPredicate predicate) {
    UsdPrimSubtreeRange ret = new UsdPrimSubtreeRange(USDIPCPINVOKE.UsdPrim_GetFilteredDescendants(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdPrim GetParent() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetParent(swigCPtr), true);
    return ret;
  }

  public UsdPrim GetNextSibling() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetNextSibling(swigCPtr), true);
    return ret;
  }

  public UsdPrim GetFilteredNextSibling(Usd_PrimFlagsPredicate predicate) {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetFilteredNextSibling(swigCPtr, Usd_PrimFlagsPredicate.getCPtr(predicate)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsPseudoRoot() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsPseudoRoot(swigCPtr);
    return ret;
  }

  public UsdVariantSets GetVariantSets() {
    UsdVariantSets ret = new UsdVariantSets(USDIPCPINVOKE.UsdPrim_GetVariantSets(swigCPtr), true);
    return ret;
  }

  public UsdVariantSet GetVariantSet(string variantSetName) {
    UsdVariantSet ret = new UsdVariantSet(USDIPCPINVOKE.UsdPrim_GetVariantSet(swigCPtr, variantSetName), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasVariantSets() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasVariantSets(swigCPtr);
    return ret;
  }

  public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, bool custom, SdfVariability variability) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_0(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), custom, (int)variability), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, bool custom) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_1(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), custom), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName, SdfVariability variability) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_2(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName), (int)variability), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(TfToken name, SdfValueTypeName typeName) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_3(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, bool custom, SdfVariability variability) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_4(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), custom, (int)variability), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, bool custom) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_5(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), custom), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName, SdfVariability variability) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_6(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName), (int)variability), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateAttribute(StdStringVector nameElts, SdfValueTypeName typeName) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_CreateAttribute__SWIG_7(swigCPtr, StdStringVector.getCPtr(nameElts), SdfValueTypeName.getCPtr(typeName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttributeVector GetAttributes() {
    UsdAttributeVector ret = new UsdAttributeVector(USDIPCPINVOKE.UsdPrim_GetAttributes(swigCPtr), true);
    return ret;
  }

  public UsdAttributeVector GetAuthoredAttributes() {
    UsdAttributeVector ret = new UsdAttributeVector(USDIPCPINVOKE.UsdPrim_GetAuthoredAttributes(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetAttribute(TfToken attrName) {
    UsdAttribute ret = new UsdAttribute(USDIPCPINVOKE.UsdPrim_GetAttribute(swigCPtr, TfToken.getCPtr(attrName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAttribute(TfToken attrName) {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAttribute(swigCPtr, TfToken.getCPtr(attrName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationship CreateRelationship(TfToken relName, bool custom) {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdPrim_CreateRelationship__SWIG_0(swigCPtr, TfToken.getCPtr(relName), custom), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationship CreateRelationship(TfToken relName) {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdPrim_CreateRelationship__SWIG_1(swigCPtr, TfToken.getCPtr(relName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationship CreateRelationship(StdStringVector nameElts, bool custom) {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdPrim_CreateRelationship__SWIG_2(swigCPtr, StdStringVector.getCPtr(nameElts), custom), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationship CreateRelationship(StdStringVector nameElts) {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdPrim_CreateRelationship__SWIG_3(swigCPtr, StdStringVector.getCPtr(nameElts)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationshipVector GetRelationships() {
    UsdRelationshipVector ret = new UsdRelationshipVector(USDIPCPINVOKE.UsdPrim_GetRelationships(swigCPtr), true);
    return ret;
  }

  public UsdRelationshipVector GetAuthoredRelationships() {
    UsdRelationshipVector ret = new UsdRelationshipVector(USDIPCPINVOKE.UsdPrim_GetAuthoredRelationships(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetRelationship(TfToken relName) {
    UsdRelationship ret = new UsdRelationship(USDIPCPINVOKE.UsdPrim_GetRelationship(swigCPtr, TfToken.getCPtr(relName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasRelationship(TfToken relName) {
    bool ret = USDIPCPINVOKE.UsdPrim_HasRelationship(swigCPtr, TfToken.getCPtr(relName));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearPayload() {
    bool ret = USDIPCPINVOKE.UsdPrim_ClearPayload(swigCPtr);
    return ret;
  }

  public bool HasPayload() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasPayload(swigCPtr);
    return ret;
  }

  public bool SetPayload(SdfPayload payload) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetPayload__SWIG_0(swigCPtr, SdfPayload.getCPtr(payload));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetPayload(string assetPath, SdfPath primPath) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetPayload__SWIG_1(swigCPtr, assetPath, SdfPath.getCPtr(primPath));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetPayload(SdfLayerHandle layer, SdfPath primPath) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetPayload__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(primPath));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Load(UsdLoadPolicy policy) {
    USDIPCPINVOKE.UsdPrim_Load__SWIG_0(swigCPtr, (int)policy);
  }

  public void Load() {
    USDIPCPINVOKE.UsdPrim_Load__SWIG_1(swigCPtr);
  }

  public void Unload() {
    USDIPCPINVOKE.UsdPrim_Unload(swigCPtr);
  }

  public UsdReferences GetReferences() {
    UsdReferences ret = new UsdReferences(USDIPCPINVOKE.UsdPrim_GetReferences(swigCPtr), true);
    return ret;
  }

  public bool HasAuthoredReferences() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredReferences(swigCPtr);
    return ret;
  }

  public UsdInherits GetInherits() {
    UsdInherits ret = new UsdInherits(USDIPCPINVOKE.UsdPrim_GetInherits(swigCPtr), true);
    return ret;
  }

  public bool HasAuthoredInherits() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredInherits(swigCPtr);
    return ret;
  }

  public UsdSpecializes GetSpecializes() {
    UsdSpecializes ret = new UsdSpecializes(USDIPCPINVOKE.UsdPrim_GetSpecializes(swigCPtr), true);
    return ret;
  }

  public bool HasAuthoredSpecializes() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredSpecializes(swigCPtr);
    return ret;
  }

  public bool IsInstanceable() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsInstanceable(swigCPtr);
    return ret;
  }

  public bool SetInstanceable(bool instanceable) {
    bool ret = USDIPCPINVOKE.UsdPrim_SetInstanceable(swigCPtr, instanceable);
    return ret;
  }

  public bool ClearInstanceable() {
    bool ret = USDIPCPINVOKE.UsdPrim_ClearInstanceable(swigCPtr);
    return ret;
  }

  public bool HasAuthoredInstanceable() {
    bool ret = USDIPCPINVOKE.UsdPrim_HasAuthoredInstanceable(swigCPtr);
    return ret;
  }

  public bool IsInstance() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsInstance(swigCPtr);
    return ret;
  }

  public bool IsInstanceProxy() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsInstanceProxy(swigCPtr);
    return ret;
  }

  public bool IsMaster() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsMaster(swigCPtr);
    return ret;
  }

  public bool IsInMaster() {
    bool ret = USDIPCPINVOKE.UsdPrim_IsInMaster(swigCPtr);
    return ret;
  }

  public UsdPrim GetMaster() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetMaster(swigCPtr), true);
    return ret;
  }

  public UsdPrim GetPrimInMaster() {
    UsdPrim ret = new UsdPrim(USDIPCPINVOKE.UsdPrim_GetPrimInMaster(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_PcpPrimIndex GetPrimIndex() {
    SWIGTYPE_p_PcpPrimIndex ret = new SWIGTYPE_p_PcpPrimIndex(USDIPCPINVOKE.UsdPrim_GetPrimIndex(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_PcpPrimIndex ComputeExpandedPrimIndex() {
    SWIGTYPE_p_PcpPrimIndex ret = new SWIGTYPE_p_PcpPrimIndex(USDIPCPINVOKE.UsdPrim_ComputeExpandedPrimIndex(swigCPtr), true);
    return ret;
  }

  public bool GetAttributeValue(TfToken attrName, VtValue valueOut, UsdTimeCode time) {
    bool ret = USDIPCPINVOKE.UsdPrim_GetAttributeValue(swigCPtr, TfToken.getCPtr(attrName), VtValue.getCPtr(valueOut), UsdTimeCode.getCPtr(time));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
