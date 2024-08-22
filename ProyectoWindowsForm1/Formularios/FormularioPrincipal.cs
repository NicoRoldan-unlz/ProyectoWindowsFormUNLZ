using Microsoft.IdentityModel.Tokens;
using ProyectoWindowsForm1.Modelos;
using System.Text;

namespace ProyectoWindowsForm1.Formularios
{
    public partial class FormularioPrincipal : Form
    {
        Persona persona = new Persona();

        public FormularioPrincipal()
        {
            InitializeComponent();

            List<string> hijos = new List<string>()
                { "Manuel", "Agustin", "Alberto" };

            foreach (var hijo in hijos)
            {
                comboBoxHijos.Items.Add(hijo);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valorString = "valor";
            
            try
            {
                //if (txtNombre.Text == "" || txtApellido.Text == "" || intEdad.Value == 0)
                //    throw new Exception("Completar todos los campos.");

                if(txtNombre.Text == "")
                    throw new Exception("Completar el nombre.");
                if(txtApellido.Text == "")
                    throw new Exception("Completar el apellido.");
                if(intEdad.Value == 0)
                    throw new Exception("Completar la edad.");

                //if (txtNombre.Text == "" || txtApellido.Text == "" || intEdad.Value == 0)
                //{
                //    MessageBox.Show("Completar todos los campos.");
                //    return;
                //}

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.Edad = intEdad.Value;
                persona.FechaNacimiento = dateTimeFechaNacimiento.Value;

                if (checkBoxHijos.Checked)
                {
                    if (comboBoxHijos.Text == "")
                        throw new Exception("Elegir un hijo");

                    persona.NombreHijo = comboBoxHijos.Text;

                    MessageBox.Show($"Datos guardados: \n{persona.Nombre}" +
                    $"\n{persona.Apellido}" +
                    $"\n{persona.Edad}" +
                    $"\n{persona.FechaNacimiento}" +
                    $"\nHijo: {persona.NombreHijo}");
                }
                else
                {
                    MessageBox.Show($"Datos guardados: \n{persona.Nombre}" +
                    $"\n{persona.Apellido}" +
                    $"\n{persona.Edad}" +
                    $"\n{persona.FechaNacimiento}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHijos.Checked)
            {
                labelHijos.Enabled = true;
                labelHijos.Visible = true;
                comboBoxHijos.Enabled = true;
                comboBoxHijos.Visible = true;
            }
            else
            {
                labelHijos.Enabled = false;
                labelHijos.Visible = false;
                comboBoxHijos.Enabled = false;
                comboBoxHijos.Visible = false;
            }
        }
    }
}
