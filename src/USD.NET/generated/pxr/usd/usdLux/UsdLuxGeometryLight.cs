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

public class UsdLuxGeometryLight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdLuxGeometryLight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdLuxGeometryLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdLuxGeometryLight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdLuxGeometryLight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdLuxGeometryLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdLuxGeometryLight__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdLuxGeometryLight() : this(UsdCsPINVOKE.new_UsdLuxGeometryLight__SWIG_1(), true) {
  }

  public UsdLuxGeometryLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdLuxGeometryLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public static UsdLuxGeometryLight Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdLuxGeometryLight ret = new UsdLuxGeometryLight(UsdCsPINVOKE.UsdLuxGeometryLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdLuxGeometryLight Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdLuxGeometryLight ret = new UsdLuxGeometryLight(UsdCsPINVOKE.UsdLuxGeometryLight_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdRelationship GetGeometryRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxGeometryLight_GetGeometryRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateGeometryRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdLuxGeometryLight_CreateGeometryRel(swigCPtr), true);
    return ret;
  }

  public static readonly UsdSchemaKind schemaKind = (UsdSchemaKind)UsdCsPINVOKE.UsdLuxGeometryLight_schemaKind_get();
}

}
