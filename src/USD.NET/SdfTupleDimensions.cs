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

public class SdfTupleDimensions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfTupleDimensions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfTupleDimensions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfTupleDimensions() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_SdfTupleDimensions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfTupleDimensions() : this(USDIPCPINVOKE.new_SdfTupleDimensions__SWIG_0(), true) {
  }

  public SdfTupleDimensions(uint m) : this(USDIPCPINVOKE.new_SdfTupleDimensions__SWIG_1(m), true) {
  }

  public SdfTupleDimensions(uint m, uint n) : this(USDIPCPINVOKE.new_SdfTupleDimensions__SWIG_2(m, n), true) {
  }

  public SdfTupleDimensions(SWIGTYPE_p_a_2__size_t s) : this(USDIPCPINVOKE.new_SdfTupleDimensions__SWIG_3(SWIGTYPE_p_a_2__size_t.getCPtr(s)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_size_t d {
    set {
      USDIPCPINVOKE.SdfTupleDimensions_d_set(swigCPtr, SWIGTYPE_p_size_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = USDIPCPINVOKE.SdfTupleDimensions_d_get(swigCPtr);
      SWIGTYPE_p_size_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_size_t(cPtr, false);
      return ret;
    } 
  }

  public uint size {
    set {
      USDIPCPINVOKE.SdfTupleDimensions_size_set(swigCPtr, value);
    } 
    get {
      uint ret = USDIPCPINVOKE.SdfTupleDimensions_size_get(swigCPtr);
      return ret;
    } 
  }

}

}