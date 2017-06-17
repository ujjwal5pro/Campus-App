using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Campus.Home_Section
{
    public partial class AnouncementsPage : ContentPage
    {
        public AnouncementsPage()
        {
            InitializeComponent();
            Setdate();
        }
        public void Setdate()
        {
            PresentDate1.Text = DateTime.Now.ToString();
            PresentDate2.Text = DateTime.Today.ToString();
            PresentDate3.Text = DateTime.Today.ToString();
            PresentDate4.Text = DateTime.Today.ToString();
            PresentDate5.Text = DateTime.Today.ToString();
        }
    }
}
