// Decompiled with JetBrains decompiler
// Type: ns0.frmSupport
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmSupport : RadForm
  {
    private List<string> list_0 = new List<string>();
    private string string_0;
    private IContainer icontainer_0;
    private PictureBox feedbackPictureBox;
    private RadLabel radLabel2;
    private RadGroupBox radGroupBox1;
    private RadDateTimePicker timeViewer;
    private RadLabel radLabel4;
    private RadCheckBox chkTeamViewer;
    private RadLabel lblusualtime;
    private RadPageViewPage pageContent;
    private RadGroupBox radGroupBox2;
    private RadLabel radLabel15;
    private RadButton radButton7;
    private RadButton radButton5;
    private RadCheckBox chkSyslog;
    private RadLabel radLabel12;
    private RadLabel radLabel13;
    private RadLabel radLabel1;
    private RadTextBox txtRemarks;
    private RadPageViewPage pageTitle;
    private RadTextBox radTextBox1;
    private RadCheckedListBox lstTitles;
    private RadLabel radLabel16;
    private RadLabel radLabel17;
    private RadButton radButton4;
    private RadLabel radLabel10;
    private RadLabel radLabel11;
    private RadLabel radLabel5;
    private RadTextBox txtTitle;
    private RadPageViewPage pageEmail;
    private RadLabel radLabel14;
    private RadButton radButton3;
    private RadTextBox txtEmail;
    private RadLabel radLabel9;
    private RadLabel emailLabel;
    private RadPageViewPage pageWelcome;
    private RadButton radButton2;
    private RadLabel radLabel3;
    private PictureBox pictureBox3;
    private RadLabel radLabel8;
    private PictureBox pictureBox2;
    private RadButton radButton1;
    private PictureBox pictureBox1;
    private RadLabel radLabel7;
    private RadLabel radLabel6;
    private RadPageView radPageView1;
    private RadLabel lblProvided;

    public frmSupport()
    {
      this.InitializeComponent();
    }

    public frmSupport(string string_1)
      : this()
    {
      this.string_0 = string_1;
    }

    private void method_0(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmSupport_Load(object sender, EventArgs e)
    {
      this.lblusualtime.Text = string.Format("<html><p>Usually, assistance is provided between <span style=\"color: #ff8000\">{0}</span> and <span style=\"color: #ff8000\">{1}</span>.</p></html>", (object) new DateTime(2017, 10, 10, 12, 0, 0).ToLocalTime().ToShortTimeString(), (object) new DateTime(2017, 10, 10, 17, 0, 0).ToLocalTime().ToShortTimeString());
      this.timeViewer.MinDate = DateTime.Now.AddDays(1.0);
      this.timeViewer.DateTimePickerElement.ShowTimePicker = true;
      this.timeViewer.Format = DateTimePickerFormat.Custom;
      this.timeViewer.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
      (this.timeViewer.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new Size(400, 375);
      this.lstTitles.BeginUpdate();
      foreach (GClass32 gclass32 in GClass28.dictionary_0.Values)
      {
        this.lstTitles.Items.Add(new ListViewDataItem((object) gclass32)
        {
          Tag = (object) gclass32
        });
        foreach (GClass33 update in gclass32.Updates)
          this.lstTitles.Items.Add(new ListViewDataItem((object) update)
          {
            Tag = (object) update
          });
        if (gclass32.Boolean_2)
          this.lstTitles.Items.Add(new ListViewDataItem((object) gclass32.Dlc)
          {
            Tag = (object) gclass32.Dlc
          });
      }
      this.lstTitles.EndUpdate();
    }

    private bool method_1(string string_1)
    {
      try
      {
        return new MailAddress(string_1).Address == string_1;
      }
      catch
      {
        return false;
      }
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new frmFaq().ShowDialog();
    }

    private void radButton2_Click(object sender, EventArgs e)
    {
      this.radPageView1.SelectedPage = this.radPageView1.Pages[1];
      this.txtEmail.Focus();
    }

    private void radButton3_Click(object sender, EventArgs e)
    {
      if (!this.method_1(this.txtEmail.Text))
      {
        int num = (int) RadMessageBox.Show("You must specify a valid email address, otherwise we can't reply to you!");
      }
      else
      {
        this.radPageView1.SelectedPage = this.radPageView1.Pages[2];
        this.txtTitle.Focus();
      }
    }

    private void radButton4_Click(object sender, EventArgs e)
    {
      if (this.txtTitle.Text == "")
      {
        int num = (int) RadMessageBox.Show("Please provide a short description of the issue.");
      }
      else
      {
        this.radPageView1.SelectedPage = this.radPageView1.Pages[3];
        this.txtRemarks.Focus();
      }
    }

    private void radButton5_Click(object sender, EventArgs e)
    {
      if (this.txtRemarks.Text.Length < 40)
      {
        int num1 = (int) RadMessageBox.Show("Your request must be at least 40 characters long.");
      }
      else
      {
        this.txtTitle.Text = this.txtTitle.Text.Trim();
        this.txtRemarks.Text = this.txtRemarks.Text.Trim();
        this.txtEmail.Text = this.txtEmail.Text.Trim();
        string str1 = this.chkSyslog.Checked ? GClass6.smethod_18() : "No data provided";
        if (this.txtTitle.Text == "")
        {
          int num2 = (int) RadMessageBox.Show("Please provide a short description of the issue.");
        }
        else if (this.txtRemarks.Text.Length < 40)
        {
          int num3 = (int) RadMessageBox.Show("Your request must be at least 40 characters long.");
        }
        else if (!this.method_1(this.txtEmail.Text))
        {
          int num4 = (int) RadMessageBox.Show("You must specify a valid email address, otherwise we can't reply to you!");
        }
        else
        {
          string str2 = this.txtRemarks.Text.Trim() + Environment.NewLine;
          foreach (ListViewDataItem checkedItem in (ReadOnlyCollection<ListViewDataItem>) this.lstTitles.CheckedItems)
            str2 = str2 + checkedItem.Tag + Environment.NewLine;
          if (this.chkTeamViewer.Checked)
            str2 = str2 + Environment.NewLine + string.Format("The user has requested a TeamViewer Session at {0}.", (object) TimeZoneInfo.ConvertTimeFromUtc(this.timeViewer.Value.ToUniversalTime(), TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time")));
          if (this.string_0 != null)
            str2 = str2 + Environment.NewLine + Environment.NewLine + this.string_0;
          string s = GClass6.smethod_20(string.Format("{0}/issue/open_issue.php", (object) Class67.String_4), new NameValueCollection() { { "email", this.txtEmail.Text }, { "app_id", Settings.Default.AppId }, { "title", this.txtTitle.Text }, { "syslog", str1 } });
          try
          {
            int num5 = (int) uint.Parse(s);
          }
          catch
          {
            int num5 = (int) RadMessageBox.Show("Sorry but we are unable to process your request at the moment");
            return;
          }
          string str3 = GClass6.smethod_20(string.Format("{0}/issue/answer_issue.php", (object) Class67.String_4), new NameValueCollection() { { "issue_id", s }, { "message", str2 } });
          try
          {
            int num5 = (int) uint.Parse(str3);
          }
          catch
          {
            int num5 = (int) RadMessageBox.Show("Sorry but we are unable to process your request at the moment");
            return;
          }
          foreach (string sourceFileName in this.list_0)
          {
            try
            {
              string str4 = Path.Combine(GClass88.CachePath, str3);
              System.IO.File.Copy(sourceFileName, str4, true);
              Encoding.UTF8.GetString(new WebClient().UploadFile(string.Format("{0}/issue/upload.php", (object) Class67.String_4), str4));
            }
            catch
            {
            }
          }
          int num6 = (int) RadMessageBox.Show(string.Format("<html>Thank you for contacting us!\nYou will be notified by email (make sure to check your spam box) when a reply is available.\nYour issue id is : {0}\nYou can follow its status <a href=\"{1}/issue/view/view.php?issue_id={2}\">here</a>.\nPlease keep it for future reference.<html>", (object) s, (object) Class67.String_4, (object) s));
          this.Close();
        }
      }
    }

    private void radButton7_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      if (new FileInfo(openFileDialog.FileName).Length > 3000000L)
      {
        int num = (int) RadMessageBox.Show("This file is too big");
      }
      else
      {
        if (this.list_0.Contains(openFileDialog.FileName))
          return;
        this.list_0.Add(openFileDialog.FileName);
        this.lblProvided.Text = string.Format("{0} file(s) provided", (object) this.list_0.Count);
      }
    }

    private void radTextBox1_TextChanged(object sender, EventArgs e)
    {
      this.lstTitles.EnableFiltering = true;
      this.lstTitles.FilterDescriptors.Clear();
      this.lstTitles.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, (object) this.radTextBox1.Text));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSupport));
      this.feedbackPictureBox = new PictureBox();
      this.radLabel2 = new RadLabel();
      this.radGroupBox1 = new RadGroupBox();
      this.lblusualtime = new RadLabel();
      this.timeViewer = new RadDateTimePicker();
      this.radLabel4 = new RadLabel();
      this.chkTeamViewer = new RadCheckBox();
      this.pageContent = new RadPageViewPage();
      this.radButton5 = new RadButton();
      this.radGroupBox2 = new RadGroupBox();
      this.lblProvided = new RadLabel();
      this.radLabel15 = new RadLabel();
      this.radButton7 = new RadButton();
      this.chkSyslog = new RadCheckBox();
      this.radLabel12 = new RadLabel();
      this.radLabel13 = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.txtRemarks = new RadTextBox();
      this.pageTitle = new RadPageViewPage();
      this.radTextBox1 = new RadTextBox();
      this.lstTitles = new RadCheckedListBox();
      this.radLabel16 = new RadLabel();
      this.radLabel17 = new RadLabel();
      this.radButton4 = new RadButton();
      this.radLabel10 = new RadLabel();
      this.radLabel11 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.txtTitle = new RadTextBox();
      this.pageEmail = new RadPageViewPage();
      this.radLabel14 = new RadLabel();
      this.radButton3 = new RadButton();
      this.txtEmail = new RadTextBox();
      this.radLabel9 = new RadLabel();
      this.emailLabel = new RadLabel();
      this.pageWelcome = new RadPageViewPage();
      this.radButton2 = new RadButton();
      this.radLabel3 = new RadLabel();
      this.pictureBox3 = new PictureBox();
      this.radLabel8 = new RadLabel();
      this.pictureBox2 = new PictureBox();
      this.radButton1 = new RadButton();
      this.pictureBox1 = new PictureBox();
      this.radLabel7 = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.radPageView1 = new RadPageView();
      ((ISupportInitialize) this.feedbackPictureBox).BeginInit();
      this.radLabel2.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.lblusualtime.BeginInit();
      this.timeViewer.BeginInit();
      this.radLabel4.BeginInit();
      this.chkTeamViewer.BeginInit();
      this.pageContent.SuspendLayout();
      this.radButton5.BeginInit();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      this.lblProvided.BeginInit();
      this.radLabel15.BeginInit();
      this.radButton7.BeginInit();
      this.chkSyslog.BeginInit();
      this.radLabel12.BeginInit();
      this.radLabel12.SuspendLayout();
      this.radLabel13.BeginInit();
      this.radLabel1.BeginInit();
      this.txtRemarks.BeginInit();
      this.pageTitle.SuspendLayout();
      this.radTextBox1.BeginInit();
      this.lstTitles.BeginInit();
      this.radLabel16.BeginInit();
      this.radLabel16.SuspendLayout();
      this.radLabel17.BeginInit();
      this.radButton4.BeginInit();
      this.radLabel10.BeginInit();
      this.radLabel10.SuspendLayout();
      this.radLabel11.BeginInit();
      this.radLabel5.BeginInit();
      this.txtTitle.BeginInit();
      this.pageEmail.SuspendLayout();
      this.radLabel14.BeginInit();
      this.radButton3.BeginInit();
      this.txtEmail.BeginInit();
      this.radLabel9.BeginInit();
      this.radLabel9.SuspendLayout();
      this.emailLabel.BeginInit();
      this.pageWelcome.SuspendLayout();
      this.radButton2.BeginInit();
      this.radLabel3.BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.radLabel8.BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.radButton1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.radLabel7.BeginInit();
      this.radLabel6.BeginInit();
      this.radPageView1.BeginInit();
      this.radPageView1.SuspendLayout();
      this.BeginInit();
      this.SuspendLayout();
      this.feedbackPictureBox.Image = (Image) Class123.logo;
      this.feedbackPictureBox.Location = new Point(12, 1);
      this.feedbackPictureBox.Name = "feedbackPictureBox";
      this.feedbackPictureBox.Size = new Size(88, 78);
      this.feedbackPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      this.feedbackPictureBox.TabIndex = 11;
      this.feedbackPictureBox.TabStop = false;
      this.radLabel2.Font = new Font("Segoe UI Black", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel2.Location = new Point(149, 12);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(270, 56);
      this.radLabel2.TabIndex = 19;
      this.radLabel2.Text = "HELP CENTER";
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.lblusualtime);
      this.radGroupBox1.Controls.Add((Control) this.timeViewer);
      this.radGroupBox1.Controls.Add((Control) this.radLabel4);
      this.radGroupBox1.Controls.Add((Control) this.chkTeamViewer);
      this.radGroupBox1.HeaderText = "Remote assistance";
      this.radGroupBox1.Location = new Point(12, 484);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(469, 158);
      this.radGroupBox1.TabIndex = 22;
      this.radGroupBox1.Text = "Remote assistance";
      this.lblusualtime.Location = new Point(14, 124);
      this.lblusualtime.Name = "lblusualtime";
      this.lblusualtime.Size = new Size(55, 18);
      this.lblusualtime.TabIndex = 3;
      this.lblusualtime.Text = "radLabel5";
      this.timeViewer.Location = new Point(14, 98);
      this.timeViewer.Name = "timeViewer";
      this.timeViewer.Size = new Size(441, 20);
      this.timeViewer.TabIndex = 2;
      this.timeViewer.TabStop = false;
      this.timeViewer.Text = "vendredi 15 septembre 2017";
      this.timeViewer.Value = new DateTime(2017, 9, 15, 19, 56, 50, 24);
      this.radLabel4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel4.Location = new Point(14, 46);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(419, 46);
      this.radLabel4.TabIndex = 1;
      this.radLabel4.Text = componentResourceManager.GetString("radLabel4.Text");
      this.chkTeamViewer.Location = new Point(117, 21);
      this.chkTeamViewer.Name = "chkTeamViewer";
      this.chkTeamViewer.Size = new Size(235, 18);
      this.chkTeamViewer.TabIndex = 0;
      this.chkTeamViewer.Text = "I wish to require assistance via TeamViewer";
      this.pageContent.Controls.Add((Control) this.radButton5);
      this.pageContent.Controls.Add((Control) this.radGroupBox2);
      this.pageContent.Controls.Add((Control) this.chkSyslog);
      this.pageContent.Controls.Add((Control) this.radLabel12);
      this.pageContent.Controls.Add((Control) this.radLabel1);
      this.pageContent.Controls.Add((Control) this.txtRemarks);
      this.pageContent.ItemSize = new SizeF(50f, 28f);
      this.pageContent.Location = new Point(10, 37);
      this.pageContent.Name = "pageContent";
      this.pageContent.Size = new Size(474, 345);
      this.pageContent.Text = "Details";
      this.radButton5.Image = (Image) Class123.icnArrow;
      this.radButton5.Location = new Point(343, 308);
      this.radButton5.Name = "radButton5";
      this.radButton5.Size = new Size(128, 37);
      this.radButton5.TabIndex = 18;
      this.radButton5.Text = "    &Done";
      this.radButton5.Click += new EventHandler(this.radButton5_Click);
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add((Control) this.lblProvided);
      this.radGroupBox2.Controls.Add((Control) this.radLabel15);
      this.radGroupBox2.Controls.Add((Control) this.radButton7);
      this.radGroupBox2.HeaderText = "Attach files";
      this.radGroupBox2.Location = new Point(3, 239);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new Size(468, 64);
      this.radGroupBox2.TabIndex = 28;
      this.radGroupBox2.Text = "Attach files";
      this.lblProvided.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblProvided.Location = new Point(5, 41);
      this.lblProvided.Name = "lblProvided";
      this.lblProvided.Size = new Size(87, 18);
      this.lblProvided.TabIndex = 2;
      this.lblProvided.Text = "0 file(s) provided";
      this.radLabel15.Location = new Point(5, 22);
      this.radLabel15.Name = "radLabel15";
      this.radLabel15.Size = new Size(204, 18);
      this.radLabel15.TabIndex = 1;
      this.radLabel15.Text = "Supported formats : png,jpg (3MB max)";
      this.radButton7.Location = new Point(337, 26);
      this.radButton7.Name = "radButton7";
      this.radButton7.Size = new Size(110, 24);
      this.radButton7.TabIndex = 0;
      this.radButton7.Text = "Browse...";
      this.radButton7.Click += new EventHandler(this.radButton7_Click);
      this.chkSyslog.CheckState = CheckState.Checked;
      this.chkSyslog.Location = new Point(3, 309);
      this.chkSyslog.Name = "chkSyslog";
      this.chkSyslog.Size = new Size(276, 18);
      this.chkSyslog.TabIndex = 27;
      this.chkSyslog.Text = "Include basic system info to facilitate the assistance";
      this.chkSyslog.ToggleState = ToggleState.On;
      this.radLabel12.Controls.Add((Control) this.radLabel13);
      this.radLabel12.Location = new Point(3, 3);
      this.radLabel12.Name = "radLabel12";
      this.radLabel12.Size = new Size(365, 17);
      this.radLabel12.TabIndex = 3;
      this.radLabel12.Text = "<html>Please provide us with as much details as possible regarding your issue :</html>";
      this.radLabel13.Location = new Point(0, 72);
      this.radLabel13.Name = "radLabel13";
      this.radLabel13.Size = new Size(141, 18);
      this.radLabel13.TabIndex = 12;
      this.radLabel13.Text = "E-mail Address (Required) :";
      this.radLabel1.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel1.Location = new Point(3, 26);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(176, 18);
      this.radLabel1.TabIndex = 18;
      this.radLabel1.Text = "Details about the issue : (Required)";
      this.txtRemarks.AcceptsReturn = true;
      this.txtRemarks.AcceptsTab = true;
      this.txtRemarks.AutoSize = false;
      this.txtRemarks.Location = new Point(3, 50);
      this.txtRemarks.Multiline = true;
      this.txtRemarks.Name = "txtRemarks";
      this.txtRemarks.Size = new Size(468, 186);
      this.txtRemarks.TabIndex = 3;
      this.pageTitle.Controls.Add((Control) this.radTextBox1);
      this.pageTitle.Controls.Add((Control) this.lstTitles);
      this.pageTitle.Controls.Add((Control) this.radLabel16);
      this.pageTitle.Controls.Add((Control) this.radButton4);
      this.pageTitle.Controls.Add((Control) this.radLabel10);
      this.pageTitle.Controls.Add((Control) this.radLabel5);
      this.pageTitle.Controls.Add((Control) this.txtTitle);
      this.pageTitle.ItemSize = new SizeF(102f, 28f);
      this.pageTitle.Location = new Point(10, 37);
      this.pageTitle.Name = "pageTitle";
      this.pageTitle.Size = new Size(474, 345);
      this.pageTitle.Text = "Short description";
      this.radTextBox1.Location = new Point(4, 101);
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.NullText = "Search...";
      this.radTextBox1.Size = new Size(467, 20);
      this.radTextBox1.TabIndex = 20;
      this.radTextBox1.TextChanged += new EventHandler(this.radTextBox1_TextChanged);
      this.lstTitles.Location = new Point(4, (int) sbyte.MaxValue);
      this.lstTitles.Name = "lstTitles";
      this.lstTitles.Size = new Size(467, 172);
      this.lstTitles.TabIndex = 19;
      this.lstTitles.Text = "radCheckedListBox1";
      this.radLabel16.Controls.Add((Control) this.radLabel17);
      this.radLabel16.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel16.Location = new Point(3, 78);
      this.radLabel16.Name = "radLabel16";
      this.radLabel16.Size = new Size(214, 18);
      this.radLabel16.TabIndex = 13;
      this.radLabel16.Text = "Does your issue concern a particular title?";
      this.radLabel17.Location = new Point(0, 72);
      this.radLabel17.Name = "radLabel17";
      this.radLabel17.Size = new Size(141, 18);
      this.radLabel17.TabIndex = 12;
      this.radLabel17.Text = "E-mail Address (Required) :";
      this.radButton4.Image = (Image) Class123.icnArrow;
      this.radButton4.Location = new Point(343, 305);
      this.radButton4.Name = "radButton4";
      this.radButton4.Size = new Size(128, 37);
      this.radButton4.TabIndex = 18;
      this.radButton4.Text = "    &Next";
      this.radButton4.Click += new EventHandler(this.radButton4_Click);
      this.radLabel10.Controls.Add((Control) this.radLabel11);
      this.radLabel10.Location = new Point(3, 3);
      this.radLabel10.Name = "radLabel10";
      this.radLabel10.Size = new Size(283, 18);
      this.radLabel10.TabIndex = 2;
      this.radLabel10.Text = "Please provide us with a short description of your issue:";
      this.radLabel11.Location = new Point(0, 72);
      this.radLabel11.Name = "radLabel11";
      this.radLabel11.Size = new Size(141, 18);
      this.radLabel11.TabIndex = 12;
      this.radLabel11.Text = "E-mail Address (Required) :";
      this.radLabel5.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.radLabel5.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel5.Location = new Point(3, 26);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new Size(199, 18);
      this.radLabel5.TabIndex = 15;
      this.radLabel5.Text = "Short description of the issue (Required)";
      this.txtTitle.Location = new Point(4, 50);
      this.txtTitle.MaxLength = 50;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new Size(467, 20);
      this.txtTitle.TabIndex = 2;
      this.pageEmail.Controls.Add((Control) this.radLabel14);
      this.pageEmail.Controls.Add((Control) this.radButton3);
      this.pageEmail.Controls.Add((Control) this.txtEmail);
      this.pageEmail.Controls.Add((Control) this.radLabel9);
      this.pageEmail.ItemSize = new SizeF(114f, 28f);
      this.pageEmail.Location = new Point(10, 37);
      this.pageEmail.Name = "pageEmail";
      this.pageEmail.Size = new Size(474, 345);
      this.pageEmail.Text = "How to contact you";
      this.radLabel14.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.radLabel14.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel14.Location = new Point(3, 40);
      this.radLabel14.Name = "radLabel14";
      this.radLabel14.Size = new Size(168, 18);
      this.radLabel14.TabIndex = 18;
      this.radLabel14.Text = "Please input your e-mail address:";
      this.radButton3.Image = (Image) Class123.icnArrow;
      this.radButton3.Location = new Point(343, 305);
      this.radButton3.Name = "radButton3";
      this.radButton3.Size = new Size(128, 37);
      this.radButton3.TabIndex = 17;
      this.radButton3.Text = "    &Next";
      this.radButton3.Click += new EventHandler(this.radButton3_Click);
      this.txtEmail.Location = new Point(3, 65);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(468, 20);
      this.txtEmail.TabIndex = 1;
      this.radLabel9.AutoSize = false;
      this.radLabel9.Controls.Add((Control) this.emailLabel);
      this.radLabel9.Location = new Point(4, 4);
      this.radLabel9.Name = "radLabel9";
      this.radLabel9.Size = new Size(468, 30);
      this.radLabel9.TabIndex = 1;
      this.radLabel9.Text = "<html><p>In order to be able to provide you with an answer, we need to know how to contact you.</p><p></p><p></p><p></p></html>";
      this.emailLabel.Location = new Point(0, 72);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new Size(141, 18);
      this.emailLabel.TabIndex = 12;
      this.emailLabel.Text = "E-mail Address (Required) :";
      this.pageWelcome.Controls.Add((Control) this.radButton2);
      this.pageWelcome.Controls.Add((Control) this.radLabel3);
      this.pageWelcome.Controls.Add((Control) this.pictureBox3);
      this.pageWelcome.Controls.Add((Control) this.radLabel8);
      this.pageWelcome.Controls.Add((Control) this.pictureBox2);
      this.pageWelcome.Controls.Add((Control) this.radButton1);
      this.pageWelcome.Controls.Add((Control) this.pictureBox1);
      this.pageWelcome.Controls.Add((Control) this.radLabel7);
      this.pageWelcome.Controls.Add((Control) this.radLabel6);
      this.pageWelcome.ItemSize = new SizeF(66f, 28f);
      this.pageWelcome.Location = new Point(10, 37);
      this.pageWelcome.Name = "pageWelcome";
      this.pageWelcome.Size = new Size(474, 345);
      this.pageWelcome.Text = "Welcome!";
      this.radButton2.Location = new Point(36, 184);
      this.radButton2.Name = "radButton2";
      this.radButton2.Size = new Size(372, 24);
      this.radButton2.TabIndex = 22;
      this.radButton2.Text = "I need further assistance";
      this.radButton2.Click += new EventHandler(this.radButton2_Click);
      this.radLabel3.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel3.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel3.Location = new Point(37, 257);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(402, 32);
      this.radLabel3.TabIndex = 20;
      this.radLabel3.Text = "<html><p>I am not involved in the development of either CITRA or CEMU so I cannot</p><p>fix any of the issues which are not directly related to Wii U USB Helper.</p></html>";
      this.pictureBox3.Image = (Image) Class123.UKFlag;
      this.pictureBox3.Location = new Point(97, 239);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(24, 12);
      this.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox3.TabIndex = 26;
      this.pictureBox3.TabStop = false;
      this.radLabel8.Location = new Point(36, 149);
      this.radLabel8.Name = "radLabel8";
      this.radLabel8.Size = new Size(116, 17);
      this.radLabel8.TabIndex = 22;
      this.radLabel8.Text = "<html>Didn\"t find an answer?</html>";
      this.pictureBox2.Image = (Image) Class123.usaFlag;
      this.pictureBox2.Location = new Point(67, 238);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(24, 13);
      this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 25;
      this.pictureBox2.TabStop = false;
      this.radButton1.Location = new Point(36, 106);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(372, 24);
      this.radButton1.TabIndex = 21;
      this.radButton1.Text = "See if my problem already has a solution";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.pictureBox1.Image = (Image) Class123.frenchFlag;
      this.pictureBox1.Location = new Point(37, 237);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(24, 14);
      this.pictureBox1.TabIndex = 24;
      this.pictureBox1.TabStop = false;
      this.radLabel7.Location = new Point(36, 56);
      this.radLabel7.Name = "radLabel7";
      this.radLabel7.Size = new Size(378, 46);
      this.radLabel7.TabIndex = 0;
      this.radLabel7.Text = "<html><p>Welcome to the support center!</p><p>Before proceeding, make sure your issue does not already have a solution :</p><p></p></html>";
      this.radLabel6.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel6.Location = new Point(36, 214);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(277, 18);
      this.radLabel6.TabIndex = 23;
      this.radLabel6.Text = "Support is ONLY provided in the following languages :";
      this.radPageView1.Controls.Add((Control) this.pageWelcome);
      this.radPageView1.Controls.Add((Control) this.pageEmail);
      this.radPageView1.Controls.Add((Control) this.pageTitle);
      this.radPageView1.Controls.Add((Control) this.pageContent);
      this.radPageView1.Location = new Point(7, 85);
      this.radPageView1.Name = "radPageView1";
      this.radPageView1.SelectedPage = this.pageWelcome;
      this.radPageView1.ShowItemToolTips = false;
      this.radPageView1.Size = new Size(495, 393);
      this.radPageView1.TabIndex = 28;
      this.radPageView1.TabStop = false;
      this.radPageView1.Text = "radPageView1";
      ((RadPageViewStripElement) this.radPageView1.GetChildAt(0)).StripButtons = StripViewButtons.None;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(508, 480);
      this.Controls.Add((Control) this.radPageView1);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.feedbackPictureBox);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmSupport);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "I need help!";
      this.Load += new EventHandler(this.frmSupport_Load);
      ((ISupportInitialize) this.feedbackPictureBox).EndInit();
      this.radLabel2.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.lblusualtime.EndInit();
      this.timeViewer.EndInit();
      this.radLabel4.EndInit();
      this.chkTeamViewer.EndInit();
      this.pageContent.ResumeLayout(false);
      this.pageContent.PerformLayout();
      this.radButton5.EndInit();
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      this.lblProvided.EndInit();
      this.radLabel15.EndInit();
      this.radButton7.EndInit();
      this.chkSyslog.EndInit();
      this.radLabel12.EndInit();
      this.radLabel12.ResumeLayout(false);
      this.radLabel12.PerformLayout();
      this.radLabel13.EndInit();
      this.radLabel1.EndInit();
      this.txtRemarks.EndInit();
      this.pageTitle.ResumeLayout(false);
      this.pageTitle.PerformLayout();
      this.radTextBox1.EndInit();
      this.lstTitles.EndInit();
      this.radLabel16.EndInit();
      this.radLabel16.ResumeLayout(false);
      this.radLabel16.PerformLayout();
      this.radLabel17.EndInit();
      this.radButton4.EndInit();
      this.radLabel10.EndInit();
      this.radLabel10.ResumeLayout(false);
      this.radLabel10.PerformLayout();
      this.radLabel11.EndInit();
      this.radLabel5.EndInit();
      this.txtTitle.EndInit();
      this.pageEmail.ResumeLayout(false);
      this.pageEmail.PerformLayout();
      this.radLabel14.EndInit();
      this.radButton3.EndInit();
      this.txtEmail.EndInit();
      this.radLabel9.EndInit();
      this.radLabel9.ResumeLayout(false);
      this.radLabel9.PerformLayout();
      this.emailLabel.EndInit();
      this.pageWelcome.ResumeLayout(false);
      this.pageWelcome.PerformLayout();
      this.radButton2.EndInit();
      this.radLabel3.EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.radLabel8.EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.radButton1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.radLabel7.EndInit();
      this.radLabel6.EndInit();
      this.radPageView1.EndInit();
      this.radPageView1.ResumeLayout(false);
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
