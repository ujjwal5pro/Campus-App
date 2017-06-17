using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Admin_Section
{
    public partial class FilterUserPage : ContentPage
    {
        public FilterUserPage()
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
            }
            else
            {
                Switch1.IsEnabled = true;
                Switch2.IsEnabled = true;
            }
        }

        private async void Oncloseclicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
