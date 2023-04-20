using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");

            btn_add.Source = ImageSource.FromResource("autplay.Assets.botaoadd.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
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

        private void btn_add_Clicked(object sender, EventArgs e)
        {

        }
    }
}