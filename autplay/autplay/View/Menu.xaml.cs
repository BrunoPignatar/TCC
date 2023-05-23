using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autplay.Model;
using autplay.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        
        public Menu()
        {
            InitializeComponent();
            //ADIÇÃO DAS IMAGENS
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
            btn_add.Source = ImageSource.FromResource("autplay.Assets.botaoadd.png");
            btn_arara.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            btn_gato.Source = ImageSource.FromResource("autplay.Assets.cat.png");
            btn_dog.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            btn_peixe.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            btn_horse.Source = ImageSource.FromResource("autplay.Assets.horse.png");


            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);

           
           

    }

    //BOTÃO QUE LEVA A TELA DE SELEÇÃO-- OK
    private async void btn_jogar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new autplay.View.selecao());

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }

    //BOTÃO DE ADICIONAR FOTO COMO AVATAR--
    private void btn_add_Clicked(object sender, EventArgs e)
    {

    }

        

        private void btn_arara_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.selecao());
        }

        private void btn_gato_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.selecao());
        }

        private void btn_peixe_Clicked(object sender, EventArgs e)
        {

        }
    }
}