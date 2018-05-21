// Decompiled with JetBrains decompiler
// Type: ns0.frmEmuSettings
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmEmuSettings : RadForm
  {
    private IContainer icontainer_0;
    private RadPropertyGrid settingsGrid;
    private RadListView lstEmus;
    private RadButton cmdLaunchEmu;

    public frmEmuSettings()
    {
      this.InitializeComponent();
    }

    public bool PathWasChanged { get; private set; }

    private void cmdLaunchEmu_Click(object sender, EventArgs e)
    {
      if (this.lstEmus.SelectedItem == null)
        return;
      GClass95 instance = (GClass95) Activator.CreateInstance((Type) this.lstEmus.SelectedItem.Tag, new object[2]{ (object) GClass28.dictionary_0.ElementAt<KeyValuePair<TitleId, GClass32>>(0).Value, (object) false });
      if (instance.Boolean_0)
      {
        new Process()
        {
          StartInfo = new ProcessStartInfo()
          {
            FileName = instance.GetExecutable(),
            WorkingDirectory = instance.String_4
          }
        }.Start();
      }
      else
      {
        int num = (int) RadMessageBox.Show("The emulator is not installed yet. You must use the \"Play this game\" button at least once");
      }
    }

    private void frmEmuSettings_Load(object sender, EventArgs e)
    {
      foreach (Type type in ((IEnumerable<Type>) Assembly.GetAssembly(typeof (GClass95)).GetTypes()).Where<Type>((Func<Type, bool>) (type_0 => type_0.IsSubclassOf(typeof (GClass95)))))
        this.lstEmus.Items.Add(new ListViewDataItem(type.Name)
        {
          Tag = (object) type
        });
      this.lstEmus.SelectedIndex = 0;
    }

    private void lstEmus_SelectedItemChanged(object sender, EventArgs e)
    {
      if (this.lstEmus.SelectedItem == null)
        return;
      this.settingsGrid.SelectedObject = (object) ((GClass95) Activator.CreateInstance((Type) this.lstEmus.SelectedItem.Tag, new object[2]
      {
        (object) GClass28.dictionary_0.ElementAt<KeyValuePair<TitleId, GClass32>>(0).Value,
        (object) false
      })).EmuConfiguration_0;
    }

    private void settingsGrid_EditorRequired(object sender, PropertyGridEditorRequiredEventArgs e)
    {
      if (!e.Item.Name.ToLower().Contains("path"))
        return;
      PropertyGridBrowseEditor gridBrowseEditor = new PropertyGridBrowseEditor();
      (gridBrowseEditor.EditorElement as RadBrowseEditorElement).DialogType = BrowseEditorDialogType.FolderBrowseDialog;
      e.Editor = (IValueEditor) gridBrowseEditor;
      this.PathWasChanged = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmuSettings));
      this.settingsGrid = new RadPropertyGrid();
      this.lstEmus = new RadListView();
      this.cmdLaunchEmu = new RadButton();
      this.settingsGrid.BeginInit();
      this.lstEmus.BeginInit();
      this.cmdLaunchEmu.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.settingsGrid.Dock = DockStyle.Fill;
      this.settingsGrid.Location = new Point(243, 0);
      this.settingsGrid.Name = "settingsGrid";
      this.settingsGrid.Size = new Size(704, 382);
      this.settingsGrid.TabIndex = 0;
      this.settingsGrid.Text = "radPropertyGrid1";
      this.settingsGrid.EditorRequired += new PropertyGridEditorRequiredEventHandler(this.settingsGrid_EditorRequired);
      this.lstEmus.AllowEdit = false;
      this.lstEmus.AllowRemove = false;
      this.lstEmus.Dock = DockStyle.Left;
      this.lstEmus.Location = new Point(0, 0);
      this.lstEmus.Name = "lstEmus";
      this.lstEmus.Size = new Size(243, 406);
      this.lstEmus.TabIndex = 1;
      this.lstEmus.Text = "radListView1";
      this.lstEmus.SelectedItemChanged += new EventHandler(this.lstEmus_SelectedItemChanged);
      this.cmdLaunchEmu.Dock = DockStyle.Bottom;
      this.cmdLaunchEmu.Location = new Point(243, 382);
      this.cmdLaunchEmu.Name = "cmdLaunchEmu";
      this.cmdLaunchEmu.Size = new Size(704, 24);
      this.cmdLaunchEmu.TabIndex = 1;
      this.cmdLaunchEmu.Text = "Launch the emulator without game to configure it";
      this.cmdLaunchEmu.Click += new EventHandler(this.cmdLaunchEmu_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(947, 406);
      this.Controls.Add((Control) this.settingsGrid);
      this.Controls.Add((Control) this.cmdLaunchEmu);
      this.Controls.Add((Control) this.lstEmus);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmEmuSettings);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Emulator settings";
      this.Load += new EventHandler(this.frmEmuSettings_Load);
      this.settingsGrid.EndInit();
      this.lstEmus.EndInit();
      this.cmdLaunchEmu.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
