﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S02_L14_DataBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();
            slider.Value = 0.5;
		}

        private void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value of slider: {0:F2}", e.NewValue);
        }
    }
}