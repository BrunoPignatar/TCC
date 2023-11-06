using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodapalavra : ContentPage
    {
        public jogodapalavra()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            gerador();
        }
        string resposta_correta; int anterior; int acertos = 0;

        public void gerador()
        {
            var ramdom = new Random();

            int animal = ramdom.Next(1, 5);
            while(animal == anterior)
            {
                animal = ramdom.Next(1, 5);
            }


            if (animal == 1)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.cat.png");
                resposta_correta = "gato";
            }
            else if (animal == 2)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
                resposta_correta = "peixe";
            }
            else if (animal == 3)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.dog.png");
                resposta_correta = "cachorro";
            }
            else if (animal == 4)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.horse.png");
                resposta_correta = "cavalo";
            }
            else if (animal == 5)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
                resposta_correta = "papagaio";
            }

            anterior = animal;
            Score.Text = "Acertos: " + acertos;
        }

        private async void btn_enviar_Clicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);
            await Task.Delay(100);

            if (txt_resposta.Text == resposta_correta)
            {
                await DisplayAlert("Parabéns", "Você acertou", "ok");
                resposta_correta = "";
                txt_resposta.Text = "";
                acertos++;
                gerador();
            }
            else
            {
                await DisplayAlert("Que pena!", "Você errou\nTente Novamente!", "ok");
                txt_resposta.Text = "";
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Manipule o clique do botão aqui
                Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

                await Model.Animacoes.AnimacaoBotao(button);

                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}