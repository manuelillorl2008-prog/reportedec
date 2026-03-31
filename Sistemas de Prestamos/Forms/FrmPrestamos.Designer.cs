namespace Sistemas_de_Prestamos.Forms
{
    partial class FrmPrestamos   
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Clienteid = new System.Windows.Forms.TextBox();
            this.lblFondoDisponible = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.interestxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cuotamtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.moratxt = new System.Windows.Forms.TextBox();
            this.garantiatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sueldotxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.NombreClientetxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(213, 7);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 31;
            this.button6.Text = "Pagos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 30;
            this.button5.Text = "Prestamos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 29;
            this.button4.Text = "Clientes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(564, 331);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 27;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(181, 199);
            this.Monto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(273, 22);
            this.Monto.TabIndex = 22;
            this.Monto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Clienteid
            // 
            this.Clienteid.Location = new System.Drawing.Point(181, 129);
            this.Clienteid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clienteid.Name = "Clienteid";
            this.Clienteid.Size = new System.Drawing.Size(273, 22);
            this.Clienteid.TabIndex = 21;
            this.Clienteid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFondoDisponible
            // 
            this.lblFondoDisponible.AutoSize = true;
            this.lblFondoDisponible.Location = new System.Drawing.Point(379, 53);
            this.lblFondoDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFondoDisponible.Name = "lblFondoDisponible";
            this.lblFondoDisponible.Size = new System.Drawing.Size(252, 16);
            this.lblFondoDisponible.TabIndex = 20;
            this.lblFondoDisponible.Text = "FONDO DISPONIBLE: RD$ 10,000,000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha de Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "ClienteID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Estado";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 351);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(273, 22);
            this.textBox5.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 314);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Meses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Interes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // interestxt
            // 
            this.interestxt.Location = new System.Drawing.Point(140, 391);
            this.interestxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interestxt.Name = "interestxt";
            this.interestxt.ReadOnly = true;
            this.interestxt.Size = new System.Drawing.Size(115, 22);
            this.interestxt.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cuota Mensual";
            // 
            // cuotamtxt
            // 
            this.cuotamtxt.Location = new System.Drawing.Point(140, 422);
            this.cuotamtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuotamtxt.Name = "cuotamtxt";
            this.cuotamtxt.ReadOnly = true;
            this.cuotamtxt.Size = new System.Drawing.Size(115, 22);
            this.cuotamtxt.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Monto Total";
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(140, 454);
            this.totaltxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(115, 22);
            this.totaltxt.TabIndex = 42;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 460);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown1.TabIndex = 43;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 398);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Mora";
            // 
            // moratxt
            // 
            this.moratxt.Location = new System.Drawing.Point(340, 425);
            this.moratxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moratxt.Name = "moratxt";
            this.moratxt.ReadOnly = true;
            this.moratxt.Size = new System.Drawing.Size(115, 22);
            this.moratxt.TabIndex = 45;
            // 
            // garantiatxt
            // 
            this.garantiatxt.Location = new System.Drawing.Point(181, 229);
            this.garantiatxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.garantiatxt.Name = "garantiatxt";
            this.garantiatxt.ReadOnly = true;
            this.garantiatxt.Size = new System.Drawing.Size(273, 22);
            this.garantiatxt.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Garantia";
            // 
            // sueldotxt
            // 
            this.sueldotxt.Location = new System.Drawing.Point(181, 268);
            this.sueldotxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sueldotxt.Name = "sueldotxt";
            this.sueldotxt.ReadOnly = true;
            this.sueldotxt.Size = new System.Drawing.Size(273, 22);
            this.sueldotxt.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "sueldo";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(955, 7);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(100, 28);
            this.btnborrar.TabIndex = 50;
            this.btnborrar.Text = "Eliminar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // NombreClientetxt
            // 
            this.NombreClientetxt.Location = new System.Drawing.Point(181, 169);
            this.NombreClientetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreClientetxt.Name = "NombreClientetxt";
            this.NombreClientetxt.ReadOnly = true;
            this.NombreClientetxt.Size = new System.Drawing.Size(273, 22);
            this.NombreClientetxt.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "NombreCliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblFondoDisponible);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 80);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btnborrar);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 54);
            this.panel2.TabIndex = 54;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NombreClientetxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sueldotxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.garantiatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moratxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cuotamtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.interestxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.Clienteid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1085, 600);
            this.MinimumSize = new System.Drawing.Size(1085, 600);
            this.Name = "FrmPrestamos";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox Clienteid;
        private System.Windows.Forms.Label lblFondoDisponible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox interestxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cuotamtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox moratxt;
        private System.Windows.Forms.TextBox garantiatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sueldotxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox NombreClientetxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
