using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using DokanNet;
using Newtonsoft.Json;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x02000025 RID: 37
	public class GClass15
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0001E050 File Offset: 0x0001C250
		public GClass15(GClass32 gclass32_1)
		{
			this.gclass32_0 = gclass32_1;
			Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.String_2);
			Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.String_3);
			try
			{
				this.InstalledMods = JsonConvert.DeserializeObject<List<string>>(Alphaleonis.Win32.Filesystem.File.ReadAllText(this.String_1));
			}
			catch
			{
				this.InstalledMods = new List<string>();
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00010EBC File Offset: 0x0000F0BC
		public List<string> InstalledMods { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		public string String_0
		{
			get
			{
				return Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.String_2,
					"virtual"
				});
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00010EE2 File Offset: 0x0000F0E2
		public List<Alphaleonis.Win32.Filesystem.FileInfo> List_0
		{
			get
			{
				return new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.String_0).GetFiles("*", SearchOption.AllDirectories).ToList<Alphaleonis.Win32.Filesystem.FileInfo>();
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001E0B8 File Offset: 0x0001C2B8
		public List<string> method_0(string string_0)
		{
			GClass15.Class11 @class = new GClass15.Class11();
			string_0 = string_0.ToUpper();
			@class.gclass14_0 = this.method_2(string_0);
			List<string> list = new List<string>();
			if (!this.method_3(string_0) && @class.gclass14_0 != null)
			{
				foreach (string text in this.InstalledMods)
				{
					GClass14 gclass = this.method_2(text);
					if (gclass != null)
					{
						IEnumerable<string> files = gclass.Files;
						Func<string, bool> predicate;
						if ((predicate = @class.func_0) == null)
						{
							predicate = (@class.func_0 = new Func<string, bool>(@class.method_0));
						}
						if (files.Any(predicate))
						{
							RadMessageBox.Show(string.Format("You cannot add the mod {0} since it conflicts with {1}.", string_0, text));
							return list;
						}
					}
				}
				foreach (string text2 in @class.gclass14_0.RecommendedMods)
				{
					if (this.method_2(text2) != null && !this.method_3(text2) && RadMessageBox.Show(string.Format("It is recommended that you also add the mod {0}. Should I add it for you?", text2), "Add mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						list.Add(text2);
						list.AddRange(this.method_0(text2));
					}
				}
				foreach (string text3 in @class.gclass14_0.RequiredMods)
				{
					if (this.method_2(text3) != null && !this.method_3(text3))
					{
						RadMessageBox.Show(string.Format("The mod additional mod {0} is required. It will be enabled automatically.", text3));
						list.Add(text3);
						list.AddRange(this.method_0(text3));
					}
				}
				list.Add(string_0);
				this.method_8(string_0);
				this.method_6();
				return list;
			}
			return list;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001E280 File Offset: 0x0001C480
		public List<GClass14> method_1()
		{
			List<GClass14> result;
			try
			{
				string value = GClass6.smethod_20("https://cloud.wiiuusbhelper.com/mods/list_mods.php", new NameValueCollection
				{
					{
						"titleid",
						this.gclass32_0.TitleId.IdRaw
					}
				});
				this.list_1 = JsonConvert.DeserializeObject<List<GClass14>>(value);
				result = this.list_1;
			}
			catch (Exception)
			{
				result = new List<GClass14>();
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		public GClass14 method_2(string string_0)
		{
			GClass15.Class12 @class = new GClass15.Class12();
			@class.string_0 = string_0;
			if (this.list_1 == null)
			{
				this.list_1 = this.method_1();
			}
			GClass14 result;
			try
			{
				result = this.list_1.First(new Func<GClass14, bool>(@class.method_0));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00010EFF File Offset: 0x0000F0FF
		public bool method_3(string string_0)
		{
			return this.InstalledMods.Contains(string_0.ToUpper());
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001E348 File Offset: 0x0001C548
		public List<GClass16> method_4()
		{
			GClass15.Class13 @class = new GClass15.Class13();
			@class.gclass15_0 = this;
			@class.list_0 = new List<GClass16>();
			new FrmWait("USB Helper is preparing your mods...", new Action(@class.method_0), new Action<Exception>(GClass15.<>c.<>c_0.method_0));
			return @class.list_0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001E3AC File Offset: 0x0001C5AC
		public bool method_5(string string_0)
		{
			string_0 = string_0.ToUpper();
			if (!this.method_3(string_0))
			{
				return true;
			}
			foreach (string text in this.InstalledMods)
			{
				GClass14 gclass = this.method_2(text);
				if (gclass != null && gclass.RequiredMods.Contains(string_0))
				{
					RadMessageBox.Show(string.Format("The mod {0} is dependant on this mod. Please disable it first.", text));
					return false;
				}
			}
			this.InstalledMods.Remove(string_0);
			this.method_6();
			return true;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00010F12 File Offset: 0x0000F112
		public void method_6()
		{
			Alphaleonis.Win32.Filesystem.File.WriteAllText(this.String_1, JsonConvert.SerializeObject(this.InstalledMods));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001E454 File Offset: 0x0001C654
		public void method_7()
		{
			try
			{
				int driverVersion = Dokan.DriverVersion;
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("dokan1.dll"))
				{
					RadMessageBox.Show("You must install an additional component to use mods. Press 'Ok' to continue.");
					Class65.smethod_7("dokan.exe");
					try
					{
						int driverVersion2 = Dokan.DriverVersion;
						goto IL_58;
					}
					catch (Exception ex2)
					{
						if (ex2.Message.Contains("dokan1.dll"))
						{
							RadMessageBox.Show("USB Helper was not able to detect the required component. Try rebooting your computer.");
							throw;
						}
						goto IL_58;
					}
					goto IL_56;
					IL_58:
					return;
				}
				IL_56:
				throw;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00010F2A File Offset: 0x0000F12A
		private string String_1
		{
			get
			{
				return Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.String_2,
					"installed.json"
				});
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00010F48 File Offset: 0x0000F148
		private string String_2
		{
			get
			{
				return Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					GClass88.CachePath,
					"mods",
					this.gclass32_0.TitleId
				});
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00010F78 File Offset: 0x0000F178
		private string String_3
		{
			get
			{
				return Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.String_2,
					"archives"
				});
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00010F96 File Offset: 0x0000F196
		private void method_8(string string_0)
		{
			if (!this.InstalledMods.Contains(string_0))
			{
				this.InstalledMods.Add(string_0);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00010FB2 File Offset: 0x0000F1B2
		private bool method_9(string string_0)
		{
			return Alphaleonis.Win32.Filesystem.File.Exists(this.method_12(string_0));
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00010FC5 File Offset: 0x0000F1C5
		private void method_10(GClass14 gclass14_0)
		{
			GClass27.smethod_9(gclass14_0.DownloadLink, this.method_12(gclass14_0.Name), string.Format("Downloading {0}", gclass14_0.Name));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001E4D8 File Offset: 0x0001C6D8
		private List<GClass16> method_11(string string_0)
		{
			GClass14 gclass = this.method_2(string_0);
			if (!this.method_9(string_0))
			{
				this.method_10(gclass);
			}
			using (MD5 md = MD5.Create())
			{
				if (!md.ComputeHash(Alphaleonis.Win32.Filesystem.File.ReadAllBytes(this.method_12(string_0))).smethod_5(gclass.Md5.smethod_6()))
				{
					this.method_10(gclass);
				}
			}
			GClass6.smethod_9(Alphaleonis.Win32.Filesystem.File.ReadAllBytes(this.method_12(string_0)), this.String_0);
			List<GClass16> result;
			using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(this.method_12(string_0)))
			{
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read))
				{
					try
					{
						result = JsonConvert.DeserializeObject<List<GClass16>>(zipArchive.Entries.First(new Func<ZipArchiveEntry, bool>(GClass15.<>c.<>c_0.method_1)).smethod_7());
					}
					catch
					{
						result = new List<GClass16>();
					}
				}
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00010FEE File Offset: 0x0000F1EE
		private string method_12(string string_0)
		{
			return Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				this.String_3,
				string_0.ToUpper()
			}) + ".mod";
		}

		// Token: 0x0400006B RID: 107
		[CompilerGenerated]
		private readonly List<string> list_0;

		// Token: 0x0400006C RID: 108
		private readonly GClass32 gclass32_0;

		// Token: 0x0400006D RID: 109
		private List<GClass14> list_1;

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		private sealed class Class11
		{
			// Token: 0x060000E4 RID: 228 RVA: 0x00011017 File Offset: 0x0000F217
			internal bool method_0(string string_0)
			{
				return string_0 != "USBHELPER.MAPPINGS" && this.gclass14_0.Files.Contains(string_0);
			}

			// Token: 0x0400006E RID: 110
			public GClass14 gclass14_0;

			// Token: 0x0400006F RID: 111
			public Func<string, bool> func_0;
		}

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		private sealed class Class12
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x00011039 File Offset: 0x0000F239
			internal bool method_0(GClass14 gclass14_0)
			{
				return gclass14_0.Name.ToUpper() == this.string_0.ToUpper();
			}

			// Token: 0x04000070 RID: 112
			public string string_0;
		}

		// Token: 0x02000028 RID: 40
		[CompilerGenerated]
		private sealed class Class13
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
			internal void method_0()
			{
				GClass6.smethod_5(this.gclass15_0.String_0);
				Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.gclass15_0.String_0);
				foreach (string text in this.gclass15_0.InstalledMods.ToArray())
				{
					try
					{
						this.list_0.AddRange(this.gclass15_0.method_11(text));
					}
					catch (Exception value)
					{
						this.gclass15_0.InstalledMods.Remove(text);
						this.gclass15_0.method_6();
						Console.WriteLine(value);
					}
				}
			}

			// Token: 0x04000071 RID: 113
			public GClass15 gclass15_0;

			// Token: 0x04000072 RID: 114
			public List<GClass16> list_0;
		}
	}
}
