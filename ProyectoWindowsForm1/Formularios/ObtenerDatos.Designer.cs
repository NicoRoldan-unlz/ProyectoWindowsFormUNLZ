namespace ProyectoWindowsForm1.Formularios
{
    partial class ObtenerDatos
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
            btnObtenerDatos = new Button();
            dataGridViewPersonas = new DataGridView();
            label1 = new Label();
            textBoxIdPersona = new NumericUpDown();
            Id_Persona = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBoxIdPersona).BeginInit();
            SuspendLayout();
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(514, 400);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(117, 23);
            btnObtenerDatos.TabIndex = 22;
            btnObtenerDatos.Text = "Obtener Datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // dataGridViewPersonas
            // 
            dataGridViewPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonas.Columns.AddRange(new DataGridViewColumn[] { Id_Persona, Nombre, Apellido, Edad, FechaNacimiento });
            dataGridViewPersonas.Location = new Point(12, 109);
            dataGridViewPersonas.Name = "dataGridViewPersonas";
            dataGridViewPersonas.Size = new Size(619, 285);
            dataGridViewPersonas.TabIndex = 23;
            dataGridViewPersonas.CellContentClick += dataGridViewPersonas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 25;
            label1.Text = "ID Persona";
            // 
            // textBoxIdPersona
            // 
            textBoxIdPersona.Location = new Point(81, 27);
            textBoxIdPersona.Name = "textBoxIdPersona";
            textBoxIdPersona.Size = new Size(53, 23);
            textBoxIdPersona.TabIndex = 26;
            // 
            // Id_Persona
            // 
            Id_Persona.Frozen = true;
            Id_Persona.HeaderText = "Id_Persona";
            Id_Persona.Name = "Id_Persona";
            Id_Persona.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.Frozen = true;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            Edad.Frozen = true;
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Frozen = true;
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // ObtenerDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 435);
            Controls.Add(textBoxIdPersona);
            Controls.Add(label1);
            Controls.Add(dataGridViewPersonas);
            Controls.Add(btnObtenerDatos);
            Name = "ObtenerDatos";
            Text = "ObtenerDatos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBoxIdPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxHijos;
        private Label labelHijos;
        private ComboBox comboBoxHijos;
        private Button btnObtenerDatos;
        private DataGridView dataGridViewPersonas;
        private Label label1;
        private NumericUpDown textBoxIdPersona;
        private DataGridViewTextBoxColumn Id_Persona;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn FechaNacimiento;
    }
}