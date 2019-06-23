using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000087 RID: 135
	public class GClass56
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00012629 File Offset: 0x00010829
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00012631 File Offset: 0x00010831
		[JsonProperty("banner_url")]
		public string BannerUrl { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001263A File Offset: 0x0001083A
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00012642 File Offset: 0x00010842
		[JsonProperty("files")]
		public GClass47 Files { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001264B File Offset: 0x0001084B
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00012653 File Offset: 0x00010853
		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001265C File Offset: 0x0001085C
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00012664 File Offset: 0x00010864
		[JsonProperty("id")]
		public long Id { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001266D File Offset: 0x0001086D
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00012675 File Offset: 0x00010875
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001267E File Offset: 0x0001087E
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00012686 File Offset: 0x00010886
		[JsonProperty("new")]
		public bool New { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001268F File Offset: 0x0001088F
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00012697 File Offset: 0x00010897
		[JsonProperty("rating_info")]
		public GClass65 RatingInfo { get; set; }

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000211 RID: 529
		[CompilerGenerated]
		private GClass47 gclass47_0;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000215 RID: 533
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private GClass65 gclass65_0;
	}
}
