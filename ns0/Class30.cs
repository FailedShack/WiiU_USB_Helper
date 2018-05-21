// Decompiled with JetBrains decompiler
// Type: ns0.Class30
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
  internal static class Class30
  {
    public static bool bool_0 = false;
    public static bool bool_1 = false;
    public static string string_0 = "..\\code\\fw.img";
    public static bool bool_2 = false;
    public static bool bool_3 = false;
    public static bool bool_4 = false;
    public static string string_1 = "game.iso";
    public static bool bool_5 = false;
    public static bool bool_6 = false;
    public static string string_2 = "..\\code\\htk.bin";
    public static bool bool_7 = false;
    public static string string_3 = "";
    public static bool bool_8 = false;
    public static bool bool_9 = false;
    public static bool bool_10 = false;
    public static byte[] byte_0 = new byte[16];
    public static string string_4 = "wii_common_key.bin";
    public const int int_0 = 512;
    public const int int_1 = 262144000;
    public const int int_2 = 32768;

    public static void smethod_0(string string_5)
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      Directory.SetCurrentDirectory(string_5);
      try
      {
        Class30.bool_2 = true;
        Class30.bool_9 = true;
        Class30.smethod_4(Class30.string_0);
        byte[] byte_3 = Class30.smethod_7("hif_unpack.nfs", "hif_dec.nfs", Class30.smethod_6(Class30.string_1, "hif_unpack.nfs", false));
        GClass6.smethod_6("hif_unpack.nfs");
        Class30.smethod_5("hif_dec.nfs", "hif.nfs", Class30.byte_0, Class30.smethod_2(Class30.byte_0.Length), true, byte_3);
        GClass6.smethod_6("hif_dec.nfs");
        Class30.smethod_10("hif.nfs");
        GClass6.smethod_6("hif.nfs");
      }
      catch
      {
        Directory.SetCurrentDirectory(currentDirectory);
        throw;
      }
      finally
      {
        Directory.SetCurrentDirectory(currentDirectory);
      }
    }

    private static byte[] smethod_1(byte[] byte_1, byte[] byte_2, byte[] byte_3, bool bool_11)
    {
      byte[] numArray = new byte[byte_3.Length];
      try
      {
        AesCryptoServiceProvider cryptoServiceProvider1 = new AesCryptoServiceProvider();
        cryptoServiceProvider1.Mode = CipherMode.CBC;
        cryptoServiceProvider1.Padding = PaddingMode.None;
        cryptoServiceProvider1.KeySize = 128;
        cryptoServiceProvider1.BlockSize = 128;
        cryptoServiceProvider1.Key = byte_1;
        cryptoServiceProvider1.IV = byte_2;
        AesCryptoServiceProvider cryptoServiceProvider2 = cryptoServiceProvider1;
        if (bool_11)
        {
          using (ICryptoTransform encryptor = cryptoServiceProvider2.CreateEncryptor())
            numArray = encryptor.TransformFinalBlock(byte_3, 0, byte_3.Length);
        }
        else
        {
          using (ICryptoTransform decryptor = cryptoServiceProvider2.CreateDecryptor())
            numArray = decryptor.TransformFinalBlock(byte_3, 0, byte_3.Length);
        }
        cryptoServiceProvider2.Clear();
        return numArray;
      }
      catch
      {
        throw;
      }
    }

    private static byte[] smethod_2(int int_3)
    {
      byte[] numArray = new byte[int_3];
      for (int index = 0; index < int_3; ++index)
        numArray[index] = (byte) 0;
      return numArray;
    }

    private static bool smethod_3(byte[] byte_1, byte[] byte_2)
    {
      if (byte_1.Length == byte_2.Length)
        return Class30.memcmp(byte_1, byte_2, (long) byte_1.Length) == 0;
      return false;
    }

    private static void smethod_4(string string_5)
    {
      MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(string_5));
      byte[] numArray1 = new byte[4];
      byte[] byte_2_1 = new byte[4]
      {
        (byte) 115,
        (byte) 118,
        (byte) 110,
        (byte) 45
      };
      for (int index = 0; (long) index < memoryStream.Length - 4L; ++index)
      {
        memoryStream.Position = (long) index;
        memoryStream.Read(numArray1, 0, 4);
        if (Class30.smethod_3(numArray1, byte_2_1))
        {
          memoryStream.Read(numArray1, 0, 4);
          Encoding.UTF8.GetString(numArray1, 0, numArray1.Length);
          break;
        }
      }
      byte[] numArray2 = new byte[4];
      byte[] numArray3 = new byte[8];
      Array.Clear((Array) numArray2, 0, 4);
      byte[] byte_2_2 = new byte[4]
      {
        (byte) 32,
        (byte) 7,
        (byte) 35,
        (byte) 162
      };
      byte[] byte_2_3 = new byte[4]
      {
        (byte) 32,
        (byte) 7,
        (byte) 75,
        (byte) 11
      };
      for (int index = 0; (long) index < memoryStream.Length - 4L; ++index)
      {
        memoryStream.Position = (long) index;
        memoryStream.Read(numArray2, 0, 4);
        if (Class30.smethod_3(numArray2, byte_2_2) || Class30.smethod_3(numArray2, byte_2_3))
        {
          memoryStream.Seek((long) (index + 1), SeekOrigin.Begin);
          memoryStream.WriteByte((byte) 0);
        }
      }
      if (Class30.bool_2)
      {
        Array.Clear((Array) numArray2, 0, 4);
        Array.Clear((Array) numArray3, 0, 8);
        byte[] byte_2_4 = new byte[8]
        {
          (byte) 208,
          (byte) 11,
          (byte) 35,
          (byte) 8,
          (byte) 67,
          (byte) 19,
          (byte) 96,
          (byte) 11
        };
        byte[] buffer1 = new byte[2]
        {
          (byte) 70,
          (byte) 192
        };
        for (int index = 0; (long) index < memoryStream.Length - 8L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray3, 0, 8);
          if (Class30.smethod_3(numArray3, byte_2_4))
          {
            memoryStream.Seek((long) index, SeekOrigin.Begin);
            memoryStream.Write(buffer1, 0, 2);
          }
        }
        byte[] byte_2_5 = new byte[8]
        {
          (byte) 1,
          (byte) 148,
          (byte) 181,
          (byte) 0,
          (byte) 75,
          (byte) 8,
          (byte) 34,
          (byte) 1
        };
        byte[] buffer2 = new byte[2]{ (byte) 34, (byte) 0 };
        for (int index = 0; (long) index < memoryStream.Length - 8L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray3, 0, 8);
          if (Class30.smethod_3(numArray3, byte_2_5))
          {
            memoryStream.Seek((long) (index + 6), SeekOrigin.Begin);
            memoryStream.Write(buffer2, 0, 2);
          }
        }
        byte[] byte_2_6 = new byte[4]
        {
          (byte) 176,
          (byte) 186,
          (byte) 28,
          (byte) 15
        };
        byte[] buffer3 = new byte[16]
        {
          (byte) 229,
          (byte) 159,
          (byte) 16,
          (byte) 4,
          (byte) 229,
          (byte) 145,
          (byte) 0,
          (byte) 0,
          (byte) 225,
          (byte) 47,
          byte.MaxValue,
          (byte) 16,
          (byte) 18,
          byte.MaxValue,
          byte.MaxValue,
          (byte) 224
        };
        for (int index = 0; (long) index < memoryStream.Length - 4L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray2, 0, 4);
          if (Class30.smethod_3(numArray2, byte_2_6))
          {
            memoryStream.Seek((long) (index - 12), SeekOrigin.Begin);
            memoryStream.Write(buffer3, 0, 16);
          }
        }
        byte[] byte_2_7 = new byte[4]
        {
          (byte) 104,
          (byte) 75,
          (byte) 43,
          (byte) 6
        };
        byte[] buffer4 = new byte[20]
        {
          (byte) 73,
          (byte) 1,
          (byte) 71,
          (byte) 136,
          (byte) 70,
          (byte) 192,
          (byte) 224,
          (byte) 1,
          (byte) 18,
          byte.MaxValue,
          (byte) 254,
          (byte) 0,
          (byte) 34,
          (byte) 0,
          (byte) 35,
          (byte) 1,
          (byte) 70,
          (byte) 192,
          (byte) 70,
          (byte) 192
        };
        for (int index = 0; (long) index < memoryStream.Length - 4L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray2, 0, 4);
          if (Class30.smethod_3(numArray2, byte_2_7))
          {
            memoryStream.Seek((long) index, SeekOrigin.Begin);
            memoryStream.Write(buffer4, 0, 20);
          }
        }
        byte[] byte_2_8 = new byte[8]
        {
          (byte) 13,
          (byte) 128,
          (byte) 0,
          (byte) 0,
          (byte) 13,
          (byte) 128,
          (byte) 0,
          (byte) 0
        };
        byte[] byte_2_9 = new byte[4]
        {
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 2
        };
        byte[] buffer5 = new byte[4]
        {
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 3
        };
        for (int index = 0; (long) index < memoryStream.Length - 8L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray3, 0, 8);
          if (Class30.smethod_3(numArray3, byte_2_8))
          {
            memoryStream.Seek((long) (index + 16), SeekOrigin.Begin);
            memoryStream.Read(numArray2, 0, 4);
            if (Class30.smethod_3(numArray2, byte_2_9))
            {
              memoryStream.Seek((long) (index + 16), SeekOrigin.Begin);
              memoryStream.Write(buffer5, 0, 4);
            }
          }
        }
      }
      if (Class30.bool_9)
      {
        Array.Clear((Array) numArray2, 0, 4);
        Array.Clear((Array) numArray3, 0, 8);
        byte[] byte_2_4 = new byte[8]
        {
          (byte) 32,
          (byte) 75,
          (byte) 1,
          (byte) 104,
          (byte) 24,
          (byte) 71,
          (byte) 112,
          (byte) 0
        };
        byte[] buffer1 = new byte[2]{ (byte) 32, (byte) 0 };
        for (int index = 0; (long) index < memoryStream.Length - 8L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray3, 0, 8);
          if (Class30.smethod_3(numArray3, byte_2_4))
          {
            memoryStream.Seek((long) (index + 3), SeekOrigin.Begin);
            memoryStream.Write(buffer1, 0, 2);
          }
        }
        byte[] byte_2_5 = new byte[8]
        {
          (byte) 40,
          (byte) 0,
          (byte) 208,
          (byte) 3,
          (byte) 73,
          (byte) 2,
          (byte) 34,
          (byte) 9
        };
        byte[] buffer2 = new byte[12]
        {
          (byte) 240,
          (byte) 4,
          byte.MaxValue,
          (byte) 33,
          (byte) 72,
          (byte) 2,
          (byte) 33,
          (byte) 9,
          (byte) 240,
          (byte) 4,
          (byte) 254,
          (byte) 249
        };
        for (int index = 0; (long) index < memoryStream.Length - 8L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray3, 0, 8);
          if (Class30.smethod_3(numArray3, byte_2_5))
          {
            memoryStream.Seek((long) index, SeekOrigin.Begin);
            memoryStream.Write(buffer2, 0, 12);
          }
        }
        byte[] byte_2_6 = new byte[4]
        {
          (byte) 240,
          (byte) 1,
          (byte) 250,
          (byte) 185
        };
        byte[] buffer3 = new byte[4]
        {
          (byte) 247,
          (byte) 252,
          (byte) 251,
          (byte) 149
        };
        for (int index = 0; (long) index < memoryStream.Length - 4L; ++index)
        {
          memoryStream.Position = (long) index;
          memoryStream.Read(numArray2, 0, 4);
          if (Class30.smethod_3(numArray2, byte_2_6))
          {
            memoryStream.Seek((long) index, SeekOrigin.Begin);
            memoryStream.Write(buffer3, 0, 4);
          }
        }
      }
      FileStream fileStream = File.OpenWrite(string_5);
      memoryStream.WriteTo((Stream) fileStream);
      fileStream.Close();
      memoryStream.Close();
    }

    private static void smethod_5(string string_5, string string_6, byte[] byte_1, byte[] byte_2, bool bool_11, byte[] byte_3)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_5)))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.OpenWrite(string_6)))
        {
          if (bool_11)
            binaryWriter.Write(byte_3);
          byte[] numArray1 = new byte[16];
          numArray1[14] = (byte) 31;
          byte[] byte_2_1 = numArray1;
          byte[] numArray2 = new byte[32768];
          int num1 = 0;
          int num2 = 0;
          long length = binaryReader.BaseStream.Length;
          do
          {
            if (num1 == 8000)
              goto label_22;
label_5:
            ++num1;
            byte[] numArray3 = binaryReader.ReadBytes(length > 32768L ? 32768 : (int) length);
            if (binaryWriter.BaseStream.Position >= 98304L)
              byte_2 = byte_2_1;
            if (bool_11 && binaryWriter.BaseStream.Position < 98304L)
              numArray3 = Class30.smethod_1(byte_1, byte_2, numArray3, true);
            if (bool_11 && binaryWriter.BaseStream.Position >= 98304L)
            {
              numArray3 = Class30.smethod_1(byte_1, byte_2_1, numArray3, true);
              ++byte_2_1[15];
              if (byte_2_1[15] == (byte) 0)
              {
                ++byte_2_1[14];
                if (byte_2_1[14] == (byte) 0)
                {
                  ++byte_2_1[13];
                  if (byte_2_1[13] == (byte) 0)
                    ++byte_2_1[12];
                }
              }
            }
            if (!bool_11 && binaryWriter.BaseStream.Position < 98304L)
              numArray3 = Class30.smethod_1(byte_1, byte_2, numArray3, false);
            if (!bool_11 && binaryWriter.BaseStream.Position >= 98304L)
            {
              numArray3 = Class30.smethod_1(byte_1, byte_2, numArray3, false);
              ++byte_2_1[15];
              if (byte_2_1[15] == (byte) 0)
              {
                ++byte_2_1[14];
                if (byte_2_1[14] == (byte) 0)
                {
                  ++byte_2_1[13];
                  if (byte_2_1[13] == (byte) 0)
                    ++byte_2_1[12];
                }
              }
            }
            binaryWriter.Write(numArray3);
            length -= 32768L;
            continue;
label_22:
            num1 = 0;
            ++num2;
            goto label_5;
          }
          while (length > 0L);
        }
      }
    }

    private static long[] smethod_6(string string_5, string string_6, bool bool_11)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_5)))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.OpenWrite(string_6)))
        {
          long[] numArray1 = new long[2];
          binaryWriter.Write(binaryReader.ReadBytes(262144));
          byte[] buffer1 = binaryReader.ReadBytes(32);
          binaryWriter.Write(buffer1);
          int[,] int_3 = new int[2, 4];
          for (byte index = 0; index < (byte) 4; ++index)
          {
            int_3[0, (int) index] = (int) buffer1[8 * (int) index] * 16777216 + (int) buffer1[1 + 8 * (int) index] * 65536 + (int) buffer1[2 + 8 * (int) index] * 256 + (int) buffer1[3 + 8 * (int) index];
            int_3[1, (int) index] = int_3[0, (int) index] != 0 ? ((int) buffer1[4 + 8 * (int) index] * 16777216 + (int) buffer1[5 + 8 * (int) index] * 65536 + (int) buffer1[6 + 8 * (int) index] * 256 + (int) buffer1[7 + 8 * (int) index]) * 4 : 0;
          }
          int[,] numArray2 = Class30.smethod_8(int_3, 4);
          byte[][] numArray3 = new byte[4][];
          List<int> intList = new List<int>();
          long num1 = 262176;
          int num2 = 0;
          for (int index1 = 0; index1 < 4; ++index1)
          {
            if (numArray2[0, index1] != 0)
            {
              binaryWriter.Write(binaryReader.ReadBytes((int) ((long) numArray2[1, index1] - num1)));
              long num3 = num1 + ((long) numArray2[1, index1] - num1);
              numArray3[index1] = binaryReader.ReadBytes(8 * numArray2[0, index1]);
              num1 = num3 + (long) (8 * numArray2[0, index1]);
              for (int index2 = 0; index2 < numArray2[0, index1]; ++index2)
              {
                if (numArray3[index1][7 + 8 * index2] == (byte) 0)
                {
                  intList.Add(((int) numArray3[index1][8 * index2] * 16777216 + (int) numArray3[index1][1 + 8 * index2] * 65536 + (int) numArray3[index1][2 + 8 * index2] * 256 + (int) numArray3[index1][3 + 8 * index2]) * 4);
                  ++num2;
                }
              }
              binaryWriter.Write(numArray3[index1]);
            }
          }
          int[] array = intList.ToArray();
          int[] numArray4 = Class30.smethod_9(array, array.Length);
          numArray1[0] = (long) numArray4[0];
          byte[] byte_2 = new byte[16];
          byte[] numArray5 = new byte[1024];
          byte[] numArray6 = new byte[1024];
          int num4 = 0;
          int num5 = 0;
          for (int index1 = 0; index1 < numArray4.Length; ++index1)
          {
            binaryWriter.Write(binaryReader.ReadBytes((int) ((long) numArray4[index1] - num1)));
            long num3 = num1 + ((long) numArray4[index1] - num1);
            binaryWriter.Write(binaryReader.ReadBytes(447));
            byte[] numArray7 = binaryReader.ReadBytes(16);
            binaryWriter.Write(numArray7);
            binaryWriter.Write(binaryReader.ReadBytes(13));
            byte[] buffer2 = binaryReader.ReadBytes(8);
            binaryWriter.Write(buffer2);
            for (int index2 = 0; index2 < 16; ++index2)
              byte_2[index2] = index2 >= 8 ? (byte) 0 : buffer2[index2];
            binaryWriter.Write(binaryReader.ReadBytes(192));
            byte[] buffer3 = binaryReader.ReadBytes(130396);
            long num6 = 4L * (long) ((int) buffer3[24] * 16777216 + (int) buffer3[25] * 65536 + (int) buffer3[26] * 256 + (int) buffer3[27]);
            binaryWriter.Write(buffer3);
            num1 = num3 + 131072L + num6;
            byte[] byte_1 = Class30.smethod_1(Class30.byte_0, byte_2, numArray7, false);
            byte[] numArray8 = new byte[32768];
            while (num6 >= 32768L)
            {
              if (num4 == 8000)
              {
                num4 = 0;
                ++num5;
              }
              ++num4;
              byte[] buffer4;
              if (bool_11)
              {
                Array.Clear((Array) byte_2, 0, 16);
                byte[] byte_3_1 = binaryReader.ReadBytes(1024);
                byte[] buffer5 = Class30.smethod_1(byte_1, byte_2, byte_3_1, true);
                binaryWriter.Write(buffer5);
                if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                  Array.Copy((Array) buffer5, 976, (Array) byte_2, 0, 16);
                  byte[] byte_3_2 = binaryReader.ReadBytes(31744);
                  buffer4 = Class30.smethod_1(byte_1, byte_2, byte_3_2, bool_11);
                }
                else
                  break;
              }
              else
              {
                Array.Clear((Array) byte_2, 0, 16);
                byte[] byte_3_1 = binaryReader.ReadBytes(1024);
                byte[] buffer5 = Class30.smethod_1(byte_1, byte_2, byte_3_1, false);
                binaryWriter.Write(buffer5);
                if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                  Array.Copy((Array) byte_3_1, 976, (Array) byte_2, 0, 16);
                  byte[] byte_3_2 = binaryReader.ReadBytes(31744);
                  buffer4 = Class30.smethod_1(byte_1, byte_2, byte_3_2, false);
                }
                else
                  break;
              }
              binaryWriter.Write(buffer4);
              num6 -= 32768L;
            }
            numArray1[1] = num1 - numArray1[0];
          }
          if (!bool_11)
            return numArray1;
          long num7 = num1 <= 4699979776L ? 4699979776L - num1 : 8511160320L - num1;
          int num8 = 0;
          int num9 = 0;
          while (num7 > 0L)
          {
            if (num9 == 8000)
            {
              num9 = 0;
              ++num8;
            }
            ++num9;
            binaryWriter.Write(Class30.smethod_2(num7 > 32768L ? 32768 : (int) num7));
            num7 -= 32768L;
          }
          return (long[]) null;
        }
      }
    }

    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int memcmp(byte[] byte_1, byte[] byte_2, long long_0);

    private static byte[] smethod_7(string string_5, string string_6, long[] long_0)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_5)))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.OpenWrite(string_6)))
        {
          byte[] numArray = new byte[512];
          for (int index = 0; index < 512; ++index)
            numArray[index] = byte.MaxValue;
          numArray[0] = (byte) 69;
          numArray[1] = (byte) 71;
          numArray[2] = (byte) 71;
          numArray[3] = (byte) 83;
          numArray[4] = (byte) 0;
          numArray[5] = (byte) 1;
          numArray[6] = (byte) 16;
          numArray[7] = (byte) 17;
          numArray[8] = (byte) 0;
          numArray[9] = (byte) 0;
          numArray[10] = (byte) 0;
          numArray[11] = (byte) 0;
          numArray[12] = (byte) 0;
          numArray[13] = (byte) 0;
          numArray[14] = (byte) 0;
          numArray[15] = (byte) 0;
          numArray[16] = (byte) 0;
          numArray[17] = (byte) 0;
          numArray[18] = (byte) 0;
          numArray[19] = (byte) 3;
          numArray[20] = (byte) 0;
          numArray[21] = (byte) 0;
          numArray[22] = (byte) 0;
          numArray[23] = (byte) 0;
          numArray[24] = (byte) 0;
          numArray[25] = (byte) 0;
          numArray[26] = (byte) 0;
          numArray[27] = (byte) 1;
          numArray[28] = (byte) 0;
          numArray[29] = (byte) 0;
          numArray[30] = (byte) 0;
          numArray[31] = (byte) 8;
          numArray[32] = (byte) 0;
          numArray[33] = (byte) 0;
          numArray[34] = (byte) 0;
          numArray[35] = (byte) 2;
          numArray[36] = (byte) ((ulong) (long_0[0] / 32768L) / 16777216UL);
          numArray[37] = (byte) ((ulong) (long_0[0] / 32768L / 65536L) % 256UL);
          numArray[38] = (byte) ((ulong) (long_0[0] / 32768L / 256L) % 65536UL);
          numArray[39] = (byte) ((ulong) (long_0[0] / 32768L) % 16777216UL);
          numArray[40] = (byte) ((ulong) (long_0[1] / 32768L) / 16777216UL);
          numArray[41] = (byte) ((ulong) (long_0[1] / 32768L / 65536L) % 256UL);
          numArray[42] = (byte) ((ulong) (long_0[1] / 32768L / 256L) % 65536UL);
          numArray[43] = (byte) ((ulong) (long_0[1] / 32768L) % 16777216UL);
          numArray[508] = (byte) 83;
          numArray[509] = (byte) 71;
          numArray[510] = (byte) 71;
          numArray[511] = (byte) 69;
          int num1 = 16777216 * (int) numArray[16] + 65536 * (int) numArray[17] + 256 * (int) numArray[18] + (int) numArray[19];
          long num2 = 0;
          for (int index = 0; index < num1; ++index)
          {
            long num3 = 32768L * (16777216L * (long) numArray[20 + index * 8] + 65536L * (long) numArray[21 + index * 8] + 256L * (long) numArray[22 + index * 8] + (long) numArray[23 + index * 8]);
            long num4 = 32768L * (16777216L * (long) numArray[24 + index * 8] + 65536L * (long) numArray[25 + index * 8] + 256L * (long) numArray[26 + index * 8] + (long) numArray[27 + index * 8]);
            long num5 = num3 - num2;
            while (num5 > 0L)
            {
              binaryReader.ReadBytes(32768);
              num5 -= 32768L;
            }
            long num6 = num4;
            while (num6 > 0L)
            {
              binaryWriter.Write(binaryReader.ReadBytes(32768));
              num6 -= 32768L;
            }
            num2 = num3 + num4;
          }
          return numArray;
        }
      }
    }

    private static int[,] smethod_8(int[,] int_3, int int_4)
    {
      int num1 = 0;
      int index1 = 0;
      for (int index2 = 0; index2 < int_4; ++index2)
      {
        for (int index3 = 0; index3 < int_4 - index2; ++index3)
        {
          if (int_3[1, index3] > num1)
          {
            num1 = int_3[1, index3];
            index1 = index3;
          }
        }
        int num2 = int_3[0, int_4 - index2 - 1];
        int_3[0, int_4 - index2 - 1] = int_3[0, index1];
        int_3[0, index1] = num2;
        int num3 = int_3[1, int_4 - index2 - 1];
        int_3[1, int_4 - index2 - 1] = int_3[1, index1];
        int_3[1, index1] = num3;
      }
      return int_3;
    }

    private static int[] smethod_9(int[] int_3, int int_4)
    {
      int num1 = 0;
      int index1 = 0;
      for (int index2 = 0; index2 < int_4; ++index2)
      {
        for (int index3 = 0; index3 < int_4 - index2; ++index3)
        {
          if (int_3[index3] > num1)
          {
            num1 = int_3[index3];
            index1 = index3;
          }
        }
        int num2 = int_3[int_4 - index2 - 1];
        int_3[int_4 - index2 - 1] = int_3[index1];
        int_3[index1] = num2;
      }
      return int_3;
    }

    private static void smethod_10(string string_5)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_5)))
      {
        long length = binaryReader.BaseStream.Length;
        int num = 0;
        do
        {
          new BinaryWriter((Stream) File.OpenWrite(Directory.GetCurrentDirectory() + "\\hif_" + string.Format("{0:D6}", (object) num) + ".nfs")).Write(binaryReader.ReadBytes(length <= 262144000L ? (int) length : 262144000));
          length -= 262144000L;
          ++num;
        }
        while (length > 0L);
      }
    }
  }
}
