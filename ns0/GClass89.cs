// Decompiled with JetBrains decompiler
// Type: ns0.GClass89
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper.Server;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
  public static class GClass89
  {
    private const int int_0 = 3;
    private static GClass8 gclass8_0;
    private static bool bool_0;
    private static System.Windows.Forms.Timer timer_0;

    public static GClass8 GClass8_0
    {
      get
      {
        return GClass89.gclass8_0;
      }
      private set
      {
        GClass89.gclass8_0 = value;
        EventHandler eventHandler0 = GClass89.eventHandler_0;
        if (eventHandler0 == null)
          return;
        eventHandler0((object) null, (EventArgs) null);
      }
    }

    public static bool Boolean_0
    {
      get
      {
        return GClass89.GClass8_0 != null;
      }
    }

    public static event EventHandler Event_0;

    public static bool smethod_0(int int_1, string string_0, string string_1)
    {
      if (GClass89.timer_0 == null)
      {
        GClass89.timer_0 = new System.Windows.Forms.Timer()
        {
          Interval = 2000
        };
        GClass89.timer_0.Tick += (EventHandler) ((sender, e) =>
        {
          if (GClass89.bool_0)
            return;
          if (!Class108.Boolean_0)
            GClass89.GClass8_0 = (GClass8) null;
          else
            GClass89.GClass8_0 = new GClass8("Now mining...", "none", DateTime.Today.ToShortDateString());
        });
        GClass89.timer_0.Start();
      }
      Thread.Sleep(250);
      if (Class108.Boolean_0 || Class108.bool_0)
        return false;
      GClass89.smethod_1(string_0, string_1);
      if (GClass89.Boolean_0 || int_1 == 0)
        return false;
      if (int_1 != 1)
        return int_1 % 3 == 0;
      return true;
    }

    public static void smethod_1(string string_0, string string_1)
    {
      GClass89.GClass8_0 = (GClass8) null;
      GClass89.bool_0 = false;
      if (string_0 == null)
      {
        GClass89.GClass8_0 = (GClass8) null;
      }
      else
      {
        byte[] numArray;
        try
        {
          numArray = Convert.FromBase64String(string_0);
        }
        catch
        {
          GClass89.GClass8_0 = (GClass8) null;
          return;
        }
        if (numArray.Length != 272)
        {
          GClass89.GClass8_0 = (GClass8) null;
        }
        else
        {
          byte[] buffer = new byte[16];
          byte[] signature = new byte[256];
          Buffer.BlockCopy((Array) numArray, 0, (Array) buffer, 0, 16);
          Buffer.BlockCopy((Array) numArray, 16, (Array) signature, 0, 256);
          using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider())
          {
            cryptoServiceProvider.FromXmlString(string_1);
            GClass89.GClass8_0 = cryptoServiceProvider.VerifyData(buffer, (object) CryptoConfig.MapNameToOID("SHA1"), signature) ? GClass89.smethod_2(string_0) : (GClass8) null;
            GClass89.bool_0 = GClass89.Boolean_0;
            if (!GClass89.bool_0)
              return;
            Settings.Default.Mine = false;
            Settings.Default.Save();
            Class108.smethod_1();
          }
        }
      }
    }

    private static GClass8 smethod_2(string string_0)
    {
      try
      {
        KeyValidationResponse validationResponse = JsonConvert.DeserializeObject<KeyValidationResponse>(Encoding.UTF8.GetString(new WebClient().UploadValues(string.Format("{0}/verifyDonationKey.php", (object) Class67.String_3), new NameValueCollection()
        {
          {
            "key",
            string_0
          }
        })));
        if (validationResponse.Accepted)
          return new GClass8(validationResponse.Email, validationResponse.Key, validationResponse.DonationDate);
        int num = (int) RadMessageBox.Show(validationResponse.Message);
        Settings.Default.DonationKey = "";
        Settings.Default.Save();
        return (GClass8) null;
      }
      catch (Exception ex)
      {
        if (ex is WebException)
          return new GClass8("", "", "");
      }
      return (GClass8) null;
    }
  }
}
