using System;
using System.Collections.Generic;
using System.Data;
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

        public Clientes? IniciarSesion(string email, string contrasena)
        {
            return clientesDAL.IniciarSesion(email, contrasena);
        }

        public bool ExisteEmail(string email)
        {
            return clientesDAL.ExisteEmail(email);
        }

        public bool Registrar(Clientes cliente)
        {
            return clientesDAL.Insertar(cliente);
        }

        public DataTable ListarCiudades()
        {
            return clientesDAL.ListarCiudades();
        }
    }
}
