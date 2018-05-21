// Decompiled with JetBrains decompiler
// Type: ns0.GClass33
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.IO;

namespace ns0
{
  public class GClass33 : GClass30
  {
    public GClass33(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, string string_10, GEnum3 genum3_1)
      : base(string_7, titleId_1, string_8, byte_2, dataSize_1, string_10, genum3_1)
    {
      this.Version = string_9;
    }

    public override string String_6
    {
      get
      {
        return base.String_6 + " (UPDATE)";
      }
    }

    public override string OutputPath
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return Path.Combine(base.OutputPath, "DATA_3DS", this.Region, "UPDATES", this.String_5 + string.Format(" (v{0})", (object) this.Version));
          case GEnum3.const_1:
            return Path.Combine(base.OutputPath, "DATA", this.Region, "UPDATES", this.String_5 + string.Format(" (v{0})", (object) this.Version));
          case GEnum3.const_2:
            throw new NotImplementedException();
          default:
            throw new NotImplementedException();
        }
      }
    }

    public override string ToString()
    {
      return string.Format("{0} (UPDATE DATA) (v{1}) ({2}) ({3})", (object) this.Name, (object) this.Version, (object) this.Size, (object) this.Region);
    }
  }
}
