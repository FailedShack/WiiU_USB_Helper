// Decompiled with JetBrains decompiler
// Type: ns0.Class5
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0
{
  internal class Class5
  {
    private static readonly MemoryStream memoryStream_0 = (MemoryStream) null;
    private static readonly MemoryStream memoryStream_1 = (MemoryStream) null;
    private static readonly int int_0 = int.MaxValue;
    private static readonly int int_1 = int.MinValue;
    private static readonly object object_0;
    private static readonly byte byte_0;

    static Class5()
    {
      Class5.memoryStream_0 = new MemoryStream(0);
      Class5.memoryStream_1 = new MemoryStream(0);
      Class5.object_0 = new object();
    }

    private static string smethod_0(Assembly assembly_0)
    {
      string str = assembly_0.FullName;
      int length = str.IndexOf(',');
      if (length >= 0)
        str = str.Substring(0, length);
      return str;
    }

    private static byte[] smethod_1(Assembly assembly_0)
    {
      try
      {
        string fullName = assembly_0.FullName;
        int num = fullName.IndexOf("PublicKeyToken=");
        if (num < 0)
          num = fullName.IndexOf("publickeytoken=");
        if (num < 0)
          return (byte[]) null;
        int startIndex = num + 15;
        if (fullName[startIndex] == 'n' || fullName[startIndex] == 'N')
          return (byte[]) null;
        byte[] bytes = BitConverter.GetBytes(long.Parse(fullName.Substring(startIndex, 16), NumberStyles.HexNumber));
        Array.Reverse((Array) bytes);
        return bytes;
      }
      catch
      {
      }
      return (byte[]) null;
    }

    internal static byte[] smethod_2(Stream stream_0)
    {
      lock (Class5.object_0)
        return Class5.smethod_4(97L, stream_0);
    }

    internal static byte[] smethod_3(long long_0, Stream stream_0)
    {
      try
      {
        return Class5.smethod_2(stream_0);
      }
      catch (HostProtectionException ex)
      {
        return Class5.smethod_4(97L, stream_0);
      }
    }

    internal static byte[] smethod_4(long long_0, Stream stream_0)
    {
      Stream stream = stream_0;
      MemoryStream memoryStream = (MemoryStream) null;
      for (int index = 1; index < 4; ++index)
        stream_0.ReadByte();
      ushort num1 = ~(ushort) stream_0.ReadByte();
      if (((int) num1 & 2) != 0)
      {
        DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
        byte[] buffer1 = new byte[8];
        stream_0.Read(buffer1, 0, 8);
        cryptoServiceProvider.IV = buffer1;
        byte[] buffer2 = new byte[8];
        stream_0.Read(buffer2, 0, 8);
        bool flag = true;
        foreach (byte num2 in buffer2)
        {
          if (num2 != (byte) 0)
          {
            flag = false;
            break;
          }
        }
        if (flag)
          buffer2 = Class5.smethod_1(Assembly.GetExecutingAssembly());
        cryptoServiceProvider.Key = buffer2;
        if (Class5.memoryStream_0 == null)
          Class5.memoryStream_0.Capacity = Class5.int_0 != int.MaxValue ? Class5.int_0 : (int) stream_0.Length;
        Class5.memoryStream_0.Position = 0L;
        ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor();
        int inputBlockSize = decryptor.InputBlockSize;
        int outputBlockSize = decryptor.OutputBlockSize;
        byte[] numArray1 = new byte[decryptor.OutputBlockSize];
        byte[] numArray2 = new byte[decryptor.InputBlockSize];
        int position = (int) stream_0.Position;
        while ((long) (position + inputBlockSize) < stream_0.Length)
        {
          stream_0.Read(numArray2, 0, inputBlockSize);
          int count = decryptor.TransformBlock(numArray2, 0, inputBlockSize, numArray1, 0);
          Class5.memoryStream_0.Write(numArray1, 0, count);
          position += inputBlockSize;
        }
        stream_0.Read(numArray2, 0, (int) (stream_0.Length - (long) position));
        byte[] buffer3 = decryptor.TransformFinalBlock(numArray2, 0, (int) (stream_0.Length - (long) position));
        Class5.memoryStream_0.Write(buffer3, 0, buffer3.Length);
        stream = (Stream) Class5.memoryStream_0;
        stream.Position = 0L;
        memoryStream = Class5.memoryStream_0;
      }
      if (((int) num1 & 8) != 0)
      {
        if (Class5.memoryStream_1 == null)
          Class5.memoryStream_1.Capacity = Class5.int_1 != int.MinValue ? Class5.int_1 : (int) stream.Length * 2;
        Class5.memoryStream_1.Position = 0L;
        DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
        int count1 = 1000;
        byte[] buffer = new byte[1000];
        int count2;
        do
        {
          count2 = deflateStream.Read(buffer, 0, count1);
          if (count2 > 0)
            goto label_22;
label_21:
          continue;
label_22:
          Class5.memoryStream_1.Write(buffer, 0, count2);
          goto label_21;
        }
        while (count2 >= count1);
        memoryStream = Class5.memoryStream_1;
      }
      if (memoryStream != null)
        return memoryStream.ToArray();
      byte[] buffer4 = new byte[stream_0.Length - stream_0.Position];
      stream_0.Read(buffer4, 0, buffer4.Length);
      return buffer4;
    }
  }
}
