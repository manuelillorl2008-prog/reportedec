using Sistemas_de_Prestamos.BLL;
using Sistemas_de_Prestamos.conexion;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistemas_de_Prestamos.Forms
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void limpiarcambos()
        {
            nombretxt.Clear();
            contraseñatxt.Clear();
            correotxt.Clear();
            roltxt.SelectedIndex = -1; // Si es un ComboBox
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombretxt.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(contraseñatxt.Text))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(correotxt.Text))
            {
                MessageBox.Show("El correo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roltxt.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todo está correcto, llamamos a la BLL
            RegistrousuarioBLL usuarioBLL = new RegistrousuarioBLL();
            string resultado = usuarioBLL.RegistrarUsuario(
                nombretxt.Text,
                contraseñatxt.Text,
                correotxt.Text,
                roltxt.SelectedItem.ToString()
            );

            // Mostrar resultado
            MessageBox.Show(resultado, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos después de registrar
            limpiarcambos();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crear instancia del formulario de login
            FrmLogin frmLogin = new FrmLogin();

            // Mostrar el login
            frmLogin.Show();

            // Ocultar el formulario de registro
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

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            contraseñatxt.UseSystemPasswordChar = true;
        }
    }
    }

