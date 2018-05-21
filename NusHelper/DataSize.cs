// Decompiled with JetBrains decompiler
// Type: NusHelper.DataSize
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace NusHelper
{
  public struct DataSize : IComparable<DataSize>, IComparable
  {
    public DataSize(ulong sz)
    {
      this.TotalBytes = sz;
    }

    public ulong TotalBytes { get; }

    public static explicit operator DataSize(string number)
    {
      return new DataSize(ulong.Parse(number));
    }

    public static DataSize operator -(DataSize size1, DataSize size2)
    {
      if (size2.TotalBytes >= size1.TotalBytes)
        return new DataSize(0UL);
      return new DataSize(size1.TotalBytes - size2.TotalBytes);
    }

    public static bool operator !=(DataSize size1, ulong size2)
    {
      return (long) size1.TotalBytes != (long) size2;
    }

    public static bool operator !=(DataSize size1, DataSize size2)
    {
      return (long) size1.TotalBytes != (long) size2.TotalBytes;
    }

    public static DataSize operator +(DataSize size, ulong bt)
    {
      return new DataSize(size.TotalBytes + bt);
    }

    public static DataSize operator +(DataSize size, DataSize bt)
    {
      return new DataSize(size.TotalBytes + bt.TotalBytes);
    }

    public static DataSize operator +(ulong bt, DataSize size)
    {
      return new DataSize(size.TotalBytes + bt);
    }

    public static bool operator ==(DataSize size1, DataSize size2)
    {
      return (long) size1.TotalBytes == (long) size2.TotalBytes;
    }

    public static bool operator ==(DataSize size1, ulong size2)
    {
      return (long) size1.TotalBytes == (long) size2;
    }

    public int CompareTo(DataSize other)
    {
      return this.TotalBytes.CompareTo(other.TotalBytes);
    }

    public int CompareTo(object obj)
    {
      if (obj is DataSize)
        return this.TotalBytes.CompareTo(((DataSize) obj).TotalBytes);
      return -1;
    }

    public DataSize Diff(DataSize size2)
    {
      return new DataSize((ulong) Math.Abs((long) this.TotalBytes - (long) size2.TotalBytes));
    }

    public override bool Equals(object obj)
    {
      if (obj is DataSize)
        return (long) ((DataSize) obj).TotalBytes == (long) this.TotalBytes;
      return false;
    }

    public override string ToString()
    {
      if ((double) this.TotalBytes < Math.Pow(10.0, 6.0))
        return ((double) this.TotalBytes / Math.Pow(10.0, 3.0)).ToString("F3") + " KB";
      if ((double) this.TotalBytes < Math.Pow(10.0, 9.0))
        return ((double) this.TotalBytes / Math.Pow(10.0, 6.0)).ToString("F3") + " MB";
      if ((double) this.TotalBytes < Math.Pow(10.0, 12.0))
        return ((double) this.TotalBytes / Math.Pow(10.0, 9.0)).ToString("F3") + " GB";
      return ((double) this.TotalBytes / Math.Pow(10.0, 12.0)).ToString("F3") + " TB";
    }
  }
}
