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

public class JsParseError : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsParseError(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsParseError obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsParseError() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_JsParseError(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public JsParseError() : this(USDIPCPINVOKE.new_JsParseError(), true) {
  }

  public uint line {
    set {
      USDIPCPINVOKE.JsParseError_line_set(swigCPtr, value);
    } 
    get {
      uint ret = USDIPCPINVOKE.JsParseError_line_get(swigCPtr);
      return ret;
    } 
  }

  public uint column {
    set {
      USDIPCPINVOKE.JsParseError_column_set(swigCPtr, value);
    } 
    get {
      uint ret = USDIPCPINVOKE.JsParseError_column_get(swigCPtr);
      return ret;
    } 
  }

  public string reason {
    set {
      USDIPCPINVOKE.JsParseError_reason_set(swigCPtr, value);
      if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = USDIPCPINVOKE.JsParseError_reason_get(swigCPtr);
      if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}