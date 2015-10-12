using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin.Forms.Maps;
using System.Linq;

namespace SearchPatient
{
	public partial class SearchResult : ContentPage
	{
		//ObservableCollection<SearchData> datas = new ObservableCollection<SearchData>();

		public SearchResult ()
		{
			InitializeComponent ();

			List<SearchData> datas = new List<SearchData> {
				new SearchData ("Alex M Manade", "Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816", "2255436789","Get Direction"),
				new SearchData ("Alex M Manade", "Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816", "2255436789","Get Direction"),
				new SearchData ("Alex M Manade", "Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816", "2255436789","Get Direction"),
				new SearchData ("Alex M Manade", "Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816", "2255436789","Get Direction"),
				new SearchData ("Alex M Manade", "Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816", "2255436789","Get Direction")
			};

			listView.ItemTemplate = new DataTemplate (typeof(CustomCell));
			listView.ItemsSource = datas;
			ToolbarItems.Add(new ToolbarItem("searchh", "search2", async () =>
			{
				this.Navigation.PopAsync (true);
			}));
		}		 
	}
}


