using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000091 RID: 145
	public class GClass66
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00012805 File Offset: 0x00010A05
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0001280D File Offset: 0x00010A0D
		[JsonProperty("descriptors")]
		public GClass40 Descriptors { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00012816 File Offset: 0x00010A16
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0001281E File Offset: 0x00010A1E
		[JsonProperty("rating")]
		public GClass64 Rating { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00012827 File Offset: 0x00010A27
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0001282F File Offset: 0x00010A2F
		[JsonProperty("rating_system")]
		public GClass67 RatingSystem { get; set; }

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		private GClass40 gclass40_0;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private GClass64 gclass64_0;

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private GClass67 gclass67_0;
	}
}
