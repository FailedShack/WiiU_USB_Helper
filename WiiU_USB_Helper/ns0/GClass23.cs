using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using NusHelper;

namespace ns0
{
	// Token: 0x02000047 RID: 71
	public static class GClass23
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x000221C0 File Offset: 0x000203C0
		public static Image smethod_0(Platform platform_7)
		{
			foreach (object obj in Class121.ResourceManager.GetResourceSet(new CultureInfo("en-US"), true, true))
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if ((dictionaryEntry.Key as string).StartsWith("PFM"))
				{
					IEnumerable<string> source = (dictionaryEntry.Key as string).Substring(3).Split(new char[]
					{
						'P'
					});
					int num = (int)platform_7;
					if (source.Contains(num.ToString()))
					{
						return dictionaryEntry.Value as Image;
					}
				}
			}
			return null;
		}

		// Token: 0x04000120 RID: 288
		public static Platform[] platform_0 = new Platform[]
		{
			Platform.Nintendo_3DS_Download,
			Platform.Nintendo_DSiWare,
			Platform.GameBoy,
			Platform.GameBoy_Color,
			Platform.GameBoy_Advance_3DS,
			Platform.NES_3DS,
			Platform.GameGear,
			Platform.PC_ENGINE,
			Platform.Downloadable_Video,
			Platform.Nintendo_3DS_Download_Software,
			Platform.Nintendo_3DS,
			Platform.New_3DS_Download,
			Platform.New_3DS_Card_Download,
			Platform.Super_NES_New_3DS
		};

		// Token: 0x04000121 RID: 289
		public static Platform[] platform_1 = new Platform[]
		{
			Platform.Super_NES_New_3DS,
			Platform.GameBoy,
			Platform.GameBoy_Advance_3DS,
			Platform.GameBoy_Color,
			Platform.Nintendo_DSiWare,
			Platform.NES_3DS,
			Platform.PC_ENGINE,
			Platform.GameGear
		};

		// Token: 0x04000122 RID: 290
		public static Platform[] platform_2 = new Platform[]
		{
			Platform.Wii_Custom,
			Platform.Wii_U_Custom,
			Platform.Gamecube,
			Platform.Super_NES_Custom,
			Platform.Nintendo_64_Custom
		};

		// Token: 0x04000123 RID: 291
		public static Platform[] platform_3 = new Platform[]
		{
			Platform.Wii_U_Custom,
			Platform.Wii_U_Disc,
			Platform.Wii_U_Download,
			Platform.Wii_U_Retail_Download,
			Platform.const_8,
			Platform.Super_NES,
			Platform.Wii_U_Download_Software,
			Platform.TurboGrafx16,
			Platform.const_12,
			Platform.GameBoy_Advance,
			Platform.Nintendo_DS,
			Platform.Nintendo_64,
			Platform.Wii,
			Platform.Gamecube,
			Platform.Wii_Custom,
			Platform.Super_NES_Custom,
			Platform.Nintendo_64_Custom
		};

		// Token: 0x04000124 RID: 292
		public static Platform[] platform_4 = new Platform[]
		{
			Platform.GameBoy_Advance,
			Platform.GameGear,
			Platform.const_12,
			Platform.const_8,
			Platform.Nintendo_64,
			Platform.Super_NES,
			Platform.TurboGrafx16,
			Platform.Wii,
			Platform.Nintendo_DS
		};

		// Token: 0x04000125 RID: 293
		public static Platform[] platform_5 = new Platform[]
		{
			Platform.Arcade,
			Platform.NES_Wii,
			Platform.Super_NES_Wii,
			Platform.Nintendo_64_Wii,
			Platform.Master_System,
			Platform.Mega_Drive,
			Platform.TurboGrafx16_Wii,
			Platform.Neo_Geo,
			Platform.Commodore_64,
			Platform.MSX_Wii,
			Platform.WiiWare,
			Platform.Channel
		};

		// Token: 0x04000126 RID: 294
		public static Platform[] platform_6 = new Platform[]
		{
			Platform.Arcade,
			Platform.NES_Wii,
			Platform.Super_NES_Wii,
			Platform.Nintendo_64_Wii,
			Platform.Master_System,
			Platform.Mega_Drive,
			Platform.TurboGrafx16_Wii,
			Platform.Neo_Geo,
			Platform.Commodore_64,
			Platform.MSX_Wii
		};
	}
}
