// Decompiled with JetBrains decompiler
// Type: ns0.FrmNewTitles
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmNewTitles : RadForm
  {
    private readonly ListViewDataItemGroup listViewDataItemGroup_0 = new ListViewDataItemGroup("3DS");
    private readonly ListViewDataItemGroup listViewDataItemGroup_1 = new ListViewDataItemGroup("Wii");
    private readonly ListViewDataItemGroup listViewDataItemGroup_2 = new ListViewDataItemGroup("WiiU");
    public List<GClass30> list_0;
    private IContainer icontainer_0;
    private RadButton cmdImport;
    private RadLabel lblUpText;
    private RadButton cmdCheckAll;
    private RadGroupBox radGroupBox1;
    private RadLabel radLabel2;
    private RadCheckedListBox lstTitles;

    public FrmNewTitles(IEnumerable<GClass30> ienumerable_0, string string_0 = "New titles have been added! Please choose the ones you wish to download.")
    {
      this.InitializeComponent();
      this.lblUpText.Text = string_0;
      this.lstTitles.EnableGrouping = true;
      this.lstTitles.EnableCustomGrouping = true;
      this.lstTitles.Groups.Add(this.listViewDataItemGroup_2);
      this.lstTitles.Groups.Add(this.listViewDataItemGroup_0);
      this.lstTitles.Groups.Add(this.listViewDataItemGroup_1);
      this.lstTitles.ShowGroups = true;
      this.lstTitles.BeginUpdate();
      foreach (GClass30 gclass30 in ienumerable_0)
      {
        ListViewDataItem listViewDataItem = new ListViewDataItem((object) gclass30) { Tag = (object) gclass30 };
        switch (gclass30.System)
        {
          case GEnum3.const_0:
            listViewDataItem.Group = this.listViewDataItemGroup_0;
            break;
          case GEnum3.const_1:
            listViewDataItem.Group = this.listViewDataItemGroup_2;
            break;
          case GEnum3.const_2:
            throw new NotImplementedException();
          case GEnum3.const_3:
            listViewDataItem.Group = this.listViewDataItemGroup_1;
            break;
        }
        this.lstTitles.Items.Add(listViewDataItem);
      }
      this.lstTitles.EndUpdate();
    }

    private void cmdCheckAll_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this.lstTitles.Items)
        listViewDataItem.CheckState = ToggleState.On;
    }

    private void cmdImport_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.list_0 = this.lstTitles.Items.Where<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.CheckState == ToggleState.On)).Select<ListViewDataItem, GClass30>((Func<ListViewDataItem, GClass30>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass30)).ToList<GClass30>();
      this.Close();
    }

    private void FrmNewTitles_Load(object sender, EventArgs e)
    {
    }

    private void radGroupBox1_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmNewTitles));
      this.cmdImport = new RadButton();
      this.lblUpText = new RadLabel();
      this.cmdCheckAll = new RadButton();
      this.radGroupBox1 = new RadGroupBox();
      this.radLabel2 = new RadLabel();
      this.lstTitles = new RadCheckedListBox();
      this.cmdImport.BeginInit();
      this.lblUpText.BeginInit();
      this.cmdCheckAll.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radLabel2.BeginInit();
      this.lstTitles.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.cmdImport.Dock = DockStyle.Bottom;
      this.cmdImport.Location = new Point(10, 532);
      this.cmdImport.Name = "cmdImport";
      this.cmdImport.Size = new Size(714, 26);
      this.cmdImport.TabIndex = 9;
      this.cmdImport.Text = "Add to the queue";
      this.cmdImport.ThemeName = "VisualStudio2012Dark";
      this.cmdImport.Click += new EventHandler(this.cmdImport_Click);
      this.lblUpText.AutoSize = false;
      this.lblUpText.Dock = DockStyle.Fill;
      this.lblUpText.Location = new Point(2, 18);
      this.lblUpText.Name = "lblUpText";
      this.lblUpText.Size = new Size(710, 19);
      this.lblUpText.TabIndex = 2;
      this.lblUpText.Text = "New titles have been added! Please choose the ones you wish to download.\r\n";
      this.lblUpText.TextAlignment = ContentAlignment.MiddleCenter;
      this.lblUpText.ThemeName = "VisualStudio2012Dark";
      this.cmdCheckAll.Dock = DockStyle.Bottom;
      this.cmdCheckAll.Location = new Point(10, 506);
      this.cmdCheckAll.Name = "cmdCheckAll";
      this.cmdCheckAll.Size = new Size(714, 26);
      this.cmdCheckAll.TabIndex = 10;
      this.cmdCheckAll.Text = "Select all";
      this.cmdCheckAll.ThemeName = "VisualStudio2012Dark";
      this.cmdCheckAll.Click += new EventHandler(this.cmdCheckAll_Click);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.lblUpText);
      this.radGroupBox1.Dock = DockStyle.Top;
      this.radGroupBox1.HeaderText = "Info";
      this.radGroupBox1.Location = new Point(10, 10);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(714, 39);
      this.radGroupBox1.TabIndex = 11;
      this.radGroupBox1.Text = "Info";
      this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
      this.radGroupBox1.Click += new EventHandler(this.radGroupBox1_Click);
      this.radLabel2.Location = new Point(260, 13);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(2, 2);
      this.radLabel2.TabIndex = 8;
      this.radLabel2.ThemeName = "VisualStudio2012Dark";
      this.lstTitles.Dock = DockStyle.Fill;
      this.lstTitles.Location = new Point(10, 49);
      this.lstTitles.Name = "lstTitles";
      this.lstTitles.Size = new Size(714, 457);
      this.lstTitles.TabIndex = 7;
      this.lstTitles.Text = "\r\n";
      this.lstTitles.ThemeName = "VisualStudio2012Dark";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(734, 568);
      this.Controls.Add((Control) this.lstTitles);
      this.Controls.Add((Control) this.cmdCheckAll);
      this.Controls.Add((Control) this.cmdImport);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.radLabel2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (FrmNewTitles);
      this.Padding = new Padding(10);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "New titles available!";
      this.ThemeName = "VisualStudio2012Dark";
      this.Load += new EventHandler(this.FrmNewTitles_Load);
      this.cmdImport.EndInit();
      this.lblUpText.EndInit();
      this.cmdCheckAll.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radLabel2.EndInit();
      this.lstTitles.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
