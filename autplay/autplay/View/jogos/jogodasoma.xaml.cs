using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using autplay.Model;

using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodasoma : ContentPage
    {
        int RESPOSTA;
        Color corAntiga;
        int acertos = 0;

        public jogodasoma()
        {
            InitializeComponent();
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);
            background.Source = ImageSource.FromResource("autplay.Assets.backgroundJogodaSoma.png");
            gerar();
        }

        public void gerar()
        {
            int n1 = aleatorio(6);
            int n2 = aleatorio(6);
            RESPOSTA = n1 + n2;

            txt_numero1.Text = n1.ToString();
            txt_numero2.Text = n2.ToString();

            int vlr_botao1 = aleatorio(11);
            int vlr_botao2 = aleatorio(11);
            int vlr_botao3 = aleatorio(11);
            int vlr_botao4 = aleatorio(11);

            int botao = aleatorio(5);

            if (botao == 1)
            { vlr_botao1 = RESPOSTA; }
            else if (botao == 2)
            { vlr_botao2 = RESPOSTA; }
            else if (botao == 3)
            { vlr_botao3 = RESPOSTA; }
            else if (botao == 4)
            { vlr_botao4 = RESPOSTA; }

            while (vlr_botao1 == vlr_botao2 || vlr_botao1 == vlr_botao3 || vlr_botao1 == vlr_botao4)
            {
                vlr_botao1 = aleatorio(11);
            }
            while (vlr_botao2 == vlr_botao1 || vlr_botao2 == vlr_botao3 || vlr_botao2 == vlr_botao4)
            {
                vlr_botao2 = aleatorio(11);
            }
            while (vlr_botao3 == vlr_botao2 || vlr_botao3 == vlr_botao1 || vlr_botao3 == vlr_botao4)
            {
                vlr_botao3 = aleatorio(11);
            }
            while (vlr_botao4 == vlr_botao2 || vlr_botao4 == vlr_botao3 || vlr_botao4 == vlr_botao1)
            {
                vlr_botao4 = aleatorio(11);
            }

            btn_1.Text = vlr_botao1.ToString();
            btn_2.Text = vlr_botao2.ToString();
            btn_3.Text = vlr_botao3.ToString();
            btn_4.Text = vlr_botao4.ToString();

            btn_1.BackgroundColor = RandomColor();
            btn_2.BackgroundColor = RandomColor();
            btn_3.BackgroundColor = RandomColor();
            btn_4.BackgroundColor = RandomColor();
            Score.Text = "Score: " + acertos;

            // TERMINAR ESSA FUNÇÃO AINDA
        }

        private int aleatorio(int n)
        {
            var random = new Random();
            // Gere um valor aleatório entre 1 e 10 para os botões
            return random.Next(1, n);
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            // Manipule o clique do botão aqui
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);
            Task.Delay(500);
            int valor = int.Parse(button.Text);
            
            if (valor == RESPOSTA)
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                acertos++;
                gerar();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou\nTente Novamente!", "OK");
                button.BackgroundColor = Color.IndianRed;
            }
        }

        public Color RandomColor()
        {
            Color randomColor;
            var random = new Random();

            do
            {
                // Gera uma cor aleatória
                randomColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
            }
            // Verifica se a cor possui tons de vermelho (vermelho, rosa, laranja)
            while (randomColor.R > 200 && randomColor == corAntiga);

            corAntiga = randomColor;
            return randomColor;

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
    }
}

