using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Destinos : Form
    {
        private readonly DestinosLN destinosLN;
        private int _idAeropuertoSeleccionado = 0;
        private int _idVueloSeleccionado = 0;
        private Dictionary<string, (string Iata, int IdCiudad, int IdAeropuerto)> _aeropuertosRegistrados = new Dictionary<string, (string, int, int)>(StringComparer.OrdinalIgnoreCase);
        private bool _isUpdatingIata = false;

        public Destinos()
        {
            InitializeComponent();
            destinosLN = new DestinosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            cboNombreDestino.SelectedIndexChanged += cboNombreDestino_SelectedIndexChanged;
            cboNombreDestino.TextChanged += cboNombreDestino_TextChanged;
        }

        private void Destinos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarComboAeropuertos();
            CargarDestinos();
        }

        private void CargarComboAeropuertos()
        {
            try
            {
                _aeropuertosRegistrados.Clear();
                cboNombreDestino.Items.Clear();

                DataTable dt = destinosLN.ListarAeropuertos();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["nombre"]?.ToString()?.Trim() ?? "";
                        string iata = row["codigo_iata"]?.ToString()?.Trim() ?? "";
                        int idCiudad = (row["id_ciudad"] != DBNull.Value) ? Convert.ToInt32(row["id_ciudad"]) : 1;
                        int idAeropuerto = (row["id_aeropuerto"] != DBNull.Value) ? Convert.ToInt32(row["id_aeropuerto"]) : 0;

                        if (!string.IsNullOrWhiteSpace(nombre) && !_aeropuertosRegistrados.ContainsKey(nombre))
                        {
                            _aeropuertosRegistrados[nombre] = (iata, idCiudad, idAeropuerto);
                            cboNombreDestino.Items.Add(nombre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista de aeropuertos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        //  ASIGNACIÓN AUTOMÁTICA DE CÓDIGO IATA
        // ==========================================

        private void cboNombreDestino_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AsignarIataSegunNombre(cboNombreDestino.Text);
        }

        private void cboNombreDestino_TextChanged(object? sender, EventArgs e)
        {
            AsignarIataSegunNombre(cboNombreDestino.Text);
        }

        private void AsignarIataSegunNombre(string nombre)
        {
            if (_isUpdatingIata) return;

            string nombreLimpio = nombre?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(nombreLimpio))
            {
                txtCodigoIata.Clear();
                return;
            }

            if (_aeropuertosRegistrados.TryGetValue(nombreLimpio, out var info))
            {
                _isUpdatingIata = true;
                txtCodigoIata.Text = info.Iata;
                txtIdCiudad.Text = info.IdCiudad.ToString();
                _idAeropuertoSeleccionado = info.IdAeropuerto;
                _isUpdatingIata = false;
            }
            else
            {
                // Generar código IATA sugerido de 3 letras automáticamente
                string iataSugerido = GenerarCodigoIataAutomatico(nombreLimpio);
                _isUpdatingIata = true;
                txtCodigoIata.Text = iataSugerido;
                _isUpdatingIata = false;
            }
        }

        private string GenerarCodigoIataAutomatico(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return "";

            // Tomar sólo letras
            string letras = new string(nombre.Where(char.IsLetter).ToArray()).ToUpper();
            if (letras.Length >= 3)
            {
                return letras.Substring(0, 3);
            }
            return letras.PadRight(3, 'X');
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
            CargarDestinos();
            CargarComboAeropuertos();
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
                        string destinoCompleto = fila.Cells["Destino"].Value.ToString() ?? "";
                        if (destinoCompleto.Contains("("))
                        {
                            destinoCompleto = destinoCompleto.Substring(0, destinoCompleto.IndexOf("(")).Trim();
                        }
                        cboNombreDestino.Text = destinoCompleto;
                    }

                    if (fila.Cells["RutasDisponible"] != null && fila.Cells["RutasDisponible"].Value != null)
                    {
                        string ruta = fila.Cells["RutasDisponible"].Value.ToString() ?? "";
                        if (ruta.Contains("->"))
                        {
                            string[] partes = ruta.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                            if (partes.Length > 1)
                            {
                                txtCodigoIata.Text = partes[1].Trim().ToUpper();
                            }
                        }
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
                string nombreAeropuerto = cboNombreDestino.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombreAeropuerto))
                {
                    MessageBox.Show("Por favor ingresa o selecciona el Nombre del Aeropuerto/Destino.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNombreDestino.Focus();
                    return;
                }

                string codigoIata = txtCodigoIata.Text.Trim().ToUpper();
                if (string.IsNullOrWhiteSpace(codigoIata))
                {
                    codigoIata = GenerarCodigoIataAutomatico(nombreAeropuerto);
                    txtCodigoIata.Text = codigoIata;
                }
                if (codigoIata.Length > 3) codigoIata = codigoIata.Substring(0, 3);

                int idCiudad = 1;
                if (!string.IsNullOrWhiteSpace(txtIdCiudad.Text) && int.TryParse(txtIdCiudad.Text.Trim(), out int parsedId))
                {
                    idCiudad = parsedId;
                }

                bool resultado = destinosLN.InsertarAeropuerto(nombreAeropuerto, codigoIata, idCiudad);

                if (resultado)
                {
                    MessageBox.Show($"¡Destino '{nombreAeropuerto}' con código IATA '{codigoIata}' guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarComboAeropuertos();
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
                string nombreAeropuerto = cboNombreDestino.Text.Trim();
                if (_idAeropuertoSeleccionado <= 0)
                {
                    if (_aeropuertosRegistrados.TryGetValue(nombreAeropuerto, out var info))
                    {
                        _idAeropuertoSeleccionado = info.IdAeropuerto;
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un destino de la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(nombreAeropuerto))
                {
                    MessageBox.Show("Ingresa el nombre del destino/aeropuerto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboNombreDestino.Focus();
                    return;
                }

                string codigoIata = string.IsNullOrWhiteSpace(txtCodigoIata.Text) ? GenerarCodigoIataAutomatico(nombreAeropuerto) : txtCodigoIata.Text.Trim().ToUpper();
                if (codigoIata.Length > 3) codigoIata = codigoIata.Substring(0, 3);

                int idCiudad = 1;
                if (!string.IsNullOrWhiteSpace(txtIdCiudad.Text) && int.TryParse(txtIdCiudad.Text.Trim(), out int parsedId))
                {
                    idCiudad = parsedId;
                }

                bool resultado = destinosLN.ActualizarAeropuerto(_idAeropuertoSeleccionado, nombreAeropuerto, codigoIata, idCiudad);

                if (resultado)
                {
                    MessageBox.Show("Destino actualizado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarComboAeropuertos();
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
                        CargarComboAeropuertos();
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
            CargarComboAeropuertos();
            CargarDestinos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idAeropuertoSeleccionado = 0;
            _idVueloSeleccionado = 0;
            cboNombreDestino.Text = "";
            cboNombreDestino.SelectedIndex = -1;
            txtCodigoIata.Clear();
            txtIdCiudad.Text = "1";
        }
    }
}