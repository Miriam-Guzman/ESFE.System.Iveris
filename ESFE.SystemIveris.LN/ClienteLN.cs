using System;
using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class ClienteLN
    {
        public static List<Clientes> Buscar(Clientes pCliente)
        {
            return ClientesDAL.Buscar(pCliente);
        }
    }
}
