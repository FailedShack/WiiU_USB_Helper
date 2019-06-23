using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000168 RID: 360
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[CompilerGenerated]
	internal class Class121
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x0001083B File Offset: 0x0000EA3B
		internal Class121()
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00016660 File Offset: 0x00014860
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class121.resourceManager_0 == null)
				{
					Class121.resourceManager_0 = new ResourceManager("ns0.Class121", typeof(Class121).Assembly);
				}
				return Class121.resourceManager_0;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0001668C File Offset: 0x0001488C
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00016693 File Offset: 0x00014893
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class121.cultureInfo_0;
			}
			set
			{
				Class121.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0001669B File Offset: 0x0001489B
		internal static Bitmap arrowDown
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("arrowDown", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000166B6 File Offset: 0x000148B6
		internal static Bitmap arrowUP
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("arrowUP", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x000166D1 File Offset: 0x000148D1
		internal static Bitmap banner
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("banner", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000166EC File Offset: 0x000148EC
		internal static Bitmap bg
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("bg", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00016707 File Offset: 0x00014907
		internal static byte[] contb
		{
			get
			{
				return (byte[])Class121.ResourceManager.GetObject("contb", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00016722 File Offset: 0x00014922
		internal static Bitmap dlc
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("dlc", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0001673D File Offset: 0x0001493D
		internal static Bitmap dlIcon
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("dlIcon", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00016758 File Offset: 0x00014958
		internal static Bitmap dlTabGif
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("dlTabGif", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00016773 File Offset: 0x00014973
		internal static Bitmap dsiwareicon
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("dsiwareicon", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0001678E File Offset: 0x0001498E
		internal static Bitmap error
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("error", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000167A9 File Offset: 0x000149A9
		internal static Bitmap eurFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("eurFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000167C4 File Offset: 0x000149C4
		internal static string exploit
		{
			get
			{
				return Class121.ResourceManager.GetString("exploit", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000167DA File Offset: 0x000149DA
		internal static Bitmap filestruct
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("filestruct", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000167F5 File Offset: 0x000149F5
		internal static Bitmap fldIcon
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("fldIcon", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00016810 File Offset: 0x00014A10
		internal static Bitmap frenchFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("frenchFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0001682B File Offset: 0x00014A2B
		internal static string genres
		{
			get
			{
				return Class121.ResourceManager.GetString("genres", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00016841 File Offset: 0x00014A41
		internal static Bitmap glbIcon
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("glbIcon", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0001685C File Offset: 0x00014A5C
		internal static Bitmap hasDLC
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("hasDLC", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00016877 File Offset: 0x00014A77
		internal static Bitmap hasDLCOk
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("hasDLCOk", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00016892 File Offset: 0x00014A92
		internal static Bitmap hasUpdate
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("hasUpdate", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000168AD File Offset: 0x00014AAD
		internal static Bitmap hasUpdateOk
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("hasUpdateOk", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000168C8 File Offset: 0x00014AC8
		internal static Bitmap helperLoader
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("helperLoader", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000168E3 File Offset: 0x00014AE3
		internal static Bitmap helperLoagBg
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("helperLoagBg", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000168FE File Offset: 0x00014AFE
		internal static Bitmap icnArrow
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnArrow", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00016919 File Offset: 0x00014B19
		internal static Bitmap icnBug
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnBug", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00016934 File Offset: 0x00014B34
		internal static Bitmap icnCaseMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnCaseMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0001694F File Offset: 0x00014B4F
		internal static Bitmap icnDesktop
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnDesktop", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0001696A File Offset: 0x00014B6A
		internal static Bitmap icnDisk
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnDisk", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00016985 File Offset: 0x00014B85
		internal static Bitmap icnDownloadedMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnDownloadedMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000169A0 File Offset: 0x00014BA0
		internal static Bitmap icnExtract
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnExtract", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000169BB File Offset: 0x00014BBB
		internal static Bitmap icnFunnelMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnFunnelMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000169D6 File Offset: 0x00014BD6
		internal static Bitmap icnGearMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnGearMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000169F1 File Offset: 0x00014BF1
		internal static Bitmap icnGlassMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnGlassMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00016A0C File Offset: 0x00014C0C
		internal static Bitmap icnHelpMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnHelpMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00016A27 File Offset: 0x00014C27
		internal static Bitmap icnMiniChat
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnMiniChat", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00016A42 File Offset: 0x00014C42
		internal static Bitmap icnMovieMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnMovieMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00016A5D File Offset: 0x00014C5D
		internal static Bitmap icnNotDownloadedMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnNotDownloadedMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00016A78 File Offset: 0x00014C78
		internal static Bitmap icnPartialMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnPartialMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00016A93 File Offset: 0x00014C93
		internal static Bitmap icnPlay
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnPlay", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00016AAE File Offset: 0x00014CAE
		internal static Bitmap icnPlayMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnPlayMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00016AC9 File Offset: 0x00014CC9
		internal static Bitmap icnSaveMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnSaveMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00016AE4 File Offset: 0x00014CE4
		internal static Bitmap icnScreenshotMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnScreenshotMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00016AFF File Offset: 0x00014CFF
		internal static Bitmap icnSd
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnSd", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00016B1A File Offset: 0x00014D1A
		internal static Bitmap icnServer
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnServer", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00016B35 File Offset: 0x00014D35
		internal static Bitmap icnStarMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnStarMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00016B50 File Offset: 0x00014D50
		internal static Bitmap icnSteam
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnSteam", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00016B6B File Offset: 0x00014D6B
		internal static Bitmap icnSteamFlat
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnSteamFlat", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00016B86 File Offset: 0x00014D86
		internal static Bitmap icnTicket
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnTicket", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00016BA1 File Offset: 0x00014DA1
		internal static Bitmap icnTrophy
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnTrophy", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00016BBC File Offset: 0x00014DBC
		internal static Bitmap icnTrophyMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnTrophyMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00016BD7 File Offset: 0x00014DD7
		internal static Bitmap icnWebMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnWebMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00016BF2 File Offset: 0x00014DF2
		internal static Bitmap icnWiiU
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnWiiU", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00016C0D File Offset: 0x00014E0D
		internal static Bitmap icnWiiuMini
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnWiiuMini", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00016C28 File Offset: 0x00014E28
		internal static Bitmap icnWiiuMini1
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("icnWiiuMini1", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00016C43 File Offset: 0x00014E43
		internal static Bitmap imgArrow
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("imgArrow", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00016C5E File Offset: 0x00014E5E
		internal static Bitmap imgHowToUseCloudSaving
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("imgHowToUseCloudSaving", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00016C79 File Offset: 0x00014E79
		internal static Bitmap jpnFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("jpnFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00016C94 File Offset: 0x00014E94
		internal static string keysPub
		{
			get
			{
				return Class121.ResourceManager.GetString("keysPub", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00016CAA File Offset: 0x00014EAA
		internal static Bitmap korFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("korFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00016CC5 File Offset: 0x00014EC5
		internal static string legal
		{
			get
			{
				return Class121.ResourceManager.GetString("legal", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00016CDB File Offset: 0x00014EDB
		internal static Bitmap logo
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("logo", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00016CF6 File Offset: 0x00014EF6
		internal static Bitmap logo_horiz
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("logo_horiz", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00016D11 File Offset: 0x00014F11
		internal static Icon logo2T_png
		{
			get
			{
				return (Icon)Class121.ResourceManager.GetObject("logo2T_png", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00016D2C File Offset: 0x00014F2C
		internal static Bitmap logo3ds
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("logo3ds", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00016D47 File Offset: 0x00014F47
		internal static Bitmap logoWii
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("logoWii", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00016D62 File Offset: 0x00014F62
		internal static Bitmap logoWiiU
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("logoWiiU", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00016D7D File Offset: 0x00014F7D
		internal static byte[] makecia
		{
			get
			{
				return (byte[])Class121.ResourceManager.GetObject("makecia", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00016D98 File Offset: 0x00014F98
		internal static Bitmap newTag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("newTag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00016DB3 File Offset: 0x00014FB3
		internal static Bitmap notfound
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("notfound", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00016DCE File Offset: 0x00014FCE
		internal static Bitmap path3
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("path3", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00016DE9 File Offset: 0x00014FE9
		internal static Bitmap path3347
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("path3347", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00016E04 File Offset: 0x00015004
		internal static Bitmap PFM10P30P10P124P125P165
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM10P30P10P124P125P165", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00016E1F File Offset: 0x0001501F
		internal static Bitmap PFM164P657P1004P4002
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM164P657P1004P4002", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00016E3A File Offset: 0x0001503A
		internal static Bitmap PFM167P4009
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM167P4009", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00016E55 File Offset: 0x00015055
		internal static Bitmap PFM170P658P4003
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM170P658P4003", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00016E70 File Offset: 0x00015070
		internal static Bitmap PFM171P656P4010P4011
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM171P656P4010P4011", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00016E8B File Offset: 0x0001508B
		internal static Bitmap PFM19P24P43P83P103P1001P1002
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM19P24P43P83P103P1001P1002", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00016EA6 File Offset: 0x000150A6
		internal static Bitmap PFM20P169
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM20P169", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00016EC1 File Offset: 0x000150C1
		internal static Bitmap PFM21P22
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM21P22", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00016EDC File Offset: 0x000150DC
		internal static Bitmap PFM23P168
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM23P168", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00016EF7 File Offset: 0x000150F7
		internal static Bitmap PFM24P163P4001
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM24P163P4001", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00016F12 File Offset: 0x00015112
		internal static Bitmap PFM25
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM25", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00016F2D File Offset: 0x0001512D
		internal static Bitmap PFM26P166P4006
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM26P166P4006", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00016F48 File Offset: 0x00015148
		internal static Bitmap PFM4000
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM4000", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00016F63 File Offset: 0x00015163
		internal static Bitmap PFM4004
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM4004", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00016F7E File Offset: 0x0001517E
		internal static Bitmap PFM4005
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM4005", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00016F99 File Offset: 0x00015199
		internal static Bitmap PFM4007
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM4007", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00016FB4 File Offset: 0x000151B4
		internal static Bitmap PFM4008
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM4008", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00016FCF File Offset: 0x000151CF
		internal static Bitmap PFM655
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("PFM655", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00016FEA File Offset: 0x000151EA
		internal static Bitmap Rolling
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("Rolling", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00017005 File Offset: 0x00015205
		internal static byte[] rpl2elf
		{
			get
			{
				return (byte[])Class121.ResourceManager.GetObject("rpl2elf", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00017020 File Offset: 0x00015220
		internal static byte[] rvl
		{
			get
			{
				return (byte[])Class121.ResourceManager.GetObject("rvl", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0001703B File Offset: 0x0001523B
		internal static Bitmap semiTransparent
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("semiTransparent", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00017056 File Offset: 0x00015256
		internal static UnmanagedMemoryStream sndAdd
		{
			get
			{
				return Class121.ResourceManager.GetStream("sndAdd", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0001706C File Offset: 0x0001526C
		internal static UnmanagedMemoryStream sndNotification
		{
			get
			{
				return Class121.ResourceManager.GetStream("sndNotification", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00017082 File Offset: 0x00015282
		internal static Bitmap squares
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("squares", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0001709D File Offset: 0x0001529D
		internal static Bitmap startMiner
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("startMiner", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000170B8 File Offset: 0x000152B8
		internal static Bitmap stopMiner
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("stopMiner", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000170D3 File Offset: 0x000152D3
		internal static Bitmap tag3ds
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("tag3ds", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000170EE File Offset: 0x000152EE
		internal static Bitmap tagWii
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("tagWii", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00017109 File Offset: 0x00015309
		internal static Bitmap tagWiiU
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("tagWiiU", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00017124 File Offset: 0x00015324
		internal static Bitmap theme_preview
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("theme_preview", Class121.cultureInfo_0);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001713F File Offset: 0x0001533F
		internal static Bitmap transferAnim
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("transferAnim", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001715A File Offset: 0x0001535A
		internal static Bitmap UKFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("UKFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00017175 File Offset: 0x00015375
		internal static Bitmap updIcon
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("updIcon", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00017190 File Offset: 0x00015390
		internal static Bitmap usaFlag
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("usaFlag", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000171AB File Offset: 0x000153AB
		internal static Bitmap warning
		{
			get
			{
				return (Bitmap)Class121.ResourceManager.GetObject("warning", Class121.cultureInfo_0);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x000171C6 File Offset: 0x000153C6
		internal static byte[] wfsdump
		{
			get
			{
				return (byte[])Class121.ResourceManager.GetObject("wfsdump", Class121.cultureInfo_0);
			}
		}

		// Token: 0x040005E8 RID: 1512
		private static ResourceManager resourceManager_0;

		// Token: 0x040005E9 RID: 1513
		private static CultureInfo cultureInfo_0;
	}
}
