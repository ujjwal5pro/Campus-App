using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.MyClassroom_Section
{
    public partial class SearchPage : ContentPage
    {
        private List<string> source=new List<string>
        {
           "Notes","Question Papers","Lecture Videos","Ebooks","Course Tutorials"
        }; 
        public SearchPage()
        {
            InitializeComponent();
            this.SearchBar1.Focus();
            ListView1.ItemsSource = source;
        }

        private void ListView1_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Information", "Under Construction", "Ok");
        }
        private void SearchBar1_OnSearchButtonPressed(object sender, EventArgs e)
        {
            string mystring = SearchBar1.Text.ToLower();
            IEnumerable<string> result = source.Where(x => x.ToLower().Contains(mystring));
            if (result.Count() > 0)
                ListView1.ItemsSource = result;
            else
                ListView1.ItemsSource = new List<string> { "not found" };
        }

        private void SearchBar1_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue.ToString())) {}
            else
            {
                string mystring = SearchBar1.Text.ToLower();
                IEnumerable<string> result = source.Where(x => x.ToLower().Contains(mystring));
                if (result.Count() > 0)
                    ListView1.ItemsSource = result;
                else
                    ListView1.ItemsSource = new List<string> {"not found"};
            }
        }
    }
}
