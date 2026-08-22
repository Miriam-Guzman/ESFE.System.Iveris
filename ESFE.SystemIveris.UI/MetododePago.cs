using System;
using System.Windows.Forms;

namespace ESFE.SystemIveris.UI
{
    public partial class MetododePago : Form
    {
        public MetododePago()
        {
            InitializeComponent();
        }

        private void lblSelecionMetPag_Click(object sender, EventArgs e)
        {
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio formulario = new Inicio();
            formulario.Show();
            this.Hide();
        }

        private void btnMétodopago_Click(object sender, EventArgs e)
        {
            // Ya estamos en Método de Pago
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

        private void pic1_Click(object sender, EventArgs e)
        {
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void picimg2_Click(object sender, EventArgs e)
        {
        }

        private void lblmetododepago_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnO_Click(object sender, EventArgs e)
        {
        }

        private void picimagen_Click(object sender, EventArgs e)
        {
        }

        private void lblTarjetaDevito_Click(object sender, EventArgs e)
        {
        }

        private void lblDatosTarj_Click(object sender, EventArgs e)
        {
        }

        private void lblNombreTitular_Click(object sender, EventArgs e)
        {
        }

        private void lblFechaVencimiento_Click(object sender, EventArgs e)
        {
        }

        private void lblCCV_Click(object sender, EventArgs e)
        {
        }

        private void txtNomTitular_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtccv_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblDirecciònFatura_Click(object sender, EventArgs e)
        {
        }

        private void lblPais_Click(object sender, EventArgs e)
        {
        }

        private void lblNumerodeTarjeta_Click(object sender, EventArgs e)
        {
        }

        private void lblCuidad_Click(object sender, EventArgs e)
        {
        }

        private void lblCodigoPostal_Click(object sender, EventArgs e)
        {
        }

        private void cmbpaises_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtnumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIngresacuidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt00000_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pago confirmado correctamente.",
                "Método de Pago",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void MetododePago_Load(object sender, EventArgs e)
        {
        }
    }
}