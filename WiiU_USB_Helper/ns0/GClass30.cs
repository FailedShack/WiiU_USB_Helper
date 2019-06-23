using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using NusHelper.Emulators;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x02000065 RID: 101
	public abstract class GClass30
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00024780 File Offset: 0x00022980
		protected GClass30(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, GEnum3 genum3_1)
		{
			this.Name = string_7;
			this.TitleId = titleId_1;
			this.Region = string_8;
			this.TicketArray = byte_2;
			if (this.TicketArray != null)
			{
				this.Ticket = GClass99.smethod_7(byte_2, genum3_1);
			}
			this.Size = dataSize_1;
			this.RootDownloadLocation = string_9;
			this.System = genum3_1;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000247F8 File Offset: 0x000229F8
		public string String_0
		{
			get
			{
				switch (this.System)
				{
				case GEnum3.const_0:
					return "3DS";
				case GEnum3.const_1:
					return "WiiU";
				case GEnum3.const_2:
					return "Switch";
				default:
					return "UKN";
				}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00011E91 File Offset: 0x00010091
		public string method_0(GStruct3 gstruct3_0)
		{
			return GClass6.smethod_13(this.Size, gstruct3_0);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00024838 File Offset: 0x00022A38
		public int Int32_0
		{
			get
			{
				if (!this.Boolean_0)
				{
					return GClass80.smethod_1(this.method_1(), (long)this.Size.TotalBytes);
				}
				if (this.GEnum2_0 != GEnum2.const_2)
				{
					return 0;
				}
				return 100;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00011E9F File Offset: 0x0001009F
		public bool Boolean_0
		{
			get
			{
				return this.Platform == Platform.Gamecube || this.Platform == Platform.Wii_Custom || this.Platform == Platform.Super_NES_Custom || this.Platform == Platform.Nintendo_64_Custom;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00024874 File Offset: 0x00022A74
		public GClass32 GClass32_0
		{
			get
			{
				GClass32 result;
				try
				{
					result = GClass28.dictionary_0[this.TitleId.FullGame];
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00011ED7 File Offset: 0x000100D7
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00011EDF File Offset: 0x000100DF
		public bool CfwOnly { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000248B0 File Offset: 0x00022AB0
		public GEnum2 GEnum2_0
		{
			get
			{
				if ((DateTime.Now - this.dateTime_0).TotalSeconds <= 6.0)
				{
					return this.genum2_0;
				}
				this.dateTime_0 = DateTime.Now;
				this.genum2_0 = this.method_19();
				return this.genum2_0;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00011EE8 File Offset: 0x000100E8
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00011EF0 File Offset: 0x000100F0
		public Platform Platform { get; internal set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00011EF9 File Offset: 0x000100F9
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00011F01 File Offset: 0x00010101
		public GEnum3 System { get; internal set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00011F0A File Offset: 0x0001010A
		public string String_1
		{
			get
			{
				return string.Format("{0}{1}/", this.RootDownloadLocation, this.TitleId);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00011F22 File Offset: 0x00010122
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00011F2A File Offset: 0x0001012A
		public bool Hidden { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00011F33 File Offset: 0x00010133
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00011F3B File Offset: 0x0001013B
		public string Name { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00011F44 File Offset: 0x00010144
		public virtual string OutputPath { get; } = GClass28.string_4;

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00011F4C File Offset: 0x0001014C
		public string String_2
		{
			get
			{
				return Path.Combine(Directory.GetParent(this.OutputPath).FullName, this.TitleId.IdRaw);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00011F6E File Offset: 0x0001016E
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00011F76 File Offset: 0x00010176
		public string Region { get; private set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00011F7F File Offset: 0x0001017F
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00011F87 File Offset: 0x00010187
		public DataSize Size { get; private set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00011F90 File Offset: 0x00010190
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00011F98 File Offset: 0x00010198
		public byte[] TicketArray { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00011FA1 File Offset: 0x000101A1
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00011FA9 File Offset: 0x000101A9
		public GClass99 Ticket { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00011FB2 File Offset: 0x000101B2
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00011FBA File Offset: 0x000101BA
		public bool DiscOnly { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00011FC3 File Offset: 0x000101C3
		public TitleId TitleId { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00011FCB File Offset: 0x000101CB
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00011FD3 File Offset: 0x000101D3
		public GClass100 Tmd { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00011FDC File Offset: 0x000101DC
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00011FE4 File Offset: 0x000101E4
		public bool CurrentlyDownloaded { get; internal set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00011FED File Offset: 0x000101ED
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00011FF5 File Offset: 0x000101F5
		public bool CurrentlyUploaded { get; internal set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00024904 File Offset: 0x00022B04
		public Color Color_0
		{
			get
			{
				switch (this.GEnum2_0)
				{
				case GEnum2.const_0:
					return Color.Red;
				case GEnum2.const_1:
					return Color.Orange;
				case GEnum2.const_2:
					return Color.Green;
				default:
					return Color.Red;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00024944 File Offset: 0x00022B44
		public string String_3
		{
			get
			{
				switch (this.GEnum2_0)
				{
				case GEnum2.const_0:
					return "Not downloaded";
				case GEnum2.const_1:
					return string.Format("Download not completed, please resume ({0}%)", this.Int32_0);
				case GEnum2.const_2:
					return "Download completed, ready to install";
				default:
					return "Not downloaded";
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00011FFE File Offset: 0x000101FE
		public Color Color_1
		{
			get
			{
				if (!this.Boolean_1)
				{
					return Color.Gray;
				}
				return Color.Green;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00012013 File Offset: 0x00010213
		public string String_4
		{
			get
			{
				if (!this.Boolean_1)
				{
					return "Not installed yet";
				}
				return "Ready to play";
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00024994 File Offset: 0x00022B94
		public bool Boolean_1
		{
			get
			{
				if (this is GClass32)
				{
					GClass95 gclass = this.method_14(false);
					return gclass != null && gclass.Boolean_2;
				}
				if (this is GClass33)
				{
					GClass95 gclass2 = GClass28.dictionary_0[this.TitleId.FullGame].method_14(false);
					return gclass2 != null && gclass2.UpdateIsInstalled();
				}
				if (this is GClass31)
				{
					GClass95 gclass3 = GClass28.dictionary_0[this.TitleId.FullGame].method_14(false);
					return gclass3 != null && gclass3.DlcIsInstalled();
				}
				return false;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00012028 File Offset: 0x00010228
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00012030 File Offset: 0x00010230
		public string Version { get; protected set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00012039 File Offset: 0x00010239
		protected string String_5
		{
			get
			{
				return string.Format("{0} [{1}]", GClass30.smethod_2(this.Name), this.TitleId);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00012056 File Offset: 0x00010256
		public virtual string String_6
		{
			get
			{
				return string.Format("{0} ({1})", GClass30.smethod_3(this.String_5), this.Region);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00012073 File Offset: 0x00010273
		private string RootDownloadLocation { get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600027E RID: 638 RVA: 0x00024A20 File Offset: 0x00022C20
		// (remove) Token: 0x0600027F RID: 639 RVA: 0x00024A58 File Offset: 0x00022C58
		public event EventHandler<GClass81> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass81> eventHandler = this.eventHandler_0;
				EventHandler<GClass81> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass81> value2 = (EventHandler<GClass81>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass81>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass81> eventHandler = this.eventHandler_0;
				EventHandler<GClass81> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass81> value2 = (EventHandler<GClass81>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass81>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000280 RID: 640 RVA: 0x00024A90 File Offset: 0x00022C90
		// (remove) Token: 0x06000281 RID: 641 RVA: 0x00024AC8 File Offset: 0x00022CC8
		public event EventHandler<GEventArgs0> Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GEventArgs0> eventHandler = this.eventHandler_1;
				EventHandler<GEventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GEventArgs0> eventHandler = this.eventHandler_1;
				EventHandler<GEventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00024B00 File Offset: 0x00022D00
		private long method_1()
		{
			if (!Directory.Exists(this.OutputPath))
			{
				return 0L;
			}
			return Directory.GetFiles(this.OutputPath).Sum(new Func<string, long>(GClass30.<>c.<>c_0.method_0));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00024B4C File Offset: 0x00022D4C
		public void method_2(string string_7)
		{
			GClass30.Class42 @class = new GClass30.Class42();
			@class.string_0 = string_7;
			if (this.System != GEnum3.const_0)
			{
				return;
			}
			if (!Directory.Exists(@class.string_0))
			{
				Directory.CreateDirectory(@class.string_0);
			}
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
			GClass27.smethod_11(@class.string_0);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "PART1",
				WorkingDirectory = @class.string_0,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = true;
			process.Exited += @class.method_0;
			this.method_5(@class.string_0, "game");
			process.Start();
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00024C18 File Offset: 0x00022E18
		public void method_3(string string_7, bool bool_6 = false)
		{
			GClass30.Class43 @class = new GClass30.Class43();
			@class.string_0 = string_7;
			@class.bool_0 = bool_6;
			if (this.System != GEnum3.const_0)
			{
				return;
			}
			if (!Directory.Exists(@class.string_0))
			{
				Directory.CreateDirectory(@class.string_0);
			}
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper prepares your game", false);
			GClass27.smethod_11(@class.string_0);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "PART1",
				WorkingDirectory = @class.string_0,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = true;
			process.Exited += @class.method_0;
			this.method_5(@class.string_0, "game");
			process.Start();
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00024CEC File Offset: 0x00022EEC
		public void method_4(string string_7, bool bool_6, bool bool_7, bool bool_8)
		{
			GClass30.Class44 @class = new GClass30.Class44();
			@class.string_1 = string_7;
			@class.bool_0 = bool_8;
			@class.bool_1 = bool_7;
			@class.bool_2 = bool_6;
			if (this.System != GEnum3.const_0)
			{
				throw new Exception("This process can only be done on CTR titles");
			}
			Directory.CreateDirectory(@class.string_1);
			@class.frmWait_0 = new FrmWait("USB Helper is extracting your title...", true);
			@class.string_0 = Path.Combine(Path.GetTempPath(), "game.cia");
			this.method_5(@class.string_1, "game");
			GClass27.smethod_11(@class.string_1);
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = Path.Combine(@class.string_1, "PART1"),
				WorkingDirectory = @class.string_1
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.EnableRaisingEvents = true;
			process.Exited += @class.method_0;
			process.Start();
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00024DDC File Offset: 0x00022FDC
		public void method_5(string string_7, string string_8)
		{
			GClass30.Class45 @class = new GClass30.Class45();
			@class.gclass30_0 = this;
			@class.string_0 = string_7;
			@class.string_1 = string_8;
			if (Directory.Exists(this.String_2))
			{
				FileSystem.DeleteDirectory(this.String_2, DeleteDirectoryOption.DeleteAllContents);
			}
			FileSystem.RenameDirectory(this.OutputPath, this.TitleId.IdRaw);
			string text = Path.Combine(GClass88.CachePath, "makecia.exe");
			try
			{
				File.WriteAllBytes(text, Class121.makecia);
			}
			catch (Exception)
			{
			}
			string arguments = string.Format("\"{0}\" \"{1}\\{2}.cia\"", this.String_2, @class.string_0, this.TitleId.IdRaw);
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.EnableRaisingEvents = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.Arguments = arguments;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.WorkingDirectory = @class.string_0;
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper packs your game.", true);
			process.OutputDataReceived += @class.method_0;
			process.Start();
			process.BeginOutputReadLine();
			process.Exited += @class.method_1;
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001207B File Offset: 0x0001027B
		public void method_6()
		{
			this.dateTime_0 = DateTime.MinValue;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00012088 File Offset: 0x00010288
		public static void smethod_0()
		{
			GClass30.list_0 = new List<string>();
			if (GClass88.smethod_1("installed"))
			{
				GClass30.list_0.AddRange(GClass88.smethod_7("installed"));
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000120B4 File Offset: 0x000102B4
		public static void smethod_1()
		{
			GClass88.smethod_10("installed", GClass30.list_0.ToArray());
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000120CA File Offset: 0x000102CA
		public void method_7()
		{
			Class58 @class = this.class58_0;
			if (@class == null)
			{
				return;
			}
			@class.method_0();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000120DC File Offset: 0x000102DC
		public void method_8()
		{
			this.eventHandler_1 = null;
			this.eventHandler_0 = null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00024F38 File Offset: 0x00023138
		public string method_9(bool bool_6, DriveInfo driveInfo_0)
		{
			string text = Path.Combine(Path.GetTempPath(), "ext_usb_helper");
			Directory.CreateDirectory(text);
			if (bool_6 && !this.method_20())
			{
				return "Download Corrupted";
			}
			string text2 = Path.Combine(driveInfo_0.Name, "Install\\", this.String_6 + (this.CfwOnly ? " (CFW ONLY)" : ""));
			GClass6.smethod_5(text2);
			Directory.CreateDirectory(text2);
			if (this.System == GEnum3.const_1)
			{
				string message;
				try
				{
					FileSystem.CopyDirectory(this.OutputPath, text2, UIOption.AllDialogs);
					goto IL_88;
				}
				catch (Exception ex)
				{
					message = ex.Message;
				}
				return message;
				IL_88:
				return "OK";
			}
			if (this.System == GEnum3.const_0)
			{
				this.method_5(text, "game");
				FileSystem.MoveFile(Path.Combine(text, "game.cia"), Path.Combine(text2, "title.cia"), UIOption.AllDialogs);
				return "OK";
			}
			if (this.System == GEnum3.const_3)
			{
				this.method_10(Path.Combine(driveInfo_0.Name, "wads"), this.String_6 + ".wad");
				return "OK";
			}
			throw new NotImplementedException();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00025058 File Offset: 0x00023258
		public void method_10(string string_7, string string_8 = "game.wad")
		{
			GClass30.Class46 @class = new GClass30.Class46();
			@class.gclass30_0 = this;
			@class.string_0 = string_7;
			@class.string_1 = string_8;
			@class.frmWait_0 = new FrmWait("USB Helper is preparing your game...", true);
			Task.Run(new Action(@class.method_0));
			@class.frmWait_0.ShowDialog();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000250B0 File Offset: 0x000232B0
		public bool method_11()
		{
			this.method_6();
			bool result;
			try
			{
				GClass6.smethod_5(this.OutputPath);
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000120EC File Offset: 0x000102EC
		public string method_12()
		{
			if (this is GClass32)
			{
				return string.Format("{0} [{1}]", GClass30.smethod_2(this.Name), ((GClass32)this).ProductId);
			}
			return string.Format("{0} (unpacked)", GClass30.smethod_2(this.ToString()));
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001212C File Offset: 0x0001032C
		public void method_13(GClass95 gclass95_0)
		{
			gclass95_0.Play();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000250E8 File Offset: 0x000232E8
		public GClass95 method_14(bool bool_6)
		{
			if (this.DiscOnly)
			{
				return null;
			}
			Platform platform = this.Platform;
			if (platform <= Platform.Nintendo_3DS)
			{
				if (platform <= Platform.GameBoy_Advance_3DS)
				{
					if (platform == Platform.Wii_U_Custom)
					{
						return new Cemu(this, bool_6);
					}
					switch (platform)
					{
					case Platform.Nintendo_3DS_Download:
						return new Citra(this, bool_6);
					case Platform.GameBoy:
						return new VisualBoyAdvance(this, bool_6);
					case Platform.GameBoy_Color:
						return new VisualBoyAdvance(this, bool_6);
					case Platform.GameBoy_Advance_3DS:
						return new Citra(this, bool_6);
					}
				}
				else
				{
					if (platform == Platform.Wii_U_Disc)
					{
						return new Cemu(this, bool_6);
					}
					if (platform == Platform.Nintendo_3DS_Download_Software)
					{
						return new Citra(this, bool_6);
					}
					if (platform == Platform.Nintendo_3DS)
					{
						return new Citra(this, bool_6);
					}
				}
			}
			else if (platform <= Platform.Wii)
			{
				if (platform == Platform.Wii_U_Download)
				{
					return new Cemu(this, bool_6);
				}
				if (platform == Platform.Wii_U_Retail_Download)
				{
					return new Cemu(this, bool_6);
				}
				switch (platform)
				{
				case Platform.const_8:
					return new Fceux(this, bool_6);
				case Platform.Super_NES:
					return new Snes9x(this, bool_6);
				case Platform.Wii_U_Download_Software:
					return new Cemu(this, bool_6);
				case Platform.Nintendo_DS:
					return new DeSmuMe(this, bool_6);
				case Platform.Nintendo_64:
					return new Project64(this, bool_6);
				case Platform.Wii:
					return new Dolphin(this, bool_6);
				}
			}
			else
			{
				if (platform == Platform.New_3DS_Download)
				{
					return new Citra(this, bool_6);
				}
				if (platform == Platform.New_3DS_Card_Download)
				{
					return new Citra(this, bool_6);
				}
				if (platform == Platform.WiiWare)
				{
					return new Dolphin(this, bool_6);
				}
			}
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00025244 File Offset: 0x00023444
		public GClass13 method_15()
		{
			if (this.System != GEnum3.const_1)
			{
				throw new Exception("The FST can only be retrieved for WUP titles.");
			}
			GClass100 gclass;
			if (this is GClass33)
			{
				gclass = GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd.{1}", this.String_1, this.Version)), GEnum3.const_1);
			}
			else
			{
				gclass = GClass100.smethod_1(new GClass78().method_2(string.Format("{0}tmd", this.String_1)), GEnum3.const_1);
			}
			GClass99 gclass2;
			if (!(this is GClass33))
			{
				if (this.Platform != Platform.Wii_U_Custom)
				{
					if (this.bool_0)
					{
						gclass2 = GClass99.smethod_7(File.ReadAllBytes(Path.Combine(Path.Combine(GClass88.CachePath, "tickets"), this.TitleId.IdRaw + ".tik")), GEnum3.const_1);
						goto IL_ED;
					}
					gclass2 = GClass99.smethod_7(this.TicketArray, GEnum3.const_1);
					goto IL_ED;
				}
			}
			gclass2 = GClass99.smethod_7(new GClass78().method_2(this.String_1 + "cetk"), GEnum3.const_1);
			IL_ED:
			byte[] array = new GClass78().method_2(this.String_1 + gclass.GClass101_0[0].ContentId.ToString("x8"));
			GClass13 result;
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.Key = gclass2.Byte_0;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.None;
				aesCryptoServiceProvider.IV = new byte[16];
				result = new GClass13(aesCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length));
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000253D8 File Offset: 0x000235D8
		public bool method_16(string string_7, bool bool_6, bool bool_7 = false, IEnumerable<GClass12> ienumerable_0 = null, bool bool_8 = false)
		{
			GClass30.Class47 @class = new GClass30.Class47();
			@class.bool_0 = false;
			GClass28.gclass30_0 = this;
			if (bool_6)
			{
				string_7 = Path.Combine(string_7, this.method_12());
			}
			if (this.System == GEnum3.const_1)
			{
				GClass30.Class48 class2 = new GClass30.Class48();
				class2.class47_0 = @class;
				try
				{
					DriveInfo driveInfo = new DriveInfo(Path.GetPathRoot(string_7));
					if (driveInfo.AvailableFreeSpace < (long)this.Size.TotalBytes)
					{
						RadMessageBox.Show(string.Format("There isn't enough space left of {0}. Please free {1}.", driveInfo.Name, new DataSize(this.Size.TotalBytes - (ulong)driveInfo.AvailableFreeSpace)));
						return false;
					}
				}
				catch
				{
				}
				Directory.CreateDirectory(string_7);
				if (this.Boolean_0)
				{
					RadMessageBox.Show("Injectable titles cannot be unpacked");
					return false;
				}
				class2.frmUnpackAnimation_0 = new frmUnpackAnimation(this);
				Class7 class3 = new Class7(this);
				class3.Event_1 += class2.method_0;
				class2.bool_0 = false;
				class3.Event_0 += class2.method_1;
				class3.Event_2 += class2.method_2;
				if (ienumerable_0 != null)
				{
					class3.method_1(string_7, bool_7, ienumerable_0.ToList<GClass12>(), bool_8);
				}
				else
				{
					class3.method_1(string_7, bool_7, null, bool_8);
				}
				if (!class2.bool_0)
				{
					class2.frmUnpackAnimation_0.ShowDialog();
				}
				try
				{
					if (this is GClass32 && bool_6 && !string_7.Contains("EMULATORS"))
					{
						string path = Path.Combine(string_7, "meta", "meta.xml");
						if (File.Exists(path))
						{
							XmlDocument xmlDocument = new XmlDocument();
							xmlDocument.LoadXml(File.ReadAllText(path));
							string innerText = xmlDocument.GetElementsByTagName("company_code")[0].InnerText;
							string name = new DirectoryInfo(string_7).Name;
							string newName = string.Concat(new string[]
							{
								name.Substring(0, name.IndexOf("[")),
								"[",
								((GClass32)this).ProductId,
								innerText.Substring(2),
								"]"
							});
							FileSystem.RenameDirectory(string_7, newName);
						}
					}
					goto IL_229;
				}
				catch
				{
					goto IL_229;
				}
				bool result;
				return result;
			}
			if (this.System == GEnum3.const_0)
			{
				GClass28.gclass30_0 = null;
				return false;
			}
			IL_229:
			GClass28.gclass30_0 = null;
			return @class.bool_0;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00012134 File Offset: 0x00010334
		private void method_17(string string_7, string string_8)
		{
			if (Directory.Exists(string_7))
			{
				FileSystem.MoveDirectory(string_7, string_8, UIOption.OnlyErrorDialogs);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00025638 File Offset: 0x00023838
		public void method_18(bool bool_6, GClass82 gclass82_0, bool bool_7, bool? nullable_0)
		{
			GClass30.Class49 @class = new GClass30.Class49();
			@class.gclass30_0 = this;
			@class.bool_0 = bool_7;
			if (this.System != GEnum3.const_1)
			{
				return;
			}
			this.CurrentlyUploaded = true;
			if (bool_6 && !this.method_20())
			{
				EventHandler<GClass81> eventHandler = this.eventHandler_0;
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(this, new GClass81("Download Corrupted", true, GEnum5.const_5));
				return;
			}
			else
			{
				@class.string_0 = this.String_6 + (this.CfwOnly ? " (CFW ONLY)" : "");
				@class.long_1 = new DirectoryInfo(this.OutputPath).GetFiles().Sum(new Func<FileInfo, long>(GClass30.<>c.<>c_0.method_5));
				string text = Path.Combine("/sd/Install/", @class.string_0);
				this.class58_0 = new Class58(gclass82_0.IPAddress_0.ToString(), "anonymous", "");
				if (this.class58_0.method_1())
				{
					if (nullable_0 != null)
					{
						this.class58_0.method_13(nullable_0.Value);
					}
					this.class58_0.method_2("/sd/Install/");
					this.class58_0.method_2(text);
					this.class58_0.Event_1 += @class.method_0;
					@class.long_0 = 0L;
					@class.dateTime_0 = DateTime.Now;
					@class.ulong_0 = 0UL;
					this.class58_0.Event_0 += @class.method_1;
					try
					{
						this.class58_0.method_14(text, this.OutputPath);
					}
					catch (Exception ex)
					{
						EventHandler<GClass81> eventHandler2 = this.eventHandler_0;
						if (eventHandler2 != null)
						{
							eventHandler2(this, new GClass81(ex.Message, true, GEnum5.const_4));
						}
					}
					return;
				}
				EventHandler<GClass81> eventHandler3 = this.eventHandler_0;
				if (eventHandler3 == null)
				{
					return;
				}
				eventHandler3(this, new GClass81("Could not connect to the WIIU", true, GEnum5.const_1));
				return;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00012146 File Offset: 0x00010346
		public static string smethod_2(string string_7)
		{
			string_7 = string_7.Replace(":", "");
			return Path.GetInvalidFileNameChars().Aggregate(string_7, new Func<string, char, string>(GClass30.<>c.<>c_0.method_6));
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00025814 File Offset: 0x00023A14
		public static string smethod_3(string string_7)
		{
			string result = string_7.smethod_10(new char[]
			{
				'@',
				'#',
				'®',
				'™',
				'+',
				':',
				';',
				'©',
				'\''
			}, ' ').smethod_10(new char[]
			{
				'é',
				'è',
				'ê'
			}, 'e').smethod_10(new char[]
			{
				'È',
				'É'
			}, 'E').smethod_10(new char[]
			{
				'à',
				'â'
			}, 'a').smethod_10(new char[]
			{
				'ô',
				'ò',
				'ö'
			}, 'o').Replace("&", "and");
			if (GClass10.smethod_0(result))
			{
				return GClass10.smethod_1(result);
			}
			return result;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000258C8 File Offset: 0x00023AC8
		private GEnum2 method_19()
		{
			if (!Directory.Exists(this.OutputPath))
			{
				return GEnum2.const_0;
			}
			if (!File.Exists(Path.Combine(this.OutputPath, "title.tmd")) || !File.Exists(Path.Combine(this.OutputPath, "title.tik")) || ((this.System == GEnum3.const_1 || this.System == GEnum3.const_3) && !File.Exists(Path.Combine(this.OutputPath, "title.cert"))))
			{
				return GEnum2.const_0;
			}
			if ((this is GClass31 || this.Platform == Platform.Wii_U_Custom) && !new GClass78().method_2(this.String_1 + "tmd").smethod_5(File.ReadAllBytes(Path.Combine(this.OutputPath, "title.tmd"))))
			{
				return GEnum2.const_1;
			}
			foreach (GClass101 gclass in GClass100.smethod_0(Path.Combine(this.OutputPath, "title.tmd"), this.System).GClass101_0)
			{
				string text = Path.Combine(this.OutputPath, gclass.ContentId.ToString("x8") + ".app");
				if (!File.Exists(text))
				{
					return GEnum2.const_1;
				}
				if (new FileInfo(text).Length != (long)gclass.Size.TotalBytes.smethod_2(16u))
				{
					return GEnum2.const_1;
				}
				if (gclass.Boolean_0 && !File.Exists(Path.Combine(this.OutputPath, gclass.ContentId.ToString("x8") + ".h3")))
				{
					return GEnum2.const_1;
				}
			}
			return GEnum2.const_2;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00025A60 File Offset: 0x00023C60
		private bool method_20()
		{
			GClass30.Class50 @class = new GClass30.Class50();
			@class.gclass30_0 = this;
			@class.frmWait_0 = new FrmWait("USB Helper is verifying your download. Please wait.", false);
			@class.list_0 = null;
			Task.Run(new Action(@class.method_0));
			@class.frmWait_0.ShowDialog();
			if (@class.list_0 == null)
			{
				return false;
			}
			return @class.list_0.All(new Func<GStruct7, bool>(GClass30.<>c.<>c_0.method_7));
		}

		// Token: 0x04000199 RID: 409
		internal const int int_0 = 65536;

		// Token: 0x0400019A RID: 410
		private const int int_1 = 64512;

		// Token: 0x0400019B RID: 411
		private const int int_2 = 1024;

		// Token: 0x0400019C RID: 412
		protected static List<string> list_0;

		// Token: 0x0400019D RID: 413
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x0400019E RID: 414
		private GEnum2 genum2_0;

		// Token: 0x0400019F RID: 415
		private Class58 class58_0;

		// Token: 0x040001A0 RID: 416
		public byte[] byte_0;

		// Token: 0x040001A1 RID: 417
		public string string_0;

		// Token: 0x040001A2 RID: 418
		public string string_1;

		// Token: 0x040001A3 RID: 419
		public bool bool_0;

		// Token: 0x040001A4 RID: 420
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040001A5 RID: 421
		[CompilerGenerated]
		private Platform platform_0;

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		private GEnum3 genum3_0;

		// Token: 0x040001A7 RID: 423
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040001A8 RID: 424
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040001A9 RID: 425
		[CompilerGenerated]
		private readonly string string_3;

		// Token: 0x040001AA RID: 426
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040001AB RID: 427
		[CompilerGenerated]
		private DataSize dataSize_0;

		// Token: 0x040001AC RID: 428
		[CompilerGenerated]
		private byte[] byte_1;

		// Token: 0x040001AD RID: 429
		[CompilerGenerated]
		private GClass99 gclass99_0;

		// Token: 0x040001AE RID: 430
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040001AF RID: 431
		[CompilerGenerated]
		private readonly TitleId titleId_0;

		// Token: 0x040001B0 RID: 432
		[CompilerGenerated]
		private GClass100 gclass100_0;

		// Token: 0x040001B1 RID: 433
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040001B2 RID: 434
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040001B3 RID: 435
		[CompilerGenerated]
		private string string_5;

		// Token: 0x040001B4 RID: 436
		[CompilerGenerated]
		private readonly string string_6;

		// Token: 0x040001B5 RID: 437
		[CompilerGenerated]
		private EventHandler<GClass81> eventHandler_0;

		// Token: 0x040001B6 RID: 438
		[CompilerGenerated]
		private EventHandler<GEventArgs0> eventHandler_1;

		// Token: 0x02000067 RID: 103
		[CompilerGenerated]
		private sealed class Class42
		{
			// Token: 0x060002A5 RID: 677 RVA: 0x00025AE4 File Offset: 0x00023CE4
			internal void method_0(object sender, EventArgs e)
			{
				try
				{
					GClass6.smethod_6(Path.Combine(this.string_0, "game.cia"));
					foreach (FileInfo fileInfo in new DirectoryInfo(this.string_0).GetFiles().Where(new Func<FileInfo, bool>(GClass30.<>c.<>c_0.method_1)))
					{
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = "PART2-CFA",
							WorkingDirectory = this.string_0,
							Arguments = fileInfo.Name,
							CreateNoWindow = true,
							WindowStyle = ProcessWindowStyle.Hidden
						};
						Process process = new Process();
						process.StartInfo = startInfo;
						process.Start();
						process.WaitForExit();
					}
					this.frmWait_0.method_0();
					FileInfo[] files = new DirectoryInfo(this.string_0).GetFiles();
					for (int i = 0; i < files.Length; i++)
					{
						files[i].Delete();
					}
					foreach (FileInfo fileInfo2 in new DirectoryInfo(Path.Combine(this.string_0, "romfs")).GetFiles())
					{
						fileInfo2.MoveTo(Path.Combine(new string[]
						{
							Path.Combine(this.string_0, fileInfo2.Name)
						}));
					}
					foreach (DirectoryInfo directoryInfo in new DirectoryInfo(Path.Combine(this.string_0, "romfs")).GetDirectories())
					{
						directoryInfo.MoveTo(Path.Combine(new string[]
						{
							Path.Combine(this.string_0, directoryInfo.Name)
						}));
					}
					GClass6.smethod_5(Path.Combine(this.string_0, "romfs"));
				}
				catch (Exception ex)
				{
					RadMessageBox.Show(ex.ToString());
					this.frmWait_0.method_0();
				}
			}

			// Token: 0x040001C0 RID: 448
			public string string_0;

			// Token: 0x040001C1 RID: 449
			public FrmWait frmWait_0;
		}

		// Token: 0x02000068 RID: 104
		[CompilerGenerated]
		private sealed class Class43
		{
			// Token: 0x060002A7 RID: 679 RVA: 0x00025D00 File Offset: 0x00023F00
			internal void method_0(object sender, EventArgs e)
			{
				try
				{
					GClass6.smethod_6(Path.Combine(this.string_0, "game.cia"));
					string name = new DirectoryInfo(this.string_0).GetFiles().First(new Func<FileInfo, bool>(GClass30.<>c.<>c_0.method_2)).Name;
					ProcessStartInfo processStartInfo2;
					if (this.bool_0)
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = "PART2-AES";
						processStartInfo.WorkingDirectory = this.string_0;
						processStartInfo.Arguments = name;
						processStartInfo.CreateNoWindow = true;
						processStartInfo2 = processStartInfo;
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					}
					else
					{
						ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
						processStartInfo3.FileName = "PART2";
						processStartInfo3.WorkingDirectory = this.string_0;
						processStartInfo3.Arguments = name;
						processStartInfo3.CreateNoWindow = true;
						processStartInfo2 = processStartInfo3;
						processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
					}
					ProcessStartInfo startInfo = processStartInfo2;
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Exited += this.method_1;
					process.EnableRaisingEvents = true;
					process.Start();
				}
				catch (Exception ex)
				{
					RadMessageBox.Show(ex.ToString());
					this.frmWait_0.method_0();
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x0001220D File Offset: 0x0001040D
			internal void method_1(object sender, EventArgs e)
			{
				GClass95.smethod_3(this.string_0, Path.Combine(this.string_0, "game.cxi"), true);
				this.frmWait_0.method_0();
			}

			// Token: 0x040001C2 RID: 450
			public string string_0;

			// Token: 0x040001C3 RID: 451
			public bool bool_0;

			// Token: 0x040001C4 RID: 452
			public FrmWait frmWait_0;
		}

		// Token: 0x02000069 RID: 105
		[CompilerGenerated]
		private sealed class Class44
		{
			// Token: 0x060002AA RID: 682 RVA: 0x00025E20 File Offset: 0x00024020
			internal void method_0(object sender, EventArgs e)
			{
				try
				{
					GClass6.smethod_6(this.string_0);
					string name = new DirectoryInfo(this.string_1).GetFiles().Where(new Func<FileInfo, bool>(GClass30.<>c.<>c_0.method_3)).OrderByDescending(new Func<FileInfo, long>(GClass30.<>c.<>c_0.method_4)).ElementAt(0).Name;
					ProcessStartInfo processStartInfo = new ProcessStartInfo
					{
						FileName = "3dstool.exe",
						WorkingDirectory = this.string_1,
						Arguments = string.Format(" -xvtf {0} {1} ", this.bool_0 ? "cfa" : "cxi", name),
						CreateNoWindow = true,
						WindowStyle = ProcessWindowStyle.Hidden
					};
					if (this.bool_1)
					{
						if (this.bool_0)
						{
							throw new Exception("There is no exefs in a CFA!");
						}
						ProcessStartInfo processStartInfo2 = processStartInfo;
						processStartInfo2.Arguments += "--exefs DecryptedExeFS.bin --exefs-top-auto --exefs-auto-key ";
					}
					if (this.bool_2)
					{
						ProcessStartInfo processStartInfo3 = processStartInfo;
						processStartInfo3.Arguments += "--romfs DecryptedRomFS.bin --romfs-auto-key ";
					}
					Process process = new Process();
					process.StartInfo = processStartInfo;
					process.Exited += this.method_1;
					process.EnableRaisingEvents = true;
					process.Start();
				}
				catch
				{
				}
			}

			// Token: 0x060002AB RID: 683 RVA: 0x00025F88 File Offset: 0x00024188
			internal void method_1(object sender, EventArgs e)
			{
				Directory.CreateDirectory(Path.Combine(this.string_1, "romfs"));
				Path.Combine(this.string_1, "romfs");
				Path.Combine(this.string_1, "exefs");
				ProcessStartInfo processStartInfo = new ProcessStartInfo
				{
					FileName = Path.Combine(this.string_1, "3dstool.exe"),
					WorkingDirectory = this.string_1,
					Arguments = "-xvtf"
				};
				if (this.bool_1)
				{
					ProcessStartInfo processStartInfo2 = processStartInfo;
					processStartInfo2.Arguments += " 3dstool -czvtf exefs exefs.bin --header exefsheader.bin --exefs-dir exefs";
				}
				if (this.bool_2)
				{
					ProcessStartInfo processStartInfo3 = processStartInfo;
					processStartInfo3.Arguments += " romfs DecryptedRomFS.bin --romfs-dir romfs";
				}
				Process process = new Process();
				process.StartInfo = processStartInfo;
				process.Exited += this.method_2;
				process.EnableRaisingEvents = true;
				process.Start();
			}

			// Token: 0x060002AC RID: 684 RVA: 0x00026068 File Offset: 0x00024268
			internal void method_2(object sender, EventArgs e)
			{
				FileInfo[] files = new DirectoryInfo(this.string_1).GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					GClass6.smethod_6(files[i].FullName);
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x040001C5 RID: 453
			public string string_0;

			// Token: 0x040001C6 RID: 454
			public string string_1;

			// Token: 0x040001C7 RID: 455
			public bool bool_0;

			// Token: 0x040001C8 RID: 456
			public bool bool_1;

			// Token: 0x040001C9 RID: 457
			public bool bool_2;

			// Token: 0x040001CA RID: 458
			public FrmWait frmWait_0;
		}

		// Token: 0x0200006A RID: 106
		[CompilerGenerated]
		private sealed class Class45
		{
			// Token: 0x060002AE RID: 686 RVA: 0x000260AC File Offset: 0x000242AC
			internal void method_0(object sender, DataReceivedEventArgs e)
			{
				try
				{
					int int_ = (int)((double)long.Parse(e.Data) / this.gclass30_0.Size.TotalBytes * 100.0);
					this.frmWait_0.method_2(int_);
				}
				catch
				{
				}
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00026108 File Offset: 0x00024308
			internal void method_1(object sender, EventArgs e)
			{
				FileSystem.RenameDirectory(this.gclass30_0.String_2, new DirectoryInfo(this.gclass30_0.OutputPath).Name);
				string destFileName = Path.Combine(this.string_0, GClass30.smethod_2(this.string_1) + ".cia");
				GClass6.smethod_6(destFileName);
				File.Move(Path.Combine(this.string_0, this.gclass30_0.TitleId.IdRaw + ".cia"), destFileName);
				this.frmWait_0.method_0();
			}

			// Token: 0x040001CB RID: 459
			public GClass30 gclass30_0;

			// Token: 0x040001CC RID: 460
			public FrmWait frmWait_0;

			// Token: 0x040001CD RID: 461
			public string string_0;

			// Token: 0x040001CE RID: 462
			public string string_1;
		}

		// Token: 0x0200006B RID: 107
		[CompilerGenerated]
		private sealed class Class46
		{
			// Token: 0x060002B1 RID: 689 RVA: 0x00026198 File Offset: 0x00024398
			internal void method_0()
			{
				GClass107 gclass = new GClass107();
				string string_ = Path.Combine(this.gclass30_0.OutputPath, "title.cert");
				string string_2 = Path.Combine(this.gclass30_0.OutputPath, "title.tik");
				string string_3 = Path.Combine(this.gclass30_0.OutputPath, "title.tmd");
				EventHandler<ProgressChangedEventArgs> value;
				if ((value = this.eventHandler_0) == null)
				{
					value = (this.eventHandler_0 = new EventHandler<ProgressChangedEventArgs>(this.method_1));
				}
				gclass.Event_0 += value;
				gclass.method_0(string_, string_2, string_3, this.gclass30_0.OutputPath);
				Directory.CreateDirectory(this.string_0);
				gclass.method_1(Path.Combine(this.string_0, this.string_1));
				this.frmWait_0.method_0();
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x00012236 File Offset: 0x00010436
			internal void method_1(object sender, ProgressChangedEventArgs e)
			{
				this.frmWait_0.method_2(e.ProgressPercentage);
			}

			// Token: 0x040001CF RID: 463
			public GClass30 gclass30_0;

			// Token: 0x040001D0 RID: 464
			public FrmWait frmWait_0;

			// Token: 0x040001D1 RID: 465
			public string string_0;

			// Token: 0x040001D2 RID: 466
			public string string_1;

			// Token: 0x040001D3 RID: 467
			public EventHandler<ProgressChangedEventArgs> eventHandler_0;
		}

		// Token: 0x0200006C RID: 108
		[CompilerGenerated]
		private sealed class Class47
		{
			// Token: 0x040001D4 RID: 468
			public bool bool_0;
		}

		// Token: 0x0200006D RID: 109
		[CompilerGenerated]
		private sealed class Class48
		{
			// Token: 0x060002B5 RID: 693 RVA: 0x00012249 File Offset: 0x00010449
			internal void method_0(object object_0, GStruct0 gstruct0_0)
			{
				this.frmUnpackAnimation_0.method_1(gstruct0_0);
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00012257 File Offset: 0x00010457
			internal void method_1(object object_0, bool bool_1)
			{
				this.class47_0.bool_0 = bool_1;
				this.bool_0 = true;
				this.frmUnpackAnimation_0.method_0();
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00012277 File Offset: 0x00010477
			internal void method_2(object object_0, Exception exception_0)
			{
				RadMessageBox.Show("An error has occured.\n" + exception_0);
				this.frmUnpackAnimation_0.method_0();
			}

			// Token: 0x040001D5 RID: 469
			public frmUnpackAnimation frmUnpackAnimation_0;

			// Token: 0x040001D6 RID: 470
			public bool bool_0;

			// Token: 0x040001D7 RID: 471
			public GClass30.Class47 class47_0;
		}

		// Token: 0x0200006E RID: 110
		[CompilerGenerated]
		private sealed class Class49
		{
			// Token: 0x060002B9 RID: 697 RVA: 0x00026254 File Offset: 0x00024454
			internal void method_0(object sender, EventArgs e)
			{
				this.gclass30_0.CurrentlyUploaded = false;
				if (!this.gclass30_0.class58_0.TransferStatus.Error)
				{
					if (this.gclass30_0 is GClass32)
					{
						((GClass32)this.gclass30_0).Boolean_5 = true;
					}
					if (this.bool_0)
					{
						this.gclass30_0.class58_0.method_12(this.string_0);
					}
				}
				EventHandler<GClass81> eventHandler_ = this.gclass30_0.eventHandler_0;
				if (eventHandler_ == null)
				{
					return;
				}
				eventHandler_(this.gclass30_0, this.gclass30_0.class58_0.TransferStatus);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x000262EC File Offset: 0x000244EC
			internal void method_1(object object_0, long long_2)
			{
				try
				{
					this.long_0 += long_2;
					this.ulong_0 += (ulong)long_2;
					if ((DateTime.Now - this.dateTime_0).TotalSeconds < 2.0)
					{
						return;
					}
					GStruct3 gstruct = new GStruct3(new DataSize(this.ulong_0), DateTime.Now - this.dateTime_0);
					int num = (int)((double)this.long_0 / (double)this.long_1 * 100.0);
					if (num > 100)
					{
						num = 100;
					}
					TimeSpan timeSpan = GStruct3.smethod_1(new DataSize((ulong)(this.long_1 - this.long_0)), gstruct);
					EventHandler<GEventArgs0> eventHandler_ = this.gclass30_0.eventHandler_1;
					if (eventHandler_ != null)
					{
						eventHandler_(this.gclass30_0, new GEventArgs0(num, num, num, timeSpan, timeSpan, timeSpan, gstruct, this.gclass30_0));
					}
				}
				catch
				{
				}
				this.dateTime_0 = DateTime.Now;
				this.ulong_0 = 0UL;
			}

			// Token: 0x040001D8 RID: 472
			public GClass30 gclass30_0;

			// Token: 0x040001D9 RID: 473
			public bool bool_0;

			// Token: 0x040001DA RID: 474
			public string string_0;

			// Token: 0x040001DB RID: 475
			public long long_0;

			// Token: 0x040001DC RID: 476
			public ulong ulong_0;

			// Token: 0x040001DD RID: 477
			public DateTime dateTime_0;

			// Token: 0x040001DE RID: 478
			public long long_1;
		}

		// Token: 0x0200006F RID: 111
		[CompilerGenerated]
		private sealed class Class50
		{
			// Token: 0x060002BC RID: 700 RVA: 0x00012295 File Offset: 0x00010495
			internal void method_0()
			{
				this.list_0 = Class83.smethod_1(this.gclass30_0);
				this.frmWait_0.method_0();
			}

			// Token: 0x040001DF RID: 479
			public List<GStruct7> list_0;

			// Token: 0x040001E0 RID: 480
			public GClass30 gclass30_0;

			// Token: 0x040001E1 RID: 481
			public FrmWait frmWait_0;
		}
	}
}
