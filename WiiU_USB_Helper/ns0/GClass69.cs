using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000094 RID: 148
	public class GClass69
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0001286B File Offset: 0x00010A6B
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00012873 File Offset: 0x00010A73
		[JsonProperty("image_url")]
		public List<GClass52> ImageUrl { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0001287C File Offset: 0x00010A7C
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00012884 File Offset: 0x00010A84
		[JsonProperty("thumbnail_url")]
		public List<GClass73> ThumbnailUrl { get; set; }

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private List<GClass52> list_0;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private List<GClass73> list_1;
	}
}
