using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
	// Token: 0x02000044 RID: 68
	internal static class Class28
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00020C1C File Offset: 0x0001EE1C
		public static void smethod_0(string string_5)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			Directory.SetCurrentDirectory(string_5);
			try
			{
				Class28.bool_2 = true;
				Class28.bool_9 = true;
				Class28.smethod_4(Class28.string_0);
				long[] long_ = Class28.smethod_6(Class28.string_1, "hif_unpack.nfs", false);
				byte[] byte_ = Class28.smethod_7("hif_unpack.nfs", "hif_dec.nfs", long_);
				GClass6.smethod_6("hif_unpack.nfs");
				Class28.smethod_5("hif_dec.nfs", "hif.nfs", Class28.byte_0, Class28.smethod_2(Class28.byte_0.Length), true, byte_);
				GClass6.smethod_6("hif_dec.nfs");
				Class28.smethod_10("hif.nfs");
				GClass6.smethod_6("hif.nfs");
			}
			catch
			{
				Directory.SetCurrentDirectory(currentDirectory);
				throw;
			}
			finally
			{
				Directory.SetCurrentDirectory(currentDirectory);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		private static byte[] smethod_1(byte[] byte_1, byte[] byte_2, byte[] byte_3, bool bool_11)
		{
			byte[] array = new byte[byte_3.Length];
			byte[] result;
			try
			{
				AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
				{
					Mode = CipherMode.CBC,
					Padding = PaddingMode.None,
					KeySize = 128,
					BlockSize = 128,
					Key = byte_1,
					IV = byte_2
				};
				if (bool_11)
				{
					using (ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor())
					{
						array = cryptoTransform.TransformFinalBlock(byte_3, 0, byte_3.Length);
						goto IL_82;
					}
				}
				using (ICryptoTransform cryptoTransform2 = aesCryptoServiceProvider.CreateDecryptor())
				{
					array = cryptoTransform2.TransformFinalBlock(byte_3, 0, byte_3.Length);
				}
				IL_82:
				aesCryptoServiceProvider.Clear();
				result = array;
			}
			catch
			{
				throw;
			}
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		private static byte[] smethod_2(int int_3)
		{
			byte[] array = new byte[int_3];
			for (int i = 0; i < int_3; i++)
			{
				array[i] = 0;
			}
			return array;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000117C5 File Offset: 0x0000F9C5
		private static bool smethod_3(byte[] byte_1, byte[] byte_2)
		{
			return byte_1.Length == byte_2.Length && Class28.memcmp(byte_1, byte_2, (long)byte_1.Length) == 0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		private static void smethod_4(string string_5)
		{
			MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(string_5));
			byte[] array = new byte[4];
			byte[] byte_ = new byte[]
			{
				115,
				118,
				110,
				45
			};
			int num = 0;
			while ((long)num < memoryStream.Length - 4L)
			{
				memoryStream.Position = (long)num;
				memoryStream.Read(array, 0, 4);
				if (Class28.smethod_3(array, byte_))
				{
					memoryStream.Read(array, 0, 4);
					Encoding.UTF8.GetString(array, 0, array.Length);
					IL_76:
					byte[] array2 = new byte[4];
					byte[] array3 = new byte[8];
					Array.Clear(array2, 0, 4);
					byte[] byte_2 = new byte[]
					{
						32,
						7,
						35,
						162
					};
					byte[] byte_3 = new byte[]
					{
						32,
						7,
						75,
						11
					};
					int num2 = 0;
					while ((long)num2 < memoryStream.Length - 4L)
					{
						memoryStream.Position = (long)num2;
						memoryStream.Read(array2, 0, 4);
						if (Class28.smethod_3(array2, byte_2) || Class28.smethod_3(array2, byte_3))
						{
							memoryStream.Seek((long)(num2 + 1), SeekOrigin.Begin);
							memoryStream.WriteByte(0);
						}
						num2++;
					}
					if (Class28.bool_2)
					{
						Array.Clear(array2, 0, 4);
						Array.Clear(array3, 0, 8);
						byte[] byte_4 = new byte[]
						{
							208,
							11,
							35,
							8,
							67,
							19,
							96,
							11
						};
						byte[] buffer = new byte[]
						{
							70,
							192
						};
						int num3 = 0;
						while ((long)num3 < memoryStream.Length - 8L)
						{
							memoryStream.Position = (long)num3;
							memoryStream.Read(array3, 0, 8);
							if (Class28.smethod_3(array3, byte_4))
							{
								memoryStream.Seek((long)num3, SeekOrigin.Begin);
								memoryStream.Write(buffer, 0, 2);
							}
							num3++;
						}
						byte[] byte_5 = new byte[]
						{
							1,
							148,
							181,
							0,
							75,
							8,
							34,
							1
						};
						byte[] array4 = new byte[2];
						array4[0] = 34;
						byte[] buffer2 = array4;
						int num4 = 0;
						while ((long)num4 < memoryStream.Length - 8L)
						{
							memoryStream.Position = (long)num4;
							memoryStream.Read(array3, 0, 8);
							if (Class28.smethod_3(array3, byte_5))
							{
								memoryStream.Seek((long)(num4 + 6), SeekOrigin.Begin);
								memoryStream.Write(buffer2, 0, 2);
							}
							num4++;
						}
						byte[] byte_6 = new byte[]
						{
							176,
							186,
							28,
							15
						};
						byte[] buffer3 = new byte[]
						{
							229,
							159,
							16,
							4,
							229,
							145,
							0,
							0,
							225,
							47,
							byte.MaxValue,
							16,
							18,
							byte.MaxValue,
							byte.MaxValue,
							224
						};
						int num5 = 0;
						while ((long)num5 < memoryStream.Length - 4L)
						{
							memoryStream.Position = (long)num5;
							memoryStream.Read(array2, 0, 4);
							if (Class28.smethod_3(array2, byte_6))
							{
								memoryStream.Seek((long)(num5 - 12), SeekOrigin.Begin);
								memoryStream.Write(buffer3, 0, 16);
							}
							num5++;
						}
						byte[] byte_7 = new byte[]
						{
							104,
							75,
							43,
							6
						};
						byte[] buffer4 = new byte[]
						{
							73,
							1,
							71,
							136,
							70,
							192,
							224,
							1,
							18,
							byte.MaxValue,
							254,
							0,
							34,
							0,
							35,
							1,
							70,
							192,
							70,
							192
						};
						int num6 = 0;
						while ((long)num6 < memoryStream.Length - 4L)
						{
							memoryStream.Position = (long)num6;
							memoryStream.Read(array2, 0, 4);
							if (Class28.smethod_3(array2, byte_7))
							{
								memoryStream.Seek((long)num6, SeekOrigin.Begin);
								memoryStream.Write(buffer4, 0, 20);
							}
							num6++;
						}
						byte[] byte_8 = new byte[]
						{
							13,
							128,
							0,
							0,
							13,
							128,
							0,
							0
						};
						byte[] byte_9 = new byte[]
						{
							0,
							0,
							0,
							2
						};
						byte[] buffer5 = new byte[]
						{
							0,
							0,
							0,
							3
						};
						int num7 = 0;
						while ((long)num7 < memoryStream.Length - 8L)
						{
							memoryStream.Position = (long)num7;
							memoryStream.Read(array3, 0, 8);
							if (Class28.smethod_3(array3, byte_8))
							{
								memoryStream.Seek((long)(num7 + 16), SeekOrigin.Begin);
								memoryStream.Read(array2, 0, 4);
								if (Class28.smethod_3(array2, byte_9))
								{
									memoryStream.Seek((long)(num7 + 16), SeekOrigin.Begin);
									memoryStream.Write(buffer5, 0, 4);
								}
							}
							num7++;
						}
					}
					if (Class28.bool_9)
					{
						Array.Clear(array2, 0, 4);
						Array.Clear(array3, 0, 8);
						byte[] byte_10 = new byte[]
						{
							32,
							75,
							1,
							104,
							24,
							71,
							112,
							0
						};
						byte[] array5 = new byte[2];
						array5[0] = 32;
						byte[] buffer6 = array5;
						int num8 = 0;
						while ((long)num8 < memoryStream.Length - 8L)
						{
							memoryStream.Position = (long)num8;
							memoryStream.Read(array3, 0, 8);
							if (Class28.smethod_3(array3, byte_10))
							{
								memoryStream.Seek((long)(num8 + 3), SeekOrigin.Begin);
								memoryStream.Write(buffer6, 0, 2);
							}
							num8++;
						}
						byte[] byte_11 = new byte[]
						{
							40,
							0,
							208,
							3,
							73,
							2,
							34,
							9
						};
						byte[] buffer7 = new byte[]
						{
							240,
							4,
							byte.MaxValue,
							33,
							72,
							2,
							33,
							9,
							240,
							4,
							254,
							249
						};
						int num9 = 0;
						while ((long)num9 < memoryStream.Length - 8L)
						{
							memoryStream.Position = (long)num9;
							memoryStream.Read(array3, 0, 8);
							if (Class28.smethod_3(array3, byte_11))
							{
								memoryStream.Seek((long)num9, SeekOrigin.Begin);
								memoryStream.Write(buffer7, 0, 12);
							}
							num9++;
						}
						byte[] byte_12 = new byte[]
						{
							240,
							1,
							250,
							185
						};
						byte[] buffer8 = new byte[]
						{
							247,
							252,
							251,
							149
						};
						int num10 = 0;
						while ((long)num10 < memoryStream.Length - 4L)
						{
							memoryStream.Position = (long)num10;
							memoryStream.Read(array2, 0, 4);
							if (Class28.smethod_3(array2, byte_12))
							{
								memoryStream.Seek((long)num10, SeekOrigin.Begin);
								memoryStream.Write(buffer8, 0, 4);
							}
							num10++;
						}
					}
					FileStream fileStream = File.OpenWrite(string_5);
					memoryStream.WriteTo(fileStream);
					fileStream.Close();
					memoryStream.Close();
					return;
				}
				num++;
			}
			goto IL_76;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00021300 File Offset: 0x0001F500
		private static void smethod_5(string string_5, string string_6, byte[] byte_1, byte[] byte_2, bool bool_11, byte[] byte_3)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_5)))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(string_6)))
				{
					if (bool_11)
					{
						binaryWriter.Write(byte_3);
					}
					byte[] array = new byte[16];
					array[14] = 31;
					byte[] array2 = array;
					byte[] array3 = new byte[32768];
					int num = 0;
					int num2 = 0;
					long num3 = binaryReader.BaseStream.Length;
					do
					{
						if (num == 8000)
						{
							num = 0;
							num2++;
						}
						num++;
						array3 = binaryReader.ReadBytes((num3 > 32768L) ? 32768 : ((int)num3));
						if (binaryWriter.BaseStream.Position >= 98304L)
						{
							byte_2 = array2;
						}
						if (bool_11 && binaryWriter.BaseStream.Position < 98304L)
						{
							array3 = Class28.smethod_1(byte_1, byte_2, array3, true);
						}
						if (bool_11 && binaryWriter.BaseStream.Position >= 98304L)
						{
							array3 = Class28.smethod_1(byte_1, array2, array3, true);
							byte[] array4 = array2;
							int num4 = 15;
							array4[num4] += 1;
							if (array2[15] == 0)
							{
								byte[] array5 = array2;
								int num5 = 14;
								array5[num5] += 1;
								if (array2[14] == 0)
								{
									byte[] array6 = array2;
									int num6 = 13;
									array6[num6] += 1;
									if (array2[13] == 0)
									{
										byte[] array7 = array2;
										int num7 = 12;
										array7[num7] += 1;
									}
								}
							}
						}
						if (!bool_11 && binaryWriter.BaseStream.Position < 98304L)
						{
							array3 = Class28.smethod_1(byte_1, byte_2, array3, false);
						}
						if (!bool_11 && binaryWriter.BaseStream.Position >= 98304L)
						{
							array3 = Class28.smethod_1(byte_1, byte_2, array3, false);
							byte[] array8 = array2;
							int num8 = 15;
							array8[num8] += 1;
							if (array2[15] == 0)
							{
								byte[] array9 = array2;
								int num9 = 14;
								array9[num9] += 1;
								if (array2[14] == 0)
								{
									byte[] array10 = array2;
									int num10 = 13;
									array10[num10] += 1;
									if (array2[13] == 0)
									{
										byte[] array11 = array2;
										int num11 = 12;
										array11[num11] += 1;
									}
								}
							}
						}
						binaryWriter.Write(array3);
						num3 -= 32768L;
					}
					while (num3 > 0L);
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00021534 File Offset: 0x0001F734
		private static long[] smethod_6(string string_5, string string_6, bool bool_11)
		{
			long[] result;
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_5)))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(string_6)))
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
					array3 = Class28.smethod_8(array3, 4);
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
					int[] array5 = list.ToArray();
					array5 = Class28.smethod_9(array5, array5.Length);
					array[0] = (long)array5[0];
					byte[] array6 = new byte[16];
					byte[] array7 = new byte[1024];
					byte[] array8 = new byte[1024];
					int num3 = 0;
					int num4 = 0;
					for (int k = 0; k < array5.Length; k++)
					{
						binaryWriter.Write(binaryReader.ReadBytes((int)((long)array5[k] - num)));
						num += (long)array5[k] - num;
						binaryWriter.Write(binaryReader.ReadBytes(447));
						byte[] array9 = binaryReader.ReadBytes(16);
						binaryWriter.Write(array9);
						binaryWriter.Write(binaryReader.ReadBytes(13));
						byte[] array10 = binaryReader.ReadBytes(8);
						binaryWriter.Write(array10);
						for (int l = 0; l < 16; l++)
						{
							if (l < 8)
							{
								array6[l] = array10[l];
							}
							else
							{
								array6[l] = 0;
							}
						}
						binaryWriter.Write(binaryReader.ReadBytes(192));
						byte[] array11 = binaryReader.ReadBytes(130396);
						long num5 = 4L * (long)((int)array11[24] * 16777216 + (int)array11[25] * 65536 + (int)array11[26] * 256 + (int)array11[27]);
						binaryWriter.Write(array11);
						num += 131072L;
						num += num5;
						byte[] byte_ = Class28.smethod_1(Class28.byte_0, array6, array9, false);
						byte[] array12 = new byte[32768];
						while (num5 >= 32768L)
						{
							if (num3 == 8000)
							{
								num3 = 0;
								num4++;
							}
							num3++;
							if (bool_11)
							{
								Array.Clear(array6, 0, 16);
								array7 = binaryReader.ReadBytes(1024);
								array8 = Class28.smethod_1(byte_, array6, array7, true);
								binaryWriter.Write(array8);
								if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
								{
									break;
								}
								Array.Copy(array8, 976, array6, 0, 16);
								array12 = binaryReader.ReadBytes(31744);
								array12 = Class28.smethod_1(byte_, array6, array12, bool_11);
							}
							else
							{
								Array.Clear(array6, 0, 16);
								array8 = binaryReader.ReadBytes(1024);
								array7 = Class28.smethod_1(byte_, array6, array8, false);
								binaryWriter.Write(array7);
								if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
								{
									break;
								}
								Array.Copy(array8, 976, array6, 0, 16);
								array12 = binaryReader.ReadBytes(31744);
								array12 = Class28.smethod_1(byte_, array6, array12, false);
							}
							binaryWriter.Write(array12);
							num5 -= 32768L;
						}
						array[1] = num - array[0];
					}
					if (bool_11)
					{
						long num6;
						if (num > 4699979776L)
						{
							num6 = 8511160320L - num;
						}
						else
						{
							num6 = 4699979776L - num;
						}
						num4 = 0;
						num3 = 0;
						while (num6 > 0L)
						{
							if (num3 == 8000)
							{
								num3 = 0;
								num4++;
							}
							num3++;
							binaryWriter.Write(Class28.smethod_2((num6 > 32768L) ? 32768 : ((int)num6)));
							num6 -= 32768L;
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

		// Token: 0x060001A6 RID: 422
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern int memcmp(byte[] byte_1, byte[] byte_2, long long_0);

		// Token: 0x060001A7 RID: 423 RVA: 0x00021AD4 File Offset: 0x0001FCD4
		private static byte[] smethod_7(string string_5, string string_6, long[] long_0)
		{
			byte[] result;
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_5)))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(string_6)))
				{
					byte[] array = new byte[512];
					for (int i = 0; i < 512; i++)
					{
						array[i] = byte.MaxValue;
					}
					array[0] = 69;
					array[1] = 71;
					array[2] = 71;
					array[3] = 83;
					array[4] = 0;
					array[5] = 1;
					array[6] = 16;
					array[7] = 17;
					array[8] = 0;
					array[9] = 0;
					array[10] = 0;
					array[11] = 0;
					array[12] = 0;
					array[13] = 0;
					array[14] = 0;
					array[15] = 0;
					array[16] = 0;
					array[17] = 0;
					array[18] = 0;
					array[19] = 3;
					array[20] = 0;
					array[21] = 0;
					array[22] = 0;
					array[23] = 0;
					array[24] = 0;
					array[25] = 0;
					array[26] = 0;
					array[27] = 1;
					array[28] = 0;
					array[29] = 0;
					array[30] = 0;
					array[31] = 8;
					array[32] = 0;
					array[33] = 0;
					array[34] = 0;
					array[35] = 2;
					array[36] = (byte)(long_0[0] / 32768L / 16777216L);
					array[37] = (byte)(long_0[0] / 32768L / 65536L % 256L);
					array[38] = (byte)(long_0[0] / 32768L / 256L % 65536L);
					array[39] = (byte)(long_0[0] / 32768L % 16777216L);
					array[40] = (byte)(long_0[1] / 32768L / 16777216L);
					array[41] = (byte)(long_0[1] / 32768L / 65536L % 256L);
					array[42] = (byte)(long_0[1] / 32768L / 256L % 65536L);
					array[43] = (byte)(long_0[1] / 32768L % 16777216L);
					array[508] = 83;
					array[509] = 71;
					array[510] = 71;
					array[511] = 69;
					int num = 16777216 * (int)array[16] + 65536 * (int)array[17] + 256 * (int)array[18] + (int)array[19];
					long num2 = 0L;
					for (int j = 0; j < num; j++)
					{
						long num3 = (long)(32768UL * (16777216UL * (ulong)array[20 + j * 8] + 65536UL * (ulong)array[21 + j * 8] + 256UL * (ulong)array[22 + j * 8] + (ulong)array[23 + j * 8]));
						long num4 = (long)(32768UL * (16777216UL * (ulong)array[24 + j * 8] + 65536UL * (ulong)array[25 + j * 8] + 256UL * (ulong)array[26 + j * 8] + (ulong)array[27 + j * 8]));
						for (long num5 = num3 - num2; num5 > 0L; num5 -= 32768L)
						{
							binaryReader.ReadBytes(32768);
						}
						for (long num5 = num4; num5 > 0L; num5 -= 32768L)
						{
							binaryWriter.Write(binaryReader.ReadBytes(32768));
						}
						num2 = num3 + num4;
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00021E3C File Offset: 0x0002003C
		private static int[,] smethod_8(int[,] int_3, int int_4)
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

		// Token: 0x060001A9 RID: 425 RVA: 0x00021EE0 File Offset: 0x000200E0
		private static int[] smethod_9(int[] int_3, int int_4)
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

		// Token: 0x060001AA RID: 426 RVA: 0x00021F38 File Offset: 0x00020138
		private static void smethod_10(string string_5)
		{
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_5)))
			{
				long num = binaryReader.BaseStream.Length;
				int num2 = 0;
				do
				{
					new BinaryWriter(File.OpenWrite(Directory.GetCurrentDirectory() + "\\hif_" + string.Format("{0:D6}", num2) + ".nfs")).Write(binaryReader.ReadBytes((num <= 262144000L) ? ((int)num) : 262144000));
					num -= 262144000L;
					num2++;
				}
				while (num > 0L);
			}
		}

		// Token: 0x040000DF RID: 223
		public const int int_0 = 512;

		// Token: 0x040000E0 RID: 224
		public const int int_1 = 262144000;

		// Token: 0x040000E1 RID: 225
		public const int int_2 = 32768;

		// Token: 0x040000E2 RID: 226
		public static bool bool_0 = false;

		// Token: 0x040000E3 RID: 227
		public static bool bool_1 = false;

		// Token: 0x040000E4 RID: 228
		public static string string_0 = "..\\code\\fw.img";

		// Token: 0x040000E5 RID: 229
		public static bool bool_2 = false;

		// Token: 0x040000E6 RID: 230
		public static bool bool_3 = false;

		// Token: 0x040000E7 RID: 231
		public static bool bool_4 = false;

		// Token: 0x040000E8 RID: 232
		public static string string_1 = "game.iso";

		// Token: 0x040000E9 RID: 233
		public static bool bool_5 = false;

		// Token: 0x040000EA RID: 234
		public static bool bool_6 = false;

		// Token: 0x040000EB RID: 235
		public static string string_2 = "..\\code\\htk.bin";

		// Token: 0x040000EC RID: 236
		public static bool bool_7 = false;

		// Token: 0x040000ED RID: 237
		public static string string_3 = "";

		// Token: 0x040000EE RID: 238
		public static bool bool_8 = false;

		// Token: 0x040000EF RID: 239
		public static bool bool_9 = false;

		// Token: 0x040000F0 RID: 240
		public static bool bool_10 = false;

		// Token: 0x040000F1 RID: 241
		public static byte[] byte_0 = new byte[16];

		// Token: 0x040000F2 RID: 242
		public static string string_4 = "wii_common_key.bin";
	}
}
