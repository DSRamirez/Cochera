using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCochera
{
    public partial class ConfirmacionReserva : Form
    {

        public ConfirmacionReserva()
        {
            InitializeComponent();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarCochera();
            MessageBox.Show("Reserva generada correctamente");
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
        private void ConfirmarCochera()
        {
            DAL dAL = new DAL();
            dAL.InsertPlan();
            dAL.InsertVehiculo();
            dAL.InsertCochera();
            dAL.InsertCliente();

            Plan plan = new Plan();
            Vehiculo vehiculo = new Vehiculo();
            Cochera cochera = new Cochera();
            Cliente cliente = new Cliente();

           // cliente.Nombre = ;

            MessageBox.Show("La reserva fue generada con éxito");
        }
        #endregion
    }
}
