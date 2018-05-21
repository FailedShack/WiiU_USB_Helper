// Decompiled with JetBrains decompiler
// Type: ns0.GClass95
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Nus_Helper_Shared_Core.NusHelper.Emulators;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
  public abstract class GClass95
  {
    protected readonly GClass30 gclass30_0;
    protected bool bool_0;

    internal GClass95(GClass30 gclass30_1, string string_2, string string_3, bool bool_3 = true, bool bool_4 = false)
    {
      this.gclass30_0 = gclass30_1;
      this.FullScreen = bool_4;
      this.Name = string_2;
      try
      {
        if (!Directory.Exists(this.String_6))
          Directory.CreateDirectory(this.String_6);
      }
      catch (Exception ex)
      {
        int num = (int) RadMessageBox.Show("An error occured while initializing the emulators. Most likely you have unplugged the drive on which your games are stored. The emulation settings will now be cleared and the application will close.\n" + ex.ToString());
        try
        {
          GClass6.smethod_5(Path.Combine(GClass17.string_0));
        }
        catch
        {
        }
        Environment.Exit(0);
        return;
      }
      if (!Directory.Exists(this.String_5))
        Directory.CreateDirectory(this.String_5);
      if (!Directory.Exists(this.String_4))
        Directory.CreateDirectory(this.String_4);
      this.Url = string_3;
      this.bool_0 = bool_3;
      if (!bool_3)
        return;
      this.method_1();
    }

    public string String_0
    {
      get
      {
        return string.Format("{0}/res/emulators/{1}.zip", (object) Class67.String_2, (object) this.Name);
      }
    }

    public void method_0()
    {
      string str = "";
      try
      {
        str = System.IO.File.ReadAllText(Path.Combine(this.String_4, "etag"));
      }
      catch
      {
      }
      string contents = GClass6.smethod_14(this.String_0);
      if (this.Boolean_0 && !(str != contents))
        return;
      Class67.smethod_3(this);
      if (!this.Boolean_0)
        return;
      System.IO.File.WriteAllText(Path.Combine(this.String_4, "etag"), contents);
    }

    public void method_1()
    {
      if (!new GClass17(this).method_0().AutoUpdate)
        return;
      this.method_0();
    }

    public virtual string FileSaveLocation
    {
      get
      {
        return (string) null;
      }
    }

    public virtual string vmethod_0()
    {
      if (!Directory.Exists(this.FileSaveLocation))
        return (string) null;
      string destinationArchiveFileName = Path.GetTempPath() + (object) Guid.NewGuid();
      ZipFile.CreateFromDirectory(this.FileSaveLocation, destinationArchiveFileName);
      return destinationArchiveFileName;
    }

    public void method_2(string string_2, string string_3, string string_4)
    {
      if (string_2 == null)
        return;
      string str = Path.Combine(Path.GetDirectoryName(string_2), Convert.ToBase64String(Encoding.UTF8.GetBytes(string_3 + " " + string_4 + " " + this.gclass30_0.TitleId.IdRaw)));
      GClass6.smethod_6(str);
      System.IO.File.Move(string_2, str);
      string text = Class67.smethod_14(str, string.Format("{0}/saves/upload_save_b64.php", (object) Class67.String_1));
      if (!(text != "OK"))
        return;
      int num = (int) RadMessageBox.Show(text);
    }

    private void method_3()
    {
      try
      {
        string str = Path.Combine(GClass88.CachePath, "saves_backup");
        foreach (DirectoryInfo enumerateDirectory in new DirectoryInfo(str).EnumerateDirectories())
        {
          if (enumerateDirectory.Name.Contains<char>(','))
            enumerateDirectory.MoveTo(Path.Combine(str, enumerateDirectory.Name.Substring(0, enumerateDirectory.Name.IndexOf(','))));
        }
      }
      catch
      {
      }
    }

    public void method_4(string string_2, string string_3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass95.Class83 class83 = new GClass95.Class83();
      // ISSUE: reference to a compiler-generated field
      class83.gclass95_0 = this;
      this.method_3();
      if (this.FileSaveLocation == null)
        return;
      WebClient webClient = new WebClient();
      if (new WebClient().UploadValues(new Uri(string.Format("{0}/saves/get_save.php", (object) Class67.String_1)), new NameValueCollection()
      {
        {
          "username",
          string_2
        },
        {
          "password",
          string_3
        },
        {
          "titleid",
          this.gclass30_0.TitleId.IdRaw
        },
        {
          "hash",
          "true"
        }
      }).Length == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      class83.frmWait_0 = new FrmWait("USB Helper is downloading your save", true);
      // ISSUE: reference to a compiler-generated method
      webClient.UploadValuesCompleted += new UploadValuesCompletedEventHandler(class83.method_0);
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(class83.method_1);
      webClient.UploadValuesAsync(new Uri(string.Format("{0}/saves/get_save.php", (object) Class67.String_1)), new NameValueCollection()
      {
        {
          "username",
          string_2
        },
        {
          "password",
          string_3
        },
        {
          "titleid",
          this.gclass30_0.TitleId.IdRaw
        }
      });
      // ISSUE: reference to a compiler-generated field
      int num = (int) class83.frmWait_0.ShowDialog();
    }

    public virtual bool SupportsCustomControllerProfiles { get; }

    public virtual List<GClass95.GStruct6> GetControllerProfiles()
    {
      return new List<GClass95.GStruct6>();
    }

    public virtual void ApplyControllerProfile(GClass95.GStruct6 config)
    {
    }

    public string Name { get; }

    public string Url { get; }

    public string String_1
    {
      get
      {
        return Path.Combine(this.CurrentGamePath, "meta", "bootTvTex.tga");
      }
    }

    public string String_2
    {
      get
      {
        return Path.Combine(this.CurrentGamePath, "meta", "bootSound.btsnd");
      }
    }

    public string String_3
    {
      get
      {
        return Path.Combine(this.CurrentGamePath, "meta", "bootSound.wav");
      }
    }

    public bool FullScreen { get; set; }

    internal virtual string CurrentGamePath
    {
      get
      {
        return Path.Combine(this.String_5, this.gclass30_0.method_12());
      }
    }

    internal string String_4
    {
      get
      {
        return Path.Combine(this.String_6, "BIN");
      }
    }

    internal string String_5
    {
      get
      {
        return Path.Combine(this.String_6, "GAMES");
      }
    }

    private string String_6
    {
      get
      {
        return this.EmuConfiguration_0.RootPath;
      }
    }

    public EmuConfiguration EmuConfiguration_0
    {
      get
      {
        return new GClass17(this).method_0();
      }
    }

    private string String_7
    {
      get
      {
        return Path.Combine(this.CurrentGamePath, "stream.helper");
      }
    }

    public bool Boolean_0
    {
      get
      {
        return System.IO.File.Exists(this.GetExecutable());
      }
    }

    public bool Boolean_1
    {
      get
      {
        return System.IO.File.Exists(this.String_7);
      }
      set
      {
        if (value)
          System.IO.File.CreateText(this.String_7);
        else
          GClass6.smethod_6(this.String_7);
      }
    }

    public bool Boolean_2
    {
      get
      {
        try
        {
          return System.IO.File.Exists(this.GetRom()) && new FileInfo(this.GetRom()).Length > 0L && !this.Boolean_1;
        }
        catch
        {
          return false;
        }
      }
    }

    public virtual void Play()
    {
      try
      {
        if (!this.gclass30_0.Boolean_1 && this.gclass30_0.GEnum2_0 != GEnum2.const_2)
          this.method_6();
        else
          this.method_5();
        this.method_8(this.GetArguments());
      }
      catch (Exception ex)
      {
        int num = (int) RadMessageBox.Show("An error occured while trying to prepare this title." + (object) ex);
      }
    }

    public void method_5()
    {
      this.Boolean_1 = false;
      Class67.smethod_6();
      this.PrepareRomIfNecessary(false);
    }

    public void method_6()
    {
      this.Boolean_1 = false;
      Class67.smethod_6();
      this.PrepareRomIfNecessary(true);
    }

    public event EventHandler Event_0;

    protected void method_7()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }

    protected void method_8(string string_2)
    {
      if (!this.Boolean_0)
        throw new FileNotFoundException(string.Format("The emulator is not installed. If you have disabled automatic updates, you have to install it in {0} before being able to use it.", (object) this.GetExecutable()));
      Process process = new Process();
      process.StartInfo.FileName = this.GetExecutable();
      process.EnableRaisingEvents = true;
      process.StartInfo.Arguments = string_2;
      process.StartInfo.WorkingDirectory = this.String_4;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.RedirectStandardOutput = true;
      process.Exited += (EventHandler) ((sender, e) => this.method_7());
      if (Settings.Default.EnableCloudSaving)
      {
        this.method_4(Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
        this.Event_0 += (EventHandler) ((sender, e) => this.method_2(this.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord));
      }
      process.Start();
      if (!Settings.Default.PauseMiner)
        return;
      Class108.smethod_1();
      this.Event_0 += (EventHandler) ((sender, e) => Class108.smethod_0());
    }

    protected static long smethod_0(Stream stream_0, byte[] byte_0)
    {
      long position = stream_0.Position;
      byte[] buffer = new byte[8192];
      int num1 = 0;
      int index1;
      int index2;
      int num2;
      do
      {
        num2 = stream_0.Read(buffer, 0, buffer.Length);
        index2 = 0;
        for (index1 = 0; index1 < num2; ++index1)
        {
          ++num1;
          if ((int) buffer[index1] == (int) byte_0[index2])
            ++index2;
          else
            index2 = 0;
          if (index2 == byte_0.Length)
            break;
        }
      }
      while (num2 > 0 && index2 != byte_0.Length);
      stream_0.Seek(position + (long) num1 - (long) byte_0.Length, SeekOrigin.Begin);
      return position + (long) index1 - (long) byte_0.Length;
    }

    public virtual void vmethod_1()
    {
      try
      {
        GClass6.smethod_5(this.CurrentGamePath);
      }
      catch
      {
      }
    }

    public virtual void DeleteUpdate()
    {
    }

    public virtual void DeleteDlc()
    {
    }

    protected static DataSize smethod_1(string string_2)
    {
      if (!Directory.Exists(string_2))
        return new DataSize(0UL);
      string[] files = Directory.GetFiles(string_2, "*.*", SearchOption.AllDirectories);
      ulong sz = 0;
      foreach (string fileName in files)
      {
        FileInfo fileInfo = new FileInfo(fileName);
        sz += (ulong) fileInfo.Length;
      }
      return new DataSize(sz);
    }

    public virtual DataSize vmethod_2()
    {
      return GClass95.smethod_1(this.CurrentGamePath);
    }

    public virtual DataSize GetUpdateSize()
    {
      return new DataSize(0UL);
    }

    public virtual DataSize GetDlcSize()
    {
      return new DataSize(0UL);
    }

    public virtual ulong GetUpdateVersion()
    {
      return 0;
    }

    protected void method_9(bool bool_3)
    {
      string path1 = Path.Combine(GClass88.CachePath, "rpl2elf.exe");
      if (!System.IO.File.Exists(path1))
        System.IO.File.WriteAllBytes(path1, Class123.rpl2elf);
      GClass13 gclass13 = this.gclass30_0.method_15();
      GClass12 gclass12_1 = gclass13.Files.First<GClass12>((Func<GClass12, bool>) (gclass12_0 => gclass12_0.string_1.Contains(".rpx")));
      GClass12 gclass12_2 = gclass13.Files.First<GClass12>((Func<GClass12, bool>) (gclass12_0 =>
      {
        if (gclass12_0.bool_1)
          return gclass12_0.string_1 == "code";
        return false;
      }));
      this.gclass30_0.method_16(this.String_5, true, (bool_3 ? 1 : 0) != 0, (IEnumerable<GClass12>) new GClass12[2]
      {
        gclass12_1,
        gclass12_2
      }, false);
      Process process = new Process();
      string path2 = this.method_11();
      string str = this.method_10();
      process.StartInfo.FileName = path1;
      process.EnableRaisingEvents = true;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\"", (object) path2, (object) str);
      process.StartInfo.WorkingDirectory = Path.GetDirectoryName(path2);
      process.StartInfo.UseShellExecute = false;
      process.Start();
      process.WaitForExit();
    }

    public virtual string GetArguments()
    {
      return string.Format("\"{0}\"", (object) this.GetRom());
    }

    protected string method_10()
    {
      return this.method_11() + ".elf";
    }

    public abstract string GetExecutable();

    public abstract string GetRom();

    protected string method_11()
    {
      string path = Path.Combine(this.CurrentGamePath, "code") + "\\";
      if (!Directory.Exists(path))
        return "";
      List<string> list = ((IEnumerable<string>) Directory.GetFiles(path)).Where<string>((Func<string, bool>) (string_0 => Path.GetExtension(string_0) == ".rpx")).ToList<string>();
      if (list.Count <= 0)
        return "";
      return list[0];
    }

    private static void smethod_2(string string_2)
    {
      foreach (string directory in Directory.GetDirectories(string_2))
      {
        GClass95.smethod_2(directory);
        if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
          Directory.Delete(directory, false);
      }
    }

    public static void smethod_3(string string_2, string string_3, bool bool_3 = true)
    {
      string str = string_3;
      foreach (string file in Directory.GetFiles(string_2, "*.*", SearchOption.AllDirectories))
      {
        if (!(file == str) && (!bool_3 || !file.Contains("meta")))
        {
          try
          {
            GClass6.smethod_6(file);
          }
          catch
          {
          }
        }
      }
      GClass95.smethod_2(string_2);
    }

    public void method_12(bool bool_3 = true)
    {
      GClass95.smethod_3(this.CurrentGamePath, this.GetRom(), bool_3);
    }

    public abstract bool UpdateIsInstalled();

    public abstract bool DlcIsInstalled();

    protected virtual void PrepareRomIfNecessary(bool directDownload)
    {
      if (this.Boolean_2 || this.gclass30_0.System != GEnum3.const_1)
        return;
      this.gclass30_0.method_16(this.String_5, true, directDownload, (IEnumerable<GClass12>) null, false);
    }

    public struct GStruct6
    {
      public string Name { get; set; }

      public string ResUrl { get; set; }
    }
  }
}
