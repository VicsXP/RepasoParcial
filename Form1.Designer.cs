namespace RepasoParcial
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.numericUpDownSueldoHora = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownEmpleado = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDownHoras = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumEmpleado = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Sueldo = new System.Windows.Forms.Label();
            this.buttonGuardarAsistencia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSueldoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonIngreso);
            this.tabPage1.Controls.Add(this.numericUpDownSueldoHora);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxApellido);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownEmpleado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empleado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(312, 340);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(75, 23);
            this.buttonIngreso.TabIndex = 8;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownSueldoHora
            // 
            this.numericUpDownSueldoHora.Location = new System.Drawing.Point(58, 286);
            this.numericUpDownSueldoHora.Name = "numericUpDownSueldoHora";
            this.numericUpDownSueldoHora.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSueldoHora.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sueldo por hora";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(58, 217);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 22);
            this.textBoxApellido.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(61, 146);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. de Empleado";
            // 
            // numericUpDownEmpleado
            // 
            this.numericUpDownEmpleado.Location = new System.Drawing.Point(58, 58);
            this.numericUpDownEmpleado.Name = "numericUpDownEmpleado";
            this.numericUpDownEmpleado.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEmpleado.TabIndex = 0;
            this.numericUpDownEmpleado.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxMes);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonGuardarAsistencia);
            this.tabPage2.Controls.Add(this.Sueldo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numericUpDownNumEmpleado);
            this.tabPage2.Controls.Add(this.numericUpDownHoras);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage3.Size = new System.Drawing.Size(782, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // numericUpDownHoras
            // 
            this.numericUpDownHoras.Location = new System.Drawing.Point(142, 138);
            this.numericUpDownHoras.Name = "numericUpDownHoras";
            this.numericUpDownHoras.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHoras.TabIndex = 0;
            // 
            // numericUpDownNumEmpleado
            // 
            this.numericUpDownNumEmpleado.Location = new System.Drawing.Point(142, 82);
            this.numericUpDownNumEmpleado.Name = "numericUpDownNumEmpleado";
            this.numericUpDownNumEmpleado.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNumEmpleado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "No. Empleado";
            // 
            // Sueldo
            // 
            this.Sueldo.AutoSize = true;
            this.Sueldo.Location = new System.Drawing.Point(32, 140);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(44, 16);
            this.Sueldo.TabIndex = 3;
            this.Sueldo.Text = "Horas";
            // 
            // buttonGuardarAsistencia
            // 
            this.buttonGuardarAsistencia.Location = new System.Drawing.Point(473, 257);
            this.buttonGuardarAsistencia.Name = "buttonGuardarAsistencia";
            this.buttonGuardarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarAsistencia.TabIndex = 4;
            this.buttonGuardarAsistencia.Text = "Guardar";
            this.buttonGuardarAsistencia.UseVisualStyleBackColor = true;
            this.buttonGuardarAsistencia.Click += new System.EventHandler(this.buttonGuardarAsistencia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mes";
            // 
            // textBoxMes
            // 
            this.textBoxMes.Location = new System.Drawing.Point(142, 180);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(100, 22);
            this.textBoxMes.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSueldoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownEmpleado;
        private System.Windows.Forms.NumericUpDown numericUpDownSueldoHora;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuardarAsistencia;
        private System.Windows.Forms.Label Sueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownNumEmpleado;
        private System.Windows.Forms.NumericUpDown numericUpDownHoras;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Label label6;
    }
}

