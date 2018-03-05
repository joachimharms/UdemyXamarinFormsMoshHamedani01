using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S01_L04_HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
		    //void Handle_Clicked(object sender, System.EventArgs e)
		    //{
		    //    throw new NotImplementedException();
		    //}
			InitializeComponent ();
            
		}
	}
}