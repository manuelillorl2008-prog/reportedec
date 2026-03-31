using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    public class PrestamosDAL
    {
        private ConexionBD conexionBD = new ConexionBD();

        // Registrar préstamo
        public int RegistrarPrestamo(int clienteID, string nombreCliente, decimal monto, int plazoMeses,
                                     decimal tasaInteres, decimal interesGenerado, decimal montoTotal,
                                     string estado, int morasAcumuladas, DateTime fechaPrestamo)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Prestamos 
                    (ClienteID, NombreCliente, Monto, PlazoMeses, TasaInteres, InteresGenerado, 
                     MontoTotal, Estado, MorasAcumuladas, FechaPrestamo)
                    VALUES (@ClienteID, @NombreCliente, @Monto, @PlazoMeses, @TasaInteres, @InteresGenerado, 
                            @MontoTotal, @Estado, @MorasAcumuladas, @FechaPrestamo);
                    SELECT SCOPE_IDENTITY();", cn);

                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                cmd.Parameters.AddWithValue("@Monto", monto);
                cmd.Parameters.AddWithValue("@PlazoMeses", plazoMeses);
                cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                cmd.Parameters.AddWithValue("@InteresGenerado", interesGenerado);
                cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@MorasAcumuladas", morasAcumuladas);
                cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Editar préstamo
        public void EditarPrestamo(int prestamoID, decimal monto, int plazoMeses,
                                   decimal tasaInteres, decimal interesGenerado, decimal montoTotal,
                                   string estado, int morasAcumuladas)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Prestamos
                    SET Monto=@Monto, PlazoMeses=@PlazoMeses, TasaInteres=@TasaInteres,
                        InteresGenerado=@InteresGenerado, MontoTotal=@MontoTotal,
                        Estado=@Estado, MorasAcumuladas=@MorasAcumuladas
                    WHERE PrestamoID=@PrestamoID", cn);

                cmd.Parameters.AddWithValue("@PrestamoID", prestamoID);
                cmd.Parameters.AddWithValue("@Monto", monto);
                cmd.Parameters.AddWithValue("@PlazoMeses", plazoMeses);
                cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                cmd.Parameters.AddWithValue("@InteresGenerado", interesGenerado);
                cmd.Parameters.AddWithValue("@MontoTotal", montoTotal);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@MorasAcumuladas", morasAcumuladas);

                cmd.ExecuteNonQuery();
            }
        }

        // Consultar todos los préstamos
        public DataTable ConsultarPrestamos()
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Prestamos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Obtener préstamo por ID
        public DataRow ObtenerPrestamo(int prestamoID)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Prestamos WHERE PrestamoID=@PrestamoID", cn);
                da.SelectCommand.Parameters.AddWithValue("@PrestamoID", prestamoID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // Obtener el total de moras acumuladas por cliente
        public int ObtenerTotalMorasCliente(int clienteID)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(MorasAcumuladas),0) FROM Prestamos WHERE ClienteID=@ClienteID", cn);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // Eliminar préstamo
        public void EliminarPrestamo(int prestamoID)
        {
            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Prestamos WHERE PrestamoID=@PrestamoID", cn);
                cmd.Parameters.AddWithValue("@PrestamoID", prestamoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}