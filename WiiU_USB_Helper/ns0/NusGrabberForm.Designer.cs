namespace ns0
{
	// Token: 0x020001D2 RID: 466
	public partial class NusGrabberForm : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000D5C RID: 3420 RVA: 0x000193AC File Offset: 0x000175AC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00056CE0 File Offset: 0x00054EE0
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Region");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Size");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Completion");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Update");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Dlc");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "Console");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.NusGrabberForm));
			global::Telerik.WinControls.UI.Docking.AutoHideGroup autoHideGroup = new global::Telerik.WinControls.UI.Docking.AutoHideGroup();
			global::Telerik.WinControls.UI.Docking.AutoHideGroup autoHideGroup2 = new global::Telerik.WinControls.UI.Docking.AutoHideGroup();
			global::Telerik.WinControls.UI.CarouselBezierPath carouselBezierPath = new global::Telerik.WinControls.UI.CarouselBezierPath();
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Column 0");
			this.dockWindowPlaceholder1 = new global::Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
			this.dockWindowPlaceholder2 = new global::Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
			this.FTSearchBox = new global::Telerik.WinControls.UI.RadTextBox();
			this.lstGames = new global::Telerik.WinControls.UI.RadListView();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.label2 = new global::Telerik.WinControls.UI.RadLabel();
			this.dlQueue = new global::Telerik.WinControls.UI.RadListView();
			this.lblTotalToDl = new global::Telerik.WinControls.UI.RadLabel();
			this.lblTotalDl = new global::Telerik.WinControls.UI.RadLabel();
			this.lblNbGms = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox7 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.chkPrepareEmulation = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkPack = new global::Telerik.WinControls.UI.RadCheckBox();
			this.radDate = new global::System.Windows.Forms.DateTimePicker();
			this.cmdAbortDelay = new global::Telerik.WinControls.UI.RadButton();
			this.lblTimeLeft = new global::Telerik.WinControls.UI.RadLabel();
			this.chkUnpack = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkCopyToSD = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkSleep = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkShutdown = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkDelay = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkHibernate = new global::Telerik.WinControls.UI.RadCheckBox();
			this.grpProgressAll = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblTotalEta = new global::Telerik.WinControls.UI.RadLabel();
			this.totalProgress = new global::Telerik.WinControls.UI.RadProgressBar();
			this.radLabel9 = new global::Telerik.WinControls.UI.RadLabel();
			this.radMaxSpeed = new global::Telerik.WinControls.UI.RadSpinEditor();
			this.cmdAbortAll = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox3 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdDelete = new global::Telerik.WinControls.UI.RadButton();
			this.cmdCopy = new global::Telerik.WinControls.UI.RadButton();
			this.cmdAddDlc = new global::Telerik.WinControls.UI.RadButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.cmdAddUpdate = new global::Telerik.WinControls.UI.RadButton();
			this.cmdAddGame = new global::Telerik.WinControls.UI.RadButton();
			this.lblTitle = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox2 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblFileEta = new global::Telerik.WinControls.UI.RadLabel();
			this.pgFile = new global::Telerik.WinControls.UI.RadProgressBar();
			this.grpProgressCurrent = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblEta = new global::Telerik.WinControls.UI.RadLabel();
			this.NUSGrabberProgress = new global::Telerik.WinControls.UI.RadProgressBar();
			this.dockMain = new global::Telerik.WinControls.UI.Docking.RadDock();
			this.toolCopy = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.lstCopy = new global::Telerik.WinControls.UI.RadListView();
			this.cmdSendWiiu = new global::Telerik.WinControls.UI.RadButton();
			this.cmdManageRemoteSd = new global::Telerik.WinControls.UI.RadButton();
			this.cmdInitiateCopy = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox10 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblTotalCopy = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel6 = new global::Telerik.WinControls.UI.RadLabel();
			this.toolTabStrip3 = new global::Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolWindow5 = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.pbBanner = new global::System.Windows.Forms.PictureBox();
			this.radSplitContainer3 = new global::Telerik.WinControls.UI.RadSplitContainer();
			this.documentContainer1 = new global::Telerik.WinControls.UI.Docking.DocumentContainer();
			this.documentTabStrip1 = new global::Telerik.WinControls.UI.Docking.DocumentTabStrip();
			this.toolLibrary = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox4 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radSplitContainer1 = new global::Telerik.WinControls.UI.RadSplitContainer();
			this.splitPanel1 = new global::Telerik.WinControls.UI.SplitPanel();
			this.chkCompactView = new global::Telerik.WinControls.UI.RadCheckBox();
			this.panelLibraryCheckbox = new global::Telerik.WinControls.UI.RadPanel();
			this.chkShowLegit = new global::System.Windows.Forms.CheckBox();
			this.chkShowRednand = new global::System.Windows.Forms.CheckBox();
			this.chkShowPreviews = new global::System.Windows.Forms.CheckBox();
			this.splitPanel2 = new global::Telerik.WinControls.UI.SplitPanel();
			this.radGroupBox9 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdClearDl = new global::Telerik.WinControls.UI.RadButton();
			this.toolFilters = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox12 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.treePlatforms = new global::Telerik.WinControls.UI.RadTreeView();
			this.radGroupBox13 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.chkKOR = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkJAP = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkUSA = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkEUR = new global::Telerik.WinControls.UI.RadCheckBox();
			this.toolAdvancedSearch = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox25 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.chkGameGenres = new global::Telerik.WinControls.UI.RadCheckedListBox();
			this.cmdSearchWithCriterias = new global::Telerik.WinControls.UI.RadButton();
			this.cmdClearCriterias = new global::Telerik.WinControls.UI.RadButton();
			this.toolAdvancedSettings = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox28 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblStorageLocation = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton5 = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox22 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.chkDisableSpeedGraph = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkPreventShortcut = new global::Telerik.WinControls.UI.RadCheckBox();
			this.radGroupBox14 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblproxyStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel12 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdClearProxy = new global::Telerik.WinControls.UI.RadButton();
			this.cmdSetProxy = new global::Telerik.WinControls.UI.RadButton();
			this.radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.txtProxyUsr = new global::Telerik.WinControls.UI.RadTextBox();
			this.txtProxyPassword = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel11 = new global::Telerik.WinControls.UI.RadLabel();
			this.txtProxyUrl = new global::Telerik.WinControls.UI.RadTextBox();
			this.radLabel10 = new global::Telerik.WinControls.UI.RadLabel();
			this.toolEmuSettings = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox5 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radButton7 = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox21 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radLabel22 = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton2 = new global::Telerik.WinControls.UI.RadButton();
			this.chkForceGameMode = new global::Telerik.WinControls.UI.RadCheckBox();
			this.radLabel23 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel13 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox17 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radButton4 = new global::Telerik.WinControls.UI.RadButton();
			this.toolContribute = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox15 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox16 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdDonate = new global::Telerik.WinControls.UI.RadButton();
			this.lblDonatorDate = new global::Telerik.WinControls.UI.RadLabel();
			this.lblDonatorStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel18 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblDonatorEmail = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel16 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel15 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel14 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox20 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdSugegstIdea = new global::Telerik.WinControls.UI.RadButton();
			this.toolHelp = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox24 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdPrepareSd = new global::Telerik.WinControls.UI.RadButton();
			this.toolTabStrip1 = new global::Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolGameInfo = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox6 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.dockInfo = new global::Telerik.WinControls.UI.Docking.RadDock();
			this.toolGameDesc = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.txtDesc = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.panelGameCover = new global::Telerik.WinControls.UI.RadPanel();
			this.cmdShortcut = new global::Telerik.WinControls.UI.RadButton();
			this.cmdPlay = new global::Telerik.WinControls.UI.RadButton();
			this.pictureLogo = new global::System.Windows.Forms.PictureBox();
			this.pbCover = new global::System.Windows.Forms.PictureBox();
			this.documentContainer2 = new global::Telerik.WinControls.UI.Docking.DocumentContainer();
			this.documentTabStrip2 = new global::Telerik.WinControls.UI.Docking.DocumentTabStrip();
			this.toolMods = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.lblModsOnlyCemu = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox29 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lstMods = new global::Telerik.WinControls.UI.RadCheckedListBox();
			this.txtModSearch = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.cmdModContribute = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox27 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.modPreview = new global::Telerik.WinControls.UI.RadCarousel();
			this.txtModDescription = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.toolExtraInfo = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radGroupBox11 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblLang = new global::System.Windows.Forms.Label();
			this.lstLanguages = new global::Telerik.WinControls.UI.RadListView();
			this.pbRating = new global::System.Windows.Forms.PictureBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lstGenre = new global::Telerik.WinControls.UI.RadListView();
			this.pgScore = new global::Telerik.WinControls.UI.RadProgressBar();
			this.lstControllers = new global::Telerik.WinControls.UI.RadListView();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.toolScreenShot = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.pbPreview3 = new global::System.Windows.Forms.PictureBox();
			this.pbPreview1 = new global::System.Windows.Forms.PictureBox();
			this.pbPreview2 = new global::System.Windows.Forms.PictureBox();
			this.toolWeb = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.webBrowser = new global::System.Windows.Forms.WebBrowser();
			this.radGroupBox8 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdGoNext = new global::Telerik.WinControls.UI.RadButton();
			this.cmdGoBack = new global::Telerik.WinControls.UI.RadButton();
			this.toolMovies = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.lstMovies = new global::Telerik.WinControls.UI.RadListView();
			this.radLabel7 = new global::Telerik.WinControls.UI.RadLabel();
			this.tollSaveManager = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.cmdCommunitySaves = new global::Telerik.WinControls.UI.RadButton();
			this.cmdImportCemu = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel8 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdRestoreSave = new global::Telerik.WinControls.UI.RadButton();
			this.cmdBackupSave = new global::Telerik.WinControls.UI.RadButton();
			this.toolChat = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.lstChat = new global::Telerik.WinControls.UI.RadListView();
			this.txtChat = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.panelChatBottom = new global::Telerik.WinControls.UI.RadPanel();
			this.radioLobby = new global::Telerik.WinControls.UI.RadRadioButton();
			this.radioGameRoom = new global::Telerik.WinControls.UI.RadRadioButton();
			this.chkNotifyChat = new global::Telerik.WinControls.UI.RadCheckBox();
			this.lblChannelClientCount = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblEmuUpdateVersion = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusDLCEmu = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusUpdateEmu = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusGameEmu = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusDLCRaw = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel19 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel17 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblNbPlayers = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel5 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblDLCSize = new global::Telerik.WinControls.UI.RadLabel();
			this.lblTitleId = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusUpdateRaw = new global::Telerik.WinControls.UI.RadLabel();
			this.lblStatusGameRaw = new global::Telerik.WinControls.UI.RadLabel();
			this.lblUpdateSize = new global::Telerik.WinControls.UI.RadLabel();
			this.label5 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblGameSize = new global::Telerik.WinControls.UI.RadLabel();
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.toolTabStrip2 = new global::Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolDownload = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radPageView2 = new global::Telerik.WinControls.UI.RadPageView();
			this.radPageViewPage1 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radLiveSpeed = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblFileCheckStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radPageViewPage3 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.radGroupBox26 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.chkSuperSpeed = new global::Telerik.WinControls.UI.RadCheckBox();
			this.radLabel20 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel21 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox18 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblSpeed = new global::Telerik.WinControls.UI.RadLabel();
			this.gaugeSpeed = new global::Telerik.WinControls.UI.Gauges.RadRadialGauge();
			this.radialGaugeArc1 = new global::Telerik.WinControls.UI.Gauges.RadialGaugeArc();
			this.radialGaugeArc2 = new global::Telerik.WinControls.UI.Gauges.RadialGaugeArc();
			this.radialGaugeLabels1 = new global::Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
			this.radialGaugeTicks1 = new global::Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
			this.radialGaugeSingleLabel1 = new global::Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
			this.radPageViewPage2 = new global::Telerik.WinControls.UI.RadPageViewPage();
			this.grpLog = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lstLog = new global::Telerik.WinControls.UI.RadListView();
			this.toolTabStrip4 = new global::Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolTabStrip6 = new global::Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolWindow2 = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radPanel1 = new global::Telerik.WinControls.UI.RadPanel();
			this.cmdChangeRegion = new global::Telerik.WinControls.UI.RadButton();
			this.cmdChangeTicket = new global::Telerik.WinControls.UI.RadButton();
			this.cmdChangeFolder = new global::Telerik.WinControls.UI.RadButton();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cmdSetExtractFolder = new global::Telerik.WinControls.UI.RadButton();
			this.label6 = new global::System.Windows.Forms.Label();
			this.DownloadButton = new global::Telerik.WinControls.UI.RadButton();
			this.toolWindow3 = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radPanel2 = new global::Telerik.WinControls.UI.RadPanel();
			this.cmdCopyAll = new global::Telerik.WinControls.UI.RadButton();
			this.cmdImportGames = new global::Telerik.WinControls.UI.RadButton();
			this.cmdRefresh = new global::Telerik.WinControls.UI.RadButton();
			this.cmdAddAllGames = new global::Telerik.WinControls.UI.RadButton();
			this.cmdAddAllUpdates = new global::Telerik.WinControls.UI.RadButton();
			this.cmdAddAllDLCS = new global::Telerik.WinControls.UI.RadButton();
			this.toolWindow4 = new global::Telerik.WinControls.UI.Docking.ToolWindow();
			this.radPanel3 = new global::Telerik.WinControls.UI.RadPanel();
			this.cmdLegal = new global::Telerik.WinControls.UI.RadButton();
			this.cmdHallOfFame = new global::Telerik.WinControls.UI.RadButton();
			this.cmdChangeTheme = new global::Telerik.WinControls.UI.RadButton();
			this.radContextMenu_0 = new global::Telerik.WinControls.UI.RadContextMenu(this.icontainer_0);
			this.menuDlGame = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuDlUpdate = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuDlDLC = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuCopy = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuDelete = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuMarkInstall = new global::Telerik.WinControls.UI.RadMenuItem();
			this.radMarkNotInstalled = new global::Telerik.WinControls.UI.RadMenuItem();
			this.radUnpack = new global::Telerik.WinControls.UI.RadMenuItem();
			this.menuPlay = new global::Telerik.WinControls.UI.RadMenuItem();
			this.radPrepareEmu = new global::Telerik.WinControls.UI.RadMenuItem();
			this.radDelEmuData = new global::Telerik.WinControls.UI.RadMenuItem();
			this.radMenuItem1 = new global::Telerik.WinControls.UI.RadMenuItem();
			this.timer_2 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_3 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_4 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.lblStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.lblSynchronized = new global::Telerik.WinControls.UI.RadLabel();
			this.timer_5 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_6 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_7 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.FTSearchBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstGames).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dlQueue).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalToDl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalDl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNbGms).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox7).BeginInit();
			this.radGroupBox7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkPrepareEmulation).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkPack).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAbortDelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTimeLeft).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkUnpack).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyToSD).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkSleep).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkShutdown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDelay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkHibernate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpProgressAll).BeginInit();
			this.grpProgressAll.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalEta).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.totalProgress).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel9).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radMaxSpeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAbortAll).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).BeginInit();
			this.radGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCopy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddDlc).BeginInit();
			this.cmdAddDlc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTitle).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).BeginInit();
			this.radGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblFileEta).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pgFile).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpProgressCurrent).BeginInit();
			this.grpProgressCurrent.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEta).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.NUSGrabberProgress).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dockMain).BeginInit();
			this.dockMain.SuspendLayout();
			this.toolCopy.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstCopy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSendWiiu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdManageRemoteSd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdInitiateCopy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox10).BeginInit();
			this.radGroupBox10.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalCopy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip3).BeginInit();
			this.toolTabStrip3.SuspendLayout();
			this.toolWindow5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pbBanner).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer3).BeginInit();
			this.radSplitContainer3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.documentContainer1).BeginInit();
			this.documentContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.documentTabStrip1).BeginInit();
			this.documentTabStrip1.SuspendLayout();
			this.toolLibrary.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).BeginInit();
			this.radGroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).BeginInit();
			this.radSplitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).BeginInit();
			this.splitPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkCompactView).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelLibraryCheckbox).BeginInit();
			this.panelLibraryCheckbox.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).BeginInit();
			this.splitPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox9).BeginInit();
			this.radGroupBox9.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearDl).BeginInit();
			this.toolFilters.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox12).BeginInit();
			this.radGroupBox12.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.treePlatforms).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox13).BeginInit();
			this.radGroupBox13.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkKOR).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkJAP).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkUSA).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkEUR).BeginInit();
			this.toolAdvancedSearch.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox25).BeginInit();
			this.radGroupBox25.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkGameGenres).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSearchWithCriterias).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearCriterias).BeginInit();
			this.toolAdvancedSettings.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox28).BeginInit();
			this.radGroupBox28.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblStorageLocation).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox22).BeginInit();
			this.radGroupBox22.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkDisableSpeedGraph).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkPreventShortcut).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox14).BeginInit();
			this.radGroupBox14.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblproxyStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel12).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearProxy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSetProxy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyUsr).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyPassword).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel11).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyUrl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel10).BeginInit();
			this.toolEmuSettings.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).BeginInit();
			this.radGroupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox21).BeginInit();
			this.radGroupBox21.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel22).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkForceGameMode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel23).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel13).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox17).BeginInit();
			this.radGroupBox17.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton4).BeginInit();
			this.toolContribute.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox15).BeginInit();
			this.radGroupBox15.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox16).BeginInit();
			this.radGroupBox16.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDonate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorDate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel18).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorEmail).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel16).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel15).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel14).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox20).BeginInit();
			this.radGroupBox20.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSugegstIdea).BeginInit();
			this.toolHelp.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox24).BeginInit();
			this.radGroupBox24.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdPrepareSd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip1).BeginInit();
			this.toolTabStrip1.SuspendLayout();
			this.toolGameInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox6).BeginInit();
			this.radGroupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dockInfo).BeginInit();
			this.dockInfo.SuspendLayout();
			this.toolGameDesc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtDesc).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelGameCover).BeginInit();
			this.panelGameCover.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdShortcut).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdPlay).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLogo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbCover).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.documentContainer2).BeginInit();
			this.documentContainer2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.documentTabStrip2).BeginInit();
			this.documentTabStrip2.SuspendLayout();
			this.toolMods.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblModsOnlyCemu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox29).BeginInit();
			this.radGroupBox29.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstMods).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtModSearch).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdModContribute).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox27).BeginInit();
			this.radGroupBox27.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.modPreview).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtModDescription).BeginInit();
			this.toolExtraInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox11).BeginInit();
			this.radGroupBox11.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstLanguages).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbRating).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstGenre).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pgScore).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstControllers).BeginInit();
			this.toolScreenShot.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview2).BeginInit();
			this.toolWeb.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox8).BeginInit();
			this.radGroupBox8.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdGoNext).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdGoBack).BeginInit();
			this.toolMovies.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstMovies).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).BeginInit();
			this.tollSaveManager.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCommunitySaves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImportCemu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel8).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdRestoreSave).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdBackupSave).BeginInit();
			this.toolChat.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstChat).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtChat).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelChatBottom).BeginInit();
			this.panelChatBottom.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radioLobby).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radioGameRoom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkNotifyChat).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblChannelClientCount).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuUpdateVersion).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusDLCEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusUpdateEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusGameEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusDLCRaw).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel19).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel17).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNbPlayers).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDLCSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTitleId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusUpdateRaw).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusGameRaw).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblGameSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip2).BeginInit();
			this.toolTabStrip2.SuspendLayout();
			this.toolDownload.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPageView2).BeginInit();
			this.radPageView2.SuspendLayout();
			this.radPageViewPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLiveSpeed).BeginInit();
			this.radLiveSpeed.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblFileCheckStatus).BeginInit();
			this.radPageViewPage3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox26).BeginInit();
			this.radGroupBox26.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkSuperSpeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel20).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel21).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox18).BeginInit();
			this.radGroupBox18.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblSpeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.gaugeSpeed).BeginInit();
			this.radPageViewPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.grpLog).BeginInit();
			this.grpLog.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstLog).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip4).BeginInit();
			this.toolTabStrip4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip6).BeginInit();
			this.toolTabStrip6.SuspendLayout();
			this.toolWindow2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel1).BeginInit();
			this.radPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeRegion).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeTicket).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeFolder).BeginInit();
			this.cmdChangeFolder.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSetExtractFolder).BeginInit();
			this.cmdSetExtractFolder.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DownloadButton).BeginInit();
			this.toolWindow3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel2).BeginInit();
			this.radPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCopyAll).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImportGames).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdRefresh).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllGames).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllUpdates).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllDLCS).BeginInit();
			this.toolWindow4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel3).BeginInit();
			this.radPanel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLegal).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdHallOfFame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeTheme).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatus).BeginInit();
			this.lblStatus.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblSynchronized).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.dockWindowPlaceholder1.AutoHideSize = new global::System.Drawing.Size(510, 452);
			this.dockWindowPlaceholder1.DockWindowName = "toolDownload";
			this.dockWindowPlaceholder1.DockWindowText = "Download Manager";
			this.dockWindowPlaceholder1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dockWindowPlaceholder1.Location = new global::System.Drawing.Point(0, 0);
			this.dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
			this.dockWindowPlaceholder1.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.dockWindowPlaceholder1.Size = new global::System.Drawing.Size(200, 200);
			this.dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
			this.dockWindowPlaceholder2.AutoHideSize = new global::System.Drawing.Size(396, 104);
			this.dockWindowPlaceholder2.DockWindowName = "toolCopy";
			this.dockWindowPlaceholder2.DockWindowText = "Copy Queue";
			this.dockWindowPlaceholder2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.dockWindowPlaceholder2.Location = new global::System.Drawing.Point(0, 0);
			this.dockWindowPlaceholder2.Name = "dockWindowPlaceholder2";
			this.dockWindowPlaceholder2.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.dockWindowPlaceholder2.Size = new global::System.Drawing.Size(200, 200);
			this.dockWindowPlaceholder2.Text = "dockWindowPlaceholder2";
			this.FTSearchBox.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.FTSearchBox.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.FTSearchBox.Location = new global::System.Drawing.Point(0, 0);
			this.FTSearchBox.MinimumSize = new global::System.Drawing.Size(0, 24);
			this.FTSearchBox.Name = "FTSearchBox";
			this.FTSearchBox.NullText = "Search...";
			this.FTSearchBox.RootElement.MinSize = new global::System.Drawing.Size(0, 24);
			this.FTSearchBox.Size = new global::System.Drawing.Size(445, 24);
			this.FTSearchBox.TabIndex = 7;
			this.FTSearchBox.TextChanged += new global::System.EventHandler(this.FTSearchBox_TextChanged);
			this.lstGames.AllowEdit = false;
			this.lstGames.AllowRemove = false;
			listViewDetailColumn.HeaderText = "Name";
			listViewDetailColumn.Width = 400f;
			listViewDetailColumn2.HeaderText = "Region";
			listViewDetailColumn2.Width = 45f;
			listViewDetailColumn3.HeaderText = "Size";
			listViewDetailColumn3.Width = 70f;
			listViewDetailColumn4.HeaderText = "Completion";
			listViewDetailColumn4.Width = 70f;
			listViewDetailColumn5.HeaderText = "Update";
			listViewDetailColumn5.Width = 50f;
			listViewDetailColumn6.HeaderText = "Dlc";
			listViewDetailColumn6.Width = 40f;
			listViewDetailColumn7.HeaderText = "Console";
			listViewDetailColumn7.Width = 50f;
			this.lstGames.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2,
				listViewDetailColumn3,
				listViewDetailColumn4,
				listViewDetailColumn5,
				listViewDetailColumn6,
				listViewDetailColumn7
			});
			this.lstGames.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstGames.EnableColumnSort = true;
			this.lstGames.EnableSorting = true;
			this.lstGames.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lstGames.FullRowSelect = false;
			this.lstGames.ItemSize = new global::System.Drawing.Size(170, 64);
			this.lstGames.ItemSpacing = 1;
			this.lstGames.KeyboardSearchEnabled = true;
			this.lstGames.Location = new global::System.Drawing.Point(0, 42);
			this.lstGames.MultiSelect = true;
			this.lstGames.Name = "lstGames";
			this.lstGames.SelectLastAddedItem = false;
			this.lstGames.ShowGroups = true;
			this.lstGames.Size = new global::System.Drawing.Size(445, 197);
			this.lstGames.TabIndex = 6;
			this.lstGames.UseCompatibleTextRendering = false;
			this.lstGames.ViewType = global::Telerik.WinControls.UI.ListViewType.IconsView;
			this.lstGames.SelectedItemChanged += new global::System.EventHandler(this.lstGames_SelectedItemChanged);
			this.lstGames.ItemMouseUp += new global::Telerik.WinControls.UI.ListViewItemMouseEventHandler(this.lstGames_ItemMouseUp);
			this.lstGames.SizeChanged += new global::System.EventHandler(this.lstGames_SizeChanged);
			this.lstGames.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.lstGames_KeyUp);
			this.openFileDialog_0.FileName = "ckey.bin";
			this.label2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(445, 18);
			this.label2.TabIndex = 15;
			this.label2.Text = "Download Queue (Double Click to remove)";
			this.dlQueue.AllowColumnReorder = false;
			this.dlQueue.AllowColumnResize = false;
			this.dlQueue.AllowEdit = false;
			this.dlQueue.AllowRemove = false;
			listViewDetailColumn8.HeaderText = "Column 0";
			listViewDetailColumn8.Width = 440f;
			this.dlQueue.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn8
			});
			this.dlQueue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dlQueue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.dlQueue.ItemSpacing = -1;
			this.dlQueue.Location = new global::System.Drawing.Point(0, 18);
			this.dlQueue.Name = "dlQueue";
			this.dlQueue.ShowColumnHeaders = false;
			this.dlQueue.Size = new global::System.Drawing.Size(445, 31);
			this.dlQueue.TabIndex = 16;
			this.dlQueue.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.dlQueue.ItemMouseDoubleClick += new global::Telerik.WinControls.UI.ListViewItemEventHandler(this.dlQueue_ItemMouseDoubleClick);
			this.dlQueue.VisualItemCreating += new global::Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(this.dlQueue_VisualItemCreating);
			this.lblTotalToDl.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblTotalToDl.Location = new global::System.Drawing.Point(3, 18);
			this.lblTotalToDl.Name = "lblTotalToDl";
			this.lblTotalToDl.Size = new global::System.Drawing.Size(103, 18);
			this.lblTotalToDl.TabIndex = 17;
			this.lblTotalToDl.Text = "Total to download :";
			this.lblTotalDl.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblTotalDl.Location = new global::System.Drawing.Point(112, 18);
			this.lblTotalDl.Name = "lblTotalDl";
			this.lblTotalDl.Size = new global::System.Drawing.Size(28, 18);
			this.lblTotalDl.TabIndex = 18;
			this.lblTotalDl.Text = "0 KB";
			this.lblNbGms.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.lblNbGms.ForeColor = global::System.Drawing.Color.Green;
			this.lblNbGms.Location = new global::System.Drawing.Point(0, 0);
			this.lblNbGms.Name = "lblNbGms";
			this.lblNbGms.Size = new global::System.Drawing.Size(95, 19);
			this.lblNbGms.TabIndex = 25;
			this.lblNbGms.Text = "0 games available";
			this.radGroupBox7.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox7.Controls.Add(this.chkPrepareEmulation);
			this.radGroupBox7.Controls.Add(this.chkPack);
			this.radGroupBox7.Controls.Add(this.radDate);
			this.radGroupBox7.Controls.Add(this.cmdAbortDelay);
			this.radGroupBox7.Controls.Add(this.lblTimeLeft);
			this.radGroupBox7.Controls.Add(this.chkUnpack);
			this.radGroupBox7.Controls.Add(this.chkCopyToSD);
			this.radGroupBox7.Controls.Add(this.chkSleep);
			this.radGroupBox7.Controls.Add(this.chkShutdown);
			this.radGroupBox7.Controls.Add(this.chkDelay);
			this.radGroupBox7.Controls.Add(this.chkHibernate);
			this.radGroupBox7.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox7.HeaderText = "Action to perform once downloading is over";
			this.radGroupBox7.Location = new global::System.Drawing.Point(0, 294);
			this.radGroupBox7.Name = "radGroupBox7";
			this.radGroupBox7.Size = new global::System.Drawing.Size(0, 66);
			this.radGroupBox7.TabIndex = 30;
			this.radGroupBox7.Text = "Action to perform once downloading is over";
			this.chkPrepareEmulation.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkPrepareEmulation.Location = new global::System.Drawing.Point(23, 44);
			this.chkPrepareEmulation.Name = "chkPrepareEmulation";
			this.chkPrepareEmulation.Size = new global::System.Drawing.Size(112, 18);
			this.chkPrepareEmulation.TabIndex = 26;
			this.chkPrepareEmulation.Text = "Prepare emulation";
			this.chkPack.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkPack.Location = new global::System.Drawing.Point(-56, 44);
			this.chkPack.Name = "chkPack";
			this.chkPack.Size = new global::System.Drawing.Size(77, 18);
			this.chkPack.TabIndex = 25;
			this.chkPack.Text = "Pack to CIA";
			this.chkPack.ToggleStateChanging += new global::Telerik.WinControls.UI.StateChangingEventHandler(this.chkPack_ToggleStateChanging);
			this.radDate.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.radDate.Location = new global::System.Drawing.Point(-142, 19);
			this.radDate.Name = "radDate";
			this.radDate.Size = new global::System.Drawing.Size(132, 20);
			this.radDate.TabIndex = 25;
			this.cmdAbortDelay.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.cmdAbortDelay.Location = new global::System.Drawing.Point(-73, 42);
			this.cmdAbortDelay.Name = "cmdAbortDelay";
			this.cmdAbortDelay.Size = new global::System.Drawing.Size(63, 18);
			this.cmdAbortDelay.TabIndex = 24;
			this.cmdAbortDelay.Text = "Abort";
			this.cmdAbortDelay.Click += new global::System.EventHandler(this.cmdAbortDelay_Click);
			this.lblTimeLeft.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblTimeLeft.Location = new global::System.Drawing.Point(-167, 45);
			this.lblTimeLeft.Name = "lblTimeLeft";
			this.lblTimeLeft.Size = new global::System.Drawing.Size(11, 18);
			this.lblTimeLeft.TabIndex = 9;
			this.lblTimeLeft.Text = "-";
			this.chkUnpack.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkUnpack.Location = new global::System.Drawing.Point(-116, 45);
			this.chkUnpack.Name = "chkUnpack";
			this.chkUnpack.Size = new global::System.Drawing.Size(58, 18);
			this.chkUnpack.TabIndex = 24;
			this.chkUnpack.Text = "Unpack";
			this.chkUnpack.ToggleStateChanging += new global::Telerik.WinControls.UI.StateChangingEventHandler(this.chkUnpack_ToggleStateChanging);
			this.chkCopyToSD.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkCopyToSD.Location = new global::System.Drawing.Point(-199, 45);
			this.chkCopyToSD.Name = "chkCopyToSD";
			this.chkCopyToSD.Size = new global::System.Drawing.Size(79, 18);
			this.chkCopyToSD.TabIndex = 23;
			this.chkCopyToSD.Text = "Copy To SD";
			this.chkCopyToSD.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkCopyToSD_ToggleStateChanged);
			this.chkSleep.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkSleep.Location = new global::System.Drawing.Point(-114, 21);
			this.chkSleep.Name = "chkSleep";
			this.chkSleep.Size = new global::System.Drawing.Size(47, 18);
			this.chkSleep.TabIndex = 22;
			this.chkSleep.Text = "Sleep";
			this.chkSleep.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkSleep_ToggleStateChanged);
			this.chkShutdown.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkShutdown.Location = new global::System.Drawing.Point(-199, 21);
			this.chkShutdown.Name = "chkShutdown";
			this.chkShutdown.Size = new global::System.Drawing.Size(74, 18);
			this.chkShutdown.TabIndex = 19;
			this.chkShutdown.Text = "Shut down";
			this.chkShutdown.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkShutdown_ToggleStateChanged);
			this.chkDelay.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkDelay.Location = new global::System.Drawing.Point(23, 21);
			this.chkDelay.Name = "chkDelay";
			this.chkDelay.Size = new global::System.Drawing.Size(76, 18);
			this.chkDelay.TabIndex = 22;
			this.chkDelay.Text = "Delay start:";
			this.chkDelay.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkDelay_ToggleStateChanged);
			this.chkHibernate.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkHibernate.Location = new global::System.Drawing.Point(-56, 21);
			this.chkHibernate.Name = "chkHibernate";
			this.chkHibernate.Size = new global::System.Drawing.Size(69, 18);
			this.chkHibernate.TabIndex = 21;
			this.chkHibernate.Text = "Hibernate";
			this.chkHibernate.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkHibernate_ToggleStateChanged);
			this.grpProgressAll.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.grpProgressAll.Controls.Add(this.lblTotalEta);
			this.grpProgressAll.Controls.Add(this.totalProgress);
			this.grpProgressAll.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.grpProgressAll.HeaderText = "All games";
			this.grpProgressAll.Location = new global::System.Drawing.Point(0, 158);
			this.grpProgressAll.Name = "grpProgressAll";
			this.grpProgressAll.Padding = new global::System.Windows.Forms.Padding(16);
			this.grpProgressAll.Size = new global::System.Drawing.Size(0, 79);
			this.grpProgressAll.TabIndex = 28;
			this.grpProgressAll.Text = "All games";
			this.lblTotalEta.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblTotalEta.Location = new global::System.Drawing.Point(16, 16);
			this.lblTotalEta.Name = "lblTotalEta";
			this.lblTotalEta.Size = new global::System.Drawing.Size(75, 18);
			this.lblTotalEta.TabIndex = 8;
			this.lblTotalEta.Text = "ETA : 00:00:00";
			this.totalProgress.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.totalProgress.Location = new global::System.Drawing.Point(16, 39);
			this.totalProgress.Name = "totalProgress";
			this.totalProgress.ShowProgressIndicators = true;
			this.totalProgress.Size = new global::System.Drawing.Size(0, 24);
			this.totalProgress.TabIndex = 11;
			this.totalProgress.Text = "0 %";
			this.radLabel9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.radLabel9.Location = new global::System.Drawing.Point(130, 47);
			this.radLabel9.Name = "radLabel9";
			this.radLabel9.Size = new global::System.Drawing.Size(94, 18);
			this.radLabel9.TabIndex = 9;
			this.radLabel9.Text = "Max speed (kB/s):";
			this.radMaxSpeed.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.radMaxSpeed.Location = new global::System.Drawing.Point(230, 48);
			global::Telerik.WinControls.UI.RadSpinEditor radSpinEditor = this.radMaxSpeed;
			int[] array = new int[4];
			array[0] = 100000;
			radSpinEditor.Maximum = new decimal(array);
			this.radMaxSpeed.Name = "radMaxSpeed";
			this.radMaxSpeed.Size = new global::System.Drawing.Size(64, 20);
			this.radMaxSpeed.TabIndex = 24;
			this.radMaxSpeed.TabStop = false;
			this.radMaxSpeed.ValueChanged += new global::System.EventHandler(this.radMaxSpeed_ValueChanged);
			this.cmdAbortAll.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdAbortAll.Location = new global::System.Drawing.Point(0, 263);
			this.cmdAbortAll.Name = "cmdAbortAll";
			this.cmdAbortAll.Size = new global::System.Drawing.Size(0, 31);
			this.cmdAbortAll.TabIndex = 23;
			this.cmdAbortAll.Text = "&Abort/Pause";
			this.cmdAbortAll.Click += new global::System.EventHandler(this.cmdAbortAll_Click);
			this.radGroupBox3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox3.AutoSize = true;
			this.radGroupBox3.Controls.Add(this.cmdDelete);
			this.radGroupBox3.Controls.Add(this.cmdCopy);
			this.radGroupBox3.Controls.Add(this.cmdAddDlc);
			this.radGroupBox3.Controls.Add(this.cmdAddUpdate);
			this.radGroupBox3.Controls.Add(this.cmdAddGame);
			this.radGroupBox3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox3.HeaderText = "Actions";
			this.radGroupBox3.Location = new global::System.Drawing.Point(0, 305);
			this.radGroupBox3.Name = "radGroupBox3";
			this.radGroupBox3.Size = new global::System.Drawing.Size(667, 75);
			this.radGroupBox3.TabIndex = 30;
			this.radGroupBox3.Text = "Actions";
			this.cmdDelete.AccessibleName = "Delete";
			this.cmdDelete.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdDelete.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdDelete.Enabled = false;
			this.cmdDelete.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdDelete.Image");
			this.cmdDelete.Location = new global::System.Drawing.Point(542, 19);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdDelete.Size = new global::System.Drawing.Size(106, 53);
			this.cmdDelete.TabIndex = 6;
			this.cmdDelete.Text = "D&elete";
			this.cmdDelete.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdDelete.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.Click += new global::System.EventHandler(this.cmdDelete_Click);
			this.cmdCopy.AccessibleName = "Copy to SD";
			this.cmdCopy.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdCopy.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdCopy.Enabled = false;
			this.cmdCopy.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdCopy.Image");
			this.cmdCopy.Location = new global::System.Drawing.Point(405, 19);
			this.cmdCopy.Name = "cmdCopy";
			this.cmdCopy.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdCopy.Size = new global::System.Drawing.Size(129, 53);
			this.cmdCopy.TabIndex = 6;
			this.cmdCopy.Text = "&Copy to SD";
			this.cmdCopy.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCopy.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCopy.Click += new global::System.EventHandler(this.cmdCopy_Click);
			this.cmdAddDlc.AccessibleName = "Add DLC";
			this.cmdAddDlc.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddDlc.Controls.Add(this.label4);
			this.cmdAddDlc.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddDlc.Enabled = false;
			this.cmdAddDlc.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddDlc.Image");
			this.cmdAddDlc.Location = new global::System.Drawing.Point(263, 19);
			this.cmdAddDlc.Name = "cmdAddDlc";
			this.cmdAddDlc.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddDlc.Size = new global::System.Drawing.Size(134, 53);
			this.cmdAddDlc.TabIndex = 6;
			this.cmdAddDlc.Text = "Add &DLC";
			this.cmdAddDlc.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddDlc.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddDlc.Click += new global::System.EventHandler(this.cmdAddDlc_Click);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.ForeColor = global::System.Drawing.Color.Red;
			this.label4.Location = new global::System.Drawing.Point(56, 39);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(63, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "CFW ONLY!";
			this.cmdAddUpdate.AccessibleName = "Add update";
			this.cmdAddUpdate.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddUpdate.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddUpdate.Enabled = false;
			this.cmdAddUpdate.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddUpdate.Image");
			this.cmdAddUpdate.Location = new global::System.Drawing.Point(125, 19);
			this.cmdAddUpdate.Name = "cmdAddUpdate";
			this.cmdAddUpdate.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddUpdate.Size = new global::System.Drawing.Size(130, 53);
			this.cmdAddUpdate.TabIndex = 5;
			this.cmdAddUpdate.Text = "Add &update";
			this.cmdAddUpdate.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddUpdate.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddUpdate.Click += new global::System.EventHandler(this.cmdAddUpdate_Click);
			this.cmdAddGame.AccessibleName = "Add ";
			this.cmdAddGame.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddGame.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddGame.Enabled = false;
			this.cmdAddGame.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddGame.Image");
			this.cmdAddGame.Location = new global::System.Drawing.Point(19, 19);
			this.cmdAddGame.Name = "cmdAddGame";
			this.cmdAddGame.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddGame.Size = new global::System.Drawing.Size(98, 53);
			this.cmdAddGame.TabIndex = 4;
			this.cmdAddGame.Text = "&Add";
			this.cmdAddGame.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddGame.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddGame.Click += new global::System.EventHandler(this.cmdAddGame_Click);
			this.lblTitle.AutoSize = false;
			this.lblTitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(667, 22);
			this.lblTitle.TabIndex = 27;
			this.lblTitle.Text = "--";
			this.lblTitle.UseMnemonic = false;
			this.radGroupBox2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox2.Controls.Add(this.lblFileEta);
			this.radGroupBox2.Controls.Add(this.pgFile);
			this.radGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox2.HeaderText = "Current file";
			this.radGroupBox2.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox2.Name = "radGroupBox2";
			this.radGroupBox2.Padding = new global::System.Windows.Forms.Padding(16);
			this.radGroupBox2.Size = new global::System.Drawing.Size(0, 79);
			this.radGroupBox2.TabIndex = 33;
			this.radGroupBox2.Text = "Current file";
			this.lblFileEta.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblFileEta.Location = new global::System.Drawing.Point(16, 16);
			this.lblFileEta.Name = "lblFileEta";
			this.lblFileEta.Size = new global::System.Drawing.Size(75, 18);
			this.lblFileEta.TabIndex = 8;
			this.lblFileEta.Text = "ETA : 00:00:00";
			this.pgFile.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pgFile.Location = new global::System.Drawing.Point(16, 39);
			this.pgFile.Name = "pgFile";
			this.pgFile.ShowProgressIndicators = true;
			this.pgFile.Size = new global::System.Drawing.Size(0, 24);
			this.pgFile.TabIndex = 11;
			this.pgFile.Text = "0 %";
			this.grpProgressCurrent.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.grpProgressCurrent.Controls.Add(this.lblEta);
			this.grpProgressCurrent.Controls.Add(this.NUSGrabberProgress);
			this.grpProgressCurrent.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.grpProgressCurrent.HeaderText = "Current game";
			this.grpProgressCurrent.Location = new global::System.Drawing.Point(0, 79);
			this.grpProgressCurrent.Name = "grpProgressCurrent";
			this.grpProgressCurrent.Padding = new global::System.Windows.Forms.Padding(16);
			this.grpProgressCurrent.Size = new global::System.Drawing.Size(0, 79);
			this.grpProgressCurrent.TabIndex = 32;
			this.grpProgressCurrent.Text = "Current game";
			this.lblEta.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblEta.Location = new global::System.Drawing.Point(16, 16);
			this.lblEta.Name = "lblEta";
			this.lblEta.Size = new global::System.Drawing.Size(75, 18);
			this.lblEta.TabIndex = 8;
			this.lblEta.Text = "ETA : 00:00:00";
			this.NUSGrabberProgress.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.NUSGrabberProgress.Location = new global::System.Drawing.Point(16, 39);
			this.NUSGrabberProgress.Name = "NUSGrabberProgress";
			this.NUSGrabberProgress.ShowProgressIndicators = true;
			this.NUSGrabberProgress.Size = new global::System.Drawing.Size(0, 24);
			this.NUSGrabberProgress.TabIndex = 11;
			this.NUSGrabberProgress.Text = "0 %";
			this.dockMain.ActiveWindow = this.toolLibrary;
			this.dockMain.CausesValidation = false;
			this.dockMain.Controls.Add(this.toolTabStrip3);
			this.dockMain.Controls.Add(this.radSplitContainer3);
			this.dockMain.Controls.Add(this.toolTabStrip6);
			this.dockMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dockMain.IsCleanUpTarget = true;
			this.dockMain.Location = new global::System.Drawing.Point(0, 0);
			this.dockMain.MainDocumentContainer = this.documentContainer1;
			this.dockMain.Name = "dockMain";
			this.dockMain.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.dockMain.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			autoHideGroup.Windows.Add(this.dockWindowPlaceholder1);
			autoHideGroup2.Windows.Add(this.dockWindowPlaceholder2);
			this.dockMain.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup);
			this.dockMain.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup2);
			this.dockMain.Size = new global::System.Drawing.Size(1146, 633);
			this.dockMain.SplitterWidth = 2;
			this.dockMain.TabIndex = 32;
			this.dockMain.TabStop = false;
			this.dockMain.Text = "radDock1";
			this.dockMain.ActiveWindowChanged += new global::Telerik.WinControls.UI.Docking.DockWindowEventHandler(this.dockMain_ActiveWindowChanged);
			this.toolCopy.Caption = null;
			this.toolCopy.Controls.Add(this.lstCopy);
			this.toolCopy.Controls.Add(this.cmdSendWiiu);
			this.toolCopy.Controls.Add(this.cmdManageRemoteSd);
			this.toolCopy.Controls.Add(this.cmdInitiateCopy);
			this.toolCopy.Controls.Add(this.radGroupBox10);
			this.toolCopy.Controls.Add(this.radLabel6);
			this.toolCopy.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolCopy.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolCopy.Location = new global::System.Drawing.Point(1, 6);
			this.toolCopy.Name = "toolCopy";
			this.toolCopy.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolCopy.Size = new global::System.Drawing.Size(0, 396);
			this.toolCopy.Text = "Copy Queue";
			this.toolCopy.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.lstCopy.AllowColumnReorder = false;
			this.lstCopy.AllowColumnResize = false;
			this.lstCopy.AllowEdit = false;
			this.lstCopy.AllowRemove = false;
			this.lstCopy.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lstCopy.Location = new global::System.Drawing.Point(0, 18);
			this.lstCopy.Name = "lstCopy";
			this.lstCopy.Size = new global::System.Drawing.Size(0, 266);
			this.lstCopy.TabIndex = 35;
			this.lstCopy.ItemMouseDoubleClick += new global::Telerik.WinControls.UI.ListViewItemEventHandler(this.lstCopy_ItemMouseDoubleClick);
			this.cmdSendWiiu.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdSendWiiu.Location = new global::System.Drawing.Point(0, 284);
			this.cmdSendWiiu.Name = "cmdSendWiiu";
			this.cmdSendWiiu.Size = new global::System.Drawing.Size(0, 24);
			this.cmdSendWiiu.TabIndex = 1;
			this.cmdSendWiiu.Text = "Send to WiiU";
			this.cmdSendWiiu.Click += new global::System.EventHandler(this.cmdSendWiiu_Click);
			this.cmdManageRemoteSd.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdManageRemoteSd.Location = new global::System.Drawing.Point(0, 308);
			this.cmdManageRemoteSd.Name = "cmdManageRemoteSd";
			this.cmdManageRemoteSd.Size = new global::System.Drawing.Size(0, 24);
			this.cmdManageRemoteSd.TabIndex = 2;
			this.cmdManageRemoteSd.Text = "Manage games stored on the WiiU's SD card.\r\n";
			this.cmdManageRemoteSd.Click += new global::System.EventHandler(this.cmdManageRemoteSd_Click);
			this.cmdInitiateCopy.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdInitiateCopy.Location = new global::System.Drawing.Point(0, 332);
			this.cmdInitiateCopy.Name = "cmdInitiateCopy";
			this.cmdInitiateCopy.Size = new global::System.Drawing.Size(0, 24);
			this.cmdInitiateCopy.TabIndex = 0;
			this.cmdInitiateCopy.Text = "Copy to SD";
			this.cmdInitiateCopy.Click += new global::System.EventHandler(this.cmdInitiateCopy_Click);
			this.radGroupBox10.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox10.Controls.Add(this.lblTotalCopy);
			this.radGroupBox10.Controls.Add(this.radLabel1);
			this.radGroupBox10.Controls.Add(this.radButton1);
			this.radGroupBox10.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox10.HeaderText = "Info";
			this.radGroupBox10.Location = new global::System.Drawing.Point(0, 356);
			this.radGroupBox10.Name = "radGroupBox10";
			this.radGroupBox10.Size = new global::System.Drawing.Size(0, 40);
			this.radGroupBox10.TabIndex = 36;
			this.radGroupBox10.Text = "Info";
			this.lblTotalCopy.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.lblTotalCopy.Location = new global::System.Drawing.Point(79, 18);
			this.lblTotalCopy.Name = "lblTotalCopy";
			this.lblTotalCopy.Size = new global::System.Drawing.Size(28, 20);
			this.lblTotalCopy.TabIndex = 18;
			this.lblTotalCopy.Text = "0 KB";
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radLabel1.Location = new global::System.Drawing.Point(2, 18);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(77, 20);
			this.radLabel1.TabIndex = 17;
			this.radLabel1.Text = "Total to copy :";
			this.radButton1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.radButton1.Location = new global::System.Drawing.Point(-112, 18);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(110, 20);
			this.radButton1.TabIndex = 26;
			this.radButton1.Text = "Clear";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.radLabel6.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel6.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new global::System.Drawing.Size(0, 18);
			this.radLabel6.TabIndex = 34;
			this.radLabel6.Text = "Copy List (Double Click to remove)";
			this.toolTabStrip3.CanUpdateChildIndex = true;
			this.toolTabStrip3.CaptionVisible = false;
			this.toolTabStrip3.CausesValidation = false;
			this.toolTabStrip3.Controls.Add(this.toolWindow5);
			this.toolTabStrip3.Location = new global::System.Drawing.Point(5, 5);
			this.toolTabStrip3.Name = "toolTabStrip3";
			this.toolTabStrip3.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.toolTabStrip3.SelectedIndex = 0;
			this.toolTabStrip3.ShowItemToolTips = false;
			this.toolTabStrip3.Size = new global::System.Drawing.Size(1136, 105);
			this.toolTabStrip3.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(200, 105);
			this.toolTabStrip3.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(0, -95);
			this.toolTabStrip3.TabIndex = 2;
			this.toolTabStrip3.TabStop = false;
			this.toolWindow5.Caption = null;
			this.toolWindow5.Controls.Add(this.pbBanner);
			this.toolWindow5.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolWindow5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolWindow5.Location = new global::System.Drawing.Point(1, 2);
			this.toolWindow5.Name = "toolWindow5";
			this.toolWindow5.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow5.Size = new global::System.Drawing.Size(1134, 101);
			this.toolWindow5.Text = "toolWindow5";
			this.toolWindow5.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.pbBanner.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pbBanner.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pbBanner.Image");
			this.pbBanner.ImageLocation = "";
			this.pbBanner.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pbBanner.Location = new global::System.Drawing.Point(0, 0);
			this.pbBanner.Name = "pbBanner";
			this.pbBanner.Size = new global::System.Drawing.Size(1134, 101);
			this.pbBanner.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbBanner.TabIndex = 19;
			this.pbBanner.TabStop = false;
			this.radSplitContainer3.CausesValidation = false;
			this.radSplitContainer3.Controls.Add(this.documentContainer1);
			this.radSplitContainer3.Controls.Add(this.toolTabStrip1);
			this.radSplitContainer3.Controls.Add(this.toolTabStrip2);
			this.radSplitContainer3.Controls.Add(this.toolTabStrip4);
			this.radSplitContainer3.IsCleanUpTarget = true;
			this.radSplitContainer3.Location = new global::System.Drawing.Point(5, 112);
			this.radSplitContainer3.Name = "radSplitContainer3";
			this.radSplitContainer3.Padding = new global::System.Windows.Forms.Padding(5);
			this.radSplitContainer3.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.radSplitContainer3.Size = new global::System.Drawing.Size(1136, 404);
			this.radSplitContainer3.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(200, 375);
			this.radSplitContainer3.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(0, 185);
			this.radSplitContainer3.SplitterWidth = 2;
			this.radSplitContainer3.TabIndex = 0;
			this.radSplitContainer3.TabStop = false;
			this.documentContainer1.CausesValidation = false;
			this.documentContainer1.Controls.Add(this.documentTabStrip1);
			this.documentContainer1.Name = "documentContainer1";
			this.documentContainer1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.documentContainer1.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(461, 200);
			this.documentContainer1.SizeInfo.SizeMode = global::Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
			this.documentContainer1.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(-1092, 0);
			this.documentContainer1.SplitterWidth = 2;
			this.documentTabStrip1.CanUpdateChildIndex = true;
			this.documentTabStrip1.CausesValidation = false;
			this.documentTabStrip1.Controls.Add(this.toolLibrary);
			this.documentTabStrip1.Controls.Add(this.toolFilters);
			this.documentTabStrip1.Controls.Add(this.toolAdvancedSearch);
			this.documentTabStrip1.Controls.Add(this.toolAdvancedSettings);
			this.documentTabStrip1.Controls.Add(this.toolEmuSettings);
			this.documentTabStrip1.Controls.Add(this.toolContribute);
			this.documentTabStrip1.Controls.Add(this.toolHelp);
			this.documentTabStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.documentTabStrip1.Name = "documentTabStrip1";
			this.documentTabStrip1.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.documentTabStrip1.SelectedIndex = 0;
			this.documentTabStrip1.Size = new global::System.Drawing.Size(461, 404);
			this.documentTabStrip1.TabIndex = 0;
			this.documentTabStrip1.TabStop = false;
			this.toolLibrary.AutoScroll = true;
			this.toolLibrary.Caption = null;
			this.toolLibrary.Controls.Add(this.radGroupBox4);
			this.toolLibrary.DefaultFloatingSize = new global::System.Drawing.Size(600, 700);
			this.toolLibrary.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolLibrary.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolLibrary.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolLibrary.Image");
			this.toolLibrary.Location = new global::System.Drawing.Point(6, 29);
			this.toolLibrary.Name = "toolLibrary";
			this.toolLibrary.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolLibrary.Size = new global::System.Drawing.Size(449, 369);
			this.toolLibrary.Text = "Library";
			this.toolLibrary.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox4.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox4.AutoSize = true;
			this.radGroupBox4.Controls.Add(this.radSplitContainer1);
			this.radGroupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox4.HeaderText = "Games";
			this.radGroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox4.Name = "radGroupBox4";
			this.radGroupBox4.Size = new global::System.Drawing.Size(449, 369);
			this.radGroupBox4.TabIndex = 26;
			this.radGroupBox4.Text = "Games";
			this.radSplitContainer1.Controls.Add(this.splitPanel1);
			this.radSplitContainer1.Controls.Add(this.splitPanel2);
			this.radSplitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radSplitContainer1.IsCleanUpTarget = true;
			this.radSplitContainer1.Location = new global::System.Drawing.Point(2, 18);
			this.radSplitContainer1.Name = "radSplitContainer1";
			this.radSplitContainer1.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.radSplitContainer1.Padding = new global::System.Windows.Forms.Padding(5);
			this.radSplitContainer1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.radSplitContainer1.Size = new global::System.Drawing.Size(445, 349);
			this.radSplitContainer1.SplitterWidth = 2;
			this.radSplitContainer1.TabIndex = 0;
			this.radSplitContainer1.TabStop = false;
			this.radSplitContainer1.Text = "radSplitContainer1";
			this.splitPanel1.Controls.Add(this.lstGames);
			this.splitPanel1.Controls.Add(this.chkCompactView);
			this.splitPanel1.Controls.Add(this.FTSearchBox);
			this.splitPanel1.Controls.Add(this.panelLibraryCheckbox);
			this.splitPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.splitPanel1.Name = "splitPanel1";
			this.splitPanel1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel1.Size = new global::System.Drawing.Size(445, 258);
			this.splitPanel1.SizeInfo.AutoSizeScale = new global::System.Drawing.SizeF(0.2391304f, 0.2449275f);
			this.splitPanel1.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(17, 40);
			this.splitPanel1.TabIndex = 0;
			this.splitPanel1.TabStop = false;
			this.splitPanel1.Text = "splitPanel1";
			this.chkCompactView.AutoSize = false;
			this.chkCompactView.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.chkCompactView.Location = new global::System.Drawing.Point(0, 24);
			this.chkCompactView.Name = "chkCompactView";
			this.chkCompactView.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.chkCompactView.Size = new global::System.Drawing.Size(445, 18);
			this.chkCompactView.TabIndex = 38;
			this.chkCompactView.Text = "Compact &view";
			this.chkCompactView.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkCompactView_ToggleStateChanged);
			this.panelLibraryCheckbox.Controls.Add(this.chkShowLegit);
			this.panelLibraryCheckbox.Controls.Add(this.chkShowRednand);
			this.panelLibraryCheckbox.Controls.Add(this.chkShowPreviews);
			this.panelLibraryCheckbox.Controls.Add(this.lblNbGms);
			this.panelLibraryCheckbox.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelLibraryCheckbox.Location = new global::System.Drawing.Point(0, 239);
			this.panelLibraryCheckbox.Name = "panelLibraryCheckbox";
			this.panelLibraryCheckbox.Size = new global::System.Drawing.Size(445, 19);
			this.panelLibraryCheckbox.TabIndex = 0;
			this.chkShowLegit.AutoSize = true;
			this.chkShowLegit.Checked = true;
			this.chkShowLegit.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkShowLegit.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.chkShowLegit.Location = new global::System.Drawing.Point(274, 0);
			this.chkShowLegit.Name = "chkShowLegit";
			this.chkShowLegit.Size = new global::System.Drawing.Size(51, 19);
			this.chkShowLegit.TabIndex = 34;
			this.chkShowLegit.Text = "&Legit";
			this.chkShowLegit.UseVisualStyleBackColor = true;
			this.chkShowLegit.CheckedChanged += new global::System.EventHandler(this.chkShowLegit_CheckedChanged);
			this.chkShowRednand.AutoSize = true;
			this.chkShowRednand.Checked = true;
			this.chkShowRednand.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkShowRednand.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.chkShowRednand.Location = new global::System.Drawing.Point(325, 0);
			this.chkShowRednand.Name = "chkShowRednand";
			this.chkShowRednand.Size = new global::System.Drawing.Size(50, 19);
			this.chkShowRednand.TabIndex = 35;
			this.chkShowRednand.Text = "CF&W";
			this.chkShowRednand.UseVisualStyleBackColor = true;
			this.chkShowRednand.CheckedChanged += new global::System.EventHandler(this.chkShowRednand_CheckedChanged);
			this.chkShowPreviews.AutoSize = true;
			this.chkShowPreviews.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.chkShowPreviews.Location = new global::System.Drawing.Point(375, 0);
			this.chkShowPreviews.Name = "chkShowPreviews";
			this.chkShowPreviews.Size = new global::System.Drawing.Size(70, 19);
			this.chkShowPreviews.TabIndex = 36;
			this.chkShowPreviews.Text = "Previews";
			this.chkShowPreviews.UseVisualStyleBackColor = true;
			this.chkShowPreviews.CheckedChanged += new global::System.EventHandler(this.chkShowPreviews_CheckedChanged);
			this.splitPanel2.Controls.Add(this.dlQueue);
			this.splitPanel2.Controls.Add(this.label2);
			this.splitPanel2.Controls.Add(this.radGroupBox9);
			this.splitPanel2.Location = new global::System.Drawing.Point(0, 260);
			this.splitPanel2.Name = "splitPanel2";
			this.splitPanel2.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel2.Size = new global::System.Drawing.Size(445, 89);
			this.splitPanel2.SizeInfo.AutoSizeScale = new global::System.Drawing.SizeF(-0.2391304f, -0.2449275f);
			this.splitPanel2.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(-17, -40);
			this.splitPanel2.TabIndex = 1;
			this.splitPanel2.TabStop = false;
			this.splitPanel2.Text = "splitPanel2";
			this.radGroupBox9.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox9.Controls.Add(this.lblTotalToDl);
			this.radGroupBox9.Controls.Add(this.cmdClearDl);
			this.radGroupBox9.Controls.Add(this.lblTotalDl);
			this.radGroupBox9.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox9.HeaderText = "Info";
			this.radGroupBox9.Location = new global::System.Drawing.Point(0, 49);
			this.radGroupBox9.Name = "radGroupBox9";
			this.radGroupBox9.Size = new global::System.Drawing.Size(445, 40);
			this.radGroupBox9.TabIndex = 33;
			this.radGroupBox9.Text = "Info";
			this.cmdClearDl.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.cmdClearDl.Location = new global::System.Drawing.Point(333, 18);
			this.cmdClearDl.Name = "cmdClearDl";
			this.cmdClearDl.Size = new global::System.Drawing.Size(110, 20);
			this.cmdClearDl.TabIndex = 26;
			this.cmdClearDl.Text = "Clea&r";
			this.cmdClearDl.Click += new global::System.EventHandler(this.cmdClearDl_Click);
			this.toolFilters.Caption = null;
			this.toolFilters.Controls.Add(this.radGroupBox12);
			this.toolFilters.Controls.Add(this.radGroupBox13);
			this.toolFilters.DefaultFloatingSize = new global::System.Drawing.Size(438, 632);
			this.toolFilters.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolFilters.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolFilters.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolFilters.Image");
			this.toolFilters.Location = new global::System.Drawing.Point(6, 29);
			this.toolFilters.Name = "toolFilters";
			this.toolFilters.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolFilters.Size = new global::System.Drawing.Size(449, 369);
			this.toolFilters.Text = "Filters";
			this.toolFilters.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox12.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox12.Controls.Add(this.treePlatforms);
			this.radGroupBox12.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox12.HeaderText = "Platforms";
			this.radGroupBox12.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox12.Name = "radGroupBox12";
			this.radGroupBox12.Size = new global::System.Drawing.Size(449, 323);
			this.radGroupBox12.TabIndex = 0;
			this.radGroupBox12.Text = "Platforms";
			this.treePlatforms.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treePlatforms.Location = new global::System.Drawing.Point(2, 18);
			this.treePlatforms.Name = "treePlatforms";
			this.treePlatforms.Padding = new global::System.Windows.Forms.Padding(5);
			this.treePlatforms.Size = new global::System.Drawing.Size(445, 303);
			this.treePlatforms.SpacingBetweenNodes = -1;
			this.treePlatforms.TabIndex = 13;
			this.treePlatforms.Text = "radTreeView1";
			this.radGroupBox13.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox13.Controls.Add(this.chkKOR);
			this.radGroupBox13.Controls.Add(this.chkJAP);
			this.radGroupBox13.Controls.Add(this.chkUSA);
			this.radGroupBox13.Controls.Add(this.chkEUR);
			this.radGroupBox13.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox13.HeaderText = "Regions";
			this.radGroupBox13.Location = new global::System.Drawing.Point(0, 323);
			this.radGroupBox13.Name = "radGroupBox13";
			this.radGroupBox13.Size = new global::System.Drawing.Size(449, 46);
			this.radGroupBox13.TabIndex = 1;
			this.radGroupBox13.Text = "Regions";
			this.chkKOR.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkKOR.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chkKOR.Image");
			this.chkKOR.Location = new global::System.Drawing.Point(329, 17);
			this.chkKOR.Name = "chkKOR";
			this.chkKOR.Size = new global::System.Drawing.Size(47, 18);
			this.chkKOR.TabIndex = 42;
			this.chkKOR.Text = " ";
			this.chkKOR.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkKOR.CheckStateChanged += new global::System.EventHandler(this.chkKOR_CheckStateChanged);
			this.chkJAP.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkJAP.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chkJAP.Image");
			this.chkJAP.Location = new global::System.Drawing.Point(246, 17);
			this.chkJAP.Name = "chkJAP";
			this.chkJAP.Size = new global::System.Drawing.Size(47, 18);
			this.chkJAP.TabIndex = 41;
			this.chkJAP.Text = " ";
			this.chkJAP.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkJAP.CheckStateChanged += new global::System.EventHandler(this.chkJAP_CheckStateChanged);
			this.chkUSA.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkUSA.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chkUSA.Image");
			this.chkUSA.Location = new global::System.Drawing.Point(159, 17);
			this.chkUSA.Name = "chkUSA";
			this.chkUSA.Size = new global::System.Drawing.Size(47, 18);
			this.chkUSA.TabIndex = 40;
			this.chkUSA.Text = " ";
			this.chkUSA.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkUSA.CheckStateChanged += new global::System.EventHandler(this.chkUSA_CheckStateChanged);
			this.chkEUR.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.chkEUR.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("chkEUR.Image");
			this.chkEUR.Location = new global::System.Drawing.Point(72, 17);
			this.chkEUR.Name = "chkEUR";
			this.chkEUR.Size = new global::System.Drawing.Size(47, 18);
			this.chkEUR.TabIndex = 39;
			this.chkEUR.Text = " ";
			this.chkEUR.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.chkEUR.CheckStateChanged += new global::System.EventHandler(this.chkEUR_CheckStateChanged);
			this.toolAdvancedSearch.Caption = null;
			this.toolAdvancedSearch.Controls.Add(this.radGroupBox25);
			this.toolAdvancedSearch.Controls.Add(this.cmdSearchWithCriterias);
			this.toolAdvancedSearch.Controls.Add(this.cmdClearCriterias);
			this.toolAdvancedSearch.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolAdvancedSearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolAdvancedSearch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolAdvancedSearch.Image");
			this.toolAdvancedSearch.Location = new global::System.Drawing.Point(6, 29);
			this.toolAdvancedSearch.Name = "toolAdvancedSearch";
			this.toolAdvancedSearch.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolAdvancedSearch.Size = new global::System.Drawing.Size(449, 369);
			this.toolAdvancedSearch.Text = "Advanced Search";
			this.toolAdvancedSearch.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox25.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox25.Controls.Add(this.chkGameGenres);
			this.radGroupBox25.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox25.HeaderText = "Genre";
			this.radGroupBox25.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox25.Name = "radGroupBox25";
			this.radGroupBox25.Size = new global::System.Drawing.Size(449, 323);
			this.radGroupBox25.TabIndex = 0;
			this.radGroupBox25.Text = "Genre";
			this.chkGameGenres.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.chkGameGenres.Location = new global::System.Drawing.Point(2, 18);
			this.chkGameGenres.Name = "chkGameGenres";
			this.chkGameGenres.Padding = new global::System.Windows.Forms.Padding(5);
			this.chkGameGenres.Size = new global::System.Drawing.Size(445, 303);
			this.chkGameGenres.TabIndex = 0;
			this.chkGameGenres.Text = "radCheckedListBox1";
			this.cmdSearchWithCriterias.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdSearchWithCriterias.Location = new global::System.Drawing.Point(0, 323);
			this.cmdSearchWithCriterias.Name = "cmdSearchWithCriterias";
			this.cmdSearchWithCriterias.Size = new global::System.Drawing.Size(449, 22);
			this.cmdSearchWithCriterias.TabIndex = 1;
			this.cmdSearchWithCriterias.Text = "Search with these criterias";
			this.cmdSearchWithCriterias.Click += new global::System.EventHandler(this.cmdSearchWithCriterias_Click);
			this.cmdClearCriterias.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdClearCriterias.Location = new global::System.Drawing.Point(0, 345);
			this.cmdClearCriterias.Name = "cmdClearCriterias";
			this.cmdClearCriterias.Size = new global::System.Drawing.Size(449, 24);
			this.cmdClearCriterias.TabIndex = 2;
			this.cmdClearCriterias.Text = "Clear criterias";
			this.cmdClearCriterias.Click += new global::System.EventHandler(this.cmdClearCriterias_Click);
			this.toolAdvancedSettings.Caption = null;
			this.toolAdvancedSettings.Controls.Add(this.radGroupBox28);
			this.toolAdvancedSettings.Controls.Add(this.radGroupBox22);
			this.toolAdvancedSettings.Controls.Add(this.radGroupBox14);
			this.toolAdvancedSettings.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolAdvancedSettings.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolAdvancedSettings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolAdvancedSettings.Image");
			this.toolAdvancedSettings.Location = new global::System.Drawing.Point(6, 29);
			this.toolAdvancedSettings.Name = "toolAdvancedSettings";
			this.toolAdvancedSettings.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolAdvancedSettings.Size = new global::System.Drawing.Size(449, 369);
			this.toolAdvancedSettings.Text = "Advanced settings";
			this.toolAdvancedSettings.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox28.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox28.Controls.Add(this.lblStorageLocation);
			this.radGroupBox28.Controls.Add(this.radButton5);
			this.radGroupBox28.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox28.HeaderText = "Storage location";
			this.radGroupBox28.Location = new global::System.Drawing.Point(0, 205);
			this.radGroupBox28.Name = "radGroupBox28";
			this.radGroupBox28.Padding = new global::System.Windows.Forms.Padding(10, 25, 10, 15);
			this.radGroupBox28.Size = new global::System.Drawing.Size(449, 166);
			this.radGroupBox28.TabIndex = 36;
			this.radGroupBox28.Text = "Storage location";
			this.lblStorageLocation.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblStorageLocation.Location = new global::System.Drawing.Point(10, 25);
			this.lblStorageLocation.Name = "lblStorageLocation";
			this.lblStorageLocation.Size = new global::System.Drawing.Size(429, 102);
			this.lblStorageLocation.TabIndex = 0;
			this.lblStorageLocation.Text = "\r\n";
			this.radButton5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton5.Location = new global::System.Drawing.Point(10, 127);
			this.radButton5.Name = "radButton5";
			this.radButton5.Size = new global::System.Drawing.Size(429, 24);
			this.radButton5.TabIndex = 0;
			this.radButton5.Text = "Analyze disk usage";
			this.radButton5.Click += new global::System.EventHandler(this.radButton5_Click);
			this.radGroupBox22.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox22.Controls.Add(this.chkDisableSpeedGraph);
			this.radGroupBox22.Controls.Add(this.chkPreventShortcut);
			this.radGroupBox22.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox22.HeaderText = "Miscellaneous";
			this.radGroupBox22.Location = new global::System.Drawing.Point(0, 144);
			this.radGroupBox22.Name = "radGroupBox22";
			this.radGroupBox22.Size = new global::System.Drawing.Size(449, 61);
			this.radGroupBox22.TabIndex = 35;
			this.radGroupBox22.Text = "Miscellaneous";
			this.chkDisableSpeedGraph.Location = new global::System.Drawing.Point(207, 29);
			this.chkDisableSpeedGraph.Name = "chkDisableSpeedGraph";
			this.chkDisableSpeedGraph.Size = new global::System.Drawing.Size(229, 18);
			this.chkDisableSpeedGraph.TabIndex = 1;
			this.chkDisableSpeedGraph.Text = "Disable the speed graph (restart required)";
			this.chkDisableSpeedGraph.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkDisableSpeedGraph_ToggleStateChanged);
			this.chkPreventShortcut.Location = new global::System.Drawing.Point(17, 29);
			this.chkPreventShortcut.Name = "chkPreventShortcut";
			this.chkPreventShortcut.Size = new global::System.Drawing.Size(188, 18);
			this.chkPreventShortcut.TabIndex = 0;
			this.chkPreventShortcut.Text = "Don't geneate a desktop shortcut";
			this.chkPreventShortcut.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkPreventShortcut_ToggleStateChanged);
			this.radGroupBox14.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox14.Controls.Add(this.lblproxyStatus);
			this.radGroupBox14.Controls.Add(this.radLabel12);
			this.radGroupBox14.Controls.Add(this.cmdClearProxy);
			this.radGroupBox14.Controls.Add(this.cmdSetProxy);
			this.radGroupBox14.Controls.Add(this.radTextBox1);
			this.radGroupBox14.Controls.Add(this.txtProxyUsr);
			this.radGroupBox14.Controls.Add(this.txtProxyPassword);
			this.radGroupBox14.Controls.Add(this.radLabel11);
			this.radGroupBox14.Controls.Add(this.txtProxyUrl);
			this.radGroupBox14.Controls.Add(this.radLabel10);
			this.radGroupBox14.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox14.HeaderText = "Http Proxy";
			this.radGroupBox14.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox14.Name = "radGroupBox14";
			this.radGroupBox14.Size = new global::System.Drawing.Size(449, 144);
			this.radGroupBox14.TabIndex = 34;
			this.radGroupBox14.Text = "Http Proxy";
			this.lblproxyStatus.ForeColor = global::System.Drawing.Color.Red;
			this.lblproxyStatus.Location = new global::System.Drawing.Point(85, 121);
			this.lblproxyStatus.Name = "lblproxyStatus";
			this.lblproxyStatus.Size = new global::System.Drawing.Size(43, 18);
			this.lblproxyStatus.TabIndex = 4;
			this.lblproxyStatus.Text = "Not set";
			this.radLabel12.Location = new global::System.Drawing.Point(7, 121);
			this.radLabel12.Name = "radLabel12";
			this.radLabel12.Size = new global::System.Drawing.Size(72, 18);
			this.radLabel12.TabIndex = 3;
			this.radLabel12.Text = "Proxy status :";
			this.cmdClearProxy.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdClearProxy.Location = new global::System.Drawing.Point(227, 93);
			this.cmdClearProxy.Name = "cmdClearProxy";
			this.cmdClearProxy.Size = new global::System.Drawing.Size(167, 26);
			this.cmdClearProxy.TabIndex = 40;
			this.cmdClearProxy.Text = "Clear";
			this.cmdClearProxy.Click += new global::System.EventHandler(this.cmdClearProxy_Click);
			this.cmdSetProxy.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdSetProxy.Location = new global::System.Drawing.Point(54, 93);
			this.cmdSetProxy.Name = "cmdSetProxy";
			this.cmdSetProxy.Size = new global::System.Drawing.Size(167, 26);
			this.cmdSetProxy.TabIndex = 39;
			this.cmdSetProxy.Text = "Set";
			this.cmdSetProxy.Click += new global::System.EventHandler(this.cmdSetProxy_Click);
			this.radTextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.radTextBox1.Location = new global::System.Drawing.Point(272, 66);
			this.radTextBox1.MinimumSize = new global::System.Drawing.Size(0, 24);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.RootElement.MinSize = new global::System.Drawing.Size(0, 24);
			this.radTextBox1.Size = new global::System.Drawing.Size(164, 24);
			this.radTextBox1.TabIndex = 38;
			this.txtProxyUsr.Location = new global::System.Drawing.Point(85, 66);
			this.txtProxyUsr.MinimumSize = new global::System.Drawing.Size(0, 24);
			this.txtProxyUsr.Name = "txtProxyUsr";
			this.txtProxyUsr.RootElement.MinSize = new global::System.Drawing.Size(0, 24);
			this.txtProxyUsr.Size = new global::System.Drawing.Size(99, 24);
			this.txtProxyUsr.TabIndex = 36;
			this.txtProxyPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtProxyPassword.Location = new global::System.Drawing.Point(207, 72);
			this.txtProxyPassword.Name = "txtProxyPassword";
			this.txtProxyPassword.Size = new global::System.Drawing.Size(59, 18);
			this.txtProxyPassword.TabIndex = 37;
			this.txtProxyPassword.Text = "Password :";
			this.radLabel11.Location = new global::System.Drawing.Point(17, 72);
			this.radLabel11.Name = "radLabel11";
			this.radLabel11.Size = new global::System.Drawing.Size(62, 18);
			this.radLabel11.TabIndex = 2;
			this.radLabel11.Text = "Username :";
			this.txtProxyUrl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtProxyUrl.Location = new global::System.Drawing.Point(49, 27);
			this.txtProxyUrl.MinimumSize = new global::System.Drawing.Size(0, 24);
			this.txtProxyUrl.Name = "txtProxyUrl";
			this.txtProxyUrl.NullText = "http://someproxy.com:8080";
			this.txtProxyUrl.RootElement.MinSize = new global::System.Drawing.Size(0, 24);
			this.txtProxyUrl.Size = new global::System.Drawing.Size(387, 24);
			this.txtProxyUrl.TabIndex = 35;
			this.radLabel10.Location = new global::System.Drawing.Point(17, 28);
			this.radLabel10.Name = "radLabel10";
			this.radLabel10.Size = new global::System.Drawing.Size(26, 18);
			this.radLabel10.TabIndex = 1;
			this.radLabel10.Text = "Url :";
			this.toolEmuSettings.Caption = null;
			this.toolEmuSettings.Controls.Add(this.radGroupBox5);
			this.toolEmuSettings.Controls.Add(this.radGroupBox21);
			this.toolEmuSettings.Controls.Add(this.radGroupBox17);
			this.toolEmuSettings.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolEmuSettings.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolEmuSettings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolEmuSettings.Image");
			this.toolEmuSettings.Location = new global::System.Drawing.Point(6, 29);
			this.toolEmuSettings.Name = "toolEmuSettings";
			this.toolEmuSettings.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolEmuSettings.Size = new global::System.Drawing.Size(449, 369);
			this.toolEmuSettings.Text = "Emu. settings";
			this.toolEmuSettings.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox5.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox5.Controls.Add(this.radButton7);
			this.radGroupBox5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox5.HeaderText = "Cloud saving";
			this.radGroupBox5.Location = new global::System.Drawing.Point(0, 280);
			this.radGroupBox5.Name = "radGroupBox5";
			this.radGroupBox5.Padding = new global::System.Windows.Forms.Padding(20);
			this.radGroupBox5.Size = new global::System.Drawing.Size(449, 92);
			this.radGroupBox5.TabIndex = 4;
			this.radGroupBox5.Text = "Cloud saving";
			this.radButton7.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.radButton7.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radButton7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("radButton7.Image");
			this.radButton7.Location = new global::System.Drawing.Point(20, 20);
			this.radButton7.Name = "radButton7";
			this.radButton7.Padding = new global::System.Windows.Forms.Padding(3, 0, 0, 0);
			this.radButton7.Size = new global::System.Drawing.Size(409, 52);
			this.radButton7.TabIndex = 7;
			this.radButton7.Text = "Configure cloud saving";
			this.radButton7.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.radButton7.Click += new global::System.EventHandler(this.radButton7_Click);
			this.radGroupBox21.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox21.Controls.Add(this.radLabel22);
			this.radGroupBox21.Controls.Add(this.radButton2);
			this.radGroupBox21.Controls.Add(this.chkForceGameMode);
			this.radGroupBox21.Controls.Add(this.radLabel23);
			this.radGroupBox21.Controls.Add(this.radLabel13);
			this.radGroupBox21.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox21.HeaderText = "Game Mode (NEW VERSION!";
			this.radGroupBox21.Location = new global::System.Drawing.Point(0, 109);
			this.radGroupBox21.Name = "radGroupBox21";
			this.radGroupBox21.Padding = new global::System.Windows.Forms.Padding(15);
			this.radGroupBox21.Size = new global::System.Drawing.Size(449, 171);
			this.radGroupBox21.TabIndex = 3;
			this.radGroupBox21.Text = "Game Mode (NEW VERSION!";
			this.radLabel22.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radLabel22.Location = new global::System.Drawing.Point(15, 47);
			this.radLabel22.Name = "radLabel22";
			this.radLabel22.Size = new global::System.Drawing.Size(419, 18);
			this.radLabel22.TabIndex = 8;
			this.radLabel22.Text = " ";
			this.radButton2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.radButton2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("radButton2.Image");
			this.radButton2.Location = new global::System.Drawing.Point(15, 65);
			this.radButton2.Name = "radButton2";
			this.radButton2.Padding = new global::System.Windows.Forms.Padding(8);
			this.radButton2.Size = new global::System.Drawing.Size(419, 55);
			this.radButton2.TabIndex = 6;
			this.radButton2.Text = "Switch to Game Mode";
			this.radButton2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.radButton2.Click += new global::System.EventHandler(this.radButton2_Click);
			this.chkForceGameMode.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.chkForceGameMode.Location = new global::System.Drawing.Point(15, 120);
			this.chkForceGameMode.Margin = new global::System.Windows.Forms.Padding(10);
			this.chkForceGameMode.Name = "chkForceGameMode";
			this.chkForceGameMode.Size = new global::System.Drawing.Size(419, 18);
			this.chkForceGameMode.TabIndex = 7;
			this.chkForceGameMode.Text = "Automatically launch Game Mode on start";
			this.chkForceGameMode.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkForceGameMode_ToggleStateChanged);
			this.radLabel23.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radLabel23.Location = new global::System.Drawing.Point(15, 138);
			this.radLabel23.Name = "radLabel23";
			this.radLabel23.Size = new global::System.Drawing.Size(419, 18);
			this.radLabel23.TabIndex = 9;
			this.radLabel23.Text = " ";
			this.radLabel13.Location = new global::System.Drawing.Point(18, 23);
			this.radLabel13.Name = "radLabel13";
			this.radLabel13.Size = new global::System.Drawing.Size(319, 18);
			this.radLabel13.TabIndex = 0;
			this.radLabel13.Text = "Game Mode is a brand new interface optimized for controllers.";
			this.radGroupBox17.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox17.Controls.Add(this.radButton4);
			this.radGroupBox17.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox17.HeaderText = "Configure emulators";
			this.radGroupBox17.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox17.Name = "radGroupBox17";
			this.radGroupBox17.Padding = new global::System.Windows.Forms.Padding(20, 30, 20, 20);
			this.radGroupBox17.Size = new global::System.Drawing.Size(449, 109);
			this.radGroupBox17.TabIndex = 1;
			this.radGroupBox17.Text = "Configure emulators";
			this.radButton4.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.radButton4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radButton4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("radButton4.Image");
			this.radButton4.Location = new global::System.Drawing.Point(20, 30);
			this.radButton4.Name = "radButton4";
			this.radButton4.Padding = new global::System.Windows.Forms.Padding(3, 0, 0, 0);
			this.radButton4.Size = new global::System.Drawing.Size(409, 59);
			this.radButton4.TabIndex = 7;
			this.radButton4.Text = "Configure emulators";
			this.radButton4.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.radButton4.Click += new global::System.EventHandler(this.radButton4_Click);
			this.toolContribute.Caption = null;
			this.toolContribute.Controls.Add(this.radGroupBox15);
			this.toolContribute.Controls.Add(this.radGroupBox20);
			this.toolContribute.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolContribute.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolContribute.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolContribute.Image");
			this.toolContribute.Location = new global::System.Drawing.Point(6, 29);
			this.toolContribute.Name = "toolContribute";
			this.toolContribute.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolContribute.Size = new global::System.Drawing.Size(449, 369);
			this.toolContribute.Text = "Contribute";
			this.toolContribute.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox15.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox15.Controls.Add(this.radGroupBox16);
			this.radGroupBox15.Controls.Add(this.radLabel14);
			this.radGroupBox15.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox15.HeaderText = "Donation";
			this.radGroupBox15.Location = new global::System.Drawing.Point(0, 100);
			this.radGroupBox15.Name = "radGroupBox15";
			this.radGroupBox15.Size = new global::System.Drawing.Size(449, 269);
			this.radGroupBox15.TabIndex = 35;
			this.radGroupBox15.Text = "Donation";
			this.radGroupBox16.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox16.Controls.Add(this.cmdDonate);
			this.radGroupBox16.Controls.Add(this.lblDonatorDate);
			this.radGroupBox16.Controls.Add(this.lblDonatorStatus);
			this.radGroupBox16.Controls.Add(this.radLabel18);
			this.radGroupBox16.Controls.Add(this.lblDonatorEmail);
			this.radGroupBox16.Controls.Add(this.radLabel16);
			this.radGroupBox16.Controls.Add(this.radLabel15);
			this.radGroupBox16.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox16.HeaderText = "Info";
			this.radGroupBox16.Location = new global::System.Drawing.Point(2, 18);
			this.radGroupBox16.Name = "radGroupBox16";
			this.radGroupBox16.Size = new global::System.Drawing.Size(445, 249);
			this.radGroupBox16.TabIndex = 40;
			this.radGroupBox16.Text = "Info";
			this.cmdDonate.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdDonate.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cmdDonate.Location = new global::System.Drawing.Point(2, 212);
			this.cmdDonate.Name = "cmdDonate";
			this.cmdDonate.Size = new global::System.Drawing.Size(441, 35);
			this.cmdDonate.TabIndex = 39;
			this.cmdDonate.Text = "Donate or set Donation Key";
			this.cmdDonate.Click += new global::System.EventHandler(this.cmdDonate_Click);
			this.lblDonatorDate.Location = new global::System.Drawing.Point(112, 76);
			this.lblDonatorDate.Name = "lblDonatorDate";
			this.lblDonatorDate.Size = new global::System.Drawing.Size(11, 18);
			this.lblDonatorDate.TabIndex = 6;
			this.lblDonatorDate.Text = "-";
			this.lblDonatorStatus.ForeColor = global::System.Drawing.Color.Red;
			this.lblDonatorStatus.Location = new global::System.Drawing.Point(112, 28);
			this.lblDonatorStatus.Name = "lblDonatorStatus";
			this.lblDonatorStatus.Size = new global::System.Drawing.Size(109, 18);
			this.lblDonatorStatus.TabIndex = 4;
			this.lblDonatorStatus.Text = "You are not a donor.";
			this.radLabel18.Location = new global::System.Drawing.Point(17, 76);
			this.radLabel18.Name = "radLabel18";
			this.radLabel18.Size = new global::System.Drawing.Size(72, 18);
			this.radLabel18.TabIndex = 5;
			this.radLabel18.Text = "Donor since :";
			this.lblDonatorEmail.Location = new global::System.Drawing.Point(112, 52);
			this.lblDonatorEmail.Name = "lblDonatorEmail";
			this.lblDonatorEmail.Size = new global::System.Drawing.Size(11, 18);
			this.lblDonatorEmail.TabIndex = 5;
			this.lblDonatorEmail.Text = "-";
			this.radLabel16.Location = new global::System.Drawing.Point(17, 52);
			this.radLabel16.Name = "radLabel16";
			this.radLabel16.Size = new global::System.Drawing.Size(73, 18);
			this.radLabel16.TabIndex = 4;
			this.radLabel16.Text = "Donor email :";
			this.radLabel15.Location = new global::System.Drawing.Point(17, 28);
			this.radLabel15.Name = "radLabel15";
			this.radLabel15.Size = new global::System.Drawing.Size(91, 18);
			this.radLabel15.TabIndex = 3;
			this.radLabel15.Text = "Donation status :";
			this.radLabel14.Location = new global::System.Drawing.Point(17, 28);
			this.radLabel14.Name = "radLabel14";
			this.radLabel14.Size = new global::System.Drawing.Size(91, 18);
			this.radLabel14.TabIndex = 3;
			this.radLabel14.Text = "Donation status :";
			this.radGroupBox20.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox20.Controls.Add(this.cmdSugegstIdea);
			this.radGroupBox20.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox20.HeaderText = "Suggest features/improvements";
			this.radGroupBox20.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox20.Name = "radGroupBox20";
			this.radGroupBox20.Padding = new global::System.Windows.Forms.Padding(20);
			this.radGroupBox20.Size = new global::System.Drawing.Size(449, 100);
			this.radGroupBox20.TabIndex = 10;
			this.radGroupBox20.Text = "Suggest features/improvements";
			this.cmdSugegstIdea.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdSugegstIdea.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cmdSugegstIdea.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdSugegstIdea.Image");
			this.cmdSugegstIdea.Location = new global::System.Drawing.Point(20, 20);
			this.cmdSugegstIdea.Name = "cmdSugegstIdea";
			this.cmdSugegstIdea.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdSugegstIdea.Size = new global::System.Drawing.Size(409, 60);
			this.cmdSugegstIdea.TabIndex = 8;
			this.cmdSugegstIdea.Text = "   Suggest an idea";
			this.cmdSugegstIdea.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdSugegstIdea.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSugegstIdea.Click += new global::System.EventHandler(this.cmdSugegstIdea_Click);
			this.toolHelp.Caption = null;
			this.toolHelp.Controls.Add(this.radGroupBox24);
			this.toolHelp.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolHelp.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolHelp.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolHelp.Image");
			this.toolHelp.Location = new global::System.Drawing.Point(6, 29);
			this.toolHelp.Name = "toolHelp";
			this.toolHelp.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolHelp.Size = new global::System.Drawing.Size(449, 369);
			this.toolHelp.Text = "Help";
			this.toolHelp.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox24.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox24.Controls.Add(this.cmdPrepareSd);
			this.radGroupBox24.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox24.HeaderText = "Prepare my SD for homebrew";
			this.radGroupBox24.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox24.Name = "radGroupBox24";
			this.radGroupBox24.Padding = new global::System.Windows.Forms.Padding(20);
			this.radGroupBox24.Size = new global::System.Drawing.Size(449, 92);
			this.radGroupBox24.TabIndex = 7;
			this.radGroupBox24.Text = "Prepare my SD for homebrew";
			this.cmdPrepareSd.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdPrepareSd.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.cmdPrepareSd.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdPrepareSd.Image");
			this.cmdPrepareSd.Location = new global::System.Drawing.Point(20, 20);
			this.cmdPrepareSd.Name = "cmdPrepareSd";
			this.cmdPrepareSd.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdPrepareSd.Size = new global::System.Drawing.Size(409, 52);
			this.cmdPrepareSd.TabIndex = 6;
			this.cmdPrepareSd.Text = "Prepare my SD";
			this.cmdPrepareSd.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdPrepareSd.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdPrepareSd.Click += new global::System.EventHandler(this.cmdPrepareSd_Click);
			this.toolTabStrip1.CanUpdateChildIndex = true;
			this.toolTabStrip1.Controls.Add(this.toolGameInfo);
			this.toolTabStrip1.Location = new global::System.Drawing.Point(463, 0);
			this.toolTabStrip1.Name = "toolTabStrip1";
			this.toolTabStrip1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.toolTabStrip1.SelectedIndex = 0;
			this.toolTabStrip1.Size = new global::System.Drawing.Size(669, 404);
			this.toolTabStrip1.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(669, 200);
			this.toolTabStrip1.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(469, 0);
			this.toolTabStrip1.TabIndex = 5;
			this.toolTabStrip1.TabStop = false;
			this.toolGameInfo.AutoScroll = true;
			this.toolGameInfo.Caption = null;
			this.toolGameInfo.Controls.Add(this.radGroupBox6);
			this.toolGameInfo.Controls.Add(this.radGroupBox1);
			this.toolGameInfo.Controls.Add(this.radGroupBox3);
			this.toolGameInfo.Controls.Add(this.lblTitle);
			this.toolGameInfo.DefaultFloatingSize = new global::System.Drawing.Size(600, 400);
			this.toolGameInfo.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolGameInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolGameInfo.Location = new global::System.Drawing.Point(1, 22);
			this.toolGameInfo.Name = "toolGameInfo";
			this.toolGameInfo.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolGameInfo.Size = new global::System.Drawing.Size(667, 380);
			this.toolGameInfo.Text = "Game Info";
			this.toolGameInfo.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox6.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox6.Controls.Add(this.dockInfo);
			this.radGroupBox6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox6.HeaderText = "About";
			this.radGroupBox6.Location = new global::System.Drawing.Point(0, 22);
			this.radGroupBox6.Name = "radGroupBox6";
			this.radGroupBox6.Size = new global::System.Drawing.Size(667, 204);
			this.radGroupBox6.TabIndex = 32;
			this.radGroupBox6.Text = "About";
			this.dockInfo.ActiveWindow = this.toolGameDesc;
			this.dockInfo.CausesValidation = false;
			this.dockInfo.Controls.Add(this.documentContainer2);
			this.dockInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dockInfo.DocumentManager.ActiveDocumentMenuSortOrder = global::Telerik.WinControls.UI.Docking.ActiveDocumentListSortOrder.None;
			this.dockInfo.IsCleanUpTarget = true;
			this.dockInfo.Location = new global::System.Drawing.Point(2, 18);
			this.dockInfo.MainDocumentContainer = this.documentContainer2;
			this.dockInfo.Name = "dockInfo";
			this.dockInfo.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.dockInfo.Size = new global::System.Drawing.Size(663, 184);
			this.dockInfo.SplitterWidth = 2;
			this.dockInfo.TabIndex = 33;
			this.dockInfo.TabStop = false;
			this.dockInfo.Text = "radDock2";
			this.dockInfo.ActiveWindowChanged += new global::Telerik.WinControls.UI.Docking.DockWindowEventHandler(this.dockInfo_ActiveWindowChanged);
			this.toolGameDesc.Caption = null;
			this.toolGameDesc.Controls.Add(this.txtDesc);
			this.toolGameDesc.Controls.Add(this.panelGameCover);
			this.toolGameDesc.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolGameDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolGameDesc.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolGameDesc.Image");
			this.toolGameDesc.Location = new global::System.Drawing.Point(6, 29);
			this.toolGameDesc.Name = "toolGameDesc";
			this.toolGameDesc.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolGameDesc.Size = new global::System.Drawing.Size(641, 139);
			this.toolGameDesc.Text = "Game Info";
			this.toolGameDesc.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.txtDesc.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDesc.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.IsReadOnly = true;
			this.txtDesc.Location = new global::System.Drawing.Point(0, 0);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Padding = new global::System.Windows.Forms.Padding(10, 20, 10, 20);
			this.txtDesc.Size = new global::System.Drawing.Size(413, 139);
			this.txtDesc.TabIndex = 20;
			this.panelGameCover.Controls.Add(this.cmdShortcut);
			this.panelGameCover.Controls.Add(this.cmdPlay);
			this.panelGameCover.Controls.Add(this.pictureLogo);
			this.panelGameCover.Controls.Add(this.pbCover);
			this.panelGameCover.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panelGameCover.Location = new global::System.Drawing.Point(413, 0);
			this.panelGameCover.Name = "panelGameCover";
			this.panelGameCover.Size = new global::System.Drawing.Size(228, 139);
			this.panelGameCover.TabIndex = 25;
			this.cmdShortcut.AccessibleName = "Add desktop shortcut";
			this.cmdShortcut.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdShortcut.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdShortcut.Enabled = false;
			this.cmdShortcut.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdShortcut.Image");
			this.cmdShortcut.Location = new global::System.Drawing.Point(0, 25);
			this.cmdShortcut.Name = "cmdShortcut";
			this.cmdShortcut.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdShortcut.Size = new global::System.Drawing.Size(228, 57);
			this.cmdShortcut.TabIndex = 22;
			this.cmdShortcut.Text = " Add Desktop/Steam Shortcut";
			this.cmdShortcut.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdShortcut.Click += new global::System.EventHandler(this.cmdShortcut_Click);
			this.cmdPlay.AccessibleName = "Play this game";
			this.cmdPlay.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdPlay.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdPlay.Enabled = false;
			this.cmdPlay.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdPlay.Image");
			this.cmdPlay.Location = new global::System.Drawing.Point(0, 82);
			this.cmdPlay.Name = "cmdPlay";
			this.cmdPlay.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdPlay.Size = new global::System.Drawing.Size(228, 57);
			this.cmdPlay.TabIndex = 5;
			this.cmdPlay.Text = "&Play this game on PC";
			this.cmdPlay.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdPlay.Click += new global::System.EventHandler(this.cmdPlay_Click);
			this.pictureLogo.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pictureLogo.Location = new global::System.Drawing.Point(0, 0);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new global::System.Drawing.Size(228, 25);
			this.pictureLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureLogo.TabIndex = 21;
			this.pictureLogo.TabStop = false;
			this.pbCover.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pbCover.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pbCover.Location = new global::System.Drawing.Point(0, 0);
			this.pbCover.Name = "pbCover";
			this.pbCover.Size = new global::System.Drawing.Size(228, 139);
			this.pbCover.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbCover.TabIndex = 19;
			this.pbCover.TabStop = false;
			this.pbCover.Paint += new global::System.Windows.Forms.PaintEventHandler(this.pbCover_Paint);
			this.pbCover.DoubleClick += new global::System.EventHandler(this.pbCover_DoubleClick);
			this.documentContainer2.CausesValidation = false;
			this.documentContainer2.Controls.Add(this.documentTabStrip2);
			this.documentContainer2.Name = "documentContainer2";
			this.documentContainer2.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.documentContainer2.SizeInfo.SizeMode = global::Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
			this.documentContainer2.SplitterWidth = 2;
			this.documentTabStrip2.CanUpdateChildIndex = true;
			this.documentTabStrip2.CausesValidation = false;
			this.documentTabStrip2.Controls.Add(this.toolGameDesc);
			this.documentTabStrip2.Controls.Add(this.toolMods);
			this.documentTabStrip2.Controls.Add(this.toolExtraInfo);
			this.documentTabStrip2.Controls.Add(this.toolScreenShot);
			this.documentTabStrip2.Controls.Add(this.toolWeb);
			this.documentTabStrip2.Controls.Add(this.toolMovies);
			this.documentTabStrip2.Controls.Add(this.tollSaveManager);
			this.documentTabStrip2.Controls.Add(this.toolChat);
			this.documentTabStrip2.Location = new global::System.Drawing.Point(0, 0);
			this.documentTabStrip2.Name = "documentTabStrip2";
			this.documentTabStrip2.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.documentTabStrip2.SelectedIndex = 0;
			this.documentTabStrip2.Size = new global::System.Drawing.Size(653, 174);
			this.documentTabStrip2.TabIndex = 0;
			this.documentTabStrip2.TabStop = false;
			this.toolMods.Caption = null;
			this.toolMods.Controls.Add(this.lblModsOnlyCemu);
			this.toolMods.Controls.Add(this.radGroupBox29);
			this.toolMods.Controls.Add(this.radGroupBox27);
			this.toolMods.DefaultFloatingSize = new global::System.Drawing.Size(800, 800);
			this.toolMods.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolMods.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolMods.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolMods.Image");
			this.toolMods.Location = new global::System.Drawing.Point(6, 29);
			this.toolMods.Name = "toolMods";
			this.toolMods.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolMods.Size = new global::System.Drawing.Size(641, 139);
			this.toolMods.Text = "Mods";
			this.toolMods.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.lblModsOnlyCemu.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblModsOnlyCemu.AutoSize = false;
			this.lblModsOnlyCemu.Location = new global::System.Drawing.Point(-3, 0);
			this.lblModsOnlyCemu.Name = "lblModsOnlyCemu";
			this.lblModsOnlyCemu.Size = new global::System.Drawing.Size(638, 139);
			this.lblModsOnlyCemu.TabIndex = 3;
			this.lblModsOnlyCemu.Text = "Mods can only be used with Cemu games";
			this.lblModsOnlyCemu.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radGroupBox29.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox29.Controls.Add(this.lstMods);
			this.radGroupBox29.Controls.Add(this.txtModSearch);
			this.radGroupBox29.Controls.Add(this.cmdModContribute);
			this.radGroupBox29.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox29.HeaderText = "Mods- DON'T CLOSE USB HELPER WHILE PLAYING!";
			this.radGroupBox29.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox29.Name = "radGroupBox29";
			this.radGroupBox29.Size = new global::System.Drawing.Size(271, 139);
			this.radGroupBox29.TabIndex = 34;
			this.radGroupBox29.Text = "Mods- DON'T CLOSE USB HELPER WHILE PLAYING!";
			this.lstMods.AllowRemove = false;
			this.lstMods.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstMods.EnableFiltering = true;
			this.lstMods.Location = new global::System.Drawing.Point(2, 18);
			this.lstMods.Name = "lstMods";
			this.lstMods.Size = new global::System.Drawing.Size(267, 75);
			this.lstMods.TabIndex = 0;
			this.lstMods.Text = "radCheckedListBox1";
			this.lstMods.SelectedItemChanged += new global::System.EventHandler(this.lstMods_SelectedItemChanged);
			this.lstMods.ItemCheckedChanging += new global::Telerik.WinControls.UI.ListViewItemCancelEventHandler(this.lstMods_ItemCheckedChanging);
			this.txtModSearch.CharacterCasing = global::System.Windows.Forms.CharacterCasing.Upper;
			this.txtModSearch.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.txtModSearch.Location = new global::System.Drawing.Point(2, 93);
			this.txtModSearch.Name = "txtModSearch";
			this.txtModSearch.NullText = "Search...";
			this.txtModSearch.Size = new global::System.Drawing.Size(267, 20);
			this.txtModSearch.TabIndex = 1;
			this.txtModSearch.TextChanged += new global::System.EventHandler(this.txtModSearch_TextChanged);
			this.cmdModContribute.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdModContribute.Location = new global::System.Drawing.Point(2, 113);
			this.cmdModContribute.Name = "cmdModContribute";
			this.cmdModContribute.Size = new global::System.Drawing.Size(267, 24);
			this.cmdModContribute.TabIndex = 2;
			this.cmdModContribute.Text = "Suggest new mod/update";
			this.cmdModContribute.Click += new global::System.EventHandler(this.cmdModContribute_Click);
			this.radGroupBox27.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox27.Controls.Add(this.modPreview);
			this.radGroupBox27.Controls.Add(this.txtModDescription);
			this.radGroupBox27.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.radGroupBox27.HeaderText = "Info";
			this.radGroupBox27.Location = new global::System.Drawing.Point(271, 0);
			this.radGroupBox27.Name = "radGroupBox27";
			this.radGroupBox27.Size = new global::System.Drawing.Size(370, 139);
			this.radGroupBox27.TabIndex = 1;
			this.radGroupBox27.Text = "Info";
			this.modPreview.BackColor = global::System.Drawing.Color.Black;
			carouselBezierPath.CtrlPoint1 = new global::Telerik.WinControls.UI.Point3D(14.0, 76.0, 70.0);
			carouselBezierPath.CtrlPoint2 = new global::Telerik.WinControls.UI.Point3D(86.0, 76.0, 70.0);
			carouselBezierPath.FirstPoint = new global::Telerik.WinControls.UI.Point3D(10.0, 20.0, 0.0);
			carouselBezierPath.LastPoint = new global::Telerik.WinControls.UI.Point3D(90.0, 20.0, 0.0);
			carouselBezierPath.ZScale = 500.0;
			this.modPreview.CarouselPath = carouselBezierPath;
			this.modPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.modPreview.Location = new global::System.Drawing.Point(2, 209);
			this.modPreview.Name = "modPreview";
			this.modPreview.SelectedIndex = -1;
			this.modPreview.Size = new global::System.Drawing.Size(366, 0);
			this.modPreview.TabIndex = 1;
			this.modPreview.Text = "Preview";
			this.txtModDescription.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtModDescription.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtModDescription.IsReadOnly = true;
			this.txtModDescription.Location = new global::System.Drawing.Point(2, 18);
			this.txtModDescription.Multiline = true;
			this.txtModDescription.Name = "txtModDescription";
			this.txtModDescription.Size = new global::System.Drawing.Size(366, 191);
			this.txtModDescription.TabIndex = 0;
			this.toolExtraInfo.Caption = null;
			this.toolExtraInfo.Controls.Add(this.radGroupBox11);
			this.toolExtraInfo.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolExtraInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolExtraInfo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolExtraInfo.Image");
			this.toolExtraInfo.Location = new global::System.Drawing.Point(6, 29);
			this.toolExtraInfo.Name = "toolExtraInfo";
			this.toolExtraInfo.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolExtraInfo.Size = new global::System.Drawing.Size(641, 139);
			this.toolExtraInfo.Text = "Extra";
			this.toolExtraInfo.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radGroupBox11.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox11.Controls.Add(this.lblLang);
			this.radGroupBox11.Controls.Add(this.lstLanguages);
			this.radGroupBox11.Controls.Add(this.pbRating);
			this.radGroupBox11.Controls.Add(this.label10);
			this.radGroupBox11.Controls.Add(this.label3);
			this.radGroupBox11.Controls.Add(this.lstGenre);
			this.radGroupBox11.Controls.Add(this.pgScore);
			this.radGroupBox11.Controls.Add(this.lstControllers);
			this.radGroupBox11.Controls.Add(this.label8);
			this.radGroupBox11.Controls.Add(this.label9);
			this.radGroupBox11.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox11.HeaderText = "Addtional info";
			this.radGroupBox11.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox11.Name = "radGroupBox11";
			this.radGroupBox11.Padding = new global::System.Windows.Forms.Padding(0);
			this.radGroupBox11.Size = new global::System.Drawing.Size(641, 139);
			this.radGroupBox11.TabIndex = 9;
			this.radGroupBox11.Text = "Addtional info";
			this.lblLang.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.lblLang.AutoSize = true;
			this.lblLang.Location = new global::System.Drawing.Point(523, 161);
			this.lblLang.Name = "lblLang";
			this.lblLang.Size = new global::System.Drawing.Size(60, 13);
			this.lblLang.TabIndex = 10;
			this.lblLang.Text = "Languages";
			this.lstLanguages.AllowEdit = false;
			this.lstLanguages.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.lstLanguages.HorizontalScrollState = global::Telerik.WinControls.UI.ScrollState.AlwaysHide;
			this.lstLanguages.Location = new global::System.Drawing.Point(526, 18);
			this.lstLanguages.Name = "lstLanguages";
			this.lstLanguages.SelectLastAddedItem = false;
			this.lstLanguages.Size = new global::System.Drawing.Size(118, 103);
			this.lstLanguages.TabIndex = 9;
			this.lstLanguages.Text = "radListView1";
			this.pbRating.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pbRating.Location = new global::System.Drawing.Point(10, 29);
			this.pbRating.Name = "pbRating";
			this.pbRating.Size = new global::System.Drawing.Size(66, 80);
			this.pbRating.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbRating.TabIndex = 1;
			this.pbRating.TabStop = false;
			this.label10.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(319, 161);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(36, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Genre";
			this.label3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 160);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Rating";
			this.lstGenre.AllowEdit = false;
			this.lstGenre.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.lstGenre.Location = new global::System.Drawing.Point(316, 18);
			this.lstGenre.Name = "lstGenre";
			this.lstGenre.SelectLastAddedItem = false;
			this.lstGenre.Size = new global::System.Drawing.Size(204, 103);
			this.lstGenre.TabIndex = 7;
			this.lstGenre.Text = "radListView1";
			this.pgScore.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.pgScore.Location = new global::System.Drawing.Point(278, 18);
			this.pgScore.Name = "pgScore";
			this.pgScore.ProgressOrientation = global::Telerik.WinControls.ProgressOrientation.Bottom;
			this.pgScore.ShowProgressIndicators = true;
			this.pgScore.Size = new global::System.Drawing.Size(32, 103);
			this.pgScore.TabIndex = 3;
			this.pgScore.Text = "0 %";
			this.lstControllers.AllowEdit = false;
			this.lstControllers.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.lstControllers.Location = new global::System.Drawing.Point(81, 18);
			this.lstControllers.Name = "lstControllers";
			this.lstControllers.SelectLastAddedItem = false;
			this.lstControllers.Size = new global::System.Drawing.Size(191, 103);
			this.lstControllers.TabIndex = 6;
			this.lstControllers.Text = "radListView1";
			this.label8.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(278, 161);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(35, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Score";
			this.label9.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(78, 161);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(110, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Compatible controllers";
			this.toolScreenShot.Caption = null;
			this.toolScreenShot.Controls.Add(this.pbPreview3);
			this.toolScreenShot.Controls.Add(this.pbPreview1);
			this.toolScreenShot.Controls.Add(this.pbPreview2);
			this.toolScreenShot.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolScreenShot.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolScreenShot.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolScreenShot.Image");
			this.toolScreenShot.Location = new global::System.Drawing.Point(6, 29);
			this.toolScreenShot.Name = "toolScreenShot";
			this.toolScreenShot.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolScreenShot.Size = new global::System.Drawing.Size(641, 139);
			this.toolScreenShot.Text = "Screenshots";
			this.toolScreenShot.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.pbPreview3.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pbPreview3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pbPreview3.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pbPreview3.InitialImage");
			this.pbPreview3.Location = new global::System.Drawing.Point(458, 26);
			this.pbPreview3.Name = "pbPreview3";
			this.pbPreview3.Size = new global::System.Drawing.Size(180, 101);
			this.pbPreview3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPreview3.TabIndex = 3;
			this.pbPreview3.TabStop = false;
			this.pbPreview1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pbPreview1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pbPreview1.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pbPreview1.InitialImage");
			this.pbPreview1.Location = new global::System.Drawing.Point(2, 26);
			this.pbPreview1.Name = "pbPreview1";
			this.pbPreview1.Size = new global::System.Drawing.Size(180, 101);
			this.pbPreview1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPreview1.TabIndex = 0;
			this.pbPreview1.TabStop = false;
			this.pbPreview2.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pbPreview2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pbPreview2.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pbPreview2.InitialImage");
			this.pbPreview2.Location = new global::System.Drawing.Point(227, 26);
			this.pbPreview2.Name = "pbPreview2";
			this.pbPreview2.Size = new global::System.Drawing.Size(180, 101);
			this.pbPreview2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPreview2.TabIndex = 2;
			this.pbPreview2.TabStop = false;
			this.toolWeb.Caption = null;
			this.toolWeb.Controls.Add(this.webBrowser);
			this.toolWeb.Controls.Add(this.radGroupBox8);
			this.toolWeb.DefaultFloatingSize = new global::System.Drawing.Size(800, 600);
			this.toolWeb.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolWeb.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolWeb.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolWeb.Image");
			this.toolWeb.Location = new global::System.Drawing.Point(6, 29);
			this.toolWeb.Name = "toolWeb";
			this.toolWeb.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWeb.Size = new global::System.Drawing.Size(641, 139);
			this.toolWeb.Text = "On the Web";
			this.toolWeb.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new global::System.Drawing.Point(0, 47);
			this.webBrowser.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.ScriptErrorsSuppressed = true;
			this.webBrowser.Size = new global::System.Drawing.Size(641, 92);
			this.webBrowser.TabIndex = 0;
			this.webBrowser.TabStop = false;
			this.radGroupBox8.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox8.AutoSize = true;
			this.radGroupBox8.Controls.Add(this.cmdGoNext);
			this.radGroupBox8.Controls.Add(this.cmdGoBack);
			this.radGroupBox8.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox8.HeaderText = "Commands";
			this.radGroupBox8.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox8.Name = "radGroupBox8";
			this.radGroupBox8.Size = new global::System.Drawing.Size(641, 47);
			this.radGroupBox8.TabIndex = 1;
			this.radGroupBox8.Text = "Commands";
			this.cmdGoNext.Location = new global::System.Drawing.Point(104, 21);
			this.cmdGoNext.Name = "cmdGoNext";
			this.cmdGoNext.Size = new global::System.Drawing.Size(87, 24);
			this.cmdGoNext.TabIndex = 1;
			this.cmdGoNext.Text = ">";
			this.cmdGoNext.Click += new global::System.EventHandler(this.cmdGoNext_Click);
			this.cmdGoBack.Location = new global::System.Drawing.Point(11, 21);
			this.cmdGoBack.Name = "cmdGoBack";
			this.cmdGoBack.Size = new global::System.Drawing.Size(87, 24);
			this.cmdGoBack.TabIndex = 0;
			this.cmdGoBack.Text = "<";
			this.cmdGoBack.Click += new global::System.EventHandler(this.cmdGoBack_Click);
			this.toolMovies.Caption = null;
			this.toolMovies.Controls.Add(this.lstMovies);
			this.toolMovies.Controls.Add(this.radLabel7);
			this.toolMovies.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolMovies.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolMovies.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolMovies.Image");
			this.toolMovies.Location = new global::System.Drawing.Point(6, 29);
			this.toolMovies.Name = "toolMovies";
			this.toolMovies.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolMovies.Size = new global::System.Drawing.Size(641, 139);
			this.toolMovies.Text = "Movies";
			this.toolMovies.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.lstMovies.AllowEdit = false;
			this.lstMovies.AllowRemove = false;
			this.lstMovies.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstMovies.Location = new global::System.Drawing.Point(0, 18);
			this.lstMovies.Name = "lstMovies";
			this.lstMovies.Size = new global::System.Drawing.Size(641, 121);
			this.lstMovies.TabIndex = 1;
			this.lstMovies.Text = "radListView1";
			this.lstMovies.ItemMouseDoubleClick += new global::Telerik.WinControls.UI.ListViewItemEventHandler(this.lstMovies_ItemMouseDoubleClick);
			this.radLabel7.AutoSize = false;
			this.radLabel7.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel7.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel7.Name = "radLabel7";
			this.radLabel7.Size = new global::System.Drawing.Size(641, 18);
			this.radLabel7.TabIndex = 0;
			this.radLabel7.Text = "Note : Double click to play";
			this.tollSaveManager.Caption = null;
			this.tollSaveManager.Controls.Add(this.cmdCommunitySaves);
			this.tollSaveManager.Controls.Add(this.cmdImportCemu);
			this.tollSaveManager.Controls.Add(this.radLabel8);
			this.tollSaveManager.Controls.Add(this.cmdRestoreSave);
			this.tollSaveManager.Controls.Add(this.cmdBackupSave);
			this.tollSaveManager.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.tollSaveManager.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.tollSaveManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tollSaveManager.Image");
			this.tollSaveManager.Location = new global::System.Drawing.Point(6, 29);
			this.tollSaveManager.Name = "tollSaveManager";
			this.tollSaveManager.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.tollSaveManager.Size = new global::System.Drawing.Size(641, 139);
			this.tollSaveManager.Text = "Save Manager";
			this.tollSaveManager.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.cmdCommunitySaves.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdCommunitySaves.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdCommunitySaves.Image = global::ns0.Class121.glbIcon;
			this.cmdCommunitySaves.Location = new global::System.Drawing.Point(483, 54);
			this.cmdCommunitySaves.Name = "cmdCommunitySaves";
			this.cmdCommunitySaves.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdCommunitySaves.Size = new global::System.Drawing.Size(152, 52);
			this.cmdCommunitySaves.TabIndex = 9;
			this.cmdCommunitySaves.Text = " Commmunity ";
			this.cmdCommunitySaves.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCommunitySaves.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCommunitySaves.Click += new global::System.EventHandler(this.cmdCommunitySaves_Click);
			this.cmdImportCemu.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdImportCemu.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdImportCemu.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdImportCemu.Image");
			this.cmdImportCemu.Location = new global::System.Drawing.Point(164, 53);
			this.cmdImportCemu.Name = "cmdImportCemu";
			this.cmdImportCemu.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdImportCemu.Size = new global::System.Drawing.Size(160, 53);
			this.cmdImportCemu.TabIndex = 8;
			this.cmdImportCemu.Text = "Import to Cemu";
			this.cmdImportCemu.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdImportCemu.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdImportCemu.Click += new global::System.EventHandler(this.cmdImportCemu_Click);
			this.radLabel8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.radLabel8.ForeColor = global::System.Drawing.Color.Red;
			this.radLabel8.Location = new global::System.Drawing.Point(0, 796);
			this.radLabel8.Name = "radLabel8";
			this.radLabel8.Size = new global::System.Drawing.Size(32, 18);
			this.radLabel8.TabIndex = 7;
			this.radLabel8.Text = "BETA";
			this.cmdRestoreSave.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdRestoreSave.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdRestoreSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdRestoreSave.Image");
			this.cmdRestoreSave.Location = new global::System.Drawing.Point(330, 53);
			this.cmdRestoreSave.Name = "cmdRestoreSave";
			this.cmdRestoreSave.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdRestoreSave.Size = new global::System.Drawing.Size(147, 53);
			this.cmdRestoreSave.TabIndex = 6;
			this.cmdRestoreSave.Text = "Restore Save";
			this.cmdRestoreSave.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdRestoreSave.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdRestoreSave.Click += new global::System.EventHandler(this.cmdRestoreSave_Click);
			this.cmdBackupSave.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdBackupSave.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdBackupSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdBackupSave.Image");
			this.cmdBackupSave.Location = new global::System.Drawing.Point(11, 53);
			this.cmdBackupSave.Name = "cmdBackupSave";
			this.cmdBackupSave.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdBackupSave.Size = new global::System.Drawing.Size(147, 53);
			this.cmdBackupSave.TabIndex = 5;
			this.cmdBackupSave.Text = "Backup Save";
			this.cmdBackupSave.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdBackupSave.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdBackupSave.Click += new global::System.EventHandler(this.cmdBackupSave_Click);
			this.toolChat.Caption = null;
			this.toolChat.Controls.Add(this.lstChat);
			this.toolChat.Controls.Add(this.txtChat);
			this.toolChat.Controls.Add(this.panelChatBottom);
			this.toolChat.DefaultFloatingSize = new global::System.Drawing.Size(800, 400);
			this.toolChat.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolChat.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolChat.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolChat.Image");
			this.toolChat.Location = new global::System.Drawing.Point(6, 29);
			this.toolChat.Name = "toolChat";
			this.toolChat.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolChat.Size = new global::System.Drawing.Size(641, 139);
			this.toolChat.Text = "Chat Room";
			this.toolChat.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.lstChat.AllowEdit = false;
			this.lstChat.AllowRemove = false;
			listViewDetailColumn9.HeaderText = "Column 0";
			listViewDetailColumn9.Width = 2000f;
			this.lstChat.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn9
			});
			this.lstChat.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstChat.ItemSpacing = 2;
			this.lstChat.Location = new global::System.Drawing.Point(0, 0);
			this.lstChat.Name = "lstChat";
			this.lstChat.ShowColumnHeaders = false;
			this.lstChat.ShowGridLines = true;
			this.lstChat.Size = new global::System.Drawing.Size(641, 101);
			this.lstChat.TabIndex = 1;
			this.lstChat.Text = "radListView1";
			this.lstChat.VisualItemFormatting += new global::Telerik.WinControls.UI.ListViewVisualItemEventHandler(this.lstChat_VisualItemFormatting);
			this.txtChat.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.txtChat.Location = new global::System.Drawing.Point(0, 101);
			this.txtChat.MaxLength = 90;
			this.txtChat.Name = "txtChat";
			this.txtChat.NullText = "Type here...";
			this.txtChat.Size = new global::System.Drawing.Size(641, 20);
			this.txtChat.TabIndex = 0;
			this.txtChat.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtChat_KeyPress);
			this.panelChatBottom.Controls.Add(this.radioLobby);
			this.panelChatBottom.Controls.Add(this.radioGameRoom);
			this.panelChatBottom.Controls.Add(this.chkNotifyChat);
			this.panelChatBottom.Controls.Add(this.lblChannelClientCount);
			this.panelChatBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelChatBottom.Location = new global::System.Drawing.Point(0, 121);
			this.panelChatBottom.Name = "panelChatBottom";
			this.panelChatBottom.Size = new global::System.Drawing.Size(641, 18);
			this.panelChatBottom.TabIndex = 3;
			this.radioLobby.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioLobby.Location = new global::System.Drawing.Point(301, 0);
			this.radioLobby.Name = "radioLobby";
			this.radioLobby.Size = new global::System.Drawing.Size(118, 18);
			this.radioLobby.TabIndex = 4;
			this.radioLobby.Text = "Join the main lobby";
			this.radioLobby.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.radioLobby_ToggleStateChanged);
			this.radioGameRoom.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioGameRoom.Location = new global::System.Drawing.Point(158, 0);
			this.radioGameRoom.Name = "radioGameRoom";
			this.radioGameRoom.Size = new global::System.Drawing.Size(143, 18);
			this.radioGameRoom.TabIndex = 3;
			this.radioGameRoom.Text = "Join game-specific room";
			this.radioGameRoom.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.radioGameRoom_ToggleStateChanged);
			this.chkNotifyChat.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.chkNotifyChat.Location = new global::System.Drawing.Point(0, 0);
			this.chkNotifyChat.Name = "chkNotifyChat";
			this.chkNotifyChat.Size = new global::System.Drawing.Size(158, 18);
			this.chkNotifyChat.TabIndex = 0;
			this.chkNotifyChat.Text = "Notify me of new messages";
			this.chkNotifyChat.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkNotifyChat_ToggleStateChanged);
			this.lblChannelClientCount.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.lblChannelClientCount.Location = new global::System.Drawing.Point(512, 0);
			this.lblChannelClientCount.Name = "lblChannelClientCount";
			this.lblChannelClientCount.Size = new global::System.Drawing.Size(129, 18);
			this.lblChannelClientCount.TabIndex = 2;
			this.lblChannelClientCount.Text = "0 client(s) in this channel";
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.AutoSize = true;
			this.radGroupBox1.Controls.Add(this.lblEmuUpdateVersion);
			this.radGroupBox1.Controls.Add(this.lblStatusDLCEmu);
			this.radGroupBox1.Controls.Add(this.lblStatusUpdateEmu);
			this.radGroupBox1.Controls.Add(this.lblStatusGameEmu);
			this.radGroupBox1.Controls.Add(this.lblStatusDLCRaw);
			this.radGroupBox1.Controls.Add(this.radLabel19);
			this.radGroupBox1.Controls.Add(this.radLabel17);
			this.radGroupBox1.Controls.Add(this.lblNbPlayers);
			this.radGroupBox1.Controls.Add(this.radLabel5);
			this.radGroupBox1.Controls.Add(this.radLabel4);
			this.radGroupBox1.Controls.Add(this.lblDLCSize);
			this.radGroupBox1.Controls.Add(this.lblTitleId);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.Controls.Add(this.lblStatusUpdateRaw);
			this.radGroupBox1.Controls.Add(this.lblStatusGameRaw);
			this.radGroupBox1.Controls.Add(this.lblUpdateSize);
			this.radGroupBox1.Controls.Add(this.label5);
			this.radGroupBox1.Controls.Add(this.lblGameSize);
			this.radGroupBox1.Controls.Add(this.label1);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox1.HeaderText = "Technical info";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 226);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(667, 79);
			this.radGroupBox1.TabIndex = 29;
			this.radGroupBox1.Text = "Technical info";
			this.lblEmuUpdateVersion.AutoSize = false;
			this.lblEmuUpdateVersion.Location = new global::System.Drawing.Point(372, 58);
			this.lblEmuUpdateVersion.Name = "lblEmuUpdateVersion";
			this.lblEmuUpdateVersion.Size = new global::System.Drawing.Size(43, 18);
			this.lblEmuUpdateVersion.TabIndex = 13;
			this.lblEmuUpdateVersion.Text = "-";
			this.lblEmuUpdateVersion.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatusDLCEmu.Location = new global::System.Drawing.Point(426, 41);
			this.lblStatusDLCEmu.Name = "lblStatusDLCEmu";
			this.lblStatusDLCEmu.Size = new global::System.Drawing.Size(26, 18);
			this.lblStatusDLCEmu.TabIndex = 11;
			this.lblStatusDLCEmu.Text = "DLC";
			this.lblStatusUpdateEmu.Location = new global::System.Drawing.Point(372, 41);
			this.lblStatusUpdateEmu.Name = "lblStatusUpdateEmu";
			this.lblStatusUpdateEmu.Size = new global::System.Drawing.Size(43, 18);
			this.lblStatusUpdateEmu.TabIndex = 12;
			this.lblStatusUpdateEmu.Text = "Update";
			this.lblStatusGameEmu.Location = new global::System.Drawing.Point(325, 41);
			this.lblStatusGameEmu.Name = "lblStatusGameEmu";
			this.lblStatusGameEmu.Size = new global::System.Drawing.Size(35, 18);
			this.lblStatusGameEmu.TabIndex = 10;
			this.lblStatusGameEmu.Text = "Game";
			this.lblStatusDLCRaw.Location = new global::System.Drawing.Point(426, 17);
			this.lblStatusDLCRaw.Name = "lblStatusDLCRaw";
			this.lblStatusDLCRaw.Size = new global::System.Drawing.Size(26, 18);
			this.lblStatusDLCRaw.TabIndex = 5;
			this.lblStatusDLCRaw.Text = "DLC";
			this.radLabel19.Location = new global::System.Drawing.Point(161, 41);
			this.radLabel19.Name = "radLabel19";
			this.radLabel19.Size = new global::System.Drawing.Size(122, 18);
			this.radLabel19.TabIndex = 9;
			this.radLabel19.Text = "Content for emulation :";
			this.radLabel17.Location = new global::System.Drawing.Point(161, 17);
			this.radLabel17.Name = "radLabel17";
			this.radLabel17.Size = new global::System.Drawing.Size(158, 18);
			this.radLabel17.TabIndex = 8;
			this.radLabel17.Text = "Content for physical systems : ";
			this.lblNbPlayers.Location = new global::System.Drawing.Point(490, 38);
			this.lblNbPlayers.Name = "lblNbPlayers";
			this.lblNbPlayers.Size = new global::System.Drawing.Size(11, 18);
			this.lblNbPlayers.TabIndex = 7;
			this.lblNbPlayers.Text = "-";
			this.radLabel5.Location = new global::System.Drawing.Point(490, 17);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new global::System.Drawing.Size(44, 18);
			this.radLabel5.TabIndex = 6;
			this.radLabel5.Text = "Players:";
			this.radLabel4.Location = new global::System.Drawing.Point(16, 59);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(51, 18);
			this.radLabel4.TabIndex = 6;
			this.radLabel4.Text = "DLC size:";
			this.lblDLCSize.Location = new global::System.Drawing.Point(93, 59);
			this.lblDLCSize.Name = "lblDLCSize";
			this.lblDLCSize.Size = new global::System.Drawing.Size(11, 18);
			this.lblDLCSize.TabIndex = 7;
			this.lblDLCSize.Text = "-";
			this.lblTitleId.Location = new global::System.Drawing.Point(540, 59);
			this.lblTitleId.Name = "lblTitleId";
			this.lblTitleId.Size = new global::System.Drawing.Size(11, 18);
			this.lblTitleId.TabIndex = 6;
			this.lblTitleId.Text = "-";
			this.radLabel2.Location = new global::System.Drawing.Point(490, 59);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(47, 18);
			this.radLabel2.TabIndex = 5;
			this.radLabel2.Text = "Title ID :";
			this.lblStatusUpdateRaw.Location = new global::System.Drawing.Point(372, 17);
			this.lblStatusUpdateRaw.Name = "lblStatusUpdateRaw";
			this.lblStatusUpdateRaw.Size = new global::System.Drawing.Size(43, 18);
			this.lblStatusUpdateRaw.TabIndex = 6;
			this.lblStatusUpdateRaw.Text = "Update";
			this.lblStatusGameRaw.Location = new global::System.Drawing.Point(325, 17);
			this.lblStatusGameRaw.Name = "lblStatusGameRaw";
			this.lblStatusGameRaw.Size = new global::System.Drawing.Size(35, 18);
			this.lblStatusGameRaw.TabIndex = 4;
			this.lblStatusGameRaw.Text = "Game";
			this.lblUpdateSize.Location = new global::System.Drawing.Point(93, 38);
			this.lblUpdateSize.Name = "lblUpdateSize";
			this.lblUpdateSize.Size = new global::System.Drawing.Size(11, 18);
			this.lblUpdateSize.TabIndex = 3;
			this.lblUpdateSize.Text = "-";
			this.label5.Location = new global::System.Drawing.Point(16, 38);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(70, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "Update size :";
			this.lblGameSize.Location = new global::System.Drawing.Point(93, 17);
			this.lblGameSize.Name = "lblGameSize";
			this.lblGameSize.Size = new global::System.Drawing.Size(11, 18);
			this.lblGameSize.TabIndex = 1;
			this.lblGameSize.Text = "-";
			this.label1.Location = new global::System.Drawing.Point(16, 17);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(63, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Game size :";
			this.toolTabStrip2.CanUpdateChildIndex = true;
			this.toolTabStrip2.Controls.Add(this.toolDownload);
			this.toolTabStrip2.Location = new global::System.Drawing.Point(1134, 0);
			this.toolTabStrip2.Name = "toolTabStrip2";
			this.toolTabStrip2.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.toolTabStrip2.SelectedIndex = 0;
			this.toolTabStrip2.Size = new global::System.Drawing.Size(0, 404);
			this.toolTabStrip2.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(0, 200);
			this.toolTabStrip2.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(-200, 0);
			this.toolTabStrip2.TabIndex = 7;
			this.toolTabStrip2.TabStop = false;
			this.toolDownload.Caption = null;
			this.toolDownload.Controls.Add(this.radPageView2);
			this.toolDownload.DefaultFloatingSize = new global::System.Drawing.Size(300, 600);
			this.toolDownload.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolDownload.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolDownload.Location = new global::System.Drawing.Point(1, 22);
			this.toolDownload.Name = "toolDownload";
			this.toolDownload.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Floating;
			this.toolDownload.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.toolDownload.Size = new global::System.Drawing.Size(0, 380);
			this.toolDownload.Text = "Download Manager";
			this.toolDownload.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radPageView2.Controls.Add(this.radPageViewPage1);
			this.radPageView2.Controls.Add(this.radPageViewPage3);
			this.radPageView2.Controls.Add(this.radPageViewPage2);
			this.radPageView2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPageView2.Location = new global::System.Drawing.Point(0, 0);
			this.radPageView2.Name = "radPageView2";
			this.radPageView2.SelectedPage = this.radPageViewPage1;
			this.radPageView2.Size = new global::System.Drawing.Size(0, 380);
			this.radPageView2.TabIndex = 32;
			this.radPageView2.Text = "Download Manager";
			((global::Telerik.WinControls.UI.RadPageViewStripElement)this.radPageView2.GetChildAt(0)).StripButtons = global::Telerik.WinControls.UI.StripViewButtons.None;
			this.radPageViewPage1.Controls.Add(this.radLiveSpeed);
			this.radPageViewPage1.Controls.Add(this.cmdAbortAll);
			this.radPageViewPage1.Controls.Add(this.grpProgressAll);
			this.radPageViewPage1.Controls.Add(this.grpProgressCurrent);
			this.radPageViewPage1.Controls.Add(this.radGroupBox2);
			this.radPageViewPage1.Controls.Add(this.radGroupBox7);
			this.radPageViewPage1.Location = new global::System.Drawing.Point(10, 9);
			this.radPageViewPage1.Name = "radPageViewPage1";
			this.radPageViewPage1.Size = new global::System.Drawing.Size(0, 360);
			this.radPageViewPage1.Text = "ETA";
			this.radLiveSpeed.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radLiveSpeed.Controls.Add(this.lblFileCheckStatus);
			this.radLiveSpeed.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLiveSpeed.HeaderText = "Live Speed";
			this.radLiveSpeed.Location = new global::System.Drawing.Point(0, 237);
			this.radLiveSpeed.Name = "radLiveSpeed";
			this.radLiveSpeed.Size = new global::System.Drawing.Size(0, 26);
			this.radLiveSpeed.TabIndex = 34;
			this.radLiveSpeed.Text = "Live Speed";
			this.lblFileCheckStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblFileCheckStatus.AutoSize = false;
			this.lblFileCheckStatus.Location = new global::System.Drawing.Point(0, 0);
			this.lblFileCheckStatus.Name = "lblFileCheckStatus";
			this.lblFileCheckStatus.Size = new global::System.Drawing.Size(0, 26);
			this.lblFileCheckStatus.TabIndex = 0;
			this.lblFileCheckStatus.Text = "The application is checking the integrity of your files, please wait...";
			this.lblFileCheckStatus.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFileCheckStatus.Visible = false;
			this.radPageViewPage3.Controls.Add(this.radGroupBox26);
			this.radPageViewPage3.Controls.Add(this.radGroupBox18);
			this.radPageViewPage3.Controls.Add(this.lblSpeed);
			this.radPageViewPage3.Controls.Add(this.gaugeSpeed);
			this.radPageViewPage3.Location = new global::System.Drawing.Point(10, 37);
			this.radPageViewPage3.Name = "radPageViewPage3";
			this.radPageViewPage3.Size = new global::System.Drawing.Size(479, 555);
			this.radPageViewPage3.Text = "Speed";
			this.radGroupBox26.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox26.Controls.Add(this.chkSuperSpeed);
			this.radGroupBox26.Controls.Add(this.radLabel20);
			this.radGroupBox26.Controls.Add(this.radLabel21);
			this.radGroupBox26.Controls.Add(this.radLabel3);
			this.radGroupBox26.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox26.HeaderText = "SuperSpeed";
			this.radGroupBox26.Location = new global::System.Drawing.Point(0, 450);
			this.radGroupBox26.Name = "radGroupBox26";
			this.radGroupBox26.Size = new global::System.Drawing.Size(479, 105);
			this.radGroupBox26.TabIndex = 26;
			this.radGroupBox26.Text = "SuperSpeed";
			this.chkSuperSpeed.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.chkSuperSpeed.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.chkSuperSpeed.Location = new global::System.Drawing.Point(2, 72);
			this.chkSuperSpeed.Name = "chkSuperSpeed";
			this.chkSuperSpeed.Size = new global::System.Drawing.Size(475, 18);
			this.chkSuperSpeed.TabIndex = 2;
			this.chkSuperSpeed.Text = "Enable SuperSpeed";
			this.chkSuperSpeed.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkSuperSpeed_ToggleStateChanged);
			this.radLabel20.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel20.Location = new global::System.Drawing.Point(2, 54);
			this.radLabel20.Name = "radLabel20";
			this.radLabel20.Size = new global::System.Drawing.Size(475, 18);
			this.radLabel20.TabIndex = 1;
			this.radLabel20.Text = "It is only recommended if you have a 100+Mb/s connection.";
			this.radLabel21.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel21.Location = new global::System.Drawing.Point(2, 36);
			this.radLabel21.Name = "radLabel21";
			this.radLabel21.Size = new global::System.Drawing.Size(475, 18);
			this.radLabel21.TabIndex = 2;
			this.radLabel21.Text = "This feature is experimental.";
			this.radLabel3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel3.Location = new global::System.Drawing.Point(2, 18);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(475, 18);
			this.radLabel3.TabIndex = 0;
			this.radLabel3.Text = "SuperSpeed boosts your download speed by parallelizing the download.\r\n";
			this.radGroupBox18.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox18.Controls.Add(this.radLabel9);
			this.radGroupBox18.Controls.Add(this.radMaxSpeed);
			this.radGroupBox18.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox18.HeaderText = "Limit download speed";
			this.radGroupBox18.Location = new global::System.Drawing.Point(0, 268);
			this.radGroupBox18.Name = "radGroupBox18";
			this.radGroupBox18.Size = new global::System.Drawing.Size(479, 100);
			this.radGroupBox18.TabIndex = 25;
			this.radGroupBox18.Text = "Limit download speed";
			this.lblSpeed.AutoSize = false;
			this.lblSpeed.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblSpeed.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblSpeed.Location = new global::System.Drawing.Point(0, 210);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new global::System.Drawing.Size(479, 58);
			this.lblSpeed.TabIndex = 25;
			this.lblSpeed.Text = "0.00KB/s";
			this.lblSpeed.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.gaugeSpeed.BackColor = global::System.Drawing.Color.White;
			this.gaugeSpeed.CausesValidation = false;
			this.gaugeSpeed.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.gaugeSpeed.Items.AddRange(new global::Telerik.WinControls.RadItem[]
			{
				this.radialGaugeArc1,
				this.radialGaugeArc2,
				this.radialGaugeLabels1,
				this.radialGaugeTicks1,
				this.radialGaugeSingleLabel1
			});
			this.gaugeSpeed.Location = new global::System.Drawing.Point(0, 0);
			this.gaugeSpeed.Name = "gaugeSpeed";
			this.gaugeSpeed.RangeEnd = 180.0;
			this.gaugeSpeed.Size = new global::System.Drawing.Size(479, 210);
			this.gaugeSpeed.TabIndex = 6;
			this.gaugeSpeed.Text = "radRadialGauge1";
			this.gaugeSpeed.Value = 0f;
			this.radialGaugeArc1.BackColor = global::System.Drawing.Color.FromArgb(71, 102, 155);
			this.radialGaugeArc1.BackColor2 = global::System.Drawing.Color.FromArgb(77, 110, 162);
			this.radialGaugeArc1.BindEndRange = true;
			this.radialGaugeArc1.Name = "radialGaugeArc1";
			this.radialGaugeArc1.Radius = 80.0;
			this.radialGaugeArc1.RangeEnd = 0.0;
			this.radialGaugeArc1.Width = 15.0;
			this.radialGaugeArc2.BackColor = global::System.Drawing.Color.FromArgb(181, 181, 181);
			this.radialGaugeArc2.BackColor2 = global::System.Drawing.Color.FromArgb(194, 194, 194);
			this.radialGaugeArc2.BindStartRange = true;
			this.radialGaugeArc2.Name = "radialGaugeArc2";
			this.radialGaugeArc2.Radius = 80.0;
			this.radialGaugeArc2.RangeEnd = 180.0;
			this.radialGaugeArc2.Width = 15.0;
			this.radialGaugeLabels1.DrawText = false;
			this.radialGaugeLabels1.LabelFontSize = 5f;
			this.radialGaugeLabels1.LabelRadiusPercentage = 108f;
			this.radialGaugeLabels1.LabelsCount = 9;
			this.radialGaugeLabels1.Name = "radialGaugeLabels1";
			this.radialGaugeTicks1.CircleTicks = true;
			this.radialGaugeTicks1.DrawText = false;
			this.radialGaugeTicks1.Name = "radialGaugeTicks1";
			this.radialGaugeTicks1.TickColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.radialGaugeTicks1.TicksCount = 18;
			this.radialGaugeTicks1.TicksLenghtPercentage = 1f;
			this.radialGaugeTicks1.TicksOffset = 4;
			this.radialGaugeTicks1.TicksRadiusPercentage = 95f;
			this.radialGaugeTicks1.TickThickness = 1f;
			this.radialGaugeSingleLabel1.BindValue = true;
			this.radialGaugeSingleLabel1.ForeColor = global::System.Drawing.Color.FromArgb(76, 109, 161);
			this.radialGaugeSingleLabel1.LabelText = "Text";
			this.radialGaugeSingleLabel1.LocationPercentage = new global::System.Drawing.SizeF(0f, 0f);
			this.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1";
			this.radPageViewPage2.Controls.Add(this.grpLog);
			this.radPageViewPage2.Location = new global::System.Drawing.Point(10, 37);
			this.radPageViewPage2.Name = "radPageViewPage2";
			this.radPageViewPage2.Size = new global::System.Drawing.Size(479, 555);
			this.radPageViewPage2.Text = "Log";
			this.grpLog.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.grpLog.Controls.Add(this.lstLog);
			this.grpLog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grpLog.HeaderText = "Technical stuff";
			this.grpLog.Location = new global::System.Drawing.Point(0, 0);
			this.grpLog.Name = "grpLog";
			this.grpLog.Size = new global::System.Drawing.Size(479, 555);
			this.grpLog.TabIndex = 35;
			this.grpLog.Text = "Technical stuff";
			this.lstLog.AllowArbitraryItemHeight = true;
			this.lstLog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstLog.Location = new global::System.Drawing.Point(2, 18);
			this.lstLog.Name = "lstLog";
			this.lstLog.Size = new global::System.Drawing.Size(475, 535);
			this.lstLog.TabIndex = 25;
			this.lstLog.Text = "radListView1";
			this.toolTabStrip4.CanUpdateChildIndex = true;
			this.toolTabStrip4.Controls.Add(this.toolCopy);
			this.toolTabStrip4.Location = new global::System.Drawing.Point(1136, 0);
			this.toolTabStrip4.Name = "toolTabStrip4";
			this.toolTabStrip4.RootElement.MinSize = new global::System.Drawing.Size(0, 0);
			this.toolTabStrip4.SelectedIndex = 0;
			this.toolTabStrip4.Size = new global::System.Drawing.Size(0, 404);
			this.toolTabStrip4.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(0, 200);
			this.toolTabStrip4.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(-200, 0);
			this.toolTabStrip4.TabIndex = 8;
			this.toolTabStrip4.TabStop = false;
			this.toolTabStrip6.CanUpdateChildIndex = true;
			this.toolTabStrip6.CausesValidation = false;
			this.toolTabStrip6.Controls.Add(this.toolWindow2);
			this.toolTabStrip6.Controls.Add(this.toolWindow3);
			this.toolTabStrip6.Controls.Add(this.toolWindow4);
			this.toolTabStrip6.Location = new global::System.Drawing.Point(5, 518);
			this.toolTabStrip6.Name = "toolTabStrip6";
			this.toolTabStrip6.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.toolTabStrip6.SelectedIndex = 0;
			this.toolTabStrip6.Size = new global::System.Drawing.Size(1136, 110);
			this.toolTabStrip6.SizeInfo.AbsoluteSize = new global::System.Drawing.Size(200, 110);
			this.toolTabStrip6.SizeInfo.SplitterCorrection = new global::System.Drawing.Size(0, -90);
			this.toolTabStrip6.TabIndex = 1;
			this.toolTabStrip6.TabStop = false;
			this.toolWindow2.Caption = null;
			this.toolWindow2.Controls.Add(this.radPanel1);
			this.toolWindow2.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolWindow2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolWindow2.Location = new global::System.Drawing.Point(1, 22);
			this.toolWindow2.Name = "toolWindow2";
			this.toolWindow2.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow2.Size = new global::System.Drawing.Size(1134, 62);
			this.toolWindow2.Text = "Commands";
			this.toolWindow2.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radPanel1.AutoSize = true;
			this.radPanel1.Controls.Add(this.cmdChangeRegion);
			this.radPanel1.Controls.Add(this.cmdChangeTicket);
			this.radPanel1.Controls.Add(this.cmdChangeFolder);
			this.radPanel1.Controls.Add(this.cmdSetExtractFolder);
			this.radPanel1.Controls.Add(this.DownloadButton);
			this.radPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new global::System.Drawing.Size(1134, 62);
			this.radPanel1.TabIndex = 33;
			this.cmdChangeRegion.AccessibleName = "Change region";
			this.cmdChangeRegion.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdChangeRegion.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdChangeRegion.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdChangeRegion.Image");
			this.cmdChangeRegion.Location = new global::System.Drawing.Point(898, 4);
			this.cmdChangeRegion.Name = "cmdChangeRegion";
			this.cmdChangeRegion.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdChangeRegion.Size = new global::System.Drawing.Size(190, 55);
			this.cmdChangeRegion.TabIndex = 4;
			this.cmdChangeRegion.Text = "Change region";
			this.cmdChangeRegion.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdChangeRegion.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdChangeRegion.Click += new global::System.EventHandler(this.cmdChangeRegion_Click);
			this.cmdChangeTicket.AccessibleName = "Change tickets location";
			this.cmdChangeTicket.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdChangeTicket.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdChangeTicket.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdChangeTicket.Image");
			this.cmdChangeTicket.Location = new global::System.Drawing.Point(691, 4);
			this.cmdChangeTicket.Name = "cmdChangeTicket";
			this.cmdChangeTicket.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdChangeTicket.Size = new global::System.Drawing.Size(190, 55);
			this.cmdChangeTicket.TabIndex = 7;
			this.cmdChangeTicket.Text = "Change tickets location";
			this.cmdChangeTicket.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdChangeTicket.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdChangeTicket.Click += new global::System.EventHandler(this.cmdChangeTicket_Click);
			this.cmdChangeFolder.AccessibleName = "Set download directory";
			this.cmdChangeFolder.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdChangeFolder.Controls.Add(this.label7);
			this.cmdChangeFolder.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdChangeFolder.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdChangeFolder.Image");
			this.cmdChangeFolder.Location = new global::System.Drawing.Point(484, 4);
			this.cmdChangeFolder.Name = "cmdChangeFolder";
			this.cmdChangeFolder.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdChangeFolder.Size = new global::System.Drawing.Size(190, 55);
			this.cmdChangeFolder.TabIndex = 6;
			this.cmdChangeFolder.Text = "Set download directory";
			this.cmdChangeFolder.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdChangeFolder.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdChangeFolder.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.cmdChangeFolder_MouseClick);
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI", 6f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(102, 36);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(75, 11);
			this.label7.TabIndex = 2;
			this.label7.Text = "(Right Click to Open)";
			this.cmdSetExtractFolder.AccessibleName = "Set extraction directory";
			this.cmdSetExtractFolder.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdSetExtractFolder.Controls.Add(this.label6);
			this.cmdSetExtractFolder.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdSetExtractFolder.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdSetExtractFolder.Image");
			this.cmdSetExtractFolder.Location = new global::System.Drawing.Point(277, 4);
			this.cmdSetExtractFolder.Name = "cmdSetExtractFolder";
			this.cmdSetExtractFolder.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdSetExtractFolder.Size = new global::System.Drawing.Size(190, 55);
			this.cmdSetExtractFolder.TabIndex = 5;
			this.cmdSetExtractFolder.Text = "Set extraction directory";
			this.cmdSetExtractFolder.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdSetExtractFolder.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSetExtractFolder.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.cmdSetExtractFolder_MouseClick);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI", 6f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(103, 36);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(75, 11);
			this.label6.TabIndex = 1;
			this.label6.Text = "(Right Click to Open)";
			this.DownloadButton.AccessibleName = "Start downloading";
			this.DownloadButton.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.DownloadButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.DownloadButton.Enabled = false;
			this.DownloadButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DownloadButton.Image");
			this.DownloadButton.Location = new global::System.Drawing.Point(70, 4);
			this.DownloadButton.Name = "DownloadButton";
			this.DownloadButton.Padding = new global::System.Windows.Forms.Padding(8);
			this.DownloadButton.Size = new global::System.Drawing.Size(190, 55);
			this.DownloadButton.TabIndex = 3;
			this.DownloadButton.Text = "&Start downloading";
			this.DownloadButton.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DownloadButton.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DownloadButton.Click += new global::System.EventHandler(this.DownloadButton_Click);
			this.toolWindow3.Caption = null;
			this.toolWindow3.Controls.Add(this.radPanel2);
			this.toolWindow3.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolWindow3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolWindow3.Location = new global::System.Drawing.Point(1, 22);
			this.toolWindow3.Name = "toolWindow3";
			this.toolWindow3.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow3.Size = new global::System.Drawing.Size(1134, 62);
			this.toolWindow3.Text = "Batch commands";
			this.toolWindow3.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radPanel2.AutoSize = true;
			this.radPanel2.Controls.Add(this.cmdCopyAll);
			this.radPanel2.Controls.Add(this.cmdImportGames);
			this.radPanel2.Controls.Add(this.cmdRefresh);
			this.radPanel2.Controls.Add(this.cmdAddAllGames);
			this.radPanel2.Controls.Add(this.cmdAddAllUpdates);
			this.radPanel2.Controls.Add(this.cmdAddAllDLCS);
			this.radPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPanel2.Location = new global::System.Drawing.Point(0, 0);
			this.radPanel2.Name = "radPanel2";
			this.radPanel2.Size = new global::System.Drawing.Size(1134, 62);
			this.radPanel2.TabIndex = 34;
			this.cmdCopyAll.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdCopyAll.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdCopyAll.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdCopyAll.Image");
			this.cmdCopyAll.Location = new global::System.Drawing.Point(753, 4);
			this.cmdCopyAll.Name = "cmdCopyAll";
			this.cmdCopyAll.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdCopyAll.Size = new global::System.Drawing.Size(114, 55);
			this.cmdCopyAll.TabIndex = 7;
			this.cmdCopyAll.Text = "Copy all";
			this.cmdCopyAll.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCopyAll.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCopyAll.Click += new global::System.EventHandler(this.cmdCopyAll_Click);
			this.cmdImportGames.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdImportGames.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdImportGames.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdImportGames.Image");
			this.cmdImportGames.Location = new global::System.Drawing.Point(883, 4);
			this.cmdImportGames.Name = "cmdImportGames";
			this.cmdImportGames.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdImportGames.Size = new global::System.Drawing.Size(151, 55);
			this.cmdImportGames.TabIndex = 7;
			this.cmdImportGames.Text = "Import titles";
			this.cmdImportGames.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdImportGames.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdImportGames.Click += new global::System.EventHandler(this.cmdImportGames_Click);
			this.cmdRefresh.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdRefresh.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdRefresh.Enabled = false;
			this.cmdRefresh.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdRefresh.Image");
			this.cmdRefresh.Location = new global::System.Drawing.Point(623, 4);
			this.cmdRefresh.Name = "cmdRefresh";
			this.cmdRefresh.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdRefresh.Size = new global::System.Drawing.Size(114, 55);
			this.cmdRefresh.TabIndex = 6;
			this.cmdRefresh.Text = "Refresh";
			this.cmdRefresh.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdRefresh.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdRefresh.Click += new global::System.EventHandler(this.cmdRefresh_Click);
			this.cmdAddAllGames.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddAllGames.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddAllGames.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddAllGames.Image");
			this.cmdAddAllGames.Location = new global::System.Drawing.Point(121, 4);
			this.cmdAddAllGames.Name = "cmdAddAllGames";
			this.cmdAddAllGames.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddAllGames.Size = new global::System.Drawing.Size(151, 55);
			this.cmdAddAllGames.TabIndex = 3;
			this.cmdAddAllGames.Text = "Add all games";
			this.cmdAddAllGames.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddAllGames.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddAllGames.Click += new global::System.EventHandler(this.cmdAddAllGames_Click);
			this.cmdAddAllUpdates.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddAllUpdates.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddAllUpdates.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddAllUpdates.Image");
			this.cmdAddAllUpdates.Location = new global::System.Drawing.Point(288, 4);
			this.cmdAddAllUpdates.Name = "cmdAddAllUpdates";
			this.cmdAddAllUpdates.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddAllUpdates.Size = new global::System.Drawing.Size(156, 55);
			this.cmdAddAllUpdates.TabIndex = 5;
			this.cmdAddAllUpdates.Text = "Add all updates";
			this.cmdAddAllUpdates.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddAllUpdates.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddAllUpdates.Click += new global::System.EventHandler(this.cmdAddAllUpdates_Click);
			this.cmdAddAllDLCS.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdAddAllDLCS.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdAddAllDLCS.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdAddAllDLCS.Image");
			this.cmdAddAllDLCS.Location = new global::System.Drawing.Point(460, 4);
			this.cmdAddAllDLCS.Name = "cmdAddAllDLCS";
			this.cmdAddAllDLCS.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdAddAllDLCS.Size = new global::System.Drawing.Size(147, 55);
			this.cmdAddAllDLCS.TabIndex = 7;
			this.cmdAddAllDLCS.Text = "    Add all DLCs";
			this.cmdAddAllDLCS.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAddAllDLCS.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAddAllDLCS.Click += new global::System.EventHandler(this.cmdAddAllDLCS_Click);
			this.toolWindow4.Caption = null;
			this.toolWindow4.Controls.Add(this.radPanel3);
			this.toolWindow4.DocumentButtons = global::Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
			this.toolWindow4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.toolWindow4.Location = new global::System.Drawing.Point(1, 22);
			this.toolWindow4.Name = "toolWindow4";
			this.toolWindow4.PreviousDockState = global::Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow4.Size = new global::System.Drawing.Size(1134, 62);
			this.toolWindow4.Text = "Other";
			this.toolWindow4.ToolCaptionButtons = global::Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
			this.radPanel3.AutoSize = true;
			this.radPanel3.Controls.Add(this.cmdLegal);
			this.radPanel3.Controls.Add(this.cmdHallOfFame);
			this.radPanel3.Controls.Add(this.cmdChangeTheme);
			this.radPanel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radPanel3.Location = new global::System.Drawing.Point(0, 0);
			this.radPanel3.Name = "radPanel3";
			this.radPanel3.Size = new global::System.Drawing.Size(1134, 62);
			this.radPanel3.TabIndex = 35;
			this.cmdLegal.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdLegal.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdLegal.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdLegal.Image");
			this.cmdLegal.Location = new global::System.Drawing.Point(661, 4);
			this.cmdLegal.Name = "cmdLegal";
			this.cmdLegal.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdLegal.Size = new global::System.Drawing.Size(175, 55);
			this.cmdLegal.TabIndex = 6;
			this.cmdLegal.Text = "Legal info";
			this.cmdLegal.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdLegal.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdLegal.Click += new global::System.EventHandler(this.cmdLegal_Click);
			this.cmdHallOfFame.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdHallOfFame.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdHallOfFame.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdHallOfFame.Image");
			this.cmdHallOfFame.Location = new global::System.Drawing.Point(480, 4);
			this.cmdHallOfFame.Name = "cmdHallOfFame";
			this.cmdHallOfFame.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdHallOfFame.Size = new global::System.Drawing.Size(175, 55);
			this.cmdHallOfFame.TabIndex = 6;
			this.cmdHallOfFame.Text = "    See Hall of Fame";
			this.cmdHallOfFame.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdHallOfFame.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdHallOfFame.Click += new global::System.EventHandler(this.cmdHallOfFame_Click);
			this.cmdChangeTheme.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdChangeTheme.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.cmdChangeTheme.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cmdChangeTheme.Image");
			this.cmdChangeTheme.Location = new global::System.Drawing.Point(299, 4);
			this.cmdChangeTheme.Name = "cmdChangeTheme";
			this.cmdChangeTheme.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdChangeTheme.Size = new global::System.Drawing.Size(175, 55);
			this.cmdChangeTheme.TabIndex = 3;
			this.cmdChangeTheme.Text = "Change Theme";
			this.cmdChangeTheme.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdChangeTheme.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdChangeTheme.Click += new global::System.EventHandler(this.cmdChangeTheme_Click);
			this.radContextMenu_0.Items.AddRange(new global::Telerik.WinControls.RadItem[]
			{
				this.menuDlGame,
				this.menuDlUpdate,
				this.menuDlDLC,
				this.menuCopy,
				this.menuDelete,
				this.menuMarkInstall,
				this.radMarkNotInstalled,
				this.radUnpack,
				this.menuPlay,
				this.radPrepareEmu,
				this.radDelEmuData,
				this.radMenuItem1
			});
			this.menuDlGame.Name = "menuDlGame";
			this.menuDlGame.Text = "Download game(s)";
			this.menuDlUpdate.Name = "menuDlUpdate";
			this.menuDlUpdate.Text = "Download update";
			this.menuDlDLC.Name = "menuDlDLC";
			this.menuDlDLC.Text = "Download DLC";
			this.menuCopy.Name = "menuCopy";
			this.menuCopy.Text = "Copy to SD";
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "Delete";
			this.menuMarkInstall.Name = "menuMarkInstall";
			this.menuMarkInstall.Text = "Mark as Installed";
			this.radMarkNotInstalled.Name = "radMarkNotInstalled";
			this.radMarkNotInstalled.Text = "Mark as not installed";
			this.radUnpack.Name = "radUnpack";
			this.radUnpack.Text = "Pack/Unpack (Loadiine or CIA)";
			this.menuPlay.Name = "menuPlay";
			this.menuPlay.Text = "Play";
			this.radPrepareEmu.Name = "radPrepareEmu";
			this.radPrepareEmu.Text = "Prepare for Emulation";
			this.radDelEmuData.Name = "radDelEmuData";
			this.radDelEmuData.Text = "Manage Emulation Data";
			this.radMenuItem1.Name = "radMenuItem1";
			this.radMenuItem1.Text = "Download specific files (Experts only!)";
			this.timer_2.Interval = 350;
			this.timer_2.Tick += new global::System.EventHandler(this.timer_2_Tick);
			this.timer_3.Enabled = true;
			this.timer_3.Interval = 300000;
			this.timer_3.Tick += new global::System.EventHandler(this.timer_3_Tick);
			this.timer_4.Interval = 1000;
			this.timer_4.Tick += new global::System.EventHandler(this.timer_4_Tick);
			this.lblStatus.AutoSize = false;
			this.lblStatus.Controls.Add(this.lblSynchronized);
			this.lblStatus.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.FromArgb(192, 192, 0);
			this.lblStatus.Location = new global::System.Drawing.Point(0, 633);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(1146, 19);
			this.lblStatus.TabIndex = 33;
			this.lblStatus.Text = "Powered by Willzor's wiiuusbhelper.com (No WiiU found, please launch Wii U USB Helper Transfer Tool)";
			this.lblStatus.UseMnemonic = false;
			this.lblSynchronized.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.lblSynchronized.Location = new global::System.Drawing.Point(1135, 0);
			this.lblSynchronized.Name = "lblSynchronized";
			this.lblSynchronized.Size = new global::System.Drawing.Size(11, 19);
			this.lblSynchronized.TabIndex = 34;
			this.lblSynchronized.Text = "-";
			this.lblSynchronized.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.timer_5.Enabled = true;
			this.timer_5.Interval = 60000;
			this.timer_5.Tick += new global::System.EventHandler(this.timer_5_Tick);
			this.timer_6.Interval = 500;
			this.timer_6.Tick += new global::System.EventHandler(this.timer_6_Tick);
			this.timer_7.Enabled = true;
			this.timer_7.Interval = 60000;
			this.timer_7.Tick += new global::System.EventHandler(this.timer_7_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(1146, 652);
			base.Controls.Add(this.dockMain);
			base.Controls.Add(this.lblStatus);
			this.ForeColor = global::System.Drawing.Color.FromArgb(74, 72, 58);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			this.MinimumSize = new global::System.Drawing.Size(1154, 682);
			base.Name = "NusGrabberForm";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wii U USB Helper";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.NusGrabberForm_FormClosing);
			base.Load += new global::System.EventHandler(this.NusGrabberForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.FTSearchBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstGames).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dlQueue).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalToDl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalDl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNbGms).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox7).EndInit();
			this.radGroupBox7.ResumeLayout(false);
			this.radGroupBox7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkPrepareEmulation).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkPack).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAbortDelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTimeLeft).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkUnpack).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyToSD).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkSleep).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkShutdown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDelay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkHibernate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpProgressAll).EndInit();
			this.grpProgressAll.ResumeLayout(false);
			this.grpProgressAll.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalEta).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.totalProgress).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel9).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radMaxSpeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAbortAll).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).EndInit();
			this.radGroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCopy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddDlc).EndInit();
			this.cmdAddDlc.ResumeLayout(false);
			this.cmdAddDlc.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTitle).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).EndInit();
			this.radGroupBox2.ResumeLayout(false);
			this.radGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblFileEta).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pgFile).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpProgressCurrent).EndInit();
			this.grpProgressCurrent.ResumeLayout(false);
			this.grpProgressCurrent.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEta).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.NUSGrabberProgress).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dockMain).EndInit();
			this.dockMain.ResumeLayout(false);
			this.toolCopy.ResumeLayout(false);
			this.toolCopy.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstCopy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSendWiiu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdManageRemoteSd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdInitiateCopy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox10).EndInit();
			this.radGroupBox10.ResumeLayout(false);
			this.radGroupBox10.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalCopy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip3).EndInit();
			this.toolTabStrip3.ResumeLayout(false);
			this.toolWindow5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pbBanner).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer3).EndInit();
			this.radSplitContainer3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.documentContainer1).EndInit();
			this.documentContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.documentTabStrip1).EndInit();
			this.documentTabStrip1.ResumeLayout(false);
			this.toolLibrary.ResumeLayout(false);
			this.toolLibrary.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).EndInit();
			this.radGroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).EndInit();
			this.radSplitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).EndInit();
			this.splitPanel1.ResumeLayout(false);
			this.splitPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkCompactView).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelLibraryCheckbox).EndInit();
			this.panelLibraryCheckbox.ResumeLayout(false);
			this.panelLibraryCheckbox.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).EndInit();
			this.splitPanel2.ResumeLayout(false);
			this.splitPanel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox9).EndInit();
			this.radGroupBox9.ResumeLayout(false);
			this.radGroupBox9.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearDl).EndInit();
			this.toolFilters.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox12).EndInit();
			this.radGroupBox12.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.treePlatforms).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox13).EndInit();
			this.radGroupBox13.ResumeLayout(false);
			this.radGroupBox13.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkKOR).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkJAP).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkUSA).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkEUR).EndInit();
			this.toolAdvancedSearch.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox25).EndInit();
			this.radGroupBox25.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.chkGameGenres).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSearchWithCriterias).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearCriterias).EndInit();
			this.toolAdvancedSettings.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox28).EndInit();
			this.radGroupBox28.ResumeLayout(false);
			this.radGroupBox28.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblStorageLocation).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox22).EndInit();
			this.radGroupBox22.ResumeLayout(false);
			this.radGroupBox22.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkDisableSpeedGraph).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkPreventShortcut).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox14).EndInit();
			this.radGroupBox14.ResumeLayout(false);
			this.radGroupBox14.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblproxyStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel12).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearProxy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSetProxy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyUsr).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyPassword).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel11).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtProxyUrl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel10).EndInit();
			this.toolEmuSettings.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).EndInit();
			this.radGroupBox5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radButton7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox21).EndInit();
			this.radGroupBox21.ResumeLayout(false);
			this.radGroupBox21.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel22).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkForceGameMode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel23).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel13).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox17).EndInit();
			this.radGroupBox17.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radButton4).EndInit();
			this.toolContribute.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox15).EndInit();
			this.radGroupBox15.ResumeLayout(false);
			this.radGroupBox15.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox16).EndInit();
			this.radGroupBox16.ResumeLayout(false);
			this.radGroupBox16.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDonate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorDate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel18).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDonatorEmail).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel16).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel15).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel14).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox20).EndInit();
			this.radGroupBox20.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdSugegstIdea).EndInit();
			this.toolHelp.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox24).EndInit();
			this.radGroupBox24.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdPrepareSd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip1).EndInit();
			this.toolTabStrip1.ResumeLayout(false);
			this.toolGameInfo.ResumeLayout(false);
			this.toolGameInfo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox6).EndInit();
			this.radGroupBox6.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dockInfo).EndInit();
			this.dockInfo.ResumeLayout(false);
			this.toolGameDesc.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.txtDesc).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelGameCover).EndInit();
			this.panelGameCover.ResumeLayout(false);
			this.panelGameCover.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdShortcut).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdPlay).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLogo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbCover).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.documentContainer2).EndInit();
			this.documentContainer2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.documentTabStrip2).EndInit();
			this.documentTabStrip2.ResumeLayout(false);
			this.toolMods.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lblModsOnlyCemu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox29).EndInit();
			this.radGroupBox29.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lstMods).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtModSearch).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdModContribute).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox27).EndInit();
			this.radGroupBox27.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.modPreview).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtModDescription).EndInit();
			this.toolExtraInfo.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox11).EndInit();
			this.radGroupBox11.ResumeLayout(false);
			this.radGroupBox11.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lstLanguages).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbRating).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstGenre).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pgScore).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstControllers).EndInit();
			this.toolScreenShot.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview2).EndInit();
			this.toolWeb.ResumeLayout(false);
			this.toolWeb.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox8).EndInit();
			this.radGroupBox8.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdGoNext).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdGoBack).EndInit();
			this.toolMovies.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lstMovies).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).EndInit();
			this.tollSaveManager.ResumeLayout(false);
			this.tollSaveManager.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCommunitySaves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImportCemu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel8).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdRestoreSave).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdBackupSave).EndInit();
			this.toolChat.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lstChat).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtChat).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelChatBottom).EndInit();
			this.panelChatBottom.ResumeLayout(false);
			this.panelChatBottom.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radioLobby).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radioGameRoom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkNotifyChat).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblChannelClientCount).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuUpdateVersion).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusDLCEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusUpdateEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusGameEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusDLCRaw).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel19).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel17).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNbPlayers).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDLCSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTitleId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusUpdateRaw).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatusGameRaw).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblGameSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip2).EndInit();
			this.toolTabStrip2.ResumeLayout(false);
			this.toolDownload.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radPageView2).EndInit();
			this.radPageView2.ResumeLayout(false);
			this.radPageViewPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLiveSpeed).EndInit();
			this.radLiveSpeed.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lblFileCheckStatus).EndInit();
			this.radPageViewPage3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox26).EndInit();
			this.radGroupBox26.ResumeLayout(false);
			this.radGroupBox26.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chkSuperSpeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel20).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel21).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox18).EndInit();
			this.radGroupBox18.ResumeLayout(false);
			this.radGroupBox18.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblSpeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.gaugeSpeed).EndInit();
			this.radPageViewPage2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.grpLog).EndInit();
			this.grpLog.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lstLog).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip4).EndInit();
			this.toolTabStrip4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.toolTabStrip6).EndInit();
			this.toolTabStrip6.ResumeLayout(false);
			this.toolWindow2.ResumeLayout(false);
			this.toolWindow2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel1).EndInit();
			this.radPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeRegion).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeTicket).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeFolder).EndInit();
			this.cmdChangeFolder.ResumeLayout(false);
			this.cmdChangeFolder.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSetExtractFolder).EndInit();
			this.cmdSetExtractFolder.ResumeLayout(false);
			this.cmdSetExtractFolder.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DownloadButton).EndInit();
			this.toolWindow3.ResumeLayout(false);
			this.toolWindow3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel2).EndInit();
			this.radPanel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdCopyAll).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImportGames).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdRefresh).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllGames).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllUpdates).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdAddAllDLCS).EndInit();
			this.toolWindow4.ResumeLayout(false);
			this.toolWindow4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radPanel3).EndInit();
			this.radPanel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdLegal).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdHallOfFame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdChangeTheme).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblStatus).EndInit();
			this.lblStatus.ResumeLayout(false);
			this.lblStatus.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblSynchronized).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400088C RID: 2188
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400088D RID: 2189
		private global::Telerik.WinControls.UI.RadButton DownloadButton;

		// Token: 0x0400088E RID: 2190
		private global::Telerik.WinControls.UI.RadTextBox FTSearchBox;

		// Token: 0x0400088F RID: 2191
		private global::Telerik.WinControls.UI.RadListView lstGames;

		// Token: 0x04000890 RID: 2192
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x04000891 RID: 2193
		private global::Telerik.WinControls.UI.RadButton cmdChangeRegion;

		// Token: 0x04000892 RID: 2194
		private global::Telerik.WinControls.UI.RadButton cmdSetExtractFolder;

		// Token: 0x04000893 RID: 2195
		private global::Telerik.WinControls.UI.RadButton cmdChangeFolder;

		// Token: 0x04000894 RID: 2196
		private global::Telerik.WinControls.UI.RadLabel label2;

		// Token: 0x04000895 RID: 2197
		private global::Telerik.WinControls.UI.RadListView dlQueue;

		// Token: 0x04000896 RID: 2198
		private global::Telerik.WinControls.UI.RadLabel lblTotalToDl;

		// Token: 0x04000897 RID: 2199
		private global::Telerik.WinControls.UI.RadLabel lblTotalDl;

		// Token: 0x04000898 RID: 2200
		private global::System.Windows.Forms.PictureBox pbBanner;

		// Token: 0x04000899 RID: 2201
		private global::Telerik.WinControls.UI.RadButton cmdChangeTicket;

		// Token: 0x0400089A RID: 2202
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox7;

		// Token: 0x0400089B RID: 2203
		private global::Telerik.WinControls.UI.RadCheckBox chkShutdown;

		// Token: 0x0400089C RID: 2204
		private global::Telerik.WinControls.UI.RadCheckBox chkHibernate;

		// Token: 0x0400089D RID: 2205
		private global::Telerik.WinControls.UI.RadGroupBox grpProgressAll;

		// Token: 0x0400089E RID: 2206
		private global::Telerik.WinControls.UI.RadLabel lblTotalEta;

		// Token: 0x0400089F RID: 2207
		private global::Telerik.WinControls.UI.RadButton cmdAbortAll;

		// Token: 0x040008A0 RID: 2208
		private global::Telerik.WinControls.UI.RadProgressBar totalProgress;

		// Token: 0x040008A1 RID: 2209
		private global::System.Windows.Forms.PictureBox pbCover;

		// Token: 0x040008A2 RID: 2210
		private global::System.Windows.Forms.PictureBox pbPreview3;

		// Token: 0x040008A3 RID: 2211
		private global::System.Windows.Forms.PictureBox pbPreview2;

		// Token: 0x040008A4 RID: 2212
		private global::System.Windows.Forms.PictureBox pbPreview1;

		// Token: 0x040008A5 RID: 2213
		private global::Telerik.WinControls.UI.RadLabel lblTitle;

		// Token: 0x040008A6 RID: 2214
		private global::Telerik.WinControls.UI.RadLabel lblNbGms;

		// Token: 0x040008A7 RID: 2215
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox3;

		// Token: 0x040008A8 RID: 2216
		private global::Telerik.WinControls.UI.RadButton cmdCopy;

		// Token: 0x040008A9 RID: 2217
		private global::Telerik.WinControls.UI.RadButton cmdAddUpdate;

		// Token: 0x040008AA RID: 2218
		private global::Telerik.WinControls.UI.RadButton cmdAddGame;

		// Token: 0x040008AB RID: 2219
		private global::Telerik.WinControls.UI.RadGroupBox grpProgressCurrent;

		// Token: 0x040008AC RID: 2220
		private global::Telerik.WinControls.UI.RadLabel lblEta;

		// Token: 0x040008AD RID: 2221
		private global::Telerik.WinControls.UI.RadProgressBar NUSGrabberProgress;

		// Token: 0x040008AE RID: 2222
		private global::Telerik.WinControls.UI.RadCheckBox chkSleep;

		// Token: 0x040008AF RID: 2223
		private global::Telerik.WinControls.UI.RadButton cmdAddDlc;

		// Token: 0x040008B0 RID: 2224
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040008B1 RID: 2225
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox2;

		// Token: 0x040008B2 RID: 2226
		private global::Telerik.WinControls.UI.RadLabel lblFileEta;

		// Token: 0x040008B3 RID: 2227
		private global::Telerik.WinControls.UI.RadProgressBar pgFile;

		// Token: 0x040008B4 RID: 2228
		private global::Telerik.WinControls.UI.Docking.RadDock dockMain;

		// Token: 0x040008B5 RID: 2229
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolLibrary;

		// Token: 0x040008B6 RID: 2230
		private global::Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;

		// Token: 0x040008B7 RID: 2231
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolGameInfo;

		// Token: 0x040008B8 RID: 2232
		private global::Telerik.WinControls.UI.RadPanel radPanel1;

		// Token: 0x040008B9 RID: 2233
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolDownload;

		// Token: 0x040008BA RID: 2234
		private global::Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;

		// Token: 0x040008BB RID: 2235
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox4;

		// Token: 0x040008BC RID: 2236
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;

		// Token: 0x040008BD RID: 2237
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;

		// Token: 0x040008BE RID: 2238
		private global::Telerik.WinControls.UI.RadPanel radPanel2;

		// Token: 0x040008BF RID: 2239
		private global::Telerik.WinControls.UI.RadButton cmdAddAllGames;

		// Token: 0x040008C0 RID: 2240
		private global::Telerik.WinControls.UI.RadButton cmdAddAllUpdates;

		// Token: 0x040008C1 RID: 2241
		private global::Telerik.WinControls.UI.RadButton cmdAddAllDLCS;

		// Token: 0x040008C2 RID: 2242
		private global::Telerik.WinControls.UI.RadButton cmdClearDl;

		// Token: 0x040008C3 RID: 2243
		private global::Telerik.WinControls.UI.RadButton cmdRefresh;

		// Token: 0x040008C4 RID: 2244
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;

		// Token: 0x040008C5 RID: 2245
		private global::Telerik.WinControls.UI.RadPanel radPanel3;

		// Token: 0x040008C6 RID: 2246
		private global::Telerik.WinControls.UI.RadButton cmdChangeTheme;

		// Token: 0x040008C7 RID: 2247
		private global::System.Windows.Forms.WebBrowser webBrowser;

		// Token: 0x040008C8 RID: 2248
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox6;

		// Token: 0x040008C9 RID: 2249
		private global::Telerik.WinControls.UI.Docking.RadDock dockInfo;

		// Token: 0x040008CA RID: 2250
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolWeb;

		// Token: 0x040008CB RID: 2251
		private global::Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;

		// Token: 0x040008CC RID: 2252
		private global::Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip2;

		// Token: 0x040008CD RID: 2253
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolGameDesc;

		// Token: 0x040008CE RID: 2254
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolScreenShot;

		// Token: 0x040008CF RID: 2255
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox8;

		// Token: 0x040008D0 RID: 2256
		private global::Telerik.WinControls.UI.RadButton cmdGoBack;

		// Token: 0x040008D1 RID: 2257
		private global::Telerik.WinControls.UI.RadButton cmdGoNext;

		// Token: 0x040008D2 RID: 2258
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox9;

		// Token: 0x040008D3 RID: 2259
		private global::Telerik.WinControls.UI.RadButton cmdImportGames;

		// Token: 0x040008D4 RID: 2260
		private global::Telerik.WinControls.UI.RadSplitContainer radSplitContainer3;

		// Token: 0x040008D5 RID: 2261
		private global::Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;

		// Token: 0x040008D6 RID: 2262
		private global::Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;

		// Token: 0x040008D7 RID: 2263
		private global::Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip6;

		// Token: 0x040008D8 RID: 2264
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolCopy;

		// Token: 0x040008D9 RID: 2265
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox10;

		// Token: 0x040008DA RID: 2266
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040008DB RID: 2267
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x040008DC RID: 2268
		private global::Telerik.WinControls.UI.RadLabel lblTotalCopy;

		// Token: 0x040008DD RID: 2269
		private global::Telerik.WinControls.UI.RadListView lstCopy;

		// Token: 0x040008DE RID: 2270
		private global::Telerik.WinControls.UI.RadLabel radLabel6;

		// Token: 0x040008DF RID: 2271
		private global::Telerik.WinControls.UI.RadButton cmdInitiateCopy;

		// Token: 0x040008E0 RID: 2272
		private global::Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip4;

		// Token: 0x040008E1 RID: 2273
		private global::Telerik.WinControls.UI.RadButton cmdDelete;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Forms.CheckBox chkShowRednand;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.CheckBox chkShowLegit;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.CheckBox chkShowPreviews;

		// Token: 0x040008E5 RID: 2277
		private global::Telerik.WinControls.UI.RadContextMenu radContextMenu_0;

		// Token: 0x040008E6 RID: 2278
		private global::Telerik.WinControls.UI.RadMenuItem menuDlGame;

		// Token: 0x040008E7 RID: 2279
		private global::Telerik.WinControls.UI.RadMenuItem menuDlUpdate;

		// Token: 0x040008E8 RID: 2280
		private global::Telerik.WinControls.UI.RadMenuItem menuDlDLC;

		// Token: 0x040008E9 RID: 2281
		private global::Telerik.WinControls.UI.RadMenuItem menuCopy;

		// Token: 0x040008EA RID: 2282
		private global::Telerik.WinControls.UI.RadMenuItem menuDelete;

		// Token: 0x040008EB RID: 2283
		private global::Telerik.WinControls.UI.RadMenuItem menuMarkInstall;

		// Token: 0x040008EC RID: 2284
		private global::Telerik.WinControls.UI.RadButton cmdHallOfFame;

		// Token: 0x040008ED RID: 2285
		private global::Telerik.WinControls.UI.RadTextBoxControl txtDesc;

		// Token: 0x040008EE RID: 2286
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolExtraInfo;

		// Token: 0x040008EF RID: 2287
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008F0 RID: 2288
		private global::System.Windows.Forms.PictureBox pbRating;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040008F2 RID: 2290
		private global::Telerik.WinControls.UI.RadProgressBar pgScore;

		// Token: 0x040008F3 RID: 2291
		private global::Telerik.WinControls.UI.RadListView lstControllers;

		// Token: 0x040008F4 RID: 2292
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040008F5 RID: 2293
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040008F6 RID: 2294
		private global::Telerik.WinControls.UI.RadListView lstGenre;

		// Token: 0x040008F7 RID: 2295
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolMovies;

		// Token: 0x040008F8 RID: 2296
		private global::Telerik.WinControls.UI.RadListView lstMovies;

		// Token: 0x040008F9 RID: 2297
		private global::Telerik.WinControls.UI.RadLabel radLabel7;

		// Token: 0x040008FA RID: 2298
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox11;

		// Token: 0x040008FB RID: 2299
		private global::System.Windows.Forms.Timer timer_2;

		// Token: 0x040008FC RID: 2300
		private global::Telerik.WinControls.UI.RadButton cmdCopyAll;

		// Token: 0x040008FD RID: 2301
		private global::System.Windows.Forms.Label lblLang;

		// Token: 0x040008FE RID: 2302
		private global::Telerik.WinControls.UI.RadListView lstLanguages;

		// Token: 0x040008FF RID: 2303
		private global::System.Windows.Forms.Timer timer_3;

		// Token: 0x04000900 RID: 2304
		private global::Telerik.WinControls.UI.RadCheckBox chkCompactView;

		// Token: 0x04000901 RID: 2305
		private global::Telerik.WinControls.UI.RadButton cmdSendWiiu;

		// Token: 0x04000902 RID: 2306
		private global::Telerik.WinControls.UI.RadMenuItem radMarkNotInstalled;

		// Token: 0x04000903 RID: 2307
		private global::Telerik.WinControls.UI.RadMenuItem radUnpack;

		// Token: 0x04000904 RID: 2308
		private global::Telerik.WinControls.UI.RadCheckBox chkCopyToSD;

		// Token: 0x04000905 RID: 2309
		private global::Telerik.WinControls.UI.RadCheckBox chkUnpack;

		// Token: 0x04000906 RID: 2310
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolFilters;

		// Token: 0x04000907 RID: 2311
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox13;

		// Token: 0x04000908 RID: 2312
		private global::Telerik.WinControls.UI.RadCheckBox chkJAP;

		// Token: 0x04000909 RID: 2313
		private global::Telerik.WinControls.UI.RadCheckBox chkUSA;

		// Token: 0x0400090A RID: 2314
		private global::Telerik.WinControls.UI.RadCheckBox chkEUR;

		// Token: 0x0400090B RID: 2315
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox12;

		// Token: 0x0400090C RID: 2316
		private global::Telerik.WinControls.UI.RadLabel radLabel9;

		// Token: 0x0400090D RID: 2317
		private global::Telerik.WinControls.UI.RadSpinEditor radMaxSpeed;

		// Token: 0x0400090E RID: 2318
		private global::Telerik.WinControls.UI.RadCheckBox chkDelay;

		// Token: 0x0400090F RID: 2319
		private global::Telerik.WinControls.UI.RadLabel lblTimeLeft;

		// Token: 0x04000910 RID: 2320
		private global::System.Windows.Forms.Timer timer_4;

		// Token: 0x04000911 RID: 2321
		private global::Telerik.WinControls.UI.RadButton cmdAbortDelay;

		// Token: 0x04000912 RID: 2322
		private global::Telerik.WinControls.UI.RadButton cmdPlay;

		// Token: 0x04000913 RID: 2323
		private global::Telerik.WinControls.UI.RadButton cmdManageRemoteSd;

		// Token: 0x04000914 RID: 2324
		private global::Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;

		// Token: 0x04000915 RID: 2325
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolWindow5;

		// Token: 0x04000916 RID: 2326
		private global::Telerik.WinControls.UI.RadLabel lblStatus;

		// Token: 0x04000917 RID: 2327
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolAdvancedSettings;

		// Token: 0x04000918 RID: 2328
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox14;

		// Token: 0x04000919 RID: 2329
		private global::Telerik.WinControls.UI.RadButton cmdSetProxy;

		// Token: 0x0400091A RID: 2330
		private global::Telerik.WinControls.UI.RadTextBox radTextBox1;

		// Token: 0x0400091B RID: 2331
		private global::Telerik.WinControls.UI.RadTextBox txtProxyUsr;

		// Token: 0x0400091C RID: 2332
		private global::Telerik.WinControls.UI.RadLabel txtProxyPassword;

		// Token: 0x0400091D RID: 2333
		private global::Telerik.WinControls.UI.RadLabel radLabel11;

		// Token: 0x0400091E RID: 2334
		private global::Telerik.WinControls.UI.RadTextBox txtProxyUrl;

		// Token: 0x0400091F RID: 2335
		private global::Telerik.WinControls.UI.RadLabel radLabel10;

		// Token: 0x04000920 RID: 2336
		private global::Telerik.WinControls.UI.RadButton cmdClearProxy;

		// Token: 0x04000921 RID: 2337
		private global::Telerik.WinControls.UI.RadLabel lblproxyStatus;

		// Token: 0x04000922 RID: 2338
		private global::Telerik.WinControls.UI.RadLabel radLabel12;

		// Token: 0x04000923 RID: 2339
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox15;

		// Token: 0x04000924 RID: 2340
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox16;

		// Token: 0x04000925 RID: 2341
		private global::Telerik.WinControls.UI.RadLabel lblDonatorDate;

		// Token: 0x04000926 RID: 2342
		private global::Telerik.WinControls.UI.RadLabel radLabel18;

		// Token: 0x04000927 RID: 2343
		private global::Telerik.WinControls.UI.RadLabel lblDonatorEmail;

		// Token: 0x04000928 RID: 2344
		private global::Telerik.WinControls.UI.RadLabel radLabel16;

		// Token: 0x04000929 RID: 2345
		private global::Telerik.WinControls.UI.RadLabel radLabel15;

		// Token: 0x0400092A RID: 2346
		private global::Telerik.WinControls.UI.RadLabel lblDonatorStatus;

		// Token: 0x0400092B RID: 2347
		private global::Telerik.WinControls.UI.RadLabel radLabel14;

		// Token: 0x0400092C RID: 2348
		private global::Telerik.WinControls.UI.RadButton cmdDonate;

		// Token: 0x0400092D RID: 2349
		private global::System.Windows.Forms.PictureBox pictureLogo;

		// Token: 0x0400092E RID: 2350
		private global::Telerik.WinControls.UI.RadButton cmdBackupSave;

		// Token: 0x0400092F RID: 2351
		private global::Telerik.WinControls.UI.Docking.ToolWindow tollSaveManager;

		// Token: 0x04000930 RID: 2352
		private global::Telerik.WinControls.UI.RadButton cmdRestoreSave;

		// Token: 0x04000931 RID: 2353
		private global::Telerik.WinControls.UI.RadLabel radLabel8;

		// Token: 0x04000932 RID: 2354
		private global::System.Windows.Forms.DateTimePicker radDate;

		// Token: 0x04000933 RID: 2355
		private global::Telerik.WinControls.UI.RadCheckBox chkPack;

		// Token: 0x04000934 RID: 2356
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolEmuSettings;

		// Token: 0x04000935 RID: 2357
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox17;

		// Token: 0x04000936 RID: 2358
		private global::Telerik.WinControls.UI.RadPageView radPageView2;

		// Token: 0x04000937 RID: 2359
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;

		// Token: 0x04000938 RID: 2360
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;

		// Token: 0x04000939 RID: 2361
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox18;

		// Token: 0x0400093A RID: 2362
		private global::Telerik.WinControls.UI.Gauges.RadRadialGauge gaugeSpeed;

		// Token: 0x0400093B RID: 2363
		private global::Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc1;

		// Token: 0x0400093C RID: 2364
		private global::Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc2;

		// Token: 0x0400093D RID: 2365
		private global::Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels1;

		// Token: 0x0400093E RID: 2366
		private global::Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks1;

		// Token: 0x0400093F RID: 2367
		private global::Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel1;

		// Token: 0x04000940 RID: 2368
		private global::Telerik.WinControls.UI.RadLabel lblSpeed;

		// Token: 0x04000941 RID: 2369
		private global::Telerik.WinControls.UI.RadMenuItem menuPlay;

		// Token: 0x04000942 RID: 2370
		private global::Telerik.WinControls.UI.RadMenuItem radDelEmuData;

		// Token: 0x04000943 RID: 2371
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolContribute;

		// Token: 0x04000944 RID: 2372
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox20;

		// Token: 0x04000945 RID: 2373
		private global::Telerik.WinControls.UI.RadButton cmdSugegstIdea;

		// Token: 0x04000946 RID: 2374
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox21;

		// Token: 0x04000947 RID: 2375
		private global::Telerik.WinControls.UI.RadButton radButton2;

		// Token: 0x04000948 RID: 2376
		private global::Telerik.WinControls.UI.RadLabel radLabel13;

		// Token: 0x04000949 RID: 2377
		private global::Telerik.WinControls.UI.RadCheckBox chkPrepareEmulation;

		// Token: 0x0400094A RID: 2378
		private global::Telerik.WinControls.UI.RadMenuItem radPrepareEmu;

		// Token: 0x0400094B RID: 2379
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox22;

		// Token: 0x0400094C RID: 2380
		private global::Telerik.WinControls.UI.RadCheckBox chkPreventShortcut;

		// Token: 0x0400094D RID: 2381
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolHelp;

		// Token: 0x0400094E RID: 2382
		private global::Telerik.WinControls.UI.RadButton cmdShortcut;

		// Token: 0x0400094F RID: 2383
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox24;

		// Token: 0x04000950 RID: 2384
		private global::Telerik.WinControls.UI.RadButton cmdPrepareSd;

		// Token: 0x04000951 RID: 2385
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolAdvancedSearch;

		// Token: 0x04000952 RID: 2386
		private global::Telerik.WinControls.UI.RadButton cmdClearCriterias;

		// Token: 0x04000953 RID: 2387
		private global::Telerik.WinControls.UI.RadButton cmdSearchWithCriterias;

		// Token: 0x04000954 RID: 2388
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox25;

		// Token: 0x04000955 RID: 2389
		private global::Telerik.WinControls.UI.RadCheckedListBox chkGameGenres;

		// Token: 0x04000956 RID: 2390
		private global::Telerik.WinControls.UI.RadButton cmdLegal;

		// Token: 0x04000957 RID: 2391
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox28;

		// Token: 0x04000958 RID: 2392
		private global::Telerik.WinControls.UI.RadLabel lblStorageLocation;

		// Token: 0x04000959 RID: 2393
		private global::Telerik.WinControls.UI.RadMenuItem radMenuItem1;

		// Token: 0x0400095A RID: 2394
		private global::Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder1;

		// Token: 0x0400095B RID: 2395
		private global::Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder2;

		// Token: 0x0400095C RID: 2396
		private global::Telerik.WinControls.UI.RadCheckBox chkKOR;

		// Token: 0x0400095D RID: 2397
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x0400095E RID: 2398
		private global::Telerik.WinControls.UI.RadLabel lblEmuUpdateVersion;

		// Token: 0x0400095F RID: 2399
		private global::Telerik.WinControls.UI.RadLabel lblStatusDLCEmu;

		// Token: 0x04000960 RID: 2400
		private global::Telerik.WinControls.UI.RadLabel lblStatusUpdateEmu;

		// Token: 0x04000961 RID: 2401
		private global::Telerik.WinControls.UI.RadLabel lblStatusGameEmu;

		// Token: 0x04000962 RID: 2402
		private global::Telerik.WinControls.UI.RadLabel lblStatusDLCRaw;

		// Token: 0x04000963 RID: 2403
		private global::Telerik.WinControls.UI.RadLabel radLabel19;

		// Token: 0x04000964 RID: 2404
		private global::Telerik.WinControls.UI.RadLabel radLabel17;

		// Token: 0x04000965 RID: 2405
		private global::Telerik.WinControls.UI.RadLabel lblNbPlayers;

		// Token: 0x04000966 RID: 2406
		private global::Telerik.WinControls.UI.RadLabel radLabel5;

		// Token: 0x04000967 RID: 2407
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x04000968 RID: 2408
		private global::Telerik.WinControls.UI.RadLabel lblDLCSize;

		// Token: 0x04000969 RID: 2409
		private global::Telerik.WinControls.UI.RadLabel lblTitleId;

		// Token: 0x0400096A RID: 2410
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x0400096B RID: 2411
		private global::Telerik.WinControls.UI.RadLabel lblStatusUpdateRaw;

		// Token: 0x0400096C RID: 2412
		private global::Telerik.WinControls.UI.RadLabel lblStatusGameRaw;

		// Token: 0x0400096D RID: 2413
		private global::Telerik.WinControls.UI.RadLabel lblUpdateSize;

		// Token: 0x0400096E RID: 2414
		private global::Telerik.WinControls.UI.RadLabel label5;

		// Token: 0x0400096F RID: 2415
		private global::Telerik.WinControls.UI.RadLabel lblGameSize;

		// Token: 0x04000970 RID: 2416
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000971 RID: 2417
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox26;

		// Token: 0x04000972 RID: 2418
		private global::Telerik.WinControls.UI.RadLabel radLabel21;

		// Token: 0x04000973 RID: 2419
		private global::Telerik.WinControls.UI.RadCheckBox chkSuperSpeed;

		// Token: 0x04000974 RID: 2420
		private global::Telerik.WinControls.UI.RadLabel radLabel20;

		// Token: 0x04000975 RID: 2421
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x04000976 RID: 2422
		private global::Telerik.WinControls.UI.RadLabel lblSynchronized;

		// Token: 0x04000977 RID: 2423
		private global::Telerik.WinControls.UI.RadCheckBox chkForceGameMode;

		// Token: 0x04000978 RID: 2424
		private global::Telerik.WinControls.UI.RadLabel radLabel22;

		// Token: 0x04000979 RID: 2425
		private global::Telerik.WinControls.UI.RadLabel radLabel23;

		// Token: 0x0400097A RID: 2426
		private global::Telerik.WinControls.UI.RadButton radButton4;

		// Token: 0x0400097B RID: 2427
		private global::Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;

		// Token: 0x0400097C RID: 2428
		private global::Telerik.WinControls.UI.SplitPanel splitPanel1;

		// Token: 0x0400097D RID: 2429
		private global::Telerik.WinControls.UI.SplitPanel splitPanel2;

		// Token: 0x0400097E RID: 2430
		private global::System.Windows.Forms.Timer timer_5;

		// Token: 0x0400097F RID: 2431
		private global::Telerik.WinControls.UI.RadButton radButton5;

		// Token: 0x04000980 RID: 2432
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox5;

		// Token: 0x04000981 RID: 2433
		private global::Telerik.WinControls.UI.RadButton radButton7;

		// Token: 0x04000982 RID: 2434
		private global::Telerik.WinControls.UI.RadButton cmdImportCemu;

		// Token: 0x04000983 RID: 2435
		private global::Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;

		// Token: 0x04000984 RID: 2436
		private global::Telerik.WinControls.UI.RadGroupBox grpLog;

		// Token: 0x04000985 RID: 2437
		private global::Telerik.WinControls.UI.RadListView lstLog;

		// Token: 0x04000986 RID: 2438
		private global::Telerik.WinControls.UI.RadGroupBox radLiveSpeed;

		// Token: 0x04000987 RID: 2439
		private global::Telerik.WinControls.UI.RadLabel lblFileCheckStatus;

		// Token: 0x04000988 RID: 2440
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolChat;

		// Token: 0x04000989 RID: 2441
		private global::Telerik.WinControls.UI.RadListView lstChat;

		// Token: 0x0400098A RID: 2442
		private global::Telerik.WinControls.UI.RadTextBoxControl txtChat;

		// Token: 0x0400098B RID: 2443
		private global::Telerik.WinControls.UI.Docking.ToolWindow toolMods;

		// Token: 0x0400098C RID: 2444
		private global::Telerik.WinControls.UI.RadCheckedListBox lstMods;

		// Token: 0x0400098D RID: 2445
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox27;

		// Token: 0x0400098E RID: 2446
		private global::Telerik.WinControls.UI.RadCarousel modPreview;

		// Token: 0x0400098F RID: 2447
		private global::Telerik.WinControls.UI.RadTextBoxControl txtModDescription;

		// Token: 0x04000990 RID: 2448
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox29;

		// Token: 0x04000991 RID: 2449
		private global::Telerik.WinControls.UI.RadTextBoxControl txtModSearch;

		// Token: 0x04000992 RID: 2450
		private global::Telerik.WinControls.UI.RadButton cmdModContribute;

		// Token: 0x04000993 RID: 2451
		private global::Telerik.WinControls.UI.RadTreeView treePlatforms;

		// Token: 0x04000994 RID: 2452
		private global::System.Windows.Forms.Timer timer_6;

		// Token: 0x04000995 RID: 2453
		private global::Telerik.WinControls.UI.RadCheckBox chkDisableSpeedGraph;

		// Token: 0x04000996 RID: 2454
		private global::Telerik.WinControls.UI.RadButton cmdCommunitySaves;

		// Token: 0x04000997 RID: 2455
		private global::Telerik.WinControls.UI.RadCheckBox chkNotifyChat;

		// Token: 0x04000998 RID: 2456
		private global::Telerik.WinControls.UI.RadLabel lblChannelClientCount;

		// Token: 0x04000999 RID: 2457
		private global::System.Windows.Forms.Timer timer_7;

		// Token: 0x0400099A RID: 2458
		private global::Telerik.WinControls.UI.RadPanel panelChatBottom;

		// Token: 0x0400099B RID: 2459
		private global::Telerik.WinControls.UI.RadPanel panelGameCover;

		// Token: 0x0400099C RID: 2460
		private global::Telerik.WinControls.UI.RadPanel panelLibraryCheckbox;

		// Token: 0x0400099D RID: 2461
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400099E RID: 2462
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400099F RID: 2463
		private global::Telerik.WinControls.UI.RadRadioButton radioLobby;

		// Token: 0x040009A0 RID: 2464
		private global::Telerik.WinControls.UI.RadRadioButton radioGameRoom;

		// Token: 0x040009A1 RID: 2465
		private global::Telerik.WinControls.UI.RadLabel lblModsOnlyCemu;
	}
}
