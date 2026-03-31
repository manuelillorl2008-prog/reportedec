using System;
using System.Data;
using System.Windows.Forms;
using Sistemas_de_PrestamosC.BLL; // Importa tu capa DAL
using Sistemas_de_PrestamosF.BLL; 
namespace Sistemas_de_Prestamos.Forms
{
    public partial class Clientes : Form
    {
        private ClientesService clientesService = new ClientesService();
        public Clientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientesService.ObtenerClientes();

            // Refrescar fondo disponible
            FondoService fondoService = new FondoService();
            decimal fondo = fondoService.ConsultarFondo();
            lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + fondo.ToString("N2");

            // Recargar datos de sesión (para que no se pierdan al volver)
            cedulatxt.Text = SesionClientes.Cedula;
            Nombretxt.Text = SesionClientes.Nombre;
            apellidotxt.Text = SesionClientes.Apellido;
            correotxt.Text = SesionClientes.Correo;
            Telefonotxt.Text = SesionClientes.Telefono;

            // Validar sueldo con TryParse para evitar errores
            if (SesionClientes.Sueldo != 0)
                sueldotxt.Text = SesionClientes.Sueldo.ToString();

            garantiatxt.Text = SesionClientes.Garantia;
            direcciontxt.Text = SesionClientes.Direccion;


        }
        public static class SesionClientes
        {
            public static string Cedula { get; set; }
            public static string Nombre { get; set; }
            public static string Apellido { get; set; }
            public static string Correo { get; set; }
            public static string Telefono { get; set; }
            public static decimal Sueldo { get; set; }
            public static string Garantia { get; set; }
            public static string Direccion { get; set; }
        }


        public static class SesionFormularios
        {
            public static FrmPrestamos frmPrestamos = new FrmPrestamos();
            public static Clientes frmClientes = new Clientes();
            public static FrmPagos frmPagos = new FrmPagos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Registrar cliente en la BD
                clientesService.RegistrarCliente(
                    cedulatxt.Text,       // Cedula
                    Nombretxt.Text,       // Nombre
                    apellidotxt.Text,       // Apellido
                    correotxt.Text,      // Correo
                    Telefonotxt.Text,       // Telefono
                    direcciontxt.Text,       // Dirección
                    Convert.ToDecimal(sueldotxt.Text), // Sueldo
                    garantiatxt.Text     // Garantía
                );

                // Refrescar el DataGridView
                dataGridView1.DataSource = clientesService.ObtenerClientes();

                MessageBox.Show("Cliente registrado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteID"].Value);

                try
                {
                    clientesService.EditarCliente(
                        id,
                        Nombretxt.Text,       // Nombre
                        apellidotxt.Text,       // Apellido
                        correotxt.Text,      // Correo
                        Telefonotxt.Text,       // Telefono
                        direcciontxt.Text,       // Dirección
                        Convert.ToDecimal(sueldotxt.Text), // Sueldo
                        garantiatxt.Text     // Garantía
                    );

                    dataGridView1.DataSource = clientesService.ObtenerClientes();
                    MessageBox.Show("Cliente editado correctamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cedulatxt.Clear();   // Cedula
            Nombretxt.Clear();   // Nombre
            apellidotxt.Clear();   // Apellido
            correotxt.Clear();  // Correo
            Telefonotxt.Clear();   // Telefono
            direcciontxt.Clear();   // Dirección
            sueldotxt.Clear();  // Sueldo
            garantiatxt.Clear();// Garantía
        }

        // 🔹 Métodos de navegación (botones arriba)
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SesionClientes.Cedula = cedulatxt.Text;
            SesionClientes.Nombre = Nombretxt.Text;
            SesionClientes.Apellido = apellidotxt.Text;
            SesionClientes.Correo = correotxt.Text;
            SesionClientes.Telefono = Telefonotxt.Text;
            decimal sueldo;
            if (decimal.TryParse(sueldotxt.Text, out sueldo))
            {
                SesionClientes.Sueldo = sueldo;
            }
            else
            {
                SesionClientes.Sueldo = 0;
            }

            SesionClientes.Garantia = garantiatxt.Text;
            SesionClientes.Direccion = direcciontxt.Text;



            SesionFormularios.frmPrestamos.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Guardar datos del cliente en sesión
            SesionClientes.Cedula = cedulatxt.Text;
            SesionClientes.Nombre = Nombretxt.Text;
            SesionClientes.Apellido = apellidotxt.Text;
            SesionClientes.Correo = correotxt.Text;
            SesionClientes.Telefono = Telefonotxt.Text;

            if (decimal.TryParse(sueldotxt.Text, out decimal sueldo))
                SesionClientes.Sueldo = sueldo;
            else
                SesionClientes.Sueldo = 0;

            SesionClientes.Garantia = garantiatxt.Text;
            SesionClientes.Direccion = direcciontxt.Text;

            // Mostrar Pagos usando la instancia compartida
            SesionFormularios.frmPagos.Show();
            this.Hide(); // Ocultar Clientes, no cerrar

        }

        // 🔹 Evento para cargar datos al seleccionar fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                cedulatxt.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                Nombretxt.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                apellidotxt.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                correotxt.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                Telefonotxt.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                direcciontxt.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                sueldotxt.Text = dataGridView1.CurrentRow.Cells["Sueldo"].Value.ToString();
                garantiatxt.Text = dataGridView1.CurrentRow.Cells["Garantia"].Value.ToString();
            }

        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteID"].Value);

                try
                {
                    clientesService.EliminarCliente(id);
                    dataGridView1.DataSource = clientesService.ObtenerClientes();
                    MessageBox.Show("Cliente eliminado correctamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void garantiatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns.Add("Periodo", "Periodo");
            dataGridView1.Columns.Add("Cuota", "Cuota");
            dataGridView1.Columns.Add("Interes", "Interes");
            dataGridView1.Columns.Add("Capital", "Capital");
            dataGridView1.Columns.Add("Saldo", "Saldo");
        }

        public static class SesionAmortizacion
        {
            public static string NombreCliente { get; set; }
            public static decimal MontoDeseado { get; set; }
            public static decimal Sueldo { get; set; }
            public static int PlazoMeses { get; set; }
            public static int Moras { get; set; }
            public static DateTime FechaInicio { get; set; }
        }

        private void Btn_Amortizacion_Click(object sender, EventArgs e)
        {
            // Guardar lo que está en los TextBox de Clientes
            SesionAmortizacion.NombreCliente = Nombretxt.Text;
            if (decimal.TryParse(sueldotxt.Text, out decimal sueldo))
                SesionAmortizacion.Sueldo = sueldo;
            else
                SesionAmortizacion.Sueldo = 0;

            SesionAmortizacion.MontoDeseado = 0; // si lo defines después en amortización
            SesionAmortizacion.PlazoMeses = 0;
            SesionAmortizacion.Moras = 0;
            SesionAmortizacion.FechaInicio = DateTime.Now;

            // Abrir amortización
            FrmAmortizacion frm = new FrmAmortizacion();
            frm.Show();
            this.Hide();

        }
    }
    }

