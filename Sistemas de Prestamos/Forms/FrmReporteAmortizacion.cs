using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sistemas_de_Prestamos.Forms
{
    public partial class FrmReporteAmortizacion : Form
    {
        private DataTable data;
        private string clienteNombre;

        public FrmReporteAmortizacion(DataTable dt, string nombre)
        {
            InitializeComponent();
            data = dt;
            clienteNombre = nombre;
        }

        private void FrmReporteAmortizacion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data;
            lblCliente.Text = "Amortización - " + clienteNombre;
        }

        private void btnExportarCsv_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = "Amortizacion_" + clienteNombre + ".csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder sb = new StringBuilder();

                        // encabezados
                        for (int i = 0; i < data.Columns.Count; i++)
                        {
                            if (i > 0) sb.Append(',');
                            sb.Append(data.Columns[i].ColumnName);
                        }
                        sb.AppendLine();

                        // filas
                        foreach (DataRow row in data.Rows)
                        {
                            for (int i = 0; i < data.Columns.Count; i++)
                            {
                                if (i > 0) sb.Append(',');
                                sb.Append(row[i].ToString());
                            }
                            sb.AppendLine();
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("CSV exportado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exportando CSV: " + ex.Message);
            }
        }
    }
}
