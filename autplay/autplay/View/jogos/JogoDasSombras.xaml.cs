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

        int CERTO, BOTAO = 0;

        public JogoDasSombras()
        {
            InitializeComponent();
            gerador();
        }

        private async void img_3_Clicked(object sender, EventArgs e)
        {
            if (img_3.Source == img_sombra.Source)
            {
                await DisplayAlert("Parabens", "voce acertou", "ok");
            }
            else
            {
                await DisplayAlert("Parabens", "voce errou", "ok");
            }
            gerador();
        }

        private async void img_2_Clicked(object sender, EventArgs e)
        {
            if (img_2.Source == img_sombra.Source)
            {
                await DisplayAlert("Parabens", "voce acertou", "ok");
            }
            else
            {
                await DisplayAlert("Parabens", "voce errou", "ok");
            }
            gerador();
        }

        private async void img_1_Clicked(object sender, EventArgs e)
        {
            if (img_1.Source == img_sombra.Source)
            {
                await DisplayAlert("Parabens", "voce acertou", "ok");
            }
            else
            {
                await DisplayAlert("Parabens", "voce errou", "ok");
            }
            gerador();
        }

        public void gerador()
        {

            CERTO = new Random().Next(1, 6);

            var random = new Random();

            int img1 = random.Next(1, 6), img2 = random.Next(1, 6), img3 = random.Next(1, 6);

            

            if (CERTO == 1)
            {
                img_sombra.Source = ImageSource.FromResource("autplay.Assets.cat.png");
                BOTAO = 1;
            }
            else if (CERTO == 2)
            {
                img_sombra.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
                BOTAO = 2;
            }
            else if (CERTO == 3)
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