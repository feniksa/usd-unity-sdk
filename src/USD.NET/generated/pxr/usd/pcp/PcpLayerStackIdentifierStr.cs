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

public class PcpLayerStackIdentifierStr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PcpLayerStackIdentifierStr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpLayerStackIdentifierStr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpLayerStackIdentifierStr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_PcpLayerStackIdentifierStr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PcpLayerStackIdentifierStr(string rootLayerId, string sessionLayerId, SWIGTYPE_p_ArResolverContext resolverContext) : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_0(rootLayerId, sessionLayerId, SWIGTYPE_p_ArResolverContext.getCPtr(resolverContext)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpLayerStackIdentifierStr(string rootLayerId, string sessionLayerId) : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_1(rootLayerId, sessionLayerId), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpLayerStackIdentifierStr(string rootLayerId) : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_2(rootLayerId), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpLayerStackIdentifierStr() : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_3(), true) {
  }

  public PcpLayerStackIdentifierStr(PcpLayerStackIdentifier lsid) : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr__SWIG_4(PcpLayerStackIdentifier.getCPtr(lsid)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public class Hash : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Hash(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Hash obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Hash() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            UsdCsPINVOKE.delete_PcpLayerStackIdentifierStr_Hash(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Hash() : this(UsdCsPINVOKE.new_PcpLayerStackIdentifierStr_Hash(), true) {
    }
  
  }

  public uint GetHash() {
    uint ret = UsdCsPINVOKE.PcpLayerStackIdentifierStr_GetHash(swigCPtr);
    return ret;
  }

  public string rootLayerId {
    set {
      UsdCsPINVOKE.PcpLayerStackIdentifierStr_rootLayerId_set(swigCPtr, value);
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = UsdCsPINVOKE.PcpLayerStackIdentifierStr_rootLayerId_get(swigCPtr);
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string sessionLayerId {
    set {
      UsdCsPINVOKE.PcpLayerStackIdentifierStr_sessionLayerId_set(swigCPtr, value);
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = UsdCsPINVOKE.PcpLayerStackIdentifierStr_sessionLayerId_get(swigCPtr);
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_ArResolverContext pathResolverContext {
    set {
      UsdCsPINVOKE.PcpLayerStackIdentifierStr_pathResolverContext_set(swigCPtr, SWIGTYPE_p_ArResolverContext.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStackIdentifierStr_pathResolverContext_get(swigCPtr);
      SWIGTYPE_p_ArResolverContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ArResolverContext(cPtr, false);
      return ret;
    } 
  }

}

}
