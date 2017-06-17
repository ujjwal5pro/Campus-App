using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Admin_Section
{
    public partial class AllMediaContentPage : ContentPage
    {
        public AllMediaContentPage()
        {
            InitializeComponent();
        }

        private async void Onaddclicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AddContentPage()));
        }

        private void Oncontentapped(object sender, EventArgs e)
        {
            DisplayAlert("Information", "Under Construction", "Ok");
        }
    }
}
