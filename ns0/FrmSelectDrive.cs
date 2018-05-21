// Decompiled with JetBrains decompiler
// Type: ns0.FrmSelectDrive
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmSelectDrive : RadForm
  {
    public DriveInfo driveInfo_0;
    private DataSize dataSize_0;
    private ManagementEventWatcher managementEventWatcher_0;
    private IContainer icontainer_0;
    private RadListView lstDrives;
    private RadLabel label1;
    private RadCheckBox chkDriveNotSeen;

    public FrmSelectDrive(DataSize dataSize_1)
    {
      this.dataSize_0 = dataSize_1;
      this.InitializeComponent();
    }

    public static IEnumerable<DriveInfo> smethod_0(bool bool_0)
    {
      if (bool_0)
        return (IEnumerable<DriveInfo>) new List<DriveInfo>(((IEnumerable<DriveInfo>) DriveInfo.GetDrives()).Where<DriveInfo>((Func<DriveInfo, bool>) (driveInfo_0 =>
        {
          if (driveInfo_0.DriveType == DriveType.Removable)
            return driveInfo_0.IsReady;
          return false;
        })));
      return (IEnumerable<DriveInfo>) new List<DriveInfo>(((IEnumerable<DriveInfo>) DriveInfo.GetDrives()).Where<DriveInfo>((Func<DriveInfo, bool>) (driveInfo_0 => driveInfo_0.IsReady)));
    }

    private void chkDriveNotSeen_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      this.method_0(!this.chkDriveNotSeen.Checked);
    }

    private void managementEventWatcher_0_EventArrived(object object_0, object object_1)
    {
      this.Invoke((Delegate) (() => this.method_0(!this.chkDriveNotSeen.Checked)));
    }

    private void FrmSelectDrive_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        this.managementEventWatcher_0.EventArrived -= new EventArrivedEventHandler(this.managementEventWatcher_0_EventArrived);
        this.managementEventWatcher_0.Dispose();
      }
      catch
      {
      }
    }

    private void FrmSelectDrive_Load(object sender, EventArgs e)
    {
      this.method_0(true);
      try
      {
        this.managementEventWatcher_0 = new ManagementEventWatcher();
        WqlEventQuery wqlEventQuery = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2 OR EventType = 3");
        this.managementEventWatcher_0.EventArrived += new EventArrivedEventHandler(this.managementEventWatcher_0_EventArrived);
        this.managementEventWatcher_0.Query = (EventQuery) wqlEventQuery;
        this.managementEventWatcher_0.Start();
      }
      catch
      {
      }
    }

    private void lstDrives_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
    {
      DriveInfo tag = (DriveInfo) e.Item.Tag;
      if ((ulong) tag.TotalSize < this.dataSize_0.TotalBytes)
      {
        int num1 = (int) RadMessageBox.Show("Sorry but this drive isn't big enough, even if completely empty.");
      }
      else if ((ulong) tag.AvailableFreeSpace < this.dataSize_0.TotalBytes)
      {
        int num2 = (int) RadMessageBox.Show(string.Format("There isn't enough space on this drive! Please delete some files and try again! You need to free {0}.", (object) new DataSize(this.dataSize_0.TotalBytes - (ulong) tag.AvailableFreeSpace)));
        if (RadMessageBox.Show("Would you like to open an explorer window to make some space?", "Open explorer?", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        Process.Start(tag.Name);
      }
      else
      {
        this.driveInfo_0 = tag;
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void method_0(bool bool_0)
    {
      this.lstDrives.Items.Clear();
      foreach (DriveInfo driveInfo in FrmSelectDrive.smethod_0(bool_0))
      {
        if (driveInfo.IsReady)
        {
          this.lstDrives.BeginEdit();
          this.lstDrives.Items.Add(new ListViewDataItem(driveInfo.Name)
          {
            Image = (Image) Class123.icnDisk,
            Tag = (object) driveInfo,
            ImageAlignment = ContentAlignment.TopCenter,
            TextAlignment = ContentAlignment.BottomCenter,
            TextImageRelation = TextImageRelation.ImageAboveText
          });
          this.lstDrives.EndEdit();
        }
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
      this.lstDrives = new RadListView();
      this.label1 = new RadLabel();
      this.chkDriveNotSeen = new RadCheckBox();
      this.lstDrives.BeginInit();
      this.label1.BeginInit();
      this.chkDriveNotSeen.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.lstDrives.AllowEdit = false;
      this.lstDrives.AllowRemove = false;
      this.lstDrives.Dock = DockStyle.Fill;
      this.lstDrives.FullRowSelect = false;
      this.lstDrives.ItemSize = new Size(64, 64);
      this.lstDrives.Location = new Point(10, 28);
      this.lstDrives.Name = "lstDrives";
      this.lstDrives.Size = new Size(328, 339);
      this.lstDrives.TabIndex = 0;
      this.lstDrives.Text = "radListView1";
      this.lstDrives.ThemeName = "VisualStudio2012Dark";
      this.lstDrives.ViewType = ListViewType.IconsView;
      this.lstDrives.ItemMouseDoubleClick += new ListViewItemEventHandler(this.lstDrives_ItemMouseDoubleClick);
      this.label1.Dock = DockStyle.Top;
      this.label1.Location = new Point(10, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(224, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "Double click to select the destination drive :";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.chkDriveNotSeen.Dock = DockStyle.Bottom;
      this.chkDriveNotSeen.Location = new Point(10, 367);
      this.chkDriveNotSeen.Name = "chkDriveNotSeen";
      this.chkDriveNotSeen.Size = new Size(116, 18);
      this.chkDriveNotSeen.TabIndex = 2;
      this.chkDriveNotSeen.Text = "I can't see my drive";
      this.chkDriveNotSeen.ToggleStateChanged += new StateChangedEventHandler(this.chkDriveNotSeen_ToggleStateChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(348, 395);
      this.Controls.Add((Control) this.lstDrives);
      this.Controls.Add((Control) this.chkDriveNotSeen);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmSelectDrive);
      this.Padding = new Padding(10);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Select your destination drive";
      this.ThemeName = "VisualStudio2012Dark";
      this.FormClosing += new FormClosingEventHandler(this.FrmSelectDrive_FormClosing);
      this.Load += new EventHandler(this.FrmSelectDrive_Load);
      this.lstDrives.EndInit();
      this.label1.EndInit();
      this.chkDriveNotSeen.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
