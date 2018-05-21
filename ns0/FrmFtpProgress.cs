// Decompiled with JetBrains decompiler
// Type: ns0.FrmFtpProgress
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmFtpProgress : RadForm
  {
    private volatile bool bool_0;
    private IContainer icontainer_0;
    private RadProgressBar radProgressBar1;
    private RadLabel title;
    private RadLabel lblSpeed;
    private RadButton radButton1;
    private RadLabel lblEta;
    private PictureBox pictureBox1;
    private PictureBox pctIcon;
    private PictureBox pictureBox2;

    public FrmFtpProgress(GClass30 gclass30_0)
    {
      this.InitializeComponent();
      this.pctIcon.ImageLocation = gclass30_0.GClass32_0.IconUrl;
      this.title.Text = gclass30_0.Name;
      using (GraphicsPath path = new GraphicsPath())
      {
        path.AddEllipse(new Rectangle(0, 0, this.pctIcon.Width - 1, this.pctIcon.Height - 1));
        this.pctIcon.Region = new Region(path);
      }
    }

    public event EventHandler Event_0;

    public void method_0()
    {
      try
      {
        this.bool_0 = true;
        this.BeginInvoke((Delegate) new Action(((Form) this).Close));
      }
      catch
      {
      }
    }

    public void method_1(TimeSpan timeSpan_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.BeginInvoke((Delegate) new Action(new FrmFtpProgress.Class110()
      {
        frmFtpProgress_0 = this,
        timeSpan_0 = timeSpan_0
      }.method_0));
    }

    public void method_2(int int_0, GStruct3 gstruct3_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.BeginInvoke((Delegate) new Action(new FrmFtpProgress.Class111()
      {
        int_0 = int_0,
        frmFtpProgress_0 = this,
        gstruct3_0 = gstruct3_0
      }.method_0));
    }

    private void FrmFtpProgress_Load(object sender, EventArgs e)
    {
      this.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
      if (!this.bool_0)
        return;
      this.Close();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radProgressBar1 = new RadProgressBar();
      this.title = new RadLabel();
      this.radButton1 = new RadButton();
      this.lblSpeed = new RadLabel();
      this.lblEta = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.pctIcon = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.radProgressBar1.BeginInit();
      this.title.BeginInit();
      this.radButton1.BeginInit();
      this.lblSpeed.BeginInit();
      this.lblEta.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pctIcon).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radProgressBar1.Location = new Point(22, 79);
      this.radProgressBar1.Name = "radProgressBar1";
      this.radProgressBar1.ShowProgressIndicators = true;
      this.radProgressBar1.Size = new Size(398, 24);
      this.radProgressBar1.TabIndex = 0;
      this.radProgressBar1.Text = "0 %";
      this.title.AutoSize = false;
      this.title.Dock = DockStyle.Top;
      this.title.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.title.Location = new Point(0, 0);
      this.title.Name = "title";
      this.title.Size = new Size(442, 73);
      this.title.TabIndex = 1;
      this.title.Text = "radLabel1";
      this.title.TextAlignment = ContentAlignment.TopCenter;
      this.title.UseMnemonic = false;
      this.radButton1.Location = new Point(166, 190);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(110, 24);
      this.radButton1.TabIndex = 3;
      this.radButton1.Text = "Abort";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.lblSpeed.Location = new Point(348, 104);
      this.lblSpeed.Name = "lblSpeed";
      this.lblSpeed.Size = new Size(27, 18);
      this.lblSpeed.TabIndex = 2;
      this.lblSpeed.Text = "0.00";
      this.lblEta.Location = new Point(22, 104);
      this.lblEta.Name = "lblEta";
      this.lblEta.Size = new Size(25, 18);
      this.lblEta.TabIndex = 3;
      this.lblEta.Text = "ETA";
      this.pictureBox1.Image = (Image) Class123.icnWiiU;
      this.pictureBox1.Location = new Point(284, 133);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(128, 43);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      this.pctIcon.Location = new Point(31, 128);
      this.pctIcon.Name = "pctIcon";
      this.pctIcon.Size = new Size(64, 64);
      this.pctIcon.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pctIcon.TabIndex = 5;
      this.pctIcon.TabStop = false;
      this.pictureBox2.Image = (Image) Class123.transferAnim;
      this.pictureBox2.InitialImage = (Image) null;
      this.pictureBox2.Location = new Point(98, 138);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(180, 40);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 6;
      this.pictureBox2.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(442, 221);
      this.Controls.Add((Control) this.lblSpeed);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.pctIcon);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.lblEta);
      this.Controls.Add((Control) this.title);
      this.Controls.Add((Control) this.radProgressBar1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmFtpProgress);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Now uploading...";
      this.Load += new EventHandler(this.FrmFtpProgress_Load);
      this.radProgressBar1.EndInit();
      this.title.EndInit();
      this.radButton1.EndInit();
      this.lblSpeed.EndInit();
      this.lblEta.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pctIcon).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
