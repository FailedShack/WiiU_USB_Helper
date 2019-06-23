using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020001B4 RID: 436
	public partial class GForm1 : Form
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x000187F7 File Offset: 0x000169F7
		public GForm1(float float_0, IntPtr intptr_1, Color color_0, bool bool_2) : this()
		{
			base.Opacity = (double)float_0;
			this.BackColor = color_0;
			this.intptr_0 = intptr_1;
			if (bool_2)
			{
				base.TransparencyKey = color_0;
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00018820 File Offset: 0x00016A20
		public GForm1()
		{
			this.DoubleBuffered = true;
			base.ShowInTaskbar = false;
			base.FormBorderStyle = FormBorderStyle.None;
			base.StartPosition = FormStartPosition.Manual;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0004B28C File Offset: 0x0004948C
		public static bool smethod_0(IntPtr intptr_1)
		{
			if (intptr_1 == IntPtr.Zero)
			{
				return true;
			}
			HashSet<IntPtr> hashSet = new HashSet<IntPtr>
			{
				intptr_1
			};
			GForm1.Struct2 @struct;
			GForm1.GetWindowRect(intptr_1, out @struct);
			while ((intptr_1 = GForm1.GetWindow(intptr_1, 3)) != IntPtr.Zero && !hashSet.Contains(intptr_1))
			{
				hashSet.Add(intptr_1);
				GForm1.Struct2 struct2;
				GForm1.Struct2 struct3;
				if (GForm1.IsWindowVisible(intptr_1) && GForm1.GetWindowRect(intptr_1, out struct2) && GForm1.IntersectRect(out struct3, ref @struct, ref struct2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0004B310 File Offset: 0x00049510
		public void method_0()
		{
			try
			{
				this.bool_0 = true;
				base.Invoke(new MethodInvoker(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001884F File Offset: 0x00016A4F
		public void method_1()
		{
			Application.DoEvents();
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0004B350 File Offset: 0x00049550
		public void method_2(int int_1)
		{
			this.dateTime_0 = DateTime.Now.AddMilliseconds((double)int_1);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00018856 File Offset: 0x00016A56
		public void method_3()
		{
			this.dateTime_0 = DateTime.MaxValue;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00018863 File Offset: 0x00016A63
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			this.bool_0 = true;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00018875 File Offset: 0x00016A75
		protected override void OnClosing(CancelEventArgs e)
		{
			this.timer_0.Dispose();
			base.OnClosing(e);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00018889 File Offset: 0x00016A89
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			this.timer_0 = new System.Threading.Timer(new TimerCallback(this.method_5), null, 0, 1);
		}

		// Token: 0x06000C11 RID: 3089
		[DllImport("user32.dll")]
		private static extern IntPtr GetWindow(IntPtr intptr_1, int int_1);

		// Token: 0x06000C12 RID: 3090
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetWindowRect(IntPtr intptr_1, out GForm1.Struct2 struct2_0);

		// Token: 0x06000C13 RID: 3091
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IntersectRect(out GForm1.Struct2 struct2_0, [In] ref GForm1.Struct2 struct2_1, [In] ref GForm1.Struct2 struct2_2);

		// Token: 0x06000C14 RID: 3092
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsWindowVisible(IntPtr intptr_1);

		// Token: 0x06000C15 RID: 3093 RVA: 0x0004B374 File Offset: 0x00049574
		private void method_4()
		{
			try
			{
				if (this.bool_0)
				{
					this.timer_0.Dispose();
					base.Close();
				}
				base.Invoke(new MethodInvoker(this.method_6));
			}
			catch
			{
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000188AC File Offset: 0x00016AAC
		[CompilerGenerated]
		private void method_5(object object_0)
		{
			this.method_4();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0004B3C4 File Offset: 0x000495C4
		[CompilerGenerated]
		private void method_6()
		{
			if (!(DateTime.Now < this.dateTime_0) || !(this.intptr_0 != IntPtr.Zero) || !GClass18.IsWindowVisible(this.intptr_0))
			{
				base.Size = new Size(0, 0);
				return;
			}
			base.TopMost = true;
			GClass18.GStruct1 gstruct = default(GClass18.GStruct1);
			GClass18.GStruct1 gstruct2 = default(GClass18.GStruct1);
			GClass18.GetWindowRect(this.intptr_0, ref gstruct);
			GClass18.GetClientRect(this.intptr_0, out gstruct2);
			base.Location = new Point(gstruct.int_0 + (gstruct.Int32_0 - gstruct2.Int32_0) / 2, gstruct.int_1 + (gstruct.Int32_1 - gstruct2.Int32_1));
			base.Size = new Size(gstruct2.Int32_0, gstruct2.Int32_1);
		}

		// Token: 0x0400078F RID: 1935
		private const int int_0 = 3;

		// Token: 0x04000790 RID: 1936
		private IntPtr intptr_0;

		// Token: 0x04000791 RID: 1937
		private volatile bool bool_0;

		// Token: 0x04000792 RID: 1938
		private DateTime dateTime_0 = DateTime.MaxValue;

		// Token: 0x04000793 RID: 1939
		private bool bool_1;

		// Token: 0x04000794 RID: 1940
		private System.Threading.Timer timer_0;

		// Token: 0x020001B5 RID: 437
		private struct Struct2
		{
			// Token: 0x04000795 RID: 1941
			public int int_0;

			// Token: 0x04000796 RID: 1942
			public int int_1;

			// Token: 0x04000797 RID: 1943
			public int int_2;

			// Token: 0x04000798 RID: 1944
			public int int_3;
		}
	}
}
