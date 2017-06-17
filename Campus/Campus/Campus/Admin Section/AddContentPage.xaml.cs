using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Admin_Section
{
    public partial class AddContentPage : ContentPage
    {
        public AddContentPage()
        {
            InitializeComponent();
        }
        private void Onclreateclicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
            DisplayAlert("Information", "Media Added", "Ok");
        }

        private void Oncloseclicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
