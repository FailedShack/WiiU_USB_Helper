using System;

namespace NusHelper.Server
{
	// Token: 0x020000C3 RID: 195
	public sealed class DbRow
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001343A File Offset: 0x0001163A
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00013442 File Offset: 0x00011642
		public bool DiscOnly { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001344B File Offset: 0x0001164B
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00013453 File Offset: 0x00011653
		public string EshopId { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001345C File Offset: 0x0001165C
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00013464 File Offset: 0x00011664
		public string IconUrl { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001346D File Offset: 0x0001166D
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00013475 File Offset: 0x00011675
		public string Name { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001347E File Offset: 0x0001167E
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00013486 File Offset: 0x00011686
		public Platform Platform { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001348F File Offset: 0x0001168F
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00013497 File Offset: 0x00011697
		public bool PreLoad { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000134A0 File Offset: 0x000116A0
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x000134A8 File Offset: 0x000116A8
		public string ProductCode { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000134B1 File Offset: 0x000116B1
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x000134B9 File Offset: 0x000116B9
		public string Region { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000134C2 File Offset: 0x000116C2
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x000134CA File Offset: 0x000116CA
		public DataSize Size { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000134D3 File Offset: 0x000116D3
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x000134DB File Offset: 0x000116DB
		public TitleId TitleId { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000134E4 File Offset: 0x000116E4
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x000134EC File Offset: 0x000116EC
		public string Version { get; set; }
	}
}
