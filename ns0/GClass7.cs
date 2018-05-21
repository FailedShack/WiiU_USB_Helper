// Decompiled with JetBrains decompiler
// Type: ns0.GClass7
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ns0
{
  public class GClass7
  {
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;

    public GClass7(string string_4, string string_5, string string_6, string string_7 = "")
    {
      this.string_3 = string_5;
      this.string_1 = string_6;
      this.string_2 = string_7;
      this.string_0 = string_4;
    }

    public event EventHandler<string> Event_0;

    public void method_0()
    {
      Task.Run((Action) (() =>
      {
        try
        {
          // ISSUE: reference to a compiler-generated field
          this.eventHandler_0((object) this, Encoding.UTF8.GetString(new WebClient().UploadValues(string.Format("{0}/sendEmail.php", (object) Class67.String_4), new NameValueCollection()
          {
            {
              "from",
              this.string_0
            },
            {
              "subject",
              this.string_3
            },
            {
              "message",
              this.string_1
            },
            {
              "reply-to",
              this.string_2
            }
          })));
        }
        catch (Exception ex)
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<string> eventHandler0 = this.eventHandler_0;
          if (eventHandler0 == null)
            return;
          eventHandler0((object) this, ex.ToString());
        }
      }));
    }
  }
}
