using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace ns0
{
	// Token: 0x020000FE RID: 254
	internal static class Class83
	{
		// Token: 0x060006EC RID: 1772 RVA: 0x00031700 File Offset: 0x0002F900
		public static Enum3 smethod_0(byte[] byte_1, byte[] byte_2, int int_5, byte[] byte_3, byte byte_4)
		{
			byte[] array = new byte[16];
			array[1] = byte_4;
			byte[] array2 = array;
			SHA1 sha = SHA1.Create();
			byte[] array3 = new byte[1024];
			Buffer.BlockCopy(byte_1, 0, array3, 0, 1024);
			byte[] array4 = Class83.smethod_5(array3, byte_3, array2);
			byte[] array5 = array4;
			int num = 1;
			array5[num] ^= byte_4;
			int srcOffset = int_5 % 16 * 20;
			int srcOffset2 = (16 + int_5 / 16 % 16) * 20;
			int srcOffset3 = (32 + int_5 / 256 % 16) * 20;
			int srcOffset4 = int_5 / 4096 % 16 * 20;
			byte[] dst = new byte[20];
			byte[] array6 = new byte[20];
			byte[] dst2 = new byte[20];
			byte[] array7 = new byte[20];
			Buffer.BlockCopy(array4, srcOffset, dst, 0, 20);
			Buffer.BlockCopy(array4, srcOffset, array2, 0, 16);
			byte[] array8 = new byte[64512];
			Buffer.BlockCopy(byte_1, 1024, array8, 0, 64512);
			byte[] buffer = Class83.smethod_5(array8, byte_3, array2);
			byte[] byte_5 = sha.ComputeHash(buffer);
			if (!GClass27.smethod_1(dst, byte_5))
			{
				return Enum3.const_1;
			}
			if (int_5 % 16 == 0)
			{
				byte[] array9 = new byte[320];
				Buffer.BlockCopy(array4, srcOffset, array9, 0, 320);
				Buffer.BlockCopy(array4, srcOffset2, array6, 0, 20);
				byte_5 = sha.ComputeHash(array9);
				if (!GClass27.smethod_1(byte_5, array6))
				{
					return Enum3.const_1;
				}
			}
			if (int_5 % 256 == 0)
			{
				byte[] array10 = new byte[320];
				Buffer.BlockCopy(array4, srcOffset2, array10, 0, 320);
				Buffer.BlockCopy(array4, srcOffset3, dst2, 0, 20);
				byte_5 = sha.ComputeHash(array10);
				if (!GClass27.smethod_1(dst2, byte_5))
				{
					return Enum3.const_1;
				}
			}
			if (int_5 % 4096 != 0)
			{
				return Enum3.const_0;
			}
			byte[] array11 = new byte[320];
			Buffer.BlockCopy(array4, srcOffset3, array11, 0, 320);
			Buffer.BlockCopy(byte_2, srcOffset4, array7, 0, 20);
			byte_5 = sha.ComputeHash(array11);
			if (!GClass27.smethod_1(byte_5, array7))
			{
				return Enum3.const_1;
			}
			return Enum3.const_0;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000318E4 File Offset: 0x0002FAE4
		public static List<GStruct7> smethod_1(GClass30 gclass30_0)
		{
			Class83.Class84 @class = new Class83.Class84();
			@class.gclass30_0 = gclass30_0;
			string text = Path.Combine(@class.gclass30_0.OutputPath, "title.tmd");
			string text2 = Path.Combine(@class.gclass30_0.OutputPath, "title.tik");
			if (!File.Exists(text) || (@class.gclass30_0.Ticket == null && !File.Exists(text2)))
			{
				return new GStruct7[]
				{
					new GStruct7(null, new List<int>(), false, true)
				}.ToList<GStruct7>();
			}
			if (!File.Exists(text))
			{
				return new GStruct7[]
				{
					new GStruct7(null, new List<int>(), false, true)
				}.ToList<GStruct7>();
			}
			GClass100 gclass = GClass100.smethod_0(text, @class.gclass30_0.System);
			@class.gclass99_0 = (@class.gclass30_0.Ticket ?? GClass99.smethod_6(text2, @class.gclass30_0.System));
			return gclass.GClass101_0.Select(new Func<GClass101, GStruct7>(@class.method_0)).ToList<GStruct7>();
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000319E4 File Offset: 0x0002FBE4
		public static void smethod_2(GClass30 gclass30_0)
		{
			if (gclass30_0.GEnum2_0 != GEnum2.const_2)
			{
				throw new Exception("The title must have been downloaded!");
			}
			foreach (GClass101 gclass in GClass100.smethod_1(File.ReadAllBytes(Path.Combine(gclass30_0.OutputPath, "title.tmd")), GEnum3.const_0).GClass101_0)
			{
				string text = Path.Combine(gclass30_0.OutputPath, gclass.ContentId.ToString("x8") + ".app");
				Class83.smethod_6(text, text + ".dec", gclass30_0.byte_0, Class83.smethod_9(gclass.Index));
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00031A84 File Offset: 0x0002FC84
		private static byte[] smethod_3(string string_0, byte[] byte_1, byte[] byte_2)
		{
			byte[] result;
			using (SHA256 sha = SHA256.Create())
			{
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.Key = byte_1;
					aesCryptoServiceProvider.IV = byte_2;
					aesCryptoServiceProvider.Padding = PaddingMode.None;
					using (FileStream fileStream = File.Open(string_0, FileMode.Open))
					{
						using (CryptoStream cryptoStream = new CryptoStream(fileStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
						{
							result = sha.ComputeHash(cryptoStream);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00031B34 File Offset: 0x0002FD34
		public static GStruct7 smethod_4(GClass30 gclass30_0, GClass101 gclass101_0, byte[] byte_1)
		{
			Class83.Class85 @class = new Class83.Class85();
			@class.byte_1 = byte_1;
			@class.gclass101_0 = gclass101_0;
			List<int> list = new List<int>();
			string path = Path.Combine(gclass30_0.OutputPath, @class.gclass101_0.ContentId.ToString("x8") + ".app");
			string path2 = Path.Combine(gclass30_0.OutputPath, @class.gclass101_0.ContentId.ToString("x8") + ".h3");
			if (!@class.gclass101_0.Boolean_0)
			{
				if (!Class83.smethod_10(gclass30_0, @class.gclass101_0, @class.byte_1))
				{
					return new GStruct7(@class.gclass101_0, new List<int>(), false, true);
				}
				return new GStruct7(@class.gclass101_0, new List<int>(), false, false);
			}
			else
			{
				if (!File.Exists(path2))
				{
					return new GStruct7(@class.gclass101_0, list, true, true);
				}
				@class.byte_0 = File.ReadAllBytes(path2);
				if (!GClass27.smethod_1(SHA1.Create().ComputeHash(@class.byte_0), @class.gclass101_0.Hash))
				{
					return new GStruct7(@class.gclass101_0, list, true, true);
				}
				using (FileStream fileStream = File.OpenRead(path))
				{
					Class83.Class86 class2 = new Class83.Class86();
					class2.class85_0 = @class;
					int num = (int)(class2.class85_0.gclass101_0.Size.TotalBytes / 65536UL);
					int num2 = (int)Math.Ceiling((double)num / 768.0);
					int num3 = 0;
					class2.bool_0 = Enumerable.Repeat<bool>(false, 3).ToArray<bool>();
					class2.list_0 = Enumerable.Repeat<List<int>>(new List<int>(), 3).ToArray<List<int>>();
					Thread[] array = new Thread[3];
					for (int i = 0; i < 3; i++)
					{
						if (Class83.byte_0[i] == null)
						{
							Class83.byte_0[i] = new byte[16777216];
						}
					}
					for (int j = 0; j < num2; j++)
					{
						Class83.Class87 class3 = new Class83.Class87();
						class3.class86_0 = class2;
						class3.tuple_0 = Class83.smethod_11(num, 3, 256);
						num -= class3.tuple_0.Item2;
						for (int k = 0; k < 3; k++)
						{
							Class83.Class88 class4 = new Class83.Class88();
							class4.class87_0 = class3;
							class4.int_0 = k;
							class4.int_1 = num3;
							class4.class87_0.class86_0.bool_0[k] = false;
							class4.class87_0.class86_0.list_0[k] = new List<int>();
							fileStream.Read(Class83.byte_0[k], 0, class4.class87_0.tuple_0.Item1[k] * 65536);
							if (Class83.byte_0[k].Length != 0)
							{
								array[k] = new Thread(new ThreadStart(class4.method_0))
								{
									IsBackground = true
								};
								array[k].Start();
							}
							else
							{
								class4.class87_0.class86_0.bool_0[k] = true;
								class4.class87_0.class86_0.list_0[k] = new List<int>();
							}
							num3 += class4.class87_0.tuple_0.Item1[k];
						}
						while (!Class83.smethod_7(class3.class86_0.bool_0))
						{
							Thread.Sleep(10);
						}
						foreach (List<int> collection in class3.class86_0.list_0)
						{
							list.AddRange(collection);
						}
					}
				}
				return new GStruct7(@class.gclass101_0, list, false, false);
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00031EE4 File Offset: 0x000300E4
		public static byte[] smethod_5(byte[] byte_1, byte[] byte_2, byte[] byte_3)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.None;
			rijndaelManaged.KeySize = 128;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Key = byte_2;
			rijndaelManaged.IV = byte_3;
			byte[] array = new byte[byte_1.Length];
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
			using (MemoryStream memoryStream = new MemoryStream(byte_1))
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
				{
					cryptoStream.Read(array, 0, byte_1.Length);
				}
			}
			return array;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00031F88 File Offset: 0x00030188
		public static void smethod_6(string string_0, string string_1, byte[] byte_1, byte[] byte_2)
		{
			byte[] array = new byte[16777216];
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = byte_1;
				aesCryptoServiceProvider.IV = byte_2;
				aesCryptoServiceProvider.Padding = PaddingMode.None;
				using (FileStream fileStream = File.Open(string_0, FileMode.Open))
				{
					using (FileStream fileStream2 = File.Create(string_1))
					{
						using (CryptoStream cryptoStream = new CryptoStream(fileStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
						{
							int num;
							do
							{
								num = cryptoStream.Read(array, 0, array.Length);
								fileStream2.Write(array, 0, num);
							}
							while (num > 0);
						}
					}
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000149FD File Offset: 0x00012BFD
		private static bool smethod_7(bool[] bool_0)
		{
			return bool_0.All(new Func<bool, bool>(Class83.<>c.<>c_0.method_0));
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00032058 File Offset: 0x00030258
		private static List<int> smethod_8(byte[] byte_1, byte[] byte_2, int int_5, int int_6, byte[] byte_3, byte byte_4)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < int_6; i++)
			{
				byte[] array = new byte[65536];
				Buffer.BlockCopy(byte_1, i * 65536, array, 0, 65536);
				if (Class83.smethod_0(array, byte_2, i + int_5, byte_3, byte_4) == Enum3.const_1)
				{
					list.Add(i + int_5);
				}
			}
			return list;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000320B4 File Offset: 0x000302B4
		private static byte[] smethod_9(ushort ushort_0)
		{
			byte[] array = new byte[16];
			byte[] bytes = BitConverter.GetBytes(ushort_0);
			array[0] = bytes[1];
			array[1] = bytes[0];
			return array;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000320DC File Offset: 0x000302DC
		private static bool smethod_10(GClass30 gclass30_0, GClass101 gclass101_0, byte[] byte_1)
		{
			string text = Path.Combine(gclass30_0.OutputPath, gclass101_0.ContentId.ToString("x8") + ".app");
			byte[] array = Class83.smethod_9(gclass101_0.Index);
			byte[] array2;
			if (gclass30_0.System != GEnum3.const_1)
			{
				if (gclass30_0.System != GEnum3.const_3)
				{
					if (gclass30_0.System == GEnum3.const_0)
					{
						array2 = Class83.smethod_3(text, byte_1, array);
						goto IL_A5;
					}
					throw new NotImplementedException();
				}
			}
			byte[] array3 = File.ReadAllBytes(text);
			Array.Resize<byte>(ref array3, GClass27.smethod_0(array3.Length, 16));
			byte[] buffer = Class83.smethod_5(array3, byte_1, array);
			array2 = SHA1.Create().ComputeHash(buffer, 0, (int)gclass101_0.Size.TotalBytes);
			IL_A5:
			return GClass27.smethod_1(array2, gclass101_0.Hash);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0003219C File Offset: 0x0003039C
		private static Tuple<int[], int> smethod_11(int int_5, int int_6, int int_7)
		{
			int[] array = Enumerable.Repeat<int>(0, int_6).ToArray<int>();
			int num = 0;
			for (int i = 0; i < int_6; i++)
			{
				int num2 = Class83.smethod_12(int_5, int_7);
				num += num2;
				array[i] = num2;
				int_5 -= num2;
			}
			return new Tuple<int[], int>(array, num);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00014A24 File Offset: 0x00012C24
		private static int smethod_12(int int_5, int int_6)
		{
			if (int_6 <= int_5)
			{
				return int_6;
			}
			return int_5;
		}

		// Token: 0x040003E7 RID: 999
		private static readonly byte[][] byte_0 = new byte[3][];

		// Token: 0x040003E8 RID: 1000
		internal const int int_0 = 65536;

		// Token: 0x040003E9 RID: 1001
		private const int int_1 = 64512;

		// Token: 0x040003EA RID: 1002
		private const int int_2 = 1024;

		// Token: 0x040003EB RID: 1003
		private const int int_3 = 256;

		// Token: 0x040003EC RID: 1004
		private const int int_4 = 3;

		// Token: 0x020000FF RID: 255
		[CompilerGenerated]
		private sealed class Class84
		{
			// Token: 0x060006FA RID: 1786 RVA: 0x00014A2D File Offset: 0x00012C2D
			internal GStruct7 method_0(GClass101 gclass101_0)
			{
				return Class83.smethod_4(this.gclass30_0, gclass101_0, this.gclass99_0.Byte_0);
			}

			// Token: 0x040003ED RID: 1005
			public GClass30 gclass30_0;

			// Token: 0x040003EE RID: 1006
			public GClass99 gclass99_0;
		}

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		private sealed class Class85
		{
			// Token: 0x040003EF RID: 1007
			public byte[] byte_0;

			// Token: 0x040003F0 RID: 1008
			public byte[] byte_1;

			// Token: 0x040003F1 RID: 1009
			public GClass101 gclass101_0;
		}

		// Token: 0x02000101 RID: 257
		[CompilerGenerated]
		private sealed class Class86
		{
			// Token: 0x040003F2 RID: 1010
			public List<int>[] list_0;

			// Token: 0x040003F3 RID: 1011
			public bool[] bool_0;

			// Token: 0x040003F4 RID: 1012
			public Class83.Class85 class85_0;
		}

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		private sealed class Class87
		{
			// Token: 0x040003F5 RID: 1013
			public Tuple<int[], int> tuple_0;

			// Token: 0x040003F6 RID: 1014
			public Class83.Class86 class86_0;
		}

		// Token: 0x02000103 RID: 259
		[CompilerGenerated]
		private sealed class Class88
		{
			// Token: 0x060006FF RID: 1791 RVA: 0x000321E4 File Offset: 0x000303E4
			internal void method_0()
			{
				this.class87_0.class86_0.list_0[this.int_0] = Class83.smethod_8(Class83.byte_0[this.int_0], this.class87_0.class86_0.class85_0.byte_0, this.int_1, this.class87_0.tuple_0.Item1[this.int_0], this.class87_0.class86_0.class85_0.byte_1, (byte)this.class87_0.class86_0.class85_0.gclass101_0.Index);
				this.class87_0.class86_0.bool_0[this.int_0] = true;
			}

			// Token: 0x040003F7 RID: 1015
			public int int_0;

			// Token: 0x040003F8 RID: 1016
			public int int_1;

			// Token: 0x040003F9 RID: 1017
			public Class83.Class87 class87_0;
		}
	}
}
