using System;
using System.IO;
using System.Threading;

namespace ns0
{
	// Token: 0x020000B9 RID: 185
	internal class Stream0 : Stream
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x000130EB File Offset: 0x000112EB
		public Stream0(Stream stream_1) : this(stream_1, 0L)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00029F28 File Offset: 0x00028128
		public Stream0(Stream stream_1, long long_4)
		{
			if (stream_1 == null)
			{
				throw new ArgumentNullException("baseStream");
			}
			if (long_4 < 0L)
			{
				throw new ArgumentOutOfRangeException("maximumBytesPerSecond", long_4, "The maximum number of bytes per second can't be negatie.");
			}
			this.stream_0 = stream_1;
			this.long_2 = long_4;
			this.long_3 = this.Int64_1;
			this.long_1 = 0L;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000130F6 File Offset: 0x000112F6
		public override bool CanRead
		{
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00013103 File Offset: 0x00011303
		public override bool CanSeek
		{
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00013110 File Offset: 0x00011310
		public override bool CanWrite
		{
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0001311D File Offset: 0x0001131D
		public override long Length
		{
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001312A File Offset: 0x0001132A
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00013132 File Offset: 0x00011332
		public long Int64_0
		{
			get
			{
				return this.long_2;
			}
			set
			{
				if (this.Int64_0 != value)
				{
					this.long_2 = value;
					this.method_0();
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001314A File Offset: 0x0001134A
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00013157 File Offset: 0x00011357
		public override long Position
		{
			get
			{
				return this.stream_0.Position;
			}
			set
			{
				this.stream_0.Position = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00013165 File Offset: 0x00011365
		protected long Int64_1
		{
			get
			{
				return (long)Environment.TickCount;
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001316D File Offset: 0x0001136D
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001317A File Offset: 0x0001137A
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.method_1(count);
			return this.stream_0.Read(buffer, offset, count);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00013191 File Offset: 0x00011391
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.stream_0.Seek(offset, origin);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000131A0 File Offset: 0x000113A0
		public override void SetLength(long value)
		{
			this.stream_0.SetLength(value);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000131AE File Offset: 0x000113AE
		public override string ToString()
		{
			return this.stream_0.ToString();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000131BB File Offset: 0x000113BB
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.method_1(count);
			this.stream_0.Write(buffer, offset, count);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000131D2 File Offset: 0x000113D2
		protected void method_0()
		{
			if (this.Int64_1 - this.long_3 > 1000L)
			{
				this.long_1 = 0L;
				this.long_3 = this.Int64_1;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00029F88 File Offset: 0x00028188
		protected void method_1(int int_0)
		{
			if (this.long_2 > 0L && int_0 > 0)
			{
				this.long_1 += (long)int_0;
				long num = this.Int64_1 - this.long_3;
				if (num > 0L && this.long_1 * 1000L / num > this.long_2)
				{
					int num2 = (int)(this.long_1 * 1000L / this.long_2 - num);
					if (num2 > 1)
					{
						try
						{
							Thread.Sleep(num2);
						}
						catch (ThreadAbortException)
						{
						}
						this.method_0();
					}
				}
				return;
			}
		}

		// Token: 0x040002FD RID: 765
		public const long long_0 = 0L;

		// Token: 0x040002FE RID: 766
		private readonly Stream stream_0;

		// Token: 0x040002FF RID: 767
		private long long_1;

		// Token: 0x04000300 RID: 768
		private long long_2;

		// Token: 0x04000301 RID: 769
		private long long_3;
	}
}
