// Decompiled with JetBrains decompiler
// Type: ns0.Class17
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using DokanNet;
using DokanNet.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;

namespace ns0
{
  internal class Class17 : IDokanOperations
  {
    private readonly ConsoleLogger consoleLogger_0 = new ConsoleLogger("[EshopFs] ");
    private readonly Dictionary<string, List<Class16>> dictionary_1 = new Dictionary<string, List<Class16>>();
    private object object_0 = new object();
    private const DokanNet.FileAccess fileAccess_0 = DokanNet.FileAccess.ReadData | DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Execute | DokanNet.FileAccess.GenericExecute | DokanNet.FileAccess.GenericWrite | DokanNet.FileAccess.GenericRead;
    private const DokanNet.FileAccess fileAccess_1 = DokanNet.FileAccess.WriteData | DokanNet.FileAccess.AppendData | DokanNet.FileAccess.Delete | DokanNet.FileAccess.GenericWrite;
    private readonly string string_0;
    private readonly Dictionary<string, ulong> dictionary_0;
    private GClass30 gclass30_0;
    private GClass95 gclass95_0;
    private GClass13 gclass13_0;
    private Class9 class9_0;
    private List<string> list_0;
    private Process process_0;
    private frmLoadOverlay frmLoadOverlay_0;

    public Class17(string string_1, GClass30 gclass30_1)
    {
      if (!Directory.Exists(string_1))
        Directory.CreateDirectory(string_1);
      if (gclass30_1.System != GEnum3.const_1)
        throw new ArgumentException("Only wup titles are compatible");
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
      this.class9_0 = new Class9(this.gclass30_0);
      foreach (GClass12 file in this.gclass13_0.Files)
        this.method_0(file);
    }

    private bool method_0(GClass12 gclass12_0)
    {
      string str1 = "\\" + gclass12_0.string_0;
      if (string.IsNullOrEmpty(str1))
        return false;
      string str2 = str1;
      string[] strArray1 = str1.Split('\\');
      string[] strArray2 = str2.Split('\\');
      for (int index = 0; index < strArray1.Length; ++index)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class17.Class18 class18 = new Class17.Class18();
        if (!(Path.GetExtension(strArray1[index]) != string.Empty))
        {
          string str3 = string.Join("\\", strArray1, 0, index + 1);
          if (index == 0)
            str3 = "\\" + str3;
          string upper = str3.ToUpper();
          if (!this.dictionary_1.ContainsKey(upper))
            this.dictionary_1.Add(upper, new List<Class16>());
          if (index >= 0 && index < strArray1.Length - 1)
          {
            bool flag = Path.GetExtension(strArray1[index + 1]) == string.Empty;
            List<Class16> source = this.dictionary_1[upper];
            // ISSUE: reference to a compiler-generated field
            class18.fileInformation_0 = new FileInformation()
            {
              Attributes = flag ? FileAttributes.ReadOnly | FileAttributes.Directory : FileAttributes.ReadOnly,
              CreationTime = new DateTime?(DateTime.Now),
              LastAccessTime = new DateTime?(DateTime.Now),
              LastWriteTime = new DateTime?(DateTime.Now),
              Length = flag ? 0L : (long) gclass12_0.uint_2,
              FileName = strArray2[index + 1]
            };
            // ISSUE: reference to a compiler-generated method
            if (source.All<Class16>(new Func<Class16, bool>(class18.method_0)))
            {
              // ISSUE: reference to a compiler-generated field
              source.Add(new Class16()
              {
                fileInformation_0 = class18.fileInformation_0,
                gclass12_0 = gclass12_0
              });
            }
          }
        }
        else
          break;
      }
      return true;
    }

    private string String_0
    {
      get
      {
        return Path.Combine(this.gclass95_0.CurrentGamePath, "optimized.helper");
      }
    }

    public void method_1()
    {
      File.WriteAllText(this.String_0, JsonConvert.SerializeObject((object) this.list_0));
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
      long num = (long) this.method_5(nameof (Cleanup), fileName, info, NtStatus.Success);
    }

