using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnalizadorD
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> palabraLista = new List<String>();
        List<String> enteroLista = new List<string>();
        List<String> decimalLista = new List<string>();
        List<String> monedaLista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

  
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            listGDecimales.Items.Clear();
            listGEnteros.Items.Clear();
            listGMoneda.Items.Clear();
            listGPalabras.Items.Clear();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String cadena = textIngreso.Text;
        }

        private void separarCadena(String cadena)
        {

        }
    }
}
