using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000085 RID: 133
	public class GClass54
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000125F6 File Offset: 0x000107F6
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000125FE File Offset: 0x000107FE
		[JsonProperty("iso_code")]
		public string IsoCode { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00012607 File Offset: 0x00010807
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0001260F File Offset: 0x0001080F
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private string string_1;
	}
}
