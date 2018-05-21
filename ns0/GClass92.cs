// Decompiled with JetBrains decompiler
// Type: ns0.GClass92
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace ns0
{
  public class GClass92 : GClass91
  {
    private string string_3;
    private GClass30 gclass30_0;

    public GClass92(GClass32 gclass32_1)
      : base(gclass32_1)
    {
    }

    public override string[] String_3
    {
      get
      {
        return new string[4]
        {
          "Fetching the content",
          "Preparing the ROM",
          "Injecting the ROM",
          "Packing the game"
        };
      }
    }

    public override bool vmethod_0(string string_4)
    {
      if (this.method_14(string_4))
      {
        this.string_3 = string_4;
        return true;
      }
      int num = (int) RadMessageBox.Show("USB Helper was unable to recognize this ROM. Make sure you have provided a ROM of the same region as the title you are trying to inject");
      return false;
    }

    public override int vmethod_1()
    {
      return !System.IO.File.Exists(this.string_3) ? 0 : 1;
    }

    public override void vmethod_2()
    {
      base.vmethod_2();
      Task.Run((Action) (() =>
      {
        try
        {
          this.method_11(0);
          if (this.GClass30_0.GEnum2_0 != GEnum2.const_2)
          {
            GClass80 gclass80 = new GClass80((WebProxy) null, false, false);
            gclass80.Event_5 += (EventHandler<GClass81>) ((object_0, gclass81_0) => this.method_15());
            gclass80.method_1(new List<GClass30>((IEnumerable<GClass30>) new GClass30[1]
            {
              this.GClass30_0
            }), 100, 10000);
          }
          else
            this.method_15();
        }
        catch (Exception ex)
        {
          this.method_10(ex);
        }
      }));
    }

    public bool method_14(string string_4)
    {
      try
      {
        return this.List_0.Contains(this.method_16(string_4));
      }
      catch
      {
        return false;
      }
    }

    private GClass30 GClass30_0
    {
      get
      {
        if (this.gclass30_0 == null)
          this.gclass30_0 = (GClass30) GClass28.dictionary_0[new TitleId(this.method_6("template"))];
        return this.gclass30_0;
      }
    }

    public override string String_1
    {
      get
      {
        return "ROM";
      }
    }

    public override string String_2
    {
      get
      {
        return "n64 (*.n64)|*.n64|z64 (*.z64)|*.z64|v64 (*.v64)|*.v64";
      }
    }

    private void method_15()
    {
      string str1 = Path.Combine(this.WorkPath, "rawFiles");
      Directory.CreateDirectory(str1);
      this.GClass30_0.method_16(str1, false, false, (IEnumerable<GClass12>) null, false);
      Task task = this.method_7();
      this.method_11(1);
      string fullName = new DirectoryInfo(Path.Combine(str1, "content", "rom")).GetFiles()[0].FullName;
      GClass6.smethod_6(fullName);
      System.IO.File.WriteAllBytes(fullName, this.method_18(this.string_3, new int?()));
      try
      {
        string fileName = Path.GetFileName(fullName);
        this.method_5("config", Path.Combine(str1, "content", "config"));
        string str2 = Path.Combine(str1, "content", "config", fileName + ".ini");
        GClass6.smethod_6(str2);
        System.IO.File.Move(Path.Combine(str1, "content", "config", "config"), str2);
      }
      catch
      {
      }
      GClass6.smethod_8(string.Format("{0}/res/SNES/vc-template.zip", (object) Class67.String_2), this.WorkPath);
      task.Wait();
      this.method_11(3);
      this.vmethod_3();
      this.method_8();
      this.method_9();
    }

    private string method_16(string string_4)
    {
      return Encoding.GetEncoding(932).GetString(this.method_18(string_4, new int?(512)), 59, 4);
    }

    private GClass92.Enum2 method_17(string string_4)
    {
      using (BinaryReader binaryReader = new BinaryReader((Stream) System.IO.File.OpenRead(string_4)))
      {
        switch (binaryReader.ReadByte())
        {
          case 55:
            return GClass92.Enum2.const_2;
          case 64:
            return GClass92.Enum2.const_1;
          case 128:
            return GClass92.Enum2.const_0;
          default:
            return GClass92.Enum2.const_3;
        }
      }
    }

    private byte[] method_18(string string_4, int? nullable_0 = null)
    {
      GClass92.Enum2 enum2 = this.method_17(string_4);
      int count = 1;
      switch (enum2)
      {
        case GClass92.Enum2.const_0:
          count = 1;
          break;
        case GClass92.Enum2.const_1:
          count = 4;
          break;
        case GClass92.Enum2.const_2:
          count = 2;
          break;
      }
      byte[] buffer = new byte[count];
      using (FileStream fileStream = System.IO.File.OpenRead(string_4))
      {
        int? nullable = nullable_0;
        byte[] numArray = new byte[nullable.HasValue ? checked ((IntPtr) nullable.GetValueOrDefault()) : checked ((IntPtr) fileStream.Length)];
        int num = 0;
        do
        {
          if (fileStream.Read(buffer, 0, count) > 0)
            goto label_7;
label_6:
          continue;
label_7:
          for (int index = count - 1; index >= 0; --index)
            numArray[num++] = buffer[index];
          goto label_6;
        }
        while (num < numArray.Length);
        return numArray;
      }
    }

    private void method_19(string string_4)
    {
      string str = this.method_4("patcher.exe");
      new GClass78().method_5(string.Format("{0}/res/SNES/bootDrc.tga", (object) Class67.String_2), str, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
      GClass91.smethod_2(str, this.WorkPath, string.Format("-f -s -z9 -nolib \"{0}\"", (object) string_4), "CAFE_ROOT", this.WorkPath);
    }

    protected override void vmethod_3()
    {
      this.method_2((GClass32) this.GClass30_0);
      GClass91.smethod_1(GClass91.String_0, this.WorkPath, string.Format("-jar \"{0}\" -in rawFiles", (object) "NUSPacker.jar"));
    }

    private enum Enum2
    {
      const_0,
      const_1,
      const_2,
      const_3,
    }
  }
}
