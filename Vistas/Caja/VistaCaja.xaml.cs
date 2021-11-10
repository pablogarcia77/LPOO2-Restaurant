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
using System.Data;

using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Caja.xaml
    /// </summary>
    public partial class VistaCaja : Page
    {

        public VistaCaja()
        {
            InitializeComponent();
            
        }

 


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txbFecha.Text = DateTime.Today.ToString("d");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt = TrabajarCaja.TraerCajaFecha(DateTime.Today);

            dgCaja.DataContext = dt;

            Total.Text = getTotal(dt);
        }

        private string getTotal(DataTable dt)
        {
            decimal total = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dt.Rows[i]["Importe"]);
            }

            return total.ToString();
        }

        private void calFecha_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(calFecha.SelectedDate);
            txbFecha.Text = fecha.ToString("d");

            DataTable dt = TrabajarCaja.TraerCajaFecha(fecha);
            dgCaja.DataContext = dt;

            Total.Text = getTotal(dt);
        }
    }
}
