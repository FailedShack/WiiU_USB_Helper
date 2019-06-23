using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using NusHelper;

namespace ns0
{
	// Token: 0x020000AB RID: 171
	public sealed class GClass80 : IDisposable
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x00028548 File Offset: 0x00026748
		public GClass80(WebProxy webProxy_1, bool bool_5, bool bool_6)
		{
			this.Proxy = webProxy_1;
			this.gclass78_0.Event_2 += this.method_8;
			this.gclass78_0.Event_1 += this.method_19;
			this.gclass78_0.Event_0 += this.method_20;
			NetworkChange.NetworkAvailabilityChanged += this.method_7;
			this.bool_2 = bool_5;
			this.bool_3 = bool_6;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00012EBC File Offset: 0x000110BC
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00012EC4 File Offset: 0x000110C4
		public WebProxy Proxy { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00012ECD File Offset: 0x000110CD
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00012ED5 File Offset: 0x000110D5
		public ulong MaxSpeed { get; private set; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600045F RID: 1119 RVA: 0x00028630 File Offset: 0x00026830
		// (remove) Token: 0x06000460 RID: 1120 RVA: 0x00028668 File Offset: 0x00026868
		public event EventHandler<bool> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<bool> eventHandler = this.eventHandler_0;
				EventHandler<bool> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<bool> value2 = (EventHandler<bool>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<bool>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<bool> eventHandler = this.eventHandler_0;
				EventHandler<bool> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<bool> value2 = (EventHandler<bool>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<bool>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000461 RID: 1121 RVA: 0x000286A0 File Offset: 0x000268A0
		// (remove) Token: 0x06000462 RID: 1122 RVA: 0x000286D8 File Offset: 0x000268D8
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

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000463 RID: 1123 RVA: 0x00028710 File Offset: 0x00026910
		// (remove) Token: 0x06000464 RID: 1124 RVA: 0x00028748 File Offset: 0x00026948
		public event EventHandler<long> Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler<long> eventHandler = this.eventHandler_2;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<long> eventHandler = this.eventHandler_2;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00028780 File Offset: 0x00026980
		public ulong UInt64_0
		{
			get
			{
				try
				{
					if (this.list_0.Count > 0)
					{
						return (ulong)this.list_0.Average();
					}
				}
				catch
				{
				}
				return 0UL;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00012EDE File Offset: 0x000110DE
		public void method_0()
		{
			this.bool_0 = false;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000287C4 File Offset: 0x000269C4
		public void method_1(List<GClass30> list_2, int int_6 = 100, int int_7 = 10000)
		{
			GClass80.Class60 @class = new GClass80.Class60();
			@class.gclass80_0 = this;
			@class.list_0 = list_2;
			@class.int_0 = int_6;
			@class.int_1 = int_7;
			new Thread(new ThreadStart(@class.method_0))
			{
				IsBackground = true,
				ApartmentState = ApartmentState.STA,
				Priority = ThreadPriority.Highest
			}.Start();
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0002881C File Offset: 0x00026A1C
		private void method_2(List<GClass30> list_2)
		{
			this.dataSize_0 = new DataSize(0UL);
			this.timeSpan_2 = new TimeSpan(0L);
			this.timeSpan_1 = new TimeSpan(0L);
			this.gstruct3_0 = new GStruct3(0UL);
			this.dataSize_1 = new DataSize(0UL);
			this.list_1 = list_2;
			this.method_3();
			for (int i = this.int_0; i < list_2.Count; i++)
			{
				EventHandler<GClass79> eventHandler = this.eventHandler_4;
				if (eventHandler != null)
				{
					eventHandler(this, new GClass79(list_2[i], i));
				}
				this.method_17(string.Format("----Downloading game #{0} out of {1}----", this.int_0 + 1, list_2.Count));
				bool flag = this.method_14(list_2[i]) == GClass80.Enum1.const_0;
				list_2[i].CurrentlyDownloaded = false;
				list_2[i].method_6();
				if (!flag)
				{
					return;
				}
				if (!this.bool_0)
				{
					return;
				}
				this.int_0++;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00028920 File Offset: 0x00026B20
		public void method_3()
		{
			this.dataSize_1 = new DataSize(0UL);
			foreach (GClass30 gclass in this.list_1)
			{
				if (gclass.Boolean_0)
				{
					this.dataSize_1 += 0UL;
				}
				else
				{
					this.dataSize_1 += this.method_15(gclass, false).DataSize_0;
				}
			}
			this.method_17(string.Format("Total content size is {0}", this.dataSize_1));
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00012EE9 File Offset: 0x000110E9
		public void method_4(ulong ulong_1)
		{
			this.gclass78_0.MaximumSpeed = ulong_1;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00012EF7 File Offset: 0x000110F7
		public void Dispose()
		{
			this.method_6(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000289D0 File Offset: 0x00026BD0
		~GClass80()
		{
			this.method_6(false);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00028A00 File Offset: 0x00026C00
		private static int smethod_0(DataSize dataSize_2, DataSize dataSize_3)
		{
			int num = (int)Math.Floor(dataSize_3.TotalBytes / dataSize_2.TotalBytes * 100.0);
			if (num < 0)
			{
				num = 0;
			}
			if (num > 100)
			{
				num = 100;
			}
			return num;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00028A40 File Offset: 0x00026C40
		public static int smethod_1(long long_0, long long_1)
		{
			if (long_1 == 0L)
			{
				return 0;
			}
			int result;
			try
			{
				int num = (int)Math.Floor((double)long_0 / (double)long_1 * 100.0);
				if (num < 0)
				{
					num = 0;
				}
				if (num > 100)
				{
					num = 100;
				}
				result = num;
			}
			catch
			{
				result = 100;
			}
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00012F06 File Offset: 0x00011106
		private void method_5(string string_0)
		{
			this.gclass78_0.method_0();
			throw new GException1(string_0);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00012F19 File Offset: 0x00011119
		private void method_6(bool bool_5)
		{
			this.bool_4 = true;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00012F22 File Offset: 0x00011122
		private void method_7(object sender, NetworkAvailabilityEventArgs e)
		{
			this.bool_1 = e.IsAvailable;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00028A94 File Offset: 0x00026C94
		private void method_8(object object_0, Class56 class56_0)
		{
			GClass78 gclass = (GClass78)object_0;
			if (!this.bool_1)
			{
				this.method_5("Network lost");
			}
			if (!this.bool_0)
			{
				this.gclass78_0.method_0();
			}
			this.gstruct3_0 = gclass.DownloadSpeed;
			ulong num = this.gstruct3_0.ulong_0;
			if (num > this.MaxSpeed)
			{
				this.MaxSpeed = num;
			}
			try
			{
				this.timeSpan_1 = GStruct3.smethod_1(this.dataSize_0.Diff(gclass.TotalDownloadedCurrentGame), this.gstruct3_0);
				this.timeSpan_2 = GStruct3.smethod_1(this.dataSize_1.Diff(gclass.TotalDataDownloaded), this.gstruct3_0);
				this.timeSpan_0 = GStruct3.smethod_1(new DataSize((ulong)class56_0.long_2).Diff(new DataSize((ulong)class56_0.long_1)), this.gstruct3_0);
				this.int_4 = GClass80.smethod_0(this.dataSize_0, gclass.TotalDownloadedCurrentGame);
				this.int_5 = GClass80.smethod_0(this.dataSize_1, gclass.TotalDataDownloaded);
				this.int_3 = (int)((double)class56_0.long_1 / (double)class56_0.long_2 * 100.0);
				int num2 = this.int_1;
				this.int_1 = num2 + 1;
				if (num2 == 8)
				{
					this.list_0.Add((int)this.gstruct3_0.ulong_0);
					this.int_1 = 0;
				}
				this.method_16(this.int_4, this.int_5, this.int_3, this.timeSpan_1, this.timeSpan_2, this.timeSpan_0, this.gstruct3_0, null);
			}
			catch
			{
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00028C40 File Offset: 0x00026E40
		private void method_9(GClass30 gclass30_0, GClass100 gclass100_0, string string_0)
		{
			this.method_17("Computing title.cert...");
			string text = Path.Combine(string_0, "title.cert");
			if (gclass30_0.System == GEnum3.const_3)
			{
				File.WriteAllBytes(text, GClass96.byte_0);
				return;
			}
			if (gclass30_0.Platform == Platform.Wii_U_Custom)
			{
				this.gclass78_0.method_5(string.Format("{0}cert", gclass30_0.String_1), text, 0UL, GClass78.GEnum4.const_0, this.Proxy, 0L, null, null, 0);
				return;
			}
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(text, FileMode.Create)))
			{
				binaryWriter.Write(gclass100_0.Certificate1);
				binaryWriter.Write(gclass100_0.Certificate2);
				binaryWriter.Write(GClass100.Byte_0);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00028CFC File Offset: 0x00026EFC
		private GClass80.Enum1 method_10(GClass30 gclass30_0, GClass101 gclass101_0, string string_0, GClass80.Enum0 enum0_0, ulong ulong_1 = 0UL)
		{
			string text = gclass101_0.ContentId.ToString("x8") + ((enum0_0 == GClass80.Enum0.const_0) ? ".h3" : "");
			this.method_17(string.Format("Downloading of {0} initiated.", text));
			if (this.Proxy != null)
			{
				this.method_17(string.Format("Using proxy {0}", this.Proxy.Address));
			}
			if (enum0_0 == GClass80.Enum0.const_0)
			{
				this.gclass78_0.method_5(gclass30_0.String_1 + text, string_0 + ".h3", ulong_1, GClass78.GEnum4.const_0, this.Proxy, 0L, null, null, 0);
			}
			else if (gclass101_0.Boolean_0)
			{
				this.gclass78_0.method_5(gclass30_0.String_1 + text, string_0 + ".app", ulong_1, GClass78.GEnum4.const_1, this.Proxy, (long)gclass101_0.Size.TotalBytes, File.ReadAllBytes(string_0 + ".h3"), gclass30_0.Ticket.Byte_0, (byte)gclass101_0.Index);
			}
			else
			{
				this.gclass78_0.method_5(gclass30_0.String_1 + text, string_0 + ".app", ulong_1, GClass78.GEnum4.const_0, this.Proxy, (long)gclass101_0.Size.TotalBytes, null, null, 0);
			}
			if (!this.gclass78_0.bool_1)
			{
				return GClass80.Enum1.const_1;
			}
			return GClass80.Enum1.const_0;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00028E54 File Offset: 0x00027054
		private GClass99 method_11(GClass30 gclass30_0)
		{
			this.method_17("Fetching Ticket...");
			string text = Path.Combine(gclass30_0.OutputPath, "title.tik");
			if (gclass30_0.Platform != Platform.Wii_U_Custom)
			{
				if (!(gclass30_0 is GClass33) || gclass30_0.System != GEnum3.const_1)
				{
					if (!gclass30_0.bool_0)
					{
						this.method_17("Generating ticket");
						File.WriteAllBytes(text, gclass30_0.TicketArray);
						return gclass30_0.Ticket;
					}
					this.method_17("Downloading ticket from that site");
					byte[] array = File.ReadAllBytes(Path.Combine(Path.Combine(GClass88.CachePath, "tickets"), gclass30_0.TitleId.IdRaw + ".tik"));
					gclass30_0.TicketArray = array;
					File.WriteAllBytes(text, array);
					gclass30_0.Ticket = GClass99.smethod_7(gclass30_0.TicketArray, gclass30_0.System);
					return gclass30_0.Ticket;
				}
			}
			this.method_17("Downloading Ticket from NUS");
			this.gclass78_0.method_5(string.Format("{0}cetk", gclass30_0.String_1), text, 0UL, GClass78.GEnum4.const_0, this.Proxy, 0L, null, null, 0);
			gclass30_0.TicketArray = File.ReadAllBytes(text);
			gclass30_0.Ticket = GClass99.smethod_6(text, gclass30_0.System);
			return gclass30_0.Ticket;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00012F32 File Offset: 0x00011132
		private GClass80.Enum1 method_12(GClass32 gclass32_0)
		{
			new frmInjection(gclass32_0).ShowDialog();
			return GClass80.Enum1.const_0;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00012F41 File Offset: 0x00011141
		private void method_13(bool bool_5)
		{
			EventHandler<bool> eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, bool_5);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00028F88 File Offset: 0x00027188
		private GClass80.Enum1 method_14(GClass30 gclass30_0)
		{
			GClass80.Class61 @class = new GClass80.Class61();
			@class.gclass30_0 = gclass30_0;
			GEnum2 genum2_ = @class.gclass30_0.GEnum2_0;
			this.gclass78_0.method_9();
			this.timeSpan_1 = new TimeSpan(0L);
			this.timeSpan_0 = new TimeSpan(0L);
			this.gstruct3_0 = new GStruct3(0UL);
			@class.gclass30_0.CurrentlyDownloaded = true;
			if (!Directory.Exists(@class.gclass30_0.OutputPath))
			{
				Directory.CreateDirectory(@class.gclass30_0.OutputPath);
			}
			if (@class.gclass30_0.Boolean_0)
			{
				return this.method_12((GClass32)@class.gclass30_0);
			}
			GClass100 gclass = this.method_15(@class.gclass30_0, true);
			GClass99 gclass2 = this.method_11(@class.gclass30_0);
			if (@class.gclass30_0.System == GEnum3.const_1 || @class.gclass30_0.System == GEnum3.const_3)
			{
				this.method_9(@class.gclass30_0, gclass, @class.gclass30_0.OutputPath);
			}
			this.dataSize_0 = gclass.DataSize_0;
			this.method_17(string.Format("Content size is {0}", this.dataSize_0));
			this.method_16(0, this.int_5, 0, this.timeSpan_1, this.timeSpan_2, this.timeSpan_0, new GStruct3(0UL), @class.gclass30_0);
			int i = 0;
			while (i < (int)gclass.NumOfContents)
			{
				bool flag = false;
				if (!this.bool_0)
				{
					return GClass80.Enum1.const_1;
				}
				GClass101 gclass3;
				for (;;)
				{
					gclass3 = gclass.GClass101_0[i];
					this.method_17(string.Format("Downloading Content #{0} ({1:x8}) of {2}... ({3})", new object[]
					{
						i + 1,
						gclass3.ContentId,
						gclass.NumOfContents,
						gclass3.Size
					}));
					string text = Path.Combine(@class.gclass30_0.OutputPath, gclass3.ContentId.ToString("x8"));
					ulong num = 0UL;
					GClass6.smethod_6(text + ".app.partial");
					if (File.Exists(text + ".app"))
					{
						goto IL_48A;
					}
					IL_161:
					try
					{
						Class62.SetThreadExecutionState(2147483649u);
						this.method_17("Downloading content...");
						if (gclass3.Boolean_0)
						{
							this.method_10(@class.gclass30_0, gclass3, text, GClass80.Enum0.const_0, 0UL);
						}
						bool flag2 = false;
						if (@class.gclass30_0 is GClass33 && gclass3.Boolean_0)
						{
							IEnumerable<GClass33> updates = @class.gclass30_0.GClass32_0.Updates;
							Func<GClass33, bool> predicate;
							if ((predicate = @class.func_0) == null)
							{
								predicate = (@class.func_0 = new Func<GClass33, bool>(@class.method_0));
							}
							foreach (GClass33 gclass4 in updates.Where(predicate))
							{
								string str = Path.Combine(gclass4.OutputPath, gclass3.ContentId.ToString("x8"));
								string text2 = str + ".app";
								string path = str + ".h3";
								if (File.Exists(path) && File.Exists(text2) && File.ReadAllBytes(path).smethod_5(File.ReadAllBytes(text + ".h3")) && new FileInfo(text2).Length == (long)gclass3.Size.TotalBytes)
								{
									this.method_17("Found similar file in older update. Copying...");
									File.Copy(text2, text + ".app", true);
									this.gclass78_0.TotalDownloadedCurrentGame += gclass3.Size.TotalBytes;
									this.gclass78_0.TotalDataDownloaded += gclass3.Size;
									flag2 = true;
									break;
								}
							}
						}
						if (flag2)
						{
							break;
						}
						if (this.method_10(@class.gclass30_0, gclass3, text, GClass80.Enum0.const_1, num) == GClass80.Enum1.const_1)
						{
							return GClass80.Enum1.const_1;
						}
						if (this.bool_2)
						{
							if (!gclass3.Boolean_0 || genum2_ == GEnum2.const_2)
							{
								this.method_17("Verifying download...");
								this.method_13(true);
								GStruct7 gstruct = Class83.smethod_4(@class.gclass30_0, gclass3, gclass2.Byte_0);
								this.method_13(false);
								if (!gstruct.Boolean_0)
								{
									this.gclass78_0.TotalDataDownloaded -= gclass3.Size;
									this.gclass78_0.TotalDownloadedCurrentGame -= gclass3.Size;
									continue;
								}
							}
						}
						break;
					}
					catch (Exception ex)
					{
						bool flag3 = false;
						WebException ex2;
						if ((ex2 = (ex as WebException)) != null && ex2.Status == WebExceptionStatus.ProtocolError && ex2.Response != null)
						{
							flag3 = (((HttpWebResponse)ex2.Response).StatusCode == HttpStatusCode.NotFound);
						}
						if (!flag3)
						{
							this.method_17(string.Format("Downloading Content #{0} of {1} failed...", i + 1, gclass.NumOfContents));
							this.method_17(ex.Message);
							@class.gclass30_0.CurrentlyDownloaded = false;
							this.method_5("Downloading Content Failed:\n" + ex.Message);
						}
						else
						{
							this.method_17(string.Format("Downloading Content #{0} of {1} failed... (File not on NUS)", i + 1, gclass.NumOfContents));
						}
						goto IL_77D;
					}
					IL_48A:
					num = (ulong)new FileInfo(text + ".app").Length;
					this.method_17("Local file detected. Checking size...");
					if (num == gclass3.Size.TotalBytes)
					{
						this.method_17("Sizes match. Checking file....");
						if (gclass3.Boolean_0 && !File.Exists(text + ".h3"))
						{
							this.method_10(@class.gclass30_0, gclass3, text, GClass80.Enum0.const_0, 0UL);
						}
						if (!this.bool_3)
						{
							goto IL_72D;
						}
						this.method_13(true);
						GStruct7 gstruct2 = Class83.smethod_4(@class.gclass30_0, gclass3, gclass2.Byte_0);
						this.method_13(false);
						if (gstruct2.Boolean_0)
						{
							goto IL_72D;
						}
						if (gclass3.Boolean_0 && @class.gclass30_0.Platform != Platform.Wii_U_Custom && !flag)
						{
							this.method_17(string.Format("File has {0} corrupted block(s) for a total of  {1} bytes", gstruct2.list_0.Count, gstruct2.list_0.Count * 65536));
							this.method_17("Attempting repair. This may take a while depending on the state of the file.");
							string str2 = gclass3.ContentId.ToString("x8");
							GClass78.smethod_0(@class.gclass30_0.String_1 + str2, text + ".app", File.ReadAllBytes(text + ".h3"), @class.gclass30_0.Ticket.Byte_0, gstruct2.list_0);
							flag = true;
						}
						else
						{
							this.method_17("This file is corrupted but cannot be repaired. Now redownloading...");
							GClass6.smethod_6(text + ".app");
						}
					}
					else
					{
						if (gclass3.Size.TotalBytes >= num)
						{
							DataSize dataSize = new DataSize(num);
							this.method_17(string.Format("Sizes mismatch. Resuming download at {0}", dataSize));
							goto IL_161;
						}
						this.method_17("This file does not qualify for intelligent resuming. Redownloading...");
						GClass6.smethod_6(text + ".app");
					}
				}
				IL_782:
				i++;
				continue;
				IL_72D:
				this.method_17("This file is good, skipping...");
				this.gclass78_0.TotalDownloadedCurrentGame += gclass3.Size.TotalBytes;
				this.gclass78_0.TotalDataDownloaded += gclass3.Size;
				goto IL_782;
				IL_77D:
				GC.Collect();
				goto IL_782;
			}
			this.method_17(string.Format("Downloading Title {0} v{1} Finished...", @class.gclass30_0.TitleId, gclass.TitleVersion));
			this.method_16(100, this.int_5, 100, new TimeSpan(0L), this.timeSpan_2, new TimeSpan(0L), this.gstruct3_0, @class.gclass30_0);
			return GClass80.Enum1.const_0;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000297B4 File Offset: 0x000279B4
		private GClass100 method_15(GClass30 gclass30_0, bool bool_5 = true)
		{
			this.method_17("Downloading TMD...");
			string path = Path.Combine(gclass30_0.OutputPath, "title.tmd");
			if (!bool_5 && gclass30_0.Tmd != null)
			{
				return gclass30_0.Tmd;
			}
			GClass78 gclass = new GClass78();
			byte[] array = null;
			try
			{
				if (gclass30_0 is GClass33)
				{
					array = gclass.method_2(string.Format("{0}tmd.{1}", gclass30_0.String_1, gclass30_0.Version));
				}
				else
				{
					array = gclass.method_2(gclass30_0.String_1 + "tmd");
				}
				gclass30_0.Tmd = GClass100.smethod_1(array, gclass30_0.System);
			}
			catch (Exception ex)
			{
				string str = "TMD not found\n";
				string str2 = ex.ToString();
				string str3 = "\n";
				Exception innerException = ex.InnerException;
				this.method_5(str + str2 + str3 + ((innerException != null) ? innerException.ToString() : null));
			}
			if (bool_5)
			{
				File.WriteAllBytes(path, array);
			}
			return gclass30_0.Tmd;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600047A RID: 1146 RVA: 0x0002989C File Offset: 0x00027A9C
		// (remove) Token: 0x0600047B RID: 1147 RVA: 0x000298D4 File Offset: 0x00027AD4
		public event EventHandler<string> Event_3
		{
			[CompilerGenerated]
			add
			{
				EventHandler<string> eventHandler = this.eventHandler_3;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<string> eventHandler = this.eventHandler_3;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600047C RID: 1148 RVA: 0x0002990C File Offset: 0x00027B0C
		// (remove) Token: 0x0600047D RID: 1149 RVA: 0x00029944 File Offset: 0x00027B44
		public event EventHandler<GClass79> Event_4
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass79> eventHandler = this.eventHandler_4;
				EventHandler<GClass79> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass79> value2 = (EventHandler<GClass79>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass79>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass79> eventHandler = this.eventHandler_4;
				EventHandler<GClass79> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass79> value2 = (EventHandler<GClass79>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass79>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600047E RID: 1150 RVA: 0x0002997C File Offset: 0x00027B7C
		// (remove) Token: 0x0600047F RID: 1151 RVA: 0x000299B4 File Offset: 0x00027BB4
		public event EventHandler<GClass81> Event_5
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass81> eventHandler = this.eventHandler_5;
				EventHandler<GClass81> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass81> value2 = (EventHandler<GClass81>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass81>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass81> eventHandler = this.eventHandler_5;
				EventHandler<GClass81> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass81> value2 = (EventHandler<GClass81>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass81>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000480 RID: 1152 RVA: 0x000299EC File Offset: 0x00027BEC
		// (remove) Token: 0x06000481 RID: 1153 RVA: 0x00029A24 File Offset: 0x00027C24
		public event EventHandler<GEventArgs0> Event_6
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GEventArgs0> eventHandler = this.eventHandler_6;
				EventHandler<GEventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GEventArgs0> eventHandler = this.eventHandler_6;
				EventHandler<GEventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00029A5C File Offset: 0x00027C5C
		private void method_16(int int_6, int int_7, int int_8, TimeSpan timeSpan_3, TimeSpan timeSpan_4, TimeSpan timeSpan_5, GStruct3 gstruct3_1, GClass30 gclass30_0)
		{
			EventHandler<GEventArgs0> eventHandler = this.eventHandler_6;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GEventArgs0(int_6, int_7, int_8, timeSpan_3, timeSpan_4, timeSpan_5, gstruct3_1, gclass30_0));
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00012F55 File Offset: 0x00011155
		private void method_17(string string_0)
		{
			EventHandler<string> eventHandler = this.eventHandler_3;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, string_0);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00012F69 File Offset: 0x00011169
		private void method_18(string string_0, bool bool_5)
		{
			EventHandler<GClass81> eventHandler = this.eventHandler_5;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GClass81(string_0, bool_5, GEnum5.const_4));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00012F84 File Offset: 0x00011184
		[CompilerGenerated]
		private void method_19(object object_0, long long_0)
		{
			EventHandler<long> eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(object_0, long_0);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00012F98 File Offset: 0x00011198
		[CompilerGenerated]
		private void method_20(object object_0, long long_0)
		{
			EventHandler<long> eventHandler = this.eventHandler_2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(object_0, long_0);
		}

		// Token: 0x040002AE RID: 686
		public int int_0;

		// Token: 0x040002AF RID: 687
		private volatile bool bool_0 = true;

		// Token: 0x040002B0 RID: 688
		private const double double_0 = 0.1;

		// Token: 0x040002B1 RID: 689
		[CompilerGenerated]
		private WebProxy webProxy_0;

		// Token: 0x040002B2 RID: 690
		[CompilerGenerated]
		private ulong ulong_0;

		// Token: 0x040002B3 RID: 691
		private List<int> list_0 = new List<int>();

		// Token: 0x040002B4 RID: 692
		private int int_1;

		// Token: 0x040002B5 RID: 693
		private const int int_2 = 8;

		// Token: 0x040002B6 RID: 694
		[CompilerGenerated]
		private EventHandler<bool> eventHandler_0;

		// Token: 0x040002B7 RID: 695
		[CompilerGenerated]
		private EventHandler<long> eventHandler_1;

		// Token: 0x040002B8 RID: 696
		[CompilerGenerated]
		private EventHandler<long> eventHandler_2;

		// Token: 0x040002B9 RID: 697
		private readonly GClass78 gclass78_0 = new GClass78();

		// Token: 0x040002BA RID: 698
		private volatile bool bool_1 = true;

		// Token: 0x040002BB RID: 699
		private List<GClass30> list_1;

		// Token: 0x040002BC RID: 700
		private bool bool_2;

		// Token: 0x040002BD RID: 701
		private bool bool_3;

		// Token: 0x040002BE RID: 702
		private GStruct3 gstruct3_0;

		// Token: 0x040002BF RID: 703
		private TimeSpan timeSpan_0;

		// Token: 0x040002C0 RID: 704
		private int int_3;

		// Token: 0x040002C1 RID: 705
		private TimeSpan timeSpan_1 = new TimeSpan(0L);

		// Token: 0x040002C2 RID: 706
		private int int_4;

		// Token: 0x040002C3 RID: 707
		private bool bool_4;

		// Token: 0x040002C4 RID: 708
		private TimeSpan timeSpan_2 = new TimeSpan(0L);

		// Token: 0x040002C5 RID: 709
		private int int_5;

		// Token: 0x040002C6 RID: 710
		private DataSize dataSize_0 = new DataSize(0UL);

		// Token: 0x040002C7 RID: 711
		private DataSize dataSize_1 = new DataSize(0UL);

		// Token: 0x040002C8 RID: 712
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x040002C9 RID: 713
		[CompilerGenerated]
		private EventHandler<string> eventHandler_3;

		// Token: 0x040002CA RID: 714
		[CompilerGenerated]
		private EventHandler<GClass79> eventHandler_4;

		// Token: 0x040002CB RID: 715
		[CompilerGenerated]
		private EventHandler<GClass81> eventHandler_5;

		// Token: 0x040002CC RID: 716
		[CompilerGenerated]
		private EventHandler<GEventArgs0> eventHandler_6;

		// Token: 0x020000AC RID: 172
		public struct GStruct4
		{
			// Token: 0x040002CD RID: 717
			public DataSize dataSize_0;

			// Token: 0x040002CE RID: 718
			public TitleId titleId_0;
		}

		// Token: 0x020000AD RID: 173
		public struct GStruct5
		{
			// Token: 0x040002CF RID: 719
			public DataSize dataSize_0;

			// Token: 0x040002D0 RID: 720
			public TitleId titleId_0;

			// Token: 0x040002D1 RID: 721
			public string string_0;

			// Token: 0x040002D2 RID: 722
			public string string_1;

			// Token: 0x040002D3 RID: 723
			public string string_2;
		}

		// Token: 0x020000AE RID: 174
		private enum Enum0
		{
			// Token: 0x040002D5 RID: 725
			const_0,
			// Token: 0x040002D6 RID: 726
			const_1
		}

		// Token: 0x020000AF RID: 175
		private enum Enum1
		{
			// Token: 0x040002D8 RID: 728
			const_0,
			// Token: 0x040002D9 RID: 729
			const_1
		}

		// Token: 0x020000B0 RID: 176
		[CompilerGenerated]
		private sealed class Class60
		{
			// Token: 0x06000488 RID: 1160 RVA: 0x00029A8C File Offset: 0x00027C8C
			internal void method_0()
			{
				bool flag = true;
				this.gclass80_0.int_0 = 0;
				int num = 0;
				string arg = "";
				while (flag)
				{
					try
					{
						this.gclass80_0.gclass78_0.method_8();
						this.gclass80_0.method_2(this.list_0);
						flag = false;
					}
					catch (Exception ex)
					{
						arg = ex.Message;
						this.gclass80_0.method_17(string.Format("ERROR : {0}", ex.Message));
						this.gclass80_0.method_17(string.Format("Attemp {0} out of {1}", num + 1, this.int_0));
						this.gclass80_0.method_17(string.Format("Retrying in {0}ms ", this.int_1));
						num++;
						if (num < this.int_0 && this.gclass80_0.bool_0)
						{
							bool flag2 = true;
							int num2 = 0;
							while (flag2)
							{
								num2 += 10;
								Thread.Sleep(10);
								if (num2 >= this.int_1)
								{
									flag2 = false;
								}
								if (!this.gclass80_0.bool_0)
								{
									break;
								}
							}
							flag = true;
						}
						else
						{
							this.gclass80_0.method_17("The maximum number of attemps has been reached. Aborting..");
							this.gclass80_0.bool_0 = false;
							flag = false;
						}
					}
				}
				this.gclass80_0.method_18(this.gclass80_0.bool_0 ? "Download complete!" : string.Format("Download cancelled. {0}", arg), !this.gclass80_0.bool_0);
			}

			// Token: 0x040002DA RID: 730
			public GClass80 gclass80_0;

			// Token: 0x040002DB RID: 731
			public List<GClass30> list_0;

			// Token: 0x040002DC RID: 732
			public int int_0;

			// Token: 0x040002DD RID: 733
			public int int_1;
		}

		// Token: 0x020000B1 RID: 177
		[CompilerGenerated]
		private sealed class Class61
		{
			// Token: 0x0600048A RID: 1162 RVA: 0x00012FAC File Offset: 0x000111AC
			internal bool method_0(GClass33 gclass33_0)
			{
				return gclass33_0.Version != this.gclass30_0.Version && gclass33_0.GEnum2_0 > GEnum2.const_0;
			}

			// Token: 0x040002DE RID: 734
			public GClass30 gclass30_0;

			// Token: 0x040002DF RID: 735
			public Func<GClass33, bool> func_0;
		}
	}
}
