using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ESFE.SysDesarrollo.DAL
{
    public class DBComun
    {
        //public const string _stringCnn = @"DESKTOP-9JI9BTT\MSSQLSERVER01;Initial Catalog=BDDesarrollo;Integrated Security=True";
        public const string _stringCnn = @"Server=MIRIAM\SQLEXPRESS;Database=IVERIS_DB;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>
        /// Metodo para obtener base de datos.
        /// </summary>
        /// <returns>Devuelve la  conexion</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }
        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
