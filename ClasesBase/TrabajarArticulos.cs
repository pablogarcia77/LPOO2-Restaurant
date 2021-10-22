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

            Familia oFamilia = new Familia(1,"Menu al plato");
            Familia oFamilia1 = new Familia(2, "Minutas");
            Familia oFamilia2 = new Familia(2, "Bebidas");
            Categoria oCategoria = new Categoria(2,"Almuerzo");
            Categoria oCategoria2 = new Categoria(3, "Sandwich");
            Categoria oCategoria3 = new Categoria(4, "Gaseosas");
            Categoria oCategoria4 = new Categoria(5, "Tragos");
            Unidad_Medida oUM = new Unidad_Medida(1,"Unidad","U");
            Unidad_Medida oUM1 = new Unidad_Medida(2, "Litros", "L");

            listaArticulo.Add(new Articulo("Milanesa Napolitana",oFamilia, oCategoria, oUM, 350));
            listaArticulo.Add(new Articulo("Lomito", oFamilia1, oCategoria2, oUM, 280));
            listaArticulo.Add(new Articulo("Coca Cola", oFamilia2, oCategoria3, oUM1, 170));
            listaArticulo.Add(new Articulo("Amarula", oFamilia2, oCategoria4, oUM1, 200));

            return listaArticulo;
        }
        
    }
}
