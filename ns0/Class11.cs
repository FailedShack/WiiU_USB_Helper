// Decompiled with JetBrains decompiler
// Type: ns0.Class11
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace ns0
{
  internal class Class11 : IDokanOperations
  {
    private ConsoleLogger consoleLogger_0 = new ConsoleLogger("[Mirror] ");
    private readonly string string_0;
    private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;
    private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;

    public Class11(string string_1)
    {
      if (!Directory.Exists(string_1))
        throw new ArgumentException("path");
      this.string_0 = string_1;
    }

    private string method_0(string string_1)
    {
      return this.string_0 + string_1;
    }

    private NtStatus method_1(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_0_1)
    {
      string str = object_0_1 == null || object_0_1.Length == 0 ? string.Empty : ", " + string.Join(", ", ((IEnumerable<object>) object_0_1).Select<object, string>((Func<object, string>) (object_0_2 => string.Format((IFormatProvider) FormatProviders.DefaultFormatProvider, "{0}", new object[1]
      {
        object_0_2
      }))));
      this.consoleLogger_0.Debug(FormatProviders.DokanFormat(FormattableStringFactory.Create("{0}('{1}', {2}{3}) -> {4}", (object) string_1, (object) string_2, (object) dokanFileInfo_0, (object) str, (object) ntStatus_0)));
      return ntStatus_0;
    }

    private NtStatus method_2(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
    {
      this.consoleLogger_0.Debug(FormatProviders.DokanFormat(FormattableStringFactory.Create("{0}('{1}', {2}, [{3}], [{4}], [{5}], [{6}], [{7}]) -> {8}", (object) string_1, (object) string_2, (object) dokanFileInfo_0, (object) fileAccess_2, (object) fileShare_0, (object) fileMode_0, (object) fileOptions_0, (object) fileAttributes_0, (object) ntStatus_0)));
      return ntStatus_0;
    }

    public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
    {
      NtStatus ntStatus_0 = NtStatus.Success;
      string path = this.method_0(fileName);
      if (info.IsDirectory)
      {
        try
        {
          switch (mode)
          {
            case FileMode.CreateNew:
              if (Directory.Exists(path))
                return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
              try
              {
                File.GetAttributes(path).HasFlag((Enum) FileAttributes.Directory);
                return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
              }
              catch (IOException ex)
              {
              }
              Directory.CreateDirectory(this.method_0(fileName));
              break;
            case FileMode.Open:
              if (!Directory.Exists(path))
              {
                try
                {
                  if (!File.GetAttributes(path).HasFlag((Enum) FileAttributes.Directory))
                    return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.NotADirectory);
                }
                catch (Exception ex)
                {
                  return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
                }
                return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectPathNotFound);
              }
              new DirectoryInfo(path).EnumerateFileSystemInfos().Any<FileSystemInfo>();
              break;
          }
        }
        catch (UnauthorizedAccessException ex)
        {
          return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
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
          flag1 = Directory.Exists(path) || File.Exists(path);
          flag2 = File.GetAttributes(path).HasFlag((Enum) FileAttributes.Directory);
        }
        catch (IOException ex)
        {
        }
        switch (mode)
        {
          case FileMode.CreateNew:
            if (flag1)
              return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameCollision);
            break;
          case FileMode.Open:
            if (!flag1)
              return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
            if (flag3 | flag2)
            {
              if (flag2 && (access & DokanNet.FileAccess.Delete) == DokanNet.FileAccess.Delete && (access & DokanNet.FileAccess.Synchronize) != DokanNet.FileAccess.Synchronize)
                return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
              info.IsDirectory = flag2;
              info.Context = new object();
              return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.Success);
            }
            break;
          case FileMode.Truncate:
            if (!flag1)
              return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectNameNotFound);
            break;
        }
        try
        {
          info.Context = (object) new FileStream(path, mode, flag4 ? System.IO.FileAccess.Read : System.IO.FileAccess.ReadWrite, share, 4096, options);
          if (flag1 && (mode == FileMode.OpenOrCreate || mode == FileMode.Create))
            ntStatus_0 = NtStatus.ObjectNameCollision;
          if (mode == FileMode.CreateNew || mode == FileMode.Create)
            attributes |= FileAttributes.Archive;
          File.SetAttributes(path, attributes);
        }
        catch (UnauthorizedAccessException ex)
        {
          return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.AccessDenied);
        }
        catch (DirectoryNotFoundException ex)
        {
          return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.ObjectPathNotFound);
        }
        catch (Exception ex)
        {
          if (Marshal.GetHRForException(ex) == -2147024864)
            return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, NtStatus.SharingViolation);
          throw;
        }
      }
      return this.method_2(nameof (CreateFile), fileName, info, access, share, mode, options, attributes, ntStatus_0);
    }

    public void Cleanup(string fileName, DokanFileInfo info)
    {
      if (info.Context != null)
        Console.WriteLine(FormatProviders.DokanFormat(FormattableStringFactory.Create("{0}('{1}', {2} - entering", (object) nameof (Cleanup), (object) fileName, (object) info)));
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
          Directory.Delete(this.method_0(fileName));
        else
          File.Delete(this.method_0(fileName));
      }
      long num = (long) this.method_1(nameof (Cleanup), fileName, info, NtStatus.Success);
    }

    public void CloseFile(string fileName, DokanFileInfo info)
    {
      if (info.Context != null)
        Console.WriteLine(FormatProviders.DokanFormat(FormattableStringFactory.Create("{0}('{1}', {2} - entering", (object) nameof (CloseFile), (object) fileName, (object) info)));
      FileStream context = info.Context as FileStream;
      if (context != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (context.Dispose());
      }
      info.Context = (object) null;
      long num = (long) this.method_1(nameof (CloseFile), fileName, info, NtStatus.Success);
    }

    public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
    {
      if (info.Context == null)
      {
        using (FileStream fileStream = new FileStream(this.method_0(fileName), FileMode.Open, System.IO.FileAccess.Read))
        {
          fileStream.Position = offset;
          bytesRead = fileStream.Read(buffer, 0, buffer.Length);
        }
      }
      else
      {
        FileStream context = info.Context as FileStream;
        lock (context)
        {
          context.Position = offset;
          bytesRead = context.Read(buffer, 0, buffer.Length);
        }
      }
      return this.method_1(nameof (ReadFile), fileName, info, NtStatus.Success, (object) ("out " + bytesRead.ToString()), (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
    {
      if (info.Context == null)
      {
        using (FileStream fileStream = new FileStream(this.method_0(fileName), FileMode.Open, System.IO.FileAccess.Write))
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
      return this.method_1(nameof (WriteFile), fileName, info, NtStatus.Success, (object) ("out " + bytesWritten.ToString()), (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).Flush();
        return this.method_1(nameof (FlushFileBuffers), fileName, info, NtStatus.Success);
      }
      catch (IOException ex)
      {
        return this.method_1(nameof (FlushFileBuffers), fileName, info, NtStatus.DiskFull);
      }
    }

    public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
    {
      string str = this.method_0(fileName);
      FileSystemInfo fileSystemInfo = (FileSystemInfo) new FileInfo(str);
      if (!fileSystemInfo.Exists)
        fileSystemInfo = (FileSystemInfo) new DirectoryInfo(str);
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
      return this.method_1(nameof (GetFileInformation), fileName, info, NtStatus.Success);
    }

    public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_4(fileName, "*");
      return this.method_1(nameof (FindFiles), fileName, info, NtStatus.Success);
    }

    public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
    {
      try
      {
        if (attributes != (FileAttributes) 0)
          File.SetAttributes(this.method_0(fileName), attributes);
        return this.method_1(nameof (SetFileAttributes), fileName, info, NtStatus.Success, (object) attributes.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_1(nameof (SetFileAttributes), fileName, info, NtStatus.AccessDenied, (object) attributes.ToString());
      }
      catch (FileNotFoundException ex)
      {
        return this.method_1(nameof (SetFileAttributes), fileName, info, NtStatus.ObjectNameNotFound, (object) attributes.ToString());
      }
      catch (DirectoryNotFoundException ex)
      {
        return this.method_1(nameof (SetFileAttributes), fileName, info, NtStatus.ObjectPathNotFound, (object) attributes.ToString());
      }
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
        string path = this.method_0(fileName);
        if (creationTime.HasValue)
          File.SetCreationTime(path, creationTime.Value);
        if (lastAccessTime.HasValue)
          File.SetLastAccessTime(path, lastAccessTime.Value);
        if (lastWriteTime.HasValue)
          File.SetLastWriteTime(path, lastWriteTime.Value);
        return this.method_1(nameof (SetFileTime), fileName, info, NtStatus.Success, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_1(nameof (SetFileTime), fileName, info, NtStatus.AccessDenied, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
      catch (FileNotFoundException ex)
      {
        return this.method_1(nameof (SetFileTime), fileName, info, NtStatus.ObjectNameNotFound, (object) creationTime, (object) lastAccessTime, (object) lastWriteTime);
      }
    }

    public NtStatus DeleteFile(string fileName, DokanFileInfo info)
    {
      string path = this.method_0(fileName);
      if (Directory.Exists(path))
        return this.method_1(nameof (DeleteFile), fileName, info, NtStatus.AccessDenied);
      if (!File.Exists(path))
        return this.method_1(nameof (DeleteFile), fileName, info, NtStatus.ObjectNameNotFound);
      if (File.GetAttributes(path).HasFlag((Enum) FileAttributes.Directory))
        return this.method_1(nameof (DeleteFile), fileName, info, NtStatus.AccessDenied);
      return this.method_1(nameof (DeleteFile), fileName, info, NtStatus.Success);
    }

    public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
    {
      return this.method_1(nameof (DeleteDirectory), fileName, info, Directory.EnumerateFileSystemEntries(this.method_0(fileName)).Any<string>() ? NtStatus.DirectoryNotEmpty : NtStatus.Success);
    }

    public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
    {
      string str1 = this.method_0(oldName);
      string str2 = this.method_0(newName);
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
          return this.method_1(nameof (MoveFile), oldName, info, NtStatus.Success, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        }
        if (replace)
        {
          info.Context = (object) null;
          if (info.IsDirectory)
            return this.method_1(nameof (MoveFile), oldName, info, NtStatus.AccessDenied, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
          File.Delete(str2);
          File.Move(str1, str2);
          return this.method_1(nameof (MoveFile), oldName, info, NtStatus.Success, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
        }
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_1(nameof (MoveFile), oldName, info, NtStatus.AccessDenied, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      return this.method_1(nameof (MoveFile), oldName, info, NtStatus.ObjectNameCollision, (object) newName, (object) replace.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).SetLength(length);
        return this.method_1(nameof (SetEndOfFile), fileName, info, NtStatus.Success, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_1(nameof (SetEndOfFile), fileName, info, NtStatus.DiskFull, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).SetLength(length);
        return this.method_1(nameof (SetAllocationSize), fileName, info, NtStatus.Success, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_1(nameof (SetAllocationSize), fileName, info, NtStatus.DiskFull, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      try
      {
        ((FileStream) info.Context).Lock(offset, length);
        return this.method_1(nameof (LockFile), fileName, info, NtStatus.Success, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_1(nameof (LockFile), fileName, info, NtStatus.AccessDenied, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      try
      {
        ((FileStream) info.Context).Unlock(offset, length);
        return this.method_1(nameof (UnlockFile), fileName, info, NtStatus.Success, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_1(nameof (UnlockFile), fileName, info, NtStatus.AccessDenied, (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
    {
      DriveInfo driveInfo = ((IEnumerable<DriveInfo>) DriveInfo.GetDrives()).Single<DriveInfo>((Func<DriveInfo, bool>) (driveInfo_0 => string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase)));
      freeBytesAvailable = driveInfo.TotalFreeSpace;
      totalNumberOfBytes = driveInfo.TotalSize;
      totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
      return this.method_1(nameof (GetDiskFreeSpace), (string) null, info, NtStatus.Success, (object) ("out " + freeBytesAvailable.ToString()), (object) ("out " + totalNumberOfBytes.ToString()), (object) ("out " + totalNumberOfFreeBytes.ToString()));
    }

    public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
    {
      volumeLabel = "DOKAN";
      fileSystemName = "NTFS";
      features = FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage;
      return this.method_1(nameof (GetVolumeInformation), (string) null, info, NtStatus.Success, (object) ("out " + volumeLabel), (object) ("out " + features.ToString()), (object) ("out " + fileSystemName));
    }

    public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      try
      {
        security = info.IsDirectory ? (FileSystemSecurity) Directory.GetAccessControl(this.method_0(fileName)) : (FileSystemSecurity) File.GetAccessControl(this.method_0(fileName));
        return this.method_1(nameof (GetFileSecurity), fileName, info, NtStatus.Success, (object) sections.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        security = (FileSystemSecurity) null;
        return this.method_1(nameof (GetFileSecurity), fileName, info, NtStatus.AccessDenied, (object) sections.ToString());
      }
    }

    public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      try
      {
        if (info.IsDirectory)
          Directory.SetAccessControl(this.method_0(fileName), (DirectorySecurity) security);
        else
          File.SetAccessControl(this.method_0(fileName), (FileSecurity) security);
        return this.method_1(nameof (SetFileSecurity), fileName, info, NtStatus.Success, (object) sections.ToString());
      }
      catch (UnauthorizedAccessException ex)
      {
        return this.method_1(nameof (SetFileSecurity), fileName, info, NtStatus.AccessDenied, (object) sections.ToString());
      }
    }

    public NtStatus Mounted(DokanFileInfo info)
    {
      return this.method_1(nameof (Mounted), (string) null, info, NtStatus.Success);
    }

    public NtStatus Unmounted(DokanFileInfo info)
    {
      return this.method_1(nameof (Unmounted), (string) null, info, NtStatus.Success);
    }

    public NtStatus method_3(string string_1, IntPtr intptr_0, out string string_2, out long long_0, DokanFileInfo dokanFileInfo_0)
    {
      string_2 = string.Empty;
      long_0 = 0L;
      return this.method_1("FindStreams", string_1, dokanFileInfo_0, NtStatus.NotImplemented, (object) intptr_0.ToString(), (object) ("out " + string_2), (object) ("out " + long_0.ToString()));
    }

    public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
    {
      streams = (IList<FileInformation>) new FileInformation[0];
      return this.method_1(nameof (FindStreams), fileName, info, NtStatus.NotImplemented);
    }

    public IList<FileInformation> method_4(string string_1, string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return (IList<FileInformation>) new DirectoryInfo(this.method_0(string_1)).EnumerateFileSystemInfos().Where<FileSystemInfo>(new Func<FileSystemInfo, bool>(new Class11.Class12()
      {
        string_0 = string_2
      }.method_0)).Select<FileSystemInfo, FileInformation>((Func<FileSystemInfo, FileInformation>) (fileSystemInfo_0 =>
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
      })).ToArray<FileInformation>();
    }

    public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_4(fileName, searchPattern);
      return this.method_1(nameof (FindFilesWithPattern), fileName, info, NtStatus.Success);
    }
  }
}
