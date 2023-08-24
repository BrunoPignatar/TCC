using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new View.Menu());
            MainPage = new NavigationPage(new View.jogos.jogodasoma());
        }
        /**
         * Armazena os dados do Avatar após o login.
         */
        public static Model.Avatares DadosAvatar { get; set; }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
