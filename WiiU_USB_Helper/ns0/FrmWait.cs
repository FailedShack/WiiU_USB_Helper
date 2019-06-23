using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001C9 RID: 457
	public partial class FrmWait : RadForm
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x0004F820 File Offset: 0x0004DA20
		public FrmWait(string string_1, bool bool_1)
		{
			this.int_2 = -1;
			this.int_3 = 4;
			this.privateFontCollection_0 = new PrivateFontCollection();
			base..ctor();
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
			this.lblMessage.Text = string_1;
			if (bool_1)
			{
				base.Size = new Size(293, 195);
			}
			else
			{
				base.Size = new Size(293, 165);
			}
			this.timer_0 = new Timer
			{
				Interval = 1000
			};
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_0.Start();
			FrmWait.smethod_1(this);
			this.method_1(true);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00018B61 File Offset: 0x00016D61
		public FrmWait(string string_1, Action action_0, Action<Exception> action_1)
		{
			FrmWait.Class156 @class = new FrmWait.Class156();
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			this..ctor(string_1, false);
			@class.frmWait_0 = this;
			Task.Run(new Action(@class.method_0));
			base.ShowDialog();
		}

		// Token: 0x06000C75 RID: 3189
		[DllImport("gdi32.dll")]
		public static extern IntPtr AddFontMemResourceEx(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, [In] ref uint uint_1);

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004F8DC File Offset: 0x0004DADC
		public void method_0()
		{
			this.bool_0 = true;
			try
			{
				base.BeginInvoke(new Action(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0004F91C File Offset: 0x0004DB1C
		public void method_1(bool bool_1)
		{
			FrmWait.Class157 @class = new FrmWait.Class157();
			@class.frmWait_0 = this;
			@class.bool_0 = bool_1;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0004F968 File Offset: 0x0004DB68
		public void method_2(int int_5)
		{
			FrmWait.Class158 @class = new FrmWait.Class158();
			@class.int_0 = int_5;
			@class.frmWait_0 = this;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		private static Color smethod_0(Color color_2, float float_0)
		{
			float num = (float)color_2.R;
			float num2 = (float)color_2.G;
			float num3 = (float)color_2.B;
			if (float_0 < 0f)
			{
				float_0 = 1f + float_0;
				num *= float_0;
				num2 *= float_0;
				num3 *= float_0;
			}
			else
			{
				num = (255f - num) * float_0 + num;
				num2 = (255f - num2) * float_0 + num2;
				num3 = (255f - num3) * float_0 + num3;
			}
			return Color.FromArgb((int)color_2.A, (int)num, (int)num2, (int)num3);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0004FA34 File Offset: 0x0004DC34
		private static void smethod_1(FrmWait frmWait_0)
		{
			object obj = FrmWait.object_0;
			lock (obj)
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

		// Token: 0x06000C7B RID: 3195 RVA: 0x0004FABC File Offset: 0x0004DCBC
		private static void smethod_2(FrmWait frmWait_0)
		{
			object obj = FrmWait.object_0;
			lock (obj)
			{
				if (FrmWait.list_0.Contains(frmWait_0))
				{
					FrmWait.list_0.Remove(frmWait_0);
				}
				if (FrmWait.list_0.Count > 0)
				{
					try
					{
						FrmWait.list_0.Last<FrmWait>().method_1(true);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0004FB40 File Offset: 0x0004DD40
		private void method_3()
		{
			this.int_0++;
			if (this.int_0 == this.list_1.Count)
			{
				this.int_0 = 0;
			}
			if (this.list_1[this.int_0].Text == " ")
			{
				this.method_3();
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
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

		// Token: 0x06000C7E RID: 3198 RVA: 0x0004FBF4 File Offset: 0x0004DDF4
		private void FrmWait_Load(object sender, EventArgs e)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
			this.timer_1.Interval = 20;
			this.color_0 = this.radProgressBar1.ProgressBarElement.IndicatorElement1.BackColor;
			this.color_1 = FrmWait.smethod_0(this.color_0, 0.3f);
			this.timer_1.Start();
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0004FC60 File Offset: 0x0004DE60
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
			byte[] contb = Class121.contb;
			IntPtr intPtr = Marshal.AllocCoTaskMem(contb.Length);
			Marshal.Copy(contb, 0, intPtr, contb.Length);
			uint num = 0u;
			this.privateFontCollection_0.AddMemoryFont(intPtr, Class121.contb.Length);
			FrmWait.AddFontMemResourceEx(intPtr, (uint)Class121.contb.Length, IntPtr.Zero, ref num);
			Marshal.FreeCoTaskMem(intPtr);
			this.font_0 = new Font(this.privateFontCollection_0.Families[0], 16f);
			using (Graphics graphics = base.CreateGraphics())
			{
				SizeF sizeF = base.CreateGraphics().MeasureString("WiiU USB Helper", this.font_0);
				float num2 = (float)(this.loadingCircle1.Height / 2) - sizeF.Height / 2f;
				this.list_1 = new List<RadLabel>();
				List<SizeF> list = new List<SizeF>();
				string text = "WiiU USB Helper";
				for (int i = 0; i < text.Length; i++)
				{
					list.Add(graphics.MeasureString(text[i].ToString(), this.font_0));
				}
				float num3 = (float)(base.Width / 2) - list.Sum(new Func<SizeF, float>(FrmWait.<>c.<>c_0.method_0)) / 2f;
				int num4 = 0;
				foreach (char c in "WiiU USB Helper")
				{
					RadLabel radLabel = new RadLabel
					{
						Text = c.ToString(),
						Font = this.font_0,
						AutoSize = false,
						ForeColor = this.color_0,
						BackColor = Color.Transparent
					};
					radLabel.Left = (int)num3;
					num3 += list[num4].Width;
					radLabel.Top = (int)num2;
					radLabel.Size = new Size((int)list[num4].Width, (int)list[num4].Height);
					base.Controls.Add(radLabel);
					radLabel.Parent = this.loadingCircle1;
					this.list_1.Add(radLabel);
					radLabel.BringToFront();
					num4++;
				}
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000142A3 File Offset: 0x000124A3
		private void FrmWait_SizeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0004FF5C File Offset: 0x0004E15C
		private void lblMessage_SizeChanged(object sender, EventArgs e)
		{
			this.lblMessage.Location = new Point(base.Width / 2 - this.lblMessage.Width / 2, this.lblMessage.Location.Y);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		private void loadingCircle1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(this.BackColor);
			e.Graphics.DrawImage(Class121.helperLoagBg, new Rectangle(0, 0, base.Width, base.Height), new Rectangle(this.int_1 * -1, this.int_1 * -1, base.Width, base.Height), GraphicsUnit.Pixel);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00050008 File Offset: 0x0004E208
		private void timer_1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.int_1--;
				if (this.int_1 * -1 >= Class121.helperLoagBg.Width / 4)
				{
					this.int_1 = 0;
				}
				RadLabel radLabel = this.list_1[this.int_0];
				if (this.int_2 != this.int_0)
				{
					this.int_3 *= -1;
					this.int_4 = radLabel.Top;
					radLabel.ForeColor = this.color_1;
					if (this.int_0 > 0)
					{
						this.list_1[this.int_0 - 1].LabelElement.Opacity = 0.75;
					}
					this.int_2 = this.int_0;
				}
				radLabel.Top += this.int_3;
				if (this.int_4 - radLabel.Top > 6)
				{
					this.int_3 *= -1;
				}
				if (this.int_4 == radLabel.Top)
				{
					radLabel.Font = this.font_0;
					if (this.int_0 > 0)
					{
						this.list_1[this.int_0 - 1].LabelElement.Opacity = 1.0;
					}
					radLabel.ForeColor = this.color_0;
					this.method_3();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00018BD2 File Offset: 0x00016DD2
		[CompilerGenerated]
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.method_0();
			}
		}

		// Token: 0x04000826 RID: 2086
		private const string string_0 = "WiiU USB Helper";

		// Token: 0x04000827 RID: 2087
		private static List<FrmWait> list_0 = new List<FrmWait>();

		// Token: 0x04000828 RID: 2088
		private static object object_0 = new object();

		// Token: 0x04000829 RID: 2089
		private volatile bool bool_0;

		// Token: 0x0400082A RID: 2090
		private Color color_0;

		// Token: 0x0400082B RID: 2091
		private Color color_1;

		// Token: 0x0400082C RID: 2092
		private Font font_0;

		// Token: 0x0400082D RID: 2093
		private int int_0;

		// Token: 0x0400082E RID: 2094
		private int int_1;

		// Token: 0x0400082F RID: 2095
		private List<RadLabel> list_1;

		// Token: 0x04000830 RID: 2096
		private int int_2;

		// Token: 0x04000831 RID: 2097
		private Point point_0;

		// Token: 0x04000832 RID: 2098
		private int int_3;

		// Token: 0x04000833 RID: 2099
		private int int_4;

		// Token: 0x04000834 RID: 2100
		private Timer timer_0;

		// Token: 0x04000835 RID: 2101
		private PrivateFontCollection privateFontCollection_0;

		// Token: 0x020001CA RID: 458
		[CompilerGenerated]
		private sealed class Class156
		{
			// Token: 0x06000C88 RID: 3208 RVA: 0x000504CC File Offset: 0x0004E6CC
			internal void method_0()
			{
				try
				{
					this.action_0();
				}
				catch (Exception obj)
				{
					Action<Exception> action = this.action_1;
					if (action != null)
					{
						action(obj);
					}
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x0400083B RID: 2107
			public Action action_0;

			// Token: 0x0400083C RID: 2108
			public Action<Exception> action_1;

			// Token: 0x0400083D RID: 2109
			public FrmWait frmWait_0;
		}

		// Token: 0x020001CB RID: 459
		[CompilerGenerated]
		private sealed class Class157
		{
			// Token: 0x06000C8A RID: 3210 RVA: 0x00050518 File Offset: 0x0004E718
			internal void method_0()
			{
				this.frmWait_0.loadingCircle1.Visible = this.bool_0;
				if (this.bool_0)
				{
					this.frmWait_0.WindowState = FormWindowState.Normal;
					this.frmWait_0.Activate();
					return;
				}
				this.frmWait_0.WindowState = FormWindowState.Minimized;
			}

			// Token: 0x0400083E RID: 2110
			public FrmWait frmWait_0;

			// Token: 0x0400083F RID: 2111
			public bool bool_0;
		}

		// Token: 0x020001CC RID: 460
		[CompilerGenerated]
		private sealed class Class158
		{
			// Token: 0x06000C8C RID: 3212 RVA: 0x00018BE4 File Offset: 0x00016DE4
			internal void method_0()
			{
				if (this.int_0 < 0)
				{
					this.int_0 = 0;
				}
				if (this.int_0 > 100)
				{
					this.int_0 = 100;
				}
				this.frmWait_0.radProgressBar1.Value1 = this.int_0;
			}

			// Token: 0x04000840 RID: 2112
			public int int_0;

			// Token: 0x04000841 RID: 2113
			public FrmWait frmWait_0;
		}
	}
}
