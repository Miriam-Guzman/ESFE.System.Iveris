using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using ESFE.SystemIveris.EN;

namespace ESFE.SystemIveris.DAL
{
    public class ReservaDAL
    {
        //Metodo Buscar - Consultas
        public static List<Reserva> Buscar(Reserva pReserva)
        {
            List<Reserva> lista = new List<Reserva>();

            using (SqlConnection conexion = (SqlConnection)DBComun.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_reserva, fecha_reserva, id_cliente, id_est_reserva FROM Reserva", conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reserva r = new Reserva();
                    r.id_reserva = reader.GetInt32(0);
                    r.fecha_reserva = reader.GetDateTime(1);
                    r.id_cliente = reader.GetInt32(2);
                    r.id_est_reserva = reader.GetInt32(3);

                    lista.Add(r);
                }
            }
            return lista;
        }
    }
}
    
