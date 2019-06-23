using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000083 RID: 131
	public class GClass52
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000125C3 File Offset: 0x000107C3
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000125CB File Offset: 0x000107CB
		[JsonProperty("index")]
		public int Index { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000125D4 File Offset: 0x000107D4
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000125DC File Offset: 0x000107DC
		[JsonProperty("value")]
		public string Value { get; set; }

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400020B RID: 523
		[CompilerGenerated]
		private string string_0;
	}
}
