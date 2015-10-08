using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SearchPatient
{
	public partial class SearchResult : ContentPage
	{
		ObservableCollection<SearchData> datas = new ObservableCollection<SearchData>();

		public SearchResult ()
		{
			InitializeComponent ();
			listView.ItemsSource = datas;

			SearchData d = new SearchData ();
		

			d.title="Alex M Manade";
			d.subtitle="Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816";
			d.Address="Contact @2255436789";
			d.ButtonTitle = "Get Direction";
				
			datas.Add (d);
//			datas.Add(new SearchData{ title="Prajakta "});
//			datas.Add(new SearchData{ subtitle="Shinde"});
//			datas.Add (new SearchData{ Address = "Pune" });
			listView.ItemTemplate = new DataTemplate (typeof(CustomCell));

			//MapModel m = new MapModel ();

			//listView.ItemTemplate=	new DataTemplate (() => new CustomCell(m));
		  
		}

		void GetDirectionButton_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PopAsync ();
		}

	}
}

