// Decompiled with JetBrains decompiler
// Type: ns0.FrmWhatToCopy
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WIIU_Downloader.Forms;

namespace ns0
{
  public class FrmWhatToCopy : RadForm
  {
    private WhatToAction whatToAction_0;
    private readonly GClass32 gclass32_0;
    private readonly bool bool_0;
    private int int_0;
    public List<GClass33> list_0;
    private IContainer icontainer_0;
    private RadLabel label1;
    private RadCheckBox chkCopyGame;
    private RadCheckBox chkCopyUpdate;
    private RadButton radButton1;
    private RadCheckBox chkCopyDlc;
    private RadLabel title;

    public FrmWhatToCopy(GClass32 gclass32_1, WhatToAction whatToAction_1)
    {
      this.InitializeComponent();
      this.bool_0 = whatToAction_1 == WhatToAction.Copy || whatToAction_1 == WhatToAction.Unpack;
      this.whatToAction_0 = whatToAction_1;
      this.title.Text = gclass32_1.Name;
      this.gclass32_0 = gclass32_1;
      this.Text = string.Format("What to {0}", (object) whatToAction_1);
      this.label1.Text = string.Format("Select what you would like to {0}", (object) Enum.GetName(typeof (WhatToAction), (object) whatToAction_1).ToLower());
      if (this.bool_0)
      {
        this.chkCopyGame.Enabled = gclass32_1.GEnum2_0 == GEnum2.const_2;
        this.chkCopyUpdate.Enabled = gclass32_1.Boolean_3 && gclass32_1.Updates.Any<GClass33>((Func<GClass33, bool>) (gclass33_0 => gclass33_0.GEnum2_0 == GEnum2.const_2));
        this.chkCopyDlc.Enabled = gclass32_1.Dlc != null && gclass32_1.Dlc.GEnum2_0 == GEnum2.const_2;
      }
      else
      {
        this.chkCopyGame.Enabled = (uint) gclass32_1.GEnum2_0 > 0U;
        this.chkCopyUpdate.Enabled = gclass32_1.Boolean_3 && gclass32_1.Updates.Any<GClass33>((Func<GClass33, bool>) (gclass33_0 => (uint) gclass33_0.GEnum2_0 > 0U));
        this.chkCopyDlc.Enabled = gclass32_1.Dlc != null && (uint) gclass32_1.Dlc.GEnum2_0 > 0U;
      }
      this.Opacity = 0.0;
    }

    public bool CopyDlc { get; set; }

    public bool CopyGame { get; set; }

    public bool CopyUpdate { get; set; }

    private void chkCopyUpdate_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      if (!this.chkCopyUpdate.Checked)
        return;
      this.method_0();
    }

    private void method_0()
    {
      FrmSelectVersion frmSelectVersion = new FrmSelectVersion((IEnumerable<GClass33>) this.gclass32_0.Updates, this.bool_0);
      if (frmSelectVersion.ShowDialog() == DialogResult.OK)
        this.list_0 = frmSelectVersion.list_0;
      else
        this.chkCopyUpdate.Checked = false;
    }

    private void FrmWhatToCopy_Load(object sender, EventArgs e)
    {
      if (this.chkCopyGame.Enabled)
        ++this.int_0;
      if (this.chkCopyDlc.Enabled)
        ++this.int_0;
      if (this.chkCopyUpdate.Enabled)
        ++this.int_0;
      if (!this.bool_0)
      {
        this.Opacity = 100.0;
      }
      else
      {
        if (this.int_0 == 0)
        {
          this.DialogResult = DialogResult.Cancel;
          this.Close();
        }
        if (this.int_0 != 1)
        {
          this.Opacity = 100.0;
        }
        else
        {
          this.DialogResult = DialogResult.OK;
          this.CopyGame = this.chkCopyGame.Enabled;
          if (this.chkCopyUpdate.Enabled)
          {
            this.method_0();
            this.CopyUpdate = this.list_0 != null;
          }
          this.CopyDlc = this.chkCopyDlc.Enabled;
          this.Close();
        }
      }
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.CopyGame = this.chkCopyGame.Checked;
      this.CopyUpdate = this.chkCopyUpdate.Checked;
      this.CopyDlc = this.chkCopyDlc.Checked;
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
      this.label1 = new RadLabel();
      this.chkCopyGame = new RadCheckBox();
      this.chkCopyUpdate = new RadCheckBox();
      this.radButton1 = new RadButton();
      this.chkCopyDlc = new RadCheckBox();
      this.title = new RadLabel();
      this.label1.BeginInit();
      this.chkCopyGame.BeginInit();
      this.chkCopyUpdate.BeginInit();
      this.radButton1.BeginInit();
      this.chkCopyDlc.BeginInit();
      this.title.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.Location = new Point(56, 47);
      this.label1.Name = "label1";
      this.label1.Size = new Size(185, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Select what you would like to copy :";
      this.chkCopyGame.Location = new Point(102, 75);
      this.chkCopyGame.Name = "chkCopyGame";
      this.chkCopyGame.Size = new Size(49, 18);
      this.chkCopyGame.TabIndex = 1;
      this.chkCopyGame.Text = "Game";
      this.chkCopyUpdate.Location = new Point(102, 99);
      this.chkCopyUpdate.Name = "chkCopyUpdate";
      this.chkCopyUpdate.Size = new Size(57, 18);
      this.chkCopyUpdate.TabIndex = 2;
      this.chkCopyUpdate.Text = "Update";
      this.chkCopyUpdate.ToggleStateChanged += new StateChangedEventHandler(this.chkCopyUpdate_ToggleStateChanged);
      this.radButton1.Location = new Point(90, 147);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(110, 24);
      this.radButton1.TabIndex = 3;
      this.radButton1.Text = "Ok";
      this.radButton1.ThemeName = "Desert";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.chkCopyDlc.Location = new Point(102, 123);
      this.chkCopyDlc.Name = "chkCopyDlc";
      this.chkCopyDlc.Size = new Size(40, 18);
      this.chkCopyDlc.TabIndex = 3;
      this.chkCopyDlc.Text = "DLC";
      this.title.AutoSize = false;
      this.title.Dock = DockStyle.Top;
      this.title.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.title.Location = new Point(0, 0);
      this.title.Name = "title";
      this.title.Size = new Size(296, 45);
      this.title.TabIndex = 4;
      this.title.Text = "label2";
      this.title.TextAlignment = ContentAlignment.TopCenter;
      this.title.UseMnemonic = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(296, 172);
      this.Controls.Add((Control) this.title);
      this.Controls.Add((Control) this.chkCopyDlc);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.chkCopyUpdate);
      this.Controls.Add((Control) this.chkCopyGame);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmWhatToCopy);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "What to copy?";
      this.ThemeName = "Desert";
      this.Load += new EventHandler(this.FrmWhatToCopy_Load);
      this.label1.EndInit();
      this.chkCopyGame.EndInit();
      this.chkCopyUpdate.EndInit();
      this.radButton1.EndInit();
      this.chkCopyDlc.EndInit();
      this.title.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
