using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class VueloLN
    {
        public static List<Vuelos> Buscar(Vuelos pVuelo)
        {
            return VueloDAL.Buscar(pVuelo);
        }
    }
}
