using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class ClientesDAL
    {
        // Método para insertar un nuevo cliente en la base de datos
        public bool Insertar(Clientes clientes)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("InsertarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre", clientes.nombre);
                    comando.Parameters.AddWithValue("@apellido", clientes.apellido);
                    comando.Parameters.AddWithValue("@email", clientes.email);
                    comando.Parameters.AddWithValue("@telefono", clientes.telefono);
                    comando.Parameters.AddWithValue("@id_ciudad", clientes.id_ciudad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar un cliente existente en la base de datos
        public bool Actualizar(Clientes clientes)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("ActualizarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_cliente", clientes.id_cliente);
                    comando.Parameters.AddWithValue("@nombre", clientes.nombre);
                    comando.Parameters.AddWithValue("@apellido", clientes.apellido);
                    comando.Parameters.AddWithValue("@email", clientes.email);
                    comando.Parameters.AddWithValue("@telefono", clientes.telefono);
                    comando.Parameters.AddWithValue("@id_ciudad", clientes.id_ciudad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar un cliente de la base de datos
        public bool Eliminar(int idCliente)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("EliminarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_cliente", idCliente);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar clientes en la base de datos
        public List<Clientes> Buscar(string criterio)
        {
            List<Clientes> lista = new List<Clientes>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("BuscarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                email = reader["email"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                id_ciudad = Convert.ToInt32(reader["id_ciudad"])
                            };

                            lista.Add(cliente);
                        }
                    }
                }
            }

            return lista;
        }
    }
}

