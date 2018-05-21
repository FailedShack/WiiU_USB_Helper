// Decompiled with JetBrains decompiler
// Type: ns0.frmDriveSetup
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmDriveSetup : RadForm
  {
    private byte[] byte_0;
    private byte[] byte_1;
    private IContainer icontainer_0;
    private RadPageView radPageView1;
    private RadPageViewPage step1;
    private RadLabel radLabel1;
    private RadPageViewPage step2;
    private RadLabel radLabel2;
    private RadPageViewPage radPageViewPage1;
    private RadLabel radLabel3;
    private RadPageViewPage radPageViewPage2;
    private RadLabel radLabel4;
    private RadButton radButton1;

    public frmDriveSetup()
    {
      this.InitializeComponent();
    }

    private static bool smethod_0(EventArrivedEventArgs eventArrivedEventArgs_0)
    {
      foreach (PropertyData property in eventArrivedEventArgs_0.NewEvent.Properties)
      {
        if (property.Name == "DriveName")
          return true;
      }
      return false;
    }

    private void method_0(object sender, EventArrivedEventArgs e)
    {
      foreach (PropertyData property in ((ManagementBaseObject) e.NewEvent["TargetInstance"]).Properties)
        Console.WriteLine(property.Name + " = " + property.Value);
    }

    private void method_1(object sender, EventArrivedEventArgs e)
    {
      foreach (PropertyData property in ((ManagementBaseObject) e.NewEvent["TargetInstance"]).Properties)
        Console.WriteLine(property.Name + " = " + property.Value);
    }

    private void frmDriveSetup_Load(object sender, EventArgs e)
    {
      this.method_3();
    }

    private void method_2(DriveInfo driveInfo_0, Action action_0, Action action_1)
    {
      string path1 = Path.Combine(driveInfo_0.Name, "otp.bin");
      string path2 = Path.Combine(driveInfo_0.Name, "seeprom.bin");
      if ((!File.Exists(path1) || !File.Exists(path2)) && action_1 != null)
        action_1();
      this.byte_0 = File.ReadAllBytes(path1);
      this.byte_1 = File.ReadAllBytes(path2);
      if (action_0 == null)
        return;
      action_0();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void method_3()
    {
      this.radPageView1.SelectedPage = this.radPageView1.Pages[0];
      this.method_7((Action<EventArrivedEventArgs>) (eventArrivedEventArgs_0 =>
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        frmDriveSetup.Class103 class103 = new frmDriveSetup.Class103();
        // ISSUE: reference to a compiler-generated field
        class103.frmDriveSetup_0 = this;
        // ISSUE: reference to a compiler-generated field
        class103.driveInfo_0 = new DriveInfo(eventArrivedEventArgs_0.NewEvent.Properties["DriveName"].Value.ToString());
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.method_2(class103.driveInfo_0, (Action) (() => this.method_5()), new Action(class103.method_0));
      }), (Action<EventArrivedEventArgs>) null);
    }

    private void method_4()
    {
      this.radPageView1.SelectedPage = this.radPageView1.Pages[1];
      this.method_7((Action<EventArrivedEventArgs>) (eventArrivedEventArgs_0 => this.method_2(new DriveInfo(eventArrivedEventArgs_0.NewEvent.Properties["DriveName"].Value.ToString()), (Action) (() => this.method_5()), (Action) (() =>
      {
        int num = (int) RadMessageBox.Show("The drive you have just inserted does not contain the required files. Please try again");
        this.method_4();
      }))), (Action<EventArrivedEventArgs>) null);
    }

    private void method_5()
    {
      this.radPageView1.SelectedPage = this.radPageView1.Pages[2];
      GClass131.smethod_0(new Action<GClass132>(this.method_6));
    }

    private void method_6(GClass132 gclass132_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmDriveSetup.Class104 class104 = new frmDriveSetup.Class104();
      // ISSUE: reference to a compiler-generated field
      class104.gclass132_0 = gclass132_0;
      // ISSUE: reference to a compiler-generated field
      class104.frmDriveSetup_0 = this;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new MethodInvoker(class104.method_0));
      }
      catch
      {
      }
    }

    private void method_7(Action<EventArrivedEventArgs> action_0, Action<EventArrivedEventArgs> action_1 = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmDriveSetup.Class105 class105 = new frmDriveSetup.Class105();
      // ISSUE: reference to a compiler-generated field
      class105.frmDriveSetup_0 = this;
      // ISSUE: reference to a compiler-generated field
      class105.action_0 = action_0;
      // ISSUE: reference to a compiler-generated field
      class105.action_1 = action_1;
      WqlEventQuery wqlEventQuery1 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
      // ISSUE: reference to a compiler-generated field
      class105.managementEventWatcher_0 = new ManagementEventWatcher((EventQuery) wqlEventQuery1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class105.managementEventWatcher_0.EventArrived += new EventArrivedEventHandler(class105.method_0);
      // ISSUE: reference to a compiler-generated field
      class105.managementEventWatcher_0.Start();
      WqlEventQuery wqlEventQuery2 = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
      // ISSUE: reference to a compiler-generated field
      class105.managementEventWatcher_1 = new ManagementEventWatcher((EventQuery) wqlEventQuery2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class105.managementEventWatcher_1.EventArrived += new EventArrivedEventHandler(class105.method_1);
      // ISSUE: reference to a compiler-generated field
      class105.managementEventWatcher_1.Start();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDriveSetup));
      this.radPageView1 = new RadPageView();
      this.step1 = new RadPageViewPage();
      this.radLabel1 = new RadLabel();
      this.step2 = new RadPageViewPage();
      this.radLabel2 = new RadLabel();
      this.radPageViewPage1 = new RadPageViewPage();
      this.radLabel3 = new RadLabel();
      this.radPageViewPage2 = new RadPageViewPage();
      this.radLabel4 = new RadLabel();
      this.radButton1 = new RadButton();
      this.radPageView1.BeginInit();
      this.radPageView1.SuspendLayout();
      this.step1.SuspendLayout();
      this.radLabel1.BeginInit();
      this.step2.SuspendLayout();
      this.radLabel2.BeginInit();
      this.radPageViewPage1.SuspendLayout();
      this.radLabel3.BeginInit();
      this.radPageViewPage2.SuspendLayout();
      this.radLabel4.BeginInit();
      this.radLabel4.SuspendLayout();
      this.radButton1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radPageView1.Controls.Add((Control) this.step1);
      this.radPageView1.Controls.Add((Control) this.step2);
      this.radPageView1.Controls.Add((Control) this.radPageViewPage1);
      this.radPageView1.Controls.Add((Control) this.radPageViewPage2);
      this.radPageView1.Dock = DockStyle.Fill;
      this.radPageView1.ImeMode = ImeMode.NoControl;
      this.radPageView1.Location = new Point(0, 0);
      this.radPageView1.Name = "radPageView1";
      this.radPageView1.SelectedPage = this.step1;
      this.radPageView1.Size = new Size(884, 226);
      this.radPageView1.TabIndex = 0;
      this.radPageView1.Text = "radPageView1";
      this.radPageView1.ViewMode = PageViewMode.Backstage;
      this.step1.Controls.Add((Control) this.radLabel1);
      this.step1.ItemSize = new SizeF(194f, 45f);
      this.step1.Location = new Point(305, 4);
      this.step1.Name = "step1";
      this.step1.Size = new Size(575, 218);
      this.step1.Text = "Step 1 - Welcome";
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Fill;
      this.radLabel1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.Location = new Point(0, 0);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(575, 218);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleLeft;
      this.step2.Controls.Add((Control) this.radLabel2);
      this.step2.ItemSize = new SizeF(194f, 45f);
      this.step2.Location = new Point(305, 4);
      this.step2.Name = "step2";
      this.step2.Size = new Size(575, 218);
      this.step2.Text = "Step 2 - Prepare your SD";
      this.radLabel2.AutoSize = false;
      this.radLabel2.Dock = DockStyle.Fill;
      this.radLabel2.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel2.Location = new Point(0, 0);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(575, 218);
      this.radLabel2.TabIndex = 1;
      this.radLabel2.Text = componentResourceManager.GetString("radLabel2.Text");
      this.radPageViewPage1.Controls.Add((Control) this.radLabel3);
      this.radPageViewPage1.ItemSize = new SizeF(194f, 45f);
      this.radPageViewPage1.Location = new Point(305, 4);
      this.radPageViewPage1.Name = "radPageViewPage1";
      this.radPageViewPage1.Size = new Size(575, 218);
      this.radPageViewPage1.Text = "Step 3 - Prepare your USB device";
      this.radLabel3.AutoSize = false;
      this.radLabel3.Dock = DockStyle.Fill;
      this.radLabel3.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel3.Location = new Point(0, 0);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(575, 218);
      this.radLabel3.TabIndex = 2;
      this.radLabel3.Text = "<html><p>Alright, juste one last step!</p><p></p><p><span style=\"color: #ff8000\">Please plug in your <strong>USB device</strong> into your <strong>computer.</strong></span></p></html>";
      this.radPageViewPage2.Controls.Add((Control) this.radLabel4);
      this.radPageViewPage2.ItemSize = new SizeF(194f, 45f);
      this.radPageViewPage2.Location = new Point(305, 4);
      this.radPageViewPage2.Name = "radPageViewPage2";
      this.radPageViewPage2.Size = new Size(575, 218);
      this.radPageViewPage2.Text = "Step 4 - Done!";
      this.radLabel4.AutoSize = false;
      this.radLabel4.Controls.Add((Control) this.radButton1);
      this.radLabel4.Dock = DockStyle.Fill;
      this.radLabel4.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel4.Location = new Point(0, 0);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(575, 218);
      this.radLabel4.TabIndex = 3;
      this.radLabel4.Text = "<html>The disk was installed successfully!</html>";
      this.radLabel4.TextAlignment = ContentAlignment.MiddleCenter;
      this.radButton1.Location = new Point(197, 186);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(181, 24);
      this.radButton1.TabIndex = 0;
      this.radButton1.Text = "Exit";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(884, 226);
      this.Controls.Add((Control) this.radPageView1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmDriveSetup);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Prepare my disk";
      this.Load += new EventHandler(this.frmDriveSetup_Load);
      this.radPageView1.EndInit();
      this.radPageView1.ResumeLayout(false);
      this.step1.ResumeLayout(false);
      this.radLabel1.EndInit();
      this.step2.ResumeLayout(false);
      this.radLabel2.EndInit();
      this.radPageViewPage1.ResumeLayout(false);
      this.radLabel3.EndInit();
      this.radPageViewPage2.ResumeLayout(false);
      this.radLabel4.EndInit();
      this.radLabel4.ResumeLayout(false);
      this.radButton1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}
