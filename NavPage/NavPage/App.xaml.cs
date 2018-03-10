using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavPage
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var mp = new NavigationPage(new NavPage.MainPage { Title = "MAinPage" });
            mp.Navigation.PushAsync(new MainPage{ Title = "SoftBide" });
            MainPage = mp;
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
