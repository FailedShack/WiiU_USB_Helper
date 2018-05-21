// Decompiled with JetBrains decompiler
// Type: ns0.GClass30
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml;
using Telerik.WinControls;

namespace ns0
{
  public abstract class GClass30
  {
    private DateTime dateTime_0 = DateTime.MinValue;
    internal const int int_0 = 65536;
    private const int int_1 = 64512;
    private const int int_2 = 1024;
    protected static List<string> list_0;
    private GEnum2 genum2_0;
    private Class60 class60_0;
    public byte[] byte_0;
    public string string_0;
    public string string_1;
    public bool bool_0;

    protected GClass30(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, GEnum3 genum3_1)
    {
      this.Name = string_7;
      this.TitleId = titleId_1;
      this.Region = string_8;
      this.TicketArray = byte_2;
      if (this.TicketArray != null)
        this.Ticket = GClass99.smethod_7(byte_2, genum3_1);
      this.Size = dataSize_1;
      this.RootDownloadLocation = string_9;
      this.System = genum3_1;
    }

    public string String_0
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return "3DS";
          case GEnum3.const_1:
            return "WiiU";
          case GEnum3.const_2:
            return "Switch";
          default:
            return "UKN";
        }
      }
    }

    public string method_0(GStruct3 gstruct3_0)
    {
      return GClass6.smethod_13(this.Size, gstruct3_0);
    }

    public int Int32_0
    {
      get
      {
        if (!this.Boolean_0)
          return GClass80.smethod_1(this.method_1(), (long) this.Size.TotalBytes);
        return this.GEnum2_0 != GEnum2.const_2 ? 0 : 100;
      }
    }

    public bool Boolean_0
    {
      get
      {
        if (this.Platform != Platform.Gamecube && this.Platform != Platform.Wii_Custom && this.Platform != Platform.Super_NES_Custom)
          return this.Platform == Platform.Nintendo_64_Custom;
        return true;
      }
    }

    public GClass32 GClass32_0
    {
      get
      {
        try
        {
          return GClass28.dictionary_0[this.TitleId.FullGame];
        }
        catch
        {
          return (GClass32) null;
        }
      }
    }

    public bool CfwOnly { get; set; }

    public GEnum2 GEnum2_0
    {
      get
      {
        if ((DateTime.Now - this.dateTime_0).TotalSeconds <= 6.0)
          return this.genum2_0;
        this.dateTime_0 = DateTime.Now;
        this.genum2_0 = this.method_19();
        return this.genum2_0;
      }
    }

    public Platform Platform { get; internal set; }

    public GEnum3 System { get; internal set; }

    public string String_1
    {
      get
      {
        return string.Format("{0}{1}/", (object) this.RootDownloadLocation, (object) this.TitleId);
      }
    }

    public bool Hidden { get; set; }

    public string Name { get; set; }

    public virtual string OutputPath { get; } = GClass28.string_4;

    public string String_2
    {
      get
      {
        return Path.Combine(Directory.GetParent(this.OutputPath).FullName, this.TitleId.IdRaw);
      }
    }

    public string Region { get; private set; }

    public DataSize Size { get; private set; }

    public byte[] TicketArray { get; set; }

    public GClass99 Ticket { get; set; }

    public bool DiscOnly { get; set; }

    public TitleId TitleId { get; }

    public GClass100 Tmd { get; set; }

    public bool CurrentlyDownloaded { get; internal set; }

    public bool CurrentlyUploaded { get; internal set; }

    public Color Color_0
    {
      get
      {
        switch (this.GEnum2_0)
        {
          case GEnum2.const_0:
            return Color.Red;
          case GEnum2.const_1:
            return Color.Orange;
          case GEnum2.const_2:
            return Color.Green;
          default:
            return Color.Red;
        }
      }
    }

    public string String_3
    {
      get
      {
        switch (this.GEnum2_0)
        {
          case GEnum2.const_0:
            return "Not downloaded";
          case GEnum2.const_1:
            return string.Format("Download not completed, please resume ({0}%)", (object) this.Int32_0);
          case GEnum2.const_2:
            return "Download completed, ready to install";
          default:
            return "Not downloaded";
        }
      }
    }

    public Color Color_1
    {
      get
      {
        if (!this.Boolean_1)
          return Color.Gray;
        return Color.Green;
      }
    }

    public string String_4
    {
      get
      {
        return !this.Boolean_1 ? "Not installed yet" : "Ready to play";
      }
    }

    public bool Boolean_1
    {
      get
      {
        if (this is GClass32)
        {
          GClass95 gclass95 = this.method_14(false);
          if (gclass95 == null)
            return false;
          return gclass95.Boolean_2;
        }
        if (this is GClass33)
        {
          GClass95 gclass95 = GClass28.dictionary_0[this.TitleId.FullGame].method_14(false);
          if (gclass95 == null)
            return false;
          return gclass95.UpdateIsInstalled();
        }
        if (!(this is GClass31))
          return false;
        GClass95 gclass95_1 = GClass28.dictionary_0[this.TitleId.FullGame].method_14(false);
        if (gclass95_1 == null)
          return false;
        return gclass95_1.DlcIsInstalled();
      }
    }

    public string Version { get; protected set; }

    protected string String_5
    {
      get
      {
        return string.Format("{0} [{1}]", (object) GClass30.smethod_2(this.Name), (object) this.TitleId);
      }
    }

    public virtual string String_6
    {
      get
      {
        return string.Format("{0} ({1})", (object) GClass30.smethod_3(this.String_5), (object) this.Region);
      }
    }

    private string RootDownloadLocation { get; }

    public event EventHandler<GClass81> Event_0;

    public event EventHandler<GEventArgs0> Event_1;

    private long method_1()
    {
      if (!Directory.Exists(this.OutputPath))
        return 0;
      return ((IEnumerable<string>) Directory.GetFiles(this.OutputPath)).Sum<string>((Func<string, long>) (string_0 => new FileInfo(string_0).Length));
    }

    public void method_2(string string_7)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class44 class44 = new GClass30.Class44();
      // ISSUE: reference to a compiler-generated field
      class44.string_0 = string_7;
      if (this.System != GEnum3.const_0)
        return;
      // ISSUE: reference to a compiler-generated field
      if (!Directory.Exists(class44.string_0))
      {
        // ISSUE: reference to a compiler-generated field
        Directory.CreateDirectory(class44.string_0);
      }
      // ISSUE: reference to a compiler-generated field
      class44.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
      // ISSUE: reference to a compiler-generated field
      GClass27.smethod_11(class44.string_0);
      // ISSUE: reference to a compiler-generated field
      ProcessStartInfo processStartInfo = new ProcessStartInfo()
      {
        FileName = "PART1",
        WorkingDirectory = class44.string_0,
        CreateNoWindow = true,
        WindowStyle = ProcessWindowStyle.Hidden
      };
      Process process = new Process();
      process.StartInfo = processStartInfo;
      process.EnableRaisingEvents = true;
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class44.method_0);
      // ISSUE: reference to a compiler-generated field
      this.method_5(class44.string_0, "game");
      process.Start();
      // ISSUE: reference to a compiler-generated field
      int num = (int) class44.frmWait_0.ShowDialog();
    }

    public void method_3(string string_7, bool bool_6 = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class45 class45 = new GClass30.Class45();
      // ISSUE: reference to a compiler-generated field
      class45.string_0 = string_7;
      // ISSUE: reference to a compiler-generated field
      class45.bool_0 = bool_6;
      if (this.System != GEnum3.const_0)
        return;
      // ISSUE: reference to a compiler-generated field
      if (!Directory.Exists(class45.string_0))
      {
        // ISSUE: reference to a compiler-generated field
        Directory.CreateDirectory(class45.string_0);
      }
      // ISSUE: reference to a compiler-generated field
      class45.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
      // ISSUE: reference to a compiler-generated field
      GClass27.smethod_11(class45.string_0);
      // ISSUE: reference to a compiler-generated field
      ProcessStartInfo processStartInfo = new ProcessStartInfo()
      {
        FileName = "PART1",
        WorkingDirectory = class45.string_0,
        CreateNoWindow = true,
        WindowStyle = ProcessWindowStyle.Hidden
      };
      Process process = new Process();
      process.StartInfo = processStartInfo;
      process.EnableRaisingEvents = true;
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class45.method_0);
      // ISSUE: reference to a compiler-generated field
      this.method_5(class45.string_0, "game");
      process.Start();
      // ISSUE: reference to a compiler-generated field
      int num = (int) class45.frmWait_0.ShowDialog();
    }

    public void method_4(string string_7, bool bool_6, bool bool_7, bool bool_8)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class46 class46 = new GClass30.Class46();
      // ISSUE: reference to a compiler-generated field
      class46.string_1 = string_7;
      // ISSUE: reference to a compiler-generated field
      class46.bool_0 = bool_8;
      // ISSUE: reference to a compiler-generated field
      class46.bool_1 = bool_7;
      // ISSUE: reference to a compiler-generated field
      class46.bool_2 = bool_6;
      if (this.System != GEnum3.const_0)
        throw new Exception("This process can only be done on CTR titles");
      // ISSUE: reference to a compiler-generated field
      Directory.CreateDirectory(class46.string_1);
      // ISSUE: reference to a compiler-generated field
      class46.frmWait_0 = new FrmWait("USB Helper is extracting your title...", true);
      // ISSUE: reference to a compiler-generated field
      class46.string_0 = Path.Combine(Path.GetTempPath(), "game.cia");
      // ISSUE: reference to a compiler-generated field
      this.method_5(class46.string_1, "game");
      // ISSUE: reference to a compiler-generated field
      GClass27.smethod_11(class46.string_1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      ProcessStartInfo processStartInfo = new ProcessStartInfo()
      {
        FileName = Path.Combine(class46.string_1, "PART1"),
        WorkingDirectory = class46.string_1
      };
      Process process = new Process();
      process.StartInfo = processStartInfo;
      process.EnableRaisingEvents = true;
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class46.method_0);
      process.Start();
      // ISSUE: reference to a compiler-generated field
      int num = (int) class46.frmWait_0.ShowDialog();
    }

    public void method_5(string string_7, string string_8)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class47 class47 = new GClass30.Class47();
      // ISSUE: reference to a compiler-generated field
      class47.gclass30_0 = this;
      // ISSUE: reference to a compiler-generated field
      class47.string_0 = string_7;
      // ISSUE: reference to a compiler-generated field
      class47.string_1 = string_8;
      if (Directory.Exists(this.String_2))
        FileSystem.DeleteDirectory(this.String_2, DeleteDirectoryOption.DeleteAllContents);
      FileSystem.RenameDirectory(this.OutputPath, this.TitleId.IdRaw);
      string path = Path.Combine(GClass88.CachePath, "makecia.exe");
      try
      {
        File.WriteAllBytes(path, Class123.makecia);
      }
      catch (Exception ex)
      {
      }
      // ISSUE: reference to a compiler-generated field
      string str = string.Format("\"{0}\" \"{1}\\{2}.cia\"", (object) this.String_2, (object) class47.string_0, (object) this.TitleId.IdRaw);
      Process process = new Process();
      process.StartInfo.FileName = path;
      process.EnableRaisingEvents = true;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.Arguments = str;
      process.StartInfo.RedirectStandardOutput = true;
      // ISSUE: reference to a compiler-generated field
      process.StartInfo.WorkingDirectory = class47.string_0;
      // ISSUE: reference to a compiler-generated field
      class47.frmWait_0 = new FrmWait("Please wait while USB Helper packs your game.", true);
      // ISSUE: reference to a compiler-generated method
      process.OutputDataReceived += new DataReceivedEventHandler(class47.method_0);
      process.Start();
      process.BeginOutputReadLine();
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class47.method_1);
      // ISSUE: reference to a compiler-generated field
      int num = (int) class47.frmWait_0.ShowDialog();
    }

    public void method_6()
    {
      this.dateTime_0 = DateTime.MinValue;
    }

    public static void smethod_0()
    {
      GClass30.list_0 = new List<string>();
      if (!GClass88.smethod_1("installed"))
        return;
      GClass30.list_0.AddRange((IEnumerable<string>) GClass88.smethod_7("installed"));
    }

    public static void smethod_1()
    {
      GClass88.smethod_10("installed", GClass30.list_0.ToArray());
    }

    public void method_7()
    {
      Class60 class600 = this.class60_0;
      if (class600 == null)
        return;
      class600.method_0();
    }

    public void method_8()
    {
      // ISSUE: reference to a compiler-generated field
      this.eventHandler_1 = (EventHandler<GEventArgs0>) null;
      // ISSUE: reference to a compiler-generated field
      this.eventHandler_0 = (EventHandler<GClass81>) null;
    }

    public string method_9(bool bool_6, DriveInfo driveInfo_0)
    {
      string str1 = Path.Combine(Path.GetTempPath(), "ext_usb_helper");
      Directory.CreateDirectory(str1);
      if (bool_6 && !this.method_20())
        return "Download Corrupted";
      string str2 = Path.Combine(driveInfo_0.Name, "Install\\", this.String_6 + (this.CfwOnly ? " (CFW ONLY)" : ""));
      GClass6.smethod_5(str2);
      Directory.CreateDirectory(str2);
      if (this.System == GEnum3.const_1)
      {
        try
        {
          FileSystem.CopyDirectory(this.OutputPath, str2, UIOption.AllDialogs);
        }
        catch (Exception ex)
        {
          return ex.Message;
        }
        return "OK";
      }
      if (this.System == GEnum3.const_0)
      {
        this.method_5(str1, "game");
        FileSystem.MoveFile(Path.Combine(str1, "game.cia"), Path.Combine(str2, "title.cia"), UIOption.AllDialogs);
        return "OK";
      }
      if (this.System != GEnum3.const_3)
        throw new NotImplementedException();
      this.method_10(Path.Combine(driveInfo_0.Name, "wads"), this.String_6 + ".wad");
      return "OK";
    }

    public void method_10(string string_7, string string_8 = "game.wad")
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class48 class48 = new GClass30.Class48();
      // ISSUE: reference to a compiler-generated field
      class48.gclass30_0 = this;
      // ISSUE: reference to a compiler-generated field
      class48.string_0 = string_7;
      // ISSUE: reference to a compiler-generated field
      class48.string_1 = string_8;
      // ISSUE: reference to a compiler-generated field
      class48.frmWait_0 = new FrmWait("USB Helper is preparing your game...", true);
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class48.method_0));
      // ISSUE: reference to a compiler-generated field
      int num = (int) class48.frmWait_0.ShowDialog();
    }

    public bool method_11()
    {
      this.method_6();
      try
      {
        GClass6.smethod_5(this.OutputPath);
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public string method_12()
    {
      if (this is GClass32)
        return string.Format("{0} [{1}]", (object) GClass30.smethod_2(this.Name), (object) ((GClass32) this).ProductId);
      return string.Format("{0} (unpacked)", (object) GClass30.smethod_2(this.ToString()));
    }

    public void method_13(GClass95 gclass95_0)
    {
      gclass95_0.Play();
    }

    public GClass95 method_14(bool bool_6)
    {
      if (this.DiscOnly)
        return (GClass95) null;
      switch (this.Platform)
      {
        case Platform.Wii_U_Custom:
          return (GClass95) new Cemu(this, bool_6);
        case Platform.Nintendo_3DS_Download:
          return (GClass95) new Citra(this, bool_6);
        case Platform.GameBoy:
          return (GClass95) new VisualBoyAdvance(this, bool_6);
        case Platform.GameBoy_Color:
          return (GClass95) new VisualBoyAdvance(this, bool_6);
        case Platform.GameBoy_Advance_3DS:
          return (GClass95) new Citra(this, bool_6);
        case Platform.Wii_U_Disc:
          return (GClass95) new Cemu(this, bool_6);
        case Platform.Nintendo_3DS_Download_Software:
          return (GClass95) new Citra(this, bool_6);
        case Platform.Nintendo_3DS:
          return (GClass95) new Citra(this, bool_6);
        case Platform.Wii_U_Download:
          return (GClass95) new Cemu(this, bool_6);
        case Platform.Wii_U_Retail_Download:
          return (GClass95) new Cemu(this, bool_6);
        case Platform.const_8:
          return (GClass95) new Fceux(this, bool_6);
        case Platform.Super_NES:
          return (GClass95) new Snes9x(this, bool_6);
        case Platform.Wii_U_Download_Software:
          return (GClass95) new Cemu(this, bool_6);
        case Platform.Nintendo_DS:
          return (GClass95) new DeSmuMe(this, bool_6);
        case Platform.Nintendo_64:
          return (GClass95) new Project64(this, bool_6);
        case Platform.Wii:
          return (GClass95) new Dolphin(this, bool_6);
        case Platform.New_3DS_Download:
          return (GClass95) new Citra(this, bool_6);
        case Platform.New_3DS_Card_Download:
          return (GClass95) new Citra(this, bool_6);
        case Platform.WiiWare:
          return (GClass95) new Dolphin(this, bool_6);
        default:
          return (GClass95) null;
      }
    }

    public GClass13 method_15()
    {
      if (this.System != GEnum3.const_1)
        throw new Exception("The FST can only be retrieved for WUP titles.");
      GClass100 gclass100 = !(this is GClass33) ? GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd", (object) this.String_1)), GEnum3.const_1) : GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd.{1}", (object) this.String_1, (object) this.Version)), GEnum3.const_1);
      GClass99 gclass99 = this is GClass33 || this.Platform == Platform.Wii_U_Custom ? GClass99.smethod_7(new GClass78().method_2(this.String_1 + "cetk"), GEnum3.const_1) : (!this.bool_0 ? GClass99.smethod_7(this.TicketArray, GEnum3.const_1) : GClass99.smethod_7(File.ReadAllBytes(Path.Combine(Path.Combine(GClass88.CachePath, "tickets"), this.TitleId.IdRaw + ".tik")), GEnum3.const_1));
      byte[] inputBuffer = new GClass78().method_2(this.String_1 + gclass100.GClass101_0[0].ContentId.ToString("x8"));
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Key = gclass99.Byte_0;
        cryptoServiceProvider.Mode = CipherMode.CBC;
        cryptoServiceProvider.Padding = PaddingMode.None;
        cryptoServiceProvider.IV = new byte[16];
        return new GClass13(cryptoServiceProvider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
    }

    public bool method_16(string string_7, bool bool_6, bool bool_7 = false, IEnumerable<GClass12> ienumerable_0 = null, bool bool_8 = false)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class49 class49 = new GClass30.Class49();
      // ISSUE: reference to a compiler-generated field
      class49.bool_0 = false;
      GClass28.gclass30_0 = this;
      if (bool_6)
        string_7 = Path.Combine(string_7, this.method_12());
      if (this.System == GEnum3.const_1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass30.Class50 class50 = new GClass30.Class50();
        // ISSUE: reference to a compiler-generated field
        class50.class49_0 = class49;
        try
        {
          DriveInfo driveInfo = new DriveInfo(Path.GetPathRoot(string_7));
          long availableFreeSpace = driveInfo.AvailableFreeSpace;
          DataSize size = this.Size;
          long totalBytes = (long) size.TotalBytes;
          if ((ulong) availableFreeSpace < (ulong) totalBytes)
          {
            string format = "There isn't enough space left of {0}. Please free {1}.";
            string name = driveInfo.Name;
            size = this.Size;
            // ISSUE: variable of a boxed type
            __Boxed<DataSize> local = (ValueType) new DataSize(size.TotalBytes - (ulong) driveInfo.AvailableFreeSpace);
            int num = (int) RadMessageBox.Show(string.Format(format, (object) name, (object) local));
            return false;
          }
        }
        catch
        {
        }
        Directory.CreateDirectory(string_7);
        if (this.Boolean_0)
        {
          int num = (int) RadMessageBox.Show("Injectable titles cannot be unpacked");
          return false;
        }
        // ISSUE: reference to a compiler-generated field
        class50.frmUnpackAnimation_0 = new frmUnpackAnimation(this);
        Class9 class9 = new Class9(this);
        // ISSUE: reference to a compiler-generated method
        class9.Event_1 += new EventHandler<GStruct0>(class50.method_0);
        // ISSUE: reference to a compiler-generated field
        class50.bool_0 = false;
        // ISSUE: reference to a compiler-generated method
        class9.Event_0 += new EventHandler<bool>(class50.method_1);
        // ISSUE: reference to a compiler-generated method
        class9.Event_2 += new EventHandler<Exception>(class50.method_2);
        if (ienumerable_0 != null)
          class9.method_1(string_7, bool_7, ienumerable_0.ToList<GClass12>(), bool_8);
        else
          class9.method_1(string_7, bool_7, (List<GClass12>) null, bool_8);
        // ISSUE: reference to a compiler-generated field
        if (!class50.bool_0)
        {
          // ISSUE: reference to a compiler-generated field
          int num1 = (int) class50.frmUnpackAnimation_0.ShowDialog();
        }
        try
        {
          if (this is GClass32 & bool_6)
          {
            if (!string_7.Contains("EMULATORS"))
            {
              string path = Path.Combine(string_7, "meta", "meta.xml");
              if (File.Exists(path))
              {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(File.ReadAllText(path));
                string innerText = xmlDocument.GetElementsByTagName("company_code")[0].InnerText;
                string name = new DirectoryInfo(string_7).Name;
                string newName = name.Substring(0, name.IndexOf("[")) + "[" + ((GClass32) this).ProductId + innerText.Substring(2) + "]";
                FileSystem.RenameDirectory(string_7, newName);
              }
            }
          }
        }
        catch
        {
        }
      }
      else if (this.System == GEnum3.const_0)
      {
        GClass28.gclass30_0 = (GClass30) null;
        return false;
      }
      GClass28.gclass30_0 = (GClass30) null;
      // ISSUE: reference to a compiler-generated field
      return class49.bool_0;
    }

    private void method_17(string string_7, string string_8)
    {
      if (!Directory.Exists(string_7))
        return;
      FileSystem.MoveDirectory(string_7, string_8, UIOption.OnlyErrorDialogs);
    }

    public void method_18(bool bool_6, GClass82 gclass82_0, bool bool_7, bool? nullable_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class51 class51 = new GClass30.Class51();
      // ISSUE: reference to a compiler-generated field
      class51.gclass30_0 = this;
      // ISSUE: reference to a compiler-generated field
      class51.bool_0 = bool_7;
      if (this.System != GEnum3.const_1)
        return;
      this.CurrentlyUploaded = true;
      if (bool_6 && !this.method_20())
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<GClass81> eventHandler0 = this.eventHandler_0;
        if (eventHandler0 == null)
          return;
        eventHandler0((object) this, new GClass81("Download Corrupted", true, GEnum5.const_5));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class51.string_0 = this.String_6 + (this.CfwOnly ? " (CFW ONLY)" : "");
        // ISSUE: reference to a compiler-generated field
        class51.long_1 = ((IEnumerable<FileInfo>) new DirectoryInfo(this.OutputPath).GetFiles()).Sum<FileInfo>((Func<FileInfo, long>) (fileInfo_0 => fileInfo_0.Length));
        // ISSUE: reference to a compiler-generated field
        string string_4 = Path.Combine("/sd/Install/", class51.string_0);
        this.class60_0 = new Class60(gclass82_0.IPAddress_0.ToString(), "anonymous", "");
        if (!this.class60_0.method_1())
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<GClass81> eventHandler0 = this.eventHandler_0;
          if (eventHandler0 == null)
            return;
          eventHandler0((object) this, new GClass81("Could not connect to the WIIU", true, GEnum5.const_1));
        }
        else
        {
          if (nullable_0.HasValue)
            this.class60_0.method_13(nullable_0.Value);
          this.class60_0.method_2("/sd/Install/");
          this.class60_0.method_2(string_4);
          // ISSUE: reference to a compiler-generated method
          this.class60_0.Event_1 += new EventHandler(class51.method_0);
          // ISSUE: reference to a compiler-generated field
          class51.long_0 = 0L;
          // ISSUE: reference to a compiler-generated field
          class51.dateTime_0 = DateTime.Now;
          // ISSUE: reference to a compiler-generated field
          class51.ulong_0 = 0UL;
          // ISSUE: reference to a compiler-generated method
          this.class60_0.Event_0 += new EventHandler<long>(class51.method_1);
          try
          {
            this.class60_0.method_14(string_4, this.OutputPath);
          }
          catch (Exception ex)
          {
            // ISSUE: reference to a compiler-generated field
            EventHandler<GClass81> eventHandler0 = this.eventHandler_0;
            if (eventHandler0 == null)
              return;
            eventHandler0((object) this, new GClass81(ex.Message, true, GEnum5.const_4));
          }
        }
      }
    }

    public static string smethod_2(string string_7)
    {
      string_7 = string_7.Replace(":", "");
      return ((IEnumerable<char>) Path.GetInvalidFileNameChars()).Aggregate<char, string>(string_7, (Func<string, char, string>) ((string_0, char_0) => string_0.Replace(char_0, ' ')));
    }

    public static string smethod_3(string string_7)
    {
      string string_0 = string_7.smethod_10(new char[9]
      {
        '@',
        '#',
        '®',
        '™',
        '+',
        ':',
        ';',
        '©',
        '\''
      }, ' ').smethod_10(new char[3]{ 'é', 'è', 'ê' }, 'e').smethod_10(new char[2]
      {
        'È',
        'É'
      }, 'E').smethod_10(new char[2]{ 'à', 'â' }, 'a').smethod_10(new char[3]
      {
        'ô',
        'ò',
        'ö'
      }, 'o').Replace("&", "and");
      if (GClass10.smethod_0(string_0))
        return GClass10.smethod_1(string_0);
      return string_0;
    }

    private GEnum2 method_19()
    {
      if (!Directory.Exists(this.OutputPath) || !File.Exists(Path.Combine(this.OutputPath, "title.tmd")) || !File.Exists(Path.Combine(this.OutputPath, "title.tik")) || (this.System == GEnum3.const_1 || this.System == GEnum3.const_3) && !File.Exists(Path.Combine(this.OutputPath, "title.cert")))
        return GEnum2.const_0;
      if ((this is GClass31 || this.Platform == Platform.Wii_U_Custom) && !new GClass78().method_2(this.String_1 + "tmd").smethod_5(File.ReadAllBytes(Path.Combine(this.OutputPath, "title.tmd"))))
        return GEnum2.const_1;
      foreach (GClass101 gclass101 in GClass100.smethod_0(Path.Combine(this.OutputPath, "title.tmd"), this.System).GClass101_0)
      {
        string outputPath1 = this.OutputPath;
        uint contentId = gclass101.ContentId;
        string path2_1 = contentId.ToString("x8") + ".app";
        string str = Path.Combine(outputPath1, path2_1);
        if (!File.Exists(str) || new FileInfo(str).Length != (long) gclass101.Size.TotalBytes.smethod_2(16U))
          return GEnum2.const_1;
        if (gclass101.Boolean_0)
        {
          string outputPath2 = this.OutputPath;
          contentId = gclass101.ContentId;
          string path2_2 = contentId.ToString("x8") + ".h3";
          if (!File.Exists(Path.Combine(outputPath2, path2_2)))
            return GEnum2.const_1;
        }
      }
      return GEnum2.const_2;
    }

    private bool method_20()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass30.Class52 class52 = new GClass30.Class52();
      // ISSUE: reference to a compiler-generated field
      class52.gclass30_0 = this;
      // ISSUE: reference to a compiler-generated field
      class52.frmWait_0 = new FrmWait("USB Helper is verifying your download. Please wait.", false);
      // ISSUE: reference to a compiler-generated field
      class52.list_0 = (List<GStruct7>) null;
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class52.method_0));
      // ISSUE: reference to a compiler-generated field
      int num = (int) class52.frmWait_0.ShowDialog();
      // ISSUE: reference to a compiler-generated field
      if (class52.list_0 == null)
        return false;
      // ISSUE: reference to a compiler-generated field
      return class52.list_0.All<GStruct7>((Func<GStruct7, bool>) (gstruct7_0 => gstruct7_0.Boolean_0));
    }
  }
}
