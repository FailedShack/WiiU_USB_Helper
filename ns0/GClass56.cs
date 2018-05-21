// Decompiled with JetBrains decompiler
// Type: ns0.GClass56
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass56
  {
    [JsonProperty("banner_url")]
    public string BannerUrl { get; set; }

    [JsonProperty("files")]
    public GClass47 Files { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("new")]
    public bool New { get; set; }

    [JsonProperty("rating_info")]
    public GClass65 RatingInfo { get; set; }
  }
}
