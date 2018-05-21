// Decompiled with JetBrains decompiler
// Type: ns0.FrmImport
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmImport : RadForm
  {
    public List<GClass32> list_0 = new List<GClass32>();
    private readonly string string_0;
    private IContainer icontainer_0;
    private RadCheckedListBox lstTitles;
    private RadLabel radLabel1;
    private RadLabel radLabel2;
    private RadButton cmdImport;
    private RadGroupBox radGroupBox1;
    private RadLabel radLabel4;
    private RadLabel radLabel3;
    private RadButton cmdCheckAll;
    private RadLabel radLabel6;
    private RadLabel radLabel5;

    public FrmImport(string string_1)
    {
      this.InitializeComponent();
      this.string_0 = string_1;
    }

    private void cmdCheckAll_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this.lstTitles.Items.Where<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.Enabled)))
        listViewDataItem.CheckState = ToggleState.On;
    }

    private void cmdImport_Click(object sender, EventArgs e)
    {
      foreach (ListViewDataItem listViewDataItem in this.lstTitles.Items.Where<ListViewDataItem>((Func<ListViewDataItem, bool>) (listViewDataItem_0 => listViewDataItem_0.CheckState == ToggleState.On)))
      {
        int num;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        FrmWait frmWait = new FrmWait("USB Helper is importing your title...", new Action(new FrmImport.Class155() { frmImport_0 = this, listViewDataItem_0 = listViewDataItem }.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void FrmImport_Load(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      FrmImport.Class156 class156 = new FrmImport.Class156();
      // ISSUE: reference to a compiler-generated field
      class156.frmImport_0 = this;
      this.lstTitles.SortDescriptors.Add(new SortDescriptor("Value", ListSortDirection.Ascending));
      // ISSUE: reference to a compiler-generated field
      class156.string_0 = new string[0];
      // ISSUE: reference to a compiler-generated field
      class156.string_1 = new string[0];
      int num1;
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("USB Helper is looking for importable titles...", new Action(class156.method_0), (Action<Exception>) (exception_0 => num1 = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
      Struct4 struct4;
      // ISSUE: reference to a compiler-generated field
      foreach (string str1 in class156.string_0)
      {
        string str2 = "Ready to import";
        GClass100 gclass100 = GClass100.smethod_0(str1, GEnum3.const_1);
        TitleId titleId = new TitleId(gclass100.TitleId.ToString("x16"));
        if (!GClass28.dictionary_0.ContainsKey(titleId.FullGame))
        {
          string str3 = "Cannot be imported, not in the database";
          ListViewDataItem listViewDataItem = new ListViewDataItem();
          this.lstTitles.Items.Add(listViewDataItem);
          listViewDataItem.Enabled = false;
          listViewDataItem[0] = (object) string.Format("UNKNOWN ({0})", (object) titleId.IdRaw);
          listViewDataItem[1] = (object) str3;
        }
        else
        {
          GClass30 gclass30 = (GClass30) null;
          switch (titleId.IdType)
          {
            case GEnum1.const_0:
              gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame];
              if (gclass30.System == GEnum3.const_0)
              {
                gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame].Updates.Last<GClass33>();
                break;
              }
              if (gclass30.System == GEnum3.const_1)
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                FrmImport.Class157 class157 = new FrmImport.Class157();
                // ISSUE: reference to a compiler-generated field
                class157.ushort_0 = gclass100.TitleVersion;
                try
                {
                  // ISSUE: reference to a compiler-generated method
                  gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame].Updates.Find(new Predicate<GClass33>(class157.method_0));
                  break;
                }
                catch
                {
                  gclass30 = (GClass30) null;
                  break;
                }
              }
              else
                break;
            case GEnum1.const_1:
              gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame];
              break;
            case GEnum1.const_2:
              gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame].Dlc;
              break;
            case GEnum1.const_3:
              gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame];
              break;
            case GEnum1.const_4:
              gclass30 = (GClass30) GClass28.dictionary_0[titleId.FullGame];
              break;
          }
          if (gclass30 != null)
          {
            ListViewDataItem listViewDataItem1 = new ListViewDataItem();
            struct4 = new Struct4();
            struct4.gclass100_0 = gclass100;
            struct4.gclass30_0 = gclass30;
            struct4.string_0 = Path.GetDirectoryName(str1);
            listViewDataItem1.Tag = (object) struct4;
            ListViewDataItem listViewDataItem2 = listViewDataItem1;
            if (gclass30.GEnum2_0 != GEnum2.const_0)
            {
              str2 = "Cannot be imported, already in the library";
              listViewDataItem2.Enabled = false;
            }
            this.lstTitles.Items.Add(listViewDataItem2);
            listViewDataItem2[0] = (object) gclass30.ToString();
            listViewDataItem2[1] = (object) str2;
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      foreach (string str in class156.string_1)
      {
        try
        {
          if (!(new DirectoryInfo(Path.GetDirectoryName(str)).Name != "meta"))
          {
            TitleId key = new TitleId(XDocument.Load(str).Descendants((XName) "title_id").ElementAt<XElement>(0).Value);
            if (key.IdType == GEnum1.const_1)
            {
              if (GClass28.dictionary_0.ContainsKey(key))
              {
                GClass32 gclass32 = GClass28.dictionary_0[key];
                GClass95 gclass95 = gclass32.method_14(false);
                if (gclass95 != null)
                {
                  if (!gclass32.Boolean_1)
                  {
                    ListViewDataItem listViewDataItem1 = new ListViewDataItem();
                    this.lstTitles.Items.Add(listViewDataItem1);
                    listViewDataItem1[0] = (object) (gclass32.Name + " (EMU)");
                    listViewDataItem1[1] = (object) "Importable";
                    ListViewDataItem listViewDataItem2 = listViewDataItem1;
                    struct4 = new Struct4();
                    struct4.gclass30_0 = (GClass30) gclass32;
                    struct4.gclass95_0 = gclass95;
                    struct4.string_0 = new DirectoryInfo(Path.GetDirectoryName(str)).Parent.FullName;
                    // ISSUE: variable of a boxed type
                    __Boxed<Struct4> local = (ValueType) struct4;
                    listViewDataItem2.Tag = (object) local;
                  }
                }
              }
            }
          }
        }
        catch
        {
        }
      }
      if (this.lstTitles.Items.Count != 0)
        return;
      int num2 = (int) RadMessageBox.Show("No games were found. Please specify another path.");
      this.DialogResult = DialogResult.Abort;
      this.Close();
    }

    private void method_0(string string_1, string string_2)
    {
      try
      {
        FileSystem.MoveFile(string_1, Path.Combine(string_2, new FileInfo(string_1).Name), UIOption.AllDialogs);
      }
      catch
      {
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
      ListViewDetailColumn viewDetailColumn1 = new ListViewDetailColumn("Column 0", "Title");
      ListViewDetailColumn viewDetailColumn2 = new ListViewDetailColumn("Column 1", "Status");
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmImport));
      this.lstTitles = new RadCheckedListBox();
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.cmdImport = new RadButton();
      this.radGroupBox1 = new RadGroupBox();
      this.radLabel6 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.cmdCheckAll = new RadButton();
      this.lstTitles.BeginInit();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.cmdImport.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.radLabel6.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel3.BeginInit();
      this.cmdCheckAll.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.lstTitles.AllowRemove = false;
      viewDetailColumn1.HeaderText = "Title";
      viewDetailColumn1.Width = 500f;
      viewDetailColumn2.HeaderText = "Status";
      viewDetailColumn2.Width = 300f;
      this.lstTitles.Columns.AddRange(viewDetailColumn1, viewDetailColumn2);
      this.lstTitles.Dock = DockStyle.Fill;
      this.lstTitles.ItemSpacing = -1;
      this.lstTitles.Location = new Point(5, 95);
      this.lstTitles.Name = "lstTitles";
      this.lstTitles.Size = new Size(836, 398);
      this.lstTitles.TabIndex = 1;
      this.lstTitles.Text = "\r\n";
      this.lstTitles.ThemeName = "VisualStudio2012Dark";
      this.lstTitles.ViewType = ListViewType.DetailsView;
      this.radLabel1.Location = new Point(188, 14);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(240, 18);
      this.radLabel1.TabIndex = 2;
      this.radLabel1.Text = "USB Helper has detected the following games. ";
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.radLabel2.Location = new Point((int) byte.MaxValue, 8);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(2, 2);
      this.radLabel2.TabIndex = 3;
      this.radLabel2.ThemeName = "VisualStudio2012Dark";
      this.cmdImport.Dock = DockStyle.Bottom;
      this.cmdImport.Location = new Point(5, 519);
      this.cmdImport.Name = "cmdImport";
      this.cmdImport.Size = new Size(836, 26);
      this.cmdImport.TabIndex = 5;
      this.cmdImport.Text = "Import";
      this.cmdImport.ThemeName = "VisualStudio2012Dark";
      this.cmdImport.Click += new EventHandler(this.cmdImport_Click);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.radLabel6);
      this.radGroupBox1.Controls.Add((Control) this.radLabel5);
      this.radGroupBox1.Controls.Add((Control) this.radLabel4);
      this.radGroupBox1.Controls.Add((Control) this.radLabel3);
      this.radGroupBox1.Controls.Add((Control) this.radLabel1);
      this.radGroupBox1.Dock = DockStyle.Top;
      this.radGroupBox1.HeaderText = "Info";
      this.radGroupBox1.Location = new Point(5, 5);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(836, 90);
      this.radGroupBox1.TabIndex = 6;
      this.radGroupBox1.Text = "Info";
      this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
      this.radLabel6.Location = new Point(188, 31);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(323, 18);
      this.radLabel6.TabIndex = 4;
      this.radLabel6.Text = "This will only work with games which already appear in the app.";
      this.radLabel6.ThemeName = "VisualStudio2012Dark";
      this.radLabel5.Location = new Point(189, 48);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new Size(367, 18);
      this.radLabel5.TabIndex = 3;
      this.radLabel5.Text = "If you have tickets which are not available on that site, please post them.";
      this.radLabel5.ThemeName = "VisualStudio2012Dark";
      this.radLabel4.ForeColor = Color.Red;
      this.radLabel4.Location = new Point(188, 67);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(311, 18);
      this.radLabel4.TabIndex = 4;
      this.radLabel4.Text = "Caution, this will MOVE and RENAME the folders accordingly.";
      this.radLabel4.ThemeName = "VisualStudio2012Dark";
      this.radLabel3.Location = new Point(424, 14);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(225, 18);
      this.radLabel3.TabIndex = 3;
      this.radLabel3.Text = " Please choose the ones you wish to import.";
      this.radLabel3.ThemeName = "VisualStudio2012Dark";
      this.cmdCheckAll.Dock = DockStyle.Bottom;
      this.cmdCheckAll.Location = new Point(5, 493);
      this.cmdCheckAll.Name = "cmdCheckAll";
      this.cmdCheckAll.Size = new Size(836, 26);
      this.cmdCheckAll.TabIndex = 6;
      this.cmdCheckAll.Text = "Select all";
      this.cmdCheckAll.ThemeName = "VisualStudio2012Dark";
      this.cmdCheckAll.Click += new EventHandler(this.cmdCheckAll_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(846, 550);
      this.Controls.Add((Control) this.lstTitles);
      this.Controls.Add((Control) this.cmdCheckAll);
      this.Controls.Add((Control) this.cmdImport);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.radLabel2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MinimumSize = new Size(479, 580);
      this.Name = nameof (FrmImport);
      this.Padding = new Padding(5);
      this.RootElement.ApplyShapeToControl = true;
      this.RootElement.MaxSize = new Size(0, 0);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import games";
      this.ThemeName = "VisualStudio2012Dark";
      this.Load += new EventHandler(this.FrmImport_Load);
      this.lstTitles.EndInit();
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.cmdImport.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.radLabel6.EndInit();
      this.radLabel5.EndInit();
      this.radLabel4.EndInit();
      this.radLabel3.EndInit();
      this.cmdCheckAll.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
