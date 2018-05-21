// Decompiled with JetBrains decompiler
// Type: ns0.Class97
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.WindowsAPICodePack.Dialogs;
using NusHelper;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  internal static class Class97
  {
    private static SoundPlayer soundPlayer_0 = new SoundPlayer((Stream) Class123.sndNotification);
    private static Form form_0;

    public static Color smethod_0(GClass30 gclass30_0)
    {
      if (gclass30_0.DiscOnly)
        return Color.LightGoldenrodYellow;
      if (gclass30_0.GEnum2_0 == GEnum2.const_2)
        return Color.Green;
      if (gclass30_0.GEnum2_0 == GEnum2.const_1)
        return Color.DarkOrange;
      if (gclass30_0.GEnum2_0 != GEnum2.const_0)
        return Color.Black;
      if (gclass30_0.Boolean_0)
        return Color.Violet;
      if (ThemeResolutionService.ApplicationThemeName.Contains("Dark"))
        return Color.White;
      return Color.Black;
    }

    public static void smethod_1(GClass32 gclass32_0, int int_0, Color color_0)
    {
      if (gclass32_0.gclass86_2.Image == null)
        return;
      if (gclass32_0.Boolean_3)
        gclass32_0.gclass86_2.Image = gclass32_0.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2 ? GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.hasUpdateOk, true) : GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.hasUpdate, true);
      if (gclass32_0.Boolean_2)
        gclass32_0.gclass86_2.Image = gclass32_0.Dlc.GEnum2_0 == GEnum2.const_2 ? GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.hasDLCOk, true) : GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.hasDLC, true);
      switch (gclass32_0.System)
      {
        case GEnum3.const_0:
          gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.tag3ds, true);
          break;
        case GEnum3.const_1:
          gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.tagWiiU, true);
          break;
        case GEnum3.const_2:
          throw new NotImplementedException();
        case GEnum3.const_3:
          gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.tagWii, true);
          break;
      }
      if (gclass32_0.Boolean_4)
        gclass32_0.gclass86_2.Image = GClass6.smethod_17(gclass32_0.gclass86_2.Image, (Image) Class123.newTag, true);
      gclass32_0.gclass86_2.Image = gclass32_0.gclass86_2.Image.smethod_0(int_0, color_0, true);
    }

    public static void smethod_2()
    {
      if (!Settings.Default.Path.Contains("Program Files") || !Settings.Default.ShowProgramFilesWarning)
        return;
      int num = (int) RadMessageBox.Show("It appears you have chosen to store your games in Program Files. This could lead to a number of issues since this is a restricted location. It is advised that you chose another location which does not require admin privileges such as your personnal folder.");
      switch (RadMessageBox.Show("Would you like to set a new location now (strongly recommended)? Chosing cancel will disable future warnings.", "Problem detected", MessageBoxButtons.YesNoCancel))
      {
        case DialogResult.Cancel:
          Settings.Default.ShowProgramFilesWarning = false;
          Settings.Default.Save();
          break;
        case DialogResult.Yes:
          string str1 = Path.Combine(Settings.Default.Path, "DATA");
          string str2 = Path.Combine(Settings.Default.Path, "DATA_3DS");
          do
            ;
          while (!Class97.smethod_13(true) || !GClass6.smethod_2(Settings.Default.Path));
          if (Directory.Exists(str1))
            Class97.smethod_8(str1, Settings.Default.Path);
          if (!Directory.Exists(str2))
            break;
          Class97.smethod_8(str2, Settings.Default.Path);
          break;
      }
    }

    public static void smethod_3()
    {
      GClass88.smethod_0("dl");
    }

    public static void smethod_4(IEnumerable<GClass30> ienumerable_0, DriveInfo driveInfo_0, bool bool_0, bool bool_1, Form form_1 = null)
    {
      string str1 = "--COPY REPORT--" + Environment.NewLine;
      int num = 0;
      IEnumerable<GClass30> source = ienumerable_0;
      Func<GClass30, bool> func = (Func<GClass30, bool>) (gclass30_0 => gclass30_0.Platform == Platform.Gamecube);
      Func<GClass30, bool> predicate;
      if (source.Any<GClass30>(predicate))
        GClass94.smethod_8(driveInfo_0);
      foreach (GClass30 gclass30 in ienumerable_0)
      {
        string str2 = gclass30.method_9(bool_0, driveInfo_0);
        if (str2 == "OK")
        {
          ++num;
          if (gclass30 is GClass32)
            (gclass30 as GClass32).Boolean_5 = true;
        }
        else
          str1 += string.Format("-{0} : {1} {2}", (object) gclass30, (object) str2, (object) Environment.NewLine);
      }
      string string_1 = str1 + string.Format("-{0} title(s) were copied successfully{1}", (object) num, (object) Environment.NewLine);
      if (!bool_1 || form_1 == null)
        return;
      Class97.smethod_5("Copy report", string_1, 10, true, (Image) null);
    }

    public static void smethod_5(string string_0, string string_1, int int_0, bool bool_0 = true, Image image_0 = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class97.Class98 class98 = new Class97.Class98();
      // ISSUE: reference to a compiler-generated field
      class98.string_0 = string_0;
      // ISSUE: reference to a compiler-generated field
      class98.string_1 = string_1;
      // ISSUE: reference to a compiler-generated field
      class98.image_0 = image_0;
      // ISSUE: reference to a compiler-generated field
      class98.int_0 = int_0;
      // ISSUE: reference to a compiler-generated field
      class98.bool_0 = bool_0;
      Form form0 = Class97.form_0;
      if (form0 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      form0.Invoke((Delegate) new MethodInvoker(class98.method_0));
    }

    public static Region smethod_6(Form form_1, int int_0 = 40)
    {
      return Region.FromHrgn(Class97.CreateRoundRectRgn(0, 0, form_1.Width, form_1.Height, int_0, int_0));
    }

    public static void smethod_7(GClass32 gclass32_0, GClass82 gclass82_0, Form form_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class97.Class100 class100 = new Class97.Class100();
      // ISSUE: reference to a compiler-generated field
      class100.gclass32_0 = gclass32_0;
      // ISSUE: reference to a compiler-generated field
      class100.gclass82_0 = gclass82_0;
      // ISSUE: reference to a compiler-generated field
      class100.form_0 = form_1;
      // ISSUE: reference to a compiler-generated field
      if (class100.gclass82_0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Class97.smethod_16(class100.form_0);
      }
      else
      {
        if (RadMessageBox.Show("USB Helper will now try to import your save from your Wii U to CEMU. This will OVERWRITE any save you already have on your computer AND on your USB Helper Cloud if enabled. Continue?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
        // ISSUE: reference to a compiler-generated field
        class100.string_0 = (string) null;
        // ISSUE: reference to a compiler-generated field
        class100.frmWait_0 = new FrmWait("Please wait while USB Helper downloads your save.", false);
        // ISSUE: reference to a compiler-generated method
        Task.Run(new Action(class100.method_0));
        // ISSUE: reference to a compiler-generated field
        int num = (int) class100.frmWait_0.ShowDialog();
        // ISSUE: reference to a compiler-generated field
        if (class100.string_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          Cemu cemu = class100.gclass32_0.method_14(false) as Cemu;
          string fileSaveLocation = cemu.FileSaveLocation;
          GClass6.smethod_5(fileSaveLocation);
          Directory.CreateDirectory(fileSaveLocation);
          // ISSUE: reference to a compiler-generated field
          using (FileStream fileStream = File.OpenRead(class100.string_0))
          {
            using (ZipArchive source = new ZipArchive((Stream) fileStream))
              source.ExtractToDirectory(fileSaveLocation);
          }
          string str = Path.Combine(fileSaveLocation, "user");
          if (Directory.Exists(str))
          {
            try
            {
              Directory.Move(((IEnumerable<DirectoryInfo>) new DirectoryInfo(str).GetDirectories()).First<DirectoryInfo>((Func<DirectoryInfo, bool>) (directoryInfo_0 => GClass6.smethod_4(directoryInfo_0.Name))).FullName, Path.Combine(str, "80000001"));
              if (Settings.Default.EnableCloudSaving)
                cemu.method_2(cemu.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
            }
            catch
            {
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Class97.smethod_15(class100.form_0, "Could not import your save.");
        }
        // ISSUE: reference to a compiler-generated field
        class100.frmWait_0.method_0();
      }
    }

    public static void smethod_8(string string_0, string string_1)
    {
      Process process = new Process();
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = "cmd.exe",
        Arguments = string.Format("/c move \"{0}\" \"{1}\"", (object) string_0, (object) string_1),
        UseShellExecute = true,
        Verb = "runas"
      };
      process.Start();
      process.WaitForExit();
    }

    public static void smethod_9(string string_0)
    {
      Process.Start("explorer.exe", string_0);
    }

    public static void smethod_10(object sender, EventArgs e)
    {
      PictureBox pictureBox = (PictureBox) sender;
      if (pictureBox.Image == null)
        return;
      int num = (int) new FrmImgPreview(pictureBox.Image).ShowDialog();
    }

    public static void smethod_11(RadForm radForm_0, int int_0 = 10)
    {
      radForm_0.FormElement.Shape = (ElementShape) new RoundRectShape(int_0);
    }

    public static bool smethod_12(bool bool_0)
    {
      CommonOpenFileDialog commonOpenFileDialog1 = new CommonOpenFileDialog();
      commonOpenFileDialog1.Title = "Please chose where to store extracted games.";
      commonOpenFileDialog1.IsFolderPicker = true;
      CommonOpenFileDialog commonOpenFileDialog2 = commonOpenFileDialog1;
      while (commonOpenFileDialog2.ShowDialog() != CommonFileDialogResult.Cancel)
      {
        if (GClass6.smethod_2(commonOpenFileDialog2.FileName))
        {
          Settings.Default.ExtractFolder = commonOpenFileDialog2.FileName;
          Settings.Default.Save();
          return true;
        }
      }
      return !bool_0;
    }

    public static bool smethod_13(bool bool_0)
    {
      int num = (int) RadMessageBox.Show("Please select a location to store your games. Note : it is not recommended to chose a location such as 'Program Files' since it requires Admin privileges.");
      CommonOpenFileDialog commonOpenFileDialog1 = new CommonOpenFileDialog();
      commonOpenFileDialog1.IsFolderPicker = true;
      commonOpenFileDialog1.Title = "Please chose where to store your games.";
      CommonOpenFileDialog commonOpenFileDialog2 = commonOpenFileDialog1;
      while (commonOpenFileDialog2.ShowDialog() != CommonFileDialogResult.Cancel)
      {
        if (GClass6.smethod_2(commonOpenFileDialog2.FileName))
        {
          DirectoryInfo directoryInfo = new DirectoryInfo(commonOpenFileDialog2.FileName);
          string str = commonOpenFileDialog2.FileName;
          if (directoryInfo.Name == "DATA" || directoryInfo.Name == "DATA_3DS")
            str = directoryInfo.Parent.FullName;
          Settings.Default.Path = str;
          Settings.Default.Save();
          return true;
        }
      }
      return !bool_0;
    }

    public static void smethod_14(Form form_1)
    {
      Class97.form_0 = form_1;
    }

    public static void smethod_15(Form form_1, string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class97.Class101 class101 = new Class97.Class101();
      // ISSUE: reference to a compiler-generated field
      class101.form_0 = form_1;
      // ISSUE: reference to a compiler-generated field
      class101.string_0 = string_0;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class101.form_0.Invoke((Delegate) new MethodInvoker(class101.method_0));
    }

    public static void smethod_16(Form form_1)
    {
      Class97.smethod_15(form_1, "In order to use this feature, you must have Wii U USB Transfer Tool currently running on your Wii U.\nPlease launch it and try again.");
    }

    public static void smethod_17(TimeSpan timeSpan_0, RadLabel radLabel_0)
    {
      radLabel_0.Text = timeSpan_0.TotalSeconds > 0.0 ? string.Format("ETA : {0}", (object) GClass6.smethod_12(timeSpan_0)) : "ETA : Acquiring data...";
    }

    public static void smethod_18()
    {
      try
      {
        string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Updater.exe");
        string str = new GClass78().method_6(string.Format("{0}/Updater.hash", (object) Class67.String_0));
        using (SHA256 shA256 = SHA256.Create())
        {
          if (File.Exists(path) && Convert.ToBase64String(shA256.ComputeHash(File.ReadAllBytes(path))) == str)
            return;
          byte[] numArray = new GClass78().method_2(string.Format("{0}/Updater.exe", (object) Class67.String_0));
          if (!(Convert.ToBase64String(shA256.ComputeHash(numArray)) == str))
            return;
          File.WriteAllBytes(path, numArray);
        }
      }
      catch
      {
      }
    }

    [DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);
  }
}
