using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NusHelper;

namespace ns0
{
	// Token: 0x0200009D RID: 157
	public sealed class GClass78
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00012C67 File Offset: 0x00010E67
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00012C6F File Offset: 0x00010E6F
		public GStruct3 DownloadSpeed { get; private set; } = new GStruct3(0UL);

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00012C78 File Offset: 0x00010E78
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00012C80 File Offset: 0x00010E80
		public Exception LastError { get; private set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00012C89 File Offset: 0x00010E89
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00012C91 File Offset: 0x00010E91
		public ulong MaximumSpeed { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00012C9A File Offset: 0x00010E9A
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00012CA2 File Offset: 0x00010EA2
		public DataSize TotalDataDownloaded { get; set; } = new DataSize(0UL);

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00012CAB File Offset: 0x00010EAB
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00012CB3 File Offset: 0x00010EB3
		public DataSize TotalDownloadedCurrentGame { get; set; } = new DataSize(0UL);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000410 RID: 1040 RVA: 0x00026544 File Offset: 0x00024744
		// (remove) Token: 0x06000411 RID: 1041 RVA: 0x0002657C File Offset: 0x0002477C
		public event EventHandler<long> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<long> eventHandler = this.eventHandler_0;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<long> eventHandler = this.eventHandler_0;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000412 RID: 1042 RVA: 0x000265B4 File Offset: 0x000247B4
		// (remove) Token: 0x06000413 RID: 1043 RVA: 0x000265EC File Offset: 0x000247EC
		public event EventHandler<long> Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler<long> eventHandler = this.eventHandler_1;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<long> eventHandler = this.eventHandler_1;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00012CBC File Offset: 0x00010EBC
		public void method_0()
		{
			this.bool_1 = false;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00012CC7 File Offset: 0x00010EC7
		public void method_1()
		{
			this.TotalDataDownloaded = new DataSize(0UL);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00026624 File Offset: 0x00024824
		public byte[] method_2(string string_0)
		{
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(string_0);
			if (this.bool_0)
			{
				httpWebRequest.Accept = "application/json";
			}
			httpWebRequest.Method = "GET";
			this.bool_1 = true;
			httpWebRequest.Timeout = 30000;
			byte[] result;
			using (WebResponse response = httpWebRequest.GetResponse())
			{
				using (Stream responseStream = response.GetResponseStream())
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						int num;
						do
						{
							byte[] array = new byte[131072];
							num = responseStream.Read(array, 0, array.Length);
							memoryStream.Write(array, 0, num);
						}
						while (this.bool_1 && num > 0);
						memoryStream.Flush();
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00012CD6 File Offset: 0x00010ED6
		public byte[] method_3(string string_0)
		{
			return this.method_2(Class65.smethod_1(string_0, 7200));
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00026710 File Offset: 0x00024910
		public byte[] method_4(string string_0, int int_1)
		{
			string string_ = GClass88.smethod_8(string_0);
			if (GClass88.smethod_1(string_))
			{
				if ((DateTime.Now - GClass88.smethod_6(string_)).TotalHours <= (double)int_1)
				{
					return GClass88.smethod_4(string_);
				}
				byte[] byte_ = new WebClient().UploadValues(string.Format("{0}/requestZipHash.php", Class65.String_0), new NameValueCollection
				{
					{
						"url",
						Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
					}
				});
				using (MD5 md = MD5.Create())
				{
					byte[] array = GClass88.smethod_4(string_);
					if (GClass27.smethod_1(md.ComputeHash(array), byte_))
					{
						return array;
					}
				}
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(this.method_2(string.Format("{0}/zipProxy.php?url=", Class65.String_0) + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0)))))
			{
				using (ZipArchive zipArchive = new ZipArchive(memoryStream))
				{
					ZipArchiveEntry entry = zipArchive.GetEntry("content");
					byte[] array2 = new byte[entry.Length];
					using (Stream stream = entry.Open())
					{
						stream.Read(array2, 0, array2.Length);
					}
					GClass88.smethod_9(new Uri(string_0), array2);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00026898 File Offset: 0x00024A98
		public void method_5(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, long long_0 = 0L, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0)
		{
			if (genum4_0 == GClass78.GEnum4.const_1)
			{
				ulong_1 = ulong_1 / 65536UL * 65536UL;
			}
			this.bool_1 = true;
			this.DownloadSpeed = new GStruct3(0UL);
			this.TotalDataDownloaded += new DataSize(ulong_1);
			this.TotalDownloadedCurrentGame += new DataSize(ulong_1);
			this.dataSize_2 = new DataSize(0UL);
			this.timeSpan_0 = new TimeSpan(0L);
			this.dateTime_1 = new DateTime(0L);
			if (GClass28.bool_2 && ulong_1 == 0UL && long_0 > 0L)
			{
				this.method_12(string_0, string_1, ulong_1, GClass78.GEnum4.const_1, webProxy_0, byte_0, byte_1, byte_2, long_0);
				if (this.bool_1 && (!File.Exists(string_1) || new FileInfo(string_1).Length != long_0))
				{
					string text = string_1 + ".partial";
					ulong sz = 0UL;
					if (File.Exists(text))
					{
						sz = (ulong)new FileInfo(text).Length;
					}
					this.TotalDataDownloaded -= new DataSize(sz);
					this.TotalDownloadedCurrentGame -= new DataSize(sz);
					GClass6.smethod_6(text);
					GClass6.smethod_6(string_1);
					this.method_10(string_0, string_1, ulong_1, genum4_0, webProxy_0, byte_0, byte_1, byte_2, long_0);
					return;
				}
			}
			else
			{
				this.method_10(string_0, string_1, ulong_1, genum4_0, webProxy_0, byte_0, byte_1, byte_2, long_0);
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00012CE9 File Offset: 0x00010EE9
		public string method_6(string string_0)
		{
			return Encoding.UTF8.GetString(this.method_2(string_0));
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00026A04 File Offset: 0x00024C04
		public string method_7(string string_0, int int_1 = 604800)
		{
			string result;
			try
			{
				result = this.method_6(Class65.smethod_1(string_0, int_1));
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00012CFC File Offset: 0x00010EFC
		public void method_8()
		{
			this.TotalDataDownloaded -= this.TotalDownloadedCurrentGame;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600041D RID: 1053 RVA: 0x00026A3C File Offset: 0x00024C3C
		// (remove) Token: 0x0600041E RID: 1054 RVA: 0x00026A74 File Offset: 0x00024C74
		internal event EventHandler<Class56> Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Class56> eventHandler = this.eventHandler_2;
				EventHandler<Class56> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class56> value2 = (EventHandler<Class56>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class56>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Class56> eventHandler = this.eventHandler_2;
				EventHandler<Class56> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class56> value2 = (EventHandler<Class56>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class56>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00026AAC File Offset: 0x00024CAC
		internal static void smethod_0(string string_0, string string_1, byte[] byte_0, byte[] byte_1, IEnumerable<int> ienumerable_0)
		{
			foreach (int num in ienumerable_0)
			{
				long num2 = (long)(65536 * num);
				HttpWebRequest httpWebRequest = WebRequest.CreateHttp(string_0);
				httpWebRequest.Method = "GET";
				httpWebRequest.AddRange(num2);
				using (WebResponse response = httpWebRequest.GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						using (FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
						{
							fileStream.Seek(num2, SeekOrigin.Begin);
							byte[] array = new byte[65536];
							array = responseStream.smethod_3(array.Length, null);
							fileStream.Write(array, 0, array.Length);
							fileStream.Flush();
						}
					}
				}
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00012D15 File Offset: 0x00010F15
		internal void method_9()
		{
			this.TotalDownloadedCurrentGame = new DataSize(0UL);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00026BB0 File Offset: 0x00024DB0
		private void method_10(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0, long long_0 = 0L)
		{
			GClass78.Class51 @class = new GClass78.Class51();
			@class.gclass78_0 = this;
			@class.long_0 = (long)ulong_1;
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(string_0);
			httpWebRequest.Proxy = webProxy_0;
			httpWebRequest.Method = "GET";
			httpWebRequest.AddRange((long)ulong_1);
			httpWebRequest.Timeout = 10000;
			httpWebRequest.ReadWriteTimeout = 15000;
			int num = (int)(ulong_1 / 65536UL);
			using (WebResponse response = httpWebRequest.GetResponse())
			{
				GClass78.Class52 class2 = new GClass78.Class52();
				class2.class51_0 = @class;
				class2.long_0 = response.ContentLength + (long)ulong_1;
				using (Stream0 stream = new Stream0(response.GetResponseStream()))
				{
					int bufferSize = GClass28.bool_0 ? 4096 : 65536;
					using (FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite, bufferSize))
					{
						fileStream.Seek((long)ulong_1, SeekOrigin.Begin);
						while (this.bool_1 && class2.class51_0.long_0 < class2.long_0)
						{
							byte[] array = new byte[65536];
							stream.Int64_0 = (long)this.MaximumSpeed;
							long num3;
							if (genum4_0 == GClass78.GEnum4.const_1)
							{
								Stream stream_ = stream;
								int num2 = array.Length;
								Action<int> action_;
								if ((action_ = class2.action_0) == null)
								{
									action_ = (class2.action_0 = new Action<int>(class2.method_0));
								}
								array = stream_.smethod_3(num2, action_);
								if (array.Length < 65536)
								{
									throw new Exception("Block has invalid size");
								}
								if (GClass28.bool_1 && Class83.smethod_0(array, byte_0, num, byte_1, byte_2) == Enum3.const_1)
								{
									throw new Exception("Invalid block");
								}
								num++;
								num3 = 65536L;
							}
							else
							{
								num3 = (long)stream.Read(array, 0, array.Length);
								class2.class51_0.long_0 = class2.class51_0.long_0 + num3;
								this.method_11(new Class56(num3, class2.class51_0.long_0, class2.long_0));
							}
							if (num3 == 0L)
							{
								break;
							}
							fileStream.Write(array, 0, (int)num3);
						}
						fileStream.Flush();
					}
				}
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00026E04 File Offset: 0x00025004
		private void method_11(Class56 class56_0)
		{
			DataSize bt = new DataSize((ulong)class56_0.long_0);
			this.dateTime_0 = DateTime.Now;
			this.TotalDownloadedCurrentGame += bt;
			this.TotalDataDownloaded += bt;
			this.dataSize_2 += bt;
			this.timeSpan_0 = DateTime.Now - this.dateTime_1;
			if (this.timeSpan_0.TotalSeconds >= 1.0)
			{
				this.DownloadSpeed = new GStruct3(this.dataSize_2, this.timeSpan_0);
				this.dataSize_2 = new DataSize(0UL);
				this.dateTime_1 = DateTime.Now;
			}
			EventHandler<Class56> eventHandler = this.eventHandler_2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler.BeginInvoke(this, class56_0, null, null);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00026ED0 File Offset: 0x000250D0
		private void method_12(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0, long long_0 = 0L)
		{
			GClass78.Class53 @class = new GClass78.Class53();
			@class.long_0 = long_0;
			@class.byte_0 = byte_0;
			@class.byte_1 = byte_1;
			@class.byte_2 = byte_2;
			@class.string_0 = string_0;
			@class.webProxy_0 = webProxy_0;
			@class.gclass78_0 = this;
			@class.long_1 = 0L;
			int num = 3;
			List<Task> list = new List<Task>();
			long num2 = (long)Math.Ceiling((double)@class.long_0 / 65536.0);
			EventHandler<long> eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(this, num2);
			}
			if (num2 < (long)num)
			{
				num = (int)num2;
			}
			long num3 = num2 / (long)num;
			GClass6.smethod_6(string_1);
			@class.bool_0 = false;
			GClass78.Class54 class2 = new GClass78.Class54();
			class2.class53_0 = @class;
			class2.fileStream_0 = File.Create(string_1 + ".partial", 65536);
			try
			{
				for (int i = 0; i < num; i++)
				{
					GClass78.Class55 class3 = new GClass78.Class55();
					class3.class54_0 = class2;
					class3.long_1 = num3;
					if (i == num - 1)
					{
						class3.long_1 += num2 % (long)num;
					}
					class3.long_0 = num3 * (long)i * 65536L;
					class3.int_0 = (int)num3 * i;
					if (class3.long_0 > class3.class54_0.class53_0.long_0)
					{
						break;
					}
					class3.httpWebRequest_0 = WebRequest.CreateHttp(class3.class54_0.class53_0.string_0);
					class3.httpWebRequest_0.AddRange(class3.long_0);
					class3.httpWebRequest_0.Proxy = class3.class54_0.class53_0.webProxy_0;
					Task item = new Task(new Action(class3.method_0));
					list.Add(item);
				}
				foreach (Task task in list)
				{
					task.Start();
				}
				foreach (Task task2 in list)
				{
					task2.Wait();
				}
				if (class2.fileStream_0.Length != class2.class53_0.long_0)
				{
					class2.class53_0.bool_0 = true;
				}
			}
			finally
			{
				if (class2.fileStream_0 != null)
				{
					((IDisposable)class2.fileStream_0).Dispose();
				}
			}
			if (this.bool_1 && !@class.bool_0)
			{
				File.Move(string_1 + ".partial", string_1);
			}
		}

		// Token: 0x0400026E RID: 622
		public bool bool_0;

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private GStruct3 gstruct3_0;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private Exception exception_0;

		// Token: 0x04000271 RID: 625
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private DataSize dataSize_0;

		// Token: 0x04000273 RID: 627
		[CompilerGenerated]
		private DataSize dataSize_1;

		// Token: 0x04000274 RID: 628
		[CompilerGenerated]
		private EventHandler<long> eventHandler_0;

		// Token: 0x04000275 RID: 629
		[CompilerGenerated]
		private EventHandler<long> eventHandler_1;

		// Token: 0x04000276 RID: 630
		internal volatile bool bool_1 = true;

		// Token: 0x04000277 RID: 631
		[CompilerGenerated]
		private EventHandler<Class56> eventHandler_2;

		// Token: 0x04000278 RID: 632
		private const int int_0 = 1;

		// Token: 0x04000279 RID: 633
		private TimeSpan timeSpan_0 = new TimeSpan(0L);

		// Token: 0x0400027A RID: 634
		private DateTime dateTime_0 = new DateTime(0L);

		// Token: 0x0400027B RID: 635
		private DateTime dateTime_1 = new DateTime(0L);

		// Token: 0x0400027C RID: 636
		private DataSize dataSize_2 = new DataSize(0UL);

		// Token: 0x0400027D RID: 637
		private object object_0 = new object();

		// Token: 0x0200009E RID: 158
		public enum GEnum4
		{
			// Token: 0x0400027F RID: 639
			const_0,
			// Token: 0x04000280 RID: 640
			const_1
		}

		// Token: 0x0200009F RID: 159
		[CompilerGenerated]
		private sealed class Class51
		{
			// Token: 0x04000281 RID: 641
			public long long_0;

			// Token: 0x04000282 RID: 642
			public GClass78 gclass78_0;
		}

		// Token: 0x020000A0 RID: 160
		[CompilerGenerated]
		private sealed class Class52
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x00027198 File Offset: 0x00025398
			internal void method_0(int int_0)
			{
				this.class51_0.long_0 = this.class51_0.long_0 + (long)int_0;
				this.class51_0.gclass78_0.method_11(new Class56((long)int_0, this.class51_0.long_0, this.long_0));
			}

			// Token: 0x04000283 RID: 643
			public long long_0;

			// Token: 0x04000284 RID: 644
			public GClass78.Class51 class51_0;

			// Token: 0x04000285 RID: 645
			public Action<int> action_0;
		}

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		private sealed class Class53
		{
			// Token: 0x04000286 RID: 646
			public long long_0;

			// Token: 0x04000287 RID: 647
			public byte[] byte_0;

			// Token: 0x04000288 RID: 648
			public byte[] byte_1;

			// Token: 0x04000289 RID: 649
			public byte byte_2;

			// Token: 0x0400028A RID: 650
			public long long_1;

			// Token: 0x0400028B RID: 651
			public string string_0;

			// Token: 0x0400028C RID: 652
			public WebProxy webProxy_0;

			// Token: 0x0400028D RID: 653
			public GClass78 gclass78_0;

			// Token: 0x0400028E RID: 654
			public bool bool_0;
		}

		// Token: 0x020000A2 RID: 162
		[CompilerGenerated]
		private sealed class Class54
		{
			// Token: 0x0400028F RID: 655
			public FileStream fileStream_0;

			// Token: 0x04000290 RID: 656
			public GClass78.Class53 class53_0;
		}

		// Token: 0x020000A3 RID: 163
		[CompilerGenerated]
		private sealed class Class55
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x000271E8 File Offset: 0x000253E8
			internal void method_0()
			{
				WebResponse webResponse = null;
				Stream stream = null;
				byte[] array = new byte[65536];
				try
				{
					long num = this.long_0;
					webResponse = this.httpWebRequest_0.GetResponse();
					stream = webResponse.GetResponseStream();
					int num2 = 0;
					long num3 = this.long_1 * 65536L;
					if (num + num3 > this.class54_0.class53_0.long_0)
					{
						num3 = this.class54_0.class53_0.long_0 - num;
					}
					for (;;)
					{
						while (!this.class54_0.class53_0.bool_0 && this.class54_0.class53_0.gclass78_0.bool_1 && (long)num2 < num3)
						{
							int num5;
							if (this.class54_0.class53_0.byte_0 != null)
							{
								array = stream.smethod_3(65536, null);
								if (this.class54_0.class53_0.byte_0 != null)
								{
									int num4;
									if (array.Length == 65536)
									{
										if (!GClass28.bool_1)
										{
											goto IL_12D;
										}
										byte[] byte_ = array;
										byte[] byte_2 = this.class54_0.class53_0.byte_0;
										num4 = this.int_0;
										this.int_0 = num4 + 1;
										if (Class83.smethod_0(byte_, byte_2, num4, this.class54_0.class53_0.byte_1, this.class54_0.class53_0.byte_2) != Enum3.const_1)
										{
											goto IL_12D;
										}
									}
									num4 = this.int_0;
									this.int_0 = num4 - 1;
									num2 -= array.Length;
									this.class54_0.class53_0.long_1 = this.class54_0.class53_0.long_1 - (long)array.Length;
									if (stream != null)
									{
										stream.Dispose();
									}
									if (webResponse != null)
									{
										webResponse.Dispose();
									}
									HttpWebRequest httpWebRequest = WebRequest.CreateHttp(this.class54_0.class53_0.string_0);
									httpWebRequest.Proxy = this.class54_0.class53_0.webProxy_0;
									httpWebRequest.AddRange(num);
									webResponse = httpWebRequest.GetResponse();
									stream = webResponse.GetResponseStream();
									continue;
								}
								IL_12D:
								num5 = 65536;
							}
							else
							{
								num5 = stream.Read(array, 0, array.Length);
								if (num5 == 0)
								{
									break;
								}
								int num4 = this.int_0;
								this.int_0 = num4 + 1;
							}
							EventHandler<long> eventHandler_ = this.class54_0.class53_0.gclass78_0.eventHandler_1;
							if (eventHandler_ != null)
							{
								eventHandler_(this.class54_0.class53_0.gclass78_0, (long)(this.int_0 - 1));
							}
							this.class54_0.class53_0.gclass78_0.method_11(new Class56((long)num5, this.class54_0.class53_0.long_1, this.class54_0.class53_0.long_0));
							num2 += num5;
							this.class54_0.class53_0.long_1 = this.class54_0.class53_0.long_1 + (long)num5;
							object object_ = this.class54_0.class53_0.gclass78_0.object_0;
							lock (object_)
							{
								this.class54_0.fileStream_0.Seek(num, SeekOrigin.Begin);
								this.class54_0.fileStream_0.Write(array, 0, num5);
							}
							num = this.long_0 + (long)num2;
						}
						break;
					}
				}
				catch
				{
					this.class54_0.class53_0.bool_0 = true;
				}
				finally
				{
					if (webResponse != null)
					{
						webResponse.Dispose();
					}
					if (stream != null)
					{
						stream.Dispose();
					}
				}
			}

			// Token: 0x04000291 RID: 657
			public long long_0;

			// Token: 0x04000292 RID: 658
			public HttpWebRequest httpWebRequest_0;

			// Token: 0x04000293 RID: 659
			public long long_1;

			// Token: 0x04000294 RID: 660
			public int int_0;

			// Token: 0x04000295 RID: 661
			public GClass78.Class54 class54_0;
		}
	}
}
