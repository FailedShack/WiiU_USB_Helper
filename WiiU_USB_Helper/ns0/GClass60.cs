using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200008B RID: 139
	public class GClass60
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00012728 File Offset: 0x00010928
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00012730 File Offset: 0x00010930
		[JsonProperty("casual")]
		public int Casual { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00012739 File Offset: 0x00010939
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00012741 File Offset: 0x00010941
		[JsonProperty("intense")]
		public int Intense { get; set; }

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		private int int_1;
	}
}
