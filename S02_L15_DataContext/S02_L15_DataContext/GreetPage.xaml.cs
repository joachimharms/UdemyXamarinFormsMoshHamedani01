﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S02_L15_DataContext
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();

            //// Setze Padding für iOS im Codebehind

            //if (Device.OS == TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}
            //else if (Device.OS == TargetPlatform.Android)
            //{
            //    Padding = new Thickness(10, 20, 0, 0);
            //}
            //else if(Device.OS == TargetPlatform.Windows)
            //{
            //    Padding = new Thickness(30, 20, 0, 0);
            //}

            Device.OnPlatform<Thickness>(iOS: new Thickness(0, 20, 0, 0), Android: new Thickness(10, 20, 0, 0), WinPhone: new Thickness(30, 20, 0, 0));



		}
	}
}