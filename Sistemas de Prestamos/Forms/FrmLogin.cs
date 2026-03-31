using Sistemas_de_Prestamos.conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistemas_de_Prestamos.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void limpiarcampos()
        {
            nombretxt.Clear();
            contraseñatxt.Clear();
            correotxt.Clear();
        }

        // Botón 7: Ingresar (Login)
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas antes de consultar la BD
                if (string.IsNullOrWhiteSpace(nombretxt.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarcampos();
                    return;
                }

                if (string.IsNullOrWhiteSpace(contraseñatxt.Text))
                {
                    MessageBox.Show("Debe ingresar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarcampos();
                    return;
                }

                using (SqlConnection conexion = ConexionBD2.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ValidarLogin", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombretxt.Text);
                    cmd.Parameters.AddWithValue("@Clave", contraseñatxt.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string rol = reader["Rol"].ToString();

                        // Validar roles permitidos
                        if (rol == "Administrador" || rol == "Supervisor")
                        {
                            MessageBox.Show("Bienvenido " + nombretxt.Text + " (" + rol + ")",
                                            "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir el formulario principal (CRUD)
                            Clientes frm = new Clientes();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Acceso denegado. El rol '" + rol + "' no tiene permisos para entrar al CRUD.",
                                            "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            limpiarcampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrectos.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        limpiarcampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crear instancia del formulario de registro
            FrmRegistrar frm = new FrmRegistrar();

            // Mostrar el formulario de registro
            frm.Show();

            // Opcional: ocultar el login mientras tanto
            this.Hide();

        }

        private void vercontrabtn_Click(object sender, EventArgs e)
        {
            // Si está oculto, mostrar
            if (contraseñatxt.UseSystemPasswordChar)
            {
                contraseñatxt.UseSystemPasswordChar = false;

            }
            else
            {
                contraseñatxt.UseSystemPasswordChar = true;

            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            contraseñatxt.UseSystemPasswordChar = true;
        }
    }
}
