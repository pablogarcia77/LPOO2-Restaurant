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
    /// Lógica de interacción para ListarColeccion.xaml
    /// </summary>
    public partial class ListarColeccion : Window
    {
        private CollectionViewSource vistaColeccionFiltrada;
       

        public ListarColeccion()
        {
            InitializeComponent();
            vistaColeccionFiltrada = Resources["VISTA_ART"] as CollectionViewSource;
            
        }

        private void txtFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColeccionFiltrada != null)
            {
                vistaColeccionFiltrada.Filter += eventVistaArt_Filter;
            }
        }

        private void eventVistaArt_Filter(object sender, FilterEventArgs e)
        {

            Articulo articulo = e.Item as Articulo;

            if (articulo.Art_descrip.StartsWith(txtFiltro.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
           
        }
    }
}

