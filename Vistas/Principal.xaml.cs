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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Login.rol_id != 1)
            {
                mnuUsuario.IsEnabled = false;
                mnuArticulo.IsEnabled = false;
                mnuCategoria.IsEnabled = false;
                mnu_UM.IsEnabled = false;
                mnuFamilia.IsEnabled = false;
                mnuCliente.IsEnabled = false;
            }
            else {
                mnuMesas.IsEnabled = false;
            }
        }

        private void mnuMesas_Click(object sender, RoutedEventArgs e)
        {
            Mesas oMesas = new Mesas();
            oMesas.Show();
        }

        private void nuevoArticulo_Click(object sender, RoutedEventArgs e)
        {
            NuevoArticulo oNuevoArticulo = new NuevoArticulo();
            oNuevoArticulo.Show();
        }

        private void modificarArticulo_Click(object sender, RoutedEventArgs e)
        {
            ModificarArticulo oNuevoModificarArt = new ModificarArticulo();
            oNuevoModificarArt.Show();
        }

        private void eliminarArticulo_Click(object sender, RoutedEventArgs e)
        {
            EliminarArticulo oEliminarArt = new EliminarArticulo();
            oEliminarArt.Show();
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            NuevoCliente oNuevoCliente = new NuevoCliente();
            oNuevoCliente.Show();
        }

        private void ModificarCliente_Click(object sender, RoutedEventArgs e)
        {
            ModificarCliente oModificarCliente = new ModificarCliente();
            oModificarCliente.Show();
        }

        private void EliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            EliminarCliente oEliminarCliente = new EliminarCliente();
            oEliminarCliente.Show();
        }        

    }
}
