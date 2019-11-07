using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    
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
                
                App.TitleDatess.Add(DateTime.Now, entry.Text);

                var page = Navigation.NavigationStack.LastOrDefault(p => p is MainPage);    
                if(page != null)
                    page.Title=entry.Text;
            }
        }
    }
}