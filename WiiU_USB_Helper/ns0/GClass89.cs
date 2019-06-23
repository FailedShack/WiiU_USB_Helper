using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using NusHelper.Server;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020000C0 RID: 192
	public static class GClass89
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00013404 File Offset: 0x00011604
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0001340B File Offset: 0x0001160B
		public static GClass8 GClass8_0
		{
			get
			{
				return GClass89.gclass8_0;
			}
			private set
			{
				GClass89.gclass8_0 = value;
				EventHandler eventHandler = GClass89.eventHandler_0;
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(null, null);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00013424 File Offset: 0x00011624
		public static bool Boolean_0
		{
			get
			{
				return GClass89.GClass8_0 != null;
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060004E7 RID: 1255 RVA: 0x0002A4A4 File Offset: 0x000286A4
		// (remove) Token: 0x060004E8 RID: 1256 RVA: 0x0002A4D8 File Offset: 0x000286D8
		public static event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = GClass89.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref GClass89.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = GClass89.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref GClass89.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002A50C File Offset: 0x0002870C
		public static bool smethod_0(int int_1, string string_0, string string_1)
		{
			if (GClass89.timer_0 == null)
			{
				GClass89.timer_0 = new System.Windows.Forms.Timer
				{
					Interval = 2000
				};
				GClass89.timer_0.Tick += GClass89.<>c.<>c_0.method_0;
				GClass89.timer_0.Start();
			}
			Thread.Sleep(250);
			if (!Class106.Boolean_0 && !Class106.bool_0)
			{
				GClass89.smethod_1(string_0, string_1);
				return !GClass89.Boolean_0 && int_1 != 0 && (int_1 == 1 || int_1 % 3 == 0);
			}
			return false;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0002A5A4 File Offset: 0x000287A4
		public static void smethod_1(string string_0, string string_1)
		{
			GClass89.GClass8_0 = null;
			GClass89.bool_0 = false;
			if (string_0 == null)
			{
				GClass89.GClass8_0 = null;
				return;
			}
			byte[] array;
			try
			{
				array = Convert.FromBase64String(string_0);
			}
			catch
			{
				GClass89.GClass8_0 = null;
				return;
			}
			if (array.Length != 272)
			{
				GClass89.GClass8_0 = null;
				return;
			}
			byte[] array2 = new byte[16];
			byte[] array3 = new byte[256];
			Buffer.BlockCopy(array, 0, array2, 0, 16);
			Buffer.BlockCopy(array, 16, array3, 0, 256);
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
			{
				rsacryptoServiceProvider.FromXmlString(string_1);
				GClass89.GClass8_0 = (rsacryptoServiceProvider.VerifyData(array2, CryptoConfig.MapNameToOID("SHA1"), array3) ? GClass89.smethod_2(string_0) : null);
				GClass89.bool_0 = GClass89.Boolean_0;
				if (GClass89.bool_0)
				{
					Settings.Default.Mine = false;
					Settings.Default.Save();
					Class106.smethod_1();
				}
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002A6A0 File Offset: 0x000288A0
		private static GClass8 smethod_2(string string_0)
		{
			try
			{
				byte[] bytes = new WebClient().UploadValues(string.Format("{0}/verifyDonationKey.php", Class65.String_3), new NameValueCollection
				{
					{
						"key",
						string_0
					}
				});
				KeyValidationResponse keyValidationResponse = JsonConvert.DeserializeObject<KeyValidationResponse>(Encoding.UTF8.GetString(bytes));
				if (keyValidationResponse.Accepted)
				{
					return new GClass8(keyValidationResponse.Email, keyValidationResponse.Key, keyValidationResponse.DonationDate);
				}
				RadMessageBox.Show(keyValidationResponse.Message);
				Settings.Default.DonationKey = "";
				Settings.Default.Save();
				return null;
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					return new GClass8("", "", "");
				}
			}
			return null;
		}

		// Token: 0x0400030F RID: 783
		private const int int_0 = 3;

		// Token: 0x04000310 RID: 784
		private static GClass8 gclass8_0;

		// Token: 0x04000311 RID: 785
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x04000312 RID: 786
		private static bool bool_0;

		// Token: 0x04000313 RID: 787
		private static System.Windows.Forms.Timer timer_0;
	}
}
