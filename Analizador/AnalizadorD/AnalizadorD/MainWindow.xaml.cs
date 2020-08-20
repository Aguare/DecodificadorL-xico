using System;
using System.CodeDom;
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
            decimalLista.Clear();
            listGEnteros.Items.Clear();
            enteroLista.Clear();
            listGMoneda.Items.Clear();
            monedaLista.Clear();
            listGPalabras.Items.Clear();
            palabraLista.Clear();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String cadena = textIngreso.Text;
            if (cadena.Equals(""))
            {
                MessageBox.Show("Debe ingresar almenos una palabra");
            }
            else
            {
                separarCadena(cadena);
            }
        }

        private void separarCadena(String cadena)
        {
            char separacion = ' ';
            String[] partes = cadena.Split(separacion);
            for (int i = 0; i < partes.Length; i++)
            {
                verificarTipo(partes[i]);
            }
            llenarListas();
        }

        private void llenarListas()
        {
            foreach (String cosa in palabraLista)
            {
                listGPalabras.Items.Add(cosa);
            }
            foreach (String cosa in enteroLista)
            {
                listGEnteros.Items.Add(cosa);
            }
            foreach (String cosa in monedaLista)
            {
                listGMoneda.Items.Add(cosa);
            }
            foreach (String cosa in decimalLista)
            {
                listGDecimales.Items.Add(cosa);
            }
        }

        private void verificarTipo(String subCadena)
        {
            char[] caracteres = subCadena.ToCharArray();
            if (!subCadena.Equals("y") || !subCadena.Equals("Y") || !subCadena.Equals("o") || !subCadena.Equals("O"))
            {
                if (verificarMoneda(caracteres))
                {
                    monedaLista.Add(subCadena);
                } else if (verificarPalabra(caracteres))
                {
                    palabraLista.Add(subCadena);
                }
                else if (verificarEntero(caracteres))
                {
                    enteroLista.Add(subCadena);
                }
                else if (verificarDecimales(caracteres))
                {
                    decimalLista.Add(subCadena);
                }
            }
        }

        private Boolean verificarPalabra(char[] caracteres)
        {
            
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i]))
                {
                    if (i == caracteres.Length - 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private Boolean verificarEntero(char[] caracteres)
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (numeroEntero(caracteres[i]))
                {
                    if (i == caracteres.Length - 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private Boolean numeroEntero(char num)
        {
            if (char.IsNumber(num))
            {
                return true;
            }
            return false;
        }

        private Boolean verificarMoneda(char[] caracteres)
        {
            if (caracteres[0] == 'Q')
            {
                for (int i = 1; i < caracteres.Length; i++)
                {
                    if (caracteres[i] == '.')
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (numeroEntero(caracteres[i + 1]) && numeroEntero(caracteres[i + 2]))
                            {
                                return true;
                            }
                        }
                    }
                    if (!numeroEntero(caracteres[i]))
                    {
                        return false;
                    }
                    else if (i == caracteres.Length - 1 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Boolean verificarDecimales(char[] caracteres)
        {
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == '.')
                {
                    for (int j = i+1; j < caracteres.Length; j++)
                    {
                        if (char.IsNumber(caracteres[j]))
                        {
                            if (j == caracteres.Length-1)
                            {
                                return true;
                            }
                        }
                    }
                }
                if (!char.IsNumber(caracteres[i]))
                {
                    return false;
                }
            }
            return false;
        }
    }
}
