using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class VuelosDAL
    {
        // Método para insertar un nuevo vuelo en la base de datos
        public bool Insertar(Vuelos vuelos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarVuelo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@numero_vuelo", vuelos.numero_vuelo);
                    comando.Parameters.AddWithValue("@fecha_salida", vuelos.fecha_salida);
                    comando.Parameters.AddWithValue("@fecha_llegada", vuelos.fecha_llegada);
                    comando.Parameters.AddWithValue("@id_aeropuerto_origen", vuelos.id_aeropuerto_origen);
                    comando.Parameters.AddWithValue("@id_aeropuerto_destino", vuelos.id_aeropuerto_destino);
                    comando.Parameters.AddWithValue("@id_avion", vuelos.id_avion);
                    comando.Parameters.AddWithValue("@id_est_vuelo", vuelos.id_est_vuelo);
                    comando.Parameters.AddWithValue("@id_puerta", vuelos.id_puerta);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar un vuelo existente en la base de datos
        public bool Actualizar(Vuelos vuelos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarVuelo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_vuelo", vuelos.id_vuelo);
                    comando.Parameters.AddWithValue("@numero_vuelo", vuelos.numero_vuelo);
                    comando.Parameters.AddWithValue("@fecha_salida", vuelos.fecha_salida);
                    comando.Parameters.AddWithValue("@fecha_llegada", vuelos.fecha_llegada);
                    comando.Parameters.AddWithValue("@id_aeropuerto_origen", vuelos.id_aeropuerto_origen);
                    comando.Parameters.AddWithValue("@id_aeropuerto_destino", vuelos.id_aeropuerto_destino);
                    comando.Parameters.AddWithValue("@id_avion", vuelos.id_avion);
                    comando.Parameters.AddWithValue("@id_est_vuelo", vuelos.id_est_vuelo);
                    comando.Parameters.AddWithValue("@id_puerta", vuelos.id_puerta);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar un vuelo de la base de datos
        public bool Eliminar(int idVuelo)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarVuelo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_vuelo", idVuelo);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar vuelos por número de vuelo en la base de datos
        public List<Vuelos> Buscar(string numeroVuelo)
        {
            List<Vuelos> lista = new List<Vuelos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarVueloNumero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@numero_vuelo", numeroVuelo);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vuelos vuelo = new Vuelos
                            {
                                id_vuelo = Convert.ToInt32(reader["id_vuelo"]),
                                numero_vuelo = reader["numero_vuelo"].ToString(),
                                fecha_salida = Convert.ToDateTime(reader["fecha_salida"]),
                                fecha_llegada = Convert.ToDateTime(reader["fecha_llegada"]),
                                id_aeropuerto_origen = Convert.ToInt32(reader["id_aeropuerto_origen"]),
                                id_aeropuerto_destino = Convert.ToInt32(reader["id_aeropuerto_destino"]),
                                id_avion = Convert.ToInt32(reader["id_avion"]),
                                id_est_vuelo = Convert.ToInt32(reader["id_est_vuelo"]),
                                id_puerta = Convert.ToInt32(reader["id_puerta"])
                            };

                            lista.Add(vuelo);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
