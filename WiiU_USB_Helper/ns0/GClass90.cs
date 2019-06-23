using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000C4 RID: 196
	public class GClass90
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000134F5 File Offset: 0x000116F5
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x000134FD File Offset: 0x000116FD
		public string Question { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00013506 File Offset: 0x00011706
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0001350E File Offset: 0x0001170E
		public string Answer { get; set; }

		// Token: 0x0600050C RID: 1292 RVA: 0x00013517 File Offset: 0x00011717
		public override string ToString()
		{
			return this.Question;
		}

		// Token: 0x04000326 RID: 806
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000327 RID: 807
		[CompilerGenerated]
		private string string_1;
	}
}
