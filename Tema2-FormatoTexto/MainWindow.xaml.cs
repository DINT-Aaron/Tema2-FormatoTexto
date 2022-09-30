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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorAzulRadioButton.IsChecked = true;
        }

        private void textoEntradaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoFormateadoTextBox.Text = textoEntradaTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.FontWeight = FontWeights.Normal;
        }

        private void cursivaTextBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.FontStyle = FontStyles.Italic;
        }

        private void cursivaTextBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.FontStyle = FontStyles.Normal;
        }

        private void colorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.Foreground = Brushes.Blue;
        }
        private void colorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.Foreground = Brushes.Red;
        }

        private void colorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFormateadoTextBox.Foreground = Brushes.Green;
        }
    }
}
