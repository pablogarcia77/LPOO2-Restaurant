using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPedidos
    {
        public static int NuevoPedido(Pedido oPedido)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            // SELECT SCOPE_IDENTITY() used for get last insert id
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Pedido (Usu_Id,Mesa_Id,Cli_Id,Ped_Fecha_Emision,Ped_Fecha_Entrega,Ped_Comensales,Ped_Facturado)
                                VALUES (@usu_id,@mesa_id,@cli_id,@ped_fecha_emision,@ped_fecha_entrega,@ped_comensales,@ped_facturado) SELECT SCOPE_IDENTITY()";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usu_id", oPedido.Usu_id);
            cmd.Parameters.AddWithValue("@mesa_id", oPedido.Mesa_id);
            cmd.Parameters.AddWithValue("@cli_id", oPedido.Cli_id);
            cmd.Parameters.AddWithValue("@ped_fecha_emision", DateTime.Now);
            cmd.Parameters.AddWithValue("@ped_fecha_entrega", DateTime.Now);
            cmd.Parameters.AddWithValue("@ped_comensales", oPedido.Ped_comensales);
            cmd.Parameters.AddWithValue("@ped_facturado", oPedido.Ped_facturado);


            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            //cmd.ExecuteNonQuery();

            // insert & get last Id
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            // cerrar la conexion
            cnn.Close();

            return id;

        }

        public static void ModificarPedido(Pedido oPedido)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Pedido (Ped_Id,Usu_Id,Mesa_Id,Cli_Id,Ped_Fecha_Emision,Ped_Fecha_Entrega,Ped_Comensales,Ped_Facturado)
                                VALUES (@ped_id,@usu_id,@mesa_id,@cli_id,@ped_fecha_emision,@ped_fecha_entrega,@ped_comensales,@ped_facturado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ped_id", oPedido.Ped_id);
            cmd.Parameters.AddWithValue("@usu_id", oPedido.Usu_id);
            cmd.Parameters.AddWithValue("@mesa_id", oPedido.Mesa_id);
            cmd.Parameters.AddWithValue("@cli_id", oPedido.Cli_id);
            cmd.Parameters.AddWithValue("@ped_fecha_emision", DateTime.Now);
            cmd.Parameters.AddWithValue("@ped_fecha_entrega", DateTime.Now);
            cmd.Parameters.AddWithValue("@ped_comensales", oPedido.Ped_comensales);
            cmd.Parameters.AddWithValue("@ped_facturado", oPedido.Ped_facturado);

            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            cmd.ExecuteNonQuery();

            // cerrar la conexion
            cnn.Close();
        }

        public static Pedido TraerUltimoPedidoPorMesa(int idMesa)
        {
            Pedido oPedido = new Pedido();

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM Pedido 
                                WHERE Mesa_Id=@id ORDER BY Ped_Id DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idMesa);

            // configurar un adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // crear una tabla o conjunto de datos dataset
            DataTable dt = new DataTable();

            // llenar la tabla
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                oPedido.Ped_id = Convert.ToInt32(dt.Rows[0]["Ped_Id"]);
                oPedido.Usu_id = Convert.ToInt32(dt.Rows[0]["Usu_Id"]);
                oPedido.Mesa_id = Convert.ToInt32(dt.Rows[0]["Mesa_Id"]);
                oPedido.Cli_id = Convert.ToInt32(dt.Rows[0]["Cli_Id"]);
                oPedido.Ped_fecha_emision = Convert.ToDateTime(dt.Rows[0]["Ped_Fecha_Emision"]);
                oPedido.Ped_fecha_entrega = Convert.ToDateTime(dt.Rows[0]["Ped_Fecha_Entrega"]);
                oPedido.Ped_comensales = Convert.ToInt32(dt.Rows[0]["Ped_Comensales"]);
                oPedido.Ped_facturado = Convert.ToBoolean(dt.Rows[0]["Ped_Facturado"]);
            }

            return oPedido;
        }
    }
}
