using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Plan
    {
        public int ID_Plan { get; set; }
        public string TipoPlan { get; set; }
        public SqlDateTime FechaIngreso { get; set; }
        public SqlDateTime FechaEgreso { get; set; }
    }
}
