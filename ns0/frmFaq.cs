// Decompiled with JetBrains decompiler
// Type: ns0.frmFaq
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmFaq : RadForm
  {
    private List<GClass90> list_0;
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadLabel radLabel2;
    private RadListView lstQuestions;
    private RadTextBoxControl txtKeyWords;
    private RadLabel lblAnswer;
    private RadLabel radLabel4;
    private RadLabel radLabel3;

    public frmFaq()
    {
      this.InitializeComponent();
    }

    private void method_0()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      IEnumerable<GClass90> gclass90s = this.list_0.Where<GClass90>(new Func<GClass90, bool>(new frmFaq.Class141() { string_0 = this.txtKeyWords.Text.ToLower().Split(' ') }.method_0));
      this.lstQuestions.BeginUpdate();
      this.lstQuestions.Items.Clear();
      foreach (object obj in gclass90s)
        this.lstQuestions.Items.Add(new ListViewDataItem(obj));
      this.lstQuestions.EndUpdate();
    }

    private void frmFaq_Load(object sender, EventArgs e)
    {
      this.list_0 = Class67.smethod_0();
      this.method_0();
    }

    private void method_1(object sender, EventArgs e)
    {
    }

    private void lstQuestions_SelectedItemChanged(object sender, EventArgs e)
    {
      if (this.lstQuestions.SelectedItem == null)
        return;
      string answer = (this.lstQuestions.SelectedItem.Value as GClass90).Answer;
      StringBuilder stringBuilder = new StringBuilder(answer.Length + 100);
      int num = 0;
      foreach (char ch in answer)
      {
        if (ch != '"')
          stringBuilder.Append(ch);
        else if (num++ % 2 == 0)
          stringBuilder.Append("<span style=\"color: #ff8000\">");
        else
          stringBuilder.Append("</span>");
      }
      this.lblAnswer.Text = string.Format("<html><p>{0}</p></html>", (object) stringBuilder);
    }

    private void radLabel2_Click(object sender, EventArgs e)
    {
    }

    private void method_2(object sender, EventArgs e)
    {
      this.method_0();
    }

    private void txtKeyWords_TextChanged(object sender, EventArgs e)
    {
      this.method_0();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFaq));
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.lstQuestions = new RadListView();
      this.txtKeyWords = new RadTextBoxControl();
      this.lblAnswer = new RadLabel();
      this.radLabel4 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.lstQuestions.BeginInit();
      this.txtKeyWords.BeginInit();
      this.lblAnswer.BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel3.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.Location = new Point(20, 20);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(974, 30);
      this.radLabel1.TabIndex = 1;
      this.radLabel1.Text = "HELP CENTER";
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.radLabel2.AutoSize = false;
      this.radLabel2.Dock = DockStyle.Top;
      this.radLabel2.Location = new Point(20, 50);
      this.radLabel2.Margin = new Padding(3, 3, 3, 20);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(974, 18);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "Type a few keywords related to your problem";
      this.radLabel2.TextAlignment = ContentAlignment.TopCenter;
      this.radLabel2.Click += new EventHandler(this.radLabel2_Click);
      this.lstQuestions.AllowEdit = false;
      this.lstQuestions.AllowRemove = false;
      this.lstQuestions.Dock = DockStyle.Left;
      this.lstQuestions.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lstQuestions.ItemSpacing = 10;
      this.lstQuestions.Location = new Point(20, 129);
      this.lstQuestions.Name = "lstQuestions";
      this.lstQuestions.Size = new Size(527, 462);
      this.lstQuestions.TabIndex = 0;
      this.lstQuestions.Text = "radListView1";
      this.lstQuestions.SelectedItemChanged += new EventHandler(this.lstQuestions_SelectedItemChanged);
      this.txtKeyWords.Dock = DockStyle.Top;
      this.txtKeyWords.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtKeyWords.Location = new Point(20, 84);
      this.txtKeyWords.Margin = new Padding(3, 20, 3, 3);
      this.txtKeyWords.Name = "txtKeyWords";
      this.txtKeyWords.NullText = "Type in keywords related to your issue...";
      this.txtKeyWords.Size = new Size(974, 29);
      this.txtKeyWords.TabIndex = 5;
      this.txtKeyWords.TextChanged += new EventHandler(this.txtKeyWords_TextChanged);
      this.lblAnswer.AutoSize = false;
      this.lblAnswer.Dock = DockStyle.Fill;
      this.lblAnswer.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAnswer.Location = new Point(547, 129);
      this.lblAnswer.Name = "lblAnswer";
      this.lblAnswer.Padding = new Padding(20);
      this.lblAnswer.Size = new Size(447, 462);
      this.lblAnswer.TabIndex = 6;
      this.lblAnswer.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.radLabel4.AutoSize = false;
      this.radLabel4.Dock = DockStyle.Top;
      this.radLabel4.Location = new Point(20, 113);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(974, 16);
      this.radLabel4.TabIndex = 0;
      this.radLabel3.AutoSize = false;
      this.radLabel3.Dock = DockStyle.Top;
      this.radLabel3.Location = new Point(20, 68);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(974, 16);
      this.radLabel3.TabIndex = 7;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1014, 611);
      this.Controls.Add((Control) this.lblAnswer);
      this.Controls.Add((Control) this.lstQuestions);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.txtKeyWords);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.radLabel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmFaq);
      this.Padding = new Padding(20);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Self-help center";
      this.Load += new EventHandler(this.frmFaq_Load);
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.lstQuestions.EndInit();
      this.txtKeyWords.EndInit();
      this.lblAnswer.EndInit();
      this.radLabel4.EndInit();
      this.radLabel3.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
