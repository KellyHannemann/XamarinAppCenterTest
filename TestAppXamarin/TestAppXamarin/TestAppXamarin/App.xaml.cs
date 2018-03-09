using System;

using TestAppXamarin.Views;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace TestAppXamarin
{
	public partial class App : Application
	{

		public App ()
		{
            InitializeComponent();
            
            MainPage = new MainPage();

            AppCenter.Start("21fa1326-09bf-46ed-bbf9-044d4db4da59", typeof(Analytics));
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
