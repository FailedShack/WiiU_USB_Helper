using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200011A RID: 282
	public class GClass116
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00015042 File Offset: 0x00013242
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0001504A File Offset: 0x0001324A
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00015053 File Offset: 0x00013253
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x0001505B File Offset: 0x0001325B
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x04000486 RID: 1158
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000487 RID: 1159
		[CompilerGenerated]
		private string string_0;
	}
}
