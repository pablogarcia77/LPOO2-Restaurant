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

        public Familia Familia
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Categoria Categoria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Unidad_Medida Unidad_Medida
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
