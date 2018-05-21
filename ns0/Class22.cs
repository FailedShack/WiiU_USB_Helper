// Decompiled with JetBrains decompiler
// Type: ns0.Class22
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using DokanNet;
using DokanNet.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace ns0
{
  internal class Class22 : IDokanOperations
  {
    private readonly Dictionary<string, List<FileInformation>> dictionary_0 = new Dictionary<string, List<FileInformation>>();
    private readonly Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();
    private readonly ConsoleLogger consoleLogger_0 = new ConsoleLogger("[ModMapper] ");
    private readonly Dictionary<string, MemoryStream> dictionary_2 = new Dictionary<string, MemoryStream>();
    private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;
    private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;
    private readonly string string_0;
    private volatile bool bool_0;
    private readonly Dictionary<string, ulong> dictionary_3;
    private long long_0;
    private long long_1;

    public Class22(string string_1, Dictionary<string, ulong> dictionary_4, long long_2)
    {
      if (!Directory.Exists(string_1))
        throw new ArgumentException("rootPath");
      this.string_0 = string_1;
      this.dictionary_3 = dictionary_4;
      this.long_0 = long_2;
    }

    public void Cleanup(string fileName, DokanFileInfo info)
    {
      FileStream context = info.Context as FileStream;
      if (context != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (context.Dispose());
      }
      info.Context = (object) null;
      if (info.DeleteOnClose)
      {
        if (info.IsDirectory)
          Directory.Delete(this.method_6(fileName));
        else
          File.Delete(this.method_6(fileName));
      }
      long num = (long) this.method_8(nameof (Cleanup), fileName, info, NtStatus.Success);
    }

    public void method_0()
    {
      this.bool_0 = true;
    }

    public bool method_1(string string_1, string string_2)
    {
      if (string.IsNullOrEmpty(string_1) || string_1[0] != '\\')
        return false;
      string str = string_1;
      string_1 = string_1.ToUpperInvariant();
      string_2 = string_2.ToUpperInvariant();
      if (!File.Exists(string_2) || this.dictionary_1.ContainsKey(string_1))
        return false;
      this.dictionary_1.Add(string_1, string_2);
      string[] strArray1 = string_1.Split('\\');
      string[] strArray2 = str.Split('\\');
      for (int index = 0; index < strArray1.Length; ++index)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class22.Class23 class23 = new Class22.Class23();
        if (!(Path.GetExtension(strArray1[index]) != string.Empty))
        {
          string key = string.Join("\\", strArray1, 0, index + 1);
          if (index == 0)
            key = "\\" + key;
          if (!this.dictionary_0.ContainsKey(key))
            this.dictionary_0.Add(key, new List<FileInformation>());
          if (index >= 0 && index < strArray1.Length - 1)
          {
            bool flag = Path.GetExtension(strArray1[index + 1]) == string.Empty;
            List<FileInformation> source = this.dictionary_0[key];
            // ISSUE: reference to a compiler-generated field
            class23.fileInformation_0 = new FileInformation()
            {
              Attributes = flag ? FileAttributes.ReadOnly | FileAttributes.Directory : FileAttributes.ReadOnly,
              CreationTime = new DateTime?(DateTime.Now),
              LastAccessTime = new DateTime?(DateTime.Now),
              LastWriteTime = new DateTime?(DateTime.Now),
              Length = flag ? 0L : new FileInfo(string_2).Length,
              FileName = strArray2[index + 1]
            };
            // ISSUE: reference to a compiler-generated method
            if (source.All<FileInformation>(new Func<FileInformation, bool>(class23.method_0)))
            {
              // ISSUE: reference to a compiler-generated field
              source.Add(class23.fileInformation_0);
            }
          }
        }
        else
          break;
      }
      return true;
    }

    public void method_2(string string_1)
    {
      string_1 = string_1.ToUpper();
      if (!File.Exists(this.method_6(string_1)) || this.dictionary_2.ContainsKey(string_1))
        return;
      long length = new FileInfo(this.method_6(string_1)).Length;
      if (this.long_1 + length > this.long_0)
        return;
      this.dictionary_2.Add(string_1, new MemoryStream(File.ReadAllBytes(this.method_6(string_1))));
      this.long_1 += length;
    }

    public long method_3(string string_1)
    {
      string_1 = string_1.ToUpper();
      if (File.Exists(this.method_6(string_1)))
        return new FileInfo(this.method_6(string_1)).Length;
      return 0;
    }

    public void method_4()
    {
      foreach (Stream stream in this.dictionary_2.Values)
        stream.Dispose();
      GC.Collect();
    }

    private Stream method_5(string string_1, string string_2, FileMode fileMode_0, System.IO.FileAccess fileAccess_2, FileShare fileShare_0, int int_0, FileOptions fileOptions_0)
    {
      if (this.dictionary_3 != null)
      {
        lock (this.dictionary_3)
        {
          if (!this.dictionary_3.ContainsKey(string_2))
            this.dictionary_3.Add(string_2, 0UL);
          this.dictionary_3[string_2]++;
        }
      }
      if (this.bool_0 && this.dictionary_2.ContainsKey(string_2.ToUpperInvariant()))
        return (Stream) this.dictionary_2[string_2.ToUpperInvariant()];
      return (Stream) new FileStream(string_1, fileMode_0, fileAccess_2, fileShare_0, int_0, fileOptions_0);
    }

    private string method_6(string string_1)
    {
      string_1 = string_1.ToUpperInvariant();
      if (this.dictionary_1.ContainsKey(string_1))
        return this.dictionary_1[string_1];
      return this.string_0 + string_1;
    }

    private bool method_7(string string_1)
    {
      if (!Directory.Exists(string_1))
        return File.Exists(string_1);
      return true;
    }

    private NtStatus method_8(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_0)
    {
      return ntStatus_0;
    }

    private NtStatus method_9(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
    {
      return ntStatus_0;
    }

    public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_12(fileName, "*");
      return this.method_8(nameof (FindFiles), fileName, info, NtStatus.Success);
    }

    public NtStatus method_10(string string_1, IntPtr intptr_0, out string string_2, out long long_2, DokanFileInfo dokanFileInfo_0)
    {
      string_2 = string.Empty;
      long_2 = 0L;
      return this.method_8("FindStreams", string_1, dokanFileInfo_0, NtStatus.NotImplemented, (object) intptr_0.ToString(), (object) ("out " + string_2), (object) ("out " + long_2.ToString()));
    }

    public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
    {
      streams = (IList<FileInformation>) new FileInformation[0];
      return this.method_8(nameof (FindStreams), fileName, info, NtStatus.NotImplemented);
    }

    public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info)
    {
      try
      {
        FileStream context;
        if ((context = info.Context as FileStream) != null)
        {
          long long_0 = creationTime.HasValue ? creationTime.GetValueOrDefault().ToFileTime() : 0L;
          long long_1 = lastAccessTime.HasValue ? lastAccessTime.GetValueOrDefault().ToFileTime() : 0L;
          long long_2 = lastWriteTime.HasValue ? lastWriteTime.GetValueOrDefault().ToFileTime() : 0L;
          if (GClass18.SetFileTime(context.SafeFileHandle, ref long_0, ref long_1, ref long_2))
            return NtStatus.Success;
          throw Marshal.GetExceptionForHR(Marshal.GetLastWin32Error());
        }
        string path = this.method_6(fileName);
        if (creationTime.HasValue)
          File.SetCreationTime(path, creationTime.Value);
        if (lastAccessTime.HasValue)
          File.SetLastAccessTime(path, lastAccessTime.Value);
        if (lastWriteTime.HasValue)
          File.SetLastWriteTime(path, lastWriteTime.Value);
        return this.method_8(nameof (SetFileTime), fileName, info, NtStatus.Success, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_8(nameof (SetFileTime), fileName, info, NtStatus.AccessDenied, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
      catch (FileNotFoundException ex)
      {
        return this.method_8(nameof (SetFileTime), fileName, info, NtStatus.ObjectNameNotFound, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
    }

    public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      try
      {
        if (info.IsDirectory)
          Directory.SetAccessControl(this.method_6(fileName), (DirectorySecurity) security);
        else
          File.SetAccessControl(this.method_6(fileName), (FileSecurity) security);
        return this.method_8(nameof (SetFileSecurity), fileName, info, NtStatus.Success, (object) sections.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_8(nameof (SetFileSecurity), fileName, info, NtStatus.AccessDenied, (object) sections.ToString());
      }
    }

    public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
    {
      if (info.Context == null)
      {
        using (FileStream fileStream = new FileStream(this.method_6(fileName), FileMode.Open, System.IO.FileAccess.Write))
        {
          fileStream.Position = offset;
          fileStream.Write(buffer, 0, buffer.Length);
          bytesWritten = buffer.Length;
        }
      }
      else
      {
        FileStream context = info.Context as FileStream;
        lock (context)
        {
          context.Position = offset;
          context.Write(buffer, 0, buffer.Length);
        }
        bytesWritten = buffer.Length;
      }
      return this.method_8(nameof (WriteFile), fileName, info, NtStatus.Success, (object) ("out " + bytesWritten.ToString()), (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).Flush();
        return this.method_8(nameof (FlushFileBuffers), fileName, info, NtStatus.Success);
      }
      catch (IOException ex)
      {
        return this.method_8(nameof (FlushFileBuffers), fileName, info, NtStatus.DiskFull);
      }
    }

    public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
    {
      try
      {
        if (attributes != (FileAttributes) 0)
          File.SetAttributes(this.method_6(fileName), attributes);
        return this.method_8(nameof (SetFileAttributes), fileName, info, NtStatus.Success, (object) attributes.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_8(nameof (SetFileAttributes), fileName, info, NtStatus.AccessDenied, (object) attributes.ToString());
      }
      catch (FileNotFoundException ex)
      {
        return this.method_8(nameof (SetFileAttributes), fileName, info, NtStatus.ObjectNameNotFound, (object) attributes.ToString());
      }
      catch (DirectoryNotFoundException ex)
      {
        return this.method_8(nameof (SetFileAttributes), fileName, info, NtStatus.ObjectPathNotFound, (object) attributes.ToString());
      }
    }

    public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).SetLength(length);
        return this.method_8(nameof (SetAllocationSize), fileName, info, NtStatus.Success, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_8(nameof (SetAllocationSize), fileName, info, NtStatus.DiskFull, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus DeleteFile(string fileName, DokanFileInfo info)
    {
      string path = this.method_6(fileName);
      if (Directory.Exists(path))
        return this.method_8(nameof (DeleteFile), fileName, info, NtStatus.AccessDenied);
      if (!File.Exists(path))
        return this.method_8(nameof (DeleteFile), fileName, info, NtStatus.ObjectNameNotFound);
      if (File.GetAttributes(path).HasFlag((Enum) FileAttributes.Directory))
        return this.method_8(nameof (DeleteFile), fileName, info, NtStatus.AccessDenied);
      return this.method_8(nameof (DeleteFile), fileName, info, NtStatus.Success);
    }

    public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
    {
      return this.method_8(nameof (DeleteDirectory), fileName, info, Directory.EnumerateFileSystemEntries(this.method_6(fileName)).Any<string>() ? NtStatus.DirectoryNotEmpty : NtStatus.Success);
    }

    public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
    {
      string str1 = this.method_6(oldName);
      string str2 = this.method_6(newName);
      FileStream context = info.Context as FileStream;
      if (context != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (context.Dispose());
      }
      info.Context = (object) null;
      bool flag = info.IsDirectory ? Directory.Exists(str2) : File.Exists(str2);
      try
      {
        if (!flag)
        {
          info.Context = (object) null;
          if (info.IsDirectory)
            Directory.Move(str1, str2);
          else
            File.Move(str1, str2);
          return this.method_8(nameof (MoveFile), oldName, info, NtStatus.Success, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        }
        if (replace)
        {
          info.Context = (object) null;
          if (info.IsDirectory)
            return this.method_8(nameof (MoveFile), oldName, info, NtStatus.AccessDenied, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
          File.Delete(str2);
          File.Move(str1, str2);
          return this.method_8(nameof (MoveFile), oldName, info, NtStatus.Success, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        }
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_8(nameof (MoveFile), oldName, info, NtStatus.AccessDenied, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      return this.method_8(nameof (MoveFile), oldName, info, NtStatus.ObjectNameCollision, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).SetLength(length);
        return this.method_8(nameof (SetEndOfFile), fileName, info, NtStatus.Success, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_8(nameof (SetEndOfFile), fileName, info, NtStatus.DiskFull, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    private bool method_11(string string_1)
    {
      if (this.dictionary_0.ContainsKey(string_1.ToUpperInvariant()))
        return Directory.Exists(this.string_0 + (object) this.dictionary_0[string_1.ToUpperInvariant()]);
      return false;
    }

    public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
    {
      NtStatus ntStatus_0 = NtStatus.Success;
      string str = this.method_6(fileName);
      if (info.IsDirectory)
      {
        try
        {
          switch (mode)
          {
            case FileMode.CreateNew:
              if (Directory.Exists(str))
                return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
              try
              {
                File.GetAttributes(str).HasFlag((Enum) FileAttributes.Directory);
                return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
              }
              catch (IOException ex)
              {
              }
              Directory.CreateDirectory(this.method_6(fileName));
              break;
            case FileMode.Open:
              if (!Directory.Exists(str))
              {
                try
                {
                  if (!File.GetAttributes(str).HasFlag((Enum) FileAttributes.Directory))
                    return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.NotADirectory);
                }
                catch (Exception ex)
                {
                  return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
                }
                return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectPathNotFound);
              }
              new DirectoryInfo(str).EnumerateFileSystemInfos().Any<FileSystemInfo>();
              break;
          }
        }
        catch (UnauthorizedAccessException ex)
        {
          return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
        }
      }
      else
      {
        bool flag1 = true;
        bool flag2 = false;
        bool flag3 = (access & (DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead)) == (DokanNet.FileAccess) 0;
        bool flag4 = (access & (DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite)) == (DokanNet.FileAccess) 0;
        try
        {
          flag1 = this.method_7(str) || this.method_11(fileName);
          flag2 = this.method_11(fileName) || File.GetAttributes(str).HasFlag((Enum) FileAttributes.Directory);
        }
        catch
        {
        }
        switch (mode)
        {
          case FileMode.CreateNew:
            if (flag1)
              return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
            break;
          case FileMode.Open:
            if (!flag1)
              return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
            if (flag3 | flag2)
            {
              if (flag2 && (access & DokanNet.FileAccess.Delete) == DokanNet.FileAccess.Delete && (access & DokanNet.FileAccess.Synchronize) != DokanNet.FileAccess.Synchronize)
                return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
              info.IsDirectory = flag2;
              info.Context = new object();
              return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.Success);
            }
            break;
          case FileMode.Truncate:
            if (!flag1)
              return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
            break;
        }
        try
        {
          info.Context = (object) this.method_5(str, fileName, mode, flag4 ? System.IO.FileAccess.Read : System.IO.FileAccess.ReadWrite, share, 131072, options);
          if (flag1 && (mode == FileMode.OpenOrCreate || mode == FileMode.Create))
            ntStatus_0 = NtStatus.ObjectNameCollision;
          if (mode == FileMode.CreateNew || mode == FileMode.Create)
            attributes |= FileAttributes.Archive;
          File.SetAttributes(str, attributes);
        }
        catch (UnauthorizedAccessException ex)
        {
          return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
        }
        catch (DirectoryNotFoundException ex)
        {
          return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectPathNotFound);
        }
        catch (Exception ex)
        {
          if (Marshal.GetHRForException(ex) == -2147024864)
            return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.SharingViolation);
          throw;
        }
      }
      return this.method_9(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, ntStatus_0);
    }

    public void CloseFile(string fileName, DokanFileInfo info)
    {
      FileStream context = info.Context as FileStream;
      if (context != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (context.Dispose());
      }
      info.Context = (object) null;
      long num = (long) this.method_8(nameof (CloseFile), fileName, info, NtStatus.Success);
    }

    public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
    {
      if (info.Context == null)
      {
        using (Stream stream = this.method_5(this.method_6(fileName), fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 4096, FileOptions.None))
        {
          stream.Position = offset;
          bytesRead = stream.Read(buffer, 0, buffer.Length);
        }
      }
      else
      {
        Stream context = info.Context as Stream;
        lock (context)
        {
          context.Position = offset;
          bytesRead = context.Read(buffer, 0, buffer.Length);
        }
      }
      return this.method_8(nameof (ReadFile), fileName, info, NtStatus.Success, (object) ("out " + (object) bytesRead), (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
    {
      if (this.method_11(fileName))
      {
        fileInfo = new FileInformation()
        {
          Attributes = FileAttributes.Directory,
          CreationTime = new DateTime?(DateTime.Now),
          LastAccessTime = new DateTime?(DateTime.Now),
          LastWriteTime = new DateTime?(DateTime.Now),
          Length = 0L,
          FileName = Path.GetDirectoryName(fileName)
        };
        return NtStatus.Success;
      }
      string str = this.method_6(fileName);
      FileSystemInfo fileSystemInfo = (FileSystemInfo) new FileInfo(str);
      if (!fileSystemInfo.Exists)
      {
        if (new DirectoryInfo(str).Exists)
        {
          fileSystemInfo = (FileSystemInfo) new DirectoryInfo(str);
        }
        else
        {
          fileInfo = new FileInformation();
          return NtStatus.ObjectNameNotFound;
        }
      }
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      FileInformation& local1 = @fileInfo;
      FileInformation fileInformation1 = new FileInformation();
      fileInformation1.FileName = fileName;
      fileInformation1.Attributes = fileSystemInfo.Attributes;
      fileInformation1.CreationTime = new DateTime?(fileSystemInfo.CreationTime);
      fileInformation1.LastAccessTime = new DateTime?(fileSystemInfo.LastAccessTime);
      fileInformation1.LastWriteTime = new DateTime?(fileSystemInfo.LastWriteTime);
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      FileInformation& local2 = @fileInformation1;
      FileInfo fileInfo1 = fileSystemInfo as FileInfo;
      long num = fileInfo1 != null ? fileInfo1.Length : 0L;
      // ISSUE: explicit reference operation
      (^local2).Length = num;
      FileInformation fileInformation2 = fileInformation1;
      // ISSUE: explicit reference operation
      ^local1 = fileInformation2;
      return this.method_8(nameof (GetFileInformation), fileName, info, NtStatus.Success);
    }

    public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      try
      {
        ((FileStream) info.Context).Lock(offset, length);
        return this.method_8(nameof (LockFile), fileName, info, NtStatus.Success, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_8(nameof (LockFile), fileName, info, NtStatus.AccessDenied, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      try
      {
        ((FileStream) info.Context).Unlock(offset, length);
        return this.method_8(nameof (UnlockFile), fileName, info, NtStatus.Success, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_8(nameof (UnlockFile), fileName, info, NtStatus.AccessDenied, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
    {
      DriveInfo driveInfo = ((IEnumerable<DriveInfo>) DriveInfo.GetDrives()).Single<DriveInfo>((Func<DriveInfo, bool>) (driveInfo_0 => string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase)));
      freeBytesAvailable = driveInfo.TotalFreeSpace;
      totalNumberOfBytes = driveInfo.TotalSize;
      totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
      return this.method_8(nameof (GetDiskFreeSpace), (string) null, info, NtStatus.Success, (object) ("out " + freeBytesAvailable.ToString()), (object) ("out " + totalNumberOfBytes.ToString()), (object) ("out " + totalNumberOfFreeBytes.ToString()));
    }

    public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
    {
      volumeLabel = "USBHELPER";
      fileSystemName = "NTFS";
      features = FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage;
      return this.method_8(nameof (GetVolumeInformation), (string) null, info, NtStatus.Success, (object) ("out " + volumeLabel), (object) ("out " + (object) features), (object) ("out " + fileSystemName));
    }

    public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      try
      {
        if (this.method_11(fileName))
        {
          security = (FileSystemSecurity) null;
          return NtStatus.Success;
        }
        security = info.IsDirectory ? (FileSystemSecurity) Directory.GetAccessControl(this.method_6(fileName)) : (FileSystemSecurity) File.GetAccessControl(this.method_6(fileName));
        return this.method_8(nameof (GetFileSecurity), fileName, info, NtStatus.Success, (object) sections.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        security = (FileSystemSecurity) null;
        return this.method_8(nameof (GetFileSecurity), fileName, info, NtStatus.AccessDenied, (object) sections.ToString());
      }
    }

    public NtStatus Mounted(DokanFileInfo info)
    {
      return this.method_8(nameof (Mounted), (string) null, info, NtStatus.Success);
    }

    public NtStatus Unmounted(DokanFileInfo info)
    {
      return this.method_8(nameof (Unmounted), (string) null, info, NtStatus.Success);
    }

    public IList<FileInformation> method_12(string string_1, string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class22.Class24 class24 = new Class22.Class24();
      // ISSUE: reference to a compiler-generated field
      class24.class22_0 = this;
      // ISSUE: reference to a compiler-generated field
      class24.string_0 = string_2;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class22.Class25 class25 = new Class22.Class25();
        // ISSUE: reference to a compiler-generated field
        class25.class24_0 = class24;
        string_1 = string_1.ToUpperInvariant();
        // ISSUE: reference to a compiler-generated field
        class25.list_0 = new List<FileInformation>();
        if (this.method_7(this.method_6(string_1)))
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          class25.list_0.AddRange((IEnumerable<FileInformation>) new DirectoryInfo(this.method_6(string_1)).EnumerateFileSystemInfos().Where<FileSystemInfo>(new Func<FileSystemInfo, bool>(class25.class24_0.method_0)).Select<FileSystemInfo, FileInformation>((Func<FileSystemInfo, FileInformation>) (fileSystemInfo_0 =>
          {
            FileInformation fileInformation = new FileInformation();
            fileInformation.Attributes = fileSystemInfo_0.Attributes;
            fileInformation.CreationTime = new DateTime?(fileSystemInfo_0.CreationTime);
            fileInformation.LastAccessTime = new DateTime?(fileSystemInfo_0.LastAccessTime);
            fileInformation.LastWriteTime = new DateTime?(fileSystemInfo_0.LastWriteTime);
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            FileInformation& local = @fileInformation;
            FileInfo fileInfo = fileSystemInfo_0 as FileInfo;
            long num = fileInfo != null ? fileInfo.Length : 0L;
            // ISSUE: explicit reference operation
            (^local).Length = num;
            fileInformation.FileName = fileSystemInfo_0.Name;
            return fileInformation;
          })).ToList<FileInformation>());
        }
        if (!this.dictionary_0.ContainsKey(string_1))
        {
          // ISSUE: reference to a compiler-generated field
          return (IList<FileInformation>) class25.list_0;
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class25.list_0.AddRange(this.dictionary_0[string_1].Where<FileInformation>(new Func<FileInformation, bool>(class25.method_0)));
        // ISSUE: reference to a compiler-generated field
        return (IList<FileInformation>) class25.list_0;
      }
      catch (Exception ex)
      {
        return (IList<FileInformation>) new List<FileInformation>();
      }
    }

    public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_12(fileName, searchPattern);
      return this.method_8(nameof (FindFilesWithPattern), fileName, info, NtStatus.Success);
    }
  }
}
