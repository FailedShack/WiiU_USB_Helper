using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Alphaleonis.Win32.Filesystem;
using NusHelper;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x0200001E RID: 30
	internal class Class7
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		public Class7(GClass30 gclass30_1)
		{
			if (gclass30_1.System != GEnum3.const_1)
			{
				throw new Exception("This can only be used on WUP titles.");
			}
			this.gclass30_0 = gclass30_1;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000072 RID: 114 RVA: 0x0001BF08 File Offset: 0x0001A108
		// (remove) Token: 0x06000073 RID: 115 RVA: 0x0001BF40 File Offset: 0x0001A140
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

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000074 RID: 116 RVA: 0x0001BF78 File Offset: 0x0001A178
		// (remove) Token: 0x06000075 RID: 117 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public event EventHandler<GStruct0> Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GStruct0> eventHandler = this.eventHandler_1;
				EventHandler<GStruct0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GStruct0> value2 = (EventHandler<GStruct0>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GStruct0>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GStruct0> eventHandler = this.eventHandler_1;
				EventHandler<GStruct0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GStruct0> value2 = (EventHandler<GStruct0>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GStruct0>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		public byte[] method_0(GClass12 gclass12_0, ulong ulong_2 = 0UL)
		{
			if (this.gclass100_0 == null || this.gclass99_0 == null)
			{
				this.gclass100_0 = GClass100.smethod_1(new GClass78().method_2(this.gclass30_0.String_1 + "tmd"), GEnum3.const_1);
				this.gclass99_0 = this.method_5();
			}
			if (!gclass12_0.bool_1 && !gclass12_0.bool_0)
			{
				byte[] result;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					this.method_2(gclass12_0, memoryStream, true, ulong_2);
					result = memoryStream.ToArray();
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00010B85 File Offset: 0x0000ED85
		public void method_1(string string_0, bool bool_0 = false, List<GClass12> list_0 = null, bool bool_1 = false)
		{
			Class7.Class8 @class = new Class7.Class8();
			@class.class7_0 = this;
			@class.bool_0 = bool_0;
			@class.list_0 = list_0;
			@class.bool_1 = bool_1;
			@class.string_0 = string_0;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000078 RID: 120 RVA: 0x0001C084 File Offset: 0x0001A284
		// (remove) Token: 0x06000079 RID: 121 RVA: 0x0001C0BC File Offset: 0x0001A2BC
		public event EventHandler<Exception> Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = this.eventHandler_2;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = this.eventHandler_2;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00010BC1 File Offset: 0x0000EDC1
		private void method_2(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0UL)
		{
			if (this.gclass100_0.GClass101_0[(int)gclass12_0.short_0].Boolean_0)
			{
				this.method_3(gclass12_0, stream_0, bool_0, ulong_2);
				return;
			}
			this.method_4(gclass12_0, stream_0, bool_0, ulong_2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
		private void method_3(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0UL)
		{
			uint contentId = this.gclass100_0.GClass101_0[(int)gclass12_0.short_0].ContentId;
			byte[] inputBuffer = new byte[65536];
			ulong num = (ulong)gclass12_0.uint_1;
			ulong num2 = (ulong)gclass12_0.uint_2;
			ulong num3 = 0UL;
			ulong num4 = 64512UL;
			ulong num5 = num / 64512UL * 65536UL;
			int num6 = (int)(num5 / 65536UL);
			ulong num7 = num - num / 64512UL * 64512UL;
			if (num7 + num2 > num4)
			{
				num4 -= num7;
			}
			Stream stream = null;
			if (bool_0)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.gclass30_0.String_1 + contentId.ToString("x8"));
				httpWebRequest.Method = "GET";
				httpWebRequest.AddRange((long)num5);
				stream = httpWebRequest.GetResponse().GetResponseStream();
			}
			else
			{
				stream = this.dictionary_0[contentId];
			}
			byte[] array = new byte[16];
			array[1] = (byte)gclass12_0.short_0;
			byte[] array2 = array;
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = this.gclass99_0.Byte_0;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.None;
				aesCryptoServiceProvider.IV = array2;
				if (!bool_0)
				{
					stream.Seek((long)num5, SeekOrigin.Begin);
				}
				while (num2 > 0UL)
				{
					if (num4 > num2)
					{
						num4 = num2;
					}
					stream.smethod_4(inputBuffer, 65536);
					byte[] array3 = new byte[16];
					array3[1] = (byte)gclass12_0.short_0;
					array2 = array3;
					new byte[20];
					byte[] array4;
					using (ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, array2))
					{
						array4 = cryptoTransform.TransformFinalBlock(inputBuffer, 0, 1024);
					}
					byte[] array5 = array4;
					int num8 = 1;
					array5[num8] ^= (byte)gclass12_0.short_0;
					Buffer.BlockCopy(array4, num6 % 16 * 20, array2, 0, 16);
					using (ICryptoTransform cryptoTransform2 = aesCryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, array2))
					{
						cryptoTransform2.TransformBlock(inputBuffer, 1024, 64512, this.byte_0, 0);
					}
					num2 -= num4;
					stream_0.Write(this.byte_0, (int)num7, (int)num4);
					this.ulong_1 += num4;
					if (ulong_2 > 0UL && this.ulong_1 >= ulong_2)
					{
						break;
					}
					this.method_9();
					num3 += num4;
					num6++;
					if (num7 != 0UL)
					{
						num4 = 64512UL;
						num7 = 0UL;
					}
				}
			}
			if (bool_0)
			{
				stream.Close();
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
		private void method_4(GClass12 gclass12_0, Stream stream_0, bool bool_0, ulong ulong_2 = 0UL)
		{
			uint contentId = this.gclass100_0.GClass101_0[(int)gclass12_0.short_0].ContentId;
			ulong num = (ulong)gclass12_0.uint_1;
			ulong num2 = (ulong)gclass12_0.uint_2;
			byte[] array = new byte[16];
			array[1] = (byte)gclass12_0.short_0;
			byte[] rgbIV = array;
			Stream stream = null;
			if (bool_0)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.gclass30_0.String_1 + contentId.ToString("x8"));
				httpWebRequest.AddRange((long)num);
				stream = httpWebRequest.GetResponse().GetResponseStream();
			}
			else
			{
				stream = this.dictionary_0[contentId];
			}
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = this.gclass99_0.Byte_0;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.None;
				if (!bool_0)
				{
					stream.Seek((long)num, SeekOrigin.Begin);
				}
				int num3 = (int)this.method_7((long)num2, 16L);
				if (ulong_2 > 0UL)
				{
					long num4 = this.method_7((long)ulong_2, 16L);
					if (num4 < (long)num3)
					{
						num3 = (int)num4;
					}
				}
				byte[] inputBuffer = stream.smethod_3(num3, new Action<int>(this.method_11));
				byte[] buffer;
				using (ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(this.gclass99_0.Byte_0, rgbIV))
				{
					buffer = cryptoTransform.TransformFinalBlock(inputBuffer, 0, num3);
				}
				if (ulong_2 > 0UL)
				{
					stream_0.Write(buffer, 0, num3);
				}
				else
				{
					stream_0.Write(buffer, 0, (int)num2);
				}
			}
			if (bool_0)
			{
				stream.Close();
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0001C558 File Offset: 0x0001A758
		private GClass99 method_5()
		{
			if (!(this.gclass30_0 is GClass33))
			{
				if (this.gclass30_0.Platform != Platform.Wii_U_Custom)
				{
					if (this.gclass30_0.bool_0)
					{
						return GClass99.smethod_7(new GClass78().method_2(this.gclass30_0.string_0), GEnum3.const_1);
					}
					return GClass99.smethod_7(this.gclass30_0.TicketArray, GEnum3.const_1);
				}
			}
			return GClass99.smethod_7(new GClass78().method_2(this.gclass30_0.String_1 + "cetk"), GEnum3.const_1);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		private GClass100 method_6()
		{
			if (this.gclass30_0 is GClass33)
			{
				return GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd.{1}", this.gclass30_0.String_1, this.gclass30_0.Version)), GEnum3.const_1);
			}
			return GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd", this.gclass30_0.String_1)), GEnum3.const_1);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00010BF3 File Offset: 0x0000EDF3
		private long method_7(long long_0, long long_1)
		{
			if (long_0 % long_1 == 0L)
			{
				return long_0;
			}
			return (long_0 / long_1 + 1L) * long_1;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00010C04 File Offset: 0x0000EE04
		private string method_8(string string_0)
		{
			return System.IO.Path.Combine(this.gclass30_0.OutputPath, string_0);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0001C654 File Offset: 0x0001A854
		private void method_9()
		{
			EventHandler<GStruct0> eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GStruct0
			{
				int_1 = (int)(this.ulong_1 / this.ulong_0 * 100.0),
				int_0 = this.int_0,
				int_2 = this.int_1
			});
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0001C6B8 File Offset: 0x0001A8B8
		private void method_10()
		{
			foreach (Stream stream in this.dictionary_0.Values)
			{
				try
				{
					stream.Close();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00010C17 File Offset: 0x0000EE17
		[CompilerGenerated]
		private void method_11(int int_2)
		{
			this.ulong_1 += (ulong)((long)int_2);
			this.method_9();
		}

		// Token: 0x0400003D RID: 61
		[CompilerGenerated]
		private EventHandler<bool> eventHandler_0;

		// Token: 0x0400003E RID: 62
		[CompilerGenerated]
		private EventHandler<GStruct0> eventHandler_1;

		// Token: 0x0400003F RID: 63
		[CompilerGenerated]
		private EventHandler<Exception> eventHandler_2;

		// Token: 0x04000040 RID: 64
		private readonly GClass30 gclass30_0;

		// Token: 0x04000041 RID: 65
		private readonly byte[] byte_0 = new byte[65536];

		// Token: 0x04000042 RID: 66
		private readonly Dictionary<uint, Stream> dictionary_0 = new Dictionary<uint, Stream>();

		// Token: 0x04000043 RID: 67
		private int int_0;

		// Token: 0x04000044 RID: 68
		private GClass13 gclass13_0;

		// Token: 0x04000045 RID: 69
		private GClass99 gclass99_0;

		// Token: 0x04000046 RID: 70
		private GClass100 gclass100_0;

		// Token: 0x04000047 RID: 71
		private int int_1;

		// Token: 0x04000048 RID: 72
		private ulong ulong_0;

		// Token: 0x04000049 RID: 73
		private ulong ulong_1;

		// Token: 0x0400004A RID: 74
		private byte[] byte_1 = new byte[32768];

		// Token: 0x0200001F RID: 31
		[CompilerGenerated]
		private sealed class Class8
		{
			// Token: 0x06000085 RID: 133 RVA: 0x0001C724 File Offset: 0x0001A924
			internal void method_0()
			{
				if (this.class7_0.gclass100_0 == null || this.class7_0.gclass99_0 == null)
				{
					if (this.bool_0)
					{
						this.class7_0.gclass100_0 = this.class7_0.method_6();
						this.class7_0.gclass99_0 = this.class7_0.method_5();
					}
					else
					{
						this.class7_0.gclass99_0 = GClass99.smethod_6(this.class7_0.method_8("title.tik"), GEnum3.const_1);
						this.class7_0.gclass100_0 = GClass100.smethod_0(this.class7_0.method_8("title.tmd"), GEnum3.const_1);
					}
				}
				try
				{
					if (this.class7_0.gclass13_0 == null)
					{
						this.class7_0.gclass13_0 = this.class7_0.gclass30_0.method_15();
					}
					if (this.list_0 != null & this.bool_1)
					{
						foreach (GClass12 item in this.class7_0.gclass13_0.Files.Where(new Func<GClass12, bool>(Class7.<>c.<>c_0.method_0)))
						{
							if (!this.list_0.Contains(item))
							{
								this.list_0.Add(item);
							}
						}
					}
					List<GClass12> source = this.list_0 ?? this.class7_0.gclass13_0.Files;
					foreach (GClass12 gclass in source.Where(new Func<GClass12, bool>(Class7.<>c.<>c_0.method_1)))
					{
						Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(System.IO.Path.Combine(this.string_0, gclass.string_0));
					}
					foreach (GClass12 gclass2 in source.Where(new Func<GClass12, bool>(Class7.<>c.<>c_0.method_2)))
					{
						this.class7_0.ulong_0 = this.class7_0.ulong_0 + (ulong)gclass2.uint_2;
						this.class7_0.int_1 = this.class7_0.int_1 + 1;
					}
					try
					{
						if (!this.bool_0)
						{
							foreach (GClass101 gclass3 in this.class7_0.gclass100_0.GClass101_0)
							{
								this.class7_0.dictionary_0.Add(gclass3.ContentId, Alphaleonis.Win32.Filesystem.File.Open(this.class7_0.method_8(gclass3.ContentId.ToString("x8") + ".app"), FileMode.Open));
							}
						}
					}
					catch
					{
						RadMessageBox.Show("USB Helper could not get access to the data of the title. Make sure you are not downloading this title at the moment, and there are no other instances of USB Helper currently running");
						this.class7_0.method_10();
						EventHandler<bool> eventHandler_ = this.class7_0.eventHandler_0;
						if (eventHandler_ != null)
						{
							eventHandler_(this.class7_0, false);
						}
						return;
					}
					foreach (GClass12 gclass4 in source.Where(new Func<GClass12, bool>(Class7.<>c.<>c_0.method_3)))
					{
						if ((gclass4.short_1 & 4) == 0)
						{
							gclass4.uint_1 *= 32u;
						}
						try
						{
							Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(System.IO.Path.Combine(this.string_0, gclass4.string_0)));
							goto IL_3BC;
						}
						catch
						{
							goto IL_3BC;
						}
						FileStream fileStream;
						try
						{
							IL_36F:
							this.class7_0.method_2(gclass4, fileStream, this.bool_0, 0UL);
						}
						finally
						{
							if (fileStream != null)
							{
								((IDisposable)fileStream).Dispose();
							}
						}
						this.class7_0.int_0 = this.class7_0.int_0 + 1;
						this.class7_0.method_9();
						continue;
						IL_3BC:
						fileStream = Alphaleonis.Win32.Filesystem.File.Create(System.IO.Path.Combine(this.string_0, gclass4.string_0));
						goto IL_36F;
					}
					this.class7_0.method_10();
					EventHandler<bool> eventHandler_2 = this.class7_0.eventHandler_0;
					if (eventHandler_2 != null)
					{
						eventHandler_2(this.class7_0, true);
					}
				}
				catch (Exception e)
				{
					this.class7_0.method_10();
					EventHandler<Exception> eventHandler_3 = this.class7_0.eventHandler_2;
					if (eventHandler_3 != null)
					{
						eventHandler_3(this.class7_0, e);
					}
				}
			}

			// Token: 0x0400004B RID: 75
			public Class7 class7_0;

			// Token: 0x0400004C RID: 76
			public bool bool_0;

			// Token: 0x0400004D RID: 77
			public List<GClass12> list_0;

			// Token: 0x0400004E RID: 78
			public bool bool_1;

			// Token: 0x0400004F RID: 79
			public string string_0;
		}
	}
}
