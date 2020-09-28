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

public class RprIpcServer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RprIpcServer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RprIpcServer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RprIpcServer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_RprIpcServer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class Listener : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Listener(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Listener obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Listener() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            USDIPCPINVOKE.delete_RprIpcServer_Listener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public virtual bool ProcessCommand(string command, SWIGTYPE_p_unsigned_char payload, uint pyaloadSize) {
      bool ret = USDIPCPINVOKE.RprIpcServer_Listener_ProcessCommand(swigCPtr, command, SWIGTYPE_p_unsigned_char.getCPtr(payload), pyaloadSize);
      if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
  }

  public RprIpcServer(RprIpcServer.Listener Listener) : this(USDIPCPINVOKE.new_RprIpcServer(RprIpcServer.Listener.getCPtr(Listener)), true) {
  }

  public RprIpcServer.Layer AddLayer(SdfPath layerPath) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.RprIpcServer_AddLayer(swigCPtr, SdfPath.getCPtr(layerPath));
    RprIpcServer.Layer ret = (cPtr == global::System.IntPtr.Zero) ? null : new RprIpcServer.Layer(cPtr, false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void OnLayerEdit(SdfPath layerPath, RprIpcServer.Layer layer) {
    USDIPCPINVOKE.RprIpcServer_OnLayerEdit(swigCPtr, SdfPath.getCPtr(layerPath), RprIpcServer.Layer.getCPtr(layer));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveLayer(SdfPath layerPath) {
    USDIPCPINVOKE.RprIpcServer_RemoveLayer(swigCPtr, SdfPath.getCPtr(layerPath));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public class Layer : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Layer(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Layer obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Layer() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            USDIPCPINVOKE.delete_RprIpcServer_Layer(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Layer() : this(USDIPCPINVOKE.new_RprIpcServer_Layer(), true) {
    }
  
    public UsdStageWeakPtr GetStage() {
      UsdStageWeakPtr ret = new UsdStageWeakPtr(USDIPCPINVOKE.RprIpcServer_Layer_GetStage(swigCPtr), true);
      return ret;
    }
  
  }

}

}