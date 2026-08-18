using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Boletos
    {
        public int id_boleto { get; set; }
        public string codigo_boleto { get; set; }
        public decimal precio { get; set; }
        public int id_vuelo { get; set; }
        public int id_asiento { get; set; }
        public int id_pasajero { get; set; }
        public int id_est_boleto { get; set; }
    }
}
