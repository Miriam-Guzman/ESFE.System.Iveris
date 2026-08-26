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
            pic1 = new PictureBox();
            btnDestinos = new Button();
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnInicio = new Button();
            pictureBox2 = new PictureBox();
            lnksalirapp = new LinkLabel();
            btnDatosPasajero = new Button();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pnl1.Size = new Size(780, 185);
            pnl1.TabIndex = 17;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pic1.Location = new Point(290, 15);
            pic1.Name = "pic1";
            pic1.Size = new Size(200, 100);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 6;
            pic1.TabStop = false;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(560, 138);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(110, 30);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(135, 138);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(135, 30);
            btnMetodopago.TabIndex = 8;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            btnMetodopago.Click += btnMetodopago_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.White;
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(280, 138);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(110, 30);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnVuelos
            // 
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(400, 138);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(110, 30);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(128, 255, 128);
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(15, 138);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(110, 30);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(180, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(420, 230);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnDatosPasajero
            // 
            btnDatosPasajero.BackColor = Color.DeepSkyBlue;
            btnDatosPasajero.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDatosPasajero.ForeColor = Color.White;
            btnDatosPasajero.Location = new Point(270, 450);
            btnDatosPasajero.Name = "btnDatosPasajero";
            btnDatosPasajero.Size = new Size(240, 40);
            btnDatosPasajero.TabIndex = 20;
            btnDatosPasajero.Text = "Gestionar Pasajeros";
            btnDatosPasajero.UseVisualStyleBackColor = false;
            btnDatosPasajero.Click += btnDatosPasajero_Click;
            // 
            // lnksalirapp
            // 
            lnksalirapp.AutoSize = true;
            lnksalirapp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lnksalirapp.Location = new Point(340, 505);
            lnksalirapp.Name = "lnksalirapp";
            lnksalirapp.Size = new Size(100, 19);
            lnksalirapp.TabIndex = 19;
            lnksalirapp.TabStop = true;
            lnksalirapp.Text = "Salir de la App";
            lnksalirapp.LinkClicked += lnksalirapp_LinkClicked;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 550);
            Controls.Add(btnDatosPasajero);
            Controls.Add(lnksalirapp);
            Controls.Add(pictureBox2);
            Controls.Add(pnl1);
            Name = "Inicio";
            Text = "Inicio - ESFE System Iveris";
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Inicio_Load;
            pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private LinkLabel lnksalirapp;
        private Button btnDatosPasajero;
    }
}