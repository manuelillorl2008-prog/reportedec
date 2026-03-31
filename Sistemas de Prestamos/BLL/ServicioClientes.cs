using System;
using System.Data;
using Sistemas_de_Prestamos.DAL;

namespace Sistemas_de_PrestamosC.BLL
{
    public class ClientesService
    {
        private ClientesDAL clientesDAL = new ClientesDAL();

        // Validar datos del cliente
        private void ValidarCliente(string nombre, string apellido, string correo, string telefono, decimal sueldo, string garantia)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (sueldo <= 0)
                throw new Exception("El sueldo debe ser mayor que 0.");

        }

        // Registrar cliente
        public void RegistrarCliente(string cedula, string nombre, string apellido,
                                     string correo, string telefono, string direccion,
                                     decimal sueldo, string garantia)
        {
            ValidarCliente(nombre, apellido, correo, telefono, sueldo, garantia);

            clientesDAL.RegistrarCliente(
                cedula,
                nombre,
                apellido,
                correo,
                telefono,
                direccion,
                sueldo,
                garantia
            );
        }

        // Editar cliente
        public void EditarCliente(int id, string nombre, string apellido,
                                  string correo, string telefono, string direccion,
                                  decimal sueldo, string garantia)
        {
            ValidarCliente(nombre, apellido, correo, telefono, sueldo, garantia);

            clientesDAL.EditarCliente(
                id,
                nombre,
                apellido,
                correo,
                telefono,
                direccion,
                sueldo,
                garantia
            );
        }

        // Obtener todos los clientes
        public DataTable ObtenerClientes()
        {
            return clientesDAL.ConsultarClientes();
        }

        // Eliminar cliente
        public void EliminarCliente(int id)
        {
            if (id <= 0)
                throw new Exception("ID de cliente inválido.");

            clientesDAL.EliminarCliente(id);
        }

        // Obtener información del cliente
        public DataRow ObtenerCliente(int clienteID)
        {
            if (clienteID <= 0)
                throw new Exception("ID de cliente inválido.");

            return clientesDAL.ObtenerCliente(clienteID);
        }

        // Verificar si el cliente es moroso
        public string VerificarEstadoCliente(int moras)
        {
            return moras >= 3 ? "Moroso" : "Activo";
        }

        public (string garantia, decimal sueldo) ObtenerGarantiaYSueldo(int clienteID)
        {
            DataRow cliente = clientesDAL.ObtenerCliente(clienteID);
            if (cliente == null) throw new Exception("Cliente no encontrado.");

            string garantia = cliente["Garantia"].ToString();
            decimal sueldo = Convert.ToDecimal(cliente["Sueldo"]);

            return (garantia, sueldo);
        }

    }
}