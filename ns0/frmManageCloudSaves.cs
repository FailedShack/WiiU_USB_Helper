// Decompiled with JetBrains decompiler
// Type: ns0.frmManageCloudSaves
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper;
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
  public class frmManageCloudSaves : RadForm
  {
    private GClass32 gclass32_0;
    private IContainer icontainer_0;
    private RadListView lstSaves;
    private RadGroupBox radGroupBox1;
    private RadButton cmdDelete;

    public frmManageCloudSaves()
    {
      this.InitializeComponent();
      this.method_0();
    }

    public static DateTime smethod_0(double double_0)
    {
      return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      if (this.gclass32_0 == null || RadMessageBox.Show("Are you sure you want to delete this file? It cannot be recovered.", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      GClass6.smethod_20(string.Format("{0}/saves/delete_save.php", (object) Class67.String_1), new NameValueCollection()
      {
        {
          "username",
          Settings.Default.CloudUserName
        },
        {
          "password",
          Settings.Default.CloudPassWord
        },
        {
          "titleid",
          this.gclass32_0.TitleId.IdRaw
        }
      });
      this.method_0();
    }

    private void lstSaves_SelectedItemChanged(object sender, EventArgs e)
    {
      try
      {
        this.gclass32_0 = this.lstSaves.SelectedItem.Tag as GClass32;
      }
      catch
      {
      }
    }

    private void method_0()
    {
      this.gclass32_0 = (GClass32) null;
      List<Class152> class152List = JsonConvert.DeserializeObject<List<Class152>>(GClass6.smethod_20(string.Format("{0}/saves/list_saves.php", (object) Class67.String_1), new NameValueCollection() { { "username", Settings.Default.CloudUserName }, { "password", Settings.Default.CloudPassWord } }));
      this.lstSaves.BeginUpdate();
      this.lstSaves.Items.Clear();
      foreach (Class152 class152 in class152List)
      {
        ListViewDataItem listViewDataItem1 = new ListViewDataItem();
        this.lstSaves.Items.Add(listViewDataItem1);
        listViewDataItem1[0] = (object) GClass28.dictionary_0[new TitleId(class152.string_1)].Name;
        ListViewDataItem listViewDataItem2 = listViewDataItem1;
        int index = 1;
        DateTime dateTime = frmManageCloudSaves.smethod_0((double) class152.long_0);
        string longDateString = dateTime.ToLongDateString();
        string str1 = " ";
        dateTime = frmManageCloudSaves.smethod_0((double) class152.long_0);
        string longTimeString = dateTime.ToLongTimeString();
        string str2 = longDateString + str1 + longTimeString;
        listViewDataItem2[index] = (object) str2;
        listViewDataItem1[2] = (object) new DataSize(class152.ulong_0);
        listViewDataItem1.Tag = (object) GClass28.dictionary_0[new TitleId(class152.string_1)];
      }
      this.lstSaves.EndUpdate();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Game");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Date");
      ListViewDetailColumn viewDetailColumn3 = new ListViewDetailColumn("Column 2", "Size");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmManageCloudSaves));
      this.lstSaves = new RadListView();
      this.radGroupBox1 = new RadGroupBox();
      this.cmdDelete = new RadButton();
      this.lstSaves.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.cmdDelete.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.lstSaves.AllowEdit = false;
      this.lstSaves.AllowRemove = false;
      viewDetailColumn1.HeaderText = "Game";
      viewDetailColumn1.Width = 400f;
      viewDetailColumn2.HeaderText = "Date";
      viewDetailColumn3.HeaderText = "Size";
      this.lstSaves.Columns.AddRange(viewDetailColumn1, viewDetailColumn2, viewDetailColumn3);
      this.lstSaves.Dock = DockStyle.Fill;
      this.lstSaves.ItemSpacing = -1;
      this.lstSaves.Location = new Point(0, 0);
      this.lstSaves.Name = "lstSaves";
      this.lstSaves.Size = new Size(808, 482);
      this.lstSaves.TabIndex = 0;
      this.lstSaves.Text = "radListView1";
      this.lstSaves.ViewType = ListViewType.DetailsView;
      this.lstSaves.SelectedItemChanged += new EventHandler(this.lstSaves_SelectedItemChanged);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.cmdDelete);
      this.radGroupBox1.Dock = DockStyle.Bottom;
      this.radGroupBox1.HeaderText = "Actions";
      this.radGroupBox1.Location = new Point(0, 482);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(808, 57);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Actions";
      this.cmdDelete.Location = new Point(5, 28);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Size = new Size(177, 24);
      this.cmdDelete.TabIndex = 0;
      this.cmdDelete.Text = "Delete the save from the cloud";
      this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(808, 539);
      this.Controls.Add((Control) this.lstSaves);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmManageCloudSaves);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Manage my saves";
      this.lstSaves.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.cmdDelete.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
