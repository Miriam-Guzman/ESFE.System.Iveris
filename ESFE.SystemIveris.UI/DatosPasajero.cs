using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ESFE.SystemIveris.UI
{
    public partial class DatosPasajero : Form
    {
        // Se agrega @ al inicio para que reconozca la barra diagonal de SQLEXPRESS sin dar error
        private readonly string conexionString = @"Server=MIRIAM\SQLEXPRESS;Database=IVERIS_DB;Integrated Security=True;";

        public DatosPasajero()
        {
            InitializeComponent();
        }

        // --- MÉTODOS DE EVENTOS VACÍOS DE LA INTERFAZ ---
        private void DatosPasajero_Load(object sender, EventArgs e) { }
        private void pnl1_Paint(object sender, PaintEventArgs e) { }
        private void pic1_Click(object sender, EventArgs e) { }
        private void btnInicio_Click(object sender, EventArgs e) { }
        private void btnMetodopago_Click(object sender, EventArgs e) { }
        private void btnVuelos_Click(object sender, EventArgs e) { }
        private void btnReservas_Click(object sender, EventArgs e) { }
        private void btndestinos_Click(object sender, EventArgs e) { }
        private void lblDastospasajero_Click(object sender, EventArgs e) { }
        private void lblNombres_Click(object sender, EventArgs e) { }
        private void txt1_TextChanged(object sender, EventArgs e) { }
        private void lblApellidos_Click(object sender, EventArgs e) { }
        private void txt2_TextChanged(object sender, EventArgs e) { }
        private void lblfechanacimiento_Click(object sender, EventArgs e) { }
        private void dtp1_ValueChanged(object sender, EventArgs e) { }
        private void lblnacionalidad_Click(object sender, EventArgs e) { }
        private void txt3_TextChanged(object sender, EventArgs e) { }
        private void lblNumeroPasaporteDui_Click(object sender, EventArgs e) { }
        private void txt4_TextChanged(object sender, EventArgs e) { }
        private void lblCorreoElectro_Click(object sender, EventArgs e) { }
        private void txt5_TextChanged(object sender, EventArgs e) { }
        private void lblNumeroTelefon_Click(object sender, EventArgs e) { }
        private void txt6_TextChanged(object sender, EventArgs e) { }

        // --- BOTÓN INSERTAR ---
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Por favor ingresa Nombre y Pasaporte/DUI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Pasajeros (nombre, apellido, pasaporte, id_ciudad) VALUES (@nombre, @apellido, @pasaporte, @id_ciudad)";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txt1.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txt2.Text.Trim());
                cmd.Parameters.AddWithValue("@pasaporte", txt4.Text.Trim());
                cmd.Parameters.AddWithValue("@id_ciudad", string.IsNullOrEmpty(txt3.Text) ? 1 : Convert.ToInt32(txt3.Text.Trim()));

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pasajero guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN BUSCAR ---
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Escribe el Pasaporte/DUI para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT nombre, apellido, id_ciudad FROM Pasajeros WHERE pasaporte = @pasaporte";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@pasaporte", txt4.Text.Trim());

                try
                {
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt1.Text = reader["nombre"].ToString();
                        txt2.Text = reader["apellido"].ToString();
                        txt3.Text = reader["id_ciudad"].ToString();
                        MessageBox.Show("Pasajero encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún pasajero con ese número de Pasaporte/DUI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN ACTUALIZAR ---
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Ingresa el Pasaporte/DUI del pasajero a actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Pasajeros SET nombre = @nombre, apellido = @apellido, id_ciudad = @id_ciudad WHERE pasaporte = @pasaporte";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txt1.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", txt2.Text.Trim());
                cmd.Parameters.AddWithValue("@pasaporte", txt4.Text.Trim());
                cmd.Parameters.AddWithValue("@id_ciudad", string.IsNullOrEmpty(txt3.Text) ? 1 : Convert.ToInt32(txt3.Text.Trim()));

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún pasajero con ese Pasaporte/DUI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN ELIMINAR ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show("Escribe el Pasaporte/DUI para eliminar al pasajero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Pasajeros WHERE pasaporte = @pasaporte";

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@pasaporte", txt4.Text.Trim());

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Pasajero eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pasajero especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e) { }

        private void LimpiarFormulario()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }
    }
}