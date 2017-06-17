using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Social_Section
{
    public partial class SocialPage : ContentPage
    {
        public SocialPage()
        {
            InitializeComponent();
            Datetimeshow.Text = DateTime.Now.ToString();
            Datetimeshow1.Text = DateTime.Now.ToString();
            Datetimeshow2.Text = DateTime.Now.ToString();
            Datetimeshow3.Text = DateTime.Now.ToString();
            Datetimeshow4.Text = DateTime.Now.ToString();
            Datetimeshow5.Text = DateTime.Now.ToString();
        }

        public int A, B, C, D, E, F = 0;
        private void Onliketapped(object sender, EventArgs e)
        {
            if (A % 2 == 0)
            {
                Likeframe.BackgroundColor = Color.Blue;
                Likebutton.TextColor = Color.White;
            }
            else
            {
                Likeframe.BackgroundColor = Color.White;
                Likebutton.TextColor = Color.Black;
            }
            A++;
        }

        private async void Oncontenttapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BlogviewPage())
            {
                BarBackgroundColor = Color.Teal
            });
        }

        private void Onlike1tapped(object sender, EventArgs e)
        {
            if (B % 2 == 0)
            {
                Likeframe1.BackgroundColor = Color.Blue;
                Likebutton1.TextColor = Color.White;
            }
            else
            {
                Likeframe1.BackgroundColor = Color.White;
                Likebutton1.TextColor = Color.Black;
            }
            B++;
        }
        private void Onlike2tapped(object sender, EventArgs e)
        {
            if (C % 2 == 0)
            {
                Likeframe2.BackgroundColor = Color.Blue;
                Likebutton2.TextColor = Color.White;
            }
            else
            {
                Likeframe2.BackgroundColor = Color.White;
                Likebutton2.TextColor = Color.Black;
            }
            C++;
        }
        private void Onlike3tapped(object sender, EventArgs e)
        {
            if (D % 2 == 0)
            {
                Likeframe3.BackgroundColor = Color.Blue;
                Likebutton3.TextColor = Color.White;
            }
            else
            {
                Likeframe3.BackgroundColor = Color.White;
                Likebutton3.TextColor = Color.Black;
            }
            D++;
        }
        private void Onlike4tapped(object sender, EventArgs e)
        {
            if (E % 2 == 0)
            {
                Likeframe4.BackgroundColor = Color.Blue;
                Likebutton4.TextColor = Color.White;
            }
            else
            {
                Likeframe4.BackgroundColor = Color.White;
                Likebutton4.TextColor = Color.Black;
            }
            E++;
        }

        private void Onlike5tapped(object sender, EventArgs e)
        {
            if (F % 2 == 0)
            {
                Likeframe5.BackgroundColor = Color.Blue;
                Likebutton5.TextColor = Color.White;
            }
            else
            {
                Likeframe5.BackgroundColor = Color.White;
                Likebutton5.TextColor = Color.Black;
            }
            F++;
        }

        private async void Onfilterclicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BlogfilterPage())
            {
                BarBackgroundColor = Color.Teal
            });
        }
    }
}
