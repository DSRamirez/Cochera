using DataBase;
using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegVehiculo
    {
        DatosVehiculo objDV = new DatosVehiculo();

        public int AltaVehiculo(Vehiculo objVehiculo)
        {
            return objDV.AltaVehiculo(objVehiculo);
        }

    }
}
