// Decompiled with JetBrains decompiler
// Type: ns0.GClass71
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass71
  {
    [JsonProperty("conditional_ratings")]
    public GClass35 ConditionalRatings { get; set; }

    [JsonProperty("score")]
    public double Score { get; set; }

    [JsonProperty("star1")]
    public int Star1 { get; set; }

    [JsonProperty("star2")]
    public int Star2 { get; set; }

    [JsonProperty("star3")]
    public int Star3 { get; set; }

    [JsonProperty("star4")]
    public int Star4 { get; set; }

    [JsonProperty("star5")]
    public int Star5 { get; set; }

    [JsonProperty("votes")]
    public int Votes { get; set; }
  }
}
