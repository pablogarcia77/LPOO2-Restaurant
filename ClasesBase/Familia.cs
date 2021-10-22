using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Familia
    {
        private int fam_id;

        public int Fam_id
        {
            get { return fam_id; }
            set { fam_id = value; }
        }
        private string fam_descrip;

        public string Fam_descrip
        {
            get { return fam_descrip; }
            set { fam_descrip = value; }
        }

        public Familia(int id, string descripcion)
        {
            Fam_id = id;
            Fam_descrip = descripcion;
        }
    }
}
