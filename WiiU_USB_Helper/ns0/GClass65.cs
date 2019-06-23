using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000090 RID: 144
	public class GClass65
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000127E3 File Offset: 0x000109E3
		// (set) Token: 0x06000372 RID: 882 RVA: 0x000127EB File Offset: 0x000109EB
		[JsonProperty("rating")]
		public GClass64 Rating { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000373 RID: 883 RVA: 0x000127F4 File Offset: 0x000109F4
		// (set) Token: 0x06000374 RID: 884 RVA: 0x000127FC File Offset: 0x000109FC
		[JsonProperty("rating_system")]
		public GClass67 RatingSystem { get; set; }

		// Token: 0x0400022A RID: 554
		[CompilerGenerated]
		private GClass64 gclass64_0;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private GClass67 gclass67_0;
	}
}
