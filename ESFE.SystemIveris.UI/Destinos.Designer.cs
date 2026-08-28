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
            lblNombreDestino = new Label();
            cboNombreDestino = new ComboBox();
            lblCodigoIata = new Label();
            txtCodigoIata = new TextBox();
            lblIdCiudad = new Label();
            txtIdCiudad = new TextBox();
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
            pnl1.TabIndex = 14;
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
            pnlNav.TabIndex = 12;
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
            btnInicio.TabIndex = 7;
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
            btnMetodopago.TabIndex = 8;
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
            btnReserva.TabIndex = 10;
            btnReserva.Text = "RESERVAS";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.BackColor = Color.White;
            btnVuelos.Cursor = Cursors.Hand;
            btnVuelos.FlatAppearance.BorderSize = 0;
            btnVuelos.FlatStyle = FlatStyle.Flat;
            btnVuelos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVuelos.Location = new Point(455, 5);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(130, 32);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.BackColor = Color.FromArgb(128, 255, 128);
            btnDestinos.Cursor = Cursors.Hand;
            btnDestinos.FlatAppearance.BorderSize = 0;
            btnDestinos.FlatStyle = FlatStyle.Flat;
            btnDestinos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDestinos.Location = new Point(600, 5);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(130, 32);
            btnDestinos.TabIndex = 11;
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
            pic1.TabIndex = 6;
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
            pnlContent.TabIndex = 15;
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
            scMain.SplitterDistance = 710;
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
            pnlGridCard.Size = new Size(710, 550);
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
            dgv1.Size = new Size(678, 443);
            dgv1.TabIndex = 13;
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
            pnlSearch.Size = new Size(678, 40);
            pnlSearch.TabIndex = 28;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(0, 8);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por ciudad, aeropuerto, código IATA o número de vuelo...";
            txtBuscar.Size = new Size(464, 23);
            txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(474, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 28);
            btnBuscar.TabIndex = 18;
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
            btnRefrescar.Location = new Point(578, 5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 28);
            btnRefrescar.TabIndex = 27;
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
            lblTituloGrid.Size = new Size(272, 35);
            lblTituloGrid.TabIndex = 29;
            lblTituloGrid.Text = "Destinos y Rutas Disponibles";
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFormCard.Controls.Add(lblTituloForm);
            pnlFormCard.Controls.Add(lblNombreDestino);
            pnlFormCard.Controls.Add(cboNombreDestino);
            pnlFormCard.Controls.Add(lblCodigoIata);
            pnlFormCard.Controls.Add(txtCodigoIata);
            pnlFormCard.Controls.Add(lblIdCiudad);
            pnlFormCard.Controls.Add(txtIdCiudad);
            pnlFormCard.Controls.Add(btnInsertar);
            pnlFormCard.Controls.Add(btnModificar);
            pnlFormCard.Controls.Add(btnEliminar);
            pnlFormCard.Controls.Add(btnLimpiar);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(0, 0);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(20);
            pnlFormCard.Size = new Size(406, 550);
            pnlFormCard.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.FromArgb(40, 50, 120);
            lblTituloForm.Location = new Point(20, 15);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(276, 25);
            lblTituloForm.TabIndex = 28;
            lblTituloForm.Text = "Gestión de Destino / Aeropuerto";
            // 
            // lblNombreDestino
            // 
            lblNombreDestino.AutoSize = true;
            lblNombreDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreDestino.Location = new Point(20, 65);
            lblNombreDestino.Name = "lblNombreDestino";
            lblNombreDestino.Size = new Size(141, 15);
            lblNombreDestino.TabIndex = 21;
            lblNombreDestino.Text = "Nombre del Aeropuerto:";
            // 
            // cboNombreDestino
            // 
            cboNombreDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboNombreDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNombreDestino.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboNombreDestino.FormattingEnabled = true;
            cboNombreDestino.Location = new Point(20, 85);
            cboNombreDestino.Name = "cboNombreDestino";
            cboNombreDestino.Size = new Size(364, 23);
            cboNombreDestino.TabIndex = 22;
            // 
            // lblCodigoIata
            // 
            lblCodigoIata.AutoSize = true;
            lblCodigoIata.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigoIata.Location = new Point(20, 125);
            lblCodigoIata.Name = "lblCodigoIata";
            lblCodigoIata.Size = new Size(116, 15);
            lblCodigoIata.TabIndex = 23;
            lblCodigoIata.Text = "Código IATA (3 ltr):";
            // 
            // txtCodigoIata
            // 
            txtCodigoIata.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoIata.CharacterCasing = CharacterCasing.Upper;
            txtCodigoIata.Location = new Point(20, 145);
            txtCodigoIata.MaxLength = 3;
            txtCodigoIata.Name = "txtCodigoIata";
            txtCodigoIata.Size = new Size(364, 23);
            txtCodigoIata.TabIndex = 24;
            // 
            // lblIdCiudad
            // 
            lblIdCiudad.AutoSize = true;
            lblIdCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdCiudad.Location = new Point(20, 185);
            lblIdCiudad.Name = "lblIdCiudad";
            lblIdCiudad.Size = new Size(130, 15);
            lblIdCiudad.TabIndex = 25;
            lblIdCiudad.Text = "ID Ciudad / Ubicación:";
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdCiudad.Location = new Point(20, 205);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.Size = new Size(364, 23);
            txtIdCiudad.TabIndex = 26;
            txtIdCiudad.Text = "1";
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
            btnInsertar.Location = new Point(20, 260);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(170, 38);
            btnInsertar.TabIndex = 15;
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
            btnModificar.Location = new Point(214, 260);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 38);
            btnModificar.TabIndex = 17;
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
            btnEliminar.Location = new Point(20, 315);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 38);
            btnEliminar.TabIndex = 16;
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
            btnLimpiar.Location = new Point(214, 315);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 38);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Destinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1150, 740);
            Controls.Add(pnlContent);
            Controls.Add(pnl1);
            MinimumSize = new Size(950, 650);
            Name = "Destinos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Destinos - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += Destinos_Load;
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
        private Label lblNombreDestino;
        private ComboBox cboNombreDestino;
        private Label lblCodigoIata;
        private TextBox txtCodigoIata;
        private Label lblIdCiudad;
        private TextBox txtIdCiudad;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}