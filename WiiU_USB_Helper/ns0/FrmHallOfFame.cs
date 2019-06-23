using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001B9 RID: 441
	public partial class FrmHallOfFame : RadForm
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x000189D4 File Offset: 0x00016BD4
		public FrmHallOfFame()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000C33 RID: 3123
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetScrollInfo(IntPtr intptr_0, int int_8, ref FrmHallOfFame.Struct3 struct3_0);

		// Token: 0x06000C34 RID: 3124 RVA: 0x0004CEA4 File Offset: 0x0004B0A4
		private static void smethod_0(IntPtr intptr_0, int int_8)
		{
			FrmHallOfFame.Struct3 @struct = default(FrmHallOfFame.Struct3);
			@struct.uint_0 = (uint)Marshal.SizeOf(@struct);
			@struct.uint_1 = 23u;
			FrmHallOfFame.GetScrollInfo(intptr_0, 1, ref @struct);
			@struct.int_2 += int_8;
			FrmHallOfFame.SetScrollInfo(intptr_0, 1, ref @struct, true);
			IntPtr intptr_ = new IntPtr(5 + 65536 * @struct.int_2);
			IntPtr intptr_2 = new IntPtr(0);
			FrmHallOfFame.SendMessage(intptr_0, 277u, intptr_, intptr_2);
		}

		// Token: 0x06000C35 RID: 3125
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x06000C36 RID: 3126
		[DllImport("user32.dll")]
		private static extern int SetScrollInfo(IntPtr intptr_0, int int_8, [In] ref FrmHallOfFame.Struct3 struct3_0, bool bool_0);

		// Token: 0x06000C37 RID: 3127 RVA: 0x0004CF20 File Offset: 0x0004B120
		private void FrmHallOfFame_Load(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			this.txtFame.BackColor = this.BackColor;
			foreach (string text in new GClass78().method_6(string.Format("{0}/getContributors.php", Class65.String_3)).Split(new char[]
			{
				'\n'
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				if (text.Substring(0, 1) == "!")
				{
					text = text.Substring(1);
					list.Add(text);
				}
				RichTextBox richTextBox = this.txtFame;
				richTextBox.Text = richTextBox.Text + text + "\n";
			}
			foreach (string str in list)
			{
				this.txtFame.Find(str);
				this.txtFame.SelectionColor = Color.Gold;
			}
			this.txtFame.SelectAll();
			this.txtFame.SelectionAlignment = HorizontalAlignment.Center;
			this.timer_0.Start();
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000189E2 File Offset: 0x00016BE2
		private void timer_0_Tick(object sender, EventArgs e)
		{
			FrmHallOfFame.smethod_0(this.txtFame.Handle, 2);
		}

		// Token: 0x040007C7 RID: 1991
		private const int int_0 = 7;

		// Token: 0x040007C8 RID: 1992
		private const int int_1 = 8;

		// Token: 0x040007C9 RID: 1993
		private const int int_2 = 1;

		// Token: 0x040007CA RID: 1994
		private const int int_3 = 0;

		// Token: 0x040007CB RID: 1995
		private const int int_4 = 4;

		// Token: 0x040007CC RID: 1996
		private const int int_5 = 5;

		// Token: 0x040007CD RID: 1997
		private const int int_6 = 6;

		// Token: 0x040007CE RID: 1998
		private const int int_7 = 277;

		// Token: 0x020001BA RID: 442
		private enum Enum5
		{
			// Token: 0x040007D5 RID: 2005
			const_0,
			// Token: 0x040007D6 RID: 2006
			const_1,
			// Token: 0x040007D7 RID: 2007
			const_2,
			// Token: 0x040007D8 RID: 2008
			const_3
		}

		// Token: 0x020001BB RID: 443
		private enum Enum6
		{
			// Token: 0x040007DA RID: 2010
			const_0 = 1,
			// Token: 0x040007DB RID: 2011
			const_1,
			// Token: 0x040007DC RID: 2012
			const_2 = 4,
			// Token: 0x040007DD RID: 2013
			const_3 = 8,
			// Token: 0x040007DE RID: 2014
			const_4 = 16,
			// Token: 0x040007DF RID: 2015
			const_5 = 23
		}

		// Token: 0x020001BC RID: 444
		private struct Struct3
		{
			// Token: 0x040007E0 RID: 2016
			public uint uint_0;

			// Token: 0x040007E1 RID: 2017
			public uint uint_1;

			// Token: 0x040007E2 RID: 2018
			public int int_0;

			// Token: 0x040007E3 RID: 2019
			public int int_1;

			// Token: 0x040007E4 RID: 2020
			public uint uint_2;

			// Token: 0x040007E5 RID: 2021
			public int int_2;

			// Token: 0x040007E6 RID: 2022
			public int int_3;
		}
	}
}
