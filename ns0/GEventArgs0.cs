// Decompiled with JetBrains decompiler
// Type: ns0.GEventArgs0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  public class GEventArgs0 : EventArgs
  {
    internal GEventArgs0(int int_3, int int_4, int int_5, TimeSpan timeSpan_3, TimeSpan timeSpan_4, TimeSpan timeSpan_5, GStruct3 gstruct3_1, GClass30 gclass30_1)
    {
      this.GameProgress = int_3;
      this.TotalProgress = int_4;
      this.GameEta = timeSpan_3;
      this.TotalEta = timeSpan_4;
      this.Speed = gstruct3_1;
      this.FileEta = timeSpan_5;
      this.FileProgress = int_5;
      this.Title = gclass30_1;
    }

    public TimeSpan FileEta { get; }

    public int FileProgress { get; }

    public TimeSpan GameEta { get; }

    public int GameProgress { get; }

    public GStruct3 Speed { get; }

    public GClass30 Title { get; }

    public TimeSpan TotalEta { get; }

    public int TotalProgress { get; }
  }
}
