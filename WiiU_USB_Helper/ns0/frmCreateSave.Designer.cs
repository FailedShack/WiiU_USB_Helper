namespace ns0
{
	// Token: 0x0200018F RID: 399
	public partial class frmCreateSave : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x00017F10 File Offset: 0x00016110
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00042368 File Offset: 0x00040568
		private void InitializeComponent()
		{
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.txtDescription = new global::Telerik.WinControls.UI.RadTextBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.cmdbackup = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDescription).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdbackup).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Location = new global::System.Drawing.Point(5, 5);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(337, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Please enter a short description of the content of your save.";
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.txtDescription.AutoSize = false;
			this.txtDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new global::System.Drawing.Point(5, 23);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new global::System.Drawing.Size(337, 234);
			this.txtDescription.TabIndex = 1;
			this.radButton1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton1.Location = new global::System.Drawing.Point(5, 281);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(337, 24);
			this.radButton1.TabIndex = 1;
			this.radButton1.Text = "Cancel";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.cmdbackup.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdbackup.Location = new global::System.Drawing.Point(5, 257);
			this.cmdbackup.Name = "cmdbackup";
			this.cmdbackup.Size = new global::System.Drawing.Size(337, 24);
			this.cmdbackup.TabIndex = 2;
			this.cmdbackup.Text = "Backup";
			this.cmdbackup.Click += new global::System.EventHandler(this.cmdbackup_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(347, 310);
			base.Controls.Add(this.txtDescription);
			base.Controls.Add(this.cmdbackup);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmCreateSave";
			base.Padding = new global::System.Windows.Forms.Padding(5);
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Backup save";
			base.Load += new global::System.EventHandler(this.frmCreateSave_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDescription).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdbackup).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006A8 RID: 1704
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006A9 RID: 1705
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040006AA RID: 1706
		private global::Telerik.WinControls.UI.RadTextBox txtDescription;

		// Token: 0x040006AB RID: 1707
		private global::Telerik.WinControls.UI.RadButton cmdbackup;

		// Token: 0x040006AC RID: 1708
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}
