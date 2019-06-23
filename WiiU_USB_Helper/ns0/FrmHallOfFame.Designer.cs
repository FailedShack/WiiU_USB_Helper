namespace ns0
{
	// Token: 0x020001B9 RID: 441
	public partial class FrmHallOfFame : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x000189F5 File Offset: 0x00016BF5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0004D040 File Offset: 0x0004B240
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.FrmHallOfFame));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.txtFame = new global::System.Windows.Forms.RichTextBox();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.timer_0.Interval = 20;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.txtFame.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtFame.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtFame.Font = new global::System.Drawing.Font("Cambria", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtFame.ForeColor = global::System.Drawing.Color.White;
			this.txtFame.Location = new global::System.Drawing.Point(0, 36);
			this.txtFame.Name = "txtFame";
			this.txtFame.ReadOnly = true;
			this.txtFame.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.txtFame.Size = new global::System.Drawing.Size(579, 421);
			this.txtFame.TabIndex = 0;
			this.txtFame.TabStop = false;
			this.txtFame.Text = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(579, 18);
			this.radLabel1.TabIndex = 1;
			this.radLabel1.Text = "This is a list of people who helped make this app better by helping debugging it and/or submitting ideas.";
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.radLabel2.AutoSize = false;
			this.radLabel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel2.Location = new global::System.Drawing.Point(0, 18);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(579, 18);
			this.radLabel2.TabIndex = 2;
			this.radLabel2.Text = "Donators are indicated by a golden name.";
			this.radLabel2.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabel2.ThemeName = "VisualStudio2012Dark";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(579, 457);
			base.Controls.Add(this.txtFame);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmHallOfFame";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			this.Text = "Hall of fame";
			base.ThemeName = "VisualStudio2012Dark";
			base.Load += new global::System.EventHandler(this.FrmHallOfFame_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007CF RID: 1999
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040007D0 RID: 2000
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040007D1 RID: 2001
		private global::System.Windows.Forms.RichTextBox txtFame;

		// Token: 0x040007D2 RID: 2002
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040007D3 RID: 2003
		private global::Telerik.WinControls.UI.RadLabel radLabel2;
	}
}
