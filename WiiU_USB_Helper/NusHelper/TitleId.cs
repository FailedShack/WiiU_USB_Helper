using System;
using ns0;

namespace NusHelper
{
	// Token: 0x0200005C RID: 92
	public class TitleId : IEquatable<TitleId>
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00023754 File Offset: 0x00021954
		public TitleId(string id)
		{
			id = id.ToUpper();
			this.IdRaw = id.Substring(0, 16);
			string text = id.Substring(0, 8);
			uint num = Class198.smethod_0(text);
			if (num <= 792022325u)
			{
				if (num <= 407918885u)
				{
					if (num != 307253171u)
					{
						if (num == 407918885u)
						{
							if (text == "0005000E")
							{
								this.System = GEnum3.const_1;
								this.IdType = 0;
								goto IL_1A6;
							}
						}
					}
					else if (text == "0005000C")
					{
						this.System = GEnum3.const_1;
						this.IdType = 2;
						goto IL_1A6;
					}
				}
				else if (num != 769560898u)
				{
					if (num == 792022325u)
					{
						if (text == "00010001")
						{
							this.System = GEnum3.const_3;
							this.IdType = 1;
							goto IL_1A6;
						}
					}
				}
				else if (text == "0004000E")
				{
					this.System = GEnum3.const_0;
					this.IdType = 0;
					goto IL_1A6;
				}
			}
			else if (num <= 3135102009u)
			{
				if (num != 2583915261u)
				{
					if (num == 3135102009u)
					{
						if (text == "00040000")
						{
							this.System = GEnum3.const_0;
							this.IdType = 3;
							goto IL_1A6;
						}
					}
				}
				else if (text == "00048004")
				{
					this.System = GEnum3.const_0;
					this.IdType = 4;
					goto IL_1A6;
				}
			}
			else if (num != 3276788566u)
			{
				if (num == 3622932888u)
				{
					if (text == "0004008C")
					{
						this.System = GEnum3.const_0;
						this.IdType = 2;
						goto IL_1A6;
					}
				}
			}
			else if (text == "00050000")
			{
				this.System = GEnum3.const_1;
				this.IdType = 1;
				goto IL_1A6;
			}
			this.System = GEnum3.const_1;
			this.IdType = 5;
			IL_1A6:
			this.Low = id.Substring(0, 8);
			this.High = id.Substring(8, 8);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00023924 File Offset: 0x00021B24
		public TitleId FullDlc
		{
			get
			{
				switch (this.System)
				{
				case GEnum3.const_0:
					return new TitleId("0004008C" + this.High);
				case GEnum3.const_1:
					return new TitleId("0005000C" + this.High);
				case GEnum3.const_2:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00023984 File Offset: 0x00021B84
		public TitleId FullGame
		{
			get
			{
				switch (this.System)
				{
				case GEnum3.const_0:
					return new TitleId(((this.IdType != GEnum1.const_4) ? "00040000" : "00048004") + this.High);
				case GEnum3.const_1:
					return new TitleId("00050000" + this.High);
				case GEnum3.const_2:
					throw new NotImplementedException();
				case GEnum3.const_3:
					return new TitleId("00010001" + this.High);
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00023A0C File Offset: 0x00021C0C
		public TitleId FullUpdate
		{
			get
			{
				switch (this.System)
				{
				case GEnum3.const_0:
					return new TitleId("0004000E" + this.High);
				case GEnum3.const_1:
					return new TitleId("0005000E" + this.High);
				case GEnum3.const_2:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00011C12 File Offset: 0x0000FE12
		public GEnum1 IdType { get; }

		// Token: 0x06000218 RID: 536 RVA: 0x00011C1A File Offset: 0x0000FE1A
		public static explicit operator TitleId(string id)
		{
			return new TitleId(id);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00011C22 File Offset: 0x0000FE22
		public static implicit operator string(TitleId id)
		{
			return id.IdRaw;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00011C2A File Offset: 0x0000FE2A
		public bool Equals(TitleId other)
		{
			return other != null && other.IdRaw == this.IdRaw;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00011C42 File Offset: 0x0000FE42
		public override bool Equals(object other)
		{
			return other is TitleId && ((TitleId)other).IdRaw == this.IdRaw;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00011C64 File Offset: 0x0000FE64
		public override int GetHashCode()
		{
			return this.IdRaw.GetHashCode();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011C71 File Offset: 0x0000FE71
		public string ToSplitString()
		{
			return this.IdRaw.Insert(8, "-");
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00011C22 File Offset: 0x0000FE22
		public override string ToString()
		{
			return this.IdRaw;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00011C84 File Offset: 0x0000FE84
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00011C8C File Offset: 0x0000FE8C
		internal string High { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00011C95 File Offset: 0x0000FE95
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00011C9D File Offset: 0x0000FE9D
		internal string Low { get; set; }

		// Token: 0x04000165 RID: 357
		public readonly string IdRaw;

		// Token: 0x04000169 RID: 361
		private const string DlcLow3DS = "0004008C";

		// Token: 0x0400016A RID: 362
		private const string DlcLowSwitch = null;

		// Token: 0x0400016B RID: 363
		private const string DlcLowWiiu = "0005000C";

		// Token: 0x0400016C RID: 364
		private const string GameLow3DS = "00040000";

		// Token: 0x0400016D RID: 365
		private const string GameLowDsi = "00048004";

		// Token: 0x0400016E RID: 366
		private const string GameLowSwitch = null;

		// Token: 0x0400016F RID: 367
		private const string GameLowWii = "00010001";

		// Token: 0x04000170 RID: 368
		private const string GameLowWiiu = "00050000";

		// Token: 0x04000171 RID: 369
		private const string UpdateLow3DS = "0004000E";

		// Token: 0x04000172 RID: 370
		private const string UpdateLowSwitch = null;

		// Token: 0x04000173 RID: 371
		private const string UpdateLowWiiu = "0005000E";

		// Token: 0x04000174 RID: 372
		private readonly GEnum3 System;
	}
}
