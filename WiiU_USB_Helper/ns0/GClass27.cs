using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x02000054 RID: 84
	public static class GClass27
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00011AF6 File Offset: 0x0000FCF6
		public static int smethod_0(int int_0, int int_1)
		{
			if (int_0 % int_1 != 0)
			{
				int_0 += int_1 - int_0 % int_1;
			}
			return int_0;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002340C File Offset: 0x0002160C
		public static bool smethod_1(byte[] byte_0, byte[] byte_1)
		{
			GClass27.Class36 @class = new GClass27.Class36();
			@class.byte_0 = byte_1;
			return byte_0.Length == @class.byte_0.Length && !byte_0.Where(new Func<byte, int, bool>(@class.method_0)).Any<byte>();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00011B09 File Offset: 0x0000FD09
		public static bool smethod_2(string string_0)
		{
			return File.Exists(Path.Combine(Environment.SystemDirectory, string_0));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00011B1B File Offset: 0x0000FD1B
		public static bool smethod_3(string string_0)
		{
			return File.Exists(Path.Combine(Environment.GetEnvironmentVariable("windir"), "SysWOW64", string_0));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00011B37 File Offset: 0x0000FD37
		public static ushort smethod_4(ushort ushort_0)
		{
			return (ushort)IPAddress.HostToNetworkOrder((short)ushort_0);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00011B41 File Offset: 0x0000FD41
		public static uint smethod_5(uint uint_0)
		{
			return (uint)IPAddress.HostToNetworkOrder((int)uint_0);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00011B49 File Offset: 0x0000FD49
		public static ulong smethod_6(ulong ulong_0)
		{
			return (ulong)IPAddress.HostToNetworkOrder((long)ulong_0);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00023450 File Offset: 0x00021650
		public static void smethod_7(string string_0, string string_1)
		{
			GClass27.Class37 @class = new GClass27.Class37();
			@class.string_0 = string_0;
			@class.string_1 = string_1;
			new FrmWait("USB Helper is extracting data.", new Action(@class.method_0), new Action<Exception>(GClass27.<>c.<>c_0.method_0));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000234A8 File Offset: 0x000216A8
		public static byte[] smethod_8(string string_0)
		{
			GClass27.Class38 @class = new GClass27.Class38();
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper fetches additional data.", true);
			WebClient webClient = new WebClient();
			@class.byte_0 = null;
			webClient.DownloadProgressChanged += @class.method_0;
			webClient.DownloadDataCompleted += @class.method_1;
			webClient.DownloadDataAsync(new Uri(string_0));
			@class.frmWait_0.ShowDialog();
			return @class.byte_0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002351C File Offset: 0x0002171C
		public static void smethod_9(string string_0, string string_1, string string_2 = null)
		{
			GClass27.Class39 @class = new GClass27.Class39();
			@class.frmWait_0 = new FrmWait(string_2 ?? "Please wait while USB Helper fetches additional data.", true);
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += @class.method_0;
			webClient.DownloadFileCompleted += @class.method_1;
			webClient.DownloadFileAsync(new Uri(string_0), string_1);
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00011B51 File Offset: 0x0000FD51
		public static void smethod_10(string string_0)
		{
			GClass27.smethod_7(string.Format("{0}/res/starter/starter.zip", Class65.String_2), string_0);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00011B68 File Offset: 0x0000FD68
		public static void smethod_11(string string_0)
		{
			GClass27.smethod_7(string.Format("{0}/res/emulators/extract_toolkit.zip", Class65.String_2), string_0);
		}

		// Token: 0x02000055 RID: 85
		[CompilerGenerated]
		private sealed class Class36
		{
			// Token: 0x060001FF RID: 511 RVA: 0x00011B7F File Offset: 0x0000FD7F
			internal bool method_0(byte byte_1, int int_0)
			{
				return byte_1 != this.byte_0[int_0];
			}

			// Token: 0x0400013E RID: 318
			public byte[] byte_0;
		}

		// Token: 0x02000056 RID: 86
		[CompilerGenerated]
		private sealed class Class37
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00023588 File Offset: 0x00021788
			internal void method_0()
			{
				try
				{
					using (MemoryStream memoryStream = new MemoryStream(GClass27.smethod_8(this.string_0)))
					{
						using (ZipArchive zipArchive = new ZipArchive(memoryStream))
						{
							zipArchive.smethod_0(this.string_1, true);
						}
					}
				}
				catch (Exception ex)
				{
					RadMessageBox.Show(ex.ToString());
				}
			}

			// Token: 0x0400013F RID: 319
			public string string_0;

			// Token: 0x04000140 RID: 320
			public string string_1;
		}

		// Token: 0x02000058 RID: 88
		[CompilerGenerated]
		private sealed class Class38
		{
			// Token: 0x06000206 RID: 518 RVA: 0x00011BAE File Offset: 0x0000FDAE
			internal void method_0(object sender, DownloadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0002360C File Offset: 0x0002180C
			internal void method_1(object sender, DownloadDataCompletedEventArgs e)
			{
				try
				{
					this.byte_0 = e.Result;
				}
				catch (Exception ex)
				{
					RadMessageBox.Show(ex.ToString());
					this.byte_0 = null;
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x04000143 RID: 323
			public FrmWait frmWait_0;

			// Token: 0x04000144 RID: 324
			public byte[] byte_0;
		}

		// Token: 0x02000059 RID: 89
		[CompilerGenerated]
		private sealed class Class39
		{
			// Token: 0x06000209 RID: 521 RVA: 0x00011BC1 File Offset: 0x0000FDC1
			internal void method_0(object sender, DownloadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00011BD4 File Offset: 0x0000FDD4
			internal void method_1(object sender, AsyncCompletedEventArgs e)
			{
				this.frmWait_0.method_0();
			}

			// Token: 0x04000145 RID: 325
			public FrmWait frmWait_0;
		}
	}
}
