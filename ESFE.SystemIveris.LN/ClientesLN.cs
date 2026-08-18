using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class ClientesLN
    {
        private readonly ClientesDAL clientesDAL;

        public ClientesLN()
        {
            clientesDAL = new ClientesDAL();
        }

        public bool Insertar(Clientes clientes)
        {
            return clientesDAL.Insertar(clientes);
        }

        public bool Actualizar(Clientes clientes)
        {
            return clientesDAL.Actualizar(clientes);
        }

        public bool Eliminar(int idCliente)
        {
            return clientesDAL.Eliminar(idCliente);
        }

        public List<Clientes> Buscar(string criterio)
        {
            return clientesDAL.Buscar(criterio);
        }
    }
}
