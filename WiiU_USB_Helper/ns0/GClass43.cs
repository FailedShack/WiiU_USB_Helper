using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200007A RID: 122
	public class GClass43
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001245E File Offset: 0x0001065E
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00012466 File Offset: 0x00010666
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0001246F File Offset: 0x0001066F
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00012477 File Offset: 0x00010677
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00012480 File Offset: 0x00010680
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00012488 File Offset: 0x00010688
		[JsonProperty("required")]
		public bool Required { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00012491 File Offset: 0x00010691
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00012499 File Offset: 0x00010699
		[JsonProperty("type")]
		public int Type { get; set; }

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040001F6 RID: 502
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001F7 RID: 503
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040001F8 RID: 504
		[CompilerGenerated]
		private int int_1;
	}
}
