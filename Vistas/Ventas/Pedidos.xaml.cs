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

using Vistas.Impresiones;
using ClasesBase;

namespace Vistas.Ventas
{
    /// <summary>
    /// Lógica de interacción para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {

        public static int idMesa;

        public static Pedido pedido;

        public string articulo;

        public Items_Pedido oIP;

        public static ObservableCollection<Items_Pedido> listaIP;

        public Pedidos()
        {
            InitializeComponent();
        }

        public void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Pedido oPedido = new Pedido();
            oPedido.Usu_id = Login.rol_id;
            oPedido.Mesa_id = idMesa;
            oPedido.Cli_id = Convert.ToInt32(cboCliente.SelectedValue);
            oPedido.Ped_comensales = Convert.ToInt32(txtComensales.Text);
            oPedido.Ped_facturado = false;
            int id = TrabajarPedidos.NuevoPedido(oPedido);

            oPedido.Ped_id = id;

            List<Items_Pedido> lista = listaIP.ToList();

            lista.ForEach(delegate(Items_Pedido i)
            {
                i.Ped_id = id;
                TrabajarItemsPedido.NuevoItemPedido(i);
            });
            MessageBox.Show("Pedido Creado");

            Mesa oMesa = new Mesa();
            oMesa.Mesa_id = idMesa;
            oMesa.Mesa_estado = "En espera de comida";

            TrabajarMesa.ModificarEstadoMesa(oMesa);

            pedido = oPedido;

            ImpresionPedidos oImpP = new ImpresionPedidos();
            oImpP.Show();
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

            listaIP = listBox2.ItemsSource as ObservableCollection<Items_Pedido>;
            oIP.Art_id = Convert.ToInt32(cboArticulo.SelectedValue);
            oIP.Cantidad = Convert.ToInt32(txtCantidad.Text);
            MessageBox.Show(txtPrecio.Text);
            oIP.Precio = Convert.ToDecimal(txtPrecio.Text);
            oIP.Importe = oIP.Cantidad * oIP.Precio;
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
           
        }

    }
}
