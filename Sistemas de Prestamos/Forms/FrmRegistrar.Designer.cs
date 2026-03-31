namespace Sistemas_de_Prestamos.Forms
{
    partial class FrmRegistrar
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
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contraseñatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roltxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vercontrabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(132, 211);
            this.nombretxt.Margin = new System.Windows.Forms.Padding(4);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(273, 22);
            this.nombretxt.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 217);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 73;
            this.label13.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 317);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 71;
            this.label12.Text = "Rol";
            // 
            // correotxt
            // 
            this.correotxt.Location = new System.Drawing.Point(132, 278);
            this.correotxt.Margin = new System.Windows.Forms.Padding(4);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(273, 22);
            this.correotxt.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Correo";
            // 
            // contraseñatxt
            // 
            this.contraseñatxt.Location = new System.Drawing.Point(132, 242);
            this.contraseñatxt.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñatxt.Name = "contraseñatxt";
            this.contraseñatxt.Size = new System.Drawing.Size(273, 22);
            this.contraseñatxt.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Contraseña";
            // 
            // roltxt
            // 
            this.roltxt.FormattingEnabled = true;
            this.roltxt.Items.AddRange(new object[] {
            "Administrador",
            "Cliente",
            "Cajero",
            "Supervisor",
            "Agente de crédito"});
            this.roltxt.Location = new System.Drawing.Point(132, 317);
            this.roltxt.Margin = new System.Windows.Forms.Padding(4);
            this.roltxt.Name = "roltxt";
            this.roltxt.Size = new System.Drawing.Size(273, 24);
            this.roltxt.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 52);
            this.label1.TabIndex = 76;
            this.label1.Text = "Registro";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(18, 348);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(100, 28);
            this.btnregistrar.TabIndex = 77;
            this.btnregistrar.Text = "Registrarse";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 78;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Ya tienes cuenta? ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 69);
            this.panel1.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btnregistrar);
            this.panel2.Location = new System.Drawing.Point(509, -12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 500);
            this.panel2.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 78);
            this.panel3.TabIndex = 82;
            // 
            // vercontrabtn
            // 
            this.vercontrabtn.Location = new System.Drawing.Point(413, 239);
            this.vercontrabtn.Margin = new System.Windows.Forms.Padding(4);
            this.vercontrabtn.Name = "vercontrabtn";
            this.vercontrabtn.Size = new System.Drawing.Size(28, 28);
            this.vercontrabtn.TabIndex = 78;
            this.vercontrabtn.Text = "👁️";
            this.vercontrabtn.UseVisualStyleBackColor = true;
            this.vercontrabtn.Click += new System.EventHandler(this.vercontrabtn_Click);
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 554);
            this.Controls.Add(this.vercontrabtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roltxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contraseñatxt);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraseñatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button vercontrabtn;
    }
}