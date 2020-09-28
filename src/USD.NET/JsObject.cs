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

public class JsObject : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<string, JsValue>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          USDIPCPINVOKE.delete_JsObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public JsValue this[string key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(string key, out JsValue value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(JsValue);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

  public global::System.Collections.Generic.ICollection<string> Keys {
    get {
      global::System.Collections.Generic.ICollection<string> keys = new global::System.Collections.Generic.List<string>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<JsValue> Values {
    get {
      global::System.Collections.Generic.ICollection<JsValue> vals = new global::System.Collections.Generic.List<JsValue>();
      foreach (global::System.Collections.Generic.KeyValuePair<string, JsValue> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(global::System.Collections.Generic.KeyValuePair<string, JsValue> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<string, JsValue> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<string, JsValue> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, JsValue>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, JsValue>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<string> keyList = new global::System.Collections.Generic.List<string>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      string currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<string, JsValue>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, JsValue>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, JsValue>>.GetEnumerator() {
    return new JsObjectEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new JsObjectEnumerator(this);
  }

  public JsObjectEnumerator GetEnumerator() {
    return new JsObjectEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class JsObjectEnumerator : global::System.Collections.IEnumerator, 
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, JsValue>>
  {
    private JsObject collectionRef;
    private global::System.Collections.Generic.IList<string> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public JsObjectEnumerator(JsObject collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<string>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<string, JsValue> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<string, JsValue>)currentObject;
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
        string currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<string, JsValue>(currentKey, collectionRef[currentKey]);
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
  

  public JsObject() : this(USDIPCPINVOKE.new_JsObject__SWIG_0(), true) {
  }

  public JsObject(JsObject other) : this(USDIPCPINVOKE.new_JsObject__SWIG_1(JsObject.getCPtr(other)), true) {
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = USDIPCPINVOKE.JsObject_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = USDIPCPINVOKE.JsObject_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    USDIPCPINVOKE.JsObject_Clear(swigCPtr);
  }

  private JsValue getitem(string key) {
    JsValue ret = new JsValue(USDIPCPINVOKE.JsObject_getitem(swigCPtr, key), false);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(string key, JsValue x) {
    USDIPCPINVOKE.JsObject_setitem(swigCPtr, key, JsValue.getCPtr(x));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(string key) {
    bool ret = USDIPCPINVOKE.JsObject_ContainsKey(swigCPtr, key);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(string key, JsValue val) {
    USDIPCPINVOKE.JsObject_Add(swigCPtr, key, JsValue.getCPtr(val));
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(string key) {
    bool ret = USDIPCPINVOKE.JsObject_Remove(swigCPtr, key);
    if (USDIPCPINVOKE.SWIGPendingException.Pending) throw USDIPCPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = USDIPCPINVOKE.JsObject_create_iterator_begin(swigCPtr);
    return ret;
  }

  private string get_next_key(global::System.IntPtr swigiterator) {
    string ret = USDIPCPINVOKE.JsObject_get_next_key(swigCPtr, swigiterator);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    USDIPCPINVOKE.JsObject_destroy_iterator(swigCPtr, swigiterator);
  }

}

}
