// Decompiled with JetBrains decompiler
// Type: ns0.GClass13
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ns0
{
  public class GClass13
  {
    public GClass13(byte[] byte_0)
    {
      using (BinaryReader binaryReader_0 = new BinaryReader((Stream) new MemoryStream(byte_0)))
      {
        if (binaryReader_0.ReadUInt32() != 5526342U)
          throw new Exception("Incorrect FST!");
        binaryReader_0.smethod_2();
        int num1 = binaryReader_0.smethod_2();
        binaryReader_0.BaseStream.Seek(32L, SeekOrigin.Begin);
        for (int index = 0; index < num1; ++index)
        {
          int num2 = (int) binaryReader_0.ReadUInt32();
          int num3 = (int) binaryReader_0.smethod_4();
          int num4 = (int) binaryReader_0.ReadUInt32();
          binaryReader_0.BaseStream.Seek(20L, SeekOrigin.Current);
        }
        binaryReader_0.BaseStream.Seek((long) (32 + num1 * 32 + 8), SeekOrigin.Begin);
        uint num5 = binaryReader_0.smethod_4();
        binaryReader_0.BaseStream.Seek((long) (32 + num1 * 32), SeekOrigin.Begin);
        for (int index = 0; (long) index < (long) num5; ++index)
        {
          GClass12 gclass12 = new GClass12()
          {
            byte_0 = binaryReader_0.ReadByte()
          };
          gclass12.bool_1 = ((int) gclass12.byte_0 & 1) == 1;
          gclass12.bool_0 = ((uint) gclass12.byte_0 & 128U) > 0U;
          binaryReader_0.smethod_0(3);
          gclass12.uint_1 = binaryReader_0.smethod_4();
          gclass12.uint_2 = binaryReader_0.smethod_4();
          gclass12.short_1 = binaryReader_0.smethod_1();
          gclass12.short_0 = binaryReader_0.smethod_1();
          this.Files.Add(gclass12);
        }
        for (int index = 0; (long) index < (long) num5; ++index)
        {
          string str = "";
          while (true)
          {
            char ch = binaryReader_0.ReadChar();
            if (ch != char.MinValue)
              str += ch.ToString();
            else
              break;
          }
          this.Files[index].string_1 = str;
        }
        foreach (GClass12 gclass12 in this.Files.Where<GClass12>((Func<GClass12, bool>) (gclass12_0 => gclass12_0.bool_1)).ToList<GClass12>())
          gclass12.string_0 = Path.Combine(this.Files[(int) gclass12.uint_1].string_0 ?? "", gclass12.string_1);
        List<int> source = new List<int>()
        {
          (int) this.Files[0].uint_2
        };
        string str1 = "";
        for (int index = 1; (long) index < (long) num5; ++index)
        {
          while (source.Last<int>() <= index)
          {
            str1 = this.method_0(str1);
            source.RemoveAt(source.Count - 1);
          }
          if (this.Files[index].bool_1)
          {
            str1 = Path.Combine(str1, this.Files[index].string_1);
            source.Add((int) this.Files[index].uint_2);
          }
          else
            this.Files[index].string_0 = Path.Combine(str1, this.Files[index].string_1);
        }
      }
    }

    public List<GClass12> Files { get; set; } = new List<GClass12>();

    private string method_0(string string_0)
    {
      try
      {
        return string_0.Substring(0, string_0.LastIndexOfAny(new char[1]
        {
          '\\'
        }));
      }
      catch
      {
        return "";
      }
    }
  }
}
