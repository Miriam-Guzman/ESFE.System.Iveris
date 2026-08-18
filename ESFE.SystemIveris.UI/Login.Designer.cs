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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblCorreoEle = new Label();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            BtnIniciarSesion = new Button();
            pic1 = new PictureBox();
            lblAplicacionVME = new Label();
            lblContinuar = new Label();
            btnGoogle = new Button();
            btnFacebook = new Button();
            lnkOlvidastecontraseña = new LinkLabel();
            lnkNotienecuenta = new LinkLabel();
            txtCorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            SuspendLayout();
            // 
            // lblCorreoEle
            // 
            lblCorreoEle.AutoSize = true;
            lblCorreoEle.Location = new Point(3, 216);
            lblCorreoEle.Name = "lblCorreoEle";
            lblCorreoEle.Size = new Size(105, 15);
            lblCorreoEle.TabIndex = 0;
            lblCorreoEle.Text = "Correo Electronico";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(3, 267);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(126, 267);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(168, 23);
            txtContraseña.TabIndex = 3;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            BtnIniciarSesion.Location = new Point(132, 318);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(121, 23);
            BtnIniciarSesion.TabIndex = 4;
            BtnIniciarSesion.Text = "Iniciar Sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pic1
            // 
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic1.Image = (Image)resources.GetObject("pic1.Image");
            pic1.Location = new Point(107, 12);
            pic1.Name = "pic1";
            pic1.Size = new Size(146, 96);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 5;
            pic1.TabStop = false;
            // 
            // lblAplicacionVME
            // 
            lblAplicacionVME.AutoSize = true;
            lblAplicacionVME.Location = new Point(75, 150);
            lblAplicacionVME.Name = "lblAplicacionVME";
            lblAplicacionVME.Size = new Size(223, 15);
            lblAplicacionVME.TabIndex = 6;
            lblAplicacionVME.Text = "Aplicacion de Viajes Moderna y Elegante.";
            // 
            // lblContinuar
            // 
            lblContinuar.AutoSize = true;
            lblContinuar.Location = new Point(142, 344);
            lblContinuar.Name = "lblContinuar";
            lblContinuar.Size = new Size(96, 15);
            lblContinuar.TabIndex = 7;
            lblContinuar.Text = "O continuar con ";
            // 
            // btnGoogle
            // 
            btnGoogle.Location = new Point(75, 371);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(75, 23);
            btnGoogle.TabIndex = 8;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = true;
            // 
            // btnFacebook
            // 
            btnFacebook.Location = new Point(223, 371);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(75, 23);
            btnFacebook.TabIndex = 9;
            btnFacebook.Text = "Facebook";
            btnFacebook.UseVisualStyleBackColor = true;
            // 
            // lnkOlvidastecontraseña
            // 
            lnkOlvidastecontraseña.AutoSize = true;
            lnkOlvidastecontraseña.Location = new Point(107, 414);
            lnkOlvidastecontraseña.Name = "lnkOlvidastecontraseña";
            lnkOlvidastecontraseña.Size = new Size(146, 15);
            lnkOlvidastecontraseña.TabIndex = 10;
            lnkOlvidastecontraseña.TabStop = true;
            lnkOlvidastecontraseña.Text = "¿Olvidaste tu constraseña?";
            // 
            // lnkNotienecuenta
            // 
            lnkNotienecuenta.AutoSize = true;
            lnkNotienecuenta.Location = new Point(89, 445);
            lnkNotienecuenta.Name = "lnkNotienecuenta";
            lnkNotienecuenta.Size = new Size(184, 15);
            lnkNotienecuenta.TabIndex = 11;
            lnkNotienecuenta.TabStop = true;
            lnkNotienecuenta.Text = "¿No tienes una cuenta? Regístrate";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(126, 214);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(169, 23);
            txtCorreo.TabIndex = 12;
            txtCorreo.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 504);
            Controls.Add(txtCorreo);
            Controls.Add(lnkNotienecuenta);
            Controls.Add(lnkOlvidastecontraseña);
            Controls.Add(btnFacebook);
            Controls.Add(btnGoogle);
            Controls.Add(lblContinuar);
            Controls.Add(lblAplicacionVME);
            Controls.Add(pic1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreoEle);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreoEle;
        private Label lblContraseña;
        private TextBox textEmail;
        private TextBox txtContraseña;
        private Button BtnIniciarSesion;
        private PictureBox pic1;
        private Label lblAplicacionVME;
        private Label lblContinuar;
        private Button btnGoogle;
        private Button btnFacebook;
        private LinkLabel lnkOlvidastecontraseña;
        private LinkLabel lnkNotienecuenta;
        private TextBox txtCorreo;
    }
}
