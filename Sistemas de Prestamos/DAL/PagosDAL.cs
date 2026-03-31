using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    public class PagosDAL
    {
        private ConexionBD conexionBD = new ConexionBD();

        // Registrar pago (usa MontoPagado en lugar de MontoPago y no ClienteID)
        public int RegistrarPago(int prestamoID, string nombreCliente,
                                 decimal montoPagado, DateTime fechaPago, string estado, decimal mora = 0)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Pagos 
                    (PrestamoID, NombreCliente, MontoPagado, FechaPago, Mora, Estado)
                    VALUES (@PrestamoID, @NombreCliente, @MontoPagado, @FechaPago, @Mora, @Estado);
                    SELECT SCOPE_IDENTITY();", cn);

                cmd.Parameters.AddWithValue("@PrestamoID", prestamoID);
                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cmd.Parameters.AddWithValue("@MontoPagado", montoPagado);
                cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@Mora", mora);
                cmd.Parameters.AddWithValue("@Estado", estado);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Editar pago
        public void EditarPago(int pagoID, decimal montoPagado, DateTime fechaPago, string estado, decimal mora = 0)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Pagos
                    SET MontoPagado=@MontoPagado, FechaPago=@FechaPago, Mora=@Mora, Estado=@Estado
                    WHERE PagoID=@PagoID", cn);

                cmd.Parameters.AddWithValue("@PagoID", pagoID);
                cmd.Parameters.AddWithValue("@MontoPagado", montoPagado);
                cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@Mora", mora);
                cmd.Parameters.AddWithValue("@Estado", estado);

                cmd.ExecuteNonQuery();
            }
        }

        // Consultar todos los pagos
        public DataTable ConsultarPagos()
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pagos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Obtener pago por ID
        public DataRow ObtenerPago(int pagoID)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pagos WHERE PagoID=@PagoID", cn);
                da.SelectCommand.Parameters.AddWithValue("@PagoID", pagoID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // Eliminar pago
        public void EliminarPago(int pagoID)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Pagos WHERE PagoID=@PagoID", cn);
                cmd.Parameters.AddWithValue("@PagoID", pagoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}