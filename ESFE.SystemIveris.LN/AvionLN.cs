using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class AvionLN
    {
        public static List<Avion> Buscar(Avion pAvion)
        {
            return AvionDAL.Buscar(pAvion);
        }
    }
}