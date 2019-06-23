namespace ns0
{
	// Token: 0x020001C5 RID: 453
	public partial class FrmSelectDrive : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00018B02 File Offset: 0x00016D02
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0004EE78 File Offset: 0x0004D078
		private void InitializeComponent()
		{
			this.lstDrives = new global::Telerik.WinControls.UI.RadListView();
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.chkDriveNotSeen = new global::Telerik.WinControls.UI.RadCheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.lstDrives).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDriveNotSeen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.lstDrives.AllowEdit = false;
			this.lstDrives.AllowRemove = false;
			this.lstDrives.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstDrives.FullRowSelect = false;
			this.lstDrives.ItemSize = new global::System.Drawing.Size(64, 64);
			this.lstDrives.Location = new global::System.Drawing.Point(10, 28);
			this.lstDrives.Name = "lstDrives";
			this.lstDrives.Size = new global::System.Drawing.Size(328, 339);
			this.lstDrives.TabIndex = 0;
			this.lstDrives.Text = "radListView1";
			this.lstDrives.ThemeName = "VisualStudio2012Dark";
			this.lstDrives.ViewType = global::Telerik.WinControls.UI.ListViewType.IconsView;
			this.lstDrives.ItemMouseDoubleClick += new global::Telerik.WinControls.UI.ListViewItemEventHandler(this.lstDrives_ItemMouseDoubleClick);
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new global::System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(224, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Double click to select the destination drive :";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.chkDriveNotSeen.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.chkDriveNotSeen.Location = new global::System.Drawing.Point(10, 367);
			this.chkDriveNotSeen.Name = "chkDriveNotSeen";
			this.chkDriveNotSeen.Size = new global::System.Drawing.Size(116, 18);
			this.chkDriveNotSeen.TabIndex = 2;
			this.chkDriveNotSeen.Text = "I can't see my drive";
			this.chkDriveNotSeen.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkDriveNotSeen_ToggleStateChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(348, 395);
			base.Controls.Add(this.lstDrives);
			base.Controls.Add(this.chkDriveNotSeen);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmSelectDrive";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select your destination drive";
			base.ThemeName = "VisualStudio2012Dark";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmSelectDrive_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmSelectDrive_Load);
			((global::System.ComponentModel.ISupportInitialize)this.lstDrives).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDriveNotSeen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000814 RID: 2068
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000815 RID: 2069
		private global::Telerik.WinControls.UI.RadListView lstDrives;

		// Token: 0x04000816 RID: 2070
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000817 RID: 2071
		private global::Telerik.WinControls.UI.RadCheckBox chkDriveNotSeen;
	}
}
