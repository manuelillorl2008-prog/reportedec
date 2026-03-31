using System;
using System.Data.SqlClient;

namespace Sistemas_de_Prestamos.DAL
{
    internal class RegistrousuarioDAL
    {
        // Ajusta el nombre de tu servidor SQL aquí
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=SistemaPrestamosLogin;Trusted_Connection=True;";

        // Método para insertar un nuevo usuario
        public void InsertarUsuario(string nombreUsuario, string clave, string correo, string rol = "Usuario")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Usuarios (NombreUsuario, Clave, Correo, Rol)
                                 VALUES (@NombreUsuario, @Clave, @Correo, @Rol)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Rol", rol);

                cmd.ExecuteNonQuery();
            }
        }

        // Método para validar login usando el procedimiento almacenado
        public bool ValidarLogin(string nombreUsuario, string clave)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ValidarLogin", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Aquí puedes obtener el rol si lo necesitas
                    string rol = reader["Rol"].ToString();

                    // Solo permitir Admin y Supervisor
                    if (rol == "Administrador" || rol == "Supervisor")
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("Acceso denegado. El rol '" + rol + "' no tiene permisos.");
                    }
                }
                else
                {
                    return false; // No encontró usuario
                }
            }
        }

    }
}
