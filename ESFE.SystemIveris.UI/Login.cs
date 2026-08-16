using System;
using System.Windows.Forms;

namespace ESFE.SystemIveris.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar credenciales (ejemplo de prueba)
            if (txtCorreo.Text == "admin@iveris.com" && txtContraseña.Text == "12345")
            {
                MessageBox.Show("¡Bienvenido a SystemIveris!", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}