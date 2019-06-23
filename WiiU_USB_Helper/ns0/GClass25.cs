using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ns0
{
	// Token: 0x0200004A RID: 74
	public static class GClass25
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00022544 File Offset: 0x00020744
		public static Image smethod_0(this Image image_0, int int_0, Color color_0, bool bool_0)
		{
			int_0 *= 2;
			Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
			Image result;
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(color_0);
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				TextureBrush brush = new TextureBrush(image_0);
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddArc(0, 0, int_0, int_0, 180f, 90f);
				graphicsPath.AddArc(bitmap.Width - int_0, 0, int_0, int_0, 270f, 90f);
				graphicsPath.AddArc(bitmap.Width - int_0, bitmap.Height - int_0, int_0, int_0, 0f, 90f);
				graphicsPath.AddArc(0, bitmap.Height - int_0, int_0, int_0, 90f, 90f);
				graphics.FillPath(brush, graphicsPath);
				if (bool_0)
				{
					image_0.Dispose();
				}
				result = bitmap;
			}
			return result;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0002262C File Offset: 0x0002082C
		public static Image smethod_1(this Image image_0, int int_0, int int_1)
		{
			double val = (double)int_0 / (double)image_0.Width;
			double val2 = (double)int_1 / (double)image_0.Height;
			double num = Math.Min(val, val2);
			int width = (int)((double)image_0.Width * num);
			int height = (int)((double)image_0.Height * num);
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image_0, 0, 0, width, height);
			}
			return bitmap;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00011920 File Offset: 0x0000FB20
		public static ulong smethod_2(this ulong ulong_0, uint uint_0)
		{
			if (ulong_0 % (ulong)uint_0 == 0UL)
			{
				return ulong_0;
			}
			return (ulong_0 / (ulong)uint_0 + 1UL) * (ulong)uint_0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000226AC File Offset: 0x000208AC
		public static byte[] smethod_3(this Stream stream_0, int int_0, Action<int> action_0 = null)
		{
			byte[] array = new byte[int_0];
			int num = 0;
			do
			{
				int num2 = stream_0.Read(array, num, int_0 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				if (action_0 != null)
				{
					action_0(num2);
				}
			}
			while (num < int_0);
			return array;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000226E8 File Offset: 0x000208E8
		public static void smethod_4(this Stream stream_0, byte[] byte_0, int int_0)
		{
			int num = 0;
			do
			{
				int num2 = stream_0.Read(byte_0, num, int_0 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
			}
			while (num < int_0);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00022710 File Offset: 0x00020910
		public static bool smethod_5(this byte[] byte_0, byte[] byte_1)
		{
			if (byte_0 == byte_1)
			{
				return true;
			}
			if (byte_0.Length != byte_1.Length)
			{
				return false;
			}
			for (long num = 0L; num < (long)byte_0.Length; num += 1L)
			{
				if (checked(byte_0[(int)((IntPtr)num)] != byte_1[(int)((IntPtr)num)]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00022750 File Offset: 0x00020950
		public static byte[] smethod_6(this string string_0)
		{
			int length = string_0.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00022790 File Offset: 0x00020990
		public static string smethod_7(this ZipArchiveEntry zipArchiveEntry_0)
		{
			string result;
			using (TextReader textReader = new StreamReader(zipArchiveEntry_0.Open()))
			{
				result = textReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00011934 File Offset: 0x0000FB34
		public static string smethod_8(this string string_0)
		{
			return Regex.Replace(string_0, "<[^>]*>", "");
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000227D0 File Offset: 0x000209D0
		public static string smethod_9(this string string_0, string[] string_1, string string_2)
		{
			GClass25.Class30 @class = new GClass25.Class30();
			@class.string_0 = string_2;
			return string_1.Aggregate(string_0, new Func<string, string, string>(@class.method_0));
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00022800 File Offset: 0x00020A00
		public static string smethod_10(this string string_0, char[] char_0, char char_1)
		{
			GClass25.Class31 @class = new GClass25.Class31();
			@class.char_0 = char_1;
			return char_0.Aggregate(string_0, new Func<string, char, string>(@class.method_0));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00011946 File Offset: 0x0000FB46
		public static string smethod_11(this string string_0)
		{
			return string_0.Replace(string.Format("{0}{1}", Environment.NewLine, Environment.NewLine), string.Format("{0}", Environment.NewLine));
		}

		// Token: 0x0200004B RID: 75
		[CompilerGenerated]
		private sealed class Class30
		{
			// Token: 0x060001D3 RID: 467 RVA: 0x00011971 File Offset: 0x0000FB71
			internal string method_0(string string_1, string string_2)
			{
				return string_1.Replace(string_2, this.string_0);
			}

			// Token: 0x04000128 RID: 296
			public string string_0;
		}

		// Token: 0x0200004C RID: 76
		[CompilerGenerated]
		private sealed class Class31
		{
			// Token: 0x060001D5 RID: 469 RVA: 0x00011980 File Offset: 0x0000FB80
			internal string method_0(string string_0, char char_1)
			{
				return string_0.Replace(char_1, this.char_0);
			}

			// Token: 0x04000129 RID: 297
			public char char_0;
		}
	}
}
