using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using Newtonsoft.Json;
using NusHelper;
using NusHelper.Emulators;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x020000D9 RID: 217
	public class GClass94 : GClass91
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x0002CF84 File Offset: 0x0002B184
		public GClass94(GClass32 gclass32_1) : base(gclass32_1)
		{
			try
			{
				base.method_6("twodiscs");
				base.RomCount = 2;
			}
			catch
			{
			}
			this.CompressIso = base.method_0("notcompress", true);
			if (gclass32_1.Platform == Platform.Wii_Custom)
			{
				base.UseGamepad = base.method_0("gamepad", false);
				if (base.UseGamepad)
				{
					base.VerticalWiimote = base.method_0("vertical", false);
					base.HorizontalWiimote = base.method_0("horizontal", false);
				}
				this.PatchWifi = base.method_0("online", false);
				try
				{
					string[] array = base.method_6("patch").Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.RemoveEmptyEntries);
					this.PatchGame = new TitleId(array[0]);
					this.PatchSize = array[1];
				}
				catch
				{
				}
			}
			this.string_3 = new string[base.RomCount];
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00013E56 File Offset: 0x00012056
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00013E5E File Offset: 0x0001205E
		public bool CompressIso { get; set; } = true;

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00013E67 File Offset: 0x00012067
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00013E6F File Offset: 0x0001206F
		public bool PatchWifi { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00013E78 File Offset: 0x00012078
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00013E80 File Offset: 0x00012080
		public bool Force43 { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00013E89 File Offset: 0x00012089
		public override string[] String_3
		{
			get
			{
				return new string[]
				{
					"Fetching the content",
					"Shrinking the ISO",
					"Injecting the game",
					"Packing the game"
				};
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00013EB1 File Offset: 0x000120B1
		public TitleId PatchGame { get; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00013EB9 File Offset: 0x000120B9
		public string PatchSize { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00013EC1 File Offset: 0x000120C1
		public override string String_1
		{
			get
			{
				return "ISO";
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00013EC8 File Offset: 0x000120C8
		public override string String_2
		{
			get
			{
				if (base.ToInject.Platform != Platform.Gamecube)
				{
					return "iso (*.iso)|*.iso|ciso (*.ciso)|*.ciso|wbfs (*.wbfs)|*.wbfs";
				}
				return "iso (*.iso)|*.iso|gcm (*.gcm)|*.gcm";
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0002D094 File Offset: 0x0002B294
		public bool method_14()
		{
			if (this.PatchGame == null)
			{
				throw new Exception("This game is not patchable!");
			}
			GClass30 gclass = GClass28.dictionary_0[this.PatchGame];
			if (RadMessageBox.Show(string.Format("This title is a modified version of {0}.\nUSB Helper can build an iso for you by automatically patching the game from the eShop.\nThis way you do not have to provide the iso.\nProceed? (About {1}MB will of data will be downloaded)", gclass.Name, this.PatchSize), "Proceed?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return false;
			}
			GClass94.Class77 @class = new GClass94.Class77();
			if (gclass.GEnum2_0 != GEnum2.const_2)
			{
				GClass94.Class78 class2 = new GClass94.Class78();
				GClass80 gclass2 = new GClass80(null, true, true);
				class2.frmWait_0 = new FrmWait("USB Helper is downloading the base game", true);
				gclass2.Event_6 += class2.method_0;
				gclass2.Event_5 += class2.method_1;
				gclass2.method_1(new GClass30[]
				{
					gclass
				}.ToList<GClass30>(), 100, 10000);
				class2.frmWait_0.ShowDialog();
			}
			Dolphin dolphin = new Dolphin(gclass, false);
			dolphin.method_5();
			string rom = dolphin.GetRom();
			@class.string_0 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(rom).Parent.FullName;
			@class.string_1 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				@class.string_0,
				"workdir.tmp"
			});
			@class.string_2 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				@class.string_0,
				"patch.uhd"
			});
			dolphin.method_12(true);
			new FrmWait("USB Helper is preparing the game...", new Action(@class.method_0), new Action<Exception>(GClass94.<>c.<>c_0.method_0));
			@class.frmWait_0 = new FrmWait("USB Helper is downloading the differential data", true);
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += @class.method_1;
			webClient.DownloadFileCompleted += @class.method_2;
			webClient.DownloadFileAsync(new Uri(string.Format("{0}/res/Wii/template/{1}/patch.uhd", Class65.String_2, base.ToInject.ProductId)), @class.string_2);
			@class.frmWait_0.ShowDialog();
			new FrmWait("USB HELPER is patching the game...", new Action(@class.method_3), new Action<Exception>(GClass94.<>c.<>c_0.method_1));
			GClass6.smethod_6(@class.string_2);
			GClass6.smethod_5(@class.string_1);
			if (!this.vmethod_0(new Alphaleonis.Win32.Filesystem.DirectoryInfo(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				@class.string_0,
				"new-image"
			})).GetFiles()[0].FullName))
			{
				throw new Exception("The output iso was not recognized!");
			}
			new frmInjectionAnimation(this).ShowDialog();
			dolphin.method_12(true);
			GClass6.smethod_5(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				@class.string_0,
				"rawFiles"
			}));
			return true;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00013EE7 File Offset: 0x000120E7
		private void method_15(string string_5, string string_6)
		{
			GClass91.smethod_1(base.method_4("GCM.exe"), new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_5).Parent.FullName, string.Format("-sh \"{0}\" \"{1}\"", string_5, string_6));
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0002D34C File Offset: 0x0002B54C
		private static string smethod_5(string string_5)
		{
			byte[] array = new byte[6];
			string @string;
			using (FileStream fileStream = System.IO.File.OpenRead(string_5))
			{
				if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".ciso")
				{
					fileStream.Seek(32768L, SeekOrigin.Begin);
				}
				else if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".wbfs")
				{
					fileStream.Seek(512L, SeekOrigin.Begin);
				}
				fileStream.Read(array, 0, 6);
				@string = Encoding.ASCII.GetString(array);
			}
			return @string;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0002D3DC File Offset: 0x0002B5DC
		private static int smethod_6(string string_5)
		{
			new byte[1];
			int result;
			using (BinaryReader binaryReader = new BinaryReader(Alphaleonis.Win32.Filesystem.File.OpenRead(string_5)))
			{
				if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".ciso")
				{
					binaryReader.BaseStream.Seek(32768L, SeekOrigin.Begin);
				}
				else if (Alphaleonis.Win32.Filesystem.Path.GetExtension(string_5) == ".wbfs")
				{
					binaryReader.BaseStream.Seek(512L, SeekOrigin.Begin);
				}
				binaryReader.BaseStream.Seek(6L, SeekOrigin.Current);
				result = (int)binaryReader.ReadByte();
			}
			return result;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0002D47C File Offset: 0x0002B67C
		private int method_16(string string_5)
		{
			int result;
			try
			{
				string item = GClass94.smethod_5(string_5);
				if (base.List_0.Contains(item))
				{
					result = GClass94.smethod_6(string_5);
				}
				else
				{
					result = -1;
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		private static void smethod_7(System.IO.DriveInfo driveInfo_0)
		{
			string path = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				driveInfo_0.Name,
				"apps",
				"nintendont",
				"boot.dol"
			});
			WebClient webClient = new WebClient();
			webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			try
			{
				bool flag;
				if (!Alphaleonis.Win32.Filesystem.File.Exists(path))
				{
					flag = true;
				}
				else
				{
					byte[] byte_ = null;
					byte[] array = Alphaleonis.Win32.Filesystem.File.ReadAllBytes(path);
					byte[] bytes = Encoding.ASCII.GetBytes("blob " + array.Length.ToString() + "\0");
					byte[] array2 = new byte[array.Length + bytes.Length];
					Buffer.BlockCopy(bytes, 0, array2, 0, bytes.Length);
					Buffer.BlockCopy(array, 0, array2, bytes.Length, array.Length);
					using (SHA1 sha = SHA1.Create())
					{
						byte_ = sha.ComputeHash(array2);
					}
					byte[] byte_2 = JsonConvert.DeserializeObject<GClass21[]>(webClient.DownloadString("https://api.github.com/repos/FIX94/Nintendont/contents//loader")).First(new Func<GClass21, bool>(GClass94.<>c.<>c_0.method_2)).sha.smethod_6();
					flag = !GClass27.smethod_1(byte_, byte_2);
				}
				if (flag && RadMessageBox.Show("USB Helper was unable to detect Nintendont, or a new version is available. It is required to be able to play GC games. Would you like USB Helper to install it for you?", "Nintendont", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					GClass94.smethod_9(driveInfo_0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002D638 File Offset: 0x0002B838
		public static void smethod_8(System.IO.DriveInfo driveInfo_0)
		{
			Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				driveInfo_0.Name,
				"apps",
				"nintendont",
				"boot.dol"
			});
			string path = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				driveInfo_0.Name,
				"nincfg.bin"
			});
			GClass94.smethod_7(driveInfo_0);
			if (!Alphaleonis.Win32.Filesystem.File.Exists(path) && RadMessageBox.Show("USB Helper was unable to detect the configuration file on your SD card. It is required to be able to play GC games. Would you like USB Helper to install it for you?", "Nintendont", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				GClass94.smethod_10(driveInfo_0);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		public static void smethod_9(System.IO.DriveInfo driveInfo_0)
		{
			Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				driveInfo_0.Name,
				"apps",
				"nintendont"
			}));
			GClass27.smethod_9("https://github.com/FIX94/Nintendont/blob/master/loader/loader.dol?raw=true", Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
			{
				driveInfo_0.Name,
				"apps",
				"nintendont",
				"boot.dol"
			}), null);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00013F15 File Offset: 0x00012115
		public static void smethod_10(System.IO.DriveInfo driveInfo_0)
		{
			GClass27.smethod_9(string.Format("{0}/res/nintendont/nincfg.bin", Class65.String_2), driveInfo_0.Name + "nincfg.bin", null);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00013F3C File Offset: 0x0001213C
		public override void vmethod_2()
		{
			base.vmethod_2();
			Task.Run(new Action(this.method_17));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002D724 File Offset: 0x0002B924
		public override bool vmethod_0(string string_5)
		{
			int num = this.method_16(string_5);
			if (num > -1)
			{
				this.string_3[num] = string_5;
				if (this.string_3.All(new Func<string, bool>(GClass94.<>c.<>c_0.method_3)))
				{
					return true;
				}
			}
			else
			{
				RadMessageBox.Show("USB Helper was unable to recognize this ISO. Make sure you have provided an ISO of the same region as the title you are trying to inject");
			}
			return false;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00013F56 File Offset: 0x00012156
		public override int vmethod_1()
		{
			return this.string_3.Count(new Func<string, bool>(GClass94.<>c.<>c_0.method_4));
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00013F82 File Offset: 0x00012182
		protected override void vmethod_3()
		{
			base.method_2(GClass28.dictionary_0[new TitleId("00050000101B1100")]);
			GClass91.smethod_1(GClass91.String_0, base.WorkPath, string.Format("-jar \"{0}\" -in rawFiles", "NUSPacker.jar"));
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0002D780 File Offset: 0x0002B980
		[CompilerGenerated]
		private void method_17()
		{
			try
			{
				string string_ = this.Force43 ? string.Format("{0}/res/nintendont/autoboot43.dol", Class65.String_2) : "https://cdn.wiiuusbhelper.com/res/nintendont/autoboot.dol";
				base.method_11(0);
				string string_2 = base.method_4("rawFiles\\content\\hif_000000.nfs");
				string text = base.method_4("rawFiles\\content\\game.iso");
				string text2 = base.method_4("new-image\\");
				string text3 = base.method_4(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					text2,
					"PunEmu [CEMU69].iso"
				}));
				string sourceFileName = base.method_4("nfs2iso2nfs.exe");
				string text4 = base.method_4("rawFiles\\content\\nfs2iso2nfs.exe");
				string path = base.method_4("rawFiles\\content\\hif_000000.nfs");
				string sourceFileName2 = base.method_4("workdir.tmp2\\ticket.bin");
				string text5 = base.method_4("rawFiles\\code\\rvlt.tik");
				string sourceFileName3 = base.method_4("workdir.tmp2\\tmd.bin");
				string text6 = base.method_4("rawFiles\\code\\rvlt.tmd");
				string string_3 = base.method_4("production_output");
				string string_4 = base.method_4("output");
				string text7 = base.method_4("workdir.tmp\\");
				string string_5 = base.method_4(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					text7,
					"sys",
					"main.dol"
				}));
				string[] array = new string[]
				{
					base.method_4("workdir.tmp\\files\\game.iso"),
					base.method_4("workdir.tmp\\files\\disc2.iso")
				};
				GClass6.smethod_8("https://cdn.wiiuusbhelper.com/res/nintendont/vc-template.zip", base.WorkPath);
				GClass6.smethod_5(base.method_4("workdir.tmp2"));
				GClass6.smethod_5(string_3);
				GClass6.smethod_5(string_4);
				GClass6.smethod_6(text6);
				GClass6.smethod_6(text5);
				GClass6.smethod_6(string_2);
				GClass6.smethod_6(text);
				GClass6.smethod_6(text4);
				Task task = base.method_7();
				base.method_11(1);
				if (this.string_3 != null && base.ToInject.Platform == Platform.Gamecube)
				{
					new GClass78().method_5(string_, string_5, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
					for (int i = 0; i < this.string_3.Length; i++)
					{
						if (this.CompressIso)
						{
							this.method_15(this.string_3[i], array[i]);
						}
						else
						{
							Alphaleonis.Win32.Filesystem.File.Copy(this.string_3[i], array[i]);
						}
					}
					if (!Alphaleonis.Win32.Filesystem.File.Exists(array[0]))
					{
						throw new Exception("The iso was not shrinked sucessfully. Cannot continue.");
					}
				}
				if (base.ToInject.Platform == Platform.Wii_Custom)
				{
					if (this.PatchWifi)
					{
						if (new string[]
						{
							"RMCP01",
							"RMCE01",
							"RMCJ01"
						}.Contains(base.ToInject.ProductId))
						{
							Alphaleonis.Win32.Filesystem.File.Copy(this.string_3[0], base.method_4(Alphaleonis.Win32.Filesystem.Path.GetFileName(this.string_3[0])));
							using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(string.Format("{0}/res/Wii/mk_patcher.zip", Class65.String_2))))
							{
								using (ZipArchive zipArchive = new ZipArchive(memoryStream))
								{
									zipArchive.smethod_0(base.WorkPath, true);
								}
							}
							GClass91.smethod_0("patch-wiimmfi.bat", base.WorkPath);
							GClass6.smethod_6(base.method_4(Alphaleonis.Win32.Filesystem.Path.GetFileName(this.string_3[0])));
							text3 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(base.method_4("wiimmfi-images/")).GetFiles()[0].FullName;
						}
						else if (new string[]
						{
							"RSBP01",
							"RSBE01",
							"RSBJ01"
						}.Contains(base.ToInject.ProductId))
						{
							GClass91.smethod_1(base.method_4("PackOnline.bat"), base.WorkPath, string.Format("\"{0}\"", this.string_3[0]));
							text3 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
							{
								text2,
								"patched.iso"
							});
						}
						else
						{
							GClass6.smethod_5(text7);
							GClass91.smethod_1(base.method_4("Extract.bat"), base.WorkPath, string.Format("\"{0}\"", this.string_3[0]));
							GClass91.smethod_0(base.method_4("Pack.bat"), base.WorkPath);
							GClass6.smethod_5(text7);
							text3 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(text2).GetFiles()[0].FullName;
							GClass91.smethod_1(base.method_4("PackOnline.bat"), base.WorkPath, string.Format("\"{0}\"", text3));
							GClass6.smethod_6(text3);
							text3 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
							{
								text2,
								"patched.iso"
							});
						}
					}
					else
					{
						GClass6.smethod_5(text7);
						GClass91.smethod_1(base.method_4("Extract.bat"), base.WorkPath, string.Format("\"{0}\"", this.string_3[0]));
						GClass91.smethod_0(base.method_4("Pack.bat"), base.WorkPath);
						GClass6.smethod_5(text7);
						text3 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(text2).GetFiles()[0].FullName;
						Alphaleonis.Win32.Filesystem.File.Move(text3, Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
						{
							Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text3),
							"game.iso"
						}));
						text3 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
						{
							Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text3),
							"game.iso"
						});
					}
				}
				else if (base.ToInject.Platform == Platform.Gamecube)
				{
					GClass91.smethod_0(base.method_4("Pack.bat"), base.WorkPath);
					GClass6.smethod_5(text7);
					text3 = new Alphaleonis.Win32.Filesystem.DirectoryInfo(text2).GetFiles()[0].FullName;
				}
				base.method_11(2);
				GClass91.smethod_1(base.method_4("GetTik.bat"), base.WorkPath, string.Format("\"{0}\"", text3));
				GClass6.smethod_6(array[0]);
				GClass6.smethod_6(array[1]);
				Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName2, text5);
				Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName3, text6);
				Alphaleonis.Win32.Filesystem.File.Move(text3, text);
				Alphaleonis.Win32.Filesystem.File.Copy(sourceFileName, text4);
				if (base.ToInject.Platform == Platform.Gamecube)
				{
					GClass91.smethod_1(text4, Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text4), "-homebrew -passthrough");
				}
				else if (base.ToInject.Platform == Platform.Wii_Custom)
				{
					GClass91.smethod_1(text4, Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text4), "-passthrough");
				}
				if (!Alphaleonis.Win32.Filesystem.File.Exists(path))
				{
					throw new Exception("Injection did not complete sucessfully. Cannot continue.");
				}
				GClass6.smethod_6(text);
				GClass6.smethod_6(text4);
				base.method_11(3);
				task.Wait();
				this.vmethod_3();
				if (base.Production)
				{
					base.method_3(string_4, string_3);
				}
				GClass6.smethod_5(base.method_4("workdir.tmp2"));
				GClass6.smethod_5(base.method_4("tmp"));
				GClass6.smethod_6(string_2);
				base.method_8();
				base.method_9();
			}
			catch (Exception exception_)
			{
				base.method_10(exception_);
			}
		}

		// Token: 0x0400037A RID: 890
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x0400037B RID: 891
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x0400037C RID: 892
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x0400037D RID: 893
		private string[] string_3;

		// Token: 0x0400037E RID: 894
		[CompilerGenerated]
		private readonly TitleId titleId_0;

		// Token: 0x0400037F RID: 895
		[CompilerGenerated]
		private readonly string string_4;

		// Token: 0x020000DA RID: 218
		[CompilerGenerated]
		private sealed class Class77
		{
			// Token: 0x060005E8 RID: 1512 RVA: 0x0002DE48 File Offset: 0x0002C048
			internal void method_0()
			{
				GClass6.smethod_8(string.Format("{0}/res/nintendont/vc-template.zip", Class65.String_2), this.string_0);
				GClass6.smethod_5(this.string_1);
				GClass91.smethod_1(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.string_0,
					"Extract.bat"
				}), this.string_0, "game.iso");
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00013FBD File Offset: 0x000121BD
			internal void method_1(object sender, DownloadProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00013FD0 File Offset: 0x000121D0
			internal void method_2(object sender, AsyncCompletedEventArgs e)
			{
				this.frmWait_0.method_0();
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
			internal void method_3()
			{
				GClass4.smethod_0(this.string_1, this.string_2, Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.string_0,
					"workdir.patched"
				}));
				GClass6.smethod_5(this.string_1);
				Alphaleonis.Win32.Filesystem.Directory.Move(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.string_0,
					"workdir.patched"
				}), this.string_1);
				GClass91.smethod_0(Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
				{
					this.string_0,
					"Pack.bat"
				}), this.string_0);
			}

			// Token: 0x04000380 RID: 896
			public string string_0;

			// Token: 0x04000381 RID: 897
			public string string_1;

			// Token: 0x04000382 RID: 898
			public FrmWait frmWait_0;

			// Token: 0x04000383 RID: 899
			public string string_2;
		}

		// Token: 0x020000DB RID: 219
		[CompilerGenerated]
		private sealed class Class78
		{
			// Token: 0x060005ED RID: 1517 RVA: 0x00013FDD File Offset: 0x000121DD
			internal void method_0(object sender, GEventArgs0 e)
			{
				this.frmWait_0.method_2(e.GameProgress);
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x00013FF0 File Offset: 0x000121F0
			internal void method_1(object object_0, GClass81 gclass81_0)
			{
				this.frmWait_0.method_0();
			}

			// Token: 0x04000384 RID: 900
			public FrmWait frmWait_0;
		}
	}
}
