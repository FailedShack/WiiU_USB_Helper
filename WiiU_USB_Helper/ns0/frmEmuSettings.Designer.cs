namespace ns0
{
	// Token: 0x02000184 RID: 388
	public partial class frmEmuSettings : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x00017D2C File Offset: 0x00015F2C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000406F0 File Offset: 0x0003E8F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmEmuSettings));
			this.settingsGrid = new global::Telerik.WinControls.UI.RadPropertyGrid();
			this.lstEmus = new global::Telerik.WinControls.UI.RadListView();
			this.cmdLaunchEmu = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.settingsGrid).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstEmus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLaunchEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.settingsGrid.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.settingsGrid.Location = new global::System.Drawing.Point(243, 0);
			this.settingsGrid.Name = "settingsGrid";
			this.settingsGrid.Size = new global::System.Drawing.Size(704, 382);
			this.settingsGrid.TabIndex = 0;
			this.settingsGrid.Text = "radPropertyGrid1";
			this.settingsGrid.EditorRequired += new global::Telerik.WinControls.UI.PropertyGridEditorRequiredEventHandler(this.settingsGrid_EditorRequired);
			this.lstEmus.AllowEdit = false;
			this.lstEmus.AllowRemove = false;
			this.lstEmus.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.lstEmus.Location = new global::System.Drawing.Point(0, 0);
			this.lstEmus.Name = "lstEmus";
			this.lstEmus.Size = new global::System.Drawing.Size(243, 406);
			this.lstEmus.TabIndex = 1;
			this.lstEmus.Text = "radListView1";
			this.lstEmus.SelectedItemChanged += new global::System.EventHandler(this.lstEmus_SelectedItemChanged);
			this.cmdLaunchEmu.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdLaunchEmu.Location = new global::System.Drawing.Point(243, 382);
			this.cmdLaunchEmu.Name = "cmdLaunchEmu";
			this.cmdLaunchEmu.Size = new global::System.Drawing.Size(704, 24);
			this.cmdLaunchEmu.TabIndex = 1;
			this.cmdLaunchEmu.Text = "Launch the emulator without game to configure it";
			this.cmdLaunchEmu.Click += new global::System.EventHandler(this.cmdLaunchEmu_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(947, 406);
			base.Controls.Add(this.settingsGrid);
			base.Controls.Add(this.cmdLaunchEmu);
			base.Controls.Add(this.lstEmus);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmEmuSettings";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emulator settings";
			base.Load += new global::System.EventHandler(this.frmEmuSettings_Load);
			((global::System.ComponentModel.ISupportInitialize)this.settingsGrid).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstEmus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLaunchEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400067B RID: 1659
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400067C RID: 1660
		private global::Telerik.WinControls.UI.RadPropertyGrid settingsGrid;

		// Token: 0x0400067D RID: 1661
		private global::Telerik.WinControls.UI.RadListView lstEmus;

		// Token: 0x0400067E RID: 1662
		private global::Telerik.WinControls.UI.RadButton cmdLaunchEmu;
	}
}
