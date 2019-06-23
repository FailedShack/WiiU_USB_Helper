namespace ns0
{
	// Token: 0x020001FB RID: 507
	public partial class FrmWelcome : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000E19 RID: 3609 RVA: 0x0001994E File Offset: 0x00017B4E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000665E8 File Offset: 0x000647E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.FrmWelcome));
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdUSA = new global::Telerik.WinControls.UI.RadButton();
			this.cmdEUR = new global::Telerik.WinControls.UI.RadButton();
			this.cmdJPN = new global::Telerik.WinControls.UI.RadButton();
			this.label2 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdDisclaimer = new global::System.Windows.Forms.CheckBox();
			this.radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.radButton2 = new global::Telerik.WinControls.UI.RadButton();
			this.cmdKOR = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdUSA).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdEUR).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdJPN).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdKOR).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.Location = new global::System.Drawing.Point(114, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(290, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome ! First, please select the region of your console.";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.cmdUSA.Image = global::ns0.Class121.usaFlag;
			this.cmdUSA.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdUSA.Location = new global::System.Drawing.Point(29, 68);
			this.cmdUSA.Name = "cmdUSA";
			this.cmdUSA.Size = new global::System.Drawing.Size(110, 24);
			this.cmdUSA.TabIndex = 1;
			this.cmdUSA.Text = "USA";
			this.cmdUSA.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdUSA.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdUSA.ThemeName = "VisualStudio2012Dark";
			this.cmdUSA.Click += new global::System.EventHandler(this.cmdUSA_Click);
			this.cmdEUR.Image = global::ns0.Class121.eurFlag;
			this.cmdEUR.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdEUR.Location = new global::System.Drawing.Point(148, 68);
			this.cmdEUR.Name = "cmdEUR";
			this.cmdEUR.Size = new global::System.Drawing.Size(110, 24);
			this.cmdEUR.TabIndex = 2;
			this.cmdEUR.Text = "EUR";
			this.cmdEUR.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdEUR.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdEUR.ThemeName = "VisualStudio2012Dark";
			this.cmdEUR.Click += new global::System.EventHandler(this.cmdEUR_Click);
			this.cmdJPN.Image = global::ns0.Class121.jpnFlag;
			this.cmdJPN.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdJPN.Location = new global::System.Drawing.Point(267, 68);
			this.cmdJPN.Name = "cmdJPN";
			this.cmdJPN.Size = new global::System.Drawing.Size(110, 24);
			this.cmdJPN.TabIndex = 3;
			this.cmdJPN.Text = "JPN";
			this.cmdJPN.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdJPN.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdJPN.ThemeName = "VisualStudio2012Dark";
			this.cmdJPN.Click += new global::System.EventHandler(this.cmdJPN_Click);
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(98, 34);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(322, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Make sure you pick the right region, otherwise it may not work.";
			this.label2.ThemeName = "VisualStudio2012Dark";
			this.cmdDisclaimer.AutoSize = true;
			this.cmdDisclaimer.ForeColor = global::System.Drawing.Color.Red;
			this.cmdDisclaimer.Location = new global::System.Drawing.Point(29, 190);
			this.cmdDisclaimer.Name = "cmdDisclaimer";
			this.cmdDisclaimer.Size = new global::System.Drawing.Size(223, 17);
			this.cmdDisclaimer.TabIndex = 15;
			this.cmdDisclaimer.Text = "I agree to these terms and to the EULA";
			this.cmdDisclaimer.UseVisualStyleBackColor = true;
			this.radTextBox1.AutoSize = false;
			this.radTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radTextBox1.Location = new global::System.Drawing.Point(29, 104);
			this.radTextBox1.MinimumSize = new global::System.Drawing.Size(0, 24);
			this.radTextBox1.Multiline = true;
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.ReadOnly = true;
			this.radTextBox1.RootElement.MinSize = new global::System.Drawing.Size(0, 24);
			this.radTextBox1.Size = new global::System.Drawing.Size(477, 76);
			this.radTextBox1.TabIndex = 16;
			this.radTextBox1.Text = componentResourceManager.GetString("radTextBox1.Text");
			this.radTextBox1.ThemeName = "VisualStudio2012Dark";
			this.radButton1.Location = new global::System.Drawing.Point(430, 186);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(76, 20);
			this.radButton1.TabIndex = 17;
			this.radButton1.Text = "EULA";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.radButton2.Location = new global::System.Drawing.Point(437, 10);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new global::System.Drawing.Size(31, 20);
			this.radButton2.TabIndex = 18;
			this.radButton2.Text = "X";
			this.radButton2.Click += new global::System.EventHandler(this.radButton2_Click);
			this.cmdKOR.Image = global::ns0.Class121.korFlag;
			this.cmdKOR.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.cmdKOR.Location = new global::System.Drawing.Point(386, 68);
			this.cmdKOR.Name = "cmdKOR";
			this.cmdKOR.Size = new global::System.Drawing.Size(110, 24);
			this.cmdKOR.TabIndex = 4;
			this.cmdKOR.Text = "KOR";
			this.cmdKOR.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdKOR.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdKOR.ThemeName = "VisualStudio2012Dark";
			this.cmdKOR.Click += new global::System.EventHandler(this.cmdKOR_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(518, 210);
			base.Controls.Add(this.cmdKOR);
			base.Controls.Add(this.radButton2);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.radTextBox1);
			base.Controls.Add(this.cmdDisclaimer);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.cmdJPN);
			base.Controls.Add(this.cmdEUR);
			base.Controls.Add(this.cmdUSA);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmWelcome";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome!";
			base.ThemeName = "VisualStudio2012Dark";
			base.Load += new global::System.EventHandler(this.FrmWelcome_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdUSA).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdEUR).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdJPN).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdKOR).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A2F RID: 2607
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000A30 RID: 2608
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000A31 RID: 2609
		private global::Telerik.WinControls.UI.RadButton cmdUSA;

		// Token: 0x04000A32 RID: 2610
		private global::Telerik.WinControls.UI.RadButton cmdEUR;

		// Token: 0x04000A33 RID: 2611
		private global::Telerik.WinControls.UI.RadButton cmdJPN;

		// Token: 0x04000A34 RID: 2612
		private global::Telerik.WinControls.UI.RadLabel label2;

		// Token: 0x04000A35 RID: 2613
		private global::System.Windows.Forms.CheckBox cmdDisclaimer;

		// Token: 0x04000A36 RID: 2614
		private global::Telerik.WinControls.UI.RadTextBox radTextBox1;

		// Token: 0x04000A37 RID: 2615
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x04000A38 RID: 2616
		private global::Telerik.WinControls.UI.RadButton radButton2;

		// Token: 0x04000A39 RID: 2617
		private global::Telerik.WinControls.UI.RadButton cmdKOR;
	}
}
