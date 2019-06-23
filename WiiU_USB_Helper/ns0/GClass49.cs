using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000080 RID: 128
	public class GClass49
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0001256E File Offset: 0x0001076E
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00012576 File Offset: 0x00010776
		[JsonProperty("genre")]
		public List<GClass48> Genre { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0001257F File Offset: 0x0001077F
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00012587 File Offset: 0x00010787
		[JsonProperty("length")]
		public int Length { get; set; }

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		private List<GClass48> list_0;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		private int int_0;
	}
}
