using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000131 RID: 305
	public partial class frmDriveSetup : RadForm
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x00015638 File Offset: 0x00013838
		public frmDriveSetup()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00034F54 File Offset: 0x00033154
		private static bool smethod_0(EventArrivedEventArgs eventArrivedEventArgs_0)
		{
			using (PropertyDataCollection.PropertyDataEnumerator enumerator = eventArrivedEventArgs_0.NewEvent.Properties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Name == "DriveName")
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00034FC0 File Offset: 0x000331C0
		private void method_0(object sender, EventArrivedEventArgs e)
		{
			foreach (PropertyData propertyData in ((ManagementBaseObject)e.NewEvent["TargetInstance"]).Properties)
			{
				Console.WriteLine(propertyData.Name + " = " + propertyData.Value);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00034FC0 File Offset: 0x000331C0
		private void method_1(object sender, EventArrivedEventArgs e)
		{
			foreach (PropertyData propertyData in ((ManagementBaseObject)e.NewEvent["TargetInstance"]).Properties)
			{
				Console.WriteLine(propertyData.Name + " = " + propertyData.Value);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00015646 File Offset: 0x00013846
		private void frmDriveSetup_Load(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00035040 File Offset: 0x00033240
		private void method_2(DriveInfo driveInfo_0, Action action_0, Action action_1)
		{
			string path = Path.Combine(driveInfo_0.Name, "otp.bin");
			string path2 = Path.Combine(driveInfo_0.Name, "seeprom.bin");
			if ((!File.Exists(path) || !File.Exists(path2)) && action_1 != null)
			{
				action_1();
			}
			this.byte_0 = File.ReadAllBytes(path);
			this.byte_1 = File.ReadAllBytes(path2);
			if (action_0 != null)
			{
				action_0();
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001564E File Offset: 0x0001384E
		private void radButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00015656 File Offset: 0x00013856
		private void method_3()
		{
			this.radPageView1.SelectedPage = this.radPageView1.Pages[0];
			this.method_7(new Action<EventArrivedEventArgs>(this.method_8), null);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00015687 File Offset: 0x00013887
		private void method_4()
		{
			this.radPageView1.SelectedPage = this.radPageView1.Pages[1];
			this.method_7(new Action<EventArrivedEventArgs>(this.method_10), null);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000156B8 File Offset: 0x000138B8
		private void method_5()
		{
			this.radPageView1.SelectedPage = this.radPageView1.Pages[2];
			GClass131.smethod_0(new Action<GClass132>(this.method_6));
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000350AC File Offset: 0x000332AC
		private void method_6(GClass132 gclass132_0)
		{
			frmDriveSetup.Class102 @class = new frmDriveSetup.Class102();
			@class.gclass132_0 = gclass132_0;
			@class.frmDriveSetup_0 = this;
			try
			{
				base.Invoke(new MethodInvoker(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000350F8 File Offset: 0x000332F8
		private void method_7(Action<EventArrivedEventArgs> action_0, Action<EventArrivedEventArgs> action_1 = null)
		{
			frmDriveSetup.Class103 @class = new frmDriveSetup.Class103();
			@class.frmDriveSetup_0 = this;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
			@class.managementEventWatcher_0 = new ManagementEventWatcher(query);
			@class.managementEventWatcher_0.EventArrived += @class.method_0;
			@class.managementEventWatcher_0.Start();
			WqlEventQuery query2 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
			@class.managementEventWatcher_1 = new ManagementEventWatcher(query2);
			@class.managementEventWatcher_1.EventArrived += @class.method_1;
			@class.managementEventWatcher_1.Start();
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000359B0 File Offset: 0x00033BB0
		[CompilerGenerated]
		private void method_8(EventArrivedEventArgs eventArrivedEventArgs_0)
		{
			frmDriveSetup.Class101 @class = new frmDriveSetup.Class101();
			@class.frmDriveSetup_0 = this;
			@class.driveInfo_0 = new DriveInfo(eventArrivedEventArgs_0.NewEvent.Properties["DriveName"].Value.ToString());
			this.method_2(@class.driveInfo_0, new Action(this.method_9), new Action(@class.method_0));
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00015706 File Offset: 0x00013906
		[CompilerGenerated]
		private void method_9()
		{
			this.method_5();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00035A18 File Offset: 0x00033C18
		[CompilerGenerated]
		private void method_10(EventArrivedEventArgs eventArrivedEventArgs_0)
		{
			DriveInfo driveInfo_ = new DriveInfo(eventArrivedEventArgs_0.NewEvent.Properties["DriveName"].Value.ToString());
			this.method_2(driveInfo_, new Action(this.method_11), new Action(this.method_12));
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00015706 File Offset: 0x00013906
		[CompilerGenerated]
		private void method_11()
		{
			this.method_5();
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001570E File Offset: 0x0001390E
		[CompilerGenerated]
		private void method_12()
		{
			RadMessageBox.Show("The drive you have just inserted does not contain the required files. Please try again");
			this.method_4();
		}

		// Token: 0x040004E4 RID: 1252
		private byte[] byte_0;

		// Token: 0x040004E5 RID: 1253
		private byte[] byte_1;

		// Token: 0x02000132 RID: 306
		[CompilerGenerated]
		private sealed class Class101
		{
			// Token: 0x06000874 RID: 2164 RVA: 0x00035A6C File Offset: 0x00033C6C
			internal void method_0()
			{
				if (this.driveInfo_0.DriveFormat != "FAT32")
				{
					RadMessageBox.Show("This drive needs to be formatted to FAT32 before being used on a WiiU. Please try again once you have formatted it");
					this.frmDriveSetup_0.method_3();
					return;
				}
				GClass27.smethod_10(this.driveInfo_0.Name);
				this.frmDriveSetup_0.method_4();
			}

			// Token: 0x040004F1 RID: 1265
			public DriveInfo driveInfo_0;

			// Token: 0x040004F2 RID: 1266
			public frmDriveSetup frmDriveSetup_0;
		}

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		private sealed class Class102
		{
			// Token: 0x06000876 RID: 2166 RVA: 0x00035AC4 File Offset: 0x00033CC4
			internal void method_0()
			{
				this.gclass132_0.method_2(this.frmDriveSetup_0.byte_0, this.frmDriveSetup_0.byte_1);
				this.frmDriveSetup_0.radPageView1.SelectedPage = this.frmDriveSetup_0.radPageView1.Pages[3];
			}

			// Token: 0x040004F3 RID: 1267
			public GClass132 gclass132_0;

			// Token: 0x040004F4 RID: 1268
			public frmDriveSetup frmDriveSetup_0;
		}

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		private sealed class Class103
		{
			// Token: 0x06000878 RID: 2168 RVA: 0x00035B18 File Offset: 0x00033D18
			internal void method_0(object sender, EventArrivedEventArgs e)
			{
				frmDriveSetup.Class104 @class = new frmDriveSetup.Class104();
				@class.class103_0 = this;
				@class.eventArrivedEventArgs_0 = e;
				if (!frmDriveSetup.smethod_0(@class.eventArrivedEventArgs_0))
				{
					return;
				}
				this.managementEventWatcher_0.Stop();
				this.managementEventWatcher_0.Dispose();
				this.frmDriveSetup_0.Invoke(new MethodInvoker(@class.method_0));
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x00035B78 File Offset: 0x00033D78
			internal void method_1(object sender, EventArrivedEventArgs e)
			{
				frmDriveSetup.Class105 @class = new frmDriveSetup.Class105();
				@class.class103_0 = this;
				@class.eventArrivedEventArgs_0 = e;
				if (!frmDriveSetup.smethod_0(@class.eventArrivedEventArgs_0))
				{
					return;
				}
				this.managementEventWatcher_1.Stop();
				this.managementEventWatcher_1.Dispose();
				this.frmDriveSetup_0.Invoke(new MethodInvoker(@class.method_0));
			}

			// Token: 0x040004F5 RID: 1269
			public ManagementEventWatcher managementEventWatcher_0;

			// Token: 0x040004F6 RID: 1270
			public frmDriveSetup frmDriveSetup_0;

			// Token: 0x040004F7 RID: 1271
			public Action<EventArrivedEventArgs> action_0;

			// Token: 0x040004F8 RID: 1272
			public ManagementEventWatcher managementEventWatcher_1;

			// Token: 0x040004F9 RID: 1273
			public Action<EventArrivedEventArgs> action_1;
		}

		// Token: 0x02000135 RID: 309
		[CompilerGenerated]
		private sealed class Class104
		{
			// Token: 0x0600087B RID: 2171 RVA: 0x00015721 File Offset: 0x00013921
			internal void method_0()
			{
				Action<EventArrivedEventArgs> action_ = this.class103_0.action_0;
				if (action_ == null)
				{
					return;
				}
				action_(this.eventArrivedEventArgs_0);
			}

			// Token: 0x040004FA RID: 1274
			public EventArrivedEventArgs eventArrivedEventArgs_0;

			// Token: 0x040004FB RID: 1275
			public frmDriveSetup.Class103 class103_0;
		}

		// Token: 0x02000136 RID: 310
		[CompilerGenerated]
		private sealed class Class105
		{
			// Token: 0x0600087D RID: 2173 RVA: 0x0001573E File Offset: 0x0001393E
			internal void method_0()
			{
				Action<EventArrivedEventArgs> action_ = this.class103_0.action_1;
				if (action_ == null)
				{
					return;
				}
				action_(this.eventArrivedEventArgs_0);
			}

			// Token: 0x040004FC RID: 1276
			public EventArrivedEventArgs eventArrivedEventArgs_0;

			// Token: 0x040004FD RID: 1277
			public frmDriveSetup.Class103 class103_0;
		}
	}
}
