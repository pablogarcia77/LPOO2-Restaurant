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

namespace Vistas.Impresiones
{
    /// <summary>
    /// Lógica de interacción para VistaPreviaArticulos.xaml
    /// </summary>
    public partial class VistaPreviaArticulos : Window
    {
        private CollectionViewSource vistaColeccionFiltrada;

        public VistaPreviaArticulos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pdlg = new PrintDialog();

            if (pdlg.ShowDialog() == true)
            {
                pdlg.PrintDocument(((IDocumentPaginatorSource)DocMain).DocumentPaginator, "Imprimir");
            }
        }

        public VistaPreviaArticulos(CollectionViewSource lista)
        {
            vistaColeccionFiltrada = new CollectionViewSource();
            vistaColeccionFiltrada = lista;

            Binding binding = new Binding();
            binding.Source = vistaColeccionFiltrada;
            BindingOperations.SetBinding(lista, ListView.ItemsSourceProperty, binding);
        }

        public CollectionViewSource Render()
        {
            return vistaColeccionFiltrada;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //vistaColeccionFiltrada = new CollectionViewSource();
        }


    }
}
