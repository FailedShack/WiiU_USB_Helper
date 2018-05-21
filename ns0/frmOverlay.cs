// Decompiled with JetBrains decompiler
// Type: ns0.frmOverlay
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace ns0
{
  public class frmOverlay : GForm1
  {
    private IContainer icontainer_0;
    private PictureBox pBox;

    public frmOverlay(IntPtr intptr_1, Image image_0, System.Drawing.Point point_0, System.Drawing.Point point_1)
      : base(100f, intptr_1, Color.Magenta, true)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmOverlay.Class153 class153 = new frmOverlay.Class153();
      // ISSUE: reference to a compiler-generated field
      class153.frmOverlay_0 = this;
      this.InitializeComponent();
      this.pBox.Image = image_0;
      this.pBox.SizeMode = PictureBoxSizeMode.AutoSize;
      point_0.X += this.pBox.Width / 2;
      point_0.Y += this.pBox.Height / 2;
      this.pBox.Location = point_0;
      // ISSUE: reference to a compiler-generated field
      class153.timer_0 = new Timer() { Interval = 16 };
      // ISSUE: reference to a compiler-generated field
      class153.vector_1 = new Vector((double) point_0.X, (double) point_0.Y);
      Vector vector = new Vector((double) point_1.X, (double) point_1.Y);
      // ISSUE: reference to a compiler-generated field
      class153.float_0 = 0.01f;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class153.double_0 = (class153.vector_1 - vector).Length;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class153.vector_0 = vector - class153.vector_1;
      // ISSUE: reference to a compiler-generated field
      class153.vector_0.Normalize();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class153.timer_0.Tick += new EventHandler(class153.method_0);
      // ISSUE: reference to a compiler-generated field
      class153.timer_0.Start();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pBox = new PictureBox();
      ((ISupportInitialize) this.pBox).BeginInit();
      this.SuspendLayout();
      this.pBox.Location = new System.Drawing.Point(92, 105);
      this.pBox.Name = "pBox";
      this.pBox.Size = new System.Drawing.Size(100, 50);
      this.pBox.TabIndex = 1;
      this.pBox.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add((Control) this.pBox);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (frmOverlay);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (frmOverlay);
      ((ISupportInitialize) this.pBox).EndInit();
      this.ResumeLayout(false);
    }
  }
}
