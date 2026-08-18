using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Facturas
    {
        public int id_factura { get; set; }
        public string numero_factura { get; set; }
        public DateTime fecha_emision { get; set; }
        public decimal total { get; set; }
        public int id_pago { get; set; }
        public int id_est_factura { get; set; }
        public int id_tipo_doc { get; set; }

    }
}
