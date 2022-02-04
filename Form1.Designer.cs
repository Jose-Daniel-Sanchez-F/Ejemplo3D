namespace Ejemplo3D
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDPI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.label1Edad = new System.Windows.Forms.Label();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.buttonAbrirCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI:";
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(201, 125);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(239, 20);
            this.textBoxDPI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(201, 165);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(239, 20);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(201, 212);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(239, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(201, 257);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(239, 20);
            this.textBoxTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(242, 422);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(171, 56);
            this.buttonIngresar.TabIndex = 10;
            this.buttonIngresar.Text = "Ingresar Datos";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingreso de datos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(585, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Datos ingresados:";
            this.label7.Visible = false;
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDPI.Location = new System.Drawing.Point(606, 125);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(13, 20);
            this.labelDPI.TabIndex = 13;
            this.labelDPI.Text = ".";
            this.labelDPI.Visible = false;
            this.labelDPI.Click += new System.EventHandler(this.labelDPI_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNombre.Location = new System.Drawing.Point(606, 165);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(13, 20);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = ".";
            this.labelNombre.Visible = false;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelApellido.Location = new System.Drawing.Point(606, 212);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(13, 20);
            this.labelApellido.TabIndex = 15;
            this.labelApellido.Text = ".";
            this.labelApellido.Visible = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTelefono.Location = new System.Drawing.Point(606, 257);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(13, 20);
            this.labelTelefono.TabIndex = 16;
            this.labelTelefono.Text = ".";
            this.labelTelefono.Visible = false;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFechaNacimiento.Location = new System.Drawing.Point(606, 347);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(13, 20);
            this.labelFechaNacimiento.TabIndex = 17;
            this.labelFechaNacimiento.Text = ".";
            this.labelFechaNacimiento.Visible = false;
            // 
            // label1Edad
            // 
            this.label1Edad.AutoSize = true;
            this.label1Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1Edad.Location = new System.Drawing.Point(606, 302);
            this.label1Edad.Name = "label1Edad";
            this.label1Edad.Size = new System.Drawing.Size(13, 20);
            this.label1Edad.TabIndex = 18;
            this.label1Edad.Text = ".";
            this.label1Edad.Visible = false;
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(419, 422);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(136, 56);
            this.buttonSalida.TabIndex = 19;
            this.buttonSalida.Text = "Mostrar Datos";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // buttonAbrirCuentas
            // 
            this.buttonAbrirCuentas.Location = new System.Drawing.Point(558, 422);
            this.buttonAbrirCuentas.Name = "buttonAbrirCuentas";
            this.buttonAbrirCuentas.Size = new System.Drawing.Size(109, 56);
            this.buttonAbrirCuentas.TabIndex = 20;
            this.buttonAbrirCuentas.Text = "Abrir Cuenta";
            this.buttonAbrirCuentas.UseVisualStyleBackColor = true;
            this.buttonAbrirCuentas.Click += new System.EventHandler(this.buttonAbrirCuentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 495);
            this.Controls.Add(this.buttonAbrirCuentas);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.label1Edad);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label label1Edad;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.Button buttonAbrirCuentas;
    }
}

