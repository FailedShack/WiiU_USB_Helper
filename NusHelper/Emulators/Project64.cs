// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Project64
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
  internal class Project64 : GClass95
  {
    public Project64(GClass30 title, bool forceUpdate)
      : base(title, nameof (Project64), "http://www.pj64-emu.com/", forceUpdate, false)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetExecutable()
    {
      return Path.Combine(this.String_4, "Project64.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    public override string GetRom()
    {
      string path = Path.Combine(this.CurrentGamePath, "content", "rom");
      if (!Directory.Exists(path))
        return "";
      string[] files = Directory.GetFiles(path);
      if (((IEnumerable<string>) files).Any<string>())
        return files[0];
      return "";
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      if (!this.Boolean_2 && this.gclass30_0.System == GEnum3.const_1)
      {
        IEnumerable<GClass12> ienumerable_0 = this.gclass30_0.method_15().Files.Where<GClass12>((Func<GClass12, bool>) (x => x.string_0.Contains("rom")));
        this.gclass30_0.method_16(this.String_5, true, directDownload, ienumerable_0, true);
      }
      this.method_12(true);
    }
  }
}
