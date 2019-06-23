using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000098 RID: 152
	public class GClass73
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00012948 File Offset: 0x00010B48
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00012950 File Offset: 0x00010B50
		[JsonProperty("index")]
		public int Index { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00012959 File Offset: 0x00010B59
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00012961 File Offset: 0x00010B61
		[JsonProperty("value")]
		public string Value { get; set; }

		// Token: 0x0400023F RID: 575
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000240 RID: 576
		[CompilerGenerated]
		private string string_0;
	}
}
