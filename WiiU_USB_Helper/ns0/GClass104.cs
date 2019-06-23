using System;
using System.IO;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x0200010D RID: 269
	public class GClass104
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x00032CCC File Offset: 0x00030ECC
		public static GClass104.GEnum7 smethod_0(byte[] byte_0)
		{
			if (byte_0.Length > 68 && GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 64)) == GClass104.uint_1)
			{
				return GClass104.GEnum7.const_1;
			}
			if (byte_0.Length > 132 && GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 128)) == GClass104.uint_1)
			{
				return GClass104.GEnum7.const_2;
			}
			if (byte_0.Length > 4 && GClass27.smethod_5(BitConverter.ToUInt32(byte_0, 0)) == GClass104.uint_0)
			{
				return GClass104.GEnum7.const_3;
			}
			return GClass104.GEnum7.const_0;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00032D40 File Offset: 0x00030F40
		public static GClass104.GEnum7 smethod_1(Stream stream_0)
		{
			byte[] array = new byte[4];
			if (stream_0.Length > 68L)
			{
				stream_0.Seek(64L, SeekOrigin.Begin);
				stream_0.Read(array, 0, array.Length);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) == GClass104.uint_1)
				{
					return GClass104.GEnum7.const_1;
				}
			}
			if (stream_0.Length > 132L)
			{
				stream_0.Seek(128L, SeekOrigin.Begin);
				stream_0.Read(array, 0, array.Length);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) == GClass104.uint_1)
				{
					return GClass104.GEnum7.const_2;
				}
			}
			if (stream_0.Length > 4L)
			{
				stream_0.Seek(0L, SeekOrigin.Begin);
				stream_0.Read(array, 0, array.Length);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) == GClass104.uint_0)
				{
					return GClass104.GEnum7.const_3;
				}
			}
			return GClass104.GEnum7.const_0;
		}

		// Token: 0x04000440 RID: 1088
		private static uint uint_0 = 1229800501u;

		// Token: 0x04000441 RID: 1089
		private static uint uint_1 = 1229800788u;

		// Token: 0x0200010E RID: 270
		public enum GEnum7
		{
			// Token: 0x04000443 RID: 1091
			const_0,
			// Token: 0x04000444 RID: 1092
			const_1 = 1536,
			// Token: 0x04000445 RID: 1093
			const_2 = 1600,
			// Token: 0x04000446 RID: 1094
			const_3 = 32
		}

		// Token: 0x0200010F RID: 271
		public class GClass105
		{
			// Token: 0x06000748 RID: 1864 RVA: 0x00014C73 File Offset: 0x00012E73
			private GClass105()
			{
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000749 RID: 1865 RVA: 0x00014C9F File Offset: 0x00012E9F
			public uint UInt32_0
			{
				get
				{
					return this.uint_0;
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x0600074A RID: 1866 RVA: 0x00014CA7 File Offset: 0x00012EA7
			public byte[] Byte_0
			{
				get
				{
					return this.byte_0;
				}
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x00032E08 File Offset: 0x00031008
			public static byte[] smethod_0(byte[] byte_2)
			{
				GClass104.GClass105 gclass = GClass104.GClass105.smethod_1(byte_2);
				MemoryStream memoryStream = new MemoryStream();
				gclass.method_4(memoryStream);
				memoryStream.Write(byte_2, 0, byte_2.Length);
				byte[] result = memoryStream.ToArray();
				memoryStream.Dispose();
				return result;
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x00014CAF File Offset: 0x00012EAF
			public static GClass104.GClass105 smethod_1(byte[] byte_2)
			{
				GClass104.GClass105 gclass = new GClass104.GClass105();
				gclass.uint_0 = (uint)byte_2.Length;
				gclass.method_2(byte_2);
				return gclass;
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x00014CC6 File Offset: 0x00012EC6
			public static GClass104.GClass105 smethod_2(Stream stream_0)
			{
				if (GClass104.smethod_1(stream_0) != GClass104.GEnum7.const_3)
				{
					throw new Exception("No IMD5 Header found!");
				}
				GClass104.GClass105 gclass = new GClass104.GClass105();
				gclass.method_3(stream_0);
				return gclass;
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x00032E40 File Offset: 0x00031040
			public MemoryStream method_0()
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					this.method_4(memoryStream);
				}
				catch
				{
					memoryStream.Dispose();
					throw;
				}
				return memoryStream;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x00014CE9 File Offset: 0x00012EE9
			public void method_1(Stream stream_0)
			{
				this.method_4(stream_0);
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00032E78 File Offset: 0x00031078
			private void method_2(byte[] byte_2)
			{
				MD5 md = MD5.Create();
				this.byte_0 = md.ComputeHash(byte_2);
				md.Clear();
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x00032EA0 File Offset: 0x000310A0
			private void method_3(Stream stream_0)
			{
				stream_0.Seek(0L, SeekOrigin.Begin);
				byte[] array = new byte[4];
				stream_0.Read(array, 0, 4);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) != this.uint_1)
				{
					throw new Exception("Invalid Magic!");
				}
				stream_0.Read(array, 0, 4);
				this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(this.byte_1, 0, this.byte_1.Length);
				stream_0.Read(this.byte_0, 0, this.byte_0.Length);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x00032F30 File Offset: 0x00031130
			private void method_4(Stream stream_0)
			{
				stream_0.Seek(0L, SeekOrigin.Begin);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
				stream_0.Write(this.byte_1, 0, this.byte_1.Length);
				stream_0.Write(this.byte_0, 0, this.byte_0.Length);
			}

			// Token: 0x04000447 RID: 1095
			private uint uint_0;

			// Token: 0x04000448 RID: 1096
			private byte[] byte_0 = new byte[16];

			// Token: 0x04000449 RID: 1097
			private uint uint_1 = 1229800501u;

			// Token: 0x0400044A RID: 1098
			private byte[] byte_1 = new byte[8];
		}

		// Token: 0x02000110 RID: 272
		public class GClass106
		{
			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x00014CF2 File Offset: 0x00012EF2
			// (set) Token: 0x06000755 RID: 1877 RVA: 0x00014CFA File Offset: 0x00012EFA
			public uint UInt32_0
			{
				get
				{
					return this.uint_0;
				}
				set
				{
					this.uint_0 = value;
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x00014D03 File Offset: 0x00012F03
			// (set) Token: 0x06000757 RID: 1879 RVA: 0x00014D11 File Offset: 0x00012F11
			public string String_0
			{
				get
				{
					return this.method_3(this.byte_1);
				}
				set
				{
					this.method_4(value, 6);
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x00014D1B File Offset: 0x00012F1B
			// (set) Token: 0x06000759 RID: 1881 RVA: 0x00014D29 File Offset: 0x00012F29
			public string String_1
			{
				get
				{
					return this.method_3(this.byte_2);
				}
				set
				{
					this.method_4(value, 1);
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x00014D33 File Offset: 0x00012F33
			// (set) Token: 0x0600075B RID: 1883 RVA: 0x00014D41 File Offset: 0x00012F41
			public string String_2
			{
				get
				{
					return this.method_3(this.byte_3);
				}
				set
				{
					this.method_4(value, 3);
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x00014D4B File Offset: 0x00012F4B
			// (set) Token: 0x0600075D RID: 1885 RVA: 0x00014D59 File Offset: 0x00012F59
			public string String_3
			{
				get
				{
					return this.method_3(this.byte_4);
				}
				set
				{
					this.method_4(value, 2);
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x0600075E RID: 1886 RVA: 0x00014D63 File Offset: 0x00012F63
			public bool Boolean_0
			{
				get
				{
					return this.bool_0;
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600075F RID: 1887 RVA: 0x00014D6B File Offset: 0x00012F6B
			// (set) Token: 0x06000760 RID: 1888 RVA: 0x00014D73 File Offset: 0x00012F73
			public uint UInt32_1
			{
				get
				{
					return this.uint_2;
				}
				set
				{
					this.uint_2 = value;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06000761 RID: 1889 RVA: 0x00014D7C File Offset: 0x00012F7C
			// (set) Token: 0x06000762 RID: 1890 RVA: 0x00014D84 File Offset: 0x00012F84
			public bool Boolean_1
			{
				get
				{
					return this.bool_1;
				}
				set
				{
					this.bool_1 = value;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06000763 RID: 1891 RVA: 0x00014D8D File Offset: 0x00012F8D
			// (set) Token: 0x06000764 RID: 1892 RVA: 0x00014D9B File Offset: 0x00012F9B
			public string String_4
			{
				get
				{
					return this.method_3(this.byte_6);
				}
				set
				{
					this.method_4(value, 5);
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000765 RID: 1893 RVA: 0x00014DA5 File Offset: 0x00012FA5
			// (set) Token: 0x06000766 RID: 1894 RVA: 0x00014DB3 File Offset: 0x00012FB3
			public string String_5
			{
				get
				{
					return this.method_3(this.byte_7);
				}
				set
				{
					this.method_4(value, 0);
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000767 RID: 1895 RVA: 0x00014DBD File Offset: 0x00012FBD
			// (set) Token: 0x06000768 RID: 1896 RVA: 0x00014DCB File Offset: 0x00012FCB
			public string String_6
			{
				get
				{
					return this.method_3(this.byte_8);
				}
				set
				{
					this.method_4(value, 7);
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000769 RID: 1897 RVA: 0x00014DD5 File Offset: 0x00012FD5
			// (set) Token: 0x0600076A RID: 1898 RVA: 0x00014DDD File Offset: 0x00012FDD
			public uint UInt32_2
			{
				get
				{
					return this.uint_5;
				}
				set
				{
					this.uint_5 = value;
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600076B RID: 1899 RVA: 0x00014DE6 File Offset: 0x00012FE6
			// (set) Token: 0x0600076C RID: 1900 RVA: 0x00014DF4 File Offset: 0x00012FF4
			public string String_7
			{
				get
				{
					return this.method_3(this.byte_11);
				}
				set
				{
					this.method_4(value, 4);
				}
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x00033094 File Offset: 0x00031294
			public static GClass104.GClass106 smethod_0(Stream stream_0)
			{
				GClass104.GEnum7 genum = GClass104.smethod_1(stream_0);
				if (genum != GClass104.GEnum7.const_2 && genum != GClass104.GEnum7.const_1)
				{
					throw new Exception("No IMET Header found!");
				}
				GClass104.GClass106 gclass = new GClass104.GClass106();
				if (genum == GClass104.GEnum7.const_1)
				{
					gclass.bool_1 = true;
				}
				gclass.method_2(stream_0);
				return gclass;
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00014DFE File Offset: 0x00012FFE
			public void method_0(Stream stream_0)
			{
				this.method_5(stream_0);
			}

			// Token: 0x0600076F RID: 1903 RVA: 0x000330E0 File Offset: 0x000312E0
			private void method_1(byte[] byte_14, int int_0)
			{
				MD5 md = MD5.Create();
				this.byte_5 = md.ComputeHash(byte_14, int_0, 1536);
				md.Clear();
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x0003310C File Offset: 0x0003130C
			private void method_2(Stream stream_0)
			{
				stream_0.Seek(0L, SeekOrigin.Begin);
				byte[] array = new byte[4];
				if (!this.bool_1)
				{
					stream_0.Read(this.byte_0, 0, this.byte_0.Length);
				}
				stream_0.Read(this.byte_9, 0, this.byte_9.Length);
				stream_0.Read(array, 0, 4);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) != this.uint_3)
				{
					throw new Exception("Invalid Magic!");
				}
				stream_0.Read(array, 0, 4);
				if (GClass27.smethod_5(BitConverter.ToUInt32(array, 0)) != this.uint_4)
				{
					throw new Exception("Invalid Header Size!");
				}
				stream_0.Read(array, 0, 4);
				this.uint_6 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(array, 0, 4);
				this.uint_2 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(array, 0, 4);
				this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(array, 0, 4);
				this.uint_5 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(array, 0, 4);
				this.uint_1 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				stream_0.Read(this.byte_7, 0, this.byte_7.Length);
				stream_0.Read(this.byte_2, 0, this.byte_2.Length);
				stream_0.Read(this.byte_4, 0, this.byte_4.Length);
				stream_0.Read(this.byte_3, 0, this.byte_3.Length);
				stream_0.Read(this.byte_11, 0, this.byte_11.Length);
				stream_0.Read(this.byte_6, 0, this.byte_6.Length);
				stream_0.Read(this.byte_1, 0, this.byte_1.Length);
				stream_0.Read(this.byte_12, 0, this.byte_12.Length);
				stream_0.Read(this.byte_13, 0, this.byte_13.Length);
				stream_0.Read(this.byte_8, 0, this.byte_8.Length);
				stream_0.Read(this.byte_10, 0, this.byte_10.Length);
				stream_0.Read(this.byte_5, 0, this.byte_5.Length);
				stream_0.Seek(-16L, SeekOrigin.Current);
				stream_0.Write(new byte[16], 0, 16);
				byte[] array2 = new byte[stream_0.Length];
				stream_0.Seek(0L, SeekOrigin.Begin);
				stream_0.Read(array2, 0, array2.Length);
				MD5 md = MD5.Create();
				byte[] array3 = md.ComputeHash(array2, this.bool_1 ? 0 : 64, 1536);
				md.Clear();
				this.bool_0 = GClass27.smethod_1(array3, this.byte_5);
			}

			// Token: 0x06000771 RID: 1905 RVA: 0x000333B8 File Offset: 0x000315B8
			private string method_3(byte[] byte_14)
			{
				string text = string.Empty;
				for (int i = 0; i < 84; i += 2)
				{
					char c = BitConverter.ToChar(new byte[]
					{
						byte_14[i + 1],
						byte_14[i]
					}, 0);
					if (c != '\0')
					{
						text += c.ToString();
					}
				}
				return text;
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00033408 File Offset: 0x00031608
			private void method_4(string string_0, int int_0)
			{
				byte[] array = new byte[84];
				for (int i = 0; i < string_0.Length; i++)
				{
					byte[] bytes = BitConverter.GetBytes(string_0[i]);
					array[i * 2 + 1] = bytes[0];
					array[i * 2] = bytes[1];
				}
				switch (int_0)
				{
				case 0:
					this.byte_7 = array;
					return;
				case 1:
					this.byte_2 = array;
					return;
				case 2:
					this.byte_4 = array;
					return;
				case 3:
					this.byte_3 = array;
					return;
				case 4:
					this.byte_11 = array;
					return;
				case 5:
					this.byte_6 = array;
					return;
				case 6:
					this.byte_1 = array;
					return;
				case 7:
					this.byte_8 = array;
					return;
				default:
					return;
				}
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x000334B4 File Offset: 0x000316B4
			private void method_5(Stream stream_0)
			{
				stream_0.Seek(0L, SeekOrigin.Begin);
				if (!this.bool_1)
				{
					stream_0.Write(this.byte_0, 0, this.byte_0.Length);
				}
				stream_0.Write(this.byte_9, 0, this.byte_9.Length);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_3)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_4)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_6)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_2)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_5)), 0, 4);
				stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
				stream_0.Write(this.byte_7, 0, this.byte_7.Length);
				stream_0.Write(this.byte_2, 0, this.byte_2.Length);
				stream_0.Write(this.byte_4, 0, this.byte_4.Length);
				stream_0.Write(this.byte_3, 0, this.byte_3.Length);
				stream_0.Write(this.byte_11, 0, this.byte_11.Length);
				stream_0.Write(this.byte_6, 0, this.byte_6.Length);
				stream_0.Write(this.byte_1, 0, this.byte_1.Length);
				stream_0.Write(this.byte_12, 0, this.byte_12.Length);
				stream_0.Write(this.byte_13, 0, this.byte_13.Length);
				stream_0.Write(this.byte_8, 0, this.byte_8.Length);
				stream_0.Write(this.byte_10, 0, this.byte_10.Length);
				int num = (int)stream_0.Position;
				this.byte_5 = new byte[16];
				stream_0.Write(this.byte_5, 0, this.byte_5.Length);
				byte[] array = new byte[stream_0.Position];
				stream_0.Seek(0L, SeekOrigin.Begin);
				stream_0.Read(array, 0, array.Length);
				this.method_1(array, this.bool_1 ? 0 : 64);
				stream_0.Seek((long)num, SeekOrigin.Begin);
				stream_0.Write(this.byte_5, 0, this.byte_5.Length);
			}

			// Token: 0x0400044B RID: 1099
			private byte[] byte_0 = new byte[64];

			// Token: 0x0400044C RID: 1100
			private uint uint_0;

			// Token: 0x0400044D RID: 1101
			private byte[] byte_1 = new byte[84];

			// Token: 0x0400044E RID: 1102
			private byte[] byte_2 = new byte[84];

			// Token: 0x0400044F RID: 1103
			private uint uint_1;

			// Token: 0x04000450 RID: 1104
			private byte[] byte_3 = new byte[84];

			// Token: 0x04000451 RID: 1105
			private byte[] byte_4 = new byte[84];

			// Token: 0x04000452 RID: 1106
			private byte[] byte_5 = new byte[16];

			// Token: 0x04000453 RID: 1107
			private bool bool_0 = true;

			// Token: 0x04000454 RID: 1108
			private uint uint_2;

			// Token: 0x04000455 RID: 1109
			private uint uint_3 = 1229800788u;

			// Token: 0x04000456 RID: 1110
			private bool bool_1;

			// Token: 0x04000457 RID: 1111
			private byte[] byte_6 = new byte[84];

			// Token: 0x04000458 RID: 1112
			private byte[] byte_7 = new byte[84];

			// Token: 0x04000459 RID: 1113
			private byte[] byte_8 = new byte[84];

			// Token: 0x0400045A RID: 1114
			private byte[] byte_9 = new byte[64];

			// Token: 0x0400045B RID: 1115
			private byte[] byte_10 = new byte[588];

			// Token: 0x0400045C RID: 1116
			private uint uint_4 = 1536u;

			// Token: 0x0400045D RID: 1117
			private uint uint_5;

			// Token: 0x0400045E RID: 1118
			private byte[] byte_11 = new byte[84];

			// Token: 0x0400045F RID: 1119
			private uint uint_6 = 3u;

			// Token: 0x04000460 RID: 1120
			private byte[] byte_12 = new byte[84];

			// Token: 0x04000461 RID: 1121
			private byte[] byte_13 = new byte[84];
		}
	}
}
