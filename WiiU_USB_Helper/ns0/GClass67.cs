using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000092 RID: 146
	public class GClass67
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00012838 File Offset: 0x00010A38
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00012840 File Offset: 0x00010A40
		[JsonProperty("id")]
		public int Id { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00012849 File Offset: 0x00010A49
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00012851 File Offset: 0x00010A51
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private string string_0;
	}
}
