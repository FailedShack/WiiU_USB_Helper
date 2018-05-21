// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.DeSmuMe
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NusHelper.Emulators
{
  internal class DeSmuMe : GClass95
  {
    public DeSmuMe(GClass30 title, bool forceUpdate)
      : base(title, "DeSmuME", "http://desmume.org/", forceUpdate, false)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetExecutable()
    {
      return Path.Combine(this.String_4, "DeSmuME.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    public override string GetRom()
    {
      return Path.Combine(this.CurrentGamePath, "content", "0010", "rom.zip");
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      Class67.smethod_10();
      if (this.Boolean_2 || this.gclass30_0.System != GEnum3.const_1)
        return;
      IEnumerable<GClass12> ienumerable_0 = this.gclass30_0.method_15().Files.Where<GClass12>((Func<GClass12, bool>) (x => x.string_1 == "rom.zip"));
      Directory.CreateDirectory(Path.Combine(this.CurrentGamePath, "content", "0010"));
      this.gclass30_0.method_16(this.String_5, true, directDownload, ienumerable_0, true);
    }
  }
}
