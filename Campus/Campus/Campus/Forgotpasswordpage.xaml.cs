using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forgotpasswordpage : ContentPage
    {
        public Forgotpasswordpage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(rollno.Text==string.Empty || rollno.Text == null || email.Text==string.Empty || email.Text==null)
            {
               await DisplayAlert("Information", "Please fill required details", "ok");
            }
            else
            {
                try
                {
                    var client = new MobileServiceClient(Constants.ApplicationURL);
                    IMobileServiceTable<Modal.StudentsInfo> studendata = client.GetTable<Modal.StudentsInfo>();
                    List<Modal.StudentsInfo> items =await studendata.Where(student => student.Num == rollno.Text).ToListAsync();
                    if (items[0].Email.ToString() == email.Text)
                    {
                        await Navigation.PopModalAsync();
                        await DisplayAlert("Password", "Your Password is :: " + items[0].Password.ToString(), "ok");
                    }
                    else
                        await DisplayAlert("!! Error","Wrong Credential","ok");
                }catch(Exception ex)
                {
                   await DisplayAlert("!! Error","Fail to Recover password","ok" );
                }

            }
        }
    }
}
