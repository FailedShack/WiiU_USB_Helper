using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000024 RID: 36
	public class GClass14
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00010DCE File Offset: 0x0000EFCE
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00010DD6 File Offset: 0x0000EFD6
		[JsonProperty("category")]
		public string Category { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00010DDF File Offset: 0x0000EFDF
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00010DE7 File Offset: 0x0000EFE7
		[JsonProperty("creator")]
		public string Creator { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		[JsonProperty("date")]
		public long Date { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00010E01 File Offset: 0x0000F001
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00010E09 File Offset: 0x0000F009
		[JsonProperty("description")]
		public string Description { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00010E12 File Offset: 0x0000F012
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00010E1A File Offset: 0x0000F01A
		[JsonProperty("download_link")]
		public string DownloadLink { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00010E23 File Offset: 0x0000F023
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00010E2B File Offset: 0x0000F02B
		[JsonProperty("files")]
		public string[] Files { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00010E34 File Offset: 0x0000F034
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00010E3C File Offset: 0x0000F03C
		[JsonProperty("md5")]
		public string Md5 { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00010E45 File Offset: 0x0000F045
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00010E4D File Offset: 0x0000F04D
		[JsonProperty("name")]
		public string Name { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00010E56 File Offset: 0x0000F056
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00010E5E File Offset: 0x0000F05E
		[JsonProperty("original_link")]
		public string OriginalLink { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00010E67 File Offset: 0x0000F067
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00010E6F File Offset: 0x0000F06F
		[JsonProperty("pictures")]
		public string[] Pictures { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00010E78 File Offset: 0x0000F078
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00010E80 File Offset: 0x0000F080
		[JsonProperty("recommended_mods")]
		public string[] RecommendedMods { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00010E89 File Offset: 0x0000F089
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00010E91 File Offset: 0x0000F091
		[JsonProperty("required_mods")]
		public string[] RequiredMods { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00010E9A File Offset: 0x0000F09A
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00010EA2 File Offset: 0x0000F0A2
		[JsonProperty("size")]
		public long Size { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00010EAB File Offset: 0x0000F0AB
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00010EB3 File Offset: 0x0000F0B3
		[JsonProperty("titleid")]
		public string Titleid { get; set; }

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400005E RID: 94
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400005F RID: 95
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000060 RID: 96
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private string[] string_4;

		// Token: 0x04000063 RID: 99
		[CompilerGenerated]
		private string string_5;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private string string_6;

		// Token: 0x04000065 RID: 101
		[CompilerGenerated]
		private string string_7;

		// Token: 0x04000066 RID: 102
		[CompilerGenerated]
		private string[] string_8;

		// Token: 0x04000067 RID: 103
		[CompilerGenerated]
		private string[] string_9;

		// Token: 0x04000068 RID: 104
		[CompilerGenerated]
		private string[] string_10;

		// Token: 0x04000069 RID: 105
		[CompilerGenerated]
		private long long_1;

		// Token: 0x0400006A RID: 106
		[CompilerGenerated]
		private string string_11;
	}
}
