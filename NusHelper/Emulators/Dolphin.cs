// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Dolphin
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;
using System.Collections.Generic;
using System.IO;

namespace NusHelper.Emulators
{
  public class Dolphin : GClass95
  {
    public Dolphin(GClass30 title, bool forceUpdate)
      : base(title, nameof (Dolphin), "https://dolphin-emu.org/", forceUpdate, true)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetExecutable()
    {
      return Path.Combine(this.String_4, "Dolphin.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      Class67.smethod_10();
      if (this.Boolean_2)
        return;
      switch (this.gclass30_0.System)
      {
        case GEnum3.const_1:
          this.gclass30_0.method_16(this.CurrentGamePath, false, false, (IEnumerable<GClass12>) null, false);
          Class81.smethod_2(Path.Combine(this.CurrentGamePath, "content"));
          this.method_12(true);
          break;
        case GEnum3.const_3:
          this.gclass30_0.method_10(this.CurrentGamePath, "game.wad");
          break;
        default:
          throw new ArgumentException("This game cannot be used with Dolphin!");
      }
    }

    public override string GetRom()
    {
      switch (this.gclass30_0.System)
      {
        case GEnum3.const_1:
          return Path.Combine(this.CurrentGamePath, "game.iso");
        case GEnum3.const_3:
          return Path.Combine(this.CurrentGamePath, "game.wad");
        default:
          throw new ArgumentException("This game cannot be used with Dolphin!");
      }
    }
  }
}
