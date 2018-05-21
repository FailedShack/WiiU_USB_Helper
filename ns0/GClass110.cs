// Decompiled with JetBrains decompiler
// Type: ns0.GClass110
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace ns0
{
  public class GClass110
  {
    [JsonProperty("content")]
    public List<GClass109> Content { get; set; }

    [JsonProperty("length")]
    public int Length { get; set; }

    [JsonProperty("offset")]
    public int Offset { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }
  }
}
