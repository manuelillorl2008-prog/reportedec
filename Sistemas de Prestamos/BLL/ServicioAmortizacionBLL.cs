using Sistemas_de_Amortizacion.DAL;
using Sistemas_de_Prestamos.DAL;
using System;
using System.Collections.Generic;
using static Sistemas_de_Amortizacion.DAL.AmortizacionDAL;

namespace Servicios_de_Amortizacion.BLL
{
    public class AmortizacionBLL
    {
        private AmortizacionDAL dal = new AmortizacionDAL();

        public decimal ConsultarFondoBanco()
        {
            return dal.ObtenerFondoBanco();
        }

        public string ValidarReglas(decimal sueldo, decimal montoDeseado, decimal fondoBanco, int moras)
        {
            // Bloquear si el cliente tiene 3 o más moras acumuladas
            if (moras >= 3)
                return "Cliente con 3 o más moras";

            if (montoDeseado > fondoBanco)
                return "Monto excede fondo disponible";

            if (sueldo < 10000)
                return "Sueldo insuficiente";

            return "OK";
        }

        public double CalcularTEM(double tea)
        {
            return Math.Pow(1 + tea, 1.0 / 12) - 1;
        }

        public List<Cuotas> GenerarCuotas(decimal montoPrestamo, double tea, int meses, DateTime fechaInicio)
        {
            List<Cuotas> cuotas = new List<Cuotas>();
            double i = CalcularTEM(tea);
            double cuotaFija = CalcularCuotaFija(montoPrestamo, i, meses);
            decimal saldoAnterior = montoPrestamo;

            for (int mes = 1; mes <= meses; mes++)
            {
                double interesesDelMes = (double)saldoAnterior * i;
                double amortizacionCapital = cuotaFija - interesesDelMes;
                decimal nuevoSaldo = saldoAnterior - (decimal)amortizacionCapital;

                cuotas.Add(new Cuotas
                {
                    NumeroDeCuota = mes,
                    MontoCuota = decimal.Round((decimal)cuotaFija, 2),
                    InteresCuota = decimal.Round((decimal)interesesDelMes, 2),
                    AbonoCapital = decimal.Round((decimal)amortizacionCapital, 2),
                    SaldoRemanente = decimal.Round(Math.Max(0, nuevoSaldo), 2),
                    FechaVencimiento = fechaInicio.AddMonths(mes)
                });

                saldoAnterior = nuevoSaldo;
            }

            return cuotas;
        }

        private double CalcularCuotaFija(decimal montoPrestamo, double i, int meses)
        {
            double P = (double)montoPrestamo;
            return P * (i * Math.Pow(1 + i, meses)) / (Math.Pow(1 + i, meses) - 1);
        }
    }
}