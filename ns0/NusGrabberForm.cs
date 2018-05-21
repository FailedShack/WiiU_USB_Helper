// Decompiled with JetBrains decompiler
// Type: ns0.NusGrabberForm
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using Microsoft.VisualBasic.Devices;
using Microsoft.WindowsAPICodePack.Taskbar;
using Newtonsoft.Json;
using NusHelper;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI.Gauges;
using WIIU_Downloader.Forms;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class NusGrabberForm : RadForm
  {
    private static readonly string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\USB_HELPER\\";
    private const string string_0 = "Powered by Willzor's wiiuusbhelper.com (No Wii U found, please launch Wii U USB Helper Transfer Tool)";
    private const string string_1 = "Powered by Willzor's wiiuusbhelper.com (Connected to your Wii U!)";
    private const int int_0 = 4000;
    private readonly ListViewDataItemGroup listViewDataItemGroup_0;
    private readonly ListViewDataItemGroup listViewDataItemGroup_1;
    private readonly ListViewDataItemGroup listViewDataItemGroup_2;
    private readonly ListViewDataItemGroup listViewDataItemGroup_3;
    private readonly ListViewDataItemGroup listViewDataItemGroup_4;
    private GEnum10 genum10_0;
    private GClass80 gclass80_0;
    private ulong ulong_0;
    private bool bool_0;
    private GClass15 gclass15_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private volatile bool bool_7;
    private DriveInfo driveInfo_0;
    private List<string> list_0;
    private GClass130 gclass130_0;
    private DateTime dateTime_0;
    private GClass82 gclass82_0;
    private Bitmap bitmap_0;
    private System.Windows.Forms.Timer timer_0;
    private System.Windows.Forms.Timer timer_1;
    private float float_0;
    private List<GClass133> list_4;
    private SoundPlayer soundPlayer_0;
    private DateTime dateTime_1;
    private ChartValues<GClass125> chartValues_0;
    private LiveCharts.WinForms.CartesianChart cartesianChart_0;
    private string string_3;
    private ulong ulong_1;
    private DockWindow dockWindow_0;
    private int int_2;
    private IContainer icontainer_0;
    private RadButton DownloadButton;
    private RadTextBox FTSearchBox;
    private RadListView lstGames;
    private OpenFileDialog openFileDialog_0;
    private RadButton cmdChangeRegion;
    private RadButton cmdSetExtractFolder;
    private RadButton cmdChangeFolder;
    private RadLabel label2;
    private RadListView dlQueue;
    private RadLabel lblTotalToDl;
    private RadLabel lblTotalDl;
    private PictureBox pbBanner;
    private RadButton cmdChangeTicket;
    private RadGroupBox radGroupBox7;
    private RadCheckBox chkShutdown;
    private RadCheckBox chkHibernate;
    private RadGroupBox grpProgressAll;
    private RadLabel lblTotalEta;
    private RadButton cmdAbortAll;
    private RadProgressBar totalProgress;
    private PictureBox pbCover;
    private PictureBox pbPreview3;
    private PictureBox pbPreview2;
    private PictureBox pbPreview1;
    private RadLabel lblTitle;
    private RadLabel lblNbGms;
    private RadGroupBox radGroupBox3;
    private RadButton cmdCopy;
    private RadButton cmdAddUpdate;
    private RadButton cmdAddGame;
    private RadGroupBox grpProgressCurrent;
    private RadLabel lblEta;
    private RadProgressBar NUSGrabberProgress;
    private RadCheckBox chkSleep;
    private RadButton cmdAddDlc;
    private System.Windows.Forms.Label label4;
    private RadGroupBox radGroupBox2;
    private RadLabel lblFileEta;
    private RadProgressBar pgFile;
    private RadDock dockMain;
    private ToolWindow toolLibrary;
    private DocumentContainer documentContainer1;
    private ToolWindow toolGameInfo;
    private RadPanel radPanel1;
    private ToolWindow toolDownload;
    private DocumentTabStrip documentTabStrip1;
    private RadGroupBox radGroupBox4;
    private ToolWindow toolWindow2;
    private ToolWindow toolWindow3;
    private RadPanel radPanel2;
    private RadButton cmdAddAllGames;
    private RadButton cmdAddAllUpdates;
    private RadButton cmdAddAllDLCS;
    private RadButton cmdClearDl;
    private RadButton cmdRefresh;
    private ToolWindow toolWindow4;
    private RadPanel radPanel3;
    private RadButton cmdChangeTheme;
    private WebBrowser webBrowser;
    private RadGroupBox radGroupBox6;
    private RadDock dockInfo;
    private ToolWindow toolWeb;
    private DocumentContainer documentContainer2;
    private DocumentTabStrip documentTabStrip2;
    private ToolWindow toolGameDesc;
    private ToolWindow toolScreenShot;
    private RadGroupBox radGroupBox8;
    private RadButton cmdGoBack;
    private RadButton cmdGoNext;
    private RadGroupBox radGroupBox9;
    private RadButton cmdImportGames;
    private RadSplitContainer radSplitContainer3;
    private ToolTabStrip toolTabStrip1;
    private ToolTabStrip toolTabStrip2;
    private ToolTabStrip toolTabStrip6;
    private ToolWindow toolCopy;
    private RadGroupBox radGroupBox10;
    private RadLabel radLabel1;
    private RadButton radButton1;
    private RadLabel lblTotalCopy;
    private RadListView lstCopy;
    private RadLabel radLabel6;
    private RadButton cmdInitiateCopy;
    private ToolTabStrip toolTabStrip4;
    private RadButton cmdDelete;
    private CheckBox chkShowRednand;
    private CheckBox chkShowLegit;
    private CheckBox chkShowPreviews;
    private RadContextMenu radContextMenu_0;
    private RadMenuItem menuDlGame;
    private RadMenuItem menuDlUpdate;
    private RadMenuItem menuDlDLC;
    private RadMenuItem menuCopy;
    private RadMenuItem menuDelete;
    private RadMenuItem menuMarkInstall;
    private RadButton cmdHallOfFame;
    private RadTextBoxControl txtDesc;
    private ToolWindow toolExtraInfo;
    private System.Windows.Forms.Label label3;
    private PictureBox pbRating;
    private System.Windows.Forms.Label label8;
    private RadProgressBar pgScore;
    private RadListView lstControllers;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private RadListView lstGenre;
    private ToolWindow toolMovies;
    private RadListView lstMovies;
    private RadLabel radLabel7;
    private RadGroupBox radGroupBox11;
    private System.Windows.Forms.Timer timer_2;
    private RadButton cmdCopyAll;
    private System.Windows.Forms.Label lblLang;
    private RadListView lstLanguages;
    private System.Windows.Forms.Timer timer_3;
    private RadCheckBox chkCompactView;
    private RadButton cmdSendWiiu;
    private RadMenuItem radMarkNotInstalled;
    private RadMenuItem radUnpack;
    private RadCheckBox chkCopyToSD;
    private RadCheckBox chkUnpack;
    private ToolWindow toolFilters;
    private RadGroupBox radGroupBox13;
    private RadCheckBox chkJAP;
    private RadCheckBox chkUSA;
    private RadCheckBox chkEUR;
    private RadGroupBox radGroupBox12;
    private RadLabel radLabel9;
    private RadSpinEditor radMaxSpeed;
    private RadCheckBox chkDelay;
    private RadLabel lblTimeLeft;
    private System.Windows.Forms.Timer timer_4;
    private RadButton cmdAbortDelay;
    private RadButton cmdPlay;
    private RadButton cmdManageRemoteSd;
    private ToolTabStrip toolTabStrip3;
    private ToolWindow toolWindow5;
    private RadLabel lblStatus;
    private ToolWindow toolAdvancedSettings;
    private RadGroupBox radGroupBox14;
    private RadButton cmdSetProxy;
    private RadTextBox radTextBox1;
    private RadTextBox txtProxyUsr;
    private RadLabel txtProxyPassword;
    private RadLabel radLabel11;
    private RadTextBox txtProxyUrl;
    private RadLabel radLabel10;
    private RadButton cmdClearProxy;
    private RadLabel lblproxyStatus;
    private RadLabel radLabel12;
    private RadGroupBox radGroupBox15;
    private RadGroupBox radGroupBox16;
    private RadLabel lblDonatorDate;
    private RadLabel radLabel18;
    private RadLabel lblDonatorEmail;
    private RadLabel radLabel16;
    private RadLabel radLabel15;
    private RadLabel lblDonatorStatus;
    private RadLabel radLabel14;
    private RadButton cmdDonate;
    private PictureBox pictureLogo;
    private RadButton cmdBackupSave;
    private ToolWindow tollSaveManager;
    private RadButton cmdRestoreSave;
    private RadLabel radLabel8;
    private DateTimePicker radDate;
    private RadCheckBox chkPack;
    private ToolWindow toolEmuSettings;
    private RadGroupBox radGroupBox17;
    private RadPageView radPageView2;
    private RadPageViewPage radPageViewPage1;
    private RadPageViewPage radPageViewPage3;
    private RadGroupBox radGroupBox18;
    private RadRadialGauge gaugeSpeed;
    private RadialGaugeArc radialGaugeArc1;
    private RadialGaugeArc radialGaugeArc2;
    private RadialGaugeLabels radialGaugeLabels1;
    private RadialGaugeTicks radialGaugeTicks1;
    private RadialGaugeSingleLabel radialGaugeSingleLabel1;
    private RadLabel lblSpeed;
    private RadMenuItem menuPlay;
    private RadMenuItem radDelEmuData;
    private ToolWindow toolContribute;
    private RadGroupBox radGroupBox20;
    private RadButton cmdSugegstIdea;
    private RadGroupBox radGroupBox21;
    private RadButton radButton2;
    private RadLabel radLabel13;
    private RadCheckBox chkPrepareEmulation;
    private RadMenuItem radPrepareEmu;
    private RadGroupBox radGroupBox22;
    private RadCheckBox chkPreventShortcut;
    private ToolWindow toolHelp;
    private RadButton cmdShortcut;
    private RadGroupBox radGroupBox24;
    private RadButton cmdPrepareSd;
    private ToolWindow toolAdvancedSearch;
    private RadButton cmdClearCriterias;
    private RadButton cmdSearchWithCriterias;
    private RadGroupBox radGroupBox25;
    private RadCheckedListBox chkGameGenres;
    private RadButton cmdLegal;
    private RadGroupBox radGroupBox28;
    private RadLabel lblStorageLocation;
    private RadMenuItem radMenuItem1;
    private DockWindowPlaceholder dockWindowPlaceholder1;
    private DockWindowPlaceholder dockWindowPlaceholder2;
    private RadCheckBox chkKOR;
    private RadGroupBox radGroupBox1;
    private RadLabel lblEmuUpdateVersion;
    private RadLabel lblStatusDLCEmu;
    private RadLabel lblStatusUpdateEmu;
    private RadLabel lblStatusGameEmu;
    private RadLabel lblStatusDLCRaw;
    private RadLabel radLabel19;
    private RadLabel radLabel17;
    private RadLabel lblNbPlayers;
    private RadLabel radLabel5;
    private RadLabel radLabel4;
    private RadLabel lblDLCSize;
    private RadLabel lblTitleId;
    private RadLabel radLabel2;
    private RadLabel lblStatusUpdateRaw;
    private RadLabel lblStatusGameRaw;
    private RadLabel lblUpdateSize;
    private RadLabel label5;
    private RadLabel lblGameSize;
    private RadLabel label1;
    private RadGroupBox radGroupBox26;
    private RadLabel radLabel21;
    private RadCheckBox chkSuperSpeed;
    private RadLabel radLabel20;
    private RadLabel radLabel3;
    private RadLabel lblSynchronized;
    private RadCheckBox chkForceGameMode;
    private RadLabel radLabel22;
    private RadLabel radLabel23;
    private RadButton radButton4;
    private RadSplitContainer radSplitContainer1;
    private SplitPanel splitPanel1;
    private SplitPanel splitPanel2;
    private System.Windows.Forms.Timer timer_5;
    private RadButton radButton5;
    private RadGroupBox radGroupBox5;
    private RadButton radButton7;
    private RadButton cmdImportCemu;
    private RadPageViewPage radPageViewPage2;
    private RadGroupBox grpLog;
    private RadListView lstLog;
    private RadGroupBox radLiveSpeed;
    private RadLabel lblFileCheckStatus;
    private ToolWindow toolChat;
    private RadListView lstChat;
    private RadTextBoxControl txtChat;
    private ToolWindow toolMods;
    private RadCheckedListBox lstMods;
    private RadGroupBox radGroupBox27;
    private RadCarousel modPreview;
    private RadTextBoxControl txtModDescription;
    private RadGroupBox radGroupBox29;
    private RadTextBoxControl txtModSearch;
    private RadButton cmdModContribute;
    private RadTreeView treePlatforms;
    private System.Windows.Forms.Timer timer_6;
    private RadCheckBox chkDisableSpeedGraph;
    private RadButton cmdCommunitySaves;
    private RadCheckBox chkNotifyChat;
    private RadLabel lblChannelClientCount;
    private System.Windows.Forms.Timer timer_7;
    private RadPanel panelChatBottom;
    private RadPanel panelGameCover;
    private RadPanel panelLibraryCheckbox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private RadRadioButton radioLobby;
    private RadRadioButton radioGameRoom;
    private RadLabel lblModsOnlyCemu;

    public NusGrabberForm()
    {
      ListViewDataItemGroup viewDataItemGroup1 = new ListViewDataItemGroup("Downloaded");
      viewDataItemGroup1.Image = (Image) Class123.icnDownloadedMini;
      this.listViewDataItemGroup_0 = viewDataItemGroup1;
      ListViewDataItemGroup viewDataItemGroup2 = new ListViewDataItemGroup("Partially downloaded");
      viewDataItemGroup2.Image = (Image) Class123.icnPartialMini;
      this.listViewDataItemGroup_1 = viewDataItemGroup2;
      ListViewDataItemGroup viewDataItemGroup3 = new ListViewDataItemGroup("Installed on your WiiU");
      viewDataItemGroup3.Image = (Image) Class123.icnWiiuMini;
      this.listViewDataItemGroup_2 = viewDataItemGroup3;
      ListViewDataItemGroup viewDataItemGroup4 = new ListViewDataItemGroup("Not downloaded");
      viewDataItemGroup4.Image = (Image) Class123.icnNotDownloadedMini;
      this.listViewDataItemGroup_3 = viewDataItemGroup4;
      ListViewDataItemGroup viewDataItemGroup5 = new ListViewDataItemGroup("Ready for emulation");
      viewDataItemGroup5.Image = (Image) Class123.icnPlayMini;
      this.listViewDataItemGroup_4 = viewDataItemGroup5;
      this.dateTime_0 = DateTime.MinValue;
      this.TitlesToCopy = new List<GClass30>();
      this.TitlesToDownload = new List<GClass30>();
      this.list_4 = new List<GClass133>();
      this.soundPlayer_0 = new SoundPlayer((Stream) Class123.sndAdd);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (Settings.Default.Region == "NONE")
      {
        int num = (int) RadMessageBox.Show("You must specify a region.");
        System.Windows.Forms.Application.Restart();
      }
      Class97.smethod_14((Form) this);
      this.InitializeComponent();
      this.toolGameInfo.Select();
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      GClass28.Event_0 += (EventHandler<Exception>) ((object_0, exception_0) => this.Invoke((Delegate) new Action(new NusGrabberForm.Class162()
      {
        exception_0 = exception_0
      }.method_0)));
      this.WindowState = FormWindowState.Normal;
      this.StartPosition = FormStartPosition.WindowsDefaultBounds;
      if (Settings.Default.WindowPosition != Rectangle.Empty && GClass6.smethod_10(Settings.Default.WindowPosition))
      {
        this.StartPosition = FormStartPosition.Manual;
        this.DesktopBounds = Settings.Default.WindowPosition;
        this.WindowState = Settings.Default.WindowState;
      }
      else
      {
        this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        this.Size = Settings.Default.WindowPosition.Size;
      }
      this.dockMain.FloatingWindowCreated += (FloatingWindowEventHandler) ((sender, e) =>
      {
        e.Window.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
        e.Window.Icon = Class123.logo2T_png;
      });
      this.dockInfo.FloatingWindowCreated += (FloatingWindowEventHandler) ((sender, e) =>
      {
        e.Window.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
        e.Window.Icon = Class123.logo2T_png;
      });
      this.pbPreview1.MouseDoubleClick += new MouseEventHandler(Class97.smethod_10);
      this.pbPreview2.MouseDoubleClick += new MouseEventHandler(Class97.smethod_10);
      this.pbPreview3.MouseDoubleClick += new MouseEventHandler(Class97.smethod_10);
    }

    protected override void OnClosed(EventArgs e)
    {
      base.OnClosed(e);
      switch (this.WindowState)
      {
        case FormWindowState.Normal:
        case FormWindowState.Maximized:
          Settings.Default.WindowState = this.WindowState;
          break;
        default:
          Settings.Default.WindowState = FormWindowState.Normal;
          break;
      }
      this.Visible = false;
      this.WindowState = FormWindowState.Normal;
      Settings.Default.WindowPosition = this.DesktopBounds;
      Settings.Default.Save();
    }

    protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, Keys keyData)
    {
      switch (keyData)
      {
        case Keys.D1 | Keys.Control:
          this.toolLibrary.Select();
          return true;
        case Keys.D2 | Keys.Control:
          this.toolFilters.Select();
          return true;
        case Keys.D3 | Keys.Control:
          this.toolAdvancedSearch.Select();
          return true;
        case Keys.D4 | Keys.Control:
          this.toolAdvancedSettings.Select();
          return true;
        case Keys.D5 | Keys.Control:
          this.toolEmuSettings.Select();
          return true;
        case Keys.D6 | Keys.Control:
          this.toolContribute.Select();
          return true;
        case Keys.D7 | Keys.Control:
          this.toolHelp.Select();
          return true;
        case Keys.B | Keys.Control:
          GClass28.bool_0 = !GClass28.bool_0;
          int num1 = (int) RadMessageBox.Show("Large buffer : " + (GClass28.bool_0 ? "enabled" : "disabled"));
          return true;
        case Keys.F | Keys.Control:
          this.FTSearchBox.Focus();
          return true;
        case Keys.L | Keys.Control:
          this.lstGames.Focus();
          try
          {
            ListViewDataItem listViewDataItem = this.lstGames.Items.First<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.Visible));
            this.lstGames.ListViewElement.EnsureItemVisible(listViewDataItem);
            this.lstGames.SelectedItem = listViewDataItem;
          }
          catch
          {
          }
          return true;
        case Keys.N | Keys.Control:
          GClass28.bool_1 = !GClass28.bool_1;
          int num2 = (int) RadMessageBox.Show("AES status : " + (GClass28.bool_1 ? "enabled" : "disabled"));
          return true;
        default:
          return base.ProcessCmdKey(ref msg, keyData);
      }
    }

    private bool CurrentlyDownloading { get; set; }

    private FrmWait frmWait { get; set; }

    private int IndexGameCurrentlyDownloaded { get; set; }

    private List<Platform> Platforms { get; set; }

    private WebProxy Proxy { get; set; }

    private GClass32 PreviouslySelectedGame { get; set; }

    private GClass32 SelectedGame { get; set; }

    private List<GClass30> TitlesToCopy { get; }

    private List<GClass30> TitlesToDownload { get; }

    private void method_0(GClass32 gclass32_2)
    {
      this.method_6((GClass30) gclass32_2);
      try
      {
        if (gclass32_2.Boolean_3 && !this.dlQueue.smethod_0((GClass30) gclass32_2.Updates.Last<GClass33>()) && (gclass32_2.Updates.Last<GClass33>().GEnum2_0 != GEnum2.const_2 && RadMessageBox.Show(string.Format("{0} has an update that you do not have downloaded yet. Would you like to add it to the queue?", (object) gclass32_2), "Add update?", MessageBoxButtons.YesNo) == DialogResult.Yes))
          this.method_6((GClass30) gclass32_2.Updates.Last<GClass33>());
        if (!gclass32_2.Boolean_2 || this.dlQueue.smethod_0((GClass30) gclass32_2.Dlc) || (gclass32_2.Dlc.GEnum2_0 == GEnum2.const_2 || RadMessageBox.Show(string.Format("{0} has a DLC that you do not have downloaded yet. Would you like to add it to the queue?", (object) gclass32_2), "Add DLC?", MessageBoxButtons.YesNo) != DialogResult.Yes))
          return;
        this.method_6((GClass30) gclass32_2.Dlc);
      }
      catch
      {
      }
    }

    private ListViewDataItem method_1(GClass32 gclass32_2, RadListView radListView_0)
    {
      ListViewDataItem listViewDataItem = new ListViewDataItem((object) gclass32_2) { Tag = (object) gclass32_2, Group = this.method_11(gclass32_2), ForeColor = Class97.smethod_0((GClass30) gclass32_2) };
      radListView_0.Items.Add(listViewDataItem);
      listViewDataItem[0] = (object) gclass32_2.Name;
      listViewDataItem[1] = (object) gclass32_2.Region;
      listViewDataItem[2] = (object) gclass32_2.Size;
      listViewDataItem[3] = (object) (gclass32_2.Int32_0.ToString() + "%");
      listViewDataItem[4] = gclass32_2.Boolean_3 ? (gclass32_2.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2 ? (object) "Ready" : (object) "Yes") : (object) "No";
      listViewDataItem[5] = gclass32_2.Boolean_2 ? (gclass32_2.Dlc.GEnum2_0 == GEnum2.const_2 ? (object) "Ready" : (object) "Yes") : (object) "No";
      listViewDataItem[6] = (object) gclass32_2.String_0;
      return listViewDataItem;
    }

    private void method_2(GClass30 gclass30_0)
    {
      if (this.TitlesToCopy.Contains(gclass30_0))
        return;
      this.TitlesToCopy.Add(gclass30_0);
      this.lstCopy.Items.Add(new ListViewDataItem((object) gclass30_0)
      {
        Tag = (object) gclass30_0
      });
      this.method_16();
    }

    private void method_3()
    {
      this.DownloadButton.ButtonElement.BorderElement.ForeColor = System.Drawing.Color.Green;
      this.DownloadButton.ButtonElement.BorderElement.Width = 2f;
      if (this.timer_0 == null)
      {
        this.timer_0 = new System.Windows.Forms.Timer() { Interval = 200 };
        this.timer_0.Tick += (EventHandler) ((sender, e) => this.DownloadButton.ButtonElement.BorderElement.Visibility = this.DownloadButton.ButtonElement.BorderElement.Visibility == ElementVisibility.Hidden ? ElementVisibility.Visible : ElementVisibility.Hidden);
        this.timer_0.Start();
      }
      this.timer_0.Start();
    }

    private void method_4()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class163 class163 = new NusGrabberForm.Class163();
      // ISSUE: reference to a compiler-generated field
      class163.nusGrabberForm_0 = this;
      this.float_0 = 0.0f;
      // ISSUE: reference to a compiler-generated field
      class163.int_0 = 1;
      if (this.timer_1 == null)
      {
        this.timer_1 = new System.Windows.Forms.Timer() { Interval = 33 };
        // ISSUE: reference to a compiler-generated method
        this.timer_1.Tick += new EventHandler(class163.method_0);
        this.timer_1.Start();
      }
      this.timer_1.Start();
    }

    private void method_5(ListViewDataItem listViewDataItem_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class164 class164 = new NusGrabberForm.Class164();
      // ISSUE: reference to a compiler-generated field
      class164.listViewDataItem_0 = listViewDataItem_0;
      // ISSUE: reference to a compiler-generated field
      class164.nusGrabberForm_0 = this;
      try
      {
        // ISSUE: reference to a compiler-generated method
        Task.Run(new Action(class164.method_0));
      }
      catch
      {
      }
    }

    private void method_6(GClass30 gclass30_0)
    {
      if (gclass30_0.DiscOnly)
      {
        int num = (int) RadMessageBox.Show("This title has only been released on disc and cannot therefore be downloaded from the eShop servers. You can however download its updates or dlc if applicable.");
      }
      else
      {
        if (!this.TitlesToDownload.Contains(gclass30_0))
        {
          if (gclass30_0.Platform == Platform.Nintendo_DS && Settings.Default.ShowHaxchiWarning)
          {
            if (RadMessageBox.Show("You are trying to add a DS VC game to your download list. DO NOT USE ANY TITLE DOWNLOADED FROM THIS APP TO INSTALL CBHC (Coldboot Hacxhi) OR YOU WILL BRICK ", "Caution!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
              return;
            Settings.Default.ShowHaxchiWarning = false;
            Settings.Default.Save();
          }
          this.TitlesToDownload.Add(gclass30_0);
          ListViewDataItem listViewDataItem_0 = new ListViewDataItem() { Tag = (object) gclass30_0 };
          this.method_5(listViewDataItem_0);
          this.dlQueue.Items.Add(listViewDataItem_0);
          this.method_3();
          this.method_17();
          if (this.CurrentlyDownloading)
            this.gclass80_0.method_3();
          this.method_18();
        }
        GClass32 selectedGame = this.SelectedGame;
        if ((selectedGame != null ? (!selectedGame.method_29(gclass30_0) ? 1 : 0) : 0) != 0)
          return;
        if (gclass30_0 is GClass32)
        {
          this.cmdAddGame.Enabled = false;
        }
        else
        {
          if (!(gclass30_0 is GClass31))
            return;
          this.cmdAddDlc.Enabled = false;
        }
      }
    }

    private void method_7(GClass30 gclass30_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class166 class166 = new NusGrabberForm.Class166();
      // ISSUE: reference to a compiler-generated field
      class166.gclass30_0 = gclass30_0;
      // ISSUE: reference to a compiler-generated field
      this.TitlesToDownload.Remove(class166.gclass30_0);
      // ISSUE: reference to a compiler-generated method
      this.dlQueue.Items.Remove(this.dlQueue.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class166.method_0)));
      this.method_17();
      this.method_18();
      if (this.CurrentlyDownloading)
        this.gclass80_0.method_3();
      this.method_9();
      // ISSUE: reference to a compiler-generated field
      if (this.SelectedGame != null && !this.SelectedGame.method_29(class166.gclass30_0))
        return;
      // ISSUE: reference to a compiler-generated field
      if (class166.gclass30_0 is GClass33)
      {
        this.cmdAddUpdate.Enabled = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (class166.gclass30_0 is GClass31)
          this.cmdAddDlc.Enabled = true;
        else
          this.cmdAddGame.Enabled = true;
      }
    }

    private void method_8(int int_3, GClass133 gclass133_0)
    {
      if (int_3 == 0)
        gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
      else
        gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Visible;
      if (int_3 == this.dlQueue.Items.Count - 1)
        gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
      else
        gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Visible;
    }

    private void method_9()
    {
      foreach (GClass133 gclass133 in this.list_4.ToArray())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class167 class167 = new NusGrabberForm.Class167();
        // ISSUE: reference to a compiler-generated field
        class167.gclass133_0 = gclass133;
        try
        {
          // ISSUE: reference to a compiler-generated method
          int int_3 = this.dlQueue.Items.IndexOf(this.dlQueue.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class167.method_0)));
          if (!this.CurrentlyDownloading)
          {
            // ISSUE: reference to a compiler-generated field
            this.method_8(int_3, class167.gclass133_0);
          }
          else if (int_3 <= this.IndexGameCurrentlyDownloaded)
          {
            // ISSUE: reference to a compiler-generated field
            class167.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
            // ISSUE: reference to a compiler-generated field
            class167.gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
          }
          else if (int_3 == this.IndexGameCurrentlyDownloaded + 1)
          {
            // ISSUE: reference to a compiler-generated field
            class167.gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
            if (int_3 == this.dlQueue.Items.Count - 1)
            {
              // ISSUE: reference to a compiler-generated field
              class167.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              class167.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Visible;
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            this.method_8(int_3, class167.gclass133_0);
          }
        }
        catch
        {
          // ISSUE: reference to a compiler-generated field
          this.list_4.Remove(class167.gclass133_0);
        }
      }
    }

    private void method_10(GClass30 gclass30_0, int int_3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class168 class168 = new NusGrabberForm.Class168();
      // ISSUE: reference to a compiler-generated field
      class168.gclass30_0 = gclass30_0;
      try
      {
        // ISSUE: reference to a compiler-generated method
        int index = this.dlQueue.Items.IndexOf(this.dlQueue.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class168.method_0)));
        object tag = this.dlQueue.Items[index + int_3].Tag;
        this.dlQueue.BeginEdit();
        ListViewDataItem listViewDataItem_0_1 = new ListViewDataItem() { Tag = this.dlQueue.Items[index].Tag };
        this.dlQueue.Items[index + int_3] = listViewDataItem_0_1;
        ListViewDataItem listViewDataItem_0_2 = new ListViewDataItem() { Tag = tag };
        this.dlQueue.Items[index] = listViewDataItem_0_2;
        this.dlQueue.EndEdit();
        this.dlQueue.SelectedIndex = index + int_3;
        this.method_5(listViewDataItem_0_1);
        this.method_5(listViewDataItem_0_2);
        GClass30 gclass30 = this.TitlesToDownload[index + int_3];
        this.TitlesToDownload[index + int_3] = this.TitlesToDownload[index];
        this.TitlesToDownload[index] = gclass30;
        this.method_9();
      }
      catch
      {
      }
    }

    private void dlQueue_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
    {
      if (this.dlQueue.ViewType == ListViewType.DetailsView)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class169 class169 = new NusGrabberForm.Class169();
        // ISSUE: reference to a compiler-generated field
        class169.nusGrabberForm_0 = this;
        // ISSUE: reference to a compiler-generated field
        class169.gclass133_0 = new GClass133();
        // ISSUE: reference to a compiler-generated field
        e.VisualItem = (BaseListViewVisualItem) class169.gclass133_0;
        // ISSUE: reference to a compiler-generated field
        class169.gclass133_0.gclass30_0 = (GClass30) e.DataItem.Tag;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class169.gclass133_0.lightVisualElement_1.Click += new EventHandler(class169.method_0);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class169.gclass133_0.lightVisualElement_0.Click += new EventHandler(class169.method_1);
        // ISSUE: reference to a compiler-generated field
        this.list_4.Add(class169.gclass133_0);
      }
      this.method_9();
    }

    private ListViewDataItemGroup method_11(GClass32 gclass32_2)
    {
      if (gclass32_2.Boolean_1)
        return this.listViewDataItemGroup_4;
      if (gclass32_2.Boolean_5)
        return this.listViewDataItemGroup_2;
      switch (gclass32_2.GEnum2_0)
      {
        case GEnum2.const_0:
          return this.listViewDataItemGroup_3;
        case GEnum2.const_1:
          return this.listViewDataItemGroup_1;
        case GEnum2.const_2:
          return this.listViewDataItemGroup_0;
        default:
          return this.listViewDataItemGroup_3;
      }
    }

    private void chkCopyToSD_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (e.ToggleState == ToggleState.On)
      {
        DriveInfo driveInfo = GClass32.smethod_4(new DataSize(0UL));
        if (driveInfo == null)
          this.chkCopyToSD.Checked = false;
        else
          this.driveInfo_0 = driveInfo;
      }
      else
        this.driveInfo_0 = (DriveInfo) null;
    }

    private void chkDelay_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      this.radDate.Enabled = this.chkDelay.Checked;
    }

    private void chkEUR_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.bool_0)
        return;
      this.method_49();
    }

    private void chkHibernate_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.chkHibernate.Checked)
      {
        this.chkSleep.Checked = false;
        this.chkSleep.Checked = false;
        this.genum10_0 = GEnum10.const_3;
      }
      else
        this.genum10_0 = GEnum10.const_0;
    }

    private void chkJAP_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.bool_0)
        return;
      this.method_49();
    }

    private void chkKOR_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.bool_0)
        return;
      this.method_49();
    }

    private void chkPack_ToggleStateChanging(object sender, StateChangingEventArgs e)
    {
      if (this.chkPack.Checked || GClass6.smethod_2(Settings.Default.ExtractFolder))
        return;
      if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
        Class97.smethod_12(false);
      if (GClass6.smethod_2(Settings.Default.ExtractFolder))
        return;
      e.Cancel = true;
    }

    private void chkPreventShortcut_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.chkPreventShortcut.Checked && !System.IO.File.Exists("NOSHORTCUT"))
        System.IO.File.WriteAllText("NOSHORTCUT", "");
      if (this.chkPreventShortcut.Checked)
        return;
      GClass6.smethod_6("NOSHORTCUT");
    }

    private void chkShowLegit_CheckedChanged(object sender, EventArgs e)
    {
      this.method_49();
    }

    private void chkShowPreviews_CheckedChanged(object sender, EventArgs e)
    {
      this.method_49();
    }

    private void chkShowRednand_CheckedChanged(object sender, EventArgs e)
    {
      this.method_49();
    }

    private void chkShutdown_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.chkShutdown.Checked)
      {
        this.chkSleep.Checked = false;
        this.chkHibernate.Checked = false;
        this.genum10_0 = GEnum10.const_2;
      }
      else
        this.genum10_0 = GEnum10.const_0;
    }

    private void chkSleep_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.chkSleep.Checked)
      {
        this.chkShutdown.Checked = false;
        this.chkHibernate.Checked = false;
        this.genum10_0 = GEnum10.const_1;
      }
      else
        this.genum10_0 = GEnum10.const_0;
    }

    private void chkUnpack_ToggleStateChanging(object sender, StateChangingEventArgs e)
    {
      if (this.chkUnpack.Checked || GClass6.smethod_2(Settings.Default.ExtractFolder))
        return;
      if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
        Class97.smethod_12(false);
      if (GClass6.smethod_2(Settings.Default.ExtractFolder))
        return;
      e.Cancel = true;
    }

    private void chkUSA_CheckStateChanged(object sender, EventArgs e)
    {
      if (this.bool_0)
        return;
      this.method_49();
    }

    private void chkCompactView_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.CompactView = this.chkCompactView.Checked;
      Settings.Default.Save();
      if (this.chkCompactView.Checked)
      {
        this.lstGames.ViewType = ListViewType.DetailsView;
        this.lstGames.FullRowSelect = true;
      }
      else
      {
        this.lstGames.ViewType = ListViewType.IconsView;
        this.lstGames.ItemSize = new Size(170, 64);
      }
      this.lstGames.ItemSpacing = 1;
      this.lstGames.MultiSelect = true;
    }

    private void method_12()
    {
      try
      {
        this.gclass130_0.Exit();
        this.gclass130_0.Dispose();
      }
      catch
      {
      }
    }

    private void cmdAbortAll_Click(object sender, EventArgs e)
    {
      if (!this.CurrentlyDownloading || RadMessageBox.Show("Are you sure you want to abort? The download will pick up where it stopped next time you start it.", "Abort", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.gclass80_0.method_0();
      Thread.Sleep(1000);
      this.method_60((object) this, "--Download aborted--");
    }

    private void cmdAbortDelay_Click(object sender, EventArgs e)
    {
      this.method_59();
      this.method_18();
      this.method_54(true);
    }

    private void cmdAddAllDLCS_Click(object sender, EventArgs e)
    {
      if (RadMessageBox.Show("Caution this will add all available DLCs to the queue for the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
      {
        GClass32 tag = listViewDataItem.Tag as GClass32;
        if (tag.Boolean_2 && tag.Dlc.GEnum2_0 != GEnum2.const_2 && listViewDataItem.Visible)
          this.method_6((GClass30) tag.Dlc);
      }
    }

    private void cmdAddAllUpdates_Click(object sender, EventArgs e)
    {
      if (RadMessageBox.Show("Caution this will add all available updates to the queue for the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      bool flag = RadMessageBox.Show("Should USB Helper also add older versions of updates?", "Add older versions?", MessageBoxButtons.YesNo) == DialogResult.Yes;
      foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
      {
        GClass32 tag = listViewDataItem.Tag as GClass32;
        if (tag.Boolean_3 && listViewDataItem.Visible)
        {
          if (flag)
          {
            foreach (GClass30 gclass30_0 in tag.Updates.Where<GClass33>((Func<GClass33, bool>) (gclass33_0 => gclass33_0.GEnum2_0 != GEnum2.const_2)))
              this.method_6(gclass30_0);
          }
          else if (tag.Updates.Last<GClass33>().GEnum2_0 != GEnum2.const_2)
            this.method_6((GClass30) tag.Updates.Last<GClass33>());
        }
      }
    }

    private void cmdAddDlc_Click(object sender, EventArgs e)
    {
      this.method_6((GClass30) this.SelectedGame.Dlc);
    }

    private void cmdAddGame_Click(object sender, EventArgs e)
    {
      if (this.SelectedGame == null)
        return;
      Image image = this.lstGames.Items.First<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.Tag == this.SelectedGame)).Image;
      if (image != null)
      {
        Point position = Cursor.Position;
        Point client = this.dlQueue.FindForm().PointToClient(this.dlQueue.Parent.PointToScreen(this.dlQueue.Location));
        int num = (int) new frmOverlay(this.Handle, image, position, client).ShowDialog();
        try
        {
          this.soundPlayer_0.Play();
        }
        catch
        {
        }
      }
      this.method_0(this.SelectedGame);
    }

    private void cmdAddUpdate_Click(object sender, EventArgs e)
    {
      FrmSelectVersion frmSelectVersion = new FrmSelectVersion((IEnumerable<GClass33>) this.SelectedGame.Updates, false);
      if (frmSelectVersion.ShowDialog() != DialogResult.OK)
        return;
      foreach (GClass30 gclass30_0 in frmSelectVersion.list_0)
        this.method_6(gclass30_0);
    }

    private void method_13(object sender, EventArgs e)
    {
      new frmBug().Show();
    }

    private void cmdChangeRegion_Click(object sender, EventArgs e)
    {
      Settings.Default.Region = "NONE";
      this.bool_1 = true;
      Settings.Default.Boolean_0 = false;
      Settings.Default.Boolean_2 = false;
      Settings.Default.Boolean_1 = false;
      Settings.Default.Save();
      System.Windows.Forms.Application.Restart();
    }

    private void cmdChangeTheme_Click(object sender, EventArgs e)
    {
      int num = (int) new frmSelectTheme().ShowDialog();
    }

    private void cmdChangeTicket_Click(object sender, EventArgs e)
    {
      Settings.Default.TicketsPath = "";
      Settings.Default.TicketsPath3DS = "";
      Settings.Default.Save();
      System.Windows.Forms.Application.Restart();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this.lstCopy.Items.ToArray<ListViewDataItem>())
        this.method_50(listViewDataItem.Tag as GClass30);
    }

    private void cmdClearCriterias_Click(object sender, EventArgs e)
    {
      this.chkGameGenres.UncheckAllItems();
      this.list_0 = (List<string>) null;
      this.method_21();
      this.method_49();
    }

    private void cmdClearDl_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this.dlQueue.Items.ToArray<ListViewDataItem>())
        this.method_7(listViewDataItem.Tag as GClass30);
    }

    private void cmdClearProxy_Click(object sender, EventArgs e)
    {
      this.method_61();
    }

    private void cmdCopy_Click(object sender, EventArgs e)
    {
      this.method_55(this.SelectedGame);
    }

    private void cmdCopyAll_Click(object sender, EventArgs e)
    {
      if (RadMessageBox.Show("This will add all downloaded content (games,updates and dlc) to the copy queue. Continue?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      foreach (GClass32 gclass32 in this.lstGames.Items.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
      {
        if (gclass32.GEnum2_0 == GEnum2.const_2)
          this.method_2((GClass30) gclass32);
        if (gclass32.Boolean_3)
        {
          foreach (GClass30 gclass30_0 in gclass32.Updates.Where<GClass33>((Func<GClass33, bool>) (gclass33_0 => gclass33_0.GEnum2_0 == GEnum2.const_2)))
            this.method_2(gclass30_0);
        }
        if (gclass32.Boolean_2 && gclass32.Dlc.GEnum2_0 == GEnum2.const_2)
          this.method_2((GClass30) gclass32.Dlc);
      }
      this.toolCopy.Select();
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      this.method_28(this.SelectedGame);
    }

    private void cmdDonate_Click(object sender, EventArgs e)
    {
      int num = (int) new frmDonation().ShowDialog();
    }

    private void cmdAddAllGames_Click(object sender, EventArgs e)
    {
      if (RadMessageBox.Show("Caution this will add to the queue all the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
      {
        GClass32 tag = listViewDataItem.Tag as GClass32;
        if (tag.GEnum2_0 != GEnum2.const_2 && listViewDataItem.Visible)
          this.method_6((GClass30) tag);
      }
    }

    private void cmdGoBack_Click(object sender, EventArgs e)
    {
      this.webBrowser.GoBack();
    }

    private void cmdGoNext_Click(object sender, EventArgs e)
    {
      this.webBrowser.GoForward();
    }

    private void cmdHallOfFame_Click(object sender, EventArgs e)
    {
      int num = (int) new FrmHallOfFame().ShowDialog();
    }

    private void cmdImportGames_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() { Description = "Please select the root folder to scan." };
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      FrmImport frmImport = new FrmImport(folderBrowserDialog.SelectedPath);
      if (frmImport.ShowDialog() != DialogResult.OK)
        return;
      Class97.smethod_15((Form) this, "The games have been imported sucessfuly!");
      this.method_63(true, true, frmImport.list_0);
    }

    private void cmdInitiateCopy_Click(object sender, EventArgs e)
    {
      if (this.lstCopy.Items.Count == 0)
        return;
      DriveInfo driveInfo_0 = GClass32.smethod_4((DataSize) this.lblTotalCopy.Tag);
      if (driveInfo_0 == null)
        return;
      Class97.smethod_4((IEnumerable<GClass30>) this.TitlesToCopy, driveInfo_0, false, true, (Form) this);
      this.method_63(false, true, this.TitlesToCopy.Where<GClass30>((Func<GClass30, bool>) (gclass30_0 => gclass30_0 is GClass32)).Select<GClass30, GClass32>((Func<GClass30, GClass32>) (gclass30_0 => gclass30_0 as GClass32)).ToList<GClass32>());
      this.radButton1_Click((object) null, (EventArgs) null);
    }

    private void cmdLegal_Click(object sender, EventArgs e)
    {
      int num = (int) new frmLegal().ShowDialog();
    }

    private void cmdManageRemoteSd_Click(object sender, EventArgs e)
    {
      if (this.gclass82_0 == null)
        Class97.smethod_16((Form) this);
      else
        Class97.smethod_9(string.Format("ftp://{0}/sd/Install/", (object) this.gclass82_0.IPAddress_0));
    }

    private void cmdPlay_Click(object sender, EventArgs e)
    {
      this.method_42(this.SelectedGame);
    }

    private void cmdPrepareSd_Click(object sender, EventArgs e)
    {
      FrmSelectDrive frmSelectDrive = new FrmSelectDrive(new DataSize(0UL));
      if (frmSelectDrive.ShowDialog() == DialogResult.Cancel)
        return;
      DriveInfo driveInfo0 = frmSelectDrive.driveInfo_0;
      if (driveInfo0.DriveFormat != "FAT32")
      {
        int num1 = (int) RadMessageBox.Show("This drive needs to be formatted to FAT32 before being used on a WiiU. Please try again once you have formatted it");
      }
      else
      {
        GClass27.smethod_10(driveInfo0.Name);
        int num2 = (int) RadMessageBox.Show("SD card prepared!" + Environment.NewLine + "To launch the homebrew channel, open the web browser on your Wii U, go to http://loadiine.ovh and press \"Submit\"");
      }
    }

    private void cmdRefresh_Click(object sender, EventArgs e)
    {
      this.method_51();
    }

    private void cmdRestoreSave_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class170 class170 = new NusGrabberForm.Class170();
      if (this.gclass82_0 == null)
      {
        Class97.smethod_16((Form) this);
      }
      else
      {
        frmChoseSave frmChoseSave = new frmChoseSave(this.SelectedGame);
        if (frmChoseSave.ShowDialog() != DialogResult.OK)
          return;
        // ISSUE: reference to a compiler-generated field
        class170.frmWait_0 = new FrmWait("Please wait while USB Helper uploads your save.", false);
        // ISSUE: reference to a compiler-generated method
        Task.Run<DialogResult>(new Func<DialogResult>(class170.method_0));
        try
        {
          this.SelectedGame.method_26(this.gclass82_0, frmChoseSave.saveDescription_0.Timestamp);
        }
        catch (Exception ex)
        {
          // ISSUE: reference to a compiler-generated field
          class170.frmWait_0.method_0();
          Class97.smethod_15((Form) this, ex.Message);
          return;
        }
        // ISSUE: reference to a compiler-generated field
        class170.frmWait_0.method_0();
      }
    }

    private void cmdSearchWithCriterias_Click(object sender, EventArgs e)
    {
      if (this.chkGameGenres.CheckedItems.Count == 0)
        return;
      this.list_0 = new List<string>();
      int num;
      FrmWait frmWait = new FrmWait("USB Helper is looking for your games...", (Action) (() =>
      {
        try
        {
          string[] strArray = new string[3]{ "US", "GB", "JP" };
          foreach (object obj in strArray)
          {
            string string_0 = string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/titles?limit=1000&", obj);
            foreach (ListViewDataItem checkedItem in (ReadOnlyCollection<ListViewDataItem>) this.chkGameGenres.CheckedItems)
              string_0 += string.Format("genre[]={0}&", (object) (uint) checkedItem.Tag);
            Encoding utF8 = Encoding.UTF8;
            byte[] bytes = new GClass78() { bool_0 = true }.method_4(string_0, 24);
            foreach (GClass109 gclass109 in JsonConvert.DeserializeObject<GClass111>(utF8.GetString(bytes)).Contents.Content)
              this.list_0.Add(gclass109.Title.Id.ToString());
          }
        }
        catch
        {
        }
      }), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
      this.method_21();
      this.method_49();
    }

    private void method_14(object sender, EventArgs e)
    {
      new frmChangeLog().Show();
    }

    private void cmdSendWiiu_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class171 class171 = new NusGrabberForm.Class171();
      // ISSUE: reference to a compiler-generated field
      class171.nusGrabberForm_0 = this;
      if (this.lstCopy.Items.Count == 0)
        return;
      if (this.gclass82_0 == null)
      {
        Class97.smethod_16((Form) this);
      }
      else
      {
        Class60.bool_0 = true;
        // ISSUE: reference to a compiler-generated field
        class171.string_0 = "";
        string string_0 = "--COPY REPORT--" + Environment.NewLine;
        bool bool_7 = RadMessageBox.Show("Should the titles be installed automatically once the transfer is complete?", "Install", MessageBoxButtons.YesNo) == DialogResult.Yes;
        bool? nullable_0 = new bool?();
        if (this.gclass82_0.TransferVersion > 10)
          nullable_0 = new bool?(RadMessageBox.Show("Should the titles be removed automatically from the SD once the installation is complete?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes);
        int num1 = 0;
        foreach (GClass30 gclass30 in this.TitlesToCopy)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          NusGrabberForm.Class172 class172 = new NusGrabberForm.Class172();
          // ISSUE: reference to a compiler-generated field
          class172.class171_0 = class171;
          // ISSUE: reference to a compiler-generated field
          class172.gclass30_0 = gclass30;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          NusGrabberForm.Class173 class173 = new NusGrabberForm.Class173();
          // ISSUE: reference to a compiler-generated field
          class173.class172_0 = class172;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class173.class172_0.gclass30_0.System != GEnum3.const_1)
            return;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class173.frmFtpProgress_0 = new FrmFtpProgress(class173.class172_0.gclass30_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class173.class172_0.gclass30_0.Event_1 += new EventHandler<GEventArgs0>(class173.method_0);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class173.class172_0.gclass30_0.Event_0 += new EventHandler<GClass81>(class173.method_1);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class173.frmFtpProgress_0.Event_0 += new EventHandler(class173.class172_0.method_0);
          Thread.Sleep(1000);
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class173.class172_0.gclass30_0.method_18(false, this.gclass82_0, bool_7, nullable_0);
          // ISSUE: reference to a compiler-generated field
          int num2 = (int) class173.frmFtpProgress_0.ShowDialog();
          if (++num1 < this.TitlesToCopy.Count & bool_7)
          {
            this.gclass82_0 = (GClass82) null;
            int num3;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            FrmWait frmWait = new FrmWait("USB Helper is waiting for the installation to complete...", class173.class172_0.class171_0.action_0 ?? (class173.class172_0.class171_0.action_0 = new Action(class173.class172_0.class171_0.method_0)), (Action<Exception>) (exception_0 => num3 = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class173.class172_0.class171_0.string_0 == "OK" && class173.class172_0.gclass30_0 is GClass32)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            (class173.class172_0.gclass30_0 as GClass32).Boolean_5 = true;
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          string_0 += string.Format("-{0} : {1} {2}", (object) class173.class172_0.gclass30_0, (object) class173.class172_0.class171_0.string_0, (object) Environment.NewLine);
        }
        Class97.smethod_15((Form) this, string_0);
        this.gclass82_0 = (GClass82) null;
        this.method_63(false, true, (List<GClass32>) null);
        this.radButton1_Click((object) null, (EventArgs) null);
        Class60.bool_0 = false;
      }
    }

    private void cmdSetProxy_Click(object sender, EventArgs e)
    {
      try
      {
        Uri uri = new Uri(this.txtProxyUrl.Text);
        NetworkCredential networkCredential = new NetworkCredential(this.txtProxyUsr.Text, this.txtProxyPassword.Text);
        WebProxy webProxy = new WebProxy() { Address = uri, Credentials = (ICredentials) networkCredential, UseDefaultCredentials = true };
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("https://www.google.com");
        httpWebRequest.Proxy = (IWebProxy) webProxy;
        httpWebRequest.Timeout = 5000;
        httpWebRequest.Method = "GET";
        using (httpWebRequest.GetResponse())
          this.Proxy = webProxy;
        this.lblproxyStatus.Text = "Set";
        this.lblproxyStatus.ForeColor = System.Drawing.Color.Green;
      }
      catch (Exception ex)
      {
        this.method_61();
        int num = (int) RadMessageBox.Show(ex.Message);
      }
    }

    private void cmdShortcut_Click(object sender, EventArgs e)
    {
      GClass128.smethod_0(this.SelectedGame);
    }

    private void cmdSugegstIdea_Click(object sender, EventArgs e)
    {
      int num = (int) new frmFeedback().ShowDialog();
    }

    private void method_15()
    {
      Task.Run((Action) (() =>
      {
        try
        {
          this.ulong_0 = 0UL;
          string str1 = Path.Combine(Settings.Default.Path, "DATA");
          string str2 = Path.Combine(Settings.Default.Path, "DATA_3DS");
          if (Directory.Exists(str1))
            this.ulong_0 += GClass6.smethod_7(str1);
          if (Directory.Exists(str2))
            this.ulong_0 += GClass6.smethod_7(str2);
          if (this.ulong_0 != 0UL)
            return;
          ++this.ulong_0;
        }
        catch
        {
        }
      }));
    }

    private void method_16()
    {
      DataSize dataSize = this.lstCopy.Items.Aggregate<ListViewDataItem, DataSize>(new DataSize(0UL), (Func<DataSize, ListViewDataItem, DataSize>) ((dataSize_0, listViewDataItem_0) => dataSize_0 + (listViewDataItem_0.Tag as GClass30).Size));
      this.lblTotalCopy.Text = dataSize.ToString();
      this.lblTotalCopy.Tag = (object) dataSize;
    }

    private void method_17()
    {
      DataSize dataSize_0_1 = this.dlQueue.Items.Aggregate<ListViewDataItem, DataSize>(new DataSize(0UL), (Func<DataSize, ListViewDataItem, DataSize>) ((dataSize_0, listViewDataItem_0) => dataSize_0 + (listViewDataItem_0.Tag as GClass30).Size));
      this.lblTotalDl.Text = dataSize_0_1.ToString();
      this.lblTotalDl.Text += string.Format(" (Download time : {0})", (object) GClass6.smethod_13(dataSize_0_1, new GStruct3(Settings.Default.MeasuredSpeed)));
    }

    private void method_18()
    {
      this.DownloadButton.Enabled = this.dlQueue.Items.Count > 0 && !this.CurrentlyDownloading;
      if (!this.DownloadButton.Enabled)
      {
        System.Windows.Forms.Timer timer0 = this.timer_0;
        if (timer0 == null)
          return;
        timer0.Stop();
      }
      else
      {
        System.Windows.Forms.Timer timer0 = this.timer_0;
        if (timer0 == null)
          return;
        timer0.Start();
      }
    }

    private void dlQueue_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
    {
      if (this.CurrentlyDownloading && this.dlQueue.SelectedIndex <= this.IndexGameCurrentlyDownloaded)
      {
        int num = (int) RadMessageBox.Show("You cannot remove this game while downloading. Please abort first.");
      }
      else
        this.method_7(e.Item.Tag as GClass30);
    }

    private void DownloadButton_Click(object sender, EventArgs e)
    {
      this.method_44();
    }

    private void method_19(object object_0, GClass81 gclass81_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class174 class174 = new NusGrabberForm.Class174();
      // ISSUE: reference to a compiler-generated field
      class174.gclass81_0 = gclass81_0;
      // ISSUE: reference to a compiler-generated field
      class174.nusGrabberForm_0 = this;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class174.method_0));
      }
      catch
      {
      }
    }

    private byte[] method_20(string string_4)
    {
      string path = Path.Combine(NusGrabberForm.string_2, GClass88.smethod_8(string_4));
      if (GClass6.smethod_3(string_4))
      {
        this.bool_5 = string_4.Contains("wiiu.titlekeys");
        this.bool_4 = string_4.Contains("3ds.titlekeys");
        this.bool_6 = string_4.Contains("wii.titlekeys");
        GClass78 gclass78 = new GClass78();
        try
        {
          byte[] bytes = this.bool_5 || this.bool_4 || this.bool_6 ? gclass78.method_4(string_4 + "json", 2) : gclass78.method_2(string_4);
          Directory.CreateDirectory(NusGrabberForm.string_2);
          System.IO.File.WriteAllBytes(path, bytes);
          return bytes;
        }
        catch
        {
          if (System.IO.File.Exists(path))
          {
            Class97.smethod_15((Form) this, string.Format("There was an error while trying to fetch the title keys from {0}. Wii U USB Helper will now try to use a backup version. Please note that some features might now work as expected.", (object) string_4));
            return System.IO.File.ReadAllBytes(path);
          }
          Class97.smethod_15((Form) this, string.Format("There was an error while trying to fetch the title keys from {0} (the site is probably down). No backup was found. Unfortunately the app cannot work without it.", (object) string_4));
          return (byte[]) null;
        }
      }
      else
      {
        if (!System.IO.File.Exists(string_4))
          return (byte[]) null;
        try
        {
          return System.IO.File.ReadAllBytes(string_4);
        }
        catch
        {
          return (byte[]) null;
        }
      }
    }

    private void method_21()
    {
      this.bool_0 = false;
      this.lstGames.FilterDescriptors.Clear();
      this.lstGames.FilterPredicate = new Predicate<ListViewDataItem>(this.method_57);
      this.lstGames.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, (object) this.FTSearchBox.Text));
    }

    private void timer_2_Tick(object sender, EventArgs e)
    {
      this.method_49();
      this.timer_2.Stop();
    }

    private void FTSearchBox_TextChanged(object sender, EventArgs e)
    {
      this.lstGames.smethod_1(true);
      this.timer_2.Stop();
      this.timer_2.Start();
    }

    private void method_22(GClass74 gclass74_0, GClass32 gclass32_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class175 class175 = new NusGrabberForm.Class175();
      // ISSUE: reference to a compiler-generated field
      class175.nusGrabberForm_0 = this;
      // ISSUE: reference to a compiler-generated field
      class175.gclass74_0 = gclass74_0;
      // ISSUE: reference to a compiler-generated field
      class175.gclass32_0 = gclass32_2;
      try
      {
        if (this.IsDisposed)
          return;
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class175.method_0));
      }
      catch
      {
      }
    }

    private NusGrabberForm.Class161 method_23()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class176 class176 = new NusGrabberForm.Class176();
      // ISSUE: reference to a compiler-generated field
      class176.nusGrabberForm_0 = this;
      if (Settings.Default.TicketsPath.Contains("wiiu.titlekeys.com"))
        Settings.Default.TicketsPath = "http://wiiu.titlekeys.gq/";
      if (Settings.Default.TicketsPath3DS.Contains("3ds.titlekeys.com"))
        Settings.Default.TicketsPath3DS = "http://3ds.titlekeys.gq/";
      // ISSUE: reference to a compiler-generated field
      class176.byte_0 = (byte[]) null;
      // ISSUE: reference to a compiler-generated field
      class176.byte_1 = (byte[]) null;
      // ISSUE: reference to a compiler-generated field
      class176.byte_2 = (byte[]) null;
      int num1;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait1 = new FrmWait("USB Helper is fetching the title keys.", new Action(class176.method_0), (Action<Exception>) (exception_0 => num1 = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      while (class176.byte_0 == null && (class176.byte_1 == null && class176.byte_2 == null))
      {
        FrmAskTicket frmAskTicket = new FrmAskTicket();
        if (frmAskTicket.ShowDialog() == DialogResult.OK)
        {
          Settings.Default.TicketsPath = frmAskTicket.FileLocationWiiU;
          Settings.Default.TicketsPath3DS = frmAskTicket.FileLocation3DS;
          Settings.Default.TicketsPathWii = frmAskTicket.FileLocationWii;
          int num2;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          FrmWait frmWait2 = new FrmWait("USB Helper is fetching the title keys.", class176.action_0 ?? (class176.action_0 = new Action(class176.method_1)), (Action<Exception>) (exception_0 => num2 = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
        }
        else
          break;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return new NusGrabberForm.Class161() { WiiU = class176.byte_0, Byte_0 = class176.byte_1, Wii = class176.byte_2 };
    }

    private void method_24()
    {
      this.lblStorageLocation.Text = string.Format("<html>The content is stored in <span style=\"color: #ff8000\">{0}</span>. <strong>DATA</strong> contains Wii U and Emulation data, <strong>DATA_3DS</strong> contains 3DS data.<br> <span>Manually extracted games will go in : <span style=\"color: #ff8000\">{1}</span><br></html>", (object) Settings.Default.Path, (object) Settings.Default.ExtractFolder);
    }

    private void method_25(byte[] byte_0, byte[] byte_1, byte[] byte_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class177 class177 = new NusGrabberForm.Class177();
      // ISSUE: reference to a compiler-generated field
      class177.nusGrabberForm_0 = this;
      this.timer_6.Stop();
      // ISSUE: reference to a compiler-generated method
      GClass89.Event_0 += new EventHandler(class177.method_0);
      GClass89.smethod_0(Settings.Default.LaunchCount, Settings.Default.DonationKey, Class123.keysPub);
      ++Settings.Default.LaunchCount;
      Settings.Default.Save();
      this.frmWait = new FrmWait("Now loading...", true);
      // ISSUE: reference to a compiler-generated method
      Task.Run<DialogResult>(new Func<DialogResult>(class177.method_1));
      try
      {
        this.frmWait.method_2(10);
        string string_3 = ApplicationDeployment.IsNetworkDeployed ? "CLICKONCE" : "UPDATER";
        string string_5 = ApplicationDeployment.IsNetworkDeployed ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : Class102.string_0;
        string string_4 = "NONE";
        try
        {
          string_4 = new ComputerInfo().OSFullName;
        }
        catch
        {
        }
        GClass26.smethod_0(Settings.Default.Path, NusGrabberForm.string_2, Settings.Default.TicketsPath, Settings.Default.TicketsPath3DS, "wiiuusbhelper.com", "https://registration.wiiuusbhelper.com", this.bool_5 || this.bool_4 || this.bool_6, byte_0, byte_1, byte_2, new GStruct2(string_3, string_4, string_5), (Action<int>) null);
        this.frmWait.method_2(60);
      }
      catch (Exception ex)
      {
        int num = (int) RadMessageBox.Show(ex.ToString());
        System.Windows.Forms.Application.Exit();
        return;
      }
      this.cmdRefresh.Enabled = this.bool_5 || this.bool_4 || this.bool_6;
      this.dlQueue.Items.Clear();
      try
      {
        this.lstGames.BeginUpdate();
        this.lstGames.FilterDescriptors.Clear();
        this.lstGames.FilterPredicate = (Predicate<ListViewDataItem>) null;
        this.lstGames.Items.Clear();
        this.lstGames.EndUpdate();
      }
      catch
      {
      }
      Settings.Default.Save();
      this.lstGames.EnableCustomGrouping = true;
      this.lstGames.ShowGroups = true;
      this.lstGames.EnableFiltering = true;
      this.lstGames.EnableSorting = true;
      this.lstGames.EnableColumnSort = true;
      this.lstGames.BeginUpdate();
      // ISSUE: reference to a compiler-generated field
      class177.frmWait_0 = new FrmWait("USB HELPER is retrieving the latest metadata", true);
      // ISSUE: reference to a compiler-generated method
      Task.Run<DialogResult>(new Func<DialogResult>(class177.method_2));
      int num1 = 0;
      int num2 = -1;
      int count = GClass28.dictionary_0.Values.Count;
      foreach (GClass32 gclass32_2 in (IEnumerable<GClass32>) GClass28.dictionary_0.Values.OrderByDescending<GClass32, bool>((Func<GClass32, bool>) (gclass32_0 => gclass32_0.Boolean_4)).ThenBy<GClass32, string>((Func<GClass32, string>) (gclass32_0 => gclass32_0.Name)))
      {
        this.method_1(gclass32_2, this.lstGames);
        int int_5 = (int) ((double) num1++ / (double) count * 100.0);
        if (int_5 > num2)
        {
          num2 = int_5;
          // ISSUE: reference to a compiler-generated field
          class177.frmWait_0.method_2(int_5);
        }
      }
      // ISSUE: reference to a compiler-generated field
      class177.frmWait_0.method_0();
      this.lstGames.EndUpdate();
      this.method_52();
      Class97.smethod_3();
      new Thread(new ThreadStart(this.method_43))
      {
        IsBackground = true
      }.Start();
      Thread.Sleep(75);
      this.frmWait.method_2(100);
      this.chkSuperSpeed.Checked = Settings.Default.EnableSuperSpeed;
      this.chkShowPreviews.Checked = Settings.Default.ShowEvents;
      this.chkShowLegit.Checked = Settings.Default.ShowLegit;
      this.chkDisableSpeedGraph.Checked = !Settings.Default.ShowSpeedGraph;
      this.chkShowRednand.Checked = Settings.Default.ShowCFW;
      this.chkForceGameMode.Checked = Settings.Default.ForceGameMode;
      this.chkPreventShortcut.Checked = System.IO.File.Exists("NOSHORTCUT");
      this.chkNotifyChat.Checked = Settings.Default.ChatNotifications;
      this.radioGameRoom.IsChecked = Settings.Default.GameSpecificRoom;
      this.radioLobby.IsChecked = !Settings.Default.GameSpecificRoom;
      this.frmWait.method_0();
      this.smethod_0(false, (Image) Class123.logo_horiz);
      this.method_26();
      this.method_27();
      this.method_24();
      string region = Settings.Default.Region;
      if (!(region == "EUR"))
      {
        if (!(region == "JPN"))
        {
          if (region == "USA")
            Settings.Default.Boolean_2 = true;
        }
        else
          Settings.Default.Boolean_1 = true;
      }
      else
        Settings.Default.Boolean_0 = true;
      this.bool_0 = true;
      this.chkEUR.Checked = Settings.Default.Boolean_0;
      this.chkJAP.Checked = Settings.Default.Boolean_1;
      this.chkUSA.Checked = Settings.Default.Boolean_2;
      this.chkKOR.Checked = Settings.Default.Boolean_3;
      this.method_49();
      foreach (ListViewDataItemGroup group in this.lstGames.Groups)
      {
        try
        {
          ListViewDataItem listViewDataItem = group.Items.First<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.Visible));
          this.lstGames.ListViewElement.EnsureItemVisible(listViewDataItem);
          this.lstGames.SelectedItem = listViewDataItem;
          break;
        }
        catch
        {
        }
      }
      this.chkCompactView.Checked = Settings.Default.CompactView;
      Task.Run((Action) (() => Class97.smethod_18()));
      this.method_15();
      if (Settings.Default.Show552Warning)
      {
        Settings.Default.Show552Warning = false;
        Settings.Default.Save();
        if (RadMessageBox.Show("Thank you for using Wii U USB Helper! A new Wii U update (5.5.2) has been released. It is strongly advised NOT TO update. Would you like to see how to prevent your console from updating?", "New update!", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
        Process.Start("https://github.com/FlimFlam69/WiiUTutorial/wiki/1:-Blocking-Updates-From-Nintendo");
      }
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Interval = 4000;
      // ISSUE: reference to a compiler-generated method
      timer.Tick += new EventHandler(class177.method_3);
      timer.Start();
      GClass83 gclass83 = new GClass83();
      // ISSUE: reference to a compiler-generated method
      gclass83.Event_0 += new EventHandler<GClass82>(class177.method_4);
      gclass83.method_0(true);
      if (Settings.Default.ForceGameMode)
        this.method_47();
      GClass128.smethod_1();
      this.timer_6.Start();
    }

    private void method_26()
    {
      if (!GClass28.NewTitles.Any<GClass32>())
        return;
      FrmNewTitles frmNewTitles = new FrmNewTitles((IEnumerable<GClass30>) GClass28.NewTitles, "New titles have been added! Please choose the ones you wish to download.");
      if (frmNewTitles.ShowDialog() != DialogResult.OK)
        return;
      foreach (GClass30 gclass30 in frmNewTitles.list_0)
        this.method_0(gclass30 as GClass32);
    }

    private void method_27()
    {
      if (!GClass28.NewUpdates.Any<GClass33>())
        return;
      FrmNewTitles frmNewTitles = new FrmNewTitles((IEnumerable<GClass30>) GClass28.NewUpdates, "New titles have been added! Please choose the ones you wish to download.");
      if (frmNewTitles.ShowDialog() != DialogResult.OK)
        return;
      foreach (GClass30 gclass30_0 in frmNewTitles.list_0)
        this.method_6(gclass30_0);
    }

    private void method_28(GClass32 gclass32_2)
    {
      if (gclass32_2.Boolean_1)
      {
        frmRawOrEmu frmRawOrEmu = new frmRawOrEmu();
        if (frmRawOrEmu.ShowDialog() == DialogResult.OK)
        {
          if (frmRawOrEmu.bool_0)
          {
            this.method_56(gclass32_2);
          }
          else
          {
            int num = (int) new frmEmuInfo(gclass32_2).ShowDialog();
          }
        }
      }
      else
        this.method_56(gclass32_2);
      this.method_63(false, true, this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToList<GClass32>());
    }

    private void method_29(List<GClass30> list_5)
    {
      this.IndexGameCurrentlyDownloaded = -1;
      try
      {
        this.chartValues_0.Clear();
      }
      catch
      {
      }
      GClass80 gclass80 = new GClass80(this.Proxy, true, true);
      this.gclass80_0 = gclass80;
      this.gclass80_0.method_4((ulong) this.radMaxSpeed.Value * 1000UL);
      this.CurrentlyDownloading = true;
      gclass80.Event_6 += new EventHandler<GEventArgs0>(this.method_46);
      gclass80.Event_3 += new EventHandler<string>(this.method_60);
      gclass80.Event_4 += (EventHandler<GClass79>) ((object_0, gclass79_0) =>
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class178 class178 = new NusGrabberForm.Class178();
        // ISSUE: reference to a compiler-generated field
        class178.nusGrabberForm_0 = this;
        // ISSUE: reference to a compiler-generated field
        class178.gclass79_0 = gclass79_0;
        try
        {
          // ISSUE: reference to a compiler-generated method
          this.Invoke((Delegate) new Action(class178.method_0));
        }
        catch
        {
        }
      });
      gclass80.Event_5 += new EventHandler<GClass81>(this.method_19);
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.gclass80_0.Event_0 += (EventHandler<bool>) ((object_0, bool_9) => this.Invoke((Delegate) new Action(new NusGrabberForm.Class179()
      {
        nusGrabberForm_0 = this,
        bool_0 = bool_9
      }.method_0)));
      this.toolDownload.Image = (Image) Class123.dlTabGif;
      gclass80.method_1(list_5, 100, 10000);
    }

    private void method_30()
    {
      GClass95 gclass95_0 = this.SelectedGame.method_14(true);
      if (gclass95_0 == null)
      {
        int num1 = (int) RadMessageBox.Show("Unfortunately emulation is not yet implemented for this title.");
      }
      else
      {
        try
        {
          this.SelectedGame.method_13(gclass95_0);
        }
        catch (Exception ex)
        {
          int num2 = (int) RadMessageBox.Show(ex.Message);
        }
      }
    }

    private void method_31(object sender, EventArgs e)
    {
      this.smethod_0(true, (Image) Class123.logo_horiz);
      Class97.smethod_2();
      NusGrabberForm.Class161 class161 = this.method_23();
      bool flag = true;
      while (((class161.WiiU != null || class161.Byte_0 != null ? 0 : (class161.Wii == null ? 1 : 0)) & (flag ? 1 : 0)) != 0)
      {
        if (RadMessageBox.Show("The application could not retrieve the ticket archive from the specified location. Would you like to specify another one?", "Tickets", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          class161 = this.method_23();
        }
        else
        {
          int num = (int) RadMessageBox.Show("This application cannot work without a ticket archive.");
          flag = false;
        }
      }
      if (flag)
        this.method_25(class161.WiiU, class161.Byte_0, class161.Wii);
      else
        this.Close();
    }

    private void lstCopy_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
    {
      this.method_50(e.Item.Tag as GClass30);
    }

    private void lstGames_ItemMouseUp(object sender, ListViewItemMouseEventArgs e)
    {
      if (e.OriginalEventArgs.Button != MouseButtons.Right)
        return;
      GClass32 tag = e.Item.Tag as GClass32;
      if (tag == null)
        return;
      if (this.lstGames.SelectedItems.Count < 2)
        this.lstGames.SelectedItem = e.Item;
      if (this.lstGames.SelectedItems.Count == 0)
        return;
      IEnumerable<GClass32> source1 = this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32));
      IEnumerable<GClass32> source2 = source1;
      Func<GClass32, bool> func1 = (Func<GClass32, bool>) (gclass32_0 => gclass32_0.System == GEnum3.const_1);
      Func<GClass32, bool> predicate1;
      if (source2.All<GClass32>(predicate1))
      {
        this.radContextMenu_0.Items[7].Text = "Unpack (Loadiine)";
      }
      else
      {
        IEnumerable<GClass32> source3 = source1;
        Func<GClass32, bool> func2 = (Func<GClass32, bool>) (gclass32_0 => gclass32_0.System == GEnum3.const_0);
        Func<GClass32, bool> predicate2;
        if (source3.All<GClass32>(predicate2))
          this.radContextMenu_0.Items[7].Text = "Pack to CIA (3DS)";
        else
          this.radContextMenu_0.Items[7].Text = "Unpack Wii U titles and pack 3DS titles";
      }
      this.radContextMenu_0.Items[1].Enabled = tag.Boolean_3 && this.lstGames.SelectedItems.Count == 1;
      this.radContextMenu_0.Items[2].Enabled = tag.Boolean_2 && this.lstGames.SelectedItems.Count == 1;
      this.radContextMenu_0.Items[11].Enabled = !source1.Any<GClass32>((Func<GClass32, bool>) (gclass32_0 => gclass32_0.System != GEnum3.const_1));
      RadContextMenu radContextMenu0 = this.radContextMenu_0;
      int x1 = e.OriginalEventArgs.X;
      Point location = this.Location;
      int x2 = location.X;
      int num1 = x1 + x2;
      location = this.lstGames.Location;
      int x3 = location.X;
      int x4 = num1 + x3;
      int y1 = e.OriginalEventArgs.Y;
      location = this.Location;
      int y2 = location.Y;
      int num2 = y1 + y2;
      location = this.lstGames.Location;
      int y3 = location.Y;
      int y4 = num2 + y3 + 150;
      radContextMenu0.Show(x4, y4);
    }

    private void lstGames_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Escape)
        return;
      this.lstGames.SelectedItems.Clear();
    }

    private void lstGames_SelectedItemChanged(object sender, EventArgs e)
    {
      GClass32 tag = this.lstGames.SelectedItem?.Tag as GClass32;
      if (tag == null)
        return;
      this.SelectedGame = tag;
      this.method_65();
    }

    private void lstGames_SizeChanged(object sender, EventArgs e)
    {
      this.lstGames.Columns[0].Width = (float) (this.lstGames.Width - 20) - (this.lstGames.Columns.Sum<ListViewDetailColumn>((Func<ListViewDetailColumn, float>) (listViewDetailColumn_0 => listViewDetailColumn_0.Width)) - this.lstGames.Columns[0].Width);
    }

    private void method_32(object sender, ListViewItemEventArgs e)
    {
      if (this.bool_0)
        return;
      this.method_49();
    }

    private void method_33(GClass32 gclass32_2, bool bool_9, bool bool_10 = true)
    {
      gclass32_2.Boolean_5 = bool_9;
      if (!bool_10)
        return;
      this.method_63(false, true, (List<GClass32>) null);
    }

    private void NusGrabberForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.bool_2)
        this.method_12();
      try
      {
        Settings.Default.ShowCFW = this.chkShowRednand.Checked;
        Settings.Default.ShowLegit = this.chkShowLegit.Checked;
        Settings.Default.ShowEvents = this.chkShowPreviews.Checked;
        if (!this.bool_1)
        {
          Settings.Default.Boolean_0 = this.chkEUR.Checked;
          Settings.Default.Boolean_1 = this.chkJAP.Checked;
          Settings.Default.Boolean_2 = this.chkUSA.Checked;
          Settings.Default.Boolean_3 = this.chkKOR.Checked;
        }
        Settings.Default.Platforms = string.Join<int>(",", (IEnumerable<int>) this.Platforms.Select<Platform, int>((Func<Platform, int>) (platform_0 => (int) platform_0)).ToArray<int>());
        Settings.Default.Save();
        this.method_53();
        GClass30.smethod_1();
      }
      catch
      {
      }
    }

    private void method_34(GClass82 gclass82_1)
    {
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class180 class180 = new NusGrabberForm.Class180();
        // ISSUE: reference to a compiler-generated field
        class180.nusGrabberForm_0 = this;
        if (Class60.bool_0)
          return;
        // ISSUE: reference to a compiler-generated field
        class180.list_0 = GClass83.smethod_0(gclass82_1);
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new MethodInvoker(class180.method_0));
        // ISSUE: reference to a compiler-generated field
        if (class180.list_0.Count == 0)
          return;
        // ISSUE: reference to a compiler-generated field
        class180.list_1 = new List<GClass33>();
        // ISSUE: reference to a compiler-generated field
        foreach (GClass32 gclass32 in class180.list_0.Where<GClass32>((Func<GClass32, bool>) (gclass32_0 => gclass32_0.Boolean_3)))
        {
          if (GClass83.smethod_1(gclass82_1, (GClass30) gclass32) < int.Parse(gclass32.Updates.Last<GClass33>().Version))
          {
            // ISSUE: reference to a compiler-generated field
            class180.list_1.Add(gclass32.Updates.Last<GClass33>());
          }
        }
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new MethodInvoker(class180.method_1));
      }
      catch
      {
      }
      this.dateTime_0 = DateTime.Now;
    }

    private void method_35()
    {
      LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart();
      cartesianChart.Dock = DockStyle.Fill;
      this.cartesianChart_0 = cartesianChart;
      Charting.For<GClass125>((object) Mappers.Xy<GClass125>().X((Func<GClass125, double>) (gclass125_0 => (double) gclass125_0.DateTime.Ticks)).Y((Func<GClass125, double>) (gclass125_0 => gclass125_0.Speed)), SeriesOrientation.All);
      this.chartValues_0 = new ChartValues<GClass125>();
      LiveCharts.WinForms.CartesianChart cartesianChart0 = this.cartesianChart_0;
      SeriesCollection seriesCollection = new SeriesCollection();
      LineSeries lineSeries = new LineSeries();
      lineSeries.Values = (IChartValues) this.chartValues_0;
      lineSeries.PointGeometrySize = 1.0;
      lineSeries.StrokeThickness = 1.0;
      lineSeries.Title = "Download Speed (MB/s)";
      SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb((byte) 75, (byte) 200, (byte) 113, (byte) 55));
      solidColorBrush.Opacity = 50.0;
      lineSeries.Fill = (System.Windows.Media.Brush) solidColorBrush;
      lineSeries.Stroke = (System.Windows.Media.Brush) System.Windows.Media.Brushes.Orange;
      seriesCollection.Add((ISeriesView) lineSeries);
      cartesianChart0.Series = seriesCollection;
      this.cartesianChart_0.AxisX.Add(new Axis()
      {
        DisableAnimations = true,
        LabelFormatter = (Func<double, string>) (double_0 => new DateTime((long) double_0).ToString("mm:ss")),
        Separator = new Separator()
        {
          Step = (double) TimeSpan.FromSeconds(5.0).Ticks
        }
      });
      this.cartesianChart_0.AxisY.Add(new Axis()
      {
        DisableAnimations = true,
        MinValue = 0.0
      });
      this.method_36(DateTime.Now);
      this.radLiveSpeed.Controls.Add((Control) this.cartesianChart_0);
    }

    private void method_36(DateTime dateTime_2)
    {
      this.cartesianChart_0.AxisX[0].MaxValue = (double) dateTime_2.Ticks;
      this.cartesianChart_0.AxisX[0].MinValue = (double) (dateTime_2.Ticks - TimeSpan.FromSeconds(15.0).Ticks);
    }

    private void method_37()
    {
      this.radContextMenu_0.Items[0].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_2 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
          this.method_0(gclass32_2);
      });
      this.radContextMenu_0.Items[1].Click += (EventHandler) ((sender, e) =>
      {
        FrmSelectVersion frmSelectVersion = new FrmSelectVersion((IEnumerable<GClass33>) (this.lstGames.SelectedItems[0].Tag as GClass32).Updates, false);
        if (frmSelectVersion.ShowDialog() != DialogResult.OK)
          return;
        foreach (GClass30 gclass30_0 in frmSelectVersion.list_0)
          this.method_6(gclass30_0);
      });
      this.radContextMenu_0.Items[2].Click += (EventHandler) ((sender, e) => this.method_6((GClass30) (this.lstGames.SelectedItems[0].Tag as GClass32).Dlc));
      this.radContextMenu_0.Items[3].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_2 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
          this.method_55(gclass32_2);
      });
      this.radContextMenu_0.Items[4].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_2 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToArray<GClass32>())
          this.method_28(gclass32_2);
      });
      this.radContextMenu_0.Items[5].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_2 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToArray<GClass32>())
          this.method_33(gclass32_2, true, false);
        this.method_65();
        this.method_63(false, true, this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToList<GClass32>());
      });
      this.radContextMenu_0.Items[6].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_2 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToArray<GClass32>())
          this.method_33(gclass32_2, false, false);
        this.method_65();
        this.method_63(false, true, this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToList<GClass32>());
      });
      this.radContextMenu_0.Items[7].Click += (EventHandler) ((sender, e) =>
      {
        if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
          Class97.smethod_12(false);
        if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
        {
          Class97.smethod_15((Form) this, "Operation aborted.");
        }
        else
        {
          foreach (GClass32 gclass32_1 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
          {
            if (gclass32_1.System == GEnum3.const_1)
            {
              FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(gclass32_1, WhatToAction.Unpack);
              if (frmWhatToCopy.ShowDialog() == DialogResult.OK)
              {
                if (frmWhatToCopy.CopyDlc)
                  gclass32_1.Dlc.method_16(Settings.Default.ExtractFolder, true, false, (IEnumerable<GClass12>) null, false);
                if (frmWhatToCopy.CopyGame)
                  gclass32_1.method_16(Settings.Default.ExtractFolder, true, false, (IEnumerable<GClass12>) null, false);
                if (frmWhatToCopy.CopyUpdate)
                {
                  foreach (GClass30 gclass30 in frmWhatToCopy.list_0)
                    gclass30.method_16(Settings.Default.ExtractFolder, true, false, (IEnumerable<GClass12>) null, false);
                }
              }
            }
            else if (gclass32_1.System == GEnum3.const_0)
            {
              FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(gclass32_1, WhatToAction.Unpack);
              if (frmWhatToCopy.ShowDialog() == DialogResult.OK)
              {
                if (frmWhatToCopy.CopyDlc)
                  gclass32_1.Dlc.method_5(Settings.Default.ExtractFolder, gclass32_1.Dlc.Name + " (DLC)");
                if (frmWhatToCopy.CopyGame)
                  gclass32_1.method_5(Settings.Default.ExtractFolder, gclass32_1.Name);
                if (frmWhatToCopy.CopyUpdate)
                {
                  foreach (GClass33 gclass33 in frmWhatToCopy.list_0)
                    gclass33.method_5(Settings.Default.ExtractFolder, string.Format("{0}  (UPDATE) (v{1})", (object) gclass33.Name, (object) gclass33.Version));
                }
              }
            }
          }
        }
      });
      this.radContextMenu_0.Items[8].Click += (EventHandler) ((sender, e) => this.method_42(this.lstGames.SelectedItems[0].Tag as GClass32));
      this.radContextMenu_0.Items[9].Click += (EventHandler) ((sender, e) => this.method_45(this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).Where<GClass32>((Func<GClass32, bool>) (gclass32_0 => gclass32_0.GEnum2_0 == GEnum2.const_2)), false));
      this.radContextMenu_0.Items[10].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_1 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
        {
          int num = (int) new frmEmuInfo(gclass32_1).ShowDialog();
        }
        this.method_63(false, true, this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)).ToList<GClass32>());
      });
      this.radContextMenu_0.Items[11].Click += (EventHandler) ((sender, e) =>
      {
        foreach (GClass32 gclass32_1 in this.lstGames.SelectedItems.Select<ListViewDataItem, GClass32>((Func<ListViewDataItem, GClass32>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass32)))
        {
          int num = (int) new frmDownloadSpecificFiles(gclass32_1).ShowDialog();
        }
      });
    }

    private void method_38()
    {
      this.Platforms = new List<Platform>();
      if (string.IsNullOrEmpty(Settings.Default.Platforms))
      {
        this.Platforms.AddRange(System.Enum.GetValues(typeof (Platform)).Cast<Platform>());
      }
      else
      {
        try
        {
          this.Platforms.AddRange(((IEnumerable<string>) Settings.Default.Platforms.Split(',')).Select<string, Platform>((Func<string, Platform>) (string_0 => (Platform) int.Parse(string_0))));
        }
        catch
        {
          Settings.Default.Platforms = (string) null;
        }
      }
      this.int_2 = this.Platforms.Count;
      this.treePlatforms.AutoCheckChildNodes = true;
      this.treePlatforms.TriStateMode = true;
      this.treePlatforms.Nodes.Add("Wii U");
      this.treePlatforms.Nodes["Wii U"].Nodes.Add("Native Titles");
      this.treePlatforms.Nodes["Wii U"].Nodes.Add("Virtual Console");
      this.treePlatforms.Nodes["Wii U"].Nodes.Add("Custom Titles");
      this.treePlatforms.Nodes.Add("3DS");
      this.treePlatforms.Nodes["3DS"].Nodes.Add("Native Titles");
      this.treePlatforms.Nodes["3DS"].Nodes.Add("Virtual Console");
      this.treePlatforms.Nodes.Add("Wii");
      this.treePlatforms.Nodes["Wii"].Nodes.Add("Native Titles");
      this.treePlatforms.Nodes["Wii"].Nodes.Add("Virtual Console");
      foreach (string name in System.Enum.GetNames(typeof (Platform)))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class181 class181 = new NusGrabberForm.Class181();
        // ISSUE: reference to a compiler-generated field
        class181.nusGrabberForm_0 = this;
        Platform platform_7 = (Platform) System.Enum.Parse(typeof (Platform), name);
        // ISSUE: reference to a compiler-generated field
        class181.radTreeNode_0 = new RadTreeNode(" " + name.Replace('_', ' '))
        {
          Image = GClass23.smethod_0(platform_7),
          Tag = (object) platform_7,
          CheckType = CheckType.CheckBox,
          CheckState = this.Platforms.Contains(platform_7) ? ToggleState.On : ToggleState.Off
        };
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class181.radTreeNode_0.PropertyChanged += new PropertyChangedEventHandler(class181.method_0);
        // ISSUE: reference to a compiler-generated field
        if (((IEnumerable<Platform>) GClass23.platform_3).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
        {
          // ISSUE: reference to a compiler-generated field
          if (((IEnumerable<Platform>) GClass23.platform_2).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
          {
            // ISSUE: reference to a compiler-generated field
            this.treePlatforms.Nodes["Wii U"].Nodes["Custom Titles"].Nodes.Add(class181.radTreeNode_0);
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (((IEnumerable<Platform>) GClass23.platform_4).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
            {
              // ISSUE: reference to a compiler-generated field
              this.treePlatforms.Nodes["Wii U"].Nodes["Virtual Console"].Nodes.Add(class181.radTreeNode_0);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Nodes.Add(class181.radTreeNode_0);
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (((IEnumerable<Platform>) GClass23.platform_0).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
          {
            // ISSUE: reference to a compiler-generated field
            if (((IEnumerable<Platform>) GClass23.platform_1).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
            {
              // ISSUE: reference to a compiler-generated field
              this.treePlatforms.Nodes["3DS"].Nodes["Virtual Console"].Nodes.Add(class181.radTreeNode_0);
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Nodes.Add(class181.radTreeNode_0);
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (((IEnumerable<Platform>) GClass23.platform_5).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
            {
              // ISSUE: reference to a compiler-generated field
              if (((IEnumerable<Platform>) GClass23.platform_6).Contains<Platform>((Platform) class181.radTreeNode_0.Tag))
              {
                // ISSUE: reference to a compiler-generated field
                this.treePlatforms.Nodes["Wii"].Nodes["Virtual Console"].Nodes.Add(class181.radTreeNode_0);
              }
              else
              {
                // ISSUE: reference to a compiler-generated field
                this.treePlatforms.Nodes["Wii"].Nodes["Native Titles"].Nodes.Add(class181.radTreeNode_0);
              }
            }
          }
        }
      }
      this.treePlatforms.ExpandAll();
      this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Image = GClass23.smethod_0(Platform.Nintendo_3DS);
      this.treePlatforms.Nodes["3DS"].Image = (Image) Class123.logo3ds;
      this.treePlatforms.Nodes["3DS"].Text = "";
      this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Collapse();
      this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Collapse();
      this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Image = GClass23.smethod_0(Platform.Wii_U_Disc);
      this.treePlatforms.Nodes["Wii U"].Image = (Image) Class123.logoWiiU;
      this.treePlatforms.Nodes["Wii U"].Text = "";
      this.treePlatforms.Nodes["Wii"].Text = "";
      this.treePlatforms.Nodes["Wii"].Image = (Image) Class123.logoWii;
      this.treePlatforms.Nodes["Wii"].Nodes["Native Titles"].Collapse();
    }

    private void NusGrabberForm_Load(object sender, EventArgs e)
    {
      this.dateTime_1 = DateTime.Now;
      Class91.Event_0 += (EventHandler<HelperChat.Message>) ((object_0, message_0) =>
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class182 class182 = new NusGrabberForm.Class182();
        // ISSUE: reference to a compiler-generated field
        class182.nusGrabberForm_0 = this;
        // ISSUE: reference to a compiler-generated field
        class182.message_0 = message_0;
        try
        {
          // ISSUE: reference to a compiler-generated method
          this.Invoke((Delegate) new MethodInvoker(class182.method_0));
        }
        catch
        {
        }
      });
      if (Settings.Default.ShowSpeedGraph)
        this.method_35();
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(Class123.genres);
        foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("genre"))
          this.chkGameGenres.Items.Add(new ListViewDataItem()
          {
            Text = xmlNode.FirstChild.InnerText,
            Tag = (object) uint.Parse(xmlNode.Attributes["id"].InnerText)
          });
      }
      catch
      {
      }
      this.radDate.Value = DateTime.Now;
      this.radDate.MinDate = DateTime.Now;
      this.radDate.Format = DateTimePickerFormat.Custom;
      this.radDate.CustomFormat = "MM/dd/yyyy HH:mm";
      this.Text = this.Text + " - Current region : " + Settings.Default.Region;
      this.method_38();
      RadMessageBox.ShowInTaskbar = true;
      if (ApplicationDeployment.IsNetworkDeployed)
        this.Text = this.Text + " Ver:" + (object) ApplicationDeployment.CurrentDeployment.CurrentVersion;
      else if (Class102.string_0 != null)
        this.Text = this.Text + " Ver:" + Class102.string_0;
      if (!GClass6.smethod_2(Settings.Default.Path) && !Class97.smethod_13(true))
      {
        this.Close();
      }
      else
      {
        this.txtDesc.BackColor = this.BackColor;
        this.toolGameDesc.Select();
        this.method_37();
        Font font = new Font(this.Font, FontStyle.Bold);
        this.listViewDataItemGroup_4.Font = font;
        this.listViewDataItemGroup_2.Font = font;
        this.listViewDataItemGroup_0.Font = font;
        this.listViewDataItemGroup_1.Font = font;
        this.listViewDataItemGroup_3.Font = font;
        this.lstGames.Groups.Add(this.listViewDataItemGroup_4);
        this.lstGames.Groups.Add(this.listViewDataItemGroup_2);
        this.lstGames.Groups.Add(this.listViewDataItemGroup_0);
        this.lstGames.Groups.Add(this.listViewDataItemGroup_1);
        this.lstGames.Groups.Add(this.listViewDataItemGroup_3);
        this.method_31((object) this, (EventArgs) null);
        new GClass127().method_0();
      }
    }

    private void method_39(object object_0, GClass84 gclass84_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class183 class183 = new NusGrabberForm.Class183();
      // ISSUE: reference to a compiler-generated field
      class183.nusGrabberForm_0 = this;
      // ISSUE: reference to a compiler-generated field
      class183.gclass84_0 = gclass84_0;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class183.method_0));
        (object_0 as GClass86).Event_2 -= new EventHandler<GClass84>(this.method_39);
      }
      catch
      {
      }
    }

    private void method_40(object object_0, object object_1)
    {
      try
      {
        this.Invoke((Delegate) (() => this.panelGameCover.smethod_1(false)));
        (object_0 as GClass86).Event_0 -= new EventHandler(this.method_40);
      }
      catch
      {
      }
    }

    private void method_41(object object_0, GClass84 gclass84_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class184 class184 = new NusGrabberForm.Class184();
      // ISSUE: reference to a compiler-generated field
      class184.nusGrabberForm_0 = this;
      // ISSUE: reference to a compiler-generated field
      class184.gclass84_0 = gclass84_0;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class184.method_0));
        (object_0 as GClass86).Event_2 -= new EventHandler<GClass84>(this.method_41);
      }
      catch
      {
      }
    }

    private void pbCover_DoubleClick(object sender, EventArgs e)
    {
      if (this.SelectedGame == null)
        return;
      switch (RadMessageBox.Show("Would you like to specify a custom cover for this game? Choose cancel to download the default cover.", "Custom cover", MessageBoxButtons.YesNoCancel))
      {
        case DialogResult.Cancel:
          byte[] buffer = GClass85.smethod_0(this.SelectedGame.String_7, TimeSpan.Zero);
          if (buffer == null)
            break;
          this.pbCover.Image = Image.FromStream((Stream) new MemoryStream(buffer));
          break;
        case DialogResult.Yes:
          OpenFileDialog openFileDialog1 = new OpenFileDialog();
          openFileDialog1.CheckFileExists = true;
          openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
          OpenFileDialog openFileDialog2 = openFileDialog1;
          if (openFileDialog2.ShowDialog() != DialogResult.OK)
            break;
          Image image = Image.FromStream((Stream) new MemoryStream(System.IO.File.ReadAllBytes(openFileDialog2.FileName)));
          this.pbCover.Image = image;
          using (MemoryStream memoryStream = new MemoryStream())
          {
            image.Save((Stream) memoryStream, ImageFormat.Png);
            GClass88.smethod_9(new Uri(this.SelectedGame.String_7), memoryStream.ToArray());
            break;
          }
      }
    }

    private void method_42(GClass32 gclass32_2)
    {
      if (!gclass32_2.Boolean_1)
      {
        if (gclass32_2.GEnum2_0 != GEnum2.const_2)
        {
          GClass95 gclass95 = gclass32_2.method_14(true);
          if (gclass95 == null)
          {
            int num1 = (int) RadMessageBox.Show("This title does not support emulation for the moment.");
          }
          else if (!this.CurrentlyDownloading && gclass32_2.System == GEnum3.const_1 && gclass32_2.Size.TotalBytes < 150000000UL)
          {
            int num2 = (int) RadMessageBox.Show("USB Helper will now download and prepare your game.");
            gclass95.Play();
            this.method_63(false, true, ((IEnumerable<GClass32>) new GClass32[1]
            {
              gclass32_2
            }).ToList<GClass32>());
          }
          else
          {
            int num2 = (int) RadMessageBox.Show("You do not have downloaded this game. Wii U USB Helper will now add it to the queue. Please try again when the download is complete.");
            this.method_0(gclass32_2);
            this.chkPrepareEmulation.Checked = true;
            if (this.CurrentlyDownloading)
              return;
            this.method_44();
          }
        }
        else
        {
          this.method_30();
          this.method_63(false, true, ((IEnumerable<GClass32>) new GClass32[1]
          {
            gclass32_2
          }).ToList<GClass32>());
        }
      }
      else
        this.method_30();
    }

    private void method_43()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class185 class185 = new NusGrabberForm.Class185();
      // ISSUE: reference to a compiler-generated field
      class185.nusGrabberForm_0 = this;
      this.bool_7 = false;
      // ISSUE: reference to a compiler-generated field
      class185.int_0 = 0;
      foreach (ListViewDataItem listViewDataItem in this.lstGames.Items.ToArray<ListViewDataItem>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class186 class186 = new NusGrabberForm.Class186();
        // ISSUE: reference to a compiler-generated field
        class186.class185_0 = class185;
        // ISSUE: reference to a compiler-generated field
        class186.listViewDataItem_0 = listViewDataItem;
        try
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          NusGrabberForm.Class187 class187 = new NusGrabberForm.Class187();
          // ISSUE: reference to a compiler-generated field
          class187.class186_0 = class186;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class187.gclass32_0 = class187.class186_0.listViewDataItem_0.Tag as GClass32;
          // ISSUE: reference to a compiler-generated field
          if (class187.gclass32_0 == null)
            break;
          // ISSUE: reference to a compiler-generated field
          if (class187.gclass32_0.Platform == Platform.Nintendo_DSiWare)
          {
            // ISSUE: reference to a compiler-generated field
            class187.gclass32_0.gclass86_2.Image = (Image) Class123.dsiwareicon;
            // ISSUE: reference to a compiler-generated field
            Class97.smethod_1(class187.gclass32_0, 8, this.lstGames.ListViewElement.BackColor);
            // ISSUE: reference to a compiler-generated method
            this.Invoke((Delegate) new Action(class187.method_0));
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            while (class187.class186_0.class185_0.int_0 > 10)
              Thread.Sleep(1);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class187.class186_0.class185_0.int_0++;
            // ISSUE: reference to a compiler-generated method
            Task.Run(new Action(class187.method_1));
          }
        }
        catch
        {
        }
      }
    }

    private void method_44()
    {
      this.method_54(false);
      this.CurrentlyDownloading = true;
      this.lstLog.Items.Clear();
      this.method_18();
      this.dockMain.ActiveWindow = (DockWindow) this.toolDownload;
      if (this.chkDelay.Checked && this.radDate.Value.CompareTo(DateTime.Now) > 0)
      {
        this.DownloadButton.Enabled = false;
        this.timer_4.Start();
      }
      else
        this.method_58();
    }

    private void method_45(IEnumerable<GClass32> ienumerable_0, bool bool_9)
    {
      foreach (GClass32 gclass32 in ienumerable_0)
      {
        gclass32.method_22();
        if (this.SelectedGame == gclass32 && gclass32.Boolean_1)
          this.cmdShortcut.Enabled = true;
        if (gclass32.Boolean_1 & bool_9)
          gclass32.method_11();
      }
      this.method_63(false, true, ienumerable_0.ToList<GClass32>());
    }

    private void method_46(object sender, GEventArgs0 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class188 class188 = new NusGrabberForm.Class188();
      // ISSUE: reference to a compiler-generated field
      class188.nusGrabberForm_0 = this;
      // ISSUE: reference to a compiler-generated field
      class188.geventArgs0_0 = e;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.BeginInvoke((Delegate) new Action(class188.method_0));
      }
      catch
      {
      }
    }

    private void method_47()
    {
      Class67.smethod_4();
      Cemu cemu = new Cemu((GClass30) null, false);
      if (!cemu.Boolean_0 && !cemu.EmuConfiguration_0.AutoUpdate)
      {
        int num1 = (int) RadMessageBox.Show(string.Format("CEMU is not installed. Please install it in {0} or enable automatic updates", (object) cemu.String_4));
      }
      else
      {
        Citra citra = new Citra((GClass30) null, false);
        if (!citra.Boolean_0 && !citra.EmuConfiguration_0.AutoUpdate)
        {
          int num2 = (int) RadMessageBox.Show(string.Format("Citra is not installed. Please install it in {0} or enable automatic updates", (object) citra.String_4));
        }
        else if (this.gclass130_0 == null)
        {
          Thread thread = new Thread((ThreadStart) (() =>
          {
            this.bool_2 = true;
            this.gclass130_0 = new GClass130((Form) this);
            this.gclass130_0.Run();
          }));
          thread.SetApartmentState(ApartmentState.STA);
          thread.Start();
        }
        else
          this.gclass130_0.method_1();
      }
    }

    private void radButton2_Click(object sender, EventArgs e)
    {
      this.method_47();
    }

    private void method_48(object sender, EventArgs e)
    {
      if (GClass9.smethod_0())
        return;
      int num = (int) new frmSupport().ShowDialog();
    }

    private void cmdBackupSave_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class189 class189 = new NusGrabberForm.Class189();
      if (this.gclass82_0 == null)
      {
        Class97.smethod_16((Form) this);
      }
      else
      {
        frmCreateSave frmCreateSave = new frmCreateSave();
        if (frmCreateSave.ShowDialog() != DialogResult.OK)
          return;
        // ISSUE: reference to a compiler-generated field
        class189.frmWait_0 = new FrmWait("Please wait while USB Helper downloads your save.", false);
        try
        {
          // ISSUE: reference to a compiler-generated method
          Task.Run<DialogResult>(new Func<DialogResult>(class189.method_0));
          this.SelectedGame.method_25(this.gclass82_0, frmCreateSave.string_0);
        }
        catch (GException0 ex)
        {
          // ISSUE: reference to a compiler-generated field
          class189.frmWait_0.method_0();
          Class97.smethod_15((Form) this, "No save was found for this game on your Wii U.");
          return;
        }
        catch (Exception ex)
        {
          // ISSUE: reference to a compiler-generated field
          class189.frmWait_0.method_0();
          Class97.smethod_15((Form) this, ex.Message);
          return;
        }
        // ISSUE: reference to a compiler-generated field
        class189.frmWait_0.method_0();
      }
    }

    private void radMaxSpeed_ValueChanged(object sender, EventArgs e)
    {
      GClass80 gclass800 = this.gclass80_0;
      if (gclass800 == null)
        return;
      gclass800.method_4((ulong) this.radMaxSpeed.Value * 1000UL);
    }

    private void method_49()
    {
      this.lstGames.Visible = false;
      this.lstGames.smethod_1(true);
      this.method_21();
      this.listViewDataItemGroup_0.Text = string.Format("Downloaded ({0})", (object) this.listViewDataItemGroup_0.Items.Count);
      this.listViewDataItemGroup_4.Text = string.Format("Ready for emulation ({0})", (object) this.listViewDataItemGroup_4.Items.Count);
      this.listViewDataItemGroup_2.Text = string.Format("Installed on your WiiU/3DS ({0})", (object) this.listViewDataItemGroup_2.Items.Count);
      this.listViewDataItemGroup_1.Text = string.Format("Partially downloaded ({0})", (object) this.listViewDataItemGroup_1.Items.Count);
      this.listViewDataItemGroup_3.Text = string.Format("Not downloaded ({0})", (object) this.listViewDataItemGroup_3.Items.Count);
      this.lblNbGms.Text = string.Format("{0} game(s) available (Missing Games? Check your filters and these checkboxes ->)", (object) this.lstGames.Items.Count);
      this.lstGames.Visible = true;
      this.lstGames.smethod_1(false);
    }

    private void method_50(GClass30 gclass30_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class190 class190 = new NusGrabberForm.Class190();
      // ISSUE: reference to a compiler-generated field
      class190.gclass30_0 = gclass30_0;
      // ISSUE: reference to a compiler-generated field
      this.TitlesToCopy.Remove(class190.gclass30_0);
      // ISSUE: reference to a compiler-generated method
      this.lstCopy.Items.Remove(this.lstCopy.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class190.method_0)));
      this.method_16();
    }

    private void method_51()
    {
      this.bool_7 = true;
      Thread.Sleep(1800);
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        NusGrabberForm.Class191 class191 = new NusGrabberForm.Class191();
        // ISSUE: reference to a compiler-generated field
        class191.byte_0 = (byte[]) null;
        // ISSUE: reference to a compiler-generated field
        class191.byte_1 = (byte[]) null;
        byte[] byte_2 = (byte[]) null;
        int num;
        // ISSUE: reference to a compiler-generated method
        FrmWait frmWait = new FrmWait("USB Helper is fetching the title keys...", new Action(class191.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_25(class191.byte_0, class191.byte_1, byte_2);
      }
      catch
      {
      }
    }

    private void method_52()
    {
      string[] strArray = GClass88.smethod_7("dl");
      if (strArray == null)
        return;
      foreach (string id in strArray)
      {
        TitleId titleId = new TitleId(id);
        if (GClass28.dictionary_0.ContainsKey(new TitleId((string) titleId.FullGame)))
        {
          GClass32 gclass32 = GClass28.dictionary_0[new TitleId((string) titleId.FullGame)];
          switch (titleId.IdType)
          {
            case GEnum1.const_1:
              if (gclass32.GEnum2_0 != GEnum2.const_2)
              {
                this.method_6((GClass30) gclass32);
                continue;
              }
              continue;
            case GEnum1.const_2:
              if (gclass32.Boolean_2 && gclass32.Dlc.GEnum2_0 != GEnum2.const_2)
              {
                this.method_6((GClass30) gclass32.Dlc);
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
    }

    private void method_53()
    {
      GClass88.smethod_10("dl", this.dlQueue.Items.Select<ListViewDataItem, string>((Func<ListViewDataItem, string>) (listViewDataItem_0 => (listViewDataItem_0.Tag as GClass30).TitleId.IdRaw)).ToArray<string>());
    }

    private void method_54(bool bool_9)
    {
      this.cmdAddAllGames.Enabled = bool_9;
      this.cmdAddAllDLCS.Enabled = bool_9;
      this.cmdSetExtractFolder.Enabled = bool_9;
      this.cmdAddAllUpdates.Enabled = bool_9;
      this.cmdRefresh.Enabled = this.bool_5 || this.bool_4 || this.bool_6;
      this.cmdClearDl.Enabled = bool_9;
      this.cmdChangeFolder.Enabled = bool_9;
      this.cmdChangeRegion.Enabled = bool_9;
      this.cmdChangeTicket.Enabled = bool_9;
      this.cmdImportGames.Enabled = bool_9;
    }

    private void method_55(GClass32 gclass32_2)
    {
      GClass29 gclass29 = gclass32_2.method_31();
      if (gclass29 == null)
        return;
      if (gclass29.bool_1)
        this.method_2((GClass30) gclass32_2);
      if (gclass29.bool_2)
      {
        foreach (GClass30 gclass30_0 in gclass29.list_0)
          this.method_2(gclass30_0);
      }
      if (gclass29.bool_0)
        this.method_2((GClass30) gclass32_2.Dlc);
      this.dockMain.ActiveWindow = (DockWindow) this.toolCopy;
    }

    private void method_56(GClass32 gclass32_2)
    {
      FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(gclass32_2, WhatToAction.Delete);
      if (frmWhatToCopy.ShowDialog() != DialogResult.OK)
        return;
      if (frmWhatToCopy.CopyDlc)
        gclass32_2.Dlc.method_11();
      if (frmWhatToCopy.CopyGame)
        gclass32_2.method_11();
      if (frmWhatToCopy.CopyUpdate)
      {
        foreach (GClass30 gclass30 in frmWhatToCopy.list_0)
          gclass30.method_11();
      }
      this.method_63(true, true, new List<GClass32>((IEnumerable<GClass32>) new GClass32[1]
      {
        gclass32_2
      }));
      this.method_65();
    }

    private bool method_57(ListViewDataItem listViewDataItem_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class192 class192 = new NusGrabberForm.Class192();
      GClass32 tag = listViewDataItem_0.Tag as GClass32;
      if (tag == null)
        return true;
      // ISSUE: reference to a compiler-generated field
      class192.string_0 = tag.Name.Trim().ToLower().Split(' ');
      if (tag.CfwOnly && !this.chkShowRednand.Checked || !tag.CfwOnly && !this.chkShowLegit.Checked || (tag.Name.Contains("Event Preview") && !this.chkShowPreviews.Checked || !this.chkEUR.Checked && tag.Region == "EUR") || (!this.chkUSA.Checked && tag.Region == "USA" || !this.chkKOR.Checked && tag.Region == "KOR" || (!this.chkJAP.Checked && tag.Region == "JPN" || !this.Platforms.Contains(tag.Platform))) || this.list_0 != null && !this.list_0.Contains(tag.EshopId))
        return false;
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) this.FTSearchBox.Text.Trim().ToLower().Split(' ')).All<string>(new Func<string, bool>(class192.method_0));
    }

    private void method_58()
    {
      try
      {
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
      }
      catch
      {
      }
      this.method_29(this.TitlesToDownload);
    }

    private void method_59()
    {
      this.CurrentlyDownloading = false;
      this.lblTimeLeft.Text = "-";
      this.timer_4.Enabled = false;
    }

    private void method_60(object object_0, string string_4)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class194 class194 = new NusGrabberForm.Class194();
      // ISSUE: reference to a compiler-generated field
      class194.nusGrabberForm_0 = this;
      // ISSUE: reference to a compiler-generated field
      class194.string_0 = string_4;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new Action(class194.method_0));
      }
      catch
      {
      }
    }

    private void timer_4_Tick(object sender, EventArgs e)
    {
      this.radDate.Value.CompareTo(DateTime.Now);
      if (this.radDate.Value.CompareTo(DateTime.Now) > 0)
      {
        this.lblTimeLeft.Text = string.Format("{0} left", (object) (this.radDate.Value - DateTime.Now).ToString("hh\\:mm\\:ss"));
      }
      else
      {
        this.method_59();
        this.method_58();
      }
    }

    private void timer_3_Tick(object sender, EventArgs e)
    {
      try
      {
        GClass30.smethod_1();
      }
      catch
      {
      }
    }

    private void method_61()
    {
      this.lblproxyStatus.Text = "Not set";
      this.lblproxyStatus.ForeColor = System.Drawing.Color.Red;
      this.Proxy = (WebProxy) null;
    }

    private void method_62()
    {
      if (Class108.bool_0)
      {
        this.lblDonatorStatus.ForeColor = System.Drawing.Color.Orange;
        this.lblDonatorEmail.Text = "-";
        this.lblDonatorDate.Text = "-";
        this.lblDonatorStatus.Text = "The miner is updating...";
      }
      else if (GClass89.Boolean_0)
      {
        this.lblDonatorStatus.ForeColor = System.Drawing.Color.Green;
        this.lblDonatorStatus.Text = "Thank you for your donation!";
        this.lblDonatorEmail.Text = GClass89.GClass8_0.Email;
        this.lblDonatorDate.Text = GClass89.GClass8_0.DonationDate;
      }
      else
      {
        this.lblDonatorStatus.ForeColor = System.Drawing.Color.Red;
        this.lblDonatorStatus.Text = "You are not a donor yet.";
        this.lblDonatorEmail.Text = "-";
        this.lblDonatorDate.Text = "-";
      }
    }

    private void method_63(bool bool_9 = false, bool bool_10 = true, List<GClass32> list_5 = null)
    {
      this.lstGames.BeginUpdate();
      foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
      {
        GClass32 tag = listViewDataItem.Tag as GClass32;
        // ISSUE: explicit non-virtual call
        if (list_5 == null || __nonvirtual (list_5.Contains(tag)))
        {
          if (bool_10)
          {
            tag.method_6();
            if (tag.Boolean_3)
            {
              foreach (GClass30 update in tag.Updates)
                update.method_6();
            }
            if (tag.Boolean_2)
              tag.Dlc.method_6();
            listViewDataItem.Group = this.method_11(tag);
            listViewDataItem[3] = (object) (tag.Int32_0.ToString() + "%");
            listViewDataItem[4] = tag.Boolean_3 ? (tag.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2 ? (object) "Ready" : (object) "Yes") : (object) "No";
            listViewDataItem[5] = tag.Boolean_2 ? (tag.Dlc.GEnum2_0 == GEnum2.const_2 ? (object) "Ready" : (object) "Yes") : (object) "No";
            if (bool_9)
            {
              Class97.smethod_1(tag, 8, this.lstGames.ListViewElement.BackColor);
              listViewDataItem.Image = tag.gclass86_2.Image;
            }
          }
          listViewDataItem.ForeColor = Class97.smethod_0((GClass30) tag);
        }
      }
      this.method_49();
      this.method_15();
      this.lstGames.EndUpdate();
      this.method_65();
    }

    private void method_64(string string_4)
    {
      if (string_4 == null)
        return;
      Class91.smethod_3(string_4, this.string_3);
      this.lstChat.Items.Clear();
      this.lstChat.Items.Add(string.Format("--NOW JOINING: {0}--", (object) string_4));
      this.lstChat.Items.Add("--Remember to stay polite!--");
      this.lstChat.Items.Add("--This feature is experimental!--");
      this.lblChannelClientCount.Text = "Loading...";
      this.string_3 = string_4;
    }

    private void method_65()
    {
      if (this.SelectedGame == null)
        return;
      if (Settings.Default.GameSpecificRoom)
        this.method_64(this.SelectedGame.Name);
      this.lblModsOnlyCemu.Visible = !(this.SelectedGame.method_14(false) is Cemu);
      this.modPreview.Items.Clear();
      this.txtModDescription.Text = "";
      this.lstMods.Items.Clear();
      this.txtModSearch.Text = "";
      try
      {
        this.gclass15_0 = new GClass15(this.SelectedGame);
        List<GClass14> source = this.gclass15_0.method_1();
        this.lstMods.BeginUpdate();
        foreach (GClass14 gclass14 in (IEnumerable<GClass14>) source.OrderByDescending<GClass14, long>((Func<GClass14, long>) (gclass14_0 => gclass14_0.Date)))
        {
          ListViewDataItem listViewDataItem = new ListViewDataItem(gclass14.Name) { Tag = (object) gclass14 };
          listViewDataItem.CheckState = this.gclass15_0.method_3(gclass14.Name) ? ToggleState.On : ToggleState.Off;
          this.lstMods.Items.Add(listViewDataItem);
        }
        this.lstMods.EndUpdate();
        if (this.lstMods.Items.Count > 0)
          this.lstMods.SelectedIndex = 0;
      }
      catch
      {
      }
      this.PreviouslySelectedGame = this.SelectedGame;
      this.txtDesc.smethod_1(true);
      this.panelGameCover.smethod_1(true);
      this.bitmap_0 = (Bitmap) null;
      this.pbPreview1.Image = (Image) null;
      this.pbPreview2.Image = (Image) null;
      this.pbPreview3.Image = (Image) null;
      this.cmdShortcut.Enabled = this.SelectedGame.Boolean_1;
      this.lblGameSize.Text = this.SelectedGame.Size.ToString();
      this.lblStatusGameRaw.ForeColor = this.SelectedGame.Color_0;
      this.lblStatusGameRaw.LabelElement.ToolTipText = this.SelectedGame.String_3;
      this.lblStatusGameEmu.ForeColor = this.SelectedGame.Color_1;
      this.lblStatusGameEmu.LabelElement.ToolTipText = this.SelectedGame.String_4;
      this.lblTitleId.Text = this.SelectedGame.TitleId.ToSplitString();
      this.cmdRestoreSave.Enabled = this.SelectedGame.System == GEnum3.const_1;
      this.cmdBackupSave.Enabled = this.SelectedGame.System == GEnum3.const_1;
      this.cmdImportCemu.Enabled = this.SelectedGame.System == GEnum3.const_1;
      this.cmdCommunitySaves.Enabled = this.SelectedGame.method_14(false) != null && this.SelectedGame.method_14(false).FileSaveLocation != null;
      try
      {
        this.webBrowser.Url = new Uri(string.Format("https://www.yandex.com/search/?text={0}", (object) HttpUtility.UrlEncode(this.SelectedGame.Name + " Wii U".Replace("&", "and"))), UriKind.Absolute);
      }
      catch
      {
      }
      this.cmdAddGame.Text = this.SelectedGame.GEnum2_0 != GEnum2.const_2 || this.SelectedGame.Boolean_0 ? "&Add" : "&Verify";
      if (this.SelectedGame.Boolean_3)
      {
        this.lblUpdateSize.Text = this.SelectedGame.Updates.Last<GClass33>().Size.ToString();
        this.lblStatusUpdateEmu.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<GClass33>().String_4;
        this.lblStatusUpdateEmu.ForeColor = this.SelectedGame.Updates.Last<GClass33>().Color_1;
        this.lblStatusUpdateRaw.ForeColor = this.SelectedGame.Updates.Last<GClass33>().Color_0;
        this.lblStatusUpdateRaw.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<GClass33>().String_3;
        this.lblEmuUpdateVersion.Text = "v." + this.SelectedGame.method_14(false)?.GetUpdateVersion().ToString();
        this.cmdAddUpdate.Enabled = true;
        this.cmdAddUpdate.Text = "Add &update";
      }
      else
      {
        this.lblStatusUpdateRaw.ForeColor = System.Drawing.Color.Gray;
        this.lblStatusUpdateEmu.ForeColor = System.Drawing.Color.Gray;
        this.lblEmuUpdateVersion.Text = "-";
        this.lblUpdateSize.Text = "-";
        this.cmdAddUpdate.Text = "No update available";
        this.lblStatusUpdateRaw.LabelElement.ToolTipText = "No update available";
        this.lblStatusUpdateEmu.LabelElement.ToolTipText = "No update available";
        this.cmdAddUpdate.Enabled = false;
      }
      if (this.SelectedGame.Boolean_2)
      {
        this.lblDLCSize.Text = this.SelectedGame.Dlc.Size.ToString();
        this.lblStatusDLCRaw.ForeColor = this.SelectedGame.Dlc.Color_0;
        this.lblStatusDLCRaw.LabelElement.ToolTipText = this.SelectedGame.Dlc.String_3;
        this.lblStatusDLCEmu.ForeColor = this.SelectedGame.Color_1;
        this.lblStatusDLCEmu.LabelElement.ToolTipText = this.SelectedGame.String_4;
        this.cmdAddDlc.Enabled = !this.dlQueue.smethod_0((GClass30) this.SelectedGame.Dlc);
        this.cmdAddDlc.Text = "Add &DLC";
      }
      else
      {
        this.lblStatusDLCRaw.ForeColor = System.Drawing.Color.Gray;
        this.lblStatusDLCRaw.LabelElement.ToolTipText = "No DLC available";
        this.lblStatusDLCEmu.ForeColor = System.Drawing.Color.Gray;
        this.lblStatusDLCEmu.LabelElement.ToolTipText = "No DLC available";
        this.lblDLCSize.Text = "-";
        this.cmdAddDlc.Text = "No DLC available";
        this.cmdAddDlc.Enabled = false;
      }
      this.cmdPlay.Enabled = true;
      this.cmdAddGame.Enabled = !this.dlQueue.smethod_0((GClass30) this.SelectedGame) && !this.SelectedGame.DiscOnly;
      this.lblTitle.Text = this.SelectedGame.Name;
      if (this.SelectedGame.CfwOnly)
        this.lblTitle.Text += " (CFW ONLY)";
      if (this.SelectedGame.DiscOnly)
        this.lblTitle.Text += " (ONLY UPDATES AND DLC) ";
      this.cmdCopy.Enabled = this.SelectedGame.GEnum2_0 == GEnum2.const_2 || this.SelectedGame.Boolean_3 || this.SelectedGame.Boolean_2 && this.SelectedGame.Dlc.GEnum2_0 == GEnum2.const_2;
      this.cmdDelete.Enabled = this.SelectedGame.GEnum2_0 != GEnum2.const_0 || this.SelectedGame.Boolean_1 || this.SelectedGame.Boolean_3 || this.SelectedGame.Boolean_2 && (uint) this.SelectedGame.Dlc.GEnum2_0 > 0U;
      this.txtDesc.Text = "";
      this.pbBanner.Image = (Image) Class123.banner;
      switch (this.SelectedGame.System)
      {
        case GEnum3.const_0:
          this.pictureLogo.Image = (Image) Class123.logo3ds;
          break;
        case GEnum3.const_1:
          this.pictureLogo.Image = (Image) Class123.logoWiiU;
          break;
        case GEnum3.const_3:
          this.pictureLogo.Image = (Image) Class123.logoWii;
          break;
        default:
          this.pictureLogo.Image = (Image) null;
          break;
      }
      this.SelectedGame.method_28(new Action<GClass74, GClass32>(this.method_22));
    }

    private void method_66(ulong ulong_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      this.Invoke((Delegate) new MethodInvoker(new NusGrabberForm.Class195()
      {
        nusGrabberForm_0 = this,
        ulong_0 = ulong_2
      }.method_0));
    }

    private void chkSuperSpeed_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      GClass28.bool_2 = this.chkSuperSpeed.Checked;
      Settings.Default.EnableSuperSpeed = this.chkSuperSpeed.Checked;
      Settings.Default.Save();
    }

    private void pbCover_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      if (this.bitmap_0 == null)
      {
        graphics.Clear(this.BackColor);
      }
      else
      {
        this.panelGameCover.smethod_1(false);
        float num1 = (float) (this.pbCover.Width / 2);
        float num2 = (float) (this.pbCover.Height / 2);
        float num3 = (float) (1.0 + (double) this.float_0 / 100.0);
        graphics.ScaleTransform(num3, num3);
        graphics.DrawImage((Image) this.bitmap_0, new PointF(num1 - (float) ((double) this.bitmap_0.Width * (double) num3 / 2.0), num2 - (float) ((double) this.bitmap_0.Height * (double) num3 / 2.0)));
      }
    }

    private void lstMovies_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
    {
      GClass56 tag = e.Item.Tag as GClass56;
      try
      {
        int num = (int) new frmVideo(Class67.smethod_1(tag.Files.File.First<GClass46>((Func<GClass46, bool>) (gclass46_0 => gclass46_0.Format == "mp4")).MovieUrl, 315360000)).ShowDialog();
      }
      catch
      {
      }
    }

    private void chkForceGameMode_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.ForceGameMode = this.chkForceGameMode.Checked;
      Settings.Default.Save();
    }

    private void radButton4_Click(object sender, EventArgs e)
    {
      frmEmuSettings frmEmuSettings = new frmEmuSettings();
      int num = (int) frmEmuSettings.ShowDialog();
      if (!frmEmuSettings.PathWasChanged)
        return;
      this.method_63(false, true, (List<GClass32>) null);
    }

    private void timer_5_Tick(object sender, EventArgs e)
    {
      if ((DateTime.Now - this.dateTime_1).TotalDays < 3.0)
        return;
      Class97.smethod_5("Restart the application", "USB HELPER has not been restarted in a while. It is recommended that you restart it regularly to get the latest content.", -1, true, (Image) null);
      this.dateTime_1 = DateTime.Now;
    }

    private void radButton5_Click(object sender, EventArgs e)
    {
      frmAdvancedDiskManagement advancedDiskManagement = new frmAdvancedDiskManagement();
      int num = (int) advancedDiskManagement.ShowDialog();
      this.method_63(true, true, advancedDiskManagement.DeletedTitles);
    }

    private void radButton7_Click(object sender, EventArgs e)
    {
      int num = (int) new frmCloudSaving().ShowDialog();
    }

    private void cmdImportCemu_Click(object sender, EventArgs e)
    {
      Class97.smethod_7(this.SelectedGame, this.gclass82_0, (Form) this);
    }

    private void txtChat_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != (int) Convert.ToChar((object) Keys.Return))
        return;
      if (this.string_3 != null)
        Class91.smethod_6(Class91.smethod_2(), this.string_3, this.txtChat.Text.Trim());
      this.txtChat.Text = "";
    }

    private void lstMods_SelectedItemChanged(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      NusGrabberForm.Class196 class196 = new NusGrabberForm.Class196();
      // ISSUE: reference to a compiler-generated field
      class196.nusGrabberForm_0 = this;
      if (this.lstMods.SelectedItem == null)
        return;
      // ISSUE: reference to a compiler-generated field
      class196.gclass14_0 = this.lstMods.SelectedItem.Tag as GClass14;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.txtModDescription.Text = class196.gclass14_0.Description + Environment.NewLine + Environment.NewLine + string.Format("Creator: {0}", (object) class196.gclass14_0.Creator) + Environment.NewLine + string.Format("Original link: {0}", (object) class196.gclass14_0.OriginalLink);
      this.modPreview.Items.Clear();
      this.modPreview.Items.Clear();
      ++this.ulong_1;
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class196.method_0));
    }

    private void lstMods_ItemCheckedChanging(object sender, ListViewItemCancelEventArgs e)
    {
      GClass14 tag = e.Item.Tag as GClass14;
      if (e.Item.CheckState == ToggleState.Off)
      {
        this.lstMods.BeginUpdate();
        List<string> stringList = this.gclass15_0.method_0(tag.Name);
        if (!stringList.Contains(tag.Name))
          e.Cancel = true;
        foreach (string str in stringList)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          NusGrabberForm.Class199 class199 = new NusGrabberForm.Class199();
          // ISSUE: reference to a compiler-generated field
          class199.string_0 = str;
          try
          {
            // ISSUE: reference to a compiler-generated method
            this.lstMods.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class199.method_0)).CheckState = ToggleState.On;
          }
          catch
          {
          }
        }
        this.lstMods.EndUpdate();
      }
      else
      {
        if (this.gclass15_0.method_5(tag.Name))
          return;
        e.Cancel = true;
      }
    }

    private void txtModSearch_TextChanged(object sender, EventArgs e)
    {
      this.lstMods.FilterDescriptors.Clear();
      this.lstMods.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, (object) this.txtModSearch.Text));
    }

    private void cmdModContribute_Click(object sender, EventArgs e)
    {
      Process.Start("https://cloud.wiiuusbhelper.com/mods/suggest/index.php?name=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(this.SelectedGame.Name + string.Format(" ({0})", (object) this.SelectedGame.Region))));
    }

    private void dockMain_ActiveWindowChanged(object sender, DockWindowEventArgs e)
    {
      if (this.dockWindow_0 == this.toolDownload && Settings.Default.ShowDownloadManagerTip && (Settings.Default.LaunchCount <= 3 && this.CurrentlyDownloading))
      {
        Settings.Default.ShowDownloadManagerTip = false;
        Settings.Default.Save();
        int num = (int) new frmHelpOverlay(this.Handle, new Point?(new Point(this.Width - 40, 125)), "The Download Manager will be accessible from here!", 5).ShowDialog();
      }
      this.dockWindow_0 = e.DockWindow;
    }

    private void timer_6_Tick(object sender, EventArgs e)
    {
      if (this.int_2 != this.Platforms.Count)
        this.method_49();
      this.int_2 = this.Platforms.Count;
    }

    private void chkDisableSpeedGraph_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.ShowSpeedGraph = !this.chkDisableSpeedGraph.Checked;
      Settings.Default.Save();
    }

    private void cmdCommunitySaves_Click(object sender, EventArgs e)
    {
      int num = (int) new frmCommunitySaves(this.SelectedGame).ShowDialog();
    }

    private void chkNotifyChat_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.ChatNotifications = this.chkNotifyChat.Checked;
      Settings.Default.Save();
    }

    private void lstChat_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
    {
      e.VisualItem.TextWrap = true;
    }

    private void dockInfo_ActiveWindowChanged(object sender, DockWindowEventArgs e)
    {
      if (this.dockInfo.ActiveWindow != this.toolChat)
        return;
      this.toolChat.Text = "Chat Room";
    }

    private void timer_7_Tick(object sender, EventArgs e)
    {
      if (this.string_3 == null)
        return;
      Class91.smethod_5(this.string_3);
    }

    private void cmdSetExtractFolder_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Class97.smethod_12(false);
        this.method_24();
      }
      else
      {
        if (e.Button != MouseButtons.Right || !Directory.Exists(Settings.Default.ExtractFolder))
          return;
        Class97.smethod_9(Settings.Default.ExtractFolder);
      }
    }

    private void cmdChangeFolder_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Class97.smethod_13(false);
        this.method_51();
      }
      else
      {
        if (e.Button != MouseButtons.Right || !Directory.Exists(Settings.Default.Path))
          return;
        Class97.smethod_9(Settings.Default.Path);
      }
    }

    private void radioLobby_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.GameSpecificRoom = e.ToggleState != ToggleState.On;
      if (Settings.Default.GameSpecificRoom)
        return;
      this.method_64("MAIN LOBBY");
    }

    private void radioGameRoom_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.GameSpecificRoom = e.ToggleState == ToggleState.On;
      if (!Settings.Default.GameSpecificRoom)
        return;
      this.method_64(this.SelectedGame?.Name);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.icontainer_0 = (IContainer) new Container();
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Name");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Region");
      ListViewDetailColumn viewDetailColumn3 = new ListViewDetailColumn("Column 2", "Size");
      ListViewDetailColumn viewDetailColumn4 = new ListViewDetailColumn("Column 3", "Completion");
      ListViewDetailColumn viewDetailColumn5 = new ListViewDetailColumn("Column 4", "Update");
      ListViewDetailColumn viewDetailColumn6 = new ListViewDetailColumn("Column 5", "Dlc");
      ListViewDetailColumn viewDetailColumn7 = new ListViewDetailColumn("Column 6", "Console");
      ListViewDetailColumn viewDetailColumn8 = new ListViewDetailColumn("Column 0", "Column 0");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (NusGrabberForm));
      AutoHideGroup autoHideGroup1 = new AutoHideGroup();
      AutoHideGroup autoHideGroup2 = new AutoHideGroup();
      CarouselBezierPath carouselBezierPath = new CarouselBezierPath();
      ListViewDetailColumn viewDetailColumn9 = new ListViewDetailColumn("Column 0", "Column 0");
      this.dockWindowPlaceholder1 = new DockWindowPlaceholder();
      this.dockWindowPlaceholder2 = new DockWindowPlaceholder();
      this.FTSearchBox = new RadTextBox();
      this.lstGames = new RadListView();
      this.openFileDialog_0 = new OpenFileDialog();
      this.label2 = new RadLabel();
      this.dlQueue = new RadListView();
      this.lblTotalToDl = new RadLabel();
      this.lblTotalDl = new RadLabel();
      this.lblNbGms = new RadLabel();
      this.radGroupBox7 = new RadGroupBox();
      this.chkPrepareEmulation = new RadCheckBox();
      this.chkPack = new RadCheckBox();
      this.radDate = new DateTimePicker();
      this.cmdAbortDelay = new RadButton();
      this.lblTimeLeft = new RadLabel();
      this.chkUnpack = new RadCheckBox();
      this.chkCopyToSD = new RadCheckBox();
      this.chkSleep = new RadCheckBox();
      this.chkShutdown = new RadCheckBox();
      this.chkDelay = new RadCheckBox();
      this.chkHibernate = new RadCheckBox();
      this.grpProgressAll = new RadGroupBox();
      this.lblTotalEta = new RadLabel();
      this.totalProgress = new RadProgressBar();
      this.radLabel9 = new RadLabel();
      this.radMaxSpeed = new RadSpinEditor();
      this.cmdAbortAll = new RadButton();
      this.radGroupBox3 = new RadGroupBox();
      this.cmdDelete = new RadButton();
      this.cmdCopy = new RadButton();
      this.cmdAddDlc = new RadButton();
      this.label4 = new System.Windows.Forms.Label();
      this.cmdAddUpdate = new RadButton();
      this.cmdAddGame = new RadButton();
      this.lblTitle = new RadLabel();
      this.radGroupBox2 = new RadGroupBox();
      this.lblFileEta = new RadLabel();
      this.pgFile = new RadProgressBar();
      this.grpProgressCurrent = new RadGroupBox();
      this.lblEta = new RadLabel();
      this.NUSGrabberProgress = new RadProgressBar();
      this.dockMain = new RadDock();
      this.toolCopy = new ToolWindow();
      this.lstCopy = new RadListView();
      this.cmdSendWiiu = new RadButton();
      this.cmdManageRemoteSd = new RadButton();
      this.cmdInitiateCopy = new RadButton();
      this.radGroupBox10 = new RadGroupBox();
      this.lblTotalCopy = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.radButton1 = new RadButton();
      this.radLabel6 = new RadLabel();
      this.toolTabStrip3 = new ToolTabStrip();
      this.toolWindow5 = new ToolWindow();
      this.pbBanner = new PictureBox();
      this.radSplitContainer3 = new RadSplitContainer();
      this.documentContainer1 = new DocumentContainer();
      this.documentTabStrip1 = new DocumentTabStrip();
      this.toolLibrary = new ToolWindow();
      this.radGroupBox4 = new RadGroupBox();
      this.radSplitContainer1 = new RadSplitContainer();
      this.splitPanel1 = new SplitPanel();
      this.chkCompactView = new RadCheckBox();
      this.panelLibraryCheckbox = new RadPanel();
      this.chkShowLegit = new CheckBox();
      this.chkShowRednand = new CheckBox();
      this.chkShowPreviews = new CheckBox();
      this.splitPanel2 = new SplitPanel();
      this.radGroupBox9 = new RadGroupBox();
      this.cmdClearDl = new RadButton();
      this.toolFilters = new ToolWindow();
      this.radGroupBox12 = new RadGroupBox();
      this.treePlatforms = new RadTreeView();
      this.radGroupBox13 = new RadGroupBox();
      this.chkKOR = new RadCheckBox();
      this.chkJAP = new RadCheckBox();
      this.chkUSA = new RadCheckBox();
      this.chkEUR = new RadCheckBox();
      this.toolAdvancedSearch = new ToolWindow();
      this.radGroupBox25 = new RadGroupBox();
      this.chkGameGenres = new RadCheckedListBox();
      this.cmdSearchWithCriterias = new RadButton();
      this.cmdClearCriterias = new RadButton();
      this.toolAdvancedSettings = new ToolWindow();
      this.radGroupBox28 = new RadGroupBox();
      this.lblStorageLocation = new RadLabel();
      this.radButton5 = new RadButton();
      this.radGroupBox22 = new RadGroupBox();
      this.chkDisableSpeedGraph = new RadCheckBox();
      this.chkPreventShortcut = new RadCheckBox();
      this.radGroupBox14 = new RadGroupBox();
      this.lblproxyStatus = new RadLabel();
      this.radLabel12 = new RadLabel();
      this.cmdClearProxy = new RadButton();
      this.cmdSetProxy = new RadButton();
      this.radTextBox1 = new RadTextBox();
      this.txtProxyUsr = new RadTextBox();
      this.txtProxyPassword = new RadLabel();
      this.radLabel11 = new RadLabel();
      this.txtProxyUrl = new RadTextBox();
      this.radLabel10 = new RadLabel();
      this.toolEmuSettings = new ToolWindow();
      this.radGroupBox5 = new RadGroupBox();
      this.radButton7 = new RadButton();
      this.radGroupBox21 = new RadGroupBox();
      this.radLabel22 = new RadLabel();
      this.radButton2 = new RadButton();
      this.chkForceGameMode = new RadCheckBox();
      this.radLabel23 = new RadLabel();
      this.radLabel13 = new RadLabel();
      this.radGroupBox17 = new RadGroupBox();
      this.radButton4 = new RadButton();
      this.toolContribute = new ToolWindow();
      this.radGroupBox15 = new RadGroupBox();
      this.radGroupBox16 = new RadGroupBox();
      this.cmdDonate = new RadButton();
      this.lblDonatorDate = new RadLabel();
      this.lblDonatorStatus = new RadLabel();
      this.radLabel18 = new RadLabel();
      this.lblDonatorEmail = new RadLabel();
      this.radLabel16 = new RadLabel();
      this.radLabel15 = new RadLabel();
      this.radLabel14 = new RadLabel();
      this.radGroupBox20 = new RadGroupBox();
      this.cmdSugegstIdea = new RadButton();
      this.toolHelp = new ToolWindow();
      this.radGroupBox24 = new RadGroupBox();
      this.cmdPrepareSd = new RadButton();
      this.toolTabStrip1 = new ToolTabStrip();
      this.toolGameInfo = new ToolWindow();
      this.radGroupBox6 = new RadGroupBox();
      this.dockInfo = new RadDock();
      this.toolGameDesc = new ToolWindow();
      this.txtDesc = new RadTextBoxControl();
      this.panelGameCover = new RadPanel();
      this.cmdShortcut = new RadButton();
      this.cmdPlay = new RadButton();
      this.pictureLogo = new PictureBox();
      this.pbCover = new PictureBox();
      this.documentContainer2 = new DocumentContainer();
      this.documentTabStrip2 = new DocumentTabStrip();
      this.toolMods = new ToolWindow();
      this.lblModsOnlyCemu = new RadLabel();
      this.radGroupBox29 = new RadGroupBox();
      this.lstMods = new RadCheckedListBox();
      this.txtModSearch = new RadTextBoxControl();
      this.cmdModContribute = new RadButton();
      this.radGroupBox27 = new RadGroupBox();
      this.modPreview = new RadCarousel();
      this.txtModDescription = new RadTextBoxControl();
      this.toolExtraInfo = new ToolWindow();
      this.radGroupBox11 = new RadGroupBox();
      this.lblLang = new System.Windows.Forms.Label();
      this.lstLanguages = new RadListView();
      this.pbRating = new PictureBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lstGenre = new RadListView();
      this.pgScore = new RadProgressBar();
      this.lstControllers = new RadListView();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.toolScreenShot = new ToolWindow();
      this.pbPreview3 = new PictureBox();
      this.pbPreview1 = new PictureBox();
      this.pbPreview2 = new PictureBox();
      this.toolWeb = new ToolWindow();
      this.webBrowser = new WebBrowser();
      this.radGroupBox8 = new RadGroupBox();
      this.cmdGoNext = new RadButton();
      this.cmdGoBack = new RadButton();
      this.toolMovies = new ToolWindow();
      this.lstMovies = new RadListView();
      this.radLabel7 = new RadLabel();
      this.tollSaveManager = new ToolWindow();
      this.cmdCommunitySaves = new RadButton();
      this.cmdImportCemu = new RadButton();
      this.radLabel8 = new RadLabel();
      this.cmdRestoreSave = new RadButton();
      this.cmdBackupSave = new RadButton();
      this.toolChat = new ToolWindow();
      this.lstChat = new RadListView();
      this.txtChat = new RadTextBoxControl();
      this.panelChatBottom = new RadPanel();
      this.radioLobby = new RadRadioButton();
      this.radioGameRoom = new RadRadioButton();
      this.chkNotifyChat = new RadCheckBox();
      this.lblChannelClientCount = new RadLabel();
      this.radGroupBox1 = new RadGroupBox();
      this.lblEmuUpdateVersion = new RadLabel();
      this.lblStatusDLCEmu = new RadLabel();
      this.lblStatusUpdateEmu = new RadLabel();
      this.lblStatusGameEmu = new RadLabel();
      this.lblStatusDLCRaw = new RadLabel();
      this.radLabel19 = new RadLabel();
      this.radLabel17 = new RadLabel();
      this.lblNbPlayers = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.lblDLCSize = new RadLabel();
      this.lblTitleId = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.lblStatusUpdateRaw = new RadLabel();
      this.lblStatusGameRaw = new RadLabel();
      this.lblUpdateSize = new RadLabel();
      this.label5 = new RadLabel();
      this.lblGameSize = new RadLabel();
      this.label1 = new RadLabel();
      this.toolTabStrip2 = new ToolTabStrip();
      this.toolDownload = new ToolWindow();
      this.radPageView2 = new RadPageView();
      this.radPageViewPage1 = new RadPageViewPage();
      this.radLiveSpeed = new RadGroupBox();
      this.lblFileCheckStatus = new RadLabel();
      this.radPageViewPage3 = new RadPageViewPage();
      this.radGroupBox26 = new RadGroupBox();
      this.chkSuperSpeed = new RadCheckBox();
      this.radLabel20 = new RadLabel();
      this.radLabel21 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radGroupBox18 = new RadGroupBox();
      this.lblSpeed = new RadLabel();
      this.gaugeSpeed = new RadRadialGauge();
      this.radialGaugeArc1 = new RadialGaugeArc();
      this.radialGaugeArc2 = new RadialGaugeArc();
      this.radialGaugeLabels1 = new RadialGaugeLabels();
      this.radialGaugeTicks1 = new RadialGaugeTicks();
      this.radialGaugeSingleLabel1 = new RadialGaugeSingleLabel();
      this.radPageViewPage2 = new RadPageViewPage();
      this.grpLog = new RadGroupBox();
      this.lstLog = new RadListView();
      this.toolTabStrip4 = new ToolTabStrip();
      this.toolTabStrip6 = new ToolTabStrip();
      this.toolWindow2 = new ToolWindow();
      this.radPanel1 = new RadPanel();
      this.cmdChangeRegion = new RadButton();
      this.cmdChangeTicket = new RadButton();
      this.cmdChangeFolder = new RadButton();
      this.label7 = new System.Windows.Forms.Label();
      this.cmdSetExtractFolder = new RadButton();
      this.label6 = new System.Windows.Forms.Label();
      this.DownloadButton = new RadButton();
      this.toolWindow3 = new ToolWindow();
      this.radPanel2 = new RadPanel();
      this.cmdCopyAll = new RadButton();
      this.cmdImportGames = new RadButton();
      this.cmdRefresh = new RadButton();
      this.cmdAddAllGames = new RadButton();
      this.cmdAddAllUpdates = new RadButton();
      this.cmdAddAllDLCS = new RadButton();
      this.toolWindow4 = new ToolWindow();
      this.radPanel3 = new RadPanel();
      this.cmdLegal = new RadButton();
      this.cmdHallOfFame = new RadButton();
      this.cmdChangeTheme = new RadButton();
      this.radContextMenu_0 = new RadContextMenu(this.icontainer_0);
      this.menuDlGame = new RadMenuItem();
      this.menuDlUpdate = new RadMenuItem();
      this.menuDlDLC = new RadMenuItem();
      this.menuCopy = new RadMenuItem();
      this.menuDelete = new RadMenuItem();
      this.menuMarkInstall = new RadMenuItem();
      this.radMarkNotInstalled = new RadMenuItem();
      this.radUnpack = new RadMenuItem();
      this.menuPlay = new RadMenuItem();
      this.radPrepareEmu = new RadMenuItem();
      this.radDelEmuData = new RadMenuItem();
      this.radMenuItem1 = new RadMenuItem();
      this.timer_2 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.timer_3 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.timer_4 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.lblStatus = new RadLabel();
      this.lblSynchronized = new RadLabel();
      this.timer_5 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.timer_6 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.timer_7 = new System.Windows.Forms.Timer(this.icontainer_0);
      this.FTSearchBox.BeginInit();
      this.lstGames.BeginInit();
      this.label2.BeginInit();
      this.dlQueue.BeginInit();
      this.lblTotalToDl.BeginInit();
      this.lblTotalDl.BeginInit();
      this.lblNbGms.BeginInit();
      this.radGroupBox7.BeginInit();
      this.radGroupBox7.SuspendLayout();
      this.chkPrepareEmulation.BeginInit();
      this.chkPack.BeginInit();
      this.cmdAbortDelay.BeginInit();
      this.lblTimeLeft.BeginInit();
      this.chkUnpack.BeginInit();
      this.chkCopyToSD.BeginInit();
      this.chkSleep.BeginInit();
      this.chkShutdown.BeginInit();
      this.chkDelay.BeginInit();
      this.chkHibernate.BeginInit();
      this.grpProgressAll.BeginInit();
      this.grpProgressAll.SuspendLayout();
      this.lblTotalEta.BeginInit();
      this.totalProgress.BeginInit();
      this.radLabel9.BeginInit();
      this.radMaxSpeed.BeginInit();
      this.cmdAbortAll.BeginInit();
      this.radGroupBox3.BeginInit();
      this.radGroupBox3.SuspendLayout();
      this.cmdDelete.BeginInit();
      this.cmdCopy.BeginInit();
      this.cmdAddDlc.BeginInit();
      this.cmdAddDlc.SuspendLayout();
      this.cmdAddUpdate.BeginInit();
      this.cmdAddGame.BeginInit();
      this.lblTitle.BeginInit();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      this.lblFileEta.BeginInit();
      this.pgFile.BeginInit();
      this.grpProgressCurrent.BeginInit();
      this.grpProgressCurrent.SuspendLayout();
      this.lblEta.BeginInit();
      this.NUSGrabberProgress.BeginInit();
      this.dockMain.BeginInit();
      this.dockMain.SuspendLayout();
      this.toolCopy.SuspendLayout();
      this.lstCopy.BeginInit();
      this.cmdSendWiiu.BeginInit();
      this.cmdManageRemoteSd.BeginInit();
      this.cmdInitiateCopy.BeginInit();
      this.radGroupBox10.BeginInit();
      this.radGroupBox10.SuspendLayout();
      this.lblTotalCopy.BeginInit();
      this.radLabel1.BeginInit();
      this.radButton1.BeginInit();
      this.radLabel6.BeginInit();
      this.toolTabStrip3.BeginInit();
      this.toolTabStrip3.SuspendLayout();
      this.toolWindow5.SuspendLayout();
      ((ISupportInitialize) this.pbBanner).BeginInit();
      this.radSplitContainer3.BeginInit();
      this.radSplitContainer3.SuspendLayout();
      this.documentContainer1.BeginInit();
      this.documentContainer1.SuspendLayout();
      this.documentTabStrip1.BeginInit();
      this.documentTabStrip1.SuspendLayout();
      this.toolLibrary.SuspendLayout();
      this.radGroupBox4.BeginInit();
      this.radGroupBox4.SuspendLayout();
      this.radSplitContainer1.BeginInit();
      this.radSplitContainer1.SuspendLayout();
      this.splitPanel1.BeginInit();
      this.splitPanel1.SuspendLayout();
      this.chkCompactView.BeginInit();
      this.panelLibraryCheckbox.BeginInit();
      this.panelLibraryCheckbox.SuspendLayout();
      this.splitPanel2.BeginInit();
      this.splitPanel2.SuspendLayout();
      this.radGroupBox9.BeginInit();
      this.radGroupBox9.SuspendLayout();
      this.cmdClearDl.BeginInit();
      this.toolFilters.SuspendLayout();
      this.radGroupBox12.BeginInit();
      this.radGroupBox12.SuspendLayout();
      this.treePlatforms.BeginInit();
      this.radGroupBox13.BeginInit();
      this.radGroupBox13.SuspendLayout();
      this.chkKOR.BeginInit();
      this.chkJAP.BeginInit();
      this.chkUSA.BeginInit();
      this.chkEUR.BeginInit();
      this.toolAdvancedSearch.SuspendLayout();
      this.radGroupBox25.BeginInit();
      this.radGroupBox25.SuspendLayout();
      this.chkGameGenres.BeginInit();
      this.cmdSearchWithCriterias.BeginInit();
      this.cmdClearCriterias.BeginInit();
      this.toolAdvancedSettings.SuspendLayout();
      this.radGroupBox28.BeginInit();
      this.radGroupBox28.SuspendLayout();
      this.lblStorageLocation.BeginInit();
      this.radButton5.BeginInit();
      this.radGroupBox22.BeginInit();
      this.radGroupBox22.SuspendLayout();
      this.chkDisableSpeedGraph.BeginInit();
      this.chkPreventShortcut.BeginInit();
      this.radGroupBox14.BeginInit();
      this.radGroupBox14.SuspendLayout();
      this.lblproxyStatus.BeginInit();
      this.radLabel12.BeginInit();
      this.cmdClearProxy.BeginInit();
      this.cmdSetProxy.BeginInit();
      this.radTextBox1.BeginInit();
      this.txtProxyUsr.BeginInit();
      this.txtProxyPassword.BeginInit();
      this.radLabel11.BeginInit();
      this.txtProxyUrl.BeginInit();
      this.radLabel10.BeginInit();
      this.toolEmuSettings.SuspendLayout();
      this.radGroupBox5.BeginInit();
      this.radGroupBox5.SuspendLayout();
      this.radButton7.BeginInit();
      this.radGroupBox21.BeginInit();
      this.radGroupBox21.SuspendLayout();
      this.radLabel22.BeginInit();
      this.radButton2.BeginInit();
      this.chkForceGameMode.BeginInit();
      this.radLabel23.BeginInit();
      this.radLabel13.BeginInit();
      this.radGroupBox17.BeginInit();
      this.radGroupBox17.SuspendLayout();
      this.radButton4.BeginInit();
      this.toolContribute.SuspendLayout();
      this.radGroupBox15.BeginInit();
      this.radGroupBox15.SuspendLayout();
      this.radGroupBox16.BeginInit();
      this.radGroupBox16.SuspendLayout();
      this.cmdDonate.BeginInit();
      this.lblDonatorDate.BeginInit();
      this.lblDonatorStatus.BeginInit();
      this.radLabel18.BeginInit();
      this.lblDonatorEmail.BeginInit();
      this.radLabel16.BeginInit();
      this.radLabel15.BeginInit();
      this.radLabel14.BeginInit();
      this.radGroupBox20.BeginInit();
      this.radGroupBox20.SuspendLayout();
      this.cmdSugegstIdea.BeginInit();
      this.toolHelp.SuspendLayout();
      this.radGroupBox24.BeginInit();
      this.radGroupBox24.SuspendLayout();
      this.cmdPrepareSd.BeginInit();
      this.toolTabStrip1.BeginInit();
      this.toolTabStrip1.SuspendLayout();
      this.toolGameInfo.SuspendLayout();
      this.radGroupBox6.BeginInit();
      this.radGroupBox6.SuspendLayout();
      this.dockInfo.BeginInit();
      this.dockInfo.SuspendLayout();
      this.toolGameDesc.SuspendLayout();
      this.txtDesc.BeginInit();
      this.panelGameCover.BeginInit();
      this.panelGameCover.SuspendLayout();
      this.cmdShortcut.BeginInit();
      this.cmdPlay.BeginInit();
      ((ISupportInitialize) this.pictureLogo).BeginInit();
      ((ISupportInitialize) this.pbCover).BeginInit();
      this.documentContainer2.BeginInit();
      this.documentContainer2.SuspendLayout();
      this.documentTabStrip2.BeginInit();
      this.documentTabStrip2.SuspendLayout();
      this.toolMods.SuspendLayout();
      this.lblModsOnlyCemu.BeginInit();
      this.radGroupBox29.BeginInit();
      this.radGroupBox29.SuspendLayout();
      this.lstMods.BeginInit();
      this.txtModSearch.BeginInit();
      this.cmdModContribute.BeginInit();
      this.radGroupBox27.BeginInit();
      this.radGroupBox27.SuspendLayout();
      this.modPreview.BeginInit();
      this.txtModDescription.BeginInit();
      this.toolExtraInfo.SuspendLayout();
      this.radGroupBox11.BeginInit();
      this.radGroupBox11.SuspendLayout();
      this.lstLanguages.BeginInit();
      ((ISupportInitialize) this.pbRating).BeginInit();
      this.lstGenre.BeginInit();
      this.pgScore.BeginInit();
      this.lstControllers.BeginInit();
      this.toolScreenShot.SuspendLayout();
      ((ISupportInitialize) this.pbPreview3).BeginInit();
      ((ISupportInitialize) this.pbPreview1).BeginInit();
      ((ISupportInitialize) this.pbPreview2).BeginInit();
      this.toolWeb.SuspendLayout();
      this.radGroupBox8.BeginInit();
      this.radGroupBox8.SuspendLayout();
      this.cmdGoNext.BeginInit();
      this.cmdGoBack.BeginInit();
      this.toolMovies.SuspendLayout();
      this.lstMovies.BeginInit();
      this.radLabel7.BeginInit();
      this.tollSaveManager.SuspendLayout();
      this.cmdCommunitySaves.BeginInit();
      this.cmdImportCemu.BeginInit();
      this.radLabel8.BeginInit();
      this.cmdRestoreSave.BeginInit();
      this.cmdBackupSave.BeginInit();
      this.toolChat.SuspendLayout();
      this.lstChat.BeginInit();
      this.txtChat.BeginInit();
      this.panelChatBottom.BeginInit();
      this.panelChatBottom.SuspendLayout();
      this.radioLobby.BeginInit();
      this.radioGameRoom.BeginInit();
      this.chkNotifyChat.BeginInit();
      this.lblChannelClientCount.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.lblEmuUpdateVersion.BeginInit();
      this.lblStatusDLCEmu.BeginInit();
      this.lblStatusUpdateEmu.BeginInit();
      this.lblStatusGameEmu.BeginInit();
      this.lblStatusDLCRaw.BeginInit();
      this.radLabel19.BeginInit();
      this.radLabel17.BeginInit();
      this.lblNbPlayers.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel4.BeginInit();
      this.lblDLCSize.BeginInit();
      this.lblTitleId.BeginInit();
      this.radLabel2.BeginInit();
      this.lblStatusUpdateRaw.BeginInit();
      this.lblStatusGameRaw.BeginInit();
      this.lblUpdateSize.BeginInit();
      this.label5.BeginInit();
      this.lblGameSize.BeginInit();
      this.label1.BeginInit();
      this.toolTabStrip2.BeginInit();
      this.toolTabStrip2.SuspendLayout();
      this.toolDownload.SuspendLayout();
      this.radPageView2.BeginInit();
      this.radPageView2.SuspendLayout();
      this.radPageViewPage1.SuspendLayout();
      this.radLiveSpeed.BeginInit();
      this.radLiveSpeed.SuspendLayout();
      this.lblFileCheckStatus.BeginInit();
      this.radPageViewPage3.SuspendLayout();
      this.radGroupBox26.BeginInit();
      this.radGroupBox26.SuspendLayout();
      this.chkSuperSpeed.BeginInit();
      this.radLabel20.BeginInit();
      this.radLabel21.BeginInit();
      this.radLabel3.BeginInit();
      this.radGroupBox18.BeginInit();
      this.radGroupBox18.SuspendLayout();
      this.lblSpeed.BeginInit();
      this.gaugeSpeed.BeginInit();
      this.radPageViewPage2.SuspendLayout();
      this.grpLog.BeginInit();
      this.grpLog.SuspendLayout();
      this.lstLog.BeginInit();
      this.toolTabStrip4.BeginInit();
      this.toolTabStrip4.SuspendLayout();
      this.toolTabStrip6.BeginInit();
      this.toolTabStrip6.SuspendLayout();
      this.toolWindow2.SuspendLayout();
      this.radPanel1.BeginInit();
      this.radPanel1.SuspendLayout();
      this.cmdChangeRegion.BeginInit();
      this.cmdChangeTicket.BeginInit();
      this.cmdChangeFolder.BeginInit();
      this.cmdChangeFolder.SuspendLayout();
      this.cmdSetExtractFolder.BeginInit();
      this.cmdSetExtractFolder.SuspendLayout();
      this.DownloadButton.BeginInit();
      this.toolWindow3.SuspendLayout();
      this.radPanel2.BeginInit();
      this.radPanel2.SuspendLayout();
      this.cmdCopyAll.BeginInit();
      this.cmdImportGames.BeginInit();
      this.cmdRefresh.BeginInit();
      this.cmdAddAllGames.BeginInit();
      this.cmdAddAllUpdates.BeginInit();
      this.cmdAddAllDLCS.BeginInit();
      this.toolWindow4.SuspendLayout();
      this.radPanel3.BeginInit();
      this.radPanel3.SuspendLayout();
      this.cmdLegal.BeginInit();
      this.cmdHallOfFame.BeginInit();
      this.cmdChangeTheme.BeginInit();
      this.lblStatus.BeginInit();
      this.lblStatus.SuspendLayout();
      this.lblSynchronized.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.dockWindowPlaceholder1.AutoHideSize = new Size(510, 452);
      this.dockWindowPlaceholder1.DockWindowName = "toolDownload";
      this.dockWindowPlaceholder1.DockWindowText = "Download Manager";
      this.dockWindowPlaceholder1.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.dockWindowPlaceholder1.Location = new Point(0, 0);
      this.dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
      this.dockWindowPlaceholder1.PreviousDockState = DockState.Floating;
      this.dockWindowPlaceholder1.Size = new Size(200, 200);
      this.dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
      this.dockWindowPlaceholder2.AutoHideSize = new Size(396, 104);
      this.dockWindowPlaceholder2.DockWindowName = "toolCopy";
      this.dockWindowPlaceholder2.DockWindowText = "Copy Queue";
      this.dockWindowPlaceholder2.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.dockWindowPlaceholder2.Location = new Point(0, 0);
      this.dockWindowPlaceholder2.Name = "dockWindowPlaceholder2";
      this.dockWindowPlaceholder2.PreviousDockState = DockState.Docked;
      this.dockWindowPlaceholder2.Size = new Size(200, 200);
      this.dockWindowPlaceholder2.Text = "dockWindowPlaceholder2";
      this.FTSearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
      this.FTSearchBox.Dock = DockStyle.Top;
      this.FTSearchBox.Location = new Point(0, 0);
      this.FTSearchBox.MinimumSize = new Size(0, 24);
      this.FTSearchBox.Name = "FTSearchBox";
      this.FTSearchBox.NullText = "Search...";
      this.FTSearchBox.RootElement.MinSize = new Size(0, 24);
      this.FTSearchBox.Size = new Size(445, 24);
      this.FTSearchBox.TabIndex = 7;
      this.FTSearchBox.TextChanged += new EventHandler(this.FTSearchBox_TextChanged);
      this.lstGames.AllowEdit = false;
      this.lstGames.AllowRemove = false;
      viewDetailColumn1.HeaderText = "Name";
      viewDetailColumn1.Width = 400f;
      viewDetailColumn2.HeaderText = "Region";
      viewDetailColumn2.Width = 45f;
      viewDetailColumn3.HeaderText = "Size";
      viewDetailColumn3.Width = 70f;
      viewDetailColumn4.HeaderText = "Completion";
      viewDetailColumn4.Width = 70f;
      viewDetailColumn5.HeaderText = "Update";
      viewDetailColumn5.Width = 50f;
      viewDetailColumn6.HeaderText = "Dlc";
      viewDetailColumn6.Width = 40f;
      viewDetailColumn7.HeaderText = "Console";
      viewDetailColumn7.Width = 50f;
      this.lstGames.Columns.AddRange(viewDetailColumn1, viewDetailColumn2, viewDetailColumn3, viewDetailColumn4, viewDetailColumn5, viewDetailColumn6, viewDetailColumn7);
      this.lstGames.Dock = DockStyle.Fill;
      this.lstGames.EnableColumnSort = true;
      this.lstGames.EnableSorting = true;
      this.lstGames.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lstGames.FullRowSelect = false;
      this.lstGames.ItemSize = new Size(170, 64);
      this.lstGames.ItemSpacing = 1;
      this.lstGames.KeyboardSearchEnabled = true;
      this.lstGames.Location = new Point(0, 42);
      this.lstGames.MultiSelect = true;
      this.lstGames.Name = "lstGames";
      this.lstGames.SelectLastAddedItem = false;
      this.lstGames.ShowGroups = true;
      this.lstGames.Size = new Size(445, 197);
      this.lstGames.TabIndex = 6;
      this.lstGames.UseCompatibleTextRendering = false;
      this.lstGames.ViewType = ListViewType.IconsView;
      this.lstGames.SelectedItemChanged += new EventHandler(this.lstGames_SelectedItemChanged);
      this.lstGames.ItemMouseUp += new ListViewItemMouseEventHandler(this.lstGames_ItemMouseUp);
      this.lstGames.SizeChanged += new EventHandler(this.lstGames_SizeChanged);
      this.lstGames.KeyUp += new KeyEventHandler(this.lstGames_KeyUp);
      this.openFileDialog_0.FileName = "ckey.bin";
      this.label2.Dock = DockStyle.Top;
      this.label2.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(445, 18);
      this.label2.TabIndex = 15;
      this.label2.Text = "Download Queue (Double Click to remove)";
      this.dlQueue.AllowColumnReorder = false;
      this.dlQueue.AllowColumnResize = false;
      this.dlQueue.AllowEdit = false;
      this.dlQueue.AllowRemove = false;
      viewDetailColumn8.HeaderText = "Column 0";
      viewDetailColumn8.Width = 440f;
      this.dlQueue.Columns.AddRange(viewDetailColumn8);
      this.dlQueue.Dock = DockStyle.Fill;
      this.dlQueue.Font = new Font("Segoe UI", 9f);
      this.dlQueue.ItemSpacing = -1;
      this.dlQueue.Location = new Point(0, 18);
      this.dlQueue.Name = "dlQueue";
      this.dlQueue.ShowColumnHeaders = false;
      this.dlQueue.Size = new Size(445, 31);
      this.dlQueue.TabIndex = 16;
      this.dlQueue.ViewType = ListViewType.DetailsView;
      this.dlQueue.ItemMouseDoubleClick += new ListViewItemEventHandler(this.dlQueue_ItemMouseDoubleClick);
      this.dlQueue.VisualItemCreating += new ListViewVisualItemCreatingEventHandler(this.dlQueue_VisualItemCreating);
      this.lblTotalToDl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lblTotalToDl.Location = new Point(3, 18);
      this.lblTotalToDl.Name = "lblTotalToDl";
      this.lblTotalToDl.Size = new Size(103, 18);
      this.lblTotalToDl.TabIndex = 17;
      this.lblTotalToDl.Text = "Total to download :";
      this.lblTotalDl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lblTotalDl.Location = new Point(112, 18);
      this.lblTotalDl.Name = "lblTotalDl";
      this.lblTotalDl.Size = new Size(28, 18);
      this.lblTotalDl.TabIndex = 18;
      this.lblTotalDl.Text = "0 KB";
      this.lblNbGms.Dock = DockStyle.Left;
      this.lblNbGms.ForeColor = System.Drawing.Color.Green;
      this.lblNbGms.Location = new Point(0, 0);
      this.lblNbGms.Name = "lblNbGms";
      this.lblNbGms.Size = new Size(95, 19);
      this.lblNbGms.TabIndex = 25;
      this.lblNbGms.Text = "0 games available";
      this.radGroupBox7.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox7.Controls.Add((Control) this.chkPrepareEmulation);
      this.radGroupBox7.Controls.Add((Control) this.chkPack);
      this.radGroupBox7.Controls.Add((Control) this.radDate);
      this.radGroupBox7.Controls.Add((Control) this.cmdAbortDelay);
      this.radGroupBox7.Controls.Add((Control) this.lblTimeLeft);
      this.radGroupBox7.Controls.Add((Control) this.chkUnpack);
      this.radGroupBox7.Controls.Add((Control) this.chkCopyToSD);
      this.radGroupBox7.Controls.Add((Control) this.chkSleep);
      this.radGroupBox7.Controls.Add((Control) this.chkShutdown);
      this.radGroupBox7.Controls.Add((Control) this.chkDelay);
      this.radGroupBox7.Controls.Add((Control) this.chkHibernate);
      this.radGroupBox7.Dock = DockStyle.Bottom;
      this.radGroupBox7.HeaderText = "Action to perform once downloading is over";
      this.radGroupBox7.Location = new Point(0, 294);
      this.radGroupBox7.Name = "radGroupBox7";
      this.radGroupBox7.Size = new Size(0, 66);
      this.radGroupBox7.TabIndex = 30;
      this.radGroupBox7.Text = "Action to perform once downloading is over";
      this.chkPrepareEmulation.Anchor = AnchorStyles.None;
      this.chkPrepareEmulation.Location = new Point(23, 44);
      this.chkPrepareEmulation.Name = "chkPrepareEmulation";
      this.chkPrepareEmulation.Size = new Size(112, 18);
      this.chkPrepareEmulation.TabIndex = 26;
      this.chkPrepareEmulation.Text = "Prepare emulation";
      this.chkPack.Anchor = AnchorStyles.None;
      this.chkPack.Location = new Point(-56, 44);
      this.chkPack.Name = "chkPack";
      this.chkPack.Size = new Size(77, 18);
      this.chkPack.TabIndex = 25;
      this.chkPack.Text = "Pack to CIA";
      this.chkPack.ToggleStateChanging += new StateChangingEventHandler(this.chkPack_ToggleStateChanging);
      this.radDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.radDate.Location = new Point(-142, 19);
      this.radDate.Name = "radDate";
      this.radDate.Size = new Size(132, 20);
      this.radDate.TabIndex = 25;
      this.cmdAbortDelay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cmdAbortDelay.Location = new Point(-73, 42);
      this.cmdAbortDelay.Name = "cmdAbortDelay";
      this.cmdAbortDelay.Size = new Size(63, 18);
      this.cmdAbortDelay.TabIndex = 24;
      this.cmdAbortDelay.Text = "Abort";
      this.cmdAbortDelay.Click += new EventHandler(this.cmdAbortDelay_Click);
      this.lblTimeLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.lblTimeLeft.Location = new Point(-167, 45);
      this.lblTimeLeft.Name = "lblTimeLeft";
      this.lblTimeLeft.Size = new Size(11, 18);
      this.lblTimeLeft.TabIndex = 9;
      this.lblTimeLeft.Text = "-";
      this.chkUnpack.Anchor = AnchorStyles.None;
      this.chkUnpack.Location = new Point(-116, 45);
      this.chkUnpack.Name = "chkUnpack";
      this.chkUnpack.Size = new Size(58, 18);
      this.chkUnpack.TabIndex = 24;
      this.chkUnpack.Text = "Unpack";
      this.chkUnpack.ToggleStateChanging += new StateChangingEventHandler(this.chkUnpack_ToggleStateChanging);
      this.chkCopyToSD.Anchor = AnchorStyles.None;
      this.chkCopyToSD.Location = new Point(-199, 45);
      this.chkCopyToSD.Name = "chkCopyToSD";
      this.chkCopyToSD.Size = new Size(79, 18);
      this.chkCopyToSD.TabIndex = 23;
      this.chkCopyToSD.Text = "Copy To SD";
      this.chkCopyToSD.ToggleStateChanged += new StateChangedEventHandler(this.chkCopyToSD_ToggleStateChanged);
      this.chkSleep.Anchor = AnchorStyles.None;
      this.chkSleep.Location = new Point(-114, 21);
      this.chkSleep.Name = "chkSleep";
      this.chkSleep.Size = new Size(47, 18);
      this.chkSleep.TabIndex = 22;
      this.chkSleep.Text = "Sleep";
      this.chkSleep.ToggleStateChanged += new StateChangedEventHandler(this.chkSleep_ToggleStateChanged);
      this.chkShutdown.Anchor = AnchorStyles.None;
      this.chkShutdown.Location = new Point(-199, 21);
      this.chkShutdown.Name = "chkShutdown";
      this.chkShutdown.Size = new Size(74, 18);
      this.chkShutdown.TabIndex = 19;
      this.chkShutdown.Text = "Shut down";
      this.chkShutdown.ToggleStateChanged += new StateChangedEventHandler(this.chkShutdown_ToggleStateChanged);
      this.chkDelay.Anchor = AnchorStyles.None;
      this.chkDelay.Location = new Point(23, 21);
      this.chkDelay.Name = "chkDelay";
      this.chkDelay.Size = new Size(76, 18);
      this.chkDelay.TabIndex = 22;
      this.chkDelay.Text = "Delay start:";
      this.chkDelay.ToggleStateChanged += new StateChangedEventHandler(this.chkDelay_ToggleStateChanged);
      this.chkHibernate.Anchor = AnchorStyles.None;
      this.chkHibernate.Location = new Point(-56, 21);
      this.chkHibernate.Name = "chkHibernate";
      this.chkHibernate.Size = new Size(69, 18);
      this.chkHibernate.TabIndex = 21;
      this.chkHibernate.Text = "Hibernate";
      this.chkHibernate.ToggleStateChanged += new StateChangedEventHandler(this.chkHibernate_ToggleStateChanged);
      this.grpProgressAll.AccessibleRole = AccessibleRole.Grouping;
      this.grpProgressAll.Controls.Add((Control) this.lblTotalEta);
      this.grpProgressAll.Controls.Add((Control) this.totalProgress);
      this.grpProgressAll.Dock = DockStyle.Top;
      this.grpProgressAll.HeaderText = "All games";
      this.grpProgressAll.Location = new Point(0, 158);
      this.grpProgressAll.Name = "grpProgressAll";
      this.grpProgressAll.Padding = new Padding(16);
      this.grpProgressAll.Size = new Size(0, 79);
      this.grpProgressAll.TabIndex = 28;
      this.grpProgressAll.Text = "All games";
      this.lblTotalEta.Dock = DockStyle.Top;
      this.lblTotalEta.Location = new Point(16, 16);
      this.lblTotalEta.Name = "lblTotalEta";
      this.lblTotalEta.Size = new Size(75, 18);
      this.lblTotalEta.TabIndex = 8;
      this.lblTotalEta.Text = "ETA : 00:00:00";
      this.totalProgress.Dock = DockStyle.Bottom;
      this.totalProgress.Location = new Point(16, 39);
      this.totalProgress.Name = "totalProgress";
      this.totalProgress.ShowProgressIndicators = true;
      this.totalProgress.Size = new Size(0, 24);
      this.totalProgress.TabIndex = 11;
      this.totalProgress.Text = "0 %";
      this.radLabel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.radLabel9.Location = new Point(130, 47);
      this.radLabel9.Name = "radLabel9";
      this.radLabel9.Size = new Size(94, 18);
      this.radLabel9.TabIndex = 9;
      this.radLabel9.Text = "Max speed (kB/s):";
      this.radMaxSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.radMaxSpeed.Location = new Point(230, 48);
      this.radMaxSpeed.Maximum = new Decimal(new int[4]
      {
        100000,
        0,
        0,
        0
      });
      this.radMaxSpeed.Name = "radMaxSpeed";
      this.radMaxSpeed.Size = new Size(64, 20);
      this.radMaxSpeed.TabIndex = 24;
      this.radMaxSpeed.TabStop = false;
      this.radMaxSpeed.ValueChanged += new EventHandler(this.radMaxSpeed_ValueChanged);
      this.cmdAbortAll.Dock = DockStyle.Bottom;
      this.cmdAbortAll.Location = new Point(0, 263);
      this.cmdAbortAll.Name = "cmdAbortAll";
      this.cmdAbortAll.Size = new Size(0, 31);
      this.cmdAbortAll.TabIndex = 23;
      this.cmdAbortAll.Text = "&Abort/Pause";
      this.cmdAbortAll.Click += new EventHandler(this.cmdAbortAll_Click);
      this.radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox3.AutoSize = true;
      this.radGroupBox3.Controls.Add((Control) this.cmdDelete);
      this.radGroupBox3.Controls.Add((Control) this.cmdCopy);
      this.radGroupBox3.Controls.Add((Control) this.cmdAddDlc);
      this.radGroupBox3.Controls.Add((Control) this.cmdAddUpdate);
      this.radGroupBox3.Controls.Add((Control) this.cmdAddGame);
      this.radGroupBox3.Dock = DockStyle.Bottom;
      this.radGroupBox3.HeaderText = "Actions";
      this.radGroupBox3.Location = new Point(0, 305);
      this.radGroupBox3.Name = "radGroupBox3";
      this.radGroupBox3.Size = new Size(667, 75);
      this.radGroupBox3.TabIndex = 30;
      this.radGroupBox3.Text = "Actions";
      this.cmdDelete.AccessibleName = "Delete";
      this.cmdDelete.Anchor = AnchorStyles.None;
      this.cmdDelete.DialogResult = DialogResult.Cancel;
      this.cmdDelete.Enabled = false;
      this.cmdDelete.Image = (Image) componentResourceManager.GetObject("cmdDelete.Image");
      this.cmdDelete.Location = new Point(542, 19);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Padding = new Padding(8);
      this.cmdDelete.Size = new Size(106, 53);
      this.cmdDelete.TabIndex = 6;
      this.cmdDelete.Text = "D&elete";
      this.cmdDelete.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
      this.cmdCopy.AccessibleName = "Copy to SD";
      this.cmdCopy.Anchor = AnchorStyles.None;
      this.cmdCopy.DialogResult = DialogResult.Cancel;
      this.cmdCopy.Enabled = false;
      this.cmdCopy.Image = (Image) componentResourceManager.GetObject("cmdCopy.Image");
      this.cmdCopy.Location = new Point(405, 19);
      this.cmdCopy.Name = "cmdCopy";
      this.cmdCopy.Padding = new Padding(8);
      this.cmdCopy.Size = new Size(129, 53);
      this.cmdCopy.TabIndex = 6;
      this.cmdCopy.Text = "&Copy to SD";
      this.cmdCopy.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdCopy.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdCopy.Click += new EventHandler(this.cmdCopy_Click);
      this.cmdAddDlc.AccessibleName = "Add DLC";
      this.cmdAddDlc.Anchor = AnchorStyles.None;
      this.cmdAddDlc.Controls.Add((Control) this.label4);
      this.cmdAddDlc.DialogResult = DialogResult.Cancel;
      this.cmdAddDlc.Enabled = false;
      this.cmdAddDlc.Image = (Image) componentResourceManager.GetObject("cmdAddDlc.Image");
      this.cmdAddDlc.Location = new Point(263, 19);
      this.cmdAddDlc.Name = "cmdAddDlc";
      this.cmdAddDlc.Padding = new Padding(8);
      this.cmdAddDlc.Size = new Size(134, 53);
      this.cmdAddDlc.TabIndex = 6;
      this.cmdAddDlc.Text = "Add &DLC";
      this.cmdAddDlc.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddDlc.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddDlc.Click += new EventHandler(this.cmdAddDlc_Click);
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.ForeColor = System.Drawing.Color.Red;
      this.label4.Location = new Point(56, 39);
      this.label4.Name = "label4";
      this.label4.Size = new Size(63, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "CFW ONLY!";
      this.cmdAddUpdate.AccessibleName = "Add update";
      this.cmdAddUpdate.Anchor = AnchorStyles.None;
      this.cmdAddUpdate.DialogResult = DialogResult.Cancel;
      this.cmdAddUpdate.Enabled = false;
      this.cmdAddUpdate.Image = (Image) componentResourceManager.GetObject("cmdAddUpdate.Image");
      this.cmdAddUpdate.Location = new Point(125, 19);
      this.cmdAddUpdate.Name = "cmdAddUpdate";
      this.cmdAddUpdate.Padding = new Padding(8);
      this.cmdAddUpdate.Size = new Size(130, 53);
      this.cmdAddUpdate.TabIndex = 5;
      this.cmdAddUpdate.Text = "Add &update";
      this.cmdAddUpdate.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddUpdate.Click += new EventHandler(this.cmdAddUpdate_Click);
      this.cmdAddGame.AccessibleName = "Add ";
      this.cmdAddGame.Anchor = AnchorStyles.None;
      this.cmdAddGame.DialogResult = DialogResult.Cancel;
      this.cmdAddGame.Enabled = false;
      this.cmdAddGame.Image = (Image) componentResourceManager.GetObject("cmdAddGame.Image");
      this.cmdAddGame.Location = new Point(19, 19);
      this.cmdAddGame.Name = "cmdAddGame";
      this.cmdAddGame.Padding = new Padding(8);
      this.cmdAddGame.Size = new Size(98, 53);
      this.cmdAddGame.TabIndex = 4;
      this.cmdAddGame.Text = "&Add";
      this.cmdAddGame.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddGame.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddGame.Click += new EventHandler(this.cmdAddGame_Click);
      this.lblTitle.AutoSize = false;
      this.lblTitle.Dock = DockStyle.Top;
      this.lblTitle.Font = new Font("Microsoft Sans Serif", 12f);
      this.lblTitle.Location = new Point(0, 0);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new Size(667, 22);
      this.lblTitle.TabIndex = 27;
      this.lblTitle.Text = "--";
      this.lblTitle.UseMnemonic = false;
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add((Control) this.lblFileEta);
      this.radGroupBox2.Controls.Add((Control) this.pgFile);
      this.radGroupBox2.Dock = DockStyle.Top;
      this.radGroupBox2.HeaderText = "Current file";
      this.radGroupBox2.Location = new Point(0, 0);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Padding = new Padding(16);
      this.radGroupBox2.Size = new Size(0, 79);
      this.radGroupBox2.TabIndex = 33;
      this.radGroupBox2.Text = "Current file";
      this.lblFileEta.Dock = DockStyle.Top;
      this.lblFileEta.Location = new Point(16, 16);
      this.lblFileEta.Name = "lblFileEta";
      this.lblFileEta.Size = new Size(75, 18);
      this.lblFileEta.TabIndex = 8;
      this.lblFileEta.Text = "ETA : 00:00:00";
      this.pgFile.Dock = DockStyle.Bottom;
      this.pgFile.Location = new Point(16, 39);
      this.pgFile.Name = "pgFile";
      this.pgFile.ShowProgressIndicators = true;
      this.pgFile.Size = new Size(0, 24);
      this.pgFile.TabIndex = 11;
      this.pgFile.Text = "0 %";
      this.grpProgressCurrent.AccessibleRole = AccessibleRole.Grouping;
      this.grpProgressCurrent.Controls.Add((Control) this.lblEta);
      this.grpProgressCurrent.Controls.Add((Control) this.NUSGrabberProgress);
      this.grpProgressCurrent.Dock = DockStyle.Top;
      this.grpProgressCurrent.HeaderText = "Current game";
      this.grpProgressCurrent.Location = new Point(0, 79);
      this.grpProgressCurrent.Name = "grpProgressCurrent";
      this.grpProgressCurrent.Padding = new Padding(16);
      this.grpProgressCurrent.Size = new Size(0, 79);
      this.grpProgressCurrent.TabIndex = 32;
      this.grpProgressCurrent.Text = "Current game";
      this.lblEta.Dock = DockStyle.Top;
      this.lblEta.Location = new Point(16, 16);
      this.lblEta.Name = "lblEta";
      this.lblEta.Size = new Size(75, 18);
      this.lblEta.TabIndex = 8;
      this.lblEta.Text = "ETA : 00:00:00";
      this.NUSGrabberProgress.Dock = DockStyle.Bottom;
      this.NUSGrabberProgress.Location = new Point(16, 39);
      this.NUSGrabberProgress.Name = "NUSGrabberProgress";
      this.NUSGrabberProgress.ShowProgressIndicators = true;
      this.NUSGrabberProgress.Size = new Size(0, 24);
      this.NUSGrabberProgress.TabIndex = 11;
      this.NUSGrabberProgress.Text = "0 %";
      this.dockMain.ActiveWindow = (DockWindow) this.toolLibrary;
      this.dockMain.CausesValidation = false;
      this.dockMain.Controls.Add((Control) this.toolTabStrip3);
      this.dockMain.Controls.Add((Control) this.radSplitContainer3);
      this.dockMain.Controls.Add((Control) this.toolTabStrip6);
      this.dockMain.Dock = DockStyle.Fill;
      this.dockMain.IsCleanUpTarget = true;
      this.dockMain.Location = new Point(0, 0);
      this.dockMain.MainDocumentContainer = this.documentContainer1;
      this.dockMain.Name = "dockMain";
      this.dockMain.Orientation = Orientation.Horizontal;
      this.dockMain.RootElement.MinSize = new Size(25, 25);
      autoHideGroup1.Windows.Add((DockWindow) this.dockWindowPlaceholder1);
      autoHideGroup2.Windows.Add((DockWindow) this.dockWindowPlaceholder2);
      this.dockMain.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup1);
      this.dockMain.SerializableAutoHideContainer.RightAutoHideGroups.Add(autoHideGroup2);
      this.dockMain.Size = new Size(1146, 633);
      this.dockMain.SplitterWidth = 2;
      this.dockMain.TabIndex = 32;
      this.dockMain.TabStop = false;
      this.dockMain.Text = "radDock1";
      this.dockMain.ActiveWindowChanged += new DockWindowEventHandler(this.dockMain_ActiveWindowChanged);
      this.toolCopy.Caption = (string) null;
      this.toolCopy.Controls.Add((Control) this.lstCopy);
      this.toolCopy.Controls.Add((Control) this.cmdSendWiiu);
      this.toolCopy.Controls.Add((Control) this.cmdManageRemoteSd);
      this.toolCopy.Controls.Add((Control) this.cmdInitiateCopy);
      this.toolCopy.Controls.Add((Control) this.radGroupBox10);
      this.toolCopy.Controls.Add((Control) this.radLabel6);
      this.toolCopy.DocumentButtons = DocumentStripButtons.None;
      this.toolCopy.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolCopy.Location = new Point(1, 6);
      this.toolCopy.Name = "toolCopy";
      this.toolCopy.PreviousDockState = DockState.Docked;
      this.toolCopy.Size = new Size(0, 396);
      this.toolCopy.Text = "Copy Queue";
      this.toolCopy.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.lstCopy.AllowColumnReorder = false;
      this.lstCopy.AllowColumnResize = false;
      this.lstCopy.AllowEdit = false;
      this.lstCopy.AllowRemove = false;
      this.lstCopy.Dock = DockStyle.Fill;
      this.lstCopy.Font = new Font("Segoe UI", 9f);
      this.lstCopy.Location = new Point(0, 18);
      this.lstCopy.Name = "lstCopy";
      this.lstCopy.Size = new Size(0, 266);
      this.lstCopy.TabIndex = 35;
      this.lstCopy.ItemMouseDoubleClick += new ListViewItemEventHandler(this.lstCopy_ItemMouseDoubleClick);
      this.cmdSendWiiu.Dock = DockStyle.Bottom;
      this.cmdSendWiiu.Location = new Point(0, 284);
      this.cmdSendWiiu.Name = "cmdSendWiiu";
      this.cmdSendWiiu.Size = new Size(0, 24);
      this.cmdSendWiiu.TabIndex = 1;
      this.cmdSendWiiu.Text = "Send to WiiU";
      this.cmdSendWiiu.Click += new EventHandler(this.cmdSendWiiu_Click);
      this.cmdManageRemoteSd.Dock = DockStyle.Bottom;
      this.cmdManageRemoteSd.Location = new Point(0, 308);
      this.cmdManageRemoteSd.Name = "cmdManageRemoteSd";
      this.cmdManageRemoteSd.Size = new Size(0, 24);
      this.cmdManageRemoteSd.TabIndex = 2;
      this.cmdManageRemoteSd.Text = "Manage games stored on the WiiU's SD card.\r\n";
      this.cmdManageRemoteSd.Click += new EventHandler(this.cmdManageRemoteSd_Click);
      this.cmdInitiateCopy.Dock = DockStyle.Bottom;
      this.cmdInitiateCopy.Location = new Point(0, 332);
      this.cmdInitiateCopy.Name = "cmdInitiateCopy";
      this.cmdInitiateCopy.Size = new Size(0, 24);
      this.cmdInitiateCopy.TabIndex = 0;
      this.cmdInitiateCopy.Text = "Copy to SD";
      this.cmdInitiateCopy.Click += new EventHandler(this.cmdInitiateCopy_Click);
      this.radGroupBox10.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox10.Controls.Add((Control) this.lblTotalCopy);
      this.radGroupBox10.Controls.Add((Control) this.radLabel1);
      this.radGroupBox10.Controls.Add((Control) this.radButton1);
      this.radGroupBox10.Dock = DockStyle.Bottom;
      this.radGroupBox10.HeaderText = "Info";
      this.radGroupBox10.Location = new Point(0, 356);
      this.radGroupBox10.Name = "radGroupBox10";
      this.radGroupBox10.Size = new Size(0, 40);
      this.radGroupBox10.TabIndex = 36;
      this.radGroupBox10.Text = "Info";
      this.lblTotalCopy.Dock = DockStyle.Left;
      this.lblTotalCopy.Location = new Point(79, 18);
      this.lblTotalCopy.Name = "lblTotalCopy";
      this.lblTotalCopy.Size = new Size(28, 20);
      this.lblTotalCopy.TabIndex = 18;
      this.lblTotalCopy.Text = "0 KB";
      this.radLabel1.Dock = DockStyle.Left;
      this.radLabel1.Location = new Point(2, 18);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(77, 20);
      this.radLabel1.TabIndex = 17;
      this.radLabel1.Text = "Total to copy :";
      this.radButton1.Dock = DockStyle.Right;
      this.radButton1.Location = new Point(-112, 18);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(110, 20);
      this.radButton1.TabIndex = 26;
      this.radButton1.Text = "Clear";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.radLabel6.Dock = DockStyle.Top;
      this.radLabel6.Location = new Point(0, 0);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(0, 18);
      this.radLabel6.TabIndex = 34;
      this.radLabel6.Text = "Copy List (Double Click to remove)";
      this.toolTabStrip3.CanUpdateChildIndex = true;
      this.toolTabStrip3.CaptionVisible = false;
      this.toolTabStrip3.CausesValidation = false;
      this.toolTabStrip3.Controls.Add((Control) this.toolWindow5);
      this.toolTabStrip3.Location = new Point(5, 5);
      this.toolTabStrip3.Name = "toolTabStrip3";
      this.toolTabStrip3.RootElement.MinSize = new Size(0, 0);
      this.toolTabStrip3.SelectedIndex = 0;
      this.toolTabStrip3.ShowItemToolTips = false;
      this.toolTabStrip3.Size = new Size(1136, 105);
      this.toolTabStrip3.SizeInfo.AbsoluteSize = new Size(200, 105);
      this.toolTabStrip3.SizeInfo.SplitterCorrection = new Size(0, -95);
      this.toolTabStrip3.TabIndex = 2;
      this.toolTabStrip3.TabStop = false;
      this.toolWindow5.Caption = (string) null;
      this.toolWindow5.Controls.Add((Control) this.pbBanner);
      this.toolWindow5.DocumentButtons = DocumentStripButtons.None;
      this.toolWindow5.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolWindow5.Location = new Point(1, 2);
      this.toolWindow5.Name = "toolWindow5";
      this.toolWindow5.PreviousDockState = DockState.Docked;
      this.toolWindow5.Size = new Size(1134, 101);
      this.toolWindow5.Text = "toolWindow5";
      this.toolWindow5.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.pbBanner.Dock = DockStyle.Fill;
      this.pbBanner.Image = (Image) componentResourceManager.GetObject("pbBanner.Image");
      this.pbBanner.ImageLocation = "";
      this.pbBanner.ImeMode = ImeMode.NoControl;
      this.pbBanner.Location = new Point(0, 0);
      this.pbBanner.Name = "pbBanner";
      this.pbBanner.Size = new Size(1134, 101);
      this.pbBanner.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pbBanner.TabIndex = 19;
      this.pbBanner.TabStop = false;
      this.radSplitContainer3.CausesValidation = false;
      this.radSplitContainer3.Controls.Add((Control) this.documentContainer1);
      this.radSplitContainer3.Controls.Add((Control) this.toolTabStrip1);
      this.radSplitContainer3.Controls.Add((Control) this.toolTabStrip2);
      this.radSplitContainer3.Controls.Add((Control) this.toolTabStrip4);
      this.radSplitContainer3.IsCleanUpTarget = true;
      this.radSplitContainer3.Location = new Point(5, 112);
      this.radSplitContainer3.Name = "radSplitContainer3";
      this.radSplitContainer3.Padding = new Padding(5);
      this.radSplitContainer3.RootElement.MinSize = new Size(25, 25);
      this.radSplitContainer3.Size = new Size(1136, 404);
      this.radSplitContainer3.SizeInfo.AbsoluteSize = new Size(200, 375);
      this.radSplitContainer3.SizeInfo.SplitterCorrection = new Size(0, 185);
      this.radSplitContainer3.SplitterWidth = 2;
      this.radSplitContainer3.TabIndex = 0;
      this.radSplitContainer3.TabStop = false;
      this.documentContainer1.CausesValidation = false;
      this.documentContainer1.Controls.Add((Control) this.documentTabStrip1);
      this.documentContainer1.Name = "documentContainer1";
      this.documentContainer1.RootElement.MinSize = new Size(25, 25);
      this.documentContainer1.SizeInfo.AbsoluteSize = new Size(461, 200);
      this.documentContainer1.SizeInfo.SizeMode = SplitPanelSizeMode.Fill;
      this.documentContainer1.SizeInfo.SplitterCorrection = new Size(-1092, 0);
      this.documentContainer1.SplitterWidth = 2;
      this.documentTabStrip1.CanUpdateChildIndex = true;
      this.documentTabStrip1.CausesValidation = false;
      this.documentTabStrip1.Controls.Add((Control) this.toolLibrary);
      this.documentTabStrip1.Controls.Add((Control) this.toolFilters);
      this.documentTabStrip1.Controls.Add((Control) this.toolAdvancedSearch);
      this.documentTabStrip1.Controls.Add((Control) this.toolAdvancedSettings);
      this.documentTabStrip1.Controls.Add((Control) this.toolEmuSettings);
      this.documentTabStrip1.Controls.Add((Control) this.toolContribute);
      this.documentTabStrip1.Controls.Add((Control) this.toolHelp);
      this.documentTabStrip1.Location = new Point(0, 0);
      this.documentTabStrip1.Name = "documentTabStrip1";
      this.documentTabStrip1.RootElement.MinSize = new Size(0, 0);
      this.documentTabStrip1.SelectedIndex = 0;
      this.documentTabStrip1.Size = new Size(461, 404);
      this.documentTabStrip1.TabIndex = 0;
      this.documentTabStrip1.TabStop = false;
      this.toolLibrary.AutoScroll = true;
      this.toolLibrary.Caption = (string) null;
      this.toolLibrary.Controls.Add((Control) this.radGroupBox4);
      this.toolLibrary.DefaultFloatingSize = new Size(600, 700);
      this.toolLibrary.DocumentButtons = DocumentStripButtons.None;
      this.toolLibrary.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolLibrary.Image = (Image) componentResourceManager.GetObject("toolLibrary.Image");
      this.toolLibrary.Location = new Point(6, 29);
      this.toolLibrary.Name = "toolLibrary";
      this.toolLibrary.PreviousDockState = DockState.Floating;
      this.toolLibrary.Size = new Size(449, 369);
      this.toolLibrary.Text = "Library";
      this.toolLibrary.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox4.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox4.AutoSize = true;
      this.radGroupBox4.Controls.Add((Control) this.radSplitContainer1);
      this.radGroupBox4.Dock = DockStyle.Fill;
      this.radGroupBox4.HeaderText = "Games";
      this.radGroupBox4.Location = new Point(0, 0);
      this.radGroupBox4.Name = "radGroupBox4";
      this.radGroupBox4.Size = new Size(449, 369);
      this.radGroupBox4.TabIndex = 26;
      this.radGroupBox4.Text = "Games";
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel1);
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel2);
      this.radSplitContainer1.Dock = DockStyle.Fill;
      this.radSplitContainer1.IsCleanUpTarget = true;
      this.radSplitContainer1.Location = new Point(2, 18);
      this.radSplitContainer1.Name = "radSplitContainer1";
      this.radSplitContainer1.Orientation = Orientation.Horizontal;
      this.radSplitContainer1.Padding = new Padding(5);
      this.radSplitContainer1.RootElement.MinSize = new Size(25, 25);
      this.radSplitContainer1.Size = new Size(445, 349);
      this.radSplitContainer1.SplitterWidth = 2;
      this.radSplitContainer1.TabIndex = 0;
      this.radSplitContainer1.TabStop = false;
      this.radSplitContainer1.Text = "radSplitContainer1";
      this.splitPanel1.Controls.Add((Control) this.lstGames);
      this.splitPanel1.Controls.Add((Control) this.chkCompactView);
      this.splitPanel1.Controls.Add((Control) this.FTSearchBox);
      this.splitPanel1.Controls.Add((Control) this.panelLibraryCheckbox);
      this.splitPanel1.Location = new Point(0, 0);
      this.splitPanel1.Name = "splitPanel1";
      this.splitPanel1.RootElement.MinSize = new Size(25, 25);
      this.splitPanel1.Size = new Size(445, 258);
      this.splitPanel1.SizeInfo.AutoSizeScale = new SizeF(0.2391304f, 0.2449275f);
      this.splitPanel1.SizeInfo.SplitterCorrection = new Size(17, 40);
      this.splitPanel1.TabIndex = 0;
      this.splitPanel1.TabStop = false;
      this.splitPanel1.Text = "splitPanel1";
      this.chkCompactView.AutoSize = false;
      this.chkCompactView.Dock = DockStyle.Top;
      this.chkCompactView.Location = new Point(0, 24);
      this.chkCompactView.Name = "chkCompactView";
      this.chkCompactView.RightToLeft = RightToLeft.Yes;
      this.chkCompactView.Size = new Size(445, 18);
      this.chkCompactView.TabIndex = 38;
      this.chkCompactView.Text = "Compact &view";
      this.chkCompactView.ToggleStateChanged += new StateChangedEventHandler(this.chkCompactView_ToggleStateChanged);
      this.panelLibraryCheckbox.Controls.Add((Control) this.chkShowLegit);
      this.panelLibraryCheckbox.Controls.Add((Control) this.chkShowRednand);
      this.panelLibraryCheckbox.Controls.Add((Control) this.chkShowPreviews);
      this.panelLibraryCheckbox.Controls.Add((Control) this.lblNbGms);
      this.panelLibraryCheckbox.Dock = DockStyle.Bottom;
      this.panelLibraryCheckbox.Location = new Point(0, 239);
      this.panelLibraryCheckbox.Name = "panelLibraryCheckbox";
      this.panelLibraryCheckbox.Size = new Size(445, 19);
      this.panelLibraryCheckbox.TabIndex = 0;
      this.chkShowLegit.AutoSize = true;
      this.chkShowLegit.Checked = true;
      this.chkShowLegit.CheckState = CheckState.Checked;
      this.chkShowLegit.Dock = DockStyle.Right;
      this.chkShowLegit.Location = new Point(274, 0);
      this.chkShowLegit.Name = "chkShowLegit";
      this.chkShowLegit.Size = new Size(51, 19);
      this.chkShowLegit.TabIndex = 34;
      this.chkShowLegit.Text = "&Legit";
      this.chkShowLegit.UseVisualStyleBackColor = true;
      this.chkShowLegit.CheckedChanged += new EventHandler(this.chkShowLegit_CheckedChanged);
      this.chkShowRednand.AutoSize = true;
      this.chkShowRednand.Checked = true;
      this.chkShowRednand.CheckState = CheckState.Checked;
      this.chkShowRednand.Dock = DockStyle.Right;
      this.chkShowRednand.Location = new Point(325, 0);
      this.chkShowRednand.Name = "chkShowRednand";
      this.chkShowRednand.Size = new Size(50, 19);
      this.chkShowRednand.TabIndex = 35;
      this.chkShowRednand.Text = "CF&W";
      this.chkShowRednand.UseVisualStyleBackColor = true;
      this.chkShowRednand.CheckedChanged += new EventHandler(this.chkShowRednand_CheckedChanged);
      this.chkShowPreviews.AutoSize = true;
      this.chkShowPreviews.Dock = DockStyle.Right;
      this.chkShowPreviews.Location = new Point(375, 0);
      this.chkShowPreviews.Name = "chkShowPreviews";
      this.chkShowPreviews.Size = new Size(70, 19);
      this.chkShowPreviews.TabIndex = 36;
      this.chkShowPreviews.Text = "Previews";
      this.chkShowPreviews.UseVisualStyleBackColor = true;
      this.chkShowPreviews.CheckedChanged += new EventHandler(this.chkShowPreviews_CheckedChanged);
      this.splitPanel2.Controls.Add((Control) this.dlQueue);
      this.splitPanel2.Controls.Add((Control) this.label2);
      this.splitPanel2.Controls.Add((Control) this.radGroupBox9);
      this.splitPanel2.Location = new Point(0, 260);
      this.splitPanel2.Name = "splitPanel2";
      this.splitPanel2.RootElement.MinSize = new Size(25, 25);
      this.splitPanel2.Size = new Size(445, 89);
      this.splitPanel2.SizeInfo.AutoSizeScale = new SizeF(-0.2391304f, -0.2449275f);
      this.splitPanel2.SizeInfo.SplitterCorrection = new Size(-17, -40);
      this.splitPanel2.TabIndex = 1;
      this.splitPanel2.TabStop = false;
      this.splitPanel2.Text = "splitPanel2";
      this.radGroupBox9.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox9.Controls.Add((Control) this.lblTotalToDl);
      this.radGroupBox9.Controls.Add((Control) this.cmdClearDl);
      this.radGroupBox9.Controls.Add((Control) this.lblTotalDl);
      this.radGroupBox9.Dock = DockStyle.Bottom;
      this.radGroupBox9.HeaderText = "Info";
      this.radGroupBox9.Location = new Point(0, 49);
      this.radGroupBox9.Name = "radGroupBox9";
      this.radGroupBox9.Size = new Size(445, 40);
      this.radGroupBox9.TabIndex = 33;
      this.radGroupBox9.Text = "Info";
      this.cmdClearDl.Dock = DockStyle.Right;
      this.cmdClearDl.Location = new Point(333, 18);
      this.cmdClearDl.Name = "cmdClearDl";
      this.cmdClearDl.Size = new Size(110, 20);
      this.cmdClearDl.TabIndex = 26;
      this.cmdClearDl.Text = "Clea&r";
      this.cmdClearDl.Click += new EventHandler(this.cmdClearDl_Click);
      this.toolFilters.Caption = (string) null;
      this.toolFilters.Controls.Add((Control) this.radGroupBox12);
      this.toolFilters.Controls.Add((Control) this.radGroupBox13);
      this.toolFilters.DefaultFloatingSize = new Size(438, 632);
      this.toolFilters.DocumentButtons = DocumentStripButtons.None;
      this.toolFilters.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolFilters.Image = (Image) componentResourceManager.GetObject("toolFilters.Image");
      this.toolFilters.Location = new Point(6, 29);
      this.toolFilters.Name = "toolFilters";
      this.toolFilters.PreviousDockState = DockState.Floating;
      this.toolFilters.Size = new Size(449, 369);
      this.toolFilters.Text = "Filters";
      this.toolFilters.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox12.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox12.Controls.Add((Control) this.treePlatforms);
      this.radGroupBox12.Dock = DockStyle.Fill;
      this.radGroupBox12.HeaderText = "Platforms";
      this.radGroupBox12.Location = new Point(0, 0);
      this.radGroupBox12.Name = "radGroupBox12";
      this.radGroupBox12.Size = new Size(449, 323);
      this.radGroupBox12.TabIndex = 0;
      this.radGroupBox12.Text = "Platforms";
      this.treePlatforms.Dock = DockStyle.Fill;
      this.treePlatforms.Location = new Point(2, 18);
      this.treePlatforms.Name = "treePlatforms";
      this.treePlatforms.Padding = new Padding(5);
      this.treePlatforms.Size = new Size(445, 303);
      this.treePlatforms.SpacingBetweenNodes = -1;
      this.treePlatforms.TabIndex = 13;
      this.treePlatforms.Text = "radTreeView1";
      this.radGroupBox13.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox13.Controls.Add((Control) this.chkKOR);
      this.radGroupBox13.Controls.Add((Control) this.chkJAP);
      this.radGroupBox13.Controls.Add((Control) this.chkUSA);
      this.radGroupBox13.Controls.Add((Control) this.chkEUR);
      this.radGroupBox13.Dock = DockStyle.Bottom;
      this.radGroupBox13.HeaderText = "Regions";
      this.radGroupBox13.Location = new Point(0, 323);
      this.radGroupBox13.Name = "radGroupBox13";
      this.radGroupBox13.Size = new Size(449, 46);
      this.radGroupBox13.TabIndex = 1;
      this.radGroupBox13.Text = "Regions";
      this.chkKOR.Anchor = AnchorStyles.None;
      this.chkKOR.Image = (Image) componentResourceManager.GetObject("chkKOR.Image");
      this.chkKOR.Location = new Point(329, 17);
      this.chkKOR.Name = "chkKOR";
      this.chkKOR.Size = new Size(47, 18);
      this.chkKOR.TabIndex = 42;
      this.chkKOR.Text = " ";
      this.chkKOR.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.chkKOR.CheckStateChanged += new EventHandler(this.chkKOR_CheckStateChanged);
      this.chkJAP.Anchor = AnchorStyles.None;
      this.chkJAP.Image = (Image) componentResourceManager.GetObject("chkJAP.Image");
      this.chkJAP.Location = new Point(246, 17);
      this.chkJAP.Name = "chkJAP";
      this.chkJAP.Size = new Size(47, 18);
      this.chkJAP.TabIndex = 41;
      this.chkJAP.Text = " ";
      this.chkJAP.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.chkJAP.CheckStateChanged += new EventHandler(this.chkJAP_CheckStateChanged);
      this.chkUSA.Anchor = AnchorStyles.None;
      this.chkUSA.Image = (Image) componentResourceManager.GetObject("chkUSA.Image");
      this.chkUSA.Location = new Point(159, 17);
      this.chkUSA.Name = "chkUSA";
      this.chkUSA.Size = new Size(47, 18);
      this.chkUSA.TabIndex = 40;
      this.chkUSA.Text = " ";
      this.chkUSA.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.chkUSA.CheckStateChanged += new EventHandler(this.chkUSA_CheckStateChanged);
      this.chkEUR.Anchor = AnchorStyles.None;
      this.chkEUR.Image = (Image) componentResourceManager.GetObject("chkEUR.Image");
      this.chkEUR.Location = new Point(72, 17);
      this.chkEUR.Name = "chkEUR";
      this.chkEUR.Size = new Size(47, 18);
      this.chkEUR.TabIndex = 39;
      this.chkEUR.Text = " ";
      this.chkEUR.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.chkEUR.CheckStateChanged += new EventHandler(this.chkEUR_CheckStateChanged);
      this.toolAdvancedSearch.Caption = (string) null;
      this.toolAdvancedSearch.Controls.Add((Control) this.radGroupBox25);
      this.toolAdvancedSearch.Controls.Add((Control) this.cmdSearchWithCriterias);
      this.toolAdvancedSearch.Controls.Add((Control) this.cmdClearCriterias);
      this.toolAdvancedSearch.DocumentButtons = DocumentStripButtons.None;
      this.toolAdvancedSearch.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolAdvancedSearch.Image = (Image) componentResourceManager.GetObject("toolAdvancedSearch.Image");
      this.toolAdvancedSearch.Location = new Point(6, 29);
      this.toolAdvancedSearch.Name = "toolAdvancedSearch";
      this.toolAdvancedSearch.PreviousDockState = DockState.Docked;
      this.toolAdvancedSearch.Size = new Size(449, 369);
      this.toolAdvancedSearch.Text = "Advanced Search";
      this.toolAdvancedSearch.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox25.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox25.Controls.Add((Control) this.chkGameGenres);
      this.radGroupBox25.Dock = DockStyle.Fill;
      this.radGroupBox25.HeaderText = "Genre";
      this.radGroupBox25.Location = new Point(0, 0);
      this.radGroupBox25.Name = "radGroupBox25";
      this.radGroupBox25.Size = new Size(449, 323);
      this.radGroupBox25.TabIndex = 0;
      this.radGroupBox25.Text = "Genre";
      this.chkGameGenres.Dock = DockStyle.Fill;
      this.chkGameGenres.Location = new Point(2, 18);
      this.chkGameGenres.Name = "chkGameGenres";
      this.chkGameGenres.Padding = new Padding(5);
      this.chkGameGenres.Size = new Size(445, 303);
      this.chkGameGenres.TabIndex = 0;
      this.chkGameGenres.Text = "radCheckedListBox1";
      this.cmdSearchWithCriterias.Dock = DockStyle.Bottom;
      this.cmdSearchWithCriterias.Location = new Point(0, 323);
      this.cmdSearchWithCriterias.Name = "cmdSearchWithCriterias";
      this.cmdSearchWithCriterias.Size = new Size(449, 22);
      this.cmdSearchWithCriterias.TabIndex = 1;
      this.cmdSearchWithCriterias.Text = "Search with these criterias";
      this.cmdSearchWithCriterias.Click += new EventHandler(this.cmdSearchWithCriterias_Click);
      this.cmdClearCriterias.Dock = DockStyle.Bottom;
      this.cmdClearCriterias.Location = new Point(0, 345);
      this.cmdClearCriterias.Name = "cmdClearCriterias";
      this.cmdClearCriterias.Size = new Size(449, 24);
      this.cmdClearCriterias.TabIndex = 2;
      this.cmdClearCriterias.Text = "Clear criterias";
      this.cmdClearCriterias.Click += new EventHandler(this.cmdClearCriterias_Click);
      this.toolAdvancedSettings.Caption = (string) null;
      this.toolAdvancedSettings.Controls.Add((Control) this.radGroupBox28);
      this.toolAdvancedSettings.Controls.Add((Control) this.radGroupBox22);
      this.toolAdvancedSettings.Controls.Add((Control) this.radGroupBox14);
      this.toolAdvancedSettings.DocumentButtons = DocumentStripButtons.None;
      this.toolAdvancedSettings.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolAdvancedSettings.Image = (Image) componentResourceManager.GetObject("toolAdvancedSettings.Image");
      this.toolAdvancedSettings.Location = new Point(6, 29);
      this.toolAdvancedSettings.Name = "toolAdvancedSettings";
      this.toolAdvancedSettings.PreviousDockState = DockState.Floating;
      this.toolAdvancedSettings.Size = new Size(449, 369);
      this.toolAdvancedSettings.Text = "Advanced settings";
      this.toolAdvancedSettings.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox28.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox28.Controls.Add((Control) this.lblStorageLocation);
      this.radGroupBox28.Controls.Add((Control) this.radButton5);
      this.radGroupBox28.Dock = DockStyle.Top;
      this.radGroupBox28.HeaderText = "Storage location";
      this.radGroupBox28.Location = new Point(0, 205);
      this.radGroupBox28.Name = "radGroupBox28";
      this.radGroupBox28.Padding = new Padding(10, 25, 10, 15);
      this.radGroupBox28.Size = new Size(449, 166);
      this.radGroupBox28.TabIndex = 36;
      this.radGroupBox28.Text = "Storage location";
      this.lblStorageLocation.Dock = DockStyle.Fill;
      this.lblStorageLocation.Location = new Point(10, 25);
      this.lblStorageLocation.Name = "lblStorageLocation";
      this.lblStorageLocation.Size = new Size(429, 102);
      this.lblStorageLocation.TabIndex = 0;
      this.lblStorageLocation.Text = "\r\n";
      this.radButton5.Dock = DockStyle.Bottom;
      this.radButton5.Location = new Point(10, (int) sbyte.MaxValue);
      this.radButton5.Name = "radButton5";
      this.radButton5.Size = new Size(429, 24);
      this.radButton5.TabIndex = 0;
      this.radButton5.Text = "Analyze disk usage";
      this.radButton5.Click += new EventHandler(this.radButton5_Click);
      this.radGroupBox22.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox22.Controls.Add((Control) this.chkDisableSpeedGraph);
      this.radGroupBox22.Controls.Add((Control) this.chkPreventShortcut);
      this.radGroupBox22.Dock = DockStyle.Top;
      this.radGroupBox22.HeaderText = "Miscellaneous";
      this.radGroupBox22.Location = new Point(0, 144);
      this.radGroupBox22.Name = "radGroupBox22";
      this.radGroupBox22.Size = new Size(449, 61);
      this.radGroupBox22.TabIndex = 35;
      this.radGroupBox22.Text = "Miscellaneous";
      this.chkDisableSpeedGraph.Location = new Point(207, 29);
      this.chkDisableSpeedGraph.Name = "chkDisableSpeedGraph";
      this.chkDisableSpeedGraph.Size = new Size(229, 18);
      this.chkDisableSpeedGraph.TabIndex = 1;
      this.chkDisableSpeedGraph.Text = "Disable the speed graph (restart required)";
      this.chkDisableSpeedGraph.ToggleStateChanged += new StateChangedEventHandler(this.chkDisableSpeedGraph_ToggleStateChanged);
      this.chkPreventShortcut.Location = new Point(17, 29);
      this.chkPreventShortcut.Name = "chkPreventShortcut";
      this.chkPreventShortcut.Size = new Size(188, 18);
      this.chkPreventShortcut.TabIndex = 0;
      this.chkPreventShortcut.Text = "Don't geneate a desktop shortcut";
      this.chkPreventShortcut.ToggleStateChanged += new StateChangedEventHandler(this.chkPreventShortcut_ToggleStateChanged);
      this.radGroupBox14.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox14.Controls.Add((Control) this.lblproxyStatus);
      this.radGroupBox14.Controls.Add((Control) this.radLabel12);
      this.radGroupBox14.Controls.Add((Control) this.cmdClearProxy);
      this.radGroupBox14.Controls.Add((Control) this.cmdSetProxy);
      this.radGroupBox14.Controls.Add((Control) this.radTextBox1);
      this.radGroupBox14.Controls.Add((Control) this.txtProxyUsr);
      this.radGroupBox14.Controls.Add((Control) this.txtProxyPassword);
      this.radGroupBox14.Controls.Add((Control) this.radLabel11);
      this.radGroupBox14.Controls.Add((Control) this.txtProxyUrl);
      this.radGroupBox14.Controls.Add((Control) this.radLabel10);
      this.radGroupBox14.Dock = DockStyle.Top;
      this.radGroupBox14.HeaderText = "Http Proxy";
      this.radGroupBox14.Location = new Point(0, 0);
      this.radGroupBox14.Name = "radGroupBox14";
      this.radGroupBox14.Size = new Size(449, 144);
      this.radGroupBox14.TabIndex = 34;
      this.radGroupBox14.Text = "Http Proxy";
      this.lblproxyStatus.ForeColor = System.Drawing.Color.Red;
      this.lblproxyStatus.Location = new Point(85, 121);
      this.lblproxyStatus.Name = "lblproxyStatus";
      this.lblproxyStatus.Size = new Size(43, 18);
      this.lblproxyStatus.TabIndex = 4;
      this.lblproxyStatus.Text = "Not set";
      this.radLabel12.Location = new Point(7, 121);
      this.radLabel12.Name = "radLabel12";
      this.radLabel12.Size = new Size(72, 18);
      this.radLabel12.TabIndex = 3;
      this.radLabel12.Text = "Proxy status :";
      this.cmdClearProxy.Anchor = AnchorStyles.None;
      this.cmdClearProxy.Location = new Point(227, 93);
      this.cmdClearProxy.Name = "cmdClearProxy";
      this.cmdClearProxy.Size = new Size(167, 26);
      this.cmdClearProxy.TabIndex = 40;
      this.cmdClearProxy.Text = "Clear";
      this.cmdClearProxy.Click += new EventHandler(this.cmdClearProxy_Click);
      this.cmdSetProxy.Anchor = AnchorStyles.None;
      this.cmdSetProxy.Location = new Point(54, 93);
      this.cmdSetProxy.Name = "cmdSetProxy";
      this.cmdSetProxy.Size = new Size(167, 26);
      this.cmdSetProxy.TabIndex = 39;
      this.cmdSetProxy.Text = "Set";
      this.cmdSetProxy.Click += new EventHandler(this.cmdSetProxy_Click);
      this.radTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.radTextBox1.Location = new Point(272, 66);
      this.radTextBox1.MinimumSize = new Size(0, 24);
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.RootElement.MinSize = new Size(0, 24);
      this.radTextBox1.Size = new Size(164, 24);
      this.radTextBox1.TabIndex = 38;
      this.txtProxyUsr.Location = new Point(85, 66);
      this.txtProxyUsr.MinimumSize = new Size(0, 24);
      this.txtProxyUsr.Name = "txtProxyUsr";
      this.txtProxyUsr.RootElement.MinSize = new Size(0, 24);
      this.txtProxyUsr.Size = new Size(99, 24);
      this.txtProxyUsr.TabIndex = 36;
      this.txtProxyPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.txtProxyPassword.Location = new Point(207, 72);
      this.txtProxyPassword.Name = "txtProxyPassword";
      this.txtProxyPassword.Size = new Size(59, 18);
      this.txtProxyPassword.TabIndex = 37;
      this.txtProxyPassword.Text = "Password :";
      this.radLabel11.Location = new Point(17, 72);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new Size(62, 18);
      this.radLabel11.TabIndex = 2;
      this.radLabel11.Text = "Username :";
      this.txtProxyUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.txtProxyUrl.Location = new Point(49, 27);
      this.txtProxyUrl.MinimumSize = new Size(0, 24);
      this.txtProxyUrl.Name = "txtProxyUrl";
      this.txtProxyUrl.NullText = "http://someproxy.com:8080";
      this.txtProxyUrl.RootElement.MinSize = new Size(0, 24);
      this.txtProxyUrl.Size = new Size(387, 24);
      this.txtProxyUrl.TabIndex = 35;
      this.radLabel10.Location = new Point(17, 28);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new Size(26, 18);
      this.radLabel10.TabIndex = 1;
      this.radLabel10.Text = "Url :";
      this.toolEmuSettings.Caption = (string) null;
      this.toolEmuSettings.Controls.Add((Control) this.radGroupBox5);
      this.toolEmuSettings.Controls.Add((Control) this.radGroupBox21);
      this.toolEmuSettings.Controls.Add((Control) this.radGroupBox17);
      this.toolEmuSettings.DocumentButtons = DocumentStripButtons.None;
      this.toolEmuSettings.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolEmuSettings.Image = (Image) componentResourceManager.GetObject("toolEmuSettings.Image");
      this.toolEmuSettings.Location = new Point(6, 29);
      this.toolEmuSettings.Name = "toolEmuSettings";
      this.toolEmuSettings.PreviousDockState = DockState.Docked;
      this.toolEmuSettings.Size = new Size(449, 369);
      this.toolEmuSettings.Text = "Emu. settings";
      this.toolEmuSettings.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox5.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox5.Controls.Add((Control) this.radButton7);
      this.radGroupBox5.Dock = DockStyle.Top;
      this.radGroupBox5.HeaderText = "Cloud saving";
      this.radGroupBox5.Location = new Point(0, 280);
      this.radGroupBox5.Name = "radGroupBox5";
      this.radGroupBox5.Padding = new Padding(20);
      this.radGroupBox5.Size = new Size(449, 92);
      this.radGroupBox5.TabIndex = 4;
      this.radGroupBox5.Text = "Cloud saving";
      this.radButton7.DialogResult = DialogResult.Cancel;
      this.radButton7.Dock = DockStyle.Fill;
      this.radButton7.Image = (Image) componentResourceManager.GetObject("radButton7.Image");
      this.radButton7.Location = new Point(20, 20);
      this.radButton7.Name = "radButton7";
      this.radButton7.Padding = new Padding(3, 0, 0, 0);
      this.radButton7.Size = new Size(409, 52);
      this.radButton7.TabIndex = 7;
      this.radButton7.Text = "Configure cloud saving";
      this.radButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.radButton7.Click += new EventHandler(this.radButton7_Click);
      this.radGroupBox21.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox21.Controls.Add((Control) this.radLabel22);
      this.radGroupBox21.Controls.Add((Control) this.radButton2);
      this.radGroupBox21.Controls.Add((Control) this.chkForceGameMode);
      this.radGroupBox21.Controls.Add((Control) this.radLabel23);
      this.radGroupBox21.Controls.Add((Control) this.radLabel13);
      this.radGroupBox21.Dock = DockStyle.Top;
      this.radGroupBox21.HeaderText = "Game Mode (NEW VERSION!";
      this.radGroupBox21.Location = new Point(0, 109);
      this.radGroupBox21.Name = "radGroupBox21";
      this.radGroupBox21.Padding = new Padding(15);
      this.radGroupBox21.Size = new Size(449, 171);
      this.radGroupBox21.TabIndex = 3;
      this.radGroupBox21.Text = "Game Mode (NEW VERSION!";
      this.radLabel22.Dock = DockStyle.Bottom;
      this.radLabel22.Location = new Point(15, 47);
      this.radLabel22.Name = "radLabel22";
      this.radLabel22.Size = new Size(419, 18);
      this.radLabel22.TabIndex = 8;
      this.radLabel22.Text = " ";
      this.radButton2.DialogResult = DialogResult.Cancel;
      this.radButton2.Dock = DockStyle.Bottom;
      this.radButton2.Image = (Image) componentResourceManager.GetObject("radButton2.Image");
      this.radButton2.Location = new Point(15, 65);
      this.radButton2.Name = "radButton2";
      this.radButton2.Padding = new Padding(8);
      this.radButton2.Size = new Size(419, 55);
      this.radButton2.TabIndex = 6;
      this.radButton2.Text = "Switch to Game Mode";
      this.radButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.radButton2.Click += new EventHandler(this.radButton2_Click);
      this.chkForceGameMode.Dock = DockStyle.Bottom;
      this.chkForceGameMode.Location = new Point(15, 120);
      this.chkForceGameMode.Margin = new Padding(10);
      this.chkForceGameMode.Name = "chkForceGameMode";
      this.chkForceGameMode.Size = new Size(419, 18);
      this.chkForceGameMode.TabIndex = 7;
      this.chkForceGameMode.Text = "Automatically launch Game Mode on start";
      this.chkForceGameMode.ToggleStateChanged += new StateChangedEventHandler(this.chkForceGameMode_ToggleStateChanged);
      this.radLabel23.Dock = DockStyle.Bottom;
      this.radLabel23.Location = new Point(15, 138);
      this.radLabel23.Name = "radLabel23";
      this.radLabel23.Size = new Size(419, 18);
      this.radLabel23.TabIndex = 9;
      this.radLabel23.Text = " ";
      this.radLabel13.Location = new Point(18, 23);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new Size(319, 18);
      this.radLabel13.TabIndex = 0;
      this.radLabel13.Text = "Game Mode is a brand new interface optimized for controllers.";
      this.radGroupBox17.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox17.Controls.Add((Control) this.radButton4);
      this.radGroupBox17.Dock = DockStyle.Top;
      this.radGroupBox17.HeaderText = "Configure emulators";
      this.radGroupBox17.Location = new Point(0, 0);
      this.radGroupBox17.Name = "radGroupBox17";
      this.radGroupBox17.Padding = new Padding(20, 30, 20, 20);
      this.radGroupBox17.Size = new Size(449, 109);
      this.radGroupBox17.TabIndex = 1;
      this.radGroupBox17.Text = "Configure emulators";
      this.radButton4.DialogResult = DialogResult.Cancel;
      this.radButton4.Dock = DockStyle.Fill;
      this.radButton4.Image = (Image) componentResourceManager.GetObject("radButton4.Image");
      this.radButton4.Location = new Point(20, 30);
      this.radButton4.Name = "radButton4";
      this.radButton4.Padding = new Padding(3, 0, 0, 0);
      this.radButton4.Size = new Size(409, 59);
      this.radButton4.TabIndex = 7;
      this.radButton4.Text = "Configure emulators";
      this.radButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.radButton4.Click += new EventHandler(this.radButton4_Click);
      this.toolContribute.Caption = (string) null;
      this.toolContribute.Controls.Add((Control) this.radGroupBox15);
      this.toolContribute.Controls.Add((Control) this.radGroupBox20);
      this.toolContribute.DocumentButtons = DocumentStripButtons.None;
      this.toolContribute.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolContribute.Image = (Image) componentResourceManager.GetObject("toolContribute.Image");
      this.toolContribute.Location = new Point(6, 29);
      this.toolContribute.Name = "toolContribute";
      this.toolContribute.PreviousDockState = DockState.Floating;
      this.toolContribute.Size = new Size(449, 369);
      this.toolContribute.Text = "Contribute";
      this.toolContribute.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox15.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox15.Controls.Add((Control) this.radGroupBox16);
      this.radGroupBox15.Controls.Add((Control) this.radLabel14);
      this.radGroupBox15.Dock = DockStyle.Fill;
      this.radGroupBox15.HeaderText = "Donation";
      this.radGroupBox15.Location = new Point(0, 100);
      this.radGroupBox15.Name = "radGroupBox15";
      this.radGroupBox15.Size = new Size(449, 269);
      this.radGroupBox15.TabIndex = 35;
      this.radGroupBox15.Text = "Donation";
      this.radGroupBox16.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox16.Controls.Add((Control) this.cmdDonate);
      this.radGroupBox16.Controls.Add((Control) this.lblDonatorDate);
      this.radGroupBox16.Controls.Add((Control) this.lblDonatorStatus);
      this.radGroupBox16.Controls.Add((Control) this.radLabel18);
      this.radGroupBox16.Controls.Add((Control) this.lblDonatorEmail);
      this.radGroupBox16.Controls.Add((Control) this.radLabel16);
      this.radGroupBox16.Controls.Add((Control) this.radLabel15);
      this.radGroupBox16.Dock = DockStyle.Fill;
      this.radGroupBox16.HeaderText = "Info";
      this.radGroupBox16.Location = new Point(2, 18);
      this.radGroupBox16.Name = "radGroupBox16";
      this.radGroupBox16.Size = new Size(445, 249);
      this.radGroupBox16.TabIndex = 40;
      this.radGroupBox16.Text = "Info";
      this.cmdDonate.Dock = DockStyle.Bottom;
      this.cmdDonate.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmdDonate.Location = new Point(2, 212);
      this.cmdDonate.Name = "cmdDonate";
      this.cmdDonate.Size = new Size(441, 35);
      this.cmdDonate.TabIndex = 39;
      this.cmdDonate.Text = "Donate or set Donation Key";
      this.cmdDonate.Click += new EventHandler(this.cmdDonate_Click);
      this.lblDonatorDate.Location = new Point(112, 76);
      this.lblDonatorDate.Name = "lblDonatorDate";
      this.lblDonatorDate.Size = new Size(11, 18);
      this.lblDonatorDate.TabIndex = 6;
      this.lblDonatorDate.Text = "-";
      this.lblDonatorStatus.ForeColor = System.Drawing.Color.Red;
      this.lblDonatorStatus.Location = new Point(112, 28);
      this.lblDonatorStatus.Name = "lblDonatorStatus";
      this.lblDonatorStatus.Size = new Size(109, 18);
      this.lblDonatorStatus.TabIndex = 4;
      this.lblDonatorStatus.Text = "You are not a donor.";
      this.radLabel18.Location = new Point(17, 76);
      this.radLabel18.Name = "radLabel18";
      this.radLabel18.Size = new Size(72, 18);
      this.radLabel18.TabIndex = 5;
      this.radLabel18.Text = "Donor since :";
      this.lblDonatorEmail.Location = new Point(112, 52);
      this.lblDonatorEmail.Name = "lblDonatorEmail";
      this.lblDonatorEmail.Size = new Size(11, 18);
      this.lblDonatorEmail.TabIndex = 5;
      this.lblDonatorEmail.Text = "-";
      this.radLabel16.Location = new Point(17, 52);
      this.radLabel16.Name = "radLabel16";
      this.radLabel16.Size = new Size(73, 18);
      this.radLabel16.TabIndex = 4;
      this.radLabel16.Text = "Donor email :";
      this.radLabel15.Location = new Point(17, 28);
      this.radLabel15.Name = "radLabel15";
      this.radLabel15.Size = new Size(91, 18);
      this.radLabel15.TabIndex = 3;
      this.radLabel15.Text = "Donation status :";
      this.radLabel14.Location = new Point(17, 28);
      this.radLabel14.Name = "radLabel14";
      this.radLabel14.Size = new Size(91, 18);
      this.radLabel14.TabIndex = 3;
      this.radLabel14.Text = "Donation status :";
      this.radGroupBox20.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox20.Controls.Add((Control) this.cmdSugegstIdea);
      this.radGroupBox20.Dock = DockStyle.Top;
      this.radGroupBox20.HeaderText = "Suggest features/improvements";
      this.radGroupBox20.Location = new Point(0, 0);
      this.radGroupBox20.Name = "radGroupBox20";
      this.radGroupBox20.Padding = new Padding(20);
      this.radGroupBox20.Size = new Size(449, 100);
      this.radGroupBox20.TabIndex = 10;
      this.radGroupBox20.Text = "Suggest features/improvements";
      this.cmdSugegstIdea.DialogResult = DialogResult.Cancel;
      this.cmdSugegstIdea.Dock = DockStyle.Fill;
      this.cmdSugegstIdea.Image = (Image) componentResourceManager.GetObject("cmdSugegstIdea.Image");
      this.cmdSugegstIdea.Location = new Point(20, 20);
      this.cmdSugegstIdea.Name = "cmdSugegstIdea";
      this.cmdSugegstIdea.Padding = new Padding(8);
      this.cmdSugegstIdea.Size = new Size(409, 60);
      this.cmdSugegstIdea.TabIndex = 8;
      this.cmdSugegstIdea.Text = "   Suggest an idea";
      this.cmdSugegstIdea.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdSugegstIdea.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdSugegstIdea.Click += new EventHandler(this.cmdSugegstIdea_Click);
      this.toolHelp.Caption = (string) null;
      this.toolHelp.Controls.Add((Control) this.radGroupBox24);
      this.toolHelp.DocumentButtons = DocumentStripButtons.None;
      this.toolHelp.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolHelp.Image = (Image) componentResourceManager.GetObject("toolHelp.Image");
      this.toolHelp.Location = new Point(6, 29);
      this.toolHelp.Name = "toolHelp";
      this.toolHelp.PreviousDockState = DockState.Docked;
      this.toolHelp.Size = new Size(449, 369);
      this.toolHelp.Text = "Help";
      this.toolHelp.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox24.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox24.Controls.Add((Control) this.cmdPrepareSd);
      this.radGroupBox24.Dock = DockStyle.Top;
      this.radGroupBox24.HeaderText = "Prepare my SD for homebrew";
      this.radGroupBox24.Location = new Point(0, 0);
      this.radGroupBox24.Name = "radGroupBox24";
      this.radGroupBox24.Padding = new Padding(20);
      this.radGroupBox24.Size = new Size(449, 92);
      this.radGroupBox24.TabIndex = 7;
      this.radGroupBox24.Text = "Prepare my SD for homebrew";
      this.cmdPrepareSd.DialogResult = DialogResult.Cancel;
      this.cmdPrepareSd.Dock = DockStyle.Fill;
      this.cmdPrepareSd.Image = (Image) componentResourceManager.GetObject("cmdPrepareSd.Image");
      this.cmdPrepareSd.Location = new Point(20, 20);
      this.cmdPrepareSd.Name = "cmdPrepareSd";
      this.cmdPrepareSd.Padding = new Padding(8);
      this.cmdPrepareSd.Size = new Size(409, 52);
      this.cmdPrepareSd.TabIndex = 6;
      this.cmdPrepareSd.Text = "Prepare my SD";
      this.cmdPrepareSd.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdPrepareSd.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdPrepareSd.Click += new EventHandler(this.cmdPrepareSd_Click);
      this.toolTabStrip1.CanUpdateChildIndex = true;
      this.toolTabStrip1.Controls.Add((Control) this.toolGameInfo);
      this.toolTabStrip1.Location = new Point(463, 0);
      this.toolTabStrip1.Name = "toolTabStrip1";
      this.toolTabStrip1.RootElement.MinSize = new Size(25, 25);
      this.toolTabStrip1.SelectedIndex = 0;
      this.toolTabStrip1.Size = new Size(669, 404);
      this.toolTabStrip1.SizeInfo.AbsoluteSize = new Size(669, 200);
      this.toolTabStrip1.SizeInfo.SplitterCorrection = new Size(469, 0);
      this.toolTabStrip1.TabIndex = 5;
      this.toolTabStrip1.TabStop = false;
      this.toolGameInfo.AutoScroll = true;
      this.toolGameInfo.Caption = (string) null;
      this.toolGameInfo.Controls.Add((Control) this.radGroupBox6);
      this.toolGameInfo.Controls.Add((Control) this.radGroupBox1);
      this.toolGameInfo.Controls.Add((Control) this.radGroupBox3);
      this.toolGameInfo.Controls.Add((Control) this.lblTitle);
      this.toolGameInfo.DefaultFloatingSize = new Size(600, 400);
      this.toolGameInfo.DocumentButtons = DocumentStripButtons.None;
      this.toolGameInfo.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolGameInfo.Location = new Point(1, 22);
      this.toolGameInfo.Name = "toolGameInfo";
      this.toolGameInfo.PreviousDockState = DockState.Floating;
      this.toolGameInfo.Size = new Size(667, 380);
      this.toolGameInfo.Text = "Game Info";
      this.toolGameInfo.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox6.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox6.Controls.Add((Control) this.dockInfo);
      this.radGroupBox6.Dock = DockStyle.Fill;
      this.radGroupBox6.HeaderText = "About";
      this.radGroupBox6.Location = new Point(0, 22);
      this.radGroupBox6.Name = "radGroupBox6";
      this.radGroupBox6.Size = new Size(667, 204);
      this.radGroupBox6.TabIndex = 32;
      this.radGroupBox6.Text = "About";
      this.dockInfo.ActiveWindow = (DockWindow) this.toolGameDesc;
      this.dockInfo.CausesValidation = false;
      this.dockInfo.Controls.Add((Control) this.documentContainer2);
      this.dockInfo.Dock = DockStyle.Fill;
      this.dockInfo.DocumentManager.ActiveDocumentMenuSortOrder = ActiveDocumentListSortOrder.None;
      this.dockInfo.IsCleanUpTarget = true;
      this.dockInfo.Location = new Point(2, 18);
      this.dockInfo.MainDocumentContainer = this.documentContainer2;
      this.dockInfo.Name = "dockInfo";
      this.dockInfo.RootElement.MinSize = new Size(0, 0);
      this.dockInfo.Size = new Size(663, 184);
      this.dockInfo.SplitterWidth = 2;
      this.dockInfo.TabIndex = 33;
      this.dockInfo.TabStop = false;
      this.dockInfo.Text = "radDock2";
      this.dockInfo.ActiveWindowChanged += new DockWindowEventHandler(this.dockInfo_ActiveWindowChanged);
      this.toolGameDesc.Caption = (string) null;
      this.toolGameDesc.Controls.Add((Control) this.txtDesc);
      this.toolGameDesc.Controls.Add((Control) this.panelGameCover);
      this.toolGameDesc.DocumentButtons = DocumentStripButtons.None;
      this.toolGameDesc.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolGameDesc.Image = (Image) componentResourceManager.GetObject("toolGameDesc.Image");
      this.toolGameDesc.Location = new Point(6, 29);
      this.toolGameDesc.Name = "toolGameDesc";
      this.toolGameDesc.PreviousDockState = DockState.Docked;
      this.toolGameDesc.Size = new Size(641, 139);
      this.toolGameDesc.Text = "Game Info";
      this.toolGameDesc.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.txtDesc.Dock = DockStyle.Fill;
      this.txtDesc.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDesc.IsReadOnly = true;
      this.txtDesc.Location = new Point(0, 0);
      this.txtDesc.Multiline = true;
      this.txtDesc.Name = "txtDesc";
      this.txtDesc.Padding = new Padding(10, 20, 10, 20);
      this.txtDesc.Size = new Size(413, 139);
      this.txtDesc.TabIndex = 20;
      this.panelGameCover.Controls.Add((Control) this.cmdShortcut);
      this.panelGameCover.Controls.Add((Control) this.cmdPlay);
      this.panelGameCover.Controls.Add((Control) this.pictureLogo);
      this.panelGameCover.Controls.Add((Control) this.pbCover);
      this.panelGameCover.Dock = DockStyle.Right;
      this.panelGameCover.Location = new Point(413, 0);
      this.panelGameCover.Name = "panelGameCover";
      this.panelGameCover.Size = new Size(228, 139);
      this.panelGameCover.TabIndex = 25;
      this.cmdShortcut.AccessibleName = "Add desktop shortcut";
      this.cmdShortcut.DialogResult = DialogResult.Cancel;
      this.cmdShortcut.Dock = DockStyle.Bottom;
      this.cmdShortcut.Enabled = false;
      this.cmdShortcut.Image = (Image) componentResourceManager.GetObject("cmdShortcut.Image");
      this.cmdShortcut.Location = new Point(0, 25);
      this.cmdShortcut.Name = "cmdShortcut";
      this.cmdShortcut.Padding = new Padding(8);
      this.cmdShortcut.Size = new Size(228, 57);
      this.cmdShortcut.TabIndex = 22;
      this.cmdShortcut.Text = " Add Desktop/Steam Shortcut";
      this.cmdShortcut.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdShortcut.Click += new EventHandler(this.cmdShortcut_Click);
      this.cmdPlay.AccessibleName = "Play this game";
      this.cmdPlay.DialogResult = DialogResult.Cancel;
      this.cmdPlay.Dock = DockStyle.Bottom;
      this.cmdPlay.Enabled = false;
      this.cmdPlay.Image = (Image) componentResourceManager.GetObject("cmdPlay.Image");
      this.cmdPlay.Location = new Point(0, 82);
      this.cmdPlay.Name = "cmdPlay";
      this.cmdPlay.Padding = new Padding(8);
      this.cmdPlay.Size = new Size(228, 57);
      this.cmdPlay.TabIndex = 5;
      this.cmdPlay.Text = "&Play this game on PC";
      this.cmdPlay.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdPlay.Click += new EventHandler(this.cmdPlay_Click);
      this.pictureLogo.Dock = DockStyle.Top;
      this.pictureLogo.Location = new Point(0, 0);
      this.pictureLogo.Name = "pictureLogo";
      this.pictureLogo.Size = new Size(228, 25);
      this.pictureLogo.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureLogo.TabIndex = 21;
      this.pictureLogo.TabStop = false;
      this.pbCover.Dock = DockStyle.Fill;
      this.pbCover.ImeMode = ImeMode.NoControl;
      this.pbCover.Location = new Point(0, 0);
      this.pbCover.Name = "pbCover";
      this.pbCover.Size = new Size(228, 139);
      this.pbCover.SizeMode = PictureBoxSizeMode.CenterImage;
      this.pbCover.TabIndex = 19;
      this.pbCover.TabStop = false;
      this.pbCover.Paint += new PaintEventHandler(this.pbCover_Paint);
      this.pbCover.DoubleClick += new EventHandler(this.pbCover_DoubleClick);
      this.documentContainer2.CausesValidation = false;
      this.documentContainer2.Controls.Add((Control) this.documentTabStrip2);
      this.documentContainer2.Name = "documentContainer2";
      this.documentContainer2.RootElement.MinSize = new Size(0, 0);
      this.documentContainer2.SizeInfo.SizeMode = SplitPanelSizeMode.Fill;
      this.documentContainer2.SplitterWidth = 2;
      this.documentTabStrip2.CanUpdateChildIndex = true;
      this.documentTabStrip2.CausesValidation = false;
      this.documentTabStrip2.Controls.Add((Control) this.toolGameDesc);
      this.documentTabStrip2.Controls.Add((Control) this.toolMods);
      this.documentTabStrip2.Controls.Add((Control) this.toolExtraInfo);
      this.documentTabStrip2.Controls.Add((Control) this.toolScreenShot);
      this.documentTabStrip2.Controls.Add((Control) this.toolWeb);
      this.documentTabStrip2.Controls.Add((Control) this.toolMovies);
      this.documentTabStrip2.Controls.Add((Control) this.tollSaveManager);
      this.documentTabStrip2.Controls.Add((Control) this.toolChat);
      this.documentTabStrip2.Location = new Point(0, 0);
      this.documentTabStrip2.Name = "documentTabStrip2";
      this.documentTabStrip2.RootElement.MinSize = new Size(0, 0);
      this.documentTabStrip2.SelectedIndex = 0;
      this.documentTabStrip2.Size = new Size(653, 174);
      this.documentTabStrip2.TabIndex = 0;
      this.documentTabStrip2.TabStop = false;
      this.toolMods.Caption = (string) null;
      this.toolMods.Controls.Add((Control) this.lblModsOnlyCemu);
      this.toolMods.Controls.Add((Control) this.radGroupBox29);
      this.toolMods.Controls.Add((Control) this.radGroupBox27);
      this.toolMods.DefaultFloatingSize = new Size(800, 800);
      this.toolMods.DocumentButtons = DocumentStripButtons.None;
      this.toolMods.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolMods.Image = (Image) componentResourceManager.GetObject("toolMods.Image");
      this.toolMods.Location = new Point(6, 29);
      this.toolMods.Name = "toolMods";
      this.toolMods.PreviousDockState = DockState.Docked;
      this.toolMods.Size = new Size(641, 139);
      this.toolMods.Text = "Mods";
      this.toolMods.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.lblModsOnlyCemu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblModsOnlyCemu.AutoSize = false;
      this.lblModsOnlyCemu.Location = new Point(-3, 0);
      this.lblModsOnlyCemu.Name = "lblModsOnlyCemu";
      this.lblModsOnlyCemu.Size = new Size(638, 139);
      this.lblModsOnlyCemu.TabIndex = 3;
      this.lblModsOnlyCemu.Text = "Mods can only be used with Cemu games";
      this.lblModsOnlyCemu.TextAlignment = ContentAlignment.MiddleCenter;
      this.radGroupBox29.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox29.Controls.Add((Control) this.lstMods);
      this.radGroupBox29.Controls.Add((Control) this.txtModSearch);
      this.radGroupBox29.Controls.Add((Control) this.cmdModContribute);
      this.radGroupBox29.Dock = DockStyle.Fill;
      this.radGroupBox29.HeaderText = "Mods- DON'T CLOSE USB HELPER WHILE PLAYING!";
      this.radGroupBox29.Location = new Point(0, 0);
      this.radGroupBox29.Name = "radGroupBox29";
      this.radGroupBox29.Size = new Size(271, 139);
      this.radGroupBox29.TabIndex = 34;
      this.radGroupBox29.Text = "Mods- DON'T CLOSE USB HELPER WHILE PLAYING!";
      this.lstMods.AllowRemove = false;
      this.lstMods.Dock = DockStyle.Fill;
      this.lstMods.EnableFiltering = true;
      this.lstMods.Location = new Point(2, 18);
      this.lstMods.Name = "lstMods";
      this.lstMods.Size = new Size(267, 75);
      this.lstMods.TabIndex = 0;
      this.lstMods.Text = "radCheckedListBox1";
      this.lstMods.SelectedItemChanged += new EventHandler(this.lstMods_SelectedItemChanged);
      this.lstMods.ItemCheckedChanging += new ListViewItemCancelEventHandler(this.lstMods_ItemCheckedChanging);
      this.txtModSearch.CharacterCasing = CharacterCasing.Upper;
      this.txtModSearch.Dock = DockStyle.Bottom;
      this.txtModSearch.Location = new Point(2, 93);
      this.txtModSearch.Name = "txtModSearch";
      this.txtModSearch.NullText = "Search...";
      this.txtModSearch.Size = new Size(267, 20);
      this.txtModSearch.TabIndex = 1;
      this.txtModSearch.TextChanged += new EventHandler(this.txtModSearch_TextChanged);
      this.cmdModContribute.Dock = DockStyle.Bottom;
      this.cmdModContribute.Location = new Point(2, 113);
      this.cmdModContribute.Name = "cmdModContribute";
      this.cmdModContribute.Size = new Size(267, 24);
      this.cmdModContribute.TabIndex = 2;
      this.cmdModContribute.Text = "Suggest new mod/update";
      this.cmdModContribute.Click += new EventHandler(this.cmdModContribute_Click);
      this.radGroupBox27.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox27.Controls.Add((Control) this.modPreview);
      this.radGroupBox27.Controls.Add((Control) this.txtModDescription);
      this.radGroupBox27.Dock = DockStyle.Right;
      this.radGroupBox27.HeaderText = "Info";
      this.radGroupBox27.Location = new Point(271, 0);
      this.radGroupBox27.Name = "radGroupBox27";
      this.radGroupBox27.Size = new Size(370, 139);
      this.radGroupBox27.TabIndex = 1;
      this.radGroupBox27.Text = "Info";
      this.modPreview.BackColor = System.Drawing.Color.Black;
      carouselBezierPath.CtrlPoint1 = new Point3D(14.0, 76.0, 70.0);
      carouselBezierPath.CtrlPoint2 = new Point3D(86.0, 76.0, 70.0);
      carouselBezierPath.FirstPoint = new Point3D(10.0, 20.0, 0.0);
      carouselBezierPath.LastPoint = new Point3D(90.0, 20.0, 0.0);
      carouselBezierPath.ZScale = 500.0;
      this.modPreview.CarouselPath = (CarouselParameterPath) carouselBezierPath;
      this.modPreview.Dock = DockStyle.Fill;
      this.modPreview.Location = new Point(2, 209);
      this.modPreview.Name = "modPreview";
      this.modPreview.SelectedIndex = -1;
      this.modPreview.Size = new Size(366, 0);
      this.modPreview.TabIndex = 1;
      this.modPreview.Text = "Preview";
      this.txtModDescription.Dock = DockStyle.Top;
      this.txtModDescription.Font = new Font("Segoe UI Semibold", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtModDescription.IsReadOnly = true;
      this.txtModDescription.Location = new Point(2, 18);
      this.txtModDescription.Multiline = true;
      this.txtModDescription.Name = "txtModDescription";
      this.txtModDescription.Size = new Size(366, 191);
      this.txtModDescription.TabIndex = 0;
      this.toolExtraInfo.Caption = (string) null;
      this.toolExtraInfo.Controls.Add((Control) this.radGroupBox11);
      this.toolExtraInfo.DocumentButtons = DocumentStripButtons.None;
      this.toolExtraInfo.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolExtraInfo.Image = (Image) componentResourceManager.GetObject("toolExtraInfo.Image");
      this.toolExtraInfo.Location = new Point(6, 29);
      this.toolExtraInfo.Name = "toolExtraInfo";
      this.toolExtraInfo.PreviousDockState = DockState.Floating;
      this.toolExtraInfo.Size = new Size(641, 139);
      this.toolExtraInfo.Text = "Extra";
      this.toolExtraInfo.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radGroupBox11.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox11.Controls.Add((Control) this.lblLang);
      this.radGroupBox11.Controls.Add((Control) this.lstLanguages);
      this.radGroupBox11.Controls.Add((Control) this.pbRating);
      this.radGroupBox11.Controls.Add((Control) this.label10);
      this.radGroupBox11.Controls.Add((Control) this.label3);
      this.radGroupBox11.Controls.Add((Control) this.lstGenre);
      this.radGroupBox11.Controls.Add((Control) this.pgScore);
      this.radGroupBox11.Controls.Add((Control) this.lstControllers);
      this.radGroupBox11.Controls.Add((Control) this.label8);
      this.radGroupBox11.Controls.Add((Control) this.label9);
      this.radGroupBox11.Dock = DockStyle.Fill;
      this.radGroupBox11.HeaderText = "Addtional info";
      this.radGroupBox11.Location = new Point(0, 0);
      this.radGroupBox11.Name = "radGroupBox11";
      this.radGroupBox11.Padding = new Padding(0);
      this.radGroupBox11.Size = new Size(641, 139);
      this.radGroupBox11.TabIndex = 9;
      this.radGroupBox11.Text = "Addtional info";
      this.lblLang.Anchor = AnchorStyles.Bottom;
      this.lblLang.AutoSize = true;
      this.lblLang.Location = new Point(523, 161);
      this.lblLang.Name = "lblLang";
      this.lblLang.Size = new Size(60, 13);
      this.lblLang.TabIndex = 10;
      this.lblLang.Text = "Languages";
      this.lstLanguages.AllowEdit = false;
      this.lstLanguages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
      this.lstLanguages.HorizontalScrollState = ScrollState.AlwaysHide;
      this.lstLanguages.Location = new Point(526, 18);
      this.lstLanguages.Name = "lstLanguages";
      this.lstLanguages.SelectLastAddedItem = false;
      this.lstLanguages.Size = new Size(118, 103);
      this.lstLanguages.TabIndex = 9;
      this.lstLanguages.Text = "radListView1";
      this.pbRating.Anchor = AnchorStyles.None;
      this.pbRating.Location = new Point(10, 29);
      this.pbRating.Name = "pbRating";
      this.pbRating.Size = new Size(66, 80);
      this.pbRating.SizeMode = PictureBoxSizeMode.Zoom;
      this.pbRating.TabIndex = 1;
      this.pbRating.TabStop = false;
      this.label10.Anchor = AnchorStyles.Bottom;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(319, 161);
      this.label10.Name = "label10";
      this.label10.Size = new Size(36, 13);
      this.label10.TabIndex = 8;
      this.label10.Text = "Genre";
      this.label3.Anchor = AnchorStyles.Bottom;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 160);
      this.label3.Name = "label3";
      this.label3.Size = new Size(38, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rating";
      this.lstGenre.AllowEdit = false;
      this.lstGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
      this.lstGenre.Location = new Point(316, 18);
      this.lstGenre.Name = "lstGenre";
      this.lstGenre.SelectLastAddedItem = false;
      this.lstGenre.Size = new Size(204, 103);
      this.lstGenre.TabIndex = 7;
      this.lstGenre.Text = "radListView1";
      this.pgScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
      this.pgScore.Location = new Point(278, 18);
      this.pgScore.Name = "pgScore";
      this.pgScore.ProgressOrientation = ProgressOrientation.Bottom;
      this.pgScore.ShowProgressIndicators = true;
      this.pgScore.Size = new Size(32, 103);
      this.pgScore.TabIndex = 3;
      this.pgScore.Text = "0 %";
      this.lstControllers.AllowEdit = false;
      this.lstControllers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
      this.lstControllers.Location = new Point(81, 18);
      this.lstControllers.Name = "lstControllers";
      this.lstControllers.SelectLastAddedItem = false;
      this.lstControllers.Size = new Size(191, 103);
      this.lstControllers.TabIndex = 6;
      this.lstControllers.Text = "radListView1";
      this.label8.Anchor = AnchorStyles.Bottom;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(278, 161);
      this.label8.Name = "label8";
      this.label8.Size = new Size(35, 13);
      this.label8.TabIndex = 4;
      this.label8.Text = "Score";
      this.label9.Anchor = AnchorStyles.Bottom;
      this.label9.AutoSize = true;
      this.label9.Location = new Point(78, 161);
      this.label9.Name = "label9";
      this.label9.Size = new Size(110, 13);
      this.label9.TabIndex = 5;
      this.label9.Text = "Compatible controllers";
      this.toolScreenShot.Caption = (string) null;
      this.toolScreenShot.Controls.Add((Control) this.pbPreview3);
      this.toolScreenShot.Controls.Add((Control) this.pbPreview1);
      this.toolScreenShot.Controls.Add((Control) this.pbPreview2);
      this.toolScreenShot.DocumentButtons = DocumentStripButtons.None;
      this.toolScreenShot.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolScreenShot.Image = (Image) componentResourceManager.GetObject("toolScreenShot.Image");
      this.toolScreenShot.Location = new Point(6, 29);
      this.toolScreenShot.Name = "toolScreenShot";
      this.toolScreenShot.PreviousDockState = DockState.Docked;
      this.toolScreenShot.Size = new Size(641, 139);
      this.toolScreenShot.Text = "Screenshots";
      this.toolScreenShot.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.pbPreview3.Anchor = AnchorStyles.None;
      this.pbPreview3.ImeMode = ImeMode.NoControl;
      this.pbPreview3.InitialImage = (Image) componentResourceManager.GetObject("pbPreview3.InitialImage");
      this.pbPreview3.Location = new Point(458, 26);
      this.pbPreview3.Name = "pbPreview3";
      this.pbPreview3.Size = new Size(180, 101);
      this.pbPreview3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pbPreview3.TabIndex = 3;
      this.pbPreview3.TabStop = false;
      this.pbPreview1.Anchor = AnchorStyles.None;
      this.pbPreview1.ImeMode = ImeMode.NoControl;
      this.pbPreview1.InitialImage = (Image) componentResourceManager.GetObject("pbPreview1.InitialImage");
      this.pbPreview1.Location = new Point(2, 26);
      this.pbPreview1.Name = "pbPreview1";
      this.pbPreview1.Size = new Size(180, 101);
      this.pbPreview1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pbPreview1.TabIndex = 0;
      this.pbPreview1.TabStop = false;
      this.pbPreview2.Anchor = AnchorStyles.None;
      this.pbPreview2.ImeMode = ImeMode.NoControl;
      this.pbPreview2.InitialImage = (Image) componentResourceManager.GetObject("pbPreview2.InitialImage");
      this.pbPreview2.Location = new Point(227, 26);
      this.pbPreview2.Name = "pbPreview2";
      this.pbPreview2.Size = new Size(180, 101);
      this.pbPreview2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pbPreview2.TabIndex = 2;
      this.pbPreview2.TabStop = false;
      this.toolWeb.Caption = (string) null;
      this.toolWeb.Controls.Add((Control) this.webBrowser);
      this.toolWeb.Controls.Add((Control) this.radGroupBox8);
      this.toolWeb.DefaultFloatingSize = new Size(800, 600);
      this.toolWeb.DocumentButtons = DocumentStripButtons.None;
      this.toolWeb.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolWeb.Image = (Image) componentResourceManager.GetObject("toolWeb.Image");
      this.toolWeb.Location = new Point(6, 29);
      this.toolWeb.Name = "toolWeb";
      this.toolWeb.PreviousDockState = DockState.Docked;
      this.toolWeb.Size = new Size(641, 139);
      this.toolWeb.Text = "On the Web";
      this.toolWeb.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.webBrowser.AllowWebBrowserDrop = false;
      this.webBrowser.Dock = DockStyle.Fill;
      this.webBrowser.Location = new Point(0, 47);
      this.webBrowser.MinimumSize = new Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.ScriptErrorsSuppressed = true;
      this.webBrowser.Size = new Size(641, 92);
      this.webBrowser.TabIndex = 0;
      this.webBrowser.TabStop = false;
      this.radGroupBox8.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox8.AutoSize = true;
      this.radGroupBox8.Controls.Add((Control) this.cmdGoNext);
      this.radGroupBox8.Controls.Add((Control) this.cmdGoBack);
      this.radGroupBox8.Dock = DockStyle.Top;
      this.radGroupBox8.HeaderText = "Commands";
      this.radGroupBox8.Location = new Point(0, 0);
      this.radGroupBox8.Name = "radGroupBox8";
      this.radGroupBox8.Size = new Size(641, 47);
      this.radGroupBox8.TabIndex = 1;
      this.radGroupBox8.Text = "Commands";
      this.cmdGoNext.Location = new Point(104, 21);
      this.cmdGoNext.Name = "cmdGoNext";
      this.cmdGoNext.Size = new Size(87, 24);
      this.cmdGoNext.TabIndex = 1;
      this.cmdGoNext.Text = ">";
      this.cmdGoNext.Click += new EventHandler(this.cmdGoNext_Click);
      this.cmdGoBack.Location = new Point(11, 21);
      this.cmdGoBack.Name = "cmdGoBack";
      this.cmdGoBack.Size = new Size(87, 24);
      this.cmdGoBack.TabIndex = 0;
      this.cmdGoBack.Text = "<";
      this.cmdGoBack.Click += new EventHandler(this.cmdGoBack_Click);
      this.toolMovies.Caption = (string) null;
      this.toolMovies.Controls.Add((Control) this.lstMovies);
      this.toolMovies.Controls.Add((Control) this.radLabel7);
      this.toolMovies.DocumentButtons = DocumentStripButtons.None;
      this.toolMovies.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolMovies.Image = (Image) componentResourceManager.GetObject("toolMovies.Image");
      this.toolMovies.Location = new Point(6, 29);
      this.toolMovies.Name = "toolMovies";
      this.toolMovies.PreviousDockState = DockState.Floating;
      this.toolMovies.Size = new Size(641, 139);
      this.toolMovies.Text = "Movies";
      this.toolMovies.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.lstMovies.AllowEdit = false;
      this.lstMovies.AllowRemove = false;
      this.lstMovies.Dock = DockStyle.Fill;
      this.lstMovies.Location = new Point(0, 18);
      this.lstMovies.Name = "lstMovies";
      this.lstMovies.Size = new Size(641, 121);
      this.lstMovies.TabIndex = 1;
      this.lstMovies.Text = "radListView1";
      this.lstMovies.ItemMouseDoubleClick += new ListViewItemEventHandler(this.lstMovies_ItemMouseDoubleClick);
      this.radLabel7.AutoSize = false;
      this.radLabel7.Dock = DockStyle.Top;
      this.radLabel7.Location = new Point(0, 0);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new Size(641, 18);
      this.radLabel7.TabIndex = 0;
      this.radLabel7.Text = "Note : Double click to play";
      this.tollSaveManager.Caption = (string) null;
      this.tollSaveManager.Controls.Add((Control) this.cmdCommunitySaves);
      this.tollSaveManager.Controls.Add((Control) this.cmdImportCemu);
      this.tollSaveManager.Controls.Add((Control) this.radLabel8);
      this.tollSaveManager.Controls.Add((Control) this.cmdRestoreSave);
      this.tollSaveManager.Controls.Add((Control) this.cmdBackupSave);
      this.tollSaveManager.DocumentButtons = DocumentStripButtons.None;
      this.tollSaveManager.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.tollSaveManager.Image = (Image) componentResourceManager.GetObject("tollSaveManager.Image");
      this.tollSaveManager.Location = new Point(6, 29);
      this.tollSaveManager.Name = "tollSaveManager";
      this.tollSaveManager.PreviousDockState = DockState.Docked;
      this.tollSaveManager.Size = new Size(641, 139);
      this.tollSaveManager.Text = "Save Manager";
      this.tollSaveManager.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.cmdCommunitySaves.Anchor = AnchorStyles.None;
      this.cmdCommunitySaves.DialogResult = DialogResult.Cancel;
      this.cmdCommunitySaves.Image = (Image) Class123.glbIcon;
      this.cmdCommunitySaves.Location = new Point(483, 54);
      this.cmdCommunitySaves.Name = "cmdCommunitySaves";
      this.cmdCommunitySaves.Padding = new Padding(8);
      this.cmdCommunitySaves.Size = new Size(152, 52);
      this.cmdCommunitySaves.TabIndex = 9;
      this.cmdCommunitySaves.Text = " Commmunity ";
      this.cmdCommunitySaves.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdCommunitySaves.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdCommunitySaves.Click += new EventHandler(this.cmdCommunitySaves_Click);
      this.cmdImportCemu.Anchor = AnchorStyles.None;
      this.cmdImportCemu.DialogResult = DialogResult.Cancel;
      this.cmdImportCemu.Image = (Image) componentResourceManager.GetObject("cmdImportCemu.Image");
      this.cmdImportCemu.Location = new Point(164, 53);
      this.cmdImportCemu.Name = "cmdImportCemu";
      this.cmdImportCemu.Padding = new Padding(8);
      this.cmdImportCemu.Size = new Size(160, 53);
      this.cmdImportCemu.TabIndex = 8;
      this.cmdImportCemu.Text = "Import to Cemu";
      this.cmdImportCemu.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdImportCemu.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdImportCemu.Click += new EventHandler(this.cmdImportCemu_Click);
      this.radLabel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.radLabel8.ForeColor = System.Drawing.Color.Red;
      this.radLabel8.Location = new Point(0, 796);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new Size(32, 18);
      this.radLabel8.TabIndex = 7;
      this.radLabel8.Text = "BETA";
      this.cmdRestoreSave.Anchor = AnchorStyles.None;
      this.cmdRestoreSave.DialogResult = DialogResult.Cancel;
      this.cmdRestoreSave.Image = (Image) componentResourceManager.GetObject("cmdRestoreSave.Image");
      this.cmdRestoreSave.Location = new Point(330, 53);
      this.cmdRestoreSave.Name = "cmdRestoreSave";
      this.cmdRestoreSave.Padding = new Padding(8);
      this.cmdRestoreSave.Size = new Size(147, 53);
      this.cmdRestoreSave.TabIndex = 6;
      this.cmdRestoreSave.Text = "Restore Save";
      this.cmdRestoreSave.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdRestoreSave.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdRestoreSave.Click += new EventHandler(this.cmdRestoreSave_Click);
      this.cmdBackupSave.Anchor = AnchorStyles.None;
      this.cmdBackupSave.DialogResult = DialogResult.Cancel;
      this.cmdBackupSave.Image = (Image) componentResourceManager.GetObject("cmdBackupSave.Image");
      this.cmdBackupSave.Location = new Point(11, 53);
      this.cmdBackupSave.Name = "cmdBackupSave";
      this.cmdBackupSave.Padding = new Padding(8);
      this.cmdBackupSave.Size = new Size(147, 53);
      this.cmdBackupSave.TabIndex = 5;
      this.cmdBackupSave.Text = "Backup Save";
      this.cmdBackupSave.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdBackupSave.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdBackupSave.Click += new EventHandler(this.cmdBackupSave_Click);
      this.toolChat.Caption = (string) null;
      this.toolChat.Controls.Add((Control) this.lstChat);
      this.toolChat.Controls.Add((Control) this.txtChat);
      this.toolChat.Controls.Add((Control) this.panelChatBottom);
      this.toolChat.DefaultFloatingSize = new Size(800, 400);
      this.toolChat.DocumentButtons = DocumentStripButtons.None;
      this.toolChat.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolChat.Image = (Image) componentResourceManager.GetObject("toolChat.Image");
      this.toolChat.Location = new Point(6, 29);
      this.toolChat.Name = "toolChat";
      this.toolChat.PreviousDockState = DockState.Docked;
      this.toolChat.Size = new Size(641, 139);
      this.toolChat.Text = "Chat Room";
      this.toolChat.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.lstChat.AllowEdit = false;
      this.lstChat.AllowRemove = false;
      viewDetailColumn9.HeaderText = "Column 0";
      viewDetailColumn9.Width = 2000f;
      this.lstChat.Columns.AddRange(viewDetailColumn9);
      this.lstChat.Dock = DockStyle.Fill;
      this.lstChat.ItemSpacing = 2;
      this.lstChat.Location = new Point(0, 0);
      this.lstChat.Name = "lstChat";
      this.lstChat.ShowColumnHeaders = false;
      this.lstChat.ShowGridLines = true;
      this.lstChat.Size = new Size(641, 101);
      this.lstChat.TabIndex = 1;
      this.lstChat.Text = "radListView1";
      this.lstChat.VisualItemFormatting += new ListViewVisualItemEventHandler(this.lstChat_VisualItemFormatting);
      this.txtChat.Dock = DockStyle.Bottom;
      this.txtChat.Location = new Point(0, 101);
      this.txtChat.MaxLength = 90;
      this.txtChat.Name = "txtChat";
      this.txtChat.NullText = "Type here...";
      this.txtChat.Size = new Size(641, 20);
      this.txtChat.TabIndex = 0;
      this.txtChat.KeyPress += new KeyPressEventHandler(this.txtChat_KeyPress);
      this.panelChatBottom.Controls.Add((Control) this.radioLobby);
      this.panelChatBottom.Controls.Add((Control) this.radioGameRoom);
      this.panelChatBottom.Controls.Add((Control) this.chkNotifyChat);
      this.panelChatBottom.Controls.Add((Control) this.lblChannelClientCount);
      this.panelChatBottom.Dock = DockStyle.Bottom;
      this.panelChatBottom.Location = new Point(0, 121);
      this.panelChatBottom.Name = "panelChatBottom";
      this.panelChatBottom.Size = new Size(641, 18);
      this.panelChatBottom.TabIndex = 3;
      this.radioLobby.Dock = DockStyle.Left;
      this.radioLobby.Location = new Point(301, 0);
      this.radioLobby.Name = "radioLobby";
      this.radioLobby.Size = new Size(118, 18);
      this.radioLobby.TabIndex = 4;
      this.radioLobby.Text = "Join the main lobby";
      this.radioLobby.ToggleStateChanged += new StateChangedEventHandler(this.radioLobby_ToggleStateChanged);
      this.radioGameRoom.Dock = DockStyle.Left;
      this.radioGameRoom.Location = new Point(158, 0);
      this.radioGameRoom.Name = "radioGameRoom";
      this.radioGameRoom.Size = new Size(143, 18);
      this.radioGameRoom.TabIndex = 3;
      this.radioGameRoom.Text = "Join game-specific room";
      this.radioGameRoom.ToggleStateChanged += new StateChangedEventHandler(this.radioGameRoom_ToggleStateChanged);
      this.chkNotifyChat.Dock = DockStyle.Left;
      this.chkNotifyChat.Location = new Point(0, 0);
      this.chkNotifyChat.Name = "chkNotifyChat";
      this.chkNotifyChat.Size = new Size(158, 18);
      this.chkNotifyChat.TabIndex = 0;
      this.chkNotifyChat.Text = "Notify me of new messages";
      this.chkNotifyChat.ToggleStateChanged += new StateChangedEventHandler(this.chkNotifyChat_ToggleStateChanged);
      this.lblChannelClientCount.Dock = DockStyle.Right;
      this.lblChannelClientCount.Location = new Point(512, 0);
      this.lblChannelClientCount.Name = "lblChannelClientCount";
      this.lblChannelClientCount.Size = new Size(129, 18);
      this.lblChannelClientCount.TabIndex = 2;
      this.lblChannelClientCount.Text = "0 client(s) in this channel";
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.AutoSize = true;
      this.radGroupBox1.Controls.Add((Control) this.lblEmuUpdateVersion);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusDLCEmu);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusUpdateEmu);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusGameEmu);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusDLCRaw);
      this.radGroupBox1.Controls.Add((Control) this.radLabel19);
      this.radGroupBox1.Controls.Add((Control) this.radLabel17);
      this.radGroupBox1.Controls.Add((Control) this.lblNbPlayers);
      this.radGroupBox1.Controls.Add((Control) this.radLabel5);
      this.radGroupBox1.Controls.Add((Control) this.radLabel4);
      this.radGroupBox1.Controls.Add((Control) this.lblDLCSize);
      this.radGroupBox1.Controls.Add((Control) this.lblTitleId);
      this.radGroupBox1.Controls.Add((Control) this.radLabel2);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusUpdateRaw);
      this.radGroupBox1.Controls.Add((Control) this.lblStatusGameRaw);
      this.radGroupBox1.Controls.Add((Control) this.lblUpdateSize);
      this.radGroupBox1.Controls.Add((Control) this.label5);
      this.radGroupBox1.Controls.Add((Control) this.lblGameSize);
      this.radGroupBox1.Controls.Add((Control) this.label1);
      this.radGroupBox1.Dock = DockStyle.Bottom;
      this.radGroupBox1.HeaderText = "Technical info";
      this.radGroupBox1.Location = new Point(0, 226);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(667, 79);
      this.radGroupBox1.TabIndex = 29;
      this.radGroupBox1.Text = "Technical info";
      this.lblEmuUpdateVersion.AutoSize = false;
      this.lblEmuUpdateVersion.Location = new Point(372, 58);
      this.lblEmuUpdateVersion.Name = "lblEmuUpdateVersion";
      this.lblEmuUpdateVersion.Size = new Size(43, 18);
      this.lblEmuUpdateVersion.TabIndex = 13;
      this.lblEmuUpdateVersion.Text = "-";
      this.lblEmuUpdateVersion.TextAlignment = ContentAlignment.MiddleCenter;
      this.lblStatusDLCEmu.Location = new Point(426, 41);
      this.lblStatusDLCEmu.Name = "lblStatusDLCEmu";
      this.lblStatusDLCEmu.Size = new Size(26, 18);
      this.lblStatusDLCEmu.TabIndex = 11;
      this.lblStatusDLCEmu.Text = "DLC";
      this.lblStatusUpdateEmu.Location = new Point(372, 41);
      this.lblStatusUpdateEmu.Name = "lblStatusUpdateEmu";
      this.lblStatusUpdateEmu.Size = new Size(43, 18);
      this.lblStatusUpdateEmu.TabIndex = 12;
      this.lblStatusUpdateEmu.Text = "Update";
      this.lblStatusGameEmu.Location = new Point(325, 41);
      this.lblStatusGameEmu.Name = "lblStatusGameEmu";
      this.lblStatusGameEmu.Size = new Size(35, 18);
      this.lblStatusGameEmu.TabIndex = 10;
      this.lblStatusGameEmu.Text = "Game";
      this.lblStatusDLCRaw.Location = new Point(426, 17);
      this.lblStatusDLCRaw.Name = "lblStatusDLCRaw";
      this.lblStatusDLCRaw.Size = new Size(26, 18);
      this.lblStatusDLCRaw.TabIndex = 5;
      this.lblStatusDLCRaw.Text = "DLC";
      this.radLabel19.Location = new Point(161, 41);
      this.radLabel19.Name = "radLabel19";
      this.radLabel19.Size = new Size(122, 18);
      this.radLabel19.TabIndex = 9;
      this.radLabel19.Text = "Content for emulation :";
      this.radLabel17.Location = new Point(161, 17);
      this.radLabel17.Name = "radLabel17";
      this.radLabel17.Size = new Size(158, 18);
      this.radLabel17.TabIndex = 8;
      this.radLabel17.Text = "Content for physical systems : ";
      this.lblNbPlayers.Location = new Point(490, 38);
      this.lblNbPlayers.Name = "lblNbPlayers";
      this.lblNbPlayers.Size = new Size(11, 18);
      this.lblNbPlayers.TabIndex = 7;
      this.lblNbPlayers.Text = "-";
      this.radLabel5.Location = new Point(490, 17);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new Size(44, 18);
      this.radLabel5.TabIndex = 6;
      this.radLabel5.Text = "Players:";
      this.radLabel4.Location = new Point(16, 59);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(51, 18);
      this.radLabel4.TabIndex = 6;
      this.radLabel4.Text = "DLC size:";
      this.lblDLCSize.Location = new Point(93, 59);
      this.lblDLCSize.Name = "lblDLCSize";
      this.lblDLCSize.Size = new Size(11, 18);
      this.lblDLCSize.TabIndex = 7;
      this.lblDLCSize.Text = "-";
      this.lblTitleId.Location = new Point(540, 59);
      this.lblTitleId.Name = "lblTitleId";
      this.lblTitleId.Size = new Size(11, 18);
      this.lblTitleId.TabIndex = 6;
      this.lblTitleId.Text = "-";
      this.radLabel2.Location = new Point(490, 59);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(47, 18);
      this.radLabel2.TabIndex = 5;
      this.radLabel2.Text = "Title ID :";
      this.lblStatusUpdateRaw.Location = new Point(372, 17);
      this.lblStatusUpdateRaw.Name = "lblStatusUpdateRaw";
      this.lblStatusUpdateRaw.Size = new Size(43, 18);
      this.lblStatusUpdateRaw.TabIndex = 6;
      this.lblStatusUpdateRaw.Text = "Update";
      this.lblStatusGameRaw.Location = new Point(325, 17);
      this.lblStatusGameRaw.Name = "lblStatusGameRaw";
      this.lblStatusGameRaw.Size = new Size(35, 18);
      this.lblStatusGameRaw.TabIndex = 4;
      this.lblStatusGameRaw.Text = "Game";
      this.lblUpdateSize.Location = new Point(93, 38);
      this.lblUpdateSize.Name = "lblUpdateSize";
      this.lblUpdateSize.Size = new Size(11, 18);
      this.lblUpdateSize.TabIndex = 3;
      this.lblUpdateSize.Text = "-";
      this.label5.Location = new Point(16, 38);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 18);
      this.label5.TabIndex = 2;
      this.label5.Text = "Update size :";
      this.lblGameSize.Location = new Point(93, 17);
      this.lblGameSize.Name = "lblGameSize";
      this.lblGameSize.Size = new Size(11, 18);
      this.lblGameSize.TabIndex = 1;
      this.lblGameSize.Text = "-";
      this.label1.Location = new Point(16, 17);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Game size :";
      this.toolTabStrip2.CanUpdateChildIndex = true;
      this.toolTabStrip2.Controls.Add((Control) this.toolDownload);
      this.toolTabStrip2.Location = new Point(1134, 0);
      this.toolTabStrip2.Name = "toolTabStrip2";
      this.toolTabStrip2.RootElement.MinSize = new Size(25, 25);
      this.toolTabStrip2.SelectedIndex = 0;
      this.toolTabStrip2.Size = new Size(0, 404);
      this.toolTabStrip2.SizeInfo.AbsoluteSize = new Size(0, 200);
      this.toolTabStrip2.SizeInfo.SplitterCorrection = new Size(-200, 0);
      this.toolTabStrip2.TabIndex = 7;
      this.toolTabStrip2.TabStop = false;
      this.toolDownload.Caption = (string) null;
      this.toolDownload.Controls.Add((Control) this.radPageView2);
      this.toolDownload.DefaultFloatingSize = new Size(300, 600);
      this.toolDownload.DocumentButtons = DocumentStripButtons.None;
      this.toolDownload.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolDownload.Location = new Point(1, 22);
      this.toolDownload.Name = "toolDownload";
      this.toolDownload.PreviousDockState = DockState.Floating;
      this.toolDownload.RightToLeft = RightToLeft.No;
      this.toolDownload.Size = new Size(0, 380);
      this.toolDownload.Text = "Download Manager";
      this.toolDownload.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radPageView2.Controls.Add((Control) this.radPageViewPage1);
      this.radPageView2.Controls.Add((Control) this.radPageViewPage3);
      this.radPageView2.Controls.Add((Control) this.radPageViewPage2);
      this.radPageView2.Dock = DockStyle.Fill;
      this.radPageView2.Location = new Point(0, 0);
      this.radPageView2.Name = "radPageView2";
      this.radPageView2.SelectedPage = this.radPageViewPage1;
      this.radPageView2.Size = new Size(0, 380);
      this.radPageView2.TabIndex = 32;
      this.radPageView2.Text = "Download Manager";
      ((RadPageViewStripElement) this.radPageView2.GetChildAt(0)).StripButtons = StripViewButtons.None;
      this.radPageViewPage1.Controls.Add((Control) this.radLiveSpeed);
      this.radPageViewPage1.Controls.Add((Control) this.cmdAbortAll);
      this.radPageViewPage1.Controls.Add((Control) this.grpProgressAll);
      this.radPageViewPage1.Controls.Add((Control) this.grpProgressCurrent);
      this.radPageViewPage1.Controls.Add((Control) this.radGroupBox2);
      this.radPageViewPage1.Controls.Add((Control) this.radGroupBox7);
      this.radPageViewPage1.Location = new Point(10, 9);
      this.radPageViewPage1.Name = "radPageViewPage1";
      this.radPageViewPage1.Size = new Size(0, 360);
      this.radPageViewPage1.Text = "ETA";
      this.radLiveSpeed.AccessibleRole = AccessibleRole.Grouping;
      this.radLiveSpeed.Controls.Add((Control) this.lblFileCheckStatus);
      this.radLiveSpeed.Dock = DockStyle.Fill;
      this.radLiveSpeed.HeaderText = "Live Speed";
      this.radLiveSpeed.Location = new Point(0, 237);
      this.radLiveSpeed.Name = "radLiveSpeed";
      this.radLiveSpeed.Size = new Size(0, 26);
      this.radLiveSpeed.TabIndex = 34;
      this.radLiveSpeed.Text = "Live Speed";
      this.lblFileCheckStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblFileCheckStatus.AutoSize = false;
      this.lblFileCheckStatus.Location = new Point(0, 0);
      this.lblFileCheckStatus.Name = "lblFileCheckStatus";
      this.lblFileCheckStatus.Size = new Size(0, 26);
      this.lblFileCheckStatus.TabIndex = 0;
      this.lblFileCheckStatus.Text = "The application is checking the integrity of your files, please wait...";
      this.lblFileCheckStatus.TextAlignment = ContentAlignment.MiddleCenter;
      this.lblFileCheckStatus.Visible = false;
      this.radPageViewPage3.Controls.Add((Control) this.radGroupBox26);
      this.radPageViewPage3.Controls.Add((Control) this.radGroupBox18);
      this.radPageViewPage3.Controls.Add((Control) this.lblSpeed);
      this.radPageViewPage3.Controls.Add((Control) this.gaugeSpeed);
      this.radPageViewPage3.Location = new Point(10, 37);
      this.radPageViewPage3.Name = "radPageViewPage3";
      this.radPageViewPage3.Size = new Size(479, 555);
      this.radPageViewPage3.Text = "Speed";
      this.radGroupBox26.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox26.Controls.Add((Control) this.chkSuperSpeed);
      this.radGroupBox26.Controls.Add((Control) this.radLabel20);
      this.radGroupBox26.Controls.Add((Control) this.radLabel21);
      this.radGroupBox26.Controls.Add((Control) this.radLabel3);
      this.radGroupBox26.Dock = DockStyle.Bottom;
      this.radGroupBox26.HeaderText = "SuperSpeed";
      this.radGroupBox26.Location = new Point(0, 450);
      this.radGroupBox26.Name = "radGroupBox26";
      this.radGroupBox26.Size = new Size(479, 105);
      this.radGroupBox26.TabIndex = 26;
      this.radGroupBox26.Text = "SuperSpeed";
      this.chkSuperSpeed.Dock = DockStyle.Top;
      this.chkSuperSpeed.ForeColor = System.Drawing.Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.chkSuperSpeed.Location = new Point(2, 72);
      this.chkSuperSpeed.Name = "chkSuperSpeed";
      this.chkSuperSpeed.Size = new Size(475, 18);
      this.chkSuperSpeed.TabIndex = 2;
      this.chkSuperSpeed.Text = "Enable SuperSpeed";
      this.chkSuperSpeed.ToggleStateChanged += new StateChangedEventHandler(this.chkSuperSpeed_ToggleStateChanged);
      this.radLabel20.Dock = DockStyle.Top;
      this.radLabel20.Location = new Point(2, 54);
      this.radLabel20.Name = "radLabel20";
      this.radLabel20.Size = new Size(475, 18);
      this.radLabel20.TabIndex = 1;
      this.radLabel20.Text = "It is only recommended if you have a 100+Mb/s connection.";
      this.radLabel21.Dock = DockStyle.Top;
      this.radLabel21.Location = new Point(2, 36);
      this.radLabel21.Name = "radLabel21";
      this.radLabel21.Size = new Size(475, 18);
      this.radLabel21.TabIndex = 2;
      this.radLabel21.Text = "This feature is experimental.";
      this.radLabel3.Dock = DockStyle.Top;
      this.radLabel3.Location = new Point(2, 18);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(475, 18);
      this.radLabel3.TabIndex = 0;
      this.radLabel3.Text = "SuperSpeed boosts your download speed by parallelizing the download.\r\n";
      this.radGroupBox18.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox18.Controls.Add((Control) this.radLabel9);
      this.radGroupBox18.Controls.Add((Control) this.radMaxSpeed);
      this.radGroupBox18.Dock = DockStyle.Top;
      this.radGroupBox18.HeaderText = "Limit download speed";
      this.radGroupBox18.Location = new Point(0, 268);
      this.radGroupBox18.Name = "radGroupBox18";
      this.radGroupBox18.Size = new Size(479, 100);
      this.radGroupBox18.TabIndex = 25;
      this.radGroupBox18.Text = "Limit download speed";
      this.lblSpeed.AutoSize = false;
      this.lblSpeed.Dock = DockStyle.Top;
      this.lblSpeed.Font = new Font("Segoe UI", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblSpeed.Location = new Point(0, 210);
      this.lblSpeed.Name = "lblSpeed";
      this.lblSpeed.Size = new Size(479, 58);
      this.lblSpeed.TabIndex = 25;
      this.lblSpeed.Text = "0.00KB/s";
      this.lblSpeed.TextAlignment = ContentAlignment.MiddleCenter;
      this.gaugeSpeed.BackColor = System.Drawing.Color.White;
      this.gaugeSpeed.CausesValidation = false;
      this.gaugeSpeed.Dock = DockStyle.Top;
      this.gaugeSpeed.Items.AddRange((RadItem) this.radialGaugeArc1, (RadItem) this.radialGaugeArc2, (RadItem) this.radialGaugeLabels1, (RadItem) this.radialGaugeTicks1, (RadItem) this.radialGaugeSingleLabel1);
      this.gaugeSpeed.Location = new Point(0, 0);
      this.gaugeSpeed.Name = "gaugeSpeed";
      this.gaugeSpeed.RangeEnd = 180.0;
      this.gaugeSpeed.Size = new Size(479, 210);
      this.gaugeSpeed.TabIndex = 6;
      this.gaugeSpeed.Text = "radRadialGauge1";
      this.gaugeSpeed.Value = 0.0f;
      this.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(71, 102, 155);
      this.radialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(77, 110, 162);
      this.radialGaugeArc1.BindEndRange = true;
      this.radialGaugeArc1.Name = "radialGaugeArc1";
      this.radialGaugeArc1.Radius = 80.0;
      this.radialGaugeArc1.RangeEnd = 0.0;
      this.radialGaugeArc1.Width = 15.0;
      this.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(181, 181, 181);
      this.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(194, 194, 194);
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
      this.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(109, 109, 109);
      this.radialGaugeTicks1.TicksCount = 18;
      this.radialGaugeTicks1.TicksLenghtPercentage = 1f;
      this.radialGaugeTicks1.TicksOffset = 4;
      this.radialGaugeTicks1.TicksRadiusPercentage = 95f;
      this.radialGaugeTicks1.TickThickness = 1f;
      this.radialGaugeSingleLabel1.BindValue = true;
      this.radialGaugeSingleLabel1.ForeColor = System.Drawing.Color.FromArgb(76, 109, 161);
      this.radialGaugeSingleLabel1.LabelText = "Text";
      this.radialGaugeSingleLabel1.LocationPercentage = new SizeF(0.0f, 0.0f);
      this.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1";
      this.radPageViewPage2.Controls.Add((Control) this.grpLog);
      this.radPageViewPage2.Location = new Point(10, 37);
      this.radPageViewPage2.Name = "radPageViewPage2";
      this.radPageViewPage2.Size = new Size(479, 555);
      this.radPageViewPage2.Text = "Log";
      this.grpLog.AccessibleRole = AccessibleRole.Grouping;
      this.grpLog.Controls.Add((Control) this.lstLog);
      this.grpLog.Dock = DockStyle.Fill;
      this.grpLog.HeaderText = "Technical stuff";
      this.grpLog.Location = new Point(0, 0);
      this.grpLog.Name = "grpLog";
      this.grpLog.Size = new Size(479, 555);
      this.grpLog.TabIndex = 35;
      this.grpLog.Text = "Technical stuff";
      this.lstLog.AllowArbitraryItemHeight = true;
      this.lstLog.Dock = DockStyle.Fill;
      this.lstLog.Location = new Point(2, 18);
      this.lstLog.Name = "lstLog";
      this.lstLog.Size = new Size(475, 535);
      this.lstLog.TabIndex = 25;
      this.lstLog.Text = "radListView1";
      this.toolTabStrip4.CanUpdateChildIndex = true;
      this.toolTabStrip4.Controls.Add((Control) this.toolCopy);
      this.toolTabStrip4.Location = new Point(1136, 0);
      this.toolTabStrip4.Name = "toolTabStrip4";
      this.toolTabStrip4.RootElement.MinSize = new Size(0, 0);
      this.toolTabStrip4.SelectedIndex = 0;
      this.toolTabStrip4.Size = new Size(0, 404);
      this.toolTabStrip4.SizeInfo.AbsoluteSize = new Size(0, 200);
      this.toolTabStrip4.SizeInfo.SplitterCorrection = new Size(-200, 0);
      this.toolTabStrip4.TabIndex = 8;
      this.toolTabStrip4.TabStop = false;
      this.toolTabStrip6.CanUpdateChildIndex = true;
      this.toolTabStrip6.CausesValidation = false;
      this.toolTabStrip6.Controls.Add((Control) this.toolWindow2);
      this.toolTabStrip6.Controls.Add((Control) this.toolWindow3);
      this.toolTabStrip6.Controls.Add((Control) this.toolWindow4);
      this.toolTabStrip6.Location = new Point(5, 518);
      this.toolTabStrip6.Name = "toolTabStrip6";
      this.toolTabStrip6.RootElement.MinSize = new Size(25, 25);
      this.toolTabStrip6.SelectedIndex = 0;
      this.toolTabStrip6.Size = new Size(1136, 110);
      this.toolTabStrip6.SizeInfo.AbsoluteSize = new Size(200, 110);
      this.toolTabStrip6.SizeInfo.SplitterCorrection = new Size(0, -90);
      this.toolTabStrip6.TabIndex = 1;
      this.toolTabStrip6.TabStop = false;
      this.toolWindow2.Caption = (string) null;
      this.toolWindow2.Controls.Add((Control) this.radPanel1);
      this.toolWindow2.DocumentButtons = DocumentStripButtons.None;
      this.toolWindow2.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolWindow2.Location = new Point(1, 22);
      this.toolWindow2.Name = "toolWindow2";
      this.toolWindow2.PreviousDockState = DockState.Docked;
      this.toolWindow2.Size = new Size(1134, 62);
      this.toolWindow2.Text = "Commands";
      this.toolWindow2.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radPanel1.AutoSize = true;
      this.radPanel1.Controls.Add((Control) this.cmdChangeRegion);
      this.radPanel1.Controls.Add((Control) this.cmdChangeTicket);
      this.radPanel1.Controls.Add((Control) this.cmdChangeFolder);
      this.radPanel1.Controls.Add((Control) this.cmdSetExtractFolder);
      this.radPanel1.Controls.Add((Control) this.DownloadButton);
      this.radPanel1.Dock = DockStyle.Fill;
      this.radPanel1.Location = new Point(0, 0);
      this.radPanel1.Name = "radPanel1";
      this.radPanel1.Size = new Size(1134, 62);
      this.radPanel1.TabIndex = 33;
      this.cmdChangeRegion.AccessibleName = "Change region";
      this.cmdChangeRegion.Anchor = AnchorStyles.None;
      this.cmdChangeRegion.DialogResult = DialogResult.Cancel;
      this.cmdChangeRegion.Image = (Image) componentResourceManager.GetObject("cmdChangeRegion.Image");
      this.cmdChangeRegion.Location = new Point(898, 4);
      this.cmdChangeRegion.Name = "cmdChangeRegion";
      this.cmdChangeRegion.Padding = new Padding(8);
      this.cmdChangeRegion.Size = new Size(190, 55);
      this.cmdChangeRegion.TabIndex = 4;
      this.cmdChangeRegion.Text = "Change region";
      this.cmdChangeRegion.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdChangeRegion.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdChangeRegion.Click += new EventHandler(this.cmdChangeRegion_Click);
      this.cmdChangeTicket.AccessibleName = "Change tickets location";
      this.cmdChangeTicket.Anchor = AnchorStyles.None;
      this.cmdChangeTicket.DialogResult = DialogResult.Cancel;
      this.cmdChangeTicket.Image = (Image) componentResourceManager.GetObject("cmdChangeTicket.Image");
      this.cmdChangeTicket.Location = new Point(691, 4);
      this.cmdChangeTicket.Name = "cmdChangeTicket";
      this.cmdChangeTicket.Padding = new Padding(8);
      this.cmdChangeTicket.Size = new Size(190, 55);
      this.cmdChangeTicket.TabIndex = 7;
      this.cmdChangeTicket.Text = "Change tickets location";
      this.cmdChangeTicket.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdChangeTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdChangeTicket.Click += new EventHandler(this.cmdChangeTicket_Click);
      this.cmdChangeFolder.AccessibleName = "Set download directory";
      this.cmdChangeFolder.Anchor = AnchorStyles.None;
      this.cmdChangeFolder.Controls.Add((Control) this.label7);
      this.cmdChangeFolder.DialogResult = DialogResult.Cancel;
      this.cmdChangeFolder.Image = (Image) componentResourceManager.GetObject("cmdChangeFolder.Image");
      this.cmdChangeFolder.Location = new Point(484, 4);
      this.cmdChangeFolder.Name = "cmdChangeFolder";
      this.cmdChangeFolder.Padding = new Padding(8);
      this.cmdChangeFolder.Size = new Size(190, 55);
      this.cmdChangeFolder.TabIndex = 6;
      this.cmdChangeFolder.Text = "Set download directory";
      this.cmdChangeFolder.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdChangeFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdChangeFolder.MouseClick += new MouseEventHandler(this.cmdChangeFolder_MouseClick);
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new Font("Segoe UI", 6f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(102, 36);
      this.label7.Name = "label7";
      this.label7.Size = new Size(75, 11);
      this.label7.TabIndex = 2;
      this.label7.Text = "(Right Click to Open)";
      this.cmdSetExtractFolder.AccessibleName = "Set extraction directory";
      this.cmdSetExtractFolder.Anchor = AnchorStyles.None;
      this.cmdSetExtractFolder.Controls.Add((Control) this.label6);
      this.cmdSetExtractFolder.DialogResult = DialogResult.Cancel;
      this.cmdSetExtractFolder.Image = (Image) componentResourceManager.GetObject("cmdSetExtractFolder.Image");
      this.cmdSetExtractFolder.Location = new Point(277, 4);
      this.cmdSetExtractFolder.Name = "cmdSetExtractFolder";
      this.cmdSetExtractFolder.Padding = new Padding(8);
      this.cmdSetExtractFolder.Size = new Size(190, 55);
      this.cmdSetExtractFolder.TabIndex = 5;
      this.cmdSetExtractFolder.Text = "Set extraction directory";
      this.cmdSetExtractFolder.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdSetExtractFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdSetExtractFolder.MouseClick += new MouseEventHandler(this.cmdSetExtractFolder_MouseClick);
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new Font("Segoe UI", 6f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(103, 36);
      this.label6.Name = "label6";
      this.label6.Size = new Size(75, 11);
      this.label6.TabIndex = 1;
      this.label6.Text = "(Right Click to Open)";
      this.DownloadButton.AccessibleName = "Start downloading";
      this.DownloadButton.Anchor = AnchorStyles.None;
      this.DownloadButton.DialogResult = DialogResult.Cancel;
      this.DownloadButton.Enabled = false;
      this.DownloadButton.Image = (Image) componentResourceManager.GetObject("DownloadButton.Image");
      this.DownloadButton.Location = new Point(70, 4);
      this.DownloadButton.Name = "DownloadButton";
      this.DownloadButton.Padding = new Padding(8);
      this.DownloadButton.Size = new Size(190, 55);
      this.DownloadButton.TabIndex = 3;
      this.DownloadButton.Text = "&Start downloading";
      this.DownloadButton.TextAlignment = ContentAlignment.MiddleLeft;
      this.DownloadButton.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.DownloadButton.Click += new EventHandler(this.DownloadButton_Click);
      this.toolWindow3.Caption = (string) null;
      this.toolWindow3.Controls.Add((Control) this.radPanel2);
      this.toolWindow3.DocumentButtons = DocumentStripButtons.None;
      this.toolWindow3.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolWindow3.Location = new Point(1, 22);
      this.toolWindow3.Name = "toolWindow3";
      this.toolWindow3.PreviousDockState = DockState.Docked;
      this.toolWindow3.Size = new Size(1134, 62);
      this.toolWindow3.Text = "Batch commands";
      this.toolWindow3.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radPanel2.AutoSize = true;
      this.radPanel2.Controls.Add((Control) this.cmdCopyAll);
      this.radPanel2.Controls.Add((Control) this.cmdImportGames);
      this.radPanel2.Controls.Add((Control) this.cmdRefresh);
      this.radPanel2.Controls.Add((Control) this.cmdAddAllGames);
      this.radPanel2.Controls.Add((Control) this.cmdAddAllUpdates);
      this.radPanel2.Controls.Add((Control) this.cmdAddAllDLCS);
      this.radPanel2.Dock = DockStyle.Fill;
      this.radPanel2.Location = new Point(0, 0);
      this.radPanel2.Name = "radPanel2";
      this.radPanel2.Size = new Size(1134, 62);
      this.radPanel2.TabIndex = 34;
      this.cmdCopyAll.Anchor = AnchorStyles.None;
      this.cmdCopyAll.DialogResult = DialogResult.Cancel;
      this.cmdCopyAll.Image = (Image) componentResourceManager.GetObject("cmdCopyAll.Image");
      this.cmdCopyAll.Location = new Point(753, 4);
      this.cmdCopyAll.Name = "cmdCopyAll";
      this.cmdCopyAll.Padding = new Padding(8);
      this.cmdCopyAll.Size = new Size(114, 55);
      this.cmdCopyAll.TabIndex = 7;
      this.cmdCopyAll.Text = "Copy all";
      this.cmdCopyAll.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdCopyAll.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdCopyAll.Click += new EventHandler(this.cmdCopyAll_Click);
      this.cmdImportGames.Anchor = AnchorStyles.None;
      this.cmdImportGames.DialogResult = DialogResult.Cancel;
      this.cmdImportGames.Image = (Image) componentResourceManager.GetObject("cmdImportGames.Image");
      this.cmdImportGames.Location = new Point(883, 4);
      this.cmdImportGames.Name = "cmdImportGames";
      this.cmdImportGames.Padding = new Padding(8);
      this.cmdImportGames.Size = new Size(151, 55);
      this.cmdImportGames.TabIndex = 7;
      this.cmdImportGames.Text = "Import titles";
      this.cmdImportGames.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdImportGames.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdImportGames.Click += new EventHandler(this.cmdImportGames_Click);
      this.cmdRefresh.Anchor = AnchorStyles.None;
      this.cmdRefresh.DialogResult = DialogResult.Cancel;
      this.cmdRefresh.Enabled = false;
      this.cmdRefresh.Image = (Image) componentResourceManager.GetObject("cmdRefresh.Image");
      this.cmdRefresh.Location = new Point(623, 4);
      this.cmdRefresh.Name = "cmdRefresh";
      this.cmdRefresh.Padding = new Padding(8);
      this.cmdRefresh.Size = new Size(114, 55);
      this.cmdRefresh.TabIndex = 6;
      this.cmdRefresh.Text = "Refresh";
      this.cmdRefresh.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdRefresh.Click += new EventHandler(this.cmdRefresh_Click);
      this.cmdAddAllGames.Anchor = AnchorStyles.None;
      this.cmdAddAllGames.DialogResult = DialogResult.Cancel;
      this.cmdAddAllGames.Image = (Image) componentResourceManager.GetObject("cmdAddAllGames.Image");
      this.cmdAddAllGames.Location = new Point(121, 4);
      this.cmdAddAllGames.Name = "cmdAddAllGames";
      this.cmdAddAllGames.Padding = new Padding(8);
      this.cmdAddAllGames.Size = new Size(151, 55);
      this.cmdAddAllGames.TabIndex = 3;
      this.cmdAddAllGames.Text = "Add all games";
      this.cmdAddAllGames.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddAllGames.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddAllGames.Click += new EventHandler(this.cmdAddAllGames_Click);
      this.cmdAddAllUpdates.Anchor = AnchorStyles.None;
      this.cmdAddAllUpdates.DialogResult = DialogResult.Cancel;
      this.cmdAddAllUpdates.Image = (Image) componentResourceManager.GetObject("cmdAddAllUpdates.Image");
      this.cmdAddAllUpdates.Location = new Point(288, 4);
      this.cmdAddAllUpdates.Name = "cmdAddAllUpdates";
      this.cmdAddAllUpdates.Padding = new Padding(8);
      this.cmdAddAllUpdates.Size = new Size(156, 55);
      this.cmdAddAllUpdates.TabIndex = 5;
      this.cmdAddAllUpdates.Text = "Add all updates";
      this.cmdAddAllUpdates.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddAllUpdates.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddAllUpdates.Click += new EventHandler(this.cmdAddAllUpdates_Click);
      this.cmdAddAllDLCS.Anchor = AnchorStyles.None;
      this.cmdAddAllDLCS.DialogResult = DialogResult.Cancel;
      this.cmdAddAllDLCS.Image = (Image) componentResourceManager.GetObject("cmdAddAllDLCS.Image");
      this.cmdAddAllDLCS.Location = new Point(460, 4);
      this.cmdAddAllDLCS.Name = "cmdAddAllDLCS";
      this.cmdAddAllDLCS.Padding = new Padding(8);
      this.cmdAddAllDLCS.Size = new Size(147, 55);
      this.cmdAddAllDLCS.TabIndex = 7;
      this.cmdAddAllDLCS.Text = "    Add all DLCs";
      this.cmdAddAllDLCS.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdAddAllDLCS.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdAddAllDLCS.Click += new EventHandler(this.cmdAddAllDLCS_Click);
      this.toolWindow4.Caption = (string) null;
      this.toolWindow4.Controls.Add((Control) this.radPanel3);
      this.toolWindow4.DocumentButtons = DocumentStripButtons.None;
      this.toolWindow4.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.toolWindow4.Location = new Point(1, 22);
      this.toolWindow4.Name = "toolWindow4";
      this.toolWindow4.PreviousDockState = DockState.Docked;
      this.toolWindow4.Size = new Size(1134, 62);
      this.toolWindow4.Text = "Other";
      this.toolWindow4.ToolCaptionButtons = ToolStripCaptionButtons.None;
      this.radPanel3.AutoSize = true;
      this.radPanel3.Controls.Add((Control) this.cmdLegal);
      this.radPanel3.Controls.Add((Control) this.cmdHallOfFame);
      this.radPanel3.Controls.Add((Control) this.cmdChangeTheme);
      this.radPanel3.Dock = DockStyle.Fill;
      this.radPanel3.Location = new Point(0, 0);
      this.radPanel3.Name = "radPanel3";
      this.radPanel3.Size = new Size(1134, 62);
      this.radPanel3.TabIndex = 35;
      this.cmdLegal.Anchor = AnchorStyles.None;
      this.cmdLegal.DialogResult = DialogResult.Cancel;
      this.cmdLegal.Image = (Image) componentResourceManager.GetObject("cmdLegal.Image");
      this.cmdLegal.Location = new Point(661, 4);
      this.cmdLegal.Name = "cmdLegal";
      this.cmdLegal.Padding = new Padding(8);
      this.cmdLegal.Size = new Size(175, 55);
      this.cmdLegal.TabIndex = 6;
      this.cmdLegal.Text = "Legal info";
      this.cmdLegal.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdLegal.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdLegal.Click += new EventHandler(this.cmdLegal_Click);
      this.cmdHallOfFame.Anchor = AnchorStyles.None;
      this.cmdHallOfFame.DialogResult = DialogResult.Cancel;
      this.cmdHallOfFame.Image = (Image) componentResourceManager.GetObject("cmdHallOfFame.Image");
      this.cmdHallOfFame.Location = new Point(480, 4);
      this.cmdHallOfFame.Name = "cmdHallOfFame";
      this.cmdHallOfFame.Padding = new Padding(8);
      this.cmdHallOfFame.Size = new Size(175, 55);
      this.cmdHallOfFame.TabIndex = 6;
      this.cmdHallOfFame.Text = "    See Hall of Fame";
      this.cmdHallOfFame.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdHallOfFame.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdHallOfFame.Click += new EventHandler(this.cmdHallOfFame_Click);
      this.cmdChangeTheme.Anchor = AnchorStyles.None;
      this.cmdChangeTheme.DialogResult = DialogResult.Cancel;
      this.cmdChangeTheme.Image = (Image) componentResourceManager.GetObject("cmdChangeTheme.Image");
      this.cmdChangeTheme.Location = new Point(299, 4);
      this.cmdChangeTheme.Name = "cmdChangeTheme";
      this.cmdChangeTheme.Padding = new Padding(8);
      this.cmdChangeTheme.Size = new Size(175, 55);
      this.cmdChangeTheme.TabIndex = 3;
      this.cmdChangeTheme.Text = "Change Theme";
      this.cmdChangeTheme.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdChangeTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdChangeTheme.Click += new EventHandler(this.cmdChangeTheme_Click);
      this.radContextMenu_0.Items.AddRange((RadItem) this.menuDlGame, (RadItem) this.menuDlUpdate, (RadItem) this.menuDlDLC, (RadItem) this.menuCopy, (RadItem) this.menuDelete, (RadItem) this.menuMarkInstall, (RadItem) this.radMarkNotInstalled, (RadItem) this.radUnpack, (RadItem) this.menuPlay, (RadItem) this.radPrepareEmu, (RadItem) this.radDelEmuData, (RadItem) this.radMenuItem1);
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
      this.timer_2.Tick += new EventHandler(this.timer_2_Tick);
      this.timer_3.Enabled = true;
      this.timer_3.Interval = 300000;
      this.timer_3.Tick += new EventHandler(this.timer_3_Tick);
      this.timer_4.Interval = 1000;
      this.timer_4.Tick += new EventHandler(this.timer_4_Tick);
      this.lblStatus.AutoSize = false;
      this.lblStatus.Controls.Add((Control) this.lblSynchronized);
      this.lblStatus.Dock = DockStyle.Bottom;
      this.lblStatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(192, 192, 0);
      this.lblStatus.Location = new Point(0, 633);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(1146, 19);
      this.lblStatus.TabIndex = 33;
      this.lblStatus.Text = "Powered by Willzor's wiiuusbhelper.com (No WiiU found, please launch Wii U USB Helper Transfer Tool)";
      this.lblStatus.UseMnemonic = false;
      this.lblSynchronized.Dock = DockStyle.Right;
      this.lblSynchronized.Location = new Point(1135, 0);
      this.lblSynchronized.Name = "lblSynchronized";
      this.lblSynchronized.Size = new Size(11, 19);
      this.lblSynchronized.TabIndex = 34;
      this.lblSynchronized.Text = "-";
      this.lblSynchronized.TextAlignment = ContentAlignment.MiddleCenter;
      this.timer_5.Enabled = true;
      this.timer_5.Interval = 60000;
      this.timer_5.Tick += new EventHandler(this.timer_5_Tick);
      this.timer_6.Interval = 500;
      this.timer_6.Tick += new EventHandler(this.timer_6_Tick);
      this.timer_7.Enabled = true;
      this.timer_7.Interval = 60000;
      this.timer_7.Tick += new EventHandler(this.timer_7_Tick);
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.AutoSize = true;
      this.ClientSize = new Size(1146, 652);
      this.Controls.Add((Control) this.dockMain);
      this.Controls.Add((Control) this.lblStatus);
      this.ForeColor = System.Drawing.Color.FromArgb(74, 72, 58);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MinimumSize = new Size(1154, 682);
      this.Name = nameof (NusGrabberForm);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Wii U USB Helper";
      this.FormClosing += new FormClosingEventHandler(this.NusGrabberForm_FormClosing);
      this.Load += new EventHandler(this.NusGrabberForm_Load);
      this.FTSearchBox.EndInit();
      this.lstGames.EndInit();
      this.label2.EndInit();
      this.dlQueue.EndInit();
      this.lblTotalToDl.EndInit();
      this.lblTotalDl.EndInit();
      this.lblNbGms.EndInit();
      this.radGroupBox7.EndInit();
      this.radGroupBox7.ResumeLayout(false);
      this.radGroupBox7.PerformLayout();
      this.chkPrepareEmulation.EndInit();
      this.chkPack.EndInit();
      this.cmdAbortDelay.EndInit();
      this.lblTimeLeft.EndInit();
      this.chkUnpack.EndInit();
      this.chkCopyToSD.EndInit();
      this.chkSleep.EndInit();
      this.chkShutdown.EndInit();
      this.chkDelay.EndInit();
      this.chkHibernate.EndInit();
      this.grpProgressAll.EndInit();
      this.grpProgressAll.ResumeLayout(false);
      this.grpProgressAll.PerformLayout();
      this.lblTotalEta.EndInit();
      this.totalProgress.EndInit();
      this.radLabel9.EndInit();
      this.radMaxSpeed.EndInit();
      this.cmdAbortAll.EndInit();
      this.radGroupBox3.EndInit();
      this.radGroupBox3.ResumeLayout(false);
      this.cmdDelete.EndInit();
      this.cmdCopy.EndInit();
      this.cmdAddDlc.EndInit();
      this.cmdAddDlc.ResumeLayout(false);
      this.cmdAddDlc.PerformLayout();
      this.cmdAddUpdate.EndInit();
      this.cmdAddGame.EndInit();
      this.lblTitle.EndInit();
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      this.lblFileEta.EndInit();
      this.pgFile.EndInit();
      this.grpProgressCurrent.EndInit();
      this.grpProgressCurrent.ResumeLayout(false);
      this.grpProgressCurrent.PerformLayout();
      this.lblEta.EndInit();
      this.NUSGrabberProgress.EndInit();
      this.dockMain.EndInit();
      this.dockMain.ResumeLayout(false);
      this.toolCopy.ResumeLayout(false);
      this.toolCopy.PerformLayout();
      this.lstCopy.EndInit();
      this.cmdSendWiiu.EndInit();
      this.cmdManageRemoteSd.EndInit();
      this.cmdInitiateCopy.EndInit();
      this.radGroupBox10.EndInit();
      this.radGroupBox10.ResumeLayout(false);
      this.radGroupBox10.PerformLayout();
      this.lblTotalCopy.EndInit();
      this.radLabel1.EndInit();
      this.radButton1.EndInit();
      this.radLabel6.EndInit();
      this.toolTabStrip3.EndInit();
      this.toolTabStrip3.ResumeLayout(false);
      this.toolWindow5.ResumeLayout(false);
      ((ISupportInitialize) this.pbBanner).EndInit();
      this.radSplitContainer3.EndInit();
      this.radSplitContainer3.ResumeLayout(false);
      this.documentContainer1.EndInit();
      this.documentContainer1.ResumeLayout(false);
      this.documentTabStrip1.EndInit();
      this.documentTabStrip1.ResumeLayout(false);
      this.toolLibrary.ResumeLayout(false);
      this.toolLibrary.PerformLayout();
      this.radGroupBox4.EndInit();
      this.radGroupBox4.ResumeLayout(false);
      this.radSplitContainer1.EndInit();
      this.radSplitContainer1.ResumeLayout(false);
      this.splitPanel1.EndInit();
      this.splitPanel1.ResumeLayout(false);
      this.splitPanel1.PerformLayout();
      this.chkCompactView.EndInit();
      this.panelLibraryCheckbox.EndInit();
      this.panelLibraryCheckbox.ResumeLayout(false);
      this.panelLibraryCheckbox.PerformLayout();
      this.splitPanel2.EndInit();
      this.splitPanel2.ResumeLayout(false);
      this.splitPanel2.PerformLayout();
      this.radGroupBox9.EndInit();
      this.radGroupBox9.ResumeLayout(false);
      this.radGroupBox9.PerformLayout();
      this.cmdClearDl.EndInit();
      this.toolFilters.ResumeLayout(false);
      this.radGroupBox12.EndInit();
      this.radGroupBox12.ResumeLayout(false);
      this.treePlatforms.EndInit();
      this.radGroupBox13.EndInit();
      this.radGroupBox13.ResumeLayout(false);
      this.radGroupBox13.PerformLayout();
      this.chkKOR.EndInit();
      this.chkJAP.EndInit();
      this.chkUSA.EndInit();
      this.chkEUR.EndInit();
      this.toolAdvancedSearch.ResumeLayout(false);
      this.radGroupBox25.EndInit();
      this.radGroupBox25.ResumeLayout(false);
      this.chkGameGenres.EndInit();
      this.cmdSearchWithCriterias.EndInit();
      this.cmdClearCriterias.EndInit();
      this.toolAdvancedSettings.ResumeLayout(false);
      this.radGroupBox28.EndInit();
      this.radGroupBox28.ResumeLayout(false);
      this.radGroupBox28.PerformLayout();
      this.lblStorageLocation.EndInit();
      this.radButton5.EndInit();
      this.radGroupBox22.EndInit();
      this.radGroupBox22.ResumeLayout(false);
      this.radGroupBox22.PerformLayout();
      this.chkDisableSpeedGraph.EndInit();
      this.chkPreventShortcut.EndInit();
      this.radGroupBox14.EndInit();
      this.radGroupBox14.ResumeLayout(false);
      this.radGroupBox14.PerformLayout();
      this.lblproxyStatus.EndInit();
      this.radLabel12.EndInit();
      this.cmdClearProxy.EndInit();
      this.cmdSetProxy.EndInit();
      this.radTextBox1.EndInit();
      this.txtProxyUsr.EndInit();
      this.txtProxyPassword.EndInit();
      this.radLabel11.EndInit();
      this.txtProxyUrl.EndInit();
      this.radLabel10.EndInit();
      this.toolEmuSettings.ResumeLayout(false);
      this.radGroupBox5.EndInit();
      this.radGroupBox5.ResumeLayout(false);
      this.radButton7.EndInit();
      this.radGroupBox21.EndInit();
      this.radGroupBox21.ResumeLayout(false);
      this.radGroupBox21.PerformLayout();
      this.radLabel22.EndInit();
      this.radButton2.EndInit();
      this.chkForceGameMode.EndInit();
      this.radLabel23.EndInit();
      this.radLabel13.EndInit();
      this.radGroupBox17.EndInit();
      this.radGroupBox17.ResumeLayout(false);
      this.radButton4.EndInit();
      this.toolContribute.ResumeLayout(false);
      this.radGroupBox15.EndInit();
      this.radGroupBox15.ResumeLayout(false);
      this.radGroupBox15.PerformLayout();
      this.radGroupBox16.EndInit();
      this.radGroupBox16.ResumeLayout(false);
      this.radGroupBox16.PerformLayout();
      this.cmdDonate.EndInit();
      this.lblDonatorDate.EndInit();
      this.lblDonatorStatus.EndInit();
      this.radLabel18.EndInit();
      this.lblDonatorEmail.EndInit();
      this.radLabel16.EndInit();
      this.radLabel15.EndInit();
      this.radLabel14.EndInit();
      this.radGroupBox20.EndInit();
      this.radGroupBox20.ResumeLayout(false);
      this.cmdSugegstIdea.EndInit();
      this.toolHelp.ResumeLayout(false);
      this.radGroupBox24.EndInit();
      this.radGroupBox24.ResumeLayout(false);
      this.cmdPrepareSd.EndInit();
      this.toolTabStrip1.EndInit();
      this.toolTabStrip1.ResumeLayout(false);
      this.toolGameInfo.ResumeLayout(false);
      this.toolGameInfo.PerformLayout();
      this.radGroupBox6.EndInit();
      this.radGroupBox6.ResumeLayout(false);
      this.dockInfo.EndInit();
      this.dockInfo.ResumeLayout(false);
      this.toolGameDesc.ResumeLayout(false);
      this.txtDesc.EndInit();
      this.panelGameCover.EndInit();
      this.panelGameCover.ResumeLayout(false);
      this.panelGameCover.PerformLayout();
      this.cmdShortcut.EndInit();
      this.cmdPlay.EndInit();
      ((ISupportInitialize) this.pictureLogo).EndInit();
      ((ISupportInitialize) this.pbCover).EndInit();
      this.documentContainer2.EndInit();
      this.documentContainer2.ResumeLayout(false);
      this.documentTabStrip2.EndInit();
      this.documentTabStrip2.ResumeLayout(false);
      this.toolMods.ResumeLayout(false);
      this.lblModsOnlyCemu.EndInit();
      this.radGroupBox29.EndInit();
      this.radGroupBox29.ResumeLayout(false);
      this.lstMods.EndInit();
      this.txtModSearch.EndInit();
      this.cmdModContribute.EndInit();
      this.radGroupBox27.EndInit();
      this.radGroupBox27.ResumeLayout(false);
      this.modPreview.EndInit();
      this.txtModDescription.EndInit();
      this.toolExtraInfo.ResumeLayout(false);
      this.radGroupBox11.EndInit();
      this.radGroupBox11.ResumeLayout(false);
      this.radGroupBox11.PerformLayout();
      this.lstLanguages.EndInit();
      ((ISupportInitialize) this.pbRating).EndInit();
      this.lstGenre.EndInit();
      this.pgScore.EndInit();
      this.lstControllers.EndInit();
      this.toolScreenShot.ResumeLayout(false);
      ((ISupportInitialize) this.pbPreview3).EndInit();
      ((ISupportInitialize) this.pbPreview1).EndInit();
      ((ISupportInitialize) this.pbPreview2).EndInit();
      this.toolWeb.ResumeLayout(false);
      this.toolWeb.PerformLayout();
      this.radGroupBox8.EndInit();
      this.radGroupBox8.ResumeLayout(false);
      this.cmdGoNext.EndInit();
      this.cmdGoBack.EndInit();
      this.toolMovies.ResumeLayout(false);
      this.lstMovies.EndInit();
      this.radLabel7.EndInit();
      this.tollSaveManager.ResumeLayout(false);
      this.tollSaveManager.PerformLayout();
      this.cmdCommunitySaves.EndInit();
      this.cmdImportCemu.EndInit();
      this.radLabel8.EndInit();
      this.cmdRestoreSave.EndInit();
      this.cmdBackupSave.EndInit();
      this.toolChat.ResumeLayout(false);
      this.lstChat.EndInit();
      this.txtChat.EndInit();
      this.panelChatBottom.EndInit();
      this.panelChatBottom.ResumeLayout(false);
      this.panelChatBottom.PerformLayout();
      this.radioLobby.EndInit();
      this.radioGameRoom.EndInit();
      this.chkNotifyChat.EndInit();
      this.lblChannelClientCount.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.lblEmuUpdateVersion.EndInit();
      this.lblStatusDLCEmu.EndInit();
      this.lblStatusUpdateEmu.EndInit();
      this.lblStatusGameEmu.EndInit();
      this.lblStatusDLCRaw.EndInit();
      this.radLabel19.EndInit();
      this.radLabel17.EndInit();
      this.lblNbPlayers.EndInit();
      this.radLabel5.EndInit();
      this.radLabel4.EndInit();
      this.lblDLCSize.EndInit();
      this.lblTitleId.EndInit();
      this.radLabel2.EndInit();
      this.lblStatusUpdateRaw.EndInit();
      this.lblStatusGameRaw.EndInit();
      this.lblUpdateSize.EndInit();
      this.label5.EndInit();
      this.lblGameSize.EndInit();
      this.label1.EndInit();
      this.toolTabStrip2.EndInit();
      this.toolTabStrip2.ResumeLayout(false);
      this.toolDownload.ResumeLayout(false);
      this.radPageView2.EndInit();
      this.radPageView2.ResumeLayout(false);
      this.radPageViewPage1.ResumeLayout(false);
      this.radLiveSpeed.EndInit();
      this.radLiveSpeed.ResumeLayout(false);
      this.lblFileCheckStatus.EndInit();
      this.radPageViewPage3.ResumeLayout(false);
      this.radGroupBox26.EndInit();
      this.radGroupBox26.ResumeLayout(false);
      this.radGroupBox26.PerformLayout();
      this.chkSuperSpeed.EndInit();
      this.radLabel20.EndInit();
      this.radLabel21.EndInit();
      this.radLabel3.EndInit();
      this.radGroupBox18.EndInit();
      this.radGroupBox18.ResumeLayout(false);
      this.radGroupBox18.PerformLayout();
      this.lblSpeed.EndInit();
      this.gaugeSpeed.EndInit();
      this.radPageViewPage2.ResumeLayout(false);
      this.grpLog.EndInit();
      this.grpLog.ResumeLayout(false);
      this.lstLog.EndInit();
      this.toolTabStrip4.EndInit();
      this.toolTabStrip4.ResumeLayout(false);
      this.toolTabStrip6.EndInit();
      this.toolTabStrip6.ResumeLayout(false);
      this.toolWindow2.ResumeLayout(false);
      this.toolWindow2.PerformLayout();
      this.radPanel1.EndInit();
      this.radPanel1.ResumeLayout(false);
      this.cmdChangeRegion.EndInit();
      this.cmdChangeTicket.EndInit();
      this.cmdChangeFolder.EndInit();
      this.cmdChangeFolder.ResumeLayout(false);
      this.cmdChangeFolder.PerformLayout();
      this.cmdSetExtractFolder.EndInit();
      this.cmdSetExtractFolder.ResumeLayout(false);
      this.cmdSetExtractFolder.PerformLayout();
      this.DownloadButton.EndInit();
      this.toolWindow3.ResumeLayout(false);
      this.toolWindow3.PerformLayout();
      this.radPanel2.EndInit();
      this.radPanel2.ResumeLayout(false);
      this.cmdCopyAll.EndInit();
      this.cmdImportGames.EndInit();
      this.cmdRefresh.EndInit();
      this.cmdAddAllGames.EndInit();
      this.cmdAddAllUpdates.EndInit();
      this.cmdAddAllDLCS.EndInit();
      this.toolWindow4.ResumeLayout(false);
      this.toolWindow4.PerformLayout();
      this.radPanel3.EndInit();
      this.radPanel3.ResumeLayout(false);
      this.cmdLegal.EndInit();
      this.cmdHallOfFame.EndInit();
      this.cmdChangeTheme.EndInit();
      this.lblStatus.EndInit();
      this.lblStatus.ResumeLayout(false);
      this.lblStatus.PerformLayout();
      this.lblSynchronized.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }

    private class Class161
    {
      public byte[] WiiU { get; set; }

      public byte[] Byte_0 { get; set; }

      public byte[] Wii { get; set; }
    }
  }
}
