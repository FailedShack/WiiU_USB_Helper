// Decompiled with JetBrains decompiler
// Type: ns0.Class85
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace ns0
{
  internal static class Class85
  {
    private static readonly byte[][] byte_0 = new byte[3][];
    internal const int int_0 = 65536;
    private const int int_1 = 64512;
    private const int int_2 = 1024;
    private const int int_3 = 256;
    private const int int_4 = 3;

    public static Enum3 smethod_0(byte[] byte_1, byte[] byte_2, int int_5, byte[] byte_3, byte byte_4)
    {
      byte[] numArray1 = new byte[16];
      numArray1[1] = byte_4;
      byte[] byte_3_1 = numArray1;
      SHA1 shA1 = SHA1.Create();
      byte[] byte_1_1 = new byte[1024];
      Buffer.BlockCopy((Array) byte_1, 0, (Array) byte_1_1, 0, 1024);
      byte[] numArray2 = Class85.smethod_5(byte_1_1, byte_3, byte_3_1);
      numArray2[1] ^= byte_4;
      int srcOffset1 = int_5 % 16 * 20;
      int srcOffset2 = (16 + int_5 / 16 % 16) * 20;
      int srcOffset3 = (32 + int_5 / 256 % 16) * 20;
      int srcOffset4 = int_5 / 4096 % 16 * 20;
      byte[] byte_0_1 = new byte[20];
      byte[] byte_1_2 = new byte[20];
      byte[] byte_0_2 = new byte[20];
      byte[] byte_1_3 = new byte[20];
      Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) byte_0_1, 0, 20);
      Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) byte_3_1, 0, 16);
      byte[] byte_1_4 = new byte[64512];
      Buffer.BlockCopy((Array) byte_1, 1024, (Array) byte_1_4, 0, 64512);
      byte[] buffer1 = Class85.smethod_5(byte_1_4, byte_3, byte_3_1);
      byte[] hash1 = shA1.ComputeHash(buffer1);
      if (!GClass27.smethod_1(byte_0_1, hash1))
        return Enum3.const_1;
      if (int_5 % 16 == 0)
      {
        byte[] buffer2 = new byte[320];
        Buffer.BlockCopy((Array) numArray2, srcOffset1, (Array) buffer2, 0, 320);
        Buffer.BlockCopy((Array) numArray2, srcOffset2, (Array) byte_1_2, 0, 20);
        if (!GClass27.smethod_1(shA1.ComputeHash(buffer2), byte_1_2))
          return Enum3.const_1;
      }
      if (int_5 % 256 == 0)
      {
        byte[] buffer2 = new byte[320];
        Buffer.BlockCopy((Array) numArray2, srcOffset2, (Array) buffer2, 0, 320);
        Buffer.BlockCopy((Array) numArray2, srcOffset3, (Array) byte_0_2, 0, 20);
        byte[] hash2 = shA1.ComputeHash(buffer2);
        if (!GClass27.smethod_1(byte_0_2, hash2))
          return Enum3.const_1;
      }
      if (int_5 % 4096 != 0)
        return Enum3.const_0;
      byte[] buffer3 = new byte[320];
      Buffer.BlockCopy((Array) numArray2, srcOffset3, (Array) buffer3, 0, 320);
      Buffer.BlockCopy((Array) byte_2, srcOffset4, (Array) byte_1_3, 0, 20);
      return !GClass27.smethod_1(shA1.ComputeHash(buffer3), byte_1_3) ? Enum3.const_1 : Enum3.const_0;
    }

    public static List<GStruct7> smethod_1(GClass30 gclass30_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class85.Class86 class86 = new Class85.Class86();
      // ISSUE: reference to a compiler-generated field
      class86.gclass30_0 = gclass30_0;
      // ISSUE: reference to a compiler-generated field
      string str1 = Path.Combine(class86.gclass30_0.OutputPath, "title.tmd");
      // ISSUE: reference to a compiler-generated field
      string str2 = Path.Combine(class86.gclass30_0.OutputPath, "title.tik");
      // ISSUE: reference to a compiler-generated field
      if (File.Exists(str1) && (class86.gclass30_0.Ticket != null || File.Exists(str2)))
      {
        if (!File.Exists(str1))
          return ((IEnumerable<GStruct7>) new GStruct7[1]
          {
            new GStruct7((GClass101) null, new List<int>(), false, true)
          }).ToList<GStruct7>();
        // ISSUE: reference to a compiler-generated field
        GClass100 gclass100 = GClass100.smethod_0(str1, class86.gclass30_0.System);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class86.gclass99_0 = class86.gclass30_0.Ticket ?? GClass99.smethod_6(str2, class86.gclass30_0.System);
        // ISSUE: reference to a compiler-generated method
        return ((IEnumerable<GClass101>) gclass100.GClass101_0).Select<GClass101, GStruct7>(new Func<GClass101, GStruct7>(class86.method_0)).ToList<GStruct7>();
      }
      return ((IEnumerable<GStruct7>) new GStruct7[1]
      {
        new GStruct7((GClass101) null, new List<int>(), false, true)
      }).ToList<GStruct7>();
    }

    public static void smethod_2(GClass30 gclass30_0)
    {
      if (gclass30_0.GEnum2_0 != GEnum2.const_2)
        throw new Exception("The title must have been downloaded!");
      foreach (GClass101 gclass101 in GClass100.smethod_1(File.ReadAllBytes(Path.Combine(gclass30_0.OutputPath, "title.tmd")), GEnum3.const_0).GClass101_0)
      {
        string string_0 = Path.Combine(gclass30_0.OutputPath, gclass101.ContentId.ToString("x8") + ".app");
        Class85.smethod_6(string_0, string_0 + ".dec", gclass30_0.byte_0, Class85.smethod_9(gclass101.Index));
      }
    }

    private static byte[] smethod_3(string string_0, byte[] byte_1, byte[] byte_2)
    {
      using (SHA256 shA256 = SHA256.Create())
      {
        using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
        {
          cryptoServiceProvider.Key = byte_1;
          cryptoServiceProvider.IV = byte_2;
          cryptoServiceProvider.Padding = PaddingMode.None;
          using (FileStream fileStream = File.Open(string_0, FileMode.Open))
          {
            using (CryptoStream cryptoStream = new CryptoStream((Stream) fileStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
              return shA256.ComputeHash((Stream) cryptoStream);
          }
        }
      }
    }

    public static GStruct7 smethod_4(GClass30 gclass30_0, GClass101 gclass101_0, byte[] byte_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class85.Class87 class87 = new Class85.Class87();
      // ISSUE: reference to a compiler-generated field
      class87.byte_1 = byte_1;
      // ISSUE: reference to a compiler-generated field
      class87.gclass101_0 = gclass101_0;
      List<int> list_1 = new List<int>();
      // ISSUE: reference to a compiler-generated field
      string path1 = Path.Combine(gclass30_0.OutputPath, class87.gclass101_0.ContentId.ToString("x8") + ".app");
      // ISSUE: reference to a compiler-generated field
      string path2 = Path.Combine(gclass30_0.OutputPath, class87.gclass101_0.ContentId.ToString("x8") + ".h3");
      // ISSUE: reference to a compiler-generated field
      if (!class87.gclass101_0.Boolean_0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (!Class85.smethod_10(gclass30_0, class87.gclass101_0, class87.byte_1))
        {
          // ISSUE: reference to a compiler-generated field
          return new GStruct7(class87.gclass101_0, new List<int>(), false, true);
        }
        // ISSUE: reference to a compiler-generated field
        return new GStruct7(class87.gclass101_0, new List<int>(), false, false);
      }
      if (!File.Exists(path2))
      {
        // ISSUE: reference to a compiler-generated field
        return new GStruct7(class87.gclass101_0, list_1, true, true);
      }
      // ISSUE: reference to a compiler-generated field
      class87.byte_0 = File.ReadAllBytes(path2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!GClass27.smethod_1(SHA1.Create().ComputeHash(class87.byte_0), class87.gclass101_0.Hash))
      {
        // ISSUE: reference to a compiler-generated field
        return new GStruct7(class87.gclass101_0, list_1, true, true);
      }
      using (FileStream fileStream = File.OpenRead(path1))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class85.Class88 class88 = new Class85.Class88();
        // ISSUE: reference to a compiler-generated field
        class88.class87_0 = class87;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        int int_5 = (int) (class88.class87_0.gclass101_0.Size.TotalBytes / 65536UL);
        int num1 = (int) Math.Ceiling((double) int_5 / 768.0);
        int num2 = 0;
        // ISSUE: reference to a compiler-generated field
        class88.bool_0 = Enumerable.Repeat<bool>(false, 3).ToArray<bool>();
        // ISSUE: reference to a compiler-generated field
        class88.list_0 = Enumerable.Repeat<List<int>>(new List<int>(), 3).ToArray<List<int>>();
        Thread[] threadArray = new Thread[3];
        for (int index = 0; index < 3; ++index)
        {
          if (Class85.byte_0[index] == null)
            Class85.byte_0[index] = new byte[16777216];
        }
        for (int index1 = 0; index1 < num1; ++index1)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          Class85.Class89 class89 = new Class85.Class89();
          // ISSUE: reference to a compiler-generated field
          class89.class88_0 = class88;
          // ISSUE: reference to a compiler-generated field
          class89.tuple_0 = Class85.smethod_11(int_5, 3, 256);
          // ISSUE: reference to a compiler-generated field
          int_5 -= class89.tuple_0.Item2;
          for (int index2 = 0; index2 < 3; ++index2)
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Class85.Class90 class90 = new Class85.Class90();
            // ISSUE: reference to a compiler-generated field
            class90.class89_0 = class89;
            // ISSUE: reference to a compiler-generated field
            class90.int_0 = index2;
            // ISSUE: reference to a compiler-generated field
            class90.int_1 = num2;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class90.class89_0.class88_0.bool_0[index2] = false;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class90.class89_0.class88_0.list_0[index2] = new List<int>();
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            fileStream.Read(Class85.byte_0[index2], 0, class90.class89_0.tuple_0.Item1[index2] * 65536);
            if (Class85.byte_0[index2].Length != 0)
            {
              // ISSUE: reference to a compiler-generated method
              threadArray[index2] = new Thread(new ThreadStart(class90.method_0))
              {
                IsBackground = true
              };
              threadArray[index2].Start();
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class90.class89_0.class88_0.bool_0[index2] = true;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              class90.class89_0.class88_0.list_0[index2] = new List<int>();
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            num2 += class90.class89_0.tuple_0.Item1[index2];
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          while (!Class85.smethod_7(class89.class88_0.bool_0))
            Thread.Sleep(10);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          foreach (List<int> intList in class89.class88_0.list_0)
            list_1.AddRange((IEnumerable<int>) intList);
        }
      }
      // ISSUE: reference to a compiler-generated field
      return new GStruct7(class87.gclass101_0, list_1, false, false);
    }

    public static byte[] smethod_5(byte[] byte_1, byte[] byte_2, byte[] byte_3)
    {
      RijndaelManaged rijndaelManaged = new RijndaelManaged();
      rijndaelManaged.Mode = CipherMode.CBC;
      rijndaelManaged.Padding = PaddingMode.None;
      rijndaelManaged.KeySize = 128;
      rijndaelManaged.BlockSize = 128;
      rijndaelManaged.Key = byte_2;
      rijndaelManaged.IV = byte_3;
      byte[] buffer = new byte[byte_1.Length];
      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
      using (MemoryStream memoryStream = new MemoryStream(byte_1))
      {
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
          cryptoStream.Read(buffer, 0, byte_1.Length);
      }
      return buffer;
    }

    public static void smethod_6(string string_0, string string_1, byte[] byte_1, byte[] byte_2)
    {
      byte[] buffer = new byte[16777216];
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Key = byte_1;
        cryptoServiceProvider.IV = byte_2;
        cryptoServiceProvider.Padding = PaddingMode.None;
        using (FileStream fileStream1 = File.Open(string_0, FileMode.Open))
        {
          using (FileStream fileStream2 = File.Create(string_1))
          {
            using (CryptoStream cryptoStream = new CryptoStream((Stream) fileStream1, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
            {
              int count;
              do
              {
                count = cryptoStream.Read(buffer, 0, buffer.Length);
                fileStream2.Write(buffer, 0, count);
              }
              while (count > 0);
            }
          }
        }
      }
    }

    private static bool smethod_7(bool[] bool_0_1)
    {
      return ((IEnumerable<bool>) bool_0_1).All<bool>((Func<bool, bool>) (bool_0_2 => bool_0_2));
    }

    private static List<int> smethod_8(byte[] byte_1, byte[] byte_2, int int_5, int int_6, byte[] byte_3, byte byte_4)
    {
      List<int> intList = new List<int>();
      for (int index = 0; index < int_6; ++index)
      {
        byte[] byte_1_1 = new byte[65536];
        Buffer.BlockCopy((Array) byte_1, index * 65536, (Array) byte_1_1, 0, 65536);
        if (Class85.smethod_0(byte_1_1, byte_2, index + int_5, byte_3, byte_4) == Enum3.const_1)
          intList.Add(index + int_5);
      }
      return intList;
    }

    private static byte[] smethod_9(ushort ushort_0)
    {
      byte[] numArray = new byte[16];
      byte[] bytes = BitConverter.GetBytes(ushort_0);
      numArray[0] = bytes[1];
      numArray[1] = bytes[0];
      return numArray;
    }

    private static bool smethod_10(GClass30 gclass30_0, GClass101 gclass101_0, byte[] byte_1)
    {
      string str = Path.Combine(gclass30_0.OutputPath, gclass101_0.ContentId.ToString("x8") + ".app");
      byte[] numArray = Class85.smethod_9(gclass101_0.Index);
      byte[] byte_0;
      if (gclass30_0.System != GEnum3.const_1 && gclass30_0.System != GEnum3.const_3)
      {
        if (gclass30_0.System != GEnum3.const_0)
          throw new NotImplementedException();
        byte_0 = Class85.smethod_3(str, byte_1, numArray);
      }
      else
      {
        byte[] array = File.ReadAllBytes(str);
        Array.Resize<byte>(ref array, GClass27.smethod_0(array.Length, 16));
        byte_0 = SHA1.Create().ComputeHash(Class85.smethod_5(array, byte_1, numArray), 0, (int) gclass101_0.Size.TotalBytes);
      }
      return GClass27.smethod_1(byte_0, gclass101_0.Hash);
    }

    private static Tuple<int[], int> smethod_11(int int_5, int int_6, int int_7)
    {
      int[] array = Enumerable.Repeat<int>(0, int_6).ToArray<int>();
      int num1 = 0;
      for (int index = 0; index < int_6; ++index)
      {
        int num2 = Class85.smethod_12(int_5, int_7);
        num1 += num2;
        array[index] = num2;
        int_5 -= num2;
      }
      return new Tuple<int[], int>(array, num1);
    }

    private static int smethod_12(int int_5, int int_6)
    {
      if (int_6 <= int_5)
        return int_6;
      return int_5;
    }
  }
}
