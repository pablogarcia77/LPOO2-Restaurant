using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static Cliente TraerClientePorId(int id)
        {
            Cliente oCliente = new Cliente();

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente WHERE Cli_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            // configurar un adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // crear una tabla o conjunto de datos dataset
            DataTable dt = new DataTable();

            // llenar la tabla
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                oCliente.Cli_id = Convert.ToInt32(dt.Rows[0]["Cli_Id"]);
                oCliente.Cli_apellido = dt.Rows[0]["Cli_Apellido"].ToString();
                oCliente.Cli_nombre = dt.Rows[0]["Cli_Nombre"].ToString();
            }
            else
            {
                oCliente = null;
            }

            return oCliente;
        }

        public static DataTable TraerClientes()
        {
            //Coneccion
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            //Consulta Sql
            SqlCommand consulta = new SqlCommand("Select Cli_Id,Cli_Apellido From Cliente");
            //Conectar la bd con la consulta SQL
            consulta.Connection = cn;
            //Enlace Adaptador de la consulta Sql
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            //Creamos un Objeto Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Devolvemos el valor de la tabla
            return dt;
        }
    }
}
