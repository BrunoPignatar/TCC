using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autplay.Model;
using autplay.View;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace autplay.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {

        public Menu()
        {
            InitializeComponent();
            ConfigElementos();
        }

        //BOTÃO DE ADICIONAR FOTO COMO AVATAR 
        private async void btn_add_Clicked(object sender, EventArgs e)
        {
            try
            {
                Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

                await Model.Animacoes.AnimacaoBotao(button);

                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Selecione uma imagem"
                });

                if (result != null)
                {
                    Avatares a = new Avatares
                    {
                        ImagemEnviada = ImageSource.FromFile(result.FullPath),
                        Nome = txtNome.Text,
                        Id = 6,
                        ImagemPadrao = null,
                    };
                    App.DadosAvatar = a;
                }

                App.Current.MainPage = new NavigationPage(new View.selecao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", "Ocorreu um erro ao enviar a imagem!\nTente Novamente.", "OK");
            }
        }

        //BOTÕES PARA OS AVATARES
        private async void btn_arara_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Arara",
                    Id = 1,
                    ImagemPadrao = ImageSource.FromResource("autplay.Assets.parrot.png"),
                    ImagemEnviada = null
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_gato_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Gato",
                    Id = 2,
                    ImagemPadrao = ImageSource.FromResource("autplay.Assets.cat.png"),
                    ImagemEnviada = null
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_peixe_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Peixe",
                    Id = 3,
                    ImagemPadrao = ImageSource.FromResource("autplay.Assets.clown-fish.png"),
                    ImagemEnviada = null
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_dog_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Cachorro",
                    Id = 4,
                    ImagemPadrao = ImageSource.FromResource("autplay.Assets.dog.png"),
                    ImagemEnviada = null
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_horse_Clicked(object sender, EventArgs e)
        {
            try
            {
                Model.Avatares a = new Model.Avatares
                {
                    Nome = "Cavalo",
                    Id = 5,
                    ImagemPadrao = ImageSource.FromResource("autplay.Assets.horse.png"),
                    ImagemEnviada = null
                };
                App.DadosAvatar = a;
                App.Current.MainPage = new NavigationPage(new View.selecao());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void ConfigElementos()
        {
            // ADICIONANDO IMAGENS
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
            btn_arara.Source = ImageSource.FromResource("autplay.Assets.parrot.png");
            btn_gato.Source = ImageSource.FromResource("autplay.Assets.cat.png");
            btn_dog.Source = ImageSource.FromResource("autplay.Assets.dog.png");
            btn_peixe.Source = ImageSource.FromResource("autplay.Assets.clown-fish.png");
            btn_horse.Source = ImageSource.FromResource("autplay.Assets.horse.png");
            //DEIXANDO AS FONTES EM NEGRITO E ITÁLICO
            txtArara.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            txtCavalo.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            txtGato.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            txtPeixe.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            txtDog.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);
        }

    }
}