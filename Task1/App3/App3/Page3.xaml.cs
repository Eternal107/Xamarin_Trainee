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

        private Dictionary<DateTime, string> TitleDates;
        public Page3(Dictionary<DateTime, string> titleDates)
        {
            InitializeComponent();
            TitleDates = titleDates;
            SetListView();
        }

        private void SetListView()
        {
            int capacity = TitleDates.Count;
            List<string> temp = new List<string>();
            for (int i = 0; i < capacity; i++)
                temp.Add(TitleDates.ElementAt(i).Value + " " + TitleDates.ElementAt(i).Key.ToString("HH:mm:ss") + '\n');
            HistoryListView.ItemsSource = temp;
        }

    }
}