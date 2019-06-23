using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000081 RID: 129
	public class GClass50
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00012590 File Offset: 0x00010790
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00012598 File Offset: 0x00010798
		[JsonProperty("type")]
		public string Type { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000125A1 File Offset: 0x000107A1
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000125A9 File Offset: 0x000107A9
		[JsonProperty("url")]
		public string Url { get; set; }

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		private string string_1;
	}
}
