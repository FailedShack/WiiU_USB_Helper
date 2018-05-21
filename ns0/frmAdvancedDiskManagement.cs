// Decompiled with JetBrains decompiler
// Type: ns0.frmAdvancedDiskManagement
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmAdvancedDiskManagement : RadForm
  {
    private List<Class130> list_1 = new List<Class130>();
    private List<Class130> list_2 = new List<Class130>();
    private IContainer icontainer_0;
    private RadListView lstTitles;
    private RadButton cmdDelete;
    private RadListView lstEmuTitles;
    private RadButton cmdDeleteEmu;
    private RadGroupBox radGroupBox1;
    private RadGroupBox radGroupBox3;
    private RadLabel radLabel2;
    private RadGroupBox radGroupBox2;
    private RadLabel lblTotalRaw;
    private RadLabel radLabel1;
    private RadLabel lblTotalEmu;
    private RadSplitContainer radSplitContainer1;
    private SplitPanel splitPanel1;
    private SplitPanel splitPanel2;
    private RadButton radButton1;

    public frmAdvancedDiskManagement()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmAdvancedDiskManagement.Class124 class124 = new frmAdvancedDiskManagement.Class124();
      // ISSUE: reference to a compiler-generated field
      class124.frmAdvancedDiskManagement_0 = this;
      this.InitializeComponent();
      // ISSUE: reference to a compiler-generated field
      class124.int_0 = 0;
      // ISSUE: reference to a compiler-generated field
      class124.frmWait_0 = new FrmWait("Analyzing your disk... This might take a while.", true);
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class124.method_0));
      // ISSUE: reference to a compiler-generated field
      int num = (int) class124.frmWait_0.ShowDialog();
      this.method_2();
      this.method_3();
    }

    public List<GClass32> DeletedTitles { get; } = new List<GClass32>();

    private void method_0(Class130 class130_0, RadListView radListView_0)
    {
      ListViewDataItem listViewDataItem = new ListViewDataItem() { Tag = (object) class130_0 };
      radListView_0.Items.Add(listViewDataItem);
      listViewDataItem[0] = (object) class130_0.ToString();
      listViewDataItem[1] = (object) new DataSize(class130_0.Size);
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
      this.method_1(this.lstTitles.SelectedItem?.Tag as Class130);
    }

    private void cmdDeleteEmu_Click(object sender, EventArgs e)
    {
      this.method_1(this.lstEmuTitles.SelectedItem?.Tag as Class130);
    }

    private void method_1(Class130 class130_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmAdvancedDiskManagement.Class128 class128 = new frmAdvancedDiskManagement.Class128();
      // ISSUE: reference to a compiler-generated field
      class128.class130_0 = class130_0;
      // ISSUE: reference to a compiler-generated field
      if (class128.class130_0 == null)
        return;
      // ISSUE: reference to a compiler-generated field
      class128.class130_0.method_0();
      // ISSUE: reference to a compiler-generated field
      if (this.list_2.Contains(class128.class130_0))
      {
        // ISSUE: reference to a compiler-generated field
        this.list_2.Remove(class128.class130_0);
        // ISSUE: reference to a compiler-generated method
        this.lstTitles.Items.Remove(this.lstTitles.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class128.method_0)));
      }
      // ISSUE: reference to a compiler-generated field
      if (this.list_1.Contains(class128.class130_0))
      {
        // ISSUE: reference to a compiler-generated field
        this.list_1.Remove(class128.class130_0);
        // ISSUE: reference to a compiler-generated method
        this.lstEmuTitles.Items.Remove(this.lstEmuTitles.Items.First<ListViewDataItem>(new Func<ListViewDataItem, bool>(class128.method_1)));
      }
      // ISSUE: reference to a compiler-generated field
      if (!this.DeletedTitles.Contains(class128.class130_0.CorrespondingTitle.GClass32_0))
      {
        // ISSUE: reference to a compiler-generated field
        this.DeletedTitles.Add(class128.class130_0.CorrespondingTitle.GClass32_0);
      }
      this.method_3();
    }

    private void method_2()
    {
      foreach (Class130 class130_0 in (IEnumerable<Class130>) this.list_2.OrderByDescending<Class130, ulong>((Func<Class130, ulong>) (class130_0 => class130_0.Size)))
        this.method_0(class130_0, this.lstTitles);
      foreach (Class130 class130_0 in (IEnumerable<Class130>) this.list_1.OrderByDescending<Class130, ulong>((Func<Class130, ulong>) (class130_0 => class130_0.Size)))
        this.method_0(class130_0, this.lstEmuTitles);
    }

    private void lstEmuTitles_ItemRemoving(object sender, ListViewItemCancelEventArgs e)
    {
      this.method_1(e.Item.Tag as Class130);
    }

    private void lstTitles_ItemRemoving(object sender, ListViewItemCancelEventArgs e)
    {
      this.method_1(e.Item.Tag as Class130);
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      if (RadMessageBox.Show("This will delete all the RAW data for titles which are ready for emulation. Continue?", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      foreach (Class130 class130 in this.list_1.ToArray())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmAdvancedDiskManagement.Class129 class129 = new frmAdvancedDiskManagement.Class129();
        // ISSUE: reference to a compiler-generated field
        class129.class130_0 = class130;
        // ISSUE: reference to a compiler-generated field
        if (class129.class130_0.CorrespondingTitle.Boolean_1)
        {
          try
          {
            // ISSUE: reference to a compiler-generated method
            this.method_1(this.list_2.First<Class130>(new Func<Class130, bool>(class129.method_0)));
          }
          catch
          {
          }
        }
      }
      this.lstTitles.Invalidate();
    }

    private void method_3()
    {
      ulong sz1 = 0;
      foreach (Class130 class130 in this.list_1)
        sz1 += class130.Size;
      this.lblTotalEmu.Text = new DataSize(sz1).ToString();
      ulong sz2 = 0;
      foreach (Class130 class130 in this.list_2)
        sz2 += class130.Size;
      this.lblTotalRaw.Text = new DataSize(sz2).ToString();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Title");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Size on disk");
      ListViewDetailColumn viewDetailColumn3 = new ListViewDetailColumn("Column 0", "Title");
      ListViewDetailColumn viewDetailColumn4 = new ListViewDetailColumn("Column 1", "Size on disk");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdvancedDiskManagement));
      this.lstTitles = new RadListView();
      this.cmdDelete = new RadButton();
      this.lstEmuTitles = new RadListView();
      this.cmdDeleteEmu = new RadButton();
      this.radGroupBox1 = new RadGroupBox();
      this.radSplitContainer1 = new RadSplitContainer();
      this.splitPanel1 = new SplitPanel();
      this.radGroupBox2 = new RadGroupBox();
      this.radButton1 = new RadButton();
      this.lblTotalRaw = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.splitPanel2 = new SplitPanel();
      this.radGroupBox3 = new RadGroupBox();
      this.lblTotalEmu = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.lstTitles.BeginInit();
      this.cmdDelete.BeginInit();
      this.lstEmuTitles.BeginInit();
      this.cmdDeleteEmu.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radSplitContainer1.BeginInit();
      this.radSplitContainer1.SuspendLayout();
      this.splitPanel1.BeginInit();
      this.splitPanel1.SuspendLayout();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      this.radButton1.BeginInit();
      this.lblTotalRaw.BeginInit();
      this.radLabel1.BeginInit();
      this.splitPanel2.BeginInit();
      this.splitPanel2.SuspendLayout();
      this.radGroupBox3.BeginInit();
      this.radGroupBox3.SuspendLayout();
      this.lblTotalEmu.BeginInit();
      this.radLabel2.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      viewDetailColumn1.HeaderText = "Title";
      viewDetailColumn1.Width = 400f;
      viewDetailColumn2.HeaderText = "Size on disk";
      this.lstTitles.Columns.AddRange(viewDetailColumn1, viewDetailColumn2);
      this.lstTitles.Dock = DockStyle.Fill;
      this.lstTitles.ItemSpacing = -1;
      this.lstTitles.Location = new Point(2, 120);
      this.lstTitles.Name = "lstTitles";
      this.lstTitles.ShowGridLines = true;
      this.lstTitles.Size = new Size(726, 614);
      this.lstTitles.TabIndex = 1;
      this.lstTitles.Text = "radListView1";
      this.lstTitles.ViewType = ListViewType.DetailsView;
      this.lstTitles.ItemRemoving += new ListViewItemCancelEventHandler(this.lstTitles_ItemRemoving);
      this.cmdDelete.Dock = DockStyle.Bottom;
      this.cmdDelete.Location = new Point(2, 764);
      this.cmdDelete.Name = "cmdDelete";
      this.cmdDelete.Size = new Size(726, 24);
      this.cmdDelete.TabIndex = 2;
      this.cmdDelete.Text = "Delete";
      this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
      this.lstEmuTitles.AllowEdit = false;
      viewDetailColumn3.HeaderText = "Title";
      viewDetailColumn3.Width = 400f;
      viewDetailColumn4.HeaderText = "Size on disk";
      this.lstEmuTitles.Columns.AddRange(viewDetailColumn3, viewDetailColumn4);
      this.lstEmuTitles.Dock = DockStyle.Fill;
      this.lstEmuTitles.ItemSpacing = -1;
      this.lstEmuTitles.Location = new Point(2, 120);
      this.lstEmuTitles.Name = "lstEmuTitles";
      this.lstEmuTitles.ShowGridLines = true;
      this.lstEmuTitles.Size = new Size(726, 614);
      this.lstEmuTitles.TabIndex = 3;
      this.lstEmuTitles.Text = "radListView1";
      this.lstEmuTitles.ViewType = ListViewType.DetailsView;
      this.lstEmuTitles.ItemRemoving += new ListViewItemCancelEventHandler(this.lstEmuTitles_ItemRemoving);
      this.cmdDeleteEmu.Dock = DockStyle.Bottom;
      this.cmdDeleteEmu.Location = new Point(2, 764);
      this.cmdDeleteEmu.Name = "cmdDeleteEmu";
      this.cmdDeleteEmu.Size = new Size(726, 24);
      this.cmdDeleteEmu.TabIndex = 3;
      this.cmdDeleteEmu.Text = "Delete";
      this.cmdDeleteEmu.Click += new EventHandler(this.cmdDeleteEmu_Click);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.radSplitContainer1);
      this.radGroupBox1.Dock = DockStyle.Fill;
      this.radGroupBox1.HeaderText = "Manage Data";
      this.radGroupBox1.Location = new Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Padding = new Padding(20);
      this.radGroupBox1.Size = new Size(1504, 830);
      this.radGroupBox1.TabIndex = 5;
      this.radGroupBox1.Text = "Manage Data";
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel1);
      this.radSplitContainer1.Controls.Add((Control) this.splitPanel2);
      this.radSplitContainer1.Dock = DockStyle.Fill;
      this.radSplitContainer1.Location = new Point(20, 20);
      this.radSplitContainer1.Name = "radSplitContainer1";
      this.radSplitContainer1.RootElement.MinSize = new Size(25, 25);
      this.radSplitContainer1.Size = new Size(1464, 790);
      this.radSplitContainer1.TabIndex = 7;
      this.radSplitContainer1.TabStop = false;
      this.radSplitContainer1.Text = "radSplitContainer1";
      this.splitPanel1.Controls.Add((Control) this.radGroupBox2);
      this.splitPanel1.Location = new Point(0, 0);
      this.splitPanel1.Name = "splitPanel1";
      this.splitPanel1.RootElement.MinSize = new Size(25, 25);
      this.splitPanel1.Size = new Size(730, 790);
      this.splitPanel1.TabIndex = 0;
      this.splitPanel1.TabStop = false;
      this.splitPanel1.Text = "splitPanel1";
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add((Control) this.radButton1);
      this.radGroupBox2.Controls.Add((Control) this.lstTitles);
      this.radGroupBox2.Controls.Add((Control) this.lblTotalRaw);
      this.radGroupBox2.Controls.Add((Control) this.cmdDelete);
      this.radGroupBox2.Controls.Add((Control) this.radLabel1);
      this.radGroupBox2.Dock = DockStyle.Fill;
      this.radGroupBox2.HeaderText = "Raw content";
      this.radGroupBox2.Location = new Point(0, 0);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new Size(730, 790);
      this.radGroupBox2.TabIndex = 6;
      this.radGroupBox2.Text = "Raw content";
      this.radButton1.Dock = DockStyle.Bottom;
      this.radButton1.Location = new Point(2, 710);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(726, 24);
      this.radButton1.TabIndex = 4;
      this.radButton1.Text = "Delete all useless data";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.lblTotalRaw.Dock = DockStyle.Bottom;
      this.lblTotalRaw.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTotalRaw.Location = new Point(2, 734);
      this.lblTotalRaw.Name = "lblTotalRaw";
      this.lblTotalRaw.Size = new Size(17, 30);
      this.lblTotalRaw.TabIndex = 3;
      this.lblTotalRaw.Text = "-";
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Location = new Point(2, 18);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Padding = new Padding(20, 0, 0, 0);
      this.radLabel1.Size = new Size(726, 102);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.splitPanel2.Controls.Add((Control) this.radGroupBox3);
      this.splitPanel2.Location = new Point(734, 0);
      this.splitPanel2.Name = "splitPanel2";
      this.splitPanel2.RootElement.MinSize = new Size(25, 25);
      this.splitPanel2.Size = new Size(730, 790);
      this.splitPanel2.TabIndex = 1;
      this.splitPanel2.TabStop = false;
      this.splitPanel2.Text = "splitPanel2";
      this.radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox3.Controls.Add((Control) this.lstEmuTitles);
      this.radGroupBox3.Controls.Add((Control) this.lblTotalEmu);
      this.radGroupBox3.Controls.Add((Control) this.radLabel2);
      this.radGroupBox3.Controls.Add((Control) this.cmdDeleteEmu);
      this.radGroupBox3.Dock = DockStyle.Fill;
      this.radGroupBox3.HeaderText = "Emulation Content";
      this.radGroupBox3.Location = new Point(0, 0);
      this.radGroupBox3.Name = "radGroupBox3";
      this.radGroupBox3.Size = new Size(730, 790);
      this.radGroupBox3.TabIndex = 6;
      this.radGroupBox3.Text = "Emulation Content";
      this.lblTotalEmu.Dock = DockStyle.Bottom;
      this.lblTotalEmu.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTotalEmu.Location = new Point(2, 734);
      this.lblTotalEmu.Name = "lblTotalEmu";
      this.lblTotalEmu.Size = new Size(17, 30);
      this.lblTotalEmu.TabIndex = 4;
      this.lblTotalEmu.Text = "-";
      this.radLabel2.AutoSize = false;
      this.radLabel2.Dock = DockStyle.Top;
      this.radLabel2.Location = new Point(2, 18);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Padding = new Padding(20, 0, 0, 0);
      this.radLabel2.Size = new Size(726, 102);
      this.radLabel2.TabIndex = 1;
      this.radLabel2.Text = "<html><p>We call 'Emulation' content files that have been unpacked/decrypted/converted from the RAW files.</p><p>This is the format emulators can use to play games.</p><p></p></html>";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1504, 830);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmAdvancedDiskManagement);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Advanced Disk Space Manager";
      this.lstTitles.EndInit();
      this.cmdDelete.EndInit();
      this.lstEmuTitles.EndInit();
      this.cmdDeleteEmu.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radSplitContainer1.EndInit();
      this.radSplitContainer1.ResumeLayout(false);
      this.splitPanel1.EndInit();
      this.splitPanel1.ResumeLayout(false);
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox2.PerformLayout();
      this.radButton1.EndInit();
      this.lblTotalRaw.EndInit();
      this.radLabel1.EndInit();
      this.splitPanel2.EndInit();
      this.splitPanel2.ResumeLayout(false);
      this.radGroupBox3.EndInit();
      this.radGroupBox3.ResumeLayout(false);
      this.radGroupBox3.PerformLayout();
      this.lblTotalEmu.EndInit();
      this.radLabel2.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
