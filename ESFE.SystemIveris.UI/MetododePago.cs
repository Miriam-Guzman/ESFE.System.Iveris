using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class MetododePago : Form
    {
        private readonly PagosLN pagosLN;
        private int _idPagoSeleccionado = 0;
        private int _idMetodoPagoSeleccionado = 1; // 1: Tarjeta Crédito/Débito por defecto

        public MetododePago()
        {
            InitializeComponent();
            pagosLN = new PagosLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MetododePago_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarPaises();
            CargarPagos();
        }

        private void CargarPaises()
        {
            try
            {
                DataTable dtPaises = pagosLN.ListarPaises();
                if (dtPaises != null && dtPaises.Rows.Count > 0)
                {
                    cmbpaises.DataSource = dtPaises;
                    cmbpaises.DisplayMember = "nombre_pais";
                    cmbpaises.ValueMember = "id_pais";
                }
                else
                {
                    cmbpaises.Items.Clear();
                    cmbpaises.Items.Add("El Salvador");
                    cmbpaises.Items.Add("Guatemala");
                    cmbpaises.Items.Add("Honduras");
                    cmbpaises.Items.Add("Estados Unidos");
                    cmbpaises.SelectedIndex = 0;
                }
            }
            catch
            {
                cmbpaises.Items.Clear();
                cmbpaises.Items.Add("El Salvador");
                cmbpaises.Items.Add("Guatemala");
                cmbpaises.Items.Add("Honduras");
                cmbpaises.Items.Add("Estados Unidos");
                cmbpaises.SelectedIndex = 0;
            }
        }

        private void CargarPagos()
        {
            try
            {
                DataTable dtPagos = pagosLN.ListarPagosDetalle();
                dgvPagos.DataSource = dtPagos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar y listar pagos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnMétodopago_Click(object sender, EventArgs e)
        {
            CargarPagos();
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

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva();
            formulario.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            _idMetodoPagoSeleccionado = 1;
            btnO.Text = "●";
            MessageBox.Show("Método de pago seleccionado: Tarjeta Crédito/Débito.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        //  INTERACCIÓN CON DATAGRIDVIEW
        // ==========================================
        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvPagos.Rows.Count)
                {
                    DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];

                    if (fila.Cells["id_pago"] != null && fila.Cells["id_pago"].Value != DBNull.Value)
                    {
                        _idPagoSeleccionado = Convert.ToInt32(fila.Cells["id_pago"].Value);
                        txt00000.Text = _idPagoSeleccionado.ToString();
                    }

                    if (fila.Cells["Cliente"] != null && fila.Cells["Cliente"].Value != DBNull.Value)
                    {
                        txtNomTitular.Text = fila.Cells["Cliente"].Value.ToString();
                    }

                    if (fila.Cells["fecha_pago"] != null && fila.Cells["fecha_pago"].Value != DBNull.Value)
                    {
                        dtpFecha.Value = Convert.ToDateTime(fila.Cells["fecha_pago"].Value);
                    }
                }
            }
            catch { }
        }

        private void btnRefrescarPagos_Click(object sender, EventArgs e)
        {
            CargarPagos();
        }

        // ==========================================
        //  ACCIONES CRUD (PROCEDIMIENTOS ALMACENADOS)
        // ==========================================

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            EjecutarInsertarPago();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EjecutarInsertarPago();
        }

        private void EjecutarInsertarPago()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomTitular.Text) || string.IsNullOrWhiteSpace(txtnumeroTarjeta.Text))
                {
                    MessageBox.Show("Por favor ingresa Nombre del titular y Número de tarjeta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomTitular.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtccv.Text))
                {
                    MessageBox.Show("Por favor ingresa el código de seguridad CCV.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtccv.Focus();
                    return;
                }

                Pagos nuevoPago = new Pagos
                {
                    fecha_pago = DateTime.Now,
                    monto = 150.00m,
                    id_reserva = 1,
                    id_est_pago = 1,
                    id_met_pago = _idMetodoPagoSeleccionado
                };

                bool resultado = pagosLN.Insertar(nuevoPago);

                if (resultado)
                {
                    MessageBox.Show("¡Pago procesado y registrado exitosamente en la base de datos mediante Procedimiento Almacenado!", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPagos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idBuscar = 1;
                if (!string.IsNullOrWhiteSpace(txt00000.Text) && int.TryParse(txt00000.Text.Trim(), out int parsedId) && parsedId > 0)
                {
                    idBuscar = parsedId;
                }

                List<Pagos> lista = pagosLN.BuscarPago(idBuscar, null);

                if (lista != null && lista.Count > 0)
                {
                    Pagos pago = lista[0];
                    _idPagoSeleccionado = pago.id_pago;
                    txtNomTitular.Text = "Titular Pago #" + pago.id_pago;
                    txtnumeroTarjeta.Text = "**** **** **** " + (1000 + pago.id_pago % 1000);
                    txtccv.Text = "123";
                    dtpFecha.Value = pago.fecha_pago;
                    txt00000.Text = pago.id_pago.ToString();

                    MessageBox.Show($"Pago encontrado: ID #{pago.id_pago}, Monto: ${pago.monto:F2}, Fecha: {pago.fecha_pago:g}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro de pago con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = _idPagoSeleccionado;

                if (idPago <= 0)
                {
                    if (!string.IsNullOrWhiteSpace(txt00000.Text) && int.TryParse(txt00000.Text.Trim(), out int parsedId) && parsedId > 0)
                    {
                        idPago = parsedId;
                    }
                    else
                    {
                        MessageBox.Show("Primero busca o especifica el ID del pago a modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Pagos pagoActualizar = new Pagos
                {
                    id_pago = idPago,
                    fecha_pago = dtpFecha.Value,
                    monto = 150.00m,
                    id_reserva = 1,
                    id_est_pago = 1,
                    id_met_pago = _idMetodoPagoSeleccionado
                };

                bool resultado = pagosLN.Actualizar(pagoActualizar);

                if (resultado)
                {
                    MessageBox.Show("Pago actualizado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPagos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPago = _idPagoSeleccionado;

                if (idPago <= 0)
                {
                    if (!string.IsNullOrWhiteSpace(txt00000.Text) && int.TryParse(txt00000.Text.Trim(), out int parsedId) && parsedId > 0)
                    {
                        idPago = parsedId;
                    }
                    else
                    {
                        MessageBox.Show("Primero busca o ingresa el ID del pago a eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult confirmacion = MessageBox.Show($"¿Deseas eliminar el registro de pago #{idPago}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = pagosLN.Eliminar(idPago);

                    if (resultado)
                    {
                        MessageBox.Show("Pago eliminado exitosamente mediante Procedimiento Almacenado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarPagos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            _idPagoSeleccionado = 0;
            txtNomTitular.Clear();
            txtnumeroTarjeta.Clear();
            txtccv.Clear();
            txtIngresacuidad.Clear();
            txt00000.Text = "1";
            btnO.Text = "●";
            txtNomTitular.Focus();
        }
    }
}