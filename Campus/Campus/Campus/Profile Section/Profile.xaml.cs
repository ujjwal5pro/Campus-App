using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campus.Profile_Section
{
    public partial class Profile : ContentPage
    {
        public Profile(List<Modal.StudentsInfo> sinfo)
        {
            InitializeComponent();
            BindingContext = sinfo[0];
        }

        private async void Oneditclicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new EditprofilePage())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Oncreateblog(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CreateBlogPage())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        //private async void Onlogoutclicked(object sender, EventArgs e)
        //{
        //    await Navigation.PopModalAsync();
        //}

        //private async void Onnotificationclicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new MyClassroom_Section.NoificationPage());
        //}

        //private void Onsettingclicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Information", "Under Construction", "Back");
        //}
    }
}
