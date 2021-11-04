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
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para EliminarArticulo.xaml
    /// </summary>
    public partial class EliminarArticulo : Window
    {
        //CollectionView Vista;
        //  ObservableCollection<Articulo> listaArticulo = new ObservableCollection<Articulo>();

        public EliminarArticulo()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // TrabajarArticulos.eliminarArticuloObs(idEliminarArticulo);
            //  MessageBox.Show("Articulo Eliminado Correctamente"+idEliminarArticulo);


            // TrabajarArticulos.eliminarArticuloObs();
            // ObjectDataProvider odp = (ObjectDataProvider)this.Resources["Lista"];
            // listaArticulo = odp.Data as ObservableCollection<Articulo>;

            // Vista = (CollectionView)CollectionViewSource.GetDefaultView(Grid_content.DataContext);

            /*
            Articulo oArticulo1 = new Articulo();

            oArticulo1.Art_id = 1;
            oArticulo1.Art_descrip = "Articulo 1";
            oArticulo1.Fam_id = 1;
            oArticulo1.Art_precio = 200;
            oArticulo1.Art_maneja_stock = true;

            if (oArticulo1.Art_id == Convert.ToInt32(txtCodigo.Text))
            {
                MessageBox.Show("Articulo Eliminado Correctamente");
                MessageBox.Show("Codigo de articulo: " + oArticulo1.Art_id + ", Descripcion: " + oArticulo1.Art_descrip
                    + ", Familia: " + oArticulo1.Fam_id + ", Precio: " + oArticulo1.Art_precio);
                this.Close();
            }
            else
            {
                MessageBox.Show("El codigo no coincide con ningun articulo");
            }
             * */
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
