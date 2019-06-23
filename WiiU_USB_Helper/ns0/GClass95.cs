using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using NusHelper;
using Nus_Helper_Shared_Core.NusHelper.Emulators;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020000EA RID: 234
	public abstract class GClass95
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x0002F668 File Offset: 0x0002D868
		internal GClass95(GClass30 gclass30_1, string string_2, string string_3, bool bool_3 = true, bool bool_4 = false)
		{
			this.gclass30_0 = gclass30_1;
			this.FullScreen = bool_4;
			this.Name = string_2;
			try
			{
				if (!Directory.Exists(this.String_6))
				{
					Directory.CreateDirectory(this.String_6);
				}
			}
			catch (Exception ex)
			{
				RadMessageBox.Show("An error occured while initializing the emulators. Most likely you have unplugged the drive on which your games are stored. The emulation settings will now be cleared and the application will close.\n" + ex.ToString());
				try
				{
					GClass6.smethod_5(Path.Combine(new string[]
					{
						GClass17.string_0
					}));
				}
				catch
				{
				}
				Environment.Exit(0);
				return;
			}
			if (!Directory.Exists(this.String_5))
			{
				Directory.CreateDirectory(this.String_5);
			}
			if (!Directory.Exists(this.String_4))
			{
				Directory.CreateDirectory(this.String_4);
			}
			this.Url = string_3;
			this.bool_0 = bool_3;
			if (bool_3)
			{
				this.method_1();
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00014260 File Offset: 0x00012460
		public string String_0
		{
			get
			{
				return string.Format("{0}/res/emulators/{1}.zip", Class65.String_2, this.Name);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002F750 File Offset: 0x0002D950
		public void method_0()
		{
			string a = "";
			try
			{
				a = File.ReadAllText(Path.Combine(this.String_4, "etag"));
			}
			catch
			{
			}
			string text = GClass6.smethod_14(this.String_0);
			if (!this.Boolean_0 || a != text)
			{
				Class65.smethod_3(this);
				if (this.Boolean_0)
				{
					File.WriteAllText(Path.Combine(this.String_4, "etag"), text);
				}
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00014277 File Offset: 0x00012477
		public void method_1()
		{
			if (new GClass17(this).method_0().AutoUpdate)
			{
				this.method_0();
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00014291 File Offset: 0x00012491
		public virtual string FileSaveLocation
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		public virtual string vmethod_0()
		{
			if (!Directory.Exists(this.FileSaveLocation))
			{
				return null;
			}
			string text = Path.GetTempPath() + Guid.NewGuid();
			ZipFile.CreateFromDirectory(this.FileSaveLocation, text);
			return text;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0002F810 File Offset: 0x0002DA10
		public void method_2(string string_2, string string_3, string string_4)
		{
			if (string_2 == null)
			{
				return;
			}
			string text = Path.Combine(Path.GetDirectoryName(string_2), Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat(new string[]
			{
				string_3,
				" ",
				string_4,
				" ",
				this.gclass30_0.TitleId.IdRaw
			}))));
			GClass6.smethod_6(text);
			File.Move(string_2, text);
			string text2 = Class65.smethod_14(text, string.Format("{0}/saves/upload_save_b64.php", Class65.String_1));
			if (text2 != "OK")
			{
				RadMessageBox.Show(text2);
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0002F8AC File Offset: 0x0002DAAC
		private void method_3()
		{
			try
			{
				string text = Path.Combine(GClass88.CachePath, "saves_backup");
				foreach (DirectoryInfo directoryInfo in new DirectoryInfo(text).EnumerateDirectories())
				{
					if (directoryInfo.Name.Contains(','))
					{
						directoryInfo.MoveTo(Path.Combine(text, directoryInfo.Name.Substring(0, directoryInfo.Name.IndexOf(','))));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0002F950 File Offset: 0x0002DB50
		public void method_4(string string_2, string string_3)
		{
			GClass95.Class81 @class = new GClass95.Class81();
			@class.gclass95_0 = this;
			this.method_3();
			if (this.FileSaveLocation == null)
			{
				return;
			}
			WebClient webClient = new WebClient();
			if (new WebClient().UploadValues(new Uri(string.Format("{0}/saves/get_save.php", Class65.String_1)), new NameValueCollection
			{
				{
					"username",
					string_2
				},
				{
					"password",
					string_3
				},
				{
					"titleid",
					this.gclass30_0.TitleId.IdRaw
				},
				{
					"hash",
					"true"
				}
			}).Length == 0)
			{
				return;
			}
			@class.frmWait_0 = new FrmWait("USB Helper is downloading your save", true);
			webClient.UploadValuesCompleted += @class.method_0;
			webClient.DownloadProgressChanged += @class.method_1;
			webClient.UploadValuesAsync(new Uri(string.Format("{0}/saves/get_save.php", Class65.String_1)), new NameValueCollection
			{
				{
					"username",
					string_2
				},
				{
					"password",
					string_3
				},
				{
					"titleid",
					this.gclass30_0.TitleId.IdRaw
				}
			});
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00014294 File Offset: 0x00012494
		public virtual bool SupportsCustomControllerProfiles { get; }

		// Token: 0x06000647 RID: 1607 RVA: 0x0001429C File Offset: 0x0001249C
		public virtual List<GClass95.GStruct6> GetControllerProfiles()
		{
			return new List<GClass95.GStruct6>();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000142A3 File Offset: 0x000124A3
		public virtual void ApplyControllerProfile(GClass95.GStruct6 config)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000142A5 File Offset: 0x000124A5
		public string Name { get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000142AD File Offset: 0x000124AD
		public string Url { get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000142B5 File Offset: 0x000124B5
		public string String_1
		{
			get
			{
				return Path.Combine(this.CurrentGamePath, "meta", "bootTvTex.tga");
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x000142CC File Offset: 0x000124CC
		public string String_2
		{
			get
			{
				return Path.Combine(this.CurrentGamePath, "meta", "bootSound.btsnd");
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000142E3 File Offset: 0x000124E3
		public string String_3
		{
			get
			{
				return Path.Combine(this.CurrentGamePath, "meta", "bootSound.wav");
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x000142FA File Offset: 0x000124FA
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00014302 File Offset: 0x00012502
		public bool FullScreen { get; set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001430B File Offset: 0x0001250B
		internal virtual string CurrentGamePath
		{
			get
			{
				return Path.Combine(this.String_5, this.gclass30_0.method_12());
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00014323 File Offset: 0x00012523
		internal string String_4
		{
			get
			{
				return Path.Combine(this.String_6, "BIN");
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00014335 File Offset: 0x00012535
		internal string String_5
		{
			get
			{
				return Path.Combine(this.String_6, "GAMES");
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00014347 File Offset: 0x00012547
		private string String_6
		{
			get
			{
				return this.EmuConfiguration_0.RootPath;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00014354 File Offset: 0x00012554
		public EmuConfiguration EmuConfiguration_0
		{
			get
			{
				return new GClass17(this).method_0();
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00014361 File Offset: 0x00012561
		private string String_7
		{
			get
			{
				return Path.Combine(this.CurrentGamePath, "stream.helper");
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00014373 File Offset: 0x00012573
		public bool Boolean_0
		{
			get
			{
				return File.Exists(this.GetExecutable());
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00014380 File Offset: 0x00012580
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0001438D File Offset: 0x0001258D
		public bool Boolean_1
		{
			get
			{
				return File.Exists(this.String_7);
			}
			set
			{
				if (value)
				{
					File.CreateText(this.String_7);
					return;
				}
				GClass6.smethod_6(this.String_7);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		public bool Boolean_2
		{
			get
			{
				bool result;
				try
				{
					result = (File.Exists(this.GetRom()) && new FileInfo(this.GetRom()).Length > 0L && !this.Boolean_1);
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		public virtual void Play()
		{
			try
			{
				if (!this.gclass30_0.Boolean_1 && this.gclass30_0.GEnum2_0 != GEnum2.const_2)
				{
					this.method_6();
				}
				else
				{
					this.method_5();
				}
				this.method_8(this.GetArguments());
			}
			catch (Exception arg)
			{
				RadMessageBox.Show("An error occured while trying to prepare this title." + arg);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000143AA File Offset: 0x000125AA
		public void method_5()
		{
			this.Boolean_1 = false;
			Class65.smethod_6();
			this.PrepareRomIfNecessary(false);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000143BF File Offset: 0x000125BF
		public void method_6()
		{
			this.Boolean_1 = false;
			Class65.smethod_6();
			this.PrepareRomIfNecessary(true);
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600065D RID: 1629 RVA: 0x0002FB38 File Offset: 0x0002DD38
		// (remove) Token: 0x0600065E RID: 1630 RVA: 0x0002FB70 File Offset: 0x0002DD70
		public event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000143D4 File Offset: 0x000125D4
		protected void method_7()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		protected void method_8(string string_2)
		{
			if (!this.Boolean_0)
			{
				throw new FileNotFoundException(string.Format("The emulator is not installed. If you have disabled automatic updates, you have to install it in {0} before being able to use it.", this.GetExecutable()));
			}
			Process process = new Process();
			process.StartInfo.FileName = this.GetExecutable();
			process.EnableRaisingEvents = true;
			process.StartInfo.Arguments = string_2;
			process.StartInfo.WorkingDirectory = this.String_4;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Exited += this.method_13;
			if (Settings.Default.EnableCloudSaving)
			{
				this.method_4(Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
				this.Event_0 += this.method_14;
			}
			process.Start();
			if (Settings.Default.PauseMiner)
			{
				Class106.smethod_1();
				this.Event_0 += GClass95.<>c.<>c_0.method_1;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		protected static long smethod_0(Stream stream_0, byte[] byte_0)
		{
			long position = stream_0.Position;
			byte[] array = new byte[8192];
			int num = 0;
			int num3;
			int i;
			do
			{
				int num2 = stream_0.Read(array, 0, array.Length);
				num3 = 0;
				for (i = 0; i < num2; i++)
				{
					num++;
					if (array[i] == byte_0[num3])
					{
						num3++;
					}
					else
					{
						num3 = 0;
					}
					if (num3 == byte_0.Length)
					{
						break;
					}
				}
				if (num2 <= 0)
				{
					break;
				}
			}
			while (num3 != byte_0.Length);
			stream_0.Seek(position + (long)num - (long)byte_0.Length, SeekOrigin.Begin);
			return position + (long)i - (long)byte_0.Length;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0002FD38 File Offset: 0x0002DF38
		public virtual void vmethod_1()
		{
			try
			{
				GClass6.smethod_5(this.CurrentGamePath);
			}
			catch
			{
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000142A3 File Offset: 0x000124A3
		public virtual void DeleteUpdate()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000142A3 File Offset: 0x000124A3
		public virtual void DeleteDlc()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0002FD68 File Offset: 0x0002DF68
		protected static DataSize smethod_1(string string_2)
		{
			if (!Directory.Exists(string_2))
			{
				return new DataSize(0UL);
			}
			string[] files = Directory.GetFiles(string_2, "*.*", SearchOption.AllDirectories);
			ulong num = 0UL;
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				num += (ulong)fileInfo.Length;
			}
			return new DataSize(num);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000143E8 File Offset: 0x000125E8
		public virtual DataSize vmethod_2()
		{
			return GClass95.smethod_1(this.CurrentGamePath);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000143F5 File Offset: 0x000125F5
		public virtual DataSize GetUpdateSize()
		{
			return new DataSize(0UL);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000143F5 File Offset: 0x000125F5
		public virtual DataSize GetDlcSize()
		{
			return new DataSize(0UL);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000112BA File Offset: 0x0000F4BA
		public virtual ulong GetUpdateVersion()
		{
			return 0UL;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		protected void method_9(bool bool_3)
		{
			string text = Path.Combine(GClass88.CachePath, "rpl2elf.exe");
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Class121.rpl2elf);
			}
			GClass13 gclass = this.gclass30_0.method_15();
			GClass12 gclass2 = gclass.Files.First(new Func<GClass12, bool>(GClass95.<>c.<>c_0.method_2));
			GClass12 gclass3 = gclass.Files.First(new Func<GClass12, bool>(GClass95.<>c.<>c_0.method_3));
			this.gclass30_0.method_16(this.String_5, true, bool_3, new GClass12[]
			{
				gclass2,
				gclass3
			}, false);
			Process process = new Process();
			string text2 = this.method_11();
			string arg = this.method_10();
			process.StartInfo.FileName = text;
			process.EnableRaisingEvents = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\"", text2, arg);
			process.StartInfo.WorkingDirectory = Path.GetDirectoryName(text2);
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00014046 File Offset: 0x00012246
		public virtual string GetArguments()
		{
			return string.Format("\"{0}\"", this.GetRom());
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000143FE File Offset: 0x000125FE
		protected string method_10()
		{
			return this.method_11() + ".elf";
		}

		// Token: 0x0600066D RID: 1645
		public abstract string GetExecutable();

		// Token: 0x0600066E RID: 1646
		public abstract string GetRom();

		// Token: 0x0600066F RID: 1647 RVA: 0x0002FEE4 File Offset: 0x0002E0E4
		protected string method_11()
		{
			string path = Path.Combine(this.CurrentGamePath, "code") + "\\";
			if (!Directory.Exists(path))
			{
				return "";
			}
			List<string> list = Directory.GetFiles(path).Where(new Func<string, bool>(GClass95.<>c.<>c_0.method_4)).ToList<string>();
			if (list.Count <= 0)
			{
				return "";
			}
			return list[0];
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002FF60 File Offset: 0x0002E160
		private static void smethod_2(string string_2)
		{
			foreach (string text in Directory.GetDirectories(string_2))
			{
				GClass95.smethod_2(text);
				if (Directory.GetFiles(text).Length == 0 && Directory.GetDirectories(text).Length == 0)
				{
					Directory.Delete(text, false);
				}
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
		public static void smethod_3(string string_2, string string_3, bool bool_3 = true)
		{
			foreach (string text in Directory.GetFiles(string_2, "*.*", SearchOption.AllDirectories))
			{
				if (!(text == string_3) && (!bool_3 || !text.Contains("meta")))
				{
					try
					{
						GClass6.smethod_6(text);
					}
					catch
					{
					}
				}
			}
			GClass95.smethod_2(string_2);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00014410 File Offset: 0x00012610
		public void method_12(bool bool_3 = true)
		{
			GClass95.smethod_3(this.CurrentGamePath, this.GetRom(), bool_3);
		}

		// Token: 0x06000673 RID: 1651
		public abstract bool UpdateIsInstalled();

		// Token: 0x06000674 RID: 1652
		public abstract bool DlcIsInstalled();

		// Token: 0x06000675 RID: 1653 RVA: 0x00014424 File Offset: 0x00012624
		protected virtual void PrepareRomIfNecessary(bool directDownload)
		{
			if (!this.Boolean_2 && this.gclass30_0.System == GEnum3.const_1)
			{
				this.gclass30_0.method_16(this.String_5, true, directDownload, null, false);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00014452 File Offset: 0x00012652
		[CompilerGenerated]
		private void method_13(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001445A File Offset: 0x0001265A
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			this.method_2(this.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
		}

		// Token: 0x040003A9 RID: 937
		protected readonly GClass30 gclass30_0;

		// Token: 0x040003AA RID: 938
		protected bool bool_0;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private readonly bool bool_1;

		// Token: 0x040003AC RID: 940
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x040003AD RID: 941
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x040003AE RID: 942
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040003AF RID: 943
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x020000EB RID: 235
		public struct GStruct6
		{
			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000678 RID: 1656 RVA: 0x0001447C File Offset: 0x0001267C
			// (set) Token: 0x06000679 RID: 1657 RVA: 0x00014484 File Offset: 0x00012684
			public string Name { get; set; }

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001448D File Offset: 0x0001268D
			// (set) Token: 0x0600067B RID: 1659 RVA: 0x00014495 File Offset: 0x00012695
			public string ResUrl { get; set; }

			// Token: 0x040003B0 RID: 944
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040003B1 RID: 945
			[CompilerGenerated]
			private string string_1;
		}

		// Token: 0x020000EC RID: 236
		[CompilerGenerated]
		private sealed class Class81
		{
			// Token: 0x0600067D RID: 1661 RVA: 0x00030014 File Offset: 0x0002E214
			internal void method_0(object sender, UploadValuesCompletedEventArgs e)
			{
				GClass95.Class82 @class = new GClass95.Class82();
				@class.class81_0 = this;
				@class.uploadValuesCompletedEventArgs_0 = e;
				if (@class.uploadValuesCompletedEventArgs_0.Error != null)
				{
					RadMessageBox.Show(@class.uploadValuesCompletedEventArgs_0.Error.ToString());
					this.frmWait_0.method_0();
					return;
				}
				if (@class.uploadValuesCompletedEventArgs_0.Result.Length < 100)
				{
					RadMessageBox.Show(Encoding.UTF8.GetString(@class.uploadValuesCompletedEventArgs_0.Result));
					this.frmWait_0.method_0();
					return;
				}
				Directory.CreateDirectory(Path.GetDirectoryName(this.gclass95_0.FileSaveLocation));
				new FrmWait("USB Helper is downloading your save.", new Action(@class.method_0), new Action<Exception>(GClass95.<>c.<>c_0.method_0));
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x0001449E File Offset: 0x0001269E
			internal void method_1(object sender, DownloadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x040003B2 RID: 946
			public FrmWait frmWait_0;

			// Token: 0x040003B3 RID: 947
			public GClass95 gclass95_0;
		}

		// Token: 0x020000ED RID: 237
		[CompilerGenerated]
		private sealed class Class82
		{
			// Token: 0x06000680 RID: 1664 RVA: 0x000300E8 File Offset: 0x0002E2E8
			internal void method_0()
			{
				string text = Path.Combine(GClass88.CachePath, "saves_backup");
				Directory.CreateDirectory(text);
				string text2 = Path.Combine(text, this.class81_0.gclass95_0.gclass30_0.TitleId.IdRaw + ((int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString());
				Directory.CreateDirectory(text2);
				string text3 = this.class81_0.gclass95_0.vmethod_0();
				if (text3 != null)
				{
					File.Move(text3, Path.Combine(text2, "backup.zip"));
				}
				using (MemoryStream memoryStream = new MemoryStream(this.uploadValuesCompletedEventArgs_0.Result))
				{
					using (ZipArchive zipArchive = new ZipArchive(memoryStream))
					{
						zipArchive.smethod_0(this.class81_0.gclass95_0.FileSaveLocation, true);
					}
				}
				this.class81_0.frmWait_0.method_0();
			}

			// Token: 0x040003B4 RID: 948
			public UploadValuesCompletedEventArgs uploadValuesCompletedEventArgs_0;

			// Token: 0x040003B5 RID: 949
			public GClass95.Class81 class81_0;
		}
	}
}
