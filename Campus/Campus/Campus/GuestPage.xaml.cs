using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Academics_Section;
using Campus.Social_Section;
using Xamarin.Forms;

namespace Campus
{
    public partial class GuestPage : MasterDetailPage
    {
        public GuestPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new TabbedPage()
            {
                Children =
                {
                  new AboutCollegePage() {Title = "Welcome to GBPEC"},
                },
                BackgroundColor = Color.FromHex("#dfdfdf"),
                Title = "Home",
            });
        }
        public void OnMenuTapped(object sender, EventArgs e)
        {
            this.IsPresented = false;
        }

        private void OnSocialTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TabbedPage()
            {
                Children =
                {
                  new SocialPage() {Title = "Blogs And Articles"},
                },
                BackgroundColor = Color.FromHex("#dfdfdf"),
                Title = "Social",
            });
            this.IsPresented = false;
        }

        private async void Onfromprincipaltapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FromPrincipalPage())
            {
                BarBackgroundColor = Color.Teal
            });
            this.IsPresented = false;
        }

        private void Onhometapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TabbedPage()
            {
                Children =
                {
                  new AboutCollegePage() {Title = "Welcome to Gbpec"},
                },
                BackgroundColor = Color.FromHex("#dfdfdf"),
                Title = "Home",
            });
            this.IsPresented = false;
        }

        private async void Onresulttapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TabbedPage()
            {
                Children =
                {
                  new Resultpage() {Title = "IPU Result"},
                },
                BackgroundColor = Color.FromHex("#dfdfdf"),
                Title = "Home",
            });
            this.IsPresented = false;
        }

      
        private void Onsignintapped(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
            this.Navigation.PushModalAsync(new NavigationPage(new SigninPage()));
        }
    }
}
