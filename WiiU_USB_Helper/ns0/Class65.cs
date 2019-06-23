using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using NusHelper.Server;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x020000C5 RID: 197
	internal static class Class65
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001354F File Offset: 0x0001174F
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00013556 File Offset: 0x00011756
		public static string RootDomain { get; set; } = "wiiuusbhelper.com";

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001355E File Offset: 0x0001175E
		public static string String_0
		{
			get
			{
				return "https://application." + Class65.RootDomain;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001356F File Offset: 0x0001176F
		public static string String_1
		{
			get
			{
				return "https://cloud." + Class65.RootDomain;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00013580 File Offset: 0x00011780
		public static string String_2
		{
			get
			{
				return "https://cdn." + Class65.RootDomain;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00013591 File Offset: 0x00011791
		public static string String_3
		{
			get
			{
				return "https://registration." + Class65.RootDomain;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000135A2 File Offset: 0x000117A2
		public static string String_4
		{
			get
			{
				return "https://support." + Class65.RootDomain;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000135B3 File Offset: 0x000117B3
		private static string String_5
		{
			get
			{
				return string.Format("{0}/res/db/datav6.enc", Class65.String_2);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002A7AC File Offset: 0x000289AC
		public static List<GClass90> smethod_0()
		{
			List<GClass90> result;
			try
			{
				result = JsonConvert.DeserializeObject<List<GClass90>>(new GClass78().method_6(string.Format("{0}/getFaq.php", Class65.String_4)));
			}
			catch
			{
				result = new List<GClass90>();
			}
			return result;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000135C4 File Offset: 0x000117C4
		public static string smethod_1(string string_2, int int_1)
		{
			return string.Format("{0}/proxy.php?url=", Class65.String_0) + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_2)) + "&cache=" + int_1.ToString();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002A7F4 File Offset: 0x000289F4
		public static List<string> smethod_2()
		{
			List<string> result;
			try
			{
				result = new List<string>(new GClass78().method_6(string.Format("{0}/res/db/forceCFW.txt", Class65.String_2)).ToUpper().Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries));
			}
			catch
			{
				result = new List<string>();
			}
			return result;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002A858 File Offset: 0x00028A58
		internal static void smethod_3(GClass95 gclass95_0)
		{
			Class65.Class66 @class = new Class65.Class66();
			@class.gclass95_0 = gclass95_0;
			try
			{
				Class65.Class67 class2 = new Class65.Class67();
				class2.class66_0 = @class;
				class2.frmWait_0 = new FrmWait("USB Helper is fetching some additional files...", true);
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += class2.method_0;
				webClient.DownloadDataCompleted += class2.method_1;
				webClient.DownloadDataAsync(new Uri(class2.class66_0.gclass95_0.String_0));
				class2.frmWait_0.ShowDialog();
			}
			catch
			{
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000135F6 File Offset: 0x000117F6
		internal static void smethod_4()
		{
			if (!GClass27.smethod_2("xinput1_3.dll") || (Environment.Is64BitOperatingSystem && !GClass27.smethod_3("xinput1_3.dll")))
			{
				Class65.smethod_7("dxwebsetup.exe");
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		private static void smethod_5(string string_2)
		{
			try
			{
				GClass6.smethod_6(string_2);
			}
			catch
			{
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00013621 File Offset: 0x00011821
		internal static void smethod_6()
		{
			Class65.smethod_8("msvcr120.dll", "vcredist_x86.exe", "vcredist_x64.exe");
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002A91C File Offset: 0x00028B1C
		internal static void smethod_7(string string_2)
		{
			Class65.Class68 @class = new Class65.Class68();
			@class.string_0 = Path.Combine(Path.GetTempPath(), string_2);
			GClass27.smethod_9(string.Format("{0}/res/prerequisites/{1}", Class65.String_2, string_2), @class.string_0, null);
			Process process = new Process();
			process.StartInfo.FileName = @class.string_0;
			process.EnableRaisingEvents = true;
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.Verb = "runas";
			process.Exited += @class.method_0;
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00013637 File Offset: 0x00011837
		private static void smethod_8(string string_2, string string_3, string string_4)
		{
			if (!GClass27.smethod_2(string_2) || (Environment.Is64BitOperatingSystem && !GClass27.smethod_3(string_2)))
			{
				Class65.smethod_7(string_3);
				Class65.smethod_7(string_4);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0001365C File Offset: 0x0001185C
		internal static void smethod_9()
		{
			Class65.smethod_8("msvcr110.dll", "vcredist_x862012.exe", "vcredist_x642012.exe");
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00013672 File Offset: 0x00011872
		internal static void smethod_10()
		{
			if (!GClass27.smethod_2("msvcp140.dll"))
			{
				Class65.smethod_7("vcredist_x642015.exe");
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001368A File Offset: 0x0001188A
		public static string smethod_11()
		{
			return new GClass78().method_6(string.Format("{0}/res/txt/changelog.txt", Class65.String_2));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000136A5 File Offset: 0x000118A5
		public static string smethod_12()
		{
			return new GClass78().method_6(string.Format("{0}/getContributors.php", Class65.String_3));
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000136C0 File Offset: 0x000118C0
		public static void smethod_13()
		{
			if (Class65.zipArchive_0 == null)
			{
				return;
			}
			Class65.zipArchive_0.Dispose();
			Class65.zipArchive_0 = null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0002A9B4 File Offset: 0x00028BB4
		public static string smethod_14(string string_2, string string_3)
		{
			Class65.Class69 @class = new Class65.Class69();
			@class.frmWait_0 = new FrmWait("USB Helper is uploading data...", true);
			WebClient webClient = new WebClient();
			@class.string_0 = "";
			webClient.UploadProgressChanged += @class.method_0;
			webClient.UploadFileCompleted += @class.method_1;
			webClient.UploadFileAsync(new Uri(string_3), string_2);
			@class.frmWait_0.ShowDialog();
			return @class.string_0;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002AA2C File Offset: 0x00028C2C
		private static byte[] smethod_15()
		{
			Class65.int_0++;
			byte[] array = new byte[16];
			Random random = new Random(18211852 * Class65.int_0 * 2);
			for (int i = 0; i < 100000 * Class65.int_0; i++)
			{
				random.NextBytes(array);
			}
			using (MD5 md = MD5.Create())
			{
				for (int j = 0; j < 10000 * Class65.int_0 * Class65.int_0; j++)
				{
					array = md.ComputeHash(array);
				}
			}
			return array;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		private static void smethod_16(MemoryStream memoryStream_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Key = Class65.smethod_15();
				aesCryptoServiceProvider.IV = Class65.smethod_15();
				byte[] buffer = new byte[512];
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream_0, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
				{
					int num;
					do
					{
						num = cryptoStream.Read(buffer, 0, 512);
						memoryStream.Write(buffer, 0, num);
						Class65.int_0 = 0;
					}
					while (num > 0);
				}
				for (int i = 0; i < 16; i++)
				{
					aesCryptoServiceProvider.IV[i] = 0;
					aesCryptoServiceProvider.Key[i] = 0;
				}
			}
			Class65.zipArchive_0 = new ZipArchive(memoryStream);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002ABA4 File Offset: 0x00028DA4
		private static void smethod_17(string string_2)
		{
			string text = Path.Combine(GClass88.CachePath, "etag");
			string text2 = Path.Combine(GClass88.CachePath, "db");
			using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(Class65.String_5)))
			{
				Class65.smethod_16(memoryStream);
			}
			GClass6.smethod_6(text);
			GClass6.smethod_6(text2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002AC14 File Offset: 0x00028E14
		private static void smethod_18()
		{
			if (Class65.zipArchive_0 != null)
			{
				return;
			}
			string path = Path.Combine(GClass88.CachePath, "etag");
			string text = Path.Combine(GClass88.CachePath, "db");
			string text2 = GClass6.smethod_14(Class65.String_5);
			if (File.Exists(path) && File.Exists(text))
			{
				if (!(File.ReadAllText(path) != text2) && new FileInfo(text).Length != 0L)
				{
					using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(text)))
					{
						Class65.smethod_16(memoryStream);
						return;
					}
				}
				Class65.smethod_17(text2);
				return;
			}
			Class65.smethod_17(text2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002ACBC File Offset: 0x00028EBC
		public static void smethod_19(string string_2)
		{
			Class65.smethod_18();
			foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class65.zipArchive_0.GetEntry(string_2).smethod_7()))
			{
				if (!GClass28.dictionary_1.ContainsKey(dbRow.TitleId))
				{
					GClass28.dictionary_1.Add(dbRow.TitleId, new GClass80.GStruct4
					{
						dataSize_0 = dbRow.Size,
						titleId_0 = dbRow.TitleId
					});
				}
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002AD5C File Offset: 0x00028F5C
		public static void smethod_20(string string_2)
		{
			Class65.smethod_18();
			foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class65.zipArchive_0.GetEntry(string_2).smethod_7()).Where(new Func<DbRow, bool>(Class65.<>c.<>c_0.method_0)))
			{
				GClass28.dictionary_2.Add(dbRow.TitleId, dbRow);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002ADEC File Offset: 0x00028FEC
		public static void smethod_21(string string_2)
		{
			Class65.smethod_18();
			foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class65.zipArchive_0.GetEntry(string_2).smethod_7()))
			{
				if (!GClass28.dictionary_3.ContainsKey(dbRow.TitleId))
				{
					GClass28.dictionary_3.Add(dbRow.TitleId, new List<GClass80.GStruct5>());
				}
				GClass28.dictionary_3[dbRow.TitleId].Add(new GClass80.GStruct5
				{
					dataSize_0 = dbRow.Size,
					titleId_0 = dbRow.TitleId,
					string_0 = dbRow.Version
				});
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000136DA File Offset: 0x000118DA
		public static string[] smethod_22()
		{
			return new GClass78().method_6(string.Format("{0}/res/db/blackList.txt", Class65.String_2)).Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x04000328 RID: 808
		private static readonly List<string> list_0 = new List<string>();

		// Token: 0x04000329 RID: 809
		private static ZipArchive zipArchive_0;

		// Token: 0x0400032A RID: 810
		[CompilerGenerated]
		private static string string_0;

		// Token: 0x0400032B RID: 811
		private const string string_1 = "https://";

		// Token: 0x0400032C RID: 812
		private static Dictionary<string, IPAddress> dictionary_0 = new Dictionary<string, IPAddress>();

		// Token: 0x0400032D RID: 813
		private static object object_0 = new object();

		// Token: 0x0400032E RID: 814
		private static int int_0 = 0;

		// Token: 0x020000C6 RID: 198
		[CompilerGenerated]
		private sealed class Class66
		{
			// Token: 0x0400032F RID: 815
			public GClass95 gclass95_0;
		}

		// Token: 0x020000C7 RID: 199
		[CompilerGenerated]
		private sealed class Class67
		{
			// Token: 0x0600052F RID: 1327 RVA: 0x00013709 File Offset: 0x00011909
			internal void method_0(object sender, DownloadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x0002AEB4 File Offset: 0x000290B4
			internal void method_1(object sender, DownloadDataCompletedEventArgs e)
			{
				GClass6.smethod_9(e.Result, this.class66_0.gclass95_0.String_4);
				if (!Class65.list_0.Contains(this.class66_0.gclass95_0.Name))
				{
					Class65.list_0.Add(this.class66_0.gclass95_0.Name);
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x04000330 RID: 816
			public FrmWait frmWait_0;

			// Token: 0x04000331 RID: 817
			public Class65.Class66 class66_0;
		}

		// Token: 0x020000C8 RID: 200
		[CompilerGenerated]
		private sealed class Class68
		{
			// Token: 0x06000532 RID: 1330 RVA: 0x0001371C File Offset: 0x0001191C
			internal void method_0(object sender, EventArgs e)
			{
				Class65.smethod_5(this.string_0);
			}

			// Token: 0x04000332 RID: 818
			public string string_0;
		}

		// Token: 0x020000C9 RID: 201
		[CompilerGenerated]
		private sealed class Class69
		{
			// Token: 0x06000534 RID: 1332 RVA: 0x00013729 File Offset: 0x00011929
			internal void method_0(object sender, UploadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(2 * e.ProgressPercentage);
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0001373E File Offset: 0x0001193E
			internal void method_1(object sender, UploadFileCompletedEventArgs e)
			{
				if (e.Error != null)
				{
					RadMessageBox.Show(e.Error.ToString());
				}
				this.string_0 = Encoding.UTF8.GetString(e.Result);
				this.frmWait_0.method_0();
			}

			// Token: 0x04000333 RID: 819
			public FrmWait frmWait_0;

			// Token: 0x04000334 RID: 820
			public string string_0;
		}
	}
}
