// Decompiled with JetBrains decompiler
// Type: ns0.frmInjectionAnimation
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using WMPLib;

namespace ns0
{
  public class frmInjectionAnimation : Form
  {
    private int int_1 = 2;
    private int int_2 = 20;
    private int int_4 = -1;
    private const int int_0 = 8;
    private Bitmap bitmap_0;
    private GClass91 gclass91_0;
    private WindowsMediaPlayer windowsMediaPlayer_0;
    private List<string> list_0;
    private int int_3;
    private IContainer icontainer_0;
    private PictureBox pctAarrow;
    private RadLabel radLabel4;
    private RadLabel radLabel3;
    private RadLabel radLabel2;
    private RadLabel radLabel1;
    private Timer timer_0;
    private PictureBox pictureBox1;
    private Timer timer_1;
    private RadCheckBox chkListenToMusic;

    public frmInjectionAnimation(GClass91 gclass91_1)
    {
      this.InitializeComponent();
      this.Region = Class97.smethod_6((Form) this, 40);
      this.gclass91_0 = gclass91_1;
      try
      {
        this.int_3 = this.pctAarrow.Left;
        this.timer_1.Interval = 25;
        this.timer_1.Start();
        this.bitmap_0 = (Bitmap) Image.FromStream((Stream) new MemoryStream(new GClass78().method_2(string.Format("http://art.gametdb.com/wii/disc/{0}/{1}.png", this.gclass91_0.ToInject.Region == "USA" ? (object) "US" : (object) "EN", (object) this.gclass91_0.ToInject.ProductId))));
        this.bitmap_0.SetResolution(96f, 96f);
        this.timer_0.Interval = 30;
        this.timer_0.Start();
      }
      catch
      {
      }
      try
      {
        this.windowsMediaPlayer_0 = (WindowsMediaPlayer) new WindowsMediaPlayerClass();
        // ISSUE: method pointer
        this.windowsMediaPlayer_0.add_PlayStateChange(new _WMPOCXEvents_PlayStateChangeEventHandler((object) this, (UIntPtr) __methodptr(method_3)));
      }
      catch
      {
      }
    }

    private void chkListenToMusic_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      try
      {
        if (e.ToggleState == ToggleState.On)
          this.method_2();
        else
          ((IWMPPlayer4) this.windowsMediaPlayer_0).controls.stop();
      }
      catch
      {
      }
    }

