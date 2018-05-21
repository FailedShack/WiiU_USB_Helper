// Decompiled with JetBrains decompiler
// Type: ns0.frmShortcutType
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper.Emulators;
using SharpSteam;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmShortcutType : RadForm
  {
    private GClass30 gclass30_0;
    private IContainer icontainer_0;
    private RadButton cmdShortcut;
    private RadButton cmdSteam;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private RadLabel radLabel1;
    private RadLabel radLabel2;
    private Timer timer_0;
    private RadLabel lblCloseSteam;
    private RadSplitContainer radSplitContainer1;
    private SplitPanel splitPanel1;
    private SplitPanel splitPanel2;
    private RadButton radSteamLink;
    private RadCheckBox chkSteamLink;

    public frmShortcutType(GClass30 gclass30_1)
    {
      this.InitializeComponent();
      this.gclass30_0 = gclass30_1;
      try
      {
        this.cmdSteam.Enabled = Directory.Exists(SteamManager.GetSteamFolder());
      }
      catch
      {
        this.cmdSteam.Enabled = false;
      }
    }

    public GEnum9 ShortcutType { get; private set; }

    public bool SteamLinkFix { get; private set; }

    private void cmdShortcut_Click(object sender, EventArgs e)
    {
      this.ShortcutType = GEnum9.const_1;
      this.DialogResult = DialogResult.OK;
    }

    private void cmdSteam_Click(object sender, EventArgs e)
    {
      this.ShortcutType = GEnum9.const_0;
      this.DialogResult = DialogResult.OK;
      this.SteamLinkFix = this.chkSteamLink.Checked;
    }

    private void frmShortcutType_Load(object sender, EventArgs e)
    {
      this.radSteamLink.Visible = this.gclass30_0.method_14(false).GetControllerProfiles().Any<GClass95.GStruct6>((Func<GClass95.GStruct6, bool>) (gstruct6_0 => gstruct6_0.ResUrl.Contains("steamlink")));
      this.chkSteamLink.Visible = this.gclass30_0.method_14(false) is Cemu;
    }

    private void lblCloseSteam_Click(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("Steam"))
        process.Kill();
    }

    private void radSteamLink_Click(object sender, EventArgs e)
    {
      this.gclass30_0.method_14(false).ApplyControllerProfile(this.gclass30_0.method_14(false).GetControllerProfiles().First<GClass95.GStruct6>((Func<GClass95.GStruct6, bool>) (gstruct6_0 => gstruct6_0.ResUrl.Contains("steamlink"))));
      int num = (int) RadMessageBox.Show("Done!");
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      bool flag = GClass6.smethod_16("Steam");
      this.cmdSteam.Enabled = !flag;
      this.lblCloseSteam.Visible = flag;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmShortcutType));
      this.cmdShortcut = new RadButton();
      this.cmdSteam = new RadButton();
      this.pictureBox1 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.timer_0 = new Timer(this.icontainer_0);
      this.lblCloseSteam = new RadLabel();
      this.radSplitContainer1 = new RadSplitContainer();
      this.splitPanel1 = new SplitPanel();
      this.splitPanel2 = new SplitPanel();
      this.radSteamLink = new RadButton();
      this.chkSteamLink = new RadCheckBox();
      this.cmdShortcut.BeginInit();
      this.cmdSteam.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.lblCloseSteam.BeginInit();
      this.radSplitContainer1.BeginInit();
      this.radSplitContainer1.SuspendLayout();
      this.splitPanel1.BeginInit();
      this.splitPanel1.SuspendLayout();
      this.splitPanel2.BeginInit();
      this.splitPanel2.SuspendLayout();
      this.radSteamLink.BeginInit();
      this.chkSteamLink.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.cmdShortcut.Location = new Point(100, 168);
      this.cmdShortcut.Name = "cmdShortcut";
      this.cmdShortcut.Size = new Size(172, 24);
      this.cmdShortcut.TabIndex = 0;
      this.cmdShortcut.Text = "Create a desktop shortcut";
      this.cmdShortcut.Click += new EventHandler(this.cmdShortcut_Click);
      this.cmdSteam.Location = new Point(85, 138);
      this.cmdSteam.Name = "cmdSteam";
      this.cmdSteam.Size = new Size(172, 24);
      this.cmdSteam.TabIndex = 1;
      this.cmdSteam.Text = "Add game to Steam";
      this.cmdSteam.Click += new EventHandler(this.cmdSteam_Click);
      this.pictureBox1.Image = (Image) Class123.icnSteam;
      this.pictureBox1.Location = new Point(123, 17);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(96, 96);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox2.Image = (Image) Class123.icnDesktop;
      this.pictureBox2.Location = new Point(138, 47);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(96, 96);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      this.radLabel1.AutoSize = false;
      this.radLabel1.Location = new Point(59, 198);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(227, 21);
      this.radLabel1.TabIndex = 4;
      this.radLabel1.Text = "<html><ul><li>Launch the game from your dekstop</li></ul></html>";
      this.radLabel2.Location = new Point(40, 168);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(263, 46);
      this.radLabel2.TabIndex = 5;
      this.radLabel2.Text = "<html><ul><li>Launch the game from Steam</li><li>Launch the game from the Big Picture Mode</li><li>Launch the game with the Steam Link</li></ul></html>";
      this.timer_0.Enabled = true;
      this.timer_0.Interval = 150;
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.lblCloseSteam.Cursor = Cursors.Hand;
      this.lblCloseSteam.ForeColor = Color.Red;
      this.lblCloseSteam.Location = new Point(41, 119);
      this.lblCloseSteam.Name = "lblCloseSteam";
      this.lblCloseSteam.Size = new Size(260, 18);
      this.lblCloseSteam.TabIndex = 6;
      this.lblCloseSteam.Text = "Please close Steam to proceed (click to force close)";
      this.lblCloseSteam.Visible = false;
      this.lblCloseSteam.Click += new EventHandler(this.lblCloseSteam_Click);
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel1);
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel2);
      this.radSplitContainer1.Dock = DockStyle.Fill;
      this.radSplitContainer1.Location = new Point(0, 0);
      this.radSplitContainer1.Name = "radSplitContainer1";
      this.radSplitContainer1.RootElement.MinSize = new Size(25, 25);
      this.radSplitContainer1.Size = new Size(691, 266);
      this.radSplitContainer1.TabIndex = 8;
      this.radSplitContainer1.TabStop = false;
      this.radSplitContainer1.Text = "radSplitContainer1";
      this.splitPanel1.Controls.Add((Control) this.pictureBox2);
      this.splitPanel1.Controls.Add((Control) this.cmdShortcut);
      this.splitPanel1.Controls.Add((Control) this.radLabel1);
      this.splitPanel1.Location = new Point(0, 0);
      this.splitPanel1.Name = "splitPanel1";
      this.splitPanel1.RootElement.MinSize = new Size(25, 25);
      this.splitPanel1.Size = new Size(344, 266);
      this.splitPanel1.TabIndex = 0;
      this.splitPanel1.TabStop = false;
      this.splitPanel1.Text = "splitPanel1";
      this.splitPanel2.Controls.Add((Control) this.chkSteamLink);
      this.splitPanel2.Controls.Add((Control) this.radSteamLink);
      this.splitPanel2.Controls.Add((Control) this.pictureBox1);
      this.splitPanel2.Controls.Add((Control) this.cmdSteam);
      this.splitPanel2.Controls.Add((Control) this.lblCloseSteam);
      this.splitPanel2.Controls.Add((Control) this.radLabel2);
      this.splitPanel2.Location = new Point(348, 0);
      this.splitPanel2.Name = "splitPanel2";
      this.splitPanel2.RootElement.MinSize = new Size(25, 25);
      this.splitPanel2.Size = new Size(343, 266);
      this.splitPanel2.TabIndex = 1;
      this.splitPanel2.TabStop = false;
      this.splitPanel2.Text = "splitPanel2";
      this.radSteamLink.Location = new Point(114, 239);
      this.radSteamLink.Name = "radSteamLink";
      this.radSteamLink.Size = new Size(226, 24);
      this.radSteamLink.TabIndex = 7;
      this.radSteamLink.Text = "Download Steam Link Input Configuration";
      this.radSteamLink.Click += new EventHandler(this.radSteamLink_Click);
      this.chkSteamLink.Location = new Point(19, 242);
      this.chkSteamLink.Name = "chkSteamLink";
      this.chkSteamLink.Size = new Size(89, 18);
      this.chkSteamLink.TabIndex = 8;
      this.chkSteamLink.Text = "Steam Link fix";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(691, 266);
      this.Controls.Add((Control) this.radSplitContainer1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmShortcutType);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Choose a shortcut";
      this.Load += new EventHandler(this.frmShortcutType_Load);
      this.cmdShortcut.EndInit();
      this.cmdSteam.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.lblCloseSteam.EndInit();
      this.radSplitContainer1.EndInit();
      this.radSplitContainer1.ResumeLayout(false);
      this.splitPanel1.EndInit();
      this.splitPanel1.ResumeLayout(false);
      this.splitPanel1.PerformLayout();
      this.splitPanel2.EndInit();
      this.splitPanel2.ResumeLayout(false);
      this.splitPanel2.PerformLayout();
      this.radSteamLink.EndInit();
      this.chkSteamLink.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
