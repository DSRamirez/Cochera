using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Cochera
    {
        private string numeroCochera;

        public string NumeroCochera { get => numeroCochera; set => numeroCochera = value; }

        public void cocheras(string numCochera)
        {
            numeroCochera = numCochera;
        }
    }
}
