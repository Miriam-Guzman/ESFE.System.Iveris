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
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            txtNombreDestino = new TextBox();
            lblNombreDestino = new Label();
            txtCodigoIata = new TextBox();
            lblCodigoIata = new Label();
            txtIdCiudad = new TextBox();
            lblIdCiudad = new Label();
            btnRefrescar = new Button();
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
            pnl1.Dock = DockStyle.Top;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(800, 190);
            pnl1.TabIndex = 14;
            pnl1.Paint += pnl1_Paint;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(300, 15);
            pic1.Name = "pic1";
            pic1.Size = new Size(200, 100);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.BackColor = Color.FromArgb(128, 255, 128);
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(560, 140);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(110, 32);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = false;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(140, 140);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(130, 32);
            btnMetodopago.TabIndex = 8;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(280, 140);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(110, 32);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = true;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(420, 140);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(110, 32);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(20, 140);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(100, 32);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(20, 205);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(460, 300);
            dgv1.TabIndex = 13;
            dgv1.CellClick += dgv1_CellClick;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(500, 205);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(100, 15);
            lblBuscar.TabIndex = 19;
            lblBuscar.Text = "Buscar Destino:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(500, 225);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Ciudad, Aeropuerto o Código";
            txtBuscar.Size = new Size(170, 23);
            txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(680, 224);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 25);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombreDestino
            // 
            lblNombreDestino.AutoSize = true;
            lblNombreDestino.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblNombreDestino.Location = new Point(500, 265);
            lblNombreDestino.Name = "lblNombreDestino";
            lblNombreDestino.Size = new Size(144, 15);
            lblNombreDestino.TabIndex = 21;
            lblNombreDestino.Text = "Nombre del Aeropuerto:";
            // 
            // txtNombreDestino
            // 
            txtNombreDestino.Location = new Point(500, 285);
            txtNombreDestino.Name = "txtNombreDestino";
            txtNombreDestino.Size = new Size(260, 23);
            txtNombreDestino.TabIndex = 22;
            // 
            // lblCodigoIata
            // 
            lblCodigoIata.AutoSize = true;
            lblCodigoIata.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblCodigoIata.Location = new Point(500, 320);
            lblCodigoIata.Name = "lblCodigoIata";
            lblCodigoIata.Size = new Size(111, 15);
            lblCodigoIata.TabIndex = 23;
            lblCodigoIata.Text = "Código IATA (3 ltr):";
            // 
            // txtCodigoIata
            // 
            txtCodigoIata.Location = new Point(500, 340);
            txtCodigoIata.MaxLength = 3;
            txtCodigoIata.Name = "txtCodigoIata";
            txtCodigoIata.Size = new Size(100, 23);
            txtCodigoIata.TabIndex = 24;
            // 
            // lblIdCiudad
            // 
            lblIdCiudad.AutoSize = true;
            lblIdCiudad.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblIdCiudad.Location = new Point(620, 320);
            lblIdCiudad.Name = "lblIdCiudad";
            lblIdCiudad.Size = new Size(65, 15);
            lblIdCiudad.TabIndex = 25;
            lblIdCiudad.Text = "ID Ciudad:";
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Location = new Point(620, 340);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(100, 23);
            txtIdCiudad.TabIndex = 26;
            txtIdCiudad.Text = "1";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(192, 255, 192);
            btnInsertar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnInsertar.Location = new Point(500, 385);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(115, 32);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 192);
            btnModificar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(640, 385);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(115, 32);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(500, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 32);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.LightSkyBlue;
            btnRefrescar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnRefrescar.Location = new Point(640, 430);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(115, 32);
            btnRefrescar.TabIndex = 27;
            btnRefrescar.Text = "Listar Todo";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Destinos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(btnRefrescar);
            Controls.Add(txtIdCiudad);
            Controls.Add(lblIdCiudad);
            Controls.Add(txtCodigoIata);
            Controls.Add(lblCodigoIata);
            Controls.Add(txtNombreDestino);
            Controls.Add(lblNombreDestino);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(pnl1);
            Controls.Add(dgv1);
            Name = "Destinos";
            Text = "Destinos";
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Destinos_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
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
        private DataGridView dgv1;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private TextBox txtNombreDestino;
        private Label lblNombreDestino;
        private TextBox txtCodigoIata;
        private Label lblCodigoIata;
        private TextBox txtIdCiudad;
        private Label lblIdCiudad;
        private Button btnRefrescar;
    }
}