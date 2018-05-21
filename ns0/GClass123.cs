// Decompiled with JetBrains decompiler
// Type: ns0.GClass123
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public static class GClass123
  {
    private static Dictionary<Control, Control> dictionary_0 = new Dictionary<Control, Control>();

    public static void smethod_0(this Control control_0, bool bool_0, Image image_0)
    {
      if (control_0.Parent == null && !(control_0 is RadForm))
        return;
      if (!GClass123.dictionary_0.ContainsKey(control_0))
        GClass123.dictionary_0.Add(control_0, (Control) null);
      Control control = GClass123.dictionary_0[control_0];
      Control.ControlCollection controlCollection = control_0 is RadForm ? control_0.Controls : control_0.Parent.Controls;
      controlCollection.IndexOf(control_0);
      if (bool_0 && control == null)
      {
        PictureBox pictureBox1 = new PictureBox();
        pictureBox1.Image = image_0;
        pictureBox1.Size = control_0.Size;
        pictureBox1.Location = control_0.Location;
        pictureBox1.Anchor = control_0.Anchor;
        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        PictureBox pictureBox2 = pictureBox1;
        controlCollection.Add((Control) pictureBox2);
        GClass123.dictionary_0[control_0] = (Control) pictureBox2;
        pictureBox2.BringToFront();
      }
      else
      {
        if (control == null)
          return;
        controlCollection.Remove(control);
        GClass123.dictionary_0[control_0] = (Control) null;
      }
    }

    public static void smethod_1(this Control control_0, bool bool_0)
    {
      control_0.smethod_0(bool_0, (Image) Class123.helperLoader);
    }
  }
}
