using System;
using System.Collections.Generic;
using System.Data;
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

namespace Analizador
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<String> listaPalabras = new List<String>();
        List<String> listaEnteros = new List<String>();
        List<String> listaDecimales = new List<String>();
        List<String> listaDinero = new List<String>();

        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("Pruebaaaaa");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SepararPalabras(entradaTexto.Text);
            
        }

        private void SepararPalabras(String oracion)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listGPalabras.Items.Clear();
            listGDecimales.Items.Clear();
            listGEnteros.Items.Clear();
            listGMoneda.Items.Clear();
        }
    }
}
