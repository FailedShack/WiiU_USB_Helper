// Decompiled with JetBrains decompiler
// Type: Nus_Helper_Shared_Core.NusHelper.Emulators.EmuConfiguration
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace Nus_Helper_Shared_Core.NusHelper.Emulators
{
  public class EmuConfiguration
  {
    private bool _autoUpdate;
    private string _rootPath;

    public event EventHandler ConfigChanged;

    [JsonProperty("autoUpdate")]
    [DisplayName("Update automatically")]
    [Description("If you check this, the emulator will always be kept up to date. Disable it if you want to use your own version.")]
    public bool AutoUpdate
    {
      get
      {
        return this._autoUpdate;
      }
      set
      {
        this._autoUpdate = value;
        this.FireChange();
      }
    }

    [JsonProperty("rootPath")]
    [DisplayName("Installation Path")]
    [Description("The location where the emulator and its games will be stored. The emulator must be in a subdirectory called BIN. Disable automatic updates if you don't want your version to be overwritten.")]
    public string RootPath
    {
      get
      {
        return this._rootPath;
      }
      set
      {
        this._rootPath = value;
        this.FireChange();
      }
    }

    private void FireChange()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler configChanged = this.ConfigChanged;
      if (configChanged == null)
        return;
      configChanged((object) this, (EventArgs) null);
    }
  }
}
