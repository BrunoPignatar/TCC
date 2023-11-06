using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodocorreto : ContentPage
    {
        public jogodocorreto()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            gerador();
        }

        int pergunta = 0, numero = 0, anteriorpgt = 0, anteriornmr = 0, acertos=0;

        private async void voltar_Clicked(object sender, EventArgs e)
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

        public async void gerador()
        {
            var random = new Random();

            pergunta = random.Next(1, 5);
            numero = random.Next(1, 5);

            if(numero == anteriornmr)
            {
                numero = random.Next(1, 5);
            }


            if (pergunta == 1)
            {
                txt_pergunta.Text = "Esse é o Gato?";
            }
            else if (pergunta == 2)
            {
                txt_pergunta.Text = "Esse é o Peixe?";
            }
            else if (pergunta == 3)
            {
                txt_pergunta.Text = "Esse é o Cachorro?";
            }
            else if (pergunta == 4)
            {
                txt_pergunta.Text = "Esse é o Cavalo?";
            }
            else if (pergunta == 5)
            {
                txt_pergunta.Text = "esse é o Papagaio?";
            }

            if (numero == 1)
            {
                img_animal.Source = ImageSource.FromResource("autplay.Assets.cat.png");
            }
            else if (numero == 2)
            {
                img_animal.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            }
            else if (numero == 3)
            {
                img_animal.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (numero == 4)
            {
                img_animal.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (numero == 5)
            {
                img_animal.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            }

            anteriornmr = numero;
            txt_contagem.Text = "Acertos: " + acertos.ToString();
            await Task.Delay(1000);

            var settings = new SpeechOptions()
            {
                Volume = .50f,
                Pitch = 1.6f
            };

            await TextToSpeech.SpeakAsync(txt_pergunta.Text, settings);
        }

        private async void btn_sim_Clicked(object sender, EventArgs e)
        {
            if (numero == pergunta)
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                acertos++;
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou\nTente Novamente!", "OK");
                
            }
        }

        private async void btn_nao_Clicked(object sender, EventArgs e)
        {
            if (numero != pergunta)
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                acertos++;
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou\nTente Novamente!", "OK");
                
            }
        }
    }
}