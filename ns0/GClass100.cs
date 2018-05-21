// Decompiled with JetBrains decompiler
// Type: ns0.GClass100
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ns0
{
  public sealed class GClass100 : IDisposable
  {
    private byte[] byte_3 = new byte[64];
    private byte[] byte_4 = new byte[60];
    private byte[] byte_6 = new byte[58];
    private byte[] byte_7 = new byte[256];
    private uint uint_1 = 65537;
    private uint uint_0;
    private ushort ushort_2;
    private byte byte_2;
    private List<GClass101> list_0;
    private ushort ushort_3;
    private ushort ushort_4;
    private ushort ushort_5;
    private byte byte_5;
    private ushort ushort_6;
    private byte byte_8;
    private uint uint_2;
    private byte byte_9;
    private bool bool_0;

    public static byte[] Byte_0
    {
      get
      {
        return GClass97.byte_0;
      }
    }

    public byte[] Certificate1 { get; } = new byte[1024];

    public byte[] Certificate2 { get; } = new byte[768];

    public GClass101[] GClass101_0
    {
      get
      {
        return this.list_0.ToArray();
      }
      set
      {
        this.list_0 = new List<GClass101>((IEnumerable<GClass101>) value);
        this.NumOfContents = (ushort) value.Length;
      }
    }

    public ushort NumOfContents { get; private set; }

    public ulong TitleId { get; set; }

    public ushort TitleVersion { get; set; }

    private void method_0(Stream stream_0, GEnum3 genum3_0)
    {
      stream_0.Seek(0L, SeekOrigin.Begin);
      byte[] buffer1 = new byte[8];
      stream_0.Read(buffer1, 0, 4);
      this.uint_1 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
      stream_0.Read(this.byte_7, 0, this.byte_7.Length);
      stream_0.Read(this.byte_4, 0, this.byte_4.Length);
      stream_0.Read(this.byte_3, 0, this.byte_3.Length);
      stream_0.Read(buffer1, 0, 4);
      this.byte_9 = buffer1[0];
      this.byte_2 = buffer1[1];
      this.byte_8 = buffer1[2];
      this.byte_5 = buffer1[3];
      stream_0.Read(buffer1, 0, 8);
      stream_0.Read(buffer1, 0, 8);
      this.TitleId = GClass27.smethod_6(BitConverter.ToUInt64(buffer1, 0));
      stream_0.Read(buffer1, 0, 4);
      this.uint_2 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
      stream_0.Read(buffer1, 0, 2);
      this.ushort_3 = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 0));
      stream_0.Read(buffer1, 0, 2);
      this.ushort_4 = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 0));
      stream_0.Read(buffer1, 0, 2);
      this.ushort_6 = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 0));
      stream_0.Read(this.byte_6, 0, this.byte_6.Length);
      stream_0.Read(buffer1, 0, 4);
      this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
      stream_0.Read(buffer1, 0, 8);
      this.TitleVersion = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 0));
      this.NumOfContents = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 2));
      this.ushort_2 = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 4));
      this.ushort_5 = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 6));
      if (genum3_0 != GEnum3.const_3)
        stream_0.Position = 2820L;
      this.list_0 = new List<GClass101>();
      for (int index = 0; index < (int) this.NumOfContents; ++index)
      {
        GClass101 gclass101;
        if (genum3_0 != GEnum3.const_1 && genum3_0 != GEnum3.const_3)
        {
          if (genum3_0 != GEnum3.const_0)
            throw new NotImplementedException();
          GClass102 gclass102 = new GClass102();
          gclass102.Hash = new byte[32];
          gclass101 = (GClass101) gclass102;
        }
        else
        {
          GClass103 gclass103 = new GClass103();
          gclass103.Hash = new byte[20];
          gclass101 = (GClass101) gclass103;
        }
        stream_0.Read(buffer1, 0, 8);
        gclass101.ContentId = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        gclass101.Index = GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 4));
        gclass101.GEnum6_0 = (GEnum6) GClass27.smethod_4(BitConverter.ToUInt16(buffer1, 6));
        stream_0.Read(buffer1, 0, 8);
        gclass101.Size = new DataSize(GClass27.smethod_6(BitConverter.ToUInt64(buffer1, 0)));
        stream_0.Read(gclass101.Hash, 0, gclass101.Hash.Length);
        this.list_0.Add(gclass101);
        if (genum3_0 == GEnum3.const_1)
        {
          byte[] buffer2 = new byte[12];
          stream_0.Read(buffer2, 0, 12);
        }
      }
      stream_0.Read(this.Certificate1, 0, this.Certificate1.Length);
      stream_0.Read(this.Certificate2, 0, this.Certificate2.Length);
    }

    public void Dispose()
    {
      this.method_1(true);
      GC.SuppressFinalize((object) this);
    }

    ~GClass100()
    {
      this.method_1(false);
    }

    private void method_1(bool bool_1)
    {
      if (bool_1 && !this.bool_0)
      {
        this.byte_7 = (byte[]) null;
        this.byte_4 = (byte[]) null;
        this.byte_3 = (byte[]) null;
        this.byte_6 = (byte[]) null;
        this.list_0.Clear();
        this.list_0 = (List<GClass101>) null;
      }
      this.bool_0 = true;
    }

    public DataSize DataSize_0
    {
      get
      {
        return ((IEnumerable<GClass101>) this.GClass101_0).Aggregate<GClass101, DataSize>(new DataSize(0UL), (Func<DataSize, GClass101, DataSize>) ((dataSize_0, gclass101_0) => dataSize_0 + (gclass101_0.Size + 20UL * (gclass101_0.Size.TotalBytes / 256000000UL))));
      }
    }

    public static GClass100 smethod_0(string string_0, GEnum3 genum3_0)
    {
      return GClass100.smethod_1(File.ReadAllBytes(string_0), genum3_0);
    }

    public static GClass100 smethod_1(byte[] byte_10, GEnum3 genum3_0)
    {
      GClass100 gclass100 = new GClass100();
      MemoryStream memoryStream = new MemoryStream(byte_10);
      try
      {
        gclass100.method_0((Stream) memoryStream, genum3_0);
      }
      catch
      {
        memoryStream.Dispose();
        throw;
      }
      memoryStream.Dispose();
      return gclass100;
    }
  }
}
