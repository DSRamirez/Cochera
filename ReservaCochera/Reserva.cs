using DataBase;
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

        ConfirmacionReserva Confirm = new ConfirmacionReserva();
        public int Numero = 0;
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            Confirm.Show();

            Confirm.LblTitular.Text = Confirm.LblTitular.Text + txtTitular.Text;
            Confirm.LblDni.Text = Confirm.LblDni.Text + txtDni.Text;
            Confirm.LblDomicilio.Text = Confirm.LblDomicilio.Text + txtDomicilio.Text;
            Confirm.LblTelefono.Text = Confirm.LblTelefono.Text + txtTelefono.Text;
            Confirm.Lblemail.Text = Confirm.Lblemail.Text+ txtEmail.Text;
            Confirm.LblPlan.Text = Confirm.LblPlan.Text + CbPlan.SelectedItem.ToString();
            Confirm.lblVehiculo.Text = Confirm.lblVehiculo.Text + CbVehiculo.SelectedItem.ToString();
            Confirm.lblMarca.Text = Confirm.lblMarca.Text + txtMarca.Text;
            Confirm.LblModelo.Text = Confirm.LblModelo.Text + txtModelo.Text;
            Confirm.lblDominio.Text = Confirm.lblDominio.Text + txtDominio.Text;
            Confirm.LblFecha.Text = Confirm.LblFecha.Text + McFechaReserva.SelectionStart.ToShortDateString() + " hasta el día: " + McFechaReserva.SelectionEnd.ToShortDateString();
            Confirm.LblCochera.Text = Confirm.LblCochera.Text + Numero.ToString();

            EnviarDatos();
        }

        public void EnviarDatos()
        {
            string[] datos = new string [13];
            datos[0] = txtTitular.Text;
            datos[1] = txtDni.Text;
            datos[2] = txtDomicilio.Text;
            datos[3] = txtTelefono.Text;
            datos[4] = txtEmail.Text;
            datos[5] = CbPlan.SelectedItem.ToString();
            datos[6] = CbVehiculo.SelectedItem.ToString();
            datos[7] = txtMarca.Text;
            datos[8] = txtModelo.Text;
            datos[9] = txtDominio.Text;
            datos[10] = McFechaReserva.SelectionStart.ToShortDateString();
            datos[11] = McFechaReserva.SelectionEnd.ToShortDateString();
            datos[12] = Numero.ToString();

            Confirm.datos = datos;
        }
        #endregion

        #region Eventos CheckBox

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 1;
            if (cb1.Checked = true)
            {
                cb1.Enabled = true;
            }
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 2;
            if (cb2.Checked = true)
            {
                cb2.Enabled = true;
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 3;
            if (cb3.Checked = true)
            {
                cb3.Enabled = true;
            }
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 4;
            if (cb4.Checked = true)
            {
                cb4.Enabled = true;
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 5;
            if (cb5.Checked = true)
            {
                cb5.Enabled = true;
            }
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 6;
            if (cb6.Checked = true)
            {
                cb6.Enabled = true;
            }
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 7;
            if (cb7.Checked = true)
            {
                cb7.Enabled = true;
            }
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 8;
            if (cb8.Checked = true)
            {
                cb8.Enabled = true;
            }
        }

        private void cb9_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 9;
            if (cb9.Checked = true)
            {
                cb9.Enabled = true;
            }
        }

        private void cb10_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 10;
            if (cb10.Checked = true)
            {
                cb10.Enabled = true;
            }
        }

        private void cb11_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 11;
            if (cb11.Checked = true)
            {
                cb11.Enabled = true;
            }
        }

        private void cb12_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 12;
            if (cb12.Checked = true)
            {
                cb12.Enabled = true;
            }
        }

        private void cb13_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 13;
            if (cb13.Checked = true)
            {
                cb13.Enabled = true;
            }
        }

        private void cb14_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 14;
            if (cb14.Checked = true)
            {
                cb14.Enabled = true;
            }
        }

        private void cb15_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 15;
            if (cb15.Checked = true)
            {
                cb15.Enabled = true;
            }
        }

        private void cb16_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 16;
            if (cb16.Checked = true)
            {
                cb16.Enabled = true;
            }
        }

        private void cb17_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 17;
            if (cb17.Checked = true)
            {
                cb17.Enabled = true;
            }
        }

        private void cb18_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 18;
            if (cb18.Checked = true)
            {
                cb18.Enabled = true;
            }
        }

        private void cb19_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 19;
            if (cb19.Checked = true)
            {
                cb19.Enabled = true;
            }
        }

        private void cb20_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 20;
            if (cb20.Checked = true)
            {
                cb20.Enabled = true;
            }
        }

        private void cb21_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 21;
            if (cb21.Checked = true)
            {
                cb21.Enabled = true;
            }
        }

        private void cb22_CheckedChanged(object sender, EventArgs e)
        {
            Numero = 22;
            if (cb22.Checked = true)
            {
                cb22.Enabled = true;
            }
        }

        #endregion
    }
}
