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
            btnInicio = new Button();
            btnMetodopago = new Button();
            btnVuelos = new Button();
            btnReservas = new Button();
            btndestinos = new Button();
            lblDastospasajero = new Label();
            lblApellidos = new Label();
            lblfechanacimiento = new Label();
            lblnacionalidad = new Label();
            lblNumeroPasaporteDui = new Label();
            lblCorreoElectro = new Label();
            lblNumeroTelefon = new Label();
            lblNombres = new Label();
            dtp1 = new DateTimePicker();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            txt5 = new TextBox();
            txt6 = new TextBox();
            btncontinuar = new Button();
            pic1 = new PictureBox();
            pnl1 = new Panel();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            pnl1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(17, 112);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.BackColor = Color.White;
            btnMetodopago.FlatAppearance.BorderSize = 0;
            btnMetodopago.FlatStyle = FlatStyle.Flat;
            btnMetodopago.Location = new Point(133, 112);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(119, 23);
            btnMetodopago.TabIndex = 1;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = false;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.BackColor = Color.White;
            btnVuelos.FlatAppearance.BorderSize = 0;
            btnVuelos.FlatStyle = FlatStyle.Flat;
            btnVuelos.Location = new Point(282, 112);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(119, 23);
            btnVuelos.TabIndex = 2;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(128, 255, 128);
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Location = new Point(434, 112);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(119, 23);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "RESERVAS";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btndestinos
            // 
            btndestinos.BackColor = Color.White;
            btndestinos.FlatAppearance.BorderSize = 0;
            btndestinos.FlatStyle = FlatStyle.Flat;
            btndestinos.Location = new Point(584, 112);
            btndestinos.Name = "btndestinos";
            btndestinos.Size = new Size(119, 23);
            btndestinos.TabIndex = 4;
            btndestinos.Text = "DESTINOS";
            btndestinos.UseVisualStyleBackColor = false;
            btndestinos.Click += btndestinos_Click;
            // 
            // lblDastospasajero
            // 
            lblDastospasajero.AutoSize = true;
            lblDastospasajero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDastospasajero.Location = new Point(20, 166);
            lblDastospasajero.Name = "lblDastospasajero";
            lblDastospasajero.Size = new Size(108, 15);
            lblDastospasajero.TabIndex = 5;
            lblDastospasajero.Text = "Datos del Pasajero";
            lblDastospasajero.Click += lblDastospasajero_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellidos.Location = new Point(24, 259);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(57, 15);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos";
            lblApellidos.Click += lblApellidos_Click;
            // 
            // lblfechanacimiento
            // 
            lblfechanacimiento.AutoSize = true;
            lblfechanacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblfechanacimiento.Location = new Point(24, 323);
            lblfechanacimiento.Name = "lblfechanacimiento";
            lblfechanacimiento.Size = new Size(123, 15);
            lblfechanacimiento.TabIndex = 7;
            lblfechanacimiento.Text = "Fecha de Nacimiento";
            lblfechanacimiento.Click += lblfechanacimiento_Click;
            // 
            // lblnacionalidad
            // 
            lblnacionalidad.AutoSize = true;
            lblnacionalidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblnacionalidad.Location = new Point(24, 393);
            lblnacionalidad.Name = "lblnacionalidad";
            lblnacionalidad.Size = new Size(77, 15);
            lblnacionalidad.TabIndex = 8;
            lblnacionalidad.Text = "Nacionalidad";
            lblnacionalidad.Click += lblnacionalidad_Click;
            // 
            // lblNumeroPasaporteDui
            // 
            lblNumeroPasaporteDui.AutoSize = true;
            lblNumeroPasaporteDui.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroPasaporteDui.Location = new Point(20, 463);
            lblNumeroPasaporteDui.Name = "lblNumeroPasaporteDui";
            lblNumeroPasaporteDui.Size = new Size(163, 15);
            lblNumeroPasaporteDui.TabIndex = 9;
            lblNumeroPasaporteDui.Text = "Numero de Pasaporte o DUI";
            lblNumeroPasaporteDui.Click += lblNumeroPasaporteDui_Click;
            // 
            // lblCorreoElectro
            // 
            lblCorreoElectro.AutoSize = true;
            lblCorreoElectro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreoElectro.Location = new Point(20, 533);
            lblCorreoElectro.Name = "lblCorreoElectro";
            lblCorreoElectro.Size = new Size(110, 15);
            lblCorreoElectro.TabIndex = 10;
            lblCorreoElectro.Text = "Correo Electronico";
            lblCorreoElectro.Click += lblCorreoElectro_Click;
            // 
            // lblNumeroTelefon
            // 
            lblNumeroTelefon.AutoSize = true;
            lblNumeroTelefon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumeroTelefon.Location = new Point(20, 599);
            lblNumeroTelefon.Name = "lblNumeroTelefon";
            lblNumeroTelefon.Size = new Size(136, 15);
            lblNumeroTelefon.TabIndex = 11;
            lblNumeroTelefon.Text = "Numerono de Telefono";
            lblNumeroTelefon.Click += lblNumeroTelefon_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombres.Location = new Point(24, 195);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(58, 15);
            lblNombres.TabIndex = 12;
            lblNombres.Text = "Nombres";
            lblNombres.Click += lblNombres_Click;
            // 
            // dtp1
            // 
            dtp1.Format = DateTimePickerFormat.Short;
            dtp1.Location = new Point(20, 353);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(200, 23);
            dtp1.TabIndex = 13;
            dtp1.ValueChanged += dtp1_ValueChanged;
            // 
            // txt1
            // 
            txt1.Location = new Point(18, 213);
            txt1.Name = "txt1";
            txt1.Size = new Size(202, 23);
            txt1.TabIndex = 14;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(18, 286);
            txt2.Name = "txt2";
            txt2.Size = new Size(200, 23);
            txt2.TabIndex = 15;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // txt3
            // 
            txt3.Location = new Point(20, 421);
            txt3.Name = "txt3";
            txt3.Size = new Size(200, 23);
            txt3.TabIndex = 16;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // txt4
            // 
            txt4.Location = new Point(20, 497);
            txt4.Name = "txt4";
            txt4.Size = new Size(200, 23);
            txt4.TabIndex = 17;
            txt4.TextChanged += txt4_TextChanged;
            // 
            // txt5
            // 
            txt5.Location = new Point(18, 551);
            txt5.Name = "txt5";
            txt5.Size = new Size(202, 23);
            txt5.TabIndex = 18;
            txt5.TextChanged += txt5_TextChanged;
            // 
            // txt6
            // 
            txt6.Location = new Point(18, 626);
            txt6.Name = "txt6";
            txt6.Size = new Size(202, 23);
            txt6.TabIndex = 19;
            txt6.TextChanged += txt6_TextChanged;
            // 
            // btncontinuar
            // 
            btncontinuar.BackColor = SystemColors.Highlight;
            btncontinuar.FlatStyle = FlatStyle.Flat;
            btncontinuar.ForeColor = SystemColors.Window;
            btncontinuar.Location = new Point(467, 489);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(147, 30);
            btncontinuar.TabIndex = 20;
            btncontinuar.Text = "CONTINUAR";
            btncontinuar.UseVisualStyleBackColor = false;
            btncontinuar.Click += btncontinuar_Click;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = (Image)resources.GetObject("pic1.Image");
            pic1.Location = new Point(289, 3);
            pic1.Name = "pic1";
            pic1.Size = new Size(170, 92);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 21;
            pic1.TabStop = false;
            pic1.Click += pic1_Click;
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(128, 128, 255);
            pnl1.BorderStyle = BorderStyle.FixedSingle;
            pnl1.Controls.Add(pic1);
            pnl1.Controls.Add(btnMetodopago);
            pnl1.Controls.Add(btnInicio);
            pnl1.Controls.Add(btnVuelos);
            pnl1.Controls.Add(btnReservas);
            pnl1.Controls.Add(btndestinos);
            pnl1.Location = new Point(2, 2);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(725, 152);
            pnl1.TabIndex = 22;
            pnl1.Paint += pnl1_Paint;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.White;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.ForeColor = SystemColors.WindowText;
            btnInsertar.Location = new Point(398, 376);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(99, 30);
            btnInsertar.TabIndex = 23;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(503, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.WindowText;
            btnModificar.Location = new Point(609, 376);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(97, 30);
            btnModificar.TabIndex = 25;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = SystemColors.WindowText;
            btnBuscar.Location = new Point(293, 376);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 30);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // DatosPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 661);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(pnl1);
            Controls.Add(btncontinuar);
            Controls.Add(txt6);
            Controls.Add(txt5);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(lblDastospasajero);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(dtp1);
            Controls.Add(lblNombres);
            Controls.Add(lblNumeroTelefon);
            Controls.Add(lblCorreoElectro);
            Controls.Add(lblNumeroPasaporteDui);
            Controls.Add(lblnacionalidad);
            Controls.Add(lblfechanacimiento);
            Controls.Add(lblApellidos);
            Name = "DatosPasajero";
            Text = "Actualizar";
            Load += DatosPasajero_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            pnl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Button btnMetodopago;
        private Button btnVuelos;
        private Button btnReservas;
        private Button btndestinos;
        private Label lblDastospasajero;
        private Label lblApellidos;
        private Label lblfechanacimiento;
        private Label lblnacionalidad;
        private Label lblNumeroPasaporteDui;
        private Label lblCorreoElectro;
        private Label lblNumeroTelefon;
        private Label lblNombres;
        private DateTimePicker dtp1;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private TextBox txt5;
        private TextBox txt6;
        private Button btncontinuar;
        private PictureBox pic1;
        private Panel pnl1;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBuscar;
    }
}