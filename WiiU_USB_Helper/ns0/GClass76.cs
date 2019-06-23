using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200009B RID: 155
	public class GClass76
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00012C23 File Offset: 0x00010E23
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00012C2B File Offset: 0x00010E2B
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00012C34 File Offset: 0x00010E34
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00012C3C File Offset: 0x00010E3C
		[JsonProperty("official")]
		public bool Official { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00012C45 File Offset: 0x00010E45
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00012C4D File Offset: 0x00010E4D
		[JsonProperty("url")]
		public string Url { get; set; }

		// Token: 0x0400026A RID: 618
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400026B RID: 619
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400026C RID: 620
		[CompilerGenerated]
		private string string_1;
	}
}
