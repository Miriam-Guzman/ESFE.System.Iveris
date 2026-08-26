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
        }

        private void DatosPasajero_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            // Continuar hacia el proceso de pago o reserva
            MetododePago pago = new MetododePago();
            pago.Show();
            this.Hide();
        }

        // --- Eventos auxiliares del formulario ---
        private void pnl1_Paint(object sender, PaintEventArgs e) { }
        private void pic1_Click(object sender, EventArgs e) { }
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

                // Si no se había buscado antes, obtener su ID por pasaporte
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

                // Si no se tiene el ID, buscarlo por pasaporte
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            _idPasajeroSeleccionado = 0;
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt1.Focus();
        }
    }
}