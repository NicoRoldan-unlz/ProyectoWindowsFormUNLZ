namespace ProyectoWindowsForm1.Formularios
{
    partial class AltaPersona
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
            btnGuardarDatos = new Button();
            intEdad = new NumericUpDown();
            dateTimeFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(110, 155);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(115, 23);
            btnGuardarDatos.TabIndex = 19;
            btnGuardarDatos.Text = "Guardar Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // intEdad
            // 
            intEdad.Location = new Point(69, 76);
            intEdad.Name = "intEdad";
            intEdad.Size = new Size(100, 23);
            intEdad.TabIndex = 18;
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(137, 107);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(88, 23);
            dateTimeFechaNacimiento.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 16;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 15;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // AltaPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 203);
            Controls.Add(btnGuardarDatos);
            Controls.Add(intEdad);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "AltaPersona";
            Text = "AltaPersona";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarDatos;
        private NumericUpDown intEdad;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
    }
}