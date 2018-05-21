// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Cemu
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using DokanNet;
using DokanNet.Logging;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using ns0;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;

namespace NusHelper.Emulators
{
  internal class Cemu : GClass95
  {
    private static bool _gPackApplied;
    private string _overriddenGamePath;
    private string _shaderName;
    private byte[] _shaderHash;
    private string _modArgumentString;

    public Cemu(GClass30 title, bool forceUpdate)
      : base(title, nameof (Cemu), "http://cemu.info", forceUpdate, false)
    {
    }

    public string UpdatePath
    {
      get
      {
        return System.IO.Path.Combine(this.String_4, "mlc01", "usr", "title", "00050000", this.gclass30_0.TitleId.High.ToLower());
      }
    }

    public string DlcPath
    {
      get
      {
        return System.IO.Path.Combine(this.UpdatePath, "aoc");
      }
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      Class67.smethod_10();
      if (this.bool_0 && !Cemu._gPackApplied)
      {
        GClass2.smethod_0();
        Cemu._gPackApplied = true;
      }
      base.PrepareRomIfNecessary(directDownload);
      this.PrepareUpdateIfNecessary(directDownload);
      this.PrepareDlcIfNecessary(directDownload);
    }

    public bool RenderUpsideDown { get; set; }

    private void PrepareDlcIfNecessary(bool directDownload)
    {
      if (!(this.gclass30_0 is GClass32))
        return;
      GClass32 gclass300 = (GClass32) this.gclass30_0;
      if (!gclass300.Boolean_2 || GClass3.smethod_3((GClass30) gclass300.Dlc) || gclass300.Dlc.GEnum2_0 != GEnum2.const_2 && !directDownload)
        return;
      try
      {
        GClass31 dlc = gclass300.Dlc;
        string str1 = System.IO.Path.Combine(this.DlcPath, "tmd");
        string str2 = System.IO.Path.Combine(gclass300.Dlc.OutputPath, "title.tmd");
        if (System.IO.Directory.Exists(this.DlcPath) && System.IO.File.Exists(str1) && System.IO.File.ReadAllBytes(str1).smethod_5(System.IO.File.ReadAllBytes(str2)))
          return;
        System.IO.Directory.CreateDirectory(this.DlcPath);
        dlc.method_16(this.DlcPath, false, directDownload, (IEnumerable<GClass12>) null, false);
        System.IO.File.Copy(str2, str1, true);
      }
      catch
      {
      }
    }

    internal override string CurrentGamePath
    {
      get
      {
        if (this._overriddenGamePath == null)
          return base.CurrentGamePath;
        return this._overriddenGamePath;
      }
    }

    public void PlayStream()
    {
      string mount_point = System.IO.Path.Combine(GClass88.CachePath, "streaming", System.IO.Path.GetRandomFileName());
      System.IO.Directory.CreateDirectory(mount_point);
      Class17 fs = new Class17(this.CurrentGamePath, this.gclass30_0);
      Task.Run((Action) (() => fs.Mount(mount_point, DokanOptions.WriteProtection, 1, (ILogger) null)));
      Thread.Sleep(3000);
      this._overriddenGamePath = mount_point;
      this.InternaPrelPlay();
      this.Event_0 += (EventHandler) ((sender, e) =>
      {
        fs.method_1();
        Dokan.RemoveMountPoint(mount_point);
      });
      this.method_8(this.GetArguments());
    }

