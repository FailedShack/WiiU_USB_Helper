// Decompiled with JetBrains decompiler
// Type: ns0.Class120
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Paloma;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns0
{
  internal class Class120 : GClass138
  {
    private readonly int int_3 = 48;
    private readonly byte[] byte_0 = new byte[4]{ (byte) 82, (byte) 73, (byte) 70, (byte) 70 };
    private readonly byte[] byte_1 = new byte[32]{ (byte) 87, (byte) 65, (byte) 86, (byte) 69, (byte) 102, (byte) 109, (byte) 116, (byte) 32, (byte) 16, (byte) 0, (byte) 0, (byte) 0, (byte) 1, (byte) 0, (byte) 2, (byte) 0, (byte) 128, (byte) 187, (byte) 0, (byte) 0, (byte) 0, (byte) 238, (byte) 2, (byte) 0, (byte) 4, (byte) 0, (byte) 16, (byte) 0, (byte) 100, (byte) 97, (byte) 116, (byte) 97 };
    private int int_4 = -1;
    private int int_8 = 152;
    private List<GClass141> list_0 = new List<GClass141>();
    private GClass32[] gclass32_0 = new GClass32[50];
    private const int int_0 = 10;
    private const int int_1 = 5;
    private const int int_2 = 5;
    private float float_0;
    private Video video_0;
    private Texture2D texture2D_0;
    private GClass142 gclass142_0;
    private Texture2D texture2D_1;
    private SoundEffect soundEffect_0;
    private SoundEffectInstance soundEffectInstance_0;
    private SoundEffect soundEffect_1;
    private SoundEffect soundEffect_2;
    private Texture2D texture2D_2;
    private SpriteFont spriteFont_0;
    private int int_5;
    private int int_6;
    private bool bool_2;
    private Task task_0;
    private Texture2D texture2D_3;
    private GClass141 gclass141_0;
    private Texture2D texture2D_4;
    private int int_7;
    private int int_9;
    private int int_10;
    private GClass141 gclass141_1;
    private Texture2D texture2D_5;

    public Class120(Game game_0)
      : base(game_0)
    {
      GClass141 gclass141 = new GClass141((Texture2D) null, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight));
      gclass141.color_0 = Microsoft.Xna.Framework.Color.Blue;
      gclass141.Opacity = 0.300000011920929;
      this.gclass141_0 = gclass141;
      this.gclass141_0.method_1(new GClass137(new GClass134(1.0, 1.25, 6000.0)
      {
        IsLooping = true
      }, "Scale"));
      WebBrowser webBrowser = new WebBrowser() { ScriptErrorsSuppressed = true, DocumentText = string.Format("<html><head><title></title></head><body>{0}</body></html>", (object) "<iframe width=\"560\" height=\"315\" src=\"http://www.youtube.com/embed/yg2u_De8j5o?autoplay=1\" frameborder=\"0\" allowfullscreen></iframe>") };
    }

    public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      this.gclass143_0.method_3(gameTime_0, spriteBatch_0);
      Vector2 vector2_1 = this.method_13(this.int_9, this.int_10);
      if (this.GClass32_0 != null)
      {
        string text = new string(this.GClass32_0.Name.Where<char>((Func<char, bool>) (char_0 => this.spriteFont_0.Characters.Contains(char_0))).ToArray<char>());
        Vector2 vector2_2 = this.spriteFont_0.MeasureString(text);
        int num1 = 20;
        float num2 = vector2_2.X + (float) (2 * num1);
        float num3 = vector2_2.Y + (float) (2 * num1);
        spriteBatch_0.smethod_0(new Microsoft.Xna.Framework.Rectangle((int) ((double) vector2_1.X - (double) num2 / 2.0), (int) ((double) vector2_1.Y + 64.0 + 12.0), (int) num2, (int) num3), this.texture2D_3, 30, Microsoft.Xna.Framework.Color.White);
        spriteBatch_0.DrawString(this.spriteFont_0, text, new Vector2(vector2_1.X - num2 / 2f + (float) num1, (float) ((double) vector2_1.Y + 64.0 + 12.0) + (float) num1), Microsoft.Xna.Framework.Color.Black);
      }
      try
      {
        string shortTimeString = DateTime.Now.ToShortTimeString();
        Vector2 vector2_2 = this.spriteFont_0.MeasureString(shortTimeString);
        spriteBatch_0.DrawString(this.spriteFont_0, shortTimeString, new Vector2((float) ((double) GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth - (double) vector2_2.X - 25.0), 0.0f), Microsoft.Xna.Framework.Color.White);
      }
      catch
      {
      }
      if (this.bool_2)
      {
        if ((double) this.float_0 < 1.0)
        {
          spriteBatch_0.Draw(this.texture2D_2, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White * this.float_0);
          this.float_0 += 0.01f;
        }
        else
        {
          this.method_0();
          MediaPlayer.Stop();
          spriteBatch_0.Draw(this.texture2D_2, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White);
          if (this.texture2D_1 != null)
          {
            spriteBatch_0.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight), Microsoft.Xna.Framework.Color.White);
            spriteBatch_0.Draw(this.texture2D_5, new Vector2(0.0f, 0.0f), Microsoft.Xna.Framework.Color.White);
          }
          if (this.task_0 != null)
            return;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          Class120.Class117 class117 = new Class120.Class117();
          // ISSUE: reference to a compiler-generated field
          class117.class120_0 = this;
          // ISSUE: reference to a compiler-generated field
          class117.gclass95_0 = this.GClass32_0.method_14(true);
          // ISSUE: reference to a compiler-generated field
          class117.gclass95_0.FullScreen = true;
          // ISSUE: reference to a compiler-generated field
          class117.gclass95_0.Event_0 += (EventHandler) ((sender, e) =>
          {
            this.Hide = false;
            this.method_5();
          });
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (File.Exists(class117.gclass95_0.String_1) && File.Exists(class117.gclass95_0.String_2))
          {
            // ISSUE: reference to a compiler-generated field
            using (Bitmap bitmap = TargaImage.LoadTargaImage(class117.gclass95_0.String_1))
            {
              using (MemoryStream memoryStream = new MemoryStream())
              {
                bitmap.Save((Stream) memoryStream, ImageFormat.Png);
                this.texture2D_1 = Texture2D.FromStream(GClass138.graphicsDevice_0, (Stream) memoryStream);
              }
            }
            this.method_17(this.GClass32_0, 1f);
          }
          // ISSUE: reference to a compiler-generated method
          this.task_0 = Task.Delay(this.GClass32_0.System == GEnum3.const_1 ? 7000 : 1000).ContinueWith(new Action<Task>(class117.method_0));
        }
      }
      else
      {
        Texture2D texture2D1 = this.texture2D_1;
        if (texture2D1 != null)
        {
          // ISSUE: explicit non-virtual call
          __nonvirtual (texture2D1.Dispose());
        }
        this.texture2D_1 = (Texture2D) null;
      }
    }

    public override void vmethod_1()
    {
      Texture2D texture2D_1 = this.contentManager_0.Load<Texture2D>("Images/uiHelpKeyboard");
      this.gclass141_1 = new GClass141(texture2D_1, new Microsoft.Xna.Framework.Rectangle(0, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight - texture2D_1.Height, texture2D_1.Width, texture2D_1.Height));
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
      this.texture2D_2.SetData<Microsoft.Xna.Framework.Color>(new Microsoft.Xna.Framework.Color[1]
      {
        Microsoft.Xna.Framework.Color.Black
      });
      Vector2 vector2 = this.method_13(0, 0);
      this.gclass143_0.Cursor = new GClass141(this.texture2D_4, new Microsoft.Xna.Framework.Rectangle((int) vector2.X - this.int_8 / 2, (int) vector2.Y - this.int_8 / 2, this.int_8, this.int_8));
      this.gclass143_0.method_5(new Microsoft.Xna.Framework.Rectangle((int) vector2.X - this.int_8 / 2, (int) vector2.Y - this.int_8 / 2, this.int_8, this.int_8));
      this.gclass143_0.Cursor.method_1(new GClass137(new GClass134(1.0, 1.1, 250.0)
      {
        IsLooping = true
      }, "Scale"));
      this.method_9();
      base.vmethod_1();
    }

    public void method_9()
    {
      this.method_2((GClass135) new GClass136(new Vector2((float) (GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth / 2), (float) (GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight / 2)), 0.0, 1.0, 350.0));
      this.gclass143_0.method_2();
      this.gclass143_0.method_0((GClass140) this.gclass142_0);
      this.gclass143_0.method_0((GClass140) this.gclass141_0);
      this.gclass143_0.method_0((GClass140) new GClass141(this.texture2D_0, new Microsoft.Xna.Framework.Rectangle(0, 0, GClass138.graphicsDeviceManager_0.PreferredBackBufferWidth, GClass138.graphicsDeviceManager_0.PreferredBackBufferHeight)));
      this.gclass143_0.method_0((GClass140) this.gclass141_1);
      foreach (GClass140 gclass140 in this.list_0.ToArray())
        gclass140.Dispose();
      this.list_0.Clear();
      Task.Run((Action) (() =>
      {
        this.method_15();
        this.method_19();
        for (int int_12 = 0; int_12 < 5; ++int_12)
        {
          for (int int_11 = 0; int_11 < 10; ++int_11)
          {
            if (this.gclass32_0[int_12 * 10 + int_11] != null)
            {
              try
              {
                using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(this.gclass32_0[int_12 * 10 + int_11].IconUrl)))
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  Class120.Class118 class118_1 = new Class120.Class118();
                  // ISSUE: reference to a compiler-generated field
                  class118_1.class120_0 = this;
                  Vector2 vector2_3 = this.method_12(int_11, int_12);
                  // ISSUE: variable of a compiler-generated type
                  Class120.Class118 class118_2 = class118_1;
                  // ISSUE: reference to a compiler-generated field
                  class118_2.gclass141_0 = new GClass141(Texture2D.FromStream(GClass138.graphicsDevice_0, (Stream) memoryStream), new Microsoft.Xna.Framework.Rectangle(0, 0, 128, 128))
                  {
                    Tag = (object) this.gclass32_0[int_12 * 10 + int_11]
                  };
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  class118_1.gclass141_0.Event_0 += new EventHandler(class118_1.method_0);
                  // ISSUE: reference to a compiler-generated field
                  class118_1.gclass141_0.method_3(vector2_3, true, 2f);
                  // ISSUE: reference to a compiler-generated field
                  this.list_0.Add(class118_1.gclass141_0);
                  // ISSUE: reference to a compiler-generated field
                  class118_1.gclass141_0.method_1(new GClass137(new GClass134(1.0, 0.75, 1000.0)
                  {
                    IsLooping = true
                  }, "Opacity"));
                  // ISSUE: reference to a compiler-generated field
                  this.gclass143_0.method_0((GClass140) class118_1.gclass141_0);
                }
              }
              catch
              {
              }
            }
          }
        }
        this.method_18();
      }));
      this.method_5();
    }

    public override void vmethod_2()
    {
      this.gclass142_0.Dispose();
      base.vmethod_2();
    }

    public override void vmethod_3(GameTime gameTime_0)
    {
      this.gclass143_0.method_6(gameTime_0);
      if (this.bool_2)
        return;
      Keyboard.GetState();
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Right))
        this.method_16(true, false);
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Left))
        this.method_16(true, true);
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Up))
        this.method_16(false, true);
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Down))
        this.method_16(false, false);
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Enter))
        this.gclass143_0.method_1();
      if (this.gclass139_0.method_2(Microsoft.Xna.Framework.Input.Keys.Space) && this.Int32_0 > -1)
      {
        if (this.int_7 == 0)
        {
          try
          {
            this.int_4 = this.Int32_0;
            GClass141 gclass141 = this.list_0.First<GClass141>((Func<GClass141, bool>) (gclass141_2 => gclass141_2.Tag == this.gclass32_0[this.int_4]));
            ++this.int_7;
            Microsoft.Xna.Framework.Color orange = Microsoft.Xna.Framework.Color.Orange;
            gclass141.color_0 = orange;
          }
          catch
          {
          }
        }
        else if (this.int_7 == 1)
        {
          GClass141 gclass141_1 = (GClass141) null;
          GClass141 gclass141_3 = (GClass141) null;
          try
          {
            gclass141_1 = this.list_0.First<GClass141>((Func<GClass141, bool>) (gclass141_2 => gclass141_2.Tag == this.gclass32_0[this.int_4]));
          }
          catch
          {
          }
          try
          {
            gclass141_3 = this.list_0.First<GClass141>((Func<GClass141, bool>) (gclass141_2 => gclass141_2.Tag == this.gclass32_0[this.Int32_0]));
          }
          catch
          {
          }
          if (gclass141_1 == gclass141_3)
          {
            gclass141_1.color_0 = Microsoft.Xna.Framework.Color.White;
            this.int_7 = 0;
            return;
          }
          GClass32 gclass32 = this.gclass32_0[this.int_4];
          this.gclass32_0[this.int_4] = this.gclass32_0[this.Int32_0];
          this.gclass32_0[this.Int32_0] = gclass32;
          gclass141_1.color_0 = Microsoft.Xna.Framework.Color.White;
          if (gclass141_3 != null)
            gclass141_3.method_3(gclass141_1.Vector2_0, true, 2f);
          if (gclass141_1 != null)
            gclass141_1.method_3(this.method_12(this.int_9, this.int_10), true, 2f);
          this.method_19();
          this.int_7 = 0;
        }
      }
      try
      {
        if (!GamePad.GetCapabilities(PlayerIndex.One).IsConnected)
          return;
        GamePadState state = GamePad.GetState(PlayerIndex.One);
        GamePadThumbSticks thumbSticks = state.ThumbSticks;
        if ((double) thumbSticks.Left.X < 0.5)
          this.method_16(true, true);
        thumbSticks = state.ThumbSticks;
        if ((double) thumbSticks.Left.X > 0.5)
          this.method_16(true, false);
        thumbSticks = state.ThumbSticks;
        if ((double) thumbSticks.Left.Y < 0.5)
          this.method_16(false, true);
        thumbSticks = state.ThumbSticks;
        if ((double) thumbSticks.Left.Y <= 0.5)
          return;
        this.method_16(false, false);
      }
      catch
      {
      }
    }

    private GClass32 GClass32_0
    {
      get
      {
        if (this.int_10 * 10 + this.int_9 < this.gclass32_0.Length)
          return this.gclass32_0[this.int_10 * 10 + this.int_9];
        return (GClass32) null;
      }
    }

    private int Int32_0
    {
      get
      {
        return this.int_10 * 10 + this.int_9;
      }
    }

    private void method_10(GClass32 gclass32_1)
    {
      GClass95 gclass95 = gclass32_1.method_14(false);
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(gclass95.String_3)))
      {
        byte[] buffer = new byte[2];
        using (FileStream fileStream = File.Open(gclass95.String_2, FileMode.Open))
        {
          binaryWriter.Write(this.byte_0);
          binaryWriter.Write((int) (fileStream.Length + 44L - 8L));
          binaryWriter.Write(this.byte_1);
          binaryWriter.Write((int) fileStream.Length - 8);
          while (fileStream.Read(buffer, 0, 2) != 0)
          {
            binaryWriter.Write(buffer[1]);
            binaryWriter.Write(buffer[0]);
          }
        }
      }
    }

    private Vector2 method_11(int int_11)
    {
      return new Vector2((float) (int_11 % 10), (float) (int_11 / 10));
    }

    private Vector2 method_12(int int_11, int int_12)
    {
      return new Vector2((float) this.method_14(int_11, this.int_6), (float) this.method_14(int_12, this.int_5));
    }

    private Vector2 method_13(int int_11, int int_12)
    {
      return new Vector2((float) (this.method_14(int_11, this.int_6) + 64), (float) (this.method_14(int_12, this.int_5) + 64));
    }

    private int method_14(int int_11, int int_12)
    {
      return this.int_3 / 2 + int_12 + int_11 * (128 + this.int_3);
    }

    private void method_15()
    {
      this.gclass32_0 = new GClass32[50];
      List<GClass32> list = GClass28.dictionary_0.Values.Where<GClass32>((Func<GClass32, bool>) (gclass32_0 => gclass32_0.Boolean_1)).ToList<GClass32>();
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class120.Class119 class119 = new Class120.Class119();
        // ISSUE: reference to a compiler-generated field
        class119.string_0 = GClass88.smethod_7("guiGames");
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        for (class119.int_0 = 0; class119.int_0 < class119.string_0.Length && class119.int_0 < this.gclass32_0.Length; class119.int_0++)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          GClass32 gclass32 = list.Find(class119.predicate_0 ?? (class119.predicate_0 = new Predicate<GClass32>(class119.method_0)));
          if (gclass32 != null && !((IEnumerable<GClass32>) this.gclass32_0).Contains<GClass32>(gclass32))
          {
            // ISSUE: reference to a compiler-generated field
            this.gclass32_0[class119.int_0] = gclass32;
          }
        }
        foreach (GClass32 gclass32 in list.Where<GClass32>((Func<GClass32, bool>) (gclass32_1 => !((IEnumerable<GClass32>) this.gclass32_0).Contains<GClass32>(gclass32_1))).ToArray<GClass32>())
        {
          for (int index = 0; index < this.gclass32_0.Length; ++index)
          {
            if (this.gclass32_0[index] == null)
            {
              this.gclass32_0[index] = gclass32;
              break;
            }
          }
        }
      }
      catch
      {
        for (int index = 0; index < this.gclass32_0.Length && index < list.Count; ++index)
          this.gclass32_0[index] = list[index];
      }
    }

    private void method_16(bool bool_3, bool bool_4)
    {
      SoundEffect soundEffect1 = this.soundEffect_1;
      if (soundEffect1 != null)
        soundEffect1.Play(0.1f, 0.0f, 0.0f);
      if (bool_3 & bool_4 && this.int_9 > 0)
        --this.int_9;
      if (bool_3 && !bool_4 && this.int_9 < 9)
        ++this.int_9;
      if (!bool_3 & bool_4 && this.int_10 > 0)
        --this.int_10;
      if (!bool_3 && !bool_4 && this.int_10 < 4)
        ++this.int_10;
      Vector2 vector2 = this.method_13(this.int_9, this.int_10);
      this.gclass143_0.method_5(new Microsoft.Xna.Framework.Rectangle((int) vector2.X - this.int_8 / 2, (int) vector2.Y - this.int_8 / 2, this.int_8, this.int_8));
      Texture2D texture = this.gclass141_0.Texture;
      if (texture != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (texture.Dispose());
      }
      this.gclass141_0.Texture = (Texture2D) null;
      this.method_17(this.GClass32_0, 0.15f);
      this.method_18();
    }

    private void method_17(GClass32 gclass32_1, float float_1 = 1f)
    {
      try
      {
        SoundEffectInstance soundEffectInstance0 = this.soundEffectInstance_0;
        if (soundEffectInstance0 != null)
          soundEffectInstance0.Stop();
        SoundEffect soundEffect0 = this.soundEffect_0;
        if (soundEffect0 != null)
          soundEffect0.Dispose();
        this.soundEffectInstance_0 = (SoundEffectInstance) null;
        this.soundEffect_0 = (SoundEffect) null;
        if (gclass32_1 == null)
          return;
        GClass95 gclass95 = gclass32_1.method_14(false);
        if (!File.Exists(gclass95.String_2))
          return;
        if (!File.Exists(gclass95.String_3))
          this.method_10(this.GClass32_0);
        using (FileStream fileStream = File.OpenRead(gclass95.String_3))
          this.soundEffect_0 = SoundEffect.FromStream((Stream) fileStream);
        if (this.soundEffect_0 == null)
          return;
        this.soundEffectInstance_0 = this.soundEffect_0.CreateInstance();
        this.soundEffect_0.Play(float_1, 0.0f, 0.0f);
      }
      catch
      {
      }
    }

    private void method_18()
    {
      if (this.GClass32_0 == null)
        return;
      this.GClass32_0.method_28((Action<GClass74, GClass32>) ((gclass74_0, gclass32_1) =>
      {
        try
        {
          if (gclass32_1 != this.GClass32_0)
            return;
          Texture2D texture = this.gclass141_0.Texture;
          if (texture != null)
          {
            // ISSUE: explicit non-virtual call
            __nonvirtual (texture.Dispose());
          }
          this.gclass141_0.Texture = (Texture2D) null;
          GClass141 gclass1410 = this.gclass141_0;
          if (gclass1410 != null)
            gclass1410.method_5();
          if (gclass74_0.Screenshots == null || gclass74_0.Screenshots.Screenshot.Count < 3)
            return;
          Texture2D texture2D = this.method_4(gclass74_0.Screenshots.Screenshot[0].ImageUrl[0].Value);
          if (gclass32_1 == this.GClass32_0)
          {
            this.gclass141_0.Texture = texture2D;
          }
          else
          {
            if (texture2D == null)
              return;
            // ISSUE: explicit non-virtual call
            __nonvirtual (texture2D.Dispose());
          }
        }
        catch
        {
        }
      }));
    }

    private void method_19()
    {
      lock (this)
        GClass88.smethod_10("guiGames", ((IEnumerable<GClass32>) this.gclass32_0).Select<GClass32, string>((Func<GClass32, string>) (gclass32_0 => gclass32_0?.TitleId.IdRaw)).ToArray<string>());
    }
  }
}
