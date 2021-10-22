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
        public ABMArticulos()
        {
            InitializeComponent();
        }

        CollectionView Vista;
        ObservableCollection<Articulo> listaArticulo;

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
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToNext();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
