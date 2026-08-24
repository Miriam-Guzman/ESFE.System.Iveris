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

        public DatosPasajero()
        {
            InitializeComponent();
            pasajeroLN = new PasajerosLN();
        }

        // --- MÉTODOS DE EVENTOS VACÍOS DE LA INTERFAZ ---
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            btnInsertar_Click(sender, e);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            btnModificar_Click(sender, e);
        }
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
        private void btncontinuar_Click(object sender, EventArgs e) { }

        // ==========================================
        //  ACCIONES DE BOTONES (TRES CAPAS / SP)
        // ==========================================

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Por favor ingresa Nombre y Pasaporte/DUI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Focus();
                    return;
                }

                Pasajeros pasajero = new Pasajeros
                {
                    nombre = txt1.Text.Trim(),
                    apellido = txt2.Text.Trim(),
                    pasaporte = txt4.Text.Trim(),
                    id_ciudad = string.IsNullOrEmpty(txt3.Text) ? 1 : Convert.ToInt32(txt3.Text.Trim())
                };

                bool resultado = pasajeroLN.Insertar(pasajero);

                if (resultado)
                {
                    MessageBox.Show("Pasajero guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Escribe el Pasaporte/DUI para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                List<Pasajeros> lista = pasajeroLN.Buscar(txt4.Text.Trim());

                if (lista != null && lista.Count > 0)
                {
                    txt1.Text = lista[0].nombre;
                    txt2.Text = lista[0].apellido;
                    txt3.Text = lista[0].id_ciudad.ToString();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Ingresa el Pasaporte/DUI del pasajero a actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                Pasajeros pasajero = new Pasajeros
                {
                    nombre = txt1.Text.Trim(),
                    apellido = txt2.Text.Trim(),
                    pasaporte = txt4.Text.Trim(),
                    id_ciudad = string.IsNullOrEmpty(txt3.Text) ? 1 : Convert.ToInt32(txt3.Text.Trim())
                };

                bool resultado = pasajeroLN.Actualizar(pasajero);

                if (resultado)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt4.Text))
                {
                    MessageBox.Show("Escribe el Pasaporte/DUI para eliminar al pasajero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt4.Focus();
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (pasajeroLN.Eliminar(Convert.ToInt32(txt4.Text.Trim())))
                    {
                        MessageBox.Show("Pasajero eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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