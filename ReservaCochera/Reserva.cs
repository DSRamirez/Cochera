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

        int Numero = 0;
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmacionReserva Confirm = new ConfirmacionReserva();
            Confirm.Show();

            LblTitular.Text = txtTitular.Text;
            LblDNI.Text = txtDni.Text;
            LblDomicilio.Text = txtDomicilio.Text;
            LblTelefono.Text = txtTelefono.Text;
            Lblemail.Text = txtEmail.Text;
            
            //LblVehiculo
            //LblDominio    
            //LblMarca
            //LblModelo
            LblFechaReserva.Text = McFechaReserva.SelectionStart.ToShortDateString() + " hasta el día: " + McFechaReserva.SelectionEnd.ToShortDateString();
            LblPlan.Text = CbPlan.Text;
            //LblCochera
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

        #region Eventos CheckBox

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 1;
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 2;
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 3;
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 4;
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 5;
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 6;
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 7;
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 8;
        }

        private void cb9_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 9;
        }

        private void cb10_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 10;
        }

        private void cb11_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 11;
        }

        private void cb12_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 12;
        }

        private void cb13_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 13;
        }

        private void cb14_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 14;
        }

        private void cb15_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 15;
        }

        private void cb16_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 16;
        }

        private void cb17_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 17;
        }

        private void cb18_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 18;
        }

        private void cb19_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 19;
        }

        private void cb20_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 20;
        }

        private void cb21_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 21;
        }

        private void cb22_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 22;
        }

        #endregion
    }
}
