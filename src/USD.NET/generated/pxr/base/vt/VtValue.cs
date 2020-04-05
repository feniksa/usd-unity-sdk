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

public class VtValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VtValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


    public static implicit operator GfHalf (VtValue value) {
        return UsdCs.VtValueToGfHalf(value);
    }

    public static implicit operator GfMatrix2d (VtValue value) {
        return UsdCs.VtValueToGfMatrix2d(value);
    }

    public static implicit operator GfMatrix3d (VtValue value) {
        return UsdCs.VtValueToGfMatrix3d(value);
    }

    public static implicit operator GfMatrix4d (VtValue value) {
        return UsdCs.VtValueToGfMatrix4d(value);
    }

    public static implicit operator GfQuatd (VtValue value) {
        return UsdCs.VtValueToGfQuatd(value);
    }

    public static implicit operator GfQuatf (VtValue value) {
        return UsdCs.VtValueToGfQuatf(value);
    }

    public static implicit operator GfQuath (VtValue value) {
        return UsdCs.VtValueToGfQuath(value);
    }

    public static implicit operator GfVec2d (VtValue value) {
        return UsdCs.VtValueToGfVec2d(value);
    }

    public static implicit operator GfVec2f (VtValue value) {
        return UsdCs.VtValueToGfVec2f(value);
    }

    public static implicit operator GfVec2h (VtValue value) {
        return UsdCs.VtValueToGfVec2h(value);
    }

    public static implicit operator GfVec2i (VtValue value) {
        return UsdCs.VtValueToGfVec2i(value);
    }

    public static implicit operator GfVec3d (VtValue value) {
        return UsdCs.VtValueToGfVec3d(value);
    }

    public static implicit operator GfVec3f (VtValue value) {
        return UsdCs.VtValueToGfVec3f(value);
    }

    public static implicit operator GfVec3h (VtValue value) {
        return UsdCs.VtValueToGfVec3h(value);
    }

    public static implicit operator GfVec3i (VtValue value) {
        return UsdCs.VtValueToGfVec3i(value);
    }

    public static implicit operator GfVec4d (VtValue value) {
        return UsdCs.VtValueToGfVec4d(value);
    }

    public static implicit operator GfVec4f (VtValue value) {
        return UsdCs.VtValueToGfVec4f(value);
    }

    public static implicit operator GfVec4h (VtValue value) {
        return UsdCs.VtValueToGfVec4h(value);
    }

    public static implicit operator GfVec4i (VtValue value) {
        return UsdCs.VtValueToGfVec4i(value);
    }

    public static implicit operator SdfAssetPath (VtValue value) {
        return UsdCs.VtValueToSdfAssetPath(value);
    }

    public static implicit operator SdfAssetPathArray (VtValue value) {
        return UsdCs.VtValueToSdfAssetPathArray(value);
    }

    public static implicit operator TfToken (VtValue value) {
        return UsdCs.VtValueToTfToken(value);
    }

    public static implicit operator VtBoolArray (VtValue value) {
        return UsdCs.VtValueToVtBoolArray(value);
    }

    public static implicit operator VtDoubleArray (VtValue value) {
        return UsdCs.VtValueToVtDoubleArray(value);
    }

    public static implicit operator VtFloatArray (VtValue value) {
        return UsdCs.VtValueToVtFloatArray(value);
    }

    public static implicit operator VtHalfArray (VtValue value) {
        return UsdCs.VtValueToVtHalfArray(value);
    }

    public static implicit operator VtInt64Array (VtValue value) {
        return UsdCs.VtValueToVtInt64Array(value);
    }

    public static implicit operator VtIntArray (VtValue value) {
        return UsdCs.VtValueToVtIntArray(value);
    }

    public static implicit operator VtMatrix2dArray (VtValue value) {
        return UsdCs.VtValueToVtMatrix2dArray(value);
    }

    public static implicit operator VtMatrix3dArray (VtValue value) {
        return UsdCs.VtValueToVtMatrix3dArray(value);
    }

    public static implicit operator VtMatrix4dArray (VtValue value) {
        return UsdCs.VtValueToVtMatrix4dArray(value);
    }

    public static implicit operator VtQuatdArray (VtValue value) {
        return UsdCs.VtValueToVtQuatdArray(value);
    }

    public static implicit operator VtQuatfArray (VtValue value) {
        return UsdCs.VtValueToVtQuatfArray(value);
    }

    public static implicit operator VtQuathArray (VtValue value) {
        return UsdCs.VtValueToVtQuathArray(value);
    }

    public static implicit operator VtStringArray (VtValue value) {
        return UsdCs.VtValueToVtStringArray(value);
    }

    public static implicit operator VtTokenArray (VtValue value) {
        return UsdCs.VtValueToVtTokenArray(value);
    }

    public static implicit operator VtUCharArray (VtValue value) {
        return UsdCs.VtValueToVtUCharArray(value);
    }

    public static implicit operator VtUInt64Array (VtValue value) {
        return UsdCs.VtValueToVtUInt64Array(value);
    }

    public static implicit operator VtUIntArray (VtValue value) {
        return UsdCs.VtValueToVtUIntArray(value);
    }

    public static implicit operator VtVec2dArray (VtValue value) {
        return UsdCs.VtValueToVtVec2dArray(value);
    }

    public static implicit operator VtVec2fArray (VtValue value) {
        return UsdCs.VtValueToVtVec2fArray(value);
    }

    public static implicit operator VtVec2hArray (VtValue value) {
        return UsdCs.VtValueToVtVec2hArray(value);
    }

    public static implicit operator VtVec2iArray (VtValue value) {
        return UsdCs.VtValueToVtVec2iArray(value);
    }

    public static implicit operator VtVec3dArray (VtValue value) {
        return UsdCs.VtValueToVtVec3dArray(value);
    }

    public static implicit operator VtVec3fArray (VtValue value) {
        return UsdCs.VtValueToVtVec3fArray(value);
    }

    public static implicit operator VtVec3hArray (VtValue value) {
        return UsdCs.VtValueToVtVec3hArray(value);
    }

    public static implicit operator VtVec3iArray (VtValue value) {
        return UsdCs.VtValueToVtVec3iArray(value);
    }

    public static implicit operator VtVec4dArray (VtValue value) {
        return UsdCs.VtValueToVtVec4dArray(value);
    }

    public static implicit operator VtVec4fArray (VtValue value) {
        return UsdCs.VtValueToVtVec4fArray(value);
    }

    public static implicit operator VtVec4hArray (VtValue value) {
        return UsdCs.VtValueToVtVec4hArray(value);
    }

    public static implicit operator VtVec4iArray (VtValue value) {
        return UsdCs.VtValueToVtVec4iArray(value);
    }

    public static implicit operator bool (VtValue value) {
        return UsdCs.VtValueTobool(value);
    }

    public static implicit operator double (VtValue value) {
        return UsdCs.VtValueTodouble(value);
    }

    public static implicit operator float (VtValue value) {
        return UsdCs.VtValueTofloat(value);
    }

    public static implicit operator int (VtValue value) {
        return UsdCs.VtValueToint(value);
    }

    public static implicit operator long (VtValue value) {
        return UsdCs.VtValueTolong(value);
    }

    public static implicit operator string (VtValue value) {
        return UsdCs.VtValueTostring(value);
    }

    public static implicit operator ulong (VtValue value) {
        return UsdCs.VtValueToulong(value);
    }

    public static implicit operator byte (VtValue value) {
        return UsdCs.VtValueTobyte(value);
    }

    public static implicit operator uint (VtValue value) {
        return UsdCs.VtValueTouint(value);
    }

    public static implicit operator VtValue (GfHalf value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfMatrix2d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfMatrix3d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfMatrix4d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfQuatd value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfQuatf value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfQuath value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec2d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec2f value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec2h value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec2i value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec3d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec3f value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec3h value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec3i value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec4d value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec4f value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec4h value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (GfVec4i value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (SdfAssetPath value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (SdfAssetPathArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (TfToken value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtBoolArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtDoubleArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtFloatArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtHalfArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtInt64Array value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtIntArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtMatrix2dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtMatrix3dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtMatrix4dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtQuatdArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtQuatfArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtQuathArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtStringArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtTokenArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtUCharArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtUInt64Array value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtUIntArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec2dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec2fArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec2hArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec2iArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec3dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec3fArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec3hArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec3iArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec4dArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec4fArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec4hArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (VtVec4iArray value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (bool value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (double value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (float value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (int value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (long value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (string value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (ulong value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (byte value) {
        return new VtValue(value);
    }

    public static implicit operator VtValue (uint value) {
        return new VtValue(value);
    }

  public VtValue() : this(UsdCsPINVOKE.new_VtValue__SWIG_0(), true) {
  }

  public VtValue(VtValue other) : this(UsdCsPINVOKE.new_VtValue__SWIG_1(VtValue.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue Swap(VtValue rhs) {
    VtValue ret = new VtValue(UsdCsPINVOKE.VtValue_Swap(swigCPtr, VtValue.getCPtr(rhs)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UncheckedSwap(VtValue rhs) {
    UsdCsPINVOKE.VtValue_UncheckedSwap(swigCPtr, VtValue.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsArrayValued() {
    bool ret = UsdCsPINVOKE.VtValue_IsArrayValued(swigCPtr);
    return ret;
  }

  public uint GetArraySize() {
    uint ret = UsdCsPINVOKE.VtValue_GetArraySize(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__type_info GetTypeid() {
    SWIGTYPE_p_std__type_info ret = new SWIGTYPE_p_std__type_info(UsdCsPINVOKE.VtValue_GetTypeid(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__type_info GetElementTypeid() {
    SWIGTYPE_p_std__type_info ret = new SWIGTYPE_p_std__type_info(UsdCsPINVOKE.VtValue_GetElementTypeid(swigCPtr), false);
    return ret;
  }

  public TfType GetTfType() {
    TfType ret = new TfType(UsdCsPINVOKE.VtValue_GetTfType(swigCPtr), true);
    return ret;
  }

  public string GetTypeName() {
    string ret = UsdCsPINVOKE.VtValue_GetTypeName(swigCPtr);
    return ret;
  }

  public static VtValue CastToTypeOf(VtValue val, VtValue other) {
    VtValue ret = new VtValue(UsdCsPINVOKE.VtValue_CastToTypeOf__SWIG_0(VtValue.getCPtr(val), VtValue.getCPtr(other)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static VtValue CastToTypeid(VtValue val, SWIGTYPE_p_std__type_info type) {
    VtValue ret = new VtValue(UsdCsPINVOKE.VtValue_CastToTypeid__SWIG_0(VtValue.getCPtr(val), SWIGTYPE_p_std__type_info.getCPtr(type)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CanCastFromTypeidToTypeid(SWIGTYPE_p_std__type_info from, SWIGTYPE_p_std__type_info to) {
    bool ret = UsdCsPINVOKE.VtValue_CanCastFromTypeidToTypeid(SWIGTYPE_p_std__type_info.getCPtr(from), SWIGTYPE_p_std__type_info.getCPtr(to));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanCastToTypeOf(VtValue other) {
    bool ret = UsdCsPINVOKE.VtValue_CanCastToTypeOf(swigCPtr, VtValue.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanCastToTypeid(SWIGTYPE_p_std__type_info type) {
    bool ret = UsdCsPINVOKE.VtValue_CanCastToTypeid(swigCPtr, SWIGTYPE_p_std__type_info.getCPtr(type));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEmpty() {
    bool ret = UsdCsPINVOKE.VtValue_IsEmpty(swigCPtr);
    return ret;
  }

  public bool CanHash() {
    bool ret = UsdCsPINVOKE.VtValue_CanHash(swigCPtr);
    return ret;
  }

  public uint GetHash() {
    uint ret = UsdCsPINVOKE.VtValue_GetHash(swigCPtr);
    return ret;
  }

  public VtValue(GfHalf obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_4(GfHalf.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfMatrix2d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_5(GfMatrix2d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfMatrix3d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_6(GfMatrix3d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfMatrix4d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_7(GfMatrix4d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfQuatd obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_8(GfQuatd.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfQuatf obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_9(GfQuatf.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfQuath obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_10(GfQuath.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec2d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_11(GfVec2d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec2f obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_12(GfVec2f.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec2h obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_13(GfVec2h.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec2i obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_14(GfVec2i.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec3d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_15(GfVec3d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec3f obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_16(GfVec3f.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec3h obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_17(GfVec3h.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec3i obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_18(GfVec3i.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec4d obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_19(GfVec4d.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec4f obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_20(GfVec4f.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec4h obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_21(GfVec4h.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(GfVec4i obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_22(GfVec4i.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(SdfAssetPath obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_23(SdfAssetPath.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(SdfAssetPathArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_24(SdfAssetPathArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(TfToken obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_25(TfToken.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtBoolArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_26(VtBoolArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtDoubleArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_27(VtDoubleArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtFloatArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_28(VtFloatArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtHalfArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_29(VtHalfArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtInt64Array obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_30(VtInt64Array.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtIntArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_31(VtIntArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtMatrix2dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_32(VtMatrix2dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtMatrix3dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_33(VtMatrix3dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtMatrix4dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_34(VtMatrix4dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtQuatdArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_35(VtQuatdArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtQuatfArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_36(VtQuatfArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtQuathArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_37(VtQuathArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtStringArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_38(VtStringArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtTokenArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_39(VtTokenArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtUCharArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_40(VtUCharArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtUInt64Array obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_41(VtUInt64Array.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtUIntArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_42(VtUIntArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec2dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_43(VtVec2dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec2fArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_44(VtVec2fArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec2hArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_45(VtVec2hArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec2iArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_46(VtVec2iArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec3dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_47(VtVec3dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec3fArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_48(VtVec3fArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec3hArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_49(VtVec3hArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec3iArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_50(VtVec3iArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec4dArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_51(VtVec4dArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec4fArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_52(VtVec4fArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec4hArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_53(VtVec4hArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(VtVec4iArray obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_54(VtVec4iArray.getCPtr(obj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(bool obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_55(obj), true) {
  }

  public VtValue(double obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_56(obj), true) {
  }

  public VtValue(float obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_57(obj), true) {
  }

  public VtValue(int obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_58(obj), true) {
  }

  public VtValue(long obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_59(obj), true) {
  }

  public VtValue(string obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_60(obj), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtValue(ulong obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_61(obj), true) {
  }

  public VtValue(byte obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_62(obj), true) {
  }

  public VtValue(uint obj) : this(UsdCsPINVOKE.new_VtValue__SWIG_63(obj), true) {
  }

  public static bool Equals(VtValue lhs, VtValue rhs) {
    bool ret = UsdCsPINVOKE.VtValue_Equals(VtValue.getCPtr(lhs), VtValue.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.VtValue_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(VtValue lhs, VtValue rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || VtValue.Equals(lhs, rhs));
    }

    public static bool operator !=(VtValue lhs, VtValue rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return VtValue.Equals(this, rhs as VtValue);
    }
  
}

}
