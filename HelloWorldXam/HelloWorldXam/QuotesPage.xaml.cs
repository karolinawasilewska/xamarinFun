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
	public partial class QuotesPage : ContentPage
	{
        string[] quotes = null;
		public QuotesPage ()
		{
            quotes = new string[] { "quote1", "quote2", "quote3", "quote4", "quote5", "quote6" };
			InitializeComponent ();

            slider.Maximum = 50.0;
            slider.Minimum = 16.0;

            quote.Text = quotes[0];

        }

        private void next_Clicked(object sender, EventArgs e)
        {
            string current = quote.Text;
            int index = 0;
            for (int i = 0; i < quotes.Length; i++)
            {
                if (current == quotes[i])
                {
                    index = i;
                    break;
                }
            }
            if (index>=quotes.Length-1)
            {
                index = -1;
            }
            quote.Text = quotes[index + 1];
        }
    }
}