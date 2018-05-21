// Decompiled with JetBrains decompiler
// Type: ns0.frmSelectTheme
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmSelectTheme : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadListView lstThemes;

    public frmSelectTheme()
    {
      this.InitializeComponent();
    }

    private void frmSelectTheme_Load(object sender, EventArgs e)
    {
      foreach (object availableTheme in (IEnumerable) ThemeResolutionService.GetAvailableThemes())
      {
        Theme theme = availableTheme as Theme;
        string text = theme.Name;
        bool flag = false;
        if (text[0] == '!')
        {
          text = text.Substring(1);
          flag = true;
        }
        this.lstThemes.Items.Add(new ListViewDataItem(text)
        {
          Tag = (object) new frmSelectTheme.Struct1()
          {
            bool_0 = flag,
            theme_0 = theme
          }
        });
      }
    }

    private void lstThemes_ItemMouseClick(object sender, ListViewItemEventArgs e)
    {
      Settings.Default.ThemeName = ((frmSelectTheme.Struct1) e.Item.Tag).theme_0.Name;
      Settings.Default.Save();
      int num = (int) RadMessageBox.Show("Please restart the app for the changes to take effect.");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radLabel1 = new RadLabel();
      this.lstThemes = new RadListView();
      this.radLabel1.BeginInit();
      this.lstThemes.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Location = new Point(5, 5);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(328, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Please select a theme";
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.lstThemes.Dock = DockStyle.Fill;
      this.lstThemes.Location = new Point(5, 23);
      this.lstThemes.Name = "lstThemes";
      this.lstThemes.SelectLastAddedItem = false;
      this.lstThemes.Size = new Size(328, 355);
      this.lstThemes.TabIndex = 1;
      this.lstThemes.Text = "radListView1";
      this.lstThemes.ItemMouseClick += new ListViewItemEventHandler(this.lstThemes_ItemMouseClick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(338, 383);
      this.Controls.Add((Control) this.lstThemes);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmSelectTheme);
      this.Padding = new Padding(5);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select a theme";
      this.Load += new EventHandler(this.frmSelectTheme_Load);
      this.radLabel1.EndInit();
      this.lstThemes.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }

    internal struct Struct1
    {
      public bool bool_0;
      public Theme theme_0;
    }
  }
}
