namespace ProyectoWindowsForm1.Formularios
{
    partial class FormularioPrincipal
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
            intEdad = new NumericUpDown();
            btnAceptar = new Button();
            comboBoxHijos = new ComboBox();
            labelHijos = new Label();
            checkBoxHijos = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 39);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Nacimiento";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimeFechaNacimiento.Location = new Point(137, 105);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(88, 23);
            dateTimeFechaNacimiento.TabIndex = 8;
            // 
            // intEdad
            // 
            intEdad.Location = new Point(69, 74);
            intEdad.Name = "intEdad";
            intEdad.Size = new Size(100, 23);
            intEdad.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(216, 225);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // comboBoxHijos
            // 
            comboBoxHijos.Enabled = false;
            comboBoxHijos.FormattingEnabled = true;
            comboBoxHijos.Location = new Point(52, 181);
            comboBoxHijos.Name = "comboBoxHijos";
            comboBoxHijos.Size = new Size(88, 23);
            comboBoxHijos.TabIndex = 11;
            comboBoxHijos.Visible = false;
            // 
            // labelHijos
            // 
            labelHijos.AutoSize = true;
            labelHijos.Enabled = false;
            labelHijos.Location = new Point(12, 184);
            labelHijos.Name = "labelHijos";
            labelHijos.Size = new Size(34, 15);
            labelHijos.TabIndex = 12;
            labelHijos.Text = "Hijos";
            labelHijos.Visible = false;
            // 
            // checkBoxHijos
            // 
            checkBoxHijos.AutoSize = true;
            checkBoxHijos.Location = new Point(12, 156);
            checkBoxHijos.Name = "checkBoxHijos";
            checkBoxHijos.Size = new Size(94, 19);
            checkBoxHijos.TabIndex = 13;
            checkBoxHijos.Text = "¿Tiene Hijos?";
            checkBoxHijos.UseVisualStyleBackColor = true;
            checkBoxHijos.CheckedChanged += checkBoxHijos_CheckedChanged;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 260);
            Controls.Add(checkBoxHijos);
            Controls.Add(labelHijos);
            Controls.Add(comboBoxHijos);
            Controls.Add(btnAceptar);
            Controls.Add(intEdad);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeFechaNacimiento;
        private NumericUpDown intEdad;
        private Button btnAceptar;
        private ComboBox comboBoxHijos;
        private Label labelHijos;
        private CheckBox checkBoxHijos;
    }
}