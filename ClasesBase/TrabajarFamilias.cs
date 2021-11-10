using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarFamilias
    {
        public static void NuevaFamilia(Familia oFamilia)
        {
            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Familia (Fam_Descrip)
                                VALUES (@fam_descrip)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fam_descrip", oFamilia.Fam_descrip);

            // abrimos conexion
            cnn.Open();

            // ejecutar insert
            cmd.ExecuteNonQuery();

            // cerrar la conexion
            cnn.Close();
        }

        public static DataTable traerFamilia()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSql = new SqlCommand("Select Fam_Id,Fam_Descrip From Familia");
            consultaSql.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(consultaSql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
