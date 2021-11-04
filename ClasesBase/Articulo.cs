using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Articulo : INotifyPropertyChanged
    {

        private int art_id;

        public int Art_id
        {
            get { return art_id; }
            set { art_id = value; }
        }
        private string art_descrip;

        public string Art_descrip
        {
            get { return art_descrip; }
            set { art_descrip = value; }
        }
        private int fam_id;

        public int Fam_id
        {
            get { return fam_id; }
            set { fam_id = value; }
        }
        private int um_id;

        public int Um_id
        {
            get { return um_id; }
            set { um_id = value; }
        }

        private string art_img_uri;

        public string Art_img_uri
        {
            get { return art_img_uri; }
            set { art_img_uri = value; }
        }

        private decimal art_precio;

        public decimal Art_precio
        {
            get { return art_precio; }
            set { art_precio = value; }
        }
        private Boolean art_maneja_stock;

        public Boolean Art_maneja_stock
        {
            get { return art_maneja_stock; }
            set { art_maneja_stock = value; }
        }

        private Familia familia;

        public Familia Familia
        {
            get
            {
                return familia;
            }
            set
            {
                familia = value;
                Notificador("Familia");
            }
        }

        private Categoria categoria;

        public Categoria Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
                Notificador("Categoria");
            }
        }

        private Unidad_Medida unidad_medida;

        public Unidad_Medida Unidad_Medida
        {
            get
            {
                return unidad_medida;
            }
            set
            {
                unidad_medida = value;
                Notificador("Unidad_Medida");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private System.Data.DataTable dataTable;

        public void Notificador(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        // Nuevo constructor
        public Articulo(int id, string descripcion, Familia familia, Categoria categoria, Unidad_Medida unidad_medida, decimal precio)
        {
            Art_id = id;
            Art_descrip = descripcion;
            Familia = familia;
            Categoria = categoria;
            Unidad_Medida = unidad_medida;
            Art_precio = precio;
        }

        public Articulo() { }

        public Articulo(System.Data.DataTable dataTable)
        {
            // TODO: Complete member initialization
            this.dataTable = dataTable;
        }
    }
}
