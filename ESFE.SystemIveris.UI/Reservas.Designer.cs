namespace ESFE.SystemIveris.UI
{
    partial class Reserva
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
            pnlCenter = new Panel();
            lblTitulo = new Label();
            lblidaVuelta = new Label();
            lblorigen = new Label();
            cboOrigen = new ComboBox();
            lblDestino = new Label();
            cboDestino = new ComboBox();
            lblfechasalida = new Label();
            dtp2 = new DateTimePicker();
            lblfecharegreso = new Label();
            dtp1 = new DateTimePicker();
            lblpasajero = new Label();
            txt5 = new TextBox();
            lblclase = new Label();
            cboClase = new ComboBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            pnl1.SuspendLayout();
            pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnlContent.SuspendLayout();
            pnlCenter.SuspendLayout();
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
            pnl1.TabIndex = 15;
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
            btnReserva.BackColor = Color.FromArgb(128, 255, 128);
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
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(pnlCenter);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 160);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(1100, 580);
            pnlContent.TabIndex = 16;
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.Top;
            pnlCenter.BackColor = Color.White;
            pnlCenter.BorderStyle = BorderStyle.FixedSingle;
            pnlCenter.Controls.Add(lblTitulo);
            pnlCenter.Controls.Add(lblidaVuelta);
            pnlCenter.Controls.Add(lblorigen);
            pnlCenter.Controls.Add(cboOrigen);
            pnlCenter.Controls.Add(lblDestino);
            pnlCenter.Controls.Add(cboDestino);
            pnlCenter.Controls.Add(lblfechasalida);
            pnlCenter.Controls.Add(dtp2);
            pnlCenter.Controls.Add(lblfecharegreso);
            pnlCenter.Controls.Add(dtp1);
            pnlCenter.Controls.Add(lblpasajero);
            pnlCenter.Controls.Add(txt5);
            pnlCenter.Controls.Add(lblclase);
            pnlCenter.Controls.Add(cboClase);
            pnlCenter.Controls.Add(lblTelefono);
            pnlCenter.Controls.Add(txtTelefono);
            pnlCenter.Controls.Add(btnGuardar);
            pnlCenter.Controls.Add(btnBuscar);
            pnlCenter.Controls.Add(btnModificar);
            pnlCenter.Controls.Add(btnEliminar);
            pnlCenter.Location = new Point(175, 10);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Padding = new Padding(25);
            pnlCenter.Size = new Size(750, 560);
            pnlCenter.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 50, 120);
            lblTitulo.Location = new Point(25, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 25);
            lblTitulo.TabIndex = 36;
            lblTitulo.Text = "Reservación de Vuelos";
            // 
            // lblidaVuelta
            // 
            lblidaVuelta.AutoSize = true;
            lblidaVuelta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblidaVuelta.ForeColor = Color.FromArgb(41, 128, 185);
            lblidaVuelta.Location = new Point(25, 50);
            lblidaVuelta.Name = "lblidaVuelta";
            lblidaVuelta.Size = new Size(168, 19);
            lblidaVuelta.TabIndex = 16;
            lblidaVuelta.Text = "Modalidad: Ida y Vuelta";
            // 
            // lblorigen
            // 
            lblorigen.AutoSize = true;
            lblorigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblorigen.Location = new Point(25, 80);
            lblorigen.Name = "lblorigen";
            lblorigen.Size = new Size(111, 15);
            lblorigen.TabIndex = 18;
            lblorigen.Text = "Aeropuerto Origen:";
            // 
            // cboOrigen
            // 
            cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(25, 100);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(330, 23);
            cboOrigen.TabIndex = 17;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestino.Location = new Point(390, 80);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(116, 15);
            lblDestino.TabIndex = 19;
            lblDestino.Text = "Aeropuerto Destino:";
            // 
            // cboDestino
            // 
            cboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(390, 100);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(330, 23);
            cboDestino.TabIndex = 25;
            // 
            // lblfechasalida
            // 
            lblfechasalida.AutoSize = true;
            lblfechasalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblfechasalida.Location = new Point(25, 140);
            lblfechasalida.Name = "lblfechasalida";
            lblfechasalida.Size = new Size(95, 15);
            lblfechasalida.TabIndex = 20;
            lblfechasalida.Text = "Fecha de Salida:";
            // 
            // dtp2
            // 
            dtp2.Format = DateTimePickerFormat.Short;
            dtp2.Location = new Point(25, 160);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(330, 23);
            dtp2.TabIndex = 31;
            // 
            // lblfecharegreso
            // 
            lblfecharegreso.AutoSize = true;
            lblfecharegreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblfecharegreso.Location = new Point(390, 140);
            lblfecharegreso.Name = "lblfecharegreso";
            lblfecharegreso.Size = new Size(104, 15);
            lblfecharegreso.TabIndex = 21;
            lblfecharegreso.Text = "Fecha de Regreso:";
            // 
            // dtp1
            // 
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(390, 160);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(330, 23);
            dtp1.TabIndex = 30;
            // 
            // lblpasajero
            // 
            lblpasajero.AutoSize = true;
            lblpasajero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblpasajero.Location = new Point(25, 200);
            lblpasajero.Name = "lblpasajero";
            lblpasajero.Size = new Size(160, 15);
            lblpasajero.TabIndex = 22;
            lblpasajero.Text = "Pasajero (Escribe el nombre):";
            // 
            // txt5
            // 
            txt5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt5.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt5.Location = new Point(25, 220);
            txt5.Name = "txt5";
            txt5.PlaceholderText = "Escribe el nombre del pasajero...";
            txt5.Size = new Size(330, 23);
            txt5.TabIndex = 28;
            // 
            // lblclase
            // 
            lblclase.AutoSize = true;
            lblclase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblclase.Location = new Point(390, 200);
            lblclase.Name = "lblclase";
            lblclase.Size = new Size(106, 15);
            lblclase.TabIndex = 23;
            lblclase.Text = "Clase de Asientos:";
            // 
            // cboClase
            // 
            cboClase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClase.FormattingEnabled = true;
            cboClase.Location = new Point(390, 220);
            cboClase.Name = "cboClase";
            cboClase.Size = new Size(330, 23);
            cboClase.TabIndex = 29;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(25, 260);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(164, 15);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Número de Teléfono (9999-9999):";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(25, 280);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "9999-9999";
            txtTelefono.Size = new Size(330, 23);
            txtTelefono.TabIndex = 30;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 42);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar Reserva";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(200, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(160, 42);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar Reserva";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(375, 330);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 42);
            btnModificar.TabIndex = 35;
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
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(550, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 42);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 740);
            Controls.Add(pnlContent);
            Controls.Add(pnl1);
            MinimumSize = new Size(900, 600);
            Name = "Reserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            Load += Reserva_Load;
            pnl1.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            pnlContent.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
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
        private Panel pnlCenter;
        private Label lblTitulo;
        private Label lblidaVuelta;
        private Label lblorigen;
        private ComboBox cboOrigen;
        private Label lblDestino;
        private ComboBox cboDestino;
        private Label lblfechasalida;
        private DateTimePicker dtp2;
        private Label lblfecharegreso;
        private DateTimePicker dtp1;
        private Label lblpasajero;
        private TextBox txt5;
        private Label lblclase;
        private ComboBox cboClase;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}