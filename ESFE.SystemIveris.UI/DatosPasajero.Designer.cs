namespace ESFE.SystemIveris.UI
{
    partial class DatosPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPasajero));
            pnl1 = new Panel();
            pnlNav = new Panel();
            btnInicio = new Button();
            btnMetodopago = new Button();
            btnReservas = new Button();
            btnVuelos = new Button();
            btndestinos = new Button();
            pic1 = new PictureBox();
            pnlContent = new Panel();
            scMain = new SplitContainer();
            pnlFormCard = new Panel();
            lblDastospasajero = new Label();
            lblNombres = new Label();
            txt1 = new TextBox();
            lblApellidos = new Label();
            txt2 = new TextBox();
            lblfechanacimiento = new Label();
            dtp1 = new DateTimePicker();
            lblnacionalidad = new Label();
            txt3 = new TextBox();
            lblNumeroPasaporteDui = new Label();
            txt4 = new TextBox();
            lblCorreoElectro = new Label();
            txt5 = new TextBox();
            lblNumeroTelefon = new Label();
            txt6 = new TextBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btncontinuar = new Button();
            pnlGridCard = new Panel();
            lblListaPasajeros = new Label();
            pnlSearch = new Panel();
            txtBuscar = new TextBox();
            btnBuscarGrid = new Button();
            btnRefrescar = new Button();
            dgvPasajeros = new DataGridView();
            pnl1.SuspendLayout();
            pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            pnlFormCard.SuspendLayout();
            pnlGridCard.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).BeginInit();
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
            pnl1.TabIndex = 22;
            // 
            // pnlNav
            // 
            pnlNav.Anchor = AnchorStyles.Top;
            pnlNav.Controls.Add(btnInicio);
            pnlNav.Controls.Add(btnMetodopago);
            pnlNav.Controls.Add(btnReservas);
            pnlNav.Controls.Add(btnVuelos);
            pnlNav.Controls.Add(btndestinos);
            pnlNav.Location = new Point(200, 110);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(750, 42);
            pnlNav.TabIndex = 13;
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
            btnInicio.TabIndex = 0;
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
            btnMetodopago.TabIndex = 1;
            btnMetodopago.Text = "MÉTODO DE PAGO";
            btnMetodopago.UseVisualStyleBackColor = false;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(128, 255, 128);
            btnReservas.Cursor = Cursors.Hand;
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReservas.Location = new Point(310, 5);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(130, 32);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "RESERVAS";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
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
            btnVuelos.TabIndex = 2;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btndestinos
            // 
            btndestinos.BackColor = Color.White;
            btndestinos.Cursor = Cursors.Hand;
            btndestinos.FlatAppearance.BorderSize = 0;
            btndestinos.FlatStyle = FlatStyle.Flat;
            btndestinos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndestinos.Location = new Point(600, 5);
            btndestinos.Name = "btndestinos";
            btndestinos.Size = new Size(130, 32);
            btndestinos.TabIndex = 4;
            btndestinos.Text = "DESTINOS";
            btndestinos.UseVisualStyleBackColor = false;
            btndestinos.Click += btndestinos_Click;
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
            pic1.TabIndex = 21;
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
            pnlContent.TabIndex = 23;
            // 
            // scMain
            // 
            scMain.Dock = DockStyle.Fill;
            scMain.FixedPanel = FixedPanel.Panel1;
            scMain.Location = new Point(15, 15);
            scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            scMain.Panel1.AutoScroll = true;
            scMain.Panel1.Controls.Add(pnlFormCard);
            scMain.Panel1MinSize = 420;
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(pnlGridCard);
            scMain.Panel2MinSize = 450;
            scMain.Size = new Size(1120, 550);
            scMain.SplitterDistance = 460;
            scMain.TabIndex = 0;
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFormCard.Controls.Add(lblDastospasajero);
            pnlFormCard.Controls.Add(lblNombres);
            pnlFormCard.Controls.Add(txt1);
            pnlFormCard.Controls.Add(lblApellidos);
            pnlFormCard.Controls.Add(txt2);
            pnlFormCard.Controls.Add(lblfechanacimiento);
            pnlFormCard.Controls.Add(dtp1);
            pnlFormCard.Controls.Add(lblnacionalidad);
            pnlFormCard.Controls.Add(txt3);
            pnlFormCard.Controls.Add(lblNumeroPasaporteDui);
            pnlFormCard.Controls.Add(txt4);
            pnlFormCard.Controls.Add(lblCorreoElectro);
            pnlFormCard.Controls.Add(txt5);
            pnlFormCard.Controls.Add(lblNumeroTelefon);
            pnlFormCard.Controls.Add(txt6);
            pnlFormCard.Controls.Add(btnInsertar);
            pnlFormCard.Controls.Add(btnModificar);
            pnlFormCard.Controls.Add(btnEliminar);
            pnlFormCard.Controls.Add(btnBuscar);
            pnlFormCard.Controls.Add(btnLimpiar);
            pnlFormCard.Controls.Add(btncontinuar);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(0, 0);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(15);
            pnlFormCard.Size = new Size(460, 550);
            pnlFormCard.TabIndex = 0;
            // 
            // lblDastospasajero
            // 
            lblDastospasajero.AutoSize = true;
            lblDastospasajero.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDastospasajero.ForeColor = Color.FromArgb(40, 50, 120);
            lblDastospasajero.Location = new Point(15, 10);
            lblDastospasajero.Name = "lblDastospasajero";
            lblDastospasajero.Size = new Size(168, 25);
            lblDastospasajero.TabIndex = 5;
            lblDastospasajero.Text = "Datos del Pasajero";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombres.Location = new Point(15, 45);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(61, 15);
            lblNombres.TabIndex = 12;
            lblNombres.Text = "Nombres:";
            // 
            // txt1
            // 
            txt1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt1.Location = new Point(15, 63);
            txt1.Name = "txt1";
            txt1.Size = new Size(425, 23);
            txt1.TabIndex = 14;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidos.Location = new Point(15, 93);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(60, 15);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos:";
            // 
            // txt2
            // 
            txt2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt2.Location = new Point(15, 111);
            txt2.Name = "txt2";
            txt2.Size = new Size(425, 23);
            txt2.TabIndex = 15;
            // 
            // lblfechanacimiento
            // 
            lblfechanacimiento.AutoSize = true;
            lblfechanacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblfechanacimiento.Location = new Point(15, 141);
            lblfechanacimiento.Name = "lblfechanacimiento";
            lblfechanacimiento.Size = new Size(126, 15);
            lblfechanacimiento.TabIndex = 7;
            lblfechanacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtp1
            // 
            dtp1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(15, 159);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(425, 23);
            dtp1.TabIndex = 13;
            // 
            // lblnacionalidad
            // 
            lblnacionalidad.AutoSize = true;
            lblnacionalidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblnacionalidad.Location = new Point(15, 189);
            lblnacionalidad.Name = "lblnacionalidad";
            lblnacionalidad.Size = new Size(130, 15);
            lblnacionalidad.TabIndex = 8;
            lblnacionalidad.Text = "ID Ciudad / Ubicación:";
            // 
            // txt3
            // 
            txt3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt3.Location = new Point(15, 207);
            txt3.Name = "txt3";
            txt3.Size = new Size(425, 23);
            txt3.TabIndex = 16;
            txt3.Text = "1";
            // 
            // lblNumeroPasaporteDui
            // 
            lblNumeroPasaporteDui.AutoSize = true;
            lblNumeroPasaporteDui.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroPasaporteDui.Location = new Point(15, 237);
            lblNumeroPasaporteDui.Name = "lblNumeroPasaporteDui";
            lblNumeroPasaporteDui.Size = new Size(166, 15);
            lblNumeroPasaporteDui.TabIndex = 9;
            lblNumeroPasaporteDui.Text = "Número de Pasaporte o DUI:";
            // 
            // txt4
            // 
            txt4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt4.Location = new Point(15, 255);
            txt4.Name = "txt4";
            txt4.Size = new Size(425, 23);
            txt4.TabIndex = 17;
            // 
            // lblCorreoElectro
            // 
            lblCorreoElectro.AutoSize = true;
            lblCorreoElectro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreoElectro.Location = new Point(15, 285);
            lblCorreoElectro.Name = "lblCorreoElectro";
            lblCorreoElectro.Size = new Size(113, 15);
            lblCorreoElectro.TabIndex = 10;
            lblCorreoElectro.Text = "Correo Electrónico:";
            // 
            // txt5
            // 
            txt5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt5.Location = new Point(15, 303);
            txt5.Name = "txt5";
            txt5.Size = new Size(425, 23);
            txt5.TabIndex = 18;
            // 
            // lblNumeroTelefon
            // 
            lblNumeroTelefon.AutoSize = true;
            lblNumeroTelefon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroTelefon.Location = new Point(15, 333);
            lblNumeroTelefon.Name = "lblNumeroTelefon";
            lblNumeroTelefon.Size = new Size(123, 15);
            lblNumeroTelefon.TabIndex = 11;
            lblNumeroTelefon.Text = "Número de Teléfono:";
            // 
            // txt6
            // 
            txt6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt6.Location = new Point(15, 351);
            txt6.Name = "txt6";
            txt6.Size = new Size(425, 23);
            txt6.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(15, 390);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 32);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(46, 204, 113);
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(102, 390);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(80, 32);
            btnInsertar.TabIndex = 23;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(189, 390);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 32);
            btnModificar.TabIndex = 25;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(276, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 32);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightGray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(363, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 32);
            btnLimpiar.TabIndex = 27;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btncontinuar
            // 
            btncontinuar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btncontinuar.BackColor = Color.FromArgb(41, 128, 185);
            btncontinuar.Cursor = Cursors.Hand;
            btncontinuar.FlatAppearance.BorderSize = 0;
            btncontinuar.FlatStyle = FlatStyle.Flat;
            btncontinuar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btncontinuar.ForeColor = Color.White;
            btncontinuar.Location = new Point(15, 435);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(425, 40);
            btncontinuar.TabIndex = 20;
            btncontinuar.Text = "CONTINUAR AL PAGO →";
            btncontinuar.UseVisualStyleBackColor = false;
            btncontinuar.Click += btncontinuar_Click;
            // 
            // pnlGridCard
            // 
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(dgvPasajeros);
            pnlGridCard.Controls.Add(pnlSearch);
            pnlGridCard.Controls.Add(lblListaPasajeros);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(656, 550);
            pnlGridCard.TabIndex = 0;
            // 
            // lblListaPasajeros
            // 
            lblListaPasajeros.AutoSize = true;
            lblListaPasajeros.Dock = DockStyle.Top;
            lblListaPasajeros.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblListaPasajeros.ForeColor = Color.FromArgb(40, 50, 120);
            lblListaPasajeros.Location = new Point(15, 15);
            lblListaPasajeros.Name = "lblListaPasajeros";
            lblListaPasajeros.Padding = new Padding(0, 0, 0, 10);
            lblListaPasajeros.Size = new Size(207, 35);
            lblListaPasajeros.TabIndex = 0;
            lblListaPasajeros.Text = "Pasajeros Registrados";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtBuscar);
            pnlSearch.Controls.Add(btnBuscarGrid);
            pnlSearch.Controls.Add(btnRefrescar);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(15, 50);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(624, 40);
            pnlSearch.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(0, 7);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, apellido, pasaporte o ID...";
            txtBuscar.Size = new Size(410, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscarGrid
            // 
            btnBuscarGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarGrid.BackColor = Color.LightSkyBlue;
            btnBuscarGrid.Cursor = Cursors.Hand;
            btnBuscarGrid.FlatAppearance.BorderSize = 0;
            btnBuscarGrid.FlatStyle = FlatStyle.Flat;
            btnBuscarGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarGrid.Location = new Point(420, 5);
            btnBuscarGrid.Name = "btnBuscarGrid";
            btnBuscarGrid.Size = new Size(95, 28);
            btnBuscarGrid.TabIndex = 1;
            btnBuscarGrid.Text = "Buscar";
            btnBuscarGrid.UseVisualStyleBackColor = false;
            btnBuscarGrid.Click += btnBuscarGrid_Click;
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
            btnRefrescar.Location = new Point(524, 5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(100, 28);
            btnRefrescar.TabIndex = 2;
            btnRefrescar.Text = "Listar Todo";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvPasajeros
            // 
            dgvPasajeros.AllowUserToAddRows = false;
            dgvPasajeros.AllowUserToDeleteRows = false;
            dgvPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasajeros.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajeros.Dock = DockStyle.Fill;
            dgvPasajeros.Location = new Point(15, 90);
            dgvPasajeros.MultiSelect = false;
            dgvPasajeros.Name = "dgvPasajeros";
            dgvPasajeros.ReadOnly = true;
            dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasajeros.Size = new Size(624, 443);
            dgvPasajeros.TabIndex = 2;
            dgvPasajeros.CellClick += dgvPasajeros_CellClick;
            // 
            // DatosPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1150, 740);
            Controls.Add(pnlContent);
            Controls.Add(pnl1);
            MinimumSize = new Size(950, 650);
            Name = "DatosPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pasajeros - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += DatosPasajero_Load;
            pnl1.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            pnlContent.ResumeLayout(false);
            scMain.Panel1.ResumeLayout(false);
            scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scMain).EndInit();
            scMain.ResumeLayout(false);
            pnlFormCard.ResumeLayout(false);
            pnlFormCard.PerformLayout();
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private Panel pnlNav;
        private PictureBox pic1;
        private Button btnInicio;
        private Button btnMetodopago;
        private Button btnReservas;
        private Button btnVuelos;
        private Button btndestinos;
        private Panel pnlContent;
        private SplitContainer scMain;
        private Panel pnlFormCard;
        private Label lblDastospasajero;
        private Label lblNombres;
        private TextBox txt1;
        private Label lblApellidos;
        private TextBox txt2;
        private Label lblfechanacimiento;
        private DateTimePicker dtp1;
        private Label lblnacionalidad;
        private TextBox txt3;
        private Label lblNumeroPasaporteDui;
        private TextBox txt4;
        private Label lblCorreoElectro;
        private TextBox txt5;
        private Label lblNumeroTelefon;
        private TextBox txt6;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btncontinuar;
        private Panel pnlGridCard;
        private Label lblListaPasajeros;
        private Panel pnlSearch;
        private TextBox txtBuscar;
        private Button btnBuscarGrid;
        private Button btnRefrescar;
        private DataGridView dgvPasajeros;
    }
}