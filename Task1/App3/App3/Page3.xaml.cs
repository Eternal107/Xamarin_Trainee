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
    public partial class Page3 : ContentPage
    {
        private string myStringProperty;
        public string MyStringProperty
        {
            get
            {
                return myStringProperty;
            }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty));
            }
        }

        private void SetPropertyLabel()
        {
            int capacity = App.Titles.Count;

            for (int i = 0; i < capacity; i++)
                MyStringProperty += (App.Titles[i] + " " + App.Dates[i] + '\n');
        }
        public Page3()
        {
            SetPropertyLabel();
            BindingContext = this;
            InitializeComponent();
        }

    }
}