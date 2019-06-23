namespace ns0
{
	// Token: 0x02000131 RID: 305
	public partial class frmDriveSetup : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x000156E7 File Offset: 0x000138E7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00035194 File Offset: 0x00033394
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmDriveSetup));
			this.radPageView1 = new global::Telerik.WinControls.UI.RadPageView();
			this.step1 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.step2 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.radPageViewPage1 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radPageViewPage2 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radPageView1).BeginInit();
			this.radPageView1.SuspendLayout();
			this.step1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			this.step2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			this.radPageViewPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			this.radPageViewPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			this.radLabel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radPageView1.Controls.Add(this.step1);
			this.radPageView1.Controls.Add(this.step2);
			this.radPageView1.Controls.Add(this.radPageViewPage1);
			this.radPageView1.Controls.Add(this.radPageViewPage2);
			this.radPageView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPageView1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radPageView1.Location = new global::System.Drawing.Point(0, 0);
			this.radPageView1.Name = "radPageView1";
			this.radPageView1.SelectedPage = this.step1;
			this.radPageView1.Size = new global::System.Drawing.Size(884, 226);
			this.radPageView1.TabIndex = 0;
			this.radPageView1.Text = "radPageView1";
			this.radPageView1.ViewMode = global::Telerik.WinControls.UI.PageViewMode.Backstage;
			this.step1.Controls.Add(this.radLabel1);
			this.step1.ItemSize = new global::System.Drawing.SizeF(194f, 45f);
			this.step1.Location = new global::System.Drawing.Point(305, 4);
			this.step1.Name = "step1";
			this.step1.Size = new global::System.Drawing.Size(575, 218);
			this.step1.Text = "Step 1 - Welcome";
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(575, 218);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.step2.Controls.Add(this.radLabel2);
			this.step2.ItemSize = new global::System.Drawing.SizeF(194f, 45f);
			this.step2.Location = new global::System.Drawing.Point(305, 4);
			this.step2.Name = "step2";
			this.step2.Size = new global::System.Drawing.Size(575, 218);
			this.step2.Text = "Step 2 - Prepare your SD";
			this.radLabel2.AutoSize = false;
			this.radLabel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLabel2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel2.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(575, 218);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = componentResourceManager.GetString("radLabel2.Text");
			this.radPageViewPage1.Controls.Add(this.radLabel3);
			this.radPageViewPage1.ItemSize = new global::System.Drawing.SizeF(194f, 45f);
			this.radPageViewPage1.Location = new global::System.Drawing.Point(305, 4);
			this.radPageViewPage1.Name = "radPageViewPage1";
			this.radPageViewPage1.Size = new global::System.Drawing.Size(575, 218);
			this.radPageViewPage1.Text = "Step 3 - Prepare your USB device";
			this.radLabel3.AutoSize = false;
			this.radLabel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLabel3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel3.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(575, 218);
			this.radLabel3.TabIndex = 2;
			this.radLabel3.Text = "<html><p>Alright, juste one last step!</p><p></p><p><span style=\"color: #ff8000\">Please plug in your <strong>USB device</strong> into your <strong>computer.</strong></span></p></html>";
			this.radPageViewPage2.Controls.Add(this.radLabel4);
			this.radPageViewPage2.ItemSize = new global::System.Drawing.SizeF(194f, 45f);
			this.radPageViewPage2.Location = new global::System.Drawing.Point(305, 4);
			this.radPageViewPage2.Name = "radPageViewPage2";
			this.radPageViewPage2.Size = new global::System.Drawing.Size(575, 218);
			this.radPageViewPage2.Text = "Step 4 - Done!";
			this.radLabel4.AutoSize = false;
			this.radLabel4.Controls.Add(this.radButton1);
			this.radLabel4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLabel4.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel4.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(575, 218);
			this.radLabel4.TabIndex = 3;
			this.radLabel4.Text = "<html>The disk was installed successfully!</html>";
			this.radLabel4.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radButton1.Location = new global::System.Drawing.Point(197, 186);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(181, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Exit";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(884, 226);
			base.Controls.Add(this.radPageView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDriveSetup";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prepare my disk";
			base.Load += new global::System.EventHandler(this.frmDriveSetup_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radPageView1).EndInit();
			this.radPageView1.ResumeLayout(false);
			this.step1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			this.step2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			this.radPageViewPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			this.radPageViewPage2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			this.radLabel4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040004E6 RID: 1254
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040004E7 RID: 1255
		private global::Telerik.WinControls.UI.RadPageView radPageView1;

		// Token: 0x040004E8 RID: 1256
		private global::Telerik.WinControls.UI.RadPageViewPage step1;

		// Token: 0x040004E9 RID: 1257
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040004EA RID: 1258
		private global::Telerik.WinControls.UI.RadPageViewPage step2;

		// Token: 0x040004EB RID: 1259
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040004EC RID: 1260
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;

		// Token: 0x040004ED RID: 1261
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040004EE RID: 1262
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;

		// Token: 0x040004EF RID: 1263
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x040004F0 RID: 1264
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}
