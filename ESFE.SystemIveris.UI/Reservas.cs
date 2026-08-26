using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.LN;

namespace ESFE.SystemIveris.UI
{
    public partial class Reserva : Form
    {
        private readonly ReservasLN reservaLN;

        public Reserva()
        {
            InitializeComponent();
            reservaLN = new ReservasLN();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
                if (!int.TryParse(txt5.Text.Trim(), out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID de cliente válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt5.Focus();
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
                    MessageBox.Show("¡Reserva guardada con éxito mediante Procedimiento Almacenado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt1.Text.Trim(), out int idReserva))
                {
                    MessageBox.Show("Ingrese el ID de la reserva a modificar en el primer campo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Focus();
                    return;
                }

                if (!int.TryParse(txt5.Text.Trim(), out int idCliente))
                {
                    MessageBox.Show("Ingrese un ID de cliente válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt5.Focus();
                    return;
                }

                ESFE.SystemIveris.EN.Reservas reserva = new ESFE.SystemIveris.EN.Reservas
                {
                    id_reserva = idReserva,
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
                if (!int.TryParse(txt5.Text.Trim(), out int idCliente))
                {
                    MessageBox.Show("Ingrese el ID del cliente para buscar sus reservas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt5.Focus();
                    return;
                }

                List<ESFE.SystemIveris.EN.Reservas> lista = reservaLN.Buscar(idCliente);

                if (lista != null && lista.Count > 0)
                {
                    MessageBox.Show("Se encontraron " + lista.Count + " reservas para este cliente.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para el cliente especificado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!int.TryParse(txt1.Text.Trim(), out int idReserva))
                {
                    MessageBox.Show("Ingrese el ID de la reserva a eliminar en el primer campo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Focus();
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Desea eliminar la reserva #" + idReserva + "?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (reservaLN.Eliminar(idReserva))
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
            txt1.Clear();
            txt2.Clear();
            txt5.Clear();
            txt6.Clear();
            dtp1.Value = DateTime.Now;
            dtp2.Value = DateTime.Now;
            txt1.Focus();
        }
    }
}