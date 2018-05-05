using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldXam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LaunchPage : ContentPage
	{
		public LaunchPage ()
		{
			InitializeComponent ();
		}

        private async void MainPage_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }

        private async void QuotesPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuotesPage());
        }

        private async void StackLayoutPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout());
        }

        private async void InstagramPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InstagramPage());
        }
    }
}