using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{

    public partial class MainPage : ContentPage
    {
        private Dictionary<DateTime, string> TitleDates = new Dictionary<DateTime, string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToPage2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(TitleDates));
        }

        private void GoToPage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3(TitleDates));
        }

    }


}
