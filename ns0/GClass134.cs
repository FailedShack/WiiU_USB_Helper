// Decompiled with JetBrains decompiler
// Type: ns0.GClass134
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  public class GClass134
  {
    private double double_0;
    private double double_1;
    private bool bool_1;
    private double double_2;
    private DateTime? nullable_0;
    private double double_3;

    public GClass134(double double_4, double double_5, double double_6)
    {
      this.double_2 = double_4;
      this.double_1 = double_5;
      this.double_0 = double_6;
      this.double_3 = (double_5 - double_4) / double_6;
    }

    public event EventHandler Event_0;

    public bool IsLooping { get; set; }

    public void method_0()
    {
      this.bool_1 = true;
    }

    public double method_1()
    {
      if (!this.nullable_0.HasValue)
        this.nullable_0 = new DateTime?(DateTime.Now);
      double num = (DateTime.Now - this.nullable_0.Value).TotalMilliseconds;
      if (num >= this.double_0)
      {
        if (!this.IsLooping)
        {
          if (!this.bool_1)
            this.method_4();
          this.bool_1 = true;
          return this.double_1;
        }
        double double2 = this.double_2;
        this.double_2 = this.double_1;
        this.double_1 = double2;
        this.double_3 *= -1.0;
        this.nullable_0 = new DateTime?(DateTime.Now);
        num = 0.0;
      }
      return this.double_3 * num + this.double_2;
    }

    public bool method_2()
    {
      if (this.bool_1)
        return true;
      if (this.nullable_0.HasValue && !this.IsLooping)
        return this.bool_1 = (DateTime.Now - this.nullable_0.Value).TotalMilliseconds >= this.double_0;
      return false;
    }

    public void method_3()
    {
      this.bool_1 = false;
      this.nullable_0 = new DateTime?(DateTime.Now);
    }

    private void method_4()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }
  }
}
