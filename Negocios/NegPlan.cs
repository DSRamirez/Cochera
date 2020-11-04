using DataBase;
using ReservaCochera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegPlan
    {
        DatosPlan objDP = new DatosPlan();

        public int AltaPlan (Plan objPlan)
        {
            return objDP.AltaPlan (objPlan);
        }
    }
}
