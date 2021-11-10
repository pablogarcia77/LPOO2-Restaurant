using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCategorias
    {
        public static DataTable traerCategoria()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand sqlConsulta = new SqlCommand("Select * From Categorias");
            sqlConsulta.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(sqlConsulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
