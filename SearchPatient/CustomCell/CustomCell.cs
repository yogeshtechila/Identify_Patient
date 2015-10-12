using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Lotz.Xam.Messaging;

namespace SearchPatient
{

	public class CustomCell: ViewCell
	{

		public CustomCell ()
		{
			//instantiate each of our views
			StackLayout cellWrapper = new StackLayout ();
			StackLayout horizontalLayout = new StackLayout ();

			Label namelbl = new Label();
			Label addresslbl = new Label();
			Button contactBtn = new Button();
			Button GetDir = new Button ();



			GetDir.Clicked += GetDir_Clicked;
			contactBtn.Clicked+= ContactBtn_Clicked;

			//set bindings
			namelbl.SetBinding (Label.TextProperty, "name");
			addresslbl.SetBinding (Label.TextProperty, "address");
			contactBtn.SetBinding (Button.TextProperty, "contact");
			GetDir.SetBinding (Button.TextProperty, "ButtonTitle");

			//Set properties for desired design
			horizontalLayout.Orientation = StackOrientation.Vertical;

			//add views to the view hierarchy
			horizontalLayout.Children.Add (namelbl);
			horizontalLayout.Children.Add (addresslbl);
			horizontalLayout.Children.Add (contactBtn);
			horizontalLayout.Children.Add (GetDir);
			cellWrapper.Children.Add (horizontalLayout);
			View = cellWrapper;	
		}

		void ContactBtn_Clicked (object sender, EventArgs e)
		{
			var PhoneCallTask = MessagingPlugin.PhoneDialer;  
			if (PhoneCallTask.CanMakePhoneCall)  
				PhoneCallTask.MakePhoneCall("2255436789"); 
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

