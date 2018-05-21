// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Citra
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using CommonCompressors;
using Microsoft.VisualBasic.FileIO;
using ns0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;

namespace NusHelper.Emulators
{
  internal class Citra : GClass95
  {
    public Citra(GClass30 title, bool forceUpdate)
      : base(title, nameof (Citra), "https://citra-emu.org/", forceUpdate, false)
    {
    }

    public static Citra.NCCH_TYPE GetNcchType(string filePath)
    {
      try
      {
        using (FileStream fileStream = System.IO.File.OpenRead(filePath))
        {
          fileStream.Seek(256L, SeekOrigin.Begin);
          byte[] numArray = new byte[4];
          fileStream.Read(numArray, 0, 4);
          if (!numArray.smethod_5(new byte[4]
          {
            (byte) 78,
            (byte) 67,
            (byte) 67,
            (byte) 72
          }))
            return Citra.NCCH_TYPE.NONE;
          fileStream.Seek(397L, SeekOrigin.Begin);
          int num = fileStream.ReadByte();
          bool flag1 = (uint) (num & 2) > 0U;
          bool flag2;
          if ((flag2 = (uint) (num & 1) > 0U) & flag1)
            return Citra.NCCH_TYPE.const_1;
          return flag2 ? Citra.NCCH_TYPE.const_0 : Citra.NCCH_TYPE.NONE;
        }
      }
      catch
      {
        return Citra.NCCH_TYPE.NONE;
      }
    }

    public override void Play()
    {
      Class67.smethod_10();
      this.DownloadSharedFont();
      foreach (GClass32 archive in GClass28.list_0)
        this.DownloadArchive(archive);
      this.PrepareRomIfNecessary(false);
      this.method_8(this.GetArguments());
    }

    private void DownloadArchive(GClass32 archive)
    {
      string str = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof (Citra), "nand", "00000000000000000000000000000000", "title", archive.TitleId.Low.ToLower(), archive.TitleId.High.ToLower(), "content");
      Directory.CreateDirectory(str);
      string destinationFile = Path.Combine(str, "00000000.app.romfs");
      if (System.IO.File.Exists(destinationFile))
        return;
      GClass80 gclass80 = new GClass80((WebProxy) null, true, true);
      FrmWait frmWait = new FrmWait("Downloading system archive from: NUS...", true);
      gclass80.Event_5 += (EventHandler<GClass81>) ((_param1, _param2) =>
      {
        string temp_dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        GClass6.smethod_5(temp_dir);
        Directory.CreateDirectory(temp_dir);
        Path.Combine(temp_dir, "game.cia");
        archive.method_5(temp_dir, "game");
        GClass27.smethod_11(temp_dir);
        ProcessStartInfo processStartInfo1 = new ProcessStartInfo()
        {
          FileName = Path.Combine(temp_dir, "PART1"),
          WorkingDirectory = temp_dir
        };
        Process process1 = new Process();
        process1.StartInfo = processStartInfo1;
        process1.EnableRaisingEvents = true;
        process1.Exited += (EventHandler) ((sender1, e1) =>
        {
          try
          {
            IEnumerable<FileInfo> potential_files = new DirectoryInfo(temp_dir).EnumerateFiles("contents.*");
            if (potential_files.Count<FileInfo>() == 0)
              throw new Exception("An error occured while preparing the system archive!");
            FileInfo fileInfo = potential_files.First<FileInfo>((Func<FileInfo, bool>) (x => x.Length == potential_files.Max<FileInfo>((Func<FileInfo, long>) (y => y.Length))));
            ProcessStartInfo processStartInfo2 = new ProcessStartInfo()
            {
              FileName = Path.Combine(temp_dir, "3dstool.exe"),
              WorkingDirectory = temp_dir,
              Arguments = string.Format("-xvtf cfa {0} --romfs 00000000.app.romfs --romfs-auto-key", (object) fileInfo)
            };
            Process process2 = new Process();
            process2.StartInfo = processStartInfo2;
            process2.Exited += (EventHandler) ((sender2, e2) =>
            {
              string path = Path.Combine(temp_dir, "00000000.app.romfs");
              using (FileStream fileStream1 = System.IO.File.Create(destinationFile))
              {
                using (FileStream fileStream2 = System.IO.File.Open(path, FileMode.Open))
                {
                  fileStream2.Seek(4096L, SeekOrigin.Begin);
                  for (int index = 0; (long) index < fileStream2.Length - 4096L; ++index)
                  {
                    int num = fileStream2.ReadByte();
                    fileStream1.WriteByte((byte) num);
                  }
                }
              }
              GClass6.smethod_5(temp_dir);
              frmWait.method_0();
            });
            process2.EnableRaisingEvents = true;
            process2.Start();
          }
          catch
          {
          }
        });
        process1.Start();
      });
      gclass80.Event_6 += (EventHandler<GEventArgs0>) ((sender, e) => frmWait.method_2(e.GameProgress));
      gclass80.method_1(((IEnumerable<GClass30>) new GClass30[1]
      {
        (GClass30) archive
      }).ToList<GClass30>(), 100, 10000);
      int num1 = (int) frmWait.ShowDialog();
    }

