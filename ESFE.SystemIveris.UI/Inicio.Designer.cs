namespace ESFE.SystemIveris.UI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pnl1 = new Panel();
            pnlNav = new Panel();
            btnInicio = new Button();
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnDestinos = new Button();
            pic1 = new PictureBox();
            pnlMain = new Panel();
            pnlCenter = new Panel();
            pictureBox2 = new PictureBox();
            lblBienvenida = new Label();
            lblSubtitulo = new Label();
            pnlCards = new FlowLayoutPanel();
            btnCardPasajeros = new Button();
            btnCardVuelos = new Button();
            btnCardDestinos = new Button();
            btnCardPagos = new Button();
            btnCardReservas = new Button();
            lnksalirapp = new LinkLabel();
            pnl1.SuspendLayout();
            pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnlMain.SuspendLayout();
            pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlCards.SuspendLayout();
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
            pnl1.Size = new Size(1100, 160);
            pnl1.TabIndex = 17;
            // 
            // pnlNav
            // 
            pnlNav.Anchor = AnchorStyles.Top;
            pnlNav.Controls.Add(btnInicio);
            pnlNav.Controls.Add(btnMetodopago);
            pnlNav.Controls.Add(btnReserva);
            pnlNav.Controls.Add(btnVuelos);
            pnlNav.Controls.Add(btnDestinos);
            pnlNav.Location = new Point(175, 110);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(750, 42);
            pnlNav.TabIndex = 12;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(128, 255, 128);
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
            btnDestinos.BackColor = Color.White;
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
            pic1.Location = new Point(460, 10);
            pic1.Name = "pic1";
            pic1.Size = new Size(180, 90);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(pnlCenter);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 160);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1100, 560);
            pnlMain.TabIndex = 18;
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.Top;
            pnlCenter.Controls.Add(pictureBox2);
            pnlCenter.Controls.Add(lblBienvenida);
            pnlCenter.Controls.Add(lblSubtitulo);
            pnlCenter.Controls.Add(pnlCards);
            pnlCenter.Controls.Add(lnksalirapp);
            pnlCenter.Location = new Point(100, 15);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(900, 530);
            pnlCenter.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(250, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(40, 50, 120);
            lblBienvenida.Location = new Point(0, 215);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(900, 35);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido al Sistema de Gestión de Aerolíneas Iveris";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(0, 252);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(900, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Selecciona un módulo del menú superior o accede a las opciones rápidas:";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCards
            // 
            pnlCards.Anchor = AnchorStyles.Top;
            pnlCards.Controls.Add(btnCardPasajeros);
            pnlCards.Controls.Add(btnCardVuelos);
            pnlCards.Controls.Add(btnCardDestinos);
            pnlCards.Controls.Add(btnCardPagos);
            pnlCards.Controls.Add(btnCardReservas);
            pnlCards.FlowDirection = FlowDirection.LeftToRight;
            pnlCards.Location = new Point(45, 290);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(810, 160);
            pnlCards.TabIndex = 21;
            // 
            // btnCardPasajeros
            // 
            btnCardPasajeros.BackColor = Color.FromArgb(52, 152, 219);
            btnCardPasajeros.Cursor = Cursors.Hand;
            btnCardPasajeros.FlatAppearance.BorderSize = 0;
            btnCardPasajeros.FlatStyle = FlatStyle.Flat;
            btnCardPasajeros.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCardPasajeros.ForeColor = Color.White;
            btnCardPasajeros.Location = new Point(10, 10);
            btnCardPasajeros.Margin = new Padding(10);
            btnCardPasajeros.Name = "btnCardPasajeros";
            btnCardPasajeros.Size = new Size(240, 60);
            btnCardPasajeros.TabIndex = 0;
            btnCardPasajeros.Text = "👤 Gestión de Pasajeros";
            btnCardPasajeros.UseVisualStyleBackColor = false;
            btnCardPasajeros.Click += btnDatosPasajero_Click;
            // 
            // btnCardVuelos
            // 
            btnCardVuelos.BackColor = Color.FromArgb(46, 204, 113);
            btnCardVuelos.Cursor = Cursors.Hand;
            btnCardVuelos.FlatAppearance.BorderSize = 0;
            btnCardVuelos.FlatStyle = FlatStyle.Flat;
            btnCardVuelos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCardVuelos.ForeColor = Color.White;
            btnCardVuelos.Location = new Point(280, 10);
            btnCardVuelos.Margin = new Padding(10);
            btnCardVuelos.Name = "btnCardVuelos";
            btnCardVuelos.Size = new Size(240, 60);
            btnCardVuelos.TabIndex = 1;
            btnCardVuelos.Text = "✈️ Control de Vuelos";
            btnCardVuelos.UseVisualStyleBackColor = false;
            btnCardVuelos.Click += btnVuelos_Click;
            // 
            // btnCardDestinos
            // 
            btnCardDestinos.BackColor = Color.FromArgb(155, 89, 182);
            btnCardDestinos.Cursor = Cursors.Hand;
            btnCardDestinos.FlatAppearance.BorderSize = 0;
            btnCardDestinos.FlatStyle = FlatStyle.Flat;
            btnCardDestinos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCardDestinos.ForeColor = Color.White;
            btnCardDestinos.Location = new Point(550, 10);
            btnCardDestinos.Margin = new Padding(10);
            btnCardDestinos.Name = "btnCardDestinos";
            btnCardDestinos.Size = new Size(240, 60);
            btnCardDestinos.TabIndex = 2;
            btnCardDestinos.Text = "🌍 Destinos / Aeropuertos";
            btnCardDestinos.UseVisualStyleBackColor = false;
            btnCardDestinos.Click += btnDestinos_Click;
            // 
            // btnCardPagos
            // 
            btnCardPagos.BackColor = Color.FromArgb(230, 126, 34);
            btnCardPagos.Cursor = Cursors.Hand;
            btnCardPagos.FlatAppearance.BorderSize = 0;
            btnCardPagos.FlatStyle = FlatStyle.Flat;
            btnCardPagos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCardPagos.ForeColor = Color.White;
            btnCardPagos.Location = new Point(145, 90);
            btnCardPagos.Margin = new Padding(145, 10, 10, 10);
            btnCardPagos.Name = "btnCardPagos";
            btnCardPagos.Size = new Size(240, 60);
            btnCardPagos.TabIndex = 3;
            btnCardPagos.Text = "💳 Métodos de Pago";
            btnCardPagos.UseVisualStyleBackColor = false;
            btnCardPagos.Click += btnMetodopago_Click;
            // 
            // btnCardReservas
            // 
            btnCardReservas.BackColor = Color.FromArgb(26, 188, 156);
            btnCardReservas.Cursor = Cursors.Hand;
            btnCardReservas.FlatAppearance.BorderSize = 0;
            btnCardReservas.FlatStyle = FlatStyle.Flat;
            btnCardReservas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCardReservas.ForeColor = Color.White;
            btnCardReservas.Location = new Point(415, 90);
            btnCardReservas.Margin = new Padding(10);
            btnCardReservas.Name = "btnCardReservas";
            btnCardReservas.Size = new Size(240, 60);
            btnCardReservas.TabIndex = 4;
            btnCardReservas.Text = "📋 Reservas";
            btnCardReservas.UseVisualStyleBackColor = false;
            btnCardReservas.Click += btnReserva_Click;
            // 
            // lnksalirapp
            // 
            lnksalirapp.Anchor = AnchorStyles.Top;
            lnksalirapp.AutoSize = true;
            lnksalirapp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lnksalirapp.LinkColor = Color.FromArgb(192, 57, 43);
            lnksalirapp.Location = new Point(390, 480);
            lnksalirapp.Name = "lnksalirapp";
            lnksalirapp.Size = new Size(120, 20);
            lnksalirapp.TabIndex = 19;
            lnksalirapp.TabStop = true;
            lnksalirapp.Text = "🚪 Salir de la App";
            lnksalirapp.LinkClicked += lnksalirapp_LinkClicked;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 720);
            Controls.Add(pnlMain);
            Controls.Add(pnl1);
            MinimumSize = new Size(900, 600);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            pnl1.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            pnlMain.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlCards.ResumeLayout(false);
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
        private Panel pnlMain;
        private Panel pnlCenter;
        private PictureBox pictureBox2;
        private Label lblBienvenida;
        private Label lblSubtitulo;
        private FlowLayoutPanel pnlCards;
        private Button btnCardPasajeros;
        private Button btnCardVuelos;
        private Button btnCardDestinos;
        private Button btnCardPagos;
        private Button btnCardReservas;
        private LinkLabel lnksalirapp;
    }
}