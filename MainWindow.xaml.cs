using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculadora_ISR
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculoISR Calculo = new CalculoISR();
        private static readonly Regex _regex = new Regex("[^0-9]+"); //Expresión regular que indica sólo números
        // Variable auxiliar para determinar cuando se debe borrar el texto que está en pantalla.
        bool limpiarPantalla = false;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void BtnISR_Click(object sender, RoutedEventArgs e)
        {       
            
            if (!String.IsNullOrEmpty(txtSueldoMensual.Text)) // Verifica si es es nulo o el campo está vacío
            {
                var isr = Double.Parse(txtSueldoMensual.Text);
                //Operador ternario para indicar que el sueldo debe ser más de 0.01
                Result.Content = isr >= 0.01 ? ("$" + Math.Round(Calculo.Calcular(isr), 2).ToString()) : "Ingresa un sueldo mayor a $0";                
            }   
        }

        //Sólo aceptar números y el caracter .
        private void TxtSueldoMensual_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (e.Text != "." && _regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
            else if (e.Text == ".")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }

        //Evitar que se utilice la tecla de espacio
        private void TxtSueldoMensual_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space && txtSueldoMensual.IsFocused == true)
            {
                e.Handled = true;
            }
        }
    }
}
