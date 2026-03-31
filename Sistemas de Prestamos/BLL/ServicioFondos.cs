using Sistemas_de_Prestamos.DAL;

namespace Sistemas_de_PrestamosF.BLL
{
    public class FondoService
    {
        private FondoDAL fondoDAL = new FondoDAL();

        public decimal ConsultarFondo()
        {
            return fondoDAL.ObtenerMontoDisponible();
        }

        public void ActualizarFondo(decimal nuevoMonto)
        {
            fondoDAL.ActualizarMontoDisponible(nuevoMonto);
        }
    }
}
