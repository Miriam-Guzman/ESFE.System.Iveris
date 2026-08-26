using System;
using System.Data;
using System.Windows.Forms;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Destinos : Form
    {
        private readonly DestinosLN destinosLN;
        private int _idAeropuertoSeleccionado = 0;
        private int _idVueloSeleccionado = 0;

        public Destinos()
        {
            InitializeComponent();
            destinosLN = new DestinosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Destinos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarDestinos();
        }

        private void CargarDestinos()
        {
            try
            {
                DataTable dt = destinosLN.ListarDestinos();
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar y cargar destinos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        //  NAVEGACIÓN ENTRE FORMULARIOS
        // ==========================================
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnMetodopago_Click(object sender, EventArgs e)
        {
            MetododePago formulario = new MetododePago();
            formulario.Show();
            this.Hide();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva();
            formulario.Show();
            this.Hide();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos formulario = new Vuelos();
            formulario.Show();
            this.Hide();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            // Ya estamos en Destinos
            CargarDestinos();
        }

        private void pic1_Click(object sender, EventArgs e) { }
        private void pnl1_Paint(object sender, PaintEventArgs e) { }

        // ==========================================
        //  INTERACCIÓN CON DATAGRIDVIEW
        // ==========================================
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv1.Rows.Count)
                {
                    DataGridViewRow fila = dgv1.Rows[e.RowIndex];

                    if (fila.Cells["id_vuelo"] != null && fila.Cells["id_vuelo"].Value != DBNull.Value)
                    {
                        _idVueloSeleccionado = Convert.ToInt32(fila.Cells["id_vuelo"].Value);
                    }

                    if (fila.Cells["id_aeropuerto_destino"] != null && fila.Cells["id_aeropuerto_destino"].Value != DBNull.Value)
                    {
                        _idAeropuertoSeleccionado = Convert.ToInt32(fila.Cells["id_aeropuerto_destino"].Value);
                    }
                    else if (fila.Cells["id_aeropuerto"] != null && fila.Cells["id_aeropuerto"].Value != DBNull.Value)
                    {
                        _idAeropuertoSeleccionado = Convert.ToInt32(fila.Cells["id_aeropuerto"].Value);
                    }

                    if (fila.Cells["Destino"] != null && fila.Cells["Destino"].Value != null)
                    {
                        txtNombreDestino.Text = fila.Cells["Destino"].Value.ToString();
                    }
                }
            }
            catch { }
        }

        // ==========================================
        //  ACCIONES CRUD (PROCEDIMIENTOS ALMACENADOS)
        // ==========================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    CargarDestinos();
                    return;
                }

                DataTable dt = destinosLN.BuscarDestinos(criterio);
                dgv1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron destinos con ese criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar destinos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreDestino.Text) || string.IsNullOrWhiteSpace(txtCodigoIata.Text))
                {
                    MessageBox.Show("Por favor ingresa Nombre del Aeropuerto/Destino y Código IATA.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreDestino.Focus();
                    return;
                }

                int idCiudad = 1;
                if (!string.IsNullOrWhiteSpace(txtIdCiudad.Text) && int.TryParse(txtIdCiudad.Text.Trim(), out int parsedId))
                {
                    idCiudad = parsedId;
                }

                string codigoIata = txtCodigoIata.Text.Trim().ToUpper();
                if (codigoIata.Length > 3) codigoIata = codigoIata.Substring(0, 3);

                bool resultado = destinosLN.InsertarAeropuerto(txtNombreDestino.Text.Trim(), codigoIata, idCiudad);

                if (resultado)
                {
                    MessageBox.Show("Destino/Aeropuerto guardado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDestinos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idAeropuertoSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor selecciona un destino de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreDestino.Text))
                {
                    MessageBox.Show("Ingresa el nombre del destino/aeropuerto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreDestino.Focus();
                    return;
                }

                string codigoIata = string.IsNullOrWhiteSpace(txtCodigoIata.Text) ? "DES" : txtCodigoIata.Text.Trim().ToUpper();
                if (codigoIata.Length > 3) codigoIata = codigoIata.Substring(0, 3);

                int idCiudad = 1;
                if (!string.IsNullOrWhiteSpace(txtIdCiudad.Text) && int.TryParse(txtIdCiudad.Text.Trim(), out int parsedId))
                {
                    idCiudad = parsedId;
                }

                bool resultado = destinosLN.ActualizarAeropuerto(_idAeropuertoSeleccionado, txtNombreDestino.Text.Trim(), codigoIata, idCiudad);

                if (resultado)
                {
                    MessageBox.Show("Destino actualizado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarDestinos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idVueloSeleccionado <= 0 && _idAeropuertoSeleccionado <= 0)
                {
                    MessageBox.Show("Selecciona un destino de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar este destino?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = false;
                    if (_idVueloSeleccionado > 0)
                    {
                        eliminado = destinosLN.EliminarVuelo(_idVueloSeleccionado);
                    }
                    else if (_idAeropuertoSeleccionado > 0)
                    {
                        eliminado = destinosLN.EliminarAeropuerto(_idAeropuertoSeleccionado);
                    }

                    if (eliminado)
                    {
                        MessageBox.Show("Destino eliminado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarDestinos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LimpiarCampos();
            CargarDestinos();
        }

        private void LimpiarCampos()
        {
            _idAeropuertoSeleccionado = 0;
            _idVueloSeleccionado = 0;
            txtNombreDestino.Clear();
            txtCodigoIata.Clear();
            txtIdCiudad.Text = "1";
        }
    }
}