// Decompiled with JetBrains decompiler
// Type: ns0.GClass132
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Cryptography;

namespace ns0
{
  public class GClass132
  {
    private readonly ManagementObject managementObject_0;

    public GClass132(ManagementObject managementObject_1)
    {
      this.managementObject_0 = managementObject_1;
    }

    public ulong UInt64_0
    {
      get
      {
        return ulong.Parse(this.managementObject_0.Properties["Size"].Value.ToString());
      }
    }

    public bool Boolean_0
    {
      get
      {
        if (File.Exists(this.String_1))
          return File.Exists(this.String_3);
        return false;
      }
    }

    public string String_0
    {
      get
      {
        return this.managementObject_0.Properties["Name"].Value.ToString();
      }
    }

    public string String_1
    {
      get
      {
        return Path.Combine(this.String_5, "otp.bin");
      }
    }

    public string String_2
    {
      get
      {
        return this.managementObject_0.Properties["PNPDeviceID"].Value.ToString();
      }
    }

    public string String_3
    {
      get
      {
        return Path.Combine(this.String_5, "seeprom.bin");
      }
    }

    public byte[] method_0()
    {
      if (!this.Boolean_0)
        throw new Exception("Disk is not installed");
      byte[] numArray = new byte[16];
      Buffer.BlockCopy((Array) File.ReadAllBytes(this.String_1), 304, (Array) numArray, 0, 16);
      byte[] inputBuffer = new byte[16];
      Buffer.BlockCopy((Array) File.ReadAllBytes(this.String_3), 176, (Array) inputBuffer, 0, 16);
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Key = numArray;
        cryptoServiceProvider.IV = new byte[16];
        cryptoServiceProvider.Mode = CipherMode.ECB;
        cryptoServiceProvider.Padding = PaddingMode.None;
        using (ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor())
          return encryptor.TransformFinalBlock(inputBuffer, 0, 16);
      }
    }

    public void method_1(string string_0, string string_1 = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass132.Class116 class116 = new GClass132.Class116();
      File.WriteAllBytes(GClass132.String_4, Class123.wfsdump);
      // ISSUE: reference to a compiler-generated field
      class116.frmWait_0 = new FrmWait("USB Helper is reading your disk...", false);
      Process process = new Process() { StartInfo = new ProcessStartInfo() { FileName = GClass132.String_4, UseShellExecute = true, Arguments = string.Format("--input {0} --output {1} --otp {2} --seeprom {3} --usb {4}", (object) this.String_0, (object) string_0, (object) this.String_1, (object) this.String_3, string_1 != null ? (object) ("--dump-path " + string_1) : (object) ""), Verb = "runas", CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden } };
      process.EnableRaisingEvents = true;
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class116.method_0);
      try
      {
        process.Start();
        // ISSUE: reference to a compiler-generated field
        int num = (int) class116.frmWait_0.ShowDialog();
      }
      catch
      {
      }
    }

    public void method_2(byte[] byte_0, byte[] byte_1)
    {
      Directory.CreateDirectory(this.String_5);
      File.WriteAllBytes(this.String_1, byte_0);
      File.WriteAllBytes(this.String_3, byte_1);
    }

    public void method_3()
    {
      GClass6.smethod_6(this.String_1);
      GClass6.smethod_6(this.String_3);
      try
      {
        GClass6.smethod_5(this.String_5);
      }
      catch
      {
      }
    }

    private static string String_4
    {
      get
      {
        return Path.Combine(GClass88.CachePath, "wfsdump.exe");
      }
    }

    private string String_5
    {
      get
      {
        return Path.Combine(GClass88.CachePath, this.String_6);
      }
    }

    private string String_6
    {
      get
      {
        return GClass88.smethod_8(this.String_2);
      }
    }
  }
}
