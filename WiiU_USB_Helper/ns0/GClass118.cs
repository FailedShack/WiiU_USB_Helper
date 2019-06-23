using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200011C RID: 284
	public class GClass118
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x000150A8 File Offset: 0x000132A8
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x000150B0 File Offset: 0x000132B0
		[JsonProperty("rating")]
		public GClass117 Rating { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000150B9 File Offset: 0x000132B9
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x000150C1 File Offset: 0x000132C1
		[JsonProperty("rating_system")]
		public GClass119 RatingSystem { get; set; }

		// Token: 0x0400048C RID: 1164
		[CompilerGenerated]
		private GClass117 gclass117_0;

		// Token: 0x0400048D RID: 1165
		[CompilerGenerated]
		private GClass119 gclass119_0;
	}
}
