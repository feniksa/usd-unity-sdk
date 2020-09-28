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

public class GfMatrix3d : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfMatrix3d(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfMatrix3d obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfMatrix3d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_GfMatrix3d(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfMatrix3d() : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_0(), true) {
  }

  public GfMatrix3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_1(m00, m01, m02, m10, m11, m12, m20, m21, m22), true) {
  }

  public GfMatrix3d(double s) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_2(s), true) {
  }

  public GfMatrix3d(int s) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_3(s), true) {
  }

  public GfMatrix3d(GfVec3d v) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_4(GfVec3d.getCPtr(v)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix3d(StdDoubleVectorVector v) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_5(StdDoubleVectorVector.getCPtr(v)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix3d(StdFloatVectorVector v) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_6(StdFloatVectorVector.getCPtr(v)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix3d(GfRotation rot) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_7(GfRotation.getCPtr(rot)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix3d(GfQuatd rot) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_8(GfQuatd.getCPtr(rot)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix3d(GfMatrix3f m) : this(USDIPCPINVOKE.new_GfMatrix3d__SWIG_9(GfMatrix3f.getCPtr(m)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(int i, GfVec3d v) {
    USDIPCPINVOKE.GfMatrix3d_SetRow(swigCPtr, i, GfVec3d.getCPtr(v));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColumn(int i, GfVec3d v) {
    USDIPCPINVOKE.GfMatrix3d_SetColumn(swigCPtr, i, GfVec3d.getCPtr(v));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3d GetRow(int i) {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfMatrix3d_GetRow(swigCPtr, i), true);
    return ret;
  }

  public GfVec3d GetColumn(int i) {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfMatrix3d_GetColumn(swigCPtr, i), true);
    return ret;
  }

  public GfMatrix3d Set(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_Set(swigCPtr, m00, m01, m02, m10, m11, m12, m20, m21, m22), false);
    return ret;
  }

  public GfMatrix3d SetIdentity() {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetIdentity(swigCPtr), false);
    return ret;
  }

  public GfMatrix3d SetZero() {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetZero(swigCPtr), false);
    return ret;
  }

  public GfMatrix3d SetDiagonal(double s) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetDiagonal__SWIG_0(swigCPtr, s), false);
    return ret;
  }

  public GfMatrix3d SetDiagonal(GfVec3d arg0) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetDiagonal__SWIG_1(swigCPtr, GfVec3d.getCPtr(arg0)), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double Get(SWIGTYPE_p_a_3__double m) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.GfMatrix3d_Get(swigCPtr, SWIGTYPE_p_a_3__double.getCPtr(m));
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public GfMatrix3d GetTranspose() {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetTranspose(swigCPtr), true);
    return ret;
  }

  public GfMatrix3d GetInverse(ref double det, double eps) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetInverse__SWIG_0(swigCPtr, ref det, eps), true);
    return ret;
  }

  public GfMatrix3d GetInverse(ref double det) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetInverse__SWIG_1(swigCPtr, ref det), true);
    return ret;
  }

  public GfMatrix3d GetInverse() {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetInverse__SWIG_2(swigCPtr), true);
    return ret;
  }

  public double GetDeterminant() {
    double ret = USDIPCPINVOKE.GfMatrix3d_GetDeterminant(swigCPtr);
    return ret;
  }

  public bool Orthonormalize(bool issueWarning) {
    bool ret = USDIPCPINVOKE.GfMatrix3d_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
    return ret;
  }

  public bool Orthonormalize() {
    bool ret = USDIPCPINVOKE.GfMatrix3d_Orthonormalize__SWIG_1(swigCPtr);
    return ret;
  }

  public GfMatrix3d GetOrthonormalized(bool issueWarning) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), true);
    return ret;
  }

  public GfMatrix3d GetOrthonormalized() {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_GetOrthonormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public double GetHandedness() {
    double ret = USDIPCPINVOKE.GfMatrix3d_GetHandedness(swigCPtr);
    return ret;
  }

  public bool IsRightHanded() {
    bool ret = USDIPCPINVOKE.GfMatrix3d_IsRightHanded(swigCPtr);
    return ret;
  }

  public bool IsLeftHanded() {
    bool ret = USDIPCPINVOKE.GfMatrix3d_IsLeftHanded(swigCPtr);
    return ret;
  }

  public GfMatrix3d SetScale(double scaleFactor) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetScale__SWIG_0(swigCPtr, scaleFactor), false);
    return ret;
  }

  public GfMatrix3d SetRotate(GfQuatd rot) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetRotate__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix3d SetRotate(GfRotation rot) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix3d SetScale(GfVec3d scaleFactors) {
    GfMatrix3d ret = new GfMatrix3d(USDIPCPINVOKE.GfMatrix3d_SetScale__SWIG_1(swigCPtr, GfVec3d.getCPtr(scaleFactors)), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRotation ExtractRotation() {
    GfRotation ret = new GfRotation(USDIPCPINVOKE.GfMatrix3d_ExtractRotation(swigCPtr), true);
    return ret;
  }

  public GfVec3d DecomposeRotation(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2) {
    GfVec3d ret = new GfVec3d(USDIPCPINVOKE.GfMatrix3d_DecomposeRotation(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfQuaternion ExtractRotationQuaternion() {
    GfQuaternion ret = new GfQuaternion(USDIPCPINVOKE.GfMatrix3d_ExtractRotationQuaternion(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfMatrix3d lhs, GfMatrix3d rhs) {
    bool ret = USDIPCPINVOKE.GfMatrix3d_Equals(GfMatrix3d.getCPtr(lhs), GfMatrix3d.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = USDIPCPINVOKE.GfMatrix3d_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfMatrix3d lhs, GfMatrix3d rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfMatrix3d.Equals(lhs, rhs));
    }

    public static bool operator !=(GfMatrix3d lhs, GfMatrix3d rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfMatrix3d.Equals(this, rhs as GfMatrix3d);
    }
  
  public override string ToString() {
    string ret = USDIPCPINVOKE.GfMatrix3d_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(double[] dest) {
    USDIPCPINVOKE.GfMatrix3d_CopyToArray(swigCPtr, dest);
  }

  public void CopyFromArray(double[] src) {
    USDIPCPINVOKE.GfMatrix3d_CopyFromArray(swigCPtr, src);
  }

  public static readonly uint numRows = USDIPCPINVOKE.GfMatrix3d_numRows_get();
  public static readonly uint numColumns = USDIPCPINVOKE.GfMatrix3d_numColumns_get();
}

}
