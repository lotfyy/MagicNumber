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
    public partial class GamePage : ContentPage
    {
        const int nbmin = 10;
        const int nbmax = 20;
        int nbmagique = 0;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            numberEntry.Focus();
        }
        public GamePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            nbmagique = new Random().Next(nbmin, nbmax);
            minMaxLabel.Text = "Entre " + nbmin + " et " + nbmax;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(numberEntry.Text))
            {
                DisplayAlert("Oops", "Vous devez entrer un nombre",  "Continue");
                return;

            }
            int usernumber = 0 ;
            try
            {
                usernumber = Int32.Parse(numberEntry.Text);

            }
            catch (Exception)
            {
                DisplayAlert("Oops", "Vous devez entrer des chiffres", "Continue");
                return;
            }
            
            if( (usernumber>nbmax) || (usernumber < nbmin))
            {
                DisplayAlert("Oops", "Vous devez entrer un nombre entre " + nbmin+" et "+ nbmax, "Continue");
                return;

            }
            if (nbmagique> usernumber)
            {
                DisplayAlert("Oops", "Le nombre est supérieur à" + usernumber, "Continue");
                return;
            }
            if (nbmagique < usernumber)
            {
                DisplayAlert("Oops", "Le nombre est inférieur à" + usernumber, "Continue");
                return;
            }
            if (nbmagique == usernumber)
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                winAction();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                return;
        
            }

        }
        private async Task winAction()
        {
    
            await Navigation.PushAsync(new WinPage());

        }
    }
}