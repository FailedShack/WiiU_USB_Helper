// Decompiled with JetBrains decompiler
// Type: ns0.GClass46
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass46
  {
    [JsonProperty("dimension")]
    public string Dimension { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("movie_url")]
    public string MovieUrl { get; set; }

    [JsonProperty("play_time_sec")]
    public int PlayTimeSec { get; set; }

    [JsonProperty("quality")]
    public string Quality { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }
  }
}
