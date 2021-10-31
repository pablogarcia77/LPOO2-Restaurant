using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace ClasesBase
{
    public class TrabajarItemsPedido
    {
        public ObservableCollection<Items_Pedido> TraerItemsPedido()
        {
            ObservableCollection<Items_Pedido> listaIPedidos = new ObservableCollection<Items_Pedido>();
            return listaIPedidos;
        }
    }
}
