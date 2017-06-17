using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.MyClassroom_Section;
using Xamarin.Forms;

namespace Campus.Academics_Section
{
    public partial class LibraryPage : ContentPage
    {
        public LibraryPage()
        {
            InitializeComponent();
            showcontent();
        }
        public int a = 0;
        public int b = 0;
        public int c = 0;
        private void Onebookstapped(object sender, EventArgs e)
        {
            if (a%2 == 0)
            {
                Contentlist.IsVisible = true;
                Contentlistremove();
                Ebooksfield.Children.Add(Contentlist);
                Ebooks.IsVisible = true;
            }
            else
            {
                showcontent();
            }
            a++;
        }private void Onmagzinestapped(object sender, EventArgs e)
        {
            if (b%2==0)
            {
                Contentlist.IsVisible = true;
                Contentlistremove();
                Magzinesfield.Children.Add(Contentlist);
                Magzines.IsVisible = true;
            }
            else
            {
                showcontent();
            }
            b++;
        }
        private void Onenewspaperstapped(object sender, EventArgs e)
        {
            if (c%2==0)
            {
                Contentlist.IsVisible = true;
                Contentlistremove();
                Newspapersfield.Children.Add(Contentlist);
                Newspapers.IsVisible = true;
            }
            else
            {
                showcontent();
            }
                c++;
        }

        void Contentlistremove()
        {
            Ebooksfield.Children.Remove(Contentlist);
            Magzinesfield.Children.Remove(Contentlist);
            Newspapersfield.Children.Remove(Contentlist);
        }

        void showcontent()
        {
            Contentlist.IsVisible = false;
            Ebooks.IsVisible = true;
            Magzines.IsVisible = true;
            Newspapers.IsVisible = true;
            Contentlistremove();
        }

        private void Onsearchclicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SearchPage());
        }
    }
}
