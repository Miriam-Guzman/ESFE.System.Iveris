using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.SystemIveris.DAL;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.LN
{
    public class BoletosLN
    {
        private readonly BoletosDAL boletosDAL;

        public BoletosLN()
        {
            boletosDAL = new BoletosDAL();
        }

        public bool Insertar(Boletos boletos)
        {
            return boletosDAL.Insertar(boletos);
        }

        public bool Actualizar(Boletos boletos)
        {
            return boletosDAL.Actualizar(boletos);
        }

        public bool Eliminar(int idBoleto)
        {
            return boletosDAL.Eliminar(idBoleto);
        }

        public List<Boletos> Buscar(string codigo)
        {
            return boletosDAL.Buscar(codigo);
        }
    }
}