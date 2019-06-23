using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WIIU_Downloader.Properties
{
	// Token: 0x02000169 RID: 361
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x000171FF File Offset: 0x000153FF
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00017206 File Offset: 0x00015406
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00017218 File Offset: 0x00015418
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("NONE")]
		public string Region
		{
			get
			{
				return (string)this["Region"];
			}
			set
			{
				this["Region"] = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00017226 File Offset: 0x00015426
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00017238 File Offset: 0x00015438
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool Cleanup
		{
			get
			{
				return (bool)this["Cleanup"];
			}
			set
			{
				this["Cleanup"] = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0001724B File Offset: 0x0001544B
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0001725D File Offset: 0x0001545D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Path
		{
			get
			{
				return (string)this["Path"];
			}
			set
			{
				this["Path"] = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0001726B File Offset: 0x0001546B
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0001727D File Offset: 0x0001547D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string TicketsPath
		{
			get
			{
				return (string)this["TicketsPath"];
			}
			set
			{
				this["TicketsPath"] = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0001728B File Offset: 0x0001548B
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0001729D File Offset: 0x0001549D
		[DefaultSettingValue("DarkOrange")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ThemeName
		{
			get
			{
				return (string)this["ThemeName"];
			}
			set
			{
				this["ThemeName"] = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000172AB File Offset: 0x000154AB
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000172BD File Offset: 0x000154BD
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool CompactView
		{
			get
			{
				return (bool)this["CompactView"];
			}
			set
			{
				this["CompactView"] = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000172D0 File Offset: 0x000154D0
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000172E2 File Offset: 0x000154E2
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ShowLegit
		{
			get
			{
				return (bool)this["ShowLegit"];
			}
			set
			{
				this["ShowLegit"] = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x000172F5 File Offset: 0x000154F5
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00017307 File Offset: 0x00015507
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool ShowCFW
		{
			get
			{
				return (bool)this["ShowCFW"];
			}
			set
			{
				this["ShowCFW"] = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0001731A File Offset: 0x0001551A
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0001732C File Offset: 0x0001552C
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool ShowEvents
		{
			get
			{
				return (bool)this["ShowEvents"];
			}
			set
			{
				this["ShowEvents"] = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0001733F File Offset: 0x0001553F
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00017351 File Offset: 0x00015551
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public long LastNewsDate
		{
			get
			{
				return (long)this["LastNewsDate"];
			}
			set
			{
				this["LastNewsDate"] = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00017364 File Offset: 0x00015564
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00017376 File Offset: 0x00015576
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string TicketsPath3DS
		{
			get
			{
				return (string)this["TicketsPath3DS"];
			}
			set
			{
				this["TicketsPath3DS"] = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00017384 File Offset: 0x00015584
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00017396 File Offset: 0x00015596
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool Boolean_0
		{
			get
			{
				return (bool)this["EUR"];
			}
			set
			{
				this["EUR"] = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000173A9 File Offset: 0x000155A9
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x000173BB File Offset: 0x000155BB
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Boolean_1
		{
			get
			{
				return (bool)this["JPN"];
			}
			set
			{
				this["JPN"] = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000173CE File Offset: 0x000155CE
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000173E0 File Offset: 0x000155E0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool Boolean_2
		{
			get
			{
				return (bool)this["USA"];
			}
			set
			{
				this["USA"] = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x000173F3 File Offset: 0x000155F3
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00017405 File Offset: 0x00015605
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string CemuExecutable
		{
			get
			{
				return (string)this["CemuExecutable"];
			}
			set
			{
				this["CemuExecutable"] = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00017413 File Offset: 0x00015613
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00017425 File Offset: 0x00015625
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExtractFolder
		{
			get
			{
				return (string)this["ExtractFolder"];
			}
			set
			{
				this["ExtractFolder"] = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00017433 File Offset: 0x00015633
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00017445 File Offset: 0x00015645
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string DonationKey
		{
			get
			{
				return (string)this["DonationKey"];
			}
			set
			{
				this["DonationKey"] = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00017453 File Offset: 0x00015653
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00017465 File Offset: 0x00015665
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public int LaunchCount
		{
			get
			{
				return (int)this["LaunchCount"];
			}
			set
			{
				this["LaunchCount"] = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00017478 File Offset: 0x00015678
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0001748A File Offset: 0x0001568A
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string Platforms
		{
			get
			{
				return (string)this["Platforms"];
			}
			set
			{
				this["Platforms"] = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00017498 File Offset: 0x00015698
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000174AA File Offset: 0x000156AA
		[UserScopedSetting]
		[DefaultSettingValue("0, 0, 0, 0")]
		[DebuggerNonUserCode]
		public Rectangle WindowPosition
		{
			get
			{
				return (Rectangle)this["WindowPosition"];
			}
			set
			{
				this["WindowPosition"] = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000174BD File Offset: 0x000156BD
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x000174CF File Offset: 0x000156CF
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		[UserScopedSetting]
		public FormWindowState WindowState
		{
			get
			{
				return (FormWindowState)this["WindowState"];
			}
			set
			{
				this["WindowState"] = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000174E2 File Offset: 0x000156E2
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x000174F4 File Offset: 0x000156F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool ForceUpdates
		{
			get
			{
				return (bool)this["ForceUpdates"];
			}
			set
			{
				this["ForceUpdates"] = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00017507 File Offset: 0x00015707
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00017519 File Offset: 0x00015719
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowHaxchiWarning
		{
			get
			{
				return (bool)this["ShowHaxchiWarning"];
			}
			set
			{
				this["ShowHaxchiWarning"] = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0001752C File Offset: 0x0001572C
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0001753E File Offset: 0x0001573E
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ForceUpdatesCitra
		{
			get
			{
				return (bool)this["ForceUpdatesCitra"];
			}
			set
			{
				this["ForceUpdatesCitra"] = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00017551 File Offset: 0x00015751
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00017563 File Offset: 0x00015763
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowEmulatorDataWarning
		{
			get
			{
				return (bool)this["ShowEmulatorDataWarning"];
			}
			set
			{
				this["ShowEmulatorDataWarning"] = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00017576 File Offset: 0x00015776
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00017588 File Offset: 0x00015788
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ShowProgramFilesWarning
		{
			get
			{
				return (bool)this["ShowProgramFilesWarning"];
			}
			set
			{
				this["ShowProgramFilesWarning"] = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0001759B File Offset: 0x0001579B
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000175AD File Offset: 0x000157AD
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ShowCitraWarning
		{
			get
			{
				return (bool)this["ShowCitraWarning"];
			}
			set
			{
				this["ShowCitraWarning"] = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000175C0 File Offset: 0x000157C0
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x000175D2 File Offset: 0x000157D2
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool Show552Warning
		{
			get
			{
				return (bool)this["Show552Warning"];
			}
			set
			{
				this["Show552Warning"] = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x000175E5 File Offset: 0x000157E5
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x000175F7 File Offset: 0x000157F7
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool ForceUpdatesDolphin
		{
			get
			{
				return (bool)this["ForceUpdatesDolphin"];
			}
			set
			{
				this["ForceUpdatesDolphin"] = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0001760A File Offset: 0x0001580A
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0001761C File Offset: 0x0001581C
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool Boolean_3
		{
			get
			{
				return (bool)this["KOR"];
			}
			set
			{
				this["KOR"] = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0001762F File Offset: 0x0001582F
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00017641 File Offset: 0x00015841
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool EnableSuperSpeed
		{
			get
			{
				return (bool)this["EnableSuperSpeed"];
			}
			set
			{
				this["EnableSuperSpeed"] = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00017654 File Offset: 0x00015854
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00017666 File Offset: 0x00015866
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public ulong MeasuredSpeed
		{
			get
			{
				return (ulong)this["MeasuredSpeed"];
			}
			set
			{
				this["MeasuredSpeed"] = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00017679 File Offset: 0x00015879
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0001768B File Offset: 0x0001588B
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool Mine
		{
			get
			{
				return (bool)this["Mine"];
			}
			set
			{
				this["Mine"] = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001769E File Offset: 0x0001589E
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000176B0 File Offset: 0x000158B0
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string AppId
		{
			get
			{
				return (string)this["AppId"];
			}
			set
			{
				this["AppId"] = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000176BE File Offset: 0x000158BE
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000176D0 File Offset: 0x000158D0
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool ForceGameMode
		{
			get
			{
				return (bool)this["ForceGameMode"];
			}
			set
			{
				this["ForceGameMode"] = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000176E3 File Offset: 0x000158E3
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x000176F5 File Offset: 0x000158F5
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool PauseMiner
		{
			get
			{
				return (bool)this["PauseMiner"];
			}
			set
			{
				this["PauseMiner"] = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00017708 File Offset: 0x00015908
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0001771A File Offset: 0x0001591A
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool EnableCloudSaving
		{
			get
			{
				return (bool)this["EnableCloudSaving"];
			}
			set
			{
				this["EnableCloudSaving"] = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001772D File Offset: 0x0001592D
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0001773F File Offset: 0x0001593F
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string CloudUserName
		{
			get
			{
				return (string)this["CloudUserName"];
			}
			set
			{
				this["CloudUserName"] = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0001774D File Offset: 0x0001594D
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0001775F File Offset: 0x0001595F
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string CloudPassWord
		{
			get
			{
				return (string)this["CloudPassWord"];
			}
			set
			{
				this["CloudPassWord"] = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0001776D File Offset: 0x0001596D
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0001777F File Offset: 0x0001597F
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool ShowDownloadManagerTip
		{
			get
			{
				return (bool)this["ShowDownloadManagerTip"];
			}
			set
			{
				this["ShowDownloadManagerTip"] = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00017792 File Offset: 0x00015992
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x000177A4 File Offset: 0x000159A4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool ShowSpeedGraph
		{
			get
			{
				return (bool)this["ShowSpeedGraph"];
			}
			set
			{
				this["ShowSpeedGraph"] = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x000177B7 File Offset: 0x000159B7
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000177C9 File Offset: 0x000159C9
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool ChatNotifications
		{
			get
			{
				return (bool)this["ChatNotifications"];
			}
			set
			{
				this["ChatNotifications"] = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000177DC File Offset: 0x000159DC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000177EE File Offset: 0x000159EE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string TicketsPathWii
		{
			get
			{
				return (string)this["TicketsPathWii"];
			}
			set
			{
				this["TicketsPathWii"] = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000177FC File Offset: 0x000159FC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0001780E File Offset: 0x00015A0E
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		public bool GameSpecificRoom
		{
			get
			{
				return (bool)this["GameSpecificRoom"];
			}
			set
			{
				this["GameSpecificRoom"] = value;
			}
		}

		// Token: 0x040005EA RID: 1514
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
