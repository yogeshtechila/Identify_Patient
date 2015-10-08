using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace SearchPatient
{

	public class CustomCell: ViewCell
	{

		public CustomCell ()
		{
			//instantiate each of our views
			StackLayout cellWrapper = new StackLayout ();
			StackLayout horizontalLayout = new StackLayout ();
			Label left = new Label ();
			Label right = new Label ();
			Label adres = new Label ();
	     	Button GetDir = new Button ();

			GetDir.Clicked += GetDir_Clicked;

			//GetDir.Clicked += (sender, args) => _model.getDirection ();

			//set bindings
			left.SetBinding (Label.TextProperty, "title");
			right.SetBinding (Label.TextProperty, "subtitle");
			adres.SetBinding (Label.TextProperty, "Address");
			GetDir.SetBinding (Button.TextProperty, "ButtonTitle");

			//Set properties for desired design
//			cellWrapper.BackgroundColor = Color.FromHex ("#eee");
			horizontalLayout.Orientation = StackOrientation.Vertical;
//			left.TextColor = Color.FromHex ("#f35e20");
//			right.TextColor = Color.FromHex ("503026");

			//add views to the view hierarchy
			horizontalLayout.Children.Add (left);
			horizontalLayout.Children.Add (right);
			horizontalLayout.Children.Add (adres);
			horizontalLayout.Children.Add (GetDir);
			cellWrapper.Children.Add (horizontalLayout);
			View = cellWrapper;	
		}

		void GetDir_Clicked (object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine ("Pressed cell");

						if (Device.OS == TargetPlatform.iOS) {
							//https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
							Device.OpenUri(new Uri("http://maps.apple.com/?daddr=San+Francisco,+CA&saddr=cupertino"));
			
						} else if (Device.OS == TargetPlatform.Android) {
							// opens the 'task chooser' so the user can pick Maps, Chrome or other mapping app
							Device.OpenUri(new Uri("http://maps.google.com/?daddr=San+Francisco,+CA&saddr=Mountain+View"));
			
						} else if (Device.OS == TargetPlatform.WinPhone) {
							//DisplayAlert("To Do", "Not yet implemented", "OK");
						}
		}
	}
}

