using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class ReservasLN
    {
        private readonly ReservasDAL reservasDAL;

        public ReservasLN()
        {
            reservasDAL = new ReservasDAL();
        }

        public bool Insertar(Reservas reservas)
        {
            return reservasDAL.Insertar(reservas);
        }

        public bool Actualizar(Reservas reservas)
        {
            return reservasDAL.Actualizar(reservas);
        }

        public bool Eliminar(int idReserva)
        {
            return reservasDAL.Eliminar(idReserva);
        }

        public List<Reservas> Buscar(int idCliente)
        {
            return reservasDAL.Buscar(idCliente);
        }
    }
}

