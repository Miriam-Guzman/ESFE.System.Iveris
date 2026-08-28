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

        // Método para listar clases de asientos
        public DataTable ListarClases()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    using (SqlCommand comando = new SqlCommand("SP_ListarClase", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch
            {
                // Fallback por consulta directa si el SP no existiera aún
                try
                {
                    using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                    {
                        using (SqlCommand comando = new SqlCommand("SELECT id_clase, descripcion FROM dbo.Clases ORDER BY id_clase", conexion))
                        {
                            comando.CommandType = CommandType.Text;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                            {
                                adapter.Fill(dt);
                            }
                        }
                    }
                }
                catch { }
            }

            // Si la tabla sigue vacía, agregamos las clases estándar como fallback seguro
            if (dt.Rows.Count == 0)
            {
                if (!dt.Columns.Contains("id_clase"))
                    dt.Columns.Add("id_clase", typeof(int));
                if (!dt.Columns.Contains("descripcion"))
                    dt.Columns.Add("descripcion", typeof(string));

                dt.Rows.Add(1, "Económica");
                dt.Rows.Add(2, "Ejecutiva");
                dt.Rows.Add(3, "Primera Clase");
            }

            return dt;
        }

        // Método para listar pasajeros y clientes para autocompletar
        public DataTable ListarPasajerosYClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
                {
                    string sql = @"
                        SELECT id_pasajero AS Id, nombre + ' ' + apellido AS NombreCompleto, pasaporte AS Documento, 'Pasajero' AS Tipo
                        FROM dbo.Pasajeros
                        UNION
                        SELECT id_cliente AS Id, nombre + ' ' + apellido AS NombreCompleto, telefono AS Documento, 'Cliente' AS Tipo
                        FROM dbo.Clientes
                        ORDER BY NombreCompleto";

                    using (SqlCommand comando = new SqlCommand(sql, conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch { }

            return dt;
        }
    }
}
