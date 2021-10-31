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
using System.Collections.ObjectModel;
using System.Data;

using ClasesBase;

namespace Vistas.Ventas
{
    /// <summary>
    /// Lógica de interacción para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {

        public int idMesa;

        public Pedido pedido;

        public string articulo;

        public Items_Pedido oIP;

        public ObservableCollection<Items_Pedido> listaIP;

        public Pedidos()
        {
            InitializeComponent();
        }

        public void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Se da de alta los datos// idMesa: " + idMesa + " - Usuario: " + txt + " - Cliente: " + idCli + " - FechaEntrega: " + fechaEntrega.ToShortDateString() + " - Comensales: " + comensales);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            idMesa = Mesas.idMesa;
            cboCliente.ItemsSource = TrabajarCliente.TraerClientes().DefaultView;
            cboArticulo.ItemsSource = TrabajarArticulos.TraerArticulos().DefaultView;
            txtNroMesa.Text = idMesa.ToString();
            listaIP = new ObservableCollection<Items_Pedido>();
            
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            oIP = new Items_Pedido();

            ObservableCollection<Items_Pedido> listaIP = listBox2.ItemsSource as ObservableCollection<Items_Pedido>;
            oIP.Art_id = Convert.ToInt32(cboArticulo.SelectedValue);
            oIP.Cantidad = Convert.ToInt32(txtCantidad.Text);
            oIP.Precio = Convert.ToInt32(txtPrecio.Text);
            oIP.Importe = oIP.Cantidad * oIP.Precio;
            oIP.Ped_id = Convert.ToInt32(txtPedido.Text);
            listaIP.Add(oIP);
        }

        private void cboArticulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Articulo articulo = new Articulo();
            //articulo = cboArticulo.SelectedItem as Articulo;
            
            articulo = ((DataRowView)cboArticulo.SelectedItem)["Art_Descrip"].ToString();

            
            //txbArt.Text = TrabajarArticulos.TraerArticuloPorId(Convert.ToInt32(cboArticulo.SelectedValue));
            
            //oIP.Art_id = Convert.ToInt32(cboArticulo.SelectedValue);
            
        }

        private void cboCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txbClienteId.Text = cboCliente.SelectedValue.ToString();
        }

    }
}
