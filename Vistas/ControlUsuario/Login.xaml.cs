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
using System.Windows.Navigation;
using System.Windows.Shapes;

using ClasesBase;

namespace Vistas.ControlUsuario
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    /// 
     public partial class Login : UserControl
    {


         public String Usuario
         {
             get { return txtUsuario.Text; }
         }

         public String Password
         {
             get { return passUsuario.Password; }
         }

        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
