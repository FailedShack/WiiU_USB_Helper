using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using NusHelper;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x0200000C RID: 12
	public static class GClass6
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0001AB7C File Offset: 0x00018D7C
		public static bool smethod_0(string string_0, byte[] byte_0, HashAlgorithm hashAlgorithm_0)
		{
			bool result;
			using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(string_0))
			{
				byte[] byte_ = hashAlgorithm_0.ComputeHash(fileStream);
				hashAlgorithm_0.Dispose();
				result = byte_0.smethod_5(byte_);
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		public static bool smethod_1(string string_0)
		{
			bool result;
			try
			{
				Alphaleonis.Win32.Filesystem.Directory.GetAccessControl(string_0);
				result = true;
			}
			catch (UnauthorizedAccessException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00010983 File Offset: 0x0000EB83
		public static bool smethod_2(string string_0)
		{
			return !string.IsNullOrEmpty(string_0) && Alphaleonis.Win32.Filesystem.Directory.Exists(string_0) && GClass6.smethod_1(string_0);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		public static bool smethod_3(string string_0)
		{
			bool result;
			try
			{
				result = (string_0.Substring(0, 4) == "http");
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0001099D File Offset: 0x0000EB9D
		public static bool smethod_4(string string_0)
		{
			return Regex.IsMatch(string_0, "\\A\\b[0-9a-fA-F]+\\b\\Z");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000109AA File Offset: 0x0000EBAA
		public static void smethod_5(string string_0)
		{
			if (Alphaleonis.Win32.Filesystem.Directory.Exists(string_0))
			{
				Alphaleonis.Win32.Filesystem.Directory.Delete(string_0, true);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000109BB File Offset: 0x0000EBBB
		public static void smethod_6(string string_0)
		{
			if (Alphaleonis.Win32.Filesystem.File.Exists(string_0))
			{
				Alphaleonis.Win32.Filesystem.File.Delete(string_0);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0001AC2C File Offset: 0x00018E2C
		public static ulong smethod_7(string string_0)
		{
			ulong num = 0UL;
			if (!Alphaleonis.Win32.Filesystem.Directory.Exists(string_0))
			{
				return 0UL;
			}
			try
			{
				foreach (string fileName in Alphaleonis.Win32.Filesystem.Directory.GetFiles(string_0, "*.*", SearchOption.AllDirectories))
				{
					num += (ulong)new Alphaleonis.Win32.Filesystem.FileInfo(fileName).Length;
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000109CB File Offset: 0x0000EBCB
		public static void smethod_8(string string_0, string string_1)
		{
			GClass6.smethod_9(new GClass78().method_2(string_0), string_1);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0001AC8C File Offset: 0x00018E8C
		public static void smethod_9(byte[] byte_0, string string_0)
		{
			using (MemoryStream memoryStream = new MemoryStream(byte_0))
			{
				using (ZipArchive zipArchive = new ZipArchive(memoryStream))
				{
					zipArchive.smethod_0(string_0, true);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		public static bool smethod_10(Rectangle rectangle_0)
		{
			GClass6.Class2 @class = new GClass6.Class2();
			@class.rectangle_0 = rectangle_0;
			return Screen.AllScreens.Any(new Func<Screen, bool>(@class.method_0));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0001AD14 File Offset: 0x00018F14
		public static Color smethod_11(Bitmap bitmap_0)
		{
			if (bitmap_0 == null)
			{
				return Color.Black;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < bitmap_0.Height / 2; j++)
				{
					Color pixel = bitmap_0.GetPixel(i, j);
					num += (int)pixel.R;
					num2 += (int)pixel.G;
					num3 += (int)pixel.B;
				}
			}
			num /= bitmap_0.Height / 2 * 10;
			num2 /= bitmap_0.Height / 2 * 10;
			num3 /= bitmap_0.Height / 2 * 10;
			return Color.FromArgb(num, num2, num3);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		public static string smethod_12(TimeSpan timeSpan_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (timeSpan_0.Days > 0)
			{
				stringBuilder.Append(string.Format("{0}d ", timeSpan_0.Days));
			}
			if (timeSpan_0.Hours > 0)
			{
				stringBuilder.Append(string.Format("{0}h ", timeSpan_0.Hours));
			}
			if (timeSpan_0.Minutes > 0)
			{
				stringBuilder.Append(string.Format("{0}m ", timeSpan_0.Minutes));
			}
			if (timeSpan_0.Seconds > 0)
			{
				stringBuilder.Append(string.Format("{0}s ", timeSpan_0.Seconds));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000109DE File Offset: 0x0000EBDE
		public static string smethod_13(DataSize dataSize_0, GStruct3 gstruct3_0)
		{
			if (gstruct3_0.ulong_0 > 0UL)
			{
				return GClass6.smethod_12(GStruct3.smethod_1(dataSize_0, gstruct3_0));
			}
			return "Not available at the moment.";
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0001AE68 File Offset: 0x00019068
		public static string smethod_14(string string_0)
		{
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.Method = "HEAD";
			string result;
			using (WebResponse response = webRequest.GetResponse())
			{
				result = response.Headers["etag"];
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0001AEBC File Offset: 0x000190BC
		public static long smethod_15(string string_0)
		{
			long result;
			try
			{
				WebRequest webRequest = WebRequest.Create(string_0);
				webRequest.Method = "HEAD";
				using (WebResponse response = webRequest.GetResponse())
				{
					result = response.ContentLength;
				}
			}
			catch
			{
				result = -1L;
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000109FC File Offset: 0x0000EBFC
		public static bool smethod_16(string string_0)
		{
			return Process.GetProcessesByName(string_0).Length != 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0001AF18 File Offset: 0x00019118
		public static Image smethod_17(Image image_0, Image image_1, bool bool_0 = true)
		{
			Bitmap bitmap = new Bitmap(48, 48);
			Image result;
			try
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
					graphics.DrawImage(image_0, new PointF(0f, 0f));
					graphics.DrawImage(image_1, new PointF(0f, 0f));
					graphics.Save();
				}
				if (bool_0)
				{
					image_0.Dispose();
				}
				result = bitmap;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0001AFAC File Offset: 0x000191AC
		public static string smethod_18()
		{
			string text = "---SYSLOG---" + Environment.NewLine;
			text = text + GClass1.smethod_17() + Environment.NewLine;
			text = text + (Environment.Is64BitProcess ? "64 bits process" : "32 bits process") + Environment.NewLine;
			text = text + GClass1.smethod_18() + Environment.NewLine;
			text = text + GClass1.smethod_10() + Environment.NewLine;
			text = text + Screen.PrimaryScreen.WorkingArea.ToString() + Environment.NewLine;
			foreach (Alphaleonis.Win32.Filesystem.DriveInfo driveInfo in Alphaleonis.Win32.Filesystem.DriveInfo.GetDrives())
			{
				text = string.Concat(new object[]
				{
					text,
					"-",
					driveInfo.Name,
					" ",
					driveInfo.TotalSize / 1000000000L,
					"GB ",
					driveInfo.AvailableFreeSpace / 1000000000L,
					"GB",
					Environment.NewLine
				});
			}
			foreach (PropertyInfo propertyInfo in Settings.Default.GetType().GetProperties())
			{
				try
				{
					string str = string.Concat(new object[]
					{
						propertyInfo.Name,
						":",
						propertyInfo.GetValue(Settings.Default),
						Environment.NewLine
					});
					text += str;
				}
				catch
				{
				}
			}
			return text;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0001B144 File Offset: 0x00019344
		public static void smethod_19(string string_0, NameValueCollection nameValueCollection_0)
		{
			try
			{
				new WebClient().UploadValuesAsync(new Uri(string_0), nameValueCollection_0);
			}
			catch
			{
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0001B178 File Offset: 0x00019378
		public static string smethod_20(string string_0, NameValueCollection nameValueCollection_0)
		{
			string result;
			try
			{
				result = Encoding.UTF8.GetString(new WebClient().UploadValues(new Uri(string_0), nameValueCollection_0));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400000B RID: 11
		public const int int_0 = 3000000;

		// Token: 0x0200000D RID: 13
		[CompilerGenerated]
		private sealed class Class2
		{
			// Token: 0x06000043 RID: 67 RVA: 0x0001B1BC File Offset: 0x000193BC
			internal bool method_0(Screen screen_0)
			{
				return screen_0.WorkingArea.IntersectsWith(this.rectangle_0);
			}

			// Token: 0x0400000C RID: 12
			public Rectangle rectangle_0;
		}
	}
}
