using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.DAL
{
    public class ClienteDAL
    {
        public static List<Cliente> Buscar(Cliente pCliente)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad FROM Clientes", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.id_cliente = reader.GetInt32(0);
                    c.nombre = reader.GetString(1);
                    c.apellido = reader.GetString(2);
                    c.email = reader.GetString(3);
                    c.telefono = reader.GetString(4);
                    c.id_ciudad = reader.GetInt32(5);

                    lista.Add(c);
                }
            }
            return lista;
        }
    }
}

