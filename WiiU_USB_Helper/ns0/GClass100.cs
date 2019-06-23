using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using NusHelper;

namespace ns0
{
	// Token: 0x02000108 RID: 264
	public sealed class GClass100 : IDisposable
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00014B28 File Offset: 0x00012D28
		public static byte[] Byte_0
		{
			get
			{
				return GClass97.byte_0;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00014B2F File Offset: 0x00012D2F
		public byte[] Certificate1 { get; } = new byte[1024];

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00014B37 File Offset: 0x00012D37
		public byte[] Certificate2 { get; } = new byte[768];

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00014B3F File Offset: 0x00012D3F
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00014B4C File Offset: 0x00012D4C
		public GClass101[] GClass101_0
		{
			get
			{
				return this.list_0.ToArray();
			}
			set
			{
				this.list_0 = new List<GClass101>(value);
				this.NumOfContents = (ushort)value.Length;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00014B64 File Offset: 0x00012D64
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00014B6C File Offset: 0x00012D6C
		public ushort NumOfContents { get; private set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00014B75 File Offset: 0x00012D75
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00014B7D File Offset: 0x00012D7D
		public ulong TitleId { get; set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00014B86 File Offset: 0x00012D86
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00014B8E File Offset: 0x00012D8E
		public ushort TitleVersion { get; set; }

		// Token: 0x06000727 RID: 1831 RVA: 0x00032870 File Offset: 0x00030A70
		private void method_0(Stream stream_0, GEnum3 genum3_0)
		{
			stream_0.Seek(0L, SeekOrigin.Begin);
			byte[] array = new byte[8];
			stream_0.Read(array, 0, 4);
			this.uint_1 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
			stream_0.Read(this.byte_7, 0, this.byte_7.Length);
			stream_0.Read(this.byte_4, 0, this.byte_4.Length);
			stream_0.Read(this.byte_3, 0, this.byte_3.Length);
			stream_0.Read(array, 0, 4);
			this.byte_9 = array[0];
			this.byte_2 = array[1];
			this.byte_8 = array[2];
			this.byte_5 = array[3];
			stream_0.Read(array, 0, 8);
			stream_0.Read(array, 0, 8);
			this.TitleId = GClass27.smethod_6(BitConverter.ToUInt64(array, 0));
			stream_0.Read(array, 0, 4);
			this.uint_2 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
			stream_0.Read(array, 0, 2);
			this.ushort_3 = GClass27.smethod_4(BitConverter.ToUInt16(array, 0));
			stream_0.Read(array, 0, 2);
			this.ushort_4 = GClass27.smethod_4(BitConverter.ToUInt16(array, 0));
			stream_0.Read(array, 0, 2);
			this.ushort_6 = GClass27.smethod_4(BitConverter.ToUInt16(array, 0));
			stream_0.Read(this.byte_6, 0, this.byte_6.Length);
			stream_0.Read(array, 0, 4);
			this.uint_0 = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
			stream_0.Read(array, 0, 8);
			this.TitleVersion = GClass27.smethod_4(BitConverter.ToUInt16(array, 0));
			this.NumOfContents = GClass27.smethod_4(BitConverter.ToUInt16(array, 2));
			this.ushort_2 = GClass27.smethod_4(BitConverter.ToUInt16(array, 4));
			this.ushort_5 = GClass27.smethod_4(BitConverter.ToUInt16(array, 6));
			if (genum3_0 != GEnum3.const_3)
			{
				stream_0.Position = 2820L;
			}
			this.list_0 = new List<GClass101>();
			int i = 0;
			while (i < (int)this.NumOfContents)
			{
				if (genum3_0 == GEnum3.const_1)
				{
					goto IL_1FE;
				}
				if (genum3_0 == GEnum3.const_3)
				{
					goto IL_1FE;
				}
				if (genum3_0 != GEnum3.const_0)
				{
					throw new NotImplementedException();
				}
				GClass101 gclass = new GClass102
				{
					Hash = new byte[32]
				};
				IL_211:
				stream_0.Read(array, 0, 8);
				gclass.ContentId = GClass27.smethod_5(BitConverter.ToUInt32(array, 0));
				gclass.Index = GClass27.smethod_4(BitConverter.ToUInt16(array, 4));
				gclass.GEnum6_0 = (GEnum6)GClass27.smethod_4(BitConverter.ToUInt16(array, 6));
				stream_0.Read(array, 0, 8);
				gclass.Size = new DataSize(GClass27.smethod_6(BitConverter.ToUInt64(array, 0)));
				stream_0.Read(gclass.Hash, 0, gclass.Hash.Length);
				this.list_0.Add(gclass);
				if (genum3_0 == GEnum3.const_1)
				{
					byte[] buffer = new byte[12];
					stream_0.Read(buffer, 0, 12);
				}
				i++;
				continue;
				IL_1FE:
				gclass = new GClass103
				{
					Hash = new byte[20]
				};
				goto IL_211;
			}
			stream_0.Read(this.Certificate1, 0, this.Certificate1.Length);
			stream_0.Read(this.Certificate2, 0, this.Certificate2.Length);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00014B97 File Offset: 0x00012D97
		public void Dispose()
		{
			this.method_1(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00032B6C File Offset: 0x00030D6C
		~GClass100()
		{
			this.method_1(false);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00032B9C File Offset: 0x00030D9C
		private void method_1(bool bool_1)
		{
			if (bool_1 && !this.bool_0)
			{
				this.byte_7 = null;
				this.byte_4 = null;
				this.byte_3 = null;
				this.byte_6 = null;
				this.list_0.Clear();
				this.list_0 = null;
			}
			this.bool_0 = true;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00032BEC File Offset: 0x00030DEC
		public DataSize DataSize_0
		{
			get
			{
				DataSize seed = new DataSize(0UL);
				return this.GClass101_0.Aggregate(seed, new Func<DataSize, GClass101, DataSize>(GClass100.<>c.<>c_0.method_0));
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00014BA6 File Offset: 0x00012DA6
		public static GClass100 smethod_0(string string_0, GEnum3 genum3_0)
		{
			return GClass100.smethod_1(File.ReadAllBytes(string_0), genum3_0);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00032C30 File Offset: 0x00030E30
		public static GClass100 smethod_1(byte[] byte_10, GEnum3 genum3_0)
		{
			GClass100 gclass = new GClass100();
			MemoryStream memoryStream = new MemoryStream(byte_10);
			try
			{
				gclass.method_0(memoryStream, genum3_0);
			}
			catch
			{
				memoryStream.Dispose();
				throw;
			}
			memoryStream.Dispose();
			return gclass;
		}

		// Token: 0x04000421 RID: 1057
		[CompilerGenerated]
		private readonly byte[] byte_0;

		// Token: 0x04000422 RID: 1058
		[CompilerGenerated]
		private readonly byte[] byte_1;

		// Token: 0x04000423 RID: 1059
		[CompilerGenerated]
		private ushort ushort_0;

		// Token: 0x04000424 RID: 1060
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x04000425 RID: 1061
		[CompilerGenerated]
		private ushort ushort_1;

		// Token: 0x04000426 RID: 1062
		private uint uint_0;

		// Token: 0x04000427 RID: 1063
		private ushort ushort_2;

		// Token: 0x04000428 RID: 1064
		private byte byte_2;

		// Token: 0x04000429 RID: 1065
		private List<GClass101> list_0;

		// Token: 0x0400042A RID: 1066
		private ushort ushort_3;

		// Token: 0x0400042B RID: 1067
		private byte[] byte_3 = new byte[64];

		// Token: 0x0400042C RID: 1068
		private byte[] byte_4 = new byte[60];

		// Token: 0x0400042D RID: 1069
		private ushort ushort_4;

		// Token: 0x0400042E RID: 1070
		private ushort ushort_5;

		// Token: 0x0400042F RID: 1071
		private byte byte_5;

		// Token: 0x04000430 RID: 1072
		private ushort ushort_6;

		// Token: 0x04000431 RID: 1073
		private byte[] byte_6 = new byte[58];

		// Token: 0x04000432 RID: 1074
		private byte[] byte_7 = new byte[256];

		// Token: 0x04000433 RID: 1075
		private uint uint_1 = 65537u;

		// Token: 0x04000434 RID: 1076
		private byte byte_8;

		// Token: 0x04000435 RID: 1077
		private uint uint_2;

		// Token: 0x04000436 RID: 1078
		private byte byte_9;

		// Token: 0x04000437 RID: 1079
		private bool bool_0;
	}
}
