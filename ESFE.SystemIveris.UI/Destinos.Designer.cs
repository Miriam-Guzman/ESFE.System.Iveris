namespace ESFE.SystemIveris.UI
{
    partial class Destinos
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
            Destino = new DataGridViewTextBoxColumn();
            RTSDPIBLE = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            this.btnInsertar = new Button();
            this.btnEliminar = new Button();
            this.btnModificar = new Button();
            btnBuscar = new Button();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
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
            pnl1.Location = new Point(-5, 6);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(615, 226);
            pnl1.TabIndex = 14;
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
            btnDestinos.BackColor = Color.FromArgb(128, 255, 128);
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(498, 170);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(105, 31);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = false;
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
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(276, 170);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(105, 31);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = true;
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
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Destino, RTSDPIBLE, Hora });
            dgv1.Location = new Point(12, 248);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(347, 176);
            dgv1.TabIndex = 13;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // RTSDPIBLE
            // 
            RTSDPIBLE.HeaderText = "Rutas Disponible";
            RTSDPIBLE.Name = "RTSDPIBLE";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora de Vuelo";
            Hora.Name = "Hora";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new Point(401, 264);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new Size(75, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += this.btnInsertar_Click;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(493, 264);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += this.btnEliminar_Click;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new Point(401, 306);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += this.btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(493, 306);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Destinos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 510);
            Controls.Add(btnBuscar);
            Controls.Add(this.btnModificar);
            Controls.Add(this.btnEliminar);
            Controls.Add(this.btnInsertar);
            Controls.Add(pnl1);
            Controls.Add(dgv1);
            Name = "Destinos";
            Text = "Destinos";
            Load += Destinos_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private PictureBox pic1;
        private Button btnDestinos;
        private Button btnMetodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnInicio;
        private DataGridView dgv1;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn RTSDPIBLE;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn AvionAsignado;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBuscar;
    }
}