using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodasoma : ContentPage
    {
        int RESPOSTA;
        //bool REINICIAR = false;
        
        public jogodasoma()
        {
            InitializeComponent();
            gerar();

        }

        //    public void gerador()
        //    {
        //        var random = new Random();

        //        int numero1 = random.Next(1, 5);
        //        int numero2 = random.Next(1, 5);

        //        int botao1 = 0; //random.Next(1, 10);
        //        int botao2 = 0; //random.Next(1, 10);
        //        int botao3 = 0; //random.Next(1, 10);
        //        int botao4 = 0; //random.Next(1, 10);


        //        txt_numero1.Text = numero1.ToString();
        //        txt_numero2.Text = numero2.ToString();

        //        int resposta = numero1 + numero2;

        //        RESPOSTA = resposta;

        //        int escolha_certo = random.Next(1, 4);

        //        if (escolha_certo == 1)
        //        {
        //            btn_1.Text = resposta.ToString();
        //            // WHILE PARA O RESULTADO NÃO CAIR EM DOIS BOTÕES AO MESMO TEMPO
        //            while (botao2 == 0 || botao2 == resposta)
        //            {
        //                botao2 = random.Next(1, 10);
        //            }

        //            while (botao3 == 0 || botao3 == resposta)
        //            {
        //                botao3 = random.Next(1, 10);
        //            }

        //            while (botao4 == 0 || botao4 == resposta)
        //            {
        //                botao4 = random.Next(1, 10);
        //            }

        //            btn_2.Text = botao2.ToString();
        //            btn_3.Text = botao3.ToString();
        //            btn_4.Text = botao4.ToString();
        //        }
        //        else if (escolha_certo == 2)
        //        {
        //            btn_2.Text = resposta.ToString();
        //            // WHILE PARA O RESULTADO NÃO CAIR EM DOIS BOTÕES AO MESMO TEMPO
        //            while (botao1 == 0 || botao1 == resposta)
        //            {
        //                botao1 = random.Next(1, 10);
        //            }

        //            while (botao3 == 0 || botao3 == resposta)
        //            {
        //                botao3 = random.Next(1, 10);
        //            }

        //            while (botao4 == 0 || botao4 == resposta)
        //            {
        //                botao4 = random.Next(1, 10);
        //            }

        //            btn_1.Text = botao2.ToString();
        //            btn_3.Text = botao3.ToString();
        //            btn_4.Text = botao4.ToString();
        //        }
        //        else if (escolha_certo == 3)
        //        {
        //            btn_3.Text = resposta.ToString();
        //            // WHILE PARA O RESULTADO NÃO CAIR EM DOIS BOTÕES AO MESMO TEMPO
        //            while (botao2 == 0 || botao2 == resposta)
        //            {
        //                botao2 = random.Next(1, 10);
        //            }

        //            while (botao1 == 0 || botao1 == resposta)
        //            {
        //                botao1 = random.Next(1, 10);
        //            }

        //            while (botao4 == 0 || botao4 == resposta)
        //            {
        //                botao4 = random.Next(1, 10);
        //            }

        //            btn_2.Text = botao2.ToString();
        //            btn_3.Text = botao1.ToString();
        //            btn_4.Text = botao4.ToString();
        //        }
        //        else if (escolha_certo == 4)
        //        {
        //            btn_4.Text = resposta.ToString();
        //            // WHILE PARA O RESULTADO NÃO CAIR EM DOIS BOTÕES AO MESMO TEMPO
        //            while (botao2 == 0 || botao2 == resposta)
        //            {
        //                botao2 = random.Next(1, 10);
        //            }

        //            while (botao3 == 0 || botao3 == resposta)
        //            {
        //                botao3 = random.Next(1, 10);
        //            }

        //            while (botao1 == 0 || botao1 == resposta)
        //            {
        //                botao1 = random.Next(1, 10);
        //            }

        //            btn_2.Text = botao2.ToString();
        //            btn_3.Text = botao3.ToString();
        //            btn_1.Text = botao4.ToString();
        //        }
        //        //

        //        //if (escolha_certo != 1)
        //        //{
        //        //    int errado = random.Next(1, 10);

        //        //    while (errado == resposta)
        //        //    {
        //        //        errado = random.Next(1, 10);
        //        //    }

        //        //    btn_1.Text = errado.ToString();
        //        //}
        //        //if (escolha_certo != 2)
        //        //{

        //        //    while (errado1 == resposta)
        //        //    {
        //        //        errado1 = random.Next(1, 10);
        //        //    }

        //        //    btn_2.Text = errado1.ToString();
        //        //}
        //        //if (escolha_certo != 3)
        //        //{
        //        //    while (errado3 == resposta || errado1 == errado2)
        //        //    {
        //        //        errado2 = random.Next(1, 10);
        //        //    }

        //        //    btn_3.Text = errado2.ToString();
        //        //}
        //        //if (escolha_certo != 4)
        //        //{
        //        //    while (errado4 == resposta || errado1 == errado2 || errado3 == errado2)
        //        //    {
        //        //        errado4 = random.Next(1, 10);
        //        //    }

        //        //    btn_4.Text = errado4.ToString();
        //    }

        //    private async void btn_4_Clicked(object sender, EventArgs e)
        //    {
        //        if (btn_4.Text == RESPOSTA.ToString())
        //        {
        //            await DisplayAlert("Parabéns", "Você acertou", "OK");
        //            gerador();
        //        }
        //        else
        //        {
        //            await DisplayAlert("Que Pena", "Você errou", "OK");
        //        }
        //    }

        //    private async void btn_3_Clicked(object sender, EventArgs e)
        //    {
        //        if (btn_3.Text == RESPOSTA.ToString())
        //        {
        //            await DisplayAlert("Parabéns", "Você acertou", "OK");
        //            gerador();
        //        }
        //        else
        //        {
        //            await DisplayAlert("Que Pena", "Você errou", "OK");
        //        }
        //    }

        //    private async void btn_2_Clicked(object sender, EventArgs e)
        //    {
        //        if (btn_2.Text == RESPOSTA.ToString())
        //        {
        //            await DisplayAlert("Parabéns", "Você acertou", "OK");
        //            gerador();
        //        }
        //        else
        //        {
        //            await DisplayAlert("Que Pena", "Você errou", "OK");
        //        }
        //    }

        //    private async void btn_1_Clicked(object sender, EventArgs e)
        //    {
        //        if (btn_1.Text == RESPOSTA.ToString())
        //        {
        //            await DisplayAlert("Parabéns", "Você acertou", "OK");
        //            gerador();
        //        }
        //        else
        //        {
        //            await DisplayAlert("Que Pena", "Você errou", "OK");
        //        }
        //    }

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
            else if(botao == 2)
            { vlr_botao2 = RESPOSTA; }
            else if(botao == 3)
            { vlr_botao3 = RESPOSTA; }
            else if(botao == 4)
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
            int valor = int.Parse(button.Text);

            if (valor == RESPOSTA)
            {
                await DisplayAlert("Parabéns", "Você acertou", "OK");
                gerar();
            }
            else
            {
                await DisplayAlert("Que Pena", "Você errou\nTente Novamente!", "OK");
            }

            //MessageBox.Show("Você clicou no botão com valor: " + valor);
        }
    }
}

