using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.SystemIveris.DAL;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.LN
{
    public class PagosLN
    {
        private readonly PagosDAL pagosDAL;

        public PagosLN()
        {
            pagosDAL = new PagosDAL();
        }

        public bool Insertar(Pagos pagos)
        {
            return pagosDAL.Insertar(pagos);
        }

        public bool Actualizar(Pagos pagos)
        {
            return pagosDAL.Actualizar(pagos);
        }

        public bool Eliminar(int idPago)
        {
            return pagosDAL.Eliminar(idPago);
        }

        public List<Pagos> Buscar(int idReserva)
        {
            return pagosDAL.Buscar(idReserva);
        }
    }
}