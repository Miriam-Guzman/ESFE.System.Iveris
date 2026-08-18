using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.EN
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? email { get; set; } 
        public string? telefono { get; set; }
        public int id_ciudad { get; set; }
    }
}
