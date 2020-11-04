using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaCochera
{
    public class Cliente
    {
        private string nombre;
        private string domicilio;
        private string telefono;
        private string email;
        private string dNI;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string DNI { get => dNI; set => dNI = value; }

        public void Clientes(string nom, string dom, string tel, string mail, string dni)
        {
            nombre = nom;
            domicilio = dom;
            telefono = tel;
            email = mail;
            dNI = dni;
        }
    }
}
