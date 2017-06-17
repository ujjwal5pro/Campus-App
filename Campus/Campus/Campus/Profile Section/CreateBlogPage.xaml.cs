using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Modal;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

using Xamarin.Forms;

namespace Campus.Profile_Section
{
    public partial class CreateBlogPage : ContentPage
    {
        MobileServiceClient client;
        IMobileServiceTable<Blogs> table;
        public CreateBlogPage()
        {
            InitializeComponent();
            this.client = new MobileServiceClient(Constants.ApplicationURL);
            this.table = client.GetTable<Blogs>();
        }

        private async void Oncreateclicked(object sender, EventArgs e)
        {
            string Name = Application.Current.Properties["Name"] as string;

            var studentin = new Modal.Blogs
            {
                Title = btitle.Text,
                Content = bcontent.Text,
                Dtime = DateTime.Now.ToString(),
                Owner=Name,
                Field=bfield.Text
            };
            try
            {
                await table.InsertAsync(studentin);
                await DisplayAlert("Information", "Blog/Article Created", "ok");
                await Navigation.PopModalAsync();
            }
            catch (Exception exp)
            {
                await DisplayAlert("Message", exp.ToString(), "ok");
            }
            finally
            {
             
            }
        }

        private void Oncloseclicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
