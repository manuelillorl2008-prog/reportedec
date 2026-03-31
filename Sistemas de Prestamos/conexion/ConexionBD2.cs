using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.conexion
{
    internal class ConexionBD2
    {
        private static string cadena = "Server=.\\SQLEXPRESS;Database=SistemaPrestamosLogin;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();
            return conn;
        }
    }
}