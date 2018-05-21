// Decompiled with JetBrains decompiler
// Type: ns0.GClass31
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.IO;

namespace ns0
{
  public class GClass31 : GClass30
  {
    public GClass31(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, GEnum3 genum3_1)
      : base(string_7, titleId_1, string_8, byte_2, dataSize_1, string_9, genum3_1)
    {
    }

    public override string String_6
    {
      get
      {
        return base.String_6 + " (DLC)";
      }
    }

    public override string OutputPath
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return Path.Combine(base.OutputPath, "DATA_3DS", this.Region, "DLCS", this.String_5);
          case GEnum3.const_1:
            return Path.Combine(base.OutputPath, "DATA", this.Region, "DLCS", this.String_5);
          case GEnum3.const_2:
            throw new NotImplementedException();
          default:
            throw new NotImplementedException();
        }
      }
    }

    public override string ToString()
    {
      return string.Format("{0} (DLC) ({1}) ({2})", (object) this.Name, (object) this.Size, (object) this.Region);
    }
  }
}
