using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000113 RID: 275
	public class GClass109
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00014F21 File Offset: 0x00013121
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00014F29 File Offset: 0x00013129
		[JsonProperty("index")]
		public int Index { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00014F32 File Offset: 0x00013132
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00014F3A File Offset: 0x0001313A
		[JsonProperty("title")]
		public GClass121 Title { get; set; }

		// Token: 0x04000475 RID: 1141
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000476 RID: 1142
		[CompilerGenerated]
		private GClass121 gclass121_0;
	}
}
