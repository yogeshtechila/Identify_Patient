using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace SearchPatient
{
	public partial class SearchPatient : ContentPage
	{
		public SearchPatient ()
		{
			InitializeComponent ();
			this.Title="Identity Patient";

			//SearchBtn.Image = "search.png";

//				Device.OnPlatform(
//				iOS: ImageSource.FromFile("Images/Default.png"),
//				Android:  ImageSource.FromFile("waterfront.jpg"),
//				WinPhone: ImageSource.FromFile("Images/waterfront.png"));

		}

		void OnSearchClicked(object sender, EventArgs  e)
		{

			if((string.IsNullOrEmpty(FirstNameText.Text)) && (string.IsNullOrEmpty(LastNameText.Text)))
			{			
				DisplayAlert ("Please enter First name or Last name!", null, "Ok");
			}
			else
			{
				this.Navigation.PushAsync (new SearchResult(), true);				
			}
		}

		void OnRadioClicked(object sender, EventArgs  e)
		{
			var button = (Button)sender;

			var v= button.Image.File.ToString ();
			if (v == "unchecked.png") 
			{
				button.Image = "checked.png";
				radioButton2.Image = "unchecked.png";
			} 
			else 
			{
				button.Image = "unchecked.png";
			}
		}


		void OnFemaleRadioClicked(object sender, EventArgs  e)
		{
			var button = (Button)sender;

			var v= button.Image.File.ToString ();
			if (v == "unchecked.png") {
				button.Image = "checked.png";
				radioButton1.Image = "unchecked.png";

			} else {
				button.Image = "unchecked.png";
			}
		}

	}
}

