using System;

using Xamarin.Forms;

namespace SearchPatient
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new SearchPatient());

			Current.Resources = new ResourceDictionary();
			Current.Resources.Add("UlycesColor", Color.FromRgb(121, 248, 81));
			var navigationStyle = new Style(typeof (NavigationPage));
			var barTextColorSetter = new Setter {Property = NavigationPage.BarTextColorProperty, Value = Color.White};
			var barBackgroundColorSetter= new Setter {Property = NavigationPage.BarBackgroundColorProperty, Value = Color.Red};

			navigationStyle.Setters.Add(barTextColorSetter );
			navigationStyle.Setters.Add(barBackgroundColorSetter);

			Current.Resources.Add(navigationStyle);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

