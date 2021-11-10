using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUnidadMedida
    {
        public static DataTable traerUnidadMedida()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSql = new SqlCommand("Select * from Unidad_Medida");
            consultaSql.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(consultaSql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
