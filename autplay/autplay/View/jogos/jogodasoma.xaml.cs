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
    public partial class jogodasoma : ContentPage
    {
        int RESPOSTA;
        bool REINICIAR = false;
        public jogodasoma()
        {
            InitializeComponent();
            gerador();
      
        }

        public void gerador()
        {
            var random = new Random();

            int numero1 = random.Next(1, 5);
            int numero2 = random.Next(1, 5);

            int errado1 = random.Next(1, 10);
            int errado2 = random.Next(1, 10);
            int errado3 = random.Next(1, 10);
            int errado4 = random.Next(1, 10);


            txt_numero1.Text = numero1.ToString();
            txt_numero2.Text = numero2.ToString();

            int resposta = numero1 + numero2;

            RESPOSTA = resposta;

            int escolha_certo = random.Next(1, 4);

            if (escolha_certo == 1)
            {
                btn_1.Text = resposta.ToString();
            }
            else if (escolha_certo == 2)
            {
                btn_2.Text = resposta.ToString();
            }
            else if (escolha_certo == 3)
            {
                btn_3.Text = resposta.ToString();
            }
            else if (escolha_certo == 4)
            {
                btn_4.Text = resposta.ToString();
            }

            if (escolha_certo != 1)
            {
                int errado = random.Next(1, 10);

                while (errado == resposta)
                {
                    errado = random.Next(1, 10);
                }

                btn_1.Text = errado.ToString();
            }
            if (escolha_certo != 2)
            {

                while (errado1 == resposta)
                {
                    errado1 = random.Next(1, 10);
                }

                btn_2.Text = errado1.ToString();
            }
            if (escolha_certo != 3)
            {
                while (errado3 == resposta || errado1 == errado2)
                {
                    errado2 = random.Next(1, 10);
                }

                btn_3.Text = errado2.ToString();
            }
            if (escolha_certo != 4)
            {
                while (errado4 == resposta || errado1 == errado2 || errado3 == errado2)
                {
                    errado4 = random.Next(1, 10);
                }

                btn_4.Text = errado4.ToString();
            }
        
    }

        private async void btn_4_Clicked(object sender, EventArgs e)
        {
            if (btn_1.Text == RESPOSTA.ToString())
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou", "OK");

            }
        }

        private async void btn_3_Clicked(object sender, EventArgs e)
        {
            if (btn_3.Text == RESPOSTA.ToString())
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou", "OK");

            }
        }

        private async void btn_2_Clicked(object sender, EventArgs e)
        {
            if (btn_2.Text == RESPOSTA.ToString())
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou", "OK");

            }
        }

        private async void btn_1_Clicked(object sender, EventArgs e)
        {
            if (btn_1.Text == RESPOSTA.ToString())
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou", "OK");

            }
        }
    }
    
}