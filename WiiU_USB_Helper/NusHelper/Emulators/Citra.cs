using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CommonCompressors;
using Microsoft.VisualBasic.FileIO;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000DD RID: 221
	internal class Citra : GClass95
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00014031 File Offset: 0x00012231
		public Citra(GClass30 title, bool forceUpdate) : base(title, "Citra", "https://citra-emu.org/", forceUpdate, false)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0002DF3C File Offset: 0x0002C13C
		public static Citra.NCCH_TYPE GetNcchType(string filePath)
		{
			Citra.NCCH_TYPE result;
			try
			{
				using (FileStream fileStream = File.OpenRead(filePath))
				{
					fileStream.Seek(256L, SeekOrigin.Begin);
					byte[] array = new byte[4];
					fileStream.Read(array, 0, 4);
					if (!array.smethod_5(new byte[]
					{
						78,
						67,
						67,
						72
					}))
					{
						result = Citra.NCCH_TYPE.NONE;
					}
					else
					{
						fileStream.Seek(397L, SeekOrigin.Begin);
						int num = fileStream.ReadByte();
						bool flag = (num & 2) != 0;
						bool flag2;
						if ((flag2 = ((num & 1) != 0)) && flag)
						{
							result = Citra.NCCH_TYPE.const_1;
						}
						else if (flag2)
						{
							result = Citra.NCCH_TYPE.const_0;
						}
						else
						{
							result = Citra.NCCH_TYPE.NONE;
						}
					}
				}
			}
			catch
			{
				result = Citra.NCCH_TYPE.NONE;
			}
			return result;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public override void Play()
		{
			Class65.smethod_10();
			this.DownloadSharedFont();
			foreach (GClass32 archive in GClass28.list_0)
			{
				this.DownloadArchive(archive);
			}
			this.PrepareRomIfNecessary(false);
			base.method_8(this.GetArguments());
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0002E068 File Offset: 0x0002C268
		private void DownloadArchive(GClass32 archive)
		{
			string text = Path.Combine(new string[]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				"Citra",
				"nand",
				"00000000000000000000000000000000",
				"title",
				archive.TitleId.Low.ToLower(),
				archive.TitleId.High.ToLower(),
				"content"
			});
			Directory.CreateDirectory(text);
			string destinationFile = Path.Combine(text, "00000000.app.romfs");
			if (File.Exists(destinationFile))
			{
				return;
			}
			GClass80 gclass = new GClass80(null, true, true);
			FrmWait frmWait = new FrmWait("Downloading system archive from: NUS...", true);
			gclass.Event_5 += delegate(object <p0>, GClass81 <p1>)
			{
				string temp_dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
				GClass6.smethod_5(temp_dir);
				Directory.CreateDirectory(temp_dir);
				Path.Combine(temp_dir, "game.cia");
				archive.method_5(temp_dir, "game");
				GClass27.smethod_11(temp_dir);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(temp_dir, "PART1"),
					WorkingDirectory = temp_dir
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = true;
				process.Exited += delegate(object sender, EventArgs e)
				{
					try
					{
						IEnumerable<FileInfo> potential_files = new DirectoryInfo(temp_dir).EnumerateFiles("contents.*");
						if (potential_files.Count<FileInfo>() == 0)
						{
							throw new Exception("An error occured while preparing the system archive!");
						}
						FileInfo arg = potential_files.First((FileInfo x) => x.Length == potential_files.Max((FileInfo y) => y.Length));
						ProcessStartInfo startInfo2 = new ProcessStartInfo
						{
							FileName = Path.Combine(temp_dir, "3dstool.exe"),
							WorkingDirectory = temp_dir,
							Arguments = string.Format("-xvtf cfa {0} --romfs 00000000.app.romfs --romfs-auto-key", arg)
						};
						Process process2 = new Process();
						process2.StartInfo = startInfo2;
						process2.Exited += delegate(object sender, EventArgs e)
						{
							string path = Path.Combine(temp_dir, "00000000.app.romfs");
							using (FileStream fileStream = File.Create(destinationFile))
							{
								using (FileStream fileStream2 = File.Open(path, FileMode.Open))
								{
									fileStream2.Seek(4096L, SeekOrigin.Begin);
									int num = 0;
									while ((long)num < fileStream2.Length - 4096L)
									{
										int num2 = fileStream2.ReadByte();
										fileStream.WriteByte((byte)num2);
										num++;
									}
								}
							}
							GClass6.smethod_5(temp_dir);
							frmWait.method_0();
						};
						process2.EnableRaisingEvents = true;
						process2.Start();
					}
					catch
					{
					}
				};
				process.Start();
			};
			gclass.Event_6 += delegate(object sender, GEventArgs0 e)
			{
				frmWait.method_2(e.GameProgress);
			};
			gclass.method_1(new GClass30[]
			{
				archive
			}.ToList<GClass30>(), 100, 10000);
			frmWait.ShowDialog();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0002E180 File Offset: 0x0002C380
		private void DownloadSharedFont()
		{
			string sharedFontDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Citra", "sysdata", "shared_font.bin");
			if (File.Exists(sharedFontDestination))
			{
				return;
			}
			GClass80 gclass = new GClass80(null, true, true);
			FrmWait frmWait = new FrmWait("Downloading the Shared Font from NUS...", true);
			gclass.Event_5 += delegate(object <p0>, GClass81 <p1>)
			{
				Path.Combine(Path.GetTempPath(), "game.cia");
				GClass28.gclass32_0.method_5(Path.GetTempPath(), "game");
				string outputDir = Path.GetTempPath();
				GClass27.smethod_11(outputDir);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(outputDir, "PART1"),
					WorkingDirectory = outputDir
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = true;
				process.Exited += delegate(object sender, EventArgs e)
				{
					try
					{
						ProcessStartInfo startInfo2 = new ProcessStartInfo
						{
							FileName = Path.Combine(outputDir, "3dstool.exe"),
							WorkingDirectory = outputDir,
							Arguments = "-xvtf cfa contents.0000.00000000 --romfs DecryptedRomFS.bin --romfs-auto-key"
						};
						Process process2 = new Process();
						process2.StartInfo = startInfo2;
						process2.Exited += delegate(object sender, EventArgs e)
						{
							ProcessStartInfo startInfo3 = new ProcessStartInfo
							{
								FileName = "3dstool.exe",
								WorkingDirectory = outputDir,
								Arguments = "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS"
							};
							Process process3 = new Process();
							process3.StartInfo = startInfo3;
							process3.EnableRaisingEvents = true;
							process3.Exited += delegate(object sender, EventArgs e)
							{
								string path = Path.Combine(outputDir, "ExtractedRomFS", "cbf_std.bcfnt.lz");
								byte[] buffer = new LZ11().Decompress(File.ReadAllBytes(path));
								Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Citra", "sysdata"));
								using (FileStream fileStream = File.Create(sharedFontDestination))
								{
									using (MemoryStream memoryStream = new MemoryStream(buffer))
									{
										memoryStream.Seek(928L, SeekOrigin.Begin);
										fileStream.Write(Class3.byte_1, 0, Class3.byte_1.Length);
										for (int i = 0; i < 3095744; i++)
										{
											int num = memoryStream.ReadByte();
											fileStream.WriteByte((byte)num);
										}
										fileStream.Write(Class3.byte_0, 0, Class3.byte_0.Length);
									}
								}
								frmWait.method_0();
							};
							process3.Start();
						};
						process2.EnableRaisingEvents = true;
						process2.Start();
					}
					catch
					{
					}
				};
				process.Start();
			};
			gclass.Event_6 += delegate(object sender, GEventArgs0 e)
			{
				frmWait.method_2(e.GameProgress);
			};
			gclass.method_1(new GClass30[]
			{
				GClass28.gclass32_0
			}.ToList<GClass30>(), 100, 10000);
			frmWait.ShowDialog();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00014046 File Offset: 0x00012246
		public override string GetArguments()
		{
			return string.Format("\"{0}\"", this.GetRom());
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00014058 File Offset: 0x00012258
		public override string GetExecutable()
		{
			return Path.Combine(base.String_4, "citra-qt.exe");
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001406A File Offset: 0x0001226A
		public override string GetRom()
		{
			return Path.Combine(this.CurrentGamePath, "game.cxi");
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001407C File Offset: 0x0001227C
		private string UpdatePath
		{
			get
			{
				return Path.Combine(this.CitraTitlePath, "0004000e", this.gclass30_0.TitleId.High.ToLower(), "content");
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000140A8 File Offset: 0x000122A8
		private string CitraDataRootPath
		{
			get
			{
				return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Citra");
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000140BB File Offset: 0x000122BB
		private string CitraTitlePath
		{
			get
			{
				return Path.Combine(new string[]
				{
					this.CitraDataRootPath,
					"sdmc",
					"Nintendo 3DS",
					"00000000000000000000000000000000",
					"00000000000000000000000000000000",
					"title"
				});
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000140F9 File Offset: 0x000122F9
		private string UpdateVersionFilePath
		{
			get
			{
				return Path.Combine(this.UpdatePath, "ver");
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001410B File Offset: 0x0001230B
		private string UpdateFilePath
		{
			get
			{
				return Path.Combine(this.UpdatePath, "00000000.app");
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001411D File Offset: 0x0001231D
		private string DlcFilePath
		{
			get
			{
				return Path.Combine(this.DlcPath, "00000000.app");
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001412F File Offset: 0x0001232F
		private string DlcPath
		{
			get
			{
				return Path.Combine(this.CitraTitlePath, "0004000c", this.gclass30_0.TitleId.High.ToLower());
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0002E22C File Offset: 0x0002C42C
		public override void DeleteUpdate()
		{
			try
			{
				GClass6.smethod_5(this.UpdatePath);
			}
			catch
			{
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0002E25C File Offset: 0x0002C45C
		private void PrepareUpdateIfNecessary(bool directDownload)
		{
			if (!(this.gclass30_0 is GClass32))
			{
				return;
			}
			if (directDownload)
			{
				return;
			}
			GClass32 gclass = (GClass32)this.gclass30_0;
			if (!gclass.Boolean_3)
			{
				return;
			}
			if (GClass3.smethod_3(gclass.Updates[0]))
			{
				return;
			}
			bool flag = false;
			try
			{
				GClass33 gclass2 = gclass.Updates.Last((GClass33 x) => x.GEnum2_0 == GEnum2.const_2);
				if (!Directory.Exists(this.UpdatePath))
				{
					Directory.CreateDirectory(this.UpdatePath);
				}
				else if (this.UpdateIsInstalled() && File.Exists(this.UpdateVersionFilePath))
				{
					flag = (File.ReadAllText(this.UpdateVersionFilePath) == gclass2.Version);
				}
				if (!flag && !directDownload)
				{
					gclass2.method_3(this.UpdatePath, false);
					FileSystem.RenameFile(Path.Combine(this.UpdatePath, "game.cxi"), "00000000.app");
					File.WriteAllText(this.UpdateVersionFilePath, gclass2.Version);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0002E36C File Offset: 0x0002C56C
		private void PrepareDlcIfNecessary(bool directDownload)
		{
			if (!(this.gclass30_0 is GClass32))
			{
				return;
			}
			if (directDownload)
			{
				return;
			}
			GClass32 gclass = (GClass32)this.gclass30_0;
			if (!gclass.Boolean_2)
			{
				return;
			}
			if (GClass3.smethod_3(gclass.Dlc))
			{
				return;
			}
			if (this.DlcIsInstalled())
			{
				return;
			}
			gclass.Dlc.method_2(this.DlcPath);
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		public override string FileSaveLocation
		{
			get
			{
				return Path.Combine(new string[]
				{
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
					"Citra",
					"sdmc",
					"Nintendo 3DS",
					"00000000000000000000000000000000",
					"00000000000000000000000000000000",
					"title",
					this.gclass30_0.TitleId.Low.ToLower(),
					this.gclass30_0.TitleId.High.ToLower(),
					"data",
					"00000001"
				});
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0002E460 File Offset: 0x0002C660
		public override ulong GetUpdateVersion()
		{
			ulong result;
			try
			{
				result = ulong.Parse(File.ReadAllText(this.UpdateVersionFilePath));
			}
			catch
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0002E498 File Offset: 0x0002C698
		public override DataSize GetUpdateSize()
		{
			DataSize result;
			try
			{
				if (!File.Exists(this.UpdateFilePath))
				{
					result = new DataSize(0UL);
				}
				else
				{
					result = new DataSize((ulong)new FileInfo(this.UpdateFilePath).Length);
				}
			}
			catch
			{
				result = new DataSize(0UL);
			}
			return result;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0002E4F0 File Offset: 0x0002C6F0
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			if (!base.Boolean_2)
			{
				string text = Path.Combine(base.String_5, this.gclass30_0.TitleId.IdRaw);
				GClass6.smethod_5(text);
				this.gclass30_0.method_3(text, false);
				string name = new DirectoryInfo(this.CurrentGamePath).Name;
				GClass6.smethod_5(Path.Combine(base.String_5, name));
				FileSystem.RenameDirectory(text, name);
			}
			this.PrepareUpdateIfNecessary(directDownload);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00014156 File Offset: 0x00012356
		public override bool UpdateIsInstalled()
		{
			return File.Exists(this.UpdateFilePath) && new FileInfo(this.UpdateFilePath).Length > 0L;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001417B File Offset: 0x0001237B
		public override bool DlcIsInstalled()
		{
			return Directory.Exists(this.DlcFilePath);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00014188 File Offset: 0x00012388
		public override void DeleteDlc()
		{
			GClass6.smethod_5(this.DlcPath);
		}

		// Token: 0x020000DE RID: 222
		public enum NCCH_TYPE
		{
			// Token: 0x0400038C RID: 908
			const_0,
			// Token: 0x0400038D RID: 909
			const_1,
			// Token: 0x0400038E RID: 910
			NONE
		}
	}
}
