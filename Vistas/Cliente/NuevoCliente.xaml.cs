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
    /// Lógica de interacción para NuevoCliente.xaml
    /// </summary>
    public partial class NuevoCliente : Window
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_id = Convert.ToInt32(txtCodigo.Text);
            oCliente.Cli_apellido = txtApellido.Text;
            oCliente.Cli_nombre = txtNombre.Text;
            oCliente.Cli_domicilio = txtDireccion.Text;
            oCliente.Cli_telefono = txtTelefono.Text;
            oCliente.Cli_email = txtEmail.Text;

            MessageBox.Show("Cliente Agregado Exitosamente");
            MessageBox.Show("Codigo: " + oCliente.Cli_id + ", Apellido: " + oCliente.Cli_apellido + ", Nombre: " +
                oCliente.Cli_nombre + ", Domicilio: " + oCliente.Cli_apellido + ", Telefono: " + oCliente.Cli_telefono
                + ", Email: " + oCliente.Cli_email);
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
