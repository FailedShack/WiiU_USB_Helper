// Decompiled with JetBrains decompiler
// Type: ns0.Class9
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ns0
{
  internal class Class9
  {
    private readonly byte[] byte_0 = new byte[65536];
    private readonly Dictionary<uint, Stream> dictionary_0 = new Dictionary<uint, Stream>();
    private byte[] byte_1 = new byte[32768];
    private readonly GClass30 gclass30_0;
    private int int_0;
    private GClass13 gclass13_0;
    private GClass99 gclass99_0;
    private GClass100 gclass100_0;
    private int int_1;
    private ulong ulong_0;
    private ulong ulong_1;

    public Class9(GClass30 gclass30_1)
    {
      if (gclass30_1.System != GEnum3.const_1)
        throw new Exception("This can only be used on WUP titles.");
      this.gclass30_0 = gclass30_1;
    }

    public event EventHandler<bool> Event_0;

    public event EventHandler<GStruct0> Event_1;

    public byte[] method_0(GClass12 gclass12_0, ulong ulong_2 = 0)
    {
      if (this.gclass100_0 == null || this.gclass99_0 == null)
      {
        this.gclass100_0 = GClass100.smethod_1(new GClass78().method_2(this.gclass30_0.String_1 + "tmd"), GEnum3.const_1);
        this.gclass99_0 = this.method_5();
      }
      if (gclass12_0.bool_1 || gclass12_0.bool_0)
        return (byte[]) null;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        this.method_2(gclass12_0, (Stream) memoryStream, true, ulong_2);
        return memoryStream.ToArray();
      }
    }

    public void method_1(string string_0, bool bool_0 = false, List<GClass12> list_0 = null, bool bool_1 = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(new Class9.Class10()
      {
        class9_0 = this,
        bool_0 = bool_0,
        list_0 = list_0,
        bool_1 = bool_1,
        string_0 = string_0
      }.method_0));
    }

    public event EventHandler<Exception> Event_2;

    private void method_2(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0)
    {
      if (this.gclass100_0.GClass101_0[(int) gclass12_0.short_0].Boolean_0)
        this.method_3(gclass12_0, stream_0, bool_0, ulong_2);
      else
        this.method_4(gclass12_0, stream_0, bool_0, ulong_2);
    }

    private void method_3(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0)
    {
      uint contentId = this.gclass100_0.GClass101_0[(int) gclass12_0.short_0].ContentId;
      byte[] numArray1 = new byte[65536];
      long uint1 = (long) gclass12_0.uint_1;
      ulong uint2 = (ulong) gclass12_0.uint_2;
      ulong num1 = 0;
      ulong num2 = 64512;
      ulong num3 = (ulong) uint1 / 64512UL * 65536UL;
      int num4 = (int) (num3 / 65536UL);
      ulong num5 = (ulong) (uint1 - (long) ((ulong) uint1 / 64512UL) * 64512L);
      if (num5 + uint2 > num2)
        num2 -= num5;
      Stream responseStream;
      if (bool_0)
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.gclass30_0.String_1 + contentId.ToString("x8"));
        httpWebRequest.Method = "GET";
        httpWebRequest.AddRange((long) num3);
        responseStream = httpWebRequest.GetResponse().GetResponseStream();
      }
      else
        responseStream = this.dictionary_0[contentId];
      byte[] numArray2 = new byte[16];
      numArray2[1] = (byte) gclass12_0.short_0;
      byte[] numArray3 = numArray2;
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Key = this.gclass99_0.Byte_0;
        cryptoServiceProvider.Mode = CipherMode.CBC;
        cryptoServiceProvider.Padding = PaddingMode.None;
        cryptoServiceProvider.IV = numArray3;
        if (!bool_0)
          responseStream.Seek((long) num3, SeekOrigin.Begin);
        while (uint2 > 0UL)
        {
          if (num2 > uint2)
            num2 = uint2;
          responseStream.smethod_4(numArray1, 65536);
          byte[] numArray4 = new byte[16];
          numArray4[1] = (byte) gclass12_0.short_0;
          byte[] rgbIV = numArray4;
          byte[] numArray5 = new byte[20];
          byte[] numArray6;
          using (ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, rgbIV))
            numArray6 = decryptor.TransformFinalBlock(numArray1, 0, 1024);
          numArray6[1] ^= (byte) gclass12_0.short_0;
          Buffer.BlockCopy((Array) numArray6, num4 % 16 * 20, (Array) rgbIV, 0, 16);
          using (ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, rgbIV))
            decryptor.TransformBlock(numArray1, 1024, 64512, this.byte_0, 0);
          uint2 -= num2;
          stream_0.Write(this.byte_0, (int) num5, (int) num2);
          this.ulong_1 += num2;
          if (ulong_2 > 0UL)
          {
            if (this.ulong_1 >= ulong_2)
              break;
          }
          this.method_9();
          num1 += num2;
          ++num4;
          if (num5 != 0UL)
          {
            num2 = 64512UL;
            num5 = 0UL;
          }
        }
      }
      if (!bool_0)
        return;
      responseStream.Close();
    }

    private void method_4(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0)
    {
      uint contentId = this.gclass100_0.GClass101_0[(int) gclass12_0.short_0].ContentId;
      ulong uint1 = (ulong) gclass12_0.uint_1;
      ulong uint2 = (ulong) gclass12_0.uint_2;
      byte[] numArray = new byte[16];
      numArray[1] = (byte) gclass12_0.short_0;
      byte[] rgbIV = numArray;
      Stream responseStream;
      if (bool_0)
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.gclass30_0.String_1 + contentId.ToString("x8"));
        httpWebRequest.AddRange((long) uint1);
        responseStream = httpWebRequest.GetResponse().GetResponseStream();
      }
      else
        responseStream = this.dictionary_0[contentId];
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Key = this.gclass99_0.Byte_0;
        cryptoServiceProvider.Mode = CipherMode.CBC;
        cryptoServiceProvider.Padding = PaddingMode.None;
        if (!bool_0)
          responseStream.Seek((long) uint1, SeekOrigin.Begin);
        int num1 = (int) this.method_7((long) uint2, 16L);
        if (ulong_2 > 0UL)
        {
          long num2 = this.method_7((long) ulong_2, 16L);
          if (num2 < (long) num1)
            num1 = (int) num2;
        }
        byte[] inputBuffer = responseStream.smethod_3(num1, (Action<int>) (int_2 =>
        {
          this.ulong_1 += (ulong) int_2;
          this.method_9();
        }));
        byte[] buffer;
        using (ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, rgbIV))
          buffer = decryptor.TransformFinalBlock(inputBuffer, 0, num1);
        if (ulong_2 > 0UL)
          stream_0.Write(buffer, 0, num1);
        else
          stream_0.Write(buffer, 0, (int) uint2);
      }
      if (!bool_0)
        return;
      responseStream.Close();
    }

    private GClass99 method_5()
    {
      if (this.gclass30_0 is GClass33 || this.gclass30_0.Platform == Platform.Wii_U_Custom)
        return GClass99.smethod_7(new GClass78().method_2(this.gclass30_0.String_1 + "cetk"), GEnum3.const_1);
      if (this.gclass30_0.bool_0)
        return GClass99.smethod_7(new GClass78().method_2(this.gclass30_0.string_0), GEnum3.const_1);
      return GClass99.smethod_7(this.gclass30_0.TicketArray, GEnum3.const_1);
    }

    private GClass100 method_6()
    {
      if (this.gclass30_0 is GClass33)
        return GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd.{1}", (object) this.gclass30_0.String_1, (object) this.gclass30_0.Version)), GEnum3.const_1);
      return GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd", (object) this.gclass30_0.String_1)), GEnum3.const_1);
    }

    private long method_7(long long_0, long long_1)
    {
      if (long_0 % long_1 == 0L)
        return long_0;
      return (long_0 / long_1 + 1L) * long_1;
    }

    private string method_8(string string_0)
    {
      return Path.Combine(this.gclass30_0.OutputPath, string_0);
    }

    private void method_9()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<GStruct0> eventHandler1 = this.eventHandler_1;
      if (eventHandler1 == null)
        return;
      eventHandler1((object) this, new GStruct0()
      {
        int_1 = (int) ((double) this.ulong_1 / (double) this.ulong_0 * 100.0),
        int_0 = this.int_0,
        int_2 = this.int_1
      });
    }

    private void method_10()
    {
      foreach (Stream stream in this.dictionary_0.Values)
      {
        try
        {
          stream.Close();
        }
        catch
        {
        }
      }
    }
  }
}
