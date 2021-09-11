using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pedido
    {
        private int ped_id;

        public int Ped_id
        {
            get { return ped_id; }
            set { ped_id = value; }
        }
        private int usu_id;

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }
        private int mesa_id;

        public int Mesa_id
        {
            get { return mesa_id; }
            set { mesa_id = value; }
        }
        private int cli_id;

        public int Cli_id
        {
            get { return cli_id; }
            set { cli_id = value; }
        }
        private DateTime ped_fecha_emision;

        public DateTime Ped_fecha_emision
        {
            get { return ped_fecha_emision; }
            set { ped_fecha_emision = value; }
        }
        private DateTime ped_fecha_entrega;

        public DateTime Ped_fecha_entrega
        {
            get { return ped_fecha_entrega; }
            set { ped_fecha_entrega = value; }
        }
        private int ped_comensales;

        public int Ped_comensales
        {
            get { return ped_comensales; }
            set { ped_comensales = value; }
        }
        private bool ped_facturado;

        public bool Ped_facturado
        {
            get { return ped_facturado; }
            set { ped_facturado = value; }
        }
    }
}
