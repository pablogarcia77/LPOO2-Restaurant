﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Items_Pedido
    {
        private int item_ped_id;

        public int Item_ped_id
        {
            get { return item_ped_id; }
            set { item_ped_id = value; }
        }
        private int ped_id;

        public int Ped_id
        {
            get { return ped_id; }
            set { ped_id = value; }
        }
        private int art_id;

        public int Art_id
        {
            get { return art_id; }
            set { art_id = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
    }
}
