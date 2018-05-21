// Decompiled with JetBrains decompiler
// Type: WIIU_Downloader.Properties.Settings
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WIIU_Downloader.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("NONE")]
    public string Region
    {
      get
      {
        return (string) this[nameof (Region)];
      }
      set
      {
        this[nameof (Region)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool Cleanup
    {
      get
      {
        return (bool) this[nameof (Cleanup)];
      }
      set
      {
        this[nameof (Cleanup)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string Path
    {
      get
      {
        return (string) this[nameof (Path)];
      }
      set
      {
        this[nameof (Path)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string TicketsPath
    {
      get
      {
        return (string) this[nameof (TicketsPath)];
      }
      set
      {
        this[nameof (TicketsPath)] = (object) value;
      }
    }

    [DefaultSettingValue("DarkOrange")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string ThemeName
    {
      get
      {
        return (string) this[nameof (ThemeName)];
      }
      set
      {
        this[nameof (ThemeName)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool CompactView
    {
      get
      {
        return (bool) this[nameof (CompactView)];
      }
      set
      {
        this[nameof (CompactView)] = (object) value;
      }
    }

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ShowLegit
    {
      get
      {
        return (bool) this[nameof (ShowLegit)];
      }
      set
      {
        this[nameof (ShowLegit)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool ShowCFW
    {
      get
      {
        return (bool) this[nameof (ShowCFW)];
      }
      set
      {
        this[nameof (ShowCFW)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool ShowEvents
    {
      get
      {
        return (bool) this[nameof (ShowEvents)];
      }
      set
      {
        this[nameof (ShowEvents)] = (object) value;
      }
    }

    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public long LastNewsDate
    {
      get
      {
        return (long) this[nameof (LastNewsDate)];
      }
      set
      {
        this[nameof (LastNewsDate)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string TicketsPath3DS
    {
      get
      {
        return (string) this[nameof (TicketsPath3DS)];
      }
      set
      {
        this[nameof (TicketsPath3DS)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool Boolean_0
    {
      get
      {
        return (bool) this["EUR"];
      }
      set
      {
        this["EUR"] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool Boolean_1
    {
      get
      {
        return (bool) this["JPN"];
      }
      set
      {
        this["JPN"] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    public bool Boolean_2
    {
      get
      {
        return (bool) this["USA"];
      }
      set
      {
        this["USA"] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string CemuExecutable
    {
      get
      {
        return (string) this[nameof (CemuExecutable)];
      }
      set
      {
        this[nameof (CemuExecutable)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string ExtractFolder
    {
      get
      {
        return (string) this[nameof (ExtractFolder)];
      }
      set
      {
        this[nameof (ExtractFolder)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string DonationKey
    {
      get
      {
        return (string) this[nameof (DonationKey)];
      }
      set
      {
        this[nameof (DonationKey)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    public int LaunchCount
    {
      get
      {
        return (int) this[nameof (LaunchCount)];
      }
      set
      {
        this[nameof (LaunchCount)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string Platforms
    {
      get
      {
        return (string) this[nameof (Platforms)];
      }
      set
      {
        this[nameof (Platforms)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("0, 0, 0, 0")]
    [DebuggerNonUserCode]
    public Rectangle WindowPosition
    {
      get
      {
        return (Rectangle) this[nameof (WindowPosition)];
      }
      set
      {
        this[nameof (WindowPosition)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("Normal")]
    [UserScopedSetting]
    public FormWindowState WindowState
    {
      get
      {
        return (FormWindowState) this[nameof (WindowState)];
      }
      set
      {
        this[nameof (WindowState)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool ForceUpdates
    {
      get
      {
        return (bool) this[nameof (ForceUpdates)];
      }
      set
      {
        this[nameof (ForceUpdates)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool ShowHaxchiWarning
    {
      get
      {
        return (bool) this[nameof (ShowHaxchiWarning)];
      }
      set
      {
        this[nameof (ShowHaxchiWarning)] = (object) value;
      }
    }

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ForceUpdatesCitra
    {
      get
      {
        return (bool) this[nameof (ForceUpdatesCitra)];
      }
      set
      {
        this[nameof (ForceUpdatesCitra)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool ShowEmulatorDataWarning
    {
      get
      {
        return (bool) this[nameof (ShowEmulatorDataWarning)];
      }
      set
      {
        this[nameof (ShowEmulatorDataWarning)] = (object) value;
      }
    }

    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ShowProgramFilesWarning
    {
      get
      {
        return (bool) this[nameof (ShowProgramFilesWarning)];
      }
      set
      {
        this[nameof (ShowProgramFilesWarning)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool ShowCitraWarning
    {
      get
      {
        return (bool) this[nameof (ShowCitraWarning)];
      }
      set
      {
        this[nameof (ShowCitraWarning)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("True")]
    public bool Show552Warning
    {
      get
      {
        return (bool) this[nameof (Show552Warning)];
      }
      set
      {
        this[nameof (Show552Warning)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    [UserScopedSetting]
    public bool ForceUpdatesDolphin
    {
      get
      {
        return (bool) this[nameof (ForceUpdatesDolphin)];
      }
      set
      {
        this[nameof (ForceUpdatesDolphin)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool Boolean_3
    {
      get
      {
        return (bool) this["KOR"];
      }
      set
      {
        this["KOR"] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool EnableSuperSpeed
    {
      get
      {
        return (bool) this[nameof (EnableSuperSpeed)];
      }
      set
      {
        this[nameof (EnableSuperSpeed)] = (object) value;
      }
    }

    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public ulong MeasuredSpeed
    {
      get
      {
        return (ulong) this[nameof (MeasuredSpeed)];
      }
      set
      {
        this[nameof (MeasuredSpeed)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool Mine
    {
      get
      {
        return (bool) this[nameof (Mine)];
      }
      set
      {
        this[nameof (Mine)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    [UserScopedSetting]
    public string AppId
    {
      get
      {
        return (string) this[nameof (AppId)];
      }
      set
      {
        this[nameof (AppId)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool ForceGameMode
    {
      get
      {
        return (bool) this[nameof (ForceGameMode)];
      }
      set
      {
        this[nameof (ForceGameMode)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool PauseMiner
    {
      get
      {
        return (bool) this[nameof (PauseMiner)];
      }
      set
      {
        this[nameof (PauseMiner)] = (object) value;
      }
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("False")]
    [UserScopedSetting]
    public bool EnableCloudSaving
    {
      get
      {
        return (bool) this[nameof (EnableCloudSaving)];
      }
      set
      {
        this[nameof (EnableCloudSaving)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string CloudUserName
    {
      get
      {
        return (string) this[nameof (CloudUserName)];
      }
      set
      {
        this[nameof (CloudUserName)] = (object) value;
      }
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string CloudPassWord
    {
      get
      {
        return (string) this[nameof (CloudPassWord)];
      }
      set
      {
        this[nameof (CloudPassWord)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool ShowDownloadManagerTip
    {
      get
      {
        return (bool) this[nameof (ShowDownloadManagerTip)];
      }
      set
      {
        this[nameof (ShowDownloadManagerTip)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool ShowSpeedGraph
    {
      get
      {
        return (bool) this[nameof (ShowSpeedGraph)];
      }
      set
      {
        this[nameof (ShowSpeedGraph)] = (object) value;
      }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool ChatNotifications
    {
      get
      {
        return (bool) this[nameof (ChatNotifications)];
      }
      set
      {
        this[nameof (ChatNotifications)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string TicketsPathWii
    {
      get
      {
        return (string) this[nameof (TicketsPathWii)];
      }
      set
      {
        this[nameof (TicketsPathWii)] = (object) value;
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool GameSpecificRoom
    {
      get
      {
        return (bool) this[nameof (GameSpecificRoom)];
      }
      set
      {
        this[nameof (GameSpecificRoom)] = (object) value;
      }
    }
  }
}
