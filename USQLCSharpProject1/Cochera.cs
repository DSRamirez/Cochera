using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Cochera
    {
       // private int id_cochera;
        private string numeroCochera;

        public int ID_Cochera { get; set; }
        public string NumeroCochera { get => numeroCochera; set => numeroCochera = value; }

        public void cocheras(string numCochera)
        {
            numeroCochera = numCochera;
        }
    }
}
