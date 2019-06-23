using System;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using NusHelper;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000143 RID: 323
	internal static class Class110
	{
		// Token: 0x060008B4 RID: 2228 RVA: 0x00036C08 File Offset: 0x00034E08
		private static bool smethod_0()
		{
			bool result;
			try
			{
				string text = File.ReadAllText(Path.Combine(GClass88.CachePath, "lasttitles"));
				int num = 0;
				foreach (string text2 in text.Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					if (!string.IsNullOrEmpty(text2))
					{
						num++;
						new TitleId(text2);
					}
				}
				if (num < 25)
				{
					result = false;
				}
				else
				{
					result = (new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable("LocalAppData"), "Hikari06")).EnumerateFiles("user.config", SearchOption.AllDirectories).Count<FileInfo>() > 1);
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00036CB8 File Offset: 0x00034EB8
		[STAThread]
		private static void Main(string[] args)
		{
			try
			{
				ServicePointManager.SecurityProtocol |= (SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(Settings.Default.AppId))
			{
				Settings.Default.AppId = Guid.NewGuid().ToString();
				Settings.Default.Save();
			}
			GClass88.smethod_13(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\USB_HELPER\\");
			Class106.smethod_1();
			AppDomain.CurrentDomain.UnhandledException += Class110.<>c.<>c_0.method_0;
			if (args.Length == 1)
			{
				Class100.string_0 = args[0];
			}
			if (!ApplicationDeployment.IsNetworkDeployed && Class100.string_0 == null)
			{
				RadMessageBox.Show("You cannot execute this application directly. Please use the default shortcut on your desktop or execute Updater.exe");
				Application.Exit();
				return;
			}
			foreach (string resourcePath in Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(new Func<string, bool>(Class110.<>c.<>c_0.method_1)))
			{
				ThemeResolutionService.LoadPackageResource(resourcePath);
			}
			Application.EnableVisualStyles();
			if (Settings.Default.ThemeName == "VisualStudio2012Dark")
			{
				Settings.Default.ThemeName = "DarkBlue";
			}
			if (Settings.Default.ThemeName == "VisualStudio2012Light")
			{
				Settings.Default.ThemeName = "Light";
			}
			Settings.Default.Save();
			ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
			bool flag = Class110.smethod_0();
			if (Settings.Default.LaunchCount == 0 && !flag)
			{
				new frmSupportOver().ShowDialog();
				Application.Exit();
				Environment.Exit(0);
				return;
			}
			if (Settings.Default.Region == "NONE")
			{
				Class110.bool_0 = true;
				FrmWelcome frmWelcome = new FrmWelcome();
				frmWelcome.ShowDialog();
				if (frmWelcome.bool_0)
				{
					Class106.smethod_1();
					Application.Exit();
					return;
				}
			}
			using (Mutex mutex = new Mutex(true, "Global\\WIIU_USB_HELPER"))
			{
				try
				{
					if (!mutex.WaitOne(0, true))
					{
						RadMessageBox.Show("An instance of WiiU USB Helper is already running.");
						return;
					}
				}
				catch (AbandonedMutexException)
				{
				}
				SystemEvents.PowerModeChanged += Class110.<>c.<>c_0.method_2;
				Class106.smethod_0();
				Class89.smethod_0();
				Application.Run(new NusGrabberForm());
				Class89.smethod_1();
				Class106.smethod_1();
			}
		}

		// Token: 0x04000526 RID: 1318
		public static bool bool_0;

		// Token: 0x04000527 RID: 1319
		private static volatile bool bool_1;
	}
}
