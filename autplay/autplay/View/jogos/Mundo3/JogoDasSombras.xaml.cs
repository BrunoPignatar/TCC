using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JogoDasSombras : ContentPage
    {
        public JogoDasSombras()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            gerador();
        }
        ImageSource imgcorreta; int acertos = 0, anteriorResposta = 0, anteriorbotao = 0;
        private async void check(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            if (btn.Source == imgcorreta)
            {
                await DisplayAlert("Parabens", "voce acertou", "ok");
                acertos++;
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena ", "Você errou\nTente Novamente", "ok");
            }
        }

        public void gerador()
        {
            var random = new Random();

            int resposta = random.Next(1, 6);
            while (resposta == anteriorResposta)
            {
                resposta = random.Next(1, 5);
            }

            //botao correto
            int botao = random.Next(1, 5);
            while (botao == anteriorbotao)
            {
                botao = random.Next(1, 4);
            }

            //colocando img_sombra
            if (resposta == 1)
            {
                imgcorreta = ImageSource.FromResource("autplay.Assets.parrot.png");
                img_sombra.Source = imgcorreta;
            }
            else if (resposta == 2)
            {
                imgcorreta = ImageSource.FromResource("autplay.Assets.dog.png");
                img_sombra.Source = imgcorreta;
            }
            else if (resposta == 3)
            {
                imgcorreta = ImageSource.FromResource("autplay.Assets.horse.png");
                img_sombra.Source = imgcorreta;
            }
            else if (resposta == 4)
            {
                imgcorreta = ImageSource.FromResource("autplay.Assets.clown-fish.png");
                img_sombra.Source = imgcorreta;
            }
            else if (resposta == 5)
            {
                imgcorreta = ImageSource.FromResource("autplay.Assets.cat.png");
                img_sombra.Source = imgcorreta;
            }

            // gerando fotos aleatorias
            int btn1 = random.Next(1, 5),
                btn2 = random.Next(1, 5),
                btn3 = random.Next(1, 5);
            while (btn1 == botao || btn1 == btn2 || btn1 == btn3)
            {
                btn1 = random.Next(1, 5);
            }
            while (btn2 == botao || btn2 == btn1 || btn2 == btn3)
            {
                btn2 = random.Next(1, 5);
            }
            while (btn3 == botao || btn3 == btn2 || btn3 == btn1)
            {
                btn3 = random.Next(1, 5);
            }


            //colocando resposta correta
            if (botao == 1)
            {
                img_1.Source = imgcorreta;
                img_2.Source = ImagemAleatoria(btn1);
                img_3.Source = ImagemAleatoria(btn2);
                img_4.Source = ImagemAleatoria(btn3);
            }
            else if (botao == 2)
            {
                img_1.Source = ImagemAleatoria(btn1);
                img_2.Source = imgcorreta;
                img_3.Source = ImagemAleatoria(btn2);
                img_4.Source = ImagemAleatoria(btn3);
            }
            else if (botao == 3)
            {
                img_1.Source = ImagemAleatoria(btn2);
                img_2.Source = ImagemAleatoria(btn1);
                img_3.Source = imgcorreta;
                img_4.Source = ImagemAleatoria(btn3);
            }
            else if (botao == 4)
            {
                img_1.Source = ImagemAleatoria(btn3);
                img_2.Source = ImagemAleatoria(btn1);
                img_3.Source = ImagemAleatoria(btn2);
                img_4.Source = imgcorreta;
            }

            anteriorResposta = resposta;
            anteriorbotao = botao;
            Score.Text = "Acertos: " + acertos.ToString();
        }

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

        public ImageSource ImagemAleatoria(int gerado)
        {
            if (gerado == 1)
            {
                return ImageSource.FromResource("autplay.Assets.parrot.png");
            }
            else if (gerado == 2)
            {
                return ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (gerado == 3)
            {
                return ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (gerado == 4)
            {
                return ImageSource.FromResource("autplay.Assets.clown-fish.png");
            }
            else if (gerado == 5)
            {
                return ImageSource.FromResource("autplay.Assets.cat.png");
            }
            return "";
        }
    }
}