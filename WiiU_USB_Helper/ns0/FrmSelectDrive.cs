using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001C5 RID: 453
	public partial class FrmSelectDrive : RadForm
	{
		// Token: 0x06000C59 RID: 3161 RVA: 0x00018AC2 File Offset: 0x00016CC2
		public FrmSelectDrive(DataSize dataSize_1)
		{
			this.dataSize_0 = dataSize_1;
			this.InitializeComponent();
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0004EBE0 File Offset: 0x0004CDE0
		public static IEnumerable<DriveInfo> smethod_0(bool bool_0)
		{
			if (bool_0)
			{
				return new List<DriveInfo>(DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(FrmSelectDrive.<>c.<>c_0.method_0)));
			}
			return new List<DriveInfo>(DriveInfo.GetDrives().Where(new Func<DriveInfo, bool>(FrmSelectDrive.<>c.<>c_0.method_1)));
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00018AD7 File Offset: 0x00016CD7
		private void chkDriveNotSeen_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			this.method_0(!this.chkDriveNotSeen.Checked);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00018AED File Offset: 0x00016CED
		private void managementEventWatcher_0_EventArrived(object object_0, object object_1)
		{
			base.Invoke(new MethodInvoker(this.method_1));
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0004EC50 File Offset: 0x0004CE50
		private void FrmSelectDrive_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.managementEventWatcher_0.EventArrived -= new EventArrivedEventHandler(this.managementEventWatcher_0_EventArrived);
				this.managementEventWatcher_0.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0004EC94 File Offset: 0x0004CE94
		private void FrmSelectDrive_Load(object sender, EventArgs e)
		{
			this.method_0(true);
			try
			{
				this.managementEventWatcher_0 = new ManagementEventWatcher();
				WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2 OR EventType = 3");
				this.managementEventWatcher_0.EventArrived += new EventArrivedEventHandler(this.managementEventWatcher_0_EventArrived);
				this.managementEventWatcher_0.Query = query;
				this.managementEventWatcher_0.Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0004ED04 File Offset: 0x0004CF04
		private void lstDrives_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
		{
			DriveInfo driveInfo = (DriveInfo)e.Item.Tag;
			if (driveInfo.TotalSize < (long)this.dataSize_0.TotalBytes)
			{
				RadMessageBox.Show("Sorry but this drive isn't big enough, even if completely empty.");
				return;
			}
			if (driveInfo.AvailableFreeSpace < (long)this.dataSize_0.TotalBytes)
			{
				DataSize dataSize = new DataSize(this.dataSize_0.TotalBytes - (ulong)driveInfo.AvailableFreeSpace);
				RadMessageBox.Show(string.Format("There isn't enough space on this drive! Please delete some files and try again! You need to free {0}.", dataSize));
				if (RadMessageBox.Show("Would you like to open an explorer window to make some space?", "Open explorer?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Process.Start(driveInfo.Name);
					return;
				}
			}
			else
			{
				this.driveInfo_0 = driveInfo;
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		private void method_0(bool bool_0)
		{
			this.lstDrives.Items.Clear();
			foreach (DriveInfo driveInfo in FrmSelectDrive.smethod_0(bool_0))
			{
				if (driveInfo.IsReady)
				{
					this.lstDrives.BeginEdit();
					ListViewDataItem item = new ListViewDataItem(driveInfo.Name)
					{
						Image = Class121.icnDisk,
						Tag = driveInfo,
						ImageAlignment = ContentAlignment.TopCenter,
						TextAlignment = ContentAlignment.BottomCenter,
						TextImageRelation = TextImageRelation.ImageAboveText
					};
					this.lstDrives.Items.Add(item);
					this.lstDrives.EndEdit();
				}
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00018AD7 File Offset: 0x00016CD7
		[CompilerGenerated]
		private void method_1()
		{
			this.method_0(!this.chkDriveNotSeen.Checked);
		}

		// Token: 0x04000811 RID: 2065
		public DriveInfo driveInfo_0;

		// Token: 0x04000812 RID: 2066
		private DataSize dataSize_0;

		// Token: 0x04000813 RID: 2067
		private ManagementEventWatcher managementEventWatcher_0;
	}
}
