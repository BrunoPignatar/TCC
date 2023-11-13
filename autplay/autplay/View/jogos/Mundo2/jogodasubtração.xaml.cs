using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodasubtração : ContentPage
    {
        int RESPOSTA;
        Color corAntiga;
        int acertos = 0;
        public jogodasubtração()
        {
            InitializeComponent();
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);
            background.Source = ImageSource.FromResource("autplay.Assets.backgroundJogodaSoma.png");
            gerar();
        }

        public async void gerar()
        {
            try
            {
                int n1, n2;
                do
                {
                    n1 = aleatorio(6);
                    n2 = aleatorio(6);
                } while (n1 <= n2 || n1 == 0);

                RESPOSTA = n1 - n2;
                txt_numero1.Text = n1.ToString();
                txt_numero2.Text = n2.ToString();

                List<int> valoresBotoes = new List<int> { RESPOSTA, aleatorio(11), aleatorio(11), aleatorio(11) };

                // Embaralhar os valores
                valoresBotoes = valoresBotoes.OrderBy(a => Guid.NewGuid()).ToList();


                Console.WriteLine("-------------------------------------------");

                Console.WriteLine(valoresBotoes[0]); // 4
                Console.WriteLine(valoresBotoes[1]); // 9
                Console.WriteLine(valoresBotoes[2]); // 1
                Console.WriteLine(valoresBotoes[3]); // 4
                Console.WriteLine(RESPOSTA); // 4

                Console.WriteLine("-------------------------------------------");

                for (int i = 0; i < valoresBotoes.Count; i++)
                {
                    for (int j = i + 1; j < valoresBotoes.Count; j++)
                    {
                        if (valoresBotoes[i] == valoresBotoes[j])
                        {
                            valoresBotoes[j] = aleatorio(11);
                            j = i + 1;
                        }
                    }
                }


                btn_1.Text = valoresBotoes[0].ToString();
                btn_2.Text = valoresBotoes[1].ToString();
                btn_3.Text = valoresBotoes[2].ToString();
                btn_4.Text = valoresBotoes[3].ToString();

                // Definir as cores dos botões
                btn_1.BackgroundColor = RandomColor();
                btn_2.BackgroundColor = RandomColor();
                btn_3.BackgroundColor = RandomColor();
                btn_4.BackgroundColor = RandomColor();

                Score.Text = "Score: " + acertos;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
                Console.WriteLine(ex.StackTrace);
            }


        }

        private int aleatorio(int n)
        {
            var random = new Random();
            // Gere um valor aleatório entre 1 e 10 para os botões
            return random.Next(0, n);
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