using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Profile_Section
{
    public partial class EditprofilePage : ContentPage
    {
        public EditprofilePage()
        {
            InitializeComponent();
        }

        private void Oncontinueclicked(object sender, EventArgs e)
        {
            DisplayAlert("Information", "Profile Updated", "Ok");
            this.Navigation.PopModalAsync();
        }
    }
}
