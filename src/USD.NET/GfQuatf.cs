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

public class GfQuatf : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfQuatf(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfQuatf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfQuatf() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_GfQuatf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfQuatf() : this(USDIPCPINVOKE.new_GfQuatf__SWIG_0(), true) {
  }

  public GfQuatf(float realVal) : this(USDIPCPINVOKE.new_GfQuatf__SWIG_1(realVal), true) {
  }

  public GfQuatf(float real, float i, float j, float k) : this(USDIPCPINVOKE.new_GfQuatf__SWIG_2(real, i, j, k), true) {
  }

  public GfQuatf(float real, GfVec3f imaginary) : this(USDIPCPINVOKE.new_GfQuatf__SWIG_3(real, GfVec3f.getCPtr(imaginary)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfQuatf(GfQuatd other) : this(USDIPCPINVOKE.new_GfQuatf__SWIG_4(GfQuatd.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfQuatf(GfQuath other) : this(USDIPCPINVOKE.new_GfQuatf__SWIG_5(GfQuath.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfQuatf GetIdentity() {
    GfQuatf ret = new GfQuatf(USDIPCPINVOKE.GfQuatf_GetIdentity(), true);
    return ret;
  }

  public float GetReal() {
    float ret = USDIPCPINVOKE.GfQuatf_GetReal(swigCPtr);
    return ret;
  }

  public void SetReal(float real) {
    USDIPCPINVOKE.GfQuatf_SetReal(swigCPtr, real);
  }

  public GfVec3f GetImaginary() {
    GfVec3f ret = new GfVec3f(USDIPCPINVOKE.GfQuatf_GetImaginary(swigCPtr), false);
    return ret;
  }

  public void SetImaginary(GfVec3f imaginary) {
    USDIPCPINVOKE.GfQuatf_SetImaginary__SWIG_0(swigCPtr, GfVec3f.getCPtr(imaginary));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetImaginary(float i, float j, float k) {
    USDIPCPINVOKE.GfQuatf_SetImaginary__SWIG_1(swigCPtr, i, j, k);
  }

  public float GetLength() {
    float ret = USDIPCPINVOKE.GfQuatf_GetLength(swigCPtr);
    return ret;
  }

  public GfQuatf GetNormalized(float eps) {
    GfQuatf ret = new GfQuatf(USDIPCPINVOKE.GfQuatf_GetNormalized__SWIG_0(swigCPtr, eps), true);
    return ret;
  }

  public GfQuatf GetNormalized() {
    GfQuatf ret = new GfQuatf(USDIPCPINVOKE.GfQuatf_GetNormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public float Normalize(float eps) {
    float ret = USDIPCPINVOKE.GfQuatf_Normalize__SWIG_0(swigCPtr, eps);
    return ret;
  }

  public float Normalize() {
    float ret = USDIPCPINVOKE.GfQuatf_Normalize__SWIG_1(swigCPtr);
    return ret;
  }

  public GfQuatf GetConjugate() {
    GfQuatf ret = new GfQuatf(USDIPCPINVOKE.GfQuatf_GetConjugate(swigCPtr), true);
    return ret;
  }

  public GfQuatf GetInverse() {
    GfQuatf ret = new GfQuatf(USDIPCPINVOKE.GfQuatf_GetInverse(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfQuatf lhs, GfQuatf rhs) {
    bool ret = USDIPCPINVOKE.GfQuatf_Equals(GfQuatf.getCPtr(lhs), GfQuatf.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = USDIPCPINVOKE.GfQuatf_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfQuatf lhs, GfQuatf rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfQuatf.Equals(lhs, rhs));
    }

    public static bool operator !=(GfQuatf lhs, GfQuatf rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfQuatf.Equals(this, rhs as GfQuatf);
    }
  
}

}
