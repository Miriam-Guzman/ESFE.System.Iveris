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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnDestinos = new Button();
            btnMetodopago = new Button();
            btnReserva = new Button();
            btnVuelos = new Button();
            btnInicio = new Button();
            dataGridView1 = new DataGridView();
            NumerodeVuelo = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            AvionAsignado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDestinos);
            panel1.Controls.Add(btnMetodopago);
            panel1.Controls.Add(btnReserva);
            panel1.Controls.Add(btnVuelos);
            panel1.Controls.Add(btnInicio);
            panel1.Location = new Point(-5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 199);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pictureBox1.Location = new Point(327, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDestinos.Location = new Point(524, 162);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(105, 27);
            btnDestinos.TabIndex = 11;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            // 
            // btnMetodopago
            // 
            btnMetodopago.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnMetodopago.Location = new Point(148, 162);
            btnMetodopago.Name = "btnMetodopago";
            btnMetodopago.Size = new Size(148, 27);
            btnMetodopago.TabIndex = 8;
            btnMetodopago.Text = "Metodo de Pago";
            btnMetodopago.UseVisualStyleBackColor = true;
            // 
            // btnReserva
            // 
            btnReserva.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnReserva.Location = new Point(302, 162);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(105, 27);
            btnReserva.TabIndex = 10;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = true;
            // 
            // btnVuelos
            // 
            btnVuelos.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnVuelos.Location = new Point(413, 162);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(105, 27);
            btnVuelos.TabIndex = 9;
            btnVuelos.Text = "Vuelos";
            btnVuelos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnInicio.Location = new Point(37, 162);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 27);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio ";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NumerodeVuelo, Destino, Origen, Hora, AvionAsignado });
            dataGridView1.Location = new Point(12, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 155);
            dataGridView1.TabIndex = 13;
            // 
            // NumerodeVuelo
            // 
            NumerodeVuelo.HeaderText = "Numero de Vuelo";
            NumerodeVuelo.Name = "NumerodeVuelo";
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // AvionAsignado
            // 
            AvionAsignado.HeaderText = "Avion Asignado";
            AvionAsignado.Name = "AvionAsignado";
            // 
            // Destinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Destinos";
            Text = "Destinos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDestinos;
        private Button btnMetodopago;
        private Button btnReserva;
        private Button btnVuelos;
        private Button btnInicio;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NumerodeVuelo;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn AvionAsignado;
    }
}