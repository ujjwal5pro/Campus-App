using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Academics_Section.PlacementCell_Section;
using Xamarin.Forms;

namespace Campus.Academics_Section
{
    public partial class PlacementCellPage : ContentPage
    {
        public PlacementCellPage()
        {
            InitializeComponent();
        }

        private async void Onprojecttapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Projects())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Onworkshopstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Workshops())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Oninternshipstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Internships())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Onjobstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Jobs())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Onscholarshipstapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Scholarships())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private async void Onhighereducationtapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HigherEducation())
            {
                BarBackgroundColor = Color.Teal
            });
        }
    }
}
