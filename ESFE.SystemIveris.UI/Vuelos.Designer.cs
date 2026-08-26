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
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnRefrescar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            txtNumeroVuelo = new TextBox();
            lblNumeroVuelo = new Label();
            txtOrigenId = new TextBox();
            lblOrigenId = new Label();
            txtDestinoId = new TextBox();
            lblDestinoId = new Label();
            txtAvionId = new TextBox();
            lblAvionId = new Label();
            dtpSalida = new DateTimePicker();
            lblSalida = new Label();
            dtpLlegada = new DateTimePicker();
            lblLlegada = new Label();
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
            pnl1.Dock = DockStyle.Top;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(822, 209);
            pnl1.TabIndex = 5;
            pnl1.Paint += pnl1_Paint;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(325, 17);
            pic1.Name = "pic1";
            pic1.Size = new Size(200, 113);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 12;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(590, 156);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(110, 34);
            btnDestinos.TabIndex = 17;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(145, 156);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(135, 34);
            btnMetodopago.TabIndex = 14;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.White;
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(295, 156);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(110, 34);
            btnReserva.TabIndex = 16;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.BackColor = Color.FromArgb(128, 255, 128);
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(420, 156);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(110, 34);
            btnVuelos.TabIndex = 15;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(20, 156);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(110, 34);
            btnInicio.TabIndex = 13;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(20, 227);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(490, 397);
            dgv1.TabIndex = 6;
            dgv1.CellClick += dgv1_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(720, 246);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(530, 550);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 36);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(192, 255, 192);
            btnInsertar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnInsertar.Location = new Point(530, 493);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(130, 36);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(255, 255, 192);
            btnModificar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(685, 493);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 36);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.LightSkyBlue;
            btnRefrescar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnRefrescar.Location = new Point(685, 550);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(130, 36);
            btnRefrescar.TabIndex = 32;
            btnRefrescar.Text = "Listar Todo";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(530, 247);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Núm. vuelo o destino";
            txtBuscar.Size = new Size(180, 25);
            txtBuscar.TabIndex = 19;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(530, 227);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(86, 15);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar Vuelo:";
            // 
            // txtNumeroVuelo
            // 
            txtNumeroVuelo.Location = new Point(530, 309);
            txtNumeroVuelo.Name = "txtNumeroVuelo";
            txtNumeroVuelo.Size = new Size(130, 25);
            txtNumeroVuelo.TabIndex = 21;
            // 
            // lblNumeroVuelo
            // 
            lblNumeroVuelo.AutoSize = true;
            lblNumeroVuelo.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblNumeroVuelo.Location = new Point(530, 289);
            lblNumeroVuelo.Name = "lblNumeroVuelo";
            lblNumeroVuelo.Size = new Size(107, 15);
            lblNumeroVuelo.TabIndex = 20;
            lblNumeroVuelo.Text = "Número de Vuelo:";
            // 
            // txtOrigenId
            // 
            txtOrigenId.Location = new Point(530, 372);
            txtOrigenId.Name = "txtOrigenId";
            txtOrigenId.Size = new Size(130, 25);
            txtOrigenId.TabIndex = 23;
            txtOrigenId.Text = "1";
            // 
            // lblOrigenId
            // 
            lblOrigenId.AutoSize = true;
            lblOrigenId.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblOrigenId.Location = new Point(530, 351);
            lblOrigenId.Name = "lblOrigenId";
            lblOrigenId.Size = new Size(113, 15);
            lblOrigenId.TabIndex = 22;
            lblOrigenId.Text = "ID Aeropto. Origen:";
            // 
            // txtDestinoId
            // 
            txtDestinoId.Location = new Point(680, 372);
            txtDestinoId.Name = "txtDestinoId";
            txtDestinoId.Size = new Size(130, 25);
            txtDestinoId.TabIndex = 25;
            txtDestinoId.Text = "2";
            // 
            // lblDestinoId
            // 
            lblDestinoId.AutoSize = true;
            lblDestinoId.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblDestinoId.Location = new Point(680, 351);
            lblDestinoId.Name = "lblDestinoId";
            lblDestinoId.Size = new Size(118, 15);
            lblDestinoId.TabIndex = 24;
            lblDestinoId.Text = "ID Aeropto. Destino:";
            // 
            // txtAvionId
            // 
            txtAvionId.Location = new Point(680, 309);
            txtAvionId.Name = "txtAvionId";
            txtAvionId.Size = new Size(130, 25);
            txtAvionId.TabIndex = 27;
            txtAvionId.Text = "1";
            // 
            // lblAvionId
            // 
            lblAvionId.AutoSize = true;
            lblAvionId.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblAvionId.Location = new Point(680, 289);
            lblAvionId.Name = "lblAvionId";
            lblAvionId.Size = new Size(55, 15);
            lblAvionId.TabIndex = 26;
            lblAvionId.Text = "ID Avión:";
            // 
            // dtpSalida
            // 
            dtpSalida.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpSalida.Format = DateTimePickerFormat.Custom;
            dtpSalida.Location = new Point(530, 434);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(135, 25);
            dtpSalida.TabIndex = 29;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblSalida.Location = new Point(530, 414);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(82, 15);
            lblSalida.TabIndex = 28;
            lblSalida.Text = "Fecha Salida:";
            // 
            // dtpLlegada
            // 
            dtpLlegada.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpLlegada.Format = DateTimePickerFormat.Custom;
            dtpLlegada.Location = new Point(680, 434);
            dtpLlegada.Name = "dtpLlegada";
            dtpLlegada.Size = new Size(135, 25);
            dtpLlegada.TabIndex = 31;
            // 
            // lblLlegada
            // 
            lblLlegada.AutoSize = true;
            lblLlegada.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblLlegada.Location = new Point(680, 414);
            lblLlegada.Name = "lblLlegada";
            lblLlegada.Size = new Size(92, 15);
            lblLlegada.TabIndex = 30;
            lblLlegada.Text = "Fecha Llegada:";
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 646);
            Controls.Add(btnRefrescar);
            Controls.Add(dtpLlegada);
            Controls.Add(lblLlegada);
            Controls.Add(dtpSalida);
            Controls.Add(lblSalida);
            Controls.Add(txtAvionId);
            Controls.Add(lblAvionId);
            Controls.Add(txtDestinoId);
            Controls.Add(lblDestinoId);
            Controls.Add(txtOrigenId);
            Controls.Add(lblOrigenId);
            Controls.Add(txtNumeroVuelo);
            Controls.Add(lblNumeroVuelo);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(dgv1);
            Controls.Add(pnl1);
            Name = "Vuelos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vuelos";
            WindowState = FormWindowState.Maximized;
            Load += Vuelos_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl1;
        private DataGridView dgv1;
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
        private Button btnRefrescar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private TextBox txtNumeroVuelo;
        private Label lblNumeroVuelo;
        private TextBox txtOrigenId;
        private Label lblOrigenId;
        private TextBox txtDestinoId;
        private Label lblDestinoId;
        private TextBox txtAvionId;
        private Label lblAvionId;
        private DateTimePicker dtpSalida;
        private Label lblSalida;
        private DateTimePicker dtpLlegada;
        private Label lblLlegada;
    }
}