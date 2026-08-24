using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class FacturasDAL
    {
        //Método para insertar una nueva factura en la base de datos
        public bool Insertar(Facturas facturas)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_InsertarFactura", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@numero_factura", facturas.numero_factura);
                    comando.Parameters.AddWithValue("@fecha_emision", facturas.fecha_emision);
                    comando.Parameters.AddWithValue("@total", facturas.total);
                    comando.Parameters.AddWithValue("@id_pago", facturas.id_pago);
                    comando.Parameters.AddWithValue("@id_est_factura", facturas.id_est_factura);
                    comando.Parameters.AddWithValue("@id_tipo_doc", facturas.id_tipo_doc);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para actualizar una factura existente en la base de datos
        public bool Actualizar(Facturas facturas)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_ActualizarFactura", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_factura", facturas.id_factura);
                    comando.Parameters.AddWithValue("@numero_factura", facturas.numero_factura);
                    comando.Parameters.AddWithValue("@fecha_emision", facturas.fecha_emision);
                    comando.Parameters.AddWithValue("@total", facturas.total);
                    comando.Parameters.AddWithValue("@id_pago", facturas.id_pago);
                    comando.Parameters.AddWithValue("@id_est_factura", facturas.id_est_factura);
                    comando.Parameters.AddWithValue("@id_tipo_doc", facturas.id_tipo_doc);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        //Método para eliminar una factura de la base de datos
        public bool Eliminar(int idFactura)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_EliminarFactura", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_factura", idFactura);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        //Método para buscar facturas por número en la base de datos
        public List<Facturas> Buscar(string numeroFactura)
        {
            List<Facturas> lista = new List<Facturas>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("SP_BuscarFacturaNumero", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@numero_factura", numeroFactura);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Facturas factura = new Facturas
                            {
                                id_factura = Convert.ToInt32(reader["id_factura"]),
                                numero_factura = reader["numero_factura"].ToString(),
                                fecha_emision = Convert.ToDateTime(reader["fecha_emision"]),
                                total = Convert.ToDecimal(reader["total"]),
                                id_pago = Convert.ToInt32(reader["id_pago"]),
                                id_est_factura = Convert.ToInt32(reader["id_est_factura"]),
                                id_tipo_doc = Convert.ToInt32(reader["id_tipo_doc"])
                            };

                            lista.Add(factura);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
