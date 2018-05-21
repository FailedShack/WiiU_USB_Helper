// Decompiled with JetBrains decompiler
// Type: ns0.frmChoseSave
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Nus_Helper_Shared_Core.NusHelper.Saves;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmChoseSave : RadForm
  {
    public SaveDescription saveDescription_0;
    private IContainer icontainer_0;
    private RadCheckedListBox lstSaves;
    private RadButton cmdbackup;
    private RadButton radButton1;

    public frmChoseSave(GClass32 gclass32_0)
    {
      this.InitializeComponent();
      foreach (SaveDescription saveDescription in gclass32_0.method_24())
      {
        ListViewDataItem listViewDataItem = new ListViewDataItem() { Tag = (object) saveDescription };
        this.lstSaves.Items.Add(listViewDataItem);
        listViewDataItem[0] = (object) frmChoseSave.smethod_0(double.Parse(saveDescription.Timestamp)).ToShortDateString();
        listViewDataItem[1] = (object) saveDescription.Description;
      }
    }

    public static DateTime smethod_0(double double_0)
    {
      return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
    }

    private void frmChoseSave_Load(object sender, EventArgs e)
    {
    }

    private void cmdbackup_Click(object sender, EventArgs e)
    {
      if (this.lstSaves.CheckedItems.Count != 0 && this.lstSaves.CheckedItems.Count <= 1)
      {
        this.saveDescription_0 = this.lstSaves.CheckedItems[0].Tag as SaveDescription;
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        int num = (int) RadMessageBox.Show("Please select one save.");
      }
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Date");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Description");
      this.lstSaves = new RadCheckedListBox();
      this.cmdbackup = new RadButton();
      this.radButton1 = new RadButton();
      this.lstSaves.BeginInit();
      this.cmdbackup.BeginInit();
      this.radButton1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      viewDetailColumn1.HeaderText = "Date";
      viewDetailColumn2.HeaderText = "Description";
      viewDetailColumn2.Width = 500f;
      this.lstSaves.Columns.AddRange(viewDetailColumn1, viewDetailColumn2);
      this.lstSaves.Dock = DockStyle.Fill;
      this.lstSaves.ItemSpacing = -1;
      this.lstSaves.Location = new Point(0, 0);
      this.lstSaves.Name = "lstSaves";
      this.lstSaves.Size = new Size(728, 362);
      this.lstSaves.TabIndex = 0;
      this.lstSaves.Text = "radCheckedListBox1";
      this.lstSaves.ViewType = ListViewType.DetailsView;
      this.cmdbackup.Dock = DockStyle.Bottom;
      this.cmdbackup.Location = new Point(0, 362);
      this.cmdbackup.Name = "cmdbackup";
      this.cmdbackup.Size = new Size(728, 24);
      this.cmdbackup.TabIndex = 4;
      this.cmdbackup.Text = "Restore";
      this.cmdbackup.Click += new EventHandler(this.cmdbackup_Click);
      this.radButton1.Dock = DockStyle.Bottom;
      this.radButton1.Location = new Point(0, 386);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(728, 24);
      this.radButton1.TabIndex = 3;
      this.radButton1.Text = "Cancel";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(728, 410);
      this.Controls.Add((Control) this.lstSaves);
      this.Controls.Add((Control) this.cmdbackup);
      this.Controls.Add((Control) this.radButton1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmChoseSave);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Chose a Save File";
      this.Load += new EventHandler(this.frmChoseSave_Load);
      this.lstSaves.EndInit();
      this.cmdbackup.EndInit();
      this.radButton1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
