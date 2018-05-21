// Decompiled with JetBrains decompiler
// Type: ns0.Class130
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  internal class Class130
  {
    private Action action_0;

    public Class130(string string_1, ulong ulong_1, GClass30 gclass30_1, Action action_1)
    {
      this.Name = string_1;
      this.Size = ulong_1;
      this.action_0 = action_1;
      this.CorrespondingTitle = gclass30_1;
    }

    public GClass30 CorrespondingTitle { get; }

    public string Name { get; }

    public ulong Size { get; }

    public void method_0()
    {
      this.action_0();
    }

    public override string ToString()
    {
      return this.Name;
    }
  }
}
