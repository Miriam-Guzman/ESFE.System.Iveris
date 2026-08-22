using System;
using System.Windows.Forms;

namespace ESFE.SystemIveris.UI
{
    public partial class Metodopago2 : Form
    {
        public Metodopago2()
        {
            InitializeComponent();
        }

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

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            Vuelos formulario = new Vuelos();
            formulario.Show();
            this.Hide();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva();
            formulario.Show();
            this.Hide();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Destinos formulario = new Destinos();
            formulario.Show();
            this.Hide();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
        }

        private void btnResumenCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Resumen de compra.",
                "Resumen",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void pic2_Click(object sender, EventArgs e)
        {
        }

        private void lblSal_Click(object sender, EventArgs e)
        {
        }

        private void pic3_Click(object sender, EventArgs e)
        {
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
        }

        private void pic4_Click(object sender, EventArgs e)
        {
        }

        private void lblPasajero_Click(object sender, EventArgs e)
        {
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pic5_Click(object sender, EventArgs e)
        {
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lbl03_Click(object sender, EventArgs e)
        {
        }

        private void pic6_Click(object sender, EventArgs e)
        {
        }

        private void lblClase_Click(object sender, EventArgs e)
        {
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
        }

        private void pic7_Click(object sender, EventArgs e)
        {
        }

        private void lblEquipaje2_Click(object sender, EventArgs e)
        {
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
        }

        private void lblTarifaVuelo_Click(object sender, EventArgs e)
        {
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
        }

        private void lblEquipaje_Click(object sender, EventArgs e)
        {
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
        }
    }
}
