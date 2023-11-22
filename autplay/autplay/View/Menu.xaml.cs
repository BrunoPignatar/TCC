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
        string nome;
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
                
                if(txtNome.Text != null)
                {
                    nome = txtNome.Text;
                }
                else { nome = "Arara"; }
                Model.Avatares a = new Model.Avatares
                {
                    Nome = nome,
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
                if (txtNome.Text != null)
                {
                    nome = txtNome.Text;
                }
                else { nome = "Gato"; }
                Model.Avatares a = new Model.Avatares
                {
                    Nome = nome,
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
                if (txtNome.Text != null)
                {
                    nome = txtNome.Text;
                }
                else { nome = "Peixe"; }
                Model.Avatares a = new Model.Avatares
                {
                    Nome = nome,
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
                if (txtNome.Text != null)
                {
                    nome = txtNome.Text;
                }
                else { nome = "Cachorro"; }
                Model.Avatares a = new Model.Avatares
                {
                    Nome = nome,
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
                if (txtNome.Text != null)
                {
                    nome = txtNome.Text;
                }
                else { nome = "Cavalo"; }
                Model.Avatares a = new Model.Avatares
                {
                    Nome = nome,
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

        private async void btn_ajuda1_Clicked(object sender, EventArgs e)
        {
            var settings = new SpeechOptions()
            {
                Volume = .50f,
                Pitch = 1f
            };
            await TextToSpeech.SpeakAsync("Olá, Bem vindo ao neu play! Selecione seu avatar para se aventurar, se não gostar dos avatares padrões você pode escolher seu próprio nome e sua foto", settings);
        }
    }
}