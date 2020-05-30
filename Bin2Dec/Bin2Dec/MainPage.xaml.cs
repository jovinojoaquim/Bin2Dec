using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bin2Dec
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double total = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void VerificarTexto(object sender, TextChangedEventArgs e)
        {
            char ultimoDigitado = etBinario.Text.LastOrDefault();
            if (ultimoDigitado != '0' && ultimoDigitado != '1')
            {
                DisplayAlert("Atenção", "Só pode ser digitado 0 ou 1", "OK");
                etBinario.Text = etBinario.Text.Replace(ultimoDigitado, ' ').Trim();
            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            total = 0;
            for (int i = 0; i < etBinario.Text.Length; i++)
            {
                etBinario.Text.Substring(i, 1);
                total += double.Parse(etBinario.Text.Substring(i, 1)) * Math.Pow(2, etBinario.Text.Length - i - 1);
            }
            lbResultado.Text = "O resultado é: " + total.ToString();
        }
    }
}
