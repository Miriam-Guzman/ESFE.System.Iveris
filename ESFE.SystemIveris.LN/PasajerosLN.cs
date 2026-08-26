using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class PasajerosLN
    {
        private readonly PasajerosDAL pasajerosDAL;

        public PasajerosLN()
        {
            pasajerosDAL = new PasajerosDAL();
        }

        public bool Insertar(Pasajeros pasajeros)
        {
            return pasajerosDAL.Insertar(pasajeros);
        }

        public bool Actualizar(Pasajeros pasajeros)
        {
            return pasajerosDAL.Actualizar(pasajeros);
        }

        public bool Eliminar(int idPasajero)
        {
            return pasajerosDAL.Eliminar(idPasajero);
        }

        public List<Pasajeros> Buscar(string criterio)
        {
            return pasajerosDAL.Buscar(criterio);
        }

        public List<Pasajeros> Listar()
        {
            return pasajerosDAL.Listar();
        }
    }
}
