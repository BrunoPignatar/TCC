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
    public partial class JogoDasSombras : ContentPage
    {

        int acertos = 0;

        public JogoDasSombras()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            gerador();
        }

        private async void check(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            if (btn.Source == img_sombra.Source)
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

            int img_1 = random.Next(0, 6),
                img_2 = random.Next(0, 6),
                img_3 = random.Next(0, 6),
                img_4 = random.Next(0, 6);

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
    }
}