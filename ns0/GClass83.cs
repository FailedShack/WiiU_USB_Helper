// Decompiled with JetBrains decompiler
// Type: ns0.GClass83
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ns0
{
  public sealed class GClass83
  {
    private readonly UdpClient udpClient_0 = new UdpClient(14521);
    private volatile bool bool_0 = true;
    private const string string_0 = "HELLO FROM WIIU!";

    public event EventHandler<GClass82> Event_0;

    public static List<GClass32> smethod_0(GClass82 gclass82_0)
    {
      List<GClass32> gclass32List = new List<GClass32>();
      try
      {
        foreach (string str in new Class60(gclass82_0.IPAddress_0.ToString(), "", "").method_4("/storage_usb/usr/title/00050000"))
        {
          if (str.Length == 8)
          {
            TitleId key = new TitleId("00050000" + str);
            if (GClass28.dictionary_0.ContainsKey(key))
              gclass32List.Add(GClass28.dictionary_0[key]);
          }
        }
      }
      catch
      {
      }
      return gclass32List;
    }

    public static int smethod_1(GClass82 gclass82_0, GClass30 gclass30_0)
    {
      try
      {
        byte[] bytes = new Class60(gclass82_0.IPAddress_0.ToString(), "", "").method_7(string.Format("/storage_usb/usr/title/0005000e/{0}/meta/meta.xml", (object) gclass30_0.TitleId.High.ToLower()));
        XmlDocument xmlDocument = new XmlDocument();
        string xml = Encoding.UTF8.GetString(bytes).Trim('\xFEFF');
        xmlDocument.LoadXml(xml);
        return int.Parse(xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value);
      }
      catch
      {
        return -1;
      }
    }

    public void method_0(bool bool_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(new GClass83.Class65()
      {
        gclass83_0 = this,
        bool_0 = bool_1
      }.method_0));
    }

    public void method_1()
    {
      this.bool_0 = false;
      this.udpClient_0.Close();
    }

    private void method_2(IPAddress ipaddress_0, int int_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<GClass82> eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, new GClass82()
      {
        IPAddress_0 = ipaddress_0,
        TransferVersion = int_0
      });
    }
  }
}
