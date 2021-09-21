using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas.Familia
{
    /// <summary>
    /// Lógica de interacción para NuevaFamilia.xaml
    /// </summary>
    public partial class NuevaFamilia : Window
    {
        public NuevaFamilia()
        {
            InitializeComponent();
        }

        private void btnCancalear_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
