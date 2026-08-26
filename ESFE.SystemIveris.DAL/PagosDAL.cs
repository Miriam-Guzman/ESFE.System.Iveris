using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class PagosDAL
    {
        //Método para insertar un nuevo pago en la base de datos
        public bool Insertar(Pagos pagos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@fecha_pago", pagos.fecha_pago);
                    comando.Parameters.AddWithValue("@monto", pagos.monto);
                    comando.Parameters.AddWithValue("@id_reserva", pagos.id_reserva);
                    comando.Parameters.AddWithValue("@id_est_pago", pagos.id_est_pago);
                    comando.Parameters.AddWithValue("@id_met_pago", pagos.id_met_pago);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para actualizar un pago existente en la base de datos
        public bool Actualizar(Pagos pagos)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_pago", pagos.id_pago);
                    comando.Parameters.AddWithValue("@fecha_pago", pagos.fecha_pago);
                    comando.Parameters.AddWithValue("@monto", pagos.monto);
                    comando.Parameters.AddWithValue("@id_reserva", pagos.id_reserva);
                    comando.Parameters.AddWithValue("@id_est_pago", pagos.id_est_pago);
                    comando.Parameters.AddWithValue("@id_met_pago", pagos.id_met_pago);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para eliminar un pago de la base de datos
        public bool Eliminar(int idPago)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_pago", idPago);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        //Método para buscar pagos por reserva en la base de datos
        public List<Pagos> Buscar(int idReserva)
        {
            List<Pagos> lista = new List<Pagos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarPagoReserva", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_reserva", idReserva);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pagos pago = new Pagos
                            {
                                id_pago = Convert.ToInt32(reader["id_pago"]),
                                fecha_pago = Convert.ToDateTime(reader["fecha_pago"]),
                                monto = Convert.ToDecimal(reader["monto"]),
                                id_reserva = Convert.ToInt32(reader["id_reserva"]),
                                id_est_pago = Convert.ToInt32(reader["id_est_pago"]),
                                id_met_pago = Convert.ToInt32(reader["id_met_pago"])
                            };

                            lista.Add(pago);
                        }
                    }
                }
            }

            return lista;
        }

        // Método para buscar pagos por ID o criterio
        public List<Pagos> BuscarPago(int? idPago, int? idReserva)
        {
            List<Pagos> lista = new List<Pagos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_pago", (object)idPago ?? DBNull.Value);
                    comando.Parameters.AddWithValue("@id_reserva", (object)idReserva ?? DBNull.Value);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pagos pago = new Pagos
                            {
                                id_pago = Convert.ToInt32(reader["id_pago"]),
                                fecha_pago = Convert.ToDateTime(reader["fecha_pago"]),
                                monto = Convert.ToDecimal(reader["monto"]),
                                id_reserva = Convert.ToInt32(reader["id_reserva"]),
                                id_est_pago = Convert.ToInt32(reader["id_est_pago"]),
                                id_met_pago = Convert.ToInt32(reader["id_met_pago"])
                            };

                            lista.Add(pago);
                        }
                    }
                }
            }

            return lista;
        }

        // Listar pagos detallados para mostrar en vistas
        public DataTable ListarPagosDetalle()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarPagosDetalle", conexion))
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

        // Listar países
        public DataTable ListarPaises()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarPaises", conexion))
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

        // Listar métodos de pago
        public DataTable ListarMetPagos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarMetPagos", conexion))
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

        // Listar todos los pagos
        public List<Pagos> Listar()
        {
            List<Pagos> lista = new List<Pagos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ListarPago", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pagos pago = new Pagos
                            {
                                id_pago = Convert.ToInt32(reader["id_pago"]),
                                fecha_pago = Convert.ToDateTime(reader["fecha_pago"]),
                                monto = Convert.ToDecimal(reader["monto"]),
                                id_reserva = Convert.ToInt32(reader["id_reserva"]),
                                id_est_pago = Convert.ToInt32(reader["id_est_pago"]),
                                id_met_pago = Convert.ToInt32(reader["id_met_pago"])
                            };

                            lista.Add(pago);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
