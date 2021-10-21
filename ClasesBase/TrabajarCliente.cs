using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static Cliente TraerCliente()
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_apellido = "Perez";
            return oCliente;
        }
    }
}
