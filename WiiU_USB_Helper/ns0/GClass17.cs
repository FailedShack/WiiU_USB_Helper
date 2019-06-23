using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using NusHelper.Emulators;
using Nus_Helper_Shared_Core.NusHelper.Emulators;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x0200002C RID: 44
	public class GClass17
	{
		// Token: 0x060000FA RID: 250 RVA: 0x000110E6 File Offset: 0x0000F2E6
		public GClass17(GClass95 gclass95_1)
		{
			this.gclass95_0 = gclass95_1;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001E704 File Offset: 0x0001C904
		public EmuConfiguration method_0()
		{
			if (!this.dictionary_0.ContainsKey(this.gclass95_0.Name))
			{
				try
				{
					if (File.Exists(this.String_0))
					{
						this.emuConfiguration_0 = JsonConvert.DeserializeObject<EmuConfiguration>(File.ReadAllText(this.String_0));
					}
					else
					{
						this.emuConfiguration_0 = this.EmuConfiguration_0;
					}
				}
				catch
				{
					this.emuConfiguration_0 = this.EmuConfiguration_0;
				}
				this.emuConfiguration_0.ConfigChanged += this.emuConfiguration_0_ConfigChanged;
				this.method_1();
				this.dictionary_0.Add(this.gclass95_0.Name, this.emuConfiguration_0);
			}
			return this.dictionary_0[this.gclass95_0.Name];
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00011116 File Offset: 0x0000F316
		private EmuConfiguration EmuConfiguration_0
		{
			get
			{
				return new EmuConfiguration
				{
					RootPath = Path.Combine(GClass28.string_4, "DATA", "EMULATORS", this.gclass95_0.Name),
					AutoUpdate = true
				};
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00011149 File Offset: 0x0000F349
		private string String_0
		{
			get
			{
				return Path.Combine(GClass17.string_0, this.gclass95_0.Name + ".json");
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		private void method_1()
		{
			if (!Settings.Default.ForceUpdates && this.gclass95_0 is Cemu)
			{
				this.emuConfiguration_0.AutoUpdate = false;
				Settings.Default.ForceUpdates = true;
			}
			if (!Settings.Default.ForceUpdatesCitra && this.gclass95_0 is Citra)
			{
				this.emuConfiguration_0.AutoUpdate = false;
				Settings.Default.ForceUpdatesCitra = true;
			}
			if (!Settings.Default.ForceUpdatesDolphin && this.gclass95_0 is Dolphin)
			{
				this.emuConfiguration_0.AutoUpdate = false;
				Settings.Default.ForceUpdatesDolphin = true;
			}
			Settings.Default.Save();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001116A File Offset: 0x0000F36A
		private void method_2()
		{
			File.WriteAllText(this.String_0, JsonConvert.SerializeObject(this.emuConfiguration_0));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00011182 File Offset: 0x0000F382
		[CompilerGenerated]
		private void emuConfiguration_0_ConfigChanged(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x0400007B RID: 123
		public static string string_0 = Path.Combine(GClass88.CachePath, "emu");

		// Token: 0x0400007C RID: 124
		private readonly Dictionary<string, EmuConfiguration> dictionary_0 = new Dictionary<string, EmuConfiguration>();

		// Token: 0x0400007D RID: 125
		private readonly GClass95 gclass95_0;

		// Token: 0x0400007E RID: 126
		private EmuConfiguration emuConfiguration_0;
	}
}
