using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.selectword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mundo1 : ContentPage
    {
        public Mundo1()
        {
            InitializeComponent();

            //removendo a navbar
            NavigationPage.SetHasNavigationBar(this, false);

            //BARRA DO USUÁRIO(AVATAR)
            AvatarImage.Source = ImageSource.FromResource(App.DadosAvatar.Imagem);
            lblBoasVindas.Text = "Bem-vindo Senhor " + App.DadosAvatar.Nome;
            AlterAvatar.Source = ImageSource.FromResource("autplay.Assets.lapis.png");
        }

        private async void jogo1_Clicked(object sender, EventArgs e)
        {
            
            // Aguardar por 2 segundos (2000 milissegundos)
            await Task.Delay(300);
            
            Navigation.PushAsync(new autplay.View.jogos.jogodavelha());
        }

        private void jogo2_Clicked(object sender, EventArgs e)
        {

        }

        private void jogo3_Clicked(object sender, EventArgs e)
        {

        }

        private void AlterAvatar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}