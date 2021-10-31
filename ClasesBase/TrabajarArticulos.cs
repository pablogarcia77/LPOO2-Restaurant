using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

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


        public ObservableCollection<Articulo> TraerArticulosObs()
        {
            ObservableCollection<Articulo> listaArticulo = new ObservableCollection<Articulo>();
            /**
            Familia oFamilia = new Familia(2, "Productos Terminados");
            Familia oFamilia2 = new Familia(3, "Bebidas");
            Categoria oCategoria = new Categoria(3,"Desayunos");
            Categoria oCategoria2 = new Categoria(2, "Minutas");
            Categoria oCategoria3 = new Categoria(1, "Menu");
            Unidad_Medida oUM = new Unidad_Medida(1,"Kilos","Kg");

            listaArticulo.Add(new Articulo("Lomito", oFamilia, oCategoria2, oUM, 500));
            listaArticulo.Add(new Articulo("Pizza",oFamilia, oCategoria, oUM, 500));
            
            listaArticulo.Add(new Articulo("Coca Cola", oFamilia2, oCategoria3, oUM, 500));
            **/
            return listaArticulo;
        }

        public static string TraerArticuloPorId(int id)
        {
            string articulo;

            // Creamos la conexión
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.conexion);

            // configurar el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Art_Descrip FROM Articulo WHERE Art_Id=@id";
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
                articulo = dt.Rows[0][0].ToString();
            }
            else
            {
                articulo = "No se encontro";
            }

            return articulo;
        }
        
    }
}
