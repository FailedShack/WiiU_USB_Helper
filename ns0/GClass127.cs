// Decompiled with JetBrains decompiler
// Type: ns0.GClass127
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;

namespace ns0
{
  public class GClass127
  {
    private Dictionary<string, FileSystemWatcher> dictionary_0 = new Dictionary<string, FileSystemWatcher>();

    public void method_0()
    {
      try
      {
        foreach (DriveInfo drive in DriveInfo.GetDrives())
          this.method_3(drive);
        ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher();
        managementEventWatcher.EventArrived += new EventArrivedEventHandler(this.method_1);
        managementEventWatcher.Query = (EventQuery) new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
        managementEventWatcher.Start();
      }
      catch
      {
      }
    }

    private void method_1(object sender, EventArrivedEventArgs e)
    {
      try
      {
        this.method_3(new DriveInfo(e.NewEvent.Properties["DriveName"].Value.ToString()));
      }
      catch
      {
      }
    }

    private void method_2(object sender, FileSystemEventArgs e)
    {
      try
      {
        if (!(GClass30.smethod_3(e.Name) != e.Name))
          return;
        this.method_4(Path.GetPathRoot(e.FullPath));
      }
      catch
      {
      }
    }

    private void method_3(DriveInfo driveInfo_0)
    {
      try
      {
        string index = Path.Combine(driveInfo_0.RootDirectory.FullName, "install");
        if (!driveInfo_0.IsReady || driveInfo_0.DriveType != DriveType.Removable || !Directory.Exists(index))
          return;
        if (this.dictionary_0.ContainsKey(index))
        {
          this.dictionary_0[index].EnableRaisingEvents = false;
          this.dictionary_0[index].Dispose();
          this.dictionary_0.Remove(index);
        }
        FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(index);
        fileSystemWatcher.Created += new FileSystemEventHandler(this.method_2);
        fileSystemWatcher.EnableRaisingEvents = true;
        this.dictionary_0.Add(index, fileSystemWatcher);
        IEnumerable<DirectoryInfo> source = new DirectoryInfo(index).EnumerateDirectories().Where<DirectoryInfo>((Func<DirectoryInfo, bool>) (directoryInfo_0 => GClass30.smethod_3(directoryInfo_0.Name) != directoryInfo_0.Name));
        Func<DirectoryInfo, bool> func = (Func<DirectoryInfo, bool>) (directoryInfo_0 => File.Exists(Path.Combine(directoryInfo_0.FullName, "title.tik")));
        Func<DirectoryInfo, bool> predicate;
        if (!source.Where<DirectoryInfo>(predicate).Any<DirectoryInfo>())
          return;
        this.method_4(driveInfo_0.Name);
      }
      catch
      {
      }
    }

    private void method_4(string string_0)
    {
      Class97.smethod_5("Error found", string.Format("USB Helper has detected that some or all of the games on your SD card (drive {0}) have special characters in their directory name.\nPlease remove the special characters (such as é,©,etc..) or the installation will fail.\nIn the future, prefer using the Copy to SD feature to avoid this problem.", (object) string_0), -1, true, (Image) Class123.icnSd);
    }
  }
}
