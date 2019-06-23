using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000112 RID: 274
	public class GClass108
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00014EEE File Offset: 0x000130EE
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00014EF6 File Offset: 0x000130F6
		public uint UInt32_0
		{
			get
			{
				return this.uint_1;
			}
			set
			{
				this.uint_1 = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00014EFF File Offset: 0x000130FF
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00014F07 File Offset: 0x00013107
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00014F10 File Offset: 0x00013110
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00014F18 File Offset: 0x00013118
		public uint UInt32_2
		{
			get
			{
				return this.uint_6;
			}
			set
			{
				this.uint_6 = value;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00033AAC File Offset: 0x00031CAC
		public void method_0(Stream stream_0)
		{
			stream_0.Seek(0L, SeekOrigin.Begin);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_3)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_7)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_0)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_4)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_5)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_6)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_1)), 0, 4);
			stream_0.Write(BitConverter.GetBytes(GClass27.smethod_5(this.uint_2)), 0, 4);
		}

		// Token: 0x0400046D RID: 1133
		private uint uint_0 = 2560u;

		// Token: 0x0400046E RID: 1134
		private uint uint_1;

		// Token: 0x0400046F RID: 1135
		private uint uint_2;

		// Token: 0x04000470 RID: 1136
		private uint uint_3 = 32u;

		// Token: 0x04000471 RID: 1137
		private uint uint_4;

		// Token: 0x04000472 RID: 1138
		private uint uint_5 = 676u;

		// Token: 0x04000473 RID: 1139
		private uint uint_6;

		// Token: 0x04000474 RID: 1140
		private uint uint_7 = 1232273408u;
	}
}
