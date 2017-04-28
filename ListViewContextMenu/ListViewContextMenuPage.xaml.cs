using System.Collections.ObjectModel;
using System.Diagnostics;

using Xamarin.Forms;

namespace ListViewContextMenu
{
	public partial class ListViewContextMenuPage : ContentPage
	{
		public ObservableCollection<MyItem> ListData { get; set; }

		public ListViewContextMenuPage()
		{
			InitializeComponent();
			InitializeDataSource();
			MyListView.ItemsSource = ListData;
		}

		private void InitializeDataSource()
		{
			ListData = new ObservableCollection<MyItem>();

			ListData.Add(new MyItem { Name = "First Item" });
			ListData.Add(new MyItem { Name = "Second Item" });
			ListData.Add(new MyItem { Name = "Third Item" });
		}
	}
}
