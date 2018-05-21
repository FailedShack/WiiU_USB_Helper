// Decompiled with JetBrains decompiler
// Type: ns0.GClass14
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass14
  {
    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("creator")]
    public string Creator { get; set; }

    [JsonProperty("date")]
    public long Date { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("download_link")]
    public string DownloadLink { get; set; }

    [JsonProperty("files")]
    public string[] Files { get; set; }

    [JsonProperty("md5")]
    public string Md5 { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("original_link")]
    public string OriginalLink { get; set; }

    [JsonProperty("pictures")]
    public string[] Pictures { get; set; }

    [JsonProperty("recommended_mods")]
    public string[] RecommendedMods { get; set; }

    [JsonProperty("required_mods")]
    public string[] RequiredMods { get; set; }

    [JsonProperty("size")]
    public long Size { get; set; }

    [JsonProperty("titleid")]
    public string Titleid { get; set; }
  }
}
