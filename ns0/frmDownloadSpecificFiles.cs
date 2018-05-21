// Decompiled with JetBrains decompiler
// Type: ns0.frmDownloadSpecificFiles
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.WindowsAPICodePack.Dialogs;
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
  public class frmDownloadSpecificFiles : RadForm
  {
    private readonly GClass32 gclass32_0;
    private GClass13 gclass13_0;
    private Class9 class9_0;
    private GClass13 gclass13_1;
    private Class9 class9_1;
    private GClass13 gclass13_2;
    private Class9 class9_2;
    private IContainer icontainer_0;
    private RadTreeView lstNodesGame;
    private RadButton radButton1;
    private RadTreeView lstNodesUpdate;
    private RadTreeView lstNodesDlc;
    private RadGroupBox radGroupBox1;
    private RadGroupBox radGroupBox2;
    private RadGroupBox radGroupBox3;
    private RadGroupBox radGroupBox4;
    private RadGroupBox grpPreview;
    private RadGroupBox radGroupBox5;
    private RadLabel radLabel1;
    private RadLabel radLabel2;
    private RadLabel lblFullPath;
    private RadLabel lblSize;

    public frmDownloadSpecificFiles(GClass32 gclass32_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmDownloadSpecificFiles.Class132 class132 = new frmDownloadSpecificFiles.Class132();
      // ISSUE: reference to a compiler-generated field
      class132.gclass32_0 = gclass32_1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      // ISSUE: reference to a compiler-generated field
      class132.frmDownloadSpecificFiles_0 = this;
      this.InitializeComponent();
      // ISSUE: reference to a compiler-generated field
      this.gclass32_0 = class132.gclass32_0;
      if (this.gclass32_0.Boolean_0)
        return;
      // ISSUE: reference to a compiler-generated field
      if (class132.gclass32_0.System != GEnum3.const_1)
        throw new Exception("This only works with WUP titles!");
      this.lstNodesGame.TriStateMode = true;
      this.lstNodesDlc.TriStateMode = true;
      this.lstNodesUpdate.TriStateMode = true;
      // ISSUE: reference to a compiler-generated field
      this.lstNodesUpdate.Enabled = class132.gclass32_0.Boolean_3;
      // ISSUE: reference to a compiler-generated field
      this.lstNodesDlc.Enabled = class132.gclass32_0.Boolean_2;
      // ISSUE: reference to a compiler-generated field
      this.lstNodesGame.Enabled = !class132.gclass32_0.DiscOnly;
      int num;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("Please wait while USB Helper fetches data...", new Action(class132.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
    }

    private void method_0(RadTreeView radTreeView_0, GClass30 gclass30_0, GClass13 gclass13_3, string string_0)
    {
      List<GClass12> gclass12List = new List<GClass12>();
      foreach (RadTreeNode checkedNode in radTreeView_0.CheckedNodes)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        gclass12List.Add(gclass13_3.Files.Find(new Predicate<GClass12>(new frmDownloadSpecificFiles.Class133()
        {
          radTreeNode_0 = checkedNode
        }.method_0)));
      }
      if (gclass12List.Count <= 0)
        return;
      gclass30_0.method_16(string_0, true, true, (IEnumerable<GClass12>) gclass12List, false);
    }

    private void frmDownloadSpecificFiles_Load(object sender, EventArgs e)
    {
      if (!this.gclass32_0.Boolean_0)
        return;
      int num = (int) RadMessageBox.Show("This feature is not compatible with this title.");
      this.Close();
    }

    private void lstNodesDlc_NodeMouseClick(object sender, RadTreeViewEventArgs e)
    {
      this.method_1(e.Node, this.gclass13_0, this.class9_0);
    }

    private void lstNodesGame_NodeMouseClick(object sender, RadTreeViewEventArgs e)
    {
      this.method_1(e.Node, this.gclass13_1, this.class9_1);
    }

    private void lstNodesUpdate_NodeMouseClick(object sender, RadTreeViewEventArgs e)
    {
      this.method_1(e.Node, this.gclass13_2, this.class9_2);
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      CommonOpenFileDialog commonOpenFileDialog1 = new CommonOpenFileDialog();
      commonOpenFileDialog1.IsFolderPicker = true;
      commonOpenFileDialog1.Title = "Please chose where to download your files.";
      CommonOpenFileDialog commonOpenFileDialog2 = commonOpenFileDialog1;
      if (commonOpenFileDialog2.ShowDialog() != CommonFileDialogResult.Ok)
        return;
      if (this.lstNodesGame.Enabled)
        this.method_0(this.lstNodesGame, (GClass30) this.gclass32_0, this.gclass13_1, commonOpenFileDialog2.FileName);
      if (this.lstNodesUpdate.Enabled)
        this.method_0(this.lstNodesUpdate, (GClass30) this.gclass32_0.Updates.Last<GClass33>(), this.gclass13_2, commonOpenFileDialog2.FileName);
      if (!this.lstNodesDlc.Enabled)
        return;
      this.method_0(this.lstNodesDlc, (GClass30) this.gclass32_0.Dlc, this.gclass13_0, commonOpenFileDialog2.FileName);
    }

    private void method_1(RadTreeNode radTreeNode_0, GClass13 gclass13_3, Class9 class9_3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmDownloadSpecificFiles.Class134 class134 = new frmDownloadSpecificFiles.Class134();
      // ISSUE: reference to a compiler-generated field
      class134.radTreeNode_0 = radTreeNode_0;
      // ISSUE: reference to a compiler-generated field
      class134.frmDownloadSpecificFiles_0 = this;
      // ISSUE: reference to a compiler-generated field
      class134.class9_0 = class9_3;
      // ISSUE: reference to a compiler-generated field
      this.lblFullPath.Text = class134.radTreeNode_0.FullPath;
      this.grpPreview.Controls.Clear();
      // ISSUE: reference to a compiler-generated field
      if (class134.radTreeNode_0.Nodes.Count == 0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmDownloadSpecificFiles.Class135 class135 = new frmDownloadSpecificFiles.Class135();
        // ISSUE: reference to a compiler-generated field
        class135.class134_0 = class134;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class135.gclass12_0 = gclass13_3.Files.Find(new Predicate<GClass12>(class135.class134_0.method_0));
        // ISSUE: reference to a compiler-generated field
        this.lblSize.Text = new DataSize((ulong) class135.gclass12_0.uint_2).ToString();
        // ISSUE: reference to a compiler-generated method
        Task.Run(new Action(class135.method_0));
      }
      else
        this.lblSize.Text = "";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDownloadSpecificFiles));
      this.lstNodesGame = new RadTreeView();
      this.radButton1 = new RadButton();
      this.lstNodesUpdate = new RadTreeView();
      this.lstNodesDlc = new RadTreeView();
      this.radGroupBox1 = new RadGroupBox();
      this.radGroupBox2 = new RadGroupBox();
      this.radGroupBox3 = new RadGroupBox();
      this.radGroupBox4 = new RadGroupBox();
      this.grpPreview = new RadGroupBox();
      this.radGroupBox5 = new RadGroupBox();
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.lblFullPath = new RadLabel();
      this.lblSize = new RadLabel();
      this.lstNodesGame.BeginInit();
      this.radButton1.BeginInit();
      this.lstNodesUpdate.BeginInit();
      this.lstNodesDlc.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radGroupBox2.BeginInit();
      this.radGroupBox2.SuspendLayout();
      this.radGroupBox3.BeginInit();
      this.radGroupBox3.SuspendLayout();
      this.radGroupBox4.BeginInit();
      this.radGroupBox4.SuspendLayout();
      this.grpPreview.BeginInit();
      this.radGroupBox5.BeginInit();
      this.radGroupBox5.SuspendLayout();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.lblFullPath.BeginInit();
      this.lblSize.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.lstNodesGame.Dock = DockStyle.Fill;
      this.lstNodesGame.Location = new Point(2, 18);
      this.lstNodesGame.Name = "lstNodesGame";
      this.lstNodesGame.Size = new Size(334, 505);
      this.lstNodesGame.SpacingBetweenNodes = -1;
      this.lstNodesGame.TabIndex = 0;
      this.lstNodesGame.NodeMouseClick += new RadTreeView.TreeViewEventHandler(this.lstNodesGame_NodeMouseClick);
      this.radButton1.Dock = DockStyle.Bottom;
      this.radButton1.Location = new Point(0, 525);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(1530, 24);
      this.radButton1.TabIndex = 0;
      this.radButton1.Text = "Download Selected Files";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.lstNodesUpdate.Dock = DockStyle.Fill;
      this.lstNodesUpdate.Location = new Point(2, 18);
      this.lstNodesUpdate.Name = "lstNodesUpdate";
      this.lstNodesUpdate.Size = new Size(365, 505);
      this.lstNodesUpdate.SpacingBetweenNodes = -1;
      this.lstNodesUpdate.TabIndex = 1;
      this.lstNodesUpdate.NodeMouseClick += new RadTreeView.TreeViewEventHandler(this.lstNodesUpdate_NodeMouseClick);
      this.lstNodesDlc.Dock = DockStyle.Fill;
      this.lstNodesDlc.Location = new Point(2, 18);
      this.lstNodesDlc.Name = "lstNodesDlc";
      this.lstNodesDlc.Size = new Size(384, 505);
      this.lstNodesDlc.SpacingBetweenNodes = -1;
      this.lstNodesDlc.TabIndex = 2;
      this.lstNodesDlc.NodeMouseClick += new RadTreeView.TreeViewEventHandler(this.lstNodesDlc_NodeMouseClick);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.lstNodesGame);
      this.radGroupBox1.Dock = DockStyle.Left;
      this.radGroupBox1.HeaderText = "Game";
      this.radGroupBox1.Location = new Point(0, 0);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(338, 525);
      this.radGroupBox1.TabIndex = 3;
      this.radGroupBox1.Text = "Game";
      this.radGroupBox2.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add((Control) this.lstNodesUpdate);
      this.radGroupBox2.Dock = DockStyle.Left;
      this.radGroupBox2.HeaderText = "Update";
      this.radGroupBox2.Location = new Point(338, 0);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new Size(369, 525);
      this.radGroupBox2.TabIndex = 4;
      this.radGroupBox2.Text = "Update";
      this.radGroupBox3.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox3.Controls.Add((Control) this.lstNodesDlc);
      this.radGroupBox3.Dock = DockStyle.Left;
      this.radGroupBox3.HeaderText = "Dlc";
      this.radGroupBox3.Location = new Point(707, 0);
      this.radGroupBox3.Name = "radGroupBox3";
      this.radGroupBox3.Size = new Size(388, 525);
      this.radGroupBox3.TabIndex = 5;
      this.radGroupBox3.Text = "Dlc";
      this.radGroupBox4.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox4.Controls.Add((Control) this.grpPreview);
      this.radGroupBox4.Controls.Add((Control) this.radGroupBox5);
      this.radGroupBox4.Dock = DockStyle.Fill;
      this.radGroupBox4.HeaderText = "File Info";
      this.radGroupBox4.Location = new Point(1095, 0);
      this.radGroupBox4.Name = "radGroupBox4";
      this.radGroupBox4.Size = new Size(435, 525);
      this.radGroupBox4.TabIndex = 6;
      this.radGroupBox4.Text = "File Info";
      this.grpPreview.AccessibleRole = AccessibleRole.Grouping;
      this.grpPreview.Dock = DockStyle.Fill;
      this.grpPreview.HeaderText = "File preview";
      this.grpPreview.Location = new Point(2, 118);
      this.grpPreview.Name = "grpPreview";
      this.grpPreview.Size = new Size(431, 405);
      this.grpPreview.TabIndex = 7;
      this.grpPreview.Text = "File preview";
      this.radGroupBox5.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox5.Controls.Add((Control) this.radLabel1);
      this.radGroupBox5.Controls.Add((Control) this.radLabel2);
      this.radGroupBox5.Controls.Add((Control) this.lblFullPath);
      this.radGroupBox5.Controls.Add((Control) this.lblSize);
      this.radGroupBox5.Dock = DockStyle.Top;
      this.radGroupBox5.HeaderText = "Details";
      this.radGroupBox5.Location = new Point(2, 18);
      this.radGroupBox5.Name = "radGroupBox5";
      this.radGroupBox5.Size = new Size(431, 100);
      this.radGroupBox5.TabIndex = 7;
      this.radGroupBox5.Text = "Details";
      this.radLabel1.Location = new Point(18, 36);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(55, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Full Path :";
      this.radLabel2.Location = new Point(18, 60);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(32, 18);
      this.radLabel2.TabIndex = 1;
      this.radLabel2.Text = "Size :";
      this.lblFullPath.Location = new Point(80, 35);
      this.lblFullPath.Name = "lblFullPath";
      this.lblFullPath.Size = new Size(11, 18);
      this.lblFullPath.TabIndex = 1;
      this.lblFullPath.Text = "-";
      this.lblSize.Location = new Point(80, 59);
      this.lblSize.Name = "lblSize";
      this.lblSize.Size = new Size(11, 18);
      this.lblSize.TabIndex = 2;
      this.lblSize.Text = "-";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1530, 549);
      this.Controls.Add((Control) this.radGroupBox4);
      this.Controls.Add((Control) this.radGroupBox3);
      this.Controls.Add((Control) this.radGroupBox2);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.radButton1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmDownloadSpecificFiles);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Download Specific Files";
      this.Load += new EventHandler(this.frmDownloadSpecificFiles_Load);
      this.lstNodesGame.EndInit();
      this.radButton1.EndInit();
      this.lstNodesUpdate.EndInit();
      this.lstNodesDlc.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox2.EndInit();
      this.radGroupBox2.ResumeLayout(false);
      this.radGroupBox3.EndInit();
      this.radGroupBox3.ResumeLayout(false);
      this.radGroupBox4.EndInit();
      this.radGroupBox4.ResumeLayout(false);
      this.grpPreview.EndInit();
      this.radGroupBox5.EndInit();
      this.radGroupBox5.ResumeLayout(false);
      this.radGroupBox5.PerformLayout();
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.lblFullPath.EndInit();
      this.lblSize.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
