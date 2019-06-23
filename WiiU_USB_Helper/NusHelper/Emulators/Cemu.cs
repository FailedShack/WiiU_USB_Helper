using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Alphaleonis.Win32.Filesystem;
using DokanNet;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using ns0;
using Telerik.WinControls;

namespace NusHelper.Emulators
{
	// Token: 0x020000EF RID: 239
	internal class Cemu : GClass95
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x00014504 File Offset: 0x00012704
		public Cemu(GClass30 title, bool forceUpdate) : base(title, "Cemu", "http://cemu.info", forceUpdate, false)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00030200 File Offset: 0x0002E400
		public string UpdatePath
		{
			get
			{
				return System.IO.Path.Combine(new string[]
				{
					base.String_4,
					"mlc01",
					"usr",
					"title",
					"00050000",
					this.gclass30_0.TitleId.High.ToLower()
				});
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00014519 File Offset: 0x00012719
		public string DlcPath
		{
			get
			{
				return System.IO.Path.Combine(this.UpdatePath, "aoc");
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001452B File Offset: 0x0001272B
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			Class65.smethod_10();
			if (this.bool_0 && !Cemu._gPackApplied)
			{
				GClass2.smethod_0();
				Cemu._gPackApplied = true;
			}
			base.PrepareRomIfNecessary(directDownload);
			this.PrepareUpdateIfNecessary(directDownload);
			this.PrepareDlcIfNecessary(directDownload);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00014561 File Offset: 0x00012761
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00014569 File Offset: 0x00012769
		public bool RenderUpsideDown { get; set; }

		// Token: 0x0600068E RID: 1678 RVA: 0x0003025C File Offset: 0x0002E45C
		private void PrepareDlcIfNecessary(bool directDownload)
		{
			if (!(this.gclass30_0 is GClass32))
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
			if (gclass.Dlc.GEnum2_0 != GEnum2.const_2 && !directDownload)
			{
				return;
			}
			try
			{
				GClass31 dlc = gclass.Dlc;
				string text = System.IO.Path.Combine(this.DlcPath, "tmd");
				string text2 = System.IO.Path.Combine(gclass.Dlc.OutputPath, "title.tmd");
				if (!System.IO.Directory.Exists(this.DlcPath) || !System.IO.File.Exists(text) || !System.IO.File.ReadAllBytes(text).smethod_5(System.IO.File.ReadAllBytes(text2)))
				{
					System.IO.Directory.CreateDirectory(this.DlcPath);
					dlc.method_16(this.DlcPath, false, directDownload, null, false);
					System.IO.File.Copy(text2, text, true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00014572 File Offset: 0x00012772
		internal override string CurrentGamePath
		{
			get
			{
				if (this._overriddenGamePath == null)
				{
					return base.CurrentGamePath;
				}
				return this._overriddenGamePath;
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00030340 File Offset: 0x0002E540
		public void PlayStream()
		{
			string mount_point = System.IO.Path.Combine(GClass88.CachePath, "streaming", System.IO.Path.GetRandomFileName());
			System.IO.Directory.CreateDirectory(mount_point);
			Class15 fs = new Class15(this.CurrentGamePath, this.gclass30_0);
			Task.Run(delegate()
			{
				fs.Mount(mount_point, DokanOptions.WriteProtection, 1, null);
			});
			Thread.Sleep(3000);
			this._overriddenGamePath = mount_point;
			this.InternaPrelPlay();
			base.Event_0 += delegate(object sender, EventArgs e)
			{
				fs.method_1();
				Dokan.RemoveMountPoint(mount_point);
			};
			base.method_8(this.GetArguments());
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000303DC File Offset: 0x0002E5DC
		private void PrepareUpdateIfNecessary(bool directDownload)
		{
			if (!(this.gclass30_0 is GClass32))
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
				if (!System.IO.Directory.Exists(this.UpdatePath))
				{
					System.IO.Directory.CreateDirectory(this.UpdatePath);
				}
				else
				{
					string text = System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml");
					if (System.IO.File.Exists(text))
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string value = xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value;
						GClass33 gclass2 = gclass.Updates.Last((GClass33 x) => x.GEnum2_0 == GEnum2.const_2);
						flag = (value == gclass2.Version);
					}
				}
				if (!flag)
				{
					if (!directDownload)
					{
						gclass.Updates.Last((GClass33 x) => x.GEnum2_0 == GEnum2.const_2).method_16(this.UpdatePath, false, false, null, false);
					}
					else
					{
						gclass.Updates.Last<GClass33>().method_16(this.UpdatePath, false, true, null, false);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00014589 File Offset: 0x00012789
		private string MetaFileUrl
		{
			get
			{
				return string.Format("{0}meta.txt", this.ShaderBaseUrl);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001459B File Offset: 0x0001279B
		private string[] GetShaderMetaData()
		{
			return new GClass78().method_6(this.MetaFileUrl).Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.RemoveEmptyEntries);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000145C1 File Offset: 0x000127C1
		public string ShaderTransferDir
		{
			get
			{
				return System.IO.Path.Combine(base.String_4, "shaderCache", "transferable");
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000145D8 File Offset: 0x000127D8
		private string ShaderFile
		{
			get
			{
				return System.IO.Path.Combine(this.ShaderTransferDir, this.ShaderName + ".bin");
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00030520 File Offset: 0x0002E720
		private string ShaderName
		{
			get
			{
				if (this._shaderName == null)
				{
					string[] shaderMetaData = this.GetShaderMetaData();
					this._shaderName = shaderMetaData[0];
					this._shaderHash = shaderMetaData[1].smethod_6();
				}
				return this._shaderName;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0003055C File Offset: 0x0002E75C
		private byte[] ShaderHash
		{
			get
			{
				if (this._shaderHash == null)
				{
					string[] shaderMetaData = this.GetShaderMetaData();
					this._shaderName = shaderMetaData[0];
					this._shaderHash = shaderMetaData[1].smethod_6();
				}
				return this._shaderHash;
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00030598 File Offset: 0x0002E798
		public bool ShaderCacheIsInstalled()
		{
			if (new ComputerInfo().TotalPhysicalMemory < 6000000000UL)
			{
				return true;
			}
			if (!this.ShaderCacheIsAvailable())
			{
				return true;
			}
			if (!System.IO.File.Exists(this.ShaderFile))
			{
				return false;
			}
			bool result;
			using (SHA256 sha = SHA256.Create())
			{
				result = sha.ComputeHash(System.IO.File.ReadAllBytes(this.ShaderFile)).smethod_5(this.ShaderHash);
			}
			return result;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000145F5 File Offset: 0x000127F5
		private string ShaderBaseUrl
		{
			get
			{
				return string.Format("{0}/res/emulators/Cemu/shaders/{1}/", Class65.String_2, this.gclass30_0.TitleId.High);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00014616 File Offset: 0x00012816
		public void InstallShaderCache()
		{
			System.IO.Directory.CreateDirectory(this.ShaderTransferDir);
			GClass27.smethod_7(string.Format("{0}{1}.zip", this.ShaderBaseUrl, this.GetId()), this.ShaderTransferDir);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00030618 File Offset: 0x0002E818
		public bool ShaderCacheIsAvailable()
		{
			bool result;
			try
			{
				new GClass78().method_2(this.MetaFileUrl);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00011A1C File Offset: 0x0000FC1C
		public override bool SupportsCustomControllerProfiles
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00030650 File Offset: 0x0002E850
		public override string FileSaveLocation
		{
			get
			{
				return System.IO.Path.Combine(new string[]
				{
					base.String_4,
					"mlc01",
					"usr",
					"save",
					this.gclass30_0.TitleId.Low.ToLower(),
					this.gclass30_0.TitleId.High.ToLower()
				});
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000306BC File Offset: 0x0002E8BC
		public string GetId()
		{
			string result;
			try
			{
				byte[] array = System.IO.File.ReadAllBytes(base.method_11());
				uint num = 873913535u;
				foreach (uint num2 in array)
				{
					num = (num << 3 | num >> 29);
					num += num2;
				}
				result = num.ToString("X").ToLower();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00030728 File Offset: 0x0002E928
		public override List<GClass95.GStruct6> GetControllerProfiles()
		{
			List<GClass95.GStruct6> controllerProfiles = base.GetControllerProfiles();
			foreach (string text in new GClass78().method_6(string.Format("{0}/res/emulators/Cemu/controllers/meta.txt", Class65.String_2)).Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				controllerProfiles.Add(new GClass95.GStruct6
				{
					Name = text.Split(new char[]
					{
						'|'
					})[0],
					ResUrl = string.Format("{0}/res/emulators/Cemu/controllers/", Class65.String_2) + text.Split(new char[]
					{
						'|'
					})[1]
				});
			}
			return controllerProfiles;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000307D8 File Offset: 0x0002E9D8
		public override void ApplyControllerProfile(GClass95.GStruct6 config)
		{
			string text = System.IO.Path.Combine(base.String_4, "controllerProfiles");
			string string_ = System.IO.Path.Combine(text, "controller0.txt");
			System.IO.Directory.CreateDirectory(text);
			new GClass78().method_5(config.ResUrl, string_, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00014645 File Offset: 0x00012845
		public override string GetRom()
		{
			return base.method_11();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001464D File Offset: 0x0001284D
		public override string GetArguments()
		{
			if (this._modArgumentString == null)
			{
				return this.GenerateArguments(this.GetRom(), System.IO.Path.Combine(base.String_4, "mlc01"));
			}
			return this._modArgumentString;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001467A File Offset: 0x0001287A
		public override string GetExecutable()
		{
			return System.IO.Path.Combine(base.String_4, "cemu.exe");
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001468C File Offset: 0x0001288C
		public override DataSize GetUpdateSize()
		{
			return GClass95.smethod_1(this.UpdatePath);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00014699 File Offset: 0x00012899
		public override DataSize GetDlcSize()
		{
			return GClass95.smethod_1(this.DlcPath);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00030824 File Offset: 0x0002EA24
		public override ulong GetUpdateVersion()
		{
			string text = System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml");
			if (System.IO.File.Exists(text))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text);
				return ulong.Parse(xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value);
			}
			return 0UL;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00030874 File Offset: 0x0002EA74
		private void InstallCommunityShaders()
		{
			try
			{
				string id = this.GetId();
				long num = 0L;
				string text = System.IO.Path.Combine(this.ShaderTransferDir, id + ".bin");
				if (System.IO.File.Exists(text))
				{
					num = new System.IO.FileInfo(text).Length;
				}
				if (GClass6.smethod_20(string.Format("{0}/shaders/proposal.php", Class65.String_1), new NameValueCollection
				{
					{
						"id",
						id
					},
					{
						"size",
						num.ToString()
					}
				}) == "LARGER")
				{
					GClass27.smethod_7(string.Format("{0}/shaders/vault/{1}.zip", Class65.String_1, id), this.ShaderTransferDir);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0003092C File Offset: 0x0002EB2C
		private string GenerateArguments(string gameRomPath, string mlcPath)
		{
			return string.Format("-g \"{0}\"", gameRomPath) + (base.FullScreen ? " -f" : "") + (this.RenderUpsideDown ? " -ud" : (string.Format(" -mlc \"{0}\"", mlcPath) ?? ""));
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000146A6 File Offset: 0x000128A6
		private string PerformanceFile
		{
			get
			{
				return System.IO.Path.Combine(this.CurrentGamePath, "performance.helper");
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x000146B8 File Offset: 0x000128B8
		private string PerformanceFileMlc
		{
			get
			{
				return System.IO.Path.Combine(this.CurrentGamePath, "performance.mlc.helper");
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00030980 File Offset: 0x0002EB80
		private bool CheckNvidiaDriverVersion()
		{
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_VideoController").Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					PropertyData propertyData = managementObject.Properties["CurrentBitsPerPixel"];
					PropertyData propertyData2 = managementObject.Properties["Description"];
					PropertyData propertyData3 = managementObject.Properties["DriverVersion"];
					int num;
					if (propertyData.Value != null && propertyData2.Value != null && propertyData3.Value != null && propertyData2.Value.ToString().ToLower().Contains("nvidia") && int.TryParse(propertyData3.Value.ToString().Replace(".", "").Substring(5), out num) && num < 38792)
					{
						DialogResult dialogResult = RadMessageBox.Show("USB Helper has detected that your NVIDIA driver is very old. You will encounter several issues when playing games with Cemu. Please update your driver as soon as possible. Should I take you to the download page?", "Old driver", MessageBoxButtons.YesNoCancel);
						if (dialogResult == DialogResult.Cancel)
						{
							return false;
						}
						if (dialogResult == DialogResult.Yes)
						{
							Process.Start("http://www.nvidia.fr/Download/index.aspx");
							if (RadMessageBox.Show("It is recommended that you also delete your old shader cache, should I do it for you?", "Delete shader cache?", MessageBoxButtons.YesNo) == DialogResult.Yes)
							{
								GClass6.smethod_5(System.IO.Path.Combine(base.String_4, "shaderCache", "precompiled"));
							}
							return false;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000146CA File Offset: 0x000128CA
		public override void Play()
		{
			this.InternaPrelPlay();
			base.Play();
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00030B00 File Offset: 0x0002ED00
		private void InternaPrelPlay()
		{
			if (!this.CheckNvidiaDriverVersion())
			{
				return;
			}
			if (base.EmuConfiguration_0.AutoUpdate && new ComputerInfo().TotalPhysicalMemory >= 6442450944UL)
			{
				this.InstallCommunityShaders();
			}
			base.Event_0 += delegate(object sender, EventArgs e)
			{
				Class25.smethod_0(this.gclass30_0 as GClass32);
			};
			this._modArgumentString = null;
			GClass15 gclass = new GClass15((GClass32)this.gclass30_0);
			if (gclass.InstalledMods.Count > 0)
			{
				Dictionary<string, ulong> counter = null;
				Dictionary<string, ulong> counter_mlc = null;
				try
				{
					counter = JsonConvert.DeserializeObject<Dictionary<string, ulong>>(System.IO.File.ReadAllText(this.PerformanceFile));
				}
				catch
				{
					counter = new Dictionary<string, ulong>();
				}
				try
				{
					counter_mlc = JsonConvert.DeserializeObject<Dictionary<string, ulong>>(System.IO.File.ReadAllText(this.PerformanceFileMlc));
				}
				catch
				{
					counter_mlc = new Dictionary<string, ulong>();
				}
				gclass.method_7();
				List<GClass16> list = gclass.method_4();
				Class20 mapper = new Class20(this.CurrentGamePath, counter, 134217728L);
				Class20 mapper_mlc = new Class20(System.IO.Path.Combine(base.String_4, "mlc01"), counter_mlc, 134217728L);
				foreach (Alphaleonis.Win32.Filesystem.FileInfo fileInfo in gclass.List_0)
				{
					if (System.IO.File.Exists(base.String_4 + "\\mlc01\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass.String_0.Length)))
					{
						mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass.String_0.Length), fileInfo.FullName);
					}
					else if (System.IO.File.Exists(this.CurrentGamePath + fileInfo.FullName.Substring(gclass.String_0.Length)))
					{
						mapper.method_1(fileInfo.FullName.Substring(gclass.String_0.Length), fileInfo.FullName);
					}
					else
					{
						mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + fileInfo.FullName.Substring(gclass.String_0.Length), fileInfo.FullName);
						mapper.method_1(fileInfo.FullName.Substring(gclass.String_0.Length), fileInfo.FullName);
					}
				}
				foreach (GClass16 gclass2 in list)
				{
					string string_ = gclass.String_0 + gclass2.ArchiveRelativePath;
					mapper.method_1(gclass2.GameRelativePath, string_);
					mapper_mlc.method_1("\\usr\\title\\00050000\\" + this.gclass30_0.TitleId.High.ToLower() + gclass2.GameRelativePath, string_);
				}
				Task.Run(delegate()
				{
					foreach (KeyValuePair<string, ulong> keyValuePair in from x in counter
					orderby x.Value descending
					select x)
					{
						mapper.method_2(keyValuePair.Key);
					}
					foreach (KeyValuePair<string, ulong> keyValuePair2 in from x in counter_mlc
					orderby x.Value descending
					select x)
					{
						mapper_mlc.method_2(keyValuePair2.Key);
					}
					mapper.method_0();
					mapper_mlc.method_0();
				});
				System.IO.Directory.CreateDirectory(System.IO.Path.Combine(GClass88.CachePath, "mods", "mount"));
				foreach (System.IO.DirectoryInfo directoryInfo in new System.IO.DirectoryInfo(System.IO.Path.Combine(GClass88.CachePath, "mods", "mount")).EnumerateDirectories())
				{
					try
					{
						try
						{
							Dokan.RemoveMountPoint(directoryInfo.FullName);
						}
						catch
						{
						}
						directoryInfo.Delete(true);
					}
					catch
					{
					}
				}
				string mount_point = System.IO.Path.Combine(GClass88.CachePath, "mods", "mount", System.IO.Path.GetRandomFileName());
				string mount_point_mlc = System.IO.Path.Combine(GClass88.CachePath, "mods", "mount", System.IO.Path.GetRandomFileName());
				GClass6.smethod_5(mount_point);
				System.IO.Directory.CreateDirectory(mount_point);
				System.IO.Directory.CreateDirectory(mount_point_mlc);
				base.Event_0 += delegate(object sender, EventArgs e)
				{
					mapper.method_4();
					mapper_mlc.method_4();
					System.IO.File.WriteAllText(this.PerformanceFile, JsonConvert.SerializeObject(counter));
					System.IO.File.WriteAllText(this.PerformanceFileMlc, JsonConvert.SerializeObject((from x in counter_mlc
					where x.Key.Contains("\\USR\\TITLE\\00050000\\")
					select x).ToDictionary((KeyValuePair<string, ulong> x) => x.Key, (KeyValuePair<string, ulong> x) => x.Value)));
					Dokan.RemoveMountPoint(mount_point);
					Dokan.RemoveMountPoint(mount_point_mlc);
					GClass6.smethod_5(mount_point);
					GClass6.smethod_5(mount_point_mlc);
				};
				Task.Run(delegate()
				{
					mapper.Mount(mount_point, DokanOptions.WriteProtection, 10, null);
				});
				Task.Run(delegate()
				{
					mapper_mlc.Mount(mount_point_mlc, DokanOptions.FixedDrive, 10, null);
				});
				Thread.Sleep(2000);
				string gameRomPath = (from x in System.IO.Directory.GetFiles(System.IO.Path.Combine(mount_point, "code") + "\\")
				where System.IO.Path.GetExtension(x) == ".rpx"
				select x).ToList<string>()[0];
				this._modArgumentString = this.GenerateArguments(gameRomPath, mount_point_mlc);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00031090 File Offset: 0x0002F290
		public override void DeleteUpdate()
		{
			base.DeleteUpdate();
			try
			{
				GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "code"));
			}
			catch
			{
			}
			try
			{
				GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "meta"));
			}
			catch
			{
			}
			try
			{
				GClass6.smethod_5(System.IO.Path.Combine(this.UpdatePath, "content"));
			}
			catch
			{
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0003111C File Offset: 0x0002F31C
		public override void DeleteDlc()
		{
			try
			{
				GClass6.smethod_5(this.DlcPath);
			}
			catch
			{
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000146D8 File Offset: 0x000128D8
		public override bool UpdateIsInstalled()
		{
			return System.IO.File.Exists(System.IO.Path.Combine(this.UpdatePath, "meta", "meta.xml"));
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000146F4 File Offset: 0x000128F4
		public override bool DlcIsInstalled()
		{
			return System.IO.Directory.Exists(this.DlcPath);
		}

		// Token: 0x040003BC RID: 956
		private static bool _gPackApplied;

		// Token: 0x040003BE RID: 958
		private string _overriddenGamePath;

		// Token: 0x040003BF RID: 959
		private string _shaderName;

		// Token: 0x040003C0 RID: 960
		private byte[] _shaderHash;

		// Token: 0x040003C1 RID: 961
		private string _modArgumentString;
	}
}
