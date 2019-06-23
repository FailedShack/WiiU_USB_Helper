using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200008A RID: 138
	public class GClass59
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600034F RID: 847 RVA: 0x000126F5 File Offset: 0x000108F5
		// (set) Token: 0x06000350 RID: 848 RVA: 0x000126FD File Offset: 0x000108FD
		[JsonProperty("controllers")]
		public GClass37 Controllers { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00012706 File Offset: 0x00010906
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0001270E File Offset: 0x0001090E
		[JsonProperty("features")]
		public GClass45 Features { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00012717 File Offset: 0x00010917
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0001271F File Offset: 0x0001091F
		[JsonProperty("type")]
		public string Type { get; set; }

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private GClass37 gclass37_0;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private GClass45 gclass45_0;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private string string_0;
	}
}
