using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000153 RID: 339
	public class GClass132
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x00015DDF File Offset: 0x00013FDF
		public GClass132(ManagementObject managementObject_1)
		{
			this.managementObject_0 = managementObject_1;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00015DEE File Offset: 0x00013FEE
		public ulong UInt64_0
		{
			get
			{
				return ulong.Parse(this.managementObject_0.Properties["Size"].Value.ToString());
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00015E14 File Offset: 0x00014014
		public bool Boolean_0
		{
			get
			{
				return File.Exists(this.String_1) && File.Exists(this.String_3);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00015E30 File Offset: 0x00014030
		public string String_0
		{
			get
			{
				return this.managementObject_0.Properties["Name"].Value.ToString();
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00015E51 File Offset: 0x00014051
		public string String_1
		{
			get
			{
				return Path.Combine(this.String_5, "otp.bin");
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00015E63 File Offset: 0x00014063
		public string String_2
		{
			get
			{
				return this.managementObject_0.Properties["PNPDeviceID"].Value.ToString();
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00015E84 File Offset: 0x00014084
		public string String_3
		{
			get
			{
				return Path.Combine(this.String_5, "seeprom.bin");
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00038814 File Offset: 0x00036A14
		public byte[] method_0()
		{
			if (!this.Boolean_0)
			{
				throw new Exception("Disk is not installed");
			}
			byte[] array = new byte[16];
			Buffer.BlockCopy(File.ReadAllBytes(this.String_1), 304, array, 0, 16);
			byte[] array2 = new byte[16];
			Buffer.BlockCopy(File.ReadAllBytes(this.String_3), 176, array2, 0, 16);
			byte[] result = null;
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = array;
				aesCryptoServiceProvider.IV = new byte[16];
				aesCryptoServiceProvider.Mode = CipherMode.ECB;
				aesCryptoServiceProvider.Padding = PaddingMode.None;
				using (ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor())
				{
					result = cryptoTransform.TransformFinalBlock(array2, 0, 16);
				}
			}
			return result;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000388EC File Offset: 0x00036AEC
		public void method_1(string string_0, string string_1 = null)
		{
			GClass132.Class114 @class = new GClass132.Class114();
			File.WriteAllBytes(GClass132.String_4, Class121.wfsdump);
			@class.frmWait_0 = new FrmWait("USB Helper is reading your disk...", false);
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = GClass132.String_4,
					UseShellExecute = true,
					Arguments = string.Format("--input {0} --output {1} --otp {2} --seeprom {3} --usb {4}", new object[]
					{
						this.String_0,
						string_0,
						this.String_1,
						this.String_3,
						(string_1 != null) ? ("--dump-path " + string_1) : ""
					}),
					Verb = "runas",
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden
				}
			};
			process.EnableRaisingEvents = true;
			process.Exited += @class.method_0;
			try
			{
				process.Start();
				@class.frmWait_0.ShowDialog();
			}
			catch
			{
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00015E96 File Offset: 0x00014096
		public void method_2(byte[] byte_0, byte[] byte_1)
		{
			Directory.CreateDirectory(this.String_5);
			File.WriteAllBytes(this.String_1, byte_0);
			File.WriteAllBytes(this.String_3, byte_1);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000389F0 File Offset: 0x00036BF0
		public void method_3()
		{
			GClass6.smethod_6(this.String_1);
			GClass6.smethod_6(this.String_3);
			try
			{
				GClass6.smethod_5(this.String_5);
			}
			catch
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00015EBC File Offset: 0x000140BC
		private static string String_4
		{
			get
			{
				return Path.Combine(GClass88.CachePath, "wfsdump.exe");
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00015ECD File Offset: 0x000140CD
		private string String_5
		{
			get
			{
				return Path.Combine(GClass88.CachePath, this.String_6);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00015EDF File Offset: 0x000140DF
		private string String_6
		{
			get
			{
				return GClass88.smethod_8(this.String_2);
			}
		}

		// Token: 0x04000575 RID: 1397
		private readonly ManagementObject managementObject_0;

		// Token: 0x02000154 RID: 340
		[CompilerGenerated]
		private sealed class Class114
		{
			// Token: 0x0600092C RID: 2348 RVA: 0x00015EEC File Offset: 0x000140EC
			internal void method_0(object sender, EventArgs e)
			{
				this.frmWait_0.method_0();
			}

			// Token: 0x04000576 RID: 1398
			public FrmWait frmWait_0;
		}
	}
}
