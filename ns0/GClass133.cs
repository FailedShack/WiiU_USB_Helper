// Decompiled with JetBrains decompiler
// Type: ns0.GClass133
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class GClass133 : SimpleListViewVisualItem
  {
    public GClass30 gclass30_0;
    public LightVisualElement lightVisualElement_0;
    public LightVisualElement lightVisualElement_1;
    private LightVisualElement lightVisualElement_2;

    protected override Type ThemeEffectiveType
    {
      get
      {
        return typeof (SimpleListViewVisualItem);
      }
    }

    protected override void CreateChildElements()
    {
      base.CreateChildElements();
      LightVisualElement lightVisualElement1 = new LightVisualElement();
      lightVisualElement1.MinSize = new Size(120, 0);
      lightVisualElement1.ShouldHandleMouseInput = false;
      lightVisualElement1.TextAlignment = ContentAlignment.MiddleLeft;
      lightVisualElement1.NotifyParentOnMouseInput = true;
      lightVisualElement1.AutoSize = true;
      this.lightVisualElement_2 = lightVisualElement1;
      LightVisualElement lightVisualElement2 = new LightVisualElement();
      lightVisualElement2.Image = (Image) Class123.arrowUP;
      lightVisualElement2.AutoSize = false;
      this.lightVisualElement_1 = lightVisualElement2;
      LightVisualElement lightVisualElement3 = new LightVisualElement();
      lightVisualElement3.Image = (Image) Class123.arrowDown;
      lightVisualElement3.AutoSize = false;
      this.lightVisualElement_0 = lightVisualElement3;
      this.lightVisualElement_0.Size = new Size(30, 20);
      this.lightVisualElement_1.Size = new Size(30, 20);
      this.Children.Add((RadElement) this.lightVisualElement_2);
      this.Children.Add((RadElement) this.lightVisualElement_0);
      this.Children.Add((RadElement) this.lightVisualElement_1);
    }

    protected override void SynchronizeProperties()
    {
      base.SynchronizeProperties();
      this.Text = "";
      this.lightVisualElement_0.Location = new Point(this.Parent.Bounds.Width - 40, 0);
      this.lightVisualElement_1.Location = new Point(this.Parent.Bounds.Width - 65, 0);
      this.gclass30_0 = (GClass30) this.Data.Tag;
      if (this.gclass30_0 is GClass32)
        this.lightVisualElement_2.Text = (this.gclass30_0 as GClass32).method_30();
      else
        this.lightVisualElement_2.Text = this.gclass30_0.ToString();
      this.Image = this.Data.Image;
      this.lightVisualElement_2.Location = new Point(50, 0);
    }
  }
}
