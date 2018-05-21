// Decompiled with JetBrains decompiler
// Type: ns0.GClass20
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace ns0
{
  public static class GClass20
  {
    public static bool smethod_0(this RadListView radListView_0, GClass30 gclass30_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return radListView_0.Items.Any<ListViewDataItem>(new Func<ListViewDataItem, bool>(new GClass20.Class29()
      {
        gclass30_0 = gclass30_0
      }.method_0));
    }
  }
}
