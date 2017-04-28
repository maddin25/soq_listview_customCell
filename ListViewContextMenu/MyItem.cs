using System;
using System.Diagnostics;

using Xamarin.Forms;

namespace ListViewContextMenu
{
	public class MyItem
	{
		public string Name { get; set; }
		public Command OnAction { get; set; }

		public MyItem()
		{
			OnAction = new Command((obj) => Debug.WriteLine($"Item {obj.ToString()} clicked"));
		}

		public override string ToString()
		{
			return string.Format($"MyItem: Name={Name}");
		}
	}
}
