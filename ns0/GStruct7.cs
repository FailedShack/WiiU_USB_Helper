// Decompiled with JetBrains decompiler
// Type: ns0.GStruct7
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Collections.Generic;
using System.Linq;

namespace ns0
{
  public struct GStruct7
  {
    public readonly List<int> list_0;
    public readonly bool bool_0;
    public readonly bool bool_1;
    private readonly GClass101 gclass101_0;

    public GStruct7(GClass101 gclass101_1, List<int> list_1, bool bool_2, bool bool_3)
    {
      this.gclass101_0 = gclass101_1;
      this.list_0 = list_1;
      this.bool_1 = bool_2;
      this.bool_0 = bool_3;
    }

    public bool Boolean_0
    {
      get
      {
        if (!this.bool_0 && !this.bool_1)
          return !this.list_0.Any<int>();
        return false;
      }
    }

    public override string ToString()
    {
      return string.Format("File {0:x8} has {1} bad blocks", (object) this.gclass101_0.ContentId, (object) this.list_0.Count);
    }
  }
}
