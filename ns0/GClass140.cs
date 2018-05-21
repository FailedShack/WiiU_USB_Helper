// Decompiled with JetBrains decompiler
// Type: ns0.GClass140
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ns0
{
  public abstract class GClass140 : IDisposable
  {
    public Color color_0 = Color.White;
    public bool bool_0 = true;
    private List<GClass137> list_0 = new List<GClass137>();
    public Vector2 vector2_0;
    private Vector2 vector2_1;
    private float float_0;
    private bool bool_2;
    private float float_1;
    private Vector2 vector2_2;

    public GClass140(Texture2D texture2D_1, Rectangle rectangle_1)
    {
      this.Texture = texture2D_1;
      this.Rectangle = rectangle_1;
      this.vector2_0 = this.Vector2_0;
    }

    public event EventHandler Event_0;

    public bool Hide { get; set; }

    public double Opacity { get; set; } = 1.0;

    public Vector2 Vector2_0
    {
      get
      {
        return new Vector2((float) this.Rectangle.X, (float) this.Rectangle.Y);
      }
      set
      {
        this.Rectangle = new Rectangle((int) value.X, (int) value.Y, this.Rectangle.Width, this.Rectangle.Height);
      }
    }

    public Rectangle Rectangle { get; protected set; }

    public double Scale { get; set; } = 1.0;

    public object Tag { get; set; }

    public Texture2D Texture { get; set; }

    public void method_0()
    {
      foreach (GClass137 gclass137 in this.list_0.ToArray())
        gclass137.method_0();
    }

    public void method_1(GClass137 gclass137_0)
    {
      gclass137_0.Target = (object) this;
      this.list_0.Add(gclass137_0);
    }

    public virtual void Dispose()
    {
      Texture2D texture = this.Texture;
      if (texture == null)
        return;
      // ISSUE: explicit non-virtual call
      __nonvirtual (texture.Dispose());
    }

    public void method_2()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }

    public void method_3(Vector2 vector2_3, bool bool_3, float float_2 = 0.0f)
    {
      if (bool_3 && vector2_3 != this.Vector2_0)
      {
        this.vector2_0 = vector2_3;
        this.bool_2 = bool_3;
        this.float_1 = float_2;
        this.vector2_1 = Vector2.Normalize(this.vector2_0 - this.Vector2_0);
        this.float_0 = Vector2.Distance(this.Vector2_0, this.vector2_0);
        this.vector2_2 = this.Vector2_0;
      }
      else
        this.Vector2_0 = vector2_3;
    }

    public abstract void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0);

    public void method_4()
    {
      this.list_0.Clear();
    }

    public void method_5()
    {
      foreach (GClass137 gclass137 in this.list_0.ToArray())
        gclass137.method_2();
    }

    public virtual void vmethod_1(GameTime gameTime_0)
    {
      foreach (GClass137 gclass137 in this.list_0.ToArray())
        gclass137.method_1();
      if (!this.bool_2)
        return;
      this.Vector2_0 += this.vector2_1 * 2f * (float) gameTime_0.ElapsedGameTime.TotalMilliseconds;
      if ((double) Vector2.Distance(this.vector2_2, this.Vector2_0) < (double) this.float_0)
        return;
      this.Vector2_0 = this.vector2_0;
      this.bool_2 = false;
    }
  }
}
