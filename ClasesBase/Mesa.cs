using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Mesa
    {
        private int mesa_id;

        public int Mesa_id
        {
            get { return mesa_id; }
            set { mesa_id = value; }
        }
        private int mesa_posicion;

        public int Mesa_posicion
        {
            get { return mesa_posicion; }
            set { mesa_posicion = value; }
        }
        private int mesa_estado;

        public int Mesa_estado
        {
            get { return mesa_estado; }
            set { mesa_estado = value; }
        }
    }
}
