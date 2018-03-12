using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace S02_L16_DealingWithDifferentDevices
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new S02_L16_DealingWithDifferentDevices.MainPage();
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
