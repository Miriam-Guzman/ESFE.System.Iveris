namespace ESFE.SystemIveris.UI
{
    partial class Reserva
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
            pnl1 = new Panel();
            pic1 = new PictureBox();
            btnDestinos = new Button();
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnInicio = new Button();
            lblidaVuelta = new Label();
            txt1 = new TextBox();
            lblorigen = new Label();
            lblDestino = new Label();
            lblfechasalida = new Label();
            lblfecharegreso = new Label();
            lblpasajero = new Label();
            lblclase = new Label();
            txt2 = new TextBox();
            txt5 = new TextBox();
            txt6 = new TextBox();
            dtp1 = new DateTimePicker();
            dtp2 = new DateTimePicker();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(128, 128, 255);
            pnl1.Controls.Add(pic1);
            pnl1.Controls.Add(btnDestinos);
            pnl1.Controls.Add(btnMetodopago);
            pnl1.Controls.Add(btnReserva);
            pnl1.Controls.Add(btnVuelos);
            pnl1.Controls.Add(btnInicio);
            pnl1.Location = new Point(2, 1);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(615, 226);
            pnl1.TabIndex = 15;
            pnl1.Paint += pnl1_Paint;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(217, 27);
            pic1.Name = "pic1";
            pic1.Size = new Size(199, 114);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(498, 170);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(105, 31);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(122, 170);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(148, 31);
            btnMetodopago.TabIndex = 8;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(192, 255, 192);
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(276, 170);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(105, 31);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(387, 170);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(105, 31);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(11, 170);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 31);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio ";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblidaVuelta
            // 
            lblidaVuelta.AutoSize = true;
            lblidaVuelta.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblidaVuelta.Location = new Point(244, 246);
            lblidaVuelta.Name = "lblidaVuelta";
            lblidaVuelta.Size = new Size(83, 16);
            lblidaVuelta.TabIndex = 16;
            lblidaVuelta.Text = "Ida y Vuelta";
            lblidaVuelta.Click += lblidaVuelta_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(14, 299);
            txt1.Name = "txt1";
            txt1.Size = new Size(366, 25);
            txt1.TabIndex = 17;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // lblorigen
            // 
            lblorigen.AutoSize = true;
            lblorigen.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblorigen.Location = new Point(18, 278);
            lblorigen.Name = "lblorigen";
            lblorigen.Size = new Size(50, 16);
            lblorigen.TabIndex = 18;
            lblorigen.Text = "Origen";
            lblorigen.Click += lblorigen_Click;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(14, 329);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(54, 16);
            lblDestino.TabIndex = 19;
            lblDestino.Text = "Destino";
            lblDestino.Click += lblDestino_Click;
            // 
            // lblfechasalida
            // 
            lblfechasalida.AutoSize = true;
            lblfechasalida.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechasalida.Location = new Point(14, 391);
            lblfechasalida.Name = "lblfechasalida";
            lblfechasalida.Size = new Size(108, 16);
            lblfechasalida.TabIndex = 20;
            lblfechasalida.Text = "Fecha de salida";
            lblfechasalida.Click += lblfechasalida_Click;
            // 
            // lblfecharegreso
            // 
            lblfecharegreso.AutoSize = true;
            lblfecharegreso.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfecharegreso.Location = new Point(14, 457);
            lblfecharegreso.Name = "lblfecharegreso";
            lblfecharegreso.Size = new Size(118, 16);
            lblfecharegreso.TabIndex = 21;
            lblfecharegreso.Text = "Fecha de regreso";
            lblfecharegreso.Click += lblfecharegreso_Click;
            // 
            // lblpasajero
            // 
            lblpasajero.AutoSize = true;
            lblpasajero.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasajero.Location = new Point(14, 532);
            lblpasajero.Name = "lblpasajero";
            lblpasajero.Size = new Size(63, 16);
            lblpasajero.TabIndex = 22;
            lblpasajero.Text = "Pasajero";
            lblpasajero.Click += lblpasajero_Click;
            // 
            // lblclase
            // 
            lblclase.AutoSize = true;
            lblclase.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclase.Location = new Point(17, 614);
            lblclase.Name = "lblclase";
            lblclase.Size = new Size(42, 16);
            lblclase.TabIndex = 23;
            lblclase.Text = "Clase";
            lblclase.Click += lblclase_Click;
            // 
            // txt2
            // 
            txt2.Location = new Point(13, 350);
            txt2.Name = "txt2";
            txt2.Size = new Size(366, 25);
            txt2.TabIndex = 25;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // txt5
            // 
            txt5.Location = new Point(14, 567);
            txt5.Name = "txt5";
            txt5.Size = new Size(366, 25);
            txt5.TabIndex = 28;
            txt5.TextChanged += txt5_TextChanged;
            // 
            // txt6
            // 
            txt6.Location = new Point(13, 635);
            txt6.Name = "txt6";
            txt6.Size = new Size(366, 25);
            txt6.TabIndex = 29;
            txt6.TextChanged += txt6_TextChanged;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(13, 490);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(357, 25);
            dtp1.TabIndex = 30;
            dtp1.ValueChanged += dtp1_ValueChanged;
            // 
            // dtp2
            // 
            dtp2.Location = new Point(18, 417);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(356, 25);
            dtp2.TabIndex = 31;
            dtp2.ValueChanged += dtp2_ValueChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Blue;
            btnBuscar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(312, 686);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 43);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Blue;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(186, 686);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 43);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Blue;
            btnEliminar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(438, 686);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 43);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Blue;
            btnModificar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(60, 686);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 43);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 741);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(dtp2);
            Controls.Add(dtp1);
            Controls.Add(txt6);
            Controls.Add(txt5);
            Controls.Add(txt2);
            Controls.Add(lblclase);
            Controls.Add(lblpasajero);
            Controls.Add(lblfecharegreso);
            Controls.Add(lblfechasalida);
            Controls.Add(lblDestino);
            Controls.Add(lblorigen);
            Controls.Add(txt1);
            Controls.Add(lblidaVuelta);
            Controls.Add(pnl1);
            Name = "Reserva";
            Text = "Reserva";
            Load += Reserva_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl1;
        private PictureBox pic1;
        private Button btnDestinos;
        private Button btnMetodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnInicio;
        private Label lblidaVuelta;
        private TextBox txt1;
        private Label lblorigen;
        private Label lblDestino;
        private Label lblfechasalida;
        private Label lblfecharegreso;
        private Label lblpasajero;
        private Label lblclase;
        private TextBox txt2;
        private TextBox txt5;
        private TextBox txt6;
        private DateTimePicker dtp1;
        private DateTimePicker dtp2;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}