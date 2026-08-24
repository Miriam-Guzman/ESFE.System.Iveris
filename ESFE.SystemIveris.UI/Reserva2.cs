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
    public partial class Reserva2 : Form
    {
        public Reserva2()
        {
            InitializeComponent();
        }

        // --- MÉTODOS DE EVENTOS VACÍOS DE LA INTERFAZ ---
        private void pic2_Click(object sender, EventArgs e) { }
        private void Reserva2_Load(object sender, EventArgs e) { }
        private void pnl1_Paint(object sender, PaintEventArgs e) { }
        private void pic1_Click(object sender, EventArgs e) { }
        private void txt1_TextChanged(object sender, EventArgs e) { }
        private void txt2_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void lbl1_Click(object sender, EventArgs e) { }
        private void lblTipoclase_Click(object sender, EventArgs e) { }
        private void pnl01_Paint(object sender, PaintEventArgs e) { }
        private void pic2_Click_1(object sender, EventArgs e) { }
        private void lbl2_Click(object sender, EventArgs e) { }
        private void lblhora_Click(object sender, EventArgs e) { }
        private void lblsal_Click(object sender, EventArgs e) { }
        private void lblHM_Click(object sender, EventArgs e) { }
        private void lbl_____________Click(object sender, EventArgs e) { }
        private void lblHM2_Click(object sender, EventArgs e) { }
        private void lblHora2_Click(object sender, EventArgs e) { }
        private void lblgua_Click(object sender, EventArgs e) { }
        private void lbldinero_Click(object sender, EventArgs e) { }
        private void lblporpsjr_Click(object sender, EventArgs e) { }
        private void pic3_Click(object sender, EventArgs e) { }
        private void pnl2_Paint(object sender, PaintEventArgs e) { }
        private void lbl12_Click(object sender, EventArgs e) { }
        private void lbl11_Click(object sender, EventArgs e) { }
        private void lbl10_Click(object sender, EventArgs e) { }
        private void lbl9_Click(object sender, EventArgs e) { }
        private void lbl7_Click(object sender, EventArgs e) { }
        private void lbl8_Click(object sender, EventArgs e) { }
        private void lbl6_Click(object sender, EventArgs e) { }
        private void lbl5_Click(object sender, EventArgs e) { }
        private void lbl4_Click(object sender, EventArgs e) { }
        private void lbl3_Click(object sender, EventArgs e) { }

        // ==========================================
        //  BARRA DE NAVEGACIÓN SUPERIOR
        // ==========================================

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio();
            frm.Show();
            this.Hide();
        }

        private void btnMetodopago_Click(object sender, EventArgs e)
        {
            MetododePago frm = new MetododePago();
            frm.Show();
            this.Hide();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva frm = new Reserva();
            frm.Show();
            this.Hide();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos frm = new Vuelos();
            frm.Show();
            this.Hide();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Destinos frm = new Destinos();
            frm.Show();
            this.Hide();
        }

        // ==========================================
        //  ACCIONES DE BÚSQUEDA Y SELECCIÓN (SOLO BUSCAR)
        // ==========================================

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt1.Text) && string.IsNullOrWhiteSpace(txt2.Text))
                {
                    MessageBox.Show("Por favor ingresa un País de Origen o Destino para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt1.Focus();
                    return;
                }

                MessageBox.Show("Búsqueda realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar vuelos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Vuelo SV201 seleccionado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MetododePago frm = new MetododePago();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Vuelo SV202 seleccionado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MetododePago frm = new MetododePago();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}