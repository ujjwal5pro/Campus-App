using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Campus.Admin_Section
{
    public partial class UserManagePage : ContentPage
    {
        public UserManagePage(Modal.StudentsInfo sinfo)
        {
            InitializeComponent();
            BindingContext = sinfo;
        }
    }
}
