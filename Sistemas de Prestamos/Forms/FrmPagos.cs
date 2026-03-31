using Sistemas_de_Prestamos.BLL;
using Sistemas_de_Prestamos.DAL;
using Sistemas_de_PrestamosC.BLL;
using Sistemas_de_PrestamosF.BLL;
using System;
using System.Data;
using System.Windows.Forms;
using static Sistemas_de_Prestamos.Forms.FrmPrestamos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistemas_de_Prestamos.Forms
{
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
            this.NombreClientetxt.Leave += new System.EventHandler(this.NombreClientetxt_Leave);

        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            try
            {
                PagosDAL dal = new PagosDAL();
                dataGridView1.DataSource = dal.ConsultarPagos();

                FondoService fondoService = new FondoService();
                decimal fondo = fondoService.ConsultarFondo();
                lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + fondo.ToString("N2");

                textBox1.Text = SesionPagos.PrestamoID.ToString();
                textBox2.Text = SesionPagos.MontoPagado.ToString();
                Moratxt.Text = SesionPagos.Mora.ToString();
                Fechapagodtp.Value = SesionPagos.FechaPago == DateTime.MinValue ? DateTime.Now : SesionPagos.FechaPago;
                estadotxt.Text = SesionPagos.Estado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Pagos: " + ex.Message);
            }



        }
        public static class SesionPagos
        {
            public static int PrestamoID { get; set; }
            public static decimal MontoPagado { get; set; }
            public static decimal Mora { get; set; }
            public static DateTime FechaPago { get; set; }
            public static string Estado { get; set; }
        }
        public static class SesionFormularios
        {
            public static FrmPrestamos frmPrestamos = new FrmPrestamos();
            public static Clientes frmClientes = new Clientes();
            public static FrmPagos frmPagos = new FrmPagos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prestamoID;
            decimal montoPagado;
            decimal mora = 0;

            // Validar PrestamoID
            if (!int.TryParse(textBox1.Text.Trim(), out prestamoID))
            {
                MessageBox.Show("PrestamoID no válido.");
                return;
            }

            // Validar monto de pago
            if (!decimal.TryParse(textBox2.Text.Trim(), out montoPagado))
            {
                MessageBox.Show("Monto de pago no válido.");
                return;
            }

            // Validar mora (opcional, si el usuario la escribe)
            if (!string.IsNullOrWhiteSpace(Moratxt.Text))
            {
                if (!decimal.TryParse(Moratxt.Text.Trim(), out mora))
                {
                    MessageBox.Show("Valor de mora no válido.");
                    return;
                }
            }

            DateTime fechaPago = Fechapagodtp.Value;
            string estado = estadotxt.Text.Trim();

            PagoService servicio = new PagoService();
            FondoService fondoService = new FondoService();

            try
            {
                // Registrar pago (el BLL calculará la mora si se pasa 0)
                int nuevoID = servicio.RegistrarPago(prestamoID, montoPagado, fechaPago, estado, mora);

                // Mostrar el nombre del cliente en el TextBox
                NombreClientetxt.Text = servicio.ObtenerNombreClienteDesdePrestamo(prestamoID);

                // Actualizar fondo (sumar lo pagado al fondo disponible)
                decimal fondoActual = fondoService.ConsultarFondo();
                decimal nuevoFondo = fondoActual + montoPagado;
                fondoService.ActualizarFondo(nuevoFondo);

                // Refrescar label
                lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ " + nuevoFondo.ToString("N2");

                // Mensaje de confirmación
                MessageBox.Show("Pago registrado correctamente. ID: " + nuevoID);

                // Aviso adicional si el pago generó mora
                if (mora > 0)
                {
                    MessageBox.Show("⚠ Este pago generó una mora de RD$ " + mora.ToString("N2"));
                }

                // Refrescar DataGrid
                dataGridView1.DataSource = servicio.ConsultarPagos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago: " + ex.Message);
            }
        }



        private void LimpiarCampos()
        {
            textBox1.Clear(); // PrestamoID
            textBox2.Clear(); // Monto del pago
            Fechapagodtp.Value = DateTime.Now; // Fecha de pago
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Editar pago seleccionado
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PagoID"].Value);

                DateTime fechaPago = Fechapagodtp.Value;

                decimal montoPagado;
                if (!decimal.TryParse(textBox2.Text.Trim(), out montoPagado))
                {
                    MessageBox.Show("El monto del pago no es válido.");
                    return;
                }

                decimal mora = 0;
                if (!string.IsNullOrWhiteSpace(Moratxt.Text))
                {
                    if (!decimal.TryParse(Moratxt.Text.Trim(), out mora))
                    {
                        MessageBox.Show("Valor de mora no válido.");
                        return;
                    }
                }

                string estado = estadotxt.Text.Trim();

                PagoService servicio = new PagoService();
                try
                {
                    // Editar pago (el BLL calculará la mora si se pasa 0)
                    servicio.EditarPago(id, montoPagado, fechaPago, estado, mora);

                    // Mostrar el nombre del cliente en el TextBox
                    NombreClientetxt.Text = servicio.ObtenerNombreClienteDesdePrestamo(
                        Convert.ToInt32(textBox1.Text) // PrestamoID
                    );

                    // Mensaje de confirmación
                    MessageBox.Show("Pago editado correctamente.");

                    // Aviso adicional si el pago tiene mora
                    if (mora > 0)
                    {
                        MessageBox.Show("⚠ Este pago tiene una mora de RD$ " + mora.ToString("N2"));
                    }

                    // Refrescar DataGrid
                    dataGridView1.DataSource = servicio.ConsultarPagos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar pago: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pago para editar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int prestamoID;
            if (int.TryParse(textBox1.Text, out prestamoID))
                SesionPagos.PrestamoID = prestamoID;

            decimal monto;
            if (decimal.TryParse(textBox2.Text, out monto))
                SesionPagos.MontoPagado = monto;

            decimal mora;
            if (decimal.TryParse(Moratxt.Text, out mora))
                SesionPagos.Mora = mora;

            SesionPagos.FechaPago = Fechapagodtp.Value;
            SesionPagos.Estado = estadotxt.Text;

            // Navegar
            SesionFormularios.frmClientes.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int prestamoID;
            if (int.TryParse(textBox1.Text, out prestamoID))
                SesionPagos.PrestamoID = prestamoID;

            decimal monto;
            if (decimal.TryParse(textBox2.Text, out monto))
                SesionPagos.MontoPagado = monto;

            decimal mora;
            if (decimal.TryParse(Moratxt.Text, out mora))
                SesionPagos.Mora = mora;

            SesionPagos.FechaPago = Fechapagodtp.Value;
            SesionPagos.Estado = estadotxt.Text;

            // Navegar
            SesionFormularios.frmPrestamos.Show();
            this.Hide();

        }



        private void button6_Click(object sender, EventArgs e)
        {
            PagosDAL dal = new PagosDAL();
            dataGridView1.DataSource = dal.ConsultarPagos();
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
                // PrestamoID → textBox1
                textBox1.Text = dataGridView1.CurrentRow.Cells["PrestamoID"].Value.ToString();

                // MontoPagado → textBox2
                textBox2.Text = dataGridView1.CurrentRow.Cells["MontoPagado"].Value.ToString();

                // Si quieres duplicar la fecha en otro campo (ejemplo textBox4)
                Fechapagodtp.Text = dataGridView1.CurrentRow.Cells["FechaPago"].Value.ToString();

                estadotxt.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();

            }
        }
        

        private void btneliminar_Click(object sender, EventArgs e)
        {
            PagoService servicio = new PagoService(); // usamos PagoService (BLL)

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PagoID"].Value);

                try
                {
                    servicio.EliminarPago(id);

                    MessageBox.Show("Pago eliminado correctamente.");
                    dataGridView1.DataSource = servicio.ConsultarPagos(); // refrescar grilla
                    LimpiarCampos(); // limpiar los campos del formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar pago: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pago para eliminar.");
            }


        }

        private void NombreClientetxt_TextChanged(object sender, EventArgs e)
        {

            }

            private void NombreClientetxt_Leave(object sender, EventArgs e)
        {
            try
            {
                int prestamoID = Convert.ToInt32(textBox1.Text.Trim());
                PagoService servicio = new PagoService();

                // Obtener el nombre del cliente desde el préstamo
                string nombreCliente = servicio.ObtenerNombreClienteDesdePrestamo(prestamoID);

                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    NombreClientetxt.Text = nombreCliente; // mostrarlo en el TextBox
                }
                else
                {
                    MessageBox.Show("No se encontró el préstamo con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar nombre del cliente: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void estadotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fechapagodtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bttnAmortizacion(object sender, EventArgs e)
        {   
            FrmAmortizacion frm = new FrmAmortizacion();
            frm.Show(); // Abre el formulario
        }
    }
    }
    

