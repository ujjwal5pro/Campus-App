using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Academics_Section;
using Campus.Home_Section;
using Campus.MyClassroom_Section;
using Campus.Profile_Section;
using Campus.Social_Section;
using Xamarin.Forms;

namespace Campus
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage(List<Modal.StudentsInfo> sinfo)
        {
            InitializeComponent();
            BindingContext = sinfo[0];
            Detail=new NavigationPage(new TabbedPage()
            {
                Children =
                {
                    new HomePage() { Icon="Home.png"},
                    new MyClassroom() { Icon="Book.png"},
                    new SocialPage() {Icon="Social.png"},
                    new Profile(sinfo) {  Icon="Profile.png"}
                }, 
                BackgroundColor = Color.FromHex("#dfdfdf"),
                Title = "GBP Campus"
            });
        }
        public void OnMenuTapped(object sender, EventArgs e)
        {
            this.IsPresented = false;
        }

        public async void OnMyclassroomTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MyClassroom())
            {
                BarBackgroundColor = Color.Teal,
            });
            this.IsPresented = false;
        }
        private async void OnSocialTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SocialPage())
            {
                BarBackgroundColor = Color.Teal,
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

        private async void Ondetailstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AboutCollegePage())
            {
                BarBackgroundColor = Color.Teal
            });
            this.IsPresented = false;
        }

        //private async void Onplacementcelltapped(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new PlacementCellPage())
        //    {
        //        BarBackgroundColor = Color.Teal
        //    });
        //    this.IsPresented = false;
        //}

        private async void Onlibrarytapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new LibraryPage())
            {
                BarBackgroundColor = Color.Teal
            });
            this.IsPresented = false;
        }

        //private async void Onpaymenttapped(object sender, EventArgs e)
        //{
        //    //await Navigation.PushModalAsync(new NavigationPage(new FeesPaymentPage())
        //    //{
        //    //    BarBackgroundColor = Color.Teal
        //    //});
        //    this.IsPresented = false;
        //    await DisplayAlert("Information", "Under Construction", "Back");
        //}

        private async void Onresulttapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Resultpage())
            {
                BarBackgroundColor = Color.Teal
            });
            this.IsPresented = false;
        }

        private async void Onrtitapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RtiPage())
            {
                BarBackgroundColor = Color.Teal
            });
            this.IsPresented = false;
        }
        protected override bool OnBackButtonPressed()
        {
            return false;
        }

        private void Onlogouttapped(object sender, EventArgs e)
        {
            Application.Current.Properties["loginstatus"] = "out";
            Application.Current.SavePropertiesAsync();
            this.IsPresented = false;
            this.Navigation.PushModalAsync(new Campus.SigninPage());
        }
    }

}
