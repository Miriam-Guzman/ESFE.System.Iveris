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
            btnBuscarvuelos = new Button();
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
            pnl1.Size = new Size(615, 199);
            pnl1.TabIndex = 15;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(217, 24);
            pic1.Name = "pic1";
            pic1.Size = new Size(199, 101);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(498, 150);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(105, 27);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(122, 150);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(148, 27);
            btnMetodopago.TabIndex = 8;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(192, 255, 192);
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(276, 150);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(105, 27);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            // 
            // btnVuelos
            // 
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(387, 150);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(105, 27);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(11, 150);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 27);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio ";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // lblidaVuelta
            // 
            lblidaVuelta.AutoSize = true;
            lblidaVuelta.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblidaVuelta.Location = new Point(13, 216);
            lblidaVuelta.Name = "lblidaVuelta";
            lblidaVuelta.Size = new Size(83, 16);
            lblidaVuelta.TabIndex = 16;
            lblidaVuelta.Text = "Ida y Vuelta";
            // 
            // txt1
            // 
            txt1.Location = new Point(35, 269);
            txt1.Name = "txt1";
            txt1.Size = new Size(366, 23);
            txt1.TabIndex = 17;
            // 
            // lblorigen
            // 
            lblorigen.AutoSize = true;
            lblorigen.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblorigen.Location = new Point(35, 251);
            lblorigen.Name = "lblorigen";
            lblorigen.Size = new Size(50, 16);
            lblorigen.TabIndex = 18;
            lblorigen.Text = "Origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(34, 319);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(54, 16);
            lblDestino.TabIndex = 19;
            lblDestino.Text = "Destino";
            // 
            // lblfechasalida
            // 
            lblfechasalida.AutoSize = true;
            lblfechasalida.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechasalida.Location = new Point(32, 389);
            lblfechasalida.Name = "lblfechasalida";
            lblfechasalida.Size = new Size(108, 16);
            lblfechasalida.TabIndex = 20;
            lblfechasalida.Text = "Fecha de salida";
            // 
            // lblfecharegreso
            // 
            lblfecharegreso.AutoSize = true;
            lblfecharegreso.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfecharegreso.Location = new Point(32, 447);
            lblfecharegreso.Name = "lblfecharegreso";
            lblfecharegreso.Size = new Size(118, 16);
            lblfecharegreso.TabIndex = 21;
            lblfecharegreso.Text = "Fecha de regreso";
            // 
            // lblpasajero
            // 
            lblpasajero.AutoSize = true;
            lblpasajero.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasajero.Location = new Point(32, 513);
            lblpasajero.Name = "lblpasajero";
            lblpasajero.Size = new Size(63, 16);
            lblpasajero.TabIndex = 22;
            lblpasajero.Text = "Pasajero";
            // 
            // lblclase
            // 
            lblclase.AutoSize = true;
            lblclase.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclase.Location = new Point(35, 586);
            lblclase.Name = "lblclase";
            lblclase.Size = new Size(42, 16);
            lblclase.TabIndex = 23;
            lblclase.Text = "Clase";
            // 
            // txt2
            // 
            txt2.Location = new Point(31, 353);
            txt2.Name = "txt2";
            txt2.Size = new Size(366, 23);
            txt2.TabIndex = 25;
            // 
            // txt5
            // 
            txt5.Location = new Point(32, 544);
            txt5.Name = "txt5";
            txt5.Size = new Size(366, 23);
            txt5.TabIndex = 28;
            // 
            // txt6
            // 
            txt6.Location = new Point(31, 604);
            txt6.Name = "txt6";
            txt6.Size = new Size(366, 23);
            txt6.TabIndex = 29;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(31, 476);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(357, 23);
            dtp1.TabIndex = 30;
            // 
            // dtp2
            // 
            dtp2.Location = new Point(36, 412);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(356, 23);
            dtp2.TabIndex = 31;
            // 
            // btnBuscarvuelos
            // 
            btnBuscarvuelos.BackColor = Color.Blue;
            btnBuscarvuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarvuelos.ForeColor = Color.White;
            btnBuscarvuelos.Location = new Point(193, 649);
            btnBuscarvuelos.Name = "btnBuscarvuelos";
            btnBuscarvuelos.Size = new Size(208, 45);
            btnBuscarvuelos.TabIndex = 32;
            btnBuscarvuelos.Text = "Buscar Vuelos";
            btnBuscarvuelos.UseVisualStyleBackColor = false;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 722);
            Controls.Add(btnBuscarvuelos);
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
        private Button btnBuscarvuelos;
    }
}