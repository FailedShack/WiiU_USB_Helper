// Decompiled with JetBrains decompiler
// Type: ns0.GClass137
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  public class GClass137
  {
    private GClass134 gclass134_0;
    private string string_0;

    public GClass137(GClass134 gclass134_1, string string_1)
    {
      if (gclass134_1 == null)
        throw new ArgumentException("animator cannot be null");
      if (string.IsNullOrEmpty(string_1))
        throw new ArgumentException("property cannot be null");
      this.gclass134_0 = gclass134_1;
      this.string_0 = string_1;
    }

    public object Target { get; set; }

    public void method_0()
    {
      this.gclass134_0.method_0();
    }

    public void method_1()
    {
      if (this.Target == null)
        return;
      this.Target.GetType().GetProperty(this.string_0).SetValue(this.Target, (object) this.gclass134_0.method_1());
    }

    public void method_2()
    {
      this.gclass134_0.method_3();
    }
  }
}
