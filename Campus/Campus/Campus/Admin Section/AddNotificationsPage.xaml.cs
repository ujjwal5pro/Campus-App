using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Services;
using Campus.Modal;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace Campus.Admin_Section
{
    public partial class AddNotificationsPage : ContentPage
    {
        //TodoItemManager manager;
        MobileServiceClient client;
        IMobileServiceTable<TodoItem> table;
        public AddNotificationsPage()
        {
            InitializeComponent();
            //manager = TodoItemManager.DefaultManager;
            this.client = new MobileServiceClient(Constants.ApplicationURL);
            this.table = client.GetTable<TodoItem>();
        }

        async private void Onclreateclicked(object sender, EventArgs e)
        {
            var Areastrng = string.Empty;
            switch (Area.SelectedIndex)
            {
                case 0: Areastrng = "Global"; break;
                case 1: Areastrng = "Specific Class"; break;
            }

            var tstring=string.Empty;
            switch (type.SelectedIndex)
            {
                case 0: tstring = "Anouncement"; break; 
                case 1: tstring = "Notice"; break;
                case 2: tstring = "Academics"; break;
                case 3: tstring = "Placement"; break;
                case 4: tstring = "Library"; break;
                case 5: tstring = "Sports"; break;
                case 6: tstring = "Others"; break;
            }

            var Departmntstrng = string.Empty;
            switch (department.SelectedIndex)
            {
                case 0: Departmntstrng = "cse"; break;
                case 1: Departmntstrng = "mae"; break;
                case 2: Departmntstrng = "ece"; break;
            }

            if (Global_Stack.IsVisible) { Departmntstrng = string.Empty; }
            else if (local_Stack.IsVisible) { tstring = string.Empty; }
            
            var todo = new TodoItem
            {
                Name = title.Text,
                Content = content.Text,
                Dtime = DateTime.Now.ToString(),
                Owner = "Administrator",
                Area = Areastrng,
                Type = tstring,
                Department=Departmntstrng
            };
            try
            {
                //await manager.SaveTaskAsync(todo);
                await table.InsertAsync(todo);
                await Navigation.PopModalAsync();
                await DisplayAlert("Information", "Notification Created", "Ok");
            }
            catch (Exception exp)
            {
                await DisplayAlert("!! Fail", "Please check your internet connection.", "ok");
            }

        }

        private void Oncloseclicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Area.SelectedIndex==0)
            {
                Global_Stack.IsVisible = true;
                local_Stack.IsVisible = false;
            }
            else if (Area.SelectedIndex == 1)
            {
                Global_Stack.IsVisible = false;
                local_Stack.IsVisible = true;
            }
        }
    }
}