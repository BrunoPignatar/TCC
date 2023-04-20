using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class selecao : ContentPage
    {
        public selecao()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new autplay.selectword.Mundo1());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new autplay.selectword.Mundo2());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new autplay.selectword.Mundo3());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}