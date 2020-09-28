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

public class UsdGeomBasisCurvesComputeInterpolationInfo : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<UsdGeomBasisCurvesComputeInterpolationInfoPair>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdGeomBasisCurvesComputeInterpolationInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomBasisCurvesComputeInterpolationInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomBasisCurvesComputeInterpolationInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_UsdGeomBasisCurvesComputeInterpolationInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdGeomBasisCurvesComputeInterpolationInfo(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (UsdGeomBasisCurvesComputeInterpolationInfoPair element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public UsdGeomBasisCurvesComputeInterpolationInfoPair this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(UsdGeomBasisCurvesComputeInterpolationInfoPair[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(UsdGeomBasisCurvesComputeInterpolationInfoPair[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<UsdGeomBasisCurvesComputeInterpolationInfoPair> global::System.Collections.Generic.IEnumerable<UsdGeomBasisCurvesComputeInterpolationInfoPair>.GetEnumerator() {
    return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
  }

  public UsdGeomBasisCurvesComputeInterpolationInfoEnumerator GetEnumerator() {
    return new UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UsdGeomBasisCurvesComputeInterpolationInfoEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<UsdGeomBasisCurvesComputeInterpolationInfoPair>
  {
    private UsdGeomBasisCurvesComputeInterpolationInfo collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UsdGeomBasisCurvesComputeInterpolationInfoEnumerator(UsdGeomBasisCurvesComputeInterpolationInfo collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public UsdGeomBasisCurvesComputeInterpolationInfoPair Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (UsdGeomBasisCurvesComputeInterpolationInfoPair)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Clear(swigCPtr);
  }

  public void Add(UsdGeomBasisCurvesComputeInterpolationInfoPair x) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Add(swigCPtr, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(x));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_reserve(swigCPtr, n);
  }

  public UsdGeomBasisCurvesComputeInterpolationInfo() : this(USDIPCPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_0(), true) {
  }

  public UsdGeomBasisCurvesComputeInterpolationInfo(UsdGeomBasisCurvesComputeInterpolationInfo other) : this(USDIPCPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_1(UsdGeomBasisCurvesComputeInterpolationInfo.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomBasisCurvesComputeInterpolationInfo(int capacity) : this(USDIPCPINVOKE.new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_2(capacity), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  private UsdGeomBasisCurvesComputeInterpolationInfoPair getitemcopy(int index) {
    UsdGeomBasisCurvesComputeInterpolationInfoPair ret = new UsdGeomBasisCurvesComputeInterpolationInfoPair(USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_getitemcopy(swigCPtr, index), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private UsdGeomBasisCurvesComputeInterpolationInfoPair getitem(int index) {
    UsdGeomBasisCurvesComputeInterpolationInfoPair ret = new UsdGeomBasisCurvesComputeInterpolationInfoPair(USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_getitem(swigCPtr, index), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair val) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_setitem(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(val));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(UsdGeomBasisCurvesComputeInterpolationInfo values) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_AddRange(swigCPtr, UsdGeomBasisCurvesComputeInterpolationInfo.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomBasisCurvesComputeInterpolationInfo GetRange(int index, int count) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_GetRange(swigCPtr, index, count);
    UsdGeomBasisCurvesComputeInterpolationInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdGeomBasisCurvesComputeInterpolationInfo(cPtr, true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, UsdGeomBasisCurvesComputeInterpolationInfoPair x) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Insert(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(x));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, UsdGeomBasisCurvesComputeInterpolationInfo values) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_InsertRange(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfo.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_RemoveAt(swigCPtr, index);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_RemoveRange(swigCPtr, index, count);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static UsdGeomBasisCurvesComputeInterpolationInfo Repeat(UsdGeomBasisCurvesComputeInterpolationInfoPair value, int count) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Repeat(UsdGeomBasisCurvesComputeInterpolationInfoPair.getCPtr(value), count);
    UsdGeomBasisCurvesComputeInterpolationInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdGeomBasisCurvesComputeInterpolationInfo(cPtr, true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_1(swigCPtr, index, count);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, UsdGeomBasisCurvesComputeInterpolationInfo values) {
    USDIPCPINVOKE.UsdGeomBasisCurvesComputeInterpolationInfo_SetRange(swigCPtr, index, UsdGeomBasisCurvesComputeInterpolationInfo.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

}

}