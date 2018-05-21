// Decompiled with JetBrains decompiler
// Type: ns0.GClass109
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass109
  {
    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("title")]
    public GClass121 Title { get; set; }
  }
}
