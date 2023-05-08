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
        ObservableCollection<Avatares> list;
        public Menu()
        {
            InitializeComponent();
            //ADIÇÃO DAS IMAGENS
            logo.Source = ImageSource.FromResource("autplay.Assets.logo.png");
            btn_add.Source = ImageSource.FromResource("autplay.Assets.botaoadd.png");
            //REMOVENDO A NAVBAR
            NavigationPage.SetHasNavigationBar(this, false);

            //ADICIONANDO OS AVATARES
            list = new ObservableCollection<Avatares>
            {
                new Avatares{Nome="juan",Imagem="https://tinyurl.com/sm59xs32"},
                new Avatares{Nome="Cachorro",Imagem="https://tinyurl.com/4fujmffr"},
                new Avatares{Nome="Gato",Imagem="https://tinyurl.com/2zbbx3an"},
                new Avatares{Nome="Peixe",Imagem="https://tinyurl.com/445abh2e"},
                new Avatares{Nome="Arara",Imagem="https://tinyurl.com/3n4dz6nu"},
        };
            avatares.ItemsSource = list;


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

}
}