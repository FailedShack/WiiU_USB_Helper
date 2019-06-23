using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200011F RID: 287
	public class GClass121
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00015163 File Offset: 0x00013363
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0001516B File Offset: 0x0001336B
		[JsonProperty("aoc_available")]
		public bool AocAvailable { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00015174 File Offset: 0x00013374
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0001517C File Offset: 0x0001337C
		[JsonProperty("banner_url")]
		public string BannerUrl { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00015185 File Offset: 0x00013385
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0001518D File Offset: 0x0001338D
		[JsonProperty("demo_available")]
		public bool DemoAvailable { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00015196 File Offset: 0x00013396
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0001519E File Offset: 0x0001339E
		[JsonProperty("display_genre")]
		public string DisplayGenre { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x000151A7 File Offset: 0x000133A7
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x000151AF File Offset: 0x000133AF
		[JsonProperty("eshop_sales")]
		public bool EshopSales { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000151B8 File Offset: 0x000133B8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000151C0 File Offset: 0x000133C0
		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000151C9 File Offset: 0x000133C9
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000151D1 File Offset: 0x000133D1
		[JsonProperty("id")]
		public long Id { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000151DA File Offset: 0x000133DA
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000151E2 File Offset: 0x000133E2
		[JsonProperty("in_app_purchase")]
		public bool InAppPurchase { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000151EB File Offset: 0x000133EB
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000151F3 File Offset: 0x000133F3
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000151FC File Offset: 0x000133FC
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00015204 File Offset: 0x00013404
		[JsonProperty("new")]
		public bool New { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001520D File Offset: 0x0001340D
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00015215 File Offset: 0x00013415
		[JsonProperty("platform")]
		public GClass114 Platform { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001521E File Offset: 0x0001341E
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00015226 File Offset: 0x00013426
		[JsonProperty("price_on_retail")]
		public string PriceOnRetail { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0001522F File Offset: 0x0001342F
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00015237 File Offset: 0x00013437
		[JsonProperty("price_on_retail_detail")]
		public GClass115 PriceOnRetailDetail { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00015240 File Offset: 0x00013440
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00015248 File Offset: 0x00013448
		[JsonProperty("product_code")]
		public string ProductCode { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00015251 File Offset: 0x00013451
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00015259 File Offset: 0x00013459
		[JsonProperty("publisher")]
		public GClass116 Publisher { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00015262 File Offset: 0x00013462
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0001526A File Offset: 0x0001346A
		[JsonProperty("rating_info")]
		public GClass118 RatingInfo { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00015273 File Offset: 0x00013473
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0001527B File Offset: 0x0001347B
		[JsonProperty("release_date_on_eshop")]
		public string ReleaseDateOnEshop { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00015284 File Offset: 0x00013484
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0001528C File Offset: 0x0001348C
		[JsonProperty("release_date_on_retail")]
		public string ReleaseDateOnRetail { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00015295 File Offset: 0x00013495
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0001529D File Offset: 0x0001349D
		[JsonProperty("retail_sales")]
		public bool RetailSales { get; set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000152A6 File Offset: 0x000134A6
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000152AE File Offset: 0x000134AE
		[JsonProperty("star_rating_info")]
		public GClass120 StarRatingInfo { get; set; }

		// Token: 0x04000497 RID: 1175
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000498 RID: 1176
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000499 RID: 1177
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400049A RID: 1178
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400049B RID: 1179
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400049C RID: 1180
		[CompilerGenerated]
		private string string_2;

		// Token: 0x0400049D RID: 1181
		[CompilerGenerated]
		private long long_0;

		// Token: 0x0400049E RID: 1182
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400049F RID: 1183
		[CompilerGenerated]
		private string string_3;

		// Token: 0x040004A0 RID: 1184
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040004A1 RID: 1185
		[CompilerGenerated]
		private GClass114 gclass114_0;

		// Token: 0x040004A2 RID: 1186
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040004A3 RID: 1187
		[CompilerGenerated]
		private GClass115 gclass115_0;

		// Token: 0x040004A4 RID: 1188
		[CompilerGenerated]
		private string string_5;

		// Token: 0x040004A5 RID: 1189
		[CompilerGenerated]
		private GClass116 gclass116_0;

		// Token: 0x040004A6 RID: 1190
		[CompilerGenerated]
		private GClass118 gclass118_0;

		// Token: 0x040004A7 RID: 1191
		[CompilerGenerated]
		private string string_6;

		// Token: 0x040004A8 RID: 1192
		[CompilerGenerated]
		private string string_7;

		// Token: 0x040004A9 RID: 1193
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040004AA RID: 1194
		[CompilerGenerated]
		private GClass120 gclass120_0;
	}
}
