using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class AvionesDAL
    {
        // Método para insertar un nuevo avión en la base de datos
        public bool Insertar(Aviones aviones)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarAvion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@modelo", aviones.modelo);
                    comando.Parameters.AddWithValue("@capacidad", aviones.capacidad);
                    comando.Parameters.AddWithValue("@matricula", aviones.matricula);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar un avión existente en la base de datos
        public bool Actualizar(Aviones aviones)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarAvion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_avion", aviones.id_avion);
                    comando.Parameters.AddWithValue("@modelo", aviones.modelo);
                    comando.Parameters.AddWithValue("@capacidad", aviones.capacidad);
                    comando.Parameters.AddWithValue("@matricula", aviones.matricula);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar un avión de la base de datos
        public bool Eliminar(int idAvion)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarAvion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_avion", idAvion);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar aviones por modelo o matrícula en la base de datos
        public List<Aviones> Buscar(string criterio)
        {
            List<Aviones> lista = new List<Aviones>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarAvion", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aviones avion = new Aviones
                            {
                                id_avion = Convert.ToInt32(reader["id_avion"]),
                                modelo = reader["modelo"].ToString(),
                                capacidad = Convert.ToInt32(reader["capacidad"]),
                                matricula = reader["matricula"].ToString()
                            };

                            lista.Add(avion);
                        }
                    }
                }
            }

            return lista;
        }
    }
}