// Decompiled with JetBrains decompiler
// Type: ns0.GClass1
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Management;

namespace ns0
{
  public static class GClass1
  {
    public static string smethod_0()
    {
      ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
      string empty = string.Empty;
      using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
      {
        if (enumerator.MoveNext())
          empty = enumerator.Current.Properties["processorID"].Value.ToString();
      }
      return empty;
    }

    public static string smethod_1()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
      string str = "";
      foreach (ManagementObject managementObject in instances)
        str += Convert.ToString(managementObject["VolumeSerialNumber"]);
      return str;
    }

    public static string smethod_2()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
      string empty = string.Empty;
      foreach (ManagementObject managementObject in instances)
      {
        if (empty == string.Empty && (bool) managementObject["IPEnabled"])
          empty = managementObject["MacAddress"].ToString();
        managementObject.Dispose();
      }
      return empty.Replace(":", "");
    }

    public static string smethod_3()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Manufacturer").ToString();
        }
        catch
        {
        }
      }
      return "Board Maker: Unknown";
    }

    public static string smethod_4()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Product").ToString();
        }
        catch
        {
        }
      }
      return "Product: Unknown";
    }

    public static string smethod_5()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Drive").ToString();
        }
        catch
        {
        }
      }
      return "CD ROM Drive Letter: Unknown";
    }

    public static string smethod_6()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Manufacturer").ToString();
        }
        catch
        {
        }
      }
      return "BIOS Maker: Unknown";
    }

    public static string smethod_7()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("SerialNumber").ToString();
        }
        catch
        {
        }
      }
      return "BIOS Serial Number: Unknown";
    }

    public static string smethod_8()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Caption").ToString();
        }
        catch
        {
        }
      }
      return "BIOS Caption: Unknown";
    }

    public static string smethod_9()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("Name").ToString();
        }
        catch
        {
        }
      }
      return "User Account Name: Unknown";
    }

    public static string smethod_10()
    {
      ManagementObjectCollection objectCollection = new ManagementObjectSearcher(new ManagementScope(), new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory")).Get();
      long num = 0;
      foreach (ManagementBaseObject managementBaseObject in objectCollection)
      {
        long int64 = Convert.ToInt64(managementBaseObject["Capacity"]);
        num += int64;
      }
      return (num / 1024L / 1024L).ToString() + "MB";
    }

    public static string smethod_11()
    {
      int num = 0;
      foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ManagementScope(), new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray")).Get())
        num = Convert.ToInt32(managementBaseObject["MemoryDevices"]);
      return num.ToString();
    }

    public static string smethod_12()
    {
      string empty = string.Empty;
      foreach (ManagementObject instance in new ManagementClass("Win32_Processor").GetInstances())
      {
        if (empty == string.Empty)
          empty = instance.Properties["Manufacturer"].Value.ToString();
      }
      return empty;
    }

    public static int smethod_13()
    {
      int num = 0;
      foreach (ManagementObject instance in new ManagementClass("Win32_Processor").GetInstances())
      {
        if (num == 0)
          num = Convert.ToInt32(instance.Properties["CurrentClockSpeed"].Value.ToString());
      }
      return num;
    }

    public static string smethod_14()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
      string empty = string.Empty;
      foreach (ManagementObject managementObject in instances)
      {
        if (empty == string.Empty && (bool) managementObject["IPEnabled"])
          empty = managementObject["DefaultIPGateway"].ToString();
        managementObject.Dispose();
      }
      return empty.Replace(":", "");
    }

    public static double? smethod_15()
    {
      double? nullable = new double?();
      using (ManagementClass managementClass = new ManagementClass("Win32_Processor"))
      {
        using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementClass.GetInstances().GetEnumerator())
        {
          if (enumerator.MoveNext())
            nullable = new double?(0.001 * (double) (uint) enumerator.Current.Properties["CurrentClockSpeed"].Value);
        }
      }
      return nullable;
    }

    public static string smethod_16()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
      {
        try
        {
          return managementObject.GetPropertyValue("CurrentLanguage").ToString();
        }
        catch
        {
        }
      }
      return "BIOS Maker: Unknown";
    }

    public static string smethod_17()
    {
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
      {
        try
        {
          return ((string) managementObject["Caption"]).Trim() + ", " + (string) managementObject["Version"] + ", " + (string) managementObject["OSArchitecture"];
        }
        catch
        {
        }
      }
      return "BIOS Maker: Unknown";
    }

    public static string smethod_18()
    {
      ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
      string str = string.Empty;
      foreach (ManagementObject managementObject in instances)
        str = ((string) managementObject["Name"]).Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ") + ", " + (string) managementObject["Caption"] + ", " + (string) managementObject["SocketDesignation"];
      return str;
    }

    public static string smethod_19()
    {
      ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
      string empty = string.Empty;
      foreach (ManagementBaseObject managementBaseObject in instances)
        empty = (string) managementBaseObject["Name"];
      return empty;
    }
  }
}
