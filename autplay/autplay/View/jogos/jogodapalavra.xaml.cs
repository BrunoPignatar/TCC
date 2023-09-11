using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodapalavra : ContentPage
    {
        public jogodapalavra()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            gerador();
        }
        string resposta_correta;

        public void gerador()
        {
            var ramdom = new Random();

            int animal = ramdom.Next(1, 5);

            if (animal == 1)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.cat.png");
                resposta_correta = "gato";
            }
            else if (animal == 2)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
                resposta_correta = "peixe";
            }
            else if (animal == 3)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.dog.png");
                resposta_correta = "cachorro";
            }
            else if (animal == 4)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.horse.png");
                resposta_correta = "cavalo";
            }
            else if (animal == 5)
            {
                img_imagem.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
                resposta_correta = "papagaio";
            }

        }

        private async void btn_enviar_Clicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);
            Task.Delay(500);



            if (txt_resposta.Text == resposta_correta)
            {
                await DisplayAlert("parabens", "vc acertou", "ok");
            }
            else
            {
                await DisplayAlert("qu̡̠̣̤̎͌ͥ̂͊̉ͅe̦̲͍͆̈́ ͙̹̺͙̖̿̐ͣ̅͐̚p̦͙̬̰͍͚ͩ̿̋ͅe͋͐n̝̬̞̂ͨͅâ͆̽\r\n", "v͒͆̊͊́̂͘o̳͖͚̜c̖̙̮̳͖̠̣ê̝̍ͤ̌̏͟ ̧̔͗̇̈́̀ͯȅ̤͍̰̟̬̌̊ͅr̲͈͜r̙ͣ̆ͭ͘o̪͎̣ṳ̠̠̣̗̅̅̓ͯ͟\r\n", "o̖͚̟͍̘̰̻ͨͥ̈͗k͔͒̈͊̒͝");
            }

            txt_resposta.Text = "";
            resposta_correta = "";
            gerador();
        }
    }
}