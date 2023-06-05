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
            AdcImagens();

            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);

        }

        //BOTÃO QUE LEVA A TELA DE SELEÇÃO-- OK
        //private async void btn_jogar_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        await Navigation.PushAsync(new autplay.View.selecao());

        //    }
        //    catch (Exception ex)
        //    {
        //        DisplayAlert("Error", ex.Message, "OK");
        //    }
        //}

        //BOTÃO DE ADICIONAR FOTO COMO AVATAR--
        private void btn_add_Clicked(object sender, EventArgs e)
        {
            
        }

        //BOTÕES PARA OS AVATARES
        private void btn_arara_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Arara",
                    Id = 1,
                    Imagem = "autplay.Assets.parrot.png"
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }



        private void btn_gato_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Gato",
                    Id = 2,
                    Imagem = "autplay.Assets.cat.png"
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
            
        }

        private void btn_peixe_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Peixe",
                    Id = 3,
                    Imagem = "autplay.Assets.clown-fish.png"
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
            
        }

        private void btn_dog_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Cachorro",
                    Id = 4,
                    Imagem = "autplay.Assets.dog.png"
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
            
        }

        private void btn_horse_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Cavalo",
                    Id = 5,
                    Imagem = "autplay.Assets.horse.png"
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
            
        }

        private void AdcImagens()
        {
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
            btn_add.Source = ImageSource.FromResource("autplay.Assets.botaoadd.png");
            btn_arara.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            btn_gato.Source = ImageSource.FromResource("autplay.Assets.cat.png");
            btn_dog.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            btn_peixe.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            btn_horse.Source = ImageSource.FromResource("autplay.Assets.horse.png");
        }

    }
}