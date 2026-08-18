namespace ESFE.SystemIveris.UI
{
    partial class Vuelos
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
            btnReservas = new Button();
            btnMétodoPago = new Button();
            btnVuelos = new Button();
            btnInicio = new Button();
            dgv1 = new DataGridView();
            NumerodeVuelo = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            AvionAsignado = new DataGridViewTextBoxColumn();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = SystemColors.ActiveCaption;
            pnl1.BorderStyle = BorderStyle.FixedSingle;
            pnl1.Controls.Add(pic1);
            pnl1.Controls.Add(btnDestinos);
            pnl1.Controls.Add(btnReservas);
            pnl1.Controls.Add(btnMétodoPago);
            pnl1.Controls.Add(btnVuelos);
            pnl1.Controls.Add(btnInicio);
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(543, 160);
            pnl1.TabIndex = 5;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(198, 22);
            pic1.Name = "pic1";
            pic1.Size = new Size(184, 87);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 5;
            pic1.TabStop = false;
            // 
            // btnDestinos
            // 
            btnDestinos.Location = new Point(439, 115);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(75, 23);
            btnDestinos.TabIndex = 4;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            btnReservas.Location = new Point(358, 115);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(75, 23);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            // 
            // btnMétodoPago
            // 
            btnMétodoPago.Location = new Point(248, 115);
            btnMétodoPago.Name = "btnMétodoPago";
            btnMétodoPago.Size = new Size(104, 23);
            btnMétodoPago.TabIndex = 2;
            btnMétodoPago.Text = "Método de Pago";
            btnMétodoPago.UseVisualStyleBackColor = true;
            // 
            // btnVuelos
            // 
            btnVuelos.Location = new Point(158, 115);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(75, 23);
            btnVuelos.TabIndex = 1;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(63, 116);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { NumerodeVuelo, Origen, Destino, Hora, AvionAsignado });
            dgv1.Location = new Point(3, 196);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(543, 102);
            dgv1.TabIndex = 6;
            // 
            // NumerodeVuelo
            // 
            NumerodeVuelo.HeaderText = "Numero de Vuelo";
            NumerodeVuelo.Name = "NumerodeVuelo";
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // AvionAsignado
            // 
            AvionAsignado.HeaderText = "Avion Asiganado";
            AvionAsignado.Name = "AvionAsignado";
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(dgv1);
            Controls.Add(pnl1);
            Name = "Vuelos";
            Text = "Vuelos";
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private PictureBox pic1;
        private Button btnDestinos;
        private Button btnReservas;
        private Button btnMétodoPago;
        private Button btnVuelos;
        private Button btnInicio;
        private DataGridView dgv1;
        private DataGridViewTextBoxColumn NumerodeVuelo;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn AvionAsignado;
    }
}