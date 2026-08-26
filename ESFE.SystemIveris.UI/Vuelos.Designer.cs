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
            pnlNav = new Panel();
            btnInicio = new Button();
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnDestinos = new Button();
            pic1 = new PictureBox();
            pnlContent = new Panel();
            scMain = new SplitContainer();
            pnlGridCard = new Panel();
            dgv1 = new DataGridView();
            pnlSearch = new Panel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            lblTituloGrid = new Label();
            pnlFormCard = new Panel();
            lblTituloForm = new Label();
            lblNumeroVuelo = new Label();
            txtNumeroVuelo = new TextBox();
            lblAvionId = new Label();
            txtAvionId = new TextBox();
            lblOrigenId = new Label();
            txtOrigenId = new TextBox();
            lblDestinoId = new Label();
            txtDestinoId = new TextBox();
            lblSalida = new Label();
            dtpSalida = new DateTimePicker();
            lblLlegada = new Label();
            dtpLlegada = new DateTimePicker();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            pnl1.SuspendLayout();
            pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            pnlSearch.SuspendLayout();
            pnlFormCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(70, 90, 200);
            pnl1.Controls.Add(pnlNav);
            pnl1.Controls.Add(pic1);
            pnl1.Dock = DockStyle.Top;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(1150, 160);
            pnl1.TabIndex = 5;
            // 
            // pnlNav
            // 
            pnlNav.Anchor = AnchorStyles.Top;
            pnlNav.Controls.Add(btnInicio);
            pnlNav.Controls.Add(btnMetodopago);
            pnlNav.Controls.Add(btnReserva);
            pnlNav.Controls.Add(btnVuelos);
            pnlNav.Controls.Add(btnDestinos);
            pnlNav.Location = new Point(200, 110);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(750, 42);
            pnlNav.TabIndex = 18;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInicio.Location = new Point(10, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(130, 32);
            btnInicio.TabIndex = 13;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.BackColor = Color.White;
            btnMetodopago.Cursor = Cursors.Hand;
            btnMetodopago.FlatAppearance.BorderSize = 0;
            btnMetodopago.FlatStyle = FlatStyle.Flat;
            btnMetodopago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMetodopago.Location = new Point(155, 5);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(140, 32);
            btnMetodopago.TabIndex = 14;
            btnMetodopago.Text = "MÉTODO DE PAGO";
            btnMetodopago.UseVisualStyleBackColor = false;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.White;
            btnReserva.Cursor = Cursors.Hand;
            btnReserva.FlatAppearance.BorderSize = 0;
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReserva.Location = new Point(310, 5);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(130, 32);
            btnReserva.TabIndex = 16;
            btnReserva.Text = "RESERVAS";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.BackColor = Color.FromArgb(128, 255, 128);
            btnVuelos.Cursor = Cursors.Hand;
            btnVuelos.FlatAppearance.BorderSize = 0;
            btnVuelos.FlatStyle = FlatStyle.Flat;
            btnVuelos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVuelos.Location = new Point(455, 5);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(130, 32);
            btnVuelos.TabIndex = 15;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.BackColor = Color.White;
            btnDestinos.Cursor = Cursors.Hand;
            btnDestinos.FlatAppearance.BorderSize = 0;
            btnDestinos.FlatStyle = FlatStyle.Flat;
            btnDestinos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDestinos.Location = new Point(600, 5);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(130, 32);
            btnDestinos.TabIndex = 17;
            btnDestinos.Text = "DESTINOS";
            btnDestinos.UseVisualStyleBackColor = false;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // pic1
            // 
            pic1.Anchor = AnchorStyles.Top;
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(485, 10);
            pic1.Name = "pic1";
            pic1.Size = new Size(180, 90);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 12;
            pic1.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(scMain);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 160);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(15);
            pnlContent.Size = new Size(1150, 580);
            pnlContent.TabIndex = 6;
            // 
            // scMain
            // 
            scMain.Dock = DockStyle.Fill;
            scMain.FixedPanel = FixedPanel.Panel2;
            scMain.Location = new Point(15, 15);
            scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.Controls.Add(pnlGridCard);
            scMain.Panel1MinSize = 450;
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.AutoScroll = true;
            scMain.Panel2.Controls.Add(pnlFormCard);
            scMain.Panel2MinSize = 380;
            scMain.Size = new Size(1120, 550);
            scMain.SplitterDistance = 700;
            scMain.TabIndex = 0;
            // 
            // pnlGridCard
            // 
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(dgv1);
            pnlGridCard.Controls.Add(pnlSearch);
            pnlGridCard.Controls.Add(lblTituloGrid);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(700, 550);
            pnlGridCard.TabIndex = 0;
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Dock = DockStyle.Fill;
            dgv1.Location = new Point(15, 90);
            dgv1.MultiSelect = false;
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(668, 443);
            dgv1.TabIndex = 6;
            dgv1.CellClick += dgv1_CellClick;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtBuscar);
            pnlSearch.Controls.Add(btnBuscar);
            pnlSearch.Controls.Add(btnRefrescar);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(15, 50);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(668, 40);
            pnlSearch.TabIndex = 33;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(0, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por número de vuelo o destino...";
            txtBuscar.Size = new Size(454, 23);
            txtBuscar.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(464, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 28);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescar.BackColor = Color.FromArgb(46, 204, 113);
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(568, 5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 28);
            btnRefrescar.TabIndex = 32;
            btnRefrescar.Text = "Listar Todo";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblTituloGrid
            // 
            lblTituloGrid.AutoSize = true;
            lblTituloGrid.Dock = DockStyle.Top;
            lblTituloGrid.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloGrid.ForeColor = Color.FromArgb(40, 50, 120);
            lblTituloGrid.Location = new Point(15, 15);
            lblTituloGrid.Name = "lblTituloGrid";
            lblTituloGrid.Padding = new Padding(0, 0, 0, 10);
            lblTituloGrid.Size = new Size(276, 35);
            lblTituloGrid.TabIndex = 34;
            lblTituloGrid.Text = "Listado de Vuelos Programados";
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFormCard.Controls.Add(lblTituloForm);
            pnlFormCard.Controls.Add(lblNumeroVuelo);
            pnlFormCard.Controls.Add(txtNumeroVuelo);
            pnlFormCard.Controls.Add(lblAvionId);
            pnlFormCard.Controls.Add(txtAvionId);
            pnlFormCard.Controls.Add(lblOrigenId);
            pnlFormCard.Controls.Add(txtOrigenId);
            pnlFormCard.Controls.Add(lblDestinoId);
            pnlFormCard.Controls.Add(txtDestinoId);
            pnlFormCard.Controls.Add(lblSalida);
            pnlFormCard.Controls.Add(dtpSalida);
            pnlFormCard.Controls.Add(lblLlegada);
            pnlFormCard.Controls.Add(dtpLlegada);
            pnlFormCard.Controls.Add(btnInsertar);
            pnlFormCard.Controls.Add(btnModificar);
            pnlFormCard.Controls.Add(btnEliminar);
            pnlFormCard.Controls.Add(btnLimpiar);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(0, 0);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(20);
            pnlFormCard.Size = new Size(416, 550);
            pnlFormCard.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.FromArgb(40, 50, 120);
            lblTituloForm.Location = new Point(20, 15);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(169, 25);
            lblTituloForm.TabIndex = 33;
            lblTituloForm.Text = "Gestión de Vuelos";
            // 
            // lblNumeroVuelo
            // 
            lblNumeroVuelo.AutoSize = true;
            lblNumeroVuelo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroVuelo.Location = new Point(20, 55);
            lblNumeroVuelo.Name = "lblNumeroVuelo";
            lblNumeroVuelo.Size = new Size(107, 15);
            lblNumeroVuelo.TabIndex = 20;
            lblNumeroVuelo.Text = "Número de Vuelo:";
            // 
            // txtNumeroVuelo
            // 
            txtNumeroVuelo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumeroVuelo.Location = new Point(20, 75);
            txtNumeroVuelo.Name = "txtNumeroVuelo";
            txtNumeroVuelo.PlaceholderText = "Ejemplo: IV-501";
            txtNumeroVuelo.Size = new Size(374, 23);
            txtNumeroVuelo.TabIndex = 21;
            // 
            // lblAvionId
            // 
            lblAvionId.AutoSize = true;
            lblAvionId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvionId.Location = new Point(20, 110);
            lblAvionId.Name = "lblAvionId";
            lblAvionId.Size = new Size(57, 15);
            lblAvionId.TabIndex = 26;
            lblAvionId.Text = "ID Avión:";
            // 
            // txtAvionId
            // 
            txtAvionId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAvionId.Location = new Point(20, 130);
            txtAvionId.Name = "txtAvionId";
            txtAvionId.Size = new Size(374, 23);
            txtAvionId.TabIndex = 27;
            txtAvionId.Text = "1";
            // 
            // lblOrigenId
            // 
            lblOrigenId.AutoSize = true;
            lblOrigenId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrigenId.Location = new Point(20, 165);
            lblOrigenId.Name = "lblOrigenId";
            lblOrigenId.Size = new Size(113, 15);
            lblOrigenId.TabIndex = 22;
            lblOrigenId.Text = "ID Aeropto. Origen:";
            // 
            // txtOrigenId
            // 
            txtOrigenId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrigenId.Location = new Point(20, 185);
            txtOrigenId.Name = "txtOrigenId";
            txtOrigenId.Size = new Size(374, 23);
            txtOrigenId.TabIndex = 23;
            txtOrigenId.Text = "1";
            // 
            // lblDestinoId
            // 
            lblDestinoId.AutoSize = true;
            lblDestinoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestinoId.Location = new Point(20, 220);
            lblDestinoId.Name = "lblDestinoId";
            lblDestinoId.Size = new Size(118, 15);
            lblDestinoId.TabIndex = 24;
            lblDestinoId.Text = "ID Aeropto. Destino:";
            // 
            // txtDestinoId
            // 
            txtDestinoId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDestinoId.Location = new Point(20, 240);
            txtDestinoId.Name = "txtDestinoId";
            txtDestinoId.Size = new Size(374, 23);
            txtDestinoId.TabIndex = 25;
            txtDestinoId.Text = "2";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalida.Location = new Point(20, 275);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(79, 15);
            lblSalida.TabIndex = 28;
            lblSalida.Text = "Fecha Salida:";
            // 
            // dtpSalida
            // 
            dtpSalida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpSalida.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpSalida.Format = DateTimePickerFormat.Custom;
            dtpSalida.Location = new Point(20, 295);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(374, 23);
            dtpSalida.TabIndex = 29;
            // 
            // lblLlegada
            // 
            lblLlegada.AutoSize = true;
            lblLlegada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLlegada.Location = new Point(20, 330);
            lblLlegada.Name = "lblLlegada";
            lblLlegada.Size = new Size(89, 15);
            lblLlegada.TabIndex = 30;
            lblLlegada.Text = "Fecha Llegada:";
            // 
            // dtpLlegada
            // 
            dtpLlegada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpLlegada.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpLlegada.Format = DateTimePickerFormat.Custom;
            dtpLlegada.Location = new Point(20, 350);
            dtpLlegada.Name = "dtpLlegada";
            dtpLlegada.Size = new Size(374, 23);
            dtpLlegada.TabIndex = 31;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnInsertar.BackColor = Color.FromArgb(46, 204, 113);
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(20, 400);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(175, 38);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(219, 400);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(175, 38);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(20, 455);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(175, 38);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(219, 455);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 38);
            btnLimpiar.TabIndex = 34;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Vuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1150, 740);
            Controls.Add(pnlContent);
            Controls.Add(pnl1);
            MinimumSize = new Size(950, 650);
            Name = "Vuelos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Vuelos - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += Vuelos_Load;
            pnl1.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            pnlContent.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlFormCard.ResumeLayout(false);
            pnlFormCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private Panel pnlNav;
        private PictureBox pic1;
        private Button btnDestinos;
        private Button btnMetodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnInicio;
        private Panel pnlContent;
        private SplitContainer scMain;
        private Panel pnlGridCard;
        private DataGridView dgv1;
        private Panel pnlSearch;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnRefrescar;
        private Label lblTituloGrid;
        private Panel pnlFormCard;
        private Label lblTituloForm;
        private Label lblNumeroVuelo;
        private TextBox txtNumeroVuelo;
        private Label lblAvionId;
        private TextBox txtAvionId;
        private Label lblOrigenId;
        private TextBox txtOrigenId;
        private Label lblDestinoId;
        private TextBox txtDestinoId;
        private Label lblSalida;
        private DateTimePicker dtpSalida;
        private Label lblLlegada;
        private DateTimePicker dtpLlegada;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}