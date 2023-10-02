﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.selectword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mundo1 : ContentPage
    {
        public Mundo1()
        {
            InitializeComponent();

            //removendo a navbar
            NavigationPage.SetHasNavigationBar(this, false);

            //BARRA DO USUÁRIO(AVATAR)
            if (App.DadosAvatar.ImagemEnviada != null)
            {
                AvatarImage.Source = App.DadosAvatar.ImagemEnviada;
                lblBoasVindas.Text = "Bem-vindo Senhor(a) " + App.DadosAvatar.Nome;
            }
            else
            {
                AvatarImage.Source = App.DadosAvatar.ImagemPadrao;
                lblBoasVindas.Text = "Bem-vindo Senhor(a) " + App.DadosAvatar.Nome;
            }

            AlterAvatar.Source = ImageSource.FromResource("autplay.Assets.lapis.png");
        }

        private async void jogo1_Clicked(object sender, EventArgs e)
        {
            // Manipule o clique do botão aqui
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);
            
            await Navigation.PushAsync(new autplay.View.jogos.jogodavelha());
        }

        private async void jogo2_Clicked(object sender, EventArgs e)
        {
            // Manipule o clique do botão aqui
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);

            await Navigation.PushAsync(new autplay.View.jogos.jogodapalavra());
        }

        private async void jogo3_Clicked(object sender, EventArgs e)
        {
            // Manipule o clique do botão aqui
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;

            await Model.Animacoes.AnimacaoBotao(button);

            //Navigation.PushAsync(new autplay.View.jogos.jogodapalavra());
        }

        private void AlterAvatar_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new View.Menu());
                App.DadosAvatar = null;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
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
    }
}