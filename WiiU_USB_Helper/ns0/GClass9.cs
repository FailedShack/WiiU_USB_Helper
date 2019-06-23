using System;
using System.Diagnostics;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x02000011 RID: 17
	public static class GClass9
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0001B304 File Offset: 0x00019504
		public static bool smethod_0()
		{
			try
			{
				if (GClass9.smethod_1() && RadMessageBox.Show("The live support service is currently online. Would you like to require immediate assistance?", "Immediate assistance", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Process.Start(string.Format("{0}/chat/", Class65.String_4));
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0001B35C File Offset: 0x0001955C
		public static bool smethod_1()
		{
			bool result;
			try
			{
				result = (new GClass78().method_6(string.Format("{0}/getStatus.php", Class65.String_4)) == "ONLINE");
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
