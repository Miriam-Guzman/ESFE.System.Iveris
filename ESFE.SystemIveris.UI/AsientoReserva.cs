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
    public partial class AsientoReserva : Form
    {
        public AsientoReserva()
        {
            InitializeComponent();
        }

        private void AsientoReserva_Load(object sender, EventArgs e)
        {
        }
        //hola
        // ==========================================
        //  BARRA DE NAVEGACIÓN SUPERIOR
        // ==========================================
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio();
            frm.Show();
            this.Hide();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos frm = new Vuelos();
            frm.Show();
            this.Hide();
        }

        private void btnMétodoPago_Click(object sender, EventArgs e)
        {
            MetododePago frm = new MetododePago();
            frm.Show();
            this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reserva2 frm = new Reserva2();
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
        //  SELECCIÓN DE ASIENTOS (EVENTOS DE CLIC)
        // ==========================================
        private void SeleccionarAsiento(string nombreAsiento)
        {
            try
            {
                MessageBox.Show($"Asiento {nombreAsiento} seleccionado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MetododePago frm = new MetododePago();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el asiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnA12_Click(object sender, EventArgs e) => SeleccionarAsiento("A12");
        private void btnH23_Click(object sender, EventArgs e) => SeleccionarAsiento("H23");
        private void btnG19_Click(object sender, EventArgs e) => SeleccionarAsiento("G19");
        private void btn78_Click(object sender, EventArgs e) => SeleccionarAsiento("T78");
        private void btnJ88_Click(object sender, EventArgs e) => SeleccionarAsiento("J88");
        private void btnR57_Click(object sender, EventArgs e) => SeleccionarAsiento("R57");
        private void btnM44_Click(object sender, EventArgs e) => SeleccionarAsiento("M44");
        private void btnU51_Click(object sender, EventArgs e) => SeleccionarAsiento("U51");
        private void btnA20_Click(object sender, EventArgs e) => SeleccionarAsiento("A20");
        private void btnV52_Click(object sender, EventArgs e) => SeleccionarAsiento("V52");
        private void btnD28_Click(object sender, EventArgs e) => SeleccionarAsiento("D28");
        private void btnE90_Click(object sender, EventArgs e) => SeleccionarAsiento("E90");

        // ==========================================
        //  BOTONES DE PROCEDIMIENTOS ALMACENADOS
        // ==========================================
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Conexión lógica para SP_InsertarAsiento
            try
            {
                // Aquí ejecutas la lógica de tu capa de negocio usando SP_InsertarAsiento
                MessageBox.Show("Procedimiento SP_InsertarAsiento ejecutado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Conexión lógica para SP_BuscarAsiento (Listar)
            try
            {
                // Aquí ejecutas la lógica de tu capa de negocio usando SP_BuscarAsiento
                MessageBox.Show("Procedimiento SP_BuscarAsiento ejecutado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Conexión lógica para SP_ModificarAsiento
            try
            {
                // Aquí ejecutas la lógica de tu capa de negocio usando SP_ModificarAsiento
                MessageBox.Show("Procedimiento SP_ModificarAsiento ejecutado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        // ==========================================
        //  MÉTODOS VACÍOS REQUERIDOS POR EL DISEÑADOR
        // ==========================================
        private void pic1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblSelecionaAsiento_Click(object sender, EventArgs e) { }
        private void pnl2_Paint(object sender, PaintEventArgs e) { }
        private void lbl1_Click(object sender, EventArgs e) { }
        private void lbl2_Click(object sender, EventArgs e) { }
        private void lbl3_Click(object sender, EventArgs e) { }
        private void lbl4_Click(object sender, EventArgs e) { }
        private void pnl3_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}