using System;
using System.Data;
using Sistemas_de_Prestamos.DAL;

namespace Sistemas_de_Prestamos.BLL
{
    public class PagoService
    {
        private PagosDAL pagosDAL = new PagosDAL();
        private PrestamoService prestamoService = new PrestamoService();

        // Registrar pago con parámetro mora
        public int RegistrarPago(int prestamoID, decimal montoPagado, DateTime fechaPago, string estado, decimal mora)
        {
            // Buscar el préstamo en la tabla Prestamos
            DataRow prestamo = prestamoService.ObtenerPrestamo(prestamoID);

            if (prestamo == null)
                throw new Exception("Préstamo no encontrado.");

            string nombreCliente = prestamo["NombreCliente"].ToString();
            DateTime fechaPrestamo = Convert.ToDateTime(prestamo["FechaPrestamo"]); // 👈 CORRECTO

            // Si no se pasó mora, calcularla automáticamente
            if (mora == 0 && fechaPago > fechaPrestamo.AddMonths(1))
            {
                mora = montoPagado * 0.05m; // penalidad del 5%
            }

            // Guardar el pago con la mora calculada
            return pagosDAL.RegistrarPago(prestamoID, nombreCliente, montoPagado, fechaPago, estado, mora);
        }

        // Consultar todos los pagos
        public DataTable ConsultarPagos()
        {
            return pagosDAL.ConsultarPagos();
        }

        // Obtener pago específico
        public DataRow ObtenerPago(int pagoID)
        {
            return pagosDAL.ObtenerPago(pagoID);
        }

        // Editar pago con parámetro mora
        public void EditarPago(int pagoID, decimal montoPagado, DateTime fechaPago, string estado, decimal mora)
        {
            DataRow pago = ObtenerPago(pagoID);
            if (pago == null)
                throw new Exception("Pago no encontrado.");

            int prestamoID = Convert.ToInt32(pago["PrestamoID"]);
            DataRow prestamo = prestamoService.ObtenerPrestamo(prestamoID);

            if (prestamo == null)
                throw new Exception("Préstamo no encontrado.");

            DateTime fechaPrestamo = Convert.ToDateTime(prestamo["FechaPrestamo"]); // 👈 CORRECTO

            // Si no se pasó mora, calcularla automáticamente
            if (mora == 0 && fechaPago > fechaPrestamo.AddMonths(1))
            {
                mora = montoPagado * 0.05m;
            }

            pagosDAL.EditarPago(pagoID, montoPagado, fechaPago, estado, mora);
        }

        // Eliminar pago
        public void EliminarPago(int pagoID)
        {
            pagosDAL.EliminarPago(pagoID);
        }

        // Obtener nombre del cliente desde PrestamoID
        public string ObtenerNombreClienteDesdePrestamo(int prestamoID)
        {
            DataRow prestamo = prestamoService.ObtenerPrestamo(prestamoID);

            if (prestamo == null)
                throw new Exception("Préstamo no encontrado.");

            return prestamo["NombreCliente"].ToString();
        }
    }
}
