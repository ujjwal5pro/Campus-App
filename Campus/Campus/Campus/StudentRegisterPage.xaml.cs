using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Campus.Modal;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace Campus
{
    public partial class StudentRegisterPage : ContentPage
    {
        //Services.StudentsInfoManager manager;
        MobileServiceClient client;
        IMobileServiceTable<StudentsInfo> table;

        public StudentRegisterPage()
        {
            InitializeComponent();
            //manager = Services.StudentsInfoManager.DefaultManager;
            this.client = new MobileServiceClient(Constants.ApplicationURL);
            this.table = client.GetTable<StudentsInfo>();
        }

        async private void Oncontinueclicked(object sender, EventArgs e)
        {
            if (password.Text != string.Empty && password.Text!=null)
            {

                var Departmntstrng = string.Empty;
                switch (department.SelectedIndex)
                {
                    case 0: Departmntstrng = "cse"; break;
                    case 1: Departmntstrng = "mae"; break;
                    case 2: Departmntstrng = "ece"; break;
                }
                var studentin = new Modal.StudentsInfo
                {
                    Num = rollno.Text,
                    Name = name.Text,
                    Department = Departmntstrng,
                    Session = sessoin.Text,
                    Dob = birthdate.Text,
                    Phone = phone.Text,
                    Email = email.Text,
                    Password = password.Text,
                };
                try
                {
                    syncIndicator.IsRunning = true;
                    syncIndicator.IsVisible = true;
                    await table.InsertAsync(studentin);
                    syncIndicator.IsVisible = false;
                    syncIndicator.IsRunning = false;
                    await DisplayAlert("Information", "Registered Successfully", "Ok");
                    await Navigation.PopModalAsync();
                    await Navigation.PushModalAsync(new SigninPage());
                }
                catch (Exception exp)
                {
                    //mainstack.IsVisible = true;
                    syncIndicator.IsRunning = false;
                    syncIndicator.IsVisible = false;
                    await DisplayAlert("!! Registration Fail", "Please check your internet connection.", "ok");
                }
                finally
                {
                    //mainstack.IsVisible = true;
                }
            }
            else
                await DisplayAlert("!! Registration Fail", "Please enter full details", "ok");
        }
        private void Onnextclicked(object sender, EventArgs e)
        {
            if (rollno.Text == null || rollno.Text==string.Empty)
            {
                DisplayAlert("Warning", "Problem in roll no", "ok");
            }
            else
            {
                rollno1.Text = rollno.Text;
                stack1.IsVisible = false;
                stack2.IsVisible = true;
                name.Focus();
            }
            
        }
        private void OnNext2clicked(object sender, EventArgs e)
        {
            if (validate())
            {
                stack2.IsVisible = false;
                stack3.IsVisible = true;
            }
            else
                DisplayAlert("!! Information", "Please enter full details", "ok");

        }


        private void Oncloseclicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            if (stack3.IsVisible) { stack3.IsVisible = false;stack2.IsVisible = true; }
            else if (stack2.IsVisible) { stack2.IsVisible = false;stack1.IsVisible = true; }
            else
            {
                    this.Navigation.PopModalAsync();
            }
                return true;
        }
         

        public bool validate()
        {
                if(rollno.Text==string.Empty || rollno.Text==null ||
                name.Text== string.Empty || name.Text==null ||
                 department.SelectedIndex==-1 || 
                  sessoin.Text == string.Empty || sessoin.Text==null ||
                  birthdate.Text == string.Empty || birthdate.Text==null||
                  phone.Text == string.Empty || phone.Text==null ||
                  email.Text == string.Empty || email.Text==null)
            {
                return false; }
            else return true;
        }

    }
}
