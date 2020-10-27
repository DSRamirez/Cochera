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
            Reserva reserva = new Reserva();           
        }
        #endregion
    }
}
