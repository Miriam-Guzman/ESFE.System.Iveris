using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class DestinosDAL
    {
        // Listar destinos disponibles formateados para la vista
        public DataTable ListarDestinos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarDestinos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Buscar destinos por ciudad, aeropuerto, código o número de vuelo
        public DataTable BuscarDestinos(string criterio)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarDestinos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio ?? "");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Insertar un nuevo destino/aeropuerto
        public bool InsertarAeropuerto(string nombre, string codigoIata, int idCiudad)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarAeropuerto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@codigo_iata", codigoIata);
                    comando.Parameters.AddWithValue("@id_ciudad", idCiudad);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Actualizar aeropuerto/destino existente
        public bool ActualizarAeropuerto(int idAeropuerto, string nombre, string codigoIata, int idCiudad)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarAeropuerto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_aeropuerto", idAeropuerto);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@codigo_iata", codigoIata);
                    comando.Parameters.AddWithValue("@id_ciudad", idCiudad);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Eliminar aeropuerto/destino
        public bool EliminarAeropuerto(int idAeropuerto)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarAeropuerto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_aeropuerto", idAeropuerto);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Eliminar vuelo asociado al destino
        public bool EliminarVuelo(int idVuelo)
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

        // Listar todos los aeropuertos
        public DataTable ListarAeropuertos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarAeropuerto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
