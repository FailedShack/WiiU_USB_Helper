// Decompiled with JetBrains decompiler
// Type: ns0.FrmSelectVersion
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
  internal class FrmSelectVersion : RadForm
  {
    private RadButton _cmdCheckAll;
    private RadButton _cmdImport;
    private RadCheckedListBox _lstVersions;
    private RadGroupBox _radGroupBox1;
    private RadLabel _radLabel1;
    private RadLabel _radLabel2;
    public List<GClass33> list_0;

    public FrmSelectVersion(IEnumerable<GClass33> ienumerable_0, bool bool_0)
    {
      this.InitializeComponent();
      foreach (GClass33 gclass33 in ienumerable_0)
        this._lstVersions.Items.Add(new ListViewDataItem(string.Format("v{0} ({1})", (object) gclass33.Version, (object) gclass33.Size))
        {
          Tag = (object) gclass33,
          ForeColor = gclass33.Color_0,
          Enabled = !bool_0 || gclass33.GEnum2_0 == GEnum2.const_2
        });
    }

    private void _cmdCheckAll_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this._lstVersions.Items.Where<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.Enabled)))
        listViewDataItem.CheckState = ToggleState.On;
    }

    private void _cmdImport_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.list_0 = this._lstVersions.Items.Where<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.CheckState == ToggleState.On)).Select<ListViewDataItem, GClass33>((Func<ListViewDataItem, GClass33>) (listViewDataItem_0 => listViewDataItem_0.Tag as GClass33)).ToList<GClass33>();
      this.Close();
    }

    private void FrmSelectVersion_Load(object sender, EventArgs e)
    {
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmSelectVersion));
      this._lstVersions = new RadCheckedListBox();
      this._radLabel1 = new RadLabel();
      this._cmdImport = new RadButton();
      this._radGroupBox1 = new RadGroupBox();
      this._radLabel2 = new RadLabel();
      this._cmdCheckAll = new RadButton();
      this._lstVersions.BeginInit();
      this._radLabel1.BeginInit();
      this._cmdImport.BeginInit();
      this._radGroupBox1.BeginInit();
      this._radGroupBox1.SuspendLayout();
      this._radLabel2.BeginInit();
      this._cmdCheckAll.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this._lstVersions.AllowRemove = false;
      this._lstVersions.Dock = DockStyle.Fill;
      this._lstVersions.Location = new Point(10, 46);
      this._lstVersions.Name = "_lstVersions";
      this._lstVersions.Size = new Size(446, 337);
      this._lstVersions.TabIndex = 7;
      this._lstVersions.Text = "\r\n";
      this._lstVersions.ThemeName = "VisualStudio2012Dark";
      this._radLabel1.Location = new Point(5, 14);
      this._radLabel1.Name = "_radLabel1";
      this._radLabel1.Size = new Size(399, 18);
      this._radLabel1.TabIndex = 2;
      this._radLabel1.Text = "Please select the desired update versions. You usually only need the latest one.";
      this._radLabel1.ThemeName = "VisualStudio2012Dark";
      this._cmdImport.Dock = DockStyle.Bottom;
      this._cmdImport.Location = new Point(10, 383);
      this._cmdImport.Name = "_cmdImport";
      this._cmdImport.Size = new Size(446, 26);
      this._cmdImport.TabIndex = 9;
      this._cmdImport.Text = "Ok";
      this._cmdImport.ThemeName = "VisualStudio2012Dark";
      this._cmdImport.Click += new EventHandler(this._cmdImport_Click);
      this._radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this._radGroupBox1.Controls.Add((Control) this._radLabel1);
      this._radGroupBox1.Dock = DockStyle.Top;
      this._radGroupBox1.HeaderText = "Info";
      this._radGroupBox1.Location = new Point(10, 10);
      this._radGroupBox1.Name = "_radGroupBox1";
      this._radGroupBox1.Size = new Size(446, 36);
      this._radGroupBox1.TabIndex = 10;
      this._radGroupBox1.Text = "Info";
      this._radGroupBox1.ThemeName = "VisualStudio2012Dark";
      this._radLabel2.Location = new Point(265, 18);
      this._radLabel2.Name = "_radLabel2";
      this._radLabel2.Size = new Size(2, 2);
      this._radLabel2.TabIndex = 8;
      this._radLabel2.ThemeName = "VisualStudio2012Dark";
      this._cmdCheckAll.Dock = DockStyle.Bottom;
      this._cmdCheckAll.Location = new Point(10, 409);
      this._cmdCheckAll.Name = "_cmdCheckAll";
      this._cmdCheckAll.Size = new Size(446, 26);
      this._cmdCheckAll.TabIndex = 11;
      this._cmdCheckAll.Text = "Select all";
      this._cmdCheckAll.ThemeName = "VisualStudio2012Dark";
      this._cmdCheckAll.Click += new EventHandler(this._cmdCheckAll_Click);
      this.ClientSize = new Size(466, 445);
      this.Controls.Add((Control) this._lstVersions);
      this.Controls.Add((Control) this._cmdImport);
      this.Controls.Add((Control) this._radGroupBox1);
      this.Controls.Add((Control) this._radLabel2);
      this.Controls.Add((Control) this._cmdCheckAll);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (FrmSelectVersion);
      this.Padding = new Padding(10);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select versions";
      this.Load += new EventHandler(this.FrmSelectVersion_Load);
      this._lstVersions.EndInit();
      this._radLabel1.EndInit();
      this._cmdImport.EndInit();
      this._radGroupBox1.EndInit();
      this._radGroupBox1.ResumeLayout(false);
      this._radGroupBox1.PerformLayout();
      this._radLabel2.EndInit();
      this._cmdCheckAll.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
