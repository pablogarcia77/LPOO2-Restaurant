using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Historial_Login
    {
        private int log_id;

        public int Log_id
        {
            get { return log_id; }
            set { log_id = value; }
        }
        private int usu_id;

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }
        private DateTime log_fecha_hora;

        public DateTime Log_fecha_hora
        {
            get { return log_fecha_hora; }
            set { log_fecha_hora = value; }
        }
        private string log_descrip;

        public string Log_descrip
        {
            get { return log_descrip; }
            set { log_descrip = value; }
        }
    }
}
