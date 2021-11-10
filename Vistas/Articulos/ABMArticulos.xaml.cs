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
using System.Collections.ObjectModel;

using ClasesBase;

namespace Vistas.Articulos
{
    /// <summary>
    /// Lógica de interacción para ABMArticulos.xaml
    /// </summary>
    public partial class ABMArticulos : Page
    {
        public static int id;
        CollectionView Vista;
        ObservableCollection<Articulo> listaArticulo = new ObservableCollection<Articulo>();
        int idEliminarArticulo;

        public ABMArticulos()
        {
            InitializeComponent();
        }  

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["Lista"];
            listaArticulo = odp.Data as ObservableCollection<Articulo>;

            Vista = (CollectionView)CollectionViewSource.GetDefaultView(Grid_content.DataContext);
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToPrevious();
            if (Vista.IsCurrentBeforeFirst)
            {
                Vista.MoveCurrentToLast();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
            if (Vista.IsCurrentAfterLast)
            {
                Vista.MoveCurrentToFirst();
            }
        }

        private void btnVerLista_Click(object sender, RoutedEventArgs e)
        {
            ListaArticulos oLA = new ListaArticulos();
            oLA.Show();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //agregado
            NuevoArticulo ventana = new NuevoArticulo();
            ventana.Show();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Articulo oArticulo = Vista.CurrentItem as Articulo;
            if (oArticulo != null)
            {
                ModificarArticulo md = new ModificarArticulo(oArticulo);
                md.Show();
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //agregado
            idEliminarArticulo = Convert.ToInt32(txbCodigo.Text);
            if (MessageBox.Show("Desea eliminar el articulo", "Eliminar Articulo", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
            {
                TrabajarArticulos.eliminarArticuloObs(idEliminarArticulo);
                MessageBox.Show("Se elimino el Articulo correctamente");
                TrabajarArticulos.TraerArticulosObs();
            }
        }
    }
}
