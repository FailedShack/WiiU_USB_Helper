using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using NusHelper.Emulators;

namespace ns0
{
	// Token: 0x02000005 RID: 5
	public static class GClass2
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0001A5EC File Offset: 0x000187EC
		internal static void smethod_0()
		{
			try
			{
				string text = Path.Combine(GClass88.CachePath, "packs");
				Directory.CreateDirectory(text);
				GClass27.smethod_7("https://github.com/slashiee/cemu_graphic_packs/archive/master.zip", text);
				IEnumerable<string> files = Directory.GetFiles(text, "*", System.IO.SearchOption.AllDirectories);
				string text2 = Path.Combine(new Cemu(null, false).String_4, "graphicPacks");
				Directory.CreateDirectory(text2);
				foreach (string path in files.Where(new Func<string, bool>(GClass2.<>c.<>c_0.method_0)))
				{
					string directoryName = Path.GetDirectoryName(path);
					string text3 = Path.Combine(text2, new DirectoryInfo(Path.GetDirectoryName(path)).Name);
					if (Directory.Exists(Path.Combine(text2, text3)))
					{
						Directory.Delete(text3, true);
					}
					try
					{
						FileSystem.MoveDirectory(directoryName, text3);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}
}
