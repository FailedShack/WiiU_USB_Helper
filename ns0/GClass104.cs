// Decompiled with JetBrains decompiler
// Type: ns0.GClass104
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;
using System.Security.Cryptography;

namespace ns0
{
  public class GClass104
  {
    private static uint uint_0 = 1229800501;
    private static uint uint_1 = 1229800788;

    public static GClass104.GEnum7 smethod_0(byte[] byte_0)
    {
      if (byte_0.Length > 68 && (int) GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 64)) == (int) GClass104.uint_1)
        return GClass104.GEnum7.const_1;
      if (byte_0.Length > 132 && (int) GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 128)) == (int) GClass104.uint_1)
        return GClass104.GEnum7.const_2;
      return byte_0.Length > 4 && (int) GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 0)) == (int) GClass104.uint_0 ? GClass104.GEnum7.const_3 : GClass104.GEnum7.const_0;
    }

    public static GClass104.GEnum7 smethod_1(Stream stream_0)
    {
      byte[] buffer = new byte[4];
      if (stream_0.Length > 68L)
      {
        stream_0.Seek(64L, SeekOrigin.Begin);
        stream_0.Read(buffer, 0, buffer.Length);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer, 0)) == (int) GClass104.uint_1)
          return GClass104.GEnum7.const_1;
      }
      if (stream_0.Length > 132L)
      {
        stream_0.Seek(128L, SeekOrigin.Begin);
        stream_0.Read(buffer, 0, buffer.Length);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer, 0)) == (int) GClass104.uint_1)
          return GClass104.GEnum7.const_2;
      }
      if (stream_0.Length > 4L)
      {
        stream_0.Seek(0L, SeekOrigin.Begin);
        stream_0.Read(buffer, 0, buffer.Length);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer, 0)) == (int) GClass104.uint_0)
          return GClass104.GEnum7.const_3;
      }
      return GClass104.GEnum7.const_0;
    }

    public enum GEnum7
    {
      const_0 = 0,
      const_3 = 32, // 0x00000020
      const_1 = 1536, // 0x00000600
      const_2 = 1600, // 0x00000640
    }

    public class GClass105
    {
      private byte[] byte_0 = new byte[16];
      private uint uint_1 = 1229800501;
      private byte[] byte_1 = new byte[8];
      private uint uint_0;

      private GClass105()
      {
      }

      public uint UInt32_0
      {
        get
        {
          return this.uint_0;
        }
      }

      public byte[] Byte_0
      {
        get
        {
          return this.byte_0;
        }
      }

      public static byte[] smethod_0(byte[] byte_2)
      {
        GClass104.GClass105 gclass105 = GClass104.GClass105.smethod_1(byte_2);
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = memoryStream1;
        gclass105.method_4((Stream) memoryStream2);
        memoryStream1.Write(byte_2, 0, byte_2.Length);
        byte[] array = memoryStream1.ToArray();
        memoryStream1.Dispose();
        return array;
      }

      public static GClass104.GClass105 smethod_1(byte[] byte_2)
      {
        GClass104.GClass105 gclass105 = new GClass104.GClass105();
        gclass105.uint_0 = (uint) byte_2.Length;
        gclass105.method_2(byte_2);
        return gclass105;
      }

      public static GClass104.GClass105 smethod_2(Stream stream_0)
      {
        if (GClass104.smethod_1(stream_0) != GClass104.GEnum7.const_3)
          throw new Exception("No IMD5 Header found!");
        GClass104.GClass105 gclass105 = new GClass104.GClass105();
        gclass105.method_3(stream_0);
        return gclass105;
      }

      public MemoryStream method_0()
      {
        MemoryStream memoryStream = new MemoryStream();
        try
        {
          this.method_4((Stream) memoryStream);
        }
        catch
        {
          memoryStream.Dispose();
          throw;
        }
        return memoryStream;
      }

      public void method_1(Stream stream_0)
      {
        this.method_4(stream_0);
      }

      private void method_2(byte[] byte_2)
      {
        MD5 md5 = MD5.Create();
        this.byte_0 = md5.ComputeHash(byte_2);
        md5.Clear();
      }

      private void method_3(Stream stream_0)
      {
        stream_0.Seek(0L, SeekOrigin.Begin);
        byte[] buffer = new byte[4];
        stream_0.Read(buffer, 0, 4);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer, 0)) != (int) this.uint_1)
          throw new Exception("Invalid Magic!");
        stream_0.Read(buffer, 0, 4);
        this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(buffer, 0));
        stream_0.Read(this.byte_1, 0, this.byte_1.Length);
        stream_0.Read(this.byte_0, 0, this.byte_0.Length);
      }

      private void method_4(Stream stream_0)
      {
        stream_0.Seek(0L, SeekOrigin.Begin);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
        stream_0.Write(this.byte_1, 0, this.byte_1.Length);
        stream_0.Write(this.byte_0, 0, this.byte_0.Length);
      }
    }

    public class GClass106
    {
      private byte[] byte_0 = new byte[64];
      private byte[] byte_1 = new byte[84];
      private byte[] byte_2 = new byte[84];
      private byte[] byte_3 = new byte[84];
      private byte[] byte_4 = new byte[84];
      private byte[] byte_5 = new byte[16];
      private bool bool_0 = true;
      private uint uint_3 = 1229800788;
      private byte[] byte_6 = new byte[84];
      private byte[] byte_7 = new byte[84];
      private byte[] byte_8 = new byte[84];
      private byte[] byte_9 = new byte[64];
      private byte[] byte_10 = new byte[588];
      private uint uint_4 = 1536;
      private byte[] byte_11 = new byte[84];
      private uint uint_6 = 3;
      private byte[] byte_12 = new byte[84];
      private byte[] byte_13 = new byte[84];
      private uint uint_0;
      private uint uint_1;
      private uint uint_2;
      private bool bool_1;
      private uint uint_5;

      public uint UInt32_0
      {
        get
        {
          return this.uint_0;
        }
        set
        {
          this.uint_0 = value;
        }
      }

      public string String_0
      {
        get
        {
          return this.method_3(this.byte_1);
        }
        set
        {
          this.method_4(value, 6);
        }
      }

      public string String_1
      {
        get
        {
          return this.method_3(this.byte_2);
        }
        set
        {
          this.method_4(value, 1);
        }
      }

      public string String_2
      {
        get
        {
          return this.method_3(this.byte_3);
        }
        set
        {
          this.method_4(value, 3);
        }
      }

      public string String_3
      {
        get
        {
          return this.method_3(this.byte_4);
        }
        set
        {
          this.method_4(value, 2);
        }
      }

      public bool Boolean_0
      {
        get
        {
          return this.bool_0;
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

      public bool Boolean_1
      {
        get
        {
          return this.bool_1;
        }
        set
        {
          this.bool_1 = value;
        }
      }

      public string String_4
      {
        get
        {
          return this.method_3(this.byte_6);
        }
        set
        {
          this.method_4(value, 5);
        }
      }

      public string String_5
      {
        get
        {
          return this.method_3(this.byte_7);
        }
        set
        {
          this.method_4(value, 0);
        }
      }

      public string String_6
      {
        get
        {
          return this.method_3(this.byte_8);
        }
        set
        {
          this.method_4(value, 7);
        }
      }

      public uint UInt32_2
      {
        get
        {
          return this.uint_5;
        }
        set
        {
          this.uint_5 = value;
        }
      }

      public string String_7
      {
        get
        {
          return this.method_3(this.byte_11);
        }
        set
        {
          this.method_4(value, 4);
        }
      }

      public static GClass104.GClass106 smethod_0(Stream stream_0)
      {
        GClass104.GEnum7 genum7 = GClass104.smethod_1(stream_0);
        switch (genum7)
        {
          case GClass104.GEnum7.const_1:
          case GClass104.GEnum7.const_2:
            GClass104.GClass106 gclass106 = new GClass104.GClass106();
            if (genum7 == GClass104.GEnum7.const_1)
              gclass106.bool_1 = true;
            gclass106.method_2(stream_0);
            return gclass106;
          default:
            throw new Exception("No IMET Header found!");
        }
      }

      public void method_0(Stream stream_0)
      {
        this.method_5(stream_0);
      }

      private void method_1(byte[] byte_14, int int_0)
      {
        MD5 md5 = MD5.Create();
        this.byte_5 = md5.ComputeHash(byte_14, int_0, 1536);
        md5.Clear();
      }

      private void method_2(Stream stream_0)
      {
        stream_0.Seek(0L, SeekOrigin.Begin);
        byte[] buffer1 = new byte[4];
        if (!this.bool_1)
          stream_0.Read(this.byte_0, 0, this.byte_0.Length);
        stream_0.Read(this.byte_9, 0, this.byte_9.Length);
        stream_0.Read(buffer1, 0, 4);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0)) != (int) this.uint_3)
          throw new Exception("Invalid Magic!");
        stream_0.Read(buffer1, 0, 4);
        if ((int) GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0)) != (int) this.uint_4)
          throw new Exception("Invalid Header Size!");
        stream_0.Read(buffer1, 0, 4);
        this.uint_6 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        stream_0.Read(buffer1, 0, 4);
        this.uint_2 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        stream_0.Read(buffer1, 0, 4);
        this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        stream_0.Read(buffer1, 0, 4);
        this.uint_5 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        stream_0.Read(buffer1, 0, 4);
        this.uint_1 = GClass27.smethod_5(BitConverter.ToUInt32(buffer1, 0));
        stream_0.Read(this.byte_7, 0, this.byte_7.Length);
        stream_0.Read(this.byte_2, 0, this.byte_2.Length);
        stream_0.Read(this.byte_4, 0, this.byte_4.Length);
        stream_0.Read(this.byte_3, 0, this.byte_3.Length);
        stream_0.Read(this.byte_11, 0, this.byte_11.Length);
        stream_0.Read(this.byte_6, 0, this.byte_6.Length);
        stream_0.Read(this.byte_1, 0, this.byte_1.Length);
        stream_0.Read(this.byte_12, 0, this.byte_12.Length);
        stream_0.Read(this.byte_13, 0, this.byte_13.Length);
        stream_0.Read(this.byte_8, 0, this.byte_8.Length);
        stream_0.Read(this.byte_10, 0, this.byte_10.Length);
        stream_0.Read(this.byte_5, 0, this.byte_5.Length);
        stream_0.Seek(-16L, SeekOrigin.Current);
        stream_0.Write(new byte[16], 0, 16);
        byte[] buffer2 = new byte[stream_0.Length];
        stream_0.Seek(0L, SeekOrigin.Begin);
        stream_0.Read(buffer2, 0, buffer2.Length);
        MD5 md5 = MD5.Create();
        byte[] hash = md5.ComputeHash(buffer2, this.bool_1 ? 0 : 64, 1536);
        md5.Clear();
        this.bool_0 = GClass27.smethod_1(hash, this.byte_5);
      }

      private string method_3(byte[] byte_14)
      {
        string empty = string.Empty;
        int index = 0;
        while (index < 84)
        {
          char ch = BitConverter.ToChar(new byte[2]{ byte_14[index + 1], byte_14[index] }, 0);
          if (ch != char.MinValue)
            empty += ch.ToString();
          index += 2;
        }
        return empty;
      }

      private void method_4(string string_0, int int_0)
      {
        byte[] numArray = new byte[84];
        for (int index = 0; index < string_0.Length; ++index)
        {
          byte[] bytes = BitConverter.GetBytes(string_0[index]);
          numArray[index * 2 + 1] = bytes[0];
          numArray[index * 2] = bytes[1];
        }
        switch (int_0)
        {
          case 0:
            this.byte_7 = numArray;
            break;
          case 1:
            this.byte_2 = numArray;
            break;
          case 2:
            this.byte_4 = numArray;
            break;
          case 3:
            this.byte_3 = numArray;
            break;
          case 4:
            this.byte_11 = numArray;
            break;
          case 5:
            this.byte_6 = numArray;
            break;
          case 6:
            this.byte_1 = numArray;
            break;
          case 7:
            this.byte_8 = numArray;
            break;
        }
      }

      private void method_5(Stream stream_0)
      {
        stream_0.Seek(0L, SeekOrigin.Begin);
        if (!this.bool_1)
          stream_0.Write(this.byte_0, 0, this.byte_0.Length);
        stream_0.Write(this.byte_9, 0, this.byte_9.Length);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_3)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_4)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_6)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_2)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_5)), 0, 4);
        stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
        stream_0.Write(this.byte_7, 0, this.byte_7.Length);
        stream_0.Write(this.byte_2, 0, this.byte_2.Length);
        stream_0.Write(this.byte_4, 0, this.byte_4.Length);
        stream_0.Write(this.byte_3, 0, this.byte_3.Length);
        stream_0.Write(this.byte_11, 0, this.byte_11.Length);
        stream_0.Write(this.byte_6, 0, this.byte_6.Length);
        stream_0.Write(this.byte_1, 0, this.byte_1.Length);
        stream_0.Write(this.byte_12, 0, this.byte_12.Length);
        stream_0.Write(this.byte_13, 0, this.byte_13.Length);
        stream_0.Write(this.byte_8, 0, this.byte_8.Length);
        stream_0.Write(this.byte_10, 0, this.byte_10.Length);
        int position = (int) stream_0.Position;
        this.byte_5 = new byte[16];
        stream_0.Write(this.byte_5, 0, this.byte_5.Length);
        byte[] numArray = new byte[stream_0.Position];
        stream_0.Seek(0L, SeekOrigin.Begin);
        stream_0.Read(numArray, 0, numArray.Length);
        this.method_1(numArray, this.bool_1 ? 0 : 64);
        stream_0.Seek((long) position, SeekOrigin.Begin);
        stream_0.Write(this.byte_5, 0, this.byte_5.Length);
      }
    }
  }
}
