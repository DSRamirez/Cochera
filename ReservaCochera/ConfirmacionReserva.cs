using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservaCochera
{
    public partial class ConfirmacionReserva : Form
    {
        public ConfirmacionReserva()
        {
            InitializeComponent();
        }

        public string[] datos = new string[13];

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarCochera();
            this.Close();

        }
        private void btEditar_Click_1(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            this.Close();
            reserva.Show();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos
        public Cliente objentCliente = new Cliente();
        public Plan objentPlan = new Plan();
        public Cochera objentCochera = new Cochera();
        public Vehiculo objentVehiculo = new Vehiculo();
        public Negocios.NegCliente objNegCliente = new Negocios.NegCliente();
        public Negocios.NegPlan objNegPlan = new Negocios.NegPlan();
        public Negocios.NegCochera objNegCochera = new Negocios.NegCochera();
        public Negocios.NegVehiculo objNegVehiculo = new Negocios.NegVehiculo();

        private void ConfirmarCochera()
        {
            int cGrabados = -1;
            int pGrabados = -1;
            int vGrabados = -1;
            int nGrabados = -1;

            Plan_A_Obj();
            Cliente_A_Obj();
            Vehiculo_A_Obj();
            Cochera_A_Obj();

            pGrabados = objNegPlan.AltaPlan(objentPlan);
            cGrabados = objNegCliente.AltaCliente(objentCliente);
            vGrabados = objNegVehiculo.AltaVehiculo(objentVehiculo); //, objentCliente.ID_Cliente
            nGrabados = objNegCochera.AltaCochera(objentCochera); //objentCliente.ID_Cliente, objentPlan.ID_Plan, objentVehiculo.Id_Vehiculo

            if (cGrabados == -1)
            {
                MessageBox.Show("Error al intentar cargar el cliente");
            }
            else if (pGrabados == -1)
            {
                MessageBox.Show("Error al intentar cargar el Plan");
            }
            else if (vGrabados == -1)
            {
                MessageBox.Show("Error al intentar cargar el Vehiculo");
            }
            else if (nGrabados == -1)
            {
                MessageBox.Show("Error al intentar cargar la cochera");
            }
            else
            {
                MessageBox.Show("La reserva fue generada con éxito");
            }

        }

        public void Cliente_A_Obj()
        {
            objentCliente.Clientes(datos[0], datos[2], datos[3], datos[4], datos[1]);
        }

        public void Plan_A_Obj()
        {
            objentPlan.planes(datos[5], datos[10], datos[11]);
        }

        public void Vehiculo_A_Obj()
        {
            objentVehiculo.vehiculos(datos[6], datos[9], datos[8], datos[7]);
        }

        public void Cochera_A_Obj()
        {
            objentCochera.cocheras(datos[12]);
        }

        #endregion

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtMaximizar.Visible = false;
            BtRestaurar.Visible = true;
        }

        private void BtRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void BtMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
