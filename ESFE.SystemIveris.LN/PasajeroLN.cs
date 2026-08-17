using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;
using System.Reflection.Metadata.Ecma335;

namespace ESFE.SystemIveris.LN
{
    public class PasajeroLN
    {
        public static List<Pasajero> Buscar(Pasajero pPasajero)
        {
            return PasajeroDAL.Buscar(pPasajero);
        }
    }
}
