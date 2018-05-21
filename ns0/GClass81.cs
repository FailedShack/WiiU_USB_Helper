// Decompiled with JetBrains decompiler
// Type: ns0.GClass81
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

namespace ns0
{
  public class GClass81
  {
    public GClass81(string string_1, bool bool_1, GEnum5 genum5_1)
    {
      this.Message = string_1;
      this.Error = bool_1;
      this.Type = genum5_1;
    }

    public bool Error { get; }

    public string Message { get; }

    public GEnum5 Type { get; }
  }
}
