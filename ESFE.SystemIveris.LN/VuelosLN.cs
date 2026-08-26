using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class VuelosLN
    {
        private readonly VuelosDAL vuelosDAL;

        public VuelosLN()
        {
            vuelosDAL = new VuelosDAL();
        }

        public bool Insertar(Vuelos vuelos)
        {
            return vuelosDAL.Insertar(vuelos);
        }

        public bool Actualizar(Vuelos vuelos)
        {
            return vuelosDAL.Actualizar(vuelos);
        }

        public bool Eliminar(int idVuelo)
        {
            return vuelosDAL.Eliminar(idVuelo);
        }

        public List<Vuelos> Buscar(string numeroVuelo)
        {
            return vuelosDAL.Buscar(numeroVuelo);
        }

        public System.Data.DataTable ListarVuelosDetalle()
        {
            return vuelosDAL.ListarVuelosDetalle();
        }

        public System.Data.DataTable BuscarVuelosDetalle(string criterio)
        {
            return vuelosDAL.BuscarVuelosDetalle(criterio);
        }

        public List<Vuelos> Listar()
        {
            return vuelosDAL.Listar();
        }
    }
}
