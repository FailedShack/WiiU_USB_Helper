// Decompiled with JetBrains decompiler
// Type: ns0.GClass121
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass121
  {
    [JsonProperty("aoc_available")]
    public bool AocAvailable { get; set; }

    [JsonProperty("banner_url")]
    public string BannerUrl { get; set; }

    [JsonProperty("demo_available")]
    public bool DemoAvailable { get; set; }

    [JsonProperty("display_genre")]
    public string DisplayGenre { get; set; }

    [JsonProperty("eshop_sales")]
    public bool EshopSales { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("in_app_purchase")]
    public bool InAppPurchase { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("new")]
    public bool New { get; set; }

    [JsonProperty("platform")]
    public GClass114 Platform { get; set; }

    [JsonProperty("price_on_retail")]
    public string PriceOnRetail { get; set; }

    [JsonProperty("price_on_retail_detail")]
    public GClass115 PriceOnRetailDetail { get; set; }

    [JsonProperty("product_code")]
    public string ProductCode { get; set; }

    [JsonProperty("publisher")]
    public GClass116 Publisher { get; set; }

    [JsonProperty("rating_info")]
    public GClass118 RatingInfo { get; set; }

    [JsonProperty("release_date_on_eshop")]
    public string ReleaseDateOnEshop { get; set; }

    [JsonProperty("release_date_on_retail")]
    public string ReleaseDateOnRetail { get; set; }

    [JsonProperty("retail_sales")]
    public bool RetailSales { get; set; }

    [JsonProperty("star_rating_info")]
    public GClass120 StarRatingInfo { get; set; }
  }
}
