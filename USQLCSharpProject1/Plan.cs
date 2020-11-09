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
        //private int id_plan;
        private string tipoPlan;
        private string fechaIngreso;
        private string fechaEgreso;

        public int ID_Plan { get; set; }
        public string TipoPlan { get => tipoPlan; set => tipoPlan = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }

        public void planes(string tipop, string fing, string fegr)
        {
            tipoPlan = tipop;
            fechaIngreso = fing;
            fechaEgreso = fegr;
        }
    }
}
