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
            // ,Fam_Id,UM_Id,Art_Precio
            SqlCommand consulta = new SqlCommand("Select Art_Id,Art_Descrip,Art_Precio From Articulo");
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

        public static ObservableCollection<Articulo> TraerArticulosObs()
        {
            ObservableCollection<Articulo> listaArticulo = new ObservableCollection<Articulo>();
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSql = new SqlCommand(@"SELECT dbo.Articulo.Art_Id, dbo.Articulo.Art_Descrip, dbo.Familia.Fam_Descrip, dbo.Unidad_Medida.UM_Descrip, dbo.Categorias.Cat_Descrip, dbo.Articulo.Art_Precio
                            FROM   dbo.Articulo INNER JOIN
                         dbo.Familia ON dbo.Articulo.Fam_Id = dbo.Familia.Fam_Id INNER JOIN
                         dbo.Categorias ON dbo.Articulo.Cat_Id = dbo.Categorias.Cat_Id INNER JOIN
                         dbo.Unidad_Medida ON dbo.Articulo.UM_Id = dbo.Unidad_Medida.UM_Id");
            consultaSql.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(consultaSql);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Articulo articuloBD = new Articulo();
                Familia familia = new Familia();
                Categoria categoria = new Categoria();
                Unidad_Medida unidad_Medida = new Unidad_Medida();
                articuloBD.Art_id = Convert.ToInt32(dt.Rows[i][0]);
                articuloBD.Art_descrip = Convert.ToString(dt.Rows[i][1]);
                familia.Fam_descrip = Convert.ToString(dt.Rows[i][2]);
                categoria.Cat_descrip = Convert.ToString(dt.Rows[i][3]);
                unidad_Medida.Um_descrip = Convert.ToString(dt.Rows[i][4]);
                articuloBD.Art_precio = Convert.ToDecimal(dt.Rows[i][5]);
                listaArticulo.Add(new Articulo(articuloBD.Art_id, articuloBD.Art_descrip, familia, categoria, unidad_Medida, articuloBD.Art_precio));

            }
            return listaArticulo;
        }

        /**
        public static ObservableCollection<Articulo> TraerArticulosObs()
        {
            ObservableCollection<Articulo> listaArticulo = new ObservableCollection<Articulo>();
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            //SqlCommand consultaSql = new SqlCommand("SELECT dbo.Articulo.Art_Id, dbo.Articulo.Art_Descrip, dbo.Familia.Fam_Descrip, dbo.Categorias.Cat_Descrip, dbo.Unidad_Medida.UM_Descrip, dbo.Articulo.Art_Precio FROM dbo.Articulo CROSS JOIN   dbo.Categorias CROSS JOIN  dbo.Familia CROSS JOIN  dbo.Unidad_Medida");
            SqlCommand consultaSql = new SqlCommand("SELECT dbo.Articulo.Art_Id, dbo.Articulo.Art_Descrip, dbo.Familia.Fam_Descrip, dbo.Categorias.Cat_Descrip, dbo.Unidad_Medida.UM_Descrip, dbo.Articulo.Art_Precio FROM dbo.Articulo LEFT JOIN dbo.Categorias ON (dbo.Categorias.Cat_Id = dbo.Articulo.Cat_Id) LEFT JOIN dbo.Familia ON (dbo.Familia.Fam_Id = dbo.Articulo.Fam_Id) LEFT JOIN dbo.Unidad_Medida ON (dbo.Unidad_Medida.UM_Id = dbo.Articulo.UM_Id)");
            //SqlCommand consultaSql = new SqlCommand("SELECT a.Art_Id, a.Art_Descrip, f.Fam_Descrip, c.Cat_Descrip, um.UM_Descrip, a.Art_Precio FROM Articulo a, Categorias c, Familia f, Unidad_Medida um WHERE a.Fam_Id=f.Fam_Id AND a.UM_Id=um.UM_Id AND a.Cat_Id=c.Cat_Id");
            consultaSql.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(consultaSql);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Articulo articuloBD = new Articulo();
                Familia familia = new Familia();
                Categoria categoria = new Categoria();
                Unidad_Medida unidad_Medida = new Unidad_Medida();
                articuloBD.Art_id = Convert.ToInt32(dt.Rows[i][0]);
                articuloBD.Art_descrip = Convert.ToString(dt.Rows[i][1]);
                familia.Fam_descrip = Convert.ToString(dt.Rows[i][2]);
                categoria.Cat_descrip = Convert.ToString(dt.Rows[i][3]);
                unidad_Medida.Um_descrip = Convert.ToString(dt.Rows[i][4]);
                articuloBD.Art_precio = Convert.ToDecimal(dt.Rows[i][5]);
                listaArticulo.Add(new Articulo(articuloBD.Art_id, articuloBD.Art_descrip, familia, categoria, unidad_Medida, articuloBD.Art_precio));

            }
            return listaArticulo;
        }
        **/
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

        public static Articulo obtenerUnArticulo(int id)
        {
            Articulo articulo = new Articulo();
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSql = new SqlCommand("Select * from Articulo where Art_Id=@id");
            consultaSql.Connection = cn;
            consultaSql.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(consultaSql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0] != null)
            {
                articulo.Art_id = Convert.ToInt32(dt.Rows[0][0]);
                articulo.Art_descrip = Convert.ToString(dt.Rows[0][1]);
                articulo.Fam_id = Convert.ToInt32(dt.Rows[0][2]);
                articulo.Um_id = Convert.ToInt32(dt.Rows[0][3]);
                articulo.Art_precio = Convert.ToDecimal(dt.Rows[0][4]);
                articulo.Art_maneja_stock = Convert.ToBoolean(dt.Rows[0][5]);
            }


            return articulo;
        }

        public static void nuevoArticuloObs(Articulo nuevoArticulo)
        {

            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSQL = new SqlCommand("Insert Into Articulo (Art_Descrip,Fam_Id,UM_Id,Art_Precio,Art_Maneja_Stock,Cat_Id,Art_Img_Uri) values (@d,@f,@u,@p,@s,@c,@a)");
            consultaSQL.Connection = cn;
            consultaSQL.Parameters.AddWithValue("@d", nuevoArticulo.Art_descrip);
            consultaSQL.Parameters.AddWithValue("@f", nuevoArticulo.Fam_id);
            consultaSQL.Parameters.AddWithValue("@p", nuevoArticulo.Art_precio);
            consultaSQL.Parameters.AddWithValue("@u", nuevoArticulo.Um_id);
            consultaSQL.Parameters.AddWithValue("@s", nuevoArticulo.Art_maneja_stock);
            consultaSQL.Parameters.AddWithValue("@c", nuevoArticulo.Categoria.Cat_id);
            consultaSQL.Parameters.AddWithValue("@a", nuevoArticulo.Art_Img_Uri);
            cn.Open();
            consultaSQL.ExecuteNonQuery();
            cn.Close();
        }

        public static void modificarArticuloObs(Articulo modificarArticulo)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSql = new SqlCommand("Update Articulo Set Art_Descrip=@d,Fam_Id=@f,UM_Id=@u,Art_Precio=@p,Art_Maneja_Stock=@s,Cat_Id=@c where Art_Id=@id");
            consultaSql.Connection = cn;

            consultaSql.Parameters.AddWithValue("@id", modificarArticulo.Art_id);
            consultaSql.Parameters.AddWithValue("@d", modificarArticulo.Art_descrip);
            consultaSql.Parameters.AddWithValue("@f", modificarArticulo.Fam_id);
            consultaSql.Parameters.AddWithValue("@u", modificarArticulo.Um_id);
            consultaSql.Parameters.AddWithValue("@p", modificarArticulo.Art_precio);
            consultaSql.Parameters.AddWithValue("@s", modificarArticulo.Art_maneja_stock);
            consultaSql.Parameters.AddWithValue("@c", modificarArticulo.Categoria.Cat_id);
            cn.Open();
            consultaSql.ExecuteNonQuery();
            cn.Close();
        }

        public static void eliminarArticuloObs(int id)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand consultaSQL = new SqlCommand("Delete From Articulo where Art_Id = @id");
            consultaSQL.Connection = cn;
            consultaSQL.Parameters.AddWithValue("@id", id);
            cn.Open();
            consultaSQL.ExecuteNonQuery();
            cn.Close();
        }
        
    }
}
