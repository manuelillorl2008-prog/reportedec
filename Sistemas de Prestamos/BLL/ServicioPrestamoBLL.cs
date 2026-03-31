using Sistemas_de_Prestamos.DAL;
using Sistemas_de_PrestamosC.BLL;
using System;
using System.Data;

namespace Sistemas_de_Prestamos.BLL
{
    public class PrestamoService
    {
        private PrestamosDAL prestamosDAL = new PrestamosDAL();
        private ClientesService clienteService = new ClientesService();
        private FondoDAL fondosDAL = new FondoDAL(); // Manejo de fondos

        // Crear préstamo
        public int CrearPrestamo(int clienteID, decimal monto, int plazoMeses,
                                 decimal sueldo, string garantia, DateTime fechaPrestamo,
                                 string estado)
        {
            // Validación de sueldo
            if (monto > sueldo * 4)
                throw new Exception("El monto del préstamo no puede superar 4 veces el sueldo del cliente.");

            // Validación de garantía
            if (string.IsNullOrEmpty(garantia))
                throw new Exception("La garantía es obligatoria para el préstamo.");

            // Validación de fondos disponibles
            decimal fondosDisponibles = fondosDAL.ObtenerMontoDisponible();
            if (monto > fondosDisponibles)
                throw new Exception("La entidad no posee fondos suficientes para otorgar este préstamo.");

            // Obtener datos del cliente
            DataRow cliente = clienteService.ObtenerCliente(clienteID);
            if (cliente == null)
                throw new Exception("Cliente no encontrado.");

            // Verificar moras acumuladas del cliente: si tiene 3 o más, no puede solicitar más préstamos
            int morasAcumuladas = prestamosDAL.ObtenerTotalMorasCliente(clienteID);
            if (morasAcumuladas >= 3)
                throw new Exception("Ya tienes 3 moras, por lo tanto, no puedes pedir más préstamos.");

            string nombreCliente = cliente["Nombre"].ToString();

            // Calcular tasa e interés
            decimal tasaInteres = ObtenerTasa(plazoMeses);
            decimal interesGenerado = CalcularInteresGenerado(monto, tasaInteres, plazoMeses);
            decimal montoTotal = CalcularTotal(monto, interesGenerado);

            // Registrar préstamo
            int prestamoID = prestamosDAL.RegistrarPrestamo(
                clienteID,
                nombreCliente,
                monto,
                plazoMeses,
                tasaInteres,
                interesGenerado,
                montoTotal,
                estado,
                0, // moras iniciales
                fechaPrestamo
            );

            // Actualizar fondos (restar el monto prestado)
            fondosDAL.ActualizarMontoDisponible(fondosDisponibles - monto);

            return prestamoID;
        }

        // Actualizar préstamo
        public void ActualizarPrestamo(int prestamoID, decimal monto, int plazoMeses, string estado)
        {
            decimal tasaInteres = ObtenerTasa(plazoMeses);
            decimal interesGenerado = CalcularInteresGenerado(monto, tasaInteres, plazoMeses);
            decimal montoTotal = CalcularTotal(monto, interesGenerado);

            prestamosDAL.EditarPrestamo(prestamoID, monto, plazoMeses, tasaInteres, interesGenerado, montoTotal, estado, 0);
        }

        // Consultar préstamos
        public DataTable ConsultarPrestamos()
        {
            return prestamosDAL.ConsultarPrestamos();
        }

        // Obtener préstamo específico
        public DataRow ObtenerPrestamo(int prestamoID)
        {
            return prestamosDAL.ObtenerPrestamo(prestamoID);
        }

        // Eliminar préstamo
        public void EliminarPrestamo(int prestamoID)
        {
            prestamosDAL.EliminarPrestamo(prestamoID);
        }

        // Cálculo de tasa según meses
        public decimal ObtenerTasa(int plazoMeses)
        {
            if (plazoMeses <= 6) return 0.05m;
            if (plazoMeses <= 12) return 0.08m;
            return 0.10m;
        }

        // Cálculo de interés generado
        public decimal CalcularInteresGenerado(decimal monto, decimal tasa, int meses)
        {
            return monto * tasa * meses;
        }

        // Cálculo de monto total
        public decimal CalcularTotal(decimal monto, decimal interes)
        {
            return monto + interes;
        }

        // Cálculo de cuota mensual
        public decimal CalcularCuota(decimal monto, decimal tasa, int meses)
        {
            decimal interes = CalcularInteresGenerado(monto, tasa, meses);
            decimal total = CalcularTotal(monto, interes);
            return total / meses;
        }
    }
}