    private Stream method_2(string string_1, string string_2, FileMode fileMode_0, System.IO.FileAccess fileAccess_2, FileShare fileShare_0, int int_0, FileOptions fileOptions_0)
    {
      if (!this.list_0.Contains(string_2))
        this.list_0.Add(string_2);
      if (this.dictionary_0 != null)
      {
        lock (this.dictionary_0)
        {
          if (!this.dictionary_0.ContainsKey(string_2))
            this.dictionary_0.Add(string_2, 0UL);
          this.dictionary_0[string_2]++;
        }
      }
      return (Stream) new FileStream(string_1, fileMode_0, fileAccess_2, fileShare_0, int_0, fileOptions_0);
    }

    private string method_3(string string_1)
    {
      return this.string_0 + string_1;
    }

    private bool method_4(string string_1)
    {
      if (!Directory.Exists(string_1))
        return File.Exists(string_1);
      return true;
    }

    private NtStatus method_5(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, NtStatus ntStatus_0, params object[] object_1)
    {
      return ntStatus_0;
    }

    private NtStatus method_6(string string_1, string string_2, DokanFileInfo dokanFileInfo_0, DokanNet.FileAccess fileAccess_2, FileShare fileShare_0, FileMode fileMode_0, FileOptions fileOptions_0, FileAttributes fileAttributes_0, NtStatus ntStatus_0)
    {
      return ntStatus_0;
    }

    public NtStatus FindFiles(string fileName, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_10(fileName, "*");
      return this.method_5(nameof (FindFiles), fileName, info, NtStatus.Success);
    }

    public NtStatus method_7(string string_1, IntPtr intptr_0, out string string_2, out long long_0, DokanFileInfo dokanFileInfo_0)
    {
      string_2 = string.Empty;
      long_0 = 0L;
      return this.method_5("FindStreams", string_1, dokanFileInfo_0, NtStatus.NotImplemented, (object) intptr_0.ToString(), (object) ("out " + string_2), (object) ("out " + long_0.ToString()));
    }

    public NtStatus FindStreams(string fileName, out IList<FileInformation> streams, DokanFileInfo info)
    {
      streams = (IList<FileInformation>) new FileInformation[0];
      return this.method_5(nameof (FindStreams), fileName, info, NtStatus.NotImplemented);
    }

