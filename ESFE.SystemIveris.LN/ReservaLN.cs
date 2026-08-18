using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class ReservaLN
    {
        public static List<Reservas> Buscar(Reservas pReserva)
        {
            return ReservasDAL.Buscar(pReserva);
        }
    }
}

