using Sistemas_de_Prestamos.DAL;
using System;

namespace Sistemas_de_Prestamos.BLL
{
    internal class RegistrousuarioBLL
    {
        private RegistrousuarioDAL usuarioDAL = new RegistrousuarioDAL();

        // Método para registrar un usuario con validaciones
        public string RegistrarUsuario(string nombreUsuario, string clave, string correo, string rol = "Usuario")
        {
            // Validaciones básicas antes de llamar al DAL
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                return "El nombre de usuario es obligatorio.";

            if (string.IsNullOrWhiteSpace(clave))
                return "La clave es obligatoria.";

            if (string.IsNullOrWhiteSpace(correo))
                return "El correo es obligatorio.";

            // Aquí podrías agregar más reglas de negocio (ejemplo: validar formato de correo)

            try
            {
                usuarioDAL.InsertarUsuario(nombreUsuario, clave, correo, rol);
                return "Usuario registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar usuario: " + ex.Message;
            }
        }

        // Método para validar login
        public bool ValidarLogin(string nombreUsuario, string clave)
        {
            return usuarioDAL.ValidarLogin(nombreUsuario, clave);
        }
    }
}
