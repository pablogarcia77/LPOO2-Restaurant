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
using Vistas.Ventas;


namespace Vistas.Impresiones
{
    /// <summary>
    /// Lógica de interacción para ImpresionPedidos.xaml
    /// </summary>
    public partial class ImpresionPedidos : Window
    {
        public ImpresionPedidos()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Pedido oPedido = TrabajarPedidos.TraerUltimoPedidoPorMesa(Pedidos.idMesa);
            //List<Items_Pedido> lista = Pedidos.listaIP.ToList();
            List<Items_Pedido> lista = TrabajarItemsPedido.TraerItemsPedidoPorIdPedido(oPedido.Ped_id);
            Decimal total = 0;
            lista.ForEach(delegate(Items_Pedido i)
            {
                TextBlock txbc = new TextBlock();
                txbc.Text = i.Cantidad.ToString();
                txbc.Name = "txbc" + i.Ped_id.ToString();
                stackCantidad.Children.Add(txbc);

                TextBlock txbd = new TextBlock();
                txbd.Text = TrabajarArticulos.TraerArticuloPorId(i.Art_id);
                txbd.Name = "txbd" + i.Ped_id.ToString();
                stackDescripcion.Children.Add(txbd);

                TextBlock txbp = new TextBlock();
                txbp.Text = i.Importe.ToString();
                txbp.Name = "txbp" + i.Ped_id.ToString();
                stackPrecio.Children.Add(txbp);

                total = total + i.Importe;
            });

            txbNroPedido.Text = oPedido.Ped_id.ToString();

            txbTotal.Text = total.ToString();

            txbMesa.Text = oPedido.Mesa_id.ToString();
            txbMozo.Text = TrabajarUsuarios.TraerUsuarioPorId(oPedido.Usu_id).Usu_apellido_nombre;
            txbNroPedido.Text = oPedido.Ped_id.ToString();
            txbFechaPedido.Text = oPedido.Ped_fecha_emision.ToString();
        }
    }
}
