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
    public partial class Mundo2 : ContentPage
    {
        public Mundo2()
        {
            InitializeComponent();

            //removendo a navbar
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void jogo1_mundo2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new autplay.View.jogos.jogodasoma());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void jogo2_mundo2_Clicked(object sender, EventArgs e)
        {

        }

        private void jogo3_mundo2_Clicked(object sender, EventArgs e)
        {

        }
    }
}