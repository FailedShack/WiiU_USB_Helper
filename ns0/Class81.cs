// Decompiled with JetBrains decompiler
// Type: ns0.Class81
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Telerik.WinControls;

namespace ns0
{
  internal static class Class81
  {
    public static bool bool_0 = false;
    public static string string_0 = "..\\code\\htk.bin";
    public static string string_1 = "";
    private static readonly byte[] byte_0 = new byte[32768];
    private static readonly byte[] byte_1 = new byte[16]
    {
      (byte) 235,
      (byte) 228,
      (byte) 42,
      (byte) 34,
      (byte) 94,
      (byte) 133,
      (byte) 147,
      (byte) 228,
      (byte) 72,
      (byte) 217,
      (byte) 197,
      (byte) 69,
      (byte) 115,
      (byte) 129,
      (byte) 170,
      (byte) 247
    };
    public const int int_0 = 512;
    public const int int_1 = 262144000;
    public const int int_2 = 32768;

    public static void smethod_0(byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5, bool bool_1)
    {
      try
      {
        RijndaelManaged rijndaelManaged = new RijndaelManaged();
        rijndaelManaged.Mode = CipherMode.CBC;
        rijndaelManaged.Padding = PaddingMode.None;
        rijndaelManaged.KeySize = 128;
        rijndaelManaged.BlockSize = 128;
        rijndaelManaged.Key = byte_2;
        rijndaelManaged.IV = byte_3;
        if (bool_1)
        {
          using (ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor())
            encryptor.TransformBlock(byte_4, 0, byte_4.Length, byte_5, 0);
        }
        else
        {
          using (ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor())
            decryptor.TransformBlock(byte_4, 0, byte_4.Length, byte_5, 0);
        }
        rijndaelManaged.Clear();
      }
      catch (CryptographicException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public static long[] smethod_1(string string_2, string string_3, bool bool_1)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_2)))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.OpenWrite(string_3)))
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
          Console.WriteLine();
          int[,] numArray2 = Class81.smethod_6(int_3, 4);
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
          Console.WriteLine();
          int[] array = intList.ToArray();
          int[] numArray4 = Class81.smethod_7(array, array.Length);
          numArray1[0] = (long) numArray4[0];
          byte[] numArray5 = new byte[16];
          int num4 = 0;
          byte[] numArray6 = new byte[31744];
          byte[] numArray7 = new byte[31744];
          byte[] buffer2 = new byte[130396];
          byte[] buffer3 = new byte[32768];
          long num5 = 0;
          int num6 = 0;
          for (int index1 = 0; index1 < numArray4.Length; ++index1)
          {
            long num3 = (long) numArray4[index1] - num1;
            long num7;
            do
            {
              num7 = num3 - num5;
              int count = binaryReader.BaseStream.Read(buffer3, 0, (long) buffer3.Length >= num7 ? (int) num7 : buffer3.Length);
              binaryWriter.BaseStream.Write(buffer3, 0, count);
              num5 += (long) count;
            }
            while (num7 > 0L);
            long num8 = num1 + ((long) numArray4[index1] - num1);
            binaryWriter.Write(binaryReader.ReadBytes(447));
            byte[] numArray8 = binaryReader.ReadBytes(16);
            binaryWriter.Write(numArray8);
            binaryWriter.Write(binaryReader.ReadBytes(13));
            byte[] buffer4 = binaryReader.ReadBytes(8);
            binaryWriter.Write(buffer4);
            for (int index2 = 0; index2 < 16; ++index2)
              numArray5[index2] = index2 >= 8 ? (byte) 0 : buffer4[index2];
            binaryWriter.Write(binaryReader.ReadBytes(192));
            binaryReader.BaseStream.Read(buffer2, 0, buffer2.Length);
            long num9 = 4L * (long) ((int) buffer2[24] * 16777216 + (int) buffer2[25] * 65536 + (int) buffer2[26] * 256 + (int) buffer2[27]);
            binaryWriter.Write(buffer2);
            num1 = num8 + 131072L + num9;
            byte[] numArray9 = new byte[16];
            Class81.smethod_0(Class81.byte_1, numArray5, numArray8, numArray9, false);
            while (num9 >= 32768L)
            {
              if (num4 == 8000)
              {
                num4 = 0;
                ++num6;
              }
              ++num4;
              binaryWriter.Write(binaryReader.ReadBytes(976));
              numArray5 = binaryReader.ReadBytes(16);
              binaryWriter.Write(numArray5);
              binaryWriter.Write(binaryReader.ReadBytes(32));
              binaryReader.BaseStream.Read(numArray6, 0, numArray6.Length);
              Class81.smethod_0(numArray9, numArray5, numArray6, numArray7, bool_1);
              binaryWriter.Write(numArray7);
              num9 -= 32768L;
            }
            numArray1[1] = num1 - numArray1[0];
          }
          if (!bool_1)
            return numArray1;
          long num10 = num1 <= 4699979776L ? 4699979776L - num1 : 8511160320L - num1;
          int num11 = 0;
          int num12 = 0;
          while (num10 > 0L)
          {
            if (num12 == 8000)
            {
              num12 = 0;
              ++num11;
            }
            ++num12;
            long num3 = num10 > 32768L ? 32768L : num10;
            binaryWriter.Write(Class81.byte_0, 0, (int) num3);
            num10 -= 32768L;
          }
          return (long[]) null;
        }
      }
    }

    public static void smethod_2(string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class81.Class82 class82 = new Class81.Class82();
      Class81.string_1 = string_2;
      // ISSUE: reference to a compiler-generated field
      class82.byte_0 = Class81.smethod_5(Path.Combine(Class81.string_1, "hif_000000.nfs"));
      // ISSUE: reference to a compiler-generated field
      class82.string_0 = Path.Combine(Class81.string_1, "hif_unpack.nfs");
      int num;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("Please wait while USB Helper converts this game...", new Action(class82.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
    }

    public static void smethod_3(Stream stream_0, string string_2, byte[] byte_2, byte[] byte_3, byte[] byte_4)
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.OpenWrite(string_2)))
      {
        int num1 = 16777216 * (int) byte_2[16] + 65536 * (int) byte_2[17] + 256 * (int) byte_2[18] + (int) byte_2[19];
        long num2 = 0;
        byte[] numArray1 = new byte[32768];
        byte[] numArray2 = new byte[32768];
        for (int index = 0; index < num1; ++index)
        {
          long num3 = 32768L * (16777216L * (long) byte_2[20 + index * 8] + 65536L * (long) byte_2[21 + index * 8] + 256L * (long) byte_2[22 + index * 8] + (long) byte_2[23 + index * 8]);
          long num4 = 32768L * (16777216L * (long) byte_2[24 + index * 8] + 65536L * (long) byte_2[25 + index * 8] + 256L * (long) byte_2[26 + index * 8] + (long) byte_2[27 + index * 8]);
          long num5 = num3 - num2;
          while (num5 > 0L)
          {
            binaryWriter.Write(Class81.byte_0);
            num5 -= 32768L;
          }
          long num6 = num4;
          while (num6 > 0L)
          {
            stream_0.Read(numArray1, 0, 32768);
            Class81.smethod_0(byte_3, byte_4, numArray1, numArray2, false);
            binaryWriter.Write(numArray2);
            num6 -= 32768L;
          }
          num2 = num3 + num4;
        }
      }
    }

    private static byte[] smethod_4(int int_3)
    {
      byte[] numArray = new byte[int_3];
      for (int index = 0; index < int_3; ++index)
        numArray[index] = (byte) 0;
      return numArray;
    }

    private static byte[] smethod_5(string string_2)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(string_2)))
        return binaryReader.ReadBytes(512);
    }

    private static int[,] smethod_6(int[,] int_3, int int_4)
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

    private static int[] smethod_7(int[] int_3, int int_4)
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
  }
}
