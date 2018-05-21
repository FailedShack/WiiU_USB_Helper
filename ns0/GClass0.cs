// Decompiled with JetBrains decompiler
// Type: ns0.GClass0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Collections.Generic;
using System.ComponentModel;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace ns0
{
  public class GClass0 : IComparer<ListViewDataItem>
  {
    private RadListViewElement radListViewElement_0;

    public GClass0(RadListViewElement radListViewElement_1)
    {
      this.radListViewElement_0 = radListViewElement_1;
    }

    public int Compare(ListViewDataItem x, ListViewDataItem y)
    {
      using (IEnumerator<SortDescriptor> enumerator = this.radListViewElement_0.SortDescriptors.GetEnumerator())
      {
        if (enumerator.MoveNext())
        {
          SortDescriptor current = enumerator.Current;
          if (current.PropertyIndex == 2)
          {
            int num = (x.Tag as GClass30).Size.TotalBytes.CompareTo((y.Tag as GClass30).Size.TotalBytes);
            if (current.Direction == ListSortDirection.Descending)
              num *= -1;
            if (x.Group != y.Group)
              return -1;
            return num;
          }
          int propertyIndex = current.PropertyIndex;
          return x[propertyIndex].ToString().CompareTo(y[propertyIndex].ToString()) * (current.Direction == ListSortDirection.Descending ? -1 : 1);
        }
      }
      this.radListViewElement_0.EnableCustomGrouping = true;
      return 0;
    }
  }
}
