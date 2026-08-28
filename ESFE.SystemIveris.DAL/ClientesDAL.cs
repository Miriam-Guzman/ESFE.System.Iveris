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
                using (SqlCommand comando = new SqlCommand("SP_InsertarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre", clientes.nombre ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@apellido", clientes.apellido ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@email", clientes.email ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@telefono", clientes.telefono ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@id_ciudad", clientes.id_ciudad);
                    comando.Parameters.AddWithValue("@contrasena", string.IsNullOrEmpty(clientes.contrasena) ? (object)DBNull.Value : clientes.contrasena);

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
                using (SqlCommand comando = new SqlCommand("SP_ActualizarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_cliente", clientes.id_cliente);
                    comando.Parameters.AddWithValue("@nombre", clientes.nombre ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@apellido", clientes.apellido ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@email", clientes.email ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@telefono", clientes.telefono ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@id_ciudad", clientes.id_ciudad);
                    comando.Parameters.AddWithValue("@contrasena", string.IsNullOrEmpty(clientes.contrasena) ? (object)DBNull.Value : clientes.contrasena);

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
                using (SqlCommand comando = new SqlCommand("SP_EliminarCliente", conexion))
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
                using (SqlCommand comando = new SqlCommand("SP_BuscarCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio ?? string.Empty);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                nombre = reader["nombre"] != DBNull.Value ? reader["nombre"].ToString() : string.Empty,
                                apellido = reader["apellido"] != DBNull.Value ? reader["apellido"].ToString() : string.Empty,
                                email = reader["email"] != DBNull.Value ? reader["email"].ToString() : string.Empty,
                                telefono = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : string.Empty,
                                id_ciudad = Convert.ToInt32(reader["id_ciudad"]),
                                contrasena = reader["contrasena"] != DBNull.Value ? reader["contrasena"].ToString() : string.Empty
                            };

                            lista.Add(cliente);
                        }
                    }
                }
            }

            return lista;
        }

        // Método para validar credenciales e iniciar sesión
        public Clientes? IniciarSesion(string email, string contrasena)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_IniciarSesionCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Clientes
                            {
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                nombre = reader["nombre"] != DBNull.Value ? reader["nombre"].ToString() : string.Empty,
                                apellido = reader["apellido"] != DBNull.Value ? reader["apellido"].ToString() : string.Empty,
                                email = reader["email"] != DBNull.Value ? reader["email"].ToString() : string.Empty,
                                telefono = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : string.Empty,
                                id_ciudad = Convert.ToInt32(reader["id_ciudad"]),
                                contrasena = reader["contrasena"] != DBNull.Value ? reader["contrasena"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Método para verificar si un correo ya se encuentra registrado
        public bool ExisteEmail(string email)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ExisteEmailCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@email", email);

                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Método para listar ciudades para el registro
        public DataTable ListarCiudades()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarCuidades", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(comando))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

