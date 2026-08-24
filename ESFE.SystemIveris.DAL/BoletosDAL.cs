using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class BoletosDAL
    {
        //Método para insertar un nuevo boleto en la base de datos
        public bool Insertar(Boletos boletos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarBoleto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@codigo_boleto", boletos.codigo_boleto);
                    comando.Parameters.AddWithValue("@precio", boletos.precio);
                    comando.Parameters.AddWithValue("@id_vuelo", boletos.id_vuelo);
                    comando.Parameters.AddWithValue("@id_asiento", boletos.id_asiento);
                    comando.Parameters.AddWithValue("@id_pasajero", boletos.id_pasajero);
                    comando.Parameters.AddWithValue("@id_est_boleto", boletos.id_est_boleto);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para actualizar un boleto existente en la base de datos
        public bool Actualizar(Boletos boletos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarBoleto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_boleto", boletos.id_boleto);
                    comando.Parameters.AddWithValue("@codigo_boleto", boletos.codigo_boleto);
                    comando.Parameters.AddWithValue("@precio", boletos.precio);
                    comando.Parameters.AddWithValue("@id_vuelo", boletos.id_vuelo);
                    comando.Parameters.AddWithValue("@id_asiento", boletos.id_asiento);
                    comando.Parameters.AddWithValue("@id_pasajero", boletos.id_pasajero);
                    comando.Parameters.AddWithValue("@id_est_boleto", boletos.id_est_boleto);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para eliminar un boleto de la base de datos
        public bool Eliminar(int idBoleto)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarBoleto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_boleto", idBoleto);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        //Método para buscar boletos por código en la base de datos
        public List<Boletos> Buscar(string codigo)
        {
            List<Boletos> lista = new List<Boletos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarBoletoCodigo", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@codigo_boleto", codigo);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Boletos boleto = new Boletos 
                            {
                                id_boleto = Convert.ToInt32(reader["id_boleto"]),
                                codigo_boleto = reader["codigo_boleto"].ToString(),
                                precio = Convert.ToDecimal(reader["precio"]),
                                id_vuelo = Convert.ToInt32(reader["id_vuelo"]),
                                id_asiento = Convert.ToInt32(reader["id_asiento"]),
                                id_pasajero = Convert.ToInt32(reader["id_pasajero"]),
                                id_est_boleto = Convert.ToInt32(reader["id_est_boleto"])
                            };

                            lista.Add(boleto);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
