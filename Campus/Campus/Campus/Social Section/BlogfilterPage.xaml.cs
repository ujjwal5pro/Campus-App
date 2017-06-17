using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Social_Section
{
    public partial class BlogfilterPage : ContentPage
    {
        public BlogfilterPage()
        {
            InitializeComponent();
        }
        private void All_OnToggled(object sender, ToggledEventArgs e)
        {
            if (All.IsToggled == true)
            {
                Switch1.IsToggled = true;
                Switch1.IsEnabled = false;
                Switch2.IsToggled = true;
                Switch2.IsEnabled = false;
                Switch3.IsToggled = true;
                Switch3.IsEnabled = false;
                Switch4.IsToggled = true;
                Switch4.IsEnabled = false;
                Switch5.IsToggled = true;
                Switch5.IsEnabled = false;
                Switch6.IsToggled = true;
                Switch6.IsEnabled = false;
            }
            else
            {
                Switch1.IsEnabled = true;
                Switch2.IsEnabled = true;
                Switch3.IsEnabled = true;
                Switch4.IsEnabled = true;
                Switch5.IsEnabled = true;
                Switch6.IsEnabled = true;
            }
        }

        private async void Oncloseclicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
