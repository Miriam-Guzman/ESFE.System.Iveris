using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public DateTime fecha_reserva { get; set; }
        public int id_cliente { get; set; }
        public int id_est_reserva { get; set; }
    }
}
