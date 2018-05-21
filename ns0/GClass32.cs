// Decompiled with JetBrains decompiler
// Type: ns0.GClass32
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIIU_Downloader.Forms;

namespace ns0
{
  public class GClass32 : GClass30
  {
    private static readonly string[] string_11 = new string[9]
    {
      "GB",
      "US",
      "JP",
      "AU",
      "DE",
      "FR",
      "IT",
      "SP",
      "MX"
    };
    private readonly string string_7 = string.Format("{0}/res/nintendont/template/", (object) Class67.String_2);
    private readonly string string_8 = string.Format("{0}/res/Wii/template/", (object) Class67.String_2);
    private readonly string string_9 = string.Format("{0}/res/SNES/template/", (object) Class67.String_2);
    private readonly string string_10 = string.Format("{0}/res/N64/template/", (object) Class67.String_2);
    public GClass86 gclass86_0 = new GClass86();
    public GClass86 gclass86_1 = new GClass86();
    public GClass86 gclass86_2 = new GClass86();
    private GClass74 gclass74_0;

    public GClass32(string string_15, TitleId titleId_1, string string_16, byte[] byte_2, DataSize dataSize_1, List<GClass33> list_2, string string_17, string string_18, string string_19, string string_20, Platform platform_1, GEnum3 genum3_1)
      : base(string_15, titleId_1, string_16, byte_2, dataSize_1, string_20, genum3_1)
    {
      this.EshopId = string_17;
      this.IconUrl = string_19;
      this.ProductId = string_18;
      this.Updates = list_2;
      this.Platform = platform_1;
    }

    public new string String_6
    {
      get
      {
        if (!this.Boolean_0)
          throw new Exception("This can only be used on injectable titles!");
        switch (this.Platform)
        {
          case Platform.Gamecube:
            return this.string_7 + this.ProductId;
          case Platform.Wii_Custom:
            return this.string_8 + this.ProductId;
          case Platform.Super_NES_Custom:
            return this.string_9 + this.ProductId;
          case Platform.Nintendo_64_Custom:
            return this.string_10 + this.ProductId;
          default:
            throw new Exception("This can only be used on injectable titles!");
        }
      }
    }

    public string String_7
    {
      get
      {
        string str = this.Region == "EUR" ? "EN" : (this.Region == "USA" ? "US" : "JA");
        switch (this.System)
        {
          case GEnum3.const_0:
            return string.Format("http://art.gametdb.com/3ds/box/{0}/{1}.png", (object) str, (object) this.ProductId);
          case GEnum3.const_1:
            return string.Format("http://art.gametdb.com/wiiu/cover3D/{0}/{1}.png", (object) str, (object) this.ProductId);
          case GEnum3.const_3:
            return string.Format("http://art.gametdb.com/wii/cover3D/{0}/{1}.png", (object) str, (object) this.ProductId);
          default:
            throw new NotImplementedException("Unknown system");
        }
      }
    }

    public GClass31 Dlc { get; set; }

    public string EshopId { get; }

    public bool Boolean_2
    {
      get
      {
        return this.Dlc != null;
      }
    }

    public bool Boolean_3
    {
      get
      {
        return this.Updates.Count > 0;
      }
    }

    public string IconUrl { get; }

    public bool Boolean_4
    {
      get
      {
        return GClass28.list_3.Contains(this);
      }
    }

    public bool Boolean_5
    {
      get
      {
        return GClass30.list_0.Contains(this.TitleId.IdRaw);
      }
      set
      {
        bool flag;
        if ((flag = GClass30.list_0.Contains(this.TitleId.IdRaw)) && !value)
        {
          GClass30.list_0.Remove(this.TitleId.IdRaw);
        }
        else
        {
          if (!(!flag & value))
            return;
          GClass30.list_0.Add(this.TitleId.IdRaw);
        }
      }
    }

    public GClass91 method_21()
    {
      switch (this.Platform)
      {
        case Platform.Gamecube:
          return (GClass91) new GClass94(this);
        case Platform.Wii_Custom:
          return (GClass91) new GClass94(this);
        case Platform.Super_NES_Custom:
          return (GClass91) new GClass93(this);
        case Platform.Nintendo_64_Custom:
          return (GClass91) new GClass92(this);
        default:
          return (GClass91) null;
      }
    }

