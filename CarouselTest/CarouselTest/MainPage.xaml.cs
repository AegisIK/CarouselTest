using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.MainPageViewModel();
            List<string> mylist = new List<string>(new string[] { "page1", "page2", "page3", "page4" });
            view.ItemsSource = mylist;
    }
    }
}
