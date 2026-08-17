using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.DAL
{
    public class AvionDAL
    {
        public static List<Avion> Buscar(Avion pAvion)
        {
            List<Avion> lista = new List<Avion>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_avion, modelo, capacidad, matricula FROM Aviones", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Avion a = new Avion();
                    a.id_avion = reader.GetInt32(0);
                    a.modelo = reader.GetString(1);
                    a.capacidad = reader.GetInt32(2);
                    a.matricula = reader.GetString(3);

                    lista.Add(a);
                }
            }

            return lista;
        }
    }
}