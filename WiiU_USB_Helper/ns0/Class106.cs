using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Win32;
using Telerik.WinControls;
using WIIU_Downloader;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000139 RID: 313
	internal static class Class106
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0001577D File Offset: 0x0001397D
		public static bool Boolean_0
		{
			get
			{
				return GClass6.smethod_16("xmr-stak");
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00035D08 File Offset: 0x00033F08
		public static void smethod_0()
		{
			if (!Settings.Default.Mine)
			{
				return;
			}
			if (!Environment.Is64BitOperatingSystem)
			{
				RadMessageBox.Show("Sorry but you need a 64 bit OS to mine!");
				Settings.Default.Mine = false;
				Settings.Default.Save();
				return;
			}
			if (!Class106.Boolean_0)
			{
				Class106.bool_2 = true;
				try
				{
					Task.Run(new Action(Class106.<>c.<>c_0.method_0));
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00035D94 File Offset: 0x00033F94
		public static void smethod_1()
		{
			try
			{
				Class106.bool_2 = false;
				Process process = Class106.process_0;
				if (process != null)
				{
					process.Kill();
				}
				Process[] processesByName = Process.GetProcessesByName("xmr-stak");
				for (int i = 0; i < processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00015789 File Offset: 0x00013989
		private static bool smethod_2(string string_0)
		{
			return ((string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName")).Contains(string_0);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000157AF File Offset: 0x000139AF
		private static bool smethod_3()
		{
			return Class106.smethod_2("Windows 10");
		}

		// Token: 0x04000500 RID: 1280
		public static bool bool_0;

		// Token: 0x04000501 RID: 1281
		private static MinerPofile minerPofile_0;

		// Token: 0x04000502 RID: 1282
		private static volatile bool bool_1;

		// Token: 0x04000503 RID: 1283
		private static Process process_0;

		// Token: 0x04000504 RID: 1284
		private static volatile bool bool_2;

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		private sealed class Class107
		{
			// Token: 0x0600088A RID: 2186 RVA: 0x000157BB File Offset: 0x000139BB
			internal void method_0(object sender, EventArgs e)
			{
				int exitCode = this.process_0.ExitCode;
			}

			// Token: 0x04000505 RID: 1285
			public Process process_0;
		}
	}
}
