// Decompiled with JetBrains decompiler
// Type: ns0.FrmAskTicket
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmAskTicket : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel label1;
    private RadButton cmdSavelink;
    private RadGroupBox radGroupBox2;
    private RadTextBox radTextBox1;
    private RadButton radButton2;
    private RadTextBox radTextBox2;
    private RadLabel radLabel1;
    private RadPageView radPageView1;
    private RadPageViewPage radPageViewPage1;
    private RadPageViewPage radPageViewPage2;
    private RadGroupBox radGroupBox3;
    private RadLabel radLabel4;
    private PictureBox pictureBox1;
    private RadButton radButton1;
    private RadLabel label5;
    private RadGroupBox radGroupBox1;
    private RadLabel label6;
    private RadTextBox txtUrl;
    private RadLabel label7;
    private RadLabel radLabel5;
    private RadLabel radLabel6;
    private RadLabel radLabel3;
    private RadLabel radLabel7;
    private RadTextBox radTextBox3;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;

    public FrmAskTicket()
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
    }

    public string FileLocation3DS { get; set; } = "";

    public string FileLocationWii { get; set; } = "";

    public string FileLocationWiiU { get; set; } = "";

    private void cmdSavelink_Click(object sender, EventArgs e)
    {
      this.txtUrl.Text = this.txtUrl.Text.Trim();
      if (this.txtUrl.Text.Contains("wiiu.titlekeys.com"))
      {
        int num = (int) RadMessageBox.Show("This textbox is not meant to be used with this site. Please look below.");
        this.txtUrl.Text = "";
      }
      else
      {
        GClass78 gclass78 = new GClass78();
        try
        {
          gclass78.method_2(this.txtUrl.Text);
          this.FileLocationWiiU = this.txtUrl.Text;
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        catch
        {
          int num = (int) RadMessageBox.Show("Sorry but the link you have provided seems invalid.");
        }
      }
    }

    private void FrmAskTicket_Load(object sender, EventArgs e)
    {
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.CheckFileExists = true;
      openFileDialog1.Multiselect = false;
      openFileDialog1.Filter = "RAR Archive (*.rar)|*.rar";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.DialogResult = DialogResult.OK;
      this.FileLocationWiiU = openFileDialog2.FileName;
      this.Close();
    }

    private void radButton2_Click(object sender, EventArgs e)
    {
      if (this.radTextBox1.Text.Contains("wiiu.titlekeys"))
        this.FileLocationWiiU = "http://wiiu.titlekeys.gq/";
      if (this.radTextBox2.Text.Contains("3ds.titlekeys"))
        this.FileLocation3DS = "http://3ds.titlekeys.gq/";
      if (this.radTextBox3.Text.Contains("wii.titlekeys"))
        this.FileLocationWii = "http://wii.titlekeys.gq/";
      if (!(this.FileLocation3DS != "") && !(this.FileLocationWiiU != "") && !(this.FileLocationWii != ""))
      {
        int num = (int) RadMessageBox.Show("The urls you have specified appear to be incorrect. Please check them.");
      }
      else
      {
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void radGroupBox1_DragDrop(object sender, DragEventArgs e)
    {
      string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
      if (File.Exists(data[0]))
      {
        this.DialogResult = DialogResult.OK;
        this.FileLocationWiiU = data[0];
        this.Close();
      }
      else
      {
        int num = (int) RadMessageBox.Show("Sorry but the path you have provided seems invalid.");
      }
    }

    private void radGroupBox1_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
    {
    }

    private void radPageViewPage1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void radTextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new RadLabel();
      this.cmdSavelink = new RadButton();
      this.radGroupBox2 = new RadGroupBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.radLabel7 = new RadLabel();
      this.radTextBox3 = new RadTextBox();
      this.radTextBox1 = new RadTextBox();
      this.radLabel5 = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radTextBox2 = new RadTextBox();
      this.radButton2 = new RadButton();
      this.radPageView1 = new RadPageView();
      this.radPageViewPage1 = new RadPageViewPage();
      this.radPageViewPage2 = new RadPageViewPage();
      this.radGroupBox3 = new RadGroupBox();
      this.radLabel6 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.radButton1 = new RadButton();
      this.label5 = new RadLabel();
      this.radGroupBox1 = new RadGroupBox();
      this.label6 = new RadLabel();
      this.txtUrl = new RadTextBox();
      this.label7 = new RadLabel();
      this.label1.BeginInit();
      this.cmdSavelink.BeginInit();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.radLabel7.BeginInit();
      this.radTextBox3.BeginInit();
      this.radTextBox1.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel1.BeginInit();
      this.radLabel3.BeginInit();
      this.radTextBox2.BeginInit();
      this.radButton2.BeginInit();
      this.radPageView1.BeginInit();
      this.radPageView1.SuspendLayout();
      this.radPageViewPage1.SuspendLayout();
      this.radPageViewPage2.SuspendLayout();
      this.radGroupBox3.BeginInit();
      this.radGroupBox3.SuspendLayout();
      this.radLabel6.BeginInit();
      this.radLabel4.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.radButton1.BeginInit();
      this.label5.BeginInit();
      this.radGroupBox1.BeginInit();
      this.label6.BeginInit();
      this.txtUrl.BeginInit();
      this.label7.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = false;
      this.label1.Dock = DockStyle.Top;
      this.label1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.label1.Location = new Point(10, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(561, 41);
      this.label1.TabIndex = 0;
      this.label1.Text = "In order to work, this application needs to download tickets.\r\nUnfortunately, since this is copyrighted material, you will need to provide them yourself.";
      this.label1.TextAlignment = ContentAlignment.TopCenter;
      this.cmdSavelink.Location = new Point(1027, 499);
      this.cmdSavelink.Name = "cmdSavelink";
      this.cmdSavelink.Size = new Size(110, 24);
      this.cmdSavelink.TabIndex = 10;
      this.cmdSavelink.Text = "Save link";
      this.cmdSavelink.ThemeName = "Desert";
      this.cmdSavelink.Click += new EventHandler(this.cmdSavelink_Click);
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.AllowDrop = true;
      this.radGroupBox2.Controls.Add((Control) this.pictureBox4);
      this.radGroupBox2.Controls.Add((Control) this.pictureBox3);
      this.radGroupBox2.Controls.Add((Control) this.pictureBox2);
      this.radGroupBox2.Controls.Add((Control) this.radLabel7);
      this.radGroupBox2.Controls.Add((Control) this.radTextBox3);
      this.radGroupBox2.Controls.Add((Control) this.radTextBox1);
      this.radGroupBox2.Controls.Add((Control) this.radLabel5);
      this.radGroupBox2.Controls.Add((Control) this.radLabel1);
      this.radGroupBox2.Controls.Add((Control) this.radLabel3);
      this.radGroupBox2.Controls.Add((Control) this.radTextBox2);
      this.radGroupBox2.Controls.Add((Control) this.radButton2);
      this.radGroupBox2.Dock = DockStyle.Fill;
      this.radGroupBox2.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radGroupBox2.HeaderText = "Use the title key sites";
      this.radGroupBox2.Location = new Point(0, 0);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new Size(551, 531);
      this.radGroupBox2.TabIndex = 7;
      this.radGroupBox2.Text = "Use the title key sites";
      this.radGroupBox2.ThemeName = "Desert";
      this.pictureBox4.Image = (Image) Class123.logoWii;
      this.pictureBox4.Location = new Point(482, 231);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(33, 18);
      this.pictureBox4.TabIndex = 18;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Visible = false;
      this.pictureBox3.Image = (Image) Class123.logo3ds;
      this.pictureBox3.Location = new Point(462, 170);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(53, 18);
      this.pictureBox3.TabIndex = 17;
      this.pictureBox3.TabStop = false;
      this.pictureBox2.Image = (Image) Class123.logoWiiU;
      this.pictureBox2.Location = new Point(462, 104);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(53, 18);
      this.pictureBox2.TabIndex = 16;
      this.pictureBox2.TabStop = false;
      this.radLabel7.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel7.Location = new Point(36, 231);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new Size(226, 18);
      this.radLabel7.TabIndex = 14;
      this.radLabel7.Text = "For the Wii: (only works on Wii and vWii)";
      this.radLabel7.Visible = false;
      this.radTextBox3.Location = new Point(85, (int) byte.MaxValue);
      this.radTextBox3.Name = "radTextBox3";
      this.radTextBox3.NullText = "Please paste here the address to that Wii site";
      this.radTextBox3.Size = new Size(430, 20);
      this.radTextBox3.TabIndex = 15;
      this.radTextBox3.ThemeName = "Desert";
      this.radTextBox3.Visible = false;
      this.radTextBox1.Location = new Point(85, 128);
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.NullText = "Please paste here the address to that WiiU site";
      this.radTextBox1.Size = new Size(430, 20);
      this.radTextBox1.TabIndex = 10;
      this.radTextBox1.ThemeName = "Desert";
      this.radTextBox1.TextChanged += new EventHandler(this.radTextBox1_TextChanged);
      this.radLabel5.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel5.Location = new Point(71, 69);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new Size(429, 18);
      this.radLabel5.TabIndex = 2;
      this.radLabel5.Text = "If you wish to download both 3DS and WiiU games you have to input both urls.";
      this.radLabel1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.Location = new Point(36, 170);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(239, 18);
      this.radLabel1.TabIndex = 2;
      this.radLabel1.Text = "For the 3DS: (only works on 3DS, not WiiU!)";
      this.radLabel3.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel3.Location = new Point(36, 104);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(76, 18);
      this.radLabel3.TabIndex = 3;
      this.radLabel3.Text = "For the WiiU:";
      this.radTextBox2.Location = new Point(85, 194);
      this.radTextBox2.Name = "radTextBox2";
      this.radTextBox2.NullText = "Please paste here the address to that 3DS site";
      this.radTextBox2.Size = new Size(430, 20);
      this.radTextBox2.TabIndex = 11;
      this.radTextBox2.ThemeName = "Desert";
      this.radButton2.Location = new Point(187, 286);
      this.radButton2.Name = "radButton2";
      this.radButton2.Size = new Size(177, 25);
      this.radButton2.TabIndex = 13;
      this.radButton2.Text = "Ok";
      this.radButton2.ThemeName = "Desert";
      this.radButton2.Click += new EventHandler(this.radButton2_Click);
      this.radPageView1.Controls.Add((Control) this.radPageViewPage1);
      this.radPageView1.Controls.Add((Control) this.radPageViewPage2);
      this.radPageView1.Dock = DockStyle.Fill;
      this.radPageView1.ItemSizeMode = PageViewItemSizeMode.EqualSize;
      this.radPageView1.Location = new Point(10, 51);
      this.radPageView1.Name = "radPageView1";
      this.radPageView1.SelectedPage = this.radPageViewPage1;
      this.radPageView1.Size = new Size(561, 626);
      this.radPageView1.TabIndex = 14;
      this.radPageView1.Text = "Method - 1 (Recommended)";
      this.radPageView1.ViewMode = PageViewMode.Stack;
      this.radPageView1.SelectedPageChanged += new EventHandler(this.radPageView1_SelectedPageChanged);
      this.radPageViewPage1.Controls.Add((Control) this.radGroupBox2);
      this.radPageViewPage1.ItemSize = new SizeF(561f, 32f);
      this.radPageViewPage1.Location = new Point(5, 29);
      this.radPageViewPage1.Name = "radPageViewPage1";
      this.radPageViewPage1.Size = new Size(551, 531);
      this.radPageViewPage1.Text = "Method 1 - (Recommended)";
      this.radPageViewPage1.Paint += new PaintEventHandler(this.radPageViewPage1_Paint);
      this.radPageViewPage2.Controls.Add((Control) this.radGroupBox3);
      this.radPageViewPage2.ItemSize = new SizeF(561f, 32f);
      this.radPageViewPage2.Location = new Point(5, 29);
      this.radPageViewPage2.Name = "radPageViewPage2";
      this.radPageViewPage2.Size = new Size(551, 531);
      this.radPageViewPage2.Text = "Alternate Method";
      this.radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox3.Controls.Add((Control) this.radLabel6);
      this.radGroupBox3.Controls.Add((Control) this.radLabel4);
      this.radGroupBox3.Controls.Add((Control) this.pictureBox1);
      this.radGroupBox3.Controls.Add((Control) this.radButton1);
      this.radGroupBox3.Controls.Add((Control) this.label5);
      this.radGroupBox3.Controls.Add((Control) this.radGroupBox1);
      this.radGroupBox3.Controls.Add((Control) this.label6);
      this.radGroupBox3.Controls.Add((Control) this.txtUrl);
      this.radGroupBox3.Controls.Add((Control) this.label7);
      this.radGroupBox3.Dock = DockStyle.Fill;
      this.radGroupBox3.HeaderText = "Alternate method";
      this.radGroupBox3.Location = new Point(0, 0);
      this.radGroupBox3.Name = "radGroupBox3";
      this.radGroupBox3.Padding = new Padding(10);
      this.radGroupBox3.Size = new Size(551, 531);
      this.radGroupBox3.TabIndex = 14;
      this.radGroupBox3.Text = "Alternate method";
      this.radLabel6.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel6.ForeColor = Color.FromArgb(192, 0, 0);
      this.radLabel6.Location = new Point(132, 23);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(300, 19);
      this.radLabel6.TabIndex = 13;
      this.radLabel6.Text = "This method is outdated and no longer supported.";
      this.radLabel4.Location = new Point(13, 47);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(469, 18);
      this.radLabel4.TabIndex = 6;
      this.radLabel4.Text = "If you want to use your own archive, just create a rar archive with the following file structure :";
      this.pictureBox1.Image = (Image) Class123.filestruct;
      this.pictureBox1.Location = new Point(13, 71);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(547, 193);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      this.radButton1.Location = new Point(435, 242);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(110, 24);
      this.radButton1.TabIndex = 12;
      this.radButton1.Text = "Browse...";
      this.radButton1.ThemeName = "Desert";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.label5.Location = new Point(13, 270);
      this.label5.Name = "label5";
      this.label5.Size = new Size(252, 18);
      this.label5.TabIndex = 5;
      this.label5.Text = "Now, please drag and drop your archive file here:";
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.AllowDrop = true;
      this.radGroupBox1.HeaderText = "Drag Here!";
      this.radGroupBox1.Location = new Point(9, 326);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(544, 133);
      this.radGroupBox1.TabIndex = 6;
      this.radGroupBox1.Text = "Drag Here!";
      this.radGroupBox1.ThemeName = "Desert";
      this.radGroupBox1.DragDrop += new DragEventHandler(this.radGroupBox1_DragDrop);
      this.radGroupBox1.DragEnter += new DragEventHandler(this.radGroupBox1_DragEnter);
      this.label6.Location = new Point(106, 465);
      this.label6.Name = "label6";
      this.label6.Size = new Size(346, 18);
      this.label6.TabIndex = 7;
      this.label6.Text = "Alternatively, you can use a URL to fetch the ticket archive at launch.";
      this.txtUrl.Location = new Point(65, 498);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new Size(433, 20);
      this.txtUrl.TabIndex = 9;
      this.txtUrl.ThemeName = "Desert";
      this.label7.Location = new Point(151, 480);
      this.label7.Name = "label7";
      this.label7.Size = new Size(256, 18);
      this.label7.TabIndex = 8;
      this.label7.Text = "Caution, it has to be a direct link ! (No mega links)";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(581, 687);
      this.Controls.Add((Control) this.radPageView1);
      this.Controls.Add((Control) this.cmdSavelink);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmAskTicket);
      this.Padding = new Padding(10);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ticket";
      this.ThemeName = "Desert";
      this.Load += new EventHandler(this.FrmAskTicket_Load);
      this.label1.EndInit();
      this.cmdSavelink.EndInit();
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.radLabel7.EndInit();
      this.radTextBox3.EndInit();
      this.radTextBox1.EndInit();
      this.radLabel5.EndInit();
      this.radLabel1.EndInit();
      this.radLabel3.EndInit();
      this.radTextBox2.EndInit();
      this.radButton2.EndInit();
      this.radPageView1.EndInit();
      this.radPageView1.ResumeLayout(false);
      this.radPageViewPage1.ResumeLayout(false);
      this.radPageViewPage2.ResumeLayout(false);
      this.radGroupBox3.EndInit();
      this.radGroupBox3.ResumeLayout(false);
      this.radGroupBox3.PerformLayout();
      this.radLabel6.EndInit();
      this.radLabel4.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.radButton1.EndInit();
      this.label5.EndInit();
      this.radGroupBox1.EndInit();
      this.label6.EndInit();
      this.txtUrl.EndInit();
      this.label7.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
