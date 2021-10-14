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
using ClasesBase;

namespace Vistas.Articulos
{
    /// <summary>
    /// Interaction logic for MostrarArticulos.xaml
    /// </summary>
    public partial class MostrarArticulos : Window
    {
        public MostrarArticulos()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGrid1.DataContext = TrabajarArticulos.TraerArticulos();
        }
    }
}
