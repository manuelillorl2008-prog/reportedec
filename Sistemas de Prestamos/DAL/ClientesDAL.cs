using System;
using System.Data;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    public class ClientesDAL
    {
        // Registrar cliente
        public void RegistrarCliente(string cedula, string nombre, string apellido,
                                     string correo, string telefono, string direccion,
                                     decimal sueldo, string garantia)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO Clientes (Cedula,Nombre,Apellido,Correo,Telefono,Direccion,Sueldo,Garantia) " +
                "VALUES (@Cedula,@Nombre,@Apellido,@Correo,@Telefono,@Direccion,@Sueldo,@Garantia)", cn);

                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                cmd.Parameters.AddWithValue("@Garantia", garantia);

                cmd.ExecuteNonQuery();
            }
        }

        // Editar cliente
        public void EditarCliente(int id, string nombre, string apellido,
                                  string correo, string telefono, string direccion,
                                  decimal sueldo, string garantia)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(
                "UPDATE Clientes SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, Telefono=@Telefono, Direccion=@Direccion, Sueldo=@Sueldo, Garantia=@Garantia WHERE ClienteID=@ID", cn);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                cmd.Parameters.AddWithValue("@Garantia", garantia);

                cmd.ExecuteNonQuery();
            }
        }

        // Consultar clientes
        public DataTable ConsultarClientes()
        {
            ConexionBD conexionBD = new ConexionBD();

            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // Eliminar cliente
        public void EliminarCliente(int id)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlCommand cmd = new SqlCommand(
                "DELETE FROM Clientes WHERE ClienteID=@ID", cn);

                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Obtener datos del cliente para validar préstamos
        public DataRow ObtenerCliente(int clienteID)
        {
            ConexionBD conexionBD = new ConexionBD();

            using (SqlConnection cn = conexionBD.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes WHERE ClienteID=@ClienteID", cn);
                da.SelectCommand.Parameters.AddWithValue("@ClienteID", clienteID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

    }
}

