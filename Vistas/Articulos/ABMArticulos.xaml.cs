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
    public partial class ABMArticulos : Window
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToPrevious();
            if (Vista.IsCurrentBeforeFirst)
            {
                Vista.MoveCurrentToLast();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
            if (Vista.IsCurrentAfterLast)
            {
                Vista.MoveCurrentToFirst();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ListaArticulos oLA = new ListaArticulos();
            oLA.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //agregado
            NuevoArticulo ventana = new NuevoArticulo();
            ventana.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //agregado
            id = Convert.ToInt32(textBox1.Text);
            ModificarArticulo ventana = new ModificarArticulo();
            ventana.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //agregado
            idEliminarArticulo = Convert.ToInt32(textBox1.Text);
            if (MessageBox.Show("Desea eliminar el articulo", "Eliminar Articulo", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
            {
                TrabajarArticulos.eliminarArticuloObs(idEliminarArticulo);
                MessageBox.Show("Se elimino el Articulo correctamente");
                TrabajarArticulos.TraerArticulosObs();
                this.Hide();
            }
        }
    }
}
