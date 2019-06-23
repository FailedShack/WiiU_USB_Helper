using System;
using System.IO;
using NusHelper;

namespace ns0
{
	// Token: 0x0200005D RID: 93
	public class GClass31 : GClass30
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00011CA6 File Offset: 0x0000FEA6
		public GClass31(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, GEnum3 genum3_1) : base(string_7, titleId_1, string_8, byte_2, dataSize_1, string_9, genum3_1)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00011CB9 File Offset: 0x0000FEB9
		public override string String_6
		{
			get
			{
				return base.String_6 + " (DLC)";
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00023A6C File Offset: 0x00021C6C
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case GEnum3.const_0:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA_3DS",
						base.Region,
						"DLCS",
						base.String_5
					});
				case GEnum3.const_1:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA",
						base.Region,
						"DLCS",
						base.String_5
					});
				case GEnum3.const_2:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00011CCB File Offset: 0x0000FECB
		public override string ToString()
		{
			return string.Format("{0} (DLC) ({1}) ({2})", base.Name, base.Size, base.Region);
		}
	}
}
