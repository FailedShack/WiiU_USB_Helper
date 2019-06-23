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
	// Token: 0x02000034 RID: 52
	internal class Class20 : IDokanOperations
	{
		// Token: 0x06000138 RID: 312 RVA: 0x0001F190 File Offset: 0x0001D390
		public Class20(string string_1, Dictionary<string, ulong> dictionary_4, long long_2)
		{
			if (!Directory.Exists(string_1))
			{
				throw new ArgumentException("rootPath");
			}
			this.string_0 = string_1;
			this.dictionary_3 = dictionary_4;
			this.long_0 = long_2;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001F1FC File Offset: 0x0001D3FC
		public void Cleanup(string fileName, DokanFileInfo info)
		{
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
					Directory.Delete(this.method_6(fileName));
				}
				else
				{
					File.Delete(this.method_6(fileName));
				}
			}
			this.method_8("Cleanup", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00011414 File Offset: 0x0000F614
		public void method_0()
		{
			this.bool_0 = true;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001F268 File Offset: 0x0001D468
		public bool method_1(string string_1, string string_2)
		{
			if (!string.IsNullOrEmpty(string_1))
			{
				if (string_1[0] == '\\')
				{
					string text = string_1;
					string_1 = string_1.ToUpperInvariant();
					string_2 = string_2.ToUpperInvariant();
					if (File.Exists(string_2) && !this.dictionary_1.ContainsKey(string_1))
					{
						this.dictionary_1.Add(string_1, string_2);
						string[] array = string_1.Split(new char[]
						{
							'\\'
						});
						string[] array2 = text.Split(new char[]
						{
							'\\'
						});
						for (int i = 0; i < array.Length; i++)
						{
							Class20.Class21 @class = new Class20.Class21();
							if (Path.GetExtension(array[i]) != string.Empty)
							{
								break;
							}
							string text2 = string.Join("\\", array, 0, i + 1);
							if (i == 0)
							{
								text2 = "\\" + text2;
							}
							if (!this.dictionary_0.ContainsKey(text2))
							{
								this.dictionary_0.Add(text2, new List<FileInformation>());
							}
							if (i >= 0 && i < array.Length - 1)
							{
								bool flag = Path.GetExtension(array[i + 1]) == string.Empty;
								List<FileInformation> list = this.dictionary_0[text2];
								@class.fileInformation_0 = new FileInformation
								{
									Attributes = (flag ? (FileAttributes.ReadOnly | FileAttributes.Directory) : FileAttributes.ReadOnly),
									CreationTime = new DateTime?(DateTime.Now),
									LastAccessTime = new DateTime?(DateTime.Now),
									LastWriteTime = new DateTime?(DateTime.Now),
									Length = (flag ? 0L : new FileInfo(string_2).Length),
									FileName = array2[i + 1]
								};
								if (list.All(new Func<FileInformation, bool>(@class.method_0)))
								{
									list.Add(@class.fileInformation_0);
								}
							}
						}
						return true;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001F444 File Offset: 0x0001D644
		public void method_2(string string_1)
		{
			string_1 = string_1.ToUpper();
			if (File.Exists(this.method_6(string_1)) && !this.dictionary_2.ContainsKey(string_1))
			{
				long length = new FileInfo(this.method_6(string_1)).Length;
				if (this.long_1 + length <= this.long_0)
				{
					this.dictionary_2.Add(string_1, new MemoryStream(File.ReadAllBytes(this.method_6(string_1))));
					this.long_1 += length;
				}
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001141F File Offset: 0x0000F61F
		public long method_3(string string_1)
		{
			string_1 = string_1.ToUpper();
			if (File.Exists(this.method_6(string_1)))
			{
				return new FileInfo(this.method_6(string_1)).Length;
			}
			return 0L;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		public void method_4()
		{
			foreach (MemoryStream memoryStream in this.dictionary_2.Values)
			{
				memoryStream.Dispose();
			}
			GC.Collect();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001F520 File Offset: 0x0001D720
		private Stream method_5(string string_1, string string_2, FileMode fileMode_0, System.IO.FileAccess fileAccess_2, FileShare fileShare_0, int int_0, FileOptions fileOptions_0)
		{
			if (this.dictionary_3 != null)
			{
				Dictionary<string, ulong> obj = this.dictionary_3;
				lock (obj)
				{
					if (!this.dictionary_3.ContainsKey(string_2))
					{
						this.dictionary_3.Add(string_2, 0UL);
					}
					Dictionary<string, ulong> dictionary = this.dictionary_3;
					ulong num = dictionary[string_2];
					dictionary[string_2] = num + 1UL;
				}
			}
			if (this.bool_0 && this.dictionary_2.ContainsKey(string_2.ToUpperInvariant()))
			{
				return this.dictionary_2[string_2.ToUpperInvariant()];
			}
			return new FileStream(string_1, fileMode_0, fileAccess_2, fileShare_0, int_0, fileOptions_0);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001144D File Offset: 0x0000F64D
		private string method_6(string string_1)
		{
			string_1 = string_1.ToUpperInvariant();
			if (this.dictionary_1.ContainsKey(string_1))
			{
				return this.dictionary_1[string_1];
			}
			return this.string_0 + string_1;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000111FC File Offset: 0x0000F3FC
		private bool method_7(string string_1)
		{
			return Directory.Exists(string_1) || File.Exists(string_1);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001120E File Offset: 0x0000F40E
		private NtStatus method_8(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_0)
		{
			return ntStatus_0;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00011212 File Offset: 0x0000F412
		private NtStatus method_9(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
		{
			return ntStatus_0;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00011480 File Offset: 0x0000F680
		public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_12(fileName, "*");
			return this.method_8("FindFiles", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		public NtStatus method_10(string string_1, IntPtr intptr_0, out string string_2, out long long_2, DokanFileInfo dokanFileInfo_0)
		{
			string_2 = string.Empty;
			long_2 = 0L;
			return this.method_8("FindStreams", string_1, dokanFileInfo_0, (NtStatus)((ulong)-1073741822), new object[]
			{
				intptr_0.ToString(),
				"out " + string_2,
				"out " + long_2.ToString()
			});
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000114A5 File Offset: 0x0000F6A5
		public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
		{
			streams = new FileInformation[0];
			return this.method_8("FindStreams", fileName, info, (NtStatus)((ulong)-1073741822), new object[0]);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001F638 File Offset: 0x0001D838
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
					string path = this.method_6(fileName);
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
					result = this.method_8("SetFileTime", fileName, info, NtStatus.Success, new object[]
					{
						creationTime,
						lastAccessTime,
						lastWriteTime
					});
				}
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_8("SetFileTime", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					creationTime,
					lastAccessTime,
					lastWriteTime
				});
			}
			catch (FileNotFoundException)
			{
				result = this.method_8("SetFileTime", fileName, info, (NtStatus)((ulong)-1073741772), new object[]
				{
					creationTime,
					lastAccessTime,
					lastWriteTime
				});
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001F808 File Offset: 0x0001DA08
		public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				if (info.IsDirectory)
				{
					Directory.SetAccessControl(this.method_6(fileName), (DirectorySecurity)security);
				}
				else
				{
					File.SetAccessControl(this.method_6(fileName), (FileSecurity)security);
				}
				result = this.method_8("SetFileSecurity", fileName, info, NtStatus.Success, new object[]
				{
					sections.ToString()
				});
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_8("SetFileSecurity", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					sections.ToString()
				});
			}
			return result;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
		{
			if (info.Context == null)
			{
				using (FileStream fileStream = new FileStream(this.method_6(fileName), FileMode.Open, System.IO.FileAccess.Write))
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
			return this.method_8("WriteFile", fileName, info, NtStatus.Success, new object[]
			{
				"out " + bytesWritten.ToString(),
				offset.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001F988 File Offset: 0x0001DB88
		public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Flush();
				result = this.method_8("FlushFileBuffers", fileName, info, NtStatus.Success, new object[0]);
			}
			catch (IOException)
			{
				result = this.method_8("FlushFileBuffers", fileName, info, (NtStatus)((ulong)-1073741697), new object[0]);
			}
			return result;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				if (attributes != (FileAttributes)0)
				{
					File.SetAttributes(this.method_6(fileName), attributes);
				}
				result = this.method_8("SetFileAttributes", fileName, info, NtStatus.Success, new object[]
				{
					attributes.ToString()
				});
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_8("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					attributes.ToString()
				});
			}
			catch (FileNotFoundException)
			{
				result = this.method_8("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741772), new object[]
				{
					attributes.ToString()
				});
			}
			catch (DirectoryNotFoundException)
			{
				result = this.method_8("SetFileAttributes", fileName, info, (NtStatus)((ulong)-1073741766), new object[]
				{
					attributes.ToString()
				});
			}
			return result;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
		public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).SetLength(length);
				result = this.method_8("SetAllocationSize", fileName, info, NtStatus.Success, new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_8("SetAllocationSize", fileName, info, (NtStatus)((ulong)-1073741697), new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001FB68 File Offset: 0x0001DD68
		public NtStatus DeleteFile(string fileName, DokanFileInfo info)
		{
			string path = this.method_6(fileName);
			if (Directory.Exists(path))
			{
				return this.method_8("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[0]);
			}
			if (!File.Exists(path))
			{
				return this.method_8("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741772), new object[0]);
			}
			if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
			{
				return this.method_8("DeleteFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[0]);
			}
			return this.method_8("DeleteFile", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000114C8 File Offset: 0x0000F6C8
		public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
		{
			return this.method_8("DeleteDirectory", fileName, info, (NtStatus)(Directory.EnumerateFileSystemEntries(this.method_6(fileName)).Any<string>() ? ((ulong)-1073741567) : 0UL), new object[0]);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001FC0C File Offset: 0x0001DE0C
		public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
		{
			string text = this.method_6(oldName);
			string text2 = this.method_6(newName);
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
					return this.method_8("MoveFile", oldName, info, NtStatus.Success, new object[]
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
						return this.method_8("MoveFile", oldName, info, (NtStatus)((ulong)-1073741790), new object[]
						{
							newName,
							replace.ToString(CultureInfo.InvariantCulture)
						});
					}
					File.Delete(text2);
					File.Move(text, text2);
					return this.method_8("MoveFile", oldName, info, NtStatus.Success, new object[]
					{
						newName,
						replace.ToString(CultureInfo.InvariantCulture)
					});
				}
			}
			catch (UnauthorizedAccessException)
			{
				return this.method_8("MoveFile", oldName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					newName,
					replace.ToString(CultureInfo.InvariantCulture)
				});
			}
			return this.method_8("MoveFile", oldName, info, (NtStatus)((ulong)-1073741771), new object[]
			{
				newName,
				replace.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).SetLength(length);
				result = this.method_8("SetEndOfFile", fileName, info, NtStatus.Success, new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_8("SetEndOfFile", fileName, info, (NtStatus)((ulong)-1073741697), new object[]
				{
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000114FA File Offset: 0x0000F6FA
		private bool method_11(string string_1)
		{
			return this.dictionary_0.ContainsKey(string_1.ToUpperInvariant()) && Directory.Exists(this.string_0 + this.dictionary_0[string_1.ToUpperInvariant()]);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001FE2C File Offset: 0x0001E02C
		public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
		{
			NtStatus ntStatus_ = NtStatus.Success;
			string text = this.method_6(fileName);
			if (info.IsDirectory)
			{
				try
				{
					if (mode != FileMode.CreateNew)
					{
						if (mode == FileMode.Open)
						{
							if (!Directory.Exists(text))
							{
								try
								{
									if (!File.GetAttributes(text).HasFlag(FileAttributes.Directory))
									{
										return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741565));
									}
								}
								catch (Exception)
								{
									return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
								}
								return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741766));
							}
							new DirectoryInfo(text).EnumerateFileSystemInfos().Any<FileSystemInfo>();
						}
					}
					else
					{
						if (Directory.Exists(text))
						{
							return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
						}
						try
						{
							File.GetAttributes(text).HasFlag(FileAttributes.Directory);
							return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
						}
						catch (IOException)
						{
						}
						Directory.CreateDirectory(this.method_6(fileName));
					}
					goto IL_38B;
				}
				catch (UnauthorizedAccessException)
				{
					return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
				}
			}
			bool flag = true;
			bool flag2 = false;
			bool flag3 = (access & (DokanNet.FileAccess)((ulong)-536870873)) == (DokanNet.FileAccess)0L;
			bool flag4 = (access & (DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite)) == (DokanNet.FileAccess)0L;
			try
			{
				flag = (this.method_7(text) || this.method_11(fileName));
				flag2 = (this.method_11(fileName) || File.GetAttributes(text).HasFlag(FileAttributes.Directory));
			}
			catch
			{
			}
			switch (mode)
			{
			case FileMode.CreateNew:
				if (flag)
				{
					return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741771));
				}
				break;
			case FileMode.Open:
				if (!flag)
				{
					return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
				}
				if (flag3 || flag2)
				{
					if (flag2 && (access & DokanNet.FileAccess.Delete) == DokanNet.FileAccess.Delete && (access & DokanNet.FileAccess.Synchronize) != DokanNet.FileAccess.Synchronize)
					{
						return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
					}
					info.IsDirectory = flag2;
					info.Context = new object();
					return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, NtStatus.Success);
				}
				break;
			case FileMode.Truncate:
				if (!flag)
				{
					return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741772));
				}
				break;
			}
			NtStatus result;
			try
			{
				info.Context = this.method_5(text, fileName, mode, flag4 ? System.IO.FileAccess.Read : System.IO.FileAccess.ReadWrite, share, 131072, options);
				if (flag && (mode == FileMode.OpenOrCreate || mode == FileMode.Create))
				{
					ntStatus_ = (NtStatus)((ulong)-1073741771);
				}
				if (mode == FileMode.CreateNew || mode == FileMode.Create)
				{
					attributes |= FileAttributes.Archive;
				}
				File.SetAttributes(text, attributes);
				goto IL_38B;
			}
			catch (UnauthorizedAccessException)
			{
				result = this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741790));
			}
			catch (DirectoryNotFoundException)
			{
				result = this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741766));
			}
			catch (Exception e)
			{
				uint hrforException = (uint)Marshal.GetHRForException(e);
				if (hrforException != 2147942432u)
				{
					throw;
				}
				result = this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, (NtStatus)((ulong)-1073741757));
			}
			return result;
			IL_38B:
			return this.method_9("CreateFile", fileName, info, access, share, mode, options, attributes, ntStatus_);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00011532 File Offset: 0x0000F732
		public void CloseFile(string fileName, DokanFileInfo info)
		{
			FileStream fileStream = info.Context as FileStream;
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
			info.Context = null;
			this.method_8("CloseFile", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00020288 File Offset: 0x0001E488
		public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
		{
			if (info.Context == null)
			{
				using (Stream stream = this.method_5(this.method_6(fileName), fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 4096, FileOptions.None))
				{
					stream.Position = offset;
					bytesRead = stream.Read(buffer, 0, buffer.Length);
					goto IL_7C;
				}
			}
			Stream stream2 = info.Context as Stream;
			Stream obj = stream2;
			lock (obj)
			{
				stream2.Position = offset;
				bytesRead = stream2.Read(buffer, 0, buffer.Length);
			}
			IL_7C:
			return this.method_8("ReadFile", fileName, info, NtStatus.Success, new object[]
			{
				"out " + bytesRead,
				offset.ToString(CultureInfo.InvariantCulture)
			});
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00020368 File Offset: 0x0001E568
		public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
		{
			FileInformation fileInformation;
			if (this.method_11(fileName))
			{
				fileInformation = new FileInformation
				{
					Attributes = FileAttributes.Directory,
					CreationTime = new DateTime?(DateTime.Now),
					LastAccessTime = new DateTime?(DateTime.Now),
					LastWriteTime = new DateTime?(DateTime.Now),
					Length = 0L,
					FileName = Path.GetDirectoryName(fileName)
				};
				fileInfo = fileInformation;
				return NtStatus.Success;
			}
			string text = this.method_6(fileName);
			FileSystemInfo fileSystemInfo = new FileInfo(text);
			if (!fileSystemInfo.Exists)
			{
				if (!new DirectoryInfo(text).Exists)
				{
					fileInfo = default(FileInformation);
					return (NtStatus)((ulong)-1073741772);
				}
				fileSystemInfo = new DirectoryInfo(text);
			}
			fileInformation = default(FileInformation);
			fileInformation.FileName = fileName;
			fileInformation.Attributes = fileSystemInfo.Attributes;
			fileInformation.CreationTime = new DateTime?(fileSystemInfo.CreationTime);
			fileInformation.LastAccessTime = new DateTime?(fileSystemInfo.LastAccessTime);
			fileInformation.LastWriteTime = new DateTime?(fileSystemInfo.LastWriteTime);
			FileInfo fileInfo2 = fileSystemInfo as FileInfo;
			fileInformation.Length = ((fileInfo2 != null) ? fileInfo2.Length : 0L);
			fileInfo = fileInformation;
			return this.method_8("GetFileInformation", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000204A8 File Offset: 0x0001E6A8
		public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Lock(offset, length);
				result = this.method_8("LockFile", fileName, info, NtStatus.Success, new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_8("LockFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0002054C File Offset: 0x0001E74C
		public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				((FileStream)info.Context).Unlock(offset, length);
				result = this.method_8("UnlockFile", fileName, info, NtStatus.Success, new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			catch (IOException)
			{
				result = this.method_8("UnlockFile", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					offset.ToString(CultureInfo.InvariantCulture),
					length.ToString(CultureInfo.InvariantCulture)
				});
			}
			return result;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000205F0 File Offset: 0x0001E7F0
		public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
		{
			DriveInfo driveInfo = DriveInfo.GetDrives().Single(new Func<DriveInfo, bool>(this.method_13));
			freeBytesAvailable = driveInfo.TotalFreeSpace;
			totalNumberOfBytes = driveInfo.TotalSize;
			totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
			return this.method_8("GetDiskFreeSpace", null, info, NtStatus.Success, new object[]
			{
				"out " + freeBytesAvailable.ToString(),
				"out " + totalNumberOfBytes.ToString(),
				"out " + totalNumberOfFreeBytes.ToString()
			});
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0002067C File Offset: 0x0001E87C
		public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
		{
			volumeLabel = "USBHELPER";
			fileSystemName = "NTFS";
			features = (FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage);
			return this.method_8("GetVolumeInformation", null, info, NtStatus.Success, new object[]
			{
				"out " + volumeLabel,
				"out " + features,
				"out " + fileSystemName
			});
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000206E8 File Offset: 0x0001E8E8
		public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
		{
			NtStatus result;
			try
			{
				if (this.method_11(fileName))
				{
					security = null;
					result = NtStatus.Success;
				}
				else
				{
					security = (info.IsDirectory ? Directory.GetAccessControl(this.method_6(fileName)) : File.GetAccessControl(this.method_6(fileName)));
					result = this.method_8("GetFileSecurity", fileName, info, NtStatus.Success, new object[]
					{
						sections.ToString()
					});
				}
			}
			catch (UnauthorizedAccessException)
			{
				security = null;
				result = this.method_8("GetFileSecurity", fileName, info, (NtStatus)((ulong)-1073741790), new object[]
				{
					sections.ToString()
				});
			}
			return result;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00011567 File Offset: 0x0000F767
		public NtStatus Mounted(DokanFileInfo info)
		{
			return this.method_8("Mounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001157E File Offset: 0x0000F77E
		public NtStatus Unmounted(DokanFileInfo info)
		{
			return this.method_8("Unmounted", null, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00020798 File Offset: 0x0001E998
		public IList<FileInformation> method_12(string string_1, string string_2)
		{
			Class20.Class22 @class = new Class20.Class22();
			@class.class20_0 = this;
			@class.string_0 = string_2;
			IList<FileInformation> result;
			try
			{
				Class20.Class23 class2 = new Class20.Class23();
				class2.class22_0 = @class;
				string_1 = string_1.ToUpperInvariant();
				class2.list_0 = new List<FileInformation>();
				if (this.method_7(this.method_6(string_1)))
				{
					class2.list_0.AddRange(new DirectoryInfo(this.method_6(string_1)).EnumerateFileSystemInfos().Where(new Func<FileSystemInfo, bool>(class2.class22_0.method_0)).Select(new Func<FileSystemInfo, FileInformation>(Class20.<>c.<>c_0.method_1)).ToList<FileInformation>());
				}
				if (!this.dictionary_0.ContainsKey(string_1))
				{
					result = class2.list_0;
				}
				else
				{
					class2.list_0.AddRange(this.dictionary_0[string_1].Where(new Func<FileInformation, bool>(class2.method_0)));
					result = class2.list_0;
				}
			}
			catch (Exception)
			{
				result = new List<FileInformation>();
			}
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00011595 File Offset: 0x0000F795
		public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
		{
			files = this.method_12(fileName, searchPattern);
			return this.method_8("FindFilesWithPattern", fileName, info, NtStatus.Success, new object[0]);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000115B7 File Offset: 0x0000F7B7
		[CompilerGenerated]
		private bool method_13(DriveInfo driveInfo_0)
		{
			return string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x04000099 RID: 153
		private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;

		// Token: 0x0400009A RID: 154
		private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;

		// Token: 0x0400009B RID: 155
		private readonly string string_0;

		// Token: 0x0400009C RID: 156
		private readonly Dictionary<string, List<FileInformation>> dictionary_0 = new Dictionary<string, List<FileInformation>>();

		// Token: 0x0400009D RID: 157
		private readonly Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

		// Token: 0x0400009E RID: 158
		private readonly ConsoleLogger consoleLogger_0 = new ConsoleLogger("[ModMapper] ");

		// Token: 0x0400009F RID: 159
		private readonly Dictionary<string, MemoryStream> dictionary_2 = new Dictionary<string, MemoryStream>();

		// Token: 0x040000A0 RID: 160
		private volatile bool bool_0;

		// Token: 0x040000A1 RID: 161
		private readonly Dictionary<string, ulong> dictionary_3;

		// Token: 0x040000A2 RID: 162
		private long long_0;

		// Token: 0x040000A3 RID: 163
		private long long_1;

		// Token: 0x02000035 RID: 53
		[CompilerGenerated]
		private sealed class Class21
		{
			// Token: 0x06000161 RID: 353 RVA: 0x000115DF File Offset: 0x0000F7DF
			internal bool method_0(FileInformation fileInformation_1)
			{
				return fileInformation_1.FileName != this.fileInformation_0.FileName;
			}

			// Token: 0x040000A4 RID: 164
			public FileInformation fileInformation_0;
		}

		// Token: 0x02000037 RID: 55
		[CompilerGenerated]
		private sealed class Class22
		{
			// Token: 0x06000167 RID: 359 RVA: 0x000208A8 File Offset: 0x0001EAA8
			internal bool method_0(FileSystemInfo fileSystemInfo_0)
			{
				return !this.class20_0.dictionary_1.ContainsKey(fileSystemInfo_0.FullName.Substring(this.class20_0.string_0.Length).ToUpperInvariant()) && DokanHelper.DokanIsNameInExpression(this.string_0, fileSystemInfo_0.Name, true);
			}

			// Token: 0x040000A8 RID: 168
			public Class20 class20_0;

			// Token: 0x040000A9 RID: 169
			public string string_0;
		}

		// Token: 0x02000038 RID: 56
		[CompilerGenerated]
		private sealed class Class23
		{
			// Token: 0x06000169 RID: 361 RVA: 0x000208FC File Offset: 0x0001EAFC
			internal bool method_0(FileInformation fileInformation_0)
			{
				Class20.Class24 @class = new Class20.Class24();
				@class.fileInformation_0 = fileInformation_0;
				return DokanHelper.DokanIsNameInExpression(this.class22_0.string_0, @class.fileInformation_0.FileName, true) && !this.list_0.Any(new Func<FileInformation, bool>(@class.method_0));
			}

			// Token: 0x040000AA RID: 170
			public List<FileInformation> list_0;

			// Token: 0x040000AB RID: 171
			public Class20.Class22 class22_0;
		}

		// Token: 0x02000039 RID: 57
		[CompilerGenerated]
		private sealed class Class24
		{
			// Token: 0x0600016B RID: 363 RVA: 0x00011604 File Offset: 0x0000F804
			internal bool method_0(FileInformation fileInformation_1)
			{
				return fileInformation_1.FileName.ToUpperInvariant() == this.fileInformation_0.FileName.ToUpperInvariant();
			}

			// Token: 0x040000AC RID: 172
			public FileInformation fileInformation_0;
		}
	}
}
