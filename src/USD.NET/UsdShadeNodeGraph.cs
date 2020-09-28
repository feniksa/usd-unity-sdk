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

public class UsdShadeNodeGraph : UsdTyped {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdShadeNodeGraph(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.UsdShadeNodeGraph_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeNodeGraph obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdShadeNodeGraph() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdShadeNodeGraph(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdShadeNodeGraph(UsdPrim prim) : this(USDIPCPINVOKE.new_UsdShadeNodeGraph__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeNodeGraph() : this(USDIPCPINVOKE.new_UsdShadeNodeGraph__SWIG_1(), true) {
  }

  public UsdShadeNodeGraph(UsdSchemaBase schemaObj) : this(USDIPCPINVOKE.new_UsdShadeNodeGraph__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(USDIPCPINVOKE.UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdShadeNodeGraph Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdShadeNodeGraph ret = new UsdShadeNodeGraph(USDIPCPINVOKE.UsdShadeNodeGraph_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdShadeNodeGraph Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdShadeNodeGraph ret = new UsdShadeNodeGraph(USDIPCPINVOKE.UsdShadeNodeGraph_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeNodeGraph(UsdShadeConnectableAPI connectable) : this(USDIPCPINVOKE.new_UsdShadeNodeGraph__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdShadeConnectableAPI ConnectableAPI() {
    UsdShadeConnectableAPI ret = new UsdShadeConnectableAPI(USDIPCPINVOKE.UsdShadeNodeGraph_ConnectableAPI(swigCPtr), true);
    return ret;
  }

  public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeOutput ret = new UsdShadeOutput(USDIPCPINVOKE.UsdShadeNodeGraph_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeOutput GetOutput(TfToken name) {
    UsdShadeOutput ret = new UsdShadeOutput(USDIPCPINVOKE.UsdShadeNodeGraph_GetOutput(swigCPtr, TfToken.getCPtr(name)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_UsdShadeOutput_t GetOutputs() {
    SWIGTYPE_p_std__vectorT_UsdShadeOutput_t ret = new SWIGTYPE_p_std__vectorT_UsdShadeOutput_t(USDIPCPINVOKE.UsdShadeNodeGraph_GetOutputs(swigCPtr), true);
    return ret;
  }

  public UsdShadeShader ComputeOutputSource(TfToken outputName, TfToken sourceName, SWIGTYPE_p_UsdShadeAttributeType sourceType) {
    UsdShadeShader ret = new UsdShadeShader(USDIPCPINVOKE.UsdShadeNodeGraph_ComputeOutputSource(swigCPtr, TfToken.getCPtr(outputName), TfToken.getCPtr(sourceName), SWIGTYPE_p_UsdShadeAttributeType.getCPtr(sourceType)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName) {
    UsdShadeInput ret = new UsdShadeInput(USDIPCPINVOKE.UsdShadeNodeGraph_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdShadeInput GetInput(TfToken name) {
    UsdShadeInput ret = new UsdShadeInput(USDIPCPINVOKE.UsdShadeNodeGraph_GetInput(swigCPtr, TfToken.getCPtr(name)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_UsdShadeInput_t GetInputs() {
    SWIGTYPE_p_std__vectorT_UsdShadeInput_t ret = new SWIGTYPE_p_std__vectorT_UsdShadeInput_t(USDIPCPINVOKE.UsdShadeNodeGraph_GetInputs(swigCPtr), true);
    return ret;
  }

  public class NodeGraphHasher : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal NodeGraphHasher(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NodeGraphHasher obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~NodeGraphHasher() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            USDIPCPINVOKE.delete_UsdShadeNodeGraph_NodeGraphHasher(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public NodeGraphHasher() : this(USDIPCPINVOKE.new_UsdShadeNodeGraph_NodeGraphHasher(), true) {
    }
  
  }

  public class NodeGraphEqualFn : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal NodeGraphEqualFn(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NodeGraphEqualFn obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~NodeGraphEqualFn() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            USDIPCPINVOKE.delete_UsdShadeNodeGraph_NodeGraphEqualFn(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public NodeGraphEqualFn() : this(USDIPCPINVOKE.new_UsdShadeNodeGraph_NodeGraphEqualFn(), true) {
    }
  
  }

  public SWIGTYPE_p_std__vectorT_UsdShadeInput_t GetInterfaceInputs() {
    SWIGTYPE_p_std__vectorT_UsdShadeInput_t ret = new SWIGTYPE_p_std__vectorT_UsdShadeInput_t(USDIPCPINVOKE.UsdShadeNodeGraph_GetInterfaceInputs(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t ComputeInterfaceInputConsumersMap(bool computeTransitiveConsumers) {
    SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t ret = new SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t(USDIPCPINVOKE.UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_0(swigCPtr, computeTransitiveConsumers), true);
    return ret;
  }

  public SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t ComputeInterfaceInputConsumersMap() {
    SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t ret = new SWIGTYPE_p_std__unordered_mapT_UsdShadeInput_std__vectorT_UsdShadeInput_t_UsdShadeInput__Hash_t(USDIPCPINVOKE.UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_1(swigCPtr), true);
    return ret;
  }

}

}