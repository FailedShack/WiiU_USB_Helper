using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ns0
{
	// Token: 0x0200014D RID: 333
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
	public class GControl1 : ToolStripControlHost
	{
		// Token: 0x060008FE RID: 2302 RVA: 0x00015CC3 File Offset: 0x00013EC3
		public GControl1() : base(new GControl0())
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00015CD0 File Offset: 0x00013ED0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[RefreshProperties(RefreshProperties.All)]
		public GControl0 GControl0_0
		{
			get
			{
				return base.Control as GControl0;
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00015CDD File Offset: 0x00013EDD
		public override Size GetPreferredSize(Size constrainingSize)
		{
			return this.GControl0_0.GetPreferredSize(constrainingSize);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00015CEB File Offset: 0x00013EEB
		protected override void OnSubscribeControlEvents(Control control)
		{
			base.OnSubscribeControlEvents(control);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00015CF4 File Offset: 0x00013EF4
		protected override void OnUnsubscribeControlEvents(Control control)
		{
			base.OnUnsubscribeControlEvents(control);
		}
	}
}
