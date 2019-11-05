using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

        public Page2()
        {
            InitializeComponent();
        }

        private void SaveTtile(object sender, EventArgs e)
        {
            if (entry.Text != null)
            {
                App.Titles.Add(entry.Text);
                App.Dates.Add(DateTime.Now.ToString("HH:mm:ss"));

                Navigation.NavigationStack.First().Title = App.Titles.Last();
            }
        }
    }
}