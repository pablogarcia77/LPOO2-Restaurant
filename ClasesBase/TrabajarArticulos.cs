using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarArticulos
    {
        public static DataTable TraerArticulos()
        {   
            //Coneccion
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            //Consulta Sql
            SqlCommand consulta = new SqlCommand("Select Art_Id,Art_Descrip,Fam_Id,UM_Id,Art_Precio From Articulo");
            //Conectar la bd con la consulta SQL
            consulta.Connection = cn;
            //Enlace Adaptador de la consulta Sql
            SqlDataAdapter da =new SqlDataAdapter(consulta);
            //Creamos un Objeto Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Devolvemos el valor de la tabla
            return dt;
        }

      
      
        
    }
}
