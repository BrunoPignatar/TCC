using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace autplay.View.jogos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class jogodasoma : ContentPage
    {
        public jogodasoma()
        {
            InitializeComponent();

            var random = new Random();

            int numero1 = random.Next(1, 5);
            int numero2 = random.Next(1, 5);

            txt_numero1.Text = numero1.ToString();
            txt_numero2.Text = numero2.ToString();


            int resposta = numero1 + numero2;

            int escolha_certo = random.Next(1, 4);

            if (escolha_certo == 1)
            {
                btn_1.Text = resposta.ToString();
            }
            else if (escolha_certo == 2)
            {
                btn_2.Text = resposta.ToString();
            }
            else if (escolha_certo == 3)
            {
                btn_3.Text = resposta.ToString();
            }
           

            if (escolha_certo != 1)
            {
                int errado = random.Next(1, 10);

                if (errado == escolha_certo)
                {
                    errado = random.Next(1, 10);
                }

                btn_1.Text = errado.ToString();
            }
            if (escolha_certo != 2)
            {
                int errado = random.Next(1, 10);

                if (errado == escolha_certo)
                {
                    errado = random.Next(1, 10);
                }

                btn_2.Text = errado.ToString();
            }
            if (escolha_certo != 3)
            {
                int errado = random.Next(1, 10);

                if (errado == escolha_certo)
                {
                    errado = random.Next(1, 10);
                }

                btn_3.Text = errado.ToString();
            }
        }
    }
}