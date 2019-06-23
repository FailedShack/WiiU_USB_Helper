namespace ns0
{
	// Token: 0x020001B6 RID: 438
	public partial class frmCommunitySaveDescription : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x0001890E File Offset: 0x00016B0E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0004B518 File Offset: 0x00049718
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmCommunitySaveDescription));
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.txtDescription = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.lblLength = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdSubmit = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDescription).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblLength).BeginInit();
			this.lblLength.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSubmit).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Padding = new global::System.Windows.Forms.Padding(10);
			this.radLabel1.Size = new global::System.Drawing.Size(672, 85);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.txtDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new global::System.Drawing.Point(0, 85);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new global::System.Drawing.Size(672, 251);
			this.txtDescription.TabIndex = 1;
			this.txtDescription.TextChanged += new global::System.EventHandler(this.txtDescription_TextChanged);
			this.lblLength.AutoSize = false;
			this.lblLength.Controls.Add(this.cmdSubmit);
			this.lblLength.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblLength.Location = new global::System.Drawing.Point(0, 336);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new global::System.Drawing.Size(672, 39);
			this.lblLength.TabIndex = 0;
			this.cmdSubmit.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.cmdSubmit.Enabled = false;
			this.cmdSubmit.Image = global::ns0.Class121.icnArrow;
			this.cmdSubmit.Location = new global::System.Drawing.Point(543, 6);
			this.cmdSubmit.Name = "cmdSubmit";
			this.cmdSubmit.Size = new global::System.Drawing.Size(126, 30);
			this.cmdSubmit.TabIndex = 0;
			this.cmdSubmit.Text = "Submit";
			this.cmdSubmit.Click += new global::System.EventHandler(this.cmdSubmit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(672, 375);
			base.Controls.Add(this.txtDescription);
			base.Controls.Add(this.lblLength);
			base.Controls.Add(this.radLabel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCommunitySaveDescription";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Description";
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDescription).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblLength).EndInit();
			this.lblLength.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdSubmit).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400079C RID: 1948
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400079D RID: 1949
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x0400079E RID: 1950
		private global::Telerik.WinControls.UI.RadTextBoxControl txtDescription;

		// Token: 0x0400079F RID: 1951
		private global::Telerik.WinControls.UI.RadLabel lblLength;

		// Token: 0x040007A0 RID: 1952
		private global::Telerik.WinControls.UI.RadButton cmdSubmit;
	}
}
