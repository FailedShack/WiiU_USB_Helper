// Decompiled with JetBrains decompiler
// Type: ns0.frmCommunitySaves
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmCommunitySaves : RadForm
  {
    private GClass32 gclass32_0;
    private IContainer icontainer_0;
    private RadListView lstSaves;
    private RadButton cmdUploadSave;
    private RadButton cmdImport;
    private RadGroupBox radGroupBox1;
    private RadLabel lblNoSaves;

    public frmCommunitySaves(GClass32 gclass32_1)
    {
      this.InitializeComponent();
      this.gclass32_0 = gclass32_1;
      if (gclass32_1.method_14(false) != null && gclass32_1.method_14(false).FileSaveLocation != null)
      {
        this.method_0();
      }
      else
      {
        int num = (int) RadMessageBox.Show("This title does not support community saves.");
        this.Close();
      }
    }

    private void cmdImport_Click(object sender, EventArgs e)
    {
      if (this.lstSaves.SelectedItem == null || RadMessageBox.Show("You are about to import a save. If you already have any local save data, it will be OVERWRITTEN. If you are using Cloud Saving, your cloud save will also be OVERWRITTEN. Continue?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      GClass95 gclass95 = this.gclass32_0.method_14(false);
      GClass6.smethod_5(gclass95.FileSaveLocation);
      GClass27.smethod_7(string.Format("{0}/communitysaves/cdn/{1}", (object) Class67.String_1, (object) (this.lstSaves.SelectedItem.Tag as frmCommunitySaves.Class131).Md5), gclass95.FileSaveLocation);
      if (Settings.Default.EnableCloudSaving)
        gclass95.method_2(gclass95.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
      int num = (int) RadMessageBox.Show("Save imported!");
    }

    private void cmdUploadSave_Click(object sender, EventArgs e)
    {
      string string_2 = this.gclass32_0.method_14(false).vmethod_0();
      if (string_2 == null)
      {
        int num1 = (int) RadMessageBox.Show("An error occured while trying to compile your save. Do you have a local save to share?");
      }
      else
      {
        frmCommunitySaveDescription communitySaveDescription = new frmCommunitySaveDescription();
        if (communitySaveDescription.ShowDialog() != DialogResult.OK)
        {
          int num2 = (int) RadMessageBox.Show("The process was cancelled.");
        }
        else
        {
          string str = Class67.smethod_14(string_2, string.Format("{0}/communitysaves/upload.php", (object) Class67.String_1));
          if (str.Length != 32)
          {
            int num3 = (int) RadMessageBox.Show("An error occured while uploading your save.");
          }
          else if (GClass6.smethod_20(string.Format("{0}/communitysaves/add.php", (object) Class67.String_1), new NameValueCollection() { { "titleid", this.gclass32_0.TitleId.IdRaw }, { "md5", str }, { "description", communitySaveDescription.Description } }) == "Ok")
          {
            int num4 = (int) RadMessageBox.Show("Thank you for your contribution!");
            this.method_0();
          }
          else
          {
            int num5 = (int) RadMessageBox.Show("Your save could not be added. Perhaps a similar save already exists?");
          }
        }
      }
    }

    private void method_0()
    {
      this.lstSaves.BeginUpdate();
      this.lstSaves.Items.Clear();
      string string_0 = string.Format("{0}/communitysaves/list.php", (object) Class67.String_1);
      foreach (frmCommunitySaves.Class131 class131 in JsonConvert.DeserializeObject<List<frmCommunitySaves.Class131>>(GClass6.smethod_20(string_0, new NameValueCollection() { { "titleid", this.gclass32_0.TitleId.IdRaw } })))
      {
        ListViewDataItem listViewDataItem = new ListViewDataItem() { Tag = (object) class131 };
        this.lstSaves.Items.Add(listViewDataItem);
        listViewDataItem[0] = (object) class131.Description;
        listViewDataItem[1] = (object) class131.Date;
      }
      this.lstSaves.EndUpdate();
      this.lblNoSaves.Visible = this.lstSaves.Items.Count == 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Description");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Date");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCommunitySaves));
      this.lstSaves = new RadListView();
      this.cmdUploadSave = new RadButton();
      this.cmdImport = new RadButton();
      this.radGroupBox1 = new RadGroupBox();
      this.lblNoSaves = new RadLabel();
      this.lstSaves.BeginInit();
      this.lstSaves.SuspendLayout();
      this.cmdUploadSave.BeginInit();
      this.cmdImport.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.lblNoSaves.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      viewDetailColumn1.HeaderText = "Description";
      viewDetailColumn1.Width = 600f;
      viewDetailColumn2.HeaderText = "Date";
      this.lstSaves.Columns.AddRange(viewDetailColumn1, viewDetailColumn2);
      this.lstSaves.Controls.Add((Control) this.lblNoSaves);
      this.lstSaves.Dock = DockStyle.Fill;
      this.lstSaves.ItemSpacing = -1;
      this.lstSaves.Location = new Point(0, 0);
      this.lstSaves.Name = "lstSaves";
      this.lstSaves.Size = new Size(938, 404);
      this.lstSaves.TabIndex = 0;
      this.lstSaves.Text = "radListView1";
      this.lstSaves.ViewType = ListViewType.DetailsView;
      this.cmdUploadSave.Anchor = AnchorStyles.None;
      this.cmdUploadSave.Image = (Image) Class123.icnWebMini;
      this.cmdUploadSave.Location = new Point(482, 26);
      this.cmdUploadSave.Name = "cmdUploadSave";
      this.cmdUploadSave.Size = new Size(203, 24);
      this.cmdUploadSave.TabIndex = 0;
      this.cmdUploadSave.Text = "Upload my own save";
      this.cmdUploadSave.Click += new EventHandler(this.cmdUploadSave_Click);
      this.cmdImport.Anchor = AnchorStyles.None;
      this.cmdImport.Image = (Image) Class123.icnDownloadedMini;
      this.cmdImport.Location = new Point(253, 26);
      this.cmdImport.Name = "cmdImport";
      this.cmdImport.Size = new Size(200, 24);
      this.cmdImport.TabIndex = 1;
      this.cmdImport.Text = "Import this save";
      this.cmdImport.Click += new EventHandler(this.cmdImport_Click);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.cmdImport);
      this.radGroupBox1.Controls.Add((Control) this.cmdUploadSave);
      this.radGroupBox1.Dock = DockStyle.Bottom;
      this.radGroupBox1.HeaderText = "Options";
      this.radGroupBox1.Location = new Point(0, 404);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(938, 63);
      this.radGroupBox1.TabIndex = 1;
      this.radGroupBox1.Text = "Options";
      this.lblNoSaves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lblNoSaves.AutoSize = false;
      this.lblNoSaves.Location = new Point(0, 0);
      this.lblNoSaves.Name = "lblNoSaves";
      this.lblNoSaves.Size = new Size(938, 404);
      this.lblNoSaves.TabIndex = 0;
      this.lblNoSaves.Text = "No saves are available at the moment, why not share your own?";
      this.lblNoSaves.TextAlignment = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(938, 467);
      this.Controls.Add((Control) this.lstSaves);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmCommunitySaves);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Community Saves";
      this.lstSaves.EndInit();
      this.lstSaves.ResumeLayout(false);
      this.cmdUploadSave.EndInit();
      this.cmdImport.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.lblNoSaves.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }

    private class Class131
    {
      [JsonProperty("date")]
      public string Date { get; set; }

      [JsonProperty("description")]
      public string Description { get; set; }

      [JsonProperty("md5")]
      public string Md5 { get; set; }
    }
  }
}