    public override string OutputPath
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return Path.Combine(base.OutputPath, "DATA_3DS", this.Region, this.CfwOnly ? "ESHOP" : "GAMES", this.String_5);
          case GEnum3.const_1:
            return Path.Combine(base.OutputPath, "DATA", this.Region, this.CfwOnly ? "ESHOP" : "GAMES", this.String_5);
          case GEnum3.const_2:
            throw new NotImplementedException();
          case GEnum3.const_3:
            return Path.Combine(base.OutputPath, "DATA_WII", this.Region, this.CfwOnly ? "ESHOP" : "GAMES", this.String_5);
          default:
            throw new NotImplementedException();
        }
      }
    }

    public string ProductId { get; }

    public List<GClass33> Updates { get; } = new List<GClass33>();

    private string String_8
    {
      get
      {
        return Path.Combine(base.OutputPath, "DATA", "SAVES", this.Region, this.String_5);
      }
    }

    public string String_9
    {
      get
      {
        string str = "";
        switch (this.Updates.Last<GClass33>().GEnum2_0)
        {
          case GEnum2.const_0:
            str = "Latest update not downloaded.";
            break;
          case GEnum2.const_1:
            str = string.Format("Latest update partially downloaded ({0}%).", (object) this.Updates.Last<GClass33>().Int32_0);
            break;
          case GEnum2.const_2:
            str = "Latest update downloaded.";
            break;
        }
        int num1 = this.Updates.Count<GClass33>();
        int num2 = this.Updates.Count<GClass33>((Func<GClass33, bool>) (gclass33_0 => gclass33_0.GEnum2_0 == GEnum2.const_2));
        return str + string.Format(" ({0}/{1})", (object) num2, (object) num1);
      }
    }

    public void method_22()
    {
      GClass95 gclass95 = this.method_14(false);
      if (gclass95 == null)
        return;
      gclass95.method_5();
    }

    public void method_23(string string_15, string string_16)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass32.Class42 class42 = new GClass32.Class42();
      // ISSUE: reference to a compiler-generated field
      class42.string_0 = string_15;
      // ISSUE: reference to a compiler-generated field
      class42.string_1 = string_16;
      // ISSUE: reference to a compiler-generated field
      class42.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
      // ISSUE: reference to a compiler-generated field
      class42.string_2 = Path.Combine(Path.GetTempPath(), "ext_usb_helper");
      // ISSUE: reference to a compiler-generated field
      Directory.CreateDirectory(class42.string_2);
      // ISSUE: reference to a compiler-generated field
      Directory.CreateDirectory(class42.string_0);
      // ISSUE: reference to a compiler-generated field
      this.method_3(class42.string_2, true);
      // ISSUE: reference to a compiler-generated field
      GClass27.smethod_11(class42.string_2);
      // ISSUE: reference to a compiler-generated field
      ProcessStartInfo processStartInfo = new ProcessStartInfo()
      {
        FileName = "makerom.exe",
        WorkingDirectory = class42.string_2,
        Arguments = "-f cia -o game.cia -content game.cxi:0:0"
      };
      Process process = new Process();
      process.StartInfo = processStartInfo;
      process.EnableRaisingEvents = true;
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class42.method_0);
      process.Start();
      // ISSUE: reference to a compiler-generated field
      int num = (int) class42.frmWait_0.ShowDialog();
    }

    public List<SaveDescription> method_24()
    {
      List<SaveDescription> saveDescriptionList = new List<SaveDescription>();
      if (!Directory.Exists(this.String_8))
        return saveDescriptionList;
      foreach (FileInfo fileInfo in new DirectoryInfo(this.String_8).EnumerateFiles().Where<FileInfo>((Func<FileInfo, bool>) (fileInfo_0 => Path.GetExtension(fileInfo_0.Name) == ".zip")))
      {
        try
        {
          using (FileStream fileStream = File.Open(fileInfo.FullName, FileMode.Open))
          {
            using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Read))
            {
              using (StreamReader streamReader = new StreamReader(zipArchive.GetEntry("meta.json").Open()))
                saveDescriptionList.Add(JsonConvert.DeserializeObject<SaveDescription>(streamReader.ReadToEnd()));
            }
          }
        }
        catch
        {
        }
      }
      return saveDescriptionList;
    }

    public string method_25(GClass82 gclass82_0, string string_15)
    {
      if (!Directory.Exists(this.String_8))
        Directory.CreateDirectory(this.String_8);
      string str1 = ((long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString();
      string str2 = Path.Combine(this.String_8, str1 + ".zip");
      try
      {
        Class4.smethod_0((GClass30) this, gclass82_0.IPAddress_0, str2);
      }
      catch
      {
        GClass6.smethod_6(str2);
        throw;
      }
      if (!File.Exists(str2))
        return (string) null;
      using (FileStream fileStream = File.Open(str2, FileMode.Open, FileAccess.ReadWrite))
      {
        using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Update))
        {
          using (StreamWriter streamWriter = new StreamWriter(zipArchive.CreateEntry("meta.json").Open()))
          {
            string str3 = JsonConvert.SerializeObject((object) new SaveDescription()
            {
              Description = string_15,
              Timestamp = str1,
              Region = this.Region,
              Name = this.Name,
              TitleId = this.TitleId.IdRaw
            });
            streamWriter.Write(str3);
          }
        }
      }
      return str2;
    }

    public void method_26(GClass82 gclass82_0, string string_15)
    {
      string string_0 = Path.Combine(this.String_8, string_15 + ".zip");
      Class4.smethod_1((GClass30) this, gclass82_0.IPAddress_0, string_0);
    }

    public static DriveInfo smethod_4(DataSize dataSize_1)
    {
      FrmSelectDrive frmSelectDrive = new FrmSelectDrive(dataSize_1);
      if (frmSelectDrive.ShowDialog() == DialogResult.OK)
        return frmSelectDrive.driveInfo_0;
      return (DriveInfo) null;
    }

    private string method_27(string string_15)
    {
      try
      {
        int index = 0;
        GClass78 gclass78 = new GClass78()
        {
          bool_0 = true
        };
        if (this.System == GEnum3.const_3)
          return gclass78.method_6(string.Format("{0}/wii/info/json/{1}/info", (object) Class67.String_2, (object) this.TitleId.IdRaw));
        if (this.Platform == Platform.Wii_U_Custom || this.Boolean_0)
          return gclass78.method_6(string.Format("{0}/wiiu/info/US/{1}", (object) Class67.String_2, (object) this.TitleId.IdRaw));
        string str1 = gclass78.method_7(string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/title/{1}/?shop_id=2", (object) string_15, (object) this.EshopId), 604800);
        if (str1 != "")
          return str1;
        for (; index < GClass32.string_11.Length; ++index)
        {
          if (GClass32.string_11[index] != string_15)
          {
            string str2 = gclass78.method_7(string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/title/{1}/?shop_id=2", (object) GClass32.string_11[index], (object) this.EshopId), 604800);
            if (str2 != "")
              return str2;
          }
        }
      }
      catch
      {
      }
      return (string) null;
    }

    public void method_28(Action<GClass74, GClass32> action_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(new GClass32.Class43()
      {
        gclass32_0 = this,
        action_0 = action_0
      }.method_0));
    }

    public bool method_29(GClass30 gclass30_0)
    {
      if (gclass30_0 == this || this.Boolean_3 && gclass30_0 == this.Updates.Last<GClass33>())
        return true;
      if (this.Boolean_2)
        return gclass30_0 == this.Dlc;
      return false;
    }

    public override string ToString()
    {
      return string.Format("{0} ({1}) ({2}) ({3}%)", (object) this.Name, (object) this.Size, (object) this.Region, (object) this.Int32_0);
    }

    public string method_30()
    {
      return string.Format("{0} ({1}) ({2})", (object) this.Name, (object) this.Size, (object) this.Region);
    }

    public GClass29 method_31()
    {
      FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(this, WhatToAction.Copy);
      if (frmWhatToCopy.ShowDialog() != DialogResult.OK)
        return (GClass29) null;
      return new GClass29()
      {
        bool_0 = frmWhatToCopy.CopyDlc,
        bool_2 = frmWhatToCopy.CopyUpdate,
        bool_1 = frmWhatToCopy.CopyGame,
        list_0 = frmWhatToCopy.list_0
      };
    }
  }
}
