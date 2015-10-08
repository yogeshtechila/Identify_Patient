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
			Label namelbl = new Label();
			Label addresslbl = new Label();
			Label contactlbl = new Label();
//			Button contactlbl = new Button ();
			Button GetDir = new Button ();

			//set bindings
			namelbl.SetBinding (Label.TextProperty, "name");
			addresslbl.SetBinding (Label.TextProperty, "address");
			contactlbl.SetBinding (Label.TextProperty, "contact");
			GetDir.SetBinding (Button.TextProperty, "ButtonTitle");



			//Set properties for desired design
			horizontalLayout.Orientation = StackOrientation.Vertical;

			//add views to the view hierarchy
			horizontalLayout.Children.Add (namelbl);
			horizontalLayout.Children.Add (addresslbl);
			horizontalLayout.Children.Add (contactlbl);
			horizontalLayout.Children.Add (GetDir);
			cellWrapper.Children.Add (horizontalLayout);
			View = cellWrapper;	
		}
	}

}

