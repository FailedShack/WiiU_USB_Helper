using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x020000E5 RID: 229
	internal static class Class79
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		public static void smethod_0(byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5, bool bool_1)
		{
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.Padding = PaddingMode.None;
				rijndaelManaged.KeySize = 128;
				rijndaelManaged.BlockSize = 128;
				rijndaelManaged.Key = byte_2;
				rijndaelManaged.IV = byte_3;
				if (bool_1)
				{
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor())
					{
						cryptoTransform.TransformBlock(byte_4, 0, byte_4.Length, byte_5, 0);
						goto IL_7F;
					}
				}
				using (ICryptoTransform cryptoTransform2 = rijndaelManaged.CreateDecryptor())
				{
					cryptoTransform2.TransformBlock(byte_4, 0, byte_4.Length, byte_5, 0);
				}
				IL_7F:
				rijndaelManaged.Clear();
			}
			catch (CryptographicException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0002EB68 File Offset: 0x0002CD68
		public static long[] smethod_1(string string_2, string string_3, bool bool_1)
		{
			long[] result;
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_2)))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(string_3)))
				{
					long[] array = new long[2];
					binaryWriter.Write(binaryReader.ReadBytes(262144));
					byte[] array2 = binaryReader.ReadBytes(32);
					binaryWriter.Write(array2);
					int[,] array3 = new int[2, 4];
					for (byte b = 0; b < 4; b += 1)
					{
						array3[0, (int)b] = (int)array2[(int)(8 * b)] * 16777216 + (int)array2[(int)(1 + 8 * b)] * 65536 + (int)array2[(int)(2 + 8 * b)] * 256 + (int)array2[(int)(3 + 8 * b)];
						if (array3[0, (int)b] == 0)
						{
							array3[1, (int)b] = 0;
						}
						else
						{
							array3[1, (int)b] = ((int)array2[(int)(4 + 8 * b)] * 16777216 + (int)array2[(int)(5 + 8 * b)] * 65536 + (int)array2[(int)(6 + 8 * b)] * 256 + (int)array2[(int)(7 + 8 * b)]) * 4;
						}
					}
					Console.WriteLine();
					array3 = Class79.smethod_6(array3, 4);
					byte[][] array4 = new byte[4][];
					List<int> list = new List<int>();
					long num = 262176L;
					int num2 = 0;
					for (int i = 0; i < 4; i++)
					{
						if (array3[0, i] != 0)
						{
							binaryWriter.Write(binaryReader.ReadBytes((int)((long)array3[1, i] - num)));
							num += (long)array3[1, i] - num;
							array4[i] = binaryReader.ReadBytes(8 * array3[0, i]);
							num += (long)(8 * array3[0, i]);
							for (int j = 0; j < array3[0, i]; j++)
							{
								if (array4[i][7 + 8 * j] == 0)
								{
									list.Add(((int)array4[i][8 * j] * 16777216 + (int)array4[i][1 + 8 * j] * 65536 + (int)array4[i][2 + 8 * j] * 256 + (int)array4[i][3 + 8 * j]) * 4);
									num2++;
								}
							}
							binaryWriter.Write(array4[i]);
						}
					}
					Console.WriteLine();
					int[] array5 = list.ToArray();
					array5 = Class79.smethod_7(array5, array5.Length);
					array[0] = (long)array5[0];
					byte[] array6 = new byte[16];
					int num3 = 0;
					byte[] array7 = new byte[31744];
					byte[] array8 = new byte[31744];
					byte[] array9 = new byte[130396];
					byte[] array10 = new byte[32768];
					long num4 = 0L;
					int num5 = 0;
					for (int k = 0; k < array5.Length; k++)
					{
						long num6 = (long)array5[k] - num;
						long num7;
						do
						{
							num7 = num6 - num4;
							int num8 = binaryReader.BaseStream.Read(array10, 0, ((long)array10.Length >= num7) ? ((int)num7) : array10.Length);
							binaryWriter.BaseStream.Write(array10, 0, num8);
							num4 += (long)num8;
						}
						while (num7 > 0L);
						num += (long)array5[k] - num;
						binaryWriter.Write(binaryReader.ReadBytes(447));
						byte[] array11 = binaryReader.ReadBytes(16);
						binaryWriter.Write(array11);
						binaryWriter.Write(binaryReader.ReadBytes(13));
						byte[] array12 = binaryReader.ReadBytes(8);
						binaryWriter.Write(array12);
						for (int l = 0; l < 16; l++)
						{
							if (l < 8)
							{
								array6[l] = array12[l];
							}
							else
							{
								array6[l] = 0;
							}
						}
						binaryWriter.Write(binaryReader.ReadBytes(192));
						binaryReader.BaseStream.Read(array9, 0, array9.Length);
						long num9 = 4L * (long)((int)array9[24] * 16777216 + (int)array9[25] * 65536 + (int)array9[26] * 256 + (int)array9[27]);
						binaryWriter.Write(array9);
						num += 131072L;
						num += num9;
						byte[] array13 = new byte[16];
						Class79.smethod_0(Class79.byte_1, array6, array11, array13, false);
						while (num9 >= 32768L)
						{
							if (num3 == 8000)
							{
								num3 = 0;
								num5++;
							}
							num3++;
							binaryWriter.Write(binaryReader.ReadBytes(976));
							array6 = binaryReader.ReadBytes(16);
							binaryWriter.Write(array6);
							binaryWriter.Write(binaryReader.ReadBytes(32));
							binaryReader.BaseStream.Read(array7, 0, array7.Length);
							Class79.smethod_0(array13, array6, array7, array8, bool_1);
							binaryWriter.Write(array8);
							num9 -= 32768L;
						}
						array[1] = num - array[0];
					}
					if (bool_1)
					{
						long num10;
						if (num > 4699979776L)
						{
							num10 = 8511160320L - num;
						}
						else
						{
							num10 = 4699979776L - num;
						}
						num5 = 0;
						num3 = 0;
						while (num10 > 0L)
						{
							if (num3 == 8000)
							{
								num3 = 0;
								num5++;
							}
							num3++;
							long num11 = (num10 > 32768L) ? 32768L : num10;
							binaryWriter.Write(Class79.byte_0, 0, (int)num11);
							num10 -= 32768L;
						}
						result = null;
					}
					else
					{
						result = array;
					}
				}
			}
			return result;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0002F0E0 File Offset: 0x0002D2E0
		public static void smethod_2(string string_2)
		{
			Class79.Class80 @class = new Class79.Class80();
			Class79.string_1 = string_2;
			@class.byte_0 = Class79.smethod_5(Path.Combine(Class79.string_1, "hif_000000.nfs"));
			@class.string_0 = Path.Combine(Class79.string_1, "hif_unpack.nfs");
			new FrmWait("Please wait while USB Helper converts this game...", new Action(@class.method_0), new Action<Exception>(Class79.<>c.<>c_0.method_1));
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0002F160 File Offset: 0x0002D360
		public static void smethod_3(Stream stream_0, string string_2, byte[] byte_2, byte[] byte_3, byte[] byte_4)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(string_2)))
			{
				int num = 16777216 * (int)byte_2[16] + 65536 * (int)byte_2[17] + 256 * (int)byte_2[18] + (int)byte_2[19];
				long num2 = 0L;
				byte[] array = new byte[32768];
				byte[] array2 = new byte[32768];
				for (int i = 0; i < num; i++)
				{
					long num3 = (long)(32768UL * (16777216UL * (ulong)byte_2[20 + i * 8] + 65536UL * (ulong)byte_2[21 + i * 8] + 256UL * (ulong)byte_2[22 + i * 8] + (ulong)byte_2[23 + i * 8]));
					long num4 = (long)(32768UL * (16777216UL * (ulong)byte_2[24 + i * 8] + 65536UL * (ulong)byte_2[25 + i * 8] + 256UL * (ulong)byte_2[26 + i * 8] + (ulong)byte_2[27 + i * 8]));
					for (long num5 = num3 - num2; num5 > 0L; num5 -= 32768L)
					{
						binaryWriter.Write(Class79.byte_0);
					}
					for (long num5 = num4; num5 > 0L; num5 -= 32768L)
					{
						stream_0.Read(array, 0, 32768);
						Class79.smethod_0(byte_3, byte_4, array, array2, false);
						binaryWriter.Write(array2);
					}
					num2 = num3 + num4;
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		private static byte[] smethod_4(int int_3)
		{
			byte[] array = new byte[int_3];
			for (int i = 0; i < int_3; i++)
			{
				array[i] = 0;
			}
			return array;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0002F2F0 File Offset: 0x0002D4F0
		private static byte[] smethod_5(string string_2)
		{
			byte[] result;
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_2)))
			{
				result = binaryReader.ReadBytes(512);
			}
			return result;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00021E3C File Offset: 0x0002003C
		private static int[,] smethod_6(int[,] int_3, int int_4)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < int_4; i++)
			{
				for (int j = 0; j < int_4 - i; j++)
				{
					if (int_3[1, j] > num)
					{
						num = int_3[1, j];
						num2 = j;
					}
				}
				int num3 = int_3[0, int_4 - i - 1];
				int_3[0, int_4 - i - 1] = int_3[0, num2];
				int_3[0, num2] = num3;
				num3 = int_3[1, int_4 - i - 1];
				int_3[1, int_4 - i - 1] = int_3[1, num2];
				int_3[1, num2] = num3;
			}
			return int_3;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00021EE0 File Offset: 0x000200E0
		private static int[] smethod_7(int[] int_3, int int_4)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < int_4; i++)
			{
				for (int j = 0; j < int_4 - i; j++)
				{
					if (int_3[j] > num)
					{
						num = int_3[j];
						num2 = j;
					}
				}
				int num3 = int_3[int_4 - i - 1];
				int_3[int_4 - i - 1] = int_3[num2];
				int_3[num2] = num3;
			}
			return int_3;
		}

		// Token: 0x0400039C RID: 924
		public const int int_0 = 512;

		// Token: 0x0400039D RID: 925
		public const int int_1 = 262144000;

		// Token: 0x0400039E RID: 926
		public const int int_2 = 32768;

		// Token: 0x0400039F RID: 927
		public static bool bool_0 = false;

		// Token: 0x040003A0 RID: 928
		public static string string_0 = "..\\code\\htk.bin";

		// Token: 0x040003A1 RID: 929
		public static string string_1 = "";

		// Token: 0x040003A2 RID: 930
		private static readonly byte[] byte_0 = new byte[32768];

		// Token: 0x040003A3 RID: 931
		private static readonly byte[] byte_1 = new byte[]
		{
			235,
			228,
			42,
			34,
			94,
			133,
			147,
			228,
			72,
			217,
			197,
			69,
			115,
			129,
			170,
			247
		};

		// Token: 0x020000E6 RID: 230
		[CompilerGenerated]
		private sealed class Class80
		{
			// Token: 0x0600062C RID: 1580 RVA: 0x0002F334 File Offset: 0x0002D534
			internal void method_0()
			{
				List<string> list = new List<string>();
				int num = -1;
				while (File.Exists(Path.Combine(Class79.string_1, "hif_" + string.Format("{0:D6}", ++num) + ".nfs")))
				{
					list.Add(Path.Combine(Class79.string_1, "hif_" + string.Format("{0:D6}", num) + ".nfs"));
				}
				List<Stream> list2 = list.Select(new Func<string, Stream>(Class79.<>c.<>c_0.method_0)).ToList<Stream>();
				list2[0].Seek(512L, SeekOrigin.Begin);
				using (Stream1 stream = new Stream1(list2))
				{
					Class79.smethod_3(stream, this.string_0, this.byte_0, File.ReadAllBytes(Path.Combine(Class79.string_1, Class79.string_0)), Class79.smethod_4(16));
				}
				foreach (string text in list)
				{
					GClass6.smethod_6(text);
				}
				Class79.smethod_1(this.string_0, Path.Combine(Class79.string_1, "..//game.iso"), true);
				GClass6.smethod_6(this.string_0);
			}

			// Token: 0x040003A4 RID: 932
			public string string_0;

			// Token: 0x040003A5 RID: 933
			public byte[] byte_0;
		}
	}
}
