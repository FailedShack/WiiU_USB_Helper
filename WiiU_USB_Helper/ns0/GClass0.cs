using System;
using System.Collections.Generic;
using System.ComponentModel;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	public class GClass0 : IComparer<ListViewDataItem>
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00010818 File Offset: 0x0000EA18
		public GClass0(RadListViewElement radListViewElement_1)
		{
			this.radListViewElement_0 = radListViewElement_1;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00019970 File Offset: 0x00017B70
		public int Compare(ListViewDataItem x, ListViewDataItem y)
		{
			using (IEnumerator<SortDescriptor> enumerator = this.radListViewElement_0.SortDescriptors.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					SortDescriptor sortDescriptor = enumerator.Current;
					if (sortDescriptor.PropertyIndex != 2)
					{
						int propertyIndex = sortDescriptor.PropertyIndex;
						string text = x[propertyIndex].ToString();
						string strB = y[propertyIndex].ToString();
						return text.CompareTo(strB) * ((sortDescriptor.Direction == ListSortDirection.Descending) ? -1 : 1);
					}
					ulong totalBytes = (x.Tag as GClass30).Size.TotalBytes;
					ulong totalBytes2 = (y.Tag as GClass30).Size.TotalBytes;
					int num = totalBytes.CompareTo(totalBytes2);
					if (sortDescriptor.Direction == ListSortDirection.Descending)
					{
						num *= -1;
					}
					if (x.Group != y.Group)
					{
						return -1;
					}
					return num;
				}
			}
			this.radListViewElement_0.EnableCustomGrouping = true;
			return 0;
		}

		// Token: 0x04000001 RID: 1
		private RadListViewElement radListViewElement_0;
	}
}
