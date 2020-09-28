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

public class VtFloatArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtFloatArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.VtFloatArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtFloatArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtFloatArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_VtFloatArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public float this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtFloatArray() : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_0(), true) {
  }

  public VtFloatArray(Vt_ArrayForeignDataSource foreignSrc, SWIGTYPE_p_float data, uint size, bool addRef) : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), SWIGTYPE_p_float.getCPtr(data), size, addRef), true) {
  }

  public VtFloatArray(Vt_ArrayForeignDataSource foreignSrc, SWIGTYPE_p_float data, uint size) : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), SWIGTYPE_p_float.getCPtr(data), size), true) {
  }

  public VtFloatArray(VtFloatArray other) : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_3(VtFloatArray.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtFloatArray(uint n, float value) : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_5(n, value), true) {
  }

  public VtFloatArray(uint n) : this(USDIPCPINVOKE.new_VtFloatArray__SWIG_6(n), true) {
  }

  public void push_back(float elem) {
    USDIPCPINVOKE.VtFloatArray_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    USDIPCPINVOKE.VtFloatArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = USDIPCPINVOKE.VtFloatArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = USDIPCPINVOKE.VtFloatArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = USDIPCPINVOKE.VtFloatArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    USDIPCPINVOKE.VtFloatArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    USDIPCPINVOKE.VtFloatArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    USDIPCPINVOKE.VtFloatArray_clear(swigCPtr);
  }

  public void assign(uint n, float fill) {
    USDIPCPINVOKE.VtFloatArray_assign(swigCPtr, n, fill);
  }

  public void swap(VtFloatArray other) {
    USDIPCPINVOKE.VtFloatArray_swap(swigCPtr, VtFloatArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtFloatArray other) {
    bool ret = USDIPCPINVOKE.VtFloatArray_IsIdentical(swigCPtr, VtFloatArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtFloatArray lhs, VtFloatArray rhs) {
    bool ret = USDIPCPINVOKE.VtFloatArray_Equals(VtFloatArray.getCPtr(lhs), VtFloatArray.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = USDIPCPINVOKE.VtFloatArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(float[] dest) {
    USDIPCPINVOKE.VtFloatArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(float[] src) {
    USDIPCPINVOKE.VtFloatArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    USDIPCPINVOKE.VtFloatArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    USDIPCPINVOKE.VtFloatArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected float GetValue(int index) {
    float ret = USDIPCPINVOKE.VtFloatArray_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, float value) {
    USDIPCPINVOKE.VtFloatArray_SetValue(swigCPtr, index, value);
  }

}

}