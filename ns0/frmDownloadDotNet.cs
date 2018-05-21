// Decompiled with JetBrains decompiler
// Type: ns0.frmDownloadDotNet
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
  public class frmDownloadDotNet : Form
  {
    private IContainer icontainer_0;
    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;

    public frmDownloadDotNet()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=55170");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pictureBox1 = new PictureBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.button1 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.pictureBox1.ErrorImage = (Image) null;
      this.pictureBox1.Image = (Image) Class123.error;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(131, 134);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(152, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(316, 33);
      this.label1.TabIndex = 1;
      this.label1.Text = "An error has occured.";
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.Black;
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(155, 61);
      this.label2.Name = "label2";
      this.label2.Size = new Size(302, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "The application was unable to find some required components.";
      this.label3.AutoSize = true;
      this.label3.BackColor = Color.Black;
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(155, 85);
      this.label3.Name = "label3";
      this.label3.Size = new Size(311, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Please make sure you have installed the required dependencies.";
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.button1.Location = new Point(217, 122);
      this.button1.Name = "button1";
      this.button1.Size = new Size(179, 24);
      this.button1.TabIndex = 4;
      this.button1.Text = "Install .NET";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(502, 162);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmDownloadDotNet);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "An error has occured";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