    private void DownloadSharedFont()
    {
      string sharedFontDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof (Citra), "sysdata", "shared_font.bin");
      if (System.IO.File.Exists(sharedFontDestination))
        return;
      GClass80 gclass80 = new GClass80((WebProxy) null, true, true);
      FrmWait frmWait = new FrmWait("Downloading the Shared Font from NUS...", true);
      gclass80.Event_5 += (EventHandler<GClass81>) ((_param1, _param2) =>
      {
        Path.Combine(Path.GetTempPath(), "game.cia");
        GClass28.gclass32_0.method_5(Path.GetTempPath(), "game");
        string outputDir = Path.GetTempPath();
        GClass27.smethod_11(outputDir);
        ProcessStartInfo processStartInfo1 = new ProcessStartInfo()
        {
          FileName = Path.Combine(outputDir, "PART1"),
          WorkingDirectory = outputDir
        };
        Process process1 = new Process();
        process1.StartInfo = processStartInfo1;
        process1.EnableRaisingEvents = true;
        process1.Exited += (EventHandler) ((sender1, e1) =>
        {
          try
          {
            ProcessStartInfo processStartInfo2 = new ProcessStartInfo()
            {
              FileName = Path.Combine(outputDir, "3dstool.exe"),
              WorkingDirectory = outputDir,
              Arguments = "-xvtf cfa contents.0000.00000000 --romfs DecryptedRomFS.bin --romfs-auto-key"
            };
            Process process2 = new Process();
            process2.StartInfo = processStartInfo2;
            process2.Exited += (EventHandler) ((sender2, e2) =>
            {
              ProcessStartInfo processStartInfo2 = new ProcessStartInfo()
              {
                FileName = "3dstool.exe",
                WorkingDirectory = outputDir,
                Arguments = "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS"
              };
              Process process2 = new Process();
              process2.StartInfo = processStartInfo2;
              process2.EnableRaisingEvents = true;
              process2.Exited += (EventHandler) ((sender3, e3) =>
              {
                byte[] buffer = new LZ11().Decompress(System.IO.File.ReadAllBytes(Path.Combine(outputDir, "ExtractedRomFS", "cbf_std.bcfnt.lz")));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof (Citra), "sysdata"));
                using (FileStream fileStream = System.IO.File.Create(sharedFontDestination))
                {
                  using (MemoryStream memoryStream = new MemoryStream(buffer))
                  {
                    memoryStream.Seek(928L, SeekOrigin.Begin);
                    fileStream.Write(Class3.byte_1, 0, Class3.byte_1.Length);
                    for (int index = 0; index < 3095744; ++index)
                    {
                      int num = memoryStream.ReadByte();
                      fileStream.WriteByte((byte) num);
                    }
                    fileStream.Write(Class3.byte_0, 0, Class3.byte_0.Length);
                  }
                }
                frmWait.method_0();
              });
              process2.Start();
            });
            process2.EnableRaisingEvents = true;
            process2.Start();
          }
          catch
          {
          }
        });
        process1.Start();
      });
      gclass80.Event_6 += (EventHandler<GEventArgs0>) ((sender, e) => frmWait.method_2(e.GameProgress));
      gclass80.method_1(((IEnumerable<GClass30>) new GClass30[1]
      {
        (GClass30) GClass28.gclass32_0
      }).ToList<GClass30>(), 100, 10000);
      int num1 = (int) frmWait.ShowDialog();
    }

    public override string GetArguments()
    {
      return string.Format("\"{0}\"", (object) this.GetRom());
    }

    public override string GetExecutable()
    {
      return Path.Combine(this.String_4, "citra-qt.exe");
    }

    public override string GetRom()
    {
      return Path.Combine(this.CurrentGamePath, "game.cxi");
    }

    private string UpdatePath
    {
      get
      {
        return Path.Combine(this.CitraTitlePath, "0004000e", this.gclass30_0.TitleId.High.ToLower(), "content");
      }
    }

    private string CitraDataRootPath
    {
      get
      {
        return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof (Citra));
      }
    }

    private string CitraTitlePath
    {
      get
      {
        return Path.Combine(this.CitraDataRootPath, "sdmc", "Nintendo 3DS", "00000000000000000000000000000000", "00000000000000000000000000000000", "title");
      }
    }

    private string UpdateVersionFilePath
    {
      get
      {
        return Path.Combine(this.UpdatePath, "ver");
      }
    }

    private string UpdateFilePath
    {
      get
      {
        return Path.Combine(this.UpdatePath, "00000000.app");
      }
    }

    private string DlcFilePath
    {
      get
      {
        return Path.Combine(this.DlcPath, "00000000.app");
      }
    }

    private string DlcPath
    {
      get
      {
        return Path.Combine(this.CitraTitlePath, "0004000c", this.gclass30_0.TitleId.High.ToLower());
      }
    }

    public override void DeleteUpdate()
    {
      try
      {
        GClass6.smethod_5(this.UpdatePath);
      }
      catch
      {
      }
    }

    private void PrepareUpdateIfNecessary(bool directDownload)
    {
      if (!(this.gclass30_0 is GClass32) || directDownload)
        return;
      GClass32 gclass300 = (GClass32) this.gclass30_0;
      if (!gclass300.Boolean_3 || GClass3.smethod_3((GClass30) gclass300.Updates[0]))
        return;
      bool flag = false;
      try
      {
        GClass33 gclass33 = gclass300.Updates.Last<GClass33>((Func<GClass33, bool>) (x => x.GEnum2_0 == GEnum2.const_2));
        if (!Directory.Exists(this.UpdatePath))
          Directory.CreateDirectory(this.UpdatePath);
        else if (this.UpdateIsInstalled() && System.IO.File.Exists(this.UpdateVersionFilePath))
          flag = System.IO.File.ReadAllText(this.UpdateVersionFilePath) == gclass33.Version;
        if (flag || directDownload)
          return;
        gclass33.method_3(this.UpdatePath, false);
        FileSystem.RenameFile(Path.Combine(this.UpdatePath, "game.cxi"), "00000000.app");
        System.IO.File.WriteAllText(this.UpdateVersionFilePath, gclass33.Version);
      }
      catch
      {
      }
    }

    private void PrepareDlcIfNecessary(bool directDownload)
    {
      if (!(this.gclass30_0 is GClass32) || directDownload)
        return;
      GClass32 gclass300 = (GClass32) this.gclass30_0;
      if (!gclass300.Boolean_2 || GClass3.smethod_3((GClass30) gclass300.Dlc) || this.DlcIsInstalled())
        return;
      gclass300.Dlc.method_2(this.DlcPath);
    }

    public override string FileSaveLocation
    {
      get
      {
        return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), nameof (Citra), "sdmc", "Nintendo 3DS", "00000000000000000000000000000000", "00000000000000000000000000000000", "title", this.gclass30_0.TitleId.Low.ToLower(), this.gclass30_0.TitleId.High.ToLower(), "data", "00000001");
      }
    }

    public override ulong GetUpdateVersion()
    {
      try
      {
        return ulong.Parse(System.IO.File.ReadAllText(this.UpdateVersionFilePath));
      }
      catch
      {
        return 0;
      }
    }

    public override DataSize GetUpdateSize()
    {
      try
      {
        if (!System.IO.File.Exists(this.UpdateFilePath))
          return new DataSize(0UL);
        return new DataSize((ulong) new FileInfo(this.UpdateFilePath).Length);
      }
      catch
      {
        return new DataSize(0UL);
      }
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      if (!this.Boolean_2)
      {
        string str = Path.Combine(this.String_5, this.gclass30_0.TitleId.IdRaw);
        GClass6.smethod_5(str);
        this.gclass30_0.method_3(str, false);
        string name = new DirectoryInfo(this.CurrentGamePath).Name;
        GClass6.smethod_5(Path.Combine(this.String_5, name));
        FileSystem.RenameDirectory(str, name);
      }
      this.PrepareUpdateIfNecessary(directDownload);
    }

    public override bool UpdateIsInstalled()
    {
      if (System.IO.File.Exists(this.UpdateFilePath))
        return new FileInfo(this.UpdateFilePath).Length > 0L;
      return false;
    }

    public override bool DlcIsInstalled()
    {
      return Directory.Exists(this.DlcFilePath);
    }

    public override void DeleteDlc()
    {
      GClass6.smethod_5(this.DlcPath);
    }

    public enum NCCH_TYPE
    {
      const_0,
      const_1,
      NONE,
    }
  }
}
