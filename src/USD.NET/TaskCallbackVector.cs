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

public class TaskCallbackVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<TaskCallback>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TaskCallbackVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TaskCallbackVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TaskCallbackVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_TaskCallbackVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TaskCallbackVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TaskCallback element in c) {
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

  public TaskCallback this[int index]  {
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

  public void CopyTo(TaskCallback[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(TaskCallback[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, TaskCallback[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<TaskCallback> global::System.Collections.Generic.IEnumerable<TaskCallback>.GetEnumerator() {
    return new TaskCallbackVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new TaskCallbackVectorEnumerator(this);
  }

  public TaskCallbackVectorEnumerator GetEnumerator() {
    return new TaskCallbackVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TaskCallbackVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<TaskCallback>
  {
    private TaskCallbackVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TaskCallbackVectorEnumerator(TaskCallbackVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TaskCallback Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (TaskCallback)currentObject;
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
    USDIPCPINVOKE.TaskCallbackVector_Clear(swigCPtr);
  }

  public void Add(TaskCallback x) {
    USDIPCPINVOKE.TaskCallbackVector_Add(swigCPtr, TaskCallback.getCPtr(x));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = USDIPCPINVOKE.TaskCallbackVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = USDIPCPINVOKE.TaskCallbackVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    USDIPCPINVOKE.TaskCallbackVector_reserve(swigCPtr, n);
  }

  public TaskCallbackVector() : this(USDIPCPINVOKE.new_TaskCallbackVector__SWIG_0(), true) {
  }

  public TaskCallbackVector(TaskCallbackVector other) : this(USDIPCPINVOKE.new_TaskCallbackVector__SWIG_1(TaskCallbackVector.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaskCallbackVector(int capacity) : this(USDIPCPINVOKE.new_TaskCallbackVector__SWIG_2(capacity), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  private TaskCallback getitemcopy(int index) {
    TaskCallback ret = new TaskCallback(USDIPCPINVOKE.TaskCallbackVector_getitemcopy(swigCPtr, index), true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private TaskCallback getitem(int index) {
    TaskCallback ret = new TaskCallback(USDIPCPINVOKE.TaskCallbackVector_getitem(swigCPtr, index), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TaskCallback val) {
    USDIPCPINVOKE.TaskCallbackVector_setitem(swigCPtr, index, TaskCallback.getCPtr(val));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(TaskCallbackVector values) {
    USDIPCPINVOKE.TaskCallbackVector_AddRange(swigCPtr, TaskCallbackVector.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public TaskCallbackVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.TaskCallbackVector_GetRange(swigCPtr, index, count);
    TaskCallbackVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskCallbackVector(cPtr, true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TaskCallback x) {
    USDIPCPINVOKE.TaskCallbackVector_Insert(swigCPtr, index, TaskCallback.getCPtr(x));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TaskCallbackVector values) {
    USDIPCPINVOKE.TaskCallbackVector_InsertRange(swigCPtr, index, TaskCallbackVector.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    USDIPCPINVOKE.TaskCallbackVector_RemoveAt(swigCPtr, index);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    USDIPCPINVOKE.TaskCallbackVector_RemoveRange(swigCPtr, index, count);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TaskCallbackVector Repeat(TaskCallback value, int count) {
    global::System.IntPtr cPtr = USDIPCPINVOKE.TaskCallbackVector_Repeat(TaskCallback.getCPtr(value), count);
    TaskCallbackVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new TaskCallbackVector(cPtr, true);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    USDIPCPINVOKE.TaskCallbackVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    USDIPCPINVOKE.TaskCallbackVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TaskCallbackVector values) {
    USDIPCPINVOKE.TaskCallbackVector_SetRange(swigCPtr, index, TaskCallbackVector.getCPtr(values));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
