using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Vuelos
    {
        public int id_vuelo { get; set; }
        public string? numero_vuelo { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime fecha_llegada { get; set; }
        public int id_aeropuerto_origen { get; set; }
        public int id_aeropuerto_destino { get; set; }
        public int id_avion { get; set; }
        public int id_est_vuelo { get; set; }
        public int id_puerta { get; set; }
    }
}
