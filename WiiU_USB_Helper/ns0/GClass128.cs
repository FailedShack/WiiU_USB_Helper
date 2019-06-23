using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using HtmlAgilityPack;
using IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
using NusHelper.Emulators;
using SharpSteam;
using Telerik.WinControls;
using VDFParser.Models;

namespace ns0
{
	// Token: 0x02000147 RID: 327
	public static class GClass128
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x000373D8 File Offset: 0x000355D8
		public static void smethod_0(GClass32 gclass32_0)
		{
			if (!gclass32_0.Boolean_1)
			{
				return;
			}
			try
			{
				GClass95 gclass = gclass32_0.method_14(false);
				if (!gclass.Boolean_0)
				{
					if (!gclass.EmuConfiguration_0.AutoUpdate)
					{
						RadMessageBox.Show(string.Format("No emulator detected. Please install it in {0} or enable Automatic updates in 'Emu. Settings'.", gclass.String_4));
						return;
					}
					gclass.method_0();
				}
				gclass.FullScreen = true;
				frmShortcutType frmShortcutType = new frmShortcutType(gclass32_0);
				if (frmShortcutType.ShowDialog() == DialogResult.OK)
				{
					if (frmShortcutType.ShortcutType == GEnum9.const_1)
					{
						GClass128.smethod_5(gclass32_0, gclass);
					}
					else if (frmShortcutType.ShortcutType == GEnum9.const_0)
					{
						if (gclass is Cemu)
						{
							(gclass as Cemu).RenderUpsideDown = frmShortcutType.SteamLinkFix;
						}
						GClass128.smethod_7(gclass32_0, gclass);
					}
					RadMessageBox.Show("Done!");
				}
			}
			catch (Exception ex)
			{
				RadMessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000159AD File Offset: 0x00013BAD
		public static void smethod_1()
		{
			Task.Run(new Action(GClass128.<>c.<>c_0.method_0));
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000374A8 File Offset: 0x000356A8
		public static void smethod_2(GClass32 gclass32_0)
		{
			try
			{
				string text = GClass128.smethod_9(gclass32_0);
				if (text != null)
				{
					string string_ = GClass128.smethod_8(gclass32_0);
					foreach (string path in SteamManager.GetUsers(SteamManager.GetSteamFolder()))
					{
						ulong num = GClass128.smethod_3(gclass32_0.Name, string_);
						string text2 = System.IO.Path.Combine(path, "config", "grid");
						System.IO.Directory.CreateDirectory(text2);
						string destFileName = System.IO.Path.Combine(text2, num + ".png");
						System.IO.File.Copy(text, destFileName, true);
					}
					GClass6.smethod_6(text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000159D4 File Offset: 0x00013BD4
		private static string String_0
		{
			get
			{
				return System.IO.Path.Combine(GClass88.CachePath, "steam");
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00037544 File Offset: 0x00035744
		private static ulong smethod_3(string string_0, string string_1)
		{
			GClass122 gclass = new GClass122();
			byte[] bytes = Encoding.UTF8.GetBytes(string_1 + string_0);
			gclass.method_2(bytes);
			return (ulong)((uint)gclass.Int64_0 | 2147483648u) << 32 | 33554432UL;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00037588 File Offset: 0x00035788
		private static string smethod_4(GClass32 gclass32_0, GClass95 gclass95_0)
		{
			System.IO.Path.Combine(GClass88.CachePath, "steam");
			string text = GClass128.smethod_8(gclass32_0);
			System.IO.Directory.CreateDirectory(GClass128.String_0);
			new GClass78().method_5(string.Format("{0}/res/tools/Shortcut.exe", Class65.String_2), text, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
			System.IO.File.WriteAllText(text + ".arg", string.Format("{0}|{1}|{2}", gclass95_0.GetExecutable(), gclass95_0.GetArguments(), System.IO.Path.GetDirectoryName(gclass95_0.GetExecutable())));
			return text;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0003760C File Offset: 0x0003580C
		private static void smethod_5(GClass32 gclass32_0, GClass95 gclass95_0)
		{
			string text = System.IO.Path.Combine(GClass88.CachePath, "icons");
			string text2 = System.IO.Path.Combine(text, gclass32_0.TitleId.IdRaw + ".ico");
			System.IO.Directory.CreateDirectory(text);
			using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(gclass32_0.IconUrl)))
			{
				using (FileStream fileStream = System.IO.File.Create(text2))
				{
					GClass124.smethod_0((Bitmap)Image.FromStream(memoryStream), fileStream, 128, false);
				}
			}
			string string_ = GClass128.smethod_4(gclass32_0, gclass95_0);
			GClass128.smethod_6(gclass32_0, GClass30.smethod_2(gclass32_0.Name), Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string_, text2, gclass32_0.Name, "");
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000376E0 File Offset: 0x000358E0
		private static void smethod_6(GClass30 gclass30_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
		{
			string text = System.IO.Path.Combine(string_1, gclass30_0.TitleId.IdRaw + ".lnk");
			string text2 = System.IO.Path.Combine(string_1, string_0 + ".lnk");
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (GClass128.Class111.callSite_0 == null)
			{
				GClass128.Class111.callSite_0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(GClass128)));
			}
			IWshShortcut wshShortcut = GClass128.Class111.callSite_0.Target(GClass128.Class111.callSite_0, wshShell.CreateShortcut(text));
			wshShortcut.Arguments = string_5;
			wshShortcut.Description = string_4;
			wshShortcut.IconLocation = string_3;
			wshShortcut.TargetPath = string_2;
			wshShortcut.WorkingDirectory = System.IO.Path.GetDirectoryName(string_2);
			wshShortcut.Save();
			GClass6.smethod_6(text2);
			Alphaleonis.Win32.Filesystem.File.Move(text, text2);
			GClass128.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000377D4 File Offset: 0x000359D4
		private static void smethod_7(GClass32 gclass32_0, GClass95 gclass95_0)
		{
			GClass128.Class112 @class = new GClass128.Class112();
			@class.gclass32_0 = gclass32_0;
			if (GClass6.smethod_16("Steam"))
			{
				RadMessageBox.Show("Games cannot be added while Steam is running. Please close it and try again");
				return;
			}
			string steamFolder = SteamManager.GetSteamFolder();
			if (!System.IO.Directory.Exists(steamFolder))
			{
				RadMessageBox.Show("Steam is not installed. Cannot proceed.");
				return;
			}
			string[] users = SteamManager.GetUsers(steamFolder);
			if (users.Length == 0)
			{
				RadMessageBox.Show("USB Helper was unable to find any registered Steam user. Make sure you have logged in at least once.");
				return;
			}
			string text = System.IO.Path.Combine(GClass128.String_0, "backup");
			System.IO.Directory.CreateDirectory(GClass128.String_0);
			System.IO.Directory.CreateDirectory(text);
			string text2 = System.IO.Path.Combine(GClass128.String_0, "icon" + @class.gclass32_0.TitleId.IdRaw + ".tmp");
			string text3 = System.IO.Path.Combine(GClass128.String_0, "icon" + @class.gclass32_0.TitleId.IdRaw + ".png");
			new GClass78().method_5(@class.gclass32_0.IconUrl, text2, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
			Image image = Image.FromFile(text2);
			image.Save(text3, ImageFormat.Png);
			image.Dispose();
			GClass6.smethod_6(text2);
			string exe = GClass128.smethod_4(@class.gclass32_0, gclass95_0);
			VDFEntry item = new VDFEntry
			{
				AppName = @class.gclass32_0.Name,
				Exe = exe,
				Icon = text3,
				Tags = new string[]
				{
					"Wii U USB Helper"
				}
			};
			foreach (string text4 in users)
			{
				List<VDFEntry> list = new List<VDFEntry>();
				try
				{
					list = new List<VDFEntry>(SteamManager.ReadShortcuts(text4));
				}
				catch
				{
				}
				IEnumerable<VDFEntry> source = list;
				Func<VDFEntry, bool> predicate;
				if ((predicate = @class.func_0) == null)
				{
					predicate = (@class.func_0 = new Func<VDFEntry, bool>(@class.method_0));
				}
				if (!source.Any(predicate))
				{
					list.Add(item);
					string text5 = text4 + "\\config\\shortcuts.vdf";
					System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(text5));
					if (System.IO.File.Exists(text5))
					{
						System.IO.File.Copy(text5, System.IO.Path.Combine(text, DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString()), true);
					}
					SteamManager.WriteShortcuts(list.ToArray(), text5);
				}
			}
			GClass128.smethod_2(@class.gclass32_0);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000159E5 File Offset: 0x00013BE5
		private static string smethod_8(GClass32 gclass32_0)
		{
			return System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".exe");
		}

		// Token: 0x060008CF RID: 2255
		[DllImport("Shell32.dll")]
		private static extern int SHChangeNotify(int int_0, int int_1, IntPtr intptr_0, IntPtr intptr_1);

		// Token: 0x060008D0 RID: 2256 RVA: 0x00037A38 File Offset: 0x00035C38
		private static string smethod_9(GClass32 gclass32_0)
		{
			string text = null;
			try
			{
				try
				{
					string string_ = string.Format("{0}/res/emulators/banners/{1}.png", Class65.String_2, gclass32_0.TitleId.IdRaw);
					text = System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".banner.png");
					new GClass78().method_5(string_, text, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
					return text;
				}
				catch
				{
					text = null;
				}
				string string_2 = "http://steambanners.booru.org/index.php?page=post&s=list&tags=" + GClass30.smethod_3(GClass30.smethod_3(gclass32_0.Name.ToLower())).Replace(' ', '+');
				string html = new GClass78().method_6(string_2);
				HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
				htmlDocument.LoadHtml(html);
				IEnumerable<string> source = htmlDocument.DocumentNode.Descendants("a").Where(new Func<HtmlNode, bool>(GClass128.<>c.<>c_0.method_2)).Select(new Func<HtmlNode, string>(GClass128.<>c.<>c_0.method_3)).Where(new Func<string, bool>(GClass128.<>c.<>c_0.method_4));
				if (source.Any<string>())
				{
					string html2 = new GClass78().method_6("http://steambanners.booru.org/" + HtmlEntity.DeEntitize(source.ElementAt(0)));
					htmlDocument.LoadHtml(html2);
					string string_3 = htmlDocument.DocumentNode.Descendants("img").Where(new Func<HtmlNode, bool>(GClass128.<>c.<>c_0.method_5)).Select(new Func<HtmlNode, string>(GClass128.<>c.<>c_0.method_6)).Where(new Func<string, bool>(GClass128.<>c.<>c_0.method_7)).ElementAt(0);
					text = System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".banner.png");
					new GClass78().method_5(string_3, text, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x02000149 RID: 329
		[CompilerGenerated]
		private static class Class111
		{
			// Token: 0x04000539 RID: 1337
			public static CallSite<Func<CallSite, object, IWshShortcut>> callSite_0;
		}

		// Token: 0x0200014A RID: 330
		[CompilerGenerated]
		private sealed class Class112
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x00015A9F File Offset: 0x00013C9F
			internal bool method_0(VDFEntry vdfentry_0)
			{
				return vdfentry_0.AppName == this.gclass32_0.Name;
			}

			// Token: 0x0400053A RID: 1338
			public GClass32 gclass32_0;

			// Token: 0x0400053B RID: 1339
			public Func<VDFEntry, bool> func_0;
		}
	}
}
