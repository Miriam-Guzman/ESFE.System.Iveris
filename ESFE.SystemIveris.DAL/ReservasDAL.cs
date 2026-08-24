using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class ReservasDAL
    {
        // Método para insertar una nueva reserva en la base de datos
        public bool Insertar(Reservas reservas)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarReserva", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@fecha_reserva", reservas.fecha_reserva);
                    comando.Parameters.AddWithValue("@id_cliente", reservas.id_cliente);
                    comando.Parameters.AddWithValue("@id_est_reserva", reservas.id_est_reserva);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar una reserva existente en la base de datos
        public bool Actualizar(Reservas reservas)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarReserva", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_reserva", reservas.id_reserva);
                    comando.Parameters.AddWithValue("@fecha_reserva", reservas.fecha_reserva);
                    comando.Parameters.AddWithValue("@id_cliente", reservas.id_cliente);
                    comando.Parameters.AddWithValue("@id_est_reserva", reservas.id_est_reserva);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar una reserva de la base de datos
        public bool Eliminar(int idReserva)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarReserva", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_reserva", idReserva);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar reservas por ID de cliente en la base de datos
        public List<Reservas> Buscar(int idCliente)
        {
            List<Reservas> lista = new List<Reservas>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarReservaCliente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_cliente", idCliente);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservas reserva = new Reservas
                            {
                                id_reserva = Convert.ToInt32(reader["id_reserva"]),
                                fecha_reserva = Convert.ToDateTime(reader["fecha_reserva"]),
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                id_est_reserva = Convert.ToInt32(reader["id_est_reserva"])
                            };

                            lista.Add(reserva);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
    
