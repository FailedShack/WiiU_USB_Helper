using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000099 RID: 153
	public class GClass74
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001296A File Offset: 0x00010B6A
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00012972 File Offset: 0x00010B72
		[JsonProperty("aoc_available")]
		public bool AocAvailable { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001297B File Offset: 0x00010B7B
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00012983 File Offset: 0x00010B83
		[JsonProperty("banner_url")]
		public string BannerUrl { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0001298C File Offset: 0x00010B8C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00012994 File Offset: 0x00010B94
		[JsonProperty("copyright")]
		public GClass38 Copyright { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0001299D File Offset: 0x00010B9D
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000129A5 File Offset: 0x00010BA5
		[JsonProperty("custom_cover_url")]
		public string CustomCoverUrl { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000129AE File Offset: 0x00010BAE
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x000129B6 File Offset: 0x00010BB6
		[JsonProperty("data_size")]
		public long DataSize { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000129BF File Offset: 0x00010BBF
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x000129C7 File Offset: 0x00010BC7
		[JsonProperty("demo_available")]
		public bool DemoAvailable { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000129D0 File Offset: 0x00010BD0
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x000129D8 File Offset: 0x00010BD8
		[JsonProperty("description")]
		public string Description { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000129E1 File Offset: 0x00010BE1
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x000129E9 File Offset: 0x00010BE9
		[JsonProperty("display_genre")]
		public string DisplayGenre { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000129F2 File Offset: 0x00010BF2
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x000129FA File Offset: 0x00010BFA
		[JsonProperty("download_card_sales")]
		public GClass41 DownloadCardSales { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00012A03 File Offset: 0x00010C03
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00012A0B File Offset: 0x00010C0B
		[JsonProperty("download_code_sales")]
		public bool DownloadCodeSales { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00012A14 File Offset: 0x00010C14
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00012A1C File Offset: 0x00010C1C
		[JsonProperty("eshop_sales")]
		public bool EshopSales { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00012A25 File Offset: 0x00010C25
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00012A2D File Offset: 0x00010C2D
		[JsonProperty("features")]
		public GClass44 Features { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00012A36 File Offset: 0x00010C36
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00012A3E File Offset: 0x00010C3E
		[JsonProperty("formal_name")]
		public string FormalName { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00012A47 File Offset: 0x00010C47
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00012A4F File Offset: 0x00010C4F
		[JsonProperty("genres")]
		public GClass49 Genres { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00012A58 File Offset: 0x00010C58
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00012A60 File Offset: 0x00010C60
		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00012A69 File Offset: 0x00010C69
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00012A71 File Offset: 0x00010C71
		[JsonProperty("id")]
		public long Id { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00012A7A File Offset: 0x00010C7A
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00012A82 File Offset: 0x00010C82
		[JsonProperty("in_app_purchase")]
		public bool InAppPurchase { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00012A8B File Offset: 0x00010C8B
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00012A93 File Offset: 0x00010C93
		[JsonProperty("keywords")]
		public GClass53 Keywords { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00012A9C File Offset: 0x00010C9C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00012AA4 File Offset: 0x00010CA4
		[JsonProperty("languages")]
		public GClass55 Languages { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00012AAD File Offset: 0x00010CAD
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00012AB5 File Offset: 0x00010CB5
		[JsonProperty("movies")]
		public GClass57 Movies { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00012ABE File Offset: 0x00010CBE
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00012AC6 File Offset: 0x00010CC6
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012ACF File Offset: 0x00010CCF
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00012AD7 File Offset: 0x00010CD7
		[JsonProperty("new")]
		public bool New { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00012AE0 File Offset: 0x00010CE0
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00012AE8 File Offset: 0x00010CE8
		[JsonProperty("number_of_players")]
		public string NumberOfPlayers { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00012AF1 File Offset: 0x00010CF1
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00012AF9 File Offset: 0x00010CF9
		[JsonProperty("platform")]
		public GClass58 Platform { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00012B02 File Offset: 0x00010D02
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00012B0A File Offset: 0x00010D0A
		[JsonProperty("play_styles")]
		public GClass61 PlayStyles { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00012B13 File Offset: 0x00010D13
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00012B1B File Offset: 0x00010D1B
		[JsonProperty("preference")]
		public GClass62 Preference { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00012B24 File Offset: 0x00010D24
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00012B2C File Offset: 0x00010D2C
		[JsonProperty("product_code")]
		public string ProductCode { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00012B35 File Offset: 0x00010D35
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00012B3D File Offset: 0x00010D3D
		[JsonProperty("public")]
		public bool Public { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00012B46 File Offset: 0x00010D46
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00012B4E File Offset: 0x00010D4E
		[JsonProperty("publisher")]
		public GClass63 Publisher { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00012B57 File Offset: 0x00010D57
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00012B5F File Offset: 0x00010D5F
		[JsonProperty("rating_info")]
		public GClass66 RatingInfo { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00012B68 File Offset: 0x00010D68
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00012B70 File Offset: 0x00010D70
		[JsonProperty("release_date_on_eshop")]
		public string ReleaseDateOnEshop { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00012B79 File Offset: 0x00010D79
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00012B81 File Offset: 0x00010D81
		[JsonProperty("release_date_on_retail")]
		public string ReleaseDateOnRetail { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00012B8A File Offset: 0x00010D8A
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00012B92 File Offset: 0x00010D92
		[JsonProperty("retail_sales")]
		public bool RetailSales { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00012B9B File Offset: 0x00010D9B
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00012BA3 File Offset: 0x00010DA3
		[JsonProperty("screenshots")]
		public GClass70 Screenshots { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00012BAC File Offset: 0x00010DAC
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00012BB4 File Offset: 0x00010DB4
		[JsonProperty("star_rating_info")]
		public GClass71 StarRatingInfo { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00012BBD File Offset: 0x00010DBD
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00012BC5 File Offset: 0x00010DC5
		[JsonProperty("ticket_available")]
		public bool TicketAvailable { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00012BCE File Offset: 0x00010DCE
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00012BD6 File Offset: 0x00010DD6
		[JsonProperty("top_image")]
		public GClass75 TopImage { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00012BDF File Offset: 0x00010DDF
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00012BE7 File Offset: 0x00010DE7
		[JsonProperty("web_sales")]
		public bool WebSales { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00012BF0 File Offset: 0x00010DF0
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00012BF8 File Offset: 0x00010DF8
		[JsonProperty("web_sites")]
		public GClass77 WebSites { get; set; }

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		private GClass38 gclass38_0;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000245 RID: 581
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000246 RID: 582
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000247 RID: 583
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000248 RID: 584
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000249 RID: 585
		[CompilerGenerated]
		private GClass41 gclass41_0;

		// Token: 0x0400024A RID: 586
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private GClass44 gclass44_0;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		private string string_4;

		// Token: 0x0400024E RID: 590
		[CompilerGenerated]
		private GClass49 gclass49_0;

		// Token: 0x0400024F RID: 591
		[CompilerGenerated]
		private string string_5;

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		private long long_1;

		// Token: 0x04000251 RID: 593
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		private GClass53 gclass53_0;

		// Token: 0x04000253 RID: 595
		[CompilerGenerated]
		private GClass55 gclass55_0;

		// Token: 0x04000254 RID: 596
		[CompilerGenerated]
		private GClass57 gclass57_0;

		// Token: 0x04000255 RID: 597
		[CompilerGenerated]
		private string string_6;

		// Token: 0x04000256 RID: 598
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04000257 RID: 599
		[CompilerGenerated]
		private string string_7;

		// Token: 0x04000258 RID: 600
		[CompilerGenerated]
		private GClass58 gclass58_0;

		// Token: 0x04000259 RID: 601
		[CompilerGenerated]
		private GClass61 gclass61_0;

		// Token: 0x0400025A RID: 602
		[CompilerGenerated]
		private GClass62 gclass62_0;

		// Token: 0x0400025B RID: 603
		[CompilerGenerated]
		private string string_8;

		// Token: 0x0400025C RID: 604
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x0400025D RID: 605
		[CompilerGenerated]
		private GClass63 gclass63_0;

		// Token: 0x0400025E RID: 606
		[CompilerGenerated]
		private GClass66 gclass66_0;

		// Token: 0x0400025F RID: 607
		[CompilerGenerated]
		private string string_9;

		// Token: 0x04000260 RID: 608
		[CompilerGenerated]
		private string string_10;

		// Token: 0x04000261 RID: 609
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x04000262 RID: 610
		[CompilerGenerated]
		private GClass70 gclass70_0;

		// Token: 0x04000263 RID: 611
		[CompilerGenerated]
		private GClass71 gclass71_0;

		// Token: 0x04000264 RID: 612
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private GClass75 gclass75_0;

		// Token: 0x04000266 RID: 614
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x04000267 RID: 615
		[CompilerGenerated]
		private GClass77 gclass77_0;
	}
}
