using ProyectoWindowsForm1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWindowsForm1.Formularios
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        Persona persona = new Persona();

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                    throw new Exception("Completar el nombre.");
                if (txtApellido.Text == "")
                    throw new Exception("Completar el apellido.");
                if (intEdad.Value == 0)
                    throw new Exception("Completar la edad.");

                Persona persona1 = new Persona()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = intEdad.Value,
                    FechaNacimiento = dateTimeFechaNacimiento.Value
                };

                bool exito = persona.AltaPersona(persona1);

                if (exito)
                    MessageBox.Show("Alta de usuario exitosa.");
                else
                    MessageBox.Show("No se dio de alta el usuario.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
