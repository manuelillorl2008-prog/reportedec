namespace Sistemas_de_Prestamos.Forms
{
    partial class FrmAmortizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtbox_monto_deseado = new System.Windows.Forms.TextBox();
            this.lbl_TEA = new System.Windows.Forms.Label();
            this.txtBox_Tasa_Anual = new System.Windows.Forms.TextBox();
            this.dgv_Cuotas = new System.Windows.Forms.DataGridView();
            this.bttn_Calcular = new System.Windows.Forms.Button();
            this.bttn_Volver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbox_Nombre = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtbox_Sueldo = new System.Windows.Forms.TextBox();
            this.lbl_Monto_de_la_Empresa = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl_limitedeprestamo = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblMoras = new System.Windows.Forms.Label();
            this.txtBox_Moras = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.txtbox_Garantia = new System.Windows.Forms.TextBox();
            this.lbl_tipo_de_tiempo = new System.Windows.Forms.Label();
            this.txtBox_tipo_de_tiempo = new System.Windows.Forms.TextBox();
            this.txtbox_cuotas = new System.Windows.Forms.TextBox();
            this.lbl_Cuotas = new System.Windows.Forms.Label();
            this.lbl_Fecha_Solicitada = new System.Windows.Forms.Label();
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro = new System.Windows.Forms.Label();
            this.lblTEM = new System.Windows.Forms.Label();
            this.txt_TEM = new System.Windows.Forms.TextBox();
            this.lbl_Tiempo_de_meses = new System.Windows.Forms.Label();
            this.txtbox_tiempo_de_meses = new System.Windows.Forms.TextBox();
            this.lbl_Plazo = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar = new System.Windows.Forms.Button();
            this.DTP_1 = new System.Windows.Forms.DateTimePicker();
            this.DTP_2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(263, 116);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(81, 13);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto deseado";
            // 
            // txtbox_monto_deseado
            // 
            this.txtbox_monto_deseado.Location = new System.Drawing.Point(355, 116);
            this.txtbox_monto_deseado.Name = "txtbox_monto_deseado";
            this.txtbox_monto_deseado.Size = new System.Drawing.Size(126, 20);
            this.txtbox_monto_deseado.TabIndex = 1;
            // 
            // lbl_TEA
            // 
            this.lbl_TEA.AutoSize = true;
            this.lbl_TEA.Location = new System.Drawing.Point(307, 280);
            this.lbl_TEA.Name = "lbl_TEA";
            this.lbl_TEA.Size = new System.Drawing.Size(28, 13);
            this.lbl_TEA.TabIndex = 3;
            this.lbl_TEA.Text = "TEA";
            // 
            // txtBox_Tasa_Anual
            // 
            this.txtBox_Tasa_Anual.Location = new System.Drawing.Point(355, 277);
            this.txtBox_Tasa_Anual.Name = "txtBox_Tasa_Anual";
            this.txtBox_Tasa_Anual.Size = new System.Drawing.Size(128, 20);
            this.txtBox_Tasa_Anual.TabIndex = 4;
            // 
            // dgv_Cuotas
            // 
            this.dgv_Cuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_Cuotas.Location = new System.Drawing.Point(-6, 303);
            this.dgv_Cuotas.Name = "dgv_Cuotas";
            this.dgv_Cuotas.Size = new System.Drawing.Size(803, 238);
            this.dgv_Cuotas.TabIndex = 7;
            this.dgv_Cuotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttn_Calcular
            // 
            this.bttn_Calcular.Location = new System.Drawing.Point(662, 274);
            this.bttn_Calcular.Name = "bttn_Calcular";
            this.bttn_Calcular.Size = new System.Drawing.Size(126, 23);
            this.bttn_Calcular.TabIndex = 8;
            this.bttn_Calcular.Text = "Calcular";
            this.bttn_Calcular.UseVisualStyleBackColor = true;
            this.bttn_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_Volver
            // 
            this.bttn_Volver.Location = new System.Drawing.Point(517, 274);
            this.bttn_Volver.Name = "bttn_Volver";
            this.bttn_Volver.Size = new System.Drawing.Size(139, 23);
            this.bttn_Volver.TabIndex = 9;
            this.bttn_Volver.Text = "Volver";
            this.bttn_Volver.UseVisualStyleBackColor = true;
            this.bttn_Volver.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // txtbox_Nombre
            // 
            this.txtbox_Nombre.Location = new System.Drawing.Point(65, 19);
            this.txtbox_Nombre.Name = "txtbox_Nombre";
            this.txtbox_Nombre.Size = new System.Drawing.Size(142, 20);
            this.txtbox_Nombre.TabIndex = 11;
            this.txtbox_Nombre.TextChanged += new System.EventHandler(this.txtbox_Nombre_TextChanged);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(12, 51);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 12;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtbox_Sueldo
            // 
            this.txtbox_Sueldo.Location = new System.Drawing.Point(65, 48);
            this.txtbox_Sueldo.Name = "txtbox_Sueldo";
            this.txtbox_Sueldo.Size = new System.Drawing.Size(142, 20);
            this.txtbox_Sueldo.TabIndex = 13;
            // 
            // lbl_Monto_de_la_Empresa
            // 
            this.lbl_Monto_de_la_Empresa.AutoSize = true;
            this.lbl_Monto_de_la_Empresa.Location = new System.Drawing.Point(535, 58);
            this.lbl_Monto_de_la_Empresa.Name = "lbl_Monto_de_la_Empresa";
            this.lbl_Monto_de_la_Empresa.Size = new System.Drawing.Size(106, 13);
            this.lbl_Monto_de_la_Empresa.TabIndex = 14;
            this.lbl_Monto_de_la_Empresa.Text = "Monto de la empresa";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(647, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 15;
            // 
            // lbl_limitedeprestamo
            // 
            this.lbl_limitedeprestamo.AutoSize = true;
            this.lbl_limitedeprestamo.Location = new System.Drawing.Point(550, 15);
            this.lbl_limitedeprestamo.Name = "lbl_limitedeprestamo";
            this.lbl_limitedeprestamo.Size = new System.Drawing.Size(91, 13);
            this.lbl_limitedeprestamo.TabIndex = 16;
            this.lbl_limitedeprestamo.Text = "limite de prestamo";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(647, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 17;
            // 
            // lblMoras
            // 
            this.lblMoras.AutoSize = true;
            this.lblMoras.Location = new System.Drawing.Point(288, 19);
            this.lblMoras.Name = "lblMoras";
            this.lblMoras.Size = new System.Drawing.Size(36, 13);
            this.lblMoras.TabIndex = 18;
            this.lblMoras.Text = "Moras";
            // 
            // txtBox_Moras
            // 
            this.txtBox_Moras.Location = new System.Drawing.Point(330, 19);
            this.txtBox_Moras.Name = "txtBox_Moras";
            this.txtBox_Moras.Size = new System.Drawing.Size(138, 20);
            this.txtBox_Moras.TabIndex = 19;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(288, 55);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(47, 13);
            this.lblGarantia.TabIndex = 20;
            this.lblGarantia.Text = "Garantia";
            // 
            // txtbox_Garantia
            // 
            this.txtbox_Garantia.Location = new System.Drawing.Point(341, 51);
            this.txtbox_Garantia.Name = "txtbox_Garantia";
            this.txtbox_Garantia.Size = new System.Drawing.Size(149, 20);
            this.txtbox_Garantia.TabIndex = 22;
            // 
            // lbl_tipo_de_tiempo
            // 
            this.lbl_tipo_de_tiempo.AutoSize = true;
            this.lbl_tipo_de_tiempo.Location = new System.Drawing.Point(263, 156);
            this.lbl_tipo_de_tiempo.Name = "lbl_tipo_de_tiempo";
            this.lbl_tipo_de_tiempo.Size = new System.Drawing.Size(77, 13);
            this.lbl_tipo_de_tiempo.TabIndex = 23;
            this.lbl_tipo_de_tiempo.Text = "Tipo de tiempo";
            // 
            // txtBox_tipo_de_tiempo
            // 
            this.txtBox_tipo_de_tiempo.Location = new System.Drawing.Point(346, 153);
            this.txtBox_tipo_de_tiempo.Name = "txtBox_tipo_de_tiempo";
            this.txtBox_tipo_de_tiempo.Size = new System.Drawing.Size(135, 20);
            this.txtBox_tipo_de_tiempo.TabIndex = 24;
            // 
            // txtbox_cuotas
            // 
            this.txtbox_cuotas.Location = new System.Drawing.Point(662, 186);
            this.txtbox_cuotas.Name = "txtbox_cuotas";
            this.txtbox_cuotas.Size = new System.Drawing.Size(126, 20);
            this.txtbox_cuotas.TabIndex = 25;
            // 
            // lbl_Cuotas
            // 
            this.lbl_Cuotas.AutoSize = true;
            this.lbl_Cuotas.Location = new System.Drawing.Point(616, 189);
            this.lbl_Cuotas.Name = "lbl_Cuotas";
            this.lbl_Cuotas.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cuotas.TabIndex = 26;
            this.lbl_Cuotas.Text = "Cuotas";
            // 
            // lbl_Fecha_Solicitada
            // 
            this.lbl_Fecha_Solicitada.AutoSize = true;
            this.lbl_Fecha_Solicitada.Location = new System.Drawing.Point(263, 193);
            this.lbl_Fecha_Solicitada.Name = "lbl_Fecha_Solicitada";
            this.lbl_Fecha_Solicitada.Size = new System.Drawing.Size(86, 13);
            this.lbl_Fecha_Solicitada.TabIndex = 27;
            this.lbl_Fecha_Solicitada.Text = "Fecha Solicitada";
            // 
            // lbl_Fecha_de_Inicio_y_dia_de_cobro
            // 
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.AutoSize = true;
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.Location = new System.Drawing.Point(194, 253);
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.Name = "lbl_Fecha_de_Inicio_y_dia_de_cobro";
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.Size = new System.Drawing.Size(150, 13);
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.TabIndex = 30;
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.Text = "Fecha de Inicio y dia de cobro";
            this.lbl_Fecha_de_Inicio_y_dia_de_cobro.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblTEM
            // 
            this.lblTEM.AutoSize = true;
            this.lblTEM.Location = new System.Drawing.Point(619, 131);
            this.lblTEM.Name = "lblTEM";
            this.lblTEM.Size = new System.Drawing.Size(30, 13);
            this.lblTEM.TabIndex = 31;
            this.lblTEM.Text = "TEM";
            // 
            // txt_TEM
            // 
            this.txt_TEM.Location = new System.Drawing.Point(655, 131);
            this.txt_TEM.Name = "txt_TEM";
            this.txt_TEM.Size = new System.Drawing.Size(133, 20);
            this.txt_TEM.TabIndex = 32;
            // 
            // lbl_Tiempo_de_meses
            // 
            this.lbl_Tiempo_de_meses.AutoSize = true;
            this.lbl_Tiempo_de_meses.Location = new System.Drawing.Point(566, 160);
            this.lbl_Tiempo_de_meses.Name = "lbl_Tiempo_de_meses";
            this.lbl_Tiempo_de_meses.Size = new System.Drawing.Size(90, 13);
            this.lbl_Tiempo_de_meses.TabIndex = 33;
            this.lbl_Tiempo_de_meses.Text = "Tiempo de meses";
            // 
            // txtbox_tiempo_de_meses
            // 
            this.txtbox_tiempo_de_meses.Location = new System.Drawing.Point(662, 160);
            this.txtbox_tiempo_de_meses.Name = "txtbox_tiempo_de_meses";
            this.txtbox_tiempo_de_meses.Size = new System.Drawing.Size(126, 20);
            this.txtbox_tiempo_de_meses.TabIndex = 34;
            // 
            // lbl_Plazo
            // 
            this.lbl_Plazo.AutoSize = true;
            this.lbl_Plazo.Location = new System.Drawing.Point(288, 224);
            this.lbl_Plazo.Name = "lbl_Plazo";
            this.lbl_Plazo.Size = new System.Drawing.Size(33, 13);
            this.lbl_Plazo.TabIndex = 35;
            this.lbl_Plazo.Text = "Plazo";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(346, 220);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(179, 20);
            this.textBox15.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Periodo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Inetereses";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amortizacion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Capital Pendiente";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cuotas";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cuotas";
            this.Column6.Name = "Column6";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(582, 243);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(170, 23);
            this.Guardar.TabIndex = 37;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // DTP_1
            // 
            this.DTP_1.Location = new System.Drawing.Point(355, 194);
            this.DTP_1.Name = "DTP_1";
            this.DTP_1.Size = new System.Drawing.Size(200, 20);
            this.DTP_1.TabIndex = 38;
            // 
            // DTP_2
            // 
            this.DTP_2.Location = new System.Drawing.Point(350, 251);
            this.DTP_2.Name = "DTP_2";
            this.DTP_2.Size = new System.Drawing.Size(200, 20);
            this.DTP_2.TabIndex = 39;
            // 
            // FrmAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.DTP_2);
            this.Controls.Add(this.DTP_1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.lbl_Plazo);
            this.Controls.Add(this.txtbox_tiempo_de_meses);
            this.Controls.Add(this.lbl_Tiempo_de_meses);
            this.Controls.Add(this.txt_TEM);
            this.Controls.Add(this.lblTEM);
            this.Controls.Add(this.lbl_Fecha_de_Inicio_y_dia_de_cobro);
            this.Controls.Add(this.lbl_Fecha_Solicitada);
            this.Controls.Add(this.lbl_Cuotas);
            this.Controls.Add(this.txtbox_cuotas);
            this.Controls.Add(this.txtBox_tipo_de_tiempo);
            this.Controls.Add(this.lbl_tipo_de_tiempo);
            this.Controls.Add(this.txtbox_Garantia);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.txtBox_Moras);
            this.Controls.Add(this.lblMoras);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lbl_limitedeprestamo);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lbl_Monto_de_la_Empresa);
            this.Controls.Add(this.txtbox_Sueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtbox_Nombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bttn_Volver);
            this.Controls.Add(this.bttn_Calcular);
            this.Controls.Add(this.dgv_Cuotas);
            this.Controls.Add(this.txtBox_Tasa_Anual);
            this.Controls.Add(this.lbl_TEA);
            this.Controls.Add(this.txtbox_monto_deseado);
            this.Controls.Add(this.lblMonto);
            this.Name = "FrmAmortizacion";
            this.Text = " FrmAmortizacion";
            this.Load += new System.EventHandler(this.FrmAmortizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtbox_monto_deseado;
        private System.Windows.Forms.Label lbl_TEA;
        private System.Windows.Forms.TextBox txtBox_Tasa_Anual;
        private System.Windows.Forms.DataGridView dgv_Cuotas;
        private System.Windows.Forms.Button bttn_Calcular;
        private System.Windows.Forms.Button bttn_Volver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtbox_Nombre;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtbox_Sueldo;
        private System.Windows.Forms.Label lbl_Monto_de_la_Empresa;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl_limitedeprestamo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblMoras;
        private System.Windows.Forms.TextBox txtBox_Moras;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.TextBox txtbox_Garantia;
        private System.Windows.Forms.Label lbl_tipo_de_tiempo;
        private System.Windows.Forms.TextBox txtBox_tipo_de_tiempo;
        private System.Windows.Forms.TextBox txtbox_cuotas;
        private System.Windows.Forms.Label lbl_Cuotas;
        private System.Windows.Forms.Label lbl_Fecha_Solicitada;
        private System.Windows.Forms.Label lbl_Fecha_de_Inicio_y_dia_de_cobro;
        private System.Windows.Forms.Label lblTEM;
        private System.Windows.Forms.TextBox txt_TEM;
        private System.Windows.Forms.Label lbl_Tiempo_de_meses;
        private System.Windows.Forms.TextBox txtbox_tiempo_de_meses;
        private System.Windows.Forms.Label lbl_Plazo;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DateTimePicker DTP_1;
        private System.Windows.Forms.DateTimePicker DTP_2;
    }
}