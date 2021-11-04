using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


namespace ClasesBase
{
    public class TrabajarUsuarios
    {
        public static Usuario TraerUsuarioPorId(int id)
        {
            Usuario oUsuario = new Usuario();

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_Id=@id";
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
                oUsuario.Usu_id = Convert.ToInt32(dt.Rows[0]["Usu_Id"]);
                oUsuario.Usu_apellido_nombre = dt.Rows[0]["Usu_ApellidoNombre"].ToString();
            }
            else
            {
                oUsuario = null;
            }

            return oUsuario;
        }
    }
}