    public NtStatus SetFileTime(string fileName, DateTime? creationTime, DateTime? lastAccessTime, DateTime? lastWriteTime, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus SetFileSecurity(string fileName, FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus WriteFile(string fileName, byte[] buffer, out int bytesWritten, long offset, DokanFileInfo info)
    {
      bytesWritten = 0;
      return NtStatus.AccessDenied;
    }

    public NtStatus FlushFileBuffers(string fileName, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus SetFileAttributes(string fileName, FileAttributes attributes, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus SetAllocationSize(string fileName, long length, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus DeleteFile(string fileName, DokanFileInfo info)
    {
      return NtStatus.CannotDelete;
    }

    public NtStatus DeleteDirectory(string fileName, DokanFileInfo info)
    {
      return NtStatus.CannotDelete;
    }

    public NtStatus MoveFile(string oldName, string newName, bool replace, DokanFileInfo info)
    {
      return NtStatus.AccessDenied;
    }

    public NtStatus SetEndOfFile(string fileName, long length, DokanFileInfo info)
    {
      try
      {
        ((Stream) info.Context).SetLength(length);
        return this.method_5(nameof (SetEndOfFile), fileName, info, NtStatus.Success, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
      catch (IOException ex)
      {
        return this.method_5(nameof (SetEndOfFile), fileName, info, NtStatus.DiskFull, (object) length.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      }
    }

    private Class16 method_8(string string_1)
    {
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class17.Class19 class19 = new Class17.Class19();
        string_1 = string_1.ToUpper();
        string index = Path.GetDirectoryName(string_1) ?? "\\";
        // ISSUE: reference to a compiler-generated field
        class19.string_0 = Path.GetFileName(string_1);
        // ISSUE: reference to a compiler-generated method
        return this.dictionary_1[index].First<Class16>(new Func<Class16, bool>(class19.method_0));
      }
      catch
      {
        Console.WriteLine("NOT FOUND: " + string_1);
        return (Class16) null;
      }
    }

    private bool method_9(string string_1)
    {
      return this.method_8(string_1) != null;
    }

    public NtStatus CreateFile(string fileName, DokanNet.FileAccess access, FileShare share, FileMode mode, FileOptions options, FileAttributes attributes, DokanFileInfo info)
    {
      if (mode != FileMode.Open)
        return NtStatus.AccessDenied;
      if (!this.method_9(fileName))
        return NtStatus.ObjectNameNotFound;
      info.IsDirectory = Path.GetExtension(fileName) == "";
      info.Context = new object();
      return NtStatus.Success;
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
      long num = (long) this.method_5(nameof (CloseFile), fileName, info, NtStatus.Success);
    }

    public NtStatus ReadFile(string fileName, byte[] buffer, out int bytesRead, long offset, DokanFileInfo info)
    {
      if (!File.Exists(this.method_3(fileName)) || this.method_8(fileName).fileInformation_0.Length != new FileInfo(this.method_3(fileName)).Length)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class17.Class20 class20 = new Class17.Class20();
        // ISSUE: reference to a compiler-generated field
        class20.class17_0 = this;
        if (this.process_0 == null)
        {
          try
          {
            this.process_0 = Process.GetProcessesByName("Cemu")[0];
            Thread thread = new Thread((ThreadStart) (() =>
            {
              this.frmLoadOverlay_0 = new frmLoadOverlay(this.process_0);
              int num = (int) this.frmLoadOverlay_0.ShowDialog();
            }));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
          }
          catch
          {
          }
        }
        frmLoadOverlay frmLoadOverlay0_1 = this.frmLoadOverlay_0;
        if (frmLoadOverlay0_1 != null)
          frmLoadOverlay0_1.method_3();
        Directory.CreateDirectory(Path.GetDirectoryName(this.method_3(fileName)));
        // ISSUE: reference to a compiler-generated field
        class20.eventHandler_1 = (EventHandler<bool>) null;
        // ISSUE: reference to a compiler-generated field
        class20.eventHandler_0 = (EventHandler<GStruct0>) null;
        // ISSUE: reference to a compiler-generated field
        class20.bool_0 = false;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class20.eventHandler_1 = new EventHandler<bool>(class20.method_0);
        // ISSUE: reference to a compiler-generated field
        class20.eventHandler_0 = (EventHandler<GStruct0>) ((object_1, gstruct0_0) =>
        {
          frmLoadOverlay frmLoadOverlay0 = this.frmLoadOverlay_0;
          if (frmLoadOverlay0 == null)
            return;
          frmLoadOverlay0.method_7(gstruct0_0.int_1);
        });
        // ISSUE: reference to a compiler-generated field
        this.class9_0.Event_0 += class20.eventHandler_1;
        // ISSUE: reference to a compiler-generated field
        this.class9_0.Event_1 += class20.eventHandler_0;
        this.class9_0.method_1(this.string_0, true, ((IEnumerable<GClass12>) new GClass12[1]
        {
          this.method_8(fileName).gclass12_0
        }).ToList<GClass12>(), false);
        // ISSUE: reference to a compiler-generated field
        while (!class20.bool_0)
          Thread.Sleep(1);
        frmLoadOverlay frmLoadOverlay0_3 = this.frmLoadOverlay_0;
        if (frmLoadOverlay0_3 != null)
          frmLoadOverlay0_3.method_2(500);
      }
      Console.WriteLine("READ " + fileName);
      using (Stream stream = this.method_2(this.method_3(fileName), fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read, 4096, FileOptions.None))
      {
        stream.Position = offset;
        bytesRead = stream.Read(buffer, 0, buffer.Length);
      }
      return this.method_5(nameof (ReadFile), fileName, info, NtStatus.Success, (object) ("out " + (object) bytesRead), (object) offset.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    public NtStatus GetFileInformation(string fileName, out FileInformation fileInfo, DokanFileInfo info)
    {
      Class16 class16 = this.method_8(fileName);
      Console.WriteLine(fileName);
      if (class16 == null)
      {
        fileInfo = new FileInformation();
        return NtStatus.NoSuchFile;
      }
      fileInfo = class16.fileInformation_0;
      return NtStatus.Success;
    }

    public NtStatus LockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      return NtStatus.Success;
    }

    public NtStatus UnlockFile(string fileName, long offset, long length, DokanFileInfo info)
    {
      return NtStatus.Success;
    }

    public NtStatus GetDiskFreeSpace(out long freeBytesAvailable, out long totalNumberOfBytes, out long totalNumberOfFreeBytes, DokanFileInfo info)
    {
      DriveInfo driveInfo = ((IEnumerable<DriveInfo>) DriveInfo.GetDrives()).Single<DriveInfo>((Func<DriveInfo, bool>) (driveInfo_0 => string.Equals(driveInfo_0.RootDirectory.Name, Path.GetPathRoot(this.string_0 + "\\"), StringComparison.OrdinalIgnoreCase)));
      freeBytesAvailable = driveInfo.TotalFreeSpace;
      totalNumberOfBytes = driveInfo.TotalSize;
      totalNumberOfFreeBytes = driveInfo.AvailableFreeSpace;
      return this.method_5(nameof (GetDiskFreeSpace), (string) null, info, NtStatus.Success, (object) ("out " + freeBytesAvailable.ToString()), (object) ("out " + totalNumberOfBytes.ToString()), (object) ("out " + totalNumberOfFreeBytes.ToString()));
    }

    public NtStatus GetVolumeInformation(out string volumeLabel, out FileSystemFeatures features, out string fileSystemName, DokanFileInfo info)
    {
      volumeLabel = "USBHELPER";
      fileSystemName = "NTFS";
      features = FileSystemFeatures.CaseSensitiveSearch | FileSystemFeatures.CasePreservedNames | FileSystemFeatures.UnicodeOnDisk | FileSystemFeatures.PersistentAcls | FileSystemFeatures.SupportsRemoteStorage;
      return this.method_5(nameof (GetVolumeInformation), (string) null, info, NtStatus.Success, (object) ("out " + volumeLabel), (object) ("out " + (object) features), (object) ("out " + fileSystemName));
    }

    public NtStatus GetFileSecurity(string fileName, out FileSystemSecurity security, AccessControlSections sections, DokanFileInfo info)
    {
      security = (FileSystemSecurity) null;
      return NtStatus.NoSuchPrivilege;
    }

    public NtStatus Mounted(DokanFileInfo info)
    {
      return this.method_5(nameof (Mounted), (string) null, info, NtStatus.Success);
    }

    public NtStatus Unmounted(DokanFileInfo info)
    {
      return this.method_5(nameof (Unmounted), (string) null, info, NtStatus.Success);
    }

    public IList<FileInformation> method_10(string string_1, string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class17.Class21 class21 = new Class17.Class21();
      // ISSUE: reference to a compiler-generated field
      class21.string_0 = string_2;
      try
      {
        List<FileInformation> fileInformationList = new List<FileInformation>();
        string_1 = string_1.ToUpper();
        if (this.dictionary_1.ContainsKey(string_1))
        {
          // ISSUE: reference to a compiler-generated method
          fileInformationList.AddRange(this.dictionary_1[string_1].Where<Class16>(new Func<Class16, bool>(class21.method_0)).Select<Class16, FileInformation>((Func<Class16, FileInformation>) (class16_0 => class16_0.fileInformation_0)));
        }
        return (IList<FileInformation>) fileInformationList;
      }
      catch (Exception ex)
      {
        return (IList<FileInformation>) new List<FileInformation>();
      }
    }

    public NtStatus FindFilesWithPattern(string fileName, string searchPattern, out IList<FileInformation> files, DokanFileInfo info)
    {
      files = this.method_10(fileName, searchPattern);
      return this.method_5(nameof (FindFilesWithPattern), fileName, info, NtStatus.Success);
    }
  }
}
