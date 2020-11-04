using DataBase;
using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegCliente
    {
        DatosCliente objDCl = new DatosCliente();

        public int AltaCliente(Cliente objCliente)
        {
            return objDCl.AltaCliente(objCliente);
        }
    }
}
