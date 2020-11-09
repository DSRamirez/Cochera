using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Vehiculo
    {
      //  private int id_Vehiculo;
        private string tipoVehiculo;
        private string dominio;
        private string modelo;
        private string marca;

        public int Id_Vehiculo { get; set; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string Dominio { get => dominio; set => dominio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }

        public void vehiculos(string tipov, string domin, string mod, string mar) 
        {
            tipoVehiculo = tipov;
            dominio = domin;
            modelo = mod;
            marca = mar;
        }
    }
}
