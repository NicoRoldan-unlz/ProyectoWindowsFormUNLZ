namespace ProyectoWindowsForm1.Formularios
{
    partial class FormularioInicio
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
            btnFormObtenerDatos = new Button();
            btnFormAltaPersona = new Button();
            SuspendLayout();
            // 
            // btnFormObtenerDatos
            // 
            btnFormObtenerDatos.Location = new Point(62, 54);
            btnFormObtenerDatos.Name = "btnFormObtenerDatos";
            btnFormObtenerDatos.Size = new Size(123, 23);
            btnFormObtenerDatos.TabIndex = 0;
            btnFormObtenerDatos.Text = "Obtener Datos";
            btnFormObtenerDatos.UseVisualStyleBackColor = true;
            btnFormObtenerDatos.Click += btnFormObtenerDatos_Click;
            // 
            // btnFormAltaPersona
            // 
            btnFormAltaPersona.Location = new Point(62, 98);
            btnFormAltaPersona.Name = "btnFormAltaPersona";
            btnFormAltaPersona.Size = new Size(123, 23);
            btnFormAltaPersona.TabIndex = 1;
            btnFormAltaPersona.Text = "Alta de Persona";
            btnFormAltaPersona.UseVisualStyleBackColor = true;
            btnFormAltaPersona.Click += btnFormAltaPersona_Click;
            // 
            // FormularioInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 147);
            Controls.Add(btnFormAltaPersona);
            Controls.Add(btnFormObtenerDatos);
            Name = "FormularioInicio";
            Text = "FormularioInicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormObtenerDatos;
        private Button btnFormAltaPersona;
    }
}