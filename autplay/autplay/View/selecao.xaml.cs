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
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);

            btn_wordapocalypse.Source = ImageSource.FromResource("autplay.Assets.mundo2.png");
            btn_wordgum.Source = ImageSource.FromResource("autplay.Assets.mundo3.png");
            btn_wordrose.Source = ImageSource.FromResource("autplay.Assets.mundo1.png");


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



        private async void btn_voltar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new Menu());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void btn_wordrose_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo1());
        }

        private void btn_wordapocalypse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo2());
        }

        private void btn_wordgum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo3());
        }
    }
}