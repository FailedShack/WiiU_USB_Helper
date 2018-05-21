// Decompiled with JetBrains decompiler
// Type: ns0.frmUnpackAnimation
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmUnpackAnimation : Form
  {
    private int int_0 = -1;
    private bool bool_0;
    private IContainer icontainer_0;
    private RadProgressBar radProgressBar1;
    private PictureBox pictureBox1;
    private Timer timer_0;
    private RadLabel lblFiles;
    private RadLabel lblTile;

    public frmUnpackAnimation(GClass30 gclass30_0)
    {
      this.InitializeComponent();
      this.Region = Class97.smethod_6((Form) this, 40);
      GClass32 gclass32 = (GClass32) null;
      if (gclass30_0 is GClass32)
      {
        gclass32 = gclass30_0 as GClass32;
        this.lblTile.Text = gclass32.Name;
      }
      if (gclass30_0 is GClass31)
      {
        gclass32 = GClass28.dictionary_0[new TitleId((string) gclass30_0.TitleId.FullGame)];
        this.lblTile.Text = gclass32.Name + " DLC";
      }
      if (gclass30_0 is GClass33)
      {
        gclass32 = GClass28.dictionary_0[new TitleId((string) gclass30_0.TitleId.FullGame)];
        this.lblTile.Text = gclass32.Name + " UPDATE";
      }
      this.pictureBox1.Image = gclass32.gclass86_0.Image;
      gclass32.method_28((Action<GClass74, GClass32>) ((gclass74_0, gclass32_0) => this.pictureBox1.ImageLocation = gclass74_0.BannerUrl));
    }

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

    public void method_1(GStruct0 gstruct0_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmUnpackAnimation.Class154 class154 = new frmUnpackAnimation.Class154();
      // ISSUE: reference to a compiler-generated field
      class154.gstruct0_0 = gstruct0_0;
      // ISSUE: reference to a compiler-generated field
      class154.frmUnpackAnimation_0 = this;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class154.method_0));
      }
      catch
      {
      }
    }

    private void frmUnpackAnimation_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.bool_0)
        return;
      int num = (int) RadMessageBox.Show("You cannot close this window while the title is extracting. Please wait for the end of the process");
      e.Cancel = true;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      this.pictureBox1.Left += this.int_0;
      if (this.pictureBox1.Left > -640 && this.pictureBox1.Left < 0)
        return;
      this.int_0 *= -1;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.icontainer_0 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUnpackAnimation));
      this.radProgressBar1 = new RadProgressBar();
      this.pictureBox1 = new PictureBox();
      this.timer_0 = new Timer(this.icontainer_0);
      this.lblFiles = new RadLabel();
      this.lblTile = new RadLabel();
      this.radProgressBar1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.lblFiles.BeginInit();
      this.lblTile.BeginInit();
      this.SuspendLayout();
      this.radProgressBar1.Location = new Point(15, 75);
      this.radProgressBar1.Name = "radProgressBar1";
      this.radProgressBar1.ShowProgressIndicators = true;
      this.radProgressBar1.Size = new Size(610, 24);
      this.radProgressBar1.TabIndex = 0;
      this.radProgressBar1.Text = "0 %";
      this.pictureBox1.Location = new Point(-1, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(805, 175);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.timer_0.Enabled = true;
      this.timer_0.Interval = 30;
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.lblFiles.Location = new Point(12, 157);
      this.lblFiles.Name = "lblFiles";
      this.lblFiles.Size = new Size(9, 18);
      this.lblFiles.TabIndex = 3;
      this.lblFiles.Text = ".";
      this.lblTile.Location = new Point(15, 0);
      this.lblTile.Name = "lblTile";
      this.lblTile.Size = new Size(9, 18);
      this.lblTile.TabIndex = 4;
      this.lblTile.Text = ".";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(640, 174);
      this.Controls.Add((Control) this.lblTile);
      this.Controls.Add((Control) this.lblFiles);
      this.Controls.Add((Control) this.radProgressBar1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmUnpackAnimation);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Now unpacking...";
      this.FormClosing += new FormClosingEventHandler(this.frmUnpackAnimation_FormClosing);
      this.radProgressBar1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.lblFiles.EndInit();
      this.lblTile.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
