using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000125 RID: 293
	internal class Stream1 : Stream
	{
		// Token: 0x0600081B RID: 2075 RVA: 0x00015475 File Offset: 0x00013675
		public Stream1(IList<Stream> ilist_2) : this(ilist_2, null)
		{
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00033E94 File Offset: 0x00032094
		public Stream1(IList<Stream> ilist_2, IList<int> ilist_3)
		{
			if (ilist_2 == null)
			{
				throw new ArgumentNullException("streams");
			}
			this.ilist_0 = ilist_2;
			this.ilist_1 = ilist_3;
			if (ilist_2.Count > 0)
			{
				int num = this.int_0;
				this.int_0 = num + 1;
				this.stream_0 = ilist_2[num];
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0001547F File Offset: 0x0001367F
		public IList<Stream> IList_0
		{
			get
			{
				return this.ilist_0;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00015487 File Offset: 0x00013687
		public override void Flush()
		{
			if (this.stream_0 != null)
			{
				this.stream_0.Flush();
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0001549C File Offset: 0x0001369C
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new InvalidOperationException("Stream is not seekable.");
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000154A8 File Offset: 0x000136A8
		public override void SetLength(long value)
		{
			this.long_0 = value;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00033EF4 File Offset: 0x000320F4
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = 0;
			int num2 = offset;
			while (count > 0)
			{
				int num3 = this.stream_0.Read(buffer, num2, count);
				num += num3;
				num2 += num3;
				this.long_1 += (long)num3;
				if (num3 <= count)
				{
					count -= num3;
				}
				if (count > 0)
				{
					if (this.int_0 >= this.ilist_0.Count)
					{
						break;
					}
					IList<Stream> list = this.ilist_0;
					int num4 = this.int_0;
					this.int_0 = num4 + 1;
					this.stream_0 = list[num4];
				}
			}
			return num;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00033F78 File Offset: 0x00032178
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			Stream1.Class93 @class = new Stream1.Class93();
			@class.stream1_0 = this;
			@class.int_0 = count;
			@class.asyncCallback_0 = callback;
			@class.byte_0 = buffer;
			@class.class92_0 = new Stream1.Class92(state);
			if (@class.int_0 > 0)
			{
				Stream1.Class94 class2 = new Stream1.Class94();
				class2.class93_0 = @class;
				class2.int_0 = offset;
				class2.asyncCallback_0 = null;
				class2.asyncCallback_0 = new AsyncCallback(class2.method_0);
				this.stream_0.BeginRead(class2.class93_0.byte_0, class2.int_0, class2.class93_0.int_0, class2.asyncCallback_0, state);
			}
			else
			{
				@class.class92_0.CompletedSynchronously = true;
				@class.class92_0.method_0();
				@class.class92_0.IsCompleted = true;
				@class.asyncCallback_0(@class.class92_0);
			}
			return @class.class92_0;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00034058 File Offset: 0x00032258
		public override int EndRead(IAsyncResult asyncResult)
		{
			asyncResult.AsyncWaitHandle.WaitOne();
			Stream1.Class92 @class = (Stream1.Class92)asyncResult;
			if (@class.Exception != null)
			{
				throw @class.Exception;
			}
			return @class.int_0;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000154B1 File Offset: 0x000136B1
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new InvalidOperationException("Stream is not writable");
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000154B1 File Offset: 0x000136B1
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new InvalidOperationException("Stream is not writable");
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00034090 File Offset: 0x00032290
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (this.ilist_1 == null)
			{
				using (IEnumerator<Stream> enumerator = this.IList_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Stream stream = enumerator.Current;
						stream.Dispose();
					}
					return;
				}
			}
			for (int i = 0; i < this.IList_0.Count; i++)
			{
				this.IList_0[i].Dispose();
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00011A1C File Offset: 0x0000FC1C
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00014224 File Offset: 0x00012424
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00014224 File Offset: 0x00012424
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00034114 File Offset: 0x00032314
		public override long Length
		{
			get
			{
				if (this.long_0 == -1L)
				{
					this.long_0 = 0L;
					foreach (Stream stream in this.ilist_0)
					{
						this.long_0 += stream.Length;
					}
				}
				return this.long_0;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x000154BD File Offset: 0x000136BD
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00013DF7 File Offset: 0x00011FF7
		public override long Position
		{
			get
			{
				return this.long_1;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x040004BB RID: 1211
		private readonly IList<Stream> ilist_0;

		// Token: 0x040004BC RID: 1212
		private readonly IList<int> ilist_1;

		// Token: 0x040004BD RID: 1213
		private int int_0;

		// Token: 0x040004BE RID: 1214
		private Stream stream_0;

		// Token: 0x040004BF RID: 1215
		private long long_0 = -1L;

		// Token: 0x040004C0 RID: 1216
		private long long_1;

		// Token: 0x02000126 RID: 294
		internal class Class92 : IAsyncResult
		{
			// Token: 0x0600082D RID: 2093 RVA: 0x000154C5 File Offset: 0x000136C5
			public Class92(object object_1)
			{
				this.object_0 = object_1;
				this.manualResetEvent_0 = new ManualResetEvent(false);
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x000154E0 File Offset: 0x000136E0
			// (set) Token: 0x0600082F RID: 2095 RVA: 0x000154E8 File Offset: 0x000136E8
			public bool IsCompleted { get; internal set; }

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06000830 RID: 2096 RVA: 0x000154F1 File Offset: 0x000136F1
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					return this.manualResetEvent_0;
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x06000831 RID: 2097 RVA: 0x000154F9 File Offset: 0x000136F9
			public object AsyncState
			{
				get
				{
					return this.object_0;
				}
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000832 RID: 2098 RVA: 0x00015501 File Offset: 0x00013701
			// (set) Token: 0x06000833 RID: 2099 RVA: 0x00015509 File Offset: 0x00013709
			public bool CompletedSynchronously { get; internal set; }

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x06000834 RID: 2100 RVA: 0x00015512 File Offset: 0x00013712
			// (set) Token: 0x06000835 RID: 2101 RVA: 0x0001551A File Offset: 0x0001371A
			public Exception Exception { get; internal set; }

			// Token: 0x06000836 RID: 2102 RVA: 0x00015523 File Offset: 0x00013723
			internal void method_0()
			{
				this.manualResetEvent_0.Set();
			}

			// Token: 0x040004C1 RID: 1217
			private readonly object object_0;

			// Token: 0x040004C2 RID: 1218
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x040004C3 RID: 1219
			[CompilerGenerated]
			private bool bool_1;

			// Token: 0x040004C4 RID: 1220
			[CompilerGenerated]
			private Exception exception_0;

			// Token: 0x040004C5 RID: 1221
			private readonly ManualResetEvent manualResetEvent_0;

			// Token: 0x040004C6 RID: 1222
			public int int_0;
		}

		// Token: 0x02000127 RID: 295
		[CompilerGenerated]
		private sealed class Class93
		{
			// Token: 0x040004C7 RID: 1223
			public Stream1 stream1_0;

			// Token: 0x040004C8 RID: 1224
			public Stream1.Class92 class92_0;

			// Token: 0x040004C9 RID: 1225
			public int int_0;

			// Token: 0x040004CA RID: 1226
			public AsyncCallback asyncCallback_0;

			// Token: 0x040004CB RID: 1227
			public byte[] byte_0;
		}

		// Token: 0x02000128 RID: 296
		[CompilerGenerated]
		private sealed class Class94
		{
			// Token: 0x06000839 RID: 2105 RVA: 0x00034188 File Offset: 0x00032388
			internal void method_0(IAsyncResult iasyncResult_0)
			{
				try
				{
					int num = this.class93_0.stream1_0.stream_0.EndRead(iasyncResult_0);
					this.class93_0.class92_0.int_0 += num;
					this.int_0 += num;
					this.class93_0.stream1_0.long_1 = this.class93_0.stream1_0.long_1 + (long)num;
					if (num <= this.class93_0.int_0)
					{
						this.class93_0.int_0 = this.class93_0.int_0 - num;
					}
					if (this.class93_0.int_0 > 0)
					{
						if (this.class93_0.stream1_0.int_0 >= this.class93_0.stream1_0.ilist_0.Count)
						{
							this.class93_0.class92_0.CompletedSynchronously = false;
							this.class93_0.class92_0.method_0();
							this.class93_0.class92_0.IsCompleted = true;
							this.class93_0.asyncCallback_0(this.class93_0.class92_0);
						}
						else
						{
							Stream1 stream1_ = this.class93_0.stream1_0;
							IList<Stream> ilist_ = this.class93_0.stream1_0.ilist_0;
							Stream1 stream1_2 = this.class93_0.stream1_0;
							int num2 = this.class93_0.stream1_0.int_0;
							stream1_2.int_0 = num2 + 1;
							stream1_.stream_0 = ilist_[num2];
							this.class93_0.stream1_0.stream_0.BeginRead(this.class93_0.byte_0, this.int_0, this.class93_0.int_0, this.asyncCallback_0, iasyncResult_0.AsyncState);
						}
					}
					else
					{
						this.class93_0.class92_0.CompletedSynchronously = false;
						this.class93_0.class92_0.method_0();
						this.class93_0.class92_0.IsCompleted = true;
						this.class93_0.asyncCallback_0(this.class93_0.class92_0);
					}
				}
				catch (Exception exception)
				{
					this.class93_0.class92_0.Exception = exception;
					this.class93_0.class92_0.CompletedSynchronously = false;
					this.class93_0.class92_0.method_0();
					this.class93_0.class92_0.IsCompleted = true;
					this.class93_0.asyncCallback_0(this.class93_0.class92_0);
				}
			}

			// Token: 0x040004CC RID: 1228
			public int int_0;

			// Token: 0x040004CD RID: 1229
			public AsyncCallback asyncCallback_0;

			// Token: 0x040004CE RID: 1230
			public Stream1.Class93 class93_0;
		}
	}
}
