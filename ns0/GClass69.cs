// Decompiled with JetBrains decompiler
// Type: ns0.GClass69
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using System.Collections.Generic;

namespace ns0
{
  public class GClass69
  {
    [JsonProperty("image_url")]
    public List<GClass52> ImageUrl { get; set; }

    [JsonProperty("thumbnail_url")]
    public List<GClass73> ThumbnailUrl { get; set; }
  }
}