    private void frmInjectionAnimation_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        ((IWMPPlayer4) this.windowsMediaPlayer_0).controls.stop();
        ((IWMPPlayer4) this.windowsMediaPlayer_0).close();
      }
      catch
      {
      }
    }

    private void frmInjectionAnimation_Shown(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmInjectionAnimation.Class148 class148 = new frmInjectionAnimation.Class148();
      // ISSUE: reference to a compiler-generated field
      class148.frmInjectionAnimation_0 = this;
      // ISSUE: reference to a compiler-generated method
      this.gclass91_0.Event_0 += new EventHandler(class148.method_0);
      // ISSUE: reference to a compiler-generated method
      this.gclass91_0.Event_1 += new EventHandler<Exception>(class148.method_2);
      // ISSUE: reference to a compiler-generated field
      class148.list_0 = new List<RadLabel>();
      foreach (object control in (ArrangedElementCollection) this.Controls)
      {
        if (control is RadLabel)
        {
          // ISSUE: reference to a compiler-generated field
          class148.list_0.Add(control as RadLabel);
        }
      }
      // ISSUE: reference to a compiler-generated field
      class148.list_0.Reverse();
      string[] string3 = this.gclass91_0.String_3;
      for (int index = 0; index < 4; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        class148.list_0[index].Text = string.Format("Step {0}: {1}...", (object) (index + 1), (object) string3[index]);
      }
      // ISSUE: reference to a compiler-generated method
      this.gclass91_0.Event_2 += new EventHandler<int>(class148.method_3);
      this.gclass91_0.vmethod_2();
    }

    private string method_0()
    {
      return new GClass78().method_6(string.Format("{0}/music", (object) this.gclass91_0.ToInject.String_6));
    }

    private string method_1(string string_0)
    {
      HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
      htmlDocument.LoadHtml(new GClass78().method_6("https://downloads.khinsider.com" + string_0));
      return htmlDocument.DocumentNode.Descendants("audio").First<HtmlNode>().Attributes["src"].Value;
    }

    private void method_2()
    {
      Task.Run((Action) (() =>
      {
        try
        {
          ((IWMPPlayer4) this.windowsMediaPlayer_0).controls.stop();
          if (this.list_0 == null)
          {
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            this.list_0 = new List<string>();
            htmlDocument.LoadHtml(new GClass78().method_6(this.method_0()));
            this.list_0.AddRange((IEnumerable<string>) htmlDocument.DocumentNode.Descendants("a").Where<HtmlNode>((Func<HtmlNode, bool>) (htmlNode_0 =>
            {
              if (htmlNode_0.Attributes.Contains("href"))
                return htmlNode_0.Attributes["href"].Value.Contains(".mp3");
              return false;
            })).Select<HtmlNode, string>((Func<HtmlNode, string>) (htmlNode_0 => htmlNode_0.Attributes["href"].Value)).ToArray<string>());
          }
          ((IWMPPlayer4) this.windowsMediaPlayer_0).settings.volume = 50;
          ((IWMPPlayer4) this.windowsMediaPlayer_0).URL = this.method_1(this.list_0[new Random().Next(this.list_0.Count)]);
          ((IWMPPlayer4) this.windowsMediaPlayer_0).controls.play();
        }
        catch
        {
        }
      }));
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
      if (this.bitmap_0 == null)
        return;
      Graphics graphics = e.Graphics;
      graphics.TranslateTransform(80f, 80f);
      graphics.RotateTransform((float) this.int_1);
      graphics.DrawImage((Image) this.bitmap_0, new Point(-80, -80));
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      this.int_1 = (this.int_1 + this.int_2) % 360;
      this.pictureBox1.Refresh();
    }

    private void timer_1_Tick(object sender, EventArgs e)
    {
      if (this.pctAarrow.Left - 1 < this.int_3 || this.pctAarrow.Left + 1 > this.int_3 + 8)
        this.int_4 *= -1;
      this.pctAarrow.Left += this.int_4;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.icontainer_0 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInjectionAnimation));
      this.pctAarrow = new PictureBox();
      this.radLabel4 = new RadLabel();
      this.radLabel3 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.timer_0 = new Timer(this.icontainer_0);
      this.pictureBox1 = new PictureBox();
      this.timer_1 = new Timer(this.icontainer_0);
      this.chkListenToMusic = new RadCheckBox();
      ((ISupportInitialize) this.pctAarrow).BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel3.BeginInit();
      this.radLabel2.BeginInit();
      this.radLabel1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.chkListenToMusic.BeginInit();
      this.SuspendLayout();
      this.pctAarrow.BackColor = Color.Transparent;
      this.pctAarrow.Image = (Image) Class123.icnArrow;
      this.pctAarrow.Location = new Point(227, 35);
      this.pctAarrow.Name = "pctAarrow";
      this.pctAarrow.Size = new Size(32, 32);
      this.pctAarrow.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pctAarrow.TabIndex = 11;
      this.pctAarrow.TabStop = false;
      this.radLabel4.BackColor = Color.Transparent;
      this.radLabel4.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel4.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel4.Location = new Point(271, 144);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(184, 19);
      this.radLabel4.TabIndex = 10;
      this.radLabel4.Text = "Step 4 : Packing the game...";
      this.radLabel3.BackColor = Color.Transparent;
      this.radLabel3.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel3.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel3.Location = new Point(271, 110);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(191, 19);
      this.radLabel3.TabIndex = 9;
      this.radLabel3.Text = "Step 3 : Injecting the game...";
      this.radLabel2.BackColor = Color.Transparent;
      this.radLabel2.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel2.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel2.Location = new Point(271, 76);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(181, 19);
      this.radLabel2.TabIndex = 8;
      this.radLabel2.Text = "Step 2 : Shrinking the ISO...";
      this.radLabel1.BackColor = Color.Transparent;
      this.radLabel1.Font = new Font("Trebuchet MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel1.Location = new Point(271, 42);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(206, 19);
      this.radLabel1.TabIndex = 7;
      this.radLabel1.Text = "Step 1 : Fetching the content...";
      this.timer_0.Interval = 33;
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Location = new Point(36, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(160, 160);
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint);
      this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
      this.chkListenToMusic.Location = new Point(259, 174);
      this.chkListenToMusic.Name = "chkListenToMusic";
      this.chkListenToMusic.Size = new Size(218, 18);
      this.chkListenToMusic.TabIndex = 13;
      this.chkListenToMusic.Text = "Why not listen to the OST of the game?";
      this.chkListenToMusic.ToggleStateChanged += new StateChangedEventHandler(this.chkListenToMusic_ToggleStateChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Class123.bg;
      this.ClientSize = new Size(489, 204);
      this.Controls.Add((Control) this.chkListenToMusic);
      this.Controls.Add((Control) this.pctAarrow);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmInjectionAnimation);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Injecting...";
      this.FormClosing += new FormClosingEventHandler(this.frmInjectionAnimation_FormClosing);
      this.Shown += new EventHandler(this.frmInjectionAnimation_Shown);
      ((ISupportInitialize) this.pctAarrow).EndInit();
      this.radLabel4.EndInit();
      this.radLabel3.EndInit();
      this.radLabel2.EndInit();
      this.radLabel1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.chkListenToMusic.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
