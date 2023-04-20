using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autplay.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            //ADIÇÃO DAS IMAGENS
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
            btn_add.Source = ImageSource.FromResource("autplay.Assets.botaoadd.png");
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //BOTÃO QUE LEVA A TELA DE SELEÇÃO-- OK
        private async void btn_jogar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new autplay.View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        //BOTÃO DE ADICIONAR FOTO COMO AVATAR--
        private void btn_add_Clicked(object sender, EventArgs e)
        {

        }

    }
}