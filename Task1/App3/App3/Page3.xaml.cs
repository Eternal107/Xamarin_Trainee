using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    
    public partial class Page3 : ContentPage
    {
        
        
        public Page3()
        {

            InitializeComponent();
            SetListView();

        }

        private void SetListView()
        {
            int capacity = App.Titles.Count;
            List<string> temp = new List<string>();
            for (int i = 0; i < capacity; i++)
                temp.Add(App.Titles[i] + " " + App.Dates[i] + '\n');
            HistoryListView.ItemsSource = temp;
        }

    }
}