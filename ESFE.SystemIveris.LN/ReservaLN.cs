using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class ReservaLN
    {
        public static List<Reserva> Buscar(Reserva pReserva)
        {
            return ReservaDAL.Buscar(pReserva);
        }
    }
}

