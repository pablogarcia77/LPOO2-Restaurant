using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Categoria
    {
        private int cat_id;

        public int Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private string cat_descrip;

        public string Cat_descrip
        {
            get { return cat_descrip; }
            set { cat_descrip = value; }
        }

        public Categoria(int id, string descripcion)
        {
            Cat_id = id;
            Cat_descrip = descripcion;
        }
    }
}
