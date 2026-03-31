using Sistemas_de_Prestamos.BLL;
using Sistemas_de_Prestamos.DAL;
using Sistemas_de_PrestamosC.BLL; // Importa tu capa DAL
using Sistemas_de_PrestamosF.BLL;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistemas_de_Prestamos.Forms
{
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
            this.Clienteid.Leave += new System.EventHandler(this.textBox1_Leave);

            FondoService fondoService = new FondoService();
            decimal fondo = fondoService.ConsultarFondo();

            lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + fondo.ToString("N2");

        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            // Refrescar lista de préstamos en el DataGridView
            PrestamosDAL dal = new PrestamosDAL();
            dataGridView1.DataSource = dal.ConsultarPrestamos();

            // Refrescar fondo disponible
            FondoService fondoService = new FondoService();
            decimal fondo = fondoService.ConsultarFondo();
            lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + fondo.ToString("N2");

            // Recargar datos de sesión (para que no se pierdan al volver)
            Clienteid.Text = SesionPrestamo.ClienteID.ToString();
            Monto.Text = SesionPrestamo.Monto.ToString();
            sueldotxt.Text = SesionPrestamo.Sueldo.ToString();
            garantiatxt.Text = SesionPrestamo.Garantia;
            if (SesionPrestamo.Meses >= numericUpDown1.Minimum && SesionPrestamo.Meses <= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = SesionPrestamo.Meses;
            }
            else
            {
                numericUpDown1.Value = numericUpDown1.Minimum; // o un valor seguro
            }

            textBox5.Text = SesionPrestamo.Estado;
        }

        public static class SesionFormularios
        {
            public static FrmPrestamos frmPrestamos = new FrmPrestamos();
            public static Clientes frmClientes = new Clientes();
            public static FrmPagos frmPagos = new FrmPagos();
        }

        public static class SesionPrestamo
        {
            public static int ClienteID { get; set; }
            public static decimal Monto { get; set; }
            public static decimal Sueldo { get; set; }
            public static string Garantia { get; set; }
            public static int Meses { get; set; }
            public static string Estado { get; set; }
        }


        private void CalcularPrestamo()
        {
            PrestamoService servicio = new PrestamoService();
            decimal monto;
            int meses;

            if (decimal.TryParse(Monto.Text, out monto) &&
                int.TryParse(numericUpDown1.Value.ToString(), out meses))
            {
                decimal tasa = servicio.ObtenerTasa(meses);
                decimal interes = servicio.CalcularInteresGenerado(monto, tasa, meses);
                decimal total = servicio.CalcularTotal(monto, interes);
                decimal cuota = servicio.CalcularCuota(monto, tasa, meses);

                interestxt.Text = interes.ToString("0.00");
                totaltxt.Text = total.ToString("0.00");
                cuotamtxt.Text = cuota.ToString("0.00");
            }


        }

        // Registrar
        private void button1_Click(object sender, EventArgs e)
        {
            int clienteId;
            decimal monto;
            decimal sueldo;
            string garantia;

            PrestamoService servicio = new PrestamoService();
            PrestamosDAL dal = new PrestamosDAL();

            // Validar ClienteID
            if (!int.TryParse(Clienteid.Text.Trim(), out clienteId))
            {
                MessageBox.Show("ClienteID inválido.");
                return;
            }

            // Validar monto
            if (!decimal.TryParse(Monto.Text.Trim(), out monto))
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            // Validar sueldo
            if (!decimal.TryParse(sueldotxt.Text.Trim(), out sueldo))
            {
                MessageBox.Show("Sueldo inválido.");
                return;
            }

            garantia = garantiatxt.Text.Trim();
            int meses = (int)numericUpDown1.Value;
            string estado = textBox5.Text.Trim();

            try
            {
                // Obtener el nombre del cliente automáticamente
                ClientesService clienteService = new ClientesService();
                var cliente = clienteService.ObtenerCliente(clienteId);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                string nombreCliente = cliente["Nombre"].ToString();
                NombreClientetxt.Text = nombreCliente; // mostrarlo en el TextBox
                // Verificar moras del cliente antes de crear el préstamo
                int morasCliente = dal.ObtenerTotalMorasCliente(clienteId);
                if (morasCliente >= 3)
                {
                    MessageBox.Show("Ya tienes 3 moras, por lo tanto, no puedes pedir más préstamos.", "Cliente moroso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Crear préstamo
                int nuevoID = servicio.CrearPrestamo(
                    clienteId,
                    monto,
                    meses,
                    sueldo,
                    garantia,
                    dateTimePicker1.Value,
                    estado
                );
                FondoService fondoService = new FondoService();
                decimal fondoActual = fondoService.ConsultarFondo();
                decimal nuevoFondo = fondoActual - monto;
                fondoService.ActualizarFondo(nuevoFondo);

                // Refrescar label
                lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + nuevoFondo.ToString("N2");

                MessageBox.Show("Préstamo registrado correctamente. ID: " + nuevoID);
                dataGridView1.DataSource = dal.ConsultarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar préstamo: " + ex.Message);
            }

        }

        // Editar
        private void button2_Click(object sender, EventArgs e)
        {
            PrestamosDAL dal = new PrestamosDAL();
            PrestamoService servicio = new PrestamoService();

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PrestamoID"].Value);

                int clienteId;
                decimal monto;

                if (!int.TryParse(Clienteid.Text.Trim(), out clienteId))
                {
                    MessageBox.Show("ClienteID inválido.");
                    return;
                }

                if (!decimal.TryParse(Monto.Text.Trim(), out monto))
                {
                    MessageBox.Show("Monto inválido.");
                    return;
                }

                int meses = (int)numericUpDown1.Value;
                decimal tasa = servicio.ObtenerTasa(meses);
                decimal interes = servicio.CalcularInteresGenerado(monto, tasa, meses);
                decimal montoTotal = servicio.CalcularTotal(monto, interes);
                string estado = textBox5.Text.Trim();

                // Obtener el nombre del cliente automáticamente
                ClientesService clienteService = new ClientesService();
                var cliente = clienteService.ObtenerCliente(clienteId);
                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                string nombreCliente = cliente["Nombre"].ToString();
                NombreClientetxt.Text = nombreCliente; // mostrarlo en el formulario

                // Editar préstamo en DAL
                dal.EditarPrestamo(id, monto, meses, tasa, interes, montoTotal, estado, 0);

                MessageBox.Show("Préstamo editado correctamente.");
                dataGridView1.DataSource = dal.ConsultarPrestamos();
                LimpiarCampos();
            } 

        }

        // Limpiar
        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Clientes
        private void button4_Click(object sender, EventArgs e)
        {
            // ClienteID
            int clienteID;
            if (int.TryParse(Clienteid.Text, out clienteID))
                SesionPrestamo.ClienteID = clienteID;
            else
                SesionPrestamo.ClienteID = 0; // valor por defecto

            // Monto
            decimal monto;
            if (decimal.TryParse(Monto.Text, out monto))
                SesionPrestamo.Monto = monto;
            else
                SesionPrestamo.Monto = 0;

            // Sueldo
            decimal sueldo;
            if (decimal.TryParse(sueldotxt.Text, out sueldo))
                SesionPrestamo.Sueldo = sueldo;
            else
                SesionPrestamo.Sueldo = 0;

            // Otros campos (texto no necesitan Parse)
            SesionPrestamo.Garantia = garantiatxt.Text;
            SesionPrestamo.Meses = (int)numericUpDown1.Value;
            SesionPrestamo.Estado = textBox5.Text;


            SesionFormularios.frmClientes.Show();
            this.Hide();
        }


        // Refrescar préstamos
        private void button5_Click(object sender, EventArgs e)
        {

        }

        // Pagos
        private void button6_Click(object sender, EventArgs e)
        {
            // ClienteID
            int clienteID;
            if (int.TryParse(Clienteid.Text, out clienteID))
                SesionPrestamo.ClienteID = clienteID;
            else
                SesionPrestamo.ClienteID = 0; // valor por defecto

            // Monto
            decimal monto;
            if (decimal.TryParse(Monto.Text, out monto))
                SesionPrestamo.Monto = monto;
            else
                SesionPrestamo.Monto = 0;

            // Sueldo
            decimal sueldo;
            if (decimal.TryParse(sueldotxt.Text, out sueldo))
                SesionPrestamo.Sueldo = sueldo;
            else
                SesionPrestamo.Sueldo = 0;

            // Otros campos (texto no necesitan Parse)
            SesionPrestamo.Garantia = garantiatxt.Text;
            SesionPrestamo.Meses = (int)numericUpDown1.Value;
            SesionPrestamo.Estado = textBox5.Text;

            SesionFormularios.frmPagos.Show();
            this.Hide();
        }

        // Eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            PrestamosDAL dal = new PrestamosDAL();

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PrestamoID"].Value);

                try
                {
                    dal.EliminarPrestamo(id);
                    _ = MessageBox.Show("Préstamo eliminado correctamente.");

                    // Refrescar la lista de préstamos
                    dataGridView1.DataSource = dal.ConsultarPrestamos();

                    // Limpiar los campos del formulario
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar préstamo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para eliminar.");
            }
        }

        private void LimpiarCampos()
        {
            Clienteid.Clear(); // ClienteID
            Monto.Clear(); // Monto
            sueldotxt.Clear(); // Sueldo
            garantiatxt.Clear(); // Garantía
            textBox5.Clear(); // Estado
            interestxt.Clear();
            totaltxt.Clear();
            cuotamtxt.Clear();
            moratxt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            Clienteid.Focus();
            NombreClientetxt.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Columns.Add("Periodo", "Periodo");
                dataGridView1.Columns.Add("Cuota", "Cuota");
                dataGridView1.Columns.Add("Interes", "Interes");
                dataGridView1.Columns.Add("Capital", "Capital");
                dataGridView1.Columns.Add("Saldo", "Saldo");
            }

            if (dataGridView1.CurrentRow != null)
            {
                Clienteid.Text = dataGridView1.CurrentRow.Cells["ClienteID"].Value.ToString();
                Monto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PlazoMeses"].Value);
                textBox5.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                moratxt.Text = dataGridView1.CurrentRow.Cells["MorasAcumuladas"].Value.ToString();

                // Aquí llenamos el nombre del cliente
                NombreClientetxt.Text = dataGridView1.CurrentRow.Cells["NombreCliente"].Value.ToString();

                CalcularPrestamo();

                // Verificar si el cliente en la fila seleccionada tiene 3 o más moras
                int morasFila;
                if (int.TryParse(moratxt.Text, out morasFila) && morasFila >= 3)
                {
                    MessageBox.Show("Ya tienes 3 moras, por lo tanto, no puedes pedir más préstamos.", "Cliente moroso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrestamo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalcularPrestamo();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            PrestamosDAL dal = new PrestamosDAL();
            FondoService fondoService = new FondoService();

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PrestamoID"].Value);

                try
                {
                    // Obtener el préstamo antes de eliminarlo (para saber el monto)
                    var prestamo = dal.ObtenerPrestamo(id);
                    if (prestamo == null)
                    {
                        MessageBox.Show("Préstamo no encontrado.");
                        return;
                    }

                    decimal monto = Convert.ToDecimal(prestamo["Monto"]);

                    // Eliminar préstamo
                    dal.EliminarPrestamo(id);

                    // Actualizar fondo (sumar el monto eliminado al fondo disponible)
                    decimal fondoActual = fondoService.ConsultarFondo();
                    decimal nuevoFondo = fondoActual + monto;
                    fondoService.ActualizarFondo(nuevoFondo);

                    // Refrescar label
                    lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + nuevoFondo.ToString("N2");

                    MessageBox.Show("Préstamo eliminado correctamente.");

                    // Refrescar la lista de préstamos
                    dataGridView1.DataSource = dal.ConsultarPrestamos();

                    // Limpiar los campos del formulario
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar préstamo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para eliminar.");
            }

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Clienteid.Text))
            {
                // Si está vacío, no hacemos nada
                return;
            }

            int clienteId;
            if (!int.TryParse(Clienteid.Text.Trim(), out clienteId))
            {
                MessageBox.Show("ClienteID inválido.");
                return;
            }

            try
            {
                ClientesService clienteService = new ClientesService();
                var cliente = clienteService.ObtenerCliente(clienteId);

                if (cliente != null)
                {
                    NombreClientetxt.Text = cliente["Nombre"].ToString();
                    sueldotxt.Text = cliente["Sueldo"].ToString();
                    garantiatxt.Text = cliente["Garantia"].ToString();
                    try
                    {
                        PrestamosDAL prestamoDal = new PrestamosDAL();
                        int moras = prestamoDal.ObtenerTotalMorasCliente(clienteId);
                        moratxt.Text = moras.ToString();
                        if (moras >= 3)
                        {
                            MessageBox.Show("Ya tienes 3 moras, por lo tanto, no puedes pedir más préstamos.", "Cliente moroso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        // No bloquear flujo por fallo al consultar moras, sólo mostrar error mínimo
                        MessageBox.Show("Error al verificar moras: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del cliente: " + ex.Message);
            }
        }
            private void FrmPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            int tmpInt;
            decimal tmpDec;
            if (int.TryParse(Clienteid.Text, out tmpInt)) SesionPrestamo.ClienteID = tmpInt; else SesionPrestamo.ClienteID = 0;
            if (decimal.TryParse(Monto.Text, out tmpDec)) SesionPrestamo.Monto = tmpDec; else SesionPrestamo.Monto = 0;
            if (decimal.TryParse(sueldotxt.Text, out tmpDec)) SesionPrestamo.Sueldo = tmpDec; else SesionPrestamo.Sueldo = 0;
            SesionPrestamo.Garantia = garantiatxt.Text;
            SesionPrestamo.Meses = (int)numericUpDown1.Value;
            SesionPrestamo.Estado = textBox5.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}




