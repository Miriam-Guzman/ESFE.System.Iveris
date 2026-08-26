namespace ESFE.SystemIveris.UI
{
    partial class MetododePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetododePago));
            pnl1 = new Panel();
            pnlNav = new Panel();
            btnInicio = new Button();
            btnMétodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnDestinos = new Button();
            pic1 = new PictureBox();
            pnlContent = new Panel();
            scMain = new SplitContainer();
            pnlFormCard = new Panel();
            lblmetododepago = new Label();
            panel2 = new Panel();
            btnO = new Button();
            lblTarjetaDevito = new Label();
            picimagen = new PictureBox();
            lblDatosTarj = new Label();
            lblNombreTitular = new Label();
            txtNomTitular = new TextBox();
            lblNumerodeTarjeta = new Label();
            txtnumeroTarjeta = new TextBox();
            lblFechaVencimiento = new Label();
            dtpFecha = new DateTimePicker();
            lblCCV = new Label();
            txtccv = new TextBox();
            lblDirecciònFatura = new Label();
            lblPais = new Label();
            cmbpaises = new ComboBox();
            lblCuidad = new Label();
            txtIngresacuidad = new TextBox();
            lblCodigoPostal = new Label();
            txt00000 = new TextBox();
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnConfirmarPago = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            pnlGridCard = new Panel();
            dgvPagos = new DataGridView();
            pnlTopGrid = new Panel();
            lblHistorial = new Label();
            btnRefrescarPagos = new Button();
            pnl1.SuspendLayout();
            pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scMain).BeginInit();
            scMain.Panel1.SuspendLayout();
            scMain.Panel2.SuspendLayout();
            scMain.SuspendLayout();
            pnlFormCard.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picimagen).BeginInit();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            pnlTopGrid.SuspendLayout();
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
            pnl1.TabIndex = 13;
            // 
            // pnlNav
            // 
            pnlNav.Anchor = AnchorStyles.Top;
            pnlNav.Controls.Add(btnInicio);
            pnlNav.Controls.Add(btnMétodopago);
            pnlNav.Controls.Add(btnReserva);
            pnlNav.Controls.Add(btnVuelos);
            pnlNav.Controls.Add(btnDestinos);
            pnlNav.Location = new Point(200, 110);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(750, 42);
            pnlNav.TabIndex = 10;
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
            // btnMétodopago
            // 
            btnMétodopago.BackColor = Color.FromArgb(128, 255, 128);
            btnMétodopago.Cursor = Cursors.Hand;
            btnMétodopago.FlatAppearance.BorderSize = 0;
            btnMétodopago.FlatStyle = FlatStyle.Flat;
            btnMétodopago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMétodopago.Location = new Point(155, 5);
            btnMétodopago.Name = "btnMétodopago";
            btnMétodopago.Size = new Size(140, 32);
            btnMétodopago.TabIndex = 1;
            btnMétodopago.Text = "MÉTODO DE PAGO";
            btnMétodopago.UseVisualStyleBackColor = false;
            btnMétodopago.Click += btnMétodopago_Click;
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
            btnReserva.TabIndex = 3;
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
            btnVuelos.TabIndex = 2;
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
            btnDestinos.TabIndex = 4;
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
            pic1.TabIndex = 5;
            pic1.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(scMain);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 160);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(15);
            pnlContent.Size = new Size(1150, 600);
            pnlContent.TabIndex = 14;
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
            scMain.Panel1MinSize = 480;
            // 
            // scMain.Panel2
            // 
            scMain.Panel2.Controls.Add(pnlGridCard);
            scMain.Panel2MinSize = 450;
            scMain.Size = new Size(1120, 570);
            scMain.SplitterDistance = 500;
            scMain.TabIndex = 0;
            // 
            // pnlFormCard
            // 
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFormCard.Controls.Add(lblmetododepago);
            pnlFormCard.Controls.Add(panel2);
            pnlFormCard.Controls.Add(lblDatosTarj);
            pnlFormCard.Controls.Add(lblNombreTitular);
            pnlFormCard.Controls.Add(txtNomTitular);
            pnlFormCard.Controls.Add(lblNumerodeTarjeta);
            pnlFormCard.Controls.Add(txtnumeroTarjeta);
            pnlFormCard.Controls.Add(lblFechaVencimiento);
            pnlFormCard.Controls.Add(dtpFecha);
            pnlFormCard.Controls.Add(lblCCV);
            pnlFormCard.Controls.Add(txtccv);
            pnlFormCard.Controls.Add(lblDirecciònFatura);
            pnlFormCard.Controls.Add(lblPais);
            pnlFormCard.Controls.Add(cmbpaises);
            pnlFormCard.Controls.Add(lblCuidad);
            pnlFormCard.Controls.Add(txtIngresacuidad);
            pnlFormCard.Controls.Add(lblCodigoPostal);
            pnlFormCard.Controls.Add(txt00000);
            pnlFormCard.Controls.Add(btnInsertar);
            pnlFormCard.Controls.Add(btnBuscar);
            pnlFormCard.Controls.Add(btnModificar);
            pnlFormCard.Controls.Add(btnEliminar);
            pnlFormCard.Controls.Add(btnConfirmarPago);
            pnlFormCard.Controls.Add(btnLimpiar);
            pnlFormCard.Controls.Add(btnCancelar);
            pnlFormCard.Dock = DockStyle.Fill;
            pnlFormCard.Location = new Point(0, 0);
            pnlFormCard.Name = "pnlFormCard";
            pnlFormCard.Padding = new Padding(15);
            pnlFormCard.Size = new Size(500, 570);
            pnlFormCard.TabIndex = 0;
            // 
            // lblmetododepago
            // 
            lblmetododepago.AutoSize = true;
            lblmetododepago.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblmetododepago.ForeColor = Color.FromArgb(40, 50, 120);
            lblmetododepago.Location = new Point(15, 10);
            lblmetododepago.Name = "lblmetododepago";
            lblmetododepago.Size = new Size(160, 25);
            lblmetododepago.TabIndex = 15;
            lblmetododepago.Text = "Proceso de Pago";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(240, 243, 248);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnO);
            panel2.Controls.Add(lblTarjetaDevito);
            panel2.Controls.Add(picimagen);
            panel2.Location = new Point(15, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 55);
            panel2.TabIndex = 14;
            // 
            // btnO
            // 
            btnO.BackColor = Color.White;
            btnO.Cursor = Cursors.Hand;
            btnO.FlatStyle = FlatStyle.Flat;
            btnO.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnO.Location = new Point(10, 10);
            btnO.Name = "btnO";
            btnO.Size = new Size(35, 35);
            btnO.TabIndex = 5;
            btnO.Text = "●";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnO_Click;
            // 
            // lblTarjetaDevito
            // 
            lblTarjetaDevito.AutoSize = true;
            lblTarjetaDevito.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTarjetaDevito.Location = new Point(110, 18);
            lblTarjetaDevito.Name = "lblTarjetaDevito";
            lblTarjetaDevito.Size = new Size(174, 19);
            lblTarjetaDevito.TabIndex = 6;
            lblTarjetaDevito.Text = "Tarjeta Crédito / Débito";
            // 
            // picimagen
            // 
            picimagen.BackColor = Color.Silver;
            picimagen.BorderStyle = BorderStyle.FixedSingle;
            picimagen.Image = (Image)resources.GetObject("picimagen.Image");
            picimagen.Location = new Point(53, 10);
            picimagen.Name = "picimagen";
            picimagen.Size = new Size(51, 35);
            picimagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picimagen.TabIndex = 5;
            picimagen.TabStop = false;
            // 
            // lblDatosTarj
            // 
            lblDatosTarj.AutoSize = true;
            lblDatosTarj.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDatosTarj.ForeColor = Color.FromArgb(41, 128, 185);
            lblDatosTarj.Location = new Point(15, 102);
            lblDatosTarj.Name = "lblDatosTarj";
            lblDatosTarj.Size = new Size(130, 19);
            lblDatosTarj.TabIndex = 18;
            lblDatosTarj.Text = "Datos de la Tarjeta";
            // 
            // lblNombreTitular
            // 
            lblNombreTitular.AutoSize = true;
            lblNombreTitular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreTitular.Location = new Point(15, 128);
            lblNombreTitular.Name = "lblNombreTitular";
            lblNombreTitular.Size = new Size(116, 15);
            lblNombreTitular.TabIndex = 19;
            lblNombreTitular.Text = "Nombre del Titular:";
            // 
            // txtNomTitular
            // 
            txtNomTitular.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomTitular.Location = new Point(15, 146);
            txtNomTitular.Name = "txtNomTitular";
            txtNomTitular.Size = new Size(465, 23);
            txtNomTitular.TabIndex = 20;
            // 
            // lblNumerodeTarjeta
            // 
            lblNumerodeTarjeta.AutoSize = true;
            lblNumerodeTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumerodeTarjeta.Location = new Point(15, 175);
            lblNumerodeTarjeta.Name = "lblNumerodeTarjeta";
            lblNumerodeTarjeta.Size = new Size(115, 15);
            lblNumerodeTarjeta.TabIndex = 25;
            lblNumerodeTarjeta.Text = "Número de Tarjeta:";
            // 
            // txtnumeroTarjeta
            // 
            txtnumeroTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtnumeroTarjeta.Location = new Point(15, 193);
            txtnumeroTarjeta.MaxLength = 19;
            txtnumeroTarjeta.Name = "txtnumeroTarjeta";
            txtnumeroTarjeta.PlaceholderText = "4000 1234 5678 9010";
            txtnumeroTarjeta.Size = new Size(465, 23);
            txtnumeroTarjeta.TabIndex = 26;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaVencimiento.Location = new Point(15, 225);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(115, 15);
            lblFechaVencimiento.TabIndex = 21;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "MM/yy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(15, 243);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(180, 23);
            dtpFecha.TabIndex = 22;
            // 
            // lblCCV
            // 
            lblCCV.AutoSize = true;
            lblCCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCCV.Location = new Point(220, 225);
            lblCCV.Name = "lblCCV";
            lblCCV.Size = new Size(67, 15);
            lblCCV.TabIndex = 23;
            lblCCV.Text = "CVV / CCV:";
            // 
            // txtccv
            // 
            txtccv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtccv.Location = new Point(220, 243);
            txtccv.MaxLength = 4;
            txtccv.Name = "txtccv";
            txtccv.Size = new Size(260, 23);
            txtccv.TabIndex = 24;
            txtccv.Text = "123";
            // 
            // lblDirecciònFatura
            // 
            lblDirecciònFatura.AutoSize = true;
            lblDirecciònFatura.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDirecciònFatura.ForeColor = Color.FromArgb(41, 128, 185);
            lblDirecciònFatura.Location = new Point(15, 275);
            lblDirecciònFatura.Name = "lblDirecciònFatura";
            lblDirecciònFatura.Size = new Size(174, 19);
            lblDirecciònFatura.TabIndex = 27;
            lblDirecciònFatura.Text = "Dirección de Facturación";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPais.Location = new Point(15, 300);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(32, 15);
            lblPais.TabIndex = 28;
            lblPais.Text = "País:";
            // 
            // cmbpaises
            // 
            cmbpaises.FormattingEnabled = true;
            cmbpaises.Location = new Point(15, 318);
            cmbpaises.Name = "cmbpaises";
            cmbpaises.Size = new Size(140, 23);
            cmbpaises.TabIndex = 29;
            // 
            // lblCuidad
            // 
            lblCuidad.AutoSize = true;
            lblCuidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCuidad.Location = new Point(170, 300);
            lblCuidad.Name = "lblCuidad";
            lblCuidad.Size = new Size(47, 15);
            lblCuidad.TabIndex = 30;
            lblCuidad.Text = "Ciudad:";
            // 
            // txtIngresacuidad
            // 
            txtIngresacuidad.Location = new Point(170, 318);
            txtIngresacuidad.Name = "txtIngresacuidad";
            txtIngresacuidad.PlaceholderText = "Ciudad";
            txtIngresacuidad.Size = new Size(150, 23);
            txtIngresacuidad.TabIndex = 31;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigoPostal.Location = new Point(335, 300);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(99, 15);
            lblCodigoPostal.TabIndex = 32;
            lblCodigoPostal.Text = "C.P. / ID de Pago:";
            // 
            // txt00000
            // 
            txt00000.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt00000.Location = new Point(335, 318);
            txt00000.Name = "txt00000";
            txt00000.Size = new Size(145, 23);
            txt00000.TabIndex = 33;
            txt00000.Text = "1";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(46, 204, 113);
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(15, 355);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 32);
            btnInsertar.TabIndex = 38;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(110, 355);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 32);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(205, 355);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 32);
            btnModificar.TabIndex = 39;
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
            btnEliminar.Location = new Point(300, 355);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 32);
            btnEliminar.TabIndex = 37;
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
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(395, 355);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 32);
            btnLimpiar.TabIndex = 40;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmarPago.BackColor = Color.FromArgb(41, 128, 185);
            btnConfirmarPago.Cursor = Cursors.Hand;
            btnConfirmarPago.FlatAppearance.BorderSize = 0;
            btnConfirmarPago.FlatStyle = FlatStyle.Flat;
            btnConfirmarPago.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConfirmarPago.ForeColor = Color.White;
            btnConfirmarPago.Location = new Point(15, 400);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(465, 42);
            btnConfirmarPago.TabIndex = 35;
            btnConfirmarPago.Text = "💳 CONFIRMAR Y PROCESAR PAGO";
            btnConfirmarPago.UseVisualStyleBackColor = false;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.LightGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.DimGray;
            btnCancelar.Location = new Point(15, 450);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(465, 35);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar y Volver al Inicio";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlGridCard
            // 
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.BorderStyle = BorderStyle.FixedSingle;
            pnlGridCard.Controls.Add(dgvPagos);
            pnlGridCard.Controls.Add(pnlTopGrid);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(15);
            pnlGridCard.Size = new Size(616, 570);
            pnlGridCard.TabIndex = 0;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagos.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Dock = DockStyle.Fill;
            dgvPagos.Location = new Point(15, 60);
            dgvPagos.MultiSelect = false;
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagos.Size = new Size(584, 493);
            dgvPagos.TabIndex = 1;
            dgvPagos.CellClick += dgvPagos_CellClick;
            // 
            // pnlTopGrid
            // 
            pnlTopGrid.Controls.Add(lblHistorial);
            pnlTopGrid.Controls.Add(btnRefrescarPagos);
            pnlTopGrid.Dock = DockStyle.Top;
            pnlTopGrid.Location = new Point(15, 15);
            pnlTopGrid.Name = "pnlTopGrid";
            pnlTopGrid.Size = new Size(584, 45);
            pnlTopGrid.TabIndex = 0;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHistorial.ForeColor = Color.FromArgb(40, 50, 120);
            lblHistorial.Location = new Point(0, 8);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(276, 25);
            lblHistorial.TabIndex = 0;
            lblHistorial.Text = "Historial de Pagos Registrados";
            // 
            // btnRefrescarPagos
            // 
            btnRefrescarPagos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescarPagos.BackColor = Color.FromArgb(46, 204, 113);
            btnRefrescarPagos.Cursor = Cursors.Hand;
            btnRefrescarPagos.FlatAppearance.BorderSize = 0;
            btnRefrescarPagos.FlatStyle = FlatStyle.Flat;
            btnRefrescarPagos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefrescarPagos.ForeColor = Color.White;
            btnRefrescarPagos.Location = new Point(474, 6);
            btnRefrescarPagos.Name = "btnRefrescarPagos";
            btnRefrescarPagos.Size = new Size(110, 30);
            btnRefrescarPagos.TabIndex = 1;
            btnRefrescarPagos.Text = "Actualizar Lista";
            btnRefrescarPagos.UseVisualStyleBackColor = false;
            btnRefrescarPagos.Click += btnRefrescarPagos_Click;
            // 
            // MetododePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1150, 760);
            Controls.Add(pnlContent);
            Controls.Add(pnl1);
            MinimumSize = new Size(950, 650);
            Name = "MetododePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Método de Pago - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += MetododePago_Load;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picimagen).EndInit();
            pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            pnlTopGrid.ResumeLayout(false);
            pnlTopGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private Panel pnlNav;
        private PictureBox pic1;
        private Button btnInicio;
        private Button btnMétodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnDestinos;
        private Panel pnlContent;
        private SplitContainer scMain;
        private Panel pnlFormCard;
        private Label lblmetododepago;
        private Panel panel2;
        private Button btnO;
        private Label lblTarjetaDevito;
        private PictureBox picimagen;
        private Label lblDatosTarj;
        private Label lblNombreTitular;
        private TextBox txtNomTitular;
        private Label lblNumerodeTarjeta;
        private TextBox txtnumeroTarjeta;
        private Label lblFechaVencimiento;
        private DateTimePicker dtpFecha;
        private Label lblCCV;
        private TextBox txtccv;
        private Label lblDirecciònFatura;
        private Label lblPais;
        private ComboBox cmbpaises;
        private Label lblCuidad;
        private TextBox txtIngresacuidad;
        private Label lblCodigoPostal;
        private TextBox txt00000;
        private Button btnInsertar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnConfirmarPago;
        private Button btnCancelar;
        private Panel pnlGridCard;
        private DataGridView dgvPagos;
        private Panel pnlTopGrid;
        private Label lblHistorial;
        private Button btnRefrescarPagos;
    }
}