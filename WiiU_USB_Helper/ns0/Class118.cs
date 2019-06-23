using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Paloma;

namespace ns0
{
	// Token: 0x02000157 RID: 343
	internal class Class118 : GClass138
	{
		// Token: 0x0600093B RID: 2363 RVA: 0x00038DA0 File Offset: 0x00036FA0
		public Class118(Game game_0) : base(game_0)
		{
			this.gclass141_0 = new GClass141(null, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight))
			{
				color_0 = Microsoft.Xna.Framework.Color.Blue,
				Opacity = 0.30000001192092896
			};
			this.gclass141_0.method_1(new GClass137(new GClass134(1.0, 1.25, 6000.0)
			{
				IsLooping = true
			}, "Scale"));
			WebBrowser webBrowser = new WebBrowser();
			webBrowser.ScriptErrorsSuppressed = true;
			webBrowser.DocumentText = string.Format("<html><head><title></title></head><body>{0}</body></html>", "<iframe width=\"560\" height=\"315\" src=\"http://www.youtube.com/embed/yg2u_De8j5o?autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>");
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00038EB4 File Offset: 0x000370B4
		public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			this.gclass143_0.method_3(gameTime_0, spriteBatch_0);
			Vector2 vector = this.method_13(this.int_9, this.int_10);
			if (this.GClass32_0 != null)
			{
				string text = new string(this.GClass32_0.Name.Where(new Func<char, bool>(this.method_20)).ToArray<char>());
				Vector2 vector2 = this.spriteFont_0.MeasureString(text);
				int num = 20;
				float num2 = vector2.X + (float)(2 * num);
				float num3 = vector2.Y + (float)(2 * num);
				spriteBatch_0.smethod_0(new Microsoft.Xna.Framework.Rectangle((int)(vector.X - num2 / 2f), (int)(vector.Y + 64f + 12f), (int)num2, (int)num3), this.texture2D_3, 30, Microsoft.Xna.Framework.Color.White);
				spriteBatch_0.DrawString(this.spriteFont_0, text, new Vector2(vector.X - num2 / 2f + (float)num, vector.Y + 64f + 12f + (float)num), Microsoft.Xna.Framework.Color.Black);
			}
			try
			{
				string text2 = DateTime.Now.ToShortTimeString();
				Vector2 vector3 = this.spriteFont_0.MeasureString(text2);
				spriteBatch_0.DrawString(this.spriteFont_0, text2, new Vector2((float)GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth - vector3.X - 25f, 0f), Microsoft.Xna.Framework.Color.White);
			}
			catch
			{
			}
			if (this.bool_2)
			{
				if (this.float_0 < 1f)
				{
					spriteBatch_0.Draw(this.texture2D_2, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White * this.float_0);
					this.float_0 += 0.01f;
					return;
				}
				base.method_0();
				MediaPlayer.Stop();
				spriteBatch_0.Draw(this.texture2D_2, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White);
				if (this.texture2D_1 != null)
				{
					spriteBatch_0.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White);
					spriteBatch_0.Draw(this.texture2D_5, new Vector2(0f, 0f), Microsoft.Xna.Framework.Color.White);
				}
				if (this.task_0 == null)
				{
					Class118.Class115 @class = new Class118.Class115();
					@class.class118_0 = this;
					@class.gclass95_0 = this.GClass32_0.method_14(true);
					@class.gclass95_0.FullScreen = true;
					@class.gclass95_0.Event_0 += this.method_21;
					if (File.Exists(@class.gclass95_0.String_1) && File.Exists(@class.gclass95_0.String_2))
					{
						using (Bitmap bitmap = TargaImage.LoadTargaImage(@class.gclass95_0.String_1))
						{
							using (MemoryStream memoryStream = new MemoryStream())
							{
								bitmap.Save(memoryStream, ImageFormat.Png);
								this.texture2D_1 = Texture2D.FromStream(GClass138.graphicsDevice_0, memoryStream);
							}
						}
						this.method_17(this.GClass32_0, 1f);
					}
					this.task_0 = Task.Delay((this.GClass32_0.System == GEnum3.const_1) ? 7000 : 1000).ContinueWith(new Action<Task>(@class.method_0));
					return;
				}
			}
			else
			{
				Texture2D texture2D = this.texture2D_1;
				if (texture2D != null)
				{
					texture2D.Dispose();
				}
				this.texture2D_1 = null;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00039254 File Offset: 0x00037454
		public override void vmethod_1()
		{
			Texture2D texture2D = this.contentManager_0.Load<Texture2D>("Images/uiHelpKeyboard");
			this.gclass141_1 = new GClass141(texture2D, new Microsoft.Xna.Framework.Rectangle(0, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight - texture2D.Height, texture2D.Width, texture2D.Height));
			this.soundEffect_1 = this.contentManager_0.Load<SoundEffect>("cursorMove");
			this.soundEffect_2 = this.contentManager_0.Load<SoundEffect>("cursorOk");
			this.video_0 = this.contentManager_0.Load<Video>("bgVid");
			this.spriteFont_0 = this.contentManager_0.Load<SpriteFont>("base");
			this.texture2D_0 = this.contentManager_0.Load<Texture2D>("Images/bgTest");
			this.texture2D_5 = this.contentManager_0.Load<Texture2D>("Images/videoBg");
			this.texture2D_3 = this.contentManager_0.Load<Texture2D>("Images/rectangleText");
			this.texture2D_4 = this.contentManager_0.Load<Texture2D>("Images/sel");
			this.gclass142_0 = new GClass142(this.video_0)
			{
				IsLooping = true
			};
			this.int_5 = (GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight - 5 * (128 + this.int_3)) / 2;
			this.int_6 = (GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth - 10 * (128 + this.int_3)) / 2;
			this.texture2D_2 = new Texture2D(GClass138.graphicsDevice_0, 1, 1);
			this.texture2D_2.SetData<Microsoft.Xna.Framework.Color>(new Microsoft.Xna.Framework.Color[]
			{
				Microsoft.Xna.Framework.Color.Black
			});
			Vector2 vector = this.method_13(0, 0);
			this.gclass143_0.Cursor = new GClass141(this.texture2D_4, new Microsoft.Xna.Framework.Rectangle((int)vector.X - this.int_8 / 2, (int)vector.Y - this.int_8 / 2, this.int_8, this.int_8));
			this.gclass143_0.method_5(new Microsoft.Xna.Framework.Rectangle((int)vector.X - this.int_8 / 2, (int)vector.Y - this.int_8 / 2, this.int_8, this.int_8));
			this.gclass143_0.Cursor.method_1(new GClass137(new GClass134(1.0, 1.1, 250.0)
			{
				IsLooping = true
			}, "Scale"));
			this.method_9();
			base.vmethod_1();
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000394B4 File Offset: 0x000376B4
		public void method_9()
		{
			base.method_2(new GClass136(new Vector2((float)(GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth / 2), (float)(GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight / 2)), 0.0, 1.0, 350.0));
			this.gclass143_0.method_2();
			this.gclass143_0.method_0(this.gclass142_0);
			this.gclass143_0.method_0(this.gclass141_0);
			this.gclass143_0.method_0(new GClass141(this.texture2D_0, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight)));
			this.gclass143_0.method_0(this.gclass141_1);
			GClass141[] array = this.list_0.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
			this.list_0.Clear();
			Task.Run(new Action(this.method_22));
			base.method_5();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00015F7C File Offset: 0x0001417C
		public override void vmethod_2()
		{
			this.gclass142_0.Dispose();
			base.vmethod_2();
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000395BC File Offset: 0x000377BC
		public override void vmethod_3(GameTime gameTime_0)
		{
			this.gclass143_0.method_6(gameTime_0);
			if (!this.bool_2)
			{
				Keyboard.GetState();
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Right))
				{
					this.method_16(true, false);
				}
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Left))
				{
					this.method_16(true, true);
				}
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Up))
				{
					this.method_16(false, true);
				}
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Down))
				{
					this.method_16(false, false);
				}
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Enter))
				{
					this.gclass143_0.method_1();
				}
				if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Space) && this.Int32_0 > -1)
				{
					if (this.int_7 == 0)
					{
						try
						{
							this.int_4 = this.Int32_0;
							GClass140 gclass = this.list_0.First(new Func<GClass141, bool>(this.method_23));
							this.int_7++;
							gclass.color_0 = Microsoft.Xna.Framework.Color.Orange;
							goto IL_1E6;
						}
						catch
						{
							goto IL_1E6;
						}
					}
					if (this.int_7 == 1)
					{
						GClass141 gclass2 = null;
						GClass141 gclass3 = null;
						try
						{
							gclass2 = this.list_0.First(new Func<GClass141, bool>(this.method_24));
						}
						catch
						{
						}
						try
						{
							gclass3 = this.list_0.First(new Func<GClass141, bool>(this.method_25));
						}
						catch
						{
						}
						if (gclass2 == gclass3)
						{
							gclass2.color_0 = Microsoft.Xna.Framework.Color.White;
							this.int_7 = 0;
							return;
						}
						GClass32 gclass4 = this.gclass32_0[this.int_4];
						this.gclass32_0[this.int_4] = this.gclass32_0[this.Int32_0];
						this.gclass32_0[this.Int32_0] = gclass4;
						gclass2.color_0 = Microsoft.Xna.Framework.Color.White;
						if (gclass3 != null)
						{
							gclass3.method_3(gclass2.Vector2_0, true, 2f);
						}
						if (gclass2 != null)
						{
							gclass2.method_3(this.method_12(this.int_9, this.int_10), true, 2f);
						}
						this.method_19();
						this.int_7 = 0;
					}
				}
				IL_1E6:
				try
				{
					if (GamePad.GetCapabilities(PlayerIndex.One).IsConnected)
					{
						GamePadState state = GamePad.GetState(PlayerIndex.One);
						if (state.ThumbSticks.Left.X < 0.5f)
						{
							this.method_16(true, true);
						}
						if (state.ThumbSticks.Left.X > 0.5f)
						{
							this.method_16(true, false);
						}
						if (state.ThumbSticks.Left.Y < 0.5f)
						{
							this.method_16(false, true);
						}
						if (state.ThumbSticks.Left.Y > 0.5f)
						{
							this.method_16(false, false);
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00015F8F File Offset: 0x0001418F
		private GClass32 GClass32_0
		{
			get
			{
				if (this.int_10 * 10 + this.int_9 < this.gclass32_0.Length)
				{
					return this.gclass32_0[this.int_10 * 10 + this.int_9];
				}
				return null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00015FC4 File Offset: 0x000141C4
		private int Int32_0
		{
			get
			{
				return this.int_10 * 10 + this.int_9;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00039894 File Offset: 0x00037A94
		private void method_10(GClass32 gclass32_1)
		{
			GClass95 gclass = gclass32_1.method_14(false);
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Create(gclass.String_3)))
			{
				byte[] array = new byte[2];
				using (FileStream fileStream = File.Open(gclass.String_2, FileMode.Open))
				{
					binaryWriter.Write(this.byte_0);
					binaryWriter.Write((int)(fileStream.Length + 44L - 8L));
					binaryWriter.Write(this.byte_1);
					binaryWriter.Write((int)fileStream.Length - 8);
					while (fileStream.Read(array, 0, 2) != 0)
					{
						binaryWriter.Write(array[1]);
						binaryWriter.Write(array[0]);
					}
				}
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00015FD6 File Offset: 0x000141D6
		private Vector2 method_11(int int_11)
		{
			return new Vector2((float)(int_11 % 10), (float)(int_11 / 10));
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00015FE7 File Offset: 0x000141E7
		private Vector2 method_12(int int_11, int int_12)
		{
			return new Vector2((float)this.method_14(int_11, this.int_6), (float)this.method_14(int_12, this.int_5));
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001600A File Offset: 0x0001420A
		private Vector2 method_13(int int_11, int int_12)
		{
			return new Vector2((float)(this.method_14(int_11, this.int_6) + 64), (float)(this.method_14(int_12, this.int_5) + 64));
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00016033 File Offset: 0x00014233
		private int method_14(int int_11, int int_12)
		{
			return this.int_3 / 2 + int_12 + int_11 * (128 + this.int_3);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003995C File Offset: 0x00037B5C
		private void method_15()
		{
			this.gclass32_0 = new GClass32[50];
			List<GClass32> list = GClass28.dictionary_0.Values.Where(new Func<GClass32, bool>(Class118.<>c.<>c_0.method_0)).ToList<GClass32>();
			try
			{
				Class118.Class117 @class = new Class118.Class117();
				@class.string_0 = GClass88.smethod_7("guiGames");
				@class.int_0 = 0;
				int i;
				while (@class.int_0 < @class.string_0.Length && @class.int_0 < this.gclass32_0.Length)
				{
					List<GClass32> list2 = list;
					Predicate<GClass32> match;
					if ((match = @class.predicate_0) == null)
					{
						match = (@class.predicate_0 = new Predicate<GClass32>(@class.method_0));
					}
					GClass32 gclass = list2.Find(match);
					if (gclass != null && !this.gclass32_0.Contains(gclass))
					{
						this.gclass32_0[@class.int_0] = gclass;
					}
					i = @class.int_0;
					@class.int_0 = i + 1;
				}
				GClass32[] array = list.Where(new Func<GClass32, bool>(this.method_26)).ToArray<GClass32>();
				i = 0;
				IL_131:
				while (i < array.Length)
				{
					GClass32 gclass2 = array[i];
					for (int j = 0; j < this.gclass32_0.Length; j++)
					{
						if (this.gclass32_0[j] == null)
						{
							this.gclass32_0[j] = gclass2;
							IL_12B:
							i++;
							goto IL_131;
						}
					}
					goto IL_12B;
				}
			}
			catch
			{
				int num = 0;
				while (num < this.gclass32_0.Length && num < list.Count)
				{
					this.gclass32_0[num] = list[num];
					num++;
				}
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00039AEC File Offset: 0x00037CEC
		private void method_16(bool bool_3, bool bool_4)
		{
			SoundEffect soundEffect = this.soundEffect_1;
			if (soundEffect != null)
			{
				soundEffect.Play(0.1f, 0f, 0f);
			}
			if (bool_3 && bool_4 && this.int_9 > 0)
			{
				this.int_9--;
			}
			if (bool_3 && !bool_4 && this.int_9 < 9)
			{
				this.int_9++;
			}
			if (!bool_3 && bool_4 && this.int_10 > 0)
			{
				this.int_10--;
			}
			if (!bool_3 && !bool_4 && this.int_10 < 4)
			{
				this.int_10++;
			}
			Vector2 vector = this.method_13(this.int_9, this.int_10);
			this.gclass143_0.method_5(new Microsoft.Xna.Framework.Rectangle((int)vector.X - this.int_8 / 2, (int)vector.Y - this.int_8 / 2, this.int_8, this.int_8));
			Texture2D texture = this.gclass141_0.Texture;
			if (texture != null)
			{
				texture.Dispose();
			}
			this.gclass141_0.Texture = null;
			this.method_17(this.GClass32_0, 0.15f);
			this.method_18();
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00039C18 File Offset: 0x00037E18
		private void method_17(GClass32 gclass32_1, float float_1 = 1f)
		{
			try
			{
				SoundEffectInstance soundEffectInstance = this.soundEffectInstance_0;
				if (soundEffectInstance != null)
				{
					soundEffectInstance.Stop();
				}
				SoundEffect soundEffect = this.soundEffect_0;
				if (soundEffect != null)
				{
					soundEffect.Dispose();
				}
				this.soundEffectInstance_0 = null;
				this.soundEffect_0 = null;
				if (gclass32_1 != null)
				{
					GClass95 gclass = gclass32_1.method_14(false);
					if (File.Exists(gclass.String_2))
					{
						if (!File.Exists(gclass.String_3))
						{
							this.method_10(this.GClass32_0);
						}
						using (FileStream fileStream = File.OpenRead(gclass.String_3))
						{
							this.soundEffect_0 = SoundEffect.FromStream(fileStream);
						}
						if (this.soundEffect_0 != null)
						{
							this.soundEffectInstance_0 = this.soundEffect_0.CreateInstance();
							this.soundEffect_0.Play(float_1, 0f, 0f);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001604E File Offset: 0x0001424E
		private void method_18()
		{
			if (this.GClass32_0 != null)
			{
				this.GClass32_0.method_28(new Action<GClass74, GClass32>(this.method_27));
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00039D04 File Offset: 0x00037F04
		private void method_19()
		{
			lock (this)
			{
				GClass88.smethod_10("guiGames", this.gclass32_0.Select(new Func<GClass32, string>(Class118.<>c.<>c_0.method_1)).ToArray<string>());
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001606F File Offset: 0x0001426F
		[CompilerGenerated]
		private bool method_20(char char_0)
		{
			return this.spriteFont_0.Characters.Contains(char_0);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00016082 File Offset: 0x00014282
		[CompilerGenerated]
		private void method_21(object sender, EventArgs e)
		{
			base.Hide = false;
			base.method_5();
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00039D74 File Offset: 0x00037F74
		[CompilerGenerated]
		private void method_22()
		{
			this.method_15();
			this.method_19();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if (this.gclass32_0[i * 10 + j] != null)
					{
						try
						{
							using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(this.gclass32_0[i * 10 + j].IconUrl)))
							{
								Class118.Class116 @class = new Class118.Class116();
								@class.class118_0 = this;
								Vector2 vector2_ = this.method_12(j, i);
								@class.gclass141_0 = new GClass141(Texture2D.FromStream(GClass138.graphicsDevice_0, memoryStream), new Microsoft.Xna.Framework.Rectangle(0, 0, 128, 128))
								{
									Tag = this.gclass32_0[i * 10 + j]
								};
								@class.gclass141_0.Event_0 += @class.method_0;
								@class.gclass141_0.method_3(vector2_, true, 2f);
								this.list_0.Add(@class.gclass141_0);
								@class.gclass141_0.method_1(new GClass137(new GClass134(1.0, 0.75, 1000.0)
								{
									IsLooping = true
								}, "Opacity"));
								this.gclass143_0.method_0(@class.gclass141_0);
							}
							goto IL_147;
						}
						catch
						{
							goto IL_147;
						}
						break;
					}
					IL_147:;
				}
			}
			this.method_18();
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00016091 File Offset: 0x00014291
		[CompilerGenerated]
		private bool method_23(GClass141 gclass141_2)
		{
			return gclass141_2.Tag == this.gclass32_0[this.int_4];
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00016091 File Offset: 0x00014291
		[CompilerGenerated]
		private bool method_24(GClass141 gclass141_2)
		{
			return gclass141_2.Tag == this.gclass32_0[this.int_4];
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000160A8 File Offset: 0x000142A8
		[CompilerGenerated]
		private bool method_25(GClass141 gclass141_2)
		{
			return gclass141_2.Tag == this.gclass32_0[this.Int32_0];
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000160BF File Offset: 0x000142BF
		[CompilerGenerated]
		private bool method_26(GClass32 gclass32_1)
		{
			return !this.gclass32_0.Contains(gclass32_1);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00039F0C File Offset: 0x0003810C
		[CompilerGenerated]
		private void method_27(GClass74 gclass74_0, GClass32 gclass32_1)
		{
			try
			{
				if (gclass32_1 == this.GClass32_0)
				{
					Texture2D texture = this.gclass141_0.Texture;
					if (texture != null)
					{
						texture.Dispose();
					}
					this.gclass141_0.Texture = null;
					GClass141 gclass = this.gclass141_0;
					if (gclass != null)
					{
						gclass.method_5();
					}
					if (gclass74_0.Screenshots != null && gclass74_0.Screenshots.Screenshot.Count >= 3)
					{
						Texture2D texture2D = base.method_4(gclass74_0.Screenshots.Screenshot[0].ImageUrl[0].Value);
						if (gclass32_1 == this.GClass32_0)
						{
							this.gclass141_0.Texture = texture2D;
						}
						else if (texture2D != null)
						{
							texture2D.Dispose();
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000583 RID: 1411
		private const int int_0 = 10;

		// Token: 0x04000584 RID: 1412
		private const int int_1 = 5;

		// Token: 0x04000585 RID: 1413
		private const int int_2 = 5;

		// Token: 0x04000586 RID: 1414
		private readonly int int_3 = 48;

		// Token: 0x04000587 RID: 1415
		private readonly byte[] byte_0 = new byte[]
		{
			82,
			73,
			70,
			70
		};

		// Token: 0x04000588 RID: 1416
		private readonly byte[] byte_1 = new byte[]
		{
			87,
			65,
			86,
			69,
			102,
			109,
			116,
			32,
			16,
			0,
			0,
			0,
			1,
			0,
			2,
			0,
			128,
			187,
			0,
			0,
			0,
			238,
			2,
			0,
			4,
			0,
			16,
			0,
			100,
			97,
			116,
			97
		};

		// Token: 0x04000589 RID: 1417
		private float float_0;

		// Token: 0x0400058A RID: 1418
		private Video video_0;

		// Token: 0x0400058B RID: 1419
		private Texture2D texture2D_0;

		// Token: 0x0400058C RID: 1420
		private GClass142 gclass142_0;

		// Token: 0x0400058D RID: 1421
		private Texture2D texture2D_1;

		// Token: 0x0400058E RID: 1422
		private SoundEffect soundEffect_0;

		// Token: 0x0400058F RID: 1423
		private SoundEffectInstance soundEffectInstance_0;

		// Token: 0x04000590 RID: 1424
		private SoundEffect soundEffect_1;

		// Token: 0x04000591 RID: 1425
		private SoundEffect soundEffect_2;

		// Token: 0x04000592 RID: 1426
		private Texture2D texture2D_2;

		// Token: 0x04000593 RID: 1427
		private SpriteFont spriteFont_0;

		// Token: 0x04000594 RID: 1428
		private int int_4 = -1;

		// Token: 0x04000595 RID: 1429
		private int int_5;

		// Token: 0x04000596 RID: 1430
		private int int_6;

		// Token: 0x04000597 RID: 1431
		private bool bool_2;

		// Token: 0x04000598 RID: 1432
		private Task task_0;

		// Token: 0x04000599 RID: 1433
		private Texture2D texture2D_3;

		// Token: 0x0400059A RID: 1434
		private GClass141 gclass141_0;

		// Token: 0x0400059B RID: 1435
		private Texture2D texture2D_4;

		// Token: 0x0400059C RID: 1436
		private int int_7;

		// Token: 0x0400059D RID: 1437
		private int int_8 = 152;

		// Token: 0x0400059E RID: 1438
		private int int_9;

		// Token: 0x0400059F RID: 1439
		private int int_10;

		// Token: 0x040005A0 RID: 1440
		private GClass141 gclass141_1;

		// Token: 0x040005A1 RID: 1441
		private Texture2D texture2D_5;

		// Token: 0x040005A2 RID: 1442
		private List<GClass141> list_0 = new List<GClass141>();

		// Token: 0x040005A3 RID: 1443
		private GClass32[] gclass32_0 = new GClass32[50];

		// Token: 0x02000158 RID: 344
		[CompilerGenerated]
		private sealed class Class115
		{
			// Token: 0x06000956 RID: 2390 RVA: 0x00039FD4 File Offset: 0x000381D4
			internal void method_0(Task task_0)
			{
				SoundEffectInstance soundEffectInstance_ = this.class118_0.soundEffectInstance_0;
				if (soundEffectInstance_ != null)
				{
					soundEffectInstance_.Stop();
				}
				SoundEffect soundEffect_ = this.class118_0.soundEffect_0;
				if (soundEffect_ != null)
				{
					soundEffect_.Dispose();
				}
				this.class118_0.soundEffectInstance_0 = null;
				this.class118_0.soundEffect_0 = null;
				this.class118_0.texture2D_1 = null;
				this.class118_0.float_0 = 0f;
				this.class118_0.task_0 = null;
				this.class118_0.bool_2 = false;
				this.class118_0.Hide = true;
				this.class118_0.GClass32_0.method_13(this.gclass95_0);
			}

			// Token: 0x040005A4 RID: 1444
			public GClass95 gclass95_0;

			// Token: 0x040005A5 RID: 1445
			public Class118 class118_0;
		}

		// Token: 0x02000159 RID: 345
		[CompilerGenerated]
		private sealed class Class116
		{
			// Token: 0x06000958 RID: 2392 RVA: 0x0003A07C File Offset: 0x0003827C
			internal void method_0(object sender, EventArgs e)
			{
				SoundEffect soundEffect_ = this.class118_0.soundEffect_2;
				if (soundEffect_ != null)
				{
					soundEffect_.Play();
				}
				this.class118_0.method_2(new GClass136(this.gclass141_0.Rectangle.Center.ToVector2(), 1.0, 10.0, 650.0));
				this.class118_0.bool_2 = true;
			}

			// Token: 0x040005A6 RID: 1446
			public GClass141 gclass141_0;

			// Token: 0x040005A7 RID: 1447
			public Class118 class118_0;
		}

		// Token: 0x0200015A RID: 346
		[CompilerGenerated]
		private sealed class Class117
		{
			// Token: 0x0600095A RID: 2394 RVA: 0x000160D0 File Offset: 0x000142D0
			internal bool method_0(GClass32 gclass32_0)
			{
				return gclass32_0.TitleId.IdRaw == this.string_0[this.int_0];
			}

			// Token: 0x040005A8 RID: 1448
			public string[] string_0;

			// Token: 0x040005A9 RID: 1449
			public int int_0;

			// Token: 0x040005AA RID: 1450
			public Predicate<GClass32> predicate_0;
		}
	}
}
