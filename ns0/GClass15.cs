// Decompiled with JetBrains decompiler
// Type: ns0.GClass15
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using DokanNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ns0
{
  public class GClass15
  {
    private readonly GClass32 gclass32_0;
    private List<GClass14> list_1;

    public GClass15(GClass32 gclass32_1)
    {
      this.gclass32_0 = gclass32_1;
      Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.String_2);
      Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.String_3);
      try
      {
        this.InstalledMods = JsonConvert.DeserializeObject<List<string>>(Alphaleonis.Win32.Filesystem.File.ReadAllText(this.String_1));
      }
      catch
      {
        this.InstalledMods = new List<string>();
      }
    }

    public List<string> InstalledMods { get; }

    public string String_0
    {
      get
      {
        return Alphaleonis.Win32.Filesystem.Path.Combine(this.String_2, "virtual");
      }
    }

    public List<Alphaleonis.Win32.Filesystem.FileInfo> List_0
    {
      get
      {
        return ((IEnumerable<Alphaleonis.Win32.Filesystem.FileInfo>) new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.String_0).GetFiles("*", SearchOption.AllDirectories)).ToList<Alphaleonis.Win32.Filesystem.FileInfo>();
      }
    }

    public List<string> method_0(string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass15.Class13 class13 = new GClass15.Class13();
      string_0 = string_0.ToUpper();
      // ISSUE: reference to a compiler-generated field
      class13.gclass14_0 = this.method_2(string_0);
      List<string> stringList = new List<string>();
      // ISSUE: reference to a compiler-generated field
      if (this.method_3(string_0) || class13.gclass14_0 == null)
        return stringList;
      foreach (string installedMod in this.InstalledMods)
      {
        GClass14 gclass14 = this.method_2(installedMod);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        if (gclass14 != null && ((IEnumerable<string>) gclass14.Files).Any<string>(class13.func_0 ?? (class13.func_0 = new Func<string, bool>(class13.method_0))))
        {
          int num = (int) RadMessageBox.Show(string.Format("You cannot add the mod {0} since it conflicts with {1}.", (object) string_0, (object) installedMod));
          return stringList;
        }
      }
      // ISSUE: reference to a compiler-generated field
      foreach (string recommendedMod in class13.gclass14_0.RecommendedMods)
      {
        if (this.method_2(recommendedMod) != null && !this.method_3(recommendedMod) && RadMessageBox.Show(string.Format("It is recommended that you also add the mod {0}. Should I add it for you?", (object) recommendedMod), "Add mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          stringList.Add(recommendedMod);
          stringList.AddRange((IEnumerable<string>) this.method_0(recommendedMod));
        }
      }
      // ISSUE: reference to a compiler-generated field
      foreach (string requiredMod in class13.gclass14_0.RequiredMods)
      {
        if (this.method_2(requiredMod) != null && !this.method_3(requiredMod))
        {
          int num = (int) RadMessageBox.Show(string.Format("The mod additional mod {0} is required. It will be enabled automatically.", (object) requiredMod));
          stringList.Add(requiredMod);
          stringList.AddRange((IEnumerable<string>) this.method_0(requiredMod));
        }
      }
      stringList.Add(string_0);
      this.method_8(string_0);
      this.method_6();
      return stringList;
    }

    public List<GClass14> method_1()
    {
      try
      {
        this.list_1 = JsonConvert.DeserializeObject<List<GClass14>>(GClass6.smethod_20("https://cloud.wiiuusbhelper.com/mods/list_mods.php", new NameValueCollection()
        {
          {
            "titleid",
            this.gclass32_0.TitleId.IdRaw
          }
        }));
        return this.list_1;
      }
      catch (Exception ex)
      {
        return new List<GClass14>();
      }
    }

    public GClass14 method_2(string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass15.Class14 class14 = new GClass15.Class14();
      // ISSUE: reference to a compiler-generated field
      class14.string_0 = string_0;
      if (this.list_1 == null)
        this.list_1 = this.method_1();
      try
      {
        // ISSUE: reference to a compiler-generated method
        return this.list_1.First<GClass14>(new Func<GClass14, bool>(class14.method_0));
      }
      catch
      {
        return (GClass14) null;
      }
    }

    public bool method_3(string string_0)
    {
      return this.InstalledMods.Contains(string_0.ToUpper());
    }

    public List<GClass16> method_4()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass15.Class15 class15 = new GClass15.Class15();
      // ISSUE: reference to a compiler-generated field
      class15.gclass15_0 = this;
      // ISSUE: reference to a compiler-generated field
      class15.list_0 = new List<GClass16>();
      int num;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("USB Helper is preparing your mods...", new Action(class15.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show(exception_0.Message)));
      // ISSUE: reference to a compiler-generated field
      return class15.list_0;
    }

    public bool method_5(string string_0)
    {
      string_0 = string_0.ToUpper();
      if (!this.method_3(string_0))
        return true;
      foreach (string installedMod in this.InstalledMods)
      {
        GClass14 gclass14 = this.method_2(installedMod);
        if (gclass14 != null && ((IEnumerable<string>) gclass14.RequiredMods).Contains<string>(string_0))
        {
          int num = (int) RadMessageBox.Show(string.Format("The mod {0} is dependant on this mod. Please disable it first.", (object) installedMod));
          return false;
        }
      }
      this.InstalledMods.Remove(string_0);
      this.method_6();
      return true;
    }

    public void method_6()
    {
      Alphaleonis.Win32.Filesystem.File.WriteAllText(this.String_1, JsonConvert.SerializeObject((object) this.InstalledMods));
    }

    public void method_7()
    {
      try
      {
        int driverVersion = Dokan.DriverVersion;
      }
      catch (Exception ex1)
      {
        if (ex1.Message.Contains("dokan1.dll"))
        {
          int num1 = (int) RadMessageBox.Show("You must install an additional component to use mods. Press 'Ok' to continue.");
          Class67.smethod_7("dokan.exe");
          try
          {
            int driverVersion = Dokan.DriverVersion;
          }
          catch (Exception ex2)
          {
            if (!ex2.Message.Contains("dokan1.dll"))
              return;
            int num2 = (int) RadMessageBox.Show("USB Helper was not able to detect the required component. Try rebooting your computer.");
            throw;
          }
        }
        else
          throw;
      }
    }

    private string String_1
    {
      get
      {
        return Alphaleonis.Win32.Filesystem.Path.Combine(this.String_2, "installed.json");
      }
    }

    private string String_2
    {
      get
      {
        return Alphaleonis.Win32.Filesystem.Path.Combine(GClass88.CachePath, "mods", (string) this.gclass32_0.TitleId);
      }
    }

    private string String_3
    {
      get
      {
        return Alphaleonis.Win32.Filesystem.Path.Combine(this.String_2, "archives");
      }
    }

    private void method_8(string string_0)
    {
      if (this.InstalledMods.Contains(string_0))
        return;
      this.InstalledMods.Add(string_0);
    }

    private bool method_9(string string_0)
    {
      return Alphaleonis.Win32.Filesystem.File.Exists(this.method_12(string_0));
    }

    private void method_10(GClass14 gclass14_0)
    {
      GClass27.smethod_9(gclass14_0.DownloadLink, this.method_12(gclass14_0.Name), string.Format("Downloading {0}", (object) gclass14_0.Name));
    }

    private List<GClass16> method_11(string string_0)
    {
      GClass14 gclass14_0 = this.method_2(string_0);
      if (!this.method_9(string_0))
        this.method_10(gclass14_0);
      using (MD5 md5 = MD5.Create())
      {
        if (!md5.ComputeHash(Alphaleonis.Win32.Filesystem.File.ReadAllBytes(this.method_12(string_0))).smethod_5(gclass14_0.Md5.smethod_6()))
          this.method_10(gclass14_0);
      }
      GClass6.smethod_9(Alphaleonis.Win32.Filesystem.File.ReadAllBytes(this.method_12(string_0)), this.String_0);
      using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(this.method_12(string_0)))
      {
        using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream, ZipArchiveMode.Read))
        {
          try
          {
            return JsonConvert.DeserializeObject<List<GClass16>>(zipArchive.Entries.First<ZipArchiveEntry>((Func<ZipArchiveEntry, bool>) (zipArchiveEntry_0 => zipArchiveEntry_0.Name == "usbhelper.mappings")).smethod_7());
          }
          catch
          {
            return new List<GClass16>();
          }
        }
      }
    }

    private string method_12(string string_0)
    {
      return Alphaleonis.Win32.Filesystem.Path.Combine(this.String_3, string_0.ToUpper()) + ".mod";
    }
  }
}
