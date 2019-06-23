using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using DokanNet;
using DokanNet.Logging;

namespace ns0
{
	// Token: 0x02000021 RID: 33
	internal class Class9 : IDokanOperations
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00010C61 File Offset: 0x0000EE61
		public Class9(string string_1)
		{
			if (!Directory.Exists(string_1))
			{
				throw new ArgumentException("path");
			}
			this.string_0 = string_1;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00010C93 File Offset: 0x0000EE93
		private string method_0(string string_1)
		{
			return this.string_0 + string_1;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0001CC30 File Offset: 0x0001AE30
		private NtStatus method_1(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_0)
		{
			string text;
			if (object_0 != null && object_0.Length != 0)
			{
				text = ", " + string.Join(", ", object_0.Select(new Func<object, string>(Class9.<>c.<>c_0.method_0)));
			}
			else
			{
				text = string.Empty;
			}
			string text2 = text;
			this.consoleLogger_0.Debug(FormatProviders.DokanFormat(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0}('{1}', {2}{3}) -> {4}", new object[]
			{
				string_1,
				string_2,
				dokanFileInfo_0,
				text2,
				ntStatus_0
			})), new object[0]);
			return ntStatus_0;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001CCCC File Offset: 0x0001AECC
		private NtStatus method_2(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
		{
			this.consoleLogger_0.Debug(FormatProviders.DokanFormat(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0}('{1}', {2}, [{3}], [{4}], [{5}], [{6}], [{7}]) -> {8}", new object[]
			{
				string_1,
				string_2,
				dokanFileInfo_0,
				fileAccess_2,
				fileShare_0,
				fileMode_0,
				fileOptions_0,
				fileAttributes_0,
				ntStatus_0
			})), new object[0]);
			return ntStatus_0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
		{
			NtStatus ntStatus_ = NtStatus.Success;
			string path = this.method_0(fileName);
			if (info.IsDirectory)
			{
				try
				{
					if (mode != FileMode.CreateNew)
					{
						if (mode == FileMode.Open)
						{
							if (!Directory.Exists(path))
							{
								try
								{
									if (!File.GetAttributes(path).HasFlag(FileAttributes.Directory))
									{
										return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741565));
									}
								}
								catch (Exception)
								{
									return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
								}
								return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741766));
							}
							new DirectoryInfo(path).EnumerateFileSystemInfos().Any<FileSystemInfo>();
						}
					}
					else
					{
						if (Directory.Exists(path))
						{
							return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
						}
						try
						{
							File.GetAttributes(path).HasFlag(FileAttributes.Directory);
							return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
						}
						catch (IOException)
						{
						}
						Directory.CreateDirectory(this.method_0(fileName));
					}
					goto IL_37B;
				}
				catch (UnauthorizedAccessException)
				{
					return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
				}
			}
			bool flag = true;
			bool flag2 = false;
			bool flag3 = (access & (DokanNet.FileAccess)((ulong)-536870873)) == (DokanNet.FileAccess)0L;
			bool flag4 = (access & (DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite)) == (DokanNet.FileAccess)0L;
			try
			{
				flag = (Directory.Exists(path) || File.Exists(path));
				flag2 = File.GetAttributes(path).HasFlag(FileAttributes.Directory);
			}
			catch (IOException)
			{
			}
			switch (mode)
			{
			case FileMode.CreateNew:
				if (flag)
				{
					return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
				}
				break;
			case FileMode.Open:
				if (!flag)
				{
					return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
				}
				if (flag3 || flag2)
				{
					if (flag2 && (access & DokanNet.FileAccess.Delete) == DokanNet.FileAccess.Delete && (access & DokanNet.FileAccess.Synchronize) != DokanNet.FileAccess.Synchronize)
					{
						return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
					}
					info.IsDirectory = flag2;
					info.Context = new object();
					return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, NtStatus.Success);
				}
				break;
			case FileMode.Truncate:
				if (!flag)
				{
					return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
				}
				break;
			}
			NtStatus result;
			try
			{
				info.Context = new FileStream(path, mode, flag4 ? System.IO.FileAccess.Read : System.IO.FileAccess.ReadWrite, share, 4096, options);
				if (flag && (mode == FileMode.OpenOrCreate || mode == FileMode.Create))
				{
					ntStatus_ = (NtStatus)((ulong)-1073741771);
				}
				if (mode == FileMode.CreateNew || mode == FileMode.Create)
				{
					attributes |= FileAttributes.Archive;
				}
				File.SetAttributes(path, attributes);
				goto IL_37B;
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
			}
			catch (DirectoryNotFoundException)
			{
				result = this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741766));
			}
			catch (Exception e)
			{
				uint hrforException = (uint)Marshal.GetHRForException(e);
				if (hrforException != 2147942432u)
				{
					throw;
				}
				result = this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741757));
			}
			return result;
			IL_37B:
			return this.method_2("CreateFile", fileName, info, access, share, mode, options, attributes, ntStatus_);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001D198 File Offset: 0x0001B398
		public void Cleanup(string fileName, DokanFileInfo info)
		{
			if (info.Context != null)
			{
				Console.WriteLine(FormatProviders.DokanFormat(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0}('{1}', {2} - entering", new object[]
				{
					"Cleanup",
					fileName,
					info
				})));
			}
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			if (info.DeleteOnClose)
			{
				if (info.IsDirectory)
				{
					Directory.Delete(this.method_0(fileName));
				}
				else
				{
					File.Delete(this.method_0(fileName));
				}
			}
			this.method_1("Cleanup", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0001D234 File Offset: 0x0001B434
		public void CloseFile(string fileName, DokanFileInfo info)
		{
			if (info.Context != null)
			{
				Console.WriteLine(FormatProviders.DokanFormat(System.Runtime.CompilerServices.FormattableStringFactory.Create("{0}('{1}', {2} - entering", new object[]
				{
					"CloseFile",
					fileName,
					info
				})));
			}
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			this.method_1("CloseFile", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
		{
			if (info.Context == null)
			{
				using (FileStream fileStream = new FileStream(this.method_0(fileName), FileMode.Open, System.IO.FileAccess.Read))
				{
					fileStream.Position = offset;
					bytesRead = fileStream.Read(buffer, 0, buffer.Length);
					goto IL_73;
				}
			}
			FileStream fileStream2 = info.Context as FileStream;
			FileStream obj = fileStream2;
			lock (obj)
			{
				fileStream2.Position = offset;
				bytesRead = fileStream2.Read(buffer, 0, buffer.Length);
			}
			IL_73:
			return this.method_1("ReadFile", fileName, info, NtStatus.Success, new object[]
			{
				"out " + bytesRead.ToString(),
				offset.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001D37C File Offset: 0x0001B57C
		public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
		{
			if (info.Context == null)
			{
				using (FileStream fileStream = new FileStream(this.method_0(fileName), FileMode.Open, System.IO.FileAccess.Write))
				{
					fileStream.Position = offset;
					fileStream.Write(buffer, 0, buffer.Length);
					bytesWritten = buffer.Length;
					goto IL_79;
				}
			}
			FileStream fileStream2 = info.Context as FileStream;
			FileStream obj = fileStream2;
			lock (obj)
			{
				fileStream2.Position = offset;
				fileStream2.Write(buffer, 0, buffer.Length);
			}
			bytesWritten = buffer.Length;
			IL_79:
			return this.method_1("WriteFile", fileName, info, NtStatus.Success, new object[]
			{
				"out " + bytesWritten.ToString(),
				offset.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001D458 File Offset: 0x0001B658
		public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Flush();
				result = this.method_1("FlushFileBuffers", fileName, info, NtStatus.Success, new object[0]);
			}
			catch (IOException)
			{
				result = this.method_1("FlushFileBuffers", fileName, info, (NtStatus)((ulong)-1073741697), new object[0]);
			}
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0001D4BC File Offset: 0x0001B6BC
		public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
		{
			string text = this.method_0(fileName);
			FileSystemInfo fileSystemInfo = new FileInfo(text);
			if (!fileSystemInfo.Exists)
			{
				fileSystemInfo = new DirectoryInfo(text);
			}
			FileInformation fileInformation = default(FileInformation);
			fileInformation.FileName = fileName;
			fileInformation.Attributes = fileSystemInfo.Attributes;
			fileInformation.CreationTime = new DateTime?(fileSystemInfo.CreationTime);
			fileInformation.LastAccessTime = new DateTime?(fileSystemInfo.LastAccessTime);
			fileInformation.LastWriteTime = new DateTime?(fileSystemInfo.LastWriteTime);
			FileInfo fileInfo2 = fileSystemInfo as FileInfo;
			fileInformation.Length = ((fileInfo2 != null) ? fileInfo2.Length : 0L);
			fileInfo = fileInformation;
			return this.method_1("GetFileInformation", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00010CA1 File Offset: 0x0000EEA1
		public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_4(fileName, "*");
			return this.method_1("FindFiles", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001D570 File Offset: 0x0001B770
		public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				if (attributes != (FileAttributes)0)
				{
					File.SetAttributes(this.method_0(fileName), attributes);
				}
				result = this.method_1("SetFileAttributes", fileName, info, NtStatus.Success, new object[]
				{
					attributes.ToString()
				});
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_1("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					attributes.ToString()
				});
			}
			catch (FileNotFoundException)
			{
				result = this.method_1("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741772), new object[]
				{
					attributes.ToString()
				});
			}
			catch (DirectoryNotFoundException)
			{
				result = this.method_1("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741766), new object[]
				{
					attributes.ToString()
				});
			}
			return result;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001D668 File Offset: 0x0001B868
		public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				FileStream fileStream;
				if ((fileStream = (info.Context as FileStream)) != null)
				{
					long num = (creationTime != null) ? creationTime.GetValueOrDefault().ToFileTime() : 0L;
					long num2 = (lastAccessTime != null) ? lastAccessTime.GetValueOrDefault().ToFileTime() : 0L;
					long num3 = (lastWriteTime != null) ? lastWriteTime.GetValueOrDefault().ToFileTime() : 0L;
					if (!GClass18.SetFileTime(fileStream.SafeFileHandle, ref num, ref num2, ref num3))
					{
						throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
					}
					result = NtStatus.Success;
				}
				else
				{
					string path = this.method_0(fileName);
					if (creationTime != null)
					{
						File.SetCreationTime(path, creationTime.Value);
					}
					if (lastAccessTime != null)
					{
						File.SetLastAccessTime(path, lastAccessTime.Value);
					}
					if (lastWriteTime != null)
					{
						File.SetLastWriteTime(path, lastWriteTime.Value);
					}
					result = this.method_1("SetFileTime", fileName, info, NtStatus.Success, new object[]
					{
						creationTime,
						lastAccessTime,
						lastWriteTime
					});
				}
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_1("SetFileTime", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					creationTime,
					lastAccessTime,
					lastWriteTime
				});
			}
			catch (FileNotFoundException)
			{
				result = this.method_1("SetFileTime", fileName, info, (NtStatus)((ulong)-1073741772), new object[]
				{
					creationTime,
					lastAccessTime,
					lastWriteTime
				});
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0001D838 File Offset: 0x0001BA38
		public NtStatus DeleteFile(string fileName, DokanFileInfo info)
		{
			string path = this.method_0(fileName);
			if (Directory.Exists(path))
			{
				return this.method_1("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[0]);
			}
			if (!File.Exists(path))
			{
				return this.method_1("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741772), new object[0]);
			}
			if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
			{
				return this.method_1("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[0]);
			}
			return this.method_1("DeleteFile", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00010CC6 File Offset: 0x0000EEC6
		public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
		{
			return this.method_1("DeleteDirectory", fileName, info, (NtStatus)(Directory.EnumerateFileSystemEntries(this.method_0(fileName)).Any<string>() ? ((ulong)-1073741567) : 0UL), new object[0]);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
		{
			string text = this.method_0(oldName);
			string text2 = this.method_0(newName);
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			bool flag = info.IsDirectory ? Directory.Exists(text2) : File.Exists(text2);
			try
			{
				if (!flag)
				{
					info.Context = null;
					if (info.IsDirectory)
					{
						Directory.Move(text, text2);
					}
					else
					{
						File.Move(text, text2);
					}
					return this.method_1("MoveFile", oldName, info, NtStatus.Success, new object[]
					{
						newName,
						replace.ToString(CultureInfo.InvariantCulture)
					});
				}
				if (replace)
				{
					info.Context = null;
					if (info.IsDirectory)
					{
						return this.method_1("MoveFile", oldName, info, (NtStatus)((ulong)-1073741790), new object[]
						{
							newName,
							replace.ToString(CultureInfo.InvariantCulture)
						});
					}
					File.Delete(text2);
					File.Move(text, text2);
					return this.method_1("MoveFile", oldName, info, NtStatus.Success, new object[]
					{
						newName,
						replace.ToString(CultureInfo.InvariantCulture)
					});
				}
			}
			catch (UnauthorizedAccessException)
			{
				return this.method_1("MoveFile", oldName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					newName,
					replace.ToString(CultureInfo.InvariantCulture)
				});
			}
			return this.method_1("MoveFile", oldName, info, (NtStatus)((ulong)-1073741771), new object[]
			{
				newName,
				replace.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001DA78 File Offset: 0x0001BC78
		public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).SetLength(length);
				result = this.method_1("SetEndOfFile", fileName, info, NtStatus.Success, new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_1("SetEndOfFile", fileName, info, (NtStatus)((ulong)-1073741697), new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).SetLength(length);
				result = this.method_1("SetAllocationSize", fileName, info, NtStatus.Success, new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_1("SetAllocationSize", fileName, info, (NtStatus)((ulong)-1073741697), new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0001DB80 File Offset: 0x0001BD80
		public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Lock(offset, length);
				result = this.method_1("LockFile", fileName, info, NtStatus.Success, new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_1("LockFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0001DC24 File Offset: 0x0001BE24
		public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Unlock(offset, length);
				result = this.method_1("UnlockFile", fileName, info, NtStatus.Success, new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_1("UnlockFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
		{
			DriveInfo driveInfo = DriveInfo.GetDrives().Single(new Func<DriveInfo, bool>(this.method_5));
			freeBytesAvailable = driveInfo.TotalFreeSpace;
			totalNumberOfBytes = driveInfo.TotalSize;
			totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
			return this.method_1("GetDiskFreeSpace", null, info, NtStatus.Success, new object[]
			{
				"out " + freeBytesAvailable.ToString(),
				"out " + totalNumberOfBytes.ToString(),
				"out " + totalNumberOfFreeBytes.ToString()
			});
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001DD54 File Offset: 0x0001BF54
		public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
		{
			volumeLabel = "DOKAN";
			fileSystemName = "NTFS";
			features = (FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage);
			return this.method_1("GetVolumeInformation", null, info, NtStatus.Success, new object[]
			{
				"out " + volumeLabel,
				"out " + features.ToString(),
				"out " + fileSystemName
			});
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
		public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				security = (info.IsDirectory ? Directory.GetAccessControl(this.method_0(fileName)) : File.GetAccessControl(this.method_0(fileName)));
				result = this.method_1("GetFileSecurity", fileName, info, NtStatus.Success, new object[]
				{
					sections.ToString()
				});
			}
			catch (UnauthorizedAccessException)
			{
				security = null;
				result = this.method_1("GetFileSecurity", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					sections.ToString()
				});
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0001DE64 File Offset: 0x0001C064
		public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				if (info.IsDirectory)
				{
					Directory.SetAccessControl(this.method_0(fileName), (DirectorySecurity)security);
				}
				else
				{
					File.SetAccessControl(this.method_0(fileName), (FileSecurity)security);
				}
				result = this.method_1("SetFileSecurity", fileName, info, NtStatus.Success, new object[]
				{
					sections.ToString()
				});
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_1("SetFileSecurity", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					sections.ToString()
				});
			}
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		public NtStatus Mounted(DokanFileInfo info)
		{
			return this.method_1("Mounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00010D0F File Offset: 0x0000EF0F
		public NtStatus Unmounted(DokanFileInfo info)
		{
			return this.method_1("Unmounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0001DF08 File Offset: 0x0001C108
		public NtStatus method_3(string string_1, IntPtr intptr_0, out string string_2, out long long_0, DokanFileInfo dokanFileInfo_0)
		{
			string_2 = string.Empty;
			long_0 = 0L;
			return this.method_1("FindStreams", string_1, dokanFileInfo_0, (NtStatus)((ulong)-1073741822), new object[]
			{
				intptr_0.ToString(),
				"out " + string_2,
				"out " + long_0.ToString()
			});
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00010D26 File Offset: 0x0000EF26
		public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
		{
			streams = new FileInformation[0];
			return this.method_1("FindStreams", fileName, info, (NtStatus)((ulong)-1073741822), new object[0]);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0001DF68 File Offset: 0x0001C168
		public IList<FileInformation> method_4(string string_1, string string_2)
		{
			Class9.Class10 @class = new Class9.Class10();
			@class.string_0 = string_2;
			return new DirectoryInfo(this.method_0(string_1)).EnumerateFileSystemInfos().Where(new Func<FileSystemInfo, bool>(@class.method_0)).Select(new Func<FileSystemInfo, FileInformation>(Class9.<>c.<>c_0.method_1)).ToArray<FileInformation>();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00010D49 File Offset: 0x0000EF49
		public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_4(fileName, searchPattern);
			return this.method_1("FindFilesWithPattern", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00010D6B File Offset: 0x0000EF6B
		[CompilerGenerated]
		private bool method_5(DriveInfo driveInfo_0)
		{
			return string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000055 RID: 85
		private readonly string string_0;

		// Token: 0x04000056 RID: 86
		private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;

		// Token: 0x04000057 RID: 87
		private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;

		// Token: 0x04000058 RID: 88
		private ConsoleLogger consoleLogger_0 = new ConsoleLogger("[Mirror] ");

		// Token: 0x02000023 RID: 35
		[CompilerGenerated]
		private sealed class Class10
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x00010DBA File Offset: 0x0000EFBA
			internal bool method_0(FileSystemInfo fileSystemInfo_0)
			{
				return DokanHelper.DokanIsNameInExpression(this.string_0, fileSystemInfo_0.Name, true);
			}

			// Token: 0x0400005C RID: 92
			public string string_0;
		}
	}
}
