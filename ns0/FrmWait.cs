// Decompiled with JetBrains decompiler
// Type: ns0.FrmWait
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmWait : RadForm
  {
    private static List<FrmWait> list_0 = new List<FrmWait>();
    private static object object_0 = new object();
    private int int_2 = -1;
    private int int_3 = 4;
    private PrivateFontCollection privateFontCollection_0 = new PrivateFontCollection();
    private const string string_0 = "WiiU USB Helper";
    private volatile bool bool_0;
    private Color color_0;
    private Color color_1;
    private Font font_0;
    private int int_0;
    private int int_1;
    private List<RadLabel> list_1;
    private Point point_0;
    private int int_4;
    private Timer timer_0;
    private IContainer icontainer_0;
    private RadLabel lblMessage;
    private RadProgressBar radProgressBar1;
    private Timer timer_1;
    private GControl0 loadingCircle1;

    public FrmWait(string string_1, bool bool_1)
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
      this.lblMessage.Text = string_1;
      if (bool_1)
        this.Size = new Size(293, 195);
      else
        this.Size = new Size(293, 165);
      this.timer_0 = new Timer() { Interval = 1000 };
      this.timer_0.Tick += (EventHandler) ((sender, e) =>
      {
        if (!this.bool_0)
          return;
        this.method_0();
      });
      this.timer_0.Start();
      FrmWait.smethod_1(this);
      this.method_1(true);
    }

    public FrmWait(string string_1, Action action_0, Action<Exception> action_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FrmWait.Class158 class158 = new FrmWait.Class158();
      // ISSUE: reference to a compiler-generated field
      class158.action_0 = action_0;
      // ISSUE: reference to a compiler-generated field
      class158.action_1 = action_1;
      // ISSUE: explicit constructor call
      this.\u002Ector(string_1, false);
      // ISSUE: reference to a compiler-generated field
      class158.frmWait_0 = this;
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class158.method_0));
      int num = (int) this.ShowDialog();
    }

    [DllImport("gdi32.dll")]
    public static extern IntPtr AddFontMemResourceEx(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, [In] ref uint uint_1);

    public void method_0()
    {
      this.bool_0 = true;
      try
      {
        this.BeginInvoke((Delegate) new Action(((Form) this).Close));
      }
      catch
      {
      }
    }

    public void method_1(bool bool_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FrmWait.Class159 class159 = new FrmWait.Class159();
      // ISSUE: reference to a compiler-generated field
      class159.frmWait_0 = this;
      // ISSUE: reference to a compiler-generated field
      class159.bool_0 = bool_1;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class159.method_0));
      }
      catch
      {
      }
    }

    public void method_2(int int_5)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FrmWait.Class160 class160 = new FrmWait.Class160();
      // ISSUE: reference to a compiler-generated field
      class160.int_0 = int_5;
      // ISSUE: reference to a compiler-generated field
      class160.frmWait_0 = this;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class160.method_0));
      }
      catch
      {
      }
    }

    private static Color smethod_0(Color color_2, float float_0)
    {
      float r = (float) color_2.R;
      float g = (float) color_2.G;
      float b = (float) color_2.B;
      float num1;
      float num2;
      float num3;
      if ((double) float_0 < 0.0)
      {
        float_0 = 1f + float_0;
        num1 = r * float_0;
        num2 = g * float_0;
        num3 = b * float_0;
      }
      else
      {
        num1 = ((float) byte.MaxValue - r) * float_0 + r;
        num2 = ((float) byte.MaxValue - g) * float_0 + g;
        num3 = ((float) byte.MaxValue - b) * float_0 + b;
      }
      return Color.FromArgb((int) color_2.A, (int) num1, (int) num2, (int) num3);
    }

    private static void smethod_1(FrmWait frmWait_0)
    {
      lock (FrmWait.object_0)
      {
        foreach (FrmWait frmWait in FrmWait.list_0.ToArray())
        {
          try
          {
            frmWait.method_1(false);
          }
          catch
          {
            FrmWait.list_0.Remove(frmWait);
          }
        }
        FrmWait.list_0.Add(frmWait_0);
      }
    }

    private static void smethod_2(FrmWait frmWait_0)
    {
      lock (FrmWait.object_0)
      {
        if (FrmWait.list_0.Contains(frmWait_0))
          FrmWait.list_0.Remove(frmWait_0);
        if (FrmWait.list_0.Count <= 0)
          return;
        try
        {
          FrmWait.list_0.Last<FrmWait>().method_1(true);
        }
        catch
        {
        }
      }
    }

    private void method_3()
    {
      ++this.int_0;
      if (this.int_0 == this.list_1.Count)
        this.int_0 = 0;
      if (!(this.list_1[this.int_0].Text == " "))
        return;
      this.method_3();
    }

    private void FrmWait_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.timer_0.Stop();
      this.timer_1.Stop();
      try
      {
        this.font_0.Dispose();
        this.privateFontCollection_0.Dispose();
        FrmWait.smethod_2(this);
      }
      catch
      {
      }
    }

    private void FrmWait_Load(object sender, EventArgs e)
    {
      this.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
      this.timer_1.Interval = 20;
      this.color_0 = this.radProgressBar1.ProgressBarElement.IndicatorElement1.BackColor;
      this.color_1 = FrmWait.smethod_0(this.color_0, 0.3f);
      this.timer_1.Start();
    }

    private void FrmWait_Shown(object sender, EventArgs e)
    {
      this.loadingCircle1.GEnum8_0 = GControl0.GEnum8.const_2;
      this.loadingCircle1.Color_0 = this.color_0;
      this.loadingCircle1.BackColor = Color.Transparent;
      this.loadingCircle1.Boolean_0 = true;
      this.loadingCircle1.Int32_0 = 20;
      this.loadingCircle1.Int32_2 = 30;
      this.loadingCircle1.Int32_1 = 40;
      this.loadingCircle1.Int32_4 = 2;
      this.loadingCircle1.Int32_3 = 60;
      this.loadingCircle1.SendToBack();
      this.point_0 = this.loadingCircle1.Location;
      byte[] contb = Class123.contb;
      IntPtr num1 = Marshal.AllocCoTaskMem(contb.Length);
      Marshal.Copy(contb, 0, num1, contb.Length);
      uint uint_1 = 0;
      this.privateFontCollection_0.AddMemoryFont(num1, Class123.contb.Length);
      FrmWait.AddFontMemResourceEx(num1, (uint) Class123.contb.Length, IntPtr.Zero, ref uint_1);
      Marshal.FreeCoTaskMem(num1);
      this.font_0 = new Font(this.privateFontCollection_0.Families[0], 16f);
      using (Graphics graphics = this.CreateGraphics())
      {
        float num2 = (float) (this.loadingCircle1.Height / 2) - this.CreateGraphics().MeasureString("WiiU USB Helper", this.font_0).Height / 2f;
        this.list_1 = new List<RadLabel>();
        List<SizeF> source = new List<SizeF>();
        foreach (char ch in "WiiU USB Helper")
          source.Add(graphics.MeasureString(ch.ToString(), this.font_0));
        float num3 = (float) (this.Width / 2) - source.Sum<SizeF>((Func<SizeF, float>) (sizeF_0 => sizeF_0.Width)) / 2f;
        int index = 0;
        foreach (char ch in "WiiU USB Helper")
        {
          RadLabel radLabel1 = new RadLabel();
          radLabel1.Text = ch.ToString();
          radLabel1.Font = this.font_0;
          radLabel1.AutoSize = false;
          radLabel1.ForeColor = this.color_0;
          radLabel1.BackColor = Color.Transparent;
          RadLabel radLabel2 = radLabel1;
          radLabel2.Left = (int) num3;
          double num4 = (double) num3;
          SizeF sizeF = source[index];
          double width1 = (double) sizeF.Width;
          num3 = (float) (num4 + width1);
          radLabel2.Top = (int) num2;
          RadLabel radLabel3 = radLabel2;
          sizeF = source[index];
          int width2 = (int) sizeF.Width;
          sizeF = source[index];
          int height = (int) sizeF.Height;
          Size size = new Size(width2, height);
          radLabel3.Size = size;
          this.Controls.Add((Control) radLabel2);
          radLabel2.Parent = (Control) this.loadingCircle1;
          this.list_1.Add(radLabel2);
          radLabel2.BringToFront();
          ++index;
        }
      }
    }

    private void FrmWait_SizeChanged(object sender, EventArgs e)
    {
    }

    private void lblMessage_SizeChanged(object sender, EventArgs e)
    {
      this.lblMessage.Location = new Point(this.Width / 2 - this.lblMessage.Width / 2, this.lblMessage.Location.Y);
    }

    private void loadingCircle1_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.Clear(this.BackColor);
      e.Graphics.DrawImage((Image) Class123.helperLoagBg, new Rectangle(0, 0, this.Width, this.Height), new Rectangle(this.int_1 * -1, this.int_1 * -1, this.Width, this.Height), GraphicsUnit.Pixel);
    }

    private void timer_1_Tick(object sender, EventArgs e)
    {
      try
      {
        --this.int_1;
        if (this.int_1 * -1 >= Class123.helperLoagBg.Width / 4)
          this.int_1 = 0;
        RadLabel radLabel = this.list_1[this.int_0];
        if (this.int_2 != this.int_0)
        {
          this.int_3 *= -1;
          this.int_4 = radLabel.Top;
          radLabel.ForeColor = this.color_1;
          if (this.int_0 > 0)
            this.list_1[this.int_0 - 1].LabelElement.Opacity = 0.75;
          this.int_2 = this.int_0;
        }
        radLabel.Top += this.int_3;
        if (this.int_4 - radLabel.Top > 6)
          this.int_3 *= -1;
        if (this.int_4 != radLabel.Top)
          return;
        radLabel.Font = this.font_0;
        if (this.int_0 > 0)
          this.list_1[this.int_0 - 1].LabelElement.Opacity = 1.0;
        radLabel.ForeColor = this.color_0;
        this.method_3();
      }
      catch
      {
      }
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
      this.lblMessage = new RadLabel();
      this.radProgressBar1 = new RadProgressBar();
      this.timer_1 = new Timer(this.icontainer_0);
      this.loadingCircle1 = new GControl0();
      this.lblMessage.BeginInit();
      this.radProgressBar1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.lblMessage.BackColor = Color.Transparent;
      this.lblMessage.Location = new Point(111, 111);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new Size(62, 18);
      this.lblMessage.TabIndex = 0;
      this.lblMessage.Text = "lblMessage";
      this.lblMessage.SizeChanged += new EventHandler(this.lblMessage_SizeChanged);
      this.radProgressBar1.Location = new Point(3, 133);
      this.radProgressBar1.Name = "radProgressBar1";
      this.radProgressBar1.ShowProgressIndicators = true;
      this.radProgressBar1.Size = new Size(282, 24);
      this.radProgressBar1.TabIndex = 2;
      this.radProgressBar1.Text = "0 %";
      this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
      this.loadingCircle1.Boolean_0 = false;
      this.loadingCircle1.BackColor = Color.Transparent;
      this.loadingCircle1.Color_0 = Color.DarkGray;
      this.loadingCircle1.Int32_0 = 5;
      this.loadingCircle1.Location = new Point(-3, 0);
      this.loadingCircle1.Name = "loadingCircle1";
      this.loadingCircle1.Int32_1 = 12;
      this.loadingCircle1.Int32_2 = 11;
      this.loadingCircle1.Int32_3 = 200;
      this.loadingCircle1.Size = new Size(293, 129);
      this.loadingCircle1.Int32_4 = 2;
      this.loadingCircle1.GEnum8_0 = GControl0.GEnum8.const_0;
      this.loadingCircle1.TabIndex = 3;
      this.loadingCircle1.Text = "loadingCircle1";
      this.loadingCircle1.Paint += new PaintEventHandler(this.loadingCircle1_Paint);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(285, 129);
      this.Controls.Add((Control) this.loadingCircle1);
      this.Controls.Add((Control) this.radProgressBar1);
      this.Controls.Add((Control) this.lblMessage);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmWait);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Please wait";
      this.FormClosing += new FormClosingEventHandler(this.FrmWait_FormClosing);
      this.Load += new EventHandler(this.FrmWait_Load);
      this.Shown += new EventHandler(this.FrmWait_Shown);
      this.SizeChanged += new EventHandler(this.FrmWait_SizeChanged);
      this.lblMessage.EndInit();
      this.radProgressBar1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
