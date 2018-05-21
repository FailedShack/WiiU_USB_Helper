// Decompiled with JetBrains decompiler
// Type: ns0.GClass108
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;

namespace ns0
{
  public class GClass108
  {
    private uint uint_0 = 2560;
    private uint uint_3 = 32;
    private uint uint_5 = 676;
    private uint uint_7 = 1232273408;
    private uint uint_1;
    private uint uint_2;
    private uint uint_4;
    private uint uint_6;

    public uint UInt32_0
    {
      get
      {
        return this.uint_1;
      }
      set
      {
        this.uint_1 = value;
      }
    }

    public uint UInt32_1
    {
      get
      {
        return this.uint_2;
      }
      set
      {
        this.uint_2 = value;
      }
    }

    public uint UInt32_2
    {
      get
      {
        return this.uint_6;
      }
      set
      {
        this.uint_6 = value;
      }
    }

    public void method_0(Stream stream_0)
    {
      stream_0.Seek(0L, SeekOrigin.Begin);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_3)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_7)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_4)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_5)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_6)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
      stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_2)), 0, 4);
    }
  }
}
