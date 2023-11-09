using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodavelha : ContentPage
    {

        string vez = "X";
        int jogadas = 0;
        int WinX = 0;
        int WinO = 0;
        int Empates = 0;
        public jogodavelha()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btn10_Clicked(object sender, EventArgs e)
        {
            // Identificando qual botão disparou o evento
            Button botao_clicado = (Button)sender;

            // Desabilitando o botão
            botao_clicado.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                botao_clicado.Text = "X";
                botao_clicado.TextColor = Color.White;
                vez = "O";
                jogadas++;
                Bot();
            }
            //else
            //{
            //    botao_clicado.Text = "O";
            //    vez = "X";
            //    jogadas++;
            //}

            //horizontal
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            //vertical

            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }


            //diagonal

            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }

            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();
                WinX++;
                Xwin.Text = WinX.ToString();

            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
                WinO++;
                Owin.Text = WinO.ToString();
            }





        }

        public void zerar()
        {
            btn10.IsEnabled = true;
            btn10.Text = "";
            btn11.IsEnabled = true;
            btn11.Text = "";
            btn12.IsEnabled = true;
            btn12.Text = "";

            btn20.IsEnabled = true;
            btn20.Text = "";
            btn21.IsEnabled = true;
            btn21.Text = "";
            btn22.IsEnabled = true;
            btn22.Text = "";

            btn30.IsEnabled = true;
            btn30.Text = "";
            btn31.IsEnabled = true;
            btn31.Text = "";
            btn32.IsEnabled = true;
            btn32.Text = "";
            vez = "X";
            jogadas = 0;
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
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        public void Bot()
        {
            var random = new Random();
            int campo;

            do
            {
                campo = random.Next(1, 10);

            } while (!AtualizarBotao(campo, "O"));

            VerificarVitoriasEEmpate();
        }

        private async void VerificarVitoriasEEmpate()
        {
            // Empate
            if (jogadas == 9)
            {
                await DisplayAlert("Não temos um vencedor!", "O jogo deu velha! \nEMPATE.", "OK");
                zerar();
                Empates++;
                empatestxt.Text = Empates.ToString();
            }
        }

        private bool AtualizarBotao(int campo, string marca)
        {
            switch (campo)
            {
                case 1:
                    return Atualizar(btn10, marca);

                case 2:
                    return Atualizar(btn11, marca);

                case 3:
                    return Atualizar(btn12, marca);

                case 4:
                    return Atualizar(btn20, marca);

                case 5:
                    return Atualizar(btn21, marca);

                case 6:
                    return Atualizar(btn22, marca);

                case 7:
                    return Atualizar(btn30, marca);

                case 8:
                    return Atualizar(btn31, marca);

                case 9:
                    return Atualizar(btn32, marca);

                default:
                    return false;
            }
        }

        private bool Atualizar(Button button, string marca)
        {
            if (button.Text != "X" && button.Text != "O")
            {
                button.Text = marca;
                button.IsEnabled = false;
                jogadas++;
                vez = "X";
                return true;
            }
            return false;
        }


    }
}