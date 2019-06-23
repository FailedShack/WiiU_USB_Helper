using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using NusHelper.Emulators;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000129 RID: 297
	internal static class Class95
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x000343FC File Offset: 0x000325FC
		public static Color smethod_0(GClass30 gclass30_0)
		{
			if (gclass30_0.DiscOnly)
			{
				return Color.LightGoldenrodYellow;
			}
			if (gclass30_0.GEnum2_0 == GEnum2.const_2)
			{
				return Color.Green;
			}
			if (gclass30_0.GEnum2_0 == GEnum2.const_1)
			{
				return Color.DarkOrange;
			}
			if (gclass30_0.GEnum2_0 != GEnum2.const_0)
			{
				return Color.Black;
			}
			if (gclass30_0.Boolean_0)
			{
				return Color.Violet;
			}
			if (ThemeResolutionService.ApplicationThemeName.Contains("Dark"))
			{
				return Color.White;
			}
			return Color.Black;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00034470 File Offset: 0x00032670
		public static void smethod_1(GClass32 gclass32_0, int int_0, Color color_0)
		{
			if (gclass32_0.gclass86_2.Image == null)
			{
				return;
			}
			if (gclass32_0.Boolean_3)
			{
				gclass32_0.gclass86_2.Image = ((gclass32_0.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2) ? GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.hasUpdateOk, true) : GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.hasUpdate, true));
			}
			if (gclass32_0.Boolean_2)
			{
				gclass32_0.gclass86_2.Image = ((gclass32_0.Dlc.GEnum2_0 == GEnum2.const_2) ? GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.hasDLCOk, true) : GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.hasDLC, true));
			}
			switch (gclass32_0.System)
			{
			case GEnum3.const_0:
				gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.tag3ds, true);
				break;
			case GEnum3.const_1:
				gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.tagWiiU, true);
				break;
			case GEnum3.const_2:
				throw new NotImplementedException();
			case GEnum3.const_3:
				gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.tagWii, true);
				break;
			}
			if (gclass32_0.Boolean_4)
			{
				gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, Class121.newTag, true);
			}
			gclass32_0.gclass86_2.Image = gclass32_0.gclass86_2.Image.smethod_0(int_0, color_0, true);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00034604 File Offset: 0x00032804
		public static void smethod_2()
		{
			if (Settings.Default.Path.Contains("Program Files") && Settings.Default.ShowProgramFilesWarning)
			{
				RadMessageBox.Show("It appears you have chosen to store your games in Program Files. This could lead to a number of issues since this is a restricted location. It is advised that you chose another location which does not require admin privileges such as your personnal folder.");
				DialogResult dialogResult = RadMessageBox.Show("Would you like to set a new location now (strongly recommended)? Chosing cancel will disable future warnings.", "Problem detected", MessageBoxButtons.YesNoCancel);
				if (dialogResult != DialogResult.Cancel)
				{
					if (dialogResult != DialogResult.Yes)
					{
						return;
					}
					string text = Path.Combine(Settings.Default.Path, "DATA");
					string text2 = Path.Combine(Settings.Default.Path, "DATA_3DS");
					while (!Class95.smethod_13(true) || !GClass6.smethod_2(Settings.Default.Path))
					{
					}
					if (Directory.Exists(text))
					{
						Class95.smethod_8(text, Settings.Default.Path);
					}
					if (Directory.Exists(text2))
					{
						Class95.smethod_8(text2, Settings.Default.Path);
						return;
					}
				}
				else
				{
					Settings.Default.ShowProgramFilesWarning = false;
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00015542 File Offset: 0x00013742
		public static void smethod_3()
		{
			GClass88.smethod_0("dl");
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000346F4 File Offset: 0x000328F4
		public static void smethod_4(IEnumerable<GClass30> ienumerable_0, DriveInfo driveInfo_0, bool bool_0, bool bool_1, Form form_1 = null)
		{
			string text = "--COPY REPORT--" + Environment.NewLine;
			int num = 0;
			if (ienumerable_0.Any(new Func<GClass30, bool>(Class95.<>c.<>c_0.method_0)))
			{
				GClass94.smethod_8(driveInfo_0);
			}
			foreach (GClass30 gclass in ienumerable_0)
			{
				string text2 = gclass.method_9(bool_0, driveInfo_0);
				if (text2 == "OK")
				{
					num++;
					if (gclass is GClass32)
					{
						(gclass as GClass32).Boolean_5 = true;
					}
				}
				else
				{
					text += string.Format("-{0} : {1} {2}", gclass, text2, Environment.NewLine);
				}
			}
			text += string.Format("-{0} title(s) were copied successfully{1}", num, Environment.NewLine);
			if (bool_1 && form_1 != null)
			{
				Class95.smethod_5("Copy report", text, 10, true, null);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000347F4 File Offset: 0x000329F4
		public static void smethod_5(string string_0, string string_1, int int_0, bool bool_0 = true, Image image_0 = null)
		{
			Class95.Class96 @class = new Class95.Class96();
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			@class.image_0 = image_0;
			@class.int_0 = int_0;
			@class.bool_0 = bool_0;
			Form form = Class95.form_0;
			if (form == null)
			{
				return;
			}
			form.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001554E File Offset: 0x0001374E
		public static Region smethod_6(Form form_1, int int_0 = 40)
		{
			return Region.FromHrgn(Class95.CreateRoundRectRgn(0, 0, form_1.Width, form_1.Height, int_0, int_0));
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00034848 File Offset: 0x00032A48
		public static void smethod_7(GClass32 gclass32_0, GClass82 gclass82_0, Form form_1)
		{
			Class95.Class98 @class = new Class95.Class98();
			@class.gclass32_0 = gclass32_0;
			@class.gclass82_0 = gclass82_0;
			@class.form_0 = form_1;
			if (@class.gclass82_0 == null)
			{
				Class95.smethod_16(@class.form_0);
				return;
			}
			if (RadMessageBox.Show("USB Helper will now try to import your save from your Wii U to CEMU. This will OVERWRITE any save you already have on your computer AND on your USB Helper Cloud if enabled. Continue?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			@class.string_0 = null;
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper downloads your save.", false);
			Task.Run(new Action(@class.method_0));
			@class.frmWait_0.ShowDialog();
			if (@class.string_0 != null)
			{
				Cemu cemu = @class.gclass32_0.method_14(false) as Cemu;
				string fileSaveLocation = cemu.FileSaveLocation;
				GClass6.smethod_5(fileSaveLocation);
				Directory.CreateDirectory(fileSaveLocation);
				using (FileStream fileStream = File.OpenRead(@class.string_0))
				{
					using (ZipArchive zipArchive = new ZipArchive(fileStream))
					{
						zipArchive.ExtractToDirectory(fileSaveLocation);
					}
				}
				string text = Path.Combine(fileSaveLocation, "user");
				if (!Directory.Exists(text))
				{
					goto IL_17F;
				}
				try
				{
					Directory.Move(new DirectoryInfo(text).GetDirectories().First(new Func<DirectoryInfo, bool>(Class95.<>c.<>c_0.method_2)).FullName, Path.Combine(text, "80000001"));
					if (Settings.Default.EnableCloudSaving)
					{
						cemu.method_2(cemu.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
					}
					goto IL_17F;
				}
				catch
				{
					goto IL_17F;
				}
			}
			Class95.smethod_15(@class.form_0, "Could not import your save.");
			IL_17F:
			@class.frmWait_0.method_0();
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00034A08 File Offset: 0x00032C08
		public static void smethod_8(string string_0, string string_1)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = string.Format("/c move \"{0}\" \"{1}\"", string_0, string_1),
				UseShellExecute = true,
				Verb = "runas"
			};
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001556A File Offset: 0x0001376A
		public static void smethod_9(string string_0)
		{
			Process.Start("explorer.exe", string_0);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00034A60 File Offset: 0x00032C60
		public static void smethod_10(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (pictureBox.Image != null)
			{
				new FrmImgPreview(pictureBox.Image).ShowDialog();
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00015578 File Offset: 0x00013778
		public static void smethod_11(RadForm radForm_0, int int_0 = 10)
		{
			radForm_0.FormElement.Shape = new RoundRectShape(int_0);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00034A90 File Offset: 0x00032C90
		public static bool smethod_12(bool bool_0)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				Title = "Please chose where to store extracted games.",
				IsFolderPicker = true
			};
			while (commonOpenFileDialog.ShowDialog() != CommonFileDialogResult.Cancel)
			{
				if (GClass6.smethod_2(commonOpenFileDialog.FileName))
				{
					Settings.Default.ExtractFolder = commonOpenFileDialog.FileName;
					Settings.Default.Save();
					return true;
				}
			}
			return !bool_0;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00034AF0 File Offset: 0x00032CF0
		public static bool smethod_13(bool bool_0)
		{
			RadMessageBox.Show("Please select a location to store your games. Note : it is not recommended to chose a location such as 'Program Files' since it requires Admin privileges.");
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				Title = "Please chose where to store your games."
			};
			while (commonOpenFileDialog.ShowDialog() != CommonFileDialogResult.Cancel)
			{
				if (GClass6.smethod_2(commonOpenFileDialog.FileName))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(commonOpenFileDialog.FileName);
					string path = commonOpenFileDialog.FileName;
					if (directoryInfo.Name == "DATA" || directoryInfo.Name == "DATA_3DS")
					{
						path = directoryInfo.Parent.FullName;
					}
					Settings.Default.Path = path;
					Settings.Default.Save();
					return true;
				}
			}
			return !bool_0;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0001558B File Offset: 0x0001378B
		public static void smethod_14(Form form_1)
		{
			Class95.form_0 = form_1;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00034B98 File Offset: 0x00032D98
		public static void smethod_15(Form form_1, string string_0)
		{
			Class95.Class99 @class = new Class95.Class99();
			@class.form_0 = form_1;
			@class.string_0 = string_0;
			@class.form_0.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00015593 File Offset: 0x00013793
		public static void smethod_16(Form form_1)
		{
			Class95.smethod_15(form_1, "In order to use this feature, you must have Wii U USB Transfer Tool currently running on your Wii U.\nPlease launch it and try again.");
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000155A0 File Offset: 0x000137A0
		public static void smethod_17(TimeSpan timeSpan_0, RadLabel radLabel_0)
		{
			radLabel_0.Text = ((timeSpan_0.TotalSeconds > 0.0) ? string.Format("ETA : {0}", GClass6.smethod_12(timeSpan_0)) : "ETA : Acquiring data...");
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00034BD4 File Offset: 0x00032DD4
		public static void smethod_18()
		{
			try
			{
				string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Updater.exe");
				string b = new GClass78().method_6(string.Format("{0}/Updater.hash", Class65.String_0));
				using (SHA256 sha = SHA256.Create())
				{
					if (!File.Exists(path) || !(Convert.ToBase64String(sha.ComputeHash(File.ReadAllBytes(path))) == b))
					{
						byte[] array = new GClass78().method_2(string.Format("{0}/Updater.exe", Class65.String_0));
						if (Convert.ToBase64String(sha.ComputeHash(array)) == b)
						{
							File.WriteAllBytes(path, array);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600084E RID: 2126
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);

		// Token: 0x040004CF RID: 1231
		private static Form form_0;

		// Token: 0x040004D0 RID: 1232
		private static SoundPlayer soundPlayer_0 = new SoundPlayer(Class121.sndNotification);

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		private sealed class Class96
		{
			// Token: 0x06000855 RID: 2133 RVA: 0x00034C9C File Offset: 0x00032E9C
			internal void method_0()
			{
				Class95.Class97 @class = new Class95.Class97();
				@class.radDesktopAlert_0 = new RadDesktopAlert
				{
					CaptionText = this.string_0,
					ContentText = this.string_1,
					AutoSize = true,
					Opacity = 0.95f,
					ContentImage = this.image_0
				};
				if (this.int_0 < 0)
				{
					@class.radDesktopAlert_0.AutoClose = false;
				}
				else
				{
					@class.radDesktopAlert_0.AutoCloseDelay = this.int_0;
				}
				if (this.bool_0)
				{
					@class.radDesktopAlert_0.Opened += @class.method_0;
				}
				@class.radDesktopAlert_0.Show();
			}

			// Token: 0x040004D5 RID: 1237
			public string string_0;

			// Token: 0x040004D6 RID: 1238
			public string string_1;

			// Token: 0x040004D7 RID: 1239
			public Image image_0;

			// Token: 0x040004D8 RID: 1240
			public int int_0;

			// Token: 0x040004D9 RID: 1241
			public bool bool_0;
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class Class97
		{
			// Token: 0x06000857 RID: 2135 RVA: 0x00034D44 File Offset: 0x00032F44
			internal void method_0(object sender, EventArgs e)
			{
				Task.Delay(this.radDesktopAlert_0.FadeAnimationFrames * this.radDesktopAlert_0.FadeAnimationSpeed + 100).ContinueWith(new Action<Task>(Class95.<>c.<>c_0.method_1));
			}

			// Token: 0x040004DA RID: 1242
			public RadDesktopAlert radDesktopAlert_0;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		private sealed class Class98
		{
			// Token: 0x06000859 RID: 2137 RVA: 0x00034D98 File Offset: 0x00032F98
			internal void method_0()
			{
				try
				{
					this.string_0 = this.gclass32_0.method_25(this.gclass82_0, "Imported Save");
					this.frmWait_0.method_0();
				}
				catch (GException0)
				{
					this.frmWait_0.method_0();
					Class95.smethod_15(this.form_0, "No save was found for this game on your Wii U.");
				}
				catch (Exception ex)
				{
					this.frmWait_0.method_0();
					Class95.smethod_15(this.form_0, ex.Message);
				}
			}

			// Token: 0x040004DB RID: 1243
			public string string_0;

			// Token: 0x040004DC RID: 1244
			public GClass32 gclass32_0;

			// Token: 0x040004DD RID: 1245
			public GClass82 gclass82_0;

			// Token: 0x040004DE RID: 1246
			public FrmWait frmWait_0;

			// Token: 0x040004DF RID: 1247
			public Form form_0;
		}

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		private sealed class Class99
		{
			// Token: 0x0600085B RID: 2139 RVA: 0x00015605 File Offset: 0x00013805
			internal void method_0()
			{
				this.form_0.BringToFront();
				RadMessageBox.Show(this.string_0);
			}

			// Token: 0x040004E0 RID: 1248
			public Form form_0;

			// Token: 0x040004E1 RID: 1249
			public string string_0;
		}
	}
}
