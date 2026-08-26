using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Vuelos : Form
    {
        private readonly VuelosLN vuelosLN;
        private int _idVueloSeleccionado = 0;

        public Vuelos()
        {
            InitializeComponent();
            vuelosLN = new VuelosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtpSalida.Value = DateTime.Now.AddDays(1);
            dtpLlegada.Value = DateTime.Now.AddDays(1).AddHours(4);
            CargarVuelos();
        }

        private void CargarVuelos()
        {
            try
            {
                DataTable dt = vuelosLN.ListarVuelosDetalle();
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar y cargar vuelos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CargarVuelos();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Destinos formulario = new Destinos();
            formulario.Show();
            this.Hide();
        }

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

                    if (fila.Cells["numero_vuelo"] != null && fila.Cells["numero_vuelo"].Value != null)
                    {
                        txtNumeroVuelo.Text = fila.Cells["numero_vuelo"].Value.ToString();
                    }

                    if (fila.Cells["id_aeropuerto_origen"] != null && fila.Cells["id_aeropuerto_origen"].Value != DBNull.Value)
                    {
                        txtOrigenId.Text = fila.Cells["id_aeropuerto_origen"].Value.ToString();
                    }

                    if (fila.Cells["id_aeropuerto_destino"] != null && fila.Cells["id_aeropuerto_destino"].Value != DBNull.Value)
                    {
                        txtDestinoId.Text = fila.Cells["id_aeropuerto_destino"].Value.ToString();
                    }

                    if (fila.Cells["id_avion"] != null && fila.Cells["id_avion"].Value != DBNull.Value)
                    {
                        txtAvionId.Text = fila.Cells["id_avion"].Value.ToString();
                    }

                    if (fila.Cells["Hora"] != null && fila.Cells["Hora"].Value != DBNull.Value)
                    {
                        dtpSalida.Value = Convert.ToDateTime(fila.Cells["Hora"].Value);
                    }

                    if (fila.Cells["fecha_llegada"] != null && fila.Cells["fecha_llegada"].Value != DBNull.Value)
                    {
                        dtpLlegada.Value = Convert.ToDateTime(fila.Cells["fecha_llegada"].Value);
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
                    criterio = txtNumeroVuelo.Text.Trim();
                }

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    CargarVuelos();
                    return;
                }

                DataTable dt = vuelosLN.BuscarVuelosDetalle(criterio);
                dgv1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún vuelo con ese número o destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroVuelo.Text))
                {
                    MessageBox.Show("Por favor ingresa el número de vuelo (ejemplo: IV-501).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroVuelo.Focus();
                    return;
                }

                int origenId = int.TryParse(txtOrigenId.Text.Trim(), out int oId) ? oId : 1;
                int destinoId = int.TryParse(txtDestinoId.Text.Trim(), out int dId) ? dId : 2;
                int avionId = int.TryParse(txtAvionId.Text.Trim(), out int aId) ? aId : 1;

                EN.Vuelos nuevoVuelo = new EN.Vuelos
                {
                    numero_vuelo = txtNumeroVuelo.Text.Trim(),
                    fecha_salida = dtpSalida.Value,
                    fecha_llegada = dtpLlegada.Value,
                    id_aeropuerto_origen = origenId,
                    id_aeropuerto_destino = destinoId,
                    id_avion = avionId,
                    id_est_vuelo = 1,
                    id_puerta = 1
                };

                bool resultado = vuelosLN.Insertar(nuevoVuelo);

                if (resultado)
                {
                    MessageBox.Show("Vuelo insertado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarVuelos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idVueloSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor selecciona un vuelo de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroVuelo.Text))
                {
                    MessageBox.Show("Por favor ingresa el número de vuelo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroVuelo.Focus();
                    return;
                }

                int origenId = int.TryParse(txtOrigenId.Text.Trim(), out int oId) ? oId : 1;
                int destinoId = int.TryParse(txtDestinoId.Text.Trim(), out int dId) ? dId : 2;
                int avionId = int.TryParse(txtAvionId.Text.Trim(), out int aId) ? aId : 1;

                EN.Vuelos vueloModificado = new EN.Vuelos
                {
                    id_vuelo = _idVueloSeleccionado,
                    numero_vuelo = txtNumeroVuelo.Text.Trim(),
                    fecha_salida = dtpSalida.Value,
                    fecha_llegada = dtpLlegada.Value,
                    id_aeropuerto_origen = origenId,
                    id_aeropuerto_destino = destinoId,
                    id_avion = avionId,
                    id_est_vuelo = 1,
                    id_puerta = 1
                };

                bool resultado = vuelosLN.Actualizar(vueloModificado);

                if (resultado)
                {
                    MessageBox.Show("Vuelo actualizado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarVuelos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idVueloSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor selecciona un vuelo de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show($"¿Deseas eliminar el vuelo {_idVueloSeleccionado} ({txtNumeroVuelo.Text})?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = vuelosLN.Eliminar(_idVueloSeleccionado);

                    if (resultado)
                    {
                        MessageBox.Show("Vuelo eliminado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarVuelos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LimpiarCampos();
            CargarVuelos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idVueloSeleccionado = 0;
            txtNumeroVuelo.Clear();
            txtOrigenId.Text = "1";
            txtDestinoId.Text = "2";
            txtAvionId.Text = "1";
            txtBuscar.Clear();
        }
    }
}