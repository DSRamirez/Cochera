namespace ReservaCochera
{
    partial class ConfirmacionReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacionReserva));
            this.label1 = new System.Windows.Forms.Label();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.LblPlan = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.Lblemail = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblTitular = new System.Windows.Forms.Label();
            this.LblCochera = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLES DE LA RESERVA:\r\n\r\n";
            // 
            // BtCancelar
            // 
            this.BtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtCancelar.Image")));
            this.BtCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelar.Location = new System.Drawing.Point(531, 376);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(184, 48);
            this.BtCancelar.TabIndex = 66;
            this.BtCancelar.Text = "CANCELAR";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("BtConfirmar.Image")));
            this.BtConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtConfirmar.Location = new System.Drawing.Point(67, 376);
            this.BtConfirmar.Name = "BtConfirmar";
            this.BtConfirmar.Size = new System.Drawing.Size(184, 48);
            this.BtConfirmar.TabIndex = 65;
            this.BtConfirmar.Text = "RESERVAR";
            this.BtConfirmar.UseVisualStyleBackColor = true;
            this.BtConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(301, 376);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(184, 48);
            this.btEditar.TabIndex = 67;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click_1);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDni.Location = new System.Drawing.Point(42, 142);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(41, 20);
            this.LblDni.TabIndex = 72;
            this.LblDni.Text = "DNI:";
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDomicilio.Location = new System.Drawing.Point(42, 185);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(76, 20);
            this.LblDomicilio.TabIndex = 71;
            this.LblDomicilio.Text = "Domicilio:";
            // 
            // LblPlan
            // 
            this.LblPlan.AutoSize = true;
            this.LblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlan.Location = new System.Drawing.Point(527, 142);
            this.LblPlan.Name = "LblPlan";
            this.LblPlan.Size = new System.Drawing.Size(44, 20);
            this.LblPlan.TabIndex = 70;
            this.LblPlan.Text = "Plan:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(42, 225);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(79, 20);
            this.LblTelefono.TabIndex = 69;
            this.LblTelefono.Text = "Teléfono: ";
            // 
            // Lblemail
            // 
            this.Lblemail.AutoSize = true;
            this.Lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblemail.Location = new System.Drawing.Point(42, 266);
            this.Lblemail.Name = "Lblemail";
            this.Lblemail.Size = new System.Drawing.Size(57, 20);
            this.Lblemail.TabIndex = 68;
            this.Lblemail.Text = "E-Mail:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(527, 104);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(58, 20);
            this.LblFecha.TabIndex = 75;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblTitular
            // 
            this.LblTitular.AutoSize = true;
            this.LblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitular.Location = new System.Drawing.Point(42, 104);
            this.LblTitular.Name = "LblTitular";
            this.LblTitular.Size = new System.Drawing.Size(56, 20);
            this.LblTitular.TabIndex = 76;
            this.LblTitular.Text = "Titular:";
            // 
            // LblCochera
            // 
            this.LblCochera.AutoSize = true;
            this.LblCochera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCochera.Location = new System.Drawing.Point(527, 185);
            this.LblCochera.Name = "LblCochera";
            this.LblCochera.Size = new System.Drawing.Size(142, 20);
            this.LblCochera.TabIndex = 77;
            this.LblCochera.Text = "Cochera asignada:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(261, 104);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculo.TabIndex = 81;
            this.lblVehiculo.Text = "Vehículo: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(261, 142);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 20);
            this.lblMarca.TabIndex = 80;
            this.lblMarca.Text = "Marca: ";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModelo.Location = new System.Drawing.Point(261, 185);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(73, 20);
            this.LblModelo.TabIndex = 79;
            this.LblModelo.Text = "Modelo:  ";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio.Location = new System.Drawing.Point(261, 225);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(75, 20);
            this.lblDominio.TabIndex = 78;
            this.lblDominio.Text = "Dominio: ";
            // 
            // ConfirmacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.LblCochera);
            this.Controls.Add(this.LblTitular);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.LblPlan);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.Lblemail);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtConfirmar);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmacionReserva";
            this.Text = "ConfirmacionReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.Button btEditar;
        public System.Windows.Forms.Label LblDni;
        public System.Windows.Forms.Label LblDomicilio;
        public System.Windows.Forms.Label LblPlan;
        public System.Windows.Forms.Label LblTelefono;
        public System.Windows.Forms.Label Lblemail;
        public System.Windows.Forms.Label LblFecha;
        public System.Windows.Forms.Label LblTitular;
        public System.Windows.Forms.Label LblCochera;
        public System.Windows.Forms.Label lblVehiculo;
        public System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.Label LblModelo;
        public System.Windows.Forms.Label lblDominio;
    }
}