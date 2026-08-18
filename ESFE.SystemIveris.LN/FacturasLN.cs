using System.Collections.Generic;
using System.Text;
using ESFE.SystemIveris.EN;
using ESFE.SystemIveris.DAL;

namespace ESFE.SystemIveris.LN
{
    public class FacturasLN
       
    {
        private readonly FacturasDAL facturasDAL;

        public FacturasLN()
        {
            facturasDAL = new FacturasDAL();
        }

        public bool Insertar(Facturas facturas)
        {
            return facturasDAL.Insertar(facturas);
        }

        public bool Actualizar(Facturas facturas)
        {
            return facturasDAL.Actualizar(facturas);
        }

        public bool Eliminar(int idFactura)
        {
            return facturasDAL.Eliminar(idFactura);
        }

        public List<Facturas> Buscar(string numeroFactura)
        {
            return facturasDAL.Buscar(numeroFactura);
        }
    }
}
    

