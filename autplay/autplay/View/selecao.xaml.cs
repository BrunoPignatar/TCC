using autplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

            //ADICIONANDO AS IMAGENS DOS MUNDOS
            btn_worldapocalypse.Source = ImageSource.FromResource("autplay.Assets.mundo2.png");
            btn_worldgum.Source = ImageSource.FromResource("autplay.Assets.mundo3.png");
            btn_worldrose.Source = ImageSource.FromResource("autplay.Assets.mundo1.png");
            

            //BARRA DO USUÁRIO(AVATAR)
            //AvatarImage.Source = ImageSource.FromResource(App.DadosAvatar.ImagemPadrao);
            if (App.DadosAvatar.ImagemEnviada != null)
            {
                AvatarImage.Source = App.DadosAvatar.ImagemEnviada;
                lblBoasVindas.Text = "Bem-vindo Senhor(a) " + App.DadosAvatar.Nome;

            }
            else
            {
                AvatarImage.Source = App.DadosAvatar.ImagemPadrao;
                lblBoasVindas.Text = "Bem-vindo Senhor(a) " + App.DadosAvatar.Nome;
            }

            FalaInicial();
        }

        private async void FalaInicial()
        {
            var settings = new SpeechOptions()
            {
                Volume = .50f,
                Pitch = 1.6f
            };
            await TextToSpeech.SpeakAsync("bem vindo senhor" + App.DadosAvatar.Nome, settings);
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

        private void btn_worldrose_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo1());
        }

        private void btn_worldapocalypse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo2());
        }

        private void btn_worldgum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new selectword.Mundo3());
        }

        private async void AlterAvatar_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Manipule o clique do botão aqui
                Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

                await Model.Animacoes.AnimacaoBotao(button);

                App.Current.MainPage = new NavigationPage(new Menu());
                App.DadosAvatar = null;

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void AvatarImage_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("teste", "imagem do avatar", "OK");
        }

        private async void btn_ajuda_Clicked(object sender, EventArgs e)
        {
            var settings = new SpeechOptions()
            {
                Volume = .50f,
                Pitch = 1.6f
            };
            await TextToSpeech.SpeakAsync("Selecione um mundo e se divirta em seus jogos!", settings);
        }
    }
}