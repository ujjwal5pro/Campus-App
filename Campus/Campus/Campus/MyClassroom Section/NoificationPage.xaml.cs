using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.MyClassroom_Section
{
    public partial class NoificationPage : ContentPage
    {
        public NoificationPage()
        {
            InitializeComponent();
        }

        private async void Onclosetapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
