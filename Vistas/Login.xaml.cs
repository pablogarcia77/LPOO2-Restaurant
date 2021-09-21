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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static Usuario oUsuario = new Usuario();
        public static Usuario oUsuario2 = new Usuario();
        public static Usuario oUsuario3 = new Usuario();

        public static int rol_id;

        public Login()
        {
            InitializeComponent();
        }


        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            oUsuario.Usu_id = 1;
            oUsuario.Usu_nombre_usuario = "mozo";
            oUsuario.Usr_contraseña = "123";
            oUsuario.Rol_id = 2;
            oUsuario.Usu_apellido_nombre = "Cosme Fulanito";

            oUsuario2.Usu_id = 2;
            oUsuario2.Usu_nombre_usuario = "admin";
            oUsuario2.Usr_contraseña = "123";
            oUsuario2.Rol_id = 1;
            oUsuario2.Usu_apellido_nombre = "Max Power";

            oUsuario3.Usu_id = 3;
            oUsuario3.Usu_nombre_usuario = "vendedor";
            oUsuario3.Usr_contraseña = "123";
            oUsuario3.Rol_id = 3;
            oUsuario3.Usu_apellido_nombre = "Bart Simpson";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Principal oPrincipal = new Principal();
            if (login.Usuario == oUsuario.Usu_nombre_usuario && login.Password == oUsuario.Usr_contraseña ||
                login.Usuario == oUsuario2.Usu_nombre_usuario && login.Password == oUsuario2.Usr_contraseña ||
                login.Usuario == oUsuario3.Usu_nombre_usuario && login.Password == oUsuario3.Usr_contraseña)
            {
                if (login.Usuario == "admin")
                {
                    MessageBox.Show("Bienvenido administrador", "Ingresando al Sistema");

                    rol_id = 1;
                    oPrincipal.Show();
                }
                else
                {
                    if (login.Usuario == "mozo")
                    {
                        MessageBox.Show("Bienvenido mozo", "Ingresando al Sistema");
                        rol_id = 2;
                        oPrincipal.Show();
                    }
                    else
                    {
                        if (login.Usuario == "vendedor")
                        {
                            MessageBox.Show("Bienvenido vendedor", "Ingresando al Sistema");
                            rol_id = 3;
                            oPrincipal.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "¡Atención!");
            }
            
        }

        


        
    }
}
