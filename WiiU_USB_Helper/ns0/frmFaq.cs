using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000187 RID: 391
	public partial class frmFaq : RadForm
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x00017D96 File Offset: 0x00015F96
		public frmFaq()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00040BF4 File Offset: 0x0003EDF4
		private void method_0()
		{
			frmFaq.Class139 @class = new frmFaq.Class139();
			@class.string_0 = this.txtKeyWords.Text.ToLower().Split(new char[]
			{
				' '
			});
			IEnumerable<GClass90> enumerable = this.list_0.Where(new Func<GClass90, bool>(@class.method_0));
			this.lstQuestions.BeginUpdate();
			this.lstQuestions.Items.Clear();
			foreach (GClass90 value in enumerable)
			{
				this.lstQuestions.Items.Add(new ListViewDataItem(value));
			}
			this.lstQuestions.EndUpdate();
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00017DA4 File Offset: 0x00015FA4
		private void frmFaq_Load(object sender, EventArgs e)
		{
			this.list_0 = Class65.smethod_0();
			this.method_0();
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000142A3 File Offset: 0x000124A3
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00040CB4 File Offset: 0x0003EEB4
		private void lstQuestions_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.lstQuestions.SelectedItem == null)
			{
				return;
			}
			string answer = (this.lstQuestions.SelectedItem.Value as GClass90).Answer;
			StringBuilder stringBuilder = new StringBuilder(answer.Length + 100);
			int num = 0;
			foreach (char c in answer)
			{
				if (c != '"')
				{
					stringBuilder.Append(c);
				}
				else if (num++ % 2 == 0)
				{
					stringBuilder.Append("<span style=\"color: #ff8000\">");
				}
				else
				{
					stringBuilder.Append("</span>");
				}
			}
			this.lblAnswer.Text = string.Format("<html><p>{0}</p></html>", stringBuilder);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000142A3 File Offset: 0x000124A3
		private void radLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00017DB7 File Offset: 0x00015FB7
		private void method_2(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00017DB7 File Offset: 0x00015FB7
		private void txtKeyWords_TextChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x04000684 RID: 1668
		private List<GClass90> list_0;

		// Token: 0x02000188 RID: 392
		[CompilerGenerated]
		private sealed class Class139
		{
			// Token: 0x06000B30 RID: 2864 RVA: 0x00041394 File Offset: 0x0003F594
			internal bool method_0(GClass90 gclass90_0)
			{
				frmFaq.Class140 @class = new frmFaq.Class140();
				@class.gclass90_0 = gclass90_0;
				return this.string_0.Any(new Func<string, bool>(@class.method_0)) || this.string_0.Any(new Func<string, bool>(@class.method_1));
			}

			// Token: 0x0400068D RID: 1677
			public string[] string_0;
		}

		// Token: 0x02000189 RID: 393
		[CompilerGenerated]
		private sealed class Class140
		{
			// Token: 0x06000B32 RID: 2866 RVA: 0x00017DDE File Offset: 0x00015FDE
			internal bool method_0(string string_0)
			{
				return this.gclass90_0.Question.ToLower().Contains(string_0);
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x00017DF6 File Offset: 0x00015FF6
			internal bool method_1(string string_0)
			{
				return this.gclass90_0.Answer.ToLower().Contains(string_0);
			}

			// Token: 0x0400068E RID: 1678
			public GClass90 gclass90_0;
		}
	}
}
