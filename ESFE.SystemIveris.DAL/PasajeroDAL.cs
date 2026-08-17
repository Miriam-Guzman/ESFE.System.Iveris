using ESFE.SystemIveris.DAL;
using ESFE.SystemIveris.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.SystemIveris.DAL
{
    public class PasajeroDAL
    {
        public static List<Pasajero> Buscar(Pasajero pPasajero)
        {
            List<Pasajero> lista = new List<Pasajero>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_pasajero, nombre, apellido, pasaporte, id_ciudad FROM Pasajeros", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pasajero p = new Pasajero();
                    p.id_pasajero = reader.GetInt32(0);
                    p.nombre = reader.GetString(1);
                    p.apellido = reader.GetString(2);
                    p.pasaporte = reader.GetString(3);
                    p.id_ciudad = reader.GetInt32(4);

                    lista.Add(p);
                }
            }
            return lista;
        }
    }
}
