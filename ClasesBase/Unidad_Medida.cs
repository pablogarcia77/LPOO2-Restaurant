using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Unidad_Medida
    {
        private int um_id;

        public int Um_id
        {
            get { return um_id; }
            set { um_id = value; }
        }
        private string um_descrip;

        public string Um_descrip
        {
            get { return um_descrip; }
            set { um_descrip = value; }
        }
        private string um_abrev;

        public string Um_abrev
        {
            get { return um_abrev; }
            set { um_abrev = value; }
        }

        public Unidad_Medida(int id, string descripcion, string abreviacion) 
        {
            Um_id = id;
            Um_descrip = descripcion;
            Um_abrev = abreviacion;
        }
    }
}
