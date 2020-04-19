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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            looop();
            looop2();
            

        }

        private async Task looop()
        {
            bool always = true;
            while (always) { 
                await img.RotateTo(20, 1000);
                await img.RotateTo(0, 1000);
                img.Rotation = 0;
            }
        }
        private async Task looop2()
        {
            bool always = true;
            while (always)
            {
                await btn.ScaleTo(1.1, 1500);
                await btn.ScaleTo(1.0, 1500);

            }
        }

        private void Play_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());

        }
    }
}