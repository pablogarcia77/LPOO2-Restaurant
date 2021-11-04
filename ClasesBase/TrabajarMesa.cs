using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace ClasesBase
{
    public class TrabajarMesa
    {
        public static DataTable TotalMesas()
        {
            //Coneccion
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            //Consulta Sql
            SqlCommand consulta = new SqlCommand("Select Mesa_Id,Mesa_Estado FROM Mesa");
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

        public static Mesa TraerMesaPorId(int mesa)
        {
            Mesa oMesa = new Mesa();

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Mesa_Id,Mesa_Estado FROM Mesa WHERE Mesa_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", mesa);

            // configurar un adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // crear una tabla o conjunto de datos dataset
            DataTable dt = new DataTable();

            // llenar la tabla
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                oMesa.Mesa_id = Convert.ToInt32(dt.Rows[0]["Mesa_Id"]);
                oMesa.Mesa_estado = dt.Rows[0]["Mesa_Estado"].ToString();
            }
            else
            {
                oMesa = null;
            }

            return oMesa;
        }

        public static void ModificarEstadoMesa(Mesa oMesa)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Mesa SET Mesa_Estado=@estado 
                                WHERE Mesa_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@estado", oMesa.Mesa_estado);
            cmd.Parameters.AddWithValue("@id", oMesa.Mesa_id);

            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            cmd.ExecuteNonQuery();

            // cerrar la conexion
            cnn.Close();
        }

        
    }
}
