using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Vehiculo
    {
        private string tipoVehiculo;
        private string dominio;
        private string modelo;
        private string marca;
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string Dominio { get => dominio; set => dominio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }

        public void vehiculos(string tipo, string domin, string mod, string mar) 
        {
            tipoVehiculo = tipo;
            dominio = domin;
            modelo = mod;
            marca = mar;
        }
    }
}
