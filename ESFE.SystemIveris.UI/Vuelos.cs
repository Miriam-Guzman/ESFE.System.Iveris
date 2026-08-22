using System;
using System.Windows.Forms;

namespace ESFE.SystemIveris.UI
{
    public partial class Vuelos : Form
    {
        public Vuelos()
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

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reserva formulario = new Reserva();
            formulario.Show();
            this.Hide();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            // Ya estamos en Vuelos
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

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
        }
    }
}