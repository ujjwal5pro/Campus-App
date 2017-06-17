using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Admin_Section;
using Xamarin.Forms;

namespace Campus
{
    public partial class AdminsigninPage : ContentPage
    {
        public AdminsigninPage()
        {
            InitializeComponent();
        }

        private void Onloginclicked(object sender, EventArgs e)
        {
            if (Switchul.IsToggled && Switchc.IsToggled && Switchlr.IsToggled && Switchur.IsToggled==false && Switchll.IsToggled==false)
            {
                this.Navigation.PopModalAsync();
                this.Navigation.PushModalAsync(new NavigationPage(new TabbedPage()
                {
                    Children =
                {
                    new AllNotificationViewPage(),
                    new AllMediaContentPage(),
                    new UsersPage()
                },
                    Title = "GBPEC Administrator",
                }));
            }
            else
            {
                DisplayAlert("Warning","Access denied !!","Ok");
            }
        }
    }
}
