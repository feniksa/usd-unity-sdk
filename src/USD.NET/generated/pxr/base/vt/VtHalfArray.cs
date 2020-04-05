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

[Preserve]
public class VtHalfArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtHalfArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtHalfArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtHalfArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtHalfArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtHalfArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfHalf this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtHalfArray() : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_0(), true) {
  }

  public VtHalfArray(Vt_ArrayForeignDataSource foreignSrc, GfHalf data, uint size, bool addRef) : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_1(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfHalf.getCPtr(data), size, addRef), true) {
  }

  public VtHalfArray(Vt_ArrayForeignDataSource foreignSrc, GfHalf data, uint size) : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_2(Vt_ArrayForeignDataSource.getCPtr(foreignSrc), GfHalf.getCPtr(data), size), true) {
  }

  public VtHalfArray(VtHalfArray other) : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_3(VtHalfArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtHalfArray(uint n, GfHalf value) : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_5(n, GfHalf.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtHalfArray(uint n) : this(UsdCsPINVOKE.new_VtHalfArray__SWIG_6(n), true) {
  }

  public void push_back(GfHalf elem) {
    UsdCsPINVOKE.VtHalfArray_push_back(swigCPtr, GfHalf.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.VtHalfArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtHalfArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtHalfArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtHalfArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtHalfArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtHalfArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtHalfArray_clear(swigCPtr);
  }

  public void assign(uint n, GfHalf fill) {
    UsdCsPINVOKE.VtHalfArray_assign(swigCPtr, n, GfHalf.getCPtr(fill));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(VtHalfArray other) {
    UsdCsPINVOKE.VtHalfArray_swap(swigCPtr, VtHalfArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtHalfArray other) {
    bool ret = UsdCsPINVOKE.VtHalfArray_IsIdentical(swigCPtr, VtHalfArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtHalfArray lhs, VtHalfArray rhs) {
    bool ret = UsdCsPINVOKE.VtHalfArray_Equals(VtHalfArray.getCPtr(lhs), VtHalfArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtHalfArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfHalf[] dest) {
    UsdCsPINVOKE.VtHalfArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfHalf[] src) {
    UsdCsPINVOKE.VtHalfArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtHalfArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtHalfArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfHalf GetValue(int index) {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.VtHalfArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfHalf value) {
    UsdCsPINVOKE.VtHalfArray_SetValue(swigCPtr, index, GfHalf.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
