using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaCochera
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        #region Actions

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva Confirm = new ConfirmacionReserva();
            Confirm.Show();

            Confirm.lblDetalle.Text =
                "Reserva a nombre de: " + txtTitular.Text +
                "\nDNI: " + txtDni.Text +
                "\nDomicilio:" + txtDomicilio.Text +
                "\nTeléfono: " + txtTelefono.Text +
                "\nE-Mail: " + txtEmail.Text +
                "\nTipo de Plan: " + CbPlan.Text +
                "\nFecha de la reserva desde: " + McFechaReserva.SelectionStart.ToShortDateString() + " hasta el día: " + McFechaReserva.SelectionEnd.ToShortDateString() +
                "\nDominio: " + txtDominio.Text; 

        }

        #endregion

    }
}
