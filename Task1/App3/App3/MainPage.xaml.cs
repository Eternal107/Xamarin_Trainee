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

        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToPage2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void GoToPage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

    }


}
