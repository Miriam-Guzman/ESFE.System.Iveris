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
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            BtnIniciarSesion = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 245);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 0;
            label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 303);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(126, 303);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(168, 25);
            txtContraseña.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            BtnIniciarSesion.Location = new Point(132, 360);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(121, 26);
            BtnIniciarSesion.TabIndex = 4;
            BtnIniciarSesion.Text = "Iniciar Sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_08_11_at_9_32_19_PM;
            pictureBox1.Location = new Point(132, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 109);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 138);
            label3.Name = "label3";
            label3.Size = new Size(249, 17);
            label3.TabIndex = 6;
            label3.Text = "Aplicacion de Viajes Moderna y Elegante.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 390);
            label4.Name = "label4";
            label4.Size = new Size(105, 17);
            label4.TabIndex = 7;
            label4.Text = "O continuar con ";
            // 
            // button1
            // 
            button1.Location = new Point(75, 420);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 8;
            button1.Text = "Google";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(223, 420);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 9;
            button2.Text = "Facebook";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(107, 469);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 17);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu constraseña?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(89, 504);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(206, 17);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "¿No tienes una cuenta? Regístrate";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(126, 242);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(169, 25);
            txtCorreo.TabIndex = 12;
            txtCorreo.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 571);
            Controls.Add(txtCorreo);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textEmail;
        private TextBox txtContraseña;
        private Button BtnIniciarSesion;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox txtCorreo;
    }
}
