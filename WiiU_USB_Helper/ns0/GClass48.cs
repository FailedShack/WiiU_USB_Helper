using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200007F RID: 127
	public class GClass48
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001254C File Offset: 0x0001074C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00012554 File Offset: 0x00010754
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001255D File Offset: 0x0001075D
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00012565 File Offset: 0x00010765
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private string string_0;
	}
}
