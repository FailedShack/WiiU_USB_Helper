using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x020000A7 RID: 167
	internal class Class58
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00027580 File Offset: 0x00025780
		public Class58(string string_4, string string_5, string string_6)
		{
			this.string_1 = string_4;
			this.string_0 = "ftp://" + string_4;
			this.string_3 = string_5;
			this.string_2 = string_6;
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000434 RID: 1076 RVA: 0x000275D8 File Offset: 0x000257D8
		// (remove) Token: 0x06000435 RID: 1077 RVA: 0x00027610 File Offset: 0x00025810
		public event EventHandler<long> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<long> eventHandler = this.eventHandler_0;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<long> eventHandler = this.eventHandler_0;
				EventHandler<long> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<long> value2 = (EventHandler<long>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<long>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000436 RID: 1078 RVA: 0x00027648 File Offset: 0x00025848
		// (remove) Token: 0x06000437 RID: 1079 RVA: 0x00027680 File Offset: 0x00025880
		public event EventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00012DF3 File Offset: 0x00010FF3
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00012DFB File Offset: 0x00010FFB
		public GClass81 TransferStatus { get; private set; } = new GClass81("Upload complete!", false, GEnum5.const_6);

		// Token: 0x0600043A RID: 1082 RVA: 0x00012E04 File Offset: 0x00011004
		public void method_0()
		{
			this.TransferStatus = new GClass81("Upload aborted.", true, GEnum5.const_2);
			this.bool_1 = true;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000276B8 File Offset: 0x000258B8
		public bool method_1()
		{
			bool result = true;
			try
			{
				this.ftpWebRequest_0 = this.method_16("/", "NLST");
				this.ftpWebRequest_0.Timeout = 10000;
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
			}
			catch (Exception)
			{
				result = false;
			}
			try
			{
				FtpWebResponse ftpWebResponse = this.ftpWebResponse_0;
				if (ftpWebResponse != null)
				{
					ftpWebResponse.Close();
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00027740 File Offset: 0x00025940
		public void method_2(string string_4)
		{
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_4, "MKD");
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
				this.ftpWebResponse_0.Close();
				this.ftpWebRequest_0 = null;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000277A8 File Offset: 0x000259A8
		public void method_3(string string_4)
		{
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_4, "DELE");
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
				this.ftpWebResponse_0.Close();
				this.ftpWebRequest_0 = null;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00027810 File Offset: 0x00025A10
		public List<string> method_4(string string_4)
		{
			List<string> list = new List<string>();
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_4, "NLST");
				using (this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse())
				{
					using (this.stream_0 = this.ftpWebResponse_0.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(this.stream_0))
						{
							try
							{
								list.AddRange(streamReader.ReadToEnd().Split(new string[]
								{
									Environment.NewLine
								}, StringSplitOptions.RemoveEmptyEntries));
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.ToString());
							}
						}
					}
				}
				this.ftpWebRequest_0 = null;
				return list;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return list;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00027924 File Offset: 0x00025B24
		public void method_5(string string_4, string string_5)
		{
			using (FileStream fileStream = File.Create(string_5))
			{
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create))
				{
					this.method_8(string_4, zipArchive, "");
				}
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00027980 File Offset: 0x00025B80
		public void method_6(string string_4, string string_5)
		{
			this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
			using (FtpWebResponse ftpWebResponse = (FtpWebResponse)this.ftpWebRequest_0.GetResponse())
			{
				using (Stream responseStream = ftpWebResponse.GetResponseStream())
				{
					using (FileStream fileStream = new FileStream(string_5, FileMode.Create))
					{
						byte[] buffer = new byte[this.int_1];
						int i = responseStream.Read(buffer, 0, this.int_1);
						try
						{
							while (i > 0)
							{
								fileStream.Write(buffer, 0, i);
								i = responseStream.Read(buffer, 0, this.int_1);
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
				}
			}
			this.ftpWebRequest_0 = null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00027A64 File Offset: 0x00025C64
		public byte[] method_7(string string_4)
		{
			this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
			byte[] result;
			using (FtpWebResponse ftpWebResponse = (FtpWebResponse)this.ftpWebRequest_0.GetResponse())
			{
				using (Stream responseStream = ftpWebResponse.GetResponseStream())
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						byte[] buffer = new byte[this.int_1];
						int i = responseStream.Read(buffer, 0, this.int_1);
						try
						{
							while (i > 0)
							{
								memoryStream.Write(buffer, 0, i);
								i = responseStream.Read(buffer, 0, this.int_1);
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00027B4C File Offset: 0x00025D4C
		public void method_8(string string_4, ZipArchive zipArchive_0, string string_5)
		{
			foreach (string text in this.method_4(string_4))
			{
				string string_6 = Path.Combine(string_5, text);
				if (Class58.smethod_1(text))
				{
					this.method_8(Path.Combine(string_4, text) + "/", zipArchive_0, string_6);
				}
				else
				{
					this.method_17(Path.Combine(string_4, text), zipArchive_0, string_6);
				}
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00027BD4 File Offset: 0x00025DD4
		public string method_9(string string_4)
		{
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_4, "MDTM");
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
				this.stream_0 = this.ftpWebResponse_0.GetResponseStream();
				StreamReader streamReader = new StreamReader(this.stream_0);
				string result = null;
				try
				{
					result = streamReader.ReadToEnd();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
				streamReader.Close();
				this.stream_0.Close();
				this.ftpWebResponse_0.Close();
				this.ftpWebRequest_0 = null;
				return result;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return "";
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00027C94 File Offset: 0x00025E94
		public string method_10(string string_4)
		{
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_4, "SIZE");
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
				this.stream_0 = this.ftpWebResponse_0.GetResponseStream();
				StreamReader streamReader = new StreamReader(this.stream_0);
				string result = null;
				try
				{
					while (streamReader.Peek() != -1)
					{
						result = streamReader.ReadToEnd();
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
				streamReader.Close();
				this.stream_0.Close();
				this.ftpWebResponse_0.Close();
				this.ftpWebRequest_0 = null;
				return result;
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			return "";
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00027D60 File Offset: 0x00025F60
		public void method_11(string string_4, string string_5)
		{
			try
			{
				this.ftpWebRequest_0 = this.method_16(string_5, "RENAME");
				this.ftpWebRequest_0.RenameTo = string_5;
				this.ftpWebResponse_0 = (FtpWebResponse)this.ftpWebRequest_0.GetResponse();
				this.ftpWebResponse_0.Close();
				this.ftpWebRequest_0 = null;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00027DD4 File Offset: 0x00025FD4
		public void method_12(string string_4)
		{
			try
			{
				Class58.smethod_2(this.string_1, 21, this.string_3, this.string_2, "INST install/" + string_4);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00027E24 File Offset: 0x00026024
		public void method_13(bool bool_2)
		{
			try
			{
				Class58.smethod_2(this.string_1, 21, this.string_3, this.string_2, "REMO " + (bool_2 ? "Y" : "N"));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00012E21 File Offset: 0x00011021
		public void method_14(string string_4, string string_5)
		{
			Class58.Class59 @class = new Class58.Class59();
			@class.class58_0 = this;
			@class.string_0 = string_4;
			@class.string_1 = string_5;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00027E84 File Offset: 0x00026084
		public void method_15(string string_4, ZipArchive zipArchive_0)
		{
			this.method_2(string_4);
			List<string> list = new List<string>();
			foreach (ZipArchiveEntry zipArchiveEntry in zipArchive_0.Entries)
			{
				string directoryName = Path.GetDirectoryName(zipArchiveEntry.FullName);
				if (!list.Contains(directoryName))
				{
					list.Add(directoryName);
					string[] array = directoryName.Split(new char[]
					{
						'\\'
					});
					string text = string_4;
					foreach (string str in array)
					{
						text = text + "/" + str;
						this.method_2(text);
					}
				}
			}
			foreach (ZipArchiveEntry zipArchiveEntry2 in zipArchive_0.Entries)
			{
				if (!(zipArchiveEntry2.FullName == "meta.json"))
				{
					string string_5 = Path.Combine(string_4, zipArchiveEntry2.FullName.Replace("\\", "/"));
					if (!Class58.smethod_1(string_5))
					{
						this.method_19(string_5, zipArchiveEntry2);
					}
				}
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00027FB4 File Offset: 0x000261B4
		private static void smethod_0(TcpClient tcpClient_0)
		{
			try
			{
				NetworkStream stream = tcpClient_0.GetStream();
				if (stream.CanWrite & stream.CanRead)
				{
					byte[] array = new byte[tcpClient_0.ReceiveBufferSize + 1];
					stream.ReadTimeout = 10000;
					stream.Read(array, 0, Convert.ToInt32(tcpClient_0.ReceiveBufferSize));
					Encoding.ASCII.GetString(array);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00012E4E File Offset: 0x0001104E
		private static bool smethod_1(string string_4)
		{
			return Path.GetExtension(string_4) == string.Empty;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00028028 File Offset: 0x00026228
		private static bool smethod_2(string string_4, int int_2, string string_5, string string_6, string string_7)
		{
			bool result = false;
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(string_4, int_2);
				Class58.smethod_0(tcpClient);
				if (Class58.smethod_3(tcpClient, "user " + string_5).Contains("331") && Class58.smethod_3(tcpClient, "pass " + string_6).Contains("230") && Class58.smethod_3(tcpClient, string_7).Contains("200"))
				{
					result = true;
				}
				tcpClient.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("TransmitCommand exception: " + ex.Message);
			}
			return result;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000280CC File Offset: 0x000262CC
		private static string smethod_3(TcpClient tcpClient_0, string string_4)
		{
			string result = "";
			try
			{
				NetworkStream stream = tcpClient_0.GetStream();
				if (stream.CanWrite & stream.CanRead)
				{
					byte[] bytes = Encoding.ASCII.GetBytes(string_4 + Environment.NewLine);
					stream.Write(bytes, 0, bytes.Length);
					result = new StreamReader(stream).ReadLine();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("TransmitCommand exception: " + ex.Message);
			}
			return result;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00028150 File Offset: 0x00026350
		private FtpWebRequest method_16(string string_4, string string_5)
		{
			this.ftpWebRequest_0 = (FtpWebRequest)WebRequest.Create(this.string_0 + "/" + string_4);
			this.ftpWebRequest_0.Credentials = new NetworkCredential(this.string_3, this.string_2);
			this.ftpWebRequest_0.UseBinary = true;
			this.ftpWebRequest_0.UsePassive = true;
			this.ftpWebRequest_0.KeepAlive = true;
			this.ftpWebRequest_0.Method = string_5;
			this.ftpWebRequest_0.Timeout = 10000;
			return this.ftpWebRequest_0;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000281E0 File Offset: 0x000263E0
		private void method_17(string string_4, ZipArchive zipArchive_0, string string_5)
		{
			this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
			using (FtpWebResponse ftpWebResponse = (FtpWebResponse)this.ftpWebRequest_0.GetResponse())
			{
				using (Stream responseStream = ftpWebResponse.GetResponseStream())
				{
					using (Stream stream = zipArchive_0.CreateEntry(string_5).Open())
					{
						byte[] buffer = new byte[this.int_1];
						int i = responseStream.Read(buffer, 0, this.int_1);
						try
						{
							while (i > 0)
							{
								stream.Write(buffer, 0, i);
								i = responseStream.Read(buffer, 0, this.int_1);
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}
					}
				}
			}
			this.ftpWebRequest_0 = null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00012E60 File Offset: 0x00011060
		private void method_18(long long_0)
		{
			EventHandler<long> eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, long_0);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000282CC File Offset: 0x000264CC
		private void method_19(string string_4, ZipArchiveEntry zipArchiveEntry_0)
		{
			this.ftpWebRequest_0 = this.method_16(string_4, "STOR");
			using (Stream requestStream = this.ftpWebRequest_0.GetRequestStream())
			{
				using (Stream stream = zipArchiveEntry_0.Open())
				{
					byte[] buffer = new byte[this.int_1];
					int num = stream.Read(buffer, 0, this.int_1);
					try
					{
						while (num != 0 && !this.bool_1)
						{
							requestStream.Write(buffer, 0, num);
							num = stream.Read(buffer, 0, this.int_1);
							this.method_18((long)num);
						}
					}
					catch (Exception ex)
					{
						if (!(ex is DivideByZeroException))
						{
							this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
						}
					}
				}
			}
			this.ftpWebRequest_0 = null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000283B0 File Offset: 0x000265B0
		private void method_20(string string_4, string string_5)
		{
			this.ftpWebRequest_0 = this.method_16(string_4, "STOR");
			using (Stream requestStream = this.ftpWebRequest_0.GetRequestStream())
			{
				using (FileStream fileStream = new FileStream(string_5, FileMode.Open))
				{
					byte[] buffer = new byte[this.int_1];
					int num = fileStream.Read(buffer, 0, this.int_1);
					try
					{
						while (num != 0 && !this.bool_1)
						{
							requestStream.Write(buffer, 0, num);
							num = fileStream.Read(buffer, 0, this.int_1);
							this.method_18((long)num);
						}
					}
					catch (Exception ex)
					{
						if (!(ex is DivideByZeroException))
						{
							this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
						}
					}
				}
			}
			this.ftpWebRequest_0 = null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00028494 File Offset: 0x00026694
		private void method_21(string string_4, string string_5)
		{
			FileInfo[] files = new DirectoryInfo(string_5).GetFiles();
			int i = 0;
			IL_0E:
			while (i < files.Length)
			{
				FileInfo fileInfo = files[i];
				Thread.Sleep(125);
				int j = 1;
				if (this.bool_1)
				{
					break;
				}
				if (this.TransferStatus.Error)
				{
					break;
				}
				while (j < 5)
				{
					try
					{
						this.method_20(Path.Combine(string_4, fileInfo.Name), fileInfo.FullName);
						j = 5;
						continue;
					}
					catch (Exception ex)
					{
						j++;
						if (j >= 5)
						{
							this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
						}
						continue;
					}
					IL_77:
					i++;
					goto IL_0E;
				}
				goto IL_77;
			}
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x0400029B RID: 667
		public static volatile bool bool_0;

		// Token: 0x0400029C RID: 668
		[CompilerGenerated]
		private EventHandler<long> eventHandler_0;

		// Token: 0x0400029D RID: 669
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private GClass81 gclass81_0;

		// Token: 0x0400029F RID: 671
		private const int int_0 = 5;

		// Token: 0x040002A0 RID: 672
		private readonly int int_1 = 131072;

		// Token: 0x040002A1 RID: 673
		private readonly string string_0;

		// Token: 0x040002A2 RID: 674
		private readonly string string_1;

		// Token: 0x040002A3 RID: 675
		private readonly string string_2;

		// Token: 0x040002A4 RID: 676
		private readonly string string_3;

		// Token: 0x040002A5 RID: 677
		private volatile bool bool_1;

		// Token: 0x040002A6 RID: 678
		private FtpWebRequest ftpWebRequest_0;

		// Token: 0x040002A7 RID: 679
		private FtpWebResponse ftpWebResponse_0;

		// Token: 0x040002A8 RID: 680
		private Stream stream_0;

		// Token: 0x020000A8 RID: 168
		[CompilerGenerated]
		private sealed class Class59
		{
			// Token: 0x06000455 RID: 1109 RVA: 0x00012E74 File Offset: 0x00011074
			internal void method_0()
			{
				this.class58_0.method_21(this.string_0, this.string_1);
			}

			// Token: 0x040002A9 RID: 681
			public Class58 class58_0;

			// Token: 0x040002AA RID: 682
			public string string_0;

			// Token: 0x040002AB RID: 683
			public string string_1;
		}
	}
}
