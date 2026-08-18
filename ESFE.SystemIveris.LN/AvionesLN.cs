using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class AvionesLN
    {
        private readonly AvionesDAL avionesDAL;

        public AvionesLN()
        {
            avionesDAL = new AvionesDAL();
        }

        public bool Insertar(Aviones aviones)
        {
            return avionesDAL.Insertar(aviones);
        }

        public bool Actualizar(Aviones aviones)
        {
            return avionesDAL.Actualizar(aviones);
        }

        public bool Eliminar(int idAvion)
        {
            return avionesDAL.Eliminar(idAvion);
        }

        public List<Aviones> Buscar(string criterio)
        {
            return avionesDAL.Buscar(criterio);
        }
    }
}