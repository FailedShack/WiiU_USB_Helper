// Decompiled with JetBrains decompiler
// Type: ns0.GClass23
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace ns0
{
  public static class GClass23
  {
    public static Platform[] platform_0 = new Platform[14]
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
    public static Platform[] platform_1 = new Platform[8]
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
    public static Platform[] platform_2 = new Platform[5]
    {
      Platform.Wii_Custom,
      Platform.Wii_U_Custom,
      Platform.Gamecube,
      Platform.Super_NES_Custom,
      Platform.Nintendo_64_Custom
    };
    public static Platform[] platform_3 = new Platform[17]
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
    public static Platform[] platform_4 = new Platform[9]
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
    public static Platform[] platform_5 = new Platform[12]
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
    public static Platform[] platform_6 = new Platform[10]
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

    public static Image smethod_0(Platform platform_7)
    {
      foreach (DictionaryEntry resource in Class123.ResourceManager.GetResourceSet(new CultureInfo("en-US"), true, true))
      {
        if ((resource.Key as string).StartsWith("PFM"))
        {
          if (((IEnumerable<string>) (resource.Key as string).Substring(3).Split('P')).Contains<string>(((int) platform_7).ToString()))
            return resource.Value as Image;
        }
      }
      return (Image) null;
    }
  }
}
