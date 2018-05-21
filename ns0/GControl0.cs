// Decompiled with JetBrains decompiler
// Type: ns0.GControl0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
  public class GControl0 : Control
  {
    private readonly Color color_0 = Color.DarkGray;
    private const int int_0 = 8;
    private const int int_1 = 10;
    private const int int_2 = 10;
    private const int int_3 = 4;
    private const int int_4 = 6;
    private const int int_5 = 9;
    private const int int_6 = 7;
    private const int int_7 = 4;
    private const int int_8 = 8;
    private const int int_9 = 24;
    private const int int_10 = 9;
    private const int int_11 = 4;
    private const int int_12 = 5;
    private const int int_13 = 12;
    private const int int_14 = 11;
    private const int int_15 = 2;
    private const double double_0 = 360.0;
    private const double double_1 = 180.0;
    private readonly Timer timer_0;
    private double[] double_2;
    private PointF pointF_0;
    private Color color_1;
    private Color[] color_2;
    private int int_16;
    private bool bool_0;
    private int int_17;
    private int int_18;
    private int int_19;
    private int int_20;
    private GControl0.GEnum8 genum8_0;
    private IContainer icontainer_0;

    public GControl0()
    {
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.ResizeRedraw, true);
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      this.color_1 = this.color_0;
      this.method_4();
      this.method_9();
      this.method_6();
      this.timer_0 = new Timer();
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.method_1();
      this.Resize += new EventHandler(this.GControl0_Resize);
    }

    [Category("LoadingCircle")]
    [Description("Gets or sets the number of spoke.")]
    public bool Boolean_0
    {
      get
      {
        return this.bool_0;
      }
      set
      {
        this.bool_0 = value;
        this.method_1();
      }
    }

    [Category("LoadingCircle")]
    [TypeConverter("System.Drawing.ColorConverter")]
    [Description("Sets the color of spoke.")]
    public Color Color_0
    {
      get
      {
        return this.color_1;
      }
      set
      {
        this.color_1 = value;
        this.method_4();
        this.Invalidate();
      }
    }

    [Category("LoadingCircle")]
    [Description("Gets or sets the radius of inner circle.")]
    public int Int32_0
    {
      get
      {
        if (this.int_16 == 0)
          this.int_16 = 8;
        return this.int_16;
      }
      set
      {
        this.int_16 = value;
        this.Invalidate();
      }
    }

    [Category("LoadingCircle")]
    [Description("Gets or sets the number of spoke.")]
    public int Int32_1
    {
      get
      {
        if (this.int_17 == 0)
          this.int_17 = 10;
        return this.int_17;
      }
      set
      {
        if (this.int_17 == value || this.int_17 <= 0)
          return;
        this.int_17 = value;
        this.method_4();
        this.method_9();
        this.Invalidate();
      }
    }

    [Description("Gets or sets the radius of outer circle.")]
    [Category("LoadingCircle")]
    public int Int32_2
    {
      get
      {
        if (this.int_18 == 0)
          this.int_18 = 10;
        return this.int_18;
      }
      set
      {
        this.int_18 = value;
        this.Invalidate();
      }
    }

    [Category("LoadingCircle")]
    [Description("Gets or sets the rotation speed. Higher the slower.")]
    public int Int32_3
    {
      get
      {
        return this.timer_0.Interval;
      }
      set
      {
        if (value <= 0)
          return;
        this.timer_0.Interval = value;
      }
    }

    [Description("Gets or sets the thickness of a spoke.")]
    [Category("LoadingCircle")]
    public int Int32_4
    {
      get
      {
        if (this.int_20 <= 0)
          this.int_20 = 4;
        return this.int_20;
      }
      set
      {
        this.int_20 = value;
        this.Invalidate();
      }
    }

    [DefaultValue(typeof (GControl0.GEnum8), "Custom")]
    [Category("LoadingCircle")]
    [Description("Quickly sets the style to one of these presets, or a custom style if desired")]
    public GControl0.GEnum8 GEnum8_0
    {
      get
      {
        return this.genum8_0;
      }
      set
      {
        this.genum8_0 = value;
        switch (this.genum8_0)
        {
          case GControl0.GEnum8.const_0:
            this.method_0(12, 2, 5, 11);
            break;
          case GControl0.GEnum8.const_1:
            this.method_0(9, 4, 6, 7);
            break;
          case GControl0.GEnum8.const_2:
            this.method_0(24, 4, 8, 9);
            break;
          case GControl0.GEnum8.const_3:
            this.method_0(10, 4, 8, 10);
            break;
        }
      }
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
      proposedSize.Width = (this.int_18 + this.int_20) * 2;
      return proposedSize;
    }

    public void method_0(int int_21, int int_22, int int_23, int int_24)
    {
      this.Int32_1 = int_21;
      this.Int32_4 = int_22;
      this.Int32_0 = int_23;
      this.Int32_2 = int_24;
      this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      if (this.int_17 <= 0)
        return;
      e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
      int num = this.int_19;
      for (int index1 = 0; index1 < this.int_17; ++index1)
      {
        int index2 = num % this.int_17;
        this.method_3(e.Graphics, this.method_8(this.pointF_0, this.int_16, this.double_2[index2]), this.method_8(this.pointF_0, this.int_18, this.double_2[index2]), this.color_2[index1], this.int_20);
        num = index2 + 1;
      }
    }

    private void method_1()
    {
      if (this.bool_0)
      {
        this.timer_0.Start();
      }
      else
      {
        this.timer_0.Stop();
        this.int_19 = 0;
      }
      this.method_4();
      this.Invalidate();
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      this.int_19 = ++this.int_19 % this.int_17;
      this.Invalidate();
    }

    private Color method_2(Color color_3, int int_21)
    {
      int r = (int) color_3.R;
      int g = (int) color_3.G;
      int b = (int) color_3.B;
      return Color.FromArgb(int_21, Math.Min(r, (int) byte.MaxValue), Math.Min(g, (int) byte.MaxValue), Math.Min(b, (int) byte.MaxValue));
    }

    private void method_3(Graphics graphics_0, PointF pointF_1, PointF pointF_2, Color color_3, int int_21)
    {
      using (Pen pen = new Pen((Brush) new SolidBrush(color_3), (float) int_21))
      {
        pen.StartCap = LineCap.Round;
        pen.EndCap = LineCap.Round;
        graphics_0.DrawLine(pen, pointF_1, pointF_2);
      }
    }

    private void method_4()
    {
      this.color_2 = this.method_5(this.color_1, this.Boolean_0, this.int_17);
    }

    private Color[] method_5(Color color_3, bool bool_1, int int_21)
    {
      Color[] colorArray = new Color[this.Int32_1];
      byte num1 = (byte) ((int) byte.MaxValue / this.Int32_1);
      byte num2 = 0;
      for (int index = 0; index < this.Int32_1; ++index)
      {
        if (bool_1)
        {
          if (index != 0 && index >= this.Int32_1 - int_21)
          {
            num2 += num1;
            if (num2 > byte.MaxValue)
              num2 = byte.MaxValue;
            colorArray[index] = this.method_2(color_3, (int) num2);
          }
          else
            colorArray[index] = color_3;
        }
        else
          colorArray[index] = color_3;
      }
      return colorArray;
    }

    private void method_6()
    {
      this.pointF_0 = this.method_7((Control) this);
    }

    private PointF method_7(Control control_0)
    {
      return new PointF((float) (control_0.Width / 2), (float) (control_0.Height / 2 - 1));
    }

    private PointF method_8(PointF pointF_1, int int_21, double double_3)
    {
      double num = Math.PI * double_3 / 180.0;
      return new PointF(pointF_1.X + (float) int_21 * (float) Math.Cos(num), pointF_1.Y + (float) int_21 * (float) Math.Sin(num));
    }

    private void method_9()
    {
      this.double_2 = this.method_10(this.Int32_1);
    }

    private double[] method_10(int int_21)
    {
      double[] numArray = new double[int_21];
      double num = 360.0 / (double) int_21;
      for (int index = 0; index < int_21; ++index)
        numArray[index] = index == 0 ? num : numArray[index - 1] + num;
      return numArray;
    }

    private void GControl0_Resize(object sender, EventArgs e)
    {
      this.method_6();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    public enum GEnum8
    {
      const_0,
      const_1,
      const_2,
      const_3,
    }
  }
}
