using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Campus.Academics_Section;
using Campus.Home_Section;
using Campus.Modal;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices;

namespace Campus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("loginstatus"))
            {
                var slist = new List<StudentsInfo>
                {
                    new StudentsInfo
                    {
                        Name=Application.Current.Properties["Name"] as string,
                        Department=Application.Current.Properties["Department"] as string,
                        Session=Application.Current.Properties["Session"] as string,
                        Dob=Application.Current.Properties["Dob"] as string,
                        Num=Application.Current.Properties["Num"] as string,
                        Phone=Application.Current.Properties["Phone"] as string,
                        Email=Application.Current.Properties["Email"] as string,
                        Password=Application.Current.Properties["Password"] as string,
                    }
                };
                var status = Application.Current.Properties["loginstatus"] as string;
                if (status == "in")
                {
                    MainPage = new Campus.MainPage(slist);
                }
                else
                {
                    MainPage = new LandingPage();
                }
            }
            else
            {
                MainPage = new LandingPage();
            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        protected virtual void onBackPressed()
        {
        }
    }
}
