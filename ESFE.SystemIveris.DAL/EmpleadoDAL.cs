using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class EmpleadoDAL
    {
        public static List<Empleado> Buscar(Empleado pEmpleado)
        {
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_empleado, nombre, apellido, email, telefono, id_cargo FROM empleados", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado e = new Empleado();
                    e.id_empleado = reader.GetInt32(0);
                    e.nombre = reader.GetString(1);
                    e.apellido = reader.GetString(2);
                    e.email = reader.GetString(3);
                    e.telefono = reader.GetString(4);
                    e.id_cargo = reader.GetInt32(5);

                    lista.Add(e);
                }
            }

            return lista;
        }
    }
}
