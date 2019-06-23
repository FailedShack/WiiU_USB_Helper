using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200008D RID: 141
	public class GClass62
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001275B File Offset: 0x0001095B
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00012763 File Offset: 0x00010963
		[JsonProperty("play_style")]
		public GClass60 PlayStyle { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0001276C File Offset: 0x0001096C
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00012774 File Offset: 0x00010974
		[JsonProperty("target_player")]
		public GClass72 TargetPlayer { get; set; }

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		private GClass60 gclass60_0;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		private GClass72 gclass72_0;
	}
}
