using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace S01_L04_HelloWorld
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new S01_L04_HelloWorld.MainPage();
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
