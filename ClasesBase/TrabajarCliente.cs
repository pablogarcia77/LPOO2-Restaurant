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
        public static Cliente TraerCliente()
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_apellido = "Perez";
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
