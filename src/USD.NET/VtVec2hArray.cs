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

public class VtVec2hArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtVec2hArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(USDIPCPINVOKE.VtVec2hArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtVec2hArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtVec2hArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_VtVec2hArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfVec2h this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtVec2hArray() : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_0(), true) {
  }

  public VtVec2hArray(Vt_ArrayForeignDataSource foreignSrc, GfVec2h data, uint size, bool addRef) : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfVec2h.getCPtr(data), size, addRef), true) {
  }

  public VtVec2hArray(Vt_ArrayForeignDataSource foreignSrc, GfVec2h data, uint size) : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfVec2h.getCPtr(data), size), true) {
  }

  public VtVec2hArray(VtVec2hArray other) : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_3(VtVec2hArray.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtVec2hArray(uint n, GfVec2h value) : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_5(n, GfVec2h.getCPtr(value)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtVec2hArray(uint n) : this(USDIPCPINVOKE.new_VtVec2hArray__SWIG_6(n), true) {
  }

  public void push_back(GfVec2h elem) {
    USDIPCPINVOKE.VtVec2hArray_push_back(swigCPtr, GfVec2h.getCPtr(elem));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    USDIPCPINVOKE.VtVec2hArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = USDIPCPINVOKE.VtVec2hArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = USDIPCPINVOKE.VtVec2hArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = USDIPCPINVOKE.VtVec2hArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    USDIPCPINVOKE.VtVec2hArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    USDIPCPINVOKE.VtVec2hArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    USDIPCPINVOKE.VtVec2hArray_clear(swigCPtr);
  }

  public void assign(uint n, GfVec2h fill) {
    USDIPCPINVOKE.VtVec2hArray_assign(swigCPtr, n, GfVec2h.getCPtr(fill));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(VtVec2hArray other) {
    USDIPCPINVOKE.VtVec2hArray_swap(swigCPtr, VtVec2hArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtVec2hArray other) {
    bool ret = USDIPCPINVOKE.VtVec2hArray_IsIdentical(swigCPtr, VtVec2hArray.getCPtr(other));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtVec2hArray lhs, VtVec2hArray rhs) {
    bool ret = USDIPCPINVOKE.VtVec2hArray_Equals(VtVec2hArray.getCPtr(lhs), VtVec2hArray.getCPtr(rhs));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = USDIPCPINVOKE.VtVec2hArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfVec2h[] dest) {
    USDIPCPINVOKE.VtVec2hArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfVec2h[] src) {
    USDIPCPINVOKE.VtVec2hArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    USDIPCPINVOKE.VtVec2hArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    USDIPCPINVOKE.VtVec2hArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfVec2h GetValue(int index) {
    GfVec2h ret = new GfVec2h(USDIPCPINVOKE.VtVec2hArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfVec2h value) {
    USDIPCPINVOKE.VtVec2hArray_SetValue(swigCPtr, index, GfVec2h.getCPtr(value));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
