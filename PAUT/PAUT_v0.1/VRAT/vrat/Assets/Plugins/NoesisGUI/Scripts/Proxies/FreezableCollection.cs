/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class FreezableCollection : Freezable {
  internal new static FreezableCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new FreezableCollection(cPtr, cMemoryOwn);
  }

  internal FreezableCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(FreezableCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  private struct CollectionEnumerator : System.Collections.IEnumerator {
    object System.Collections.IEnumerator.Current {
      get { return Current; }
    }
    public object Current {
      get { return this._collection[(uint)this._index]; }
    }
    public bool MoveNext() {
      if (++this._index >= (int)this._collection.Count) {
        return false;
      }
      return true;
    }
    public void Reset() {
      this._index = -1;
    }
    public CollectionEnumerator(FreezableCollection c) {
      this._collection = c;
      this._index = -1;
    }
    private FreezableCollection _collection;
    private int _index;
  }

  public System.Collections.IEnumerator GetEnumerator() {
    return new CollectionEnumerator(this);
  }

  public object this[uint index] {
    get {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      return Get(index);
    }
    set {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      Set(index, value);
    }
  }

  public FreezableCollection() {
  }

  protected override System.IntPtr CreateCPtr(System.Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_FreezableCollection__SWIG_0();
  }

  public object Get(uint index) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FreezableCollection_Get(swigCPtr, index);
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public void Set(uint index, object item) {
    NoesisGUI_PINVOKE.FreezableCollection_Set(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
  }

  public uint Add(object item) {
    uint ret = NoesisGUI_PINVOKE.FreezableCollection_Add(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
    return ret;
  }

  public void Clear() {
    NoesisGUI_PINVOKE.FreezableCollection_Clear(swigCPtr);
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
  }

  public bool Contains(object item) {
    bool ret = NoesisGUI_PINVOKE.FreezableCollection_Contains(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
    return ret;
  }

  public int IndexOf(object item) {
    int ret = NoesisGUI_PINVOKE.FreezableCollection_IndexOf(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
    return ret;
  }

  public void Insert(uint index, object item) {
    NoesisGUI_PINVOKE.FreezableCollection_Insert(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
  }

  public void Remove(object item) {
    NoesisGUI_PINVOKE.FreezableCollection_Remove(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
  }

  public void RemoveAt(uint index) {
    NoesisGUI_PINVOKE.FreezableCollection_RemoveAt(swigCPtr, index);
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
  }

  public uint Count {
    get {
      uint ret = NoesisGUI_PINVOKE.FreezableCollection_Count_get(swigCPtr);
      #if UNITY_EDITOR || NOESIS_API
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      #endif
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.FreezableCollection_GetStaticType();
    #if UNITY_EDITOR || NOESIS_API
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    #endif
    return ret;
  }

}

}
