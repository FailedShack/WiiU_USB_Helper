// Decompiled with JetBrains decompiler
// Type: ns0.GClass17
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using Nus_Helper_Shared_Core.NusHelper.Emulators;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.IO;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class GClass17
  {
    public static string string_0 = Path.Combine(GClass88.CachePath, "emu");
    private readonly Dictionary<string, EmuConfiguration> dictionary_0 = new Dictionary<string, EmuConfiguration>();
    private readonly GClass95 gclass95_0;
    private EmuConfiguration emuConfiguration_0;

    public GClass17(GClass95 gclass95_1)
    {
      this.gclass95_0 = gclass95_1;
    }

    public EmuConfiguration method_0()
    {
      if (!this.dictionary_0.ContainsKey(this.gclass95_0.Name))
      {
        try
        {
          this.emuConfiguration_0 = !File.Exists(this.String_0) ? this.EmuConfiguration_0 : JsonConvert.DeserializeObject<EmuConfiguration>(File.ReadAllText(this.String_0));
        }
        catch
        {
          this.emuConfiguration_0 = this.EmuConfiguration_0;
        }
        this.emuConfiguration_0.ConfigChanged += (EventHandler) ((sender, e) => this.method_2());
        this.method_1();
        this.dictionary_0.Add(this.gclass95_0.Name, this.emuConfiguration_0);
      }
      return this.dictionary_0[this.gclass95_0.Name];
    }

    private EmuConfiguration EmuConfiguration_0
    {
      get
      {
        return new EmuConfiguration()
        {
          RootPath = Path.Combine(GClass28.string_4, "DATA", "EMULATORS", this.gclass95_0.Name),
          AutoUpdate = true
        };
      }
    }

    private string String_0
    {
      get
      {
        return Path.Combine(GClass17.string_0, this.gclass95_0.Name + ".json");
      }
    }

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

    private void method_2()
    {
      File.WriteAllText(this.String_0, JsonConvert.SerializeObject((object) this.emuConfiguration_0));
    }
  }
}
