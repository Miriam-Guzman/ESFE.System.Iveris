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
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnInicio = new Button();
            dgv1 = new DataGridView();
            NumerodeVuelo = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            AvionAsignado = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(128, 128, 255);
            pnl1.BorderStyle = BorderStyle.FixedSingle;
            pnl1.Controls.Add(pic1);
            pnl1.Controls.Add(btnDestinos);
            pnl1.Controls.Add(btnMetodopago);
            pnl1.Controls.Add(btnReserva);
            pnl1.Controls.Add(btnVuelos);
            pnl1.Controls.Add(btnInicio);
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(611, 187);
            pnl1.TabIndex = 5;
            pnl1.Paint += pnl1_Paint;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(211, 22);
            pic1.Name = "pic1";
            pic1.Size = new Size(199, 101);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 12;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(492, 148);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(105, 27);
            btnDestinos.TabIndex = 17;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(116, 148);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(148, 27);
            btnMetodopago.TabIndex = 14;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.White;
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(270, 148);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(105, 27);
            btnReserva.TabIndex = 16;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.BackColor = Color.FromArgb(128, 255, 128);
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(381, 148);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(105, 27);
            btnVuelos.TabIndex = 15;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(5, 148);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 27);
            btnInicio.TabIndex = 13;
            btnInicio.Text = "Inicio ";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { NumerodeVuelo, Origen, Destino, Hora, AvionAsignado });
            dgv1.Location = new Point(35, 248);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(543, 102);
            dgv1.TabIndex = 6;
            dgv1.CellContentClick += dgv1_CellContentClick;
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
            // btnBuscar
            // 
            btnBuscar.Location = new Point(57, 377);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(193, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(357, 377);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(496, 377);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(dgv1);
            Controls.Add(pnl1);
            Name = "Vuelos";
            Text = "Vuelos";
            Load += Vuelos_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private DataGridView dgv1;
        private DataGridViewTextBoxColumn NumerodeVuelo;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn AvionAsignado;
        private PictureBox pic1;
        private Button btnDestinos;
        private Button btnMetodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnInicio;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnInsertar;
        private Button btnModificar;
    }
}