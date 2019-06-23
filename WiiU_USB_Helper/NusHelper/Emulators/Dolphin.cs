using System;
using System.IO;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000E9 RID: 233
	public class Dolphin : GClass95
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x00014239 File Offset: 0x00012439
		public Dolphin(GClass30 title, bool forceUpdate) : base(title, "Dolphin", "https://dolphin-emu.org/", forceUpdate, true)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001424E File Offset: 0x0001244E
		public override string GetExecutable()
		{
			return Path.Combine(base.String_4, "Dolphin.exe");
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0002F594 File Offset: 0x0002D794
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			Class65.smethod_10();
			if (base.Boolean_2)
			{
				return;
			}
			GEnum3 system = this.gclass30_0.System;
			if (system == GEnum3.const_1)
			{
				this.gclass30_0.method_16(this.CurrentGamePath, false, false, null, false);
				Class79.smethod_2(Path.Combine(this.CurrentGamePath, "content"));
				base.method_12(true);
				return;
			}
			if (system != GEnum3.const_3)
			{
				throw new ArgumentException("This game cannot be used with Dolphin!");
			}
			this.gclass30_0.method_10(this.CurrentGamePath, "game.wad");
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0002F618 File Offset: 0x0002D818
		public override string GetRom()
		{
			GEnum3 system = this.gclass30_0.System;
			if (system == GEnum3.const_1)
			{
				return Path.Combine(this.CurrentGamePath, "game.iso");
			}
			if (system != GEnum3.const_3)
			{
				throw new ArgumentException("This game cannot be used with Dolphin!");
			}
			return Path.Combine(this.CurrentGamePath, "game.wad");
		}
	}
}
