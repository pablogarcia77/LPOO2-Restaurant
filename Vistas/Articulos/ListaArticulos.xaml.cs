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
using Vistas.Impresiones;

namespace Vistas.Articulos
{
    /// <summary>
    /// Lógica de interacción para ListaArticulos.xaml
    /// </summary>
    public partial class ListaArticulos : Window
    {
        private CollectionViewSource vistaColeccionFiltrada;

        public ListaArticulos()
        {
            InitializeComponent();
            TextBox txtDescripcion = new TextBox();
            vistaColeccionFiltrada = Resources["Vista_Articulos"] as CollectionViewSource;
        }

        private void txtDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColeccionFiltrada != null)
            {
                // Se invoca al método eventVistaUsuario_Filter a medida que escriba en el TextBox
                vistaColeccionFiltrada.Filter += eventVistaArticulo_Filter;
            }
        }

        private void eventVistaArticulo_Filter(object sender, FilterEventArgs e)
        {
            Articulo articulo = e.Item as Articulo;

            if (articulo.Art_descrip.StartsWith(txtDescripcion.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                e.Accepted = true;
            }
            else { e.Accepted = false; }
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            VistaPreviaArticulos oVPA = new VistaPreviaArticulos();
            oVPA.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }



    }
}
