using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200019E RID: 414
	public partial class frmLoadOverlay : GForm1
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x000182D2 File Offset: 0x000164D2
		public frmLoadOverlay(Process process_0) : base(0.85f, process_0.MainWindowHandle, Color.Black, false)
		{
			this.InitializeComponent();
			this.radWaitingBar1.StartWaiting();
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00045340 File Offset: 0x00043540
		public void method_7(int int_1)
		{
			frmLoadOverlay.Class149 @class = new frmLoadOverlay.Class149();
			@class.frmLoadOverlay_0 = this;
			@class.int_0 = int_1;
			try
			{
				base.Invoke(new MethodInvoker(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x0200019F RID: 415
		[CompilerGenerated]
		private sealed class Class149
		{
			// Token: 0x06000BA3 RID: 2979 RVA: 0x000456AC File Offset: 0x000438AC
			internal void method_0()
			{
				this.frmLoadOverlay_0.TopMost = true;
				if (this.int_0 < 0)
				{
					this.int_0 = 0;
				}
				if (this.int_0 > 100)
				{
					this.int_0 = 100;
				}
				this.frmLoadOverlay_0.progressBar.Value1 = this.int_0;
			}

			// Token: 0x040006FE RID: 1790
			public frmLoadOverlay frmLoadOverlay_0;

			// Token: 0x040006FF RID: 1791
			public int int_0;
		}
	}
}
