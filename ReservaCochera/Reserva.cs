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

        #region Eventos

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
        #region Seleccion Vehiculo
        private void RbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (RbAuto.Checked)
            {
                cb1.Visible = true;
                cb2.Visible = true;
                cb3.Visible = true;
                cb4.Visible = true;
                cb5.Visible = true;
                cb6.Visible = true;
                cb7.Visible = true;
                cb8.Visible = true;
                cb9.Visible = true;
                cb10.Visible = true;
                cb11.Visible = true;
                cb12.Visible = true;
                cb13.Visible = true;
                cb14.Visible = true;
                cb15.Visible = false;
                cb16.Visible = false;
                cb17.Visible = false;
                cb18.Visible = false;
                cb19.Visible = false;
                cb20.Visible = false;
                cb21.Visible = false;
                cb22.Visible = false;
            }
            else if (RbMoto.Checked)
            {
                cb1.Visible = false;
                cb2.Visible = false;
                cb3.Visible = false;
                cb4.Visible = false;
                cb5.Visible = false;
                cb6.Visible = false;
                cb7.Visible = false;
                cb8.Visible = false;
                cb9.Visible = false;
                cb10.Visible = false;
                cb11.Visible = false;
                cb12.Visible = false;
                cb13.Visible = false;
                cb14.Visible = false;
                cb15.Visible = false;
                cb16.Visible = true;
                cb17.Visible = true;
                cb18.Visible = true;
                cb19.Visible = true;
                cb20.Visible = true;
                cb21.Visible = true;
                cb22.Visible = true;
            }
        }

        #endregion

        #region Metodos privados

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //int Id = Llamar al metodo GetId("Tabla")
        }
    }
}
