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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ModificarArticulo.xaml
    /// </summary>
    public partial class ModificarArticulo : Window
    {
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Articulo oArticulo = new Articulo();
            oArticulo.Art_id = Convert.ToInt32(txtCodigo.Text);
            oArticulo.Art_descrip = txtdescrip.Text;
            oArticulo.Fam_id = Convert.ToInt32(txtFamilia.Text);
            oArticulo.Art_precio = Convert.ToDecimal(txtPrecio.Text);
            oArticulo.Um_id = Convert.ToInt32(txtUM.Text);
            oArticulo.Art_maneja_stock = true;

            MessageBox.Show("Articulo Modificado Correctamente");
            MessageBox.Show("Codigo: " + oArticulo.Art_id + ", Descripcion: " + oArticulo.Art_descrip +
                ", Familia: " + oArticulo.Fam_id + ", Precio: " + oArticulo.Art_precio + " Unidad de medida: " +
                oArticulo.Um_id + ", Stock: " + oArticulo.Art_maneja_stock);
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
