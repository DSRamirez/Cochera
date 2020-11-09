using DataBase;
using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegCochera
    {
        DatosCochera objDC = new DatosCochera();

        public int AltaCochera(Cochera objCochera) //int idcliente, int idplan, int idvehiculo
        {
            return objDC.AltaCochera(objCochera); //ref - idcliente, idplan, idvehiculo
        }
    }
}
