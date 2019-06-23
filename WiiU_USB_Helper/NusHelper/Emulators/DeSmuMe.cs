using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000F3 RID: 243
	internal class DeSmuMe : GClass95
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x000147A4 File Offset: 0x000129A4
		public DeSmuMe(GClass30 title, bool forceUpdate) : base(title, "DeSmuME", "http://desmume.org/", forceUpdate, false)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000147B9 File Offset: 0x000129B9
		public override string GetExecutable()
		{
			return Path.Combine(base.String_4, "DeSmuME.exe");
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000147CB File Offset: 0x000129CB
		public override string GetRom()
		{
			return Path.Combine(this.CurrentGamePath, "content", "0010", "rom.zip");
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0003133C File Offset: 0x0002F53C
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			Class65.smethod_10();
			if (!base.Boolean_2 && this.gclass30_0.System == GEnum3.const_1)
			{
				IEnumerable<GClass12> ienumerable_ = from x in this.gclass30_0.method_15().Files
				where x.string_1 == "rom.zip"
				select x;
				Directory.CreateDirectory(Path.Combine(this.CurrentGamePath, "content", "0010"));
				this.gclass30_0.method_16(base.String_5, true, directDownload, ienumerable_, true);
			}
		}
	}
}
