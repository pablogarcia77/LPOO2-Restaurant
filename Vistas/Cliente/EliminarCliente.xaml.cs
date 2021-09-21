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
    /// Lógica de interacción para EliminarCliente.xaml
    /// </summary>
    public partial class EliminarCliente : Window
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_id = 1;
            oCliente.Cli_apellido = "Fulanito";
            oCliente.Cli_nombre = "Cosme";
            oCliente.Cli_domicilio = "Avda. Siempre Viva 742";
            oCliente.Cli_telefono = "555256485";
            oCliente.Cli_email = "fulanito.springfield@gmail.com";

            if (Convert.ToInt32(txtCodigo.Text) == oCliente.Cli_id)
            {

                MessageBox.Show("Cliente Eliminado Exitosamente");
                MessageBox.Show("Codigo: " + oCliente.Cli_id + ", Apellido: " + oCliente.Cli_apellido + ", Nombre: " +
                    oCliente.Cli_nombre + ", Domicilio: " + oCliente.Cli_apellido + ", Telefono: " + oCliente.Cli_telefono
                    + ", Email: " + oCliente.Cli_email);
                this.Close();
            }
            else
            {
                MessageBox.Show("El codigo no coincide con ningun cliente");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
