using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WinPage : ContentPage
    {
        public WinPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            main.Scale = 0.7;
            main.ScaleTo(1.0, 1500, Easing.BounceIn);
            wait();
        }
        private async Task wait()
        {
            await Task.Delay(4000);
            await Navigation.PopToRootAsync();



        }
    }
}