// Decompiled with JetBrains decompiler
// Type: ns0.frmHelpOverlay
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmHelpOverlay : GForm1
  {
    private int int_2 = -1;
    private const int int_1 = 50;
    private Point point_0;
    private IContainer icontainer_0;
    private Label label1;
    private PictureBox pictArrow;
    private RadButton btnGotcha;
    private Timer timer_1;

    public frmHelpOverlay(IntPtr intptr_1, Point? nullable_0, string string_0, int int_3)
      : base(0.85f, intptr_1, Color.Black, false)
    {
      this.InitializeComponent();
      this.label1.Text = string_0;
      if (!nullable_0.HasValue)
        this.pictArrow.Visible = false;
      else
        this.pictArrow.Location = new Point(nullable_0.Value.X - this.pictArrow.Width, nullable_0.Value.Y - this.pictArrow.Height / 2);
      if (int_3 > 0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmHelpOverlay.Class145 class145 = new frmHelpOverlay.Class145();
        // ISSUE: reference to a compiler-generated field
        class145.frmHelpOverlay_0 = this;
        // ISSUE: reference to a compiler-generated field
        class145.timer_0 = new Timer()
        {
          Interval = int_3 * 1000
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class145.timer_0.Tick += new EventHandler(class145.method_0);
        // ISSUE: reference to a compiler-generated field
        class145.timer_0.Start();
      }
      this.point_0 = this.pictArrow.Location;
    }

    private void btnGotcha_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void timer_1_Tick(object sender, EventArgs e)
    {
      this.pictArrow.Left += this.int_2 * 7;
      if (!(this.point_0.X - this.pictArrow.Left > 50 | this.point_0.X - this.pictArrow.Left < 0))
        return;
      this.int_2 *= -1;
    }

    private void method_7(object sender, EventArgs e)
    {
      this.Close();
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
      this.label1 = new Label();
      this.pictArrow = new PictureBox();
      this.btnGotcha = new RadButton();
      this.timer_1 = new Timer(this.icontainer_0);
      ((ISupportInitialize) this.pictArrow).BeginInit();
      this.btnGotcha.BeginInit();
      this.SuspendLayout();
      this.label1.BackColor = Color.Transparent;
      this.label1.Dock = DockStyle.Fill;
      this.label1.Font = new Font("Microsoft Sans Serif", 51.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(1357, 789);
      this.label1.TabIndex = 0;
      this.label1.Text = "_";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.pictArrow.Image = (Image) Class123.imgArrow;
      this.pictArrow.Location = new Point(62, 49);
      this.pictArrow.Name = "pictArrow";
      this.pictArrow.Size = new Size(200, 200);
      this.pictArrow.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictArrow.TabIndex = 1;
      this.pictArrow.TabStop = false;
      this.btnGotcha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnGotcha.Location = new Point(1139, 728);
      this.btnGotcha.Name = "btnGotcha";
      this.btnGotcha.Size = new Size(206, 49);
      this.btnGotcha.TabIndex = 2;
      this.btnGotcha.Text = "Gotcha!";
      this.btnGotcha.Click += new EventHandler(this.btnGotcha_Click);
      this.timer_1.Enabled = true;
      this.timer_1.Interval = 33;
      this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1357, 789);
      this.Controls.Add((Control) this.btnGotcha);
      this.Controls.Add((Control) this.pictArrow);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (frmHelpOverlay);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (frmHelpOverlay);
      ((ISupportInitialize) this.pictArrow).EndInit();
      this.btnGotcha.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
