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

public class VtMatrix4dArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtMatrix4dArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.VtMatrix4dArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtMatrix4dArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtMatrix4dArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_VtMatrix4dArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfMatrix4d this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtMatrix4dArray() : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_0(), true) {
  }

  public VtMatrix4dArray(Vt_ArrayForeignDataSource foreignSrc, GfMatrix4d data, uint size, bool addRef) : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfMatrix4d.getCPtr(data), size, addRef), true) {
  }

  public VtMatrix4dArray(Vt_ArrayForeignDataSource foreignSrc, GfMatrix4d data, uint size) : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfMatrix4d.getCPtr(data), size), true) {
  }

  public VtMatrix4dArray(VtMatrix4dArray other) : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_3(VtMatrix4dArray.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtMatrix4dArray(uint n, GfMatrix4d value) : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_5(n, GfMatrix4d.getCPtr(value)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtMatrix4dArray(uint n) : this(USDIPCPINVOKE.new_VtMatrix4dArray__SWIG_6(n), true) {
  }

  public void push_back(GfMatrix4d elem) {
    USDIPCPINVOKE.VtMatrix4dArray_push_back(swigCPtr, GfMatrix4d.getCPtr(elem));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    USDIPCPINVOKE.VtMatrix4dArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = USDIPCPINVOKE.VtMatrix4dArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = USDIPCPINVOKE.VtMatrix4dArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = USDIPCPINVOKE.VtMatrix4dArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    USDIPCPINVOKE.VtMatrix4dArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    USDIPCPINVOKE.VtMatrix4dArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    USDIPCPINVOKE.VtMatrix4dArray_clear(swigCPtr);
  }

  public void assign(uint n, GfMatrix4d fill) {
    USDIPCPINVOKE.VtMatrix4dArray_assign(swigCPtr, n, GfMatrix4d.getCPtr(fill));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(VtMatrix4dArray other) {
    USDIPCPINVOKE.VtMatrix4dArray_swap(swigCPtr, VtMatrix4dArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtMatrix4dArray other) {
    bool ret = USDIPCPINVOKE.VtMatrix4dArray_IsIdentical(swigCPtr, VtMatrix4dArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtMatrix4dArray lhs, VtMatrix4dArray rhs) {
    bool ret = USDIPCPINVOKE.VtMatrix4dArray_Equals(VtMatrix4dArray.getCPtr(lhs), VtMatrix4dArray.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = USDIPCPINVOKE.VtMatrix4dArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfMatrix4d[] dest) {
    USDIPCPINVOKE.VtMatrix4dArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfMatrix4d[] src) {
    USDIPCPINVOKE.VtMatrix4dArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    USDIPCPINVOKE.VtMatrix4dArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    USDIPCPINVOKE.VtMatrix4dArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfMatrix4d GetValue(int index) {
    GfMatrix4d ret = new GfMatrix4d(USDIPCPINVOKE.VtMatrix4dArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfMatrix4d value) {
    USDIPCPINVOKE.VtMatrix4dArray_SetValue(swigCPtr, index, GfMatrix4d.getCPtr(value));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
