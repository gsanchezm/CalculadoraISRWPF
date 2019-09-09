using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Calculadora_ISR
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculoISR Calculo = new CalculoISR();
        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //Expresión regular que indica sólo números
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void BtnISR_Click(object sender, RoutedEventArgs e)
        {           
            if (!_regex.IsMatch(txtSueldoMensual.Text) && !String.IsNullOrEmpty(txtSueldoMensual.Text)) // Verifica si es número
            {
                var isr = Math.Round(Calculo.Calcular(Double.Parse(txtSueldoMensual.Text)), 2).ToString();
                Result.Content = ("$" + isr); 
            }   
        }
    }
}
