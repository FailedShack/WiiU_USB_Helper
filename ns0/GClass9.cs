// Decompiled with JetBrains decompiler
// Type: ns0.GClass9
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Diagnostics;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ns0
{
  public static class GClass9
  {
    public static bool smethod_0()
    {
      try
      {
        if (GClass9.smethod_1())
        {
          if (RadMessageBox.Show("The live support service is currently online. Would you like to require immediate assistance?", "Immediate assistance", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            Process.Start(string.Format("{0}/chat/", (object) Class67.String_4));
            return true;
          }
        }
      }
      catch
      {
      }
      return false;
    }

    public static bool smethod_1()
    {
      try
      {
        return new GClass78().method_6(string.Format("{0}/getStatus.php", (object) Class67.String_4)) == "ONLINE";
      }
      catch
      {
        return false;
      }
    }
  }
}