    private void PrepareUpdateIfNecessary(bool directDownload)
    {
      if (!(this.gclass30_0 is GClass32))
        return;
      GClass32 gclass300 = (GClass32) this.gclass30_0;
      if (!gclass300.Boolean_3 || GClass3.smethod_3((GClass30) gclass300.Updates[0]))
        return;
      bool flag = false;
      try
      {
        if (!System.IO.Directory.Exists(this.UpdatePath))
        {
          System.IO.Directory.CreateDirectory(this.UpdatePath);
        }
        else
        {
          string str = System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml");
          if (System.IO.File.Exists(str))
          {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(str);
            flag = xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value == gclass300.Updates.Last<GClass33>((Func<GClass33, bool>) (x => x.GEnum2_0 == GEnum2.const_2)).Version;
          }
        }
        if (flag)
          return;
        if (!directDownload)
          gclass300.Updates.Last<GClass33>((Func<GClass33, bool>) (x => x.GEnum2_0 == GEnum2.const_2)).method_16(this.UpdatePath, false, false, (IEnumerable<GClass12>) null, false);
        else
          gclass300.Updates.Last<GClass33>().method_16(this.UpdatePath, false, true, (IEnumerable<GClass12>) null, false);
      }
      catch
      {
      }
    }

    private string MetaFileUrl
    {
      get
      {
        return string.Format("{0}meta.txt", (object) this.ShaderBaseUrl);
      }
    }

    private string[] GetShaderMetaData()
    {
      return new GClass78().method_6(this.MetaFileUrl).Split(new string[1]
      {
        Environment.NewLine
      }, StringSplitOptions.RemoveEmptyEntries);
    }

    public string ShaderTransferDir
    {
      get
      {
        return System.IO.Path.Combine(this.String_4, "shaderCache", "transferable");
      }
    }

    private string ShaderFile
    {
      get
      {
        return System.IO.Path.Combine(this.ShaderTransferDir, this.ShaderName + ".bin");
      }
    }

    private string ShaderName
    {
      get
      {
        if (this._shaderName == null)
        {
          string[] shaderMetaData = this.GetShaderMetaData();
          this._shaderName = shaderMetaData[0];
          this._shaderHash = shaderMetaData[1].smethod_6();
        }
        return this._shaderName;
      }
    }

    private byte[] ShaderHash
    {
      get
      {
        if (this._shaderHash == null)
        {
          string[] shaderMetaData = this.GetShaderMetaData();
          this._shaderName = shaderMetaData[0];
          this._shaderHash = shaderMetaData[1].smethod_6();
        }
        return this._shaderHash;
      }
    }

    public bool ShaderCacheIsInstalled()
    {
      if (new ComputerInfo().TotalPhysicalMemory < 6000000000UL || !this.ShaderCacheIsAvailable())
        return true;
      if (!System.IO.File.Exists(this.ShaderFile))
        return false;
      using (SHA256 shA256 = SHA256.Create())
        return shA256.ComputeHash(System.IO.File.ReadAllBytes(this.ShaderFile)).smethod_5(this.ShaderHash);
    }

    private string ShaderBaseUrl
    {
      get
      {
        return string.Format("{0}/res/emulators/Cemu/shaders/{1}/", (object) Class67.String_2, (object) this.gclass30_0.TitleId.High);
      }
    }

    public void InstallShaderCache()
    {
      System.IO.Directory.CreateDirectory(this.ShaderTransferDir);
      GClass27.smethod_7(string.Format("{0}{1}.zip", (object) this.ShaderBaseUrl, (object) this.GetId()), this.ShaderTransferDir);
    }

