

namespace NominaApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputCedula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputSueldo = new System.Windows.Forms.TextBox();
            this.inputDiasTrabajados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNhed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNhen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputNhedd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNhedn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputNhrn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_trabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhedd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhedn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCedula
            // 
            this.inputCedula.Location = new System.Drawing.Point(77, 89);
            this.inputCedula.Name = "inputCedula";
            this.inputCedula.Size = new System.Drawing.Size(152, 20);
            this.inputCedula.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(78, 73);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 2;
            this.labelCedula.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(278, 89);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(203, 20);
            this.inputNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sueldo";
            // 
            // inputSueldo
            // 
            this.inputSueldo.Location = new System.Drawing.Point(526, 89);
            this.inputSueldo.Name = "inputSueldo";
            this.inputSueldo.Size = new System.Drawing.Size(100, 20);
            this.inputSueldo.TabIndex = 6;
            // 
            // inputDiasTrabajados
            // 
            this.inputDiasTrabajados.Location = new System.Drawing.Point(689, 89);
            this.inputDiasTrabajados.Name = "inputDiasTrabajados";
            this.inputDiasTrabajados.Size = new System.Drawing.Size(100, 20);
            this.inputDiasTrabajados.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dias trabajados";
            // 
            // inputNhed
            // 
            this.inputNhed.Location = new System.Drawing.Point(77, 140);
            this.inputNhed.Name = "inputNhed";
            this.inputNhed.Size = new System.Drawing.Size(100, 20);
            this.inputNhed.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NHED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "NHEN";
            // 
            // inputNhen
            // 
            this.inputNhen.Location = new System.Drawing.Point(496, 140);
            this.inputNhen.Name = "inputNhen";
            this.inputNhen.Size = new System.Drawing.Size(100, 20);
            this.inputNhen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "NHEDD";
            // 
            // inputNhedd
            // 
            this.inputNhedd.Location = new System.Drawing.Point(225, 140);
            this.inputNhedd.Name = "inputNhedd";
            this.inputNhedd.Size = new System.Drawing.Size(100, 20);
            this.inputNhedd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NHEDN";
            // 
            // inputNhedn
            // 
            this.inputNhedn.Location = new System.Drawing.Point(624, 140);
            this.inputNhedn.Name = "inputNhedn";
            this.inputNhedn.Size = new System.Drawing.Size(100, 20);
            this.inputNhedn.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "NHRN";
            // 
            // inputNhrn
            // 
            this.inputNhrn.Location = new System.Drawing.Point(361, 140);
            this.inputNhrn.Name = "inputNhrn";
            this.inputNhrn.Size = new System.Drawing.Size(100, 20);
            this.inputNhrn.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Crear Cliente";
            // 
            // dataGridEmpleados
            // 
            this.dataGridEmpleados.AllowUserToAddRows = false;
            this.dataGridEmpleados.AllowUserToDeleteRows = false;
            this.dataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Sueldo,
            this.dias_trabajados,
            this.nhed,
            this.nhedd,
            this.nhrn,
            this.nhen,
            this.nhedn});
            this.dataGridEmpleados.Location = new System.Drawing.Point(75, 274);
            this.dataGridEmpleados.Name = "dataGridEmpleados";
            this.dataGridEmpleados.ReadOnly = true;
            this.dataGridEmpleados.Size = new System.Drawing.Size(898, 228);
            this.dataGridEmpleados.TabIndex = 20;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // dias_trabajados
            // 
            this.dias_trabajados.HeaderText = "Dias Trabajados";
            this.dias_trabajados.Name = "dias_trabajados";
            this.dias_trabajados.ReadOnly = true;
            // 
            // nhed
            // 
            this.nhed.HeaderText = "NHED";
            this.nhed.Name = "nhed";
            this.nhed.ReadOnly = true;
            // 
            // nhedd
            // 
            this.nhedd.HeaderText = "NHEDD";
            this.nhedd.Name = "nhedd";
            this.nhedd.ReadOnly = true;
            // 
            // nhrn
            // 
            this.nhrn.HeaderText = "NHRN";
            this.nhrn.Name = "nhrn";
            this.nhrn.ReadOnly = true;
            // 
            // nhen
            // 
            this.nhen.HeaderText = "NHEN";
            this.nhen.Name = "nhen";
            this.nhen.ReadOnly = true;
            // 
            // nhedn
            // 
            this.nhedn.HeaderText = "NHEDN";
            this.nhedn.Name = "nhedn";
            this.nhedn.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1037, 582);
            this.Controls.Add(this.dataGridEmpleados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputNhrn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputNhedn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputNhedd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputNhen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNhed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDiasTrabajados);
            this.Controls.Add(this.inputSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputCedula);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputSueldo;
        private System.Windows.Forms.TextBox inputDiasTrabajados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNhed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNhen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputNhedd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNhedn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputNhrn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_trabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhedd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhedn;
    }
}

