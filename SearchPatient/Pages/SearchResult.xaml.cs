﻿using System;
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

			d.name="Alex M Manade";
			d.address="Baton Rouge General Mid City 1007 Bluebonnet Blvd,Baton Blvd, Louisiana, USA 70816";
			d.contact="Contact @2255436789";
			d.ButtonTitle = "Get Direction";				
			datas.Add (d);

			listView.ItemTemplate = new DataTemplate (typeof(CustomCell));

//
//			var tap = new UITapGestureRecognizer(
//				tap => UIApplication.SharedApplication.OpenUrl(new NSUrl("tel:" + contactlbl.Text))
//			);
//
//			contactlbl.UserInteractionEnabled = true;
//
//			contactlbl.AddGestureRecognizer(tap);
		}



		public void OnGetDirectionBtnClicked(object sender, EventArgs e)
		{
		DisplayAlert("You will redirect to map soon", null, "Ok");
		}
//		public void OnContactBtnClicked(object sender, EventArgs e)
//		{
//			DisplayAlert("You are contacting..", null, "Ok");
//		}

	}
}

