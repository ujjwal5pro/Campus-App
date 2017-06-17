using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Admin_Section
{
    public partial class AdminPage : MasterDetailPage
    {
        public AdminPage()
        {
            InitializeComponent();
            Detail=new NavigationPage(new TabbedPage()
            {
                Children =
                {
                    new AllNotificationViewPage()
                },
                Title = "Administrator"
            });
        }

        private void Onhomeclicked(object sender, EventArgs e)
        {
            this.IsPresented = false;
        }

        private async void Onuserstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new UsersPage()));
            this.IsPresented = false;
        }

        private async void OnnotificationsTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AllNotificationViewPage()));
            this.IsPresented = false;
        }

        private async void Onmediatapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AllMediaContentPage()));
            this.IsPresented = false;
        }

        private void Onlogouttapped(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
