using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class TrabajarCaja
    {
        public static DataTable TraerCajaFecha(DateTime fecha)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT p.Mesa_Id, SUM(ip.Importe) as Importe FROM Pedido p, Items_Pedido ip WHERE ip.Ped_Id = p.Ped_Id AND p.Ped_Fecha_Emision>@fecha AND p.Ped_Fecha_Emision<@fechaFin GROUP BY p.Mesa_Id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@fechaFin", fecha.AddDays(1));

            // configurar un adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // crear una tabla o conjunto de datos dataset
            DataTable dt = new DataTable();

            // llenar la tabla
            da.Fill(dt);

            return dt;
        }

    }
}
