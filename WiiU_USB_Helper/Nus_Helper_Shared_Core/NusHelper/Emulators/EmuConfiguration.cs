using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Nus_Helper_Shared_Core.NusHelper.Emulators
{
	// Token: 0x0200002B RID: 43
	public class EmuConfiguration
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000F3 RID: 243 RVA: 0x0001E694 File Offset: 0x0001C894
		// (remove) Token: 0x060000F4 RID: 244 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		public event EventHandler ConfigChanged;

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000110A4 File Offset: 0x0000F2A4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000110AC File Offset: 0x0000F2AC
		[JsonProperty("autoUpdate")]
		[DisplayName("Update automatically")]
		[Description("If you check this, the emulator will always be kept up to date. Disable it if you want to use your own version.")]
		public bool AutoUpdate
		{
			get
			{
				return this._autoUpdate;
			}
			set
			{
				this._autoUpdate = value;
				this.FireChange();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000110BB File Offset: 0x0000F2BB
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000110C3 File Offset: 0x0000F2C3
		[JsonProperty("rootPath")]
		[DisplayName("Installation Path")]
		[Description("The location where the emulator and its games will be stored. The emulator must be in a subdirectory called BIN. Disable automatic updates if you don't want your version to be overwritten.")]
		public string RootPath
		{
			get
			{
				return this._rootPath;
			}
			set
			{
				this._rootPath = value;
				this.FireChange();
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000110D2 File Offset: 0x0000F2D2
		private void FireChange()
		{
			EventHandler configChanged = this.ConfigChanged;
			if (configChanged == null)
			{
				return;
			}
			configChanged(this, null);
		}

		// Token: 0x04000079 RID: 121
		private bool _autoUpdate;

		// Token: 0x0400007A RID: 122
		private string _rootPath;
	}
}
