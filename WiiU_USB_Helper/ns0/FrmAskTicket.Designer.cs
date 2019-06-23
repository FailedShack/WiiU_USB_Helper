namespace ns0
{
	// Token: 0x020001B7 RID: 439
	public partial class FrmAskTicket : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C30 RID: 3120 RVA: 0x000189B5 File Offset: 0x00016BB5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0004BABC File Offset: 0x00049CBC
		private void InitializeComponent()
		{
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdSavelink = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox2 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.radLabel7 = new global::Telerik.WinControls.UI.RadLabel();
			this.radTextBox3 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radLabel5 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radTextBox2 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radButton2 = new global::Telerik.WinControls.UI.RadButton();
			this.radPageView1 = new global::Telerik.WinControls.UI.RadPageView();
			this.radPageViewPage1 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radPageViewPage2 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radGroupBox3 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radLabel6 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.label5 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.label6 = new global::Telerik.WinControls.UI.RadLabel();
			this.txtUrl = new global::Telerik.WinControls.UI.RadTextBox();
			this.label7 = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSavelink).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).BeginInit();
			this.radGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radPageView1).BeginInit();
			this.radPageView1.SuspendLayout();
			this.radPageViewPage1.SuspendLayout();
			this.radPageViewPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).BeginInit();
			this.radGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUrl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = false;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.label1.Location = new global::System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(561, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "In order to work, this application needs to download tickets.\r\nUnfortunately, since this is copyrighted material, you will need to provide them yourself.";
			this.label1.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.cmdSavelink.Location = new global::System.Drawing.Point(1027, 499);
			this.cmdSavelink.Name = "cmdSavelink";
			this.cmdSavelink.Size = new global::System.Drawing.Size(110, 24);
			this.cmdSavelink.TabIndex = 10;
			this.cmdSavelink.Text = "Save link";
			this.cmdSavelink.ThemeName = "Desert";
			this.cmdSavelink.Click += new global::System.EventHandler(this.cmdSavelink_Click);
			this.radGroupBox2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox2.AllowDrop = true;
			this.radGroupBox2.Controls.Add(this.pictureBox4);
			this.radGroupBox2.Controls.Add(this.pictureBox3);
			this.radGroupBox2.Controls.Add(this.pictureBox2);
			this.radGroupBox2.Controls.Add(this.radLabel7);
			this.radGroupBox2.Controls.Add(this.radTextBox3);
			this.radGroupBox2.Controls.Add(this.radTextBox1);
			this.radGroupBox2.Controls.Add(this.radLabel5);
			this.radGroupBox2.Controls.Add(this.radLabel1);
			this.radGroupBox2.Controls.Add(this.radLabel3);
			this.radGroupBox2.Controls.Add(this.radTextBox2);
			this.radGroupBox2.Controls.Add(this.radButton2);
			this.radGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radGroupBox2.HeaderText = "Use the title key sites";
			this.radGroupBox2.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox2.Name = "radGroupBox2";
			this.radGroupBox2.Size = new global::System.Drawing.Size(551, 531);
			this.radGroupBox2.TabIndex = 7;
			this.radGroupBox2.Text = "Use the title key sites";
			this.radGroupBox2.ThemeName = "Desert";
			this.pictureBox4.Image = global::ns0.Class121.logoWii;
			this.pictureBox4.Location = new global::System.Drawing.Point(482, 231);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(33, 18);
			this.pictureBox4.TabIndex = 18;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			this.pictureBox3.Image = global::ns0.Class121.logo3ds;
			this.pictureBox3.Location = new global::System.Drawing.Point(462, 170);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(53, 18);
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			this.pictureBox2.Image = global::ns0.Class121.logoWiiU;
			this.pictureBox2.Location = new global::System.Drawing.Point(462, 104);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(53, 18);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			this.radLabel7.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel7.Location = new global::System.Drawing.Point(36, 231);
			this.radLabel7.Name = "radLabel7";
			this.radLabel7.Size = new global::System.Drawing.Size(226, 18);
			this.radLabel7.TabIndex = 14;
			this.radLabel7.Text = "For the Wii: (only works on Wii and vWii)";
			this.radLabel7.Visible = false;
			this.radTextBox3.Location = new global::System.Drawing.Point(85, 255);
			this.radTextBox3.Name = "radTextBox3";
			this.radTextBox3.NullText = "Please paste here the address to that Wii site";
			this.radTextBox3.Size = new global::System.Drawing.Size(430, 20);
			this.radTextBox3.TabIndex = 15;
			this.radTextBox3.ThemeName = "Desert";
			this.radTextBox3.Visible = false;
			this.radTextBox1.Location = new global::System.Drawing.Point(85, 128);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.NullText = "Please paste here the address to that WiiU site";
			this.radTextBox1.Size = new global::System.Drawing.Size(430, 20);
			this.radTextBox1.TabIndex = 10;
			this.radTextBox1.ThemeName = "Desert";
			this.radTextBox1.TextChanged += new global::System.EventHandler(this.radTextBox1_TextChanged);
			this.radLabel5.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel5.Location = new global::System.Drawing.Point(71, 69);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new global::System.Drawing.Size(429, 18);
			this.radLabel5.TabIndex = 2;
			this.radLabel5.Text = "If you wish to download both 3DS and WiiU games you have to input both urls.";
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(36, 170);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(239, 18);
			this.radLabel1.TabIndex = 2;
			this.radLabel1.Text = "For the 3DS: (only works on 3DS, not WiiU!)";
			this.radLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel3.Location = new global::System.Drawing.Point(36, 104);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(76, 18);
			this.radLabel3.TabIndex = 3;
			this.radLabel3.Text = "For the WiiU:";
			this.radTextBox2.Location = new global::System.Drawing.Point(85, 194);
			this.radTextBox2.Name = "radTextBox2";
			this.radTextBox2.NullText = "Please paste here the address to that 3DS site";
			this.radTextBox2.Size = new global::System.Drawing.Size(430, 20);
			this.radTextBox2.TabIndex = 11;
			this.radTextBox2.ThemeName = "Desert";
			this.radButton2.Location = new global::System.Drawing.Point(187, 286);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new global::System.Drawing.Size(177, 25);
			this.radButton2.TabIndex = 13;
			this.radButton2.Text = "Ok";
			this.radButton2.ThemeName = "Desert";
			this.radButton2.Click += new global::System.EventHandler(this.radButton2_Click);
			this.radPageView1.Controls.Add(this.radPageViewPage1);
			this.radPageView1.Controls.Add(this.radPageViewPage2);
			this.radPageView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPageView1.ItemSizeMode = global::Telerik.WinControls.UI.PageViewItemSizeMode.EqualSize;
			this.radPageView1.Location = new global::System.Drawing.Point(10, 51);
			this.radPageView1.Name = "radPageView1";
			this.radPageView1.SelectedPage = this.radPageViewPage1;
			this.radPageView1.Size = new global::System.Drawing.Size(561, 626);
			this.radPageView1.TabIndex = 14;
			this.radPageView1.Text = "Method - 1 (Recommended)";
			this.radPageView1.ViewMode = global::Telerik.WinControls.UI.PageViewMode.Stack;
			this.radPageView1.SelectedPageChanged += new global::System.EventHandler(this.radPageView1_SelectedPageChanged);
			this.radPageViewPage1.Controls.Add(this.radGroupBox2);
			this.radPageViewPage1.ItemSize = new global::System.Drawing.SizeF(561f, 32f);
			this.radPageViewPage1.Location = new global::System.Drawing.Point(5, 29);
			this.radPageViewPage1.Name = "radPageViewPage1";
			this.radPageViewPage1.Size = new global::System.Drawing.Size(551, 531);
			this.radPageViewPage1.Text = "Method 1 - (Recommended)";
			this.radPageViewPage1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.radPageViewPage1_Paint);
			this.radPageViewPage2.Controls.Add(this.radGroupBox3);
			this.radPageViewPage2.ItemSize = new global::System.Drawing.SizeF(561f, 32f);
			this.radPageViewPage2.Location = new global::System.Drawing.Point(5, 29);
			this.radPageViewPage2.Name = "radPageViewPage2";
			this.radPageViewPage2.Size = new global::System.Drawing.Size(551, 531);
			this.radPageViewPage2.Text = "Alternate Method";
			this.radGroupBox3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox3.Controls.Add(this.radLabel6);
			this.radGroupBox3.Controls.Add(this.radLabel4);
			this.radGroupBox3.Controls.Add(this.pictureBox1);
			this.radGroupBox3.Controls.Add(this.radButton1);
			this.radGroupBox3.Controls.Add(this.label5);
			this.radGroupBox3.Controls.Add(this.radGroupBox1);
			this.radGroupBox3.Controls.Add(this.label6);
			this.radGroupBox3.Controls.Add(this.txtUrl);
			this.radGroupBox3.Controls.Add(this.label7);
			this.radGroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox3.HeaderText = "Alternate method";
			this.radGroupBox3.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox3.Name = "radGroupBox3";
			this.radGroupBox3.Padding = new global::System.Windows.Forms.Padding(10);
			this.radGroupBox3.Size = new global::System.Drawing.Size(551, 531);
			this.radGroupBox3.TabIndex = 14;
			this.radGroupBox3.Text = "Alternate method";
			this.radLabel6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel6.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.radLabel6.Location = new global::System.Drawing.Point(132, 23);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new global::System.Drawing.Size(300, 19);
			this.radLabel6.TabIndex = 13;
			this.radLabel6.Text = "This method is outdated and no longer supported.";
			this.radLabel4.Location = new global::System.Drawing.Point(13, 47);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(469, 18);
			this.radLabel4.TabIndex = 6;
			this.radLabel4.Text = "If you want to use your own archive, just create a rar archive with the following file structure :";
			this.pictureBox1.Image = global::ns0.Class121.filestruct;
			this.pictureBox1.Location = new global::System.Drawing.Point(13, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(547, 193);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.radButton1.Location = new global::System.Drawing.Point(435, 242);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(110, 24);
			this.radButton1.TabIndex = 12;
			this.radButton1.Text = "Browse...";
			this.radButton1.ThemeName = "Desert";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.label5.Location = new global::System.Drawing.Point(13, 270);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(252, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "Now, please drag and drop your archive file here:";
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.AllowDrop = true;
			this.radGroupBox1.HeaderText = "Drag Here!";
			this.radGroupBox1.Location = new global::System.Drawing.Point(9, 326);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(544, 133);
			this.radGroupBox1.TabIndex = 6;
			this.radGroupBox1.Text = "Drag Here!";
			this.radGroupBox1.ThemeName = "Desert";
			this.radGroupBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.radGroupBox1_DragDrop);
			this.radGroupBox1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.radGroupBox1_DragEnter);
			this.label6.Location = new global::System.Drawing.Point(106, 465);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(346, 18);
			this.label6.TabIndex = 7;
			this.label6.Text = "Alternatively, you can use a URL to fetch the ticket archive at launch.";
			this.txtUrl.Location = new global::System.Drawing.Point(65, 498);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new global::System.Drawing.Size(433, 20);
			this.txtUrl.TabIndex = 9;
			this.txtUrl.ThemeName = "Desert";
			this.label7.Location = new global::System.Drawing.Point(151, 480);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(256, 18);
			this.label7.TabIndex = 8;
			this.label7.Text = "Caution, it has to be a direct link ! (No mega links)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(581, 687);
			base.Controls.Add(this.radPageView1);
			base.Controls.Add(this.cmdSavelink);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmAskTicket";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ticket";
			base.ThemeName = "Desert";
			base.Load += new global::System.EventHandler(this.FrmAskTicket_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSavelink).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).EndInit();
			this.radGroupBox2.ResumeLayout(false);
			this.radGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radPageView1).EndInit();
			this.radPageView1.ResumeLayout(false);
			this.radPageViewPage1.ResumeLayout(false);
			this.radPageViewPage2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).EndInit();
			this.radGroupBox3.ResumeLayout(false);
			this.radGroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUrl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040007A4 RID: 1956
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040007A5 RID: 1957
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x040007A6 RID: 1958
		private global::Telerik.WinControls.UI.RadButton cmdSavelink;

		// Token: 0x040007A7 RID: 1959
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox2;

		// Token: 0x040007A8 RID: 1960
		private global::Telerik.WinControls.UI.RadTextBox radTextBox1;

		// Token: 0x040007A9 RID: 1961
		private global::Telerik.WinControls.UI.RadButton radButton2;

		// Token: 0x040007AA RID: 1962
		private global::Telerik.WinControls.UI.RadTextBox radTextBox2;

		// Token: 0x040007AB RID: 1963
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040007AC RID: 1964
		private global::Telerik.WinControls.UI.RadPageView radPageView1;

		// Token: 0x040007AD RID: 1965
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;

		// Token: 0x040007AE RID: 1966
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;

		// Token: 0x040007AF RID: 1967
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox3;

		// Token: 0x040007B0 RID: 1968
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x040007B1 RID: 1969
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040007B2 RID: 1970
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x040007B3 RID: 1971
		private global::Telerik.WinControls.UI.RadLabel label5;

		// Token: 0x040007B4 RID: 1972
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x040007B5 RID: 1973
		private global::Telerik.WinControls.UI.RadLabel label6;

		// Token: 0x040007B6 RID: 1974
		private global::Telerik.WinControls.UI.RadTextBox txtUrl;

		// Token: 0x040007B7 RID: 1975
		private global::Telerik.WinControls.UI.RadLabel label7;

		// Token: 0x040007B8 RID: 1976
		private global::Telerik.WinControls.UI.RadLabel radLabel5;

		// Token: 0x040007B9 RID: 1977
		private global::Telerik.WinControls.UI.RadLabel radLabel6;

		// Token: 0x040007BA RID: 1978
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040007BB RID: 1979
		private global::Telerik.WinControls.UI.RadLabel radLabel7;

		// Token: 0x040007BC RID: 1980
		private global::Telerik.WinControls.UI.RadTextBox radTextBox3;

		// Token: 0x040007BD RID: 1981
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x040007BE RID: 1982
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x040007BF RID: 1983
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
