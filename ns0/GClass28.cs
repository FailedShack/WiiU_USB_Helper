// Decompiled with JetBrains decompiler
// Type: ns0.GClass28
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using NusHelper.Server;
using System;
using System.Collections.Generic;
using System.Net;

namespace ns0
{
  public static class GClass28
  {
    public static readonly Dictionary<TitleId, GClass32> dictionary_0 = new Dictionary<TitleId, GClass32>();
    public static List<GClass32> list_0 = new List<GClass32>();
    public static List<TitleId> list_1 = new List<TitleId>();
    public static bool bool_0 = false;
    public static bool bool_1 = true;
    public static List<GClass32> list_3 = new List<GClass32>();
    public static bool bool_2 = false;
    public static IPAddress ipaddress_0 = IPAddress.Parse("95.183.50.10");
    internal static readonly Dictionary<TitleId, GClass80.GStruct4> dictionary_1 = new Dictionary<TitleId, GClass80.GStruct4>();
    internal static readonly Dictionary<TitleId, DbRow> dictionary_2 = new Dictionary<TitleId, DbRow>();
    internal static readonly Dictionary<TitleId, List<GClass80.GStruct5>> dictionary_3 = new Dictionary<TitleId, List<GClass80.GStruct5>>();
    internal static readonly List<GClass31> list_6 = new List<GClass31>();
    public const string string_0 = "This software is brought to you, free of charge, by Hikari06 (aka Kazegaya). If you have paid any amount of money (except donations of course) to obtain it you have been SCAMMED. Please demand a refund immediately and report the seller. The only offical places to download this software are the post on gbatemp.net as well as the official site wiiuusbhelper.com.";
    public const string string_1 = "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/";
    public const string string_2 = "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/";
    public const string string_3 = "http://cdn.wiiuusbhelper.com/wiiu/download/";
    public static List<string> list_2;
    public static string string_4;
    public static GClass32 gclass32_0;
    internal static GClass30 gclass30_0;
    internal static string[] string_5;

    public static event EventHandler<Exception> Event_0;

    public static List<GClass32> NewTitles { get; internal set; } = new List<GClass32>();

    public static List<GClass33> NewUpdates { get; internal set; } = new List<GClass33>();

    internal static void smethod_0(Exception exception_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<Exception> eventHandler0 = GClass28.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) null, exception_0);
    }
  }
}