    public bool ShaderCacheIsAvailable()
    {
      try
      {
        new GClass78().method_2(this.MetaFileUrl);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public override bool SupportsCustomControllerProfiles
    {
      get
      {
        return true;
      }
    }

    public override string FileSaveLocation
    {
      get
      {
        return System.IO.Path.Combine(this.String_4, "mlc01", "usr", "save", this.gclass30_0.TitleId.Low.ToLower(), this.gclass30_0.TitleId.High.ToLower());
      }
    }

    public string GetId()
    {
      try
      {
        byte[] numArray = System.IO.File.ReadAllBytes(this.method_11());
        uint num1 = 873913535;
        for (int index = 0; index < numArray.Length; ++index)
        {
          uint num2 = (uint) numArray[index];
          num1 = (num1 << 3 | num1 >> 29) + num2;
        }
        return num1.ToString("X").ToLower();
      }
      catch
      {
        return (string) null;
      }
    }

    public override List<GClass95.GStruct6> GetControllerProfiles()
    {
      List<GClass95.GStruct6> controllerProfiles = base.GetControllerProfiles();
      string str1 = new GClass78().method_6(string.Format("{0}/res/emulators/Cemu/controllers/meta.txt", (object) Class67.String_2));
      string[] separator = new string[1]
      {
        Environment.NewLine
      };
      int num = 1;
      foreach (string str2 in str1.Split(separator, (StringSplitOptions) num))
        controllerProfiles.Add(new GClass95.GStruct6()
        {
          Name = str2.Split('|')[0],
          ResUrl = string.Format("{0}/res/emulators/Cemu/controllers/", (object) Class67.String_2) + str2.Split('|')[1]
        });
      return controllerProfiles;
    }

    public override void ApplyControllerProfile(GClass95.GStruct6 config)
    {
      string str = System.IO.Path.Combine(this.String_4, "controllerProfiles");
      string string_1 = System.IO.Path.Combine(str, "controller0.txt");
      System.IO.Directory.CreateDirectory(str);
      new GClass78().method_5(config.ResUrl, string_1, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
    }

    public override string GetRom()
    {
      return this.method_11();
    }

    public override string GetArguments()
    {
      if (this._modArgumentString == null)
        return this.GenerateArguments(this.GetRom(), System.IO.Path.Combine(this.String_4, "mlc01"));
      return this._modArgumentString;
    }

    public override string GetExecutable()
    {
      return System.IO.Path.Combine(this.String_4, "cemu.exe");
    }

    public override DataSize GetUpdateSize()
    {
      return GClass95.smethod_1(this.UpdatePath);
    }

    public override DataSize GetDlcSize()
    {
      return GClass95.smethod_1(this.DlcPath);
    }

    public override ulong GetUpdateVersion()
    {
      string str = System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml");
      if (!System.IO.File.Exists(str))
        return 0;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.Load(str);
      return ulong.Parse(xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value);
    }

    private void InstallCommunityShaders()
    {
      try
      {
        string id = this.GetId();
        long num = 0;
        string str = System.IO.Path.Combine(this.ShaderTransferDir, id + ".bin");
        if (System.IO.File.Exists(str))
          num = new System.IO.FileInfo(str).Length;
        if (!(GClass6.smethod_20(string.Format("{0}/shaders/proposal.php", (object) Class67.String_1), new NameValueCollection()
        {
          {
            "id",
            id
          },
          {
            "size",
            num.ToString()
          }
        }) == "LARGER"))
          return;
        GClass27.smethod_7(string.Format("{0}/shaders/vault/{1}.zip", (object) Class67.String_1, (object) id), this.ShaderTransferDir);
      }
      catch
      {
      }
    }

    private string GenerateArguments(string gameRomPath, string mlcPath)
    {
      return string.Format("-g \"{0}\"", (object) gameRomPath) + (this.FullScreen ? " -f" : "") + (this.RenderUpsideDown ? " -ud" : string.Format(" -mlc \"{0}\"", (object) mlcPath) ?? "");
    }

    private string PerformanceFile
    {
      get
      {
        return System.IO.Path.Combine(this.CurrentGamePath, "performance.helper");
      }
    }

    private string PerformanceFileMlc
    {
      get
      {
        return System.IO.Path.Combine(this.CurrentGamePath, "performance.mlc.helper");
      }
    }

    private bool CheckNvidiaDriverVersion()
    {
      try
      {
        foreach (ManagementObject managementObject in new ManagementObjectSearcher("SELECT * FROM Win32_VideoController").Get())
        {
          PropertyData property1 = managementObject.Properties["CurrentBitsPerPixel"];
          PropertyData property2 = managementObject.Properties["Description"];
          PropertyData property3 = managementObject.Properties["DriverVersion"];
          int result;
          if (property1.Value != null && property2.Value != null && (property3.Value != null && property2.Value.ToString().ToLower().Contains("nvidia")) && (int.TryParse(property3.Value.ToString().Replace(".", "").Substring(5), out result) && result < 38792))
          {
            switch (RadMessageBox.Show("USB Helper has detected that your NVIDIA driver is very old. You will encounter several issues when playing games with Cemu. Please update your driver as soon as possible. Should I take you to the download page?", "Old driver", MessageBoxButtons.YesNoCancel))
            {
              case DialogResult.Cancel:
                return false;
              case DialogResult.Yes:
                Process.Start("http://www.nvidia.fr/Download/index.aspx");
                if (RadMessageBox.Show("It is recommended that you also delete your old shader cache, should I do it for you?", "Delete shader cache?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                  GClass6.smethod_5(System.IO.Path.Combine(this.String_4, "shaderCache", "precompiled"));
                return false;
              default:
                continue;
            }
          }
        }
      }
      catch
      {
      }
      return true;
    }

    public override void Play()
    {
      this.InternaPrelPlay();
      base.Play();
    }

    private void InternaPrelPlay()
    {
      if (!this.CheckNvidiaDriverVersion())
        return;
      if (this.EmuConfiguration_0.AutoUpdate && new ComputerInfo().TotalPhysicalMemory >= 6442450944UL)
        this.InstallCommunityShaders();
      this.Event_0 += (EventHandler) ((sender, e) => Class27.smethod_0(this.gclass30_0 as GClass32));
      this._modArgumentString = (string) null;
      GClass15 gclass15 = new GClass15((GClass32) this.gclass30_0);
      if (gclass15.InstalledMods.Count <= 0)
        return;
      Dictionary<string, ulong> counter = (Dictionary<string, ulong>) null;
      Dictionary<string, ulong> counter_mlc = (Dictionary<string, ulong>) null;
      try
      {
        counter = JsonConvert.DeserializeObject<Dictionary<string, ulong>>(System.IO.File.ReadAllText(this.PerformanceFile));
      }
      catch
      {
        counter = new Dictionary<string, ulong>();
      }
      try
      {
        counter_mlc = JsonConvert.DeserializeObject<Dictionary<string, ulong>>(System.IO.File.ReadAllText(this.PerformanceFileMlc));
      }
      catch
      {
        counter_mlc = new Dictionary<string, ulong>();
      }
      gclass15.method_7();
      List<GClass16> gclass16List = gclass15.method_4();
      Class22 mapper = new Class22(this.CurrentGamePath, counter, 134217728L);
      Class22 mapper_mlc = new Class22(System.IO.Path.Combine(this.String_4, "mlc01"), counter_mlc, 134217728L);
      foreach (Alphaleonis.Win32.Filesystem.FileInfo fileInfo in gclass15.List_0)
      {
        if (System.IO.File.Exists(this.String_4 + "\\mlc01\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass15.String_0.Length)))
          mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass15.String_0.Length), fileInfo.FullName);
        else if (System.IO.File.Exists(this.CurrentGamePath + fileInfo.FullName.Substring(gclass15.String_0.Length)))
        {
          mapper.method_1(fileInfo.FullName.Substring(gclass15.String_0.Length), fileInfo.FullName);
        }
        else
        {
          mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass15.String_0.Length), fileInfo.FullName);
          mapper.method_1(fileInfo.FullName.Substring(gclass15.String_0.Length), fileInfo.FullName);
        }
      }
      foreach (GClass16 gclass16 in gclass16List)
      {
        string string_2 = gclass15.String_0 + gclass16.ArchiveRelativePath;
        mapper.method_1(gclass16.GameRelativePath, string_2);
        mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + gclass16.GameRelativePath, string_2);
      }
      Task.Run((Action) (() =>
      {
        foreach (KeyValuePair<string, ulong> keyValuePair in (IEnumerable<KeyValuePair<string, ulong>>) counter.OrderByDescending<KeyValuePair<string, ulong>, ulong>((Func<KeyValuePair<string, ulong>, ulong>) (x => x.Value)))
          mapper.method_2(keyValuePair.Key);
        foreach (KeyValuePair<string, ulong> keyValuePair in (IEnumerable<KeyValuePair<string, ulong>>) counter_mlc.OrderByDescending<KeyValuePair<string, ulong>, ulong>((Func<KeyValuePair<string, ulong>, ulong>) (x => x.Value)))
          mapper_mlc.method_2(keyValuePair.Key);
        mapper.method_0();
        mapper_mlc.method_0();
      }));
      System.IO.Directory.CreateDirectory(System.IO.Path.Combine(GClass88.CachePath, "mods", "mount"));
      foreach (System.IO.DirectoryInfo enumerateDirectory in new System.IO.DirectoryInfo(System.IO.Path.Combine(GClass88.CachePath, "mods", "mount")).EnumerateDirectories())
      {
        try
        {
          try
          {
            Dokan.RemoveMountPoint(enumerateDirectory.FullName);
          }
          catch
          {
          }
          enumerateDirectory.Delete(true);
        }
        catch
        {
        }
      }
      string mount_point = System.IO.Path.Combine(GClass88.CachePath, "mods", "mount", System.IO.Path.GetRandomFileName());
      string mount_point_mlc = System.IO.Path.Combine(GClass88.CachePath, "mods", "mount", System.IO.Path.GetRandomFileName());
      GClass6.smethod_5(mount_point);
      System.IO.Directory.CreateDirectory(mount_point);
      System.IO.Directory.CreateDirectory(mount_point_mlc);
      this.Event_0 += (EventHandler) ((sender, e) =>
      {
        mapper.method_4();
        mapper_mlc.method_4();
        System.IO.File.WriteAllText(this.PerformanceFile, JsonConvert.SerializeObject((object) counter));
        string performanceFileMlc = this.PerformanceFileMlc;
        IEnumerable<KeyValuePair<string, ulong>> source = counter_mlc.Where<KeyValuePair<string, ulong>>((Func<KeyValuePair<string, ulong>, bool>) (x => x.Key.Contains("\\USR\\TITLE\\00050000\\")));
        Func<KeyValuePair<string, ulong>, string> func = (Func<KeyValuePair<string, ulong>, string>) (x => x.Key);
        Func<KeyValuePair<string, ulong>, string> keySelector;
        string contents = JsonConvert.SerializeObject((object) source.ToDictionary<KeyValuePair<string, ulong>, string, ulong>(keySelector, (Func<KeyValuePair<string, ulong>, ulong>) (x => x.Value)));
        System.IO.File.WriteAllText(performanceFileMlc, contents);
        Dokan.RemoveMountPoint(mount_point);
        Dokan.RemoveMountPoint(mount_point_mlc);
        GClass6.smethod_5(mount_point);
        GClass6.smethod_5(mount_point_mlc);
      });
      Task.Run((Action) (() => mapper.Mount(mount_point, DokanOptions.WriteProtection, 10, (ILogger) null)));
      Task.Run((Action) (() => mapper_mlc.Mount(mount_point_mlc, DokanOptions.FixedDrive, 10, (ILogger) null)));
      Thread.Sleep(2000);
      this._modArgumentString = this.GenerateArguments(((IEnumerable<string>) System.IO.Directory.GetFiles(System.IO.Path.Combine(mount_point, "code") + "\\")).Where<string>((Func<string, bool>) (x => System.IO.Path.GetExtension(x) == ".rpx")).ToList<string>()[0], mount_point_mlc);
    }

    public override void DeleteUpdate()
    {
      base.DeleteUpdate();
      try
      {
        GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "code"));
      }
      catch
      {
      }
      try
      {
        GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "meta"));
      }
      catch
      {
      }
      try
      {
        GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "content"));
      }
      catch
      {
      }
    }

    public override void DeleteDlc()
    {
      try
      {
        GClass6.smethod_5(this.DlcPath);
      }
      catch
      {
      }
    }

    public override bool UpdateIsInstalled()
    {
      return System.IO.File.Exists(System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml"));
    }

    public override bool DlcIsInstalled()
    {
      return System.IO.Directory.Exists(this.DlcPath);
    }
  }
}
