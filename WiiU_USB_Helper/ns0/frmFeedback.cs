using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200018A RID: 394
	internal partial class frmFeedback : RadForm
	{
		// Token: 0x06000B34 RID: 2868 RVA: 0x00017E0E File Offset: 0x0001600E
		public frmFeedback()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001564E File Offset: 0x0001384E
		private void closeButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00017E1C File Offset: 0x0001601C
		private void commentRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			this.featureRequestRadioButton.IsChecked = false;
			this.suggestionRadioButton.IsChecked = false;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00017E36 File Offset: 0x00016036
		private void featureRequestRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			this.commentRadioButton.IsChecked = false;
			this.suggestionRadioButton.IsChecked = false;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmFeedback_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000413E0 File Offset: 0x0003F5E0
		private void sendButton_Click(object sender, EventArgs e)
		{
			frmFeedback.Class141 @class = new frmFeedback.Class141();
			@class.frmFeedback_0 = this;
			this.txtRemarks.Text = this.txtRemarks.Text.Trim();
			if (this.txtRemarks.Text.Length < 50)
			{
				RadMessageBox.Show("Your request must be at least 50 characters long.");
				return;
			}
			string string_;
			if (this.commentRadioButton.IsChecked)
			{
				string_ = "New comment";
			}
			else if (this.featureRequestRadioButton.IsChecked)
			{
				string_ = "New feature request";
			}
			else
			{
				string_ = "New suggestion";
			}
			GClass7 gclass = new GClass7("feedback@wiiuusbhelper.com", string_, this.txtRemarks.Text, this.txtEmail.Text.Trim());
			@class.frmWait_0 = new FrmWait("Please wait while your feedback is sent...", false);
			gclass.Event_0 += @class.method_0;
			gclass.method_0();
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00017E50 File Offset: 0x00016050
		private void suggestionRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			this.featureRequestRadioButton.IsChecked = false;
			this.commentRadioButton.IsChecked = false;
		}

		// Token: 0x0200018B RID: 395
		[CompilerGenerated]
		private sealed class Class141
		{
			// Token: 0x06000B3E RID: 2878 RVA: 0x00041D2C File Offset: 0x0003FF2C
			internal void method_0(object object_0, string string_0)
			{
				frmFeedback.Class142 @class = new frmFeedback.Class142();
				@class.class141_0 = this;
				@class.string_0 = string_0;
				this.frmWait_0.method_0();
				this.frmFeedback_0.Invoke(new Action(@class.method_0));
			}

			// Token: 0x0400069C RID: 1692
			public FrmWait frmWait_0;

			// Token: 0x0400069D RID: 1693
			public frmFeedback frmFeedback_0;
		}

		// Token: 0x0200018C RID: 396
		[CompilerGenerated]
		private sealed class Class142
		{
			// Token: 0x06000B40 RID: 2880 RVA: 0x00017E89 File Offset: 0x00016089
			internal void method_0()
			{
				RadMessageBox.Show(this.string_0);
				this.class141_0.frmFeedback_0.Close();
			}

			// Token: 0x0400069E RID: 1694
			public string string_0;

			// Token: 0x0400069F RID: 1695
			public frmFeedback.Class141 class141_0;
		}
	}
}
