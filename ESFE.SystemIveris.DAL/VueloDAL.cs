using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.DAL
{
    public class VueloDAL
    {
        public static List<Vuelos> Buscar(Vuelos pVuelo)
        {
            List<Vuelos> lista = new List<Vuelos>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_vuelo, numero_vuelo, fecha_salida, fecha_llegada, id_aeropuerto_origen, id_aeropuerto_destino, id_avion, id_est_vuelo, id_puerta FROM Vuelos", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vuelos v = new Vuelos();
                    v.id_vuelo = reader.GetInt32(0);
                    v.numero_vuelo = reader.GetString(1);
                    v.fecha_salida = reader.GetDateTime(2);
                    v.fecha_llegada = reader.GetDateTime(3);
                    v.id_aeropuerto_origen = reader.GetInt32(4);
                    v.id_aeropuerto_destino = reader.GetInt32(5);
                    v.id_avion = reader.GetInt32(6);
                    v.id_est_vuelo = reader.GetInt32(7);
                    v.id_puerta = reader.GetInt32(8);

                    lista.Add(v);
                }
            }
            return lista;
        }
    }
}
