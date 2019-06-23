using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using NusHelper;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using WIIU_Downloader.Forms;

namespace ns0
{
	// Token: 0x0200005F RID: 95
	public class GClass32 : GClass30
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00023B0C File Offset: 0x00021D0C
		public GClass32(string string_15, TitleId titleId_1, string string_16, byte[] byte_2, DataSize dataSize_1, List<GClass33> list_2, string string_17, string string_18, string string_19, string string_20, Platform platform_1, GEnum3 genum3_1) : base(string_15, titleId_1, string_16, byte_2, dataSize_1, string_20, genum3_1)
		{
			this.EshopId = string_17;
			this.IconUrl = string_19;
			this.ProductId = string_18;
			this.Updates = list_2;
			base.Platform = platform_1;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00023C38 File Offset: 0x00021E38
		public new string String_6
		{
			get
			{
				if (!base.Boolean_0)
				{
					throw new Exception("This can only be used on injectable titles!");
				}
				switch (base.Platform)
				{
				case Platform.Gamecube:
					return this.string_7 + this.ProductId;
				case Platform.Wii_Custom:
					return this.string_8 + this.ProductId;
				case Platform.Super_NES_Custom:
					return this.string_9 + this.ProductId;
				case Platform.Nintendo_64_Custom:
					return this.string_10 + this.ProductId;
				default:
					throw new Exception("This can only be used on injectable titles!");
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00023CD0 File Offset: 0x00021ED0
		public string String_7
		{
			get
			{
				string arg = (base.Region == "EUR") ? "EN" : ((base.Region == "USA") ? "US" : "JA");
				switch (base.System)
				{
				case GEnum3.const_0:
					return string.Format("http://art.gametdb.com/3ds/box/{0}/{1}.png", arg, this.ProductId);
				case GEnum3.const_1:
					return string.Format("http://art.gametdb.com/wiiu/cover3D/{0}/{1}.png", arg, this.ProductId);
				case GEnum3.const_3:
					return string.Format("http://art.gametdb.com/wii/cover3D/{0}/{1}.png", arg, this.ProductId);
				}
				throw new NotImplementedException("Unknown system");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00011CEE File Offset: 0x0000FEEE
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00011CF6 File Offset: 0x0000FEF6
		public GClass31 Dlc { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00011CFF File Offset: 0x0000FEFF
		public string EshopId { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00011D07 File Offset: 0x0000FF07
		public bool Boolean_2
		{
			get
			{
				return this.Dlc != null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00011D12 File Offset: 0x0000FF12
		public bool Boolean_3
		{
			get
			{
				return this.Updates.Count > 0;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00011D22 File Offset: 0x0000FF22
		public string IconUrl { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00011D2A File Offset: 0x0000FF2A
		public bool Boolean_4
		{
			get
			{
				return GClass28.list_3.Contains(this);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00011D37 File Offset: 0x0000FF37
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00023D74 File Offset: 0x00021F74
		public bool Boolean_5
		{
			get
			{
				return GClass30.list_0.Contains(base.TitleId.IdRaw);
			}
			set
			{
				bool flag;
				if ((flag = GClass30.list_0.Contains(base.TitleId.IdRaw)) && !value)
				{
					GClass30.list_0.Remove(base.TitleId.IdRaw);
					return;
				}
				if (!flag && value)
				{
					GClass30.list_0.Add(base.TitleId.IdRaw);
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00023DD4 File Offset: 0x00021FD4
		public GClass91 method_21()
		{
			switch (base.Platform)
			{
			case Platform.Gamecube:
				return new GClass94(this);
			case Platform.Wii_Custom:
				return new GClass94(this);
			case Platform.Super_NES_Custom:
				return new GClass93(this);
			case Platform.Nintendo_64_Custom:
				return new GClass92(this);
			default:
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00023E24 File Offset: 0x00022024
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case GEnum3.const_0:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA_3DS",
						base.Region,
						base.CfwOnly ? "ESHOP" : "GAMES",
						base.String_5
					});
				case GEnum3.const_1:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA",
						base.Region,
						base.CfwOnly ? "ESHOP" : "GAMES",
						base.String_5
					});
				case GEnum3.const_2:
					throw new NotImplementedException();
				case GEnum3.const_3:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA_WII",
						base.Region,
						base.CfwOnly ? "ESHOP" : "GAMES",
						base.String_5
					});
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public string ProductId { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00011D56 File Offset: 0x0000FF56
		public List<GClass33> Updates { get; } = new List<GClass33>();

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00011D5E File Offset: 0x0000FF5E
		private string String_8
		{
			get
			{
				return Path.Combine(new string[]
				{
					base.OutputPath,
					"DATA",
					"SAVES",
					base.Region,
					base.String_5
				});
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00023F2C File Offset: 0x0002212C
		public string String_9
		{
			get
			{
				string str = "";
				switch (this.Updates.Last<GClass33>().GEnum2_0)
				{
				case GEnum2.const_0:
					str = "Latest update not downloaded.";
					break;
				case GEnum2.const_1:
					str = string.Format("Latest update partially downloaded ({0}%).", this.Updates.Last<GClass33>().Int32_0);
					break;
				case GEnum2.const_2:
					str = "Latest update downloaded.";
					break;
				}
				int num = this.Updates.Count<GClass33>();
				int num2 = this.Updates.Count(new Func<GClass33, bool>(GClass32.<>c.<>c_0.method_0));
				return str + string.Format(" ({0}/{1})", num2, num);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00011D96 File Offset: 0x0000FF96
		public void method_22()
		{
			GClass95 gclass = base.method_14(false);
			if (gclass == null)
			{
				return;
			}
			gclass.method_5();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00023FEC File Offset: 0x000221EC
		public void method_23(string string_15, string string_16)
		{
			GClass32.Class40 @class = new GClass32.Class40();
			@class.string_0 = string_15;
			@class.string_1 = string_16;
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
			@class.string_2 = Path.Combine(Path.GetTempPath(), "ext_usb_helper");
			Directory.CreateDirectory(@class.string_2);
			Directory.CreateDirectory(@class.string_0);
			base.method_3(@class.string_2, true);
			GClass27.smethod_11(@class.string_2);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "makerom.exe",
				WorkingDirectory = @class.string_2,
				Arguments = "-f cia -o game.cia -content game.cxi:0:0"
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = true;
			process.Exited += @class.method_0;
			process.Start();
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000240C4 File Offset: 0x000222C4
		public List<SaveDescription> method_24()
		{
			List<SaveDescription> list = new List<SaveDescription>();
			if (!Directory.Exists(this.String_8))
			{
				return list;
			}
			foreach (FileInfo fileInfo in new DirectoryInfo(this.String_8).EnumerateFiles().Where(new Func<FileInfo, bool>(GClass32.<>c.<>c_0.method_1)))
			{
				try
				{
					using (FileStream fileStream = File.Open(fileInfo.FullName, FileMode.Open))
					{
						using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(zipArchive.GetEntry("meta.json").Open()))
							{
								list.Add(JsonConvert.DeserializeObject<SaveDescription>(streamReader.ReadToEnd()));
							}
						}
					}
				}
				catch
				{
				}
			}
			return list;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000241EC File Offset: 0x000223EC
		public string method_25(GClass82 gclass82_0, string string_15)
		{
			if (!Directory.Exists(this.String_8))
			{
				Directory.CreateDirectory(this.String_8);
			}
			string text = ((long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds).ToString();
			string text2 = Path.Combine(this.String_8, text + ".zip");
			try
			{
				Class4.smethod_0(this, gclass82_0.IPAddress_0, text2);
			}
			catch
			{
				GClass6.smethod_6(text2);
				throw;
			}
			if (!File.Exists(text2))
			{
				return null;
			}
			using (FileStream fileStream = File.Open(text2, FileMode.Open, FileAccess.ReadWrite))
			{
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Update))
				{
					using (StreamWriter streamWriter = new StreamWriter(zipArchive.CreateEntry("meta.json").Open()))
					{
						string value = JsonConvert.SerializeObject(new SaveDescription
						{
							Description = string_15,
							Timestamp = text,
							Region = base.Region,
							Name = base.Name,
							TitleId = base.TitleId.IdRaw
						});
						streamWriter.Write(value);
					}
				}
			}
			return text2;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002434C File Offset: 0x0002254C
		public void method_26(GClass82 gclass82_0, string string_15)
		{
			string string_16 = Path.Combine(this.String_8, string_15 + ".zip");
			Class4.smethod_1(this, gclass82_0.IPAddress_0, string_16);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00024380 File Offset: 0x00022580
		public static DriveInfo smethod_4(DataSize dataSize_1)
		{
			FrmSelectDrive frmSelectDrive = new FrmSelectDrive(dataSize_1);
			if (frmSelectDrive.ShowDialog() == DialogResult.OK)
			{
				return frmSelectDrive.driveInfo_0;
			}
			return null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000243A8 File Offset: 0x000225A8
		private string method_27(string string_15)
		{
			try
			{
				int i = 0;
				GClass78 gclass = new GClass78
				{
					bool_0 = true
				};
				if (base.System == GEnum3.const_3)
				{
					return gclass.method_6(string.Format("{0}/wii/info/json/{1}/info", Class65.String_2, base.TitleId.IdRaw));
				}
				if (base.Platform == Platform.Wii_U_Custom || base.Boolean_0)
				{
					return gclass.method_6(string.Format("{0}/wiiu/info/US/{1}", Class65.String_2, base.TitleId.IdRaw));
				}
				string text = gclass.method_7(string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/title/{1}/?shop_id=2", string_15, this.EshopId), 604800);
				if (text != "")
				{
					return text;
				}
				while (i < GClass32.string_11.Length)
				{
					if (GClass32.string_11[i] != string_15)
					{
						text = gclass.method_7(string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/title/{1}/?shop_id=2", GClass32.string_11[i], this.EshopId), 604800);
						if (text != "")
						{
							return text;
						}
					}
					i++;
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00011DA9 File Offset: 0x0000FFA9
		public void method_28(Action<GClass74, GClass32> action_0)
		{
			GClass32.Class41 @class = new GClass32.Class41();
			@class.gclass32_0 = this;
			@class.action_0 = action_0;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00011DCF File Offset: 0x0000FFCF
		public bool method_29(GClass30 gclass30_0)
		{
			return gclass30_0 == this || (this.Boolean_3 && gclass30_0 == this.Updates.Last<GClass33>()) || (this.Boolean_2 && gclass30_0 == this.Dlc);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00011E00 File Offset: 0x00010000
		public override string ToString()
		{
			return string.Format("{0} ({1}) ({2}) ({3}%)", new object[]
			{
				base.Name,
				base.Size,
				base.Region,
				base.Int32_0
			});
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00011E40 File Offset: 0x00010040
		public string method_30()
		{
			return string.Format("{0} ({1}) ({2})", base.Name, base.Size, base.Region);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000244C8 File Offset: 0x000226C8
		public GClass29 method_31()
		{
			FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(this, WhatToAction.Copy);
			if (frmWhatToCopy.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			return new GClass29
			{
				bool_0 = frmWhatToCopy.CopyDlc,
				bool_2 = frmWhatToCopy.CopyUpdate,
				bool_1 = frmWhatToCopy.CopyGame,
				list_0 = frmWhatToCopy.list_0
			};
		}

		// Token: 0x04000179 RID: 377
		private readonly string string_7 = string.Format("{0}/res/nintendont/template/", Class65.String_2);

		// Token: 0x0400017A RID: 378
		private readonly string string_8 = string.Format("{0}/res/Wii/template/", Class65.String_2);

		// Token: 0x0400017B RID: 379
		private readonly string string_9 = string.Format("{0}/res/SNES/template/", Class65.String_2);

		// Token: 0x0400017C RID: 380
		private readonly string string_10 = string.Format("{0}/res/N64/template/", Class65.String_2);

		// Token: 0x0400017D RID: 381
		private static readonly string[] string_11 = new string[]
		{
			"GB",
			"US",
			"JP",
			"AU",
			"DE",
			"FR",
			"IT",
			"SP",
			"MX"
		};

		// Token: 0x0400017E RID: 382
		private GClass74 gclass74_0;

		// Token: 0x0400017F RID: 383
		[CompilerGenerated]
		private GClass31 gclass31_0;

		// Token: 0x04000180 RID: 384
		[CompilerGenerated]
		private readonly string string_12;

		// Token: 0x04000181 RID: 385
		[CompilerGenerated]
		private readonly string string_13;

		// Token: 0x04000182 RID: 386
		[CompilerGenerated]
		private readonly string string_14;

		// Token: 0x04000183 RID: 387
		[CompilerGenerated]
		private readonly List<GClass33> list_1;

		// Token: 0x04000184 RID: 388
		public GClass86 gclass86_0 = new GClass86();

		// Token: 0x04000185 RID: 389
		public GClass86 gclass86_1 = new GClass86();

		// Token: 0x04000186 RID: 390
		public GClass86 gclass86_2 = new GClass86();

		// Token: 0x02000061 RID: 97
		[CompilerGenerated]
		private sealed class Class40
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00024520 File Offset: 0x00022720
			internal void method_0(object sender, EventArgs e)
			{
				this.frmWait_0.method_0();
				string destinationFileName = Path.Combine(this.string_0, this.string_1 + ".cia");
				FileSystem.MoveFile(Path.Combine(this.string_2, "game.cia"), destinationFileName, UIOption.AllDialogs);
				GClass95.smethod_3(this.string_2, "", true);
			}

			// Token: 0x0400018A RID: 394
			public FrmWait frmWait_0;

			// Token: 0x0400018B RID: 395
			public string string_0;

			// Token: 0x0400018C RID: 396
			public string string_1;

			// Token: 0x0400018D RID: 397
			public string string_2;
		}

		// Token: 0x02000062 RID: 98
		[CompilerGenerated]
		private sealed class Class41
		{
			// Token: 0x0600024E RID: 590 RVA: 0x0002457C File Offset: 0x0002277C
			internal void method_0()
			{
				if (this.gclass32_0.gclass74_0 == null)
				{
					string string_ = "JP";
					if (this.gclass32_0.Region != "JPN")
					{
						if (this.gclass32_0.Region == "KOR")
						{
							string_ = "KR";
						}
						else
						{
							string twoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
							if (!(twoLetterISOLanguageName == "en"))
							{
								if (!(twoLetterISOLanguageName == "fr"))
								{
									if (!(twoLetterISOLanguageName == "de"))
									{
										if (!(twoLetterISOLanguageName == "it"))
										{
											if (!(twoLetterISOLanguageName == "es"))
											{
												string_ = ((this.gclass32_0.Region == "USA") ? "US" : "GB");
											}
											else
											{
												string_ = ((this.gclass32_0.Region != "USA") ? "ES" : "MX");
											}
										}
										else
										{
											string_ = ((this.gclass32_0.Region != "USA") ? "IT" : "US");
										}
									}
									else
									{
										string_ = ((this.gclass32_0.Region != "USA") ? "DE" : "US");
									}
								}
								else
								{
									string_ = ((this.gclass32_0.Region != "USA") ? "FR" : "US");
								}
							}
							else
							{
								string_ = ((this.gclass32_0.Region == "USA") ? "US" : "GB");
							}
						}
					}
					string text = this.gclass32_0.method_27(string_);
					if (text != null)
					{
						try
						{
							this.gclass32_0.gclass74_0 = JsonConvert.DeserializeObject<GClass68>(text).Title;
						}
						catch
						{
						}
					}
				}
				if (this.gclass32_0.gclass74_0 != null)
				{
					this.action_0(this.gclass32_0.gclass74_0, this.gclass32_0);
				}
			}

			// Token: 0x0400018E RID: 398
			public GClass32 gclass32_0;

			// Token: 0x0400018F RID: 399
			public Action<GClass74, GClass32> action_0;
		}
	}
}
