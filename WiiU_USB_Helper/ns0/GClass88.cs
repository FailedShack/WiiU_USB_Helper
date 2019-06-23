using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x020000BE RID: 190
	public static class GClass88
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000132BB File Offset: 0x000114BB
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000132C2 File Offset: 0x000114C2
		public static string CachePath { get; private set; }

		// Token: 0x060004D1 RID: 1233 RVA: 0x000132CA File Offset: 0x000114CA
		public static void smethod_0(string string_1)
		{
			if (GClass88.smethod_1(string_1))
			{
				GClass6.smethod_6(string_1.smethod_11());
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000132DF File Offset: 0x000114DF
		public static bool smethod_1(string string_1)
		{
			return File.Exists(string_1.smethod_11());
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0002A310 File Offset: 0x00028510
		public static byte[] smethod_2(Uri uri_0, TimeSpan timeSpan_0)
		{
			byte[] result;
			try
			{
				string text = uri_0.smethod_14().smethod_11();
				if (text.smethod_15(timeSpan_0))
				{
					try
					{
						byte[] array = new GClass78().method_2(uri_0.ToString());
						File.WriteAllBytes(text, array);
						return array;
					}
					catch
					{
						return File.Exists(text) ? File.ReadAllBytes(text) : null;
					}
				}
				result = File.ReadAllBytes(text);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002A390 File Offset: 0x00028590
		public static void smethod_3(Uri uri_0, TimeSpan timeSpan_0, Action<GClass87> action_0, Action action_1)
		{
			GClass88.Class64 @class = new GClass88.Class64();
			@class.uri_0 = uri_0;
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			@class.string_0 = @class.uri_0.smethod_14().smethod_11();
			if (@class.string_0.smethod_15(timeSpan_0))
			{
				Task.Run(new Action(@class.method_0));
				return;
			}
			if (new FileInfo(@class.string_0).Length > 0L)
			{
				@class.action_0(new GClass87(File.ReadAllBytes(@class.string_0), @class.string_0, true));
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000132EC File Offset: 0x000114EC
		public static byte[] smethod_4(string string_1)
		{
			if (GClass88.smethod_1(string_1))
			{
				return File.ReadAllBytes(string_1.smethod_11());
			}
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00013303 File Offset: 0x00011503
		public static byte[] smethod_5(Uri uri_0)
		{
			return GClass88.smethod_4(uri_0.smethod_14());
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00013310 File Offset: 0x00011510
		public static DateTime smethod_6(string string_1)
		{
			return new FileInfo(string_1.smethod_11()).LastWriteTime;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00013322 File Offset: 0x00011522
		public static string[] smethod_7(string string_1)
		{
			if (GClass88.smethod_1(string_1))
			{
				return File.ReadAllLines(string_1.smethod_11());
			}
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00013339 File Offset: 0x00011539
		public static string smethod_8(string string_1)
		{
			return BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.Unicode.GetBytes(string_1))).Replace("-", "");
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00013364 File Offset: 0x00011564
		public static void smethod_9(Uri uri_0, byte[] byte_0)
		{
			File.WriteAllBytes(uri_0.smethod_14().smethod_11(), byte_0);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00013377 File Offset: 0x00011577
		public static void smethod_10(string string_1, string[] string_2)
		{
			File.WriteAllLines(string_1.smethod_11(), string_2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00013385 File Offset: 0x00011585
		internal static string smethod_11(this string string_1)
		{
			return GClass88.smethod_16(string_1);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001338D File Offset: 0x0001158D
		internal static string smethod_12(string string_1)
		{
			if (GClass88.smethod_1(string_1))
			{
				return File.ReadAllText(string_1.smethod_11());
			}
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000133A4 File Offset: 0x000115A4
		internal static void smethod_13(string string_1)
		{
			GClass88.CachePath = string_1;
			if (!Directory.Exists(GClass88.CachePath))
			{
				Directory.CreateDirectory(GClass88.CachePath);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000133C3 File Offset: 0x000115C3
		internal static string smethod_14(this Uri uri_0)
		{
			return GClass88.smethod_8(uri_0.AbsoluteUri);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000133D0 File Offset: 0x000115D0
		private static bool smethod_15(this string string_1, TimeSpan timeSpan_0)
		{
			return !File.Exists(string_1) || DateTime.Now - new FileInfo(string_1).LastWriteTime > timeSpan_0;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000133F7 File Offset: 0x000115F7
		private static string smethod_16(string string_1)
		{
			return Path.Combine(GClass88.CachePath, string_1);
		}

		// Token: 0x0400030A RID: 778
		[CompilerGenerated]
		private static string string_0;

		// Token: 0x020000BF RID: 191
		[CompilerGenerated]
		private sealed class Class64
		{
			// Token: 0x060004E3 RID: 1251 RVA: 0x0002A428 File Offset: 0x00028628
			internal void method_0()
			{
				GClass78 gclass = new GClass78();
				try
				{
					byte[] array = gclass.method_2(this.uri_0.ToString());
					File.WriteAllBytes(this.string_0, array);
					this.action_0(new GClass87(array, this.string_0, false));
				}
				catch
				{
					GClass6.smethod_6(this.string_0);
					Action action = this.action_1;
					if (action != null)
					{
						action();
					}
				}
			}

			// Token: 0x0400030B RID: 779
			public Uri uri_0;

			// Token: 0x0400030C RID: 780
			public string string_0;

			// Token: 0x0400030D RID: 781
			public Action<GClass87> action_0;

			// Token: 0x0400030E RID: 782
			public Action action_1;
		}
	}
}
