using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Sistemas_de_Amortizacion.DAL
{
    public class AmortizacionDAL
    {
        public class Cuotas
        {
            public int NumeroDeCuota { get; set; }
            public decimal MontoCuota { get; set; }
            public decimal InteresCuota { get; set; }
            public decimal AbonoCapital { get; set; }
            public decimal SaldoRemanente { get; set; }
            public DateTime FechaVencimiento { get; set; }
        }

    private string connectionString = "Server=.\\SQLEXPRESS;Database=SistemaPrestamosLogin;Trusted_Connection=True;";

            public decimal ObtenerFondoBanco()
            {
                decimal fondo = 0;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FondoBanco FROM Banco"; // Ajusta si tu tabla se llama diferente

                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        fondo = Convert.ToDecimal(result);
                }

                return fondo;
            }
        }
    }
