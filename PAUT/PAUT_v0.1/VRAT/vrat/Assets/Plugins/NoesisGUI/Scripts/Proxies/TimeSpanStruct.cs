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

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct TimeSpanStruct {

  [MarshalAs(UnmanagedType.I8)]
  private long _ticks;

  public long Ticks { get { return this._ticks; } }

  public static implicit operator System.TimeSpan(TimeSpanStruct n) {
    return new System.TimeSpan(n.Ticks);
  }

  public static implicit operator TimeSpanStruct(System.TimeSpan n) {
    return new TimeSpanStruct(n.Ticks);
  }

  public TimeSpanStruct(long ticks) {
    this._ticks = ticks;
  }
  
  public static TimeSpanStruct operator+(TimeSpanStruct t0, TimeSpanStruct t1) {
    long ticks = t0._ticks + t1._ticks;
    if (t0._ticks >> 63 == t1._ticks >> 63 && t0._ticks >> 63 != ticks >> 63) {
      throw new OverflowException("TimeSpan overflow");
    }
    return new TimeSpanStruct(ticks);
  }

  public static TimeSpanStruct operator-(TimeSpanStruct t0, TimeSpanStruct t1) {
    long ticks = t0._ticks - t1._ticks;
    if (t0._ticks >> 63 == t1._ticks >> 63 && t0._ticks >> 63 != ticks >> 63) {
      throw new OverflowException("TimeSpan overflow");
    }
    return new TimeSpanStruct(ticks);
  }

  public static bool operator==(TimeSpanStruct t0, TimeSpanStruct t1) {
    return t0._ticks == t1._ticks;
  }

  public static bool operator!=(TimeSpanStruct t0, TimeSpanStruct t1) {
    return !(t0 == t1);
  }

  public static bool operator<(TimeSpanStruct t0, TimeSpanStruct t1) {
    return t0._ticks < t1._ticks;
  }

  public static bool operator<=(TimeSpanStruct t0, TimeSpanStruct t1) {
    return t0._ticks <= t1._ticks;
  }

  public static bool operator>(TimeSpanStruct t0, TimeSpanStruct t1) {
    return t0._ticks > t1._ticks;
  }

  public static bool operator>=(TimeSpanStruct t0, TimeSpanStruct t1) {
    return t0._ticks >= t1._ticks;
  }

  public override bool Equals(System.Object obj) {
    return obj is TimeSpanStruct && this == (TimeSpanStruct)obj;
  }

  public bool Equals(TimeSpanStruct v) {
    return this == v;
  }

  public override int GetHashCode() {
    return (int)this._ticks ^ (int)(this._ticks >> 32);
  }

}

}

