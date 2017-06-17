using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Modal;
using Xamarin.Forms;

namespace Campus.Admin_Section
{
    public partial class ViewNotificationPage : ContentPage
    {
        public ViewNotificationPage(TodoItem sinfo)
        {
            InitializeComponent();
            BindingContext = sinfo;
        }
    }
}
