// Decompiled with JetBrains decompiler
// Type: ns0.frmInjection
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmInjection : RadForm
  {
    private const string string_0 = "<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>This way you can enjoy Gamecube games with your Wii U Gamepad!</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required ISO.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>";
    private string string_1;
    private GClass91 gclass91_0;
    private GClass32 gclass32_0;
    private IContainer icontainer_0;
    private RadGroupBox radGroupBox1;
    private RadLabel lblIntro;
    private RadGroupBox grpDrop;
    private PictureBox pictureBox1;
    private RadLabel lblDrop;
    private PictureBox pictureBox2;
    private RadLabel radLabel3;
    private RadButton cmdPrepareSd;
    private RadButton cmdBrowse;
    private RadCheckBox chkRatio;
    private RadLabel radLabel2;
    private System.Windows.Forms.Label lblCount;
    private RadButton radButton1;

    public frmInjection(GClass32 gclass32_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmInjection.Class147 class147 = new frmInjection.Class147();
      // ISSUE: reference to a compiler-generated field
      class147.gclass32_0 = gclass32_1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      // ISSUE: reference to a compiler-generated field
      class147.frmInjection_0 = this;
      this.InitializeComponent();
      // ISSUE: reference to a compiler-generated field
      if (!class147.gclass32_0.Boolean_0)
        throw new ArgumentException("Only injectable titles can be provided!");
      // ISSUE: reference to a compiler-generated field
      this.gclass32_0 = class147.gclass32_0;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("The injection tool is starting...", new Action(class147.method_0), (Action<Exception>) null);
      this.string_1 = string.Format("<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required {0}.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>", (object) this.gclass91_0.String_1);
      this.grpDrop.Text = string.Format("Drop the following {0} : {1}({2}) {3}", (object) this.gclass91_0.String_1, (object) this.gclass32_0.Name, (object) this.gclass32_0.ProductId, (object) this.gclass32_0.Region);
      this.lblDrop.Text = string.Format("Drop the following {0} : {1}({2}) {3}", (object) this.gclass91_0.String_1, (object) this.gclass32_0.Name, (object) this.gclass32_0.ProductId, (object) this.gclass32_0.Region);
      if (this.gclass32_0.Platform != Platform.Gamecube)
        this.chkRatio.Enabled = false;
      if (this.gclass32_0.Platform == Platform.Gamecube)
        this.lblIntro.Text = "<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>This way you can enjoy Gamecube games with your Wii U Gamepad!</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required ISO.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>";
      else
        this.lblIntro.Text = this.string_1;
      this.method_3();
      if (this.gclass32_0.Platform == Platform.Gamecube)
        this.Size = new Size(609, 465);
      else
        this.Size = new Size(609, 362);
    }

    private void method_0(object sender, StateChangingEventArgs e)
    {
      if (e.NewValue != ToggleState.Off || RadMessageBox.Show("If you disable this you will NOT be able to play this game with your GamePad. Continue?", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.No)
        return;
      e.Cancel = true;
    }

    private void cmdBrowse_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Multiselect = false;
      openFileDialog1.CheckFileExists = true;
      OpenFileDialog openFileDialog2 = openFileDialog1;
      openFileDialog2.Filter = this.gclass91_0.String_2;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.method_4(openFileDialog2.FileName);
    }

    private void cmdPrepareSd_Click(object sender, EventArgs e)
    {
      FrmSelectDrive frmSelectDrive = new FrmSelectDrive(new DataSize(5000000UL));
      if (frmSelectDrive.ShowDialog() != DialogResult.OK)
        return;
      GClass94.smethod_9(frmSelectDrive.driveInfo_0);
      GClass94.smethod_10(frmSelectDrive.driveInfo_0);
    }

    private void frmInjection_Load(object sender, EventArgs e)
    {
      this.pictureBox1.ImageLocation = this.gclass32_0.IconUrl;
      if (!GClass91.Boolean_0)
      {
        if (RadMessageBox.Show("Java is not installed but is required to use this feature. Would you like to install it now?", "Java", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          Process.Start("https://www.java.com/en/");
          int num = (int) RadMessageBox.Show("Please restart the app once you have installed Java.");
          this.Close();
        }
        else
        {
          int num = (int) RadMessageBox.Show("The process cannot continue without Java.");
          this.Close();
          return;
        }
      }
      GClass94 gclass910;
      if ((gclass910 = this.gclass91_0 as GClass94) == null || gclass910.PatchGame == null || !gclass910.method_14())
        return;
      this.Close();
    }

    private void grpDrop_DragDrop(object sender, DragEventArgs e)
    {
      this.method_4(((string[]) e.Data.GetData(DataFormats.FileDrop))[0]);
    }

    private void grpDrop_DragEnter(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      e.Effect = DragDropEffects.Copy;
    }

    private void method_1()
    {
      int num = (int) new frmInjectionAnimation(this.gclass91_0).ShowDialog();
      this.Close();
    }

    private void method_2()
    {
      int num = (int) RadMessageBox.Show("Your java version is too old. Please go to https://www.java.com/en/ , install it, resart the app and try again.");
      this.Close();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      Process.Start(string.Format("{0}/vote/gamecube.php", (object) Class67.String_3));
    }

    private void radLabel2_Click(object sender, EventArgs e)
    {
      int num = (int) RadMessageBox.Show("This feature is made possible by the following tools:\n-nfs2iso2nfs by FIX94\n-Nintendont by FIX94\n-wit by Wiimm\n-NusPacker by timogus");
    }

    private void method_3()
    {
      this.lblCount.Text = string.Format("{0} {1}(s) provided out of {2}", (object) this.gclass91_0.vmethod_1(), (object) this.gclass91_0.String_1, (object) this.gclass91_0.RomCount);
    }

    private void method_4(string string_2)
    {
      if (this.gclass91_0.vmethod_0(string_2))
        this.method_1();
      this.method_3();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInjection));
      this.radGroupBox1 = new RadGroupBox();
      this.radButton1 = new RadButton();
      this.radLabel2 = new RadLabel();
      this.chkRatio = new RadCheckBox();
      this.grpDrop = new RadGroupBox();
      this.lblDrop = new RadLabel();
      this.lblCount = new System.Windows.Forms.Label();
      this.cmdBrowse = new RadButton();
      this.cmdPrepareSd = new RadButton();
      this.radLabel3 = new RadLabel();
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.lblIntro = new RadLabel();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radButton1.BeginInit();
      this.radLabel2.BeginInit();
      this.chkRatio.BeginInit();
      this.grpDrop.BeginInit();
      this.grpDrop.SuspendLayout();
      this.lblDrop.BeginInit();
      this.lblDrop.SuspendLayout();
      this.cmdBrowse.BeginInit();
      this.cmdPrepareSd.BeginInit();
      this.radLabel3.BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.lblIntro.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.radButton1);
      this.radGroupBox1.Controls.Add((Control) this.radLabel2);
      this.radGroupBox1.Controls.Add((Control) this.chkRatio);
      this.radGroupBox1.Controls.Add((Control) this.grpDrop);
      this.radGroupBox1.Controls.Add((Control) this.cmdPrepareSd);
      this.radGroupBox1.Controls.Add((Control) this.radLabel3);
      this.radGroupBox1.Controls.Add((Control) this.pictureBox2);
      this.radGroupBox1.Controls.Add((Control) this.pictureBox1);
      this.radGroupBox1.Controls.Add((Control) this.lblIntro);
      this.radGroupBox1.Dock = DockStyle.Fill;
      this.radGroupBox1.HeaderText = "Injection";
      this.radGroupBox1.Location = new Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(601, 435);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Injection";
      this.radButton1.Location = new Point(458, 12);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(138, 24);
      this.radButton1.TabIndex = 0;
      this.radButton1.Text = "Vote for the next games!";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.radLabel2.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel2.Location = new Point(5, 412);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(120, 18);
      this.radLabel2.TabIndex = 9;
      this.radLabel2.Text = "See the Special Thanks";
      this.radLabel2.Click += new EventHandler(this.radLabel2_Click);
      this.chkRatio.Location = new Point(480, 396);
      this.chkRatio.Name = "chkRatio";
      this.chkRatio.Size = new Size(91, 18);
      this.chkRatio.TabIndex = 8;
      this.chkRatio.Text = "Force 4:3 ratio";
      this.grpDrop.AccessibleRole = AccessibleRole.Grouping;
      this.grpDrop.AllowDrop = true;
      this.grpDrop.Controls.Add((Control) this.lblDrop);
      this.grpDrop.HeaderText = "Drop the ISO here !";
      this.grpDrop.Location = new Point(27, 160);
      this.grpDrop.Name = "grpDrop";
      this.grpDrop.Size = new Size(546, 169);
      this.grpDrop.TabIndex = 1;
      this.grpDrop.Text = "Drop the ISO here !";
      this.grpDrop.DragDrop += new DragEventHandler(this.grpDrop_DragDrop);
      this.grpDrop.DragEnter += new DragEventHandler(this.grpDrop_DragEnter);
      this.lblDrop.AutoSize = false;
      this.lblDrop.Controls.Add((Control) this.lblCount);
      this.lblDrop.Controls.Add((Control) this.cmdBrowse);
      this.lblDrop.Dock = DockStyle.Fill;
      this.lblDrop.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDrop.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.lblDrop.Location = new Point(2, 18);
      this.lblDrop.Name = "lblDrop";
      this.lblDrop.Size = new Size(542, 149);
      this.lblDrop.TabIndex = 0;
      this.lblDrop.Text = "Drop your ISO here!";
      this.lblDrop.TextAlignment = ContentAlignment.MiddleCenter;
      this.lblCount.AutoSize = true;
      this.lblCount.Location = new Point(386, 133);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new Size(156, 13);
      this.lblCount.TabIndex = 1;
      this.lblCount.Text = "{x} disc(s) provded out of {x}";
      this.cmdBrowse.Location = new Point(216, 122);
      this.cmdBrowse.Name = "cmdBrowse";
      this.cmdBrowse.Size = new Size(110, 24);
      this.cmdBrowse.TabIndex = 0;
      this.cmdBrowse.Text = "Browse...";
      this.cmdBrowse.Click += new EventHandler(this.cmdBrowse_Click);
      this.cmdPrepareSd.Image = (Image) Class123.icnSd;
      this.cmdPrepareSd.Location = new Point(206, 363);
      this.cmdPrepareSd.Name = "cmdPrepareSd";
      this.cmdPrepareSd.Padding = new Padding(8);
      this.cmdPrepareSd.Size = new Size(203, 51);
      this.cmdPrepareSd.TabIndex = 7;
      this.cmdPrepareSd.Text = "Prepare my SD";
      this.cmdPrepareSd.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdPrepareSd.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdPrepareSd.ThemeName = "VisualStudio2012Dark";
      this.cmdPrepareSd.Click += new EventHandler(this.cmdPrepareSd_Click);
      this.radLabel3.Location = new Point(116, 340);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(447, 17);
      this.radLabel3.TabIndex = 4;
      this.radLabel3.Text = "<html><strong><span style=\"color: #ff8000\">In order to be able to launch these games, you must prepare your SD at least once.</span></strong></html>";
      this.pictureBox2.Image = (Image) Class123.warning;
      this.pictureBox2.Location = new Point(29, 333);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(64, 64);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      this.pictureBox1.Location = new Point(27, 44);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(90, 90);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.lblIntro.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblIntro.Location = new Point(126, 21);
      this.lblIntro.Name = "lblIntro";
      this.lblIntro.Size = new Size(465, 323);
      this.lblIntro.TabIndex = 1;
      this.lblIntro.Text = componentResourceManager.GetString("lblIntro.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(601, 435);
      this.Controls.Add((Control) this.radGroupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmInjection);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Injection";
      this.Load += new EventHandler(this.frmInjection_Load);
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.radButton1.EndInit();
      this.radLabel2.EndInit();
      this.chkRatio.EndInit();
      this.grpDrop.EndInit();
      this.grpDrop.ResumeLayout(false);
      this.lblDrop.EndInit();
      this.lblDrop.ResumeLayout(false);
      this.lblDrop.PerformLayout();
      this.cmdBrowse.EndInit();
      this.cmdPrepareSd.EndInit();
      this.radLabel3.EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.lblIntro.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }

    internal sealed class Class146
    {
      [JsonProperty("force43")]
      public bool bool_0;
    }
  }
}
