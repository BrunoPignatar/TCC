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

        int resposta, BOTAO = 0, ultimoGerado=0, ultimoGeradoIMG=0;

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
                gerador();
            }
            else
            {
                await DisplayAlert("Que Pena ", "voce errou\nTente Novamente", "ok");
            }
            
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

        public void gerador()
        {
            do resposta = new Random().Next(1, 6);
            while (resposta == ultimoGerado);

            var random = new Random();


            int img1 = random.Next(1, 6),
                img2 = random.Next(1, 6),
                img3 = random.Next(1, 6);

            

            if (resposta == 1)
            {
                img_sombra.Source = ImageSource.FromResource("autplay.Assets.cat.png");
                BOTAO = 1;
            }
            else if (resposta == 2)
            {
                img_sombra.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
                BOTAO = 2;
            }
            else if (resposta == 3)
            {
                img_sombra.Source = ImageSource.FromResource("autplay.Assets.dog.png");
                BOTAO = 3;
            }
           
            while(img1 == img2 || img1 == img3)
            {
                img1 = random.Next(1, 4);
            }
            while (img2 == img1 || img2 == img3)
            {
                img2 = random.Next(1, 4);
            }
            while (img3 == img2 || img3 == img1)
            {
                img3 = random.Next(1, 4);
            }




            // img 1

            if (img1 == 1 && BOTAO != img1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.cat.png");

            }
            else if (img1 == 2 && BOTAO != img1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");

            }
            else if (img1 == 3 && BOTAO != img1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (img1 == 4 && BOTAO != img1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (img1 == 5 && BOTAO != img1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            }

            // img 2

            if (img2 == 1 && BOTAO != img2)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.cat.png");

            }
            else if ( img2 == 2 && BOTAO != img2)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            }
            else if (img2 == 3 && BOTAO != img2)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (img2 == 4 && BOTAO != img1)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (img2 == 5 && BOTAO != img1)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            }

            // img 3

            if (img3 == 1 && BOTAO != img3)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.cat.png");

            }
            else if ( img3 == 2 && BOTAO != img3)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            }
            else if ( img3 == 3 && BOTAO != img3)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (img3 == 4 && BOTAO != img1)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (img3 == 5 && BOTAO != img1)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            }


            // botao


            if (BOTAO == 1)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.cat.png");

            }
            else if (BOTAO == 2)
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            }
            else if (BOTAO == 3)
            {
                img_3.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            }
            else if (BOTAO == 4)
            {
                img_1.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            }
            else if (BOTAO == 5 )
            {
                img_2.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            }



        }
    }
}