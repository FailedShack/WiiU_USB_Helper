// Decompiled with JetBrains decompiler
// Type: ns0.GClass94
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ns0
{
  public class GClass94 : GClass91
  {
    private string[] string_3;

    public GClass94(GClass32 gclass32_1)
      : base(gclass32_1)
    {
      try
      {
        this.method_6("twodiscs");
        this.RomCount = 2;
      }
      catch
      {
      }
      this.CompressIso = this.method_0("notcompress", true);
      if (gclass32_1.Platform == Platform.Wii_Custom)
      {
        this.UseGamepad = this.method_0("gamepad", false);
        if (this.UseGamepad)
        {
          this.VerticalWiimote = this.method_0("vertical", false);
          this.HorizontalWiimote = this.method_0("horizontal", false);
        }
        this.PatchWifi = this.method_0("online", false);
        try
        {
          string[] strArray = this.method_6("patch").Split(new string[1]
          {
            Environment.NewLine
          }, StringSplitOptions.RemoveEmptyEntries);
          this.PatchGame = new TitleId(strArray[0]);
          this.PatchSize = strArray[1];
        }
        catch
        {
        }
      }
      this.string_3 = new string[this.RomCount];
    }

    public bool CompressIso { get; set; } = true;

    public bool PatchWifi { get; set; }

    public bool Force43 { get; set; }

    public override string[] String_3
    {
      get
      {
        return new string[4]
        {
          "Fetching the content",
          "Shrinking the ISO",
          "Injecting the game",
          "Packing the game"
        };
      }
    }

    public TitleId PatchGame { get; }

    public string PatchSize { get; }

    public override string String_1
    {
      get
      {
        return "ISO";
      }
    }

    public override string String_2
    {
      get
      {
        return this.ToInject.Platform != Platform.Gamecube ? "iso (*.iso)|*.iso|ciso (*.ciso)|*.ciso|wbfs (*.wbfs)|*.wbfs" : "iso (*.iso)|*.iso|gcm (*.gcm)|*.gcm";
      }
    }

    public bool method_14()
    {
      if (this.PatchGame == null)
        throw new Exception("This game is not patchable!");
      GClass30 title = (GClass30) GClass28.dictionary_0[this.PatchGame];
      if (RadMessageBox.Show(string.Format("This title is a modified version of {0}.\nUSB Helper can build an iso for you by automatically patching the game from the eShop.\nThis way you do not have to provide the iso.\nProceed? (About {1}MB will of data will be downloaded)", (object) title.Name, (object) this.PatchSize), "Proceed?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass94.Class79 class79 = new GClass94.Class79();
      if (title.GEnum2_0 != GEnum2.const_2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass94.Class80 class80 = new GClass94.Class80();
        GClass80 gclass80 = new GClass80((WebProxy) null, true, true);
        // ISSUE: reference to a compiler-generated field
        class80.frmWait_0 = new FrmWait("USB Helper is downloading the base game", true);
        // ISSUE: reference to a compiler-generated method
        gclass80.Event_6 += new EventHandler<GEventArgs0>(class80.method_0);
        // ISSUE: reference to a compiler-generated method
        gclass80.Event_5 += new EventHandler<GClass81>(class80.method_1);
        gclass80.method_1(((IEnumerable<GClass30>) new GClass30[1]
        {
          title
        }).ToList<GClass30>(), 100, 10000);
        // ISSUE: reference to a compiler-generated field
        int num = (int) class80.frmWait_0.ShowDialog();
      }
      Dolphin dolphin = new Dolphin(title, false);
      dolphin.method_5();
      string rom = dolphin.GetRom();
      // ISSUE: reference to a compiler-generated field
      class79.string_0 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(rom).Parent.FullName;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class79.string_1 = Alphaleonis.Win32.Filesystem.Path.Combine(class79.string_0, "workdir.tmp");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class79.string_2 = Alphaleonis.Win32.Filesystem.Path.Combine(class79.string_0, "patch.uhd");
      dolphin.method_12(true);
      int num1;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait1 = new FrmWait("USB Helper is preparing the game...", new Action(class79.method_0), (Action<Exception>) (exception_0 => num1 = (int) RadMessageBox.Show(exception_0.ToString())));
      // ISSUE: reference to a compiler-generated field
      class79.frmWait_0 = new FrmWait("USB Helper is downloading the differential data", true);
      WebClient webClient = new WebClient();
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(class79.method_1);
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(class79.method_2);
      // ISSUE: reference to a compiler-generated field
      webClient.DownloadFileAsync(new Uri(string.Format("{0}/res/Wii/template/{1}/patch.uhd", (object) Class67.String_2, (object) this.ToInject.ProductId)), class79.string_2);
      // ISSUE: reference to a compiler-generated field
      int num2 = (int) class79.frmWait_0.ShowDialog();
      int num3;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait2 = new FrmWait("USB HELPER is patching the game...", new Action(class79.method_3), (Action<Exception>) (exception_0 => num3 = (int) RadMessageBox.Show(exception_0.ToString())));
      // ISSUE: reference to a compiler-generated field
      GClass6.smethod_6(class79.string_2);
      // ISSUE: reference to a compiler-generated field
      GClass6.smethod_5(class79.string_1);
      // ISSUE: reference to a compiler-generated field
      if (!this.vmethod_0(new Alphaleonis.Win32.Filesystem.DirectoryInfo(Alphaleonis.Win32.Filesystem.Path.Combine(class79.string_0, "new-image")).GetFiles()[0].FullName))
        throw new Exception("The output iso was not recognized!");
      int num4 = (int) new frmInjectionAnimation((GClass91) this).ShowDialog();
      dolphin.method_12(true);
      // ISSUE: reference to a compiler-generated field
      GClass6.smethod_5(Alphaleonis.Win32.Filesystem.Path.Combine(class79.string_0, "rawFiles"));
      return true;
    }

    private void method_15(string string_5, string string_6)
    {
      GClass91.smethod_1(this.method_4("GCM.exe"), new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_5).Parent.FullName, string.Format("-sh \"{0}\" \"{1}\"", (object) string_5, (object) string_6));
    }

    private static string smethod_5(string string_5)
    {
      byte[] numArray = new byte[6];
      using (FileStream fileStream = System.IO.File.OpenRead(string_5))
      {
        if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".ciso")
          fileStream.Seek(32768L, SeekOrigin.Begin);
        else if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".wbfs")
          fileStream.Seek(512L, SeekOrigin.Begin);
        fileStream.Read(numArray, 0, 6);
        return Encoding.ASCII.GetString(numArray);
      }
    }

    private static int smethod_6(string string_5)
    {
      byte[] numArray = new byte[1];
      using (BinaryReader binaryReader = new BinaryReader((Stream) Alphaleonis.Win32.Filesystem.File.OpenRead(string_5)))
      {
        if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".ciso")
          binaryReader.BaseStream.Seek(32768L, SeekOrigin.Begin);
        else if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".wbfs")
          binaryReader.BaseStream.Seek(512L, SeekOrigin.Begin);
        binaryReader.BaseStream.Seek(6L, SeekOrigin.Current);
        return (int) binaryReader.ReadByte();
      }
    }

    private int method_16(string string_5)
    {
      try
      {
        if (this.List_0.Contains(GClass94.smethod_5(string_5)))
          return GClass94.smethod_6(string_5);
        return -1;
      }
      catch
      {
        return -1;
      }
    }

    private static void smethod_7(System.IO.DriveInfo driveInfo_0)
    {
      string path = Alphaleonis.Win32.Filesystem.Path.Combine(driveInfo_0.Name, "apps", "nintendont", "boot.dol");
      WebClient webClient = new WebClient();
      webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
      try
      {
        bool flag;
        if (!Alphaleonis.Win32.Filesystem.File.Exists(path))
        {
          flag = true;
        }
        else
        {
          byte[] byte_0 = (byte[]) null;
          byte[] numArray = Alphaleonis.Win32.Filesystem.File.ReadAllBytes(path);
          byte[] bytes = Encoding.ASCII.GetBytes("blob " + numArray.Length.ToString() + "\0");
          byte[] buffer = new byte[numArray.Length + bytes.Length];
          Buffer.BlockCopy((Array) bytes, 0, (Array) buffer, 0, bytes.Length);
          Buffer.BlockCopy((Array) numArray, 0, (Array) buffer, bytes.Length, numArray.Length);
          using (SHA1 shA1 = SHA1.Create())
            byte_0 = shA1.ComputeHash(buffer);
          byte[] byte_1 = ((IEnumerable<GClass21>) JsonConvert.DeserializeObject<GClass21[]>(webClient.DownloadString("https://api.github.com/repos/FIX94/Nintendont/contents//loader"))).First<GClass21>((Func<GClass21, bool>) (gclass21_0 => gclass21_0.name == "loader.dol")).sha.smethod_6();
          flag = !GClass27.smethod_1(byte_0, byte_1);
        }
        if (!flag || RadMessageBox.Show("USB Helper was unable to detect Nintendont, or a new version is available. It is required to be able to play GC games. Would you like USB Helper to install it for you?", "Nintendont", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        GClass94.smethod_9(driveInfo_0);
      }
      catch
      {
      }
    }

    public static void smethod_8(System.IO.DriveInfo driveInfo_0)
    {
      Alphaleonis.Win32.Filesystem.Path.Combine(driveInfo_0.Name, "apps", "nintendont", "boot.dol");
      string path = Alphaleonis.Win32.Filesystem.Path.Combine(driveInfo_0.Name, "nincfg.bin");
      GClass94.smethod_7(driveInfo_0);
      if (Alphaleonis.Win32.Filesystem.File.Exists(path) || RadMessageBox.Show("USB Helper was unable to detect the configuration file on your SD card. It is required to be able to play GC games. Would you like USB Helper to install it for you?", "Nintendont", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      GClass94.smethod_10(driveInfo_0);
    }

    public static void smethod_9(System.IO.DriveInfo driveInfo_0)
    {
      Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(Alphaleonis.Win32.Filesystem.Path.Combine(driveInfo_0.Name, "apps", "nintendont"));
      GClass27.smethod_9("https://github.com/FIX94/Nintendont/blob/master/loader/loader.dol?raw=true", Alphaleonis.Win32.Filesystem.Path.Combine(driveInfo_0.Name, "apps", "nintendont", "boot.dol"), (string) null);
    }

    public static void smethod_10(System.IO.DriveInfo driveInfo_0)
    {
      GClass27.smethod_9(string.Format("{0}/res/nintendont/nincfg.bin", (object) Class67.String_2), driveInfo_0.Name + "nincfg.bin", (string) null);
    }

    public override void vmethod_2()
    {
      base.vmethod_2();
      Task.Run((Action) (() =>
      {
        try
        {
          string string_0_1 = this.Force43 ? string.Format("{0}/res/nintendont/autoboot43.dol", (object) Class67.String_2) : "https://cdn.wiiuusbhelper.com/res/nintendont/autoboot.dol";
          this.method_11(0);
          string string_0_2 = this.method_4("rawFiles\\content\\hif_000000.nfs");
          string str1 = this.method_4("rawFiles\\content\\game.iso");
          string path1 = this.method_4("new-image\\");
          string sourceFileName1 = this.method_4(Alphaleonis.Win32.Filesystem.Path.Combine(path1, "PunEmu [CEMU69].iso"));
          string sourceFileName2 = this.method_4("nfs2iso2nfs.exe");
          string str2 = this.method_4("rawFiles\\content\\nfs2iso2nfs.exe");
          string path2 = this.method_4("rawFiles\\content\\hif_000000.nfs");
          string sourceFileName3 = this.method_4("workdir.tmp2\\ticket.bin");
          string str3 = this.method_4("rawFiles\\code\\rvlt.tik");
          string sourceFileName4 = this.method_4("workdir.tmp2\\tmd.bin");
          string str4 = this.method_4("rawFiles\\code\\rvlt.tmd");
          string str5 = this.method_4("production_output");
          string str6 = this.method_4("output");
          string string_0_3 = this.method_4("workdir.tmp\\");
          string string_1 = this.method_4(Alphaleonis.Win32.Filesystem.Path.Combine(string_0_3, "sys", "main.dol"));
          string[] strArray = new string[2]
          {
            this.method_4("workdir.tmp\\files\\game.iso"),
            this.method_4("workdir.tmp\\files\\disc2.iso")
          };
          GClass6.smethod_8("https://cdn.wiiuusbhelper.com/res/nintendont/vc-template.zip", this.WorkPath);
          GClass6.smethod_5(this.method_4("workdir.tmp2"));
          GClass6.smethod_5(str5);
          GClass6.smethod_5(str6);
          GClass6.smethod_6(str4);
          GClass6.smethod_6(str3);
          GClass6.smethod_6(string_0_2);
          GClass6.smethod_6(str1);
          GClass6.smethod_6(str2);
          Task task = this.method_7();
          this.method_11(1);
          if (this.string_3 != null && this.ToInject.Platform == Platform.Gamecube)
          {
            new GClass78().method_5(string_0_1, string_1, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
            for (int index = 0; index < this.string_3.Length; ++index)
            {
              if (this.CompressIso)
                this.method_15(this.string_3[index], strArray[index]);
              else
                Alphaleonis.Win32.Filesystem.File.Copy(this.string_3[index], strArray[index]);
            }
            if (!Alphaleonis.Win32.Filesystem.File.Exists(strArray[0]))
              throw new Exception("The iso was not shrinked sucessfully. Cannot continue.");
          }
          if (this.ToInject.Platform == Platform.Wii_Custom)
          {
            if (this.PatchWifi)
            {
              if (((IEnumerable<string>) new string[3]
              {
                "RMCP01",
                "RMCE01",
                "RMCJ01"
              }).Contains<string>(this.ToInject.ProductId))
              {
                Alphaleonis.Win32.Filesystem.File.Copy(this.string_3[0], this.method_4(Alphaleonis.Win32.Filesystem.Path.GetFileName(this.string_3[0])));
                using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(string.Format("{0}/res/Wii/mk_patcher.zip", (object) Class67.String_2))))
                {
                  using (ZipArchive zipArchive_0 = new ZipArchive((Stream) memoryStream))
                    zipArchive_0.smethod_0(this.WorkPath, true);
                }
                GClass91.smethod_0("patch-wiimmfi.bat", this.WorkPath);
                GClass6.smethod_6(this.method_4(Alphaleonis.Win32.Filesystem.Path.GetFileName(this.string_3[0])));
                sourceFileName1 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.method_4("wiimmfi-images/")).GetFiles()[0].FullName;
              }
              else if (((IEnumerable<string>) new string[3]
              {
                "RSBP01",
                "RSBE01",
                "RSBJ01"
              }).Contains<string>(this.ToInject.ProductId))
              {
                GClass91.smethod_1(this.method_4("PackOnline.bat"), this.WorkPath, string.Format("\"{0}\"", (object) this.string_3[0]));
                sourceFileName1 = Alphaleonis.Win32.Filesystem.Path.Combine(path1, "patched.iso");
              }
              else
              {
                GClass6.smethod_5(string_0_3);
                GClass91.smethod_1(this.method_4("Extract.bat"), this.WorkPath, string.Format("\"{0}\"", (object) this.string_3[0]));
                GClass91.smethod_0(this.method_4("Pack.bat"), this.WorkPath);
                GClass6.smethod_5(string_0_3);
                string fullName = new Alphaleonis.Win32.Filesystem.DirectoryInfo(path1).GetFiles()[0].FullName;
                GClass91.smethod_1(this.method_4("PackOnline.bat"), this.WorkPath, string.Format("\"{0}\"", (object) fullName));
                GClass6.smethod_6(fullName);
                sourceFileName1 = Alphaleonis.Win32.Filesystem.Path.Combine(path1, "patched.iso");
              }
            }
            else
            {
              GClass6.smethod_5(string_0_3);
              GClass91.smethod_1(this.method_4("Extract.bat"), this.WorkPath, string.Format("\"{0}\"", (object) this.string_3[0]));
              GClass91.smethod_0(this.method_4("Pack.bat"), this.WorkPath);
              GClass6.smethod_5(string_0_3);
              string fullName = new Alphaleonis.Win32.Filesystem.DirectoryInfo(path1).GetFiles()[0].FullName;
              Alphaleonis.Win32.Filesystem.File.Move(fullName, Alphaleonis.Win32.Filesystem.Path.Combine(Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(fullName), "game.iso"));
              sourceFileName1 = Alphaleonis.Win32.Filesystem.Path.Combine(Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(fullName), "game.iso");
            }
          }
          else if (this.ToInject.Platform == Platform.Gamecube)
          {
            GClass91.smethod_0(this.method_4("Pack.bat"), this.WorkPath);
            GClass6.smethod_5(string_0_3);
            sourceFileName1 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(path1).GetFiles()[0].FullName;
          }
          this.method_11(2);
          GClass91.smethod_1(this.method_4("GetTik.bat"), this.WorkPath, string.Format("\"{0}\"", (object) sourceFileName1));
          GClass6.smethod_6(strArray[0]);
          GClass6.smethod_6(strArray[1]);
          Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName3, str3);
          Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName4, str4);
          Alphaleonis.Win32.Filesystem.File.Move(sourceFileName1, str1);
          Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName2, str2);
          if (this.ToInject.Platform == Platform.Gamecube)
            GClass91.smethod_1(str2, Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(str2), "-homebrew -passthrough");
          else if (this.ToInject.Platform == Platform.Wii_Custom)
            GClass91.smethod_1(str2, Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(str2), "-passthrough");
          if (!Alphaleonis.Win32.Filesystem.File.Exists(path2))
            throw new Exception("Injection did not complete sucessfully. Cannot continue.");
          GClass6.smethod_6(str1);
          GClass6.smethod_6(str2);
          this.method_11(3);
          task.Wait();
          this.vmethod_3();
          if (this.Production)
            this.method_3(str6, str5);
          GClass6.smethod_5(this.method_4("workdir.tmp2"));
          GClass6.smethod_5(this.method_4("tmp"));
          GClass6.smethod_6(string_0_2);
          this.method_8();
          this.method_9();
        }
        catch (Exception ex)
        {
          this.method_10(ex);
        }
      }));
    }

    public override bool vmethod_0(string string_5)
    {
      int index = this.method_16(string_5);
      if (index > -1)
      {
        this.string_3[index] = string_5;
        string[] string3 = this.string_3;
        Func<string, bool> func = (Func<string, bool>) (string_0 => Alphaleonis.Win32.Filesystem.File.Exists(string_0));
        Func<string, bool> predicate;
        if (((IEnumerable<string>) string3).All<string>(predicate))
          return true;
      }
      else
      {
        int num = (int) RadMessageBox.Show("USB Helper was unable to recognize this ISO. Make sure you have provided an ISO of the same region as the title you are trying to inject");
      }
      return false;
    }

    public override int vmethod_1()
    {
      return ((IEnumerable<string>) this.string_3).Count<string>((Func<string, bool>) (string_0 => Alphaleonis.Win32.Filesystem.File.Exists(string_0)));
    }

    protected override void vmethod_3()
    {
      this.method_2(GClass28.dictionary_0[new TitleId("00050000101B1100")]);
      GClass91.smethod_1(GClass91.String_0, this.WorkPath, string.Format("-jar \"{0}\" -in rawFiles", (object) "NUSPacker.jar"));
    }
  }
}
