using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class DatosPasajero : Form
    {
        private readonly PasajerosLN pasajeroLN;
        private int _idPasajeroSeleccionado = 0;

        public DatosPasajero()
        {
            InitializeComponent();
            pasajeroLN = new PasajerosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            txt6.MaxLength = 9;
            txt6.PlaceholderText = "9999-9999";
            txt6.TextChanged += txt6_Telefono_TextChanged;
            txt6.KeyPress += txt6_Telefono_KeyPress;
        }

        private void txt6_Telefono_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                int cursor = txt6.SelectionStart;
                string digits = new string(txt6.Text.Where(char.IsDigit).ToArray());
                if (digits.Length > 8) digits = digits.Substring(0, 8);

                string formatted = digits;
                if (digits.Length > 4)
                {
                    formatted = digits.Substring(0, 4) + "-" + digits.Substring(4);
                }

                if (txt6.Text != formatted)
                {
                    txt6.Text = formatted;
                    txt6.SelectionStart = formatted.Length;
                }
            }
            catch { }
        }

        private void txt6_Telefono_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void DatosPasajero_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarPasajeros();
        }

        private void CargarPasajeros()
        {
            try
            {
                List<Pasajeros> lista = pasajeroLN.Listar();
                dgvPasajeros.DataSource = null;
                dgvPasajeros.DataSource = lista;
                ConfigurarColumnasGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar y listar pasajeros: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasGrid()
        {
            if (dgvPasajeros.Columns.Count > 0)
            {
                if (dgvPasajeros.Columns["id_pasajero"] != null)
                {
                    dgvPasajeros.Columns["id_pasajero"].HeaderText = "ID";
                    dgvPasajeros.Columns["id_pasajero"].Width = 50;
                }
                if (dgvPasajeros.Columns["nombre"] != null)
                    dgvPasajeros.Columns["nombre"].HeaderText = "Nombre";
                if (dgvPasajeros.Columns["apellido"] != null)
                    dgvPasajeros.Columns["apellido"].HeaderText = "Apellido";
                if (dgvPasajeros.Columns["pasaporte"] != null)
                    dgvPasajeros.Columns["pasaporte"].HeaderText = "Pasaporte / DUI";
                if (dgvPasajeros.Columns["id_ciudad"] != null)
                    dgvPasajeros.Columns["id_ciudad"].HeaderText = "ID Ciudad";
            }
        }

        // ==========================================
        //  NAVEGACIÓN ENTRE FORMULARIOS
        // ==========================================
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnMetodopago_Click(object sender, EventArgs e)
        {
            MetododePago metodopago = new MetododePago();
            metodopago.Show();
            this.Hide();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos vuelos = new Vuelos();
            vuelos.Show();
            this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reserva reservas = new Reserva();
            reservas.Show();
            this.Hide();
        }

        private void btndestinos_Click(object sender, EventArgs e)
        {
            Destinos destinos = new Destinos();
            destinos.Show();
            this.Hide();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            MetododePago pago = new MetododePago();
            pago.Show();
            this.Hide();
        }

        // ==========================================
        //  INTERACCIÓN CON DATAGRIDVIEW
        // ==========================================
        private void dgvPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvPasajeros.Rows.Count)
                {
                    DataGridViewRow fila = dgvPasajeros.Rows[e.RowIndex];

                    if (fila.Cells["id_pasajero"] != null && fila.Cells["id_pasajero"].Value != null)
                    {
                        _idPasajeroSeleccionado = Convert.ToInt32(fila.Cells["id_pasajero"].Value);
                    }

                    if (fila.Cells["nombre"] != null && fila.Cells["nombre"].Value != null)
                        txt1.Text = fila.Cells["nombre"].Value.ToString();

                    if (fila.Cells["apellido"] != null && fila.Cells["apellido"].Value != null)
                        txt2.Text = fila.Cells["apellido"].Value.ToString();

                    if (fila.Cells["pasaporte"] != null && fila.Cells["pasaporte"].Value != null)
                        txt4.Text = fila.Cells["pasaporte"].Value.ToString();

                    if (fila.Cells["id_ciudad"] != null && fila.Cells["id_ciudad"].Value != null)
                        txt3.Text = fila.Cells["id_ciudad"].Value.ToString();
                }
            }
            catch { }
        }

        private void btnBuscarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    CargarPasajeros();
                    return;
                }

                List<Pasajeros> lista = pasajeroLN.Buscar(criterio);
                dgvPasajeros.DataSource = null;
                dgvPasajeros.DataSource = lista;
                ConfigurarColumnasGrid();

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún pasajero con el criterio indicado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarPasajeros();
        }

        // ==========================================
        //  ACCIONES CRUD (PROCEDIMIENTOS ALMACENADOS)
        // ==========================================
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Por favor ingresa al menos Nombre y Pasaporte/DUI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Focus();
                    return;
                }

                int ciudadId = 1;
                if (!string.IsNullOrWhiteSpace(txt3.Text) && int.TryParse(txt3.Text.Trim(), out int parsedId))
                {
                    ciudadId = parsedId;
                }

                Pasajeros pasajero = new Pasajeros
                {
                    nombre = txt1.Text.Trim(),
                    apellido = txt2.Text.Trim(),
                    pasaporte = txt4.Text.Trim(),
                    id_ciudad = ciudadId
                };

                bool resultado = pasajeroLN.Insertar(pasajero);

                if (resultado)
                {
                    MessageBox.Show("Pasajero guardado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarPasajeros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pasajero: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txt4.Text.Trim();
                if (string.IsNullOrWhiteSpace(criterio))
                {
                    criterio = txt1.Text.Trim();
                }

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MessageBox.Show("Ingresa el Pasaporte/DUI o Nombre para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                List<Pasajeros> lista = pasajeroLN.Buscar(criterio);

                if (lista != null && lista.Count > 0)
                {
                    Pasajeros pasajero = lista[0];
                    _idPasajeroSeleccionado = pasajero.id_pasajero;
                    txt1.Text = pasajero.nombre;
                    txt2.Text = pasajero.apellido;
                    txt3.Text = pasajero.id_ciudad.ToString();
                    txt4.Text = pasajero.pasaporte;

                    dgvPasajeros.DataSource = null;
                    dgvPasajeros.DataSource = lista;
                    ConfigurarColumnasGrid();

                    MessageBox.Show($"Pasajero encontrado (ID: {pasajero.id_pasajero}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún pasajero con el criterio indicado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pasajero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Ingresa o busca el Pasaporte/DUI del pasajero a modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                int idPasajero = _idPasajeroSeleccionado;

                if (idPasajero == 0)
                {
                    List<Pasajeros> busqueda = pasajeroLN.Buscar(txt4.Text.Trim());
                    if (busqueda != null && busqueda.Count > 0)
                    {
                        idPasajero = busqueda[0].id_pasajero;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para modificar. Primero busca el pasajero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int ciudadId = 1;
                if (!string.IsNullOrWhiteSpace(txt3.Text) && int.TryParse(txt3.Text.Trim(), out int parsedId))
                {
                    ciudadId = parsedId;
                }

                Pasajeros pasajero = new Pasajeros
                {
                    id_pasajero = idPasajero,
                    nombre = txt1.Text.Trim(),
                    apellido = txt2.Text.Trim(),
                    pasaporte = txt4.Text.Trim(),
                    id_ciudad = ciudadId
                };

                bool resultado = pasajeroLN.Actualizar(pasajero);

                if (resultado)
                {
                    MessageBox.Show("Datos del pasajero actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarPasajeros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar pasajero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Escribe el Pasaporte/DUI o busca el pasajero para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                int idPasajero = _idPasajeroSeleccionado;

                if (idPasajero == 0)
                {
                    List<Pasajeros> busqueda = pasajeroLN.Buscar(txt4.Text.Trim());
                    if (busqueda != null && busqueda.Count > 0)
                    {
                        idPasajero = busqueda[0].id_pasajero;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún pasajero con ese Pasaporte/DUI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult confirmacion = MessageBox.Show($"¿Deseas eliminar al pasajero con ID {idPasajero} ({txt1.Text} {txt2.Text})?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (pasajeroLN.Eliminar(idPasajero))
                    {
                        MessageBox.Show("Pasajero eliminado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarPasajeros();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _idPasajeroSeleccionado = 0;
            txt1.Clear();
            txt2.Clear();
            txt3.Text = "1";
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt1.Focus();
        }
    }
}