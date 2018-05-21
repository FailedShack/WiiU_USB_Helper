// Decompiled with JetBrains decompiler
// Type: ns0.GClass131
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.Management;

namespace ns0
{
  public static class GClass131
  {
    private static int int_0;
    private static bool bool_0;

    public static event EventHandler Event_0;

    public static void smethod_0(Action<GClass132> action_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass131.Class115 class115 = new GClass131.Class115();
      // ISSUE: reference to a compiler-generated field
      class115.action_0 = action_0;
      // ISSUE: reference to a compiler-generated field
      class115.eventHandler_0 = (EventHandler) null;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      class115.eventHandler_0 = new EventHandler(class115.method_0);
      // ISSUE: reference to a compiler-generated field
      GClass131.Event_0 += class115.eventHandler_0;
    }

    public static List<GClass132> smethod_1()
    {
      List<GClass132> gclass132List = new List<GClass132>();
      try
      {
        new ManagementObjectSearcher((ObjectQuery) new WqlObjectQuery("SELECT * FROM Win32_DiskDrive")).Get();
        return gclass132List;
      }
      catch
      {
      }
      return gclass132List;
    }

    public static void smethod_2()
    {
      try
      {
        if (GClass131.bool_0)
          return;
        GClass131.bool_0 = true;
        ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher((EventQuery) new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 OR EventType = 3"));
        managementEventWatcher.EventArrived += (EventArrivedEventHandler) ((sender, e) =>
        {
          int count = GClass131.smethod_1().Count;
          if (count == GClass131.int_0)
            return;
          GClass131.int_0 = count;
          // ISSUE: reference to a compiler-generated field
          EventHandler eventHandler0 = GClass131.eventHandler_0;
          if (eventHandler0 == null)
            return;
          eventHandler0((object) null, (EventArgs) null);
        });
        managementEventWatcher.Start();
      }
      catch
      {
      }
    }
  }
}
