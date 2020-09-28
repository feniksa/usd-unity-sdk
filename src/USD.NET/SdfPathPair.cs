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

public class SdfPathPair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfPathPair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfPathPair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfPathPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_SdfPathPair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfPathPair() : this(USDIPCPINVOKE.new_SdfPathPair__SWIG_0(), true) {
  }

  public SdfPathPair(SdfPath t, SdfPath u) : this(USDIPCPINVOKE.new_SdfPathPair__SWIG_1(SdfPath.getCPtr(t), SdfPath.getCPtr(u)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPathPair(SdfPathPair p) : this(USDIPCPINVOKE.new_SdfPathPair__SWIG_2(SdfPathPair.getCPtr(p)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPath first {
    set {
      USDIPCPINVOKE.SdfPathPair_first_set(swigCPtr, SdfPath.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = USDIPCPINVOKE.SdfPathPair_first_get(swigCPtr);
      SdfPath ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPath(cPtr, false);
      return ret;
    } 
  }

  public SdfPath second {
    set {
      USDIPCPINVOKE.SdfPathPair_second_set(swigCPtr, SdfPath.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = USDIPCPINVOKE.SdfPathPair_second_get(swigCPtr);
      SdfPath ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPath(cPtr, false);
      return ret;
    } 
  }

}

}
