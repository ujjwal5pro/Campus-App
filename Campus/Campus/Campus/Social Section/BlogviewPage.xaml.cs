using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Social_Section
{
    public partial class BlogviewPage : ContentPage
    {
        public BlogviewPage()
        {
            InitializeComponent();
        }

        private async void Oncloseclicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
