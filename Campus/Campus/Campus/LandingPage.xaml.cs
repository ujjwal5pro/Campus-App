using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            ListView1.ItemsSource = new List<string>
            {
                "[] Admin","[] Student","[] Guest"
            };
        }

        public int Counter = 0;
        private void OncontinueClicked(object sender, EventArgs e)
        {
            if (Counter % 2 == 0)
            {
                Introduce.IsVisible = true;
                l1.FontSize = 45;
                l2.FontSize = 45;
                EnterButton.Text = "Enter As";
            }
            else if (Counter % 2 == 1)
            {
                Introduce.IsVisible = false;
                l1.FontSize = 50;
                l2.FontSize = 50;
                EnterButton.Text = "Enter";
            }
            Counter++;
        }

        private async void ListView1_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var user=ListView1.SelectedItem.ToString();
            if (user == "[] Admin")
            {
                await Navigation.PushModalAsync(new NavigationPage(new AdminsigninPage())
                {
                    BarBackgroundColor = Color.Teal
                });
            }
            else if(user=="[] Student")
            {
                await Navigation.PushModalAsync(new SigninPage());
            }
            else if(user=="[] Guest")
            {
                await Navigation.PushModalAsync(new GuestPage());
            }
            
        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}
