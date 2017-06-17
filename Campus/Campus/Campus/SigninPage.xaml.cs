using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace Campus
{
    public partial class SigninPage : ContentPage
    {
        public SigninPage()
        {
            InitializeComponent();
            rollno.Focus();
        }

        async private void Onsigninclicked(object sender, EventArgs e)
        {
            try
            {
                syncIndicator.IsVisible = true;
                syncIndicator.IsRunning = true;
                mainstack.IsVisible = false;
                var client = new MobileServiceClient(Constants.ApplicationURL);
                IMobileServiceTable<Modal.StudentsInfo> studendata = client.GetTable<Modal.StudentsInfo>();
                List<Modal.StudentsInfo> items = await studendata.Where(student => student.Num == rollno.Text).ToListAsync();
                if (items[0].Password.ToString() == password.Text)
                {
                    rollno.Text = string.Empty;
                    password.Text = string.Empty;
                    Application.Current.Properties["Name"] = items[0].Name.ToString();
                    Application.Current.Properties["Department"] = items[0].Department.ToString();
                    Application.Current.Properties["Session"] = items[0].Session.ToString();
                    Application.Current.Properties["Dob"] = items[0].Dob.ToString();
                    Application.Current.Properties["Num"] = items[0].Num.ToString();
                    Application.Current.Properties["Phone"] = items[0].Phone.ToString();
                    Application.Current.Properties["Email"] = items[0].Email.ToString();
                    Application.Current.Properties["Password"] = items[0].Password.ToString();
                    Application.Current.Properties["loginstatus"] = "in";
                    await Application.Current.SavePropertiesAsync();
                    await Navigation.PushModalAsync(new Campus.MainPage(items));
                }
                else
                {
                    mainstack.IsVisible = true;
                    syncIndicator.IsVisible = false;
                    syncIndicator.IsRunning=false;
                    await DisplayAlert("!! Login Error", "Wrong Credential", "ok");
                }
            }
            catch (Exception exp)
            {
                syncIndicator.IsRunning = false;
                mainstack.IsVisible = true;
                await DisplayAlert("!! Login error","Invalid input or please check your internet connection", "ok");
            }
            finally
            {
                syncIndicator.IsVisible = false;
                syncIndicator.IsRunning = false;
                mainstack.IsVisible = true;
            }

        }

        async private void Onregisterclicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushModalAsync(new NavigationPage(new StudentRegisterPage() { Title = "GBP Campus" }));
            }catch(Exception ex)
            {
                await DisplayAlert("mess",ex.ToString(),"ok");
            }
        }
        protected override bool OnBackButtonPressed()
        {
            this.Navigation.PushModalAsync(new LandingPage());
            return true;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Forgotpasswordpage());
        }
    }
}
