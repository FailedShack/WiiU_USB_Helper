// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.VisualBoyAdvance
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;
using System.IO;

namespace NusHelper.Emulators
{
  internal class VisualBoyAdvance : GClass95
  {
    public VisualBoyAdvance(GClass30 title, bool forceUpdate)
      : base(title, nameof (VisualBoyAdvance), "https://sourceforge.net/projects/vba/", forceUpdate, false)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetExecutable()
    {
      return Path.Combine(this.String_4, "VisualBoyAdvance.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    public override string GetRom()
    {
      if (this.gclass30_0.Platform == Platform.GameBoy_Color || this.gclass30_0.Platform == Platform.GameBoy)
        return Path.Combine(this.CurrentGamePath, "rom.gb");
      if (this.gclass30_0.Platform == Platform.GameBoy_Advance)
        return Path.Combine(this.CurrentGamePath, "rom.gba");
      throw new Exception("This type of game is not compatible with this emulator!");
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      Class67.smethod_10();
      if (this.Boolean_2 || this.gclass30_0.Platform != Platform.GameBoy_Color && this.gclass30_0.Platform != Platform.GameBoy)
        return;
      this.gclass30_0.method_4(this.CurrentGamePath, true, false, false);
      File.Move(new DirectoryInfo(Path.Combine(this.CurrentGamePath, "romfs", "rom")).GetFiles()[0].FullName, this.GetRom());
      this.method_12(true);
    }
  }
}
