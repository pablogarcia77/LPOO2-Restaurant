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
    public partial class Pedidos : Page
    {

        public static int idMesa;

        public static Pedido oPedido;

        public string articulo;

        public Items_Pedido oIP;

        public static ObservableCollection<Items_Pedido> listaIP;

        public Pedidos()
        {
            InitializeComponent();
        }

        public void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Pedidos.oPedido.Usu_id = Login.rol_id;
            Pedidos.oPedido.Mesa_id = idMesa;
            if (cboCliente.SelectedValue != null && !String.IsNullOrEmpty(txtComensales.Text))
            {
                Pedidos.oPedido.Cli_id = Convert.ToInt32(cboCliente.SelectedValue);
                Pedidos.oPedido.Ped_comensales = Convert.ToInt32(txtComensales.Text);
                Pedidos.oPedido.Ped_facturado = false;

                MessageBox.Show(Pedidos.oPedido.Usu_id.ToString());

                int id;
                
                if (Pedidos.oPedido.Ped_facturado == true)
                {
                    id = TrabajarPedidos.NuevoPedido(oPedido);
                }
                else
                {
                    id = Pedidos.oPedido.Ped_id;
                    MessageBox.Show("UsuariO: " + Pedidos.oPedido.Cli_id.ToString());
                    Pedidos.oPedido = TrabajarPedidos.TraerUltimoPedidoPorMesa(Pedidos.oPedido.Mesa_id);
                    //TrabajarPedidos.ModificarPedido(oPedido);
                }

                
                
                //oPedido.Ped_id = id;

                List<Items_Pedido> lista = listaIP.ToList();

                lista.ForEach(delegate(Items_Pedido i)
                {
                    //Modificar aqui porque se repite el itemPedido al actualizar pedido
                    i.Ped_id = id;
                    
                    if (i.Item_ped_id == 0)
                    {
                        TrabajarItemsPedido.NuevoItemPedido(i);
                    }
                    else {
                        TrabajarItemsPedido.ModificarItemsPedido(i);
                    }
                    
                    //MessageBox.Show(i.Item_ped_id.ToString());
                });
                MessageBox.Show("Pedido Creado");

                Mesa oMesa = new Mesa();
                oMesa.Mesa_id = idMesa;
                oMesa.Mesa_estado = "En espera de comida";

                TrabajarMesa.ModificarEstadoMesa(oMesa);

                //Pedidos.oPedido = oPedido;

                ImpresionPedidos oImpP = new ImpresionPedidos();
                oImpP.Show();
            }
            else
            {
                MessageBox.Show("Debe llenar los todos los campos");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            idMesa = Mesas.idMesa;
            Pedidos.oPedido = new Pedido();
            Pedidos.oPedido = TrabajarPedidos.TraerUltimoPedidoPorMesa(idMesa);
            cboArticulo.ItemsSource = TrabajarArticulos.TraerArticulos().DefaultView;
            cboCliente.ItemsSource = TrabajarCliente.TraerClientes().DefaultView;
            txtNroMesa.Text = idMesa.ToString();
            listaIP = new ObservableCollection<Items_Pedido>();

            MessageBox.Show(Pedidos.oPedido.Ped_id.ToString());

            if (Pedidos.oPedido.Ped_facturado == false && Pedidos.oPedido.Ped_id != 0)
            {
                cboCliente.Text = TrabajarCliente.TraerClientePorId(Pedidos.oPedido.Cli_id).Cli_apellido;
                cboCliente.IsEnabled = false;
                txtComensales.Text = Pedidos.oPedido.Ped_comensales.ToString();
                List<Items_Pedido> listArticulo = new List<Items_Pedido>();
                listArticulo = TrabajarItemsPedido.TraerItemsPedidoPorIdPedido(Pedidos.oPedido.Ped_id);
                listaIP = listBox2.ItemsSource as ObservableCollection<Items_Pedido>;

                listArticulo.ForEach(delegate(Items_Pedido i)
                {
                    listaIP.Add(i);
                });
            }
            else
            {
                cboCliente.IsEnabled = true;
                
                
            }
            
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            oIP = new Items_Pedido();

            listaIP = listBox2.ItemsSource as ObservableCollection<Items_Pedido>;

            if (cboArticulo.SelectedValue != null && !String.IsNullOrEmpty(txtCantidad.Text))
            {

                oIP.Art_id = Convert.ToInt32(cboArticulo.SelectedValue);
                oIP.Cantidad = Convert.ToInt32(txtCantidad.Text);
                oIP.Precio = Convert.ToDecimal(txtPrecio.Text);
                oIP.Importe = oIP.Cantidad * oIP.Precio;

                int index = listaIP.IndexOf(listaIP.Where(x => x.Art_id == oIP.Art_id).FirstOrDefault());
                if (index > -1)
                {
                    listaIP[index].Cantidad = listaIP[index].Cantidad + oIP.Cantidad;
                    listaIP[index].Importe = listaIP[index].Importe + oIP.Importe;
                }
                else
                {
                    listaIP.Add(oIP);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            
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
