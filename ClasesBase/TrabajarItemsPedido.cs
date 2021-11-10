using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarItemsPedido
    {
        public ObservableCollection<Items_Pedido> TraerItemsPedido()
        {
            ObservableCollection<Items_Pedido> listaIPedidos = new ObservableCollection<Items_Pedido>();
            return listaIPedidos;
        }

        public static List<Items_Pedido> TraerItemsPedidoPorIdPedido(int idPedido)
        {
            List<Items_Pedido> lista = new List<Items_Pedido>();

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM Items_Pedido 
                                WHERE Ped_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idPedido);

            // configurar un adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // crear una tabla o conjunto de datos dataset
            DataTable dt = new DataTable();

            // llenar la tabla
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Items_Pedido ip = new Items_Pedido();
                ip.Item_ped_id = Convert.ToInt32(dt.Rows[0]["Item_Ped_Id"]);
                ip.Art_id = Convert.ToInt32(dt.Rows[i]["Art_Id"]);
                ip.Precio = Convert.ToDecimal(dt.Rows[i]["Precio"]);
                ip.Cantidad = Convert.ToInt32(dt.Rows[i]["Cantidad"]);
                ip.Importe = Convert.ToDecimal(dt.Rows[i]["Importe"]);
                lista.Add(ip);
            }

            return lista;
        }

        public static void NuevoItemPedido(Items_Pedido ip)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Items_Pedido (Ped_Id,Art_Id,Precio,Cantidad,Importe)
                                VALUES (@ped_id,@art_id,@precio,@cantidad,@importe)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ped_id", ip.Ped_id);
            cmd.Parameters.AddWithValue("@art_id", ip.Art_id);
            cmd.Parameters.AddWithValue("@precio", ip.Precio);
            cmd.Parameters.AddWithValue("@cantidad", ip.Cantidad);
            cmd.Parameters.AddWithValue("@importe", ip.Importe);

            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            cmd.ExecuteNonQuery();

            // cerrar la conexion
            cnn.Close();
        }

        public static void ModificarItemsPedido(Items_Pedido oIP)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Items_Pedido SET Cantidad=@cantidad, Importe=@importe 
                                WHERE Item_Ped_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cantidad", oIP.Cantidad);
            cmd.Parameters.AddWithValue("@importe", oIP.Importe);
            cmd.Parameters.AddWithValue("@id", oIP.Item_ped_id);

            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            cmd.ExecuteNonQuery();

            // cerrar la conexion
            cnn.Close();
        }
    }
}
