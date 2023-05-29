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
        public jogodavelha()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btn10_Clicked(object sender, EventArgs e)
        {
            Button botao_clicado = (Button)sender;

            botao_clicado.IsEnabled = false;

            if (vez == "X")
            {
                botao_clicado.Text = "X"; 
                vez = "O";
                jogadas++;
            }
            else
            {
                botao_clicado.Text = "O";
                vez = "X";
                jogadas++;
            }

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            //(

            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }


            //diagonal

            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!!!", "OK");
                zerar();

            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!!!", "OK");
                zerar();
            }

            if (jogadas == 9)
            {
                await DisplayAlert("Não temos um vencedor!", "O jogo deu velha! EMPATE.", "OK");
                zerar();
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
        }
    }
}