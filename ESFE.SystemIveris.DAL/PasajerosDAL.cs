using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class PasajerosDAL
    {
        // Método para insertar un nuevo pasajero en la base de datos
        public bool Insertar(Pasajeros pasajeros)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarPasajero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre", pasajeros.nombre);
                    comando.Parameters.AddWithValue("@apellido", pasajeros.apellido);
                    comando.Parameters.AddWithValue("@pasaporte", pasajeros.pasaporte);
                    comando.Parameters.AddWithValue("@id_ciudad", pasajeros.id_ciudad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar un pasajero existente en la base de datos
        public bool Actualizar(Pasajeros pasajeros)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarPasajero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_pasajero", pasajeros.id_pasajero);
                    comando.Parameters.AddWithValue("@nombre", pasajeros.nombre);
                    comando.Parameters.AddWithValue("@apellido", pasajeros.apellido);
                    comando.Parameters.AddWithValue("@pasaporte", pasajeros.pasaporte);
                    comando.Parameters.AddWithValue("@id_ciudad", pasajeros.id_ciudad);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar un pasajero de la base de datos
        public bool Eliminar(int idPasajero)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarPasajero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_pasajero", idPasajero);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar pasajeros por nombre o pasaporte en la base de datos
        public List<Pasajeros> Buscar(string criterio)
        {
            List<Pasajeros> lista = new List<Pasajeros>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarPasajero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pasajeros pasajero = new Pasajeros
                            {
                                id_pasajero = Convert.ToInt32(reader["id_pasajero"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                pasaporte = reader["pasaporte"].ToString(),
                                id_ciudad = Convert.ToInt32(reader["id_ciudad"])
                            };

                            lista.Add(pasajero);
                        }
                    }
                }
            }

            return lista;
        }

        // Método para listar todos los pasajeros
        public List<Pasajeros> Listar()
        {
            List<Pasajeros> lista = new List<Pasajeros>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarPasajero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pasajeros pasajero = new Pasajeros
                            {
                                id_pasajero = Convert.ToInt32(reader["id_pasajero"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                pasaporte = reader["pasaporte"].ToString(),
                                id_ciudad = Convert.ToInt32(reader["id_ciudad"])
                            };

                            lista.Add(pasajero);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
