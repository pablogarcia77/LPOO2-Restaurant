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
            hideSubmenu();
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

        private void hideSubmenu()
        {
            stackUsuarios.Height = 0;
            stackArticulos.Height = 0;
            stackClientes.Height = 0;
            stackFamilia.Height = 0;
            stackCategoria.Height = 0;
            stackUM.Height = 0;
            stackVentas.Height = 0;
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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Login oLogin = new Login();
            oLogin.Show();
            this.Close();
        }


        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            if (stackUsuarios.Height == 0)
            {
                stackUsuarios.Height = 180;
            }
            else
            {
                stackUsuarios.Height = 0;
            }
        }

        private void btnArticulos_Click(object sender, RoutedEventArgs e)
        {
            if (stackArticulos.Height == 0)
            {
                stackArticulos.Height = 180;
            }
            else
            {
                stackArticulos.Height = 0;
            }
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            if (stackClientes.Height == 0)
            {
                stackClientes.Height = 180;
            }
            else
            {
                stackClientes.Height = 0;
            }
        }

        private void btnFamilia_Click(object sender, RoutedEventArgs e)
        {
            if (stackFamilia.Height == 0)
            {
                stackFamilia.Height = 180;
            }
            else
            {
                stackFamilia.Height = 0;
            }
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            if (stackCategoria.Height == 0)
            {
                stackCategoria.Height = 180;
            }
            else
            {
                stackCategoria.Height = 0;
            }
        }

        private void btnUM_Click(object sender, RoutedEventArgs e)
        {
            if (stackUM.Height == 0)
            {
                stackUM.Height = 180;
            }
            else
            {
                stackUM.Height = 0;
            }
        }

        private void btnVentas_Click(object sender, RoutedEventArgs e)
        {
            if (stackVentas.Height == 0)
            {
                stackVentas.Height = 45;
            }
            else
            {
                stackVentas.Height = 0;
            }
        }
    }
}
