using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200008F RID: 143
	public class GClass64
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001279F File Offset: 0x0001099F
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000127A7 File Offset: 0x000109A7
		[JsonProperty("age")]
		public int Age { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000127B0 File Offset: 0x000109B0
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000127B8 File Offset: 0x000109B8
		[JsonProperty("icons")]
		public GClass51 Icons { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000127C1 File Offset: 0x000109C1
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000127C9 File Offset: 0x000109C9
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000127D2 File Offset: 0x000109D2
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000127DA File Offset: 0x000109DA
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x04000226 RID: 550
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000227 RID: 551
		[CompilerGenerated]
		private GClass51 gclass51_0;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		private int int_1;

		// Token: 0x04000229 RID: 553
		[CompilerGenerated]
		private string string_0;
	}
}
