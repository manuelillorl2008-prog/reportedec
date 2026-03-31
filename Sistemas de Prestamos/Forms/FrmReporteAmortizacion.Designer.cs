namespace Sistemas_de_Prestamos.Forms
{
    partial class FrmReporteAmortizacion
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarCsv.Location = new System.Drawing.Point(650, 410);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(120, 23);
            this.btnExportarCsv.TabIndex = 1;
            this.btnExportarCsv.Text = "Exportar CSV";
            this.btnExportarCsv.UseVisualStyleBackColor = true;
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(35, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "label1";
            // 
            // FrmReporteAmortizacion
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmReporteAmortizacion";
            this.Text = "Reporte de Amortización";
            this.Load += new System.EventHandler(this.FrmReporteAmortizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportarCsv;
        private System.Windows.Forms.Label lblCliente;
    }
}
