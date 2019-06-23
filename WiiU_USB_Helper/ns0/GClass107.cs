using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace ns0
{
	// Token: 0x02000111 RID: 273
	public class GClass107 : IDisposable
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x00014E38 File Offset: 0x00013038
		public void method_0(string string_4, string string_5, string string_6, string string_7)
		{
			this.gclass100_0 = GClass100.smethod_0(string_6, GEnum3.const_3);
			this.string_0 = string_4;
			this.string_1 = string_5;
			this.string_2 = string_6;
			this.string_3 = string_7;
			this.gclass108_0 = new GClass108();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0003370C File Offset: 0x0003190C
		public void method_1(string string_4)
		{
			if (File.Exists(string_4))
			{
				File.Delete(string_4);
			}
			using (FileStream fileStream = new FileStream(string_4, FileMode.Create))
			{
				this.method_3(fileStream);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00033754 File Offset: 0x00031954
		private string method_2(GClass101 gclass101_0)
		{
			return Path.Combine(this.string_3, gclass101_0.ContentId.ToString("x8") + ".app");
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0003378C File Offset: 0x0003198C
		private void method_3(Stream stream_0)
		{
			int num = 0;
			for (int i = 0; i < this.gclass100_0.GClass101_0.Length - 1; i++)
			{
				num += GClass27.smethod_0((int)this.gclass100_0.GClass101_0[i].Size.TotalBytes, 64);
			}
			num += (int)this.gclass100_0.GClass101_0[this.gclass100_0.GClass101_0.Length - 1].Size.TotalBytes;
			this.gclass108_0.UInt32_0 = (uint)num;
			byte[] buffer = File.ReadAllBytes(this.string_2);
			byte[] array = File.ReadAllBytes(this.string_0);
			byte[] array2 = File.ReadAllBytes(this.string_1);
			GClass99.smethod_7(array2, GEnum3.const_3);
			this.gclass108_0.UInt32_2 = (uint)(484 + this.gclass100_0.GClass101_0.Length * 36);
			this.gclass108_0.UInt32_1 = 0u;
			stream_0.Seek(0L, SeekOrigin.Begin);
			this.gclass108_0.method_0(stream_0);
			stream_0.Seek((long)GClass27.smethod_0((int)stream_0.Position, 64), SeekOrigin.Begin);
			stream_0.Write(array, 0, array.Length);
			stream_0.Seek((long)GClass27.smethod_0((int)stream_0.Position, 64), SeekOrigin.Begin);
			stream_0.Write(array2, 0, array2.Length);
			stream_0.Seek((long)GClass27.smethod_0((int)stream_0.Position, 64), SeekOrigin.Begin);
			stream_0.Write(buffer, 0, (int)this.gclass108_0.UInt32_2);
			byte[] array3 = new byte[4096];
			long num2 = 0L;
			foreach (GClass101 gclass101_2 in this.gclass100_0.GClass101_0)
			{
				stream_0.Seek((long)GClass27.smethod_0((int)stream_0.Position, 64), SeekOrigin.Begin);
				using (FileStream fileStream = File.OpenRead(this.method_2(gclass101_2)))
				{
					int num3;
					do
					{
						num3 = fileStream.Read(array3, 0, array3.Length);
						stream_0.Write(array3, 0, num3);
						num2 += (long)num3;
					}
					while (num3 > 0);
				}
				this.method_4((int)((double)num2 / this.gclass108_0.UInt32_0 * 100.0));
			}
			while (stream_0.Position % 64L != 0L)
			{
				stream_0.WriteByte(0);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00014E6F File Offset: 0x0001306F
		public void Dispose()
		{
			this.vmethod_0(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00014E7E File Offset: 0x0001307E
		protected virtual void vmethod_0(bool bool_1)
		{
			if (bool_1 && !this.bool_0)
			{
				this.sha1_0.Clear();
				this.sha1_0 = null;
				this.gclass108_0 = null;
				this.gclass100_0.Dispose();
				this.byte_0 = null;
			}
			this.bool_0 = true;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000339DC File Offset: 0x00031BDC
		~GClass107()
		{
			this.vmethod_0(false);
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600077C RID: 1916 RVA: 0x00033A0C File Offset: 0x00031C0C
		// (remove) Token: 0x0600077D RID: 1917 RVA: 0x00033A44 File Offset: 0x00031C44
		public event EventHandler<ProgressChangedEventArgs> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<ProgressChangedEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<ProgressChangedEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ProgressChangedEventArgs> value2 = (EventHandler<ProgressChangedEventArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ProgressChangedEventArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<ProgressChangedEventArgs> eventHandler = this.eventHandler_0;
				EventHandler<ProgressChangedEventArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ProgressChangedEventArgs> value2 = (EventHandler<ProgressChangedEventArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ProgressChangedEventArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00033A7C File Offset: 0x00031C7C
		private void method_4(int int_0)
		{
			EventHandler<ProgressChangedEventArgs> eventHandler = this.eventHandler_0;
			if (eventHandler != null)
			{
				eventHandler(new object(), new ProgressChangedEventArgs(int_0, string.Empty));
			}
		}

		// Token: 0x04000462 RID: 1122
		private string string_0;

		// Token: 0x04000463 RID: 1123
		private string string_1;

		// Token: 0x04000464 RID: 1124
		private string string_2;

		// Token: 0x04000465 RID: 1125
		private string string_3;

		// Token: 0x04000466 RID: 1126
		private GClass100 gclass100_0;

		// Token: 0x04000467 RID: 1127
		private GClass108 gclass108_0;

		// Token: 0x04000468 RID: 1128
		private DateTime dateTime_0 = new DateTime(1970, 1, 1);

		// Token: 0x04000469 RID: 1129
		private byte[] byte_0 = new byte[0];

		// Token: 0x0400046A RID: 1130
		private SHA1 sha1_0 = SHA1.Create();

		// Token: 0x0400046B RID: 1131
		private bool bool_0;

		// Token: 0x0400046C RID: 1132
		[CompilerGenerated]
		private EventHandler<ProgressChangedEventArgs> eventHandler_0;
	}
}
