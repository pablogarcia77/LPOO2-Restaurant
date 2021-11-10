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
using Vistas.Articulos;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ModificarArticulo.xaml
    /// </summary>
    public partial class ModificarArticulo : Window
    {
        public Articulo articulo;

        public ModificarArticulo()
        {

            InitializeComponent();


        }

        public ModificarArticulo(Articulo oArticulo)
        {
            InitializeComponent();
            this.articulo = oArticulo;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /**
            articulo.Art_descrip = txtdescrip.Text;
            articulo.Fam_id = Convert.ToInt32(cmbFamilia.SelectedValue);
            articulo.Um_id = Convert.ToInt32(cmbUnidadMedida.SelectedValue);
            articulo.Categoria.Cat_id = Convert.ToInt32(cmbCategoria.SelectedValue);
            articulo.Art_precio = Convert.ToDecimal(txtPrecio.Text);
            if (checkBox1.IsChecked == true)
            {
                articulo.Art_maneja_stock = true;
            }
            else
            {
                articulo.Art_maneja_stock = false;
            }

            if (MessageBox.Show("Desea modificar el articulo", "Modificar Articulo", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                TrabajarArticulos.modificarArticuloObs(articulo);
                MessageBox.Show("Se modifico el Articulo correctamente");
                MessageBox.Show("Descripcion: " + articulo.Art_descrip +
                    ", Familia: " + articulo.Fam_id + " Unidad de medida: " +
                    articulo.Um_id + ", Categoria: " + articulo.Categoria.Cat_id + ", Precio: " + articulo.Art_precio +
                    ", Stock: " + articulo.Art_maneja_stock);
                this.Close();
            }



            this.Close();
             * */

            MessageBox.Show(cmbUnidadMedida.SelectedValue.ToString());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbUnidadMedida.ItemsSource = TrabajarUnidadMedida.traerUnidadMedida().DefaultView;
            cmbFamilia.ItemsSource = TrabajarFamilias.traerFamilia().DefaultView;
            cmbCategoria.ItemsSource = TrabajarCategorias.traerCategoria().DefaultView;

            

            if (articulo != null)
            {
                txtdescrip.Text = articulo.Art_descrip;
                cmbFamilia.Text = articulo.Familia.Fam_descrip;
                cmbUnidadMedida.Text = articulo.Unidad_Medida.Um_descrip;
                cmbCategoria.Text = articulo.Categoria.Cat_descrip;
                txtPrecio.Text = Convert.ToString(articulo.Art_precio);
            }

            MessageBox.Show(articulo.Fam_id.ToString());

            MessageBox.Show(articulo.Cat_id.ToString());

            MessageBox.Show(articulo.Unidad_Medida.Um_id.ToString());
        }



    }
}
