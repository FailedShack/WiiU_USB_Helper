// Decompiled with JetBrains decompiler
// Type: ns0.GClass74
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;

namespace ns0
{
  public class GClass74
  {
    [JsonProperty("aoc_available")]
    public bool AocAvailable { get; set; }

    [JsonProperty("banner_url")]
    public string BannerUrl { get; set; }

    [JsonProperty("copyright")]
    public GClass38 Copyright { get; set; }

    [JsonProperty("custom_cover_url")]
    public string CustomCoverUrl { get; set; }

    [JsonProperty("data_size")]
    public long DataSize { get; set; }

    [JsonProperty("demo_available")]
    public bool DemoAvailable { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("display_genre")]
    public string DisplayGenre { get; set; }

    [JsonProperty("download_card_sales")]
    public GClass41 DownloadCardSales { get; set; }

    [JsonProperty("download_code_sales")]
    public bool DownloadCodeSales { get; set; }

    [JsonProperty("eshop_sales")]
    public bool EshopSales { get; set; }

    [JsonProperty("features")]
    public GClass44 Features { get; set; }

    [JsonProperty("formal_name")]
    public string FormalName { get; set; }

    [JsonProperty("genres")]
    public GClass49 Genres { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("in_app_purchase")]
    public bool InAppPurchase { get; set; }

    [JsonProperty("keywords")]
    public GClass53 Keywords { get; set; }

    [JsonProperty("languages")]
    public GClass55 Languages { get; set; }

    [JsonProperty("movies")]
    public GClass57 Movies { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("new")]
    public bool New { get; set; }

    [JsonProperty("number_of_players")]
    public string NumberOfPlayers { get; set; }

    [JsonProperty("platform")]
    public GClass58 Platform { get; set; }

    [JsonProperty("play_styles")]
    public GClass61 PlayStyles { get; set; }

    [JsonProperty("preference")]
    public GClass62 Preference { get; set; }

    [JsonProperty("product_code")]
    public string ProductCode { get; set; }

    [JsonProperty("public")]
    public bool Public { get; set; }

    [JsonProperty("publisher")]
    public GClass63 Publisher { get; set; }

    [JsonProperty("rating_info")]
    public GClass66 RatingInfo { get; set; }

    [JsonProperty("release_date_on_eshop")]
    public string ReleaseDateOnEshop { get; set; }

    [JsonProperty("release_date_on_retail")]
    public string ReleaseDateOnRetail { get; set; }

    [JsonProperty("retail_sales")]
    public bool RetailSales { get; set; }

    [JsonProperty("screenshots")]
    public GClass70 Screenshots { get; set; }

    [JsonProperty("star_rating_info")]
    public GClass71 StarRatingInfo { get; set; }

    [JsonProperty("ticket_available")]
    public bool TicketAvailable { get; set; }

    [JsonProperty("top_image")]
    public GClass75 TopImage { get; set; }

    [JsonProperty("web_sales")]
    public bool WebSales { get; set; }

    [JsonProperty("web_sites")]
    public GClass77 WebSites { get; set; }
  }
}
