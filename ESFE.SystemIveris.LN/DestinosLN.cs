using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ESFE.SystemIveris.DAL;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.LN
{
    public class DestinosLN
    {
        private readonly DestinosDAL destinosDAL;

        public DestinosLN()
        {
            destinosDAL = new DestinosDAL();
        }

        public DataTable ListarDestinos()
        {
            return destinosDAL.ListarDestinos();
        }

        public DataTable BuscarDestinos(string criterio)
        {
            return destinosDAL.BuscarDestinos(criterio);
        }

        public bool InsertarAeropuerto(string nombre, string codigoIata, int idCiudad)
        {
            return destinosDAL.InsertarAeropuerto(nombre, codigoIata, idCiudad);
        }

        public bool ActualizarAeropuerto(int idAeropuerto, string nombre, string codigoIata, int idCiudad)
        {
            return destinosDAL.ActualizarAeropuerto(idAeropuerto, nombre, codigoIata, idCiudad);
        }

        public bool EliminarAeropuerto(int idAeropuerto)
        {
            return destinosDAL.EliminarAeropuerto(idAeropuerto);
        }

        public bool EliminarVuelo(int idVuelo)
        {
            return destinosDAL.EliminarVuelo(idVuelo);
        }

        public DataTable ListarAeropuertos()
        {
            return destinosDAL.ListarAeropuertos();
        }
    }
}
