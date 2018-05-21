// Decompiled with JetBrains decompiler
// Type: ns0.Class91
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using HelperChat;
using System;
using System.Threading.Tasks;
using WIIU_Downloader.Properties;

namespace ns0
{
  internal static class Class91
  {
    private static volatile bool bool_0 = false;
    private static object object_0 = new object();
    private static Client client_0;

    public static event EventHandler<Message> Event_0;

    public static void smethod_0()
    {
      Class91.smethod_7((Action<Client>) null, (Action) null);
    }

    public static void smethod_1()
    {
      Class91.smethod_6("APP", "NONE", "!FRWL");
      Client client0 = Class91.client_0;
      if (client0 == null)
        return;
      client0.DestroyClient();
    }

    public static string smethod_2()
    {
      if (!(Settings.Default.CloudUserName != ""))
        return "Anon-" + Settings.Default.AppId.Substring(0, 4);
      return Settings.Default.CloudUserName;
    }

    public static void smethod_3(string string_0, string string_1)
    {
      if (string_1 != null)
        Class91.smethod_6("APP", string_1, "!GBYE");
      if (string_0 == null)
        return;
      Class91.smethod_6("APP", string_0, "!HELO");
      Class91.smethod_5(string_0);
    }

    public static bool smethod_4(string string_0)
    {
      return Class91.smethod_2() == string_0;
    }

    public static void smethod_5(string string_0)
    {
      Class91.smethod_6("APP", string_0, "!CONT");
    }

    public static void smethod_6(string string_0, string string_1, string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class91.Class92 class92 = new Class91.Class92();
      // ISSUE: reference to a compiler-generated field
      class92.string_0 = string_1;
      // ISSUE: reference to a compiler-generated field
      class92.string_1 = string_0;
      // ISSUE: reference to a compiler-generated field
      class92.string_2 = string_2;
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (string.IsNullOrEmpty(class92.string_1) || string.IsNullOrEmpty(class92.string_0) || string.IsNullOrEmpty(class92.string_2))
          return;
        // ISSUE: reference to a compiler-generated method
        Class91.smethod_7(new Action<Client>(class92.method_0), (Action) (() => {}));
      }
      catch
      {
      }
    }

    private static void smethod_7(Action<Client> action_0, Action action_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class91.Class93 class93 = new Class91.Class93();
      // ISSUE: reference to a compiler-generated field
      class93.action_0 = action_0;
      // ISSUE: reference to a compiler-generated field
      class93.action_1 = action_1;
      if (Class91.client_0 != null && !Class91.client_0.Destroyed)
      {
        Class91.bool_0 = true;
        // ISSUE: reference to a compiler-generated field
        Action<Client> action0 = class93.action_0;
        if (action0 == null)
          return;
        action0(Class91.client_0);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        Task.Run(new Action(class93.method_0));
      }
    }
  }
}
