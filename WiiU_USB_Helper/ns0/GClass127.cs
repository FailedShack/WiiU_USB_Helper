using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;

namespace ns0
{
	// Token: 0x02000145 RID: 325
	public class GClass127
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00037190 File Offset: 0x00035390
		public void method_0()
		{
			try
			{
				foreach (DriveInfo driveInfo_ in DriveInfo.GetDrives())
				{
					this.method_3(driveInfo_);
				}
				ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher();
				managementEventWatcher.EventArrived += this.method_1;
				managementEventWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
				managementEventWatcher.Start();
			}
			catch
			{
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00037200 File Offset: 0x00035400
		private void method_1(object sender, EventArrivedEventArgs e)
		{
			try
			{
				DriveInfo driveInfo_ = new DriveInfo(e.NewEvent.Properties["DriveName"].Value.ToString());
				this.method_3(driveInfo_);
			}
			catch
			{
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00037250 File Offset: 0x00035450
		private void method_2(object sender, FileSystemEventArgs e)
		{
			try
			{
				if (GClass30.smethod_3(e.Name) != e.Name)
				{
					this.method_4(Path.GetPathRoot(e.FullPath));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0003729C File Offset: 0x0003549C
		private void method_3(DriveInfo driveInfo_0)
		{
			try
			{
				string text = Path.Combine(driveInfo_0.RootDirectory.FullName, "install");
				if (driveInfo_0.IsReady && driveInfo_0.DriveType == DriveType.Removable && Directory.Exists(text))
				{
					if (this.dictionary_0.ContainsKey(text))
					{
						this.dictionary_0[text].EnableRaisingEvents = false;
						this.dictionary_0[text].Dispose();
						this.dictionary_0.Remove(text);
					}
					FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(text);
					fileSystemWatcher.Created += this.method_2;
					fileSystemWatcher.EnableRaisingEvents = true;
					this.dictionary_0.Add(text, fileSystemWatcher);
					if (new DirectoryInfo(text).EnumerateDirectories().Where(new Func<DirectoryInfo, bool>(GClass127.<>c.<>c_0.method_0)).Where(new Func<DirectoryInfo, bool>(GClass127.<>c.<>c_0.method_1)).Any<DirectoryInfo>())
					{
						this.method_4(driveInfo_0.Name);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00015954 File Offset: 0x00013B54
		private void method_4(string string_0)
		{
			Class95.smethod_5("Error found", string.Format("USB Helper has detected that some or all of the games on your SD card (drive {0}) have special characters in their directory name.\nPlease remove the special characters (such as é,©,etc..) or the installation will fail.\nIn the future, prefer using the Copy to SD feature to avoid this problem.", string_0), -1, true, Class121.icnSd);
		}

		// Token: 0x0400052C RID: 1324
		private Dictionary<string, FileSystemWatcher> dictionary_0 = new Dictionary<string, FileSystemWatcher>();
	}
}
