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

public class GfVec2f : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfVec2f(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec2f obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfVec2f() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_GfVec2f(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfVec2f() : this(USDIPCPINVOKE.new_GfVec2f__SWIG_0(), true) {
  }

  public GfVec2f(GfVec2f other) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_1(GfVec2f.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2f(float value) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_2(value), true) {
  }

  public GfVec2f(float s0, float s1) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_3(s0, s1), true) {
  }

  public GfVec2f(GfVec2d other) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_5(GfVec2d.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2f(GfVec2h other) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_6(GfVec2h.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2f(GfVec2i other) : this(USDIPCPINVOKE.new_GfVec2f__SWIG_7(GfVec2i.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfVec2f XAxis() {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_XAxis(), true);
    return ret;
  }

  public static GfVec2f YAxis() {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_YAxis(), true);
    return ret;
  }

  public static GfVec2f Axis(uint i) {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_Axis(i), true);
    return ret;
  }

  public GfVec2f Set(float s0, float s1) {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_Set(swigCPtr, s0, s1), false);
    return ret;
  }

  public GfVec2f GetProjection(GfVec2f v) {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_GetProjection(swigCPtr, GfVec2f.getCPtr(v)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec2f GetComplement(GfVec2f b) {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_GetComplement(swigCPtr, GfVec2f.getCPtr(b)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetLengthSq() {
    float ret = USDIPCPINVOKE.GfVec2f_GetLengthSq(swigCPtr);
    return ret;
  }

  public float GetLength() {
    float ret = USDIPCPINVOKE.GfVec2f_GetLength(swigCPtr);
    return ret;
  }

  public float Normalize(float eps) {
    float ret = USDIPCPINVOKE.GfVec2f_Normalize__SWIG_0(swigCPtr, eps);
    return ret;
  }

  public float Normalize() {
    float ret = USDIPCPINVOKE.GfVec2f_Normalize__SWIG_1(swigCPtr);
    return ret;
  }

  public GfVec2f GetNormalized(float eps) {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_GetNormalized__SWIG_0(swigCPtr, eps), true);
    return ret;
  }

  public GfVec2f GetNormalized() {
    GfVec2f ret = new GfVec2f(USDIPCPINVOKE.GfVec2f_GetNormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfVec2f lhs, GfVec2f rhs) {
    bool ret = USDIPCPINVOKE.GfVec2f_Equals(GfVec2f.getCPtr(lhs), GfVec2f.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = USDIPCPINVOKE.GfVec2f_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfVec2f lhs, GfVec2f rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfVec2f.Equals(lhs, rhs));
    }

    public static bool operator !=(GfVec2f lhs, GfVec2f rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfVec2f.Equals(this, rhs as GfVec2f);
    }
  
  protected float GetValue(int index) {
    float ret = USDIPCPINVOKE.GfVec2f_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, float value) {
    USDIPCPINVOKE.GfVec2f_SetValue(swigCPtr, index, value);
  }

  public float this[int index] {
    get { return GetValue(index); }
    set { SetValue(index, value); }
  }
  
  public static readonly uint dimension = USDIPCPINVOKE.GfVec2f_dimension_get();
}

}