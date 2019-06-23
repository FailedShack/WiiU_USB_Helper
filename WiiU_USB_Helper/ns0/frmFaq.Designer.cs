namespace ns0
{
	// Token: 0x02000187 RID: 391
	public partial class frmFaq : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00017DBF File Offset: 0x00015FBF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00040D60 File Offset: 0x0003EF60
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmFaq));
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.lstQuestions = new global::Telerik.WinControls.UI.RadListView();
			this.txtKeyWords = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.lblAnswer = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstQuestions).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtKeyWords).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblAnswer).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(20, 20);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(974, 30);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "HELP CENTER";
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabel2.AutoSize = false;
			this.radLabel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel2.Location = new global::System.Drawing.Point(20, 50);
			this.radLabel2.Margin = new global::System.Windows.Forms.Padding(3, 3, 3, 20);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(974, 18);
			this.radLabel2.TabIndex = 2;
			this.radLabel2.Text = "Type a few keywords related to your problem";
			this.radLabel2.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.radLabel2.Click += new global::System.EventHandler(this.radLabel2_Click);
			this.lstQuestions.AllowEdit = false;
			this.lstQuestions.AllowRemove = false;
			this.lstQuestions.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.lstQuestions.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstQuestions.ItemSpacing = 10;
			this.lstQuestions.Location = new global::System.Drawing.Point(20, 129);
			this.lstQuestions.Name = "lstQuestions";
			this.lstQuestions.Size = new global::System.Drawing.Size(527, 462);
			this.lstQuestions.TabIndex = 0;
			this.lstQuestions.Text = "radListView1";
			this.lstQuestions.SelectedItemChanged += new global::System.EventHandler(this.lstQuestions_SelectedItemChanged);
			this.txtKeyWords.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtKeyWords.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtKeyWords.Location = new global::System.Drawing.Point(20, 84);
			this.txtKeyWords.Margin = new global::System.Windows.Forms.Padding(3, 20, 3, 3);
			this.txtKeyWords.Name = "txtKeyWords";
			this.txtKeyWords.NullText = "Type in keywords related to your issue...";
			this.txtKeyWords.Size = new global::System.Drawing.Size(974, 29);
			this.txtKeyWords.TabIndex = 5;
			this.txtKeyWords.TextChanged += new global::System.EventHandler(this.txtKeyWords_TextChanged);
			this.lblAnswer.AutoSize = false;
			this.lblAnswer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblAnswer.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAnswer.Location = new global::System.Drawing.Point(547, 129);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Padding = new global::System.Windows.Forms.Padding(20);
			this.lblAnswer.Size = new global::System.Drawing.Size(447, 462);
			this.lblAnswer.TabIndex = 6;
			this.lblAnswer.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.radLabel4.AutoSize = false;
			this.radLabel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel4.Location = new global::System.Drawing.Point(20, 113);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(974, 16);
			this.radLabel4.TabIndex = 0;
			this.radLabel3.AutoSize = false;
			this.radLabel3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel3.Location = new global::System.Drawing.Point(20, 68);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(974, 16);
			this.radLabel3.TabIndex = 7;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1014, 611);
			base.Controls.Add(this.lblAnswer);
			base.Controls.Add(this.lstQuestions);
			base.Controls.Add(this.radLabel4);
			base.Controls.Add(this.txtKeyWords);
			base.Controls.Add(this.radLabel3);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.radLabel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmFaq";
			base.Padding = new global::System.Windows.Forms.Padding(20);
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Self-help center";
			base.Load += new global::System.EventHandler(this.frmFaq_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstQuestions).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtKeyWords).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblAnswer).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000685 RID: 1669
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000686 RID: 1670
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000687 RID: 1671
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x04000688 RID: 1672
		private global::Telerik.WinControls.UI.RadListView lstQuestions;

		// Token: 0x04000689 RID: 1673
		private global::Telerik.WinControls.UI.RadTextBoxControl txtKeyWords;

		// Token: 0x0400068A RID: 1674
		private global::Telerik.WinControls.UI.RadLabel lblAnswer;

		// Token: 0x0400068B RID: 1675
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x0400068C RID: 1676
		private global::Telerik.WinControls.UI.RadLabel radLabel3;
	}
}
