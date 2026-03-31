using System.Configuration;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    public class ConexionBD
    {
        private readonly string _connectionString;

        public ConexionBD()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConexionPrestamos"].ConnectionString;
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(_connectionString);
            cn.Open();
            return cn;
        }
    }
}