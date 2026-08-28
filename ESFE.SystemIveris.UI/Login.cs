using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Login : Form
    {
        private readonly ClientesLN clientesLN;

        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            clientesLN = new ClientesLN();

            txtRegTelefono.MaxLength = 9;
            txtRegTelefono.PlaceholderText = "9999-9999";
            txtRegTelefono.TextChanged += txtRegTelefono_TextChanged;
            txtRegTelefono.KeyPress += txtRegTelefono_KeyPress;
        }

        private void txtRegTelefono_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int cursor = txtRegTelefono.SelectionStart;
                string digits = new string(txtRegTelefono.Text.Where(char.IsDigit).ToArray());
                if (digits.Length > 8) digits = digits.Substring(0, 8);

                string formatted = digits;
                if (digits.Length > 4)
                {
                    formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
                }

                if (txtRegTelefono.Text != formatted)
                {
                    txtRegTelefono.Text = formatted;
                    txtRegTelefono.SelectionStart = formatted.Length;
                }
            }
            catch { }
        }

        private void txtRegTelefono_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarCiudades();
            CenterCard();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void CargarCiudades()
        {
            try
            {
                DataTable dt = clientesLN.ListarCiudades();
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboRegCiudad.DataSource = dt;
                    cboRegCiudad.DisplayMember = "nombre_ciudad";
                    cboRegCiudad.ValueMember = "id_ciudad";
                }
                else
                {
                    DataTable dtFallback = new DataTable();
                    dtFallback.Columns.Add("id_ciudad", typeof(int));
                    dtFallback.Columns.Add("nombre_ciudad", typeof(string));
                    dtFallback.Rows.Add(1, "San Salvador");
                    dtFallback.Rows.Add(2, "Miami");
                    dtFallback.Rows.Add(3, "Ciudad de Mexico");
                    dtFallback.Rows.Add(4, "Madrid");

                    cboRegCiudad.DataSource = dtFallback;
                    cboRegCiudad.DisplayMember = "nombre_ciudad";
                    cboRegCiudad.ValueMember = "id_ciudad";
                }
            }
            catch
            {
                DataTable dtFallback = new DataTable();
                dtFallback.Columns.Add("id_ciudad", typeof(int));
                dtFallback.Columns.Add("nombre_ciudad", typeof(string));
                dtFallback.Rows.Add(1, "San Salvador");
                cboRegCiudad.DataSource = dtFallback;
                cboRegCiudad.DisplayMember = "nombre_ciudad";
                cboRegCiudad.ValueMember = "id_ciudad";
            }
        }

        private void CenterCard()
        {
            if (pnlMain != null)
            {
                if (pnlCard != null && pnlCard.Visible)
                    pnlCard.Left = Math.Max(20, (pnlMain.ClientSize.Width - pnlCard.Width) / 2);

                if (pnlCardRegistro != null && pnlCardRegistro.Visible)
                    pnlCardRegistro.Left = Math.Max(20, (pnlMain.ClientSize.Width - pnlCardRegistro.Width) / 2);
            }
            if (pnl1 != null && picLogo != null)
            {
                picLogo.Left = (pnl1.ClientSize.Width - picLogo.Width) / 2;
                if (lblAppTitle != null)
                    lblAppTitle.Left = (pnl1.ClientSize.Width - lblAppTitle.Width) / 2;
            }
        }

        // ==========================================
        // LÓGICA DE INICIO DE SESIÓN
        // ==========================================
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, ingresa tu correo electrónico y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Clientes? cliente = clientesLN.IniciarSesion(email, contrasena);

                if (cliente != null)
                {
                    MessageBox.Show($"¡Bienvenido/a a System Iveris, {cliente.nombre} {cliente.apellido}!", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Inicio formInicio = new Inicio();
                    formInicio.FormClosed += (s, args) => this.Close();
                    formInicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContraseña.Focus();
                e.SuppressKeyPress = true;
            }
        }

        // ==========================================
        // CAMBIAR A VISTA DE REGISTRO
        // ==========================================
        private void lnkNotienecuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlCard.Visible = false;
            pnlCardRegistro.Visible = true;
            CenterCard();
            txtRegNombre.Focus();
        }

        // ==========================================
        // CAMBIAR A VISTA DE LOGIN
        // ==========================================
        private void lnkYaTengoCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlCardRegistro.Visible = false;
            pnlCard.Visible = true;
            CenterCard();
            txtCorreo.Focus();
        }

        // ==========================================
        // LÓGICA DE REGISTRO DE NUEVO CLIENTE
        // ==========================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtRegNombre.Text.Trim();
            string apellido = txtRegApellido.Text.Trim();
            string email = txtRegCorreo.Text.Trim();
            string telefono = txtRegTelefono.Text.Trim();
            string contrasena = txtRegContraseña.Text.Trim();
            string confirmar = txtRegConfirmar.Text.Trim();

            // 1. Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Por favor, completa todos los campos para registrarte.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar formato de correo
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido (ejemplo: usuario@correo.com).", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegCorreo.Focus();
                return;
            }

            // 3. Validar longitud mínima de contraseña
            if (contrasena.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.", "Contraseña muy corta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegContraseña.Focus();
                return;
            }

            // 4. Validar que las contraseñas coincidan
            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegConfirmar.Focus();
                return;
            }

            try
            {
                // 5. Validar que el correo no esté ya registrado
                if (clientesLN.ExisteEmail(email))
                {
                    MessageBox.Show("El correo electrónico ya se encuentra registrado. Por favor, inicia sesión con tu cuenta.", "Correo ya existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRegCorreo.Focus();
                    return;
                }

                // 6. Obtener ciudad seleccionada
                int idCiudad = 1;
                if (cboRegCiudad.SelectedValue != null && int.TryParse(cboRegCiudad.SelectedValue.ToString(), out int parsedId))
                {
                    idCiudad = parsedId;
                }

                // 7. Crear el cliente
                Clientes nuevoCliente = new Clientes
                {
                    nombre = nombre,
                    apellido = apellido,
                    email = email,
                    telefono = telefono,
                    id_ciudad = idCiudad,
                    contrasena = contrasena
                };

                bool resultado = clientesLN.Registrar(nuevoCliente);

                if (resultado)
                {
                    MessageBox.Show($"¡Cuenta creada con éxito!\nBienvenido/a a System Iveris, {nombre} {apellido}.\n\nYa puedes iniciar sesión con tu correo y contraseña.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar formulario de registro
                    txtRegNombre.Clear();
                    txtRegApellido.Clear();
                    txtRegCorreo.Clear();
                    txtRegTelefono.Clear();
                    txtRegContraseña.Clear();
                    txtRegConfirmar.Clear();

                    // Prellenar en el login y cambiar de vista
                    txtCorreo.Text = email;
                    txtContraseña.Text = contrasena;

                    pnlCardRegistro.Visible = false;
                    pnlCard.Visible = true;
                    CenterCard();
                    btnIniciarSesion_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente. Por favor, intenta de nuevo.", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnksalirapp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}