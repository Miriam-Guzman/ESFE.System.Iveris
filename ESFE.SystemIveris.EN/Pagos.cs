using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Pagos
    {
        public int id_pago { get; set; }
        public DateTime fecha_pago { get; set; }
        public decimal monto { get; set; }
        public int id_reserva { get; set; }
        public int id_est_pago { get; set; }
        public int id_met_pago { get; set; }
    }
}
