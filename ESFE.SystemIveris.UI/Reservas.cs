using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Reserva : Form
    {
        private readonly ReservasLN reservaLN;
        private readonly DestinosLN destinosLN;
        private readonly PasajerosLN pasajerosLN;
        private Dictionary<string, int> pasajerosDict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        public Reserva()
        {
            InitializeComponent();
            reservaLN = new ReservasLN();
            destinosLN = new DestinosLN();
            pasajerosLN = new PasajerosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarAeropuertos();
            CargarClasesAsiento();
            CargarAutocompletadoPasajeros();
        }

        // ==========================================
        //  CARGA DE DATOS (AEROPUERTOS, CLASES, PASAJEROS)
        // ==========================================

        private void CargarAeropuertos()
        {
            try
            {
                DataTable dt = destinosLN.ListarAeropuertos();
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (!dt.Columns.Contains("NombreConIata"))
                    {
                        dt.Columns.Add("NombreConIata", typeof(string), "nombre + ' (' + codigo_iata + ')'");
                    }

                    DataTable dtOrigen = dt.Copy();
                    cboOrigen.DataSource = dtOrigen;
                    cboOrigen.DisplayMember = "NombreConIata";
                    cboOrigen.ValueMember = "id_aeropuerto";

                    DataTable dtDestino = dt.Copy();
                    cboDestino.DataSource = dtDestino;
                    cboDestino.DisplayMember = "NombreConIata";
                    cboDestino.ValueMember = "id_aeropuerto";

                    if (cboDestino.Items.Count > 1)
                    {
                        cboDestino.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado de aeropuertos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarClasesAsiento()
        {
            try
            {
                DataTable dt = reservaLN.ListarClases();
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboClase.DataSource = dt;
                    cboClase.DisplayMember = "descripcion";
                    cboClase.ValueMember = "id_clase";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases de asientos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarAutocompletadoPasajeros()
        {
            try
            {
                pasajerosDict.Clear();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                DataTable dt = reservaLN.ListarPasajerosYClientes();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["NombreCompleto"]?.ToString()?.Trim() ?? "";
                        if (!string.IsNullOrWhiteSpace(nombre))
                        {
                            collection.Add(nombre);
                            if (int.TryParse(row["Id"]?.ToString(), out int id) && !pasajerosDict.ContainsKey(nombre))
                            {
                                pasajerosDict[nombre] = id;
                            }
                        }
                    }
                }

                txt5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt5.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt5.AutoCompleteCustomSource = collection;
            }
            catch { }
        }

        // ==========================================
        //  MÁSCARA Y VALIDACIÓN DE TELÉFONO (9999-9999)
        // ==========================================

        private void txtTelefono_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int cursor = txtTelefono.SelectionStart;
                string digits = new string(txtTelefono.Text.Where(char.IsDigit).ToArray());
                if (digits.Length > 8) digits = digits.Substring(0, 8);

                string formatted = digits;
                if (digits.Length > 4)
                {
                    formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
                }

                if (txtTelefono.Text != formatted)
                {
                    txtTelefono.Text = formatted;
                    txtTelefono.SelectionStart = formatted.Length;
                }
            }
            catch { }
        }

        private void txtTelefono_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            // Ya estamos en Reservas
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos formulario = new Vuelos();
            formulario.Show();
            this.Hide();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Destinos formulario = new Destinos();
            formulario.Show();
            this.Hide();
        }

        // ==========================================
        //  ACCIONES DE BOTONES (CRUD / SP)
        // ==========================================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string pasajeroInput = txt5.Text.Trim();
                if (string.IsNullOrWhiteSpace(pasajeroInput))
                {
                    MessageBox.Show("Por favor ingrese o seleccione un pasajero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt5.Focus();
                    return;
                }

                int idCliente = 1;
                if (pasajerosDict.TryGetValue(pasajeroInput, out int idDict))
                {
                    idCliente = idDict;
                }
                else if (int.TryParse(pasajeroInput, out int idParsed))
                {
                    idCliente = idParsed;
                }

                if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && txtTelefono.Text.Length != 9)
                {
                    MessageBox.Show("El número de teléfono debe tener el formato 9999-9999 (9 caracteres).", "Validación de Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono.Focus();
                    return;
                }

                ESFE.SystemIveris.EN.Reservas reserva = new ESFE.SystemIveris.EN.Reservas
                {
                    fecha_reserva = dtp1.Value,
                    id_cliente = idCliente,
                    id_est_reserva = 1
                };

                bool resultado = reservaLN.Insertar(reserva);

                if (resultado)
                {
                    string origen = cboOrigen.Text;
                    string destino = cboDestino.Text;
                    string clase = cboClase.Text;
                    MessageBox.Show($"¡Reserva guardada con éxito!\n\nRuta: {origen} ➔ {destino}\nPasajero: {pasajeroInput}\nClase: {clase}\nTeléfono: {txtTelefono.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string pasajeroInput = txt5.Text.Trim();
                int idCliente = 1;
                if (pasajerosDict.TryGetValue(pasajeroInput, out int idDict))
                {
                    idCliente = idDict;
                }
                else if (int.TryParse(pasajeroInput, out int idParsed))
                {
                    idCliente = idParsed;
                }

                ESFE.SystemIveris.EN.Reservas reserva = new ESFE.SystemIveris.EN.Reservas
                {
                    id_reserva = 1,
                    fecha_reserva = dtp1.Value,
                    id_cliente = idCliente,
                    id_est_reserva = 1
                };

                bool resultado = reservaLN.Actualizar(reserva);

                if (resultado)
                {
                    MessageBox.Show("¡Reserva modificada correctamente mediante Procedimiento Almacenado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string pasajeroInput = txt5.Text.Trim();
                int idCliente = 1;
                if (pasajerosDict.TryGetValue(pasajeroInput, out int idDict))
                {
                    idCliente = idDict;
                }
                else if (int.TryParse(pasajeroInput, out int idParsed))
                {
                    idCliente = idParsed;
                }

                List<ESFE.SystemIveris.EN.Reservas> lista = reservaLN.Buscar(idCliente);

                if (lista != null && lista.Count > 0)
                {
                    MessageBox.Show("Se encontraron " + lista.Count + " reservas para este cliente/pasajero.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron reservas para el cliente especificado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Desea eliminar la reserva seleccionada?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (reservaLN.Eliminar(1))
                    {
                        MessageBox.Show("Reserva eliminada correctamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            if (cboOrigen.Items.Count > 0) cboOrigen.SelectedIndex = 0;
            if (cboDestino.Items.Count > 1) cboDestino.SelectedIndex = 1;
            if (cboClase.Items.Count > 0) cboClase.SelectedIndex = 0;
            txt5.Clear();
            txtTelefono.Clear();
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
            txt5.Focus();
        }
    }
}