// Decompiled with JetBrains decompiler
// Type: ns0.Class27
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Threading.Tasks;

namespace ns0
{
  internal static class Class27
  {
    public static void smethod_0(GClass32 gclass32_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(new Class27.Class28()
      {
        gclass32_0 = gclass32_0
      }.method_0));
    }
  }
}
