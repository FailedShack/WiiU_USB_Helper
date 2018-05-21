// Decompiled with JetBrains decompiler
// Type: ns0.frmEmuInfo
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper.Emulators;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmEmuInfo : RadForm
  {
    private readonly GClass32 gclass32_0;
    private bool bool_0;
    private GClass95 gclass95_0;
    private IContainer icontainer_0;
    private RadGroupBox radGroupBox1;
    private RadButton cmdDeleteGame;
    private RadLabel label3;
    private RadLabel label2;
    private RadLabel label1;
    private RadLabel lblEmuPath;
    private RadLabel lblEmuStatus;
    private RadLabel lblEmuName;
    private RadGroupBox radGroupBox5;
    private RadLabel lblDLCStatus;
    private RadLabel radLabel1;
    private RadGroupBox radGroupBox4;
    private RadLabel lblUpdateVersion;
    private RadLabel lblUpdateStatus;
    private RadLabel radLabel7;
    private RadLabel radLabel4;
    private RadGroupBox radGroupBox3;
    private RadLabel lblGameStatus;
    private RadLabel radLabel6;
    private RadButton cmdDeleteUpdate;
    private RadButton cmdDeleteDlc;
    private RadGroupBox radGroupBox2;
    private PictureBox pictGame;
    private RadGroupBox radGroupBox6;
    private RadCheckBox chkExceptionUpdate;
    private RadCheckBox chkExceptionDLC;
    private RadButton cmdVerifyGame;
    private RadButton cmdVerifyUpdate;
    private RadButton cmdVerifyDlc;

    public frmEmuInfo(GClass32 gclass32_1)
    {
      this.gclass32_0 = gclass32_1;
      this.InitializeComponent();
    }

    private static string smethod_0(bool bool_1)
    {
      return !bool_1 ? "Not installed" : "Installed";
    }

    private void chkExceptionDLC_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.bool_0)
        return;
      if (this.chkExceptionDLC.Checked)
        GClass3.smethod_0((GClass30) this.gclass32_0.Dlc);
      else
        GClass3.smethod_1((GClass30) this.gclass32_0.Dlc);
    }

    private void chkExceptionUpdate_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (this.bool_0)
        return;
      if (this.chkExceptionUpdate.Checked)
        GClass3.smethod_0((GClass30) this.gclass32_0.Updates[0]);
      else
        GClass3.smethod_1((GClass30) this.gclass32_0.Updates[0]);
    }

    private void cmdDeleteDlc_Click(object sender, EventArgs e)
    {
      this.gclass95_0.DeleteDlc();
      this.method_0();
    }

    private void cmdDeleteGame_Click(object sender, EventArgs e)
    {
      this.gclass95_0.vmethod_1();
      this.method_0();
    }

    private void cmdDeleteUpdate_Click(object sender, EventArgs e)
    {
      this.gclass95_0.DeleteUpdate();
      this.method_0();
    }

    private void cmdVerifyDlc_Click(object sender, EventArgs e)
    {
      this.method_1((GClass30) this.gclass32_0.Dlc, (Cemu) this.gclass32_0.method_14(false));
    }

    private void cmdVerifyGame_Click(object sender, EventArgs e)
    {
      this.method_1((GClass30) this.gclass32_0, (Cemu) this.gclass32_0.method_14(false));
    }

    private void cmdVerifyUpdate_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmEmuInfo.Class138 class138 = new frmEmuInfo.Class138();
      Cemu cemu_0 = (Cemu) this.gclass32_0.method_14(false);
      // ISSUE: reference to a compiler-generated field
      class138.ulong_0 = cemu_0.GetUpdateVersion();
      // ISSUE: reference to a compiler-generated method
      this.method_1((GClass30) this.gclass32_0.Updates.Find(new Predicate<GClass33>(class138.method_0)), cemu_0);
    }

    private void frmEmuInfo_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void frmEmuInfo_Load(object sender, EventArgs e)
    {
      this.method_0();
    }

    private void method_0()
    {
      this.gclass95_0 = this.gclass32_0.method_14(false);
      if (this.gclass95_0 == null)
      {
        int num = (int) RadMessageBox.Show("This title does not support emulation, so there is nothing to show here!");
        this.Close();
      }
      else
      {
        this.lblEmuName.Text = this.gclass95_0.Name;
        this.lblEmuPath.Text = this.gclass95_0.String_4;
        this.lblEmuStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.Boolean_0);
        this.lblGameStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.Boolean_2);
        this.lblUpdateStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.UpdateIsInstalled());
        this.lblDLCStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.DlcIsInstalled());
        this.bool_0 = true;
        if (this.gclass32_0.Boolean_2)
          this.chkExceptionDLC.Checked = GClass3.smethod_3((GClass30) this.gclass32_0.Dlc);
        else
          this.chkExceptionDLC.Enabled = false;
        if (this.gclass32_0.Boolean_3)
          this.chkExceptionUpdate.Checked = GClass3.smethod_3((GClass30) this.gclass32_0.Updates[0]);
        else
          this.chkExceptionUpdate.Enabled = false;
        this.bool_0 = false;
        this.lblUpdateVersion.Text = string.Format("v{0}", (object) this.gclass95_0.GetUpdateVersion());
        bool flag = this.gclass32_0.method_14(false) is Cemu;
        this.cmdVerifyGame.Visible = flag && this.gclass95_0.Boolean_2;
        this.cmdVerifyUpdate.Visible = flag && this.gclass95_0.UpdateIsInstalled();
        this.cmdVerifyDlc.Visible = flag && this.gclass95_0.DlcIsInstalled();
        this.cmdDeleteGame.Enabled = this.gclass95_0.Boolean_2;
        this.cmdDeleteUpdate.Enabled = this.gclass95_0.UpdateIsInstalled();
        this.cmdDeleteDlc.Enabled = this.gclass95_0.DlcIsInstalled();
        this.pictGame.Image = this.gclass32_0.gclass86_2.Image;
        foreach (object control1 in (ArrangedElementCollection) this.radGroupBox1.Controls)
        {
          if (control1 is RadGroupBox)
          {
            foreach (object control2 in (ArrangedElementCollection) ((Control) control1).Controls)
            {
              if (control2 is RadLabel)
              {
                RadLabel radLabel = (RadLabel) control2;
                string text = radLabel.Text;
                if (!(text == "Installed"))
                {
                  if (text == "Not installed")
                    radLabel.ForeColor = Color.Red;
                }
                else
                  radLabel.ForeColor = Color.Green;
              }
            }
          }
        }
      }
    }

    private void method_1(GClass30 gclass30_0, Cemu cemu_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmEmuInfo.Class139 class139 = new frmEmuInfo.Class139();
      // ISSUE: reference to a compiler-generated field
      class139.gclass30_0 = gclass30_0;
      // ISSUE: reference to a compiler-generated field
      class139.cemu_0 = cemu_0;
      // ISSUE: reference to a compiler-generated field
      class139.bool_0 = false;
      int num1;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("USB Helper is verifying your data...", new Action(class139.method_0), (Action<Exception>) (exception_0 => num1 = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
      // ISSUE: reference to a compiler-generated field
      if (class139.bool_0)
      {
        int num2 = (int) RadMessageBox.Show("USB Helper has detected that this title wasn't installed properly. Please delete it and try again.");
      }
      else
      {
        int num3 = (int) RadMessageBox.Show("No errors were found.");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmuInfo));
      this.radGroupBox1 = new RadGroupBox();
      this.radGroupBox6 = new RadGroupBox();
      this.lblEmuPath = new RadLabel();
      this.label1 = new RadLabel();
      this.lblEmuStatus = new RadLabel();
      this.label2 = new RadLabel();
      this.lblEmuName = new RadLabel();
      this.label3 = new RadLabel();
      this.radGroupBox3 = new RadGroupBox();
      this.cmdVerifyGame = new RadButton();
      this.pictGame = new PictureBox();
      this.lblGameStatus = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.radGroupBox4 = new RadGroupBox();
      this.cmdVerifyUpdate = new RadButton();
      this.chkExceptionUpdate = new RadCheckBox();
      this.lblUpdateVersion = new RadLabel();
      this.lblUpdateStatus = new RadLabel();
      this.radLabel7 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radGroupBox5 = new RadGroupBox();
      this.cmdVerifyDlc = new RadButton();
      this.chkExceptionDLC = new RadCheckBox();
      this.lblDLCStatus = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.cmdDeleteGame = new RadButton();
      this.cmdDeleteUpdate = new RadButton();
      this.cmdDeleteDlc = new RadButton();
      this.radGroupBox2 = new RadGroupBox();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radGroupBox6.BeginInit();
      this.radGroupBox6.SuspendLayout();
      this.lblEmuPath.BeginInit();
      this.label1.BeginInit();
      this.lblEmuStatus.BeginInit();
      this.label2.BeginInit();
      this.lblEmuName.BeginInit();
      this.label3.BeginInit();
      this.radGroupBox3.BeginInit();
      this.radGroupBox3.SuspendLayout();
      this.cmdVerifyGame.BeginInit();
      ((ISupportInitialize) this.pictGame).BeginInit();
      this.lblGameStatus.BeginInit();
      this.radLabel6.BeginInit();
      this.radGroupBox4.BeginInit();
      this.radGroupBox4.SuspendLayout();
      this.cmdVerifyUpdate.BeginInit();
      this.chkExceptionUpdate.BeginInit();
      this.lblUpdateVersion.BeginInit();
      this.lblUpdateStatus.BeginInit();
      this.radLabel7.BeginInit();
      this.radLabel4.BeginInit();
      this.radGroupBox5.BeginInit();
      this.radGroupBox5.SuspendLayout();
      this.cmdVerifyDlc.BeginInit();
      this.chkExceptionDLC.BeginInit();
      this.lblDLCStatus.BeginInit();
      this.radLabel1.BeginInit();
      this.cmdDeleteGame.BeginInit();
      this.cmdDeleteUpdate.BeginInit();
      this.cmdDeleteDlc.BeginInit();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      this.BeginInit();
      this.SuspendLayout();
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.radGroupBox6);
      this.radGroupBox1.Controls.Add((Control) this.radGroupBox3);
      this.radGroupBox1.Controls.Add((Control) this.radGroupBox4);
      this.radGroupBox1.Controls.Add((Control) this.radGroupBox5);
      this.radGroupBox1.Dock = DockStyle.Fill;
      this.radGroupBox1.HeaderText = "Info";
      this.radGroupBox1.Location = new Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(1114, 154);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Info";
      this.radGroupBox6.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox6.Controls.Add((Control) this.lblEmuPath);
      this.radGroupBox6.Controls.Add((Control) this.label1);
      this.radGroupBox6.Controls.Add((Control) this.lblEmuStatus);
      this.radGroupBox6.Controls.Add((Control) this.label2);
      this.radGroupBox6.Controls.Add((Control) this.lblEmuName);
      this.radGroupBox6.Controls.Add((Control) this.label3);
      this.radGroupBox6.Dock = DockStyle.Fill;
      this.radGroupBox6.HeaderText = "Emulator information";
      this.radGroupBox6.Location = new Point(2, 18);
      this.radGroupBox6.Name = "radGroupBox6";
      this.radGroupBox6.Size = new Size(430, 134);
      this.radGroupBox6.TabIndex = 2;
      this.radGroupBox6.Text = "Emulator information";
      this.lblEmuPath.Location = new Point(21, 89);
      this.lblEmuPath.Name = "lblEmuPath";
      this.lblEmuPath.Size = new Size(11, 18);
      this.lblEmuPath.TabIndex = 7;
      this.lblEmuPath.Text = "-";
      this.label1.Location = new Point(21, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(57, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Emulator :";
      this.lblEmuStatus.Location = new Point(120, 42);
      this.lblEmuStatus.Name = "lblEmuStatus";
      this.lblEmuStatus.Size = new Size(11, 18);
      this.lblEmuStatus.TabIndex = 6;
      this.lblEmuStatus.Text = "-";
      this.label2.Location = new Point(21, 43);
      this.label2.Name = "label2";
      this.label2.Size = new Size(89, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Emulator status :";
      this.lblEmuName.Location = new Point(120, 18);
      this.lblEmuName.Name = "lblEmuName";
      this.lblEmuName.Size = new Size(11, 18);
      this.lblEmuName.TabIndex = 5;
      this.lblEmuName.Text = "-";
      this.label3.Location = new Point(21, 65);
      this.label3.Name = "label3";
      this.label3.Size = new Size(82, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "Emulator path :";
      this.radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox3.Controls.Add((Control) this.cmdVerifyGame);
      this.radGroupBox3.Controls.Add((Control) this.pictGame);
      this.radGroupBox3.Controls.Add((Control) this.lblGameStatus);
      this.radGroupBox3.Controls.Add((Control) this.radLabel6);
      this.radGroupBox3.Dock = DockStyle.Right;
      this.radGroupBox3.HeaderText = "Game Info";
      this.radGroupBox3.Location = new Point(432, 18);
      this.radGroupBox3.Name = "radGroupBox3";
      this.radGroupBox3.Size = new Size(280, 134);
      this.radGroupBox3.TabIndex = 2;
      this.radGroupBox3.Text = "Game Info";
      this.cmdVerifyGame.Location = new Point(85, 105);
      this.cmdVerifyGame.Name = "cmdVerifyGame";
      this.cmdVerifyGame.Size = new Size(110, 24);
      this.cmdVerifyGame.TabIndex = 13;
      this.cmdVerifyGame.Text = "Verify";
      this.cmdVerifyGame.Visible = false;
      this.cmdVerifyGame.Click += new EventHandler(this.cmdVerifyGame_Click);
      this.pictGame.Location = new Point(227, 16);
      this.pictGame.Name = "pictGame";
      this.pictGame.Size = new Size(48, 48);
      this.pictGame.TabIndex = 8;
      this.pictGame.TabStop = false;
      this.lblGameStatus.Location = new Point(83, 21);
      this.lblGameStatus.Name = "lblGameStatus";
      this.lblGameStatus.Size = new Size(11, 18);
      this.lblGameStatus.TabIndex = 10;
      this.lblGameStatus.Text = "-";
      this.radLabel6.Location = new Point(6, 22);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(46, 18);
      this.radLabel6.TabIndex = 4;
      this.radLabel6.Text = "Status : ";
      this.radGroupBox4.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox4.Controls.Add((Control) this.cmdVerifyUpdate);
      this.radGroupBox4.Controls.Add((Control) this.chkExceptionUpdate);
      this.radGroupBox4.Controls.Add((Control) this.lblUpdateVersion);
      this.radGroupBox4.Controls.Add((Control) this.lblUpdateStatus);
      this.radGroupBox4.Controls.Add((Control) this.radLabel7);
      this.radGroupBox4.Controls.Add((Control) this.radLabel4);
      this.radGroupBox4.Dock = DockStyle.Right;
      this.radGroupBox4.HeaderText = "Update Info";
      this.radGroupBox4.Location = new Point(712, 18);
      this.radGroupBox4.Name = "radGroupBox4";
      this.radGroupBox4.Size = new Size(200, 134);
      this.radGroupBox4.TabIndex = 3;
      this.radGroupBox4.Text = "Update Info";
      this.cmdVerifyUpdate.Location = new Point(45, 105);
      this.cmdVerifyUpdate.Name = "cmdVerifyUpdate";
      this.cmdVerifyUpdate.Size = new Size(110, 24);
      this.cmdVerifyUpdate.TabIndex = 11;
      this.cmdVerifyUpdate.Text = "Verify";
      this.cmdVerifyUpdate.Visible = false;
      this.cmdVerifyUpdate.Click += new EventHandler(this.cmdVerifyUpdate_Click);
      this.chkExceptionUpdate.Location = new Point(7, 70);
      this.chkExceptionUpdate.Name = "chkExceptionUpdate";
      this.chkExceptionUpdate.Size = new Size(94, 18);
      this.chkExceptionUpdate.TabIndex = 10;
      this.chkExceptionUpdate.Text = "Do not unpack";
      this.chkExceptionUpdate.ToggleStateChanged += new StateChangedEventHandler(this.chkExceptionUpdate_ToggleStateChanged);
      this.lblUpdateVersion.Location = new Point(84, 46);
      this.lblUpdateVersion.Name = "lblUpdateVersion";
      this.lblUpdateVersion.Size = new Size(11, 18);
      this.lblUpdateVersion.TabIndex = 9;
      this.lblUpdateVersion.Text = "-";
      this.lblUpdateStatus.Location = new Point(83, 22);
      this.lblUpdateStatus.Name = "lblUpdateStatus";
      this.lblUpdateStatus.Size = new Size(11, 18);
      this.lblUpdateStatus.TabIndex = 7;
      this.lblUpdateStatus.Text = "-";
      this.radLabel7.Location = new Point(7, 46);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new Size(49, 18);
      this.radLabel7.TabIndex = 4;
      this.radLabel7.Text = "Version :";
      this.radLabel4.Location = new Point(6, 22);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(46, 18);
      this.radLabel4.TabIndex = 2;
      this.radLabel4.Text = "Status : ";
      this.radGroupBox5.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox5.Controls.Add((Control) this.cmdVerifyDlc);
      this.radGroupBox5.Controls.Add((Control) this.chkExceptionDLC);
      this.radGroupBox5.Controls.Add((Control) this.lblDLCStatus);
      this.radGroupBox5.Controls.Add((Control) this.radLabel1);
      this.radGroupBox5.Dock = DockStyle.Right;
      this.radGroupBox5.HeaderText = "DLC Info";
      this.radGroupBox5.Location = new Point(912, 18);
      this.radGroupBox5.Name = "radGroupBox5";
      this.radGroupBox5.Size = new Size(200, 134);
      this.radGroupBox5.TabIndex = 4;
      this.radGroupBox5.Text = "DLC Info";
      this.cmdVerifyDlc.Location = new Point(45, 105);
      this.cmdVerifyDlc.Name = "cmdVerifyDlc";
      this.cmdVerifyDlc.Size = new Size(110, 24);
      this.cmdVerifyDlc.TabIndex = 12;
      this.cmdVerifyDlc.Text = "Verify";
      this.cmdVerifyDlc.Visible = false;
      this.cmdVerifyDlc.Click += new EventHandler(this.cmdVerifyDlc_Click);
      this.chkExceptionDLC.Location = new Point(5, 70);
      this.chkExceptionDLC.Name = "chkExceptionDLC";
      this.chkExceptionDLC.Size = new Size(94, 18);
      this.chkExceptionDLC.TabIndex = 11;
      this.chkExceptionDLC.Text = "Do not unpack";
      this.chkExceptionDLC.ToggleStateChanged += new StateChangedEventHandler(this.chkExceptionDLC_ToggleStateChanged);
      this.lblDLCStatus.Location = new Point(88, 22);
      this.lblDLCStatus.Name = "lblDLCStatus";
      this.lblDLCStatus.Size = new Size(11, 18);
      this.lblDLCStatus.TabIndex = 6;
      this.lblDLCStatus.Text = "-";
      this.radLabel1.Location = new Point(11, 22);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(46, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Status : ";
      this.cmdDeleteGame.Anchor = AnchorStyles.None;
      this.cmdDeleteGame.Location = new Point(386, 24);
      this.cmdDeleteGame.Name = "cmdDeleteGame";
      this.cmdDeleteGame.Size = new Size(110, 24);
      this.cmdDeleteGame.TabIndex = 3;
      this.cmdDeleteGame.Text = "Delete Game";
      this.cmdDeleteGame.Click += new EventHandler(this.cmdDeleteGame_Click);
      this.cmdDeleteUpdate.Anchor = AnchorStyles.None;
      this.cmdDeleteUpdate.Location = new Point(502, 24);
      this.cmdDeleteUpdate.Name = "cmdDeleteUpdate";
      this.cmdDeleteUpdate.Size = new Size(110, 24);
      this.cmdDeleteUpdate.TabIndex = 4;
      this.cmdDeleteUpdate.Text = "Delete Update";
      this.cmdDeleteUpdate.Click += new EventHandler(this.cmdDeleteUpdate_Click);
      this.cmdDeleteDlc.Anchor = AnchorStyles.None;
      this.cmdDeleteDlc.Location = new Point(618, 24);
      this.cmdDeleteDlc.Name = "cmdDeleteDlc";
      this.cmdDeleteDlc.Size = new Size(110, 24);
      this.cmdDeleteDlc.TabIndex = 4;
      this.cmdDeleteDlc.Text = "Delete DLC";
      this.cmdDeleteDlc.Click += new EventHandler(this.cmdDeleteDlc_Click);
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add((Control) this.cmdDeleteDlc);
      this.radGroupBox2.Controls.Add((Control) this.cmdDeleteGame);
      this.radGroupBox2.Controls.Add((Control) this.cmdDeleteUpdate);
      this.radGroupBox2.Dock = DockStyle.Bottom;
      this.radGroupBox2.HeaderText = "Delete";
      this.radGroupBox2.Location = new Point(0, 154);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new Size(1114, 56);
      this.radGroupBox2.TabIndex = 1;
      this.radGroupBox2.Text = "Delete";
      this.ClientSize = new Size(1114, 210);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.radGroupBox2);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmEmuInfo);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Emulator Status";
      this.FormClosing += new FormClosingEventHandler(this.frmEmuInfo_FormClosing);
      this.Load += new EventHandler(this.frmEmuInfo_Load);
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox6.EndInit();
      this.radGroupBox6.ResumeLayout(false);
      this.radGroupBox6.PerformLayout();
      this.lblEmuPath.EndInit();
      this.label1.EndInit();
      this.lblEmuStatus.EndInit();
      this.label2.EndInit();
      this.lblEmuName.EndInit();
      this.label3.EndInit();
      this.radGroupBox3.EndInit();
      this.radGroupBox3.ResumeLayout(false);
      this.radGroupBox3.PerformLayout();
      this.cmdVerifyGame.EndInit();
      ((ISupportInitialize) this.pictGame).EndInit();
      this.lblGameStatus.EndInit();
      this.radLabel6.EndInit();
      this.radGroupBox4.EndInit();
      this.radGroupBox4.ResumeLayout(false);
      this.radGroupBox4.PerformLayout();
      this.cmdVerifyUpdate.EndInit();
      this.chkExceptionUpdate.EndInit();
      this.lblUpdateVersion.EndInit();
      this.lblUpdateStatus.EndInit();
      this.radLabel7.EndInit();
      this.radLabel4.EndInit();
      this.radGroupBox5.EndInit();
      this.radGroupBox5.ResumeLayout(false);
      this.radGroupBox5.PerformLayout();
      this.cmdVerifyDlc.EndInit();
      this.chkExceptionDLC.EndInit();
      this.lblDLCStatus.EndInit();
      this.radLabel1.EndInit();
      this.cmdDeleteGame.EndInit();
      this.cmdDeleteUpdate.EndInit();
      this.cmdDeleteDlc.EndInit();
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
