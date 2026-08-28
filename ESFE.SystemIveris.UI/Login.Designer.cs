namespace ESFE.SystemIveris.UI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl1 = new Panel();
            lblAppTitle = new Label();
            picLogo = new PictureBox();
            pnlMain = new Panel();
            pnlCard = new Panel();
            lnksalirapp = new LinkLabel();
            lnkNotienecuenta = new LinkLabel();
            BtnIniciarSesion = new Button();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtCorreo = new TextBox();
            lblCorreoEle = new Label();
            lblSubtitulo = new Label();
            lblBienvenido = new Label();
            pnlCardRegistro = new Panel();
            lnkRegSalir = new LinkLabel();
            lnkYaTengoCuenta = new LinkLabel();
            btnRegistrar = new Button();
            txtRegConfirmar = new TextBox();
            lblRegConfirmar = new Label();
            txtRegContraseña = new TextBox();
            lblRegContraseña = new Label();
            cboRegCiudad = new ComboBox();
            lblRegCiudad = new Label();
            txtRegTelefono = new TextBox();
            lblRegTelefono = new Label();
            txtRegCorreo = new TextBox();
            lblRegCorreo = new Label();
            txtRegApellido = new TextBox();
            lblRegApellido = new Label();
            txtRegNombre = new TextBox();
            lblRegNombre = new Label();
            lblRegSubtitulo = new Label();
            lblRegTitulo = new Label();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMain.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlCardRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(70, 90, 200);
            pnl1.Controls.Add(lblAppTitle);
            pnl1.Controls.Add(picLogo);
            pnl1.Dock = DockStyle.Top;
            pnl1.Location = new Point(0, 0);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(1100, 150);
            pnl1.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.Anchor = AnchorStyles.Top;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(200, 110);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(700, 28);
            lblAppTitle.TabIndex = 7;
            lblAppTitle.Text = "SISTEMA DE GESTIÓN DE AEROLÍNEAS IVERIS";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            picLogo.Location = new Point(460, 10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 90);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(245, 247, 250);
            pnlMain.Controls.Add(pnlCardRegistro);
            pnlMain.Controls.Add(pnlCard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 150);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1100, 570);
            pnlMain.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lnksalirapp);
            pnlCard.Controls.Add(lnkNotienecuenta);
            pnlCard.Controls.Add(BtnIniciarSesion);
            pnlCard.Controls.Add(txtContraseña);
            pnlCard.Controls.Add(lblContraseña);
            pnlCard.Controls.Add(txtCorreo);
            pnlCard.Controls.Add(lblCorreoEle);
            pnlCard.Controls.Add(lblSubtitulo);
            pnlCard.Controls.Add(lblBienvenido);
            pnlCard.Location = new Point(325, 25);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(450, 400);
            pnlCard.TabIndex = 0;
            // 
            // lnksalirapp
            // 
            lnksalirapp.ActiveLinkColor = Color.FromArgb(192, 57, 43);
            lnksalirapp.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lnksalirapp.LinkColor = Color.FromArgb(192, 57, 43);
            lnksalirapp.Location = new Point(20, 358);
            lnksalirapp.Name = "lnksalirapp";
            lnksalirapp.Size = new Size(410, 25);
            lnksalirapp.TabIndex = 12;
            lnksalirapp.TabStop = true;
            lnksalirapp.Text = "🚪 Salir de la aplicación";
            lnksalirapp.TextAlign = ContentAlignment.MiddleCenter;
            lnksalirapp.LinkClicked += lnksalirapp_LinkClicked;
            // 
            // lnkNotienecuenta
            // 
            lnkNotienecuenta.ActiveLinkColor = Color.FromArgb(70, 90, 200);
            lnkNotienecuenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnkNotienecuenta.LinkColor = Color.FromArgb(70, 90, 200);
            lnkNotienecuenta.Location = new Point(20, 300);
            lnkNotienecuenta.Name = "lnkNotienecuenta";
            lnkNotienecuenta.Size = new Size(410, 25);
            lnkNotienecuenta.TabIndex = 11;
            lnkNotienecuenta.TabStop = true;
            lnkNotienecuenta.Text = "¿No tienes una cuenta? Regístrate aquí";
            lnkNotienecuenta.TextAlign = ContentAlignment.MiddleCenter;
            lnkNotienecuenta.LinkClicked += lnkNotienecuenta_LinkClicked;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = Color.FromArgb(70, 90, 200);
            BtnIniciarSesion.Cursor = Cursors.Hand;
            BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            BtnIniciarSesion.FlatStyle = FlatStyle.Flat;
            BtnIniciarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnIniciarSesion.ForeColor = Color.White;
            BtnIniciarSesion.Location = new Point(35, 240);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(380, 42);
            BtnIniciarSesion.TabIndex = 6;
            BtnIniciarSesion.Text = "INICIAR SESIÓN";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 10.5F);
            txtContraseña.Location = new Point(35, 200);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(380, 26);
            txtContraseña.TabIndex = 5;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.KeyDown += txtContraseña_KeyDown;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblContraseña.ForeColor = Color.FromArgb(50, 50, 50);
            lblContraseña.Location = new Point(35, 175);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(81, 17);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.5F);
            txtCorreo.Location = new Point(35, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(380, 26);
            txtCorreo.TabIndex = 3;
            txtCorreo.KeyDown += txtCorreo_KeyDown;
            // 
            // lblCorreoEle
            // 
            lblCorreoEle.AutoSize = true;
            lblCorreoEle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCorreoEle.ForeColor = Color.FromArgb(50, 50, 50);
            lblCorreoEle.Location = new Point(35, 105);
            lblCorreoEle.Name = "lblCorreoEle";
            lblCorreoEle.Size = new Size(125, 17);
            lblCorreoEle.TabIndex = 2;
            lblCorreoEle.Text = "Correo Electrónico:";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(20, 60);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(410, 30);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingresa tus credenciales para acceder al sistema";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenido
            // 
            lblBienvenido.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBienvenido.ForeColor = Color.FromArgb(40, 50, 120);
            lblBienvenido.Location = new Point(20, 20);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(410, 35);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "¡Bienvenido a Iveris!";
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCardRegistro
            // 
            pnlCardRegistro.Anchor = AnchorStyles.Top;
            pnlCardRegistro.BackColor = Color.White;
            pnlCardRegistro.BorderStyle = BorderStyle.FixedSingle;
            pnlCardRegistro.Controls.Add(lnkRegSalir);
            pnlCardRegistro.Controls.Add(lnkYaTengoCuenta);
            pnlCardRegistro.Controls.Add(btnRegistrar);
            pnlCardRegistro.Controls.Add(txtRegConfirmar);
            pnlCardRegistro.Controls.Add(lblRegConfirmar);
            pnlCardRegistro.Controls.Add(txtRegContraseña);
            pnlCardRegistro.Controls.Add(lblRegContraseña);
            pnlCardRegistro.Controls.Add(cboRegCiudad);
            pnlCardRegistro.Controls.Add(lblRegCiudad);
            pnlCardRegistro.Controls.Add(txtRegTelefono);
            pnlCardRegistro.Controls.Add(lblRegTelefono);
            pnlCardRegistro.Controls.Add(txtRegCorreo);
            pnlCardRegistro.Controls.Add(lblRegCorreo);
            pnlCardRegistro.Controls.Add(txtRegApellido);
            pnlCardRegistro.Controls.Add(lblRegApellido);
            pnlCardRegistro.Controls.Add(txtRegNombre);
            pnlCardRegistro.Controls.Add(lblRegNombre);
            pnlCardRegistro.Controls.Add(lblRegSubtitulo);
            pnlCardRegistro.Controls.Add(lblRegTitulo);
            pnlCardRegistro.Location = new Point(275, 15);
            pnlCardRegistro.Name = "pnlCardRegistro";
            pnlCardRegistro.Size = new Size(550, 535);
            pnlCardRegistro.TabIndex = 1;
            pnlCardRegistro.Visible = false;
            // 
            // lnkRegSalir
            // 
            lnkRegSalir.ActiveLinkColor = Color.FromArgb(192, 57, 43);
            lnkRegSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lnkRegSalir.LinkColor = Color.FromArgb(192, 57, 43);
            lnkRegSalir.Location = new Point(20, 498);
            lnkRegSalir.Name = "lnkRegSalir";
            lnkRegSalir.Size = new Size(508, 22);
            lnkRegSalir.TabIndex = 18;
            lnkRegSalir.TabStop = true;
            lnkRegSalir.Text = "🚪 Salir de la aplicación";
            lnkRegSalir.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegSalir.LinkClicked += lnksalirapp_LinkClicked;
            // 
            // lnkYaTengoCuenta
            // 
            lnkYaTengoCuenta.ActiveLinkColor = Color.FromArgb(70, 90, 200);
            lnkYaTengoCuenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnkYaTengoCuenta.LinkColor = Color.FromArgb(70, 90, 200);
            lnkYaTengoCuenta.Location = new Point(20, 465);
            lnkYaTengoCuenta.Name = "lnkYaTengoCuenta";
            lnkYaTengoCuenta.Size = new Size(508, 24);
            lnkYaTengoCuenta.TabIndex = 17;
            lnkYaTengoCuenta.TabStop = true;
            lnkYaTengoCuenta.Text = "¿Ya tienes una cuenta? Inicia sesión aquí";
            lnkYaTengoCuenta.TextAlign = ContentAlignment.MiddleCenter;
            lnkYaTengoCuenta.LinkClicked += lnkYaTengoCuenta_LinkClicked;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(46, 204, 113);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(35, 415);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(480, 42);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "CREAR CUENTA";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtRegConfirmar
            // 
            txtRegConfirmar.Font = new Font("Segoe UI", 10F);
            txtRegConfirmar.Location = new Point(285, 365);
            txtRegConfirmar.Name = "txtRegConfirmar";
            txtRegConfirmar.Size = new Size(230, 25);
            txtRegConfirmar.TabIndex = 15;
            txtRegConfirmar.UseSystemPasswordChar = true;
            // 
            // lblRegConfirmar
            // 
            lblRegConfirmar.AutoSize = true;
            lblRegConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegConfirmar.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegConfirmar.Location = new Point(285, 345);
            lblRegConfirmar.Name = "lblRegConfirmar";
            lblRegConfirmar.Size = new Size(133, 15);
            lblRegConfirmar.TabIndex = 14;
            lblRegConfirmar.Text = "Confirmar Contraseña:";
            // 
            // txtRegContraseña
            // 
            txtRegContraseña.Font = new Font("Segoe UI", 10F);
            txtRegContraseña.Location = new Point(35, 365);
            txtRegContraseña.Name = "txtRegContraseña";
            txtRegContraseña.Size = new Size(230, 25);
            txtRegContraseña.TabIndex = 13;
            txtRegContraseña.UseSystemPasswordChar = true;
            // 
            // lblRegContraseña
            // 
            lblRegContraseña.AutoSize = true;
            lblRegContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegContraseña.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegContraseña.Location = new Point(35, 345);
            lblRegContraseña.Name = "lblRegContraseña";
            lblRegContraseña.Size = new Size(72, 15);
            lblRegContraseña.TabIndex = 12;
            lblRegContraseña.Text = "Contraseña:";
            // 
            // cboRegCiudad
            // 
            cboRegCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegCiudad.Font = new Font("Segoe UI", 10F);
            cboRegCiudad.FormattingEnabled = true;
            cboRegCiudad.Location = new Point(35, 305);
            cboRegCiudad.Name = "cboRegCiudad";
            cboRegCiudad.Size = new Size(480, 25);
            cboRegCiudad.TabIndex = 11;
            // 
            // lblRegCiudad
            // 
            lblRegCiudad.AutoSize = true;
            lblRegCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegCiudad.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegCiudad.Location = new Point(35, 285);
            lblRegCiudad.Name = "lblRegCiudad";
            lblRegCiudad.Size = new Size(116, 15);
            lblRegCiudad.TabIndex = 10;
            lblRegCiudad.Text = "Ciudad / Ubicación:";
            // 
            // txtRegTelefono
            // 
            txtRegTelefono.Font = new Font("Segoe UI", 10F);
            txtRegTelefono.Location = new Point(35, 245);
            txtRegTelefono.Name = "txtRegTelefono";
            txtRegTelefono.Size = new Size(480, 25);
            txtRegTelefono.TabIndex = 9;
            // 
            // lblRegTelefono
            // 
            lblRegTelefono.AutoSize = true;
            lblRegTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegTelefono.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegTelefono.Location = new Point(35, 225);
            lblRegTelefono.Name = "lblRegTelefono";
            lblRegTelefono.Size = new Size(59, 15);
            lblRegTelefono.TabIndex = 8;
            lblRegTelefono.Text = "Teléfono:";
            // 
            // txtRegCorreo
            // 
            txtRegCorreo.Font = new Font("Segoe UI", 10F);
            txtRegCorreo.Location = new Point(35, 185);
            txtRegCorreo.Name = "txtRegCorreo";
            txtRegCorreo.Size = new Size(480, 25);
            txtRegCorreo.TabIndex = 7;
            // 
            // lblRegCorreo
            // 
            lblRegCorreo.AutoSize = true;
            lblRegCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegCorreo.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegCorreo.Location = new Point(35, 165);
            lblRegCorreo.Name = "lblRegCorreo";
            lblRegCorreo.Size = new Size(113, 15);
            lblRegCorreo.TabIndex = 6;
            lblRegCorreo.Text = "Correo Electrónico:";
            // 
            // txtRegApellido
            // 
            txtRegApellido.Font = new Font("Segoe UI", 10F);
            txtRegApellido.Location = new Point(285, 125);
            txtRegApellido.Name = "txtRegApellido";
            txtRegApellido.Size = new Size(230, 25);
            txtRegApellido.TabIndex = 5;
            // 
            // lblRegApellido
            // 
            lblRegApellido.AutoSize = true;
            lblRegApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegApellido.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegApellido.Location = new Point(285, 105);
            lblRegApellido.Name = "lblRegApellido";
            lblRegApellido.Size = new Size(55, 15);
            lblRegApellido.TabIndex = 4;
            lblRegApellido.Text = "Apellido:";
            // 
            // txtRegNombre
            // 
            txtRegNombre.Font = new Font("Segoe UI", 10F);
            txtRegNombre.Location = new Point(35, 125);
            txtRegNombre.Name = "txtRegNombre";
            txtRegNombre.Size = new Size(230, 25);
            txtRegNombre.TabIndex = 3;
            // 
            // lblRegNombre
            // 
            lblRegNombre.AutoSize = true;
            lblRegNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegNombre.ForeColor = Color.FromArgb(50, 50, 50);
            lblRegNombre.Location = new Point(35, 105);
            lblRegNombre.Name = "lblRegNombre";
            lblRegNombre.Size = new Size(56, 15);
            lblRegNombre.TabIndex = 2;
            lblRegNombre.Text = "Nombre:";
            // 
            // lblRegSubtitulo
            // 
            lblRegSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblRegSubtitulo.ForeColor = Color.Gray;
            lblRegSubtitulo.Location = new Point(20, 55);
            lblRegSubtitulo.Name = "lblRegSubtitulo";
            lblRegSubtitulo.Size = new Size(508, 30);
            lblRegSubtitulo.TabIndex = 1;
            lblRegSubtitulo.Text = "Completa tus datos para crear tu cuenta en la aerolínea";
            lblRegSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegTitulo
            // 
            lblRegTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRegTitulo.ForeColor = Color.FromArgb(40, 50, 120);
            lblRegTitulo.Location = new Point(20, 18);
            lblRegTitulo.Name = "lblRegTitulo";
            lblRegTitulo.Size = new Size(508, 35);
            lblRegTitulo.TabIndex = 0;
            lblRegTitulo.Text = "Registro de Nuevo Cliente";
            lblRegTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 720);
            Controls.Add(pnlMain);
            Controls.Add(pnl1);
            MinimumSize = new Size(900, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            Resize += Login_Resize;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMain.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlCardRegistro.ResumeLayout(false);
            pnlCardRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl1;
        private PictureBox picLogo;
        private Label lblAppTitle;
        private Panel pnlMain;
        private Panel pnlCard;
        private Label lblBienvenido;
        private Label lblSubtitulo;
        private Label lblCorreoEle;
        private TextBox txtCorreo;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button BtnIniciarSesion;
        private LinkLabel lnkNotienecuenta;
        private LinkLabel lnksalirapp;

        // Controles de la tarjeta de Registro
        private Panel pnlCardRegistro;
        private Label lblRegTitulo;
        private Label lblRegSubtitulo;
        private Label lblRegNombre;
        private TextBox txtRegNombre;
        private Label lblRegApellido;
        private TextBox txtRegApellido;
        private Label lblRegCorreo;
        private TextBox txtRegCorreo;
        private Label lblRegTelefono;
        private TextBox txtRegTelefono;
        private Label lblRegCiudad;
        private ComboBox cboRegCiudad;
        private Label lblRegContraseña;
        private TextBox txtRegContraseña;
        private Label lblRegConfirmar;
        private TextBox txtRegConfirmar;
        private Button btnRegistrar;
        private LinkLabel lnkYaTengoCuenta;
        private LinkLabel lnkRegSalir;
    }
}
