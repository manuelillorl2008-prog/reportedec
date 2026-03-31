using System;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    public class FondoDAL
    {
        private ConexionBD conexionBD = new ConexionBD();

        public decimal ObtenerMontoDisponible()
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT MontoDisponible FROM Fondo WHERE FondoID = 1", cn);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        public void ActualizarMontoDisponible(decimal nuevoMonto)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Fondo SET MontoDisponible = @Monto WHERE FondoID = 1", cn);
                cmd.Parameters.AddWithValue("@Monto", nuevoMonto);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
