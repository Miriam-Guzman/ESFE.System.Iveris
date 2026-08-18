using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class EmpleadosDAL
    {
        // Método para insertar un nuevo empleado en la base de datos
        public bool Insertar(Empleados empleados)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("InsertarEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@nombre", empleados.nombre);
                    comando.Parameters.AddWithValue("@apellido", empleados.apellido);
                    comando.Parameters.AddWithValue("@email", empleados.email);
                    comando.Parameters.AddWithValue("@telefono", empleados.telefono);
                    comando.Parameters.AddWithValue("@id_cargo", empleados.id_cargo);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para actualizar un empleado existente en la base de datos
        public bool Actualizar(Empleados empleados)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("ActualizarEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_empleado", empleados.id_empleado);
                    comando.Parameters.AddWithValue("@nombre", empleados.nombre);
                    comando.Parameters.AddWithValue("@apellido", empleados.apellido);
                    comando.Parameters.AddWithValue("@email", empleados.email);
                    comando.Parameters.AddWithValue("@telefono", empleados.telefono);
                    comando.Parameters.AddWithValue("@id_cargo", empleados.id_cargo);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Método para eliminar un empleado de la base de datos
        public bool Eliminar(int idEmpleado)
        {
            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("EliminarEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_empleado", idEmpleado);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        // Método para buscar empleados en la base de datos
        public List<Empleados> Buscar(string criterio)
        {
            List<Empleados> lista = new List<Empleados>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand("BuscarEmpleado", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@criterio", criterio);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleados empleado = new Empleados
                            {
                                id_empleado = Convert.ToInt32(reader["id_empleado"]),
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                email = reader["email"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                id_cargo = Convert.ToInt32(reader["id_cargo"])
                            };

                            lista.Add(empleado);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
