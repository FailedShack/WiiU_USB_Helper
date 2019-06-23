using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000073 RID: 115
	public class GClass36
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00012370 File Offset: 0x00010570
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00012378 File Offset: 0x00010578
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00012381 File Offset: 0x00010581
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00012389 File Offset: 0x00010589
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00012392 File Offset: 0x00010592
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0001239A File Offset: 0x0001059A
		[JsonProperty("required")]
		public bool Required { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000123A3 File Offset: 0x000105A3
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000123AB File Offset: 0x000105AB
		[JsonProperty("type")]
		public int Type { get; set; }

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private int int_0;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		private int int_1;
	}
}
