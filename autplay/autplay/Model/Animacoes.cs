using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace autplay.Model
{
    public class Animacoes
    {
        public static async Task AnimacaoBotao(Button btn)
        {
            // Animação de escala
            await btn.ScaleTo(0.7, 100, Easing.Linear);
            await Task.Delay(50);
            await btn.ScaleTo(1, 100, Easing.Linear);
        }
    }
}
