using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Alphaleonis.Win32.Filesystem;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x020000D1 RID: 209
	public abstract class GClass91
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		protected GClass91(GClass32 gclass32_1)
		{
			this.WorkPath = gclass32_1.String_2;
			this.ToInject = gclass32_1;
			if (!GClass91.Boolean_1 && GClass91.smethod_4() == null)
			{
				Class65.smethod_7("java.exe");
				if (GClass91.smethod_4() == null)
				{
					RadMessageBox.Show("Java was not installed, it is required to build custom games.");
					throw new Exception("Java is not installed!");
				}
			}
			this.Name = this.ToInject.Name;
			try
			{
				this.Name = this.method_6("name").Replace("\\n", "\n");
			}
			catch
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000564 RID: 1380 RVA: 0x0002BE74 File Offset: 0x0002A074
		// (remove) Token: 0x06000565 RID: 1381 RVA: 0x0002BEAC File Offset: 0x0002A0AC
		public event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000566 RID: 1382 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
		// (remove) Token: 0x06000567 RID: 1383 RVA: 0x0002BF1C File Offset: 0x0002A11C
		public event EventHandler<Exception> Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = this.eventHandler_1;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = this.eventHandler_1;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000568 RID: 1384 RVA: 0x0002BF54 File Offset: 0x0002A154
		// (remove) Token: 0x06000569 RID: 1385 RVA: 0x0002BF8C File Offset: 0x0002A18C
		public event EventHandler<int> Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler<int> eventHandler = this.eventHandler_2;
				EventHandler<int> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<int> value2 = (EventHandler<int>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<int>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<int> eventHandler = this.eventHandler_2;
				EventHandler<int> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<int> value2 = (EventHandler<int>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<int>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600056A RID: 1386
		public abstract string String_1 { get; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00013978 File Offset: 0x00011B78
		public static string String_0
		{
			get
			{
				if (GClass91.Boolean_1)
				{
					return "java";
				}
				return GClass91.smethod_4();
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001398C File Offset: 0x00011B8C
		public static bool Boolean_0
		{
			get
			{
				return GClass91.Boolean_1 || System.IO.File.Exists(GClass91.smethod_4());
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000139A1 File Offset: 0x00011BA1
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000139A9 File Offset: 0x00011BA9
		public string Name { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000139B2 File Offset: 0x00011BB2
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000139BA File Offset: 0x00011BBA
		public bool Production { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000139C3 File Offset: 0x00011BC3
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000139CB File Offset: 0x00011BCB
		public string Publisher { get; set; } = "Hikari06";

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		public List<string> List_0
		{
			get
			{
				if (this.list_0 == null)
				{
					this.list_0 = new List<string>();
					this.list_0.Add(this.ToInject.ProductId);
					try
					{
						string text = this.method_6("product_codes");
						this.list_0.AddRange(text.Split(new string[]
						{
							Environment.NewLine
						}, StringSplitOptions.RemoveEmptyEntries));
					}
					catch
					{
					}
				}
				return this.list_0;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000574 RID: 1396
		public abstract string String_2 { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000139D4 File Offset: 0x00011BD4
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000139DC File Offset: 0x00011BDC
		public int RomCount { get; set; } = 1;

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000577 RID: 1399
		public abstract string[] String_3 { get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000139E5 File Offset: 0x00011BE5
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x000139ED File Offset: 0x00011BED
		public GClass32 ToInject { get; protected set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000139F6 File Offset: 0x00011BF6
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x000139FE File Offset: 0x00011BFE
		public bool UseGamepad { get; set; } = true;

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00013A07 File Offset: 0x00011C07
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00013A0F File Offset: 0x00011C0F
		public bool VerticalWiimote { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00013A18 File Offset: 0x00011C18
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00013A20 File Offset: 0x00011C20
		public bool HorizontalWiimote { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00013A29 File Offset: 0x00011C29
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00013A31 File Offset: 0x00011C31
		public string WorkPath { get; set; }

		// Token: 0x06000582 RID: 1410 RVA: 0x0002C044 File Offset: 0x0002A244
		protected bool method_0(string string_3, bool bool_4)
		{
			try
			{
				this.method_6(string_3);
				bool_4 = !bool_4;
			}
			catch
			{
			}
			return bool_4;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0002C078 File Offset: 0x0002A278
		public static void smethod_0(string string_3, string string_4)
		{
			Process process = Process.Start(new ProcessStartInfo(string_3)
			{
				WorkingDirectory = string_4,
				UseShellExecute = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			if (process == null)
			{
				process = Process.Start(new ProcessStartInfo(string_3)
				{
					WorkingDirectory = string_4,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden
				});
			}
			process.WaitForExit();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		public static void smethod_1(string string_3, string string_4, string string_5)
		{
			Process process = Process.Start(new ProcessStartInfo(string_3)
			{
				Arguments = string_5,
				WorkingDirectory = string_4,
				UseShellExecute = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			if (process == null)
			{
				process = Process.Start(new ProcessStartInfo(string_3)
				{
					Arguments = string_5,
					WorkingDirectory = string_4,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden
				});
			}
			process.WaitForExit();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00013A3A File Offset: 0x00011C3A
		public static void smethod_2(string string_3, string string_4, string string_5, string string_6, string string_7)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_3);
			processStartInfo.Arguments = string_5;
			processStartInfo.WorkingDirectory = string_4;
			processStartInfo.UseShellExecute = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.EnvironmentVariables[string_6] = string_7;
			Process.Start(processStartInfo).WaitForExit();
		}

		// Token: 0x06000586 RID: 1414
		public abstract bool vmethod_0(string string_3);

		// Token: 0x06000587 RID: 1415 RVA: 0x0002C138 File Offset: 0x0002A338
		public void method_1()
		{
			foreach (Alphaleonis.Win32.Filesystem.FileInfo fileInfo in new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.WorkPath).GetFiles("*", System.IO.SearchOption.AllDirectories))
			{
				if (System.IO.Directory.GetParent(fileInfo.FullName).Name != "output")
				{
					GClass6.smethod_6(fileInfo.FullName);
				}
			}
			foreach (Alphaleonis.Win32.Filesystem.FileInfo fileInfo2 in new Alphaleonis.Win32.Filesystem.DirectoryInfo(System.IO.Path.Combine(this.WorkPath, "output")).GetFiles())
			{
				FileSystem.MoveFile(fileInfo2.FullName, fileInfo2.FullName.Replace("output\\", ""));
			}
			Alphaleonis.Win32.Filesystem.DirectoryInfo[] directories = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.WorkPath).GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				directories[i].Delete(true);
			}
		}

		// Token: 0x06000588 RID: 1416
		public abstract int vmethod_1();

		// Token: 0x06000589 RID: 1417 RVA: 0x00013A76 File Offset: 0x00011C76
		public virtual void vmethod_2()
		{
			GClass6.smethod_5(this.WorkPath);
			System.IO.Directory.CreateDirectory(this.WorkPath);
			GClass6.smethod_5(this.ToInject.OutputPath);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002C210 File Offset: 0x0002A410
		protected void method_2(GClass32 gclass32_1)
		{
			TitleId titleId = new TitleId(this.ToInject.TitleId.IdRaw.Replace("00050000F", "000500001").Replace("000500002", "000500001"));
			Class7 @class = new Class7(gclass32_1);
			GClass13 gclass = gclass32_1.method_15();
			string @string = Encoding.UTF8.GetString(@class.method_0(gclass.Files.First(new Func<GClass12, bool>(GClass91.<>c.<>c_0.method_0)), 0UL));
			XDocument xdocument = XDocument.Parse(Encoding.UTF8.GetString(@class.method_0(gclass.Files.First(new Func<GClass12, bool>(GClass91.<>c.<>c_0.method_1)), 0UL)).Trim(new char[]
			{
				'﻿'
			}));
			xdocument.Document.Descendants("title_id").ElementAt(0).Value = titleId.IdRaw;
			xdocument.Save(this.method_4("rawFiles\\code\\app.xml"));
			string[] array = new string[]
			{
				"ja",
				"en",
				"fr",
				"de",
				"it",
				"es",
				"zhs",
				"ko",
				"nl",
				"pt",
				"ru",
				"zht"
			};
			xdocument = XDocument.Parse(@string.Trim(new char[]
			{
				'﻿'
			}));
			xdocument.Document.Descendants("title_id").ElementAt(0).Value = titleId.IdRaw;
			xdocument.Document.Descendants("product_code").ElementAt(0).Value = this.ToInject.ProductId;
			foreach (XElement xelement in xdocument.Document.Descendants().Where(new Func<XElement, bool>(GClass91.<>c.<>c_0.method_2)))
			{
				xelement.Value = "Hikari06";
			}
			foreach (XElement xelement2 in xdocument.Document.Descendants().Where(new Func<XElement, bool>(GClass91.<>c.<>c_0.method_3)))
			{
				xelement2.Value = this.Name;
			}
			foreach (XElement xelement3 in xdocument.Document.Descendants().Where(new Func<XElement, bool>(GClass91.<>c.<>c_0.method_4)))
			{
				xelement3.Value = this.Name;
			}
			foreach (XElement xelement4 in xdocument.Document.Descendants().Where(new Func<XElement, bool>(GClass91.<>c.<>c_0.method_5)))
			{
				xelement4.Value = "0";
			}
			try
			{
				if (this.UseGamepad)
				{
					xdocument.Document.Descendants("drc_use").ElementAt(0).Value = "65537";
				}
				else
				{
					xdocument.Document.Descendants("drc_use").ElementAt(0).Value = "0";
				}
			}
			catch
			{
			}
			xdocument.Save(this.method_4("rawFiles\\meta\\meta.xml"));
		}

		// Token: 0x0600058B RID: 1419
		protected abstract void vmethod_3();

		// Token: 0x0600058C RID: 1420 RVA: 0x0002C63C File Offset: 0x0002A83C
		protected void method_3(string string_3, string string_4)
		{
			System.IO.Directory.CreateDirectory(string_4);
			foreach (System.IO.FileInfo fileInfo in new System.IO.DirectoryInfo(string_3).GetFiles())
			{
				string text = fileInfo.Name.ToLower().Replace(".app", "");
				if (text == "title.tmd")
				{
					text = "tmd";
				}
				if (text == "title.tik")
				{
					text = "cetk";
				}
				if (text == "title.cert")
				{
					text = "cert";
				}
				System.IO.File.Copy(fileInfo.FullName, System.IO.Path.Combine(string_4, text));
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00013A9F File Offset: 0x00011C9F
		protected string method_4(string string_3)
		{
			return System.IO.Path.Combine(this.WorkPath, string_3);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		protected void method_5(string string_3, string string_4)
		{
			new GClass78().method_5(this.method_12(string_3), System.IO.Path.Combine(string_4, string_3), 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00013AAD File Offset: 0x00011CAD
		protected string method_6(string string_3)
		{
			return new GClass78().method_6(this.method_12(string_3));
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00013AC0 File Offset: 0x00011CC0
		protected Task method_7()
		{
			Task task = new Task(new Action(this.method_13));
			task.Start();
			return task;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0002C704 File Offset: 0x0002A904
		protected void method_8()
		{
			try
			{
				this.method_1();
				FileSystem.MoveDirectory(this.WorkPath, this.ToInject.OutputPath);
			}
			catch (Exception arg)
			{
				RadMessageBox.Show("USB Helper was unable to find the packed data. Usually this means Java is not properly installed. Please go to https://www.java.com/en/, install it, resart the app and try again." + Environment.NewLine + arg);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00013AD9 File Offset: 0x00011CD9
		protected void method_9()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00013AED File Offset: 0x00011CED
		protected void method_10(Exception exception_0)
		{
			EventHandler<Exception> eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, exception_0);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00013B01 File Offset: 0x00011D01
		protected void method_11(int int_1)
		{
			EventHandler<int> eventHandler = this.eventHandler_2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, int_1);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0002C758 File Offset: 0x0002A958
		private static bool Boolean_1
		{
			get
			{
				bool result;
				try
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = "java.exe",
						Arguments = " -version",
						RedirectStandardError = true,
						UseShellExecute = false,
						CreateNoWindow = true
					});
					result = true;
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		private static string smethod_3(string string_3, string string_4)
		{
			string result;
			try
			{
				GClass91.Class75 @class = new GClass91.Class75();
				IEnumerable<System.IO.FileInfo> source = new System.IO.DirectoryInfo(string_3).GetFiles(string_4, System.IO.SearchOption.AllDirectories).Where(new Func<System.IO.FileInfo, bool>(GClass91.<>c.<>c_0.method_6));
				@class.dateTime_0 = source.Max(new Func<System.IO.FileInfo, DateTime>(GClass91.<>c.<>c_0.method_7));
				result = source.First(new Func<System.IO.FileInfo, bool>(@class.method_0)).FullName;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002C858 File Offset: 0x0002AA58
		private static string smethod_4()
		{
			GClass91.Class76 @class = new GClass91.Class76();
			@class.list_0 = new List<string>();
			string text;
			if (Environment.Is64BitOperatingSystem)
			{
				text = GClass91.smethod_3(System.IO.Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432"), "Java"), "java.exe");
				if (text != null)
				{
					@class.list_0.Add(text);
				}
			}
			text = GClass91.smethod_3(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Java"), "java.exe");
			if (text != null)
			{
				@class.list_0.Add(text);
			}
			if (@class.list_0.Count == 0)
			{
				return null;
			}
			return @class.list_0.First(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00013B15 File Offset: 0x00011D15
		private string method_12(string string_3)
		{
			return string.Format("{0}/{1}", this.ToInject.String_6, string_3).Replace("https", "http");
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0002C900 File Offset: 0x0002AB00
		[CompilerGenerated]
		private void method_13()
		{
			this.method_5("bootDrcTex.tga", this.method_4("rawFiles\\meta\\"));
			this.method_5("bootTvTex.tga", this.method_4("rawFiles\\meta\\"));
			this.method_5("iconTex.tga", this.method_4("rawFiles\\meta\\"));
			this.method_5("bootSound.btsnd", this.method_4("rawFiles\\meta\\"));
		}

		// Token: 0x04000353 RID: 851
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000354 RID: 852
		[CompilerGenerated]
		private EventHandler<Exception> eventHandler_1;

		// Token: 0x04000355 RID: 853
		[CompilerGenerated]
		private EventHandler<int> eventHandler_2;

		// Token: 0x04000356 RID: 854
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000357 RID: 855
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000358 RID: 856
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000359 RID: 857
		private List<string> list_0;

		// Token: 0x0400035A RID: 858
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400035B RID: 859
		[CompilerGenerated]
		private GClass32 gclass32_0;

		// Token: 0x0400035C RID: 860
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400035D RID: 861
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400035F RID: 863
		[CompilerGenerated]
		private string string_2;

		// Token: 0x020000D3 RID: 211
		[CompilerGenerated]
		private sealed class Class75
		{
			// Token: 0x060005A6 RID: 1446 RVA: 0x00013BF2 File Offset: 0x00011DF2
			internal bool method_0(System.IO.FileInfo fileInfo_0)
			{
				return fileInfo_0.CreationTime == this.dateTime_0;
			}

			// Token: 0x0400036A RID: 874
			public DateTime dateTime_0;
		}

		// Token: 0x020000D4 RID: 212
		[CompilerGenerated]
		private sealed class Class76
		{
			// Token: 0x060005A8 RID: 1448 RVA: 0x00013C05 File Offset: 0x00011E05
			internal bool method_0(string string_0)
			{
				return new System.IO.FileInfo(string_0).CreationTime == this.list_0.Max(new Func<string, DateTime>(GClass91.<>c.<>c_0.method_8));
			}

			// Token: 0x0400036B RID: 875
			public List<string> list_0;
		}
	}
}
