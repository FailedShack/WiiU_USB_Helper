using System;
using System.Management;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	public static class GClass1
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00019A78 File Offset: 0x00017C78
		public static string smethod_0()
		{
			ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					result = ((ManagementObject)enumerator.Current).Properties["processorID"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00019AEC File Offset: 0x00017CEC
		public static string smethod_1()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				text += Convert.ToString(managementObject["VolumeSerialNumber"]);
			}
			return text;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00019B60 File Offset: 0x00017D60
		public static string smethod_2()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == string.Empty && (bool)managementObject["IPEnabled"])
				{
					text = managementObject["MacAddress"].ToString();
				}
				managementObject.Dispose();
			}
			text = text.Replace(":", "");
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00019C04 File Offset: 0x00017E04
		public static string smethod_3()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x06000008 RID: 8 RVA: 0x00019C88 File Offset: 0x00017E88
		public static string smethod_4()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x06000009 RID: 9 RVA: 0x00019D0C File Offset: 0x00017F0C
		public static string smethod_5()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x0600000A RID: 10 RVA: 0x00019D90 File Offset: 0x00017F90
		public static string smethod_6()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x0600000B RID: 11 RVA: 0x00019E14 File Offset: 0x00018014
		public static string smethod_7()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x0600000C RID: 12 RVA: 0x00019E98 File Offset: 0x00018098
		public static string smethod_8()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x0600000D RID: 13 RVA: 0x00019F1C File Offset: 0x0001811C
		public static string smethod_9()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x0600000E RID: 14 RVA: 0x00019FA0 File Offset: 0x000181A0
		public static string smethod_10()
		{
			ManagementScope scope = new ManagementScope();
			ObjectQuery query = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(scope, query).Get();
			long num = 0L;
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				long num2 = Convert.ToInt64(((ManagementObject)managementBaseObject)["Capacity"]);
				num += num2;
			}
			num = num / 1024L / 1024L;
			return num.ToString() + "MB";
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0001A03C File Offset: 0x0001823C
		public static string smethod_11()
		{
			int num = 0;
			ManagementScope scope = new ManagementScope();
			ObjectQuery query = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(scope, query).Get())
			{
				num = Convert.ToInt32(((ManagementObject)managementBaseObject)["MemoryDevices"]);
			}
			return num.ToString();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0001A0B8 File Offset: 0x000182B8
		public static string smethod_12()
		{
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass("Win32_Processor").GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == string.Empty)
				{
					text = managementObject.Properties["Manufacturer"].Value.ToString();
				}
			}
			return text;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0001A13C File Offset: 0x0001833C
		public static int smethod_13()
		{
			int num = 0;
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass("Win32_Processor").GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (num == 0)
				{
					num = Convert.ToInt32(managementObject.Properties["CurrentClockSpeed"].Value.ToString());
				}
			}
			return num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0001A1B8 File Offset: 0x000183B8
		public static string smethod_14()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
			string text = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == string.Empty && (bool)managementObject["IPEnabled"])
				{
					text = managementObject["DefaultIPGateway"].ToString();
				}
				managementObject.Dispose();
			}
			text = text.Replace(":", "");
			return text;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0001A25C File Offset: 0x0001845C
		public static double? smethod_15()
		{
			double? result = null;
			using (ManagementClass managementClass = new ManagementClass("Win32_Processor"))
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementClass.GetInstances().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						result = new double?(0.001 * (uint)managementObject.Properties["CurrentClockSpeed"].Value);
					}
				}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0001A300 File Offset: 0x00018500
		public static string smethod_16()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
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

		// Token: 0x06000015 RID: 21 RVA: 0x0001A384 File Offset: 0x00018584
		public static string smethod_17()
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				try
				{
					return string.Concat(new string[]
					{
						((string)managementObject["Caption"]).Trim(),
						", ",
						(string)managementObject["Version"],
						", ",
						(string)managementObject["OSArchitecture"]
					});
				}
				catch
				{
				}
			}
			return "BIOS Maker: Unknown";
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0001A44C File Offset: 0x0001864C
		public static string smethod_18()
		{
			ManagementObjectCollection instances = new ManagementClass("win32_processor").GetInstances();
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				string text = (string)managementObject["Name"];
				text = text.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");
				result = string.Concat(new string[]
				{
					text,
					", ",
					(string)managementObject["Caption"],
					", ",
					(string)managementObject["SocketDesignation"]
				});
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0001A580 File Offset: 0x00018780
		public static string smethod_19()
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				result = (string)((ManagementObject)managementBaseObject)["Name"];
			}
			return result;
		}
	}
}
