using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
using DokanNet;
using DokanNet.Logging;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x0200002E RID: 46
	internal class Class15 : IDokanOperations
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0001E874 File Offset: 0x0001CA74
		public Class15(string string_1, GClass30 gclass30_1)
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
			if (gclass30_1.System != GEnum3.const_1)
			{
				throw new ArgumentException("Only wup titles are compatible");
			}
			this.string_0 = string_1;
			Directory.CreateDirectory(this.string_0);
			this.gclass30_0 = gclass30_1;
			this.gclass95_0 = this.gclass30_0.method_14(false);
			this.gclass95_0.Boolean_1 = true;
			try
			{
				this.list_0 = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(this.String_0));
			}
			catch
			{
				this.list_0 = new List<string>();
			}
			this.gclass13_0 = gclass30_1.method_15();
			this.class7_0 = new Class7(this.gclass30_0);
			foreach (GClass12 gclass12_ in this.gclass13_0.Files)
			{
				this.method_0(gclass12_);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001E9A4 File Offset: 0x0001CBA4
		private bool method_0(GClass12 gclass12_0)
		{
			string text = "\\" + gclass12_0.string_0;
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			string text2 = text;
			string[] array = text.Split(new char[]
			{
				'\\'
			});
			string[] array2 = text2.Split(new char[]
			{
				'\\'
			});
			for (int i = 0; i < array.Length; i++)
			{
				Class15.Class16 @class = new Class15.Class16();
				if (Path.GetExtension(array[i]) != string.Empty)
				{
					break;
				}
				string text3 = string.Join("\\", array, 0, i + 1);
				if (i == 0)
				{
					text3 = "\\" + text3;
				}
				text3 = text3.ToUpper();
				if (!this.dictionary_1.ContainsKey(text3))
				{
					this.dictionary_1.Add(text3, new List<Class14>());
				}
				if (i >= 0 && i < array.Length - 1)
				{
					bool flag = Path.GetExtension(array[i + 1]) == string.Empty;
					List<Class14> list = this.dictionary_1[text3];
					@class.fileInformation_0 = new FileInformation
					{
						Attributes = (flag ? (FileAttributes.ReadOnly | FileAttributes.Directory) : FileAttributes.ReadOnly),
						CreationTime = new DateTime?(DateTime.Now),
						LastAccessTime = new DateTime?(DateTime.Now),
						LastWriteTime = new DateTime?(DateTime.Now),
						Length = (long)((ulong)(flag ? 0u : gclass12_0.uint_2)),
						FileName = array2[i + 1]
					};
					if (list.All(new Func<Class14, bool>(@class.method_0)))
					{
						list.Add(new Class14
						{
							fileInformation_0 = @class.fileInformation_0,
							gclass12_0 = gclass12_0
						});
					}
				}
			}
			return true;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0001118A File Offset: 0x0000F38A
		private string String_0
		{
			get
			{
				return Path.Combine(this.gclass95_0.CurrentGamePath, "optimized.helper");
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000111A1 File Offset: 0x0000F3A1
		public void method_1()
		{
			File.WriteAllText(this.String_0, JsonConvert.SerializeObject(this.list_0));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000111B9 File Offset: 0x0000F3B9
		public void Cleanup(string fileName, DokanFileInfo info)
		{
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			this.method_5("Cleanup", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001EB60 File Offset: 0x0001CD60
		private Stream method_2(string string_1, string string_2, FileMode fileMode_0, System.IO.FileAccess fileAccess_2, FileShare fileShare_0, int int_0, FileOptions fileOptions_0)
		{
			if (!this.list_0.Contains(string_2))
			{
				this.list_0.Add(string_2);
			}
			if (this.dictionary_0 != null)
			{
				Dictionary<string, ulong> obj = this.dictionary_0;
				lock (obj)
				{
					if (!this.dictionary_0.ContainsKey(string_2))
					{
						this.dictionary_0.Add(string_2, 0UL);
					}
					Dictionary<string, ulong> dictionary = this.dictionary_0;
					ulong num = dictionary[string_2];
					dictionary[string_2] = num + 1UL;
				}
			}
			return new FileStream(string_1, fileMode_0, fileAccess_2, fileShare_0, int_0, fileOptions_0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000111EE File Offset: 0x0000F3EE
		private string method_3(string string_1)
		{
			return this.string_0 + string_1;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000111FC File Offset: 0x0000F3FC
		private bool method_4(string string_1)
		{
			return Directory.Exists(string_1) || File.Exists(string_1);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001120E File Offset: 0x0000F40E
		private NtStatus method_5(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_1)
		{
			return ntStatus_0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00011212 File Offset: 0x0000F412
		private NtStatus method_6(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
		{
			return ntStatus_0;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00011216 File Offset: 0x0000F416
		public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_10(fileName, "*");
			return this.method_5("FindFiles", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001EC04 File Offset: 0x0001CE04
		public NtStatus method_7(string string_1, IntPtr intptr_0, out string string_2, out long long_0, DokanFileInfo dokanFileInfo_0)
		{
			string_2 = string.Empty;
			long_0 = 0L;
			return this.method_5("FindStreams", string_1, dokanFileInfo_0, (NtStatus)((ulong)-1073741822), new object[]
			{
				intptr_0.ToString(),
				"out " + string_2,
				"out " + long_0.ToString()
			});
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001123B File Offset: 0x0000F43B
		public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
		{
			streams = new FileInformation[0];
			return this.method_5("FindStreams", fileName, info, (NtStatus)((ulong)-1073741822), new object[0]);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00011266 File Offset: 0x0000F466
		public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
		{
			bytesWritten = 0;
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00011271 File Offset: 0x0000F471
		public NtStatus DeleteFile(string fileName, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741535);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00011271 File Offset: 0x0000F471
		public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741535);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001125E File Offset: 0x0000F45E
		public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
		{
			return (NtStatus)((ulong)-1073741790);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001EC64 File Offset: 0x0001CE64
		public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).SetLength(length);
				result = this.method_5("SetEndOfFile", fileName, info, NtStatus.Success, new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_5("SetEndOfFile", fileName, info, (NtStatus)((ulong)-1073741697), new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001ECE8 File Offset: 0x0001CEE8
		private Class14 method_8(string string_1)
		{
			Class14 result;
			try
			{
				Class15.Class17 @class = new Class15.Class17();
				string_1 = string_1.ToUpper();
				string key = Path.GetDirectoryName(string_1) ?? "\\";
				@class.string_0 = Path.GetFileName(string_1);
				result = this.dictionary_1[key].First(new Func<Class14, bool>(@class.method_0));
			}
			catch
			{
				Console.WriteLine("NOT FOUND: " + string_1);
				result = null;
			}
			return result;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011279 File Offset: 0x0000F479
		private bool method_9(string string_1)
		{
			return this.method_8(string_1) != null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001ED68 File Offset: 0x0001CF68
		public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
		{
			if (mode != FileMode.Open)
			{
				return (NtStatus)((ulong)-1073741790);
			}
			if (!this.method_9(fileName))
			{
				return (NtStatus)((ulong)-1073741772);
			}
			info.IsDirectory = (Path.GetExtension(fileName) == "");
			info.Context = new object();
			return NtStatus.Success;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00011285 File Offset: 0x0000F485
		public void CloseFile(string fileName, DokanFileInfo info)
		{
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			this.method_5("CloseFile", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001EDB8 File Offset: 0x0001CFB8
		public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
		{
			if (!File.Exists(this.method_3(fileName)) || this.method_8(fileName).fileInformation_0.Length != new FileInfo(this.method_3(fileName)).Length)
			{
				Class15.Class18 @class = new Class15.Class18();
				@class.class15_0 = this;
				if (this.process_0 == null)
				{
					try
					{
						this.process_0 = Process.GetProcessesByName("Cemu")[0];
						Thread thread = new Thread(new ThreadStart(this.method_11));
						thread.IsBackground = true;
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
					}
					catch
					{
					}
				}
				frmLoadOverlay frmLoadOverlay = this.frmLoadOverlay_0;
				if (frmLoadOverlay != null)
				{
					frmLoadOverlay.method_3();
				}
				Directory.CreateDirectory(Path.GetDirectoryName(this.method_3(fileName)));
				@class.eventHandler_1 = null;
				@class.eventHandler_0 = null;
				@class.bool_0 = false;
				@class.eventHandler_1 = new EventHandler<bool>(@class.method_0);
				@class.eventHandler_0 = new EventHandler<GStruct0>(this.method_12);
				this.class7_0.Event_0 += @class.eventHandler_1;
				this.class7_0.Event_1 += @class.eventHandler_0;
				this.class7_0.method_1(this.string_0, true, new GClass12[]
				{
					this.method_8(fileName).gclass12_0
				}.ToList<GClass12>(), false);
				while (!@class.bool_0)
				{
					Thread.Sleep(1);
				}
				frmLoadOverlay frmLoadOverlay2 = this.frmLoadOverlay_0;
				if (frmLoadOverlay2 != null)
				{
					frmLoadOverlay2.method_2(500);
				}
			}
			Console.WriteLine("READ " + fileName);
			using (Stream stream = this.method_2(this.method_3(fileName), fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 4096, FileOptions.None))
			{
				stream.Position = offset;
				bytesRead = stream.Read(buffer, 0, buffer.Length);
			}
			return this.method_5("ReadFile", fileName, info, NtStatus.Success, new object[]
			{
				"out " + bytesRead,
				offset.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001EFBC File Offset: 0x0001D1BC
		public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
		{
			Class14 @class = this.method_8(fileName);
			Console.WriteLine(fileName);
			if (@class == null)
			{
				fileInfo = default(FileInformation);
				return (NtStatus)((ulong)-1073741809);
			}
			fileInfo = @class.fileInformation_0;
			return NtStatus.Success;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000112BA File Offset: 0x0000F4BA
		public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			return NtStatus.Success;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000112BA File Offset: 0x0000F4BA
		public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			return NtStatus.Success;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
		public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
		{
			DriveInfo driveInfo = DriveInfo.GetDrives().Single(new Func<DriveInfo, bool>(this.method_13));
			freeBytesAvailable = driveInfo.TotalFreeSpace;
			totalNumberOfBytes = driveInfo.TotalSize;
			totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
			return this.method_5("GetDiskFreeSpace", null, info, NtStatus.Success, new object[]
			{
				"out " + freeBytesAvailable.ToString(),
				"out " + totalNumberOfBytes.ToString(),
				"out " + totalNumberOfFreeBytes.ToString()
			});
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001F084 File Offset: 0x0001D284
		public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
		{
			volumeLabel = "USBHELPER";
			fileSystemName = "NTFS";
			features = (FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage);
			return this.method_5("GetVolumeInformation", null, info, NtStatus.Success, new object[]
			{
				"out " + volumeLabel,
				"out " + features,
				"out " + fileSystemName
			});
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000112BE File Offset: 0x0000F4BE
		public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			security = null;
			return (NtStatus)((ulong)-1073741728);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000112C9 File Offset: 0x0000F4C9
		public NtStatus Mounted(DokanFileInfo info)
		{
			return this.method_5("Mounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000112E0 File Offset: 0x0000F4E0
		public NtStatus Unmounted(DokanFileInfo info)
		{
			return this.method_5("Unmounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001F0F0 File Offset: 0x0001D2F0
		public IList<FileInformation> method_10(string string_1, string string_2)
		{
			Class15.Class19 @class = new Class15.Class19();
			@class.string_0 = string_2;
			IList<FileInformation> result;
			try
			{
				List<FileInformation> list = new List<FileInformation>();
				string_1 = string_1.ToUpper();
				if (this.dictionary_1.ContainsKey(string_1))
				{
					list.AddRange(this.dictionary_1[string_1].Where(new Func<Class14, bool>(@class.method_0)).Select(new Func<Class14, FileInformation>(Class15.<>c.<>c_0.method_1)));
				}
				result = list;
			}
			catch (Exception)
			{
				result = new List<FileInformation>();
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000112F7 File Offset: 0x0000F4F7
		public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_10(fileName, searchPattern);
			return this.method_5("FindFilesWithPattern", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00011319 File Offset: 0x0000F519
		[CompilerGenerated]
		private void method_11()
		{
			this.frmLoadOverlay_0 = new frmLoadOverlay(this.process_0);
			this.frmLoadOverlay_0.ShowDialog();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00011338 File Offset: 0x0000F538
		[CompilerGenerated]
		private void method_12(object object_1, GStruct0 gstruct0_0)
		{
			frmLoadOverlay frmLoadOverlay = this.frmLoadOverlay_0;
			if (frmLoadOverlay == null)
			{
				return;
			}
			frmLoadOverlay.method_7(gstruct0_0.int_1);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00011350 File Offset: 0x0000F550
		[CompilerGenerated]
		private bool method_13(DriveInfo driveInfo_0)
		{
			return string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000081 RID: 129
		private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;

		// Token: 0x04000082 RID: 130
		private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;

		// Token: 0x04000083 RID: 131
		private readonly string string_0;

		// Token: 0x04000084 RID: 132
		private readonly ConsoleLogger consoleLogger_0 = new ConsoleLogger("[EshopFs] ");

		// Token: 0x04000085 RID: 133
		private readonly Dictionary<string, ulong> dictionary_0;

		// Token: 0x04000086 RID: 134
		private readonly Dictionary<string, List<Class14>> dictionary_1 = new Dictionary<string, List<Class14>>();

		// Token: 0x04000087 RID: 135
		private GClass30 gclass30_0;

		// Token: 0x04000088 RID: 136
		private GClass95 gclass95_0;

		// Token: 0x04000089 RID: 137
		private GClass13 gclass13_0;

		// Token: 0x0400008A RID: 138
		private Class7 class7_0;

		// Token: 0x0400008B RID: 139
		private List<string> list_0;

		// Token: 0x0400008C RID: 140
		private object object_0 = new object();

		// Token: 0x0400008D RID: 141
		private Process process_0;

		// Token: 0x0400008E RID: 142
		private frmLoadOverlay frmLoadOverlay_0;

		// Token: 0x0200002F RID: 47
		[CompilerGenerated]
		private sealed class Class16
		{
			// Token: 0x0600012D RID: 301 RVA: 0x00011378 File Offset: 0x0000F578
			internal bool method_0(Class14 class14_0)
			{
				return class14_0.fileInformation_0.FileName != this.fileInformation_0.FileName;
			}

			// Token: 0x0400008F RID: 143
			public FileInformation fileInformation_0;
		}

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		private sealed class Class17
		{
			// Token: 0x06000133 RID: 307 RVA: 0x000113A9 File Offset: 0x0000F5A9
			internal bool method_0(Class14 class14_0)
			{
				return class14_0.fileInformation_0.FileName.ToUpper() == this.string_0;
			}

			// Token: 0x04000093 RID: 147
			public string string_0;
		}

		// Token: 0x02000032 RID: 50
		[CompilerGenerated]
		private sealed class Class18
		{
			// Token: 0x06000135 RID: 309 RVA: 0x000113C6 File Offset: 0x0000F5C6
			internal void method_0(object object_0, bool bool_1)
			{
				this.class15_0.class7_0.Event_1 -= this.eventHandler_0;
				this.class15_0.class7_0.Event_0 -= this.eventHandler_1;
				this.bool_0 = true;
			}

			// Token: 0x04000094 RID: 148
			public EventHandler<GStruct0> eventHandler_0;

			// Token: 0x04000095 RID: 149
			public EventHandler<bool> eventHandler_1;

			// Token: 0x04000096 RID: 150
			public bool bool_0;

			// Token: 0x04000097 RID: 151
			public Class15 class15_0;
		}

		// Token: 0x02000033 RID: 51
		[CompilerGenerated]
		private sealed class Class19
		{
			// Token: 0x06000137 RID: 311 RVA: 0x000113FB File Offset: 0x0000F5FB
			internal bool method_0(Class14 class14_0)
			{
				return DokanHelper.DokanIsNameInExpression(this.string_0, class14_0.fileInformation_0.FileName, true);
			}

			// Token: 0x04000098 RID: 152
			public string string_0;
		}
	}
}
