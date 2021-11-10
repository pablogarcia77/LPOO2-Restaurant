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
using Microsoft.Win32;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para NuevoArticulo.xaml
    /// </summary>
    public partial class NuevoArticulo : Window
    {
        public Articulo articulo;


        public NuevoArticulo()
        {
            InitializeComponent();
        }


        public NuevoArticulo(Articulo oArticulo)
        {
            InitializeComponent();
            this.articulo = oArticulo;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Lista de objetos                            
            cmbFamilia.ItemsSource = TrabajarFamilias.traerFamilia().DefaultView;
            cmbUnidadMedida.ItemsSource = TrabajarUnidadMedida.traerUnidadMedida().DefaultView;
            cmbCategoria.ItemsSource = TrabajarCategorias.traerCategoria().DefaultView;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Articulo oArticulo = new Articulo();
            articulo.Art_descrip = txtdescrip.Text;
            articulo.Fam_id = Convert.ToInt32(cmbFamilia.SelectedValue);
            articulo.Unidad_Medida.Um_id = Convert.ToInt32(cmbUnidadMedida.SelectedValue);
            articulo.Categoria.Cat_id = Convert.ToInt32(cmbCategoria.SelectedValue);
            articulo.Art_precio = Convert.ToDecimal(txtPrecio.Text);


            if (checkStock.IsChecked == true)
            {
                articulo.Art_maneja_stock = true;
            }
            else
            {
                articulo.Art_maneja_stock = false;
            }

            TrabajarArticulos.nuevoArticuloObs(articulo);
            MessageBox.Show("Articulo Agregado Correctamente");
            MessageBox.Show("Descripcion: " + articulo.Art_descrip +
                ", Familia: " + articulo.Fam_id + " Unidad de medida: " +
                articulo.Um_id + ", Categoria: " + articulo.Categoria.Cat_id + ", Precio: " + articulo.Art_precio + ", Url: " + articulo.Art_Img_Uri +
                ", Stock: " + articulo.Art_maneja_stock);
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDinamica.Source = new BitmapImage(fileUri);
                articulo.Art_Img_Uri = fileUri.AbsoluteUri;
            }
        }
    }

}
