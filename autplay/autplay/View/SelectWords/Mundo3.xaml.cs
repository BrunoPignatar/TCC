using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.selectword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mundo3 : ContentPage
    {
        public Mundo3()
        {
            InitializeComponent();

            //removendo a navbar
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void jogo1_mundo3_Clicked(object sender, EventArgs e)
        {

        }

        private void jogo2_mundo3_Clicked(object sender, EventArgs e)
        {

        }

        private void jogo3_mundo3_Clicked(object sender, EventArgs e)
        {

        }
    }
}