using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000130 RID: 304
	public static class GClass123
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00034E7C File Offset: 0x0003307C
		public static void smethod_0(this Control control_0, bool bool_0, Image image_0)
		{
			if (control_0.Parent == null && !(control_0 is RadForm))
			{
				return;
			}
			if (!GClass123.dictionary_0.ContainsKey(control_0))
			{
				GClass123.dictionary_0.Add(control_0, null);
			}
			Control control = GClass123.dictionary_0[control_0];
			Control.ControlCollection controlCollection = (control_0 is RadForm) ? control_0.Controls : control_0.Parent.Controls;
			controlCollection.IndexOf(control_0);
			if (bool_0 && control == null)
			{
				PictureBox pictureBox = new PictureBox
				{
					Image = image_0,
					Size = control_0.Size,
					Location = control_0.Location,
					Anchor = control_0.Anchor,
					SizeMode = PictureBoxSizeMode.CenterImage
				};
				controlCollection.Add(pictureBox);
				GClass123.dictionary_0[control_0] = pictureBox;
				pictureBox.BringToFront();
				return;
			}
			if (control != null)
			{
				controlCollection.Remove(control);
				GClass123.dictionary_0[control_0] = null;
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001562A File Offset: 0x0001382A
		public static void smethod_1(this Control control_0, bool bool_0)
		{
			control_0.smethod_0(bool_0, Class121.helperLoader);
		}

		// Token: 0x040004E3 RID: 1251
		private static Dictionary<Control, Control> dictionary_0 = new Dictionary<Control, Control>();
	}
}
