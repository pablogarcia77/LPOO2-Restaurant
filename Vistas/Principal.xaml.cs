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
                btnUsuarios.IsEnabled = false;
                btnArticulos.IsEnabled = false;
                btnCategoria.IsEnabled = false;
                btnUM.IsEnabled = false;
                btnFamilia.IsEnabled = false;
                btnCliente.IsEnabled = false;
                btnMostrarArticulos.IsEnabled = false;
            }
            else {
                btnMesas.IsEnabled = false;
            }
            
        }

        private void hideSubmenu()
        {
            if (stackUsuarios.Height != 0) { stackUsuarios.Height = 0; }
            if (stackArticulos.Height != 0) { stackArticulos.Height = 0; }
            if (stackClientes.Height != 0) { stackClientes.Height = 0; }
            if (stackFamilia.Height != 0) { stackFamilia.Height = 0; }
            if (stackCategoria.Height != 0) { stackCategoria.Height = 0; }
            if (stackUM.Height != 0) { stackUM.Height = 0; }
            if (stackVentas.Height != 0) { stackVentas.Height = 0; }
        }

        private void showSubMenu(StackPanel panel)
        {
            double height = stackMenu.Height;
            if (panel.Height == 0)
            {
                hideSubmenu();
                panel.Height = height;
            }
            else
            {
                panel.Height = 0;
            }
        }

        private void btnNuevoArticulo_Click(object sender, RoutedEventArgs e)
        {
            NuevoArticulo oNuevoArticulo = new NuevoArticulo();
            oNuevoArticulo.Show();
        }

        private void btnModificarArticulo_Click(object sender, RoutedEventArgs e)
        {
            ModificarArticulo oNuevoModificarArt = new ModificarArticulo();
            oNuevoModificarArt.Show();
        }

        private void btnEliminarArticulo_Click(object sender, RoutedEventArgs e)
        {
            EliminarArticulo oEliminarArt = new EliminarArticulo();
            oEliminarArt.Show();
        }

        private void btnNuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            NuevoCliente oNuevoCliente = new NuevoCliente();
            oNuevoCliente.Show();
        }

        private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
        {
            ModificarCliente oModificarCliente = new ModificarCliente();
            oModificarCliente.Show();
        }

        private void btmEliminarCliente_Click(object sender, RoutedEventArgs e)
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
            showSubMenu(stackUsuarios);
        }

        private void btnArticulos_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackArticulos);
        }

        private void btnListarArticulo_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnMostrarArticulos_Click(object sender, RoutedEventArgs e)
        {
            MostrarArticulos oMostrarArticulos = new MostrarArticulos();
            oMostrarArticulos.Show();

        }

        private void btnModificarUsuario_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListarUsuarios_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackClientes);
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnFamilia_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackFamilia);
        }

        private void btnNuevaFamilia_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnEliminarFamilia_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnModificarFamilia_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListarFamilia_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackCategoria);
        }

        private void btnNuevaCategoria_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnEliminarCategoria_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnModificarCategoria_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListarCategoria_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnUM_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackUM);
        }
        private void btnNuevaUM_Click(object sender, RoutedEventArgs e)
        {
        }
        private void btnEliminarUM_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnModificarUM_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListarUM_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnVentas_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(stackVentas);
        }
        private void btnNuevaVenta_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnMesas_Click(object sender, RoutedEventArgs e)
        {
            Mesas oMesas = new Mesas();
            oMesas.Show();
        }

        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnABMArticulo_Click(object sender, RoutedEventArgs e)
        {
            ABMArticulos oABMArticulos = new ABMArticulos();
            oABMArticulos.Show();
        }
    }
}
