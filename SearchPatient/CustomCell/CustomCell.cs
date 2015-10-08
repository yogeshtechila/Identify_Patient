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
	}

}

